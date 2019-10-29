<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarRepair
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
        Me.gbCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mskZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAutombileInformation = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboMakeofCar = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbCost = New System.Windows.Forms.GroupBox()
        Me.btnDisplayRepairBill = New System.Windows.Forms.Button()
        Me.txtCostofParts = New System.Windows.Forms.TextBox()
        Me.txtLaborHours = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnNewRepairBill = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbCustomerInformation.SuspendLayout()
        Me.gbAutombileInformation.SuspendLayout()
        Me.gbCost.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomerInformation
        '
        Me.gbCustomerInformation.Controls.Add(Me.mskPhoneNumber)
        Me.gbCustomerInformation.Controls.Add(Me.mskZipCode)
        Me.gbCustomerInformation.Controls.Add(Me.cboState)
        Me.gbCustomerInformation.Controls.Add(Me.txtCity)
        Me.gbCustomerInformation.Controls.Add(Me.txtStreetAddress)
        Me.gbCustomerInformation.Controls.Add(Me.txtCustomerName)
        Me.gbCustomerInformation.Controls.Add(Me.Label6)
        Me.gbCustomerInformation.Controls.Add(Me.Label5)
        Me.gbCustomerInformation.Controls.Add(Me.Label4)
        Me.gbCustomerInformation.Controls.Add(Me.Label3)
        Me.gbCustomerInformation.Controls.Add(Me.Label2)
        Me.gbCustomerInformation.Controls.Add(Me.Label1)
        Me.gbCustomerInformation.Location = New System.Drawing.Point(26, 34)
        Me.gbCustomerInformation.Name = "gbCustomerInformation"
        Me.gbCustomerInformation.Size = New System.Drawing.Size(384, 301)
        Me.gbCustomerInformation.TabIndex = 0
        Me.gbCustomerInformation.TabStop = False
        Me.gbCustomerInformation.Text = "Customer Information"
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.Location = New System.Drawing.Point(134, 237)
        Me.mskPhoneNumber.Mask = "(999) 000-0000"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.mskPhoneNumber.TabIndex = 5
        '
        'mskZipCode
        '
        Me.mskZipCode.Location = New System.Drawing.Point(134, 196)
        Me.mskZipCode.Mask = "00000-9999"
        Me.mskZipCode.Name = "mskZipCode"
        Me.mskZipCode.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskZipCode.Size = New System.Drawing.Size(100, 20)
        Me.mskZipCode.TabIndex = 4
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"})
        Me.cboState.Location = New System.Drawing.Point(134, 156)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(81, 21)
        Me.cboState.Sorted = True
        Me.cboState.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(134, 116)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(204, 20)
        Me.txtCity.TabIndex = 2
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(134, 76)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(204, 20)
        Me.txtStreetAddress.TabIndex = 1
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(134, 36)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(204, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Zip Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Street Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'gbAutombileInformation
        '
        Me.gbAutombileInformation.Controls.Add(Me.Label11)
        Me.gbAutombileInformation.Controls.Add(Me.txtDescription)
        Me.gbAutombileInformation.Controls.Add(Me.cboYear)
        Me.gbAutombileInformation.Controls.Add(Me.cboMakeofCar)
        Me.gbAutombileInformation.Controls.Add(Me.Label8)
        Me.gbAutombileInformation.Controls.Add(Me.Label7)
        Me.gbAutombileInformation.Location = New System.Drawing.Point(437, 34)
        Me.gbAutombileInformation.Name = "gbAutombileInformation"
        Me.gbAutombileInformation.Size = New System.Drawing.Size(413, 236)
        Me.gbAutombileInformation.TabIndex = 1
        Me.gbAutombileInformation.TabStop = False
        Me.gbAutombileInformation.Text = "Automobile Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Description of work performed:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(26, 135)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(359, 95)
        Me.txtDescription.TabIndex = 2
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017"})
        Me.cboYear.Location = New System.Drawing.Point(101, 69)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.Sorted = True
        Me.cboYear.TabIndex = 1
        '
        'cboMakeofCar
        '
        Me.cboMakeofCar.FormattingEnabled = True
        Me.cboMakeofCar.Items.AddRange(New Object() {"Cadillac", "Chevrolet", "Dodge", "Ford", "Honda", "Jeep", "Lexus", "Lincoln", "Mazda", "Mercedes-Benz", "Mercury", "Nissan", "Toyota"})
        Me.cboMakeofCar.Location = New System.Drawing.Point(101, 28)
        Me.cboMakeofCar.Name = "cboMakeofCar"
        Me.cboMakeofCar.Size = New System.Drawing.Size(121, 21)
        Me.cboMakeofCar.Sorted = True
        Me.cboMakeofCar.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Year:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Make of Car:"
        '
        'gbCost
        '
        Me.gbCost.Controls.Add(Me.btnDisplayRepairBill)
        Me.gbCost.Controls.Add(Me.txtCostofParts)
        Me.gbCost.Controls.Add(Me.txtLaborHours)
        Me.gbCost.Controls.Add(Me.Label10)
        Me.gbCost.Controls.Add(Me.Label9)
        Me.gbCost.Location = New System.Drawing.Point(437, 276)
        Me.gbCost.Name = "gbCost"
        Me.gbCost.Size = New System.Drawing.Size(421, 102)
        Me.gbCost.TabIndex = 2
        Me.gbCost.TabStop = False
        Me.gbCost.Text = "Cost"
        '
        'btnDisplayRepairBill
        '
        Me.btnDisplayRepairBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayRepairBill.Location = New System.Drawing.Point(310, 25)
        Me.btnDisplayRepairBill.Name = "btnDisplayRepairBill"
        Me.btnDisplayRepairBill.Size = New System.Drawing.Size(94, 57)
        Me.btnDisplayRepairBill.TabIndex = 2
        Me.btnDisplayRepairBill.Text = "&Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Repair Bill"
        Me.btnDisplayRepairBill.UseVisualStyleBackColor = True
        '
        'txtCostofParts
        '
        Me.txtCostofParts.Location = New System.Drawing.Point(175, 58)
        Me.txtCostofParts.Name = "txtCostofParts"
        Me.txtCostofParts.Size = New System.Drawing.Size(115, 20)
        Me.txtCostofParts.TabIndex = 1
        '
        'txtLaborHours
        '
        Me.txtLaborHours.Location = New System.Drawing.Point(175, 27)
        Me.txtLaborHours.Name = "txtLaborHours"
        Me.txtLaborHours.Size = New System.Drawing.Size(115, 20)
        Me.txtLaborHours.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cost of Parts and Supplies:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Labor Hours:"
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 14
        Me.lstResults.Location = New System.Drawing.Point(26, 398)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(815, 200)
        Me.lstResults.TabIndex = 3
        Me.lstResults.TabStop = False
        '
        'btnNewRepairBill
        '
        Me.btnNewRepairBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRepairBill.Location = New System.Drawing.Point(316, 635)
        Me.btnNewRepairBill.Name = "btnNewRepairBill"
        Me.btnNewRepairBill.Size = New System.Drawing.Size(94, 57)
        Me.btnNewRepairBill.TabIndex = 4
        Me.btnNewRepairBill.Text = "&New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Repair Bill"
        Me.btnNewRepairBill.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(446, 635)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 57)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 702)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewRepairBill)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.gbCost)
        Me.Controls.Add(Me.gbAutombileInformation)
        Me.Controls.Add(Me.gbCustomerInformation)
        Me.Name = "frmCarRepair"
        Me.Text = "Repair Bill"
        Me.gbCustomerInformation.ResumeLayout(False)
        Me.gbCustomerInformation.PerformLayout()
        Me.gbAutombileInformation.ResumeLayout(False)
        Me.gbAutombileInformation.PerformLayout()
        Me.gbCost.ResumeLayout(False)
        Me.gbCost.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCustomerInformation As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbAutombileInformation As GroupBox
    Friend WithEvents gbCost As GroupBox
    Friend WithEvents mskPhoneNumber As MaskedTextBox
    Friend WithEvents mskZipCode As MaskedTextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents cboMakeofCar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDisplayRepairBill As Button
    Friend WithEvents txtCostofParts As TextBox
    Friend WithEvents txtLaborHours As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnNewRepairBill As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label11 As Label
End Class
