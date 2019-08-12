Public Class Form1
    Dim FirstName, LastName As String                               'Strings for the name of the user
    Dim Destination As String                                       'name of the destination of the flight
    Dim RefNumber As String                                         'Reference number of the flight
    Dim SeatsBooked(150) As SeatClass                             'table of seats to store the booked seats
    Dim SeatsBookedNum As Byte = 0                               'Number of seats booked
    Dim EconomySeatNum As Byte = 100                               'number of economy class seats available
    Dim FirstSeatNum As Byte = 30                                   'number of first class seats available
    Dim ClubSeatNum As Byte = 20                                   'number of club class seats available  




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateButtonText()              ' when the form loads, update the butons texts so the number of reamianing seats for each clas appear 
    End Sub

    Private Sub tbx_FirstName_TextChanged(sender As Object, e As EventArgs) Handles tbx_FirstName.TextChanged, tbx_LastName.TextChanged, tbx_FlightDestination.TextChanged, tbx_RefNumber.TextChanged

        CheckUserInfo()                                 'when one of the textboxes' text is changed then check to see if the none of them are empty and if they aren't then enable the seat buttons so the user can choose a seat class

    End Sub

    Private Sub btn_EconomyClassSeat_Click(sender As Object, e As EventArgs) Handles btn_EconomyClassSeat.Click
        ' when the economy class button is pressed, open form 2 and intiate the form so it disable the elements that the user shouldn't access
        Form2.Show()
        Form2.InitiateEconomy()
        Form2.Focus()



    End Sub

    Private Sub btn_FirstClassSeat_Click(sender As Object, e As EventArgs) Handles btn_FirstClassSeat.Click
        'when the First class button is pressed, open form 2 and intiate the form so it disable the elements that the user shouldn't access and enable what they should acccess
        Form2.Show()
        Form2.InitiateFirst()
        Form2.Focus()

    End Sub


    Private Sub btn_ClubClassSeat_Click(sender As Object, e As EventArgs) Handles btn_ClubClassSeat.Click
        'when the First class button is pressed, open form 2 and intiate the form so it disable the elements that the user shouldn't access and enable what they should acccess
        Form2.Show()
        Form2.InitiateClub()
        Form2.Focus()

    End Sub

    Private Sub btn_CancelSeat_Click(sender As Object, e As EventArgs) Handles btn_CancelSeat.Click
        DeletingSeat()              'When the button is pressed run the DeletingSeat Sub to delete a seat

    End Sub



    Private Sub btn_BookFlight_Click(sender As Object, e As EventArgs) Handles btn_BookFlight.Click

        'When the bookflight button is pressed then clear all the textboxes and the listbox as  and reseat
        tbx_FirstName.Clear()
        tbx_FlightDestination.Clear()       'clear all the text from the textboxes
        tbx_LastName.Clear()
        tbx_RefNumber.Clear()

        lbx_Seats.Items.Clear()             'clear the listbox (By deleting the text the buttons for the seats will get disabled as well because they get disabled if one of the textboxes is empty)

        SeatsBookedNum = 0                  'Rest the variable

        btn_BookFlight.Enabled = False
        btn_CancelSeat.Enabled = False      'disable the buttons

    End Sub








    Private Sub UpdateVariables()           'Subroutine that extracts data from the textboxes
        FirstName = tbx_FirstName.Text
        LastName = tbx_LastName.Text
        Destination = tbx_FlightDestination.Text
        RefNumber = tbx_RefNumber.Text

    End Sub

    Private Sub CheckUserInfo()         ' subroutine that checks if the textboxes are empty or not. if they aren't then they get enabled otherwise they are disbled
        UpdateVariables()
        If FirstName <> "" And LastName <> "" And Destination <> "" And RefNumber <> "" Then

            btn_EconomyClassSeat.Enabled = True
            btn_FirstClassSeat.Enabled = True
            btn_ClubClassSeat.Enabled = True

        Else

            btn_EconomyClassSeat.Enabled = False
            btn_FirstClassSeat.Enabled = False
            btn_ClubClassSeat.Enabled = False

        End If

        CheckSeatAvalibility()          'check to see if there are still seats available for each class if not then disable the button for that class

    End Sub


    Private Sub CheckSeatAvalibility()          'Subroutine that checks if there are seats available for each class if not then they get disabled

        If EconomySeatNum < 1 Then
            btn_EconomyClassSeat.Enabled = False
        End If


        If FirstSeatNum < 1 Then
            btn_FirstClassSeat.Enabled = False
        End If

        If ClubSeatNum < 1 Then
            btn_ClubClassSeat.Enabled = False
        End If

    End Sub
    Private Sub UpdateButtonText()          'update the text of the buttons so they show the number of seats remaining for that class

        btn_EconomyClassSeat.Text = "Add Economy class seat (" & EconomySeatNum & ")"
        btn_FirstClassSeat.Text = "Add First class seat (" & FirstSeatNum & ")"
        btn_ClubClassSeat.Text = "Add Club class seat (" & ClubSeatNum & ")"

    End Sub

    Public Sub AddingSeat(ByVal Seat As SeatClass)              ' a public subroutine that takes a seat as it's parameter 



        Seat.Passenger = FirstName(0) & ". " & LastName
        Seat.SeatReferenceNumber = RefNumber
        SeatsBooked(SeatsBookedNum) = Seat                          'The subroutine adds the seat to the listbox and to the talbe of seats
        SeatsBookedNum += 1
        lbx_Seats.Items.Add(Seat.SeatDescription)

        Select Case Seat.SeatClass

            Case "Economy Class Seat"
                EconomySeatNum -= 1
            Case "First Class Seat"                 'reduces the number of seats available
                FirstSeatNum -= 1
            Case "Club Class Seat"
                ClubSeatNum -= 1
        End Select
        CheckSeatAvalibility()

        btn_BookFlight.Enabled = True               'Enable the booke flight button and the cnacel seat button
        btn_CancelSeat.Enabled = True
        UpdateButtonText()

    End Sub



    Private Sub DeletingSeat()                          ' a subroutine that removes a seat from the listbox and from the seastsBooked table


        If lbx_Seats.SelectedIndex > -1 Then            'Checks to see if an item has been selected (-1 means that nothing has been selected)

            For i As Integer = lbx_Seats.SelectedIndex To 149
                SeatsBooked(i) = SeatsBooked(i + 1)
            Next


            lbx_Seats.Items.RemoveAt(lbx_Seats.SelectedIndex)

            SeatsBookedNum += -1
            If SeatsBookedNum < 1 Then

                btn_CancelSeat.Enabled = False
                btn_BookFlight.Enabled = False
            End If

        Else
            MsgBox("No item has been selected ")            'messagebox telling the user that there is not item selected
        End If

    End Sub



End Class
