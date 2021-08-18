Option Strict Off
Option Explicit On
Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Imports System.Data

Imports System.IO


Imports MySql.Data
Imports MySql.Data.MySqlClient
Friend Class frm_emp_register
    Inherits System.Windows.Forms.Form
    Dim WithEvents comport As New System.IO.Ports.SerialPort
    Dim close_flag As Boolean
    Dim tab As New DataTable("Search")
    Dim stQuery11 As String

    Dim cnnDB As SqlClient.SqlConnection

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader
    Private Sub frm_emp_register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        'Dim surverIp As String = "localhost"
        'Dim dbPassword As String = "f18K0972fn05ti09rn2"
        'Dim port As String = "5432"
        'Dim dbname As String = "Support_db"


        'cnnDB.ConnectionString = "SERVER=" & surverIp & ";DATABASE= " & dbname & _
        '                              ";USER ID=postgres;PASSWORD=" & dbPassword & _
        '                              ";Preload Reader = True;PORT= " & port
        cnnDB.Open()
        stQuery11 = "SELECT distinct(st_designation) FROM sc_employee ORDER BY st_designation"

        Dim cmd2 As New MySqlCommand(stQuery11, cnnDB)

        'cmd2.CommandText = stQuery11
        'cmd2.Connection = cnnDB

        myReader1 = cmd2.ExecuteReader()


        While myReader1.Read
            Cmbo_designation.Items.Add(myReader1.GetString(0))
        End While

        myReader1.Close()
        cnnDB.Close()

    End Sub

    Private Sub btn_Reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reg.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        Dim emp_user_id As String = ""
        Dim empname As String = ""
        Dim age As String
        Dim empid As String
        Dim mailid As String = ""
        Dim rate As String


        Dim address, designation, UsrNameEscStr As String

        empname = Trim(txt_emp_name.Text)


        mailid = Trim(Txt_mailid.Text)


        rate = txt_rate.Text

        age = maskedtxtage.Text

        designation = Cmbo_designation.Text

        address = Trim(TextBoxAddr.Text)


        'Is the User name entered
        If Trim(txt_emp_name.Text) = "" Then
            MsgBox("Please enter employee Name")
            txt_emp_name.Focus()
            Exit Sub
        End If

        'Is the designation entered
        If Trim(Cmbo_designation.Text) = "" Then
            MsgBox("Please enter Designation")
            Cmbo_designation.Focus()
            Exit Sub
        End If


        'Is the mobile number entered
        If Trim(MaskedTextBoxMobileNo.Text) = "" Then
            MsgBox("Please enter Mobile No")
            MaskedTextBoxMobileNo.Focus()
            Exit Sub
        End If

        'Is the mobile number entered
        If Trim(maskedtxtage.Text) = "" Then
            MsgBox("Please enter age")
            maskedtxtage.Focus()
            Exit Sub
        End If

        'Is the Name entered
        If Trim(TextBoxAddr.Text) = "" Then
            MsgBox("Please enter addres")
            TextBoxAddr.Focus()
            Exit Sub
        End If

        If RadioButtonMale.Checked = False And RadioButtonFemale.Checked = False Then
            MsgBox("Please Select Gender(Male or Female)")
            Exit Sub
        End If

        Dim stQuery As String

        Dim flg_gen As Short

        If RadioButtonMale.Checked = True Then
            flg_gen = 0
        Else
            flg_gen = 1
        End If

        Dim emp_no As String = ""
        If Not getempId(emp_no) Then
            MsgBox("Error Fetching Employee No")
        End If


        cnnDB.Open()
        stQuery = "insert into sc_employee values('" & emp_no & "','" & txt_empid.Text & "','" & empname & "'," & MaskedTextBoxMobileNo.Text & _
                                                    " ,'" & MaskedTextBoxMobileNo2.Text & "' ," & flg_gen & _
                                             ",'" & mailid & "','" & age & "','" & rate & "','1','" & designation & "','" & address & "','" & Format(Today.Date, "yyyy-MM-dd") & "')"
        Dim cmd4 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd4.ExecuteReader()
        myReader.Close()
        cnnDB.Close()
        'Display a confermation msg that user is created
        MsgBox("EMPLOYEE CREATED " & vbNewLine & vbNewLine & "Employee Name" & vbTab & _
               ":" & txt_emp_name.Text & vbTab & vbNewLine & "Employee ID" & vbTab & _
               vbTab & ":" & emp_no & vbTab & vbNewLine & "Designation" & vbTab & _
               vbTab & ":" & Trim(Cmbo_designation.Text) & vbTab)


        Call Button_clear_Click(Button_clear, New System.EventArgs())

    End Sub

    Private Sub Button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clear.Click
        txt_emp_name.Text = ""
        Txt_mailid.Text = ""
        txt_rate.Text = ""
        MaskedTextBoxMobileNo.Text = ""
        MaskedTextBoxMobileNo2.Text = ""
        Cmbo_designation.Text = ""
        txt_empid.Text = ""
        maskedtxtage.Text = ""
        TextBoxAddr.Text = ""

    End Sub
    Public Function getempId(ByRef emp_no As String) As Boolean
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        getempId = False
        Dim stquery3 As String = ""
        Dim st_bill_no As String
        Dim emp_cur_no As String
        Dim emp_curr As String
        Dim YYYMM As String
        Dim month As String
        Dim ym As String
        Dim pre As String
        Dim emp_exist_no As String
        ' YYYMM = readSettingIdValue(1)
        Dim stquery4, stquery5, stquery6 As String

        Dim myReader3 As MySqlDataReader = Nothing
        Dim myReader6 As MySqlDataReader = Nothing
        ' Dim myReader3 As MySqlDataReader = Nothing
        cnnDB.Open()
        'Read the Value for the setting ID
        stquery3 = "SELECT st_value FROM sc_setting WHERE si_setting_id = '" & 1 & "'"
        'Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery3
        ' cmd2.Connection = cnnDB
        'cnnDB.Open()
        Dim cmd2 As New MySqlCommand(stquery3, cnnDB)
        myReader3 = cmd2.ExecuteReader()

        If myReader3.HasRows = False Then
            myReader3.Close()
            Exit Function
        End If

        myReader3.Read()
        If Not IsDBNull(myReader3.GetValue(0)) Then
            YYYMM = myReader3.GetString(0)
        End If

        myReader3.Close()

        Dim myReader4 As MySqlDataReader = Nothing

        'Read the Value for the setting ID
        stquery4 = "SELECT st_value FROM sc_setting WHERE si_setting_id = '" & 2 & "'"
        Dim cmd4 As New MySqlCommand(stquery4, cnnDB)
        myReader4 = cmd4.ExecuteReader()



        If myReader4.HasRows = False Then
            myReader4.Close()
            Exit Function
        End If

        myReader4.Read()
        If Not IsDBNull(myReader4.GetValue(0)) Then
            month = myReader4.GetString(0)
        End If

        myReader4.Close()



        ' month = readSettingIdValue(2)
        pre = "EM"

        ym = YYYMM & month

        'Read the Value for the setting ID
        stquery6 = "SELECT st_value FROM sc_setting WHERE si_setting_id = '" & 3 & "'"
        Dim cmd6 As New MySqlCommand(stquery6, cnnDB)

        myReader6 = cmd6.ExecuteReader()

        If myReader6.HasRows = False Then
            myReader6.Close()
            Exit Function
        End If

        myReader6.Read()
        If Not IsDBNull(myReader6.GetValue(0)) Then
            emp_exist_no = myReader6.GetString(0)
        End If

        myReader6.Close()
        ' emp_exist_no = readSettingIdValue(3)


        If emp_exist_no <> "ERROR" Then
            emp_cur_no = prepad(emp_exist_no + 1, 7)

            emp_no = pre & ym & emp_cur_no

            getempId = True
        Else
            Exit Function
        End If

        stquery6 = "update sc_setting set st_value = '" & emp_cur_no & "' where si_setting_id='3'"
        'Dim cmd7 As MySqlCommand = New MySqlCommand
        'cmd7.CommandText = stquery6
        'cmd7.Connection = cnnDB
        Dim cmd7 As MySqlCommand = New MySqlCommand(stquery6, cnnDB)
        cmd7.ExecuteNonQuery()


        cnnDB.Close()

    End Function

    Private Sub Button_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_back.Click
        frm_admin.Show()
        Me.Hide()

    End Sub

    Private Sub Button_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Search.Click

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        If Rad_Empid.Checked <> False Or Rad_Empname.Checked <> False Then
            If Txt_emp_search.Text <> "" Then

                DataGridView_Search.DataSource = tab

                'Clear the grid
                tab.Columns.Clear()

                'Add Columns to search grid
                tab.Columns.Add("Employee No")
                tab.Columns.Add("Employee Name")
                tab.Columns.Add("Designation")
                tab.Columns.Add("Gender")
                tab.Columns.Add("Employee ID")
                tab.Columns.Add("Age")
                tab.Columns.Add("Cont. No")
                tab.Columns.Add("Address")
                tab.Columns.Add("Mail ID")
                tab.Columns.Add("Rate Per HR")
                tab.Columns.Add("Alternative Mobile Numb")

                With DataGridView_Search
                    'Setting the columns Alignment
                    .Columns("Employee No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns("Employee Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns("Designation").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns("Gender").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Employee ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Age").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Cont. No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Address").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Mail ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Rate Per Hr").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Alternative Mobile Numb").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                    'Setting the columns Width
                    .Columns("Employee No").Width = 60
                    .Columns("Employee Name").Width = 70
                    .Columns("Designation").Width = 70
                    .Columns("Gender").Width = 70
                    .Columns("Employee ID").Width = 70
                    .Columns("Age").Width = 70
                    .Columns("Cont. No").Width = 80
                    .Columns("Address").Width = 70
                    .Columns("Mail ID").Width = 70
                    .Columns("Rate Per Hr").Width = 70
                    .Columns("Alternative Mobile Numb").Width = 80


                    'Set Only vertical scrollbar
                    .ScrollBars = ScrollBars.Both
                End With

                DataGridView_Search.Columns("Employee No").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Employee Name").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Designation").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Gender").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Employee ID").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Age").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Cont. No").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Address").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Mail ID").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Rate Per Hr").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridView_Search.Columns("Alternative Mobile Numb").SortMode = DataGridViewColumnSortMode.NotSortable


                'Call function to set all look and feel parameters of the grid
                Call DefaultGridSettings(DataGridView_Search)

                'Add 1 blank row
                Dim row As DataRow

                row = tab.NewRow()
                tab.Rows.Add(row)

            Else
                MsgBox("Please select emplypee name or id")
                Exit Sub
            End If
        End If
        Dim stquery As String
        If Rad_Empid.Checked = True Then
            Dim stquery1 As String
            stquery1 = "Select * from sc_employee where st_emp_id like '%" & Txt_emp_search.Text & "%'"
            Dim cmd1 As MySqlCommand = New MySqlCommand

            cmd1.CommandText = stquery1
            cmd1.Connection = cnnDB
            cnnDB.Open()
            myReader = cmd1.ExecuteReader()
            tab.Clear()
            If myReader.HasRows = False Then
                MsgBox("No Records found")
                Exit Sub
            Else

                Dim row As DataRow
                Dim q_count As Double
                While myReader.Read
                    q_count = q_count + 1

                    row = tab.NewRow()

                    'Populate DataGrid_search
                    row("Employee No") = myReader.GetString(0)

                    row("Employee Name") = myReader.GetString(2)
                    row("Designation") = myReader.GetString(10)
                    'row("Gender") = myReader.GetString(7)
                    If myReader.GetValue(5) = "0" Then
                        row("Gender") = "Male"
                    Else
                        row("Gender") = "Female"
                    End If
                    row("Employee ID") = myReader.GetString(1)
                    row("Age") = myReader.GetValue(7) & " Yrs"
                    row("Cont. No") = myReader.GetString(3)
                    row("Address") = myReader.GetString(11)
                    row("Rate Per HR") = myReader.GetValue(8)
                    If Not IsDBNull(myReader.GetString(4)) Then
                        row("Alternative Mobile Numb") = myReader.GetString(4)
                    Else
                        row("Alternative Mobile Numb") = ""
                    End If
                    row("Mail ID") = myReader.GetString(6)

                    tab.Rows.Add(row)
                End While
                cnnDB.Close()
            End If
        Else
            Dim stquery2 As String

            stquery2 = "Select * from sc_employee where st_name like '%" & Txt_emp_search.Text & "%'"
            'Dim cnnDB As New MySqlConnection(myConnectionString)
            '' cmd2.CommandText = stQuery2
            '' cmd2.Connection = cnnDB
            cnnDB.Open()
            Dim cmd2 As MySqlCommand = New MySqlCommand(stquery2, cnnDB)
            myReader = cmd2.ExecuteReader()
            tab.Clear()
            If myReader.HasRows = False Then
                MsgBox("No Records found")
                Exit Sub
            Else

                Dim row As DataRow
                Dim q_count As Double
                While myReader.Read
                    q_count = q_count + 1

                    row = tab.NewRow()

                    'Populate DataGrid_search
                    row("Employee No") = myReader.GetString(0)

                    row("Employee Name") = myReader.GetString(2)
                    row("Designation") = myReader.GetString(10)
                    'row("Gender") = myReader.GetString(7)
                    If myReader.GetValue(5) = "0" Then
                        row("Gender") = "Male"
                    Else
                        row("Gender") = "Female"
                    End If
                    row("Employee ID") = myReader.GetString(1)
                    row("Age") = myReader.GetValue(7) & " Yrs"
                    row("Cont. No") = myReader.GetString(3)
                    row("Address") = myReader.GetString(11)
                    row("Rate Per HR") = myReader.GetValue(8)
                    If Not IsDBNull(myReader.GetString(4)) Then
                        row("Alternative Mobile Numb") = myReader.GetString(4)
                    Else
                        row("Alternative Mobile Numb") = ""
                    End If
                    row("Mail ID") = myReader.GetString(6)

                    tab.Rows.Add(row)
                End While
            End If
            cnnDB.Close()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim emp_user_id As String = ""
        Dim empname As String = ""
        Dim age As String
        Dim empid As String
        Dim mailid As String = ""
        Dim rate As String
        Dim mobile, mobile2 As String


        Dim address, designation, UsrNameEscStr As String

        empname = Replace(Trim(txt_emp_name.Text), "\", "\\")
        empname = Replace(empname, "'", "''")

        mailid = Replace(Txt_mailid.Text, "\", "\\")
        mailid = Replace(mailid, "'", "''")

        rate = txt_rate.Text

        age = maskedtxtage.Text

        mobile = MaskedTextBoxMobileNo.Text

        mobile2 = MaskedTextBoxMobileNo2.Text


        empid = txt_empid.Text

        designation = Cmbo_designation.Text

        address = Replace(Trim(TextBoxAddr.Text), "\", "\\")
        address = Replace(address, "'", "''")

        'Is the User name entered
        If Trim(txt_emp_name.Text) = "" Then
            MsgBox("Please enter employee Name")
            txt_emp_name.Focus()
            Exit Sub
        End If

        'Is the designation entered
        If Trim(Cmbo_designation.Text) = "" Then
            MsgBox("Please enter Designation")
            Cmbo_designation.Focus()
            Exit Sub
        End If


        'Is the mobile number entered
        If Trim(MaskedTextBoxMobileNo.Text) = "" Then
            MsgBox("Please enter Mobile No")
            MaskedTextBoxMobileNo.Focus()
            Exit Sub
        End If


        'Is the Name entered
        If Trim(TextBoxAddr.Text) = "" Then
            MsgBox("Please enter addres")
            TextBoxAddr.Focus()
            Exit Sub
        End If

        If RadioButtonMale.Checked = False And RadioButtonFemale.Checked = False Then
            MsgBox("Please Select Gender(Male or Female)")
            Exit Sub
        End If

        Dim stQuery As String

        Dim flg_gen As Short

        If RadioButtonMale.Checked = True Then
            flg_gen = 0
        Else
            flg_gen = 1
        End If

        stQuery = "update sc_employee set st_name = '" & empname & "',st_mob_no = '" & mobile & "',st_mob_noo = '" & mobile2 & "',ch_gender = '" & flg_gen & "',st_email = '" & mailid & "',si_age = '" & age & "',f_rate = '" & rate & "',st_designation = '" & designation & "' where st_emp_id='" & txt_empid.Text & "'"

        Dim Command1 As New MySqlCommand(stQuery, cnnDB)

        Command1.ExecuteNonQuery()
        cnnDB.Close()

        'Display a confermation msg that user is created
        MsgBox("Employee Details updated")


        Call Button_clear_Click(Button_clear, New System.EventArgs())

    End Sub
    Public Sub DefaultGridSettings(ByRef grid As DataGridView)
        With grid
            'Set the font for grid text
            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)

            'Set the font color
            .DefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

            'Set the grid back color
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 223, 221)

            'Set col headder height
            '.ColumnHeadersHeight = 40
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            'Set the grid row height
            .RowTemplate.Height = 18

            'Set word-rap true
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

            'Hide row headers
            .RowHeadersVisible = False

            'Set row properties 
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False

            'Set the edit mode to programatically
            .EditMode = DataGridViewEditMode.EditProgrammatically

            'Set back color as white
            .BackgroundColor = Color.White

            'Set Auto size colom mode to Displayed Rows
            '            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

            'Set the grid color
            .GridColor = Color.Gray
        End With
    End Sub
    Public Function prepad(ByVal no As String, ByVal length As Short) As String
        Dim i As Short

        For i = Len(no) To length - 1
            no = "0" & no
        Next

        prepad = no

    End Function
    Private Sub DataGridView_Search_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView_Search.DoubleClick
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim empname, stQuery As String
        txt_empid.Enabled = False
        If IsDBNull(DataGridView_Search.CurrentRow.Cells.Item(1).Value) Then
            Exit Sub
        End If

        empname = DataGridView_Search.CurrentRow.Cells.Item(1).Value


        stQuery = "Select* from sc_employee where st_name= '" & empname & "'"
        '  Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB
        cnnDB.Open()
        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()


        myReader.Read()
        txt_emp_name.Text = myReader.GetString(2)
        Cmbo_designation.Text = myReader.GetString(10)
        If myReader.GetValue(5) = "0" Then
            RadioButtonMale.Checked = True
        Else
            RadioButtonFemale.Checked = True
        End If
        txt_empid.Text = myReader.GetString(1)
        maskedtxtage.Text = myReader.GetValue(7)
        MaskedTextBoxMobileNo.Text = myReader.GetString(3)
        TextBoxAddr.Text = myReader.GetString(11)
        txt_rate.Text = myReader.GetValue(8)
        If Not IsDBNull(myReader.GetString(4)) Then
            MaskedTextBoxMobileNo2.Text = myReader.GetString(4)
        Else
            MaskedTextBoxMobileNo2.Text = ""
        End If
        Txt_mailid.Text = myReader.GetString(6)
        myReader.Close()
        cnnDB.Close()
    End Sub

    Private Sub txt_emp_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_emp_name.Leave
        txt_emp_name.Text = UCase(txt_emp_name.Text)
    End Sub

    Private Sub Cmbo_designation_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbo_designation.Leave
        Cmbo_designation.Text = UCase(Cmbo_designation.Text)
    End Sub

    Private Sub Txt_emp_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_emp_search.Click
        Txt_emp_search.Text = ""
        'DataGridView_Search.
    End Sub

End Class