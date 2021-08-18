<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_assign
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridViewAssign = New System.Windows.Forms.DataGridView
        Me.CheckBoxOpen = New System.Windows.Forms.CheckBox
        Me.CheckBoxClose = New System.Windows.Forms.CheckBox
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button_clear = New System.Windows.Forms.Button
        Me.DateTimePickerAssDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_cusname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_proname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_slno = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmb_exp = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.cmb_status = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Txt_cmpid = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Txt_empname = New System.Windows.Forms.ComboBox
        CType(Me.DataGridViewAssign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAssign
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAssign.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewAssign.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewAssign.Location = New System.Drawing.Point(18, 282)
        Me.DataGridViewAssign.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridViewAssign.Name = "DataGridViewAssign"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAssign.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewAssign.RowTemplate.Height = 28
        Me.DataGridViewAssign.Size = New System.Drawing.Size(1538, 602)
        Me.DataGridViewAssign.TabIndex = 0
        '
        'CheckBoxOpen
        '
        Me.CheckBoxOpen.AutoSize = True
        Me.CheckBoxOpen.Checked = True
        Me.CheckBoxOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBoxOpen.Location = New System.Drawing.Point(992, 12)
        Me.CheckBoxOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBoxOpen.Name = "CheckBoxOpen"
        Me.CheckBoxOpen.Size = New System.Drawing.Size(179, 26)
        Me.CheckBoxOpen.TabIndex = 1
        Me.CheckBoxOpen.Text = " Open Complaints"
        Me.CheckBoxOpen.UseVisualStyleBackColor = True
        '
        'CheckBoxClose
        '
        Me.CheckBoxClose.AutoSize = True
        Me.CheckBoxClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBoxClose.Location = New System.Drawing.Point(1182, 12)
        Me.CheckBoxClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBoxClose.Name = "CheckBoxClose"
        Me.CheckBoxClose.Size = New System.Drawing.Size(186, 26)
        Me.CheckBoxClose.TabIndex = 2
        Me.CheckBoxClose.Text = "Closed Complaints"
        Me.CheckBoxClose.UseVisualStyleBackColor = True
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(171, 18)
        Me.DateTimePickerFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePickerFrom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Between Dates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 5
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(552, 18)
        Me.DateTimePickerTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePickerTo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(494, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(1042, 120)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Assign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_clear
        '
        Me.Button_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button_clear.Location = New System.Drawing.Point(1042, 172)
        Me.Button_clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(112, 35)
        Me.Button_clear.TabIndex = 10
        Me.Button_clear.Text = "Clear"
        Me.Button_clear.UseVisualStyleBackColor = True
        '
        'DateTimePickerAssDate
        '
        Me.DateTimePickerAssDate.CustomFormat = "dd-MM-yy"
        Me.DateTimePickerAssDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerAssDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerAssDate.Location = New System.Drawing.Point(180, 208)
        Me.DateTimePickerAssDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerAssDate.Name = "DateTimePickerAssDate"
        Me.DateTimePickerAssDate.Size = New System.Drawing.Size(324, 35)
        Me.DateTimePickerAssDate.TabIndex = 946
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 951
        Me.Label5.Text = "Assigned Date"
        '
        'txt_cusname
        '
        Me.txt_cusname.AcceptsReturn = True
        Me.txt_cusname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cusname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cusname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cusname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_cusname.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_cusname.Location = New System.Drawing.Point(180, 165)
        Me.txt_cusname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_cusname.MaxLength = 50
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_cusname.Size = New System.Drawing.Size(324, 30)
        Me.txt_cusname.TabIndex = 945
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(14, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 22)
        Me.Label6.TabIndex = 950
        Me.Label6.Text = "Customer Name"
        '
        'txt_proname
        '
        Me.txt_proname.AcceptsReturn = True
        Me.txt_proname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_proname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_proname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_proname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_proname.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_proname.Location = New System.Drawing.Point(180, 83)
        Me.txt_proname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_proname.MaxLength = 50
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_proname.Size = New System.Drawing.Size(324, 30)
        Me.txt_proname.TabIndex = 943
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 83)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 22)
        Me.Label8.TabIndex = 948
        Me.Label8.Text = "Product Name "
        '
        'txt_slno
        '
        Me.txt_slno.AcceptsReturn = True
        Me.txt_slno.BackColor = System.Drawing.SystemColors.Window
        Me.txt_slno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_slno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_slno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_slno.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt_slno.Location = New System.Drawing.Point(180, 122)
        Me.txt_slno.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_slno.MaxLength = 50
        Me.txt_slno.Name = "txt_slno"
        Me.txt_slno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_slno.Size = New System.Drawing.Size(324, 30)
        Me.txt_slno.TabIndex = 944
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 126)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 22)
        Me.Label9.TabIndex = 947
        Me.Label9.Text = "Serail No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(518, 140)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 22)
        Me.Label7.TabIndex = 956
        Me.Label7.Text = "Emp Name "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(518, 185)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 22)
        Me.Label10.TabIndex = 955
        Me.Label10.Text = "Expertise"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(738, 111)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 20)
        Me.Label11.TabIndex = 952
        '
        'cmb_exp
        '
        Me.cmb_exp.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_exp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_exp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_exp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_exp.Location = New System.Drawing.Point(676, 174)
        Me.cmb_exp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_exp.Name = "cmb_exp"
        Me.cmb_exp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_exp.Size = New System.Drawing.Size(319, 26)
        Me.cmb_exp.TabIndex = 957
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(1042, 222)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 958
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmb_status
        '
        Me.cmb_status.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_status.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_status.Items.AddRange(New Object() {"open", "close"})
        Me.cmb_status.Location = New System.Drawing.Point(676, 217)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_status.Size = New System.Drawing.Size(319, 26)
        Me.cmb_status.TabIndex = 960
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(518, 222)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 22)
        Me.Label12.TabIndex = 959
        Me.Label12.Text = "Status"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1430, 9)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 35)
        Me.Button4.TabIndex = 961
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1430, 60)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 57)
        Me.Button5.TabIndex = 962
        Me.Button5.Text = "All Open Records"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1430, 134)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 58)
        Me.Button6.TabIndex = 963
        Me.Button6.Text = "All Closed Records"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Txt_cmpid
        '
        Me.Txt_cmpid.AcceptsReturn = True
        Me.Txt_cmpid.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_cmpid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_cmpid.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cmpid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_cmpid.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Txt_cmpid.Location = New System.Drawing.Point(672, 83)
        Me.Txt_cmpid.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Txt_cmpid.MaxLength = 50
        Me.Txt_cmpid.Name = "Txt_cmpid"
        Me.Txt_cmpid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_cmpid.Size = New System.Drawing.Size(324, 30)
        Me.Txt_cmpid.TabIndex = 964
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(518, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 965
        Me.Label3.Text = "Cmp Id"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1430, 212)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 966
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Txt_empname
        '
        Me.Txt_empname.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_empname.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_empname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_empname.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_empname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_empname.Location = New System.Drawing.Point(677, 138)
        Me.Txt_empname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_empname.Name = "Txt_empname"
        Me.Txt_empname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_empname.Size = New System.Drawing.Size(319, 26)
        Me.Txt_empname.TabIndex = 967
        '
        'frm_assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1574, 902)
        Me.Controls.Add(Me.Txt_empname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txt_cmpid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmb_exp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePickerAssDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cusname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_proname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_slno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePickerTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.CheckBoxClose)
        Me.Controls.Add(Me.CheckBoxOpen)
        Me.Controls.Add(Me.DataGridViewAssign)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Complaint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewAssign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewAssign As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxOpen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxClose As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button_clear As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerAssDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txt_cusname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txt_proname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txt_slno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents cmb_exp As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents Txt_cmpid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents Txt_empname As System.Windows.Forms.ComboBox
End Class
