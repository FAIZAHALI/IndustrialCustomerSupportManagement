<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_user
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
        Me.Button_back = New System.Windows.Forms.Button
        Me.Button_clear = New System.Windows.Forms.Button
        Me.Button_Apply = New System.Windows.Forms.Button
        Me.MaskedTextBoxMobileNo2 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBoxMobileNo = New System.Windows.Forms.MaskedTextBox
        Me.txt_new_uname = New System.Windows.Forms.TextBox
        Me.Cmbo_logintypes = New System.Windows.Forms.ComboBox
        Me.TextBoxAddr = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_login_names = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_new_login_name = New System.Windows.Forms.TextBox
        Me.txt_add_pwd1 = New System.Windows.Forms.TextBox
        Me.txt_Currpwd = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_add_pwd2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.RadioButtonStatus = New System.Windows.Forms.RadioButton
        Me.RadioButtonInactive = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_back
        '
        Me.Button_back.Location = New System.Drawing.Point(432, 682)
        Me.Button_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_back.Name = "Button_back"
        Me.Button_back.Size = New System.Drawing.Size(94, 35)
        Me.Button_back.TabIndex = 539
        Me.Button_back.Text = "Back"
        Me.Button_back.UseVisualStyleBackColor = True
        '
        'Button_clear
        '
        Me.Button_clear.Location = New System.Drawing.Point(321, 682)
        Me.Button_clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(100, 35)
        Me.Button_clear.TabIndex = 528
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'Button_Apply
        '
        Me.Button_Apply.Location = New System.Drawing.Point(200, 682)
        Me.Button_Apply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Apply.Name = "Button_Apply"
        Me.Button_Apply.Size = New System.Drawing.Size(112, 35)
        Me.Button_Apply.TabIndex = 527
        Me.Button_Apply.Text = "Update"
        Me.Button_Apply.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxMobileNo2
        '
        Me.MaskedTextBoxMobileNo2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxMobileNo2.Location = New System.Drawing.Point(380, 442)
        Me.MaskedTextBoxMobileNo2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBoxMobileNo2.Mask = "9999999999"
        Me.MaskedTextBoxMobileNo2.Name = "MaskedTextBoxMobileNo2"
        Me.MaskedTextBoxMobileNo2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxMobileNo2.Size = New System.Drawing.Size(144, 30)
        Me.MaskedTextBoxMobileNo2.TabIndex = 522
        '
        'MaskedTextBoxMobileNo
        '
        Me.MaskedTextBoxMobileNo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxMobileNo.Location = New System.Drawing.Point(201, 442)
        Me.MaskedTextBoxMobileNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBoxMobileNo.Mask = "9999999999"
        Me.MaskedTextBoxMobileNo.Name = "MaskedTextBoxMobileNo"
        Me.MaskedTextBoxMobileNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxMobileNo.Size = New System.Drawing.Size(144, 30)
        Me.MaskedTextBoxMobileNo.TabIndex = 521
        '
        'txt_new_uname
        '
        Me.txt_new_uname.AcceptsReturn = True
        Me.txt_new_uname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_new_uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_new_uname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_uname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_new_uname.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_new_uname.Location = New System.Drawing.Point(200, 245)
        Me.txt_new_uname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_new_uname.MaxLength = 10
        Me.txt_new_uname.Name = "txt_new_uname"
        Me.txt_new_uname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_new_uname.Size = New System.Drawing.Size(324, 30)
        Me.txt_new_uname.TabIndex = 518
        '
        'Cmbo_logintypes
        '
        Me.Cmbo_logintypes.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbo_logintypes.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmbo_logintypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbo_logintypes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbo_logintypes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmbo_logintypes.Location = New System.Drawing.Point(198, 112)
        Me.Cmbo_logintypes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmbo_logintypes.Name = "Cmbo_logintypes"
        Me.Cmbo_logintypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmbo_logintypes.Size = New System.Drawing.Size(324, 26)
        Me.Cmbo_logintypes.TabIndex = 517
        '
        'TextBoxAddr
        '
        Me.TextBoxAddr.AcceptsReturn = True
        Me.TextBoxAddr.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxAddr.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.TextBoxAddr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxAddr.Location = New System.Drawing.Point(201, 535)
        Me.TextBoxAddr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxAddr.MaxLength = 250
        Me.TextBoxAddr.Multiline = True
        Me.TextBoxAddr.Name = "TextBoxAddr"
        Me.TextBoxAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxAddr.Size = New System.Drawing.Size(322, 67)
        Me.TextBoxAddr.TabIndex = 526
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 495)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 538
        Me.Label11.Text = "Gender"
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonFemale.Location = New System.Drawing.Point(166, 11)
        Me.RadioButtonFemale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(106, 33)
        Me.RadioButtonFemale.TabIndex = 525
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonMale.Location = New System.Drawing.Point(44, 11)
        Me.RadioButtonMale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(81, 33)
        Me.RadioButtonMale.TabIndex = 524
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 543)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 536
        Me.Label9.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 449)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 535
        Me.Label8.Text = "Contact No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 532
        Me.Label5.Text = "Login Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 531
        Me.Label4.Text = "Login Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 530
        Me.Label3.Text = " User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(596, 692)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(324, 24)
        Me.Label2.TabIndex = 529
        Me.Label2.Text = " Industrial Support  Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(266, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 33)
        Me.Label1.TabIndex = 515
        Me.Label1.Text = "Edit Current  User Details Information"
        '
        'cmb_login_names
        '
        Me.cmb_login_names.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_login_names.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_login_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_login_names.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_login_names.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_login_names.Location = New System.Drawing.Point(198, 155)
        Me.cmb_login_names.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_login_names.Name = "cmb_login_names"
        Me.cmb_login_names.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_login_names.Size = New System.Drawing.Size(324, 26)
        Me.cmb_login_names.TabIndex = 540
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 541
        Me.Label6.Text = "Login Name"
        '
        'Txt_new_login_name
        '
        Me.Txt_new_login_name.AcceptsReturn = True
        Me.Txt_new_login_name.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_new_login_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_new_login_name.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_new_login_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_new_login_name.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Txt_new_login_name.Location = New System.Drawing.Point(198, 198)
        Me.Txt_new_login_name.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Txt_new_login_name.MaxLength = 10
        Me.Txt_new_login_name.Name = "Txt_new_login_name"
        Me.Txt_new_login_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_new_login_name.Size = New System.Drawing.Size(324, 30)
        Me.Txt_new_login_name.TabIndex = 542
        '
        'txt_add_pwd1
        '
        Me.txt_add_pwd1.AcceptsReturn = True
        Me.txt_add_pwd1.BackColor = System.Drawing.SystemColors.Window
        Me.txt_add_pwd1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add_pwd1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_pwd1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_add_pwd1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_add_pwd1.Location = New System.Drawing.Point(198, 335)
        Me.txt_add_pwd1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_add_pwd1.MaxLength = 15
        Me.txt_add_pwd1.Name = "txt_add_pwd1"
        Me.txt_add_pwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_add_pwd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_add_pwd1.Size = New System.Drawing.Size(324, 30)
        Me.txt_add_pwd1.TabIndex = 544
        '
        'txt_Currpwd
        '
        Me.txt_Currpwd.AcceptsReturn = True
        Me.txt_Currpwd.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Currpwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Currpwd.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Currpwd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Currpwd.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_Currpwd.Location = New System.Drawing.Point(198, 286)
        Me.txt_Currpwd.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_Currpwd.MaxLength = 15
        Me.txt_Currpwd.Name = "txt_Currpwd"
        Me.txt_Currpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Currpwd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Currpwd.Size = New System.Drawing.Size(324, 30)
        Me.txt_Currpwd.TabIndex = 543
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 343)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 546
        Me.Label7.Text = "New Pwd"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 300)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 545
        Me.Label12.Text = "Current Pwd"
        '
        'txt_add_pwd2
        '
        Me.txt_add_pwd2.AcceptsReturn = True
        Me.txt_add_pwd2.BackColor = System.Drawing.SystemColors.Window
        Me.txt_add_pwd2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add_pwd2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_pwd2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_add_pwd2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_add_pwd2.Location = New System.Drawing.Point(198, 386)
        Me.txt_add_pwd2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_add_pwd2.MaxLength = 15
        Me.txt_add_pwd2.Name = "txt_add_pwd2"
        Me.txt_add_pwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_add_pwd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_add_pwd2.Size = New System.Drawing.Size(324, 30)
        Me.txt_add_pwd2.TabIndex = 547
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 394)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 548
        Me.Label13.Text = "Re-enter Pwd"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 625)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 551
        Me.Label10.Text = "Status"
        '
        'RadioButtonStatus
        '
        Me.RadioButtonStatus.AutoSize = True
        Me.RadioButtonStatus.Checked = True
        Me.RadioButtonStatus.ForeColor = System.Drawing.Color.Red
        Me.RadioButtonStatus.Location = New System.Drawing.Point(4, 11)
        Me.RadioButtonStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonStatus.Name = "RadioButtonStatus"
        Me.RadioButtonStatus.Size = New System.Drawing.Size(77, 24)
        Me.RadioButtonStatus.TabIndex = 552
        Me.RadioButtonStatus.TabStop = True
        Me.RadioButtonStatus.Text = "Active"
        Me.RadioButtonStatus.UseVisualStyleBackColor = True
        '
        'RadioButtonInactive
        '
        Me.RadioButtonInactive.AutoSize = True
        Me.RadioButtonInactive.ForeColor = System.Drawing.Color.Red
        Me.RadioButtonInactive.Location = New System.Drawing.Point(146, 11)
        Me.RadioButtonInactive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonInactive.Name = "RadioButtonInactive"
        Me.RadioButtonInactive.Size = New System.Drawing.Size(89, 24)
        Me.RadioButtonInactive.TabIndex = 553
        Me.RadioButtonInactive.Text = "Inactive"
        Me.RadioButtonInactive.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButtonFemale)
        Me.Panel1.Controls.Add(Me.RadioButtonMale)
        Me.Panel1.Location = New System.Drawing.Point(201, 485)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 52)
        Me.Panel1.TabIndex = 554
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButtonStatus)
        Me.Panel2.Controls.Add(Me.RadioButtonInactive)
        Me.Panel2.Location = New System.Drawing.Point(201, 620)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 52)
        Me.Panel2.TabIndex = 555
        '
        'frm_edit_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 731)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_add_pwd2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_add_pwd1)
        Me.Controls.Add(Me.txt_Currpwd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txt_new_login_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_login_names)
        Me.Controls.Add(Me.Button_back)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Button_Apply)
        Me.Controls.Add(Me.MaskedTextBoxMobileNo2)
        Me.Controls.Add(Me.MaskedTextBoxMobileNo)
        Me.Controls.Add(Me.txt_new_uname)
        Me.Controls.Add(Me.Cmbo_logintypes)
        Me.Controls.Add(Me.TextBoxAddr)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_edit_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_back As System.Windows.Forms.Button
    Friend WithEvents Button_clear As System.Windows.Forms.Button
    Friend WithEvents Button_Apply As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBoxMobileNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxMobileNo As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_new_uname As System.Windows.Forms.TextBox
    Public WithEvents Cmbo_logintypes As System.Windows.Forms.ComboBox
    Public WithEvents TextBoxAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cmb_login_names As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Txt_new_login_name As System.Windows.Forms.TextBox
    Public WithEvents txt_add_pwd1 As System.Windows.Forms.TextBox
    Public WithEvents txt_Currpwd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txt_add_pwd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonStatus As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInactive As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
