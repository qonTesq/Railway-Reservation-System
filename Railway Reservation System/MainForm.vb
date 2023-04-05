Imports System.Data.OleDb

Public Class MainForm
    Private Const MaxPassengersPerTrain As Integer = 5

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
        ' Validate the fields before searching for trains for the selected journey 
        If ValidateFields() Then
            Return
        End If

        ' Hide the description picture and show the train panels
        DescriptionPicture.hide()
        TrainPanel1.Show()
        TrainPanel2.Show()

        ' Create a dictionary to store the city codes
        Dim cityCodes As New Dictionary(Of String, String)
        cityCodes.add("Jaipur", "ST001")
        cityCodes.add("Rajkot", "ST002")
        cityCodes.add("Ahmedabad", "ST003")
        cityCodes.add("Vadodara", "ST004")
        cityCodes.add("Mumbai", "ST005")

        ' Get the values from the form controls and store them in variables for easy access
        Dim origin As String = FromComboBox.SelectedItem
        Dim destination As String = ToComboBox.SelectedItem
        Dim dateOfTravel As Date = DatePicker.Value.Date
        'Dim classOfTravel As String = ClassComboBox.SelectedItem
        'Dim numberOfPassengers As Integer = PassengerCount.Value

        ' Get the station codes for the origin and destination
        Dim departureStation As String = cityCodes(origin)
        Dim arrivalStation As String = cityCodes(destination)

        ' Retrieve the train IDs that cover this journey
        Dim trainIds = GetTrainIds(departureStation, arrivalStation)

        ' Check if any train was found for the selected journey
        If trainIds.Count > 0 Then
            For Each trainId As String In trainIds
                ' Calculate the number of available seats
                Dim seatsAvailable As Integer = GetAvailableSeats(trainId, arrivalStation, dateOfTravel)

                ' Display the result to the user
                MessageBox.Show($"{seatsAvailable} seats available on Train {trainId} from {departureStation} to {arrivalStation}.")
            Next
        Else
            ' Show a message if no train was found for the selected journey
            MessageBox.Show("No train found for the selected journey.")
        End If
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

    Private Function GetTrainIds(departureStation As String, arrivalStation As String) As List(Of String)
        Dim trainIds As New List(Of String)
        Dim command As OleDbCommand = Nothing
        Dim reader As OleDbDataReader = Nothing
        Try
            command = New OleDbCommand("SELECT TrainId FROM TrainStops WHERE (StationId = @departureStation OR StationId = @arrivalStation) GROUP BY TrainId HAVING COUNT(*)>1;", Conn)
            command.Parameters.AddWithValue("@departureStation", departureStation)
            command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
            reader = command.ExecuteReader()
            While reader.Read()
                trainIds.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader?.Close()
            command?.Dispose()
        End Try
        Return trainIds
    End Function

    Private Function GetAvailableSeats(trainId As String, arrivalStation As String, dateOfTravel As Date) As Integer
        ' Retrieve the number of seats that are already booked for this train
        Dim seatsBooked = 0
        Dim command As OleDbCommand = Nothing
        Try
            command = New OleDbCommand("SELECT SUM(NumberOfSeats) AS SeatsBooked FROM Bookings WHERE TrainId = @trainID AND StationSequence < (SELECT StationSequence FROM TrainStops WHERE TrainId = @trainID AND StationId = @arrivalStation AND DateOfTravel = @dateOfTravel);", Conn)
            command.Parameters.AddWithValue("@trainID", trainId)
            command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
            command.Parameters.AddWithValue("@dateOfTravel", dateOfTravel)
            Dim result As Object = command.ExecuteScalar()
            If Not IsDBNull(result) Then
                seatsBooked = CInt(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            command?.Dispose()
        End Try
        Return MaxPassengersPerTrain - seatsBooked
    End Function

    ' Close connection to the database if the form is closed
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        WelcomeForm.Show()
    End Sub
End Class