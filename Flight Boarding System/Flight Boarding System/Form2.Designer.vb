<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_MealSelection = New System.Windows.Forms.GroupBox()
        Me.rbt_NoMeal = New System.Windows.Forms.RadioButton()
        Me.rbt_VegetarianMeal = New System.Windows.Forms.RadioButton()
        Me.rbt_ColdMeal = New System.Windows.Forms.RadioButton()
        Me.rbt_HotMeal = New System.Windows.Forms.RadioButton()
        Me.tbx_SeatName = New System.Windows.Forms.TextBox()
        Me.gbx_BedBooking = New System.Windows.Forms.GroupBox()
        Me.cbx_BookBed = New System.Windows.Forms.CheckBox()
        Me.btn_AddSeat = New System.Windows.Forms.Button()
        Me.gbx_MealSelection.SuspendLayout()
        Me.gbx_BedBooking.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seat Name:"
        '
        'gbx_MealSelection
        '
        Me.gbx_MealSelection.Controls.Add(Me.rbt_NoMeal)
        Me.gbx_MealSelection.Controls.Add(Me.rbt_VegetarianMeal)
        Me.gbx_MealSelection.Controls.Add(Me.rbt_ColdMeal)
        Me.gbx_MealSelection.Controls.Add(Me.rbt_HotMeal)
        Me.gbx_MealSelection.Location = New System.Drawing.Point(15, 63)
        Me.gbx_MealSelection.Name = "gbx_MealSelection"
        Me.gbx_MealSelection.Size = New System.Drawing.Size(308, 124)
        Me.gbx_MealSelection.TabIndex = 0
        Me.gbx_MealSelection.TabStop = False
        Me.gbx_MealSelection.Text = "Meal Selection"
        '
        'rbt_NoMeal
        '
        Me.rbt_NoMeal.AutoSize = True
        Me.rbt_NoMeal.Location = New System.Drawing.Point(6, 92)
        Me.rbt_NoMeal.Name = "rbt_NoMeal"
        Me.rbt_NoMeal.Size = New System.Drawing.Size(65, 17)
        Me.rbt_NoMeal.TabIndex = 3
        Me.rbt_NoMeal.Text = "No Meal"
        Me.rbt_NoMeal.UseVisualStyleBackColor = True
        '
        'rbt_VegetarianMeal
        '
        Me.rbt_VegetarianMeal.AutoSize = True
        Me.rbt_VegetarianMeal.Location = New System.Drawing.Point(6, 69)
        Me.rbt_VegetarianMeal.Name = "rbt_VegetarianMeal"
        Me.rbt_VegetarianMeal.Size = New System.Drawing.Size(102, 17)
        Me.rbt_VegetarianMeal.TabIndex = 2
        Me.rbt_VegetarianMeal.Text = "Vegetarian Meal"
        Me.rbt_VegetarianMeal.UseVisualStyleBackColor = True
        '
        'rbt_ColdMeal
        '
        Me.rbt_ColdMeal.AutoSize = True
        Me.rbt_ColdMeal.Location = New System.Drawing.Point(6, 46)
        Me.rbt_ColdMeal.Name = "rbt_ColdMeal"
        Me.rbt_ColdMeal.Size = New System.Drawing.Size(72, 17)
        Me.rbt_ColdMeal.TabIndex = 1
        Me.rbt_ColdMeal.Text = "Cold Meal"
        Me.rbt_ColdMeal.UseVisualStyleBackColor = True
        '
        'rbt_HotMeal
        '
        Me.rbt_HotMeal.AutoSize = True
        Me.rbt_HotMeal.Location = New System.Drawing.Point(6, 23)
        Me.rbt_HotMeal.Name = "rbt_HotMeal"
        Me.rbt_HotMeal.Size = New System.Drawing.Size(68, 17)
        Me.rbt_HotMeal.TabIndex = 0
        Me.rbt_HotMeal.TabStop = True
        Me.rbt_HotMeal.Text = "Hot Meal"
        Me.rbt_HotMeal.UseVisualStyleBackColor = True
        '
        'tbx_SeatName
        '
        Me.tbx_SeatName.Location = New System.Drawing.Point(110, 26)
        Me.tbx_SeatName.Name = "tbx_SeatName"
        Me.tbx_SeatName.Size = New System.Drawing.Size(100, 20)
        Me.tbx_SeatName.TabIndex = 3
        '
        'gbx_BedBooking
        '
        Me.gbx_BedBooking.Controls.Add(Me.cbx_BookBed)
        Me.gbx_BedBooking.Location = New System.Drawing.Point(13, 193)
        Me.gbx_BedBooking.Name = "gbx_BedBooking"
        Me.gbx_BedBooking.Size = New System.Drawing.Size(310, 71)
        Me.gbx_BedBooking.TabIndex = 1
        Me.gbx_BedBooking.TabStop = False
        Me.gbx_BedBooking.Text = "Bed booking"
        '
        'cbx_BookBed
        '
        Me.cbx_BookBed.AutoSize = True
        Me.cbx_BookBed.Location = New System.Drawing.Point(8, 29)
        Me.cbx_BookBed.Name = "cbx_BookBed"
        Me.cbx_BookBed.Size = New System.Drawing.Size(81, 17)
        Me.cbx_BookBed.TabIndex = 0
        Me.cbx_BookBed.Text = "Book a bed"
        Me.cbx_BookBed.UseVisualStyleBackColor = True
        '
        'btn_AddSeat
        '
        Me.btn_AddSeat.Enabled = False
        Me.btn_AddSeat.Location = New System.Drawing.Point(13, 270)
        Me.btn_AddSeat.Name = "btn_AddSeat"
        Me.btn_AddSeat.Size = New System.Drawing.Size(311, 57)
        Me.btn_AddSeat.TabIndex = 4
        Me.btn_AddSeat.Text = "Add Seat"
        Me.btn_AddSeat.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(335, 338)
        Me.Controls.Add(Me.btn_AddSeat)
        Me.Controls.Add(Me.gbx_BedBooking)
        Me.Controls.Add(Me.tbx_SeatName)
        Me.Controls.Add(Me.gbx_MealSelection)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Booking seat"
        Me.gbx_MealSelection.ResumeLayout(False)
        Me.gbx_MealSelection.PerformLayout()
        Me.gbx_BedBooking.ResumeLayout(False)
        Me.gbx_BedBooking.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_MealSelection As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_SeatName As System.Windows.Forms.TextBox
    Friend WithEvents gbx_BedBooking As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AddSeat As System.Windows.Forms.Button
    Friend WithEvents rbt_VegetarianMeal As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_ColdMeal As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_HotMeal As System.Windows.Forms.RadioButton
    Friend WithEvents cbx_BookBed As System.Windows.Forms.CheckBox
    Friend WithEvents rbt_NoMeal As RadioButton
End Class
