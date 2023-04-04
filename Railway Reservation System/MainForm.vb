Imports System.Data.OleDb

Public Class MainForm
    Private Const MaxPassengersPerTrain As Integer = 5

    Private WithEvents _conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\RailwayReservation.accdb")

    Private Sub conn_StateChange(sender As Object, e As StateChangeEventArgs) Handles _conn.StateChange
        If e.CurrentState = ConnectionState.Open Then
            DbConnectionStatusLabel.Text = "Connected"
            DbConnectionStatusLabel.ForeColor = Color.Lime
        Else
            DbConnectionStatusLabel.Text = "Not Connected"
            DbConnectionStatusLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatePicker.MinDate = Date.Now
        DatePicker.MaxDate = Date.Now.AddYears(1)

        TrainPanel1.Hide()
        TrainPanel2.Hide()
        DescriptionPicture.Show()

        If _conn.State = ConnectionState.Closed Then
            Try
                _conn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        LoadDataGridViews()
    End Sub

    Private sub LoadDataGridViews()
        ReservationsDataGridView.Rows.Clear()
        StationsDataGridView.Rows.Clear()
        StopsDataGridView.Rows.Clear()
        TrainsDataGridView.Rows.Clear()
        
        Dim dt as New DataTable
        Dim da As New OleDbDataAdapter("SELECT * FROM Bookings", _conn)
        da.Fill(dt)
        ReservationsDataGridView.DataSource = dt.DefaultView

        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM Stations", _conn)
        da.Fill(dt)
        StationsDataGridView.DataSource = dt.DefaultView

        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM TrainStops", _conn)
        da.Fill(dt)
        StopsDataGridView.DataSource = dt.DefaultView
        
        dt = New DataTable
        da = New OleDbDataAdapter("SELECT * FROM Trains", _conn)
        da.Fill(dt)
        TrainsDataGridView.DataSource = dt.DefaultView
    End sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If ValidateFields() Then
            Return
        End If

        DescriptionPicture.hide()
        TrainPanel1.Show()
        TrainPanel2.Show()

        Dim origin As String = FromComboBox.SelectedItem
        Dim destination As String = ToComboBox.SelectedItem
        Dim dateOfTravel As Date = DatePicker.Value
        Dim classOfTravel As String = ClassComboBox.SelectedItem
        Dim numberOfPassengers As Integer = PassengerCount.Value

        ' Assume the user has selected the journey from
        Dim departureStation = "ST001"
        Dim arrivalStation = "ST003"

        ' Retrieve the train IDs that cover this journey
        Dim trainIds As New List(Of String)
        Dim command = New OleDbCommand("SELECT TrainId FROM TrainStops WHERE (StationId = @departureStation OR StationId = @arrivalStation) GROUP BY TrainId HAVING COUNT(*)>1;", _conn)
        command.Parameters.AddWithValue("@departureStation", departureStation)
        command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        While reader.Read()
            trainIds.Add(reader.GetString(0))
        End While
        reader.Close()

        If trainIds.Count > 0 Then
            For Each trainId As String In trainIds
                ' Retrieve the number of seats that are already booked for this train
                Dim seatsBooked As Integer = 0
                command = New OleDbCommand("SELECT SUM(NumberOfSeats) AS SeatsBooked FROM Bookings WHERE TrainId = @trainID AND StationSequence < (SELECT StationSequence FROM TrainStops WHERE TrainId = @trainID AND StationId = @arrivalStation);", _conn)
                command.Parameters.AddWithValue("@trainID", trainId)
                'command.Parameters.AddWithValue("@departureStation", departureStation)
                command.Parameters.AddWithValue("@arrivalStation", arrivalStation)
                Dim result As Object = command.ExecuteScalar()
                If Not IsDBNull(result) Then
                    seatsBooked = CInt(result)
                End If

                ' Calculate the number of available seats
                Dim seatsAvailable As Integer = MaxPassengersPerTrain - seatsBooked

                ' Display the result to the user
                MessageBox.Show(String.Format("{0} seats available on Train {1} from {2} to {3}.", seatsAvailable, trainId, departureStation, arrivalStation))
            Next
        Else
            MessageBox.Show("No train found for the selected journey.")
        End If
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If _conn.State = ConnectionState.Open Then
            _conn.Close()
        End If
        WelcomeForm.Show()
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
    
End Class