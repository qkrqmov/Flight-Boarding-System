Public Class SeatClass
    Private Name As String                  'Name of the seat
    Private PassengerName As String         'Name of the passanger
    Private ReferenceNumber As String       'Refrence number of the flight
    Private ClassType As String             'The class type of the seat
    Private MealType As String              'The meal chosen by the user for this seat
    Private BedBooked As Boolean = False    'If the user booked a seat or not



    Public WriteOnly Property SeatName As String              'WriteOnly property to set the value of the seat name

        Set(value As String)
            Name = value
        End Set
    End Property

    Public WriteOnly Property Passenger As String   'Passanger name

        Set(value As String)
            PassengerName = value
        End Set
    End Property

    Public WriteOnly Property SeatReferenceNumber As String 'reference number of the seat

        Set(value As String)
            ReferenceNumber = value
        End Set
    End Property


    Public Property SeatClass As String       'the type of seat
        Get
            Return ClassType
        End Get
        Set(value As String)
            ClassType = value
        End Set
    End Property

    Public WriteOnly Property Meal As String              'Meal selected

        Set(value As String)

            MealType = value
        End Set
    End Property

    Public WriteOnly Property BookingBed As Boolean         'If the bed was booked or not

        Set(value As Boolean)

            BedBooked = value
        End Set
    End Property

    Public Function SeatDescription() As String         'Function that returns a string containing a discription of the seat
        Dim Description As String = ""          'Initialising the description variable

        Dim bedDescription As String            'Initialising the description for the bed as the bedbooked variable holds a boolean not a string

        If BedBooked = True Then
            bedDescription = "Bed Booked"          'Setting the description for the bed portion of the seat
        Else
            bedDescription = "No Bed"
        End If

        Description = NormaliseString(ClassType, 18) & NormaliseString(Name, 5) & NormaliseString(PassengerName, 12) & NormaliseString(ReferenceNumber, 10) & NormaliseString(MealType, 15) & NormaliseString(bedDescription, 10)
        'collating all the strings and setting the description variable
        'All the string variables are passed through the NormaliseString function so they will have the exact length that is also specified to the function



        Return Description


    End Function


    Private Function NormaliseString(ByVal text As String, ByVal Length As Byte)     'Function that makes it so all the string inputted has the exact length specified.
        'This Is used so the descriptions looks nicer  and allignin the listbox

        If text.Length > Length Then                    'If the string is bigger than the length specified

            text = text.Substring(0, Length - 2) + ".."     'Cut the variable and add ".." to show that the string has been cut

        Else                                            'if the string is not bigger than the length 
            text += StrDup(Length - text.Length, " ")   'Add a bunch of spaces to make it exactly as big as the length specified 
        End If

        text += StrDup(5, " ")                  ' adding 5 extra spaces so stiring that comes after it will have space

        Return text

    End Function



End Class

