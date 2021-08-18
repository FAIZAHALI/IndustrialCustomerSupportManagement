<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBoxAddr = New System.Windows.Forms.TextBox
        Me.txt_add_usr = New System.Windows.Forms.TextBox
        Me.cmb_add_auth = New System.Windows.Forms.ComboBox
        Me.txt_add_name = New System.Windows.Forms.TextBox
        Me.txt_add_pwd1 = New System.Windows.Forms.TextBox
        Me.txt_add_pwd2 = New System.Windows.Forms.TextBox
        Me.MaskedTextBoxMobileNo2 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBoxMobileNo = New System.Windows.Forms.MaskedTextBox
        Me.Button_Register = New System.Windows.Forms.Button
        Me.Button_clear = New System.Windows.Forms.Button
        Me.Button_back = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Registration Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(478, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(224, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = " Industrial Support  Management System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Login Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Login Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Re-enter Pwd"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Address"
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonFemale.Location = New System.Drawing.Point(214, 238)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(72, 24)
        Me.RadioButtonFemale.TabIndex = 10
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonMale.Location = New System.Drawing.Point(130, 238)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(56, 24)
        Me.RadioButtonMale.TabIndex = 9
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 513
        Me.Label11.Text = "Gender"
        '
        'TextBoxAddr
        '
        Me.TextBoxAddr.AcceptsReturn = True
        Me.TextBoxAddr.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxAddr.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.TextBoxAddr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxAddr.Location = New System.Drawing.Point(130, 271)
        Me.TextBoxAddr.MaxLength = 250
        Me.TextBoxAddr.Multiline = True
        Me.TextBoxAddr.Name = "TextBoxAddr"
        Me.TextBoxAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxAddr.Size = New System.Drawing.Size(216, 45)
        Me.TextBoxAddr.TabIndex = 11
        '
        'txt_add_usr
        '
        Me.txt_add_usr.AcceptsReturn = True
        Me.txt_add_usr.BackColor = System.Drawing.SystemColors.Window
        Me.txt_add_usr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add_usr.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_usr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_add_usr.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_add_usr.Location = New System.Drawing.Point(128, 52)
        Me.txt_add_usr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_add_usr.MaxLength = 10
        Me.txt_add_usr.Name = "txt_add_usr"
        Me.txt_add_usr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_add_usr.Size = New System.Drawing.Size(217, 22)
        Me.txt_add_usr.TabIndex = 1
        '
        'cmb_add_auth
        '
        Me.cmb_add_auth.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_add_auth.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_add_auth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_add_auth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_add_auth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_add_auth.Location = New System.Drawing.Point(128, 88)
        Me.cmb_add_auth.Name = "cmb_add_auth"
        Me.cmb_add_auth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_add_auth.Size = New System.Drawing.Size(217, 22)
        Me.cmb_add_auth.TabIndex = 2
        '
        'txt_add_name
        '
        Me.txt_add_name.AcceptsReturn = True
        Me.txt_add_name.BackColor = System.Drawing.SystemColors.Window
        Me.txt_add_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add_name.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_add_name.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_add_name.Location = New System.Drawing.Point(128, 122)
        Me.txt_add_name.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_add_name.MaxLength = 10
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_add_name.Size = New System.Drawing.Size(217, 22)
        Me.txt_add_name.TabIndex = 3
        '
        'txt_add_pwd1
        '
        Me.txt_add_pwd1.AcceptsReturn = True
        Me.txt_add_pwd1.BackColor = System.Drawing.SystemColors.Window
        Me.txt_add_pwd1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add_pwd1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_pwd1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_add_pwd1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_add_pwd1.Location = New System.Drawing.Point(128, 150)
        Me.txt_add_pwd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_add_pwd1.MaxLength = 15
        Me.txt_add_pwd1.Name = "txt_add_pwd1"
        Me.txt_add_pwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_add_pwd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_add_pwd1.Size = New System.Drawing.Size(217, 22)
        Me.txt_add_pwd1.TabIndex = 4
        '
        'txt_add_pwd2
        '
        Me.txt_add_pwd2.AcceptsReturn = True
        Me.txt_add_pwd2.BackColor = System.Drawing.SystemColors.Window
        Me.txt_add_pwd2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add_pwd2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add_pwd2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_add_pwd2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_add_pwd2.Location = New System.Drawing.Point(129, 178)
        Me.txt_add_pwd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_add_pwd2.MaxLength = 15
        Me.txt_add_pwd2.Name = "txt_add_pwd2"
        Me.txt_add_pwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_add_pwd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_add_pwd2.Size = New System.Drawing.Size(217, 22)
        Me.txt_add_pwd2.TabIndex = 5
        '
        'MaskedTextBoxMobileNo2
        '
        Me.MaskedTextBoxMobileNo2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxMobileNo2.Location = New System.Drawing.Point(248, 207)
        Me.MaskedTextBoxMobileNo2.Mask = "9999999999"
        Me.MaskedTextBoxMobileNo2.Name = "MaskedTextBoxMobileNo2"
        Me.MaskedTextBoxMobileNo2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxMobileNo2.Size = New System.Drawing.Size(97, 22)
        Me.MaskedTextBoxMobileNo2.TabIndex = 7
        '
        'MaskedTextBoxMobileNo
        '
        Me.MaskedTextBoxMobileNo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxMobileNo.Location = New System.Drawing.Point(129, 207)
        Me.MaskedTextBoxMobileNo.Mask = "9999999999"
        Me.MaskedTextBoxMobileNo.Name = "MaskedTextBoxMobileNo"
        Me.MaskedTextBoxMobileNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxMobileNo.Size = New System.Drawing.Size(97, 22)
        Me.MaskedTextBoxMobileNo.TabIndex = 6
        '
        'Button_Register
        '
        Me.Button_Register.Location = New System.Drawing.Point(128, 336)
        Me.Button_Register.Name = "Button_Register"
        Me.Button_Register.Size = New System.Drawing.Size(75, 23)
        Me.Button_Register.TabIndex = 12
        Me.Button_Register.Text = "Register"
        Me.Button_Register.UseVisualStyleBackColor = True
        '
        'Button_clear
        '
        Me.Button_clear.Location = New System.Drawing.Point(209, 336)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(67, 23)
        Me.Button_clear.TabIndex = 13
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'Button_back
        '
        Me.Button_back.Location = New System.Drawing.Point(282, 336)
        Me.Button_back.Name = "Button_back"
        Me.Button_back.Size = New System.Drawing.Size(63, 23)
        Me.Button_back.TabIndex = 514
        Me.Button_back.Text = "Back"
        Me.Button_back.UseVisualStyleBackColor = True
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 481)
        Me.Controls.Add(Me.Button_back)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Button_Register)
        Me.Controls.Add(Me.MaskedTextBoxMobileNo2)
        Me.Controls.Add(Me.MaskedTextBoxMobileNo)
        Me.Controls.Add(Me.txt_add_pwd2)
        Me.Controls.Add(Me.txt_add_pwd1)
        Me.Controls.Add(Me.txt_add_name)
        Me.Controls.Add(Me.cmb_add_auth)
        Me.Controls.Add(Me.txt_add_usr)
        Me.Controls.Add(Me.TextBoxAddr)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RadioButtonFemale)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents TextBoxAddr As System.Windows.Forms.TextBox
    Public WithEvents txt_add_usr As System.Windows.Forms.TextBox
    Public WithEvents cmb_add_auth As System.Windows.Forms.ComboBox
    Public WithEvents txt_add_name As System.Windows.Forms.TextBox
    Public WithEvents txt_add_pwd1 As System.Windows.Forms.TextBox
    Public WithEvents txt_add_pwd2 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxMobileNo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxMobileNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button_Register As System.Windows.Forms.Button
    Friend WithEvents Button_clear As System.Windows.Forms.Button
    Friend WithEvents Button_back As System.Windows.Forms.Button
End Class
