Imports System.Globalization

Public Class Form1
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click, ComputeMenuItem.Click
        ' Validate the data entered by the user
        If Not ValidData() Then
            Return
        End If

        ' Compute the cost, tax due, shipping/handling, and total
        Dim pricePerPart As Decimal = Decimal.Parse(PricePerPartTextBox.Text)
        Dim quantity As Integer = Integer.Parse(QuantityTextBox.Text)
        Dim weightPerPart As Decimal = Decimal.Parse(WeightPerPartTextBox.Text)
        Dim cost As Decimal = Decimal.Round(pricePerPart * quantity, 2)
        Dim taxDue As Decimal = ComputeSalesTaxDue()
        Dim shippingHandling As Decimal = ComputeTransportHandling(weightPerPart, quantity)
        Dim total As Decimal = cost + taxDue + shippingHandling

        ' Display the computed values in the respective TextBox controls
        CostTextBox.Text = cost.ToString("C")
        TaxDueTextBox.Text = taxDue.ToString("C")
        ShippingHandlingTextBox.Text = shippingHandling.ToString("C")
        TotalTextBox.Text = total.ToString("C")
    End Sub

    Private Sub NewOrderButton_Click(sender As Object, e As EventArgs) Handles NewOrderButton.Click, NewOrderMenuItem.Click
        ' Clear all TextBox and MaskedTextBox controls
        NameTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipCodeMaskedTextBox.Clear()
        DescriptionTextBox.Clear()
        PricePerPartTextBox.Clear()
        WeightPerPartTextBox.Clear()
        QuantityTextBox.Clear()

        ' Uncheck the Wholesale CheckBox control
        WholesaleCheckBox.Checked = False

        ' Reset the Transportation RadioButton controls to the U.S. Postal shipping method
        USPostalRadioButton.Checked = True

        ' Set focus to NameTextBox control
        NameTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitMenuItem.Click
        ' Confirm with the user before exiting the application
        If MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
        ' Display an About message box with the programmer's name
        MessageBox.Show("Programmer: Llewellyn Paintsil", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ColorMenuItem_Click(sender As Object, e As EventArgs) Handles ColorMenuItem.Click
        ' Display a Color dialog box and change the form's ForeColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontMenuItem_Click(sender As Object, e As EventArgs) Handles FontMenuItem.Click
        ' Display a Font dialog box and change the form's font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Me.Font = FontDialog1.Font
        End If
    End Sub

    Private Function ValidData() As Boolean
        ' Rule #1: Customer name cannot be missing
        If String.IsNullOrWhiteSpace(NameTextBox.Text) Then
            ShowValidationError(NameTextBox, "Please enter a customer name.")
            Return False
        End If

        ' Rule #2: Address cannot be missing
        If String.IsNullOrWhiteSpace(AddressTextBox.Text) Then
            ShowValidationError(AddressTextBox, "Please enter an address.")
            Return False
        End If

        ' Rule #3: City cannot be missing
        If String.IsNullOrWhiteSpace(CityTextBox.Text) Then
            ShowValidationError(CityTextBox, "Please enter a city.")
            Return False
        End If

        ' Rule #4: State code cannot be missing and must be two characters
        Dim stateCode As String = StateTextBox.Text.Trim().ToUpper()
        If stateCode.Length <> 2 Then
            ShowValidationError(StateTextBox, "Please enter a valid state code.")
            Return False
        End If

        ' Rule #5: Zip code cannot be missing the first five digits
        Dim zipCode As String = ZipCodeMaskedTextBox.Text.Replace("-", "").Trim()
        If zipCode.Length < 5 Then
            ShowValidationError(ZipCodeMaskedTextBox, "Please enter a valid zip code.")
            Return False
        End If

        ' Rule #6: Description cannot be missing
        If String.IsNullOrWhiteSpace(DescriptionTextBox.Text) Then
            ShowValidationError(DescriptionTextBox, "Please enter a description.")
            Return False
        End If

        ' Rule #7: Price must be a number greater than zero
        Dim price As Decimal
        If Not Decimal.TryParse(PricePerPartTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, price) OrElse price <= 0 Then
            ShowValidationError(PricePerPartTextBox, "Please enter a valid price greater than zero.")
            Return False
        End If

        ' Rule #8: Weight must be a number greater than zero
        Dim weight As Decimal
        If Not Decimal.TryParse(WeightPerPartTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, weight) OrElse weight <= 0 Then
            ShowValidationError(WeightPerPartTextBox, "Please enter a valid weight greater than zero.")
            Return False
        End If

        ' Rule #9: Quantity must be a number greater than zero
        Dim quantity As Integer
        If Not Integer.TryParse(QuantityTextBox.Text, quantity) OrElse quantity <= 0 Then
            ShowValidationError(QuantityTextBox, "Please enter a valid quantity greater than zero.")
            Return False
        End If

        ' Data is valid
        Return True
    End Function


    Private Sub ShowValidationError(control As Control, message As String)
        ' Show a validation error message box and set the focus to the control
        MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        control.Focus()

        If TypeOf control Is TextBox OrElse TypeOf control Is MaskedTextBox Then
            Dim textBox As TextBoxBase = DirectCast(control, TextBoxBase)
            textBox.SelectAll()
        End If
    End Sub
    Private Function ComputeSalesTaxDue() As Decimal
        ' Compute the sales tax due based on the state code and wholesale customer status
        Dim stateCode As String = StateTextBox.Text.Trim().ToUpper()
        Dim isWholesale As Boolean = WholesaleCheckBox.Checked

        ' Sales tax rates by state
        Select Case stateCode
            Case "IL"
                If isWholesale Then
                    Return 0
                Else
                    Return CostTextBox.Text * 0.07D
                End If
            Case "NY", "CA"
                If isWholesale Then
                    Return 0
                Else
                    Return CostTextBox.Text * 0.08D
                End If
            Case Else
                Return 0
        End Select
    End Function

    Private Function ComputeTransportHandling(weightPerPart As Decimal, quantity As Integer) As Decimal
        ' Compute the transportation and handling charge based on the selected transportation method and customer's state code
        Dim stateCode As String = StateTextBox.Text.Trim().ToUpper()

        ' Transportation charges per pound
        Dim usPostalCharge As Decimal = 0.15D
        Dim usPostalAirCharge As Decimal = 0.5D

        ' Handling charge per item
        Dim handlingCharge As Decimal = 5D

        ' Compute the total weight in pounds
        Dim totalWeight As Decimal = weightPerPart * quantity

        ' Compute the transportation charge
        Dim transportationCharge As Decimal
        Select Case True
            Case USPostalRadioButton.Checked
                transportationCharge = totalWeight * usPostalCharge
            Case USPostalAirRadioButton.Checked
                transportationCharge = totalWeight * usPostalAirCharge
        End Select

        ' Compute the handling charge
        Dim isHandlingCharge As Boolean = stateCode <> "MO" AndAlso stateCode <> "IL" AndAlso stateCode <> "KY"
        Dim handlingChargeTotal As Decimal = If(isHandlingCharge, handlingCharge * quantity, 0)

        ' Compute the total transportation and handling charge
        Return transportationCharge + handlingChargeTotal
    End Function

End Class
