<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pro_complaint
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
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_proname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button_back = New System.Windows.Forms.Button
        Me.Button_clear = New System.Windows.Forms.Button
        Me.MaskedTextBoxMobileNo2 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBoxMobileNo = New System.Windows.Forms.MaskedTextBox
        Me.txt_slno = New System.Windows.Forms.TextBox
        Me.TextBoxAddr = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePickerComDate = New System.Windows.Forms.DateTimePicker
        Me.cmb_status = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBoxSearch = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txtpro = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cmb_type = New System.Windows.Forms.ComboBox
        Me.DataGridViewCompSearch = New System.Windows.Forms.DataGridView
        Me.txt_cusname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePickerPurDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.RadioButtonCusname = New System.Windows.Forms.RadioButton
        Me.RadioButtonSerial = New System.Windows.Forms.RadioButton
        Me.RadioButtonMobNo = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        CType(Me.DataGridViewCompSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(554, 72)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 20)
        Me.Label12.TabIndex = 573
        Me.Label12.Text = "Complained Date"
        '
        'txt_proname
        '
        Me.txt_proname.AcceptsReturn = True
        Me.txt_proname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_proname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_proname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_proname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_proname.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_proname.Location = New System.Drawing.Point(189, 94)
        Me.txt_proname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_proname.MaxLength = 50
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_proname.Size = New System.Drawing.Size(324, 30)
        Me.txt_proname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 569
        Me.Label6.Text = "Product Name "
        '
        'Button_back
        '
        Me.Button_back.Location = New System.Drawing.Point(315, 325)
        Me.Button_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_back.Name = "Button_back"
        Me.Button_back.Size = New System.Drawing.Size(94, 35)
        Me.Button_back.TabIndex = 567
        Me.Button_back.Text = "Back"
        Me.Button_back.UseVisualStyleBackColor = True
        '
        'Button_clear
        '
        Me.Button_clear.Location = New System.Drawing.Point(206, 323)
        Me.Button_clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(100, 35)
        Me.Button_clear.TabIndex = 559
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxMobileNo2
        '
        Me.MaskedTextBoxMobileNo2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxMobileNo2.Location = New System.Drawing.Point(870, 102)
        Me.MaskedTextBoxMobileNo2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBoxMobileNo2.Mask = "9999999999"
        Me.MaskedTextBoxMobileNo2.Name = "MaskedTextBoxMobileNo2"
        Me.MaskedTextBoxMobileNo2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxMobileNo2.Size = New System.Drawing.Size(144, 30)
        Me.MaskedTextBoxMobileNo2.TabIndex = 8
        '
        'MaskedTextBoxMobileNo
        '
        Me.MaskedTextBoxMobileNo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxMobileNo.Location = New System.Drawing.Point(694, 102)
        Me.MaskedTextBoxMobileNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBoxMobileNo.Mask = "9999999999"
        Me.MaskedTextBoxMobileNo.Name = "MaskedTextBoxMobileNo"
        Me.MaskedTextBoxMobileNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxMobileNo.Size = New System.Drawing.Size(144, 30)
        Me.MaskedTextBoxMobileNo.TabIndex = 7
        '
        'txt_slno
        '
        Me.txt_slno.AcceptsReturn = True
        Me.txt_slno.BackColor = System.Drawing.SystemColors.Window
        Me.txt_slno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_slno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_slno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_slno.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_slno.Location = New System.Drawing.Point(189, 137)
        Me.txt_slno.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_slno.MaxLength = 50
        Me.txt_slno.Name = "txt_slno"
        Me.txt_slno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_slno.Size = New System.Drawing.Size(324, 30)
        Me.txt_slno.TabIndex = 3
        '
        'TextBoxAddr
        '
        Me.TextBoxAddr.AcceptsReturn = True
        Me.TextBoxAddr.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxAddr.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.TextBoxAddr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxAddr.Location = New System.Drawing.Point(696, 145)
        Me.TextBoxAddr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxAddr.MaxLength = 2500
        Me.TextBoxAddr.Multiline = True
        Me.TextBoxAddr.Name = "TextBoxAddr"
        Me.TextBoxAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxAddr.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxAddr.Size = New System.Drawing.Size(322, 67)
        Me.TextBoxAddr.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(594, 303)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 566
        Me.Label11.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(554, 152)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 564
        Me.Label9.Text = "Cust Address "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(566, 109)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 563
        Me.Label8.Text = "Contact No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 560
        Me.Label3.Text = "Serail No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(324, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 33)
        Me.Label1.TabIndex = 549
        Me.Label1.Text = "Product Complaint Registration"
        '
        'DateTimePickerComDate
        '
        Me.DateTimePickerComDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerComDate.CustomFormat = "dd-MM-yy"
        Me.DateTimePickerComDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerComDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerComDate.Location = New System.Drawing.Point(694, 52)
        Me.DateTimePickerComDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerComDate.Name = "DateTimePickerComDate"
        Me.DateTimePickerComDate.Size = New System.Drawing.Size(324, 35)
        Me.DateTimePickerComDate.TabIndex = 6
        '
        'cmb_status
        '
        Me.cmb_status.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_status.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_status.Items.AddRange(New Object() {"open", "close"})
        Me.cmb_status.Location = New System.Drawing.Point(699, 298)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_status.Size = New System.Drawing.Size(319, 26)
        Me.cmb_status.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 323)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 35)
        Me.Button1.TabIndex = 581
        Me.Button1.Text = "Register Complaint"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.AcceptsReturn = True
        Me.TextBoxSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxSearch.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxSearch.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBoxSearch.Location = New System.Drawing.Point(205, 380)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBoxSearch.MaxLength = 10
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxSearch.Size = New System.Drawing.Size(324, 30)
        Me.TextBoxSearch.TabIndex = 933
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(554, 228)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 20)
        Me.Label13.TabIndex = 576
        Me.Label13.Text = "Product Issue"
        '
        'Txtpro
        '
        Me.Txtpro.AcceptsReturn = True
        Me.Txtpro.BackColor = System.Drawing.SystemColors.Window
        Me.Txtpro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtpro.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Txtpro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txtpro.Location = New System.Drawing.Point(696, 220)
        Me.Txtpro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtpro.MaxLength = 10000
        Me.Txtpro.Multiline = True
        Me.Txtpro.Name = "Txtpro"
        Me.Txtpro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtpro.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtpro.Size = New System.Drawing.Size(322, 67)
        Me.Txtpro.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 574
        Me.Label7.Text = "Product Type"
        '
        'Cmb_type
        '
        Me.Cmb_type.BackColor = System.Drawing.SystemColors.Window
        Me.Cmb_type.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmb_type.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_type.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmb_type.Location = New System.Drawing.Point(189, 58)
        Me.Cmb_type.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmb_type.Name = "Cmb_type"
        Me.Cmb_type.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmb_type.Size = New System.Drawing.Size(319, 26)
        Me.Cmb_type.TabIndex = 1
        '
        'DataGridViewCompSearch
        '
        Me.DataGridViewCompSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompSearch.Location = New System.Drawing.Point(28, 418)
        Me.DataGridViewCompSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridViewCompSearch.Name = "DataGridViewCompSearch"
        Me.DataGridViewCompSearch.RowTemplate.Height = 28
        Me.DataGridViewCompSearch.Size = New System.Drawing.Size(1044, 275)
        Me.DataGridViewCompSearch.TabIndex = 935
        '
        'txt_cusname
        '
        Me.txt_cusname.AcceptsReturn = True
        Me.txt_cusname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cusname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cusname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cusname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_cusname.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_cusname.Location = New System.Drawing.Point(189, 180)
        Me.txt_cusname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_cusname.MaxLength = 50
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_cusname.Size = New System.Drawing.Size(324, 30)
        Me.txt_cusname.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 940
        Me.Label5.Text = "Customer Name"
        '
        'DateTimePickerPurDate
        '
        Me.DateTimePickerPurDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerPurDate.CustomFormat = "dd-MM-yy"
        Me.DateTimePickerPurDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPurDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerPurDate.Location = New System.Drawing.Point(189, 220)
        Me.DateTimePickerPurDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerPurDate.Name = "DateTimePickerPurDate"
        Me.DateTimePickerPurDate.Size = New System.Drawing.Size(324, 35)
        Me.DateTimePickerPurDate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 941
        Me.Label2.Text = "Purchased Date"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(806, 373)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 943
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButtonCusname
        '
        Me.RadioButtonCusname.AutoSize = True
        Me.RadioButtonCusname.Checked = True
        Me.RadioButtonCusname.Location = New System.Drawing.Point(39, 380)
        Me.RadioButtonCusname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonCusname.Name = "RadioButtonCusname"
        Me.RadioButtonCusname.Size = New System.Drawing.Size(135, 24)
        Me.RadioButtonCusname.TabIndex = 944
        Me.RadioButtonCusname.TabStop = True
        Me.RadioButtonCusname.Text = "Custom Name"
        Me.RadioButtonCusname.UseVisualStyleBackColor = True
        '
        'RadioButtonSerial
        '
        Me.RadioButtonSerial.AutoSize = True
        Me.RadioButtonSerial.Location = New System.Drawing.Point(537, 388)
        Me.RadioButtonSerial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonSerial.Name = "RadioButtonSerial"
        Me.RadioButtonSerial.Size = New System.Drawing.Size(120, 24)
        Me.RadioButtonSerial.TabIndex = 945
        Me.RadioButtonSerial.Text = "Serail Numb"
        Me.RadioButtonSerial.UseVisualStyleBackColor = True
        '
        'RadioButtonMobNo
        '
        Me.RadioButtonMobNo.AutoSize = True
        Me.RadioButtonMobNo.Location = New System.Drawing.Point(669, 384)
        Me.RadioButtonMobNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonMobNo.Name = "RadioButtonMobNo"
        Me.RadioButtonMobNo.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonMobNo.TabIndex = 946
        Me.RadioButtonMobNo.Text = "Mobile No"
        Me.RadioButtonMobNo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 267)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 947
        Me.Label4.Text = "Complained Through"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox1.Location = New System.Drawing.Point(189, 267)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox1.Size = New System.Drawing.Size(319, 26)
        Me.ComboBox1.TabIndex = 948
        '
        'frm_pro_complaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 711)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButtonMobNo)
        Me.Controls.Add(Me.RadioButtonSerial)
        Me.Controls.Add(Me.RadioButtonCusname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePickerPurDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cusname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cmb_type)
        Me.Controls.Add(Me.Txtpro)
        Me.Controls.Add(Me.DataGridViewCompSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.DateTimePickerComDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_proname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_back)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.MaskedTextBoxMobileNo2)
        Me.Controls.Add(Me.MaskedTextBoxMobileNo)
        Me.Controls.Add(Me.txt_slno)
        Me.Controls.Add(Me.TextBoxAddr)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_pro_complaint"
        Me.Text = "Complaint Registration"
        CType(Me.DataGridViewCompSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txt_proname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button_back As System.Windows.Forms.Button
    Friend WithEvents Button_clear As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBoxMobileNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxMobileNo As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_slno As System.Windows.Forms.TextBox
    Public WithEvents TextBoxAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerComDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Txtpro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewCompSearch As System.Windows.Forms.DataGridView
    Public WithEvents txt_cusname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerPurDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButtonCusname As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSerial As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMobNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
