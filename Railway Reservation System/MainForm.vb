Imports System.Data.OleDb

Public Class MainForm
    Private Const MaxPassengersPerTrain As Integer = 5
    Private ReadOnly _cityIds As New Dictionary(Of String, String)
    Private ReadOnly _cityCodes As New Dictionary(Of String, String)

    ' Create a connection to the database
    Private WithEvents Conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\..\..\..\data\RailwayReservation.accdb")

    ' Show the status of the database connection in the status bar
    Private Sub Conn_StateChange(sender As Object, e As StateChangeEventArgs) Handles Conn.StateChange
        If e.CurrentState = ConnectionState.Open Then
            DbConnectionStatusLabel.Text = "Connected"
            DbConnectionStatusLabel.ForeColor = Color.Lime
        Else
            DbConnectionStatusLabel.Text = "Not Connected"
            DbConnectionStatusLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the minimum and maximum dates for the date picker
        DatePicker.MinDate = Date.Now
        DatePicker.MaxDate = Date.Now.AddYears(1)

        ' Hide the train panels and show the description picture
        TrainPanel1.Hide()
        TrainPanel2.Hide()
        DescriptionPicture.Show()

        ' Open the connection to the database
        If Conn.State = ConnectionState.Closed Then
            Try
                Conn.Open()
            Catch ex As Exception
                ' Show an error message if the connection could not be established
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        _cityIds.add("Jaipur", 55555)
        _cityIds.add("Rajkot", 44444)
        _cityIds.add("Ahmedabad", 33333)
        _cityIds.add("Vadodara", 22222)
        _cityIds.add("Mumbai", 11111)

        _cityCodes.add("Jaipur", "JPR")
        _cityCodes.add("Rajkot", "RJT")
        _cityCodes.add("Ahmedabad", "ADI")
        _cityCodes.add("Vadodara", "BRC")
        _cityCodes.add("Mumbai", "BCT")

        ' Load the data from the database into the DataGridViews
        LoadDataGridViews()
    End Sub

    Private Sub LoadDataGridViews()
        ReservationsDataGridView.Rows.Clear()
        StationsDataGridView.Rows.Clear()
        StopsDataGridView.Rows.Clear()
        TrainsDataGridView.Rows.Clear()

        Dim dt as New DataTable
        Dim da As New OleDbDataAdapter("SELECT * FROM Bookings", Conn)
        da.Fill(dt)
        ReservationsDataGridView.DataSource = dt.DefaultView

        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM Stations", Conn)
        da.Fill(dt)
        StationsDataGridView.DataSource = dt.DefaultView

        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM TrainStops", Conn)
        da.Fill(dt)
        StopsDataGridView.DataSource = dt.DefaultView
        
        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM Trains", Conn)
        da.Fill(dt)
        TrainsDataGridView.DataSource = dt.DefaultView
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Validate the fields and return if any of them are invalid
        If ValidateFields() Then
            Return
        End If

        DescriptionPicture.Hide()
        TrainPanel1.Hide()
        TrainPanel2.Hide()

        ' Get the values from the fields
        Dim origin As String = FromComboBox.SelectedItem
        Dim destination As String = ToComboBox.SelectedItem
        Dim dateOfTravel As Date = DatePicker.Value.Date

        ' Get the IDs of the stations
        Dim departureStation As String = _cityIds(origin)
        Dim arrivalStation As String = _cityIds(destination)

        ' Get the IDs of the trains that run between the stations
        Dim trainIds = GetTrainIds(departureStation, arrivalStation)

        If trainIds.Count > 0 Then
            ' Get the number of seats available in each train
            Dim trainSeats As New Dictionary(Of String, Integer)
            For Each trainId In trainIds
                Dim seatsAvailable As Integer = GetAvailableSeats(trainId, arrivalStation, dateOfTravel)
                If seatsAvailable > 0 Then
                    trainSeats.add(trainId, seatsAvailable)
                End If
            Next

            ' Show the trains that have seats available
            If trainSeats.Count > 1 Then
                TrainPanel1.Show()
                TrainPanel2.Show()
                If TrainPanel1.Visible Then
                    TrainIdLabel1.Text = $"#{trainSeats.Keys(0)}"
                    TrainNameLabel1.Text = GetTrainName(trainSeats.Keys(0))
                    TrainClassLabel1.Text = $"{If(ClassComboBox.SelectedIndex = 0, "", ClassComboBox.SelectedItem)}"
                    SourceLabel1.Text = $"<strong>{origin}</strong> <FONT COLOR=#d9d9d9>({_cityCodes(origin)})</FONT>"
                    DestinationLabel1.Text = $"<strong>{destination}</strong> <FONT COLOR=#d9d9d9>({_cityCodes(destination)})</FONT>"
                    DepartTimeLabel1.Text = GetDepartureTime(trainSeats.Keys(0), departureStation).ToString("hh:mm tt")
                    ArriveTimeLabel1.Text = GetArrivalTime(trainSeats.Keys(0), arrivalStation).ToString("hh:mm tt")
                End If
                If TrainPanel2.Visible Then
                    TrainIdLabel2.Text = $"#{trainSeats.Keys(1)}"
                    TrainNameLabel2.Text = GetTrainName(trainSeats.Keys(1))
                    TrainClassLabel2.Text = $"{If(ClassComboBox.SelectedIndex = 0, "", ClassComboBox.SelectedItem)}"
                    SourceLabel2.Text = $"<strong>{origin}</strong> <FONT COLOR=#d9d9d9>({_cityCodes(origin)})</FONT>"
                    DestinationLabel2.Text = $"<strong>{destination}</strong> <FONT COLOR=#d9d9d9>({_cityCodes(destination)})</FONT>"
                    DepartTimeLabel2.Text = GetDepartureTime(trainSeats.Keys(1), departureStation).ToString("hh:mm tt")
                    ArriveTimeLabel2.Text = GetArrivalTime(trainSeats.Keys(1), arrivalStation).ToString("hh:mm tt")
                End If
            Else If trainSeats.Count = 1 Then
                TrainPanel1.Show()
                If TrainPanel1.Visible Then
                    TrainIdLabel1.Text = $"#{trainSeats.Keys(0)}"
                    TrainNameLabel1.Text = GetTrainName(trainSeats.Keys(0))
                    TrainClassLabel1.Text = $"{If(ClassComboBox.SelectedIndex = 0, "", ClassComboBox.SelectedItem)}"
                    SourceLabel1.Text = $"<strong>{origin}</strong> <FONT COLOR=#d9d9d9>({_cityCodes(origin)})</FONT>"
                    DestinationLabel1.Text = $"<strong>{destination}</strong> <FONT COLOR=#d9d9d9>({_cityCodes(destination)})</FONT>"
                    DepartTimeLabel1.Text = GetDepartureTime(trainSeats.Keys(0), departureStation).ToString("hh:mm tt")
                    ArriveTimeLabel1.Text = GetArrivalTime(trainSeats.Keys(0), arrivalStation).ToString("hh:mm tt")
                End If
            Else
                MessageBox.Show("No train found for the selected journey.")
            End If
        Else
            MessageBox.Show("No train found for the selected journey.")
        End If
    End Sub

    Private Sub BookButton1_Click(sender As Object, e As EventArgs) Handles BookButton1.Click
        ' Get the values from the fields
        Dim trainId As String = TrainIdLabel1.Text.Substring(1)
        Dim origin As String = FromComboBox.SelectedItem
        Dim destination As String = ToComboBox.SelectedItem
        Dim dateOfTravel As Date = DatePicker.Value.Date
        ' Get the IDs of the stations
        Dim departureStation As String = _cityIds(origin)
        Dim arrivalStation As String = _cityIds(destination)
        ' Get the number of seats available in the train
        Dim seatsAvailable As Integer = GetAvailableSeats(trainId, arrivalStation, dateOfTravel)
        ' Get the sequence of the booking station
        Dim bookStationSequence As Integer = GetStationSequence(trainId, departureStation)

        ' Validate the number of passengers
        If PassengerCount.Value > seatsAvailable Then
            MessageBox.Show($"Only {seatsAvailable} seats available for this train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Book the ticket
        Dim bookSuccess As Boolean = BookTicket(trainId, dateOfTravel, PassengerCount.Value, departureStation, arrivalStation, bookStationSequence)

        ' Show the result
        If Not bookSuccess Then
            MessageBox.Show("Booking failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        MessageBox.Show("Booking successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub

    Private Sub BookButton2_Click(sender As Object, e As EventArgs) Handles BookButton2.Click
        ' Get the values from the fields
        Dim trainId As String = TrainIdLabel2.Text.Substring(1)
        Dim origin As String = FromComboBox.SelectedItem
        Dim destination As String = ToComboBox.SelectedItem
        Dim dateOfTravel As Date = DatePicker.Value.Date
        ' Get the IDs of the stations
        Dim departureStation As String = _cityIds(origin)
        Dim arrivalStation As String = _cityIds(destination)
        ' Get the number of seats available in the train
        Dim seatsAvailable As Integer = GetAvailableSeats(trainId, arrivalStation, dateOfTravel)
        ' Get the sequence of the booking station
        Dim bookStationSequence As Integer = GetStationSequence(trainId, departureStation)

        ' Validate the number of passengers
        If PassengerCount.Value > seatsAvailable Then
            MessageBox.Show($"Only {seatsAvailable} seats available for this train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        
        ' Book the ticket
        Dim bookSuccess As Boolean = BookTicket(trainId, dateOfTravel, PassengerCount.Value, departureStation, arrivalStation, bookStationSequence)

        ' Show the result
        If Not bookSuccess Then
            MessageBox.Show("Booking failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        MessageBox.Show("Booking successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrEmpty(FromComboBox.SelectedItem) Or String.IsNullOrEmpty(ToComboBox.SelectedItem) Or String.IsNullOrEmpty(ClassComboBox.SelectedItem) Then
            MessageBox.Show("Please fill up all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        ElseIf FromComboBox.SelectedItem = ToComboBox.SelectedItem Then
            MessageBox.Show("Origin and destination cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        Else
            Return False
        End If
    End Function

    Private Function BookTicket(trainId As String, dateOfTravel As Date, passenCount As Integer, departureStation As String, arrivalStation As String, bookStationSequence As Integer) As Boolean
        Dim command As OleDbCommand = Nothing
        Try
            command = New OleDbCommand("INSERT INTO Bookings (TrainId, DateOfTravel, NumberOfSeats, BookStationSequence, DepartureStation, ArrivalStation) VALUES (@trainId, @dateOfTravel, @passengerCount, @bookStationSequence, @departureStation, @arrivalStation);", Conn)
            command.Parameters.AddWithValue("@trainId", trainId)
            command.Parameters.AddWithValue("@dateOfTravel", dateOfTravel)
            command.Parameters.AddWithValue("@passengerCount", passenCount)
            command.Parameters.AddWithValue("@bookStationSequence", bookStationSequence)
            command.Parameters.AddWithValue("@departureStation", departureStation)
            command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            command?.Dispose()
        End Try
        Return True
    End Function
    
    Private Function GetStationSequence(trainId As String, stationId As String) As Integer
        Dim command As OleDbCommand = Nothing
        Dim reader As OleDbDataReader = Nothing
        Try
            command = New OleDbCommand("SELECT StationSequence FROM TrainStops WHERE TrainId = @trainId AND StationId = @stationId;", Conn)
            command.Parameters.AddWithValue("@trainId", trainId)
            command.Parameters.AddWithValue("@stationId", stationId)
            reader = command.ExecuteReader()
            If reader.Read() Then
                Return reader.GetInt16(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader?.Close()
            command?.Dispose()
        End Try
        Return -1
    End Function

    Private Function GetTrainIds(departureStation As String, arrivalStation As String) As List(Of String)
        Dim trainIds As New List(Of String)
        Dim command As OleDbCommand = Nothing
        Dim reader As OleDbDataReader = Nothing
        Dim isReverse As Integer = If(departureStation > arrivalStation, -1, 0)
            Try
                command = New OleDbCommand("SELECT TrainId FROM TrainStops WHERE (StationId = @departureStation OR StationId = @arrivalStation) AND Reverse = @isReverse GROUP BY TrainId HAVING COUNT(*)>1;", Conn)
                command.Parameters.AddWithValue("@departureStation", departureStation)
                command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
                command.Parameters.AddWithValue("@isReverse", isReverse)
                reader = command.ExecuteReader()
                While reader.Read()
                    trainIds.Add(reader.GetString(0))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                reader?.Close()
                command?.Dispose()
            End Try
        Return trainIds
    End Function

    Private Function GetAvailableSeats(trainId As String, arrivalStation As String, dateOfTravel As Date) As Integer
        Dim seatsBooked = 0
        Dim command As OleDbCommand = Nothing
        Try
            command = New OleDbCommand("SELECT SUM(NumberOfSeats) AS SeatsBooked FROM Bookings WHERE TrainId = @trainID AND BookStationSequence < (SELECT StationSequence FROM TrainStops WHERE TrainId = @trainID AND StationId = @arrivalStation AND DateOfTravel = @dateOfTravel);", Conn)
            command.Parameters.AddWithValue("@trainID", trainId)
            command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
            command.Parameters.AddWithValue("@dateOfTravel", dateOfTravel)
            Dim result As Object = command.ExecuteScalar()
            If Not IsDBNull(result) Then
                seatsBooked = CInt(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            command?.Dispose()
        End Try
        Return MaxPassengersPerTrain - seatsBooked
    End Function

    Private Function GetTrainName(trainId As String) As String
        Dim trainName = ""
        Dim command As OleDbCommand = Nothing
        Try
            command = New OleDbCommand("SELECT TrainName FROM Trains WHERE TrainId = @trainID;", Conn)
            command.Parameters.AddWithValue("@trainID", trainId)
            Dim result As Object = command.ExecuteScalar()
            If Not IsDBNull(result) Then
                trainName = CStr(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            command?.Dispose()
        End Try
        Return trainName
    End Function

    Private Function GetDepartureTime(trainId As String, departureStation As String) As Date
        Dim departureTime As Date
        Dim command As OleDbCommand = Nothing
        Try
            command = New OleDbCommand("SELECT DepartureTime FROM TrainStops WHERE TrainId = @trainID AND StationId = @departureStation;", Conn)
            command.Parameters.AddWithValue("@trainID", trainId)
            command.Parameters.AddWithValue("@departureStation", departureStation)
            Dim result As Object = command.ExecuteScalar()
            If Not IsDBNull(result) Then
                departureTime = CDate(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            command?.Dispose()
        End Try
        Return departureTime
    End Function

    Private Function GetArrivalTime(trainId As String, arrivalStation As String) As Date
        Dim arrivalTime As Date
        Dim command As OleDbCommand = Nothing
        Try
            command = New OleDbCommand("SELECT ArrivalTime FROM TrainStops WHERE TrainId = @trainID AND StationId = @arrivalStation;", Conn)
            command.Parameters.AddWithValue("@trainID", trainId)
            command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
            Dim result As Object = command.ExecuteScalar()
            If Not IsDBNull(result) Then
                arrivalTime = CDate(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            command?.Dispose()
        End Try
        Return arrivalTime
    End Function

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Close connection to the database if the form is closed
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If

        ' Show the welcome form
        WelcomeForm.Show()
    End Sub
End Class