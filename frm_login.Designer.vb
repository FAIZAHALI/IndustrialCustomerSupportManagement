<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.txt_pws = New System.Windows.Forms.TextBox
        Me.lbl_templ = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.AcceptsReturn = True
        Me.txt_user.BackColor = System.Drawing.SystemColors.Window
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_user.Location = New System.Drawing.Point(352, 178)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_user.MaxLength = 0
        Me.txt_user.Name = "txt_user"
        Me.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_user.Size = New System.Drawing.Size(310, 30)
        Me.txt_user.TabIndex = 1
        '
        'txt_pws
        '
        Me.txt_pws.AcceptsReturn = True
        Me.txt_pws.BackColor = System.Drawing.SystemColors.Window
        Me.txt_pws.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pws.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pws.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pws.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_pws.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_pws.Location = New System.Drawing.Point(352, 260)
        Me.txt_pws.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_pws.MaxLength = 0
        Me.txt_pws.Name = "txt_pws"
        Me.txt_pws.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pws.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_pws.Size = New System.Drawing.Size(310, 30)
        Me.txt_pws.TabIndex = 2
        '
        'lbl_templ
        '
        Me.lbl_templ.AutoSize = True
        Me.lbl_templ.BackColor = System.Drawing.Color.Transparent
        Me.lbl_templ.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_templ.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_templ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_templ.Location = New System.Drawing.Point(207, 182)
        Me.lbl_templ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_templ.Name = "lbl_templ"
        Me.lbl_templ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_templ.Size = New System.Drawing.Size(103, 24)
        Me.lbl_templ.TabIndex = 24
        Me.lbl_templ.Text = "Login Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(207, 269)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Password"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(592, 334)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(82, 27)
        Me.LinkLabel1.TabIndex = 26
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(501, 437)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(319, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Industrial Support  Management System"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(18, 412)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 49)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Log Out"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 475)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_templ)
        Me.Controls.Add(Me.txt_pws)
        Me.Controls.Add(Me.txt_user)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txt_user As System.Windows.Forms.TextBox
    Public WithEvents txt_pws As System.Windows.Forms.TextBox
    Public WithEvents lbl_templ As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
