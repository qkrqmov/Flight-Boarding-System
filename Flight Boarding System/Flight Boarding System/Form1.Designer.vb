<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbx_UserInfo = New System.Windows.Forms.GroupBox()
        Me.tbx_RefNumber = New System.Windows.Forms.TextBox()
        Me.tbx_FlightDestination = New System.Windows.Forms.TextBox()
        Me.tbx_LastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_FirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_EconomyClassSeat = New System.Windows.Forms.Button()
        Me.btn_FirstClassSeat = New System.Windows.Forms.Button()
        Me.btn_ClubClassSeat = New System.Windows.Forms.Button()
        Me.lbx_Seats = New System.Windows.Forms.ListBox()
        Me.btn_CancelSeat = New System.Windows.Forms.Button()
        Me.btn_BookFlight = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbx_UserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_UserInfo
        '
        Me.gbx_UserInfo.BackColor = System.Drawing.Color.Transparent
        Me.gbx_UserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbx_UserInfo.Controls.Add(Me.tbx_RefNumber)
        Me.gbx_UserInfo.Controls.Add(Me.tbx_FlightDestination)
        Me.gbx_UserInfo.Controls.Add(Me.tbx_LastName)
        Me.gbx_UserInfo.Controls.Add(Me.Label4)
        Me.gbx_UserInfo.Controls.Add(Me.tbx_FirstName)
        Me.gbx_UserInfo.Controls.Add(Me.Label3)
        Me.gbx_UserInfo.Controls.Add(Me.Label2)
        Me.gbx_UserInfo.Controls.Add(Me.Label1)
        Me.gbx_UserInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gbx_UserInfo.Location = New System.Drawing.Point(14, 7)
        Me.gbx_UserInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbx_UserInfo.Name = "gbx_UserInfo"
        Me.gbx_UserInfo.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbx_UserInfo.Size = New System.Drawing.Size(357, 225)
        Me.gbx_UserInfo.TabIndex = 0
        Me.gbx_UserInfo.TabStop = False
        Me.gbx_UserInfo.Text = "Information about the user"
        '
        'tbx_RefNumber
        '
        Me.tbx_RefNumber.Location = New System.Drawing.Point(172, 171)
        Me.tbx_RefNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbx_RefNumber.Name = "tbx_RefNumber"
        Me.tbx_RefNumber.Size = New System.Drawing.Size(116, 20)
        Me.tbx_RefNumber.TabIndex = 5
        '
        'tbx_FlightDestination
        '
        Me.tbx_FlightDestination.Location = New System.Drawing.Point(172, 124)
        Me.tbx_FlightDestination.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbx_FlightDestination.Name = "tbx_FlightDestination"
        Me.tbx_FlightDestination.Size = New System.Drawing.Size(116, 20)
        Me.tbx_FlightDestination.TabIndex = 4
        '
        'tbx_LastName
        '
        Me.tbx_LastName.Location = New System.Drawing.Point(172, 81)
        Me.tbx_LastName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbx_LastName.Name = "tbx_LastName"
        Me.tbx_LastName.Size = New System.Drawing.Size(116, 20)
        Me.tbx_LastName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reference Number:"
        '
        'tbx_FirstName
        '
        Me.tbx_FirstName.Location = New System.Drawing.Point(172, 35)
        Me.tbx_FirstName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbx_FirstName.Name = "tbx_FirstName"
        Me.tbx_FirstName.Size = New System.Drawing.Size(116, 20)
        Me.tbx_FirstName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Flight Destination:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'btn_EconomyClassSeat
        '
        Me.btn_EconomyClassSeat.Enabled = False
        Me.btn_EconomyClassSeat.Location = New System.Drawing.Point(14, 238)
        Me.btn_EconomyClassSeat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_EconomyClassSeat.Name = "btn_EconomyClassSeat"
        Me.btn_EconomyClassSeat.Size = New System.Drawing.Size(357, 62)
        Me.btn_EconomyClassSeat.TabIndex = 1
        Me.btn_EconomyClassSeat.Text = "Add Economy class seat"
        Me.ToolTip1.SetToolTip(Me.btn_EconomyClassSeat, "Opens a new window to add an Economy class seat")
        Me.btn_EconomyClassSeat.UseVisualStyleBackColor = True
        '
        'btn_FirstClassSeat
        '
        Me.btn_FirstClassSeat.Enabled = False
        Me.btn_FirstClassSeat.Location = New System.Drawing.Point(14, 306)
        Me.btn_FirstClassSeat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_FirstClassSeat.Name = "btn_FirstClassSeat"
        Me.btn_FirstClassSeat.Size = New System.Drawing.Size(357, 62)
        Me.btn_FirstClassSeat.TabIndex = 2
        Me.btn_FirstClassSeat.Text = "Add First class seat"
        Me.btn_FirstClassSeat.UseVisualStyleBackColor = True
        '
        'btn_ClubClassSeat
        '
        Me.btn_ClubClassSeat.Enabled = False
        Me.btn_ClubClassSeat.Location = New System.Drawing.Point(14, 374)
        Me.btn_ClubClassSeat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_ClubClassSeat.Name = "btn_ClubClassSeat"
        Me.btn_ClubClassSeat.Size = New System.Drawing.Size(357, 62)
        Me.btn_ClubClassSeat.TabIndex = 3
        Me.btn_ClubClassSeat.Text = "Add Club Class seat"
        Me.btn_ClubClassSeat.UseVisualStyleBackColor = True
        '
        'lbx_Seats
        '
        Me.lbx_Seats.Font = New System.Drawing.Font("Courier New", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_Seats.FormattingEnabled = True
        Me.lbx_Seats.ItemHeight = 12
        Me.lbx_Seats.Location = New System.Drawing.Point(378, 13)
        Me.lbx_Seats.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lbx_Seats.Name = "lbx_Seats"
        Me.lbx_Seats.Size = New System.Drawing.Size(485, 280)
        Me.lbx_Seats.TabIndex = 4
        '
        'btn_CancelSeat
        '
        Me.btn_CancelSeat.AccessibleDescription = ""
        Me.btn_CancelSeat.Enabled = False
        Me.btn_CancelSeat.Location = New System.Drawing.Point(378, 306)
        Me.btn_CancelSeat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_CancelSeat.Name = "btn_CancelSeat"
        Me.btn_CancelSeat.Size = New System.Drawing.Size(485, 62)
        Me.btn_CancelSeat.TabIndex = 5
        Me.btn_CancelSeat.Text = "Cancel a seat"
        Me.btn_CancelSeat.UseVisualStyleBackColor = True
        '
        'btn_BookFlight
        '
        Me.btn_BookFlight.Enabled = False
        Me.btn_BookFlight.Location = New System.Drawing.Point(378, 374)
        Me.btn_BookFlight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_BookFlight.Name = "btn_BookFlight"
        Me.btn_BookFlight.Size = New System.Drawing.Size(485, 62)
        Me.btn_BookFlight.TabIndex = 6
        Me.btn_BookFlight.Text = "Book flight"
        Me.ToolTip1.SetToolTip(Me.btn_BookFlight, "A button that will book the seats for the flight")
        Me.btn_BookFlight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(876, 446)
        Me.Controls.Add(Me.btn_BookFlight)
        Me.Controls.Add(Me.lbx_Seats)
        Me.Controls.Add(Me.btn_CancelSeat)
        Me.Controls.Add(Me.btn_ClubClassSeat)
        Me.Controls.Add(Me.btn_FirstClassSeat)
        Me.Controls.Add(Me.btn_EconomyClassSeat)
        Me.Controls.Add(Me.gbx_UserInfo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Flight Boarding System"
        Me.gbx_UserInfo.ResumeLayout(False)
        Me.gbx_UserInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_UserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_RefNumber As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FlightDestination As System.Windows.Forms.TextBox
    Friend WithEvents tbx_LastName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbx_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_EconomyClassSeat As System.Windows.Forms.Button
    Friend WithEvents btn_FirstClassSeat As System.Windows.Forms.Button
    Friend WithEvents btn_ClubClassSeat As System.Windows.Forms.Button
    Friend WithEvents lbx_Seats As System.Windows.Forms.ListBox
    Friend WithEvents btn_CancelSeat As System.Windows.Forms.Button
    Friend WithEvents btn_BookFlight As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
