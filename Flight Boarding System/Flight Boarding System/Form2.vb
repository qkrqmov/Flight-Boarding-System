Public Class Form2

    Dim CurrentSeat As New SeatClass                            'Stores the seat that is being inputed in the form
    Dim seatName As String                                      'Stores the name of the seat that is inputted in the textbox
    Dim SeatType As String                                      'Stores the type fo seat
    Dim MealSelected As String                                  'Stores the name of the meal selected
    Dim BedBooked As Boolean                                    'Stores if the bed has been booked or not
    Dim NameSeatBooked(150) As String                           'stores the name of all the seats that have been booked
    Dim TotalSeatsBooked As Byte = 0                            'the total number of seats that have been booked








    Private Sub tbx_SeatName_TextChanged(sender As Object, e As EventArgs) Handles tbx_SeatName.TextChanged         ' when the user changes the text of the seat name textbox
        If tbx_SeatName.Text <> "" Then             'If the textbox is not empty then enable the add seat button otherwise disable it
            btn_AddSeat.Enabled = True
        Else
            btn_AddSeat.Enabled = False

        End If


        CheckSeatName()             ' checking to see if the seat has been booked before
    End Sub

    Private Sub btn_AddSeat_Click(sender As Object, e As EventArgs) Handles btn_AddSeat.Click
        'When the add seat button is pressed then record the seat name into the seats booked and run the function AddingSeat that adds a seat to form 1

        UpdateVariables()

        CurrentSeat.SeatClass = SeatType
        CurrentSeat.SeatName = seatName
        CurrentSeat.Meal = MealSelected
        CurrentSeat.BookingBed = BedBooked

        tbx_SeatName.Clear()

        Form1.AddingSeat(CurrentSeat)


        NameSeatBooked(TotalSeatsBooked) = seatName
        TotalSeatsBooked += 1

        Me.Hide()

    End Sub








    Public Sub InitiateEconomy()                                    'Public subroutine that can be accessed through form 1, it runs when the user select an Economy seat class
        rbt_NoMeal.Checked = True
        cbx_BookBed.CheckState = False
        'the sub setup the form so only the textbox and the button can be interacted with
        gbx_MealSelection.Enabled = False
        gbx_BedBooking.Enabled = False

        SeatType = "Economy Class Seat"

    End Sub

    Public Sub InitiateFirst()                                      'Public subroutine that can be accessed through form 1, it runs when the user select an First seat class
        rbt_NoMeal.Checked = True
        cbx_BookBed.CheckState = False
        'the sub setup the form so the textbox, the meal selection group and the button can be interacted with
        gbx_MealSelection.Enabled = True
        gbx_BedBooking.Enabled = False

        SeatType = "First Class Seat"

    End Sub

    Public Sub InitiateClub()                                      'Public subroutine that can be accessed through form 1, it runs when the user select an Club seat class
        rbt_NoMeal.Checked = True
        cbx_BookBed.CheckState = False
        'the sub setup the form so the user can interact with everything on the form

        gbx_MealSelection.Enabled = True
        gbx_BedBooking.Enabled = True

        SeatType = "Club Class Seat"

    End Sub




    Private Sub UpdateVariables()
        ' a subrooutine that updates the variable by copying the value of the textbox, radiobuttons and checkbox
        seatName = tbx_SeatName.Text

        Select Case True

            Case rbt_HotMeal.Checked
                MealSelected = "Hot Meal"

            Case rbt_ColdMeal.Checked
                MealSelected = "Cold Meal"

            Case rbt_VegetarianMeal.Checked

                MealSelected = "Vegetarian Meal"

            Case rbt_NoMeal.Checked

                MealSelected = "No Meal"

        End Select

        BedBooked = cbx_BookBed.CheckState


    End Sub


    Private Sub CheckSeatName()             'compare the text of the textbox to the names that are in the table that contains all the names of the booked seats
        If TotalSeatsBooked > 0 Then
            For i As Integer = 0 To TotalSeatsBooked
                If NameSeatBooked(i) = tbx_SeatName.Text And tbx_SeatName.Text <> "" Then
                    btn_AddSeat.Enabled = False                             'disable the add seat button and show a message box
                    MsgBox("This seat has already been booked")
                End If

            Next
        End If



    End Sub


End Class