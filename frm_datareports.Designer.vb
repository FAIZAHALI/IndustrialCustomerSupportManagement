<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_datareports
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
        Me.DataGridViewdataRep = New System.Windows.Forms.DataGridView
        Me.ComboBoxtype = New System.Windows.Forms.ComboBox
        Me.CheckBoxbtw = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker
        Me.CheckBoxall = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGridViewdataRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewdataRep
        '
        Me.DataGridViewdataRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewdataRep.Location = New System.Drawing.Point(12, 113)
        Me.DataGridViewdataRep.Name = "DataGridViewdataRep"
        Me.DataGridViewdataRep.Size = New System.Drawing.Size(912, 514)
        Me.DataGridViewdataRep.TabIndex = 0
        '
        'ComboBoxtype
        '
        Me.ComboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxtype.FormattingEnabled = True
        Me.ComboBoxtype.Items.AddRange(New Object() {"Employee Details", "Closed Complaints", "Open Complaints"})
        Me.ComboBoxtype.Location = New System.Drawing.Point(121, 73)
        Me.ComboBoxtype.Name = "ComboBoxtype"
        Me.ComboBoxtype.Size = New System.Drawing.Size(327, 21)
        Me.ComboBoxtype.TabIndex = 1
        '
        'CheckBoxbtw
        '
        Me.CheckBoxbtw.AutoSize = True
        Me.CheckBoxbtw.Checked = True
        Me.CheckBoxbtw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxbtw.Location = New System.Drawing.Point(12, 12)
        Me.CheckBoxbtw.Name = "CheckBoxbtw"
        Me.CheckBoxbtw.Size = New System.Drawing.Size(99, 17)
        Me.CheckBoxbtw.TabIndex = 2
        Me.CheckBoxbtw.Text = "Between Dates"
        Me.CheckBoxbtw.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Report  Type"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To"
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(267, 34)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTo.TabIndex = 10
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(12, 35)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFrom.TabIndex = 9
        '
        'CheckBoxall
        '
        Me.CheckBoxall.AutoSize = True
        Me.CheckBoxall.Location = New System.Drawing.Point(151, 12)
        Me.CheckBoxall.Name = "CheckBoxall"
        Me.CheckBoxall.Size = New System.Drawing.Size(80, 17)
        Me.CheckBoxall.TabIndex = 12
        Me.CheckBoxall.Text = "All Records"
        Me.CheckBoxall.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(482, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_datareports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(936, 639)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBoxall)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePickerTo)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxbtw)
        Me.Controls.Add(Me.ComboBoxtype)
        Me.Controls.Add(Me.DataGridViewdataRep)
        Me.Name = "frm_datareports"
        Me.Text = "frm_datareports"
        CType(Me.DataGridViewdataRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewdataRep As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxtype As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxbtw As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxall As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
