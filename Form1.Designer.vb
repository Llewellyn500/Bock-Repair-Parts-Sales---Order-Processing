<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        File = New ToolStripMenuItem()
        ExitMenuItem = New ToolStripMenuItem()
        Actions = New ToolStripMenuItem()
        ComputeMenuItem = New ToolStripMenuItem()
        NewOrderMenuItem = New ToolStripMenuItem()
        ColorMenuItem = New ToolStripMenuItem()
        FontMenuItem = New ToolStripMenuItem()
        Help = New ToolStripMenuItem()
        AboutMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        StateTextBox = New TextBox()
        ZipCodeMaskedTextBox = New MaskedTextBox()
        CityTextBox = New TextBox()
        AddressTextBox = New TextBox()
        NameTextBox = New TextBox()
        WholesaleCheckBox = New CheckBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        QuantityTextBox = New TextBox()
        WeightPerPartTextBox = New TextBox()
        PricePerPartTextBox = New TextBox()
        DescriptionTextBox = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        GroupBox3 = New GroupBox()
        FedExOvernightRadioButton = New RadioButton()
        USPostalAirRadioButton = New RadioButton()
        FedEx2ndDayRadioButton = New RadioButton()
        USPostalRadioButton = New RadioButton()
        GroupBox4 = New GroupBox()
        TotalTextBox = New TextBox()
        ShippingHandlingTextBox = New TextBox()
        TaxDueTextBox = New TextBox()
        CostTextBox = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        ComputeButton = New Button()
        NewOrderButton = New Button()
        ExitButton = New Button()
        ColorDialog1 = New ColorDialog()
        FontDialog1 = New FontDialog()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {File, Actions, Help})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(700, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' File
        ' 
        File.DropDownItems.AddRange(New ToolStripItem() {ExitMenuItem})
        File.Name = "File"
        File.Size = New Size(37, 20)
        File.Text = "File"
        ' 
        ' ExitMenuItem
        ' 
        ExitMenuItem.Name = "ExitMenuItem"
        ExitMenuItem.Size = New Size(154, 22)
        ExitMenuItem.Text = "Exit          Ctrl-X"
        ' 
        ' Actions
        ' 
        Actions.DropDownItems.AddRange(New ToolStripItem() {ComputeMenuItem, NewOrderMenuItem, ColorMenuItem, FontMenuItem})
        Actions.Name = "Actions"
        Actions.Size = New Size(59, 20)
        Actions.Text = "Actions"
        ' 
        ' ComputeMenuItem
        ' 
        ComputeMenuItem.Name = "ComputeMenuItem"
        ComputeMenuItem.Size = New Size(200, 22)
        ComputeMenuItem.Text = "Compute         Ctrl-C"
        ' 
        ' NewOrderMenuItem
        ' 
        NewOrderMenuItem.Name = "NewOrderMenuItem"
        NewOrderMenuItem.Size = New Size(200, 22)
        NewOrderMenuItem.Text = "New Order            Ctrl-N"
        ' 
        ' ColorMenuItem
        ' 
        ColorMenuItem.Name = "ColorMenuItem"
        ColorMenuItem.Size = New Size(200, 22)
        ColorMenuItem.Text = "Color"
        ' 
        ' FontMenuItem
        ' 
        FontMenuItem.Name = "FontMenuItem"
        FontMenuItem.Size = New Size(200, 22)
        FontMenuItem.Text = "Font"
        ' 
        ' Help
        ' 
        Help.DropDownItems.AddRange(New ToolStripItem() {AboutMenuItem})
        Help.Name = "Help"
        Help.Size = New Size(44, 20)
        Help.Text = "Help"
        ' 
        ' AboutMenuItem
        ' 
        AboutMenuItem.Name = "AboutMenuItem"
        AboutMenuItem.Size = New Size(107, 22)
        AboutMenuItem.Text = "About"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.SandyBrown
        GroupBox1.Controls.Add(StateTextBox)
        GroupBox1.Controls.Add(ZipCodeMaskedTextBox)
        GroupBox1.Controls.Add(CityTextBox)
        GroupBox1.Controls.Add(AddressTextBox)
        GroupBox1.Controls.Add(NameTextBox)
        GroupBox1.Controls.Add(WholesaleCheckBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(10, 23)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(361, 120)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(307, 62)
        StateTextBox.Margin = New Padding(3, 2, 3, 2)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(50, 23)
        StateTextBox.TabIndex = 13
        ' 
        ' ZipCodeMaskedTextBox
        ' 
        ZipCodeMaskedTextBox.Location = New Point(116, 86)
        ZipCodeMaskedTextBox.Margin = New Padding(3, 2, 3, 2)
        ZipCodeMaskedTextBox.Mask = "00000-9999"
        ZipCodeMaskedTextBox.Name = "ZipCodeMaskedTextBox"
        ZipCodeMaskedTextBox.Size = New Size(110, 23)
        ZipCodeMaskedTextBox.TabIndex = 12
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(117, 62)
        CityTextBox.Margin = New Padding(3, 2, 3, 2)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(185, 23)
        CityTextBox.TabIndex = 11
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(117, 37)
        AddressTextBox.Margin = New Padding(3, 2, 3, 2)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(239, 23)
        AddressTextBox.TabIndex = 10
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(117, 14)
        NameTextBox.Margin = New Padding(3, 2, 3, 2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(239, 23)
        NameTextBox.TabIndex = 9
        ' 
        ' WholesaleCheckBox
        ' 
        WholesaleCheckBox.AutoSize = True
        WholesaleCheckBox.Location = New Point(251, 88)
        WholesaleCheckBox.Margin = New Padding(3, 2, 3, 2)
        WholesaleCheckBox.Name = "WholesaleCheckBox"
        WholesaleCheckBox.Size = New Size(80, 19)
        WholesaleCheckBox.TabIndex = 8
        WholesaleCheckBox.Text = "Wholesale"
        WholesaleCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 3
        Label4.Text = "Zip Code:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 2
        Label3.Text = "City - State:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 1
        Label2.Text = "Address:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.SandyBrown
        GroupBox2.Controls.Add(QuantityTextBox)
        GroupBox2.Controls.Add(WeightPerPartTextBox)
        GroupBox2.Controls.Add(PricePerPartTextBox)
        GroupBox2.Controls.Add(DescriptionTextBox)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(10, 148)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(361, 96)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Parts Information"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(296, 63)
        QuantityTextBox.Margin = New Padding(3, 2, 3, 2)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(61, 23)
        QuantityTextBox.TabIndex = 16
        QuantityTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' WeightPerPartTextBox
        ' 
        WeightPerPartTextBox.Location = New Point(117, 63)
        WeightPerPartTextBox.Margin = New Padding(3, 2, 3, 2)
        WeightPerPartTextBox.Name = "WeightPerPartTextBox"
        WeightPerPartTextBox.Size = New Size(110, 23)
        WeightPerPartTextBox.TabIndex = 15
        WeightPerPartTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' PricePerPartTextBox
        ' 
        PricePerPartTextBox.Location = New Point(117, 38)
        PricePerPartTextBox.Margin = New Padding(3, 2, 3, 2)
        PricePerPartTextBox.Name = "PricePerPartTextBox"
        PricePerPartTextBox.Size = New Size(126, 23)
        PricePerPartTextBox.TabIndex = 14
        PricePerPartTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(116, 14)
        DescriptionTextBox.Margin = New Padding(3, 2, 3, 2)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(240, 23)
        DescriptionTextBox.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(234, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 15)
        Label8.TabIndex = 3
        Label8.Text = "Quantity:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(5, 68)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 15)
        Label7.TabIndex = 2
        Label7.Text = "Weight per Part:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 1
        Label6.Text = "Price per Part:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 0
        Label5.Text = "Description:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.SandyBrown
        GroupBox3.Controls.Add(FedExOvernightRadioButton)
        GroupBox3.Controls.Add(USPostalAirRadioButton)
        GroupBox3.Controls.Add(FedEx2ndDayRadioButton)
        GroupBox3.Controls.Add(USPostalRadioButton)
        GroupBox3.Location = New Point(384, 23)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(305, 86)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Transportation"
        ' 
        ' FedExOvernightRadioButton
        ' 
        FedExOvernightRadioButton.AutoSize = True
        FedExOvernightRadioButton.Location = New Point(153, 52)
        FedExOvernightRadioButton.Margin = New Padding(3, 2, 3, 2)
        FedExOvernightRadioButton.Name = "FedExOvernightRadioButton"
        FedExOvernightRadioButton.Size = New Size(115, 19)
        FedExOvernightRadioButton.TabIndex = 3
        FedExOvernightRadioButton.TabStop = True
        FedExOvernightRadioButton.Text = "Fed Ex Overnight"
        FedExOvernightRadioButton.UseVisualStyleBackColor = True
        ' 
        ' USPostalAirRadioButton
        ' 
        USPostalAirRadioButton.AutoSize = True
        USPostalAirRadioButton.Location = New Point(23, 52)
        USPostalAirRadioButton.Margin = New Padding(3, 2, 3, 2)
        USPostalAirRadioButton.Name = "USPostalAirRadioButton"
        USPostalAirRadioButton.Size = New Size(92, 19)
        USPostalAirRadioButton.TabIndex = 2
        USPostalAirRadioButton.TabStop = True
        USPostalAirRadioButton.Text = "US Postal Air"
        USPostalAirRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FedEx2ndDayRadioButton
        ' 
        FedEx2ndDayRadioButton.AutoSize = True
        FedEx2ndDayRadioButton.Location = New Point(153, 20)
        FedEx2ndDayRadioButton.Margin = New Padding(3, 2, 3, 2)
        FedEx2ndDayRadioButton.Name = "FedEx2ndDayRadioButton"
        FedEx2ndDayRadioButton.Size = New Size(105, 19)
        FedEx2ndDayRadioButton.TabIndex = 1
        FedEx2ndDayRadioButton.TabStop = True
        FedEx2ndDayRadioButton.Text = "Fed Ex 2nd Day"
        FedEx2ndDayRadioButton.UseVisualStyleBackColor = True
        ' 
        ' USPostalRadioButton
        ' 
        USPostalRadioButton.AutoSize = True
        USPostalRadioButton.Location = New Point(23, 20)
        USPostalRadioButton.Margin = New Padding(3, 2, 3, 2)
        USPostalRadioButton.Name = "USPostalRadioButton"
        USPostalRadioButton.Size = New Size(74, 19)
        USPostalRadioButton.TabIndex = 0
        USPostalRadioButton.TabStop = True
        USPostalRadioButton.Text = "US Postal"
        USPostalRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.SandyBrown
        GroupBox4.Controls.Add(TotalTextBox)
        GroupBox4.Controls.Add(ShippingHandlingTextBox)
        GroupBox4.Controls.Add(TaxDueTextBox)
        GroupBox4.Controls.Add(CostTextBox)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Location = New Point(383, 113)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(306, 130)
        GroupBox4.TabIndex = 0
        GroupBox4.TabStop = False
        GroupBox4.Text = "Output"
        ' 
        ' TotalTextBox
        ' 
        TotalTextBox.Location = New Point(131, 98)
        TotalTextBox.Margin = New Padding(3, 2, 3, 2)
        TotalTextBox.Name = "TotalTextBox"
        TotalTextBox.ReadOnly = True
        TotalTextBox.Size = New Size(169, 23)
        TotalTextBox.TabIndex = 20
        TotalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ShippingHandlingTextBox
        ' 
        ShippingHandlingTextBox.Location = New Point(131, 73)
        ShippingHandlingTextBox.Margin = New Padding(3, 2, 3, 2)
        ShippingHandlingTextBox.Name = "ShippingHandlingTextBox"
        ShippingHandlingTextBox.ReadOnly = True
        ShippingHandlingTextBox.Size = New Size(169, 23)
        ShippingHandlingTextBox.TabIndex = 19
        ShippingHandlingTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TaxDueTextBox
        ' 
        TaxDueTextBox.Location = New Point(131, 48)
        TaxDueTextBox.Margin = New Padding(3, 2, 3, 2)
        TaxDueTextBox.Name = "TaxDueTextBox"
        TaxDueTextBox.ReadOnly = True
        TaxDueTextBox.Size = New Size(169, 23)
        TaxDueTextBox.TabIndex = 18
        TaxDueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' CostTextBox
        ' 
        CostTextBox.Location = New Point(131, 23)
        CostTextBox.Margin = New Padding(3, 2, 3, 2)
        CostTextBox.Name = "CostTextBox"
        CostTextBox.ReadOnly = True
        CostTextBox.Size = New Size(169, 23)
        CostTextBox.TabIndex = 17
        CostTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(9, 101)
        Label12.Name = "Label12"
        Label12.Size = New Size(35, 15)
        Label12.TabIndex = 7
        Label12.Text = "Total:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(9, 76)
        Label11.Name = "Label11"
        Label11.Size = New Size(111, 15)
        Label11.TabIndex = 6
        Label11.Text = "Shipping/Handling:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(9, 51)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 15)
        Label10.TabIndex = 5
        Label10.Text = "Tax Due:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 15)
        Label9.TabIndex = 4
        Label9.Text = "Cost:"
        ' 
        ' ComputeButton
        ' 
        ComputeButton.BackColor = Color.SandyBrown
        ComputeButton.Location = New Point(10, 248)
        ComputeButton.Margin = New Padding(3, 2, 3, 2)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(95, 32)
        ComputeButton.TabIndex = 9
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = False
        ' 
        ' NewOrderButton
        ' 
        NewOrderButton.BackColor = Color.SandyBrown
        NewOrderButton.Location = New Point(126, 248)
        NewOrderButton.Margin = New Padding(3, 2, 3, 2)
        NewOrderButton.Name = "NewOrderButton"
        NewOrderButton.Size = New Size(95, 32)
        NewOrderButton.TabIndex = 10
        NewOrderButton.Text = "New Order"
        NewOrderButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.SandyBrown
        ExitButton.Location = New Point(593, 248)
        ExitButton.Margin = New Padding(3, 2, 3, 2)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(95, 32)
        ExitButton.TabIndex = 11
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(700, 288)
        Controls.Add(ExitButton)
        Controls.Add(NewOrderButton)
        Controls.Add(ComputeButton)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Bock Repair Parts Sales - Order Processing"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents Actions As ToolStripMenuItem
    Friend WithEvents Help As ToolStripMenuItem
    Friend WithEvents ComputeMenuItem As ToolStripMenuItem
    Friend WithEvents NewOrderMenuItem As ToolStripMenuItem
    Friend WithEvents ColorMenuItem As ToolStripMenuItem
    Friend WithEvents FontMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FedExOvernightRadioButton As RadioButton
    Friend WithEvents USPostalAirRadioButton As RadioButton
    Friend WithEvents FedEx2ndDayRadioButton As RadioButton
    Friend WithEvents USPostalRadioButton As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents WholesaleCheckBox As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComputeButton As Button
    Friend WithEvents NewOrderButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents WeightPerPartTextBox As TextBox
    Friend WithEvents PricePerPartTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ShippingHandlingTextBox As TextBox
    Friend WithEvents TaxDueTextBox As TextBox
    Friend WithEvents ZipCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents StateTextBox As TextBox
    Private WithEvents CostTextBox As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
