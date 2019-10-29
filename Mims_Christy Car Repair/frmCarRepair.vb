'Project: Car Repair
'Programmer Name: Christy Mims
'Date: 2/8/17
'Description:  This program allows the user to enter information about a customer, their car, and what has been repaired on the vehicle.
'The program also allows the user to display this information through the use Of group boxes, text boxes, combo boxes, And buttons.  It also allows 
'the user to then display information in a list box along with the results of the computed data. 
Public Class frmCarRepair
    Dim Labor_Per_Hour = 0
    Private Sub frmCarRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cost_Per_Hour As Integer
        Cost_Per_Hour = InputBox("Enter the current labor cost per hour.", "Labor Cost")
        Labor_Per_Hour = Cost_Per_Hour
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'This button allows the user to close the program.
    End Sub

    Private Sub btnNewRepairBill_Click(sender As Object, e As EventArgs) Handles btnNewRepairBill.Click
        lstResults.Items.Clear()
        txtCustomerName.Text = ""
        txtStreetAddress.Text = ""
        txtCity.Text = ""
        cboState.Text = ""
        mskZipCode.Text = ""
        mskPhoneNumber.Text = ""
        cboMakeofCar.Text = ""
        cboYear.Text = ""
        txtDescription.Text = ""
        txtLaborHours.Text = ""
        txtCostofParts.Text = ""
        'This button allows the user to clear out the data inputed in the text boxes and the results displayed in the listbox.
    End Sub

    Private Sub btnDisplayRepairBill_Click(sender As Object, e As EventArgs) Handles btnDisplayRepairBill.Click
        'This button allows the user to take all the data input in the program to be computed and displayed in the list box.
        Dim Sub_Total, Total, Tax As Decimal
        Dim Labor_Hours, PartsCost As Double
        Const Sales_Tax As Decimal = 0.07D
        Labor_Hours = CDec(txtLaborHours.Text)
        PartsCost = CDec(txtCostofParts.Text)
        Labor_Hours = Labor_Per_Hour * Labor_Hours
        Sub_Total = Labor_Hours + PartsCost
        Tax = Sales_Tax * Sub_Total
        Total = Sub_Total + Tax
        Dim FormatList As String = " {0, -20}{1, 20}"
        lstResults.Items.Add(String.Format(FormatList, "Customer:", txtCustomerName.Text))
        lstResults.Items.Add(String.Format(FormatList, "City, State, Zip:", txtCity.Text & ", " & cboState.Text & " " & mskZipCode.Text))
        lstResults.Items.Add(String.Format(FormatList, "Phone Number:", mskPhoneNumber.Text))
        lstResults.Items.Add(String.Format(FormatList, "Car Description:", cboMakeofCar.Text & " " & cboYear.Text))
        lstResults.Items.Add(String.Format(FormatList, "Labor Cost:", Labor_Hours.ToString("C")))
        lstResults.Items.Add(String.Format(FormatList, "Parts Cost:", PartsCost.ToString("C")))
        lstResults.Items.Add(String.Format(FormatList, "Sub Total:", Sub_Total.ToString("C")))
        lstResults.Items.Add(String.Format(FormatList, "Tax:", Tax.ToString("C")))
        lstResults.Items.Add(String.Format(FormatList, "Total:", Total.ToString("C")))

    End Sub
End Class
