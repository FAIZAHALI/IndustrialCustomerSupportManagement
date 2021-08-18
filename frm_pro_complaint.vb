Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Text
Imports System.Threading
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Friend Class frm_pro_complaint
    Inherits System.Windows.Forms.Form
    Dim WithEvents ComPort As New System.IO.Ports.SerialPort
    Dim close_flag As Boolean
    Dim stQuery As String
    Dim tab As New DataTable("Search")
    Dim cnnDB As SqlClient.SqlConnection

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader

    Private Sub Button_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_back.Click
        frm_main.Show()
        Me.Hide()
    End Sub

    Private Sub Button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clear.Click
        txt_cusname.Text = ""
        txt_proname.Text = ""
        txt_slno.Text = ""
        Txtpro.Text = ""
        TextBoxAddr.Text = ""
        cmb_status.Text = ""
        Cmb_type.Text = ""
        MaskedTextBoxMobileNo.Text = ""
        MaskedTextBoxMobileNo2.Text = ""

    End Sub

    Private Sub txt_cusname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cusname.Leave
        txt_cusname.Text = UCase(txt_cusname.Text)
    End Sub

    Private Sub Cmb_type_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_type.Leave
        Cmb_type.Text = UCase(Cmb_type.Text)
    End Sub

    Private Sub txt_slno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_slno.Leave
        txt_slno.Text = UCase(txt_slno.Text)
    End Sub

    Private Sub txt_proname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_proname.Leave
        txt_proname.Text = UCase(txt_proname.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim cmp_id As String = ""
        Dim cmpname As String = ""
        Dim protype As String
        Dim proname As String
        Dim problem As String = ""
        Dim mob, mob1 As String



        Dim address, serailno, UsrNameEscStr As String


        'Is the User name entered
        If Trim(txt_cusname.Text) = "" Then
            MsgBox("Please enter customer Name")
            txt_cusname.Focus()
            Exit Sub
        End If

        'Is the status selected
        If Trim(cmb_status.Text) = "" Then
            MsgBox("select the status")
            cmb_status.Focus()
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


        'Is the Name entered
        If Trim(Txtpro.Text) = "" Then
            MsgBox("Please enter the problem")
            Txtpro.Focus()
            Exit Sub
        End If

        'Is the Mobile Number entered
        If Trim(txt_proname.Text) = "" Then
            MsgBox("Please enter product name")
            txt_proname.Focus()
            Exit Sub
        End If


        'Is the Mobile Number entered
        If Trim(txt_slno.Text) = "" Then
            MsgBox("Please enter serial num")
            txt_slno.Focus()
            Exit Sub
        End If

        Dim stQuery As String

        cmpname = Replace(Trim(txt_cusname.Text), "\", "\\")
        cmpname = Replace(cmpname, "'", "''")

        proname = Replace(txt_proname.Text, "\", "\\")
        proname = Replace(proname, "'", "''")

        serailno = Replace(txt_slno.Text, "\", "\\")
        serailno = Replace(serailno, "'", "''")

        mob = MaskedTextBoxMobileNo.Text

        protype = Cmb_type.Text

        address = Replace(Trim(TextBoxAddr.Text), "\", "\\")
        address = Replace(address, "'", "''")

        problem = Replace(Trim(Txtpro.Text), "\", "\\")
        problem = Replace(problem, "'", "''")

        Dim flg_gen As Short

        If cmb_status.Text = "open" Then
            flg_gen = 1
        Else
            flg_gen = 0
        End If

        Dim emp_no As String = ""
        If Not getcomplaintId(cmp_id) Then
            MsgBox("Error Fetching complaint Reference No")
        End If


        cnnDB.Open()
        stQuery = "insert into sc_complaint_register values('" & cmp_id & "','" & cmpname & "','" & proname & _
                                                      "','" & protype & "','" & serailno & "','" & MaskedTextBoxMobileNo2.Text & _
                                                    "','" & MaskedTextBoxMobileNo.Text & "' ,'" & cmb_status.Text & _
                                             "','" & problem & "','" & Format(DateTimePickerPurDate.Value, "yyyy-MM-dd") & _
                                             "','" & Format(Today.Date, "yyyy-MM-dd") & "','" & flg_gen & "','" & address & "')"


        Dim Command As New MySqlCommand(stQuery, cnnDB)
        Dim rd As MySqlDataReader
        rd = Command.ExecuteReader()

        'Display a confermation msg that user is created
        MsgBox("REGISTERED COMPLAINT SUCCESSFULLY " & vbNewLine & vbNewLine & "Customer Name" & vbTab & _
               ":" & txt_cusname.Text & vbTab & vbNewLine & "Complaint ID" & vbTab & _
               vbTab & ":" & cmp_id & vbTab & vbNewLine)


        Call Button_clear_Click(Button_clear, New System.EventArgs())
    End Sub
    Public Function getcomplaintId(ByRef cmp_id As String) As Boolean
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        getcomplaintId = False
        Dim stquery As String = ""
        Dim st_bill_no As String
        Dim cmp_cur_no As String
        Dim cmp_curr As String
        Dim YYYMM As String
        Dim month As String
        Dim ym As String
        Dim pre As String
        Dim cmp_exist_no As String

        Dim stquery4, stquery5, stquery6 As String


        Dim myReader3 As MySqlDataReader = Nothing
        Dim myReader6 As MySqlDataReader = Nothing

        cnnDB.Open()
        'Read the Value for the setting ID
        stquery = "SELECT st_value FROM sc_setting WHERE si_setting_id = '" & 5 & "'"
        ' Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB

        Dim cmd2 As New MySqlCommand(stquery, cnnDB)
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
        stquery4 = "SELECT st_value FROM sc_setting WHERE si_setting_id = '" & 6 & "'"
        'Dim cmd3 As MySqlCommand = New MySqlCommand

        'cmd3.CommandText = stquery4
        'cmd3.Connection = cnnDB
        'cnnDB.Open()
        Dim cmd3 As New MySqlCommand(stquery4, cnnDB)
        myReader4 = cmd3.ExecuteReader()

        If myReader4.HasRows = False Then
            myReader4.Close()
            Exit Function
        End If

        myReader4.Read()
        If Not IsDBNull(myReader4.GetValue(0)) Then
            month = myReader4.GetString(0)
        End If

        myReader4.Close()
        'cnnDB.Close()


        ' month = readSettingIdValue(2)
        pre = "CP"

        ym = YYYMM & month

        'Read the Value for the setting ID
        stquery6 = "SELECT st_value FROM sc_setting WHERE si_setting_id = '" & 7 & "'"
        Dim cmd6 As New MySqlCommand(stquery6, cnnDB)

        myReader6 = cmd6.ExecuteReader()

        If myReader6.HasRows = False Then
            myReader6.Close()
            Exit Function
        End If

        myReader6.Read()
        If Not IsDBNull(myReader6.GetValue(0)) Then
            cmp_exist_no = myReader6.GetString(0)
        End If

        myReader6.Close()
        '; cnnDB.Close()


        If cmp_exist_no <> "ERROR" Then
            cmp_cur_no = prepad(cmp_exist_no + 1, 7)

            cmp_id = pre & ym & cmp_cur_no

            getcomplaintId = True
        Else
            Exit Function
        End If

        stquery = "update sc_setting set st_value = '" & cmp_cur_no & "' where si_setting_id='7'"

        Dim Command1 As New MySqlCommand(stquery, cnnDB)

        Command1.ExecuteNonQuery()
        cnnDB.Close()











    End Function

    Private Sub frm_pro_complaint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim surverIp As String = "localhost"
        Dim dbPassword As String = "f18K0972fn05ti09rn2"
        Dim port As String = "5432"
        Dim dbname As String = "Support_db"


        'cnnDB.ConnectionString = "SERVER=" & surverIp & ";DATABASE= " & dbname & _
        '                             ";USER ID=postgres;PASSWORD=" & dbPassword & _
        '                             ";Preload Reader = True;PORT= " & port

        cnnDB.ConnectionString = myConnectionString

        stQuery = "SELECT st_pro_type FROM sc_complaint_register ORDER BY st_pro_type"

        ' Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB
        cnnDB.Open()
        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()



        While myReader.Read
            Cmb_type.Items.Add(myReader.GetString(0))
        End While

        myReader.Close()
        cnnDB.Close()


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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        If RadioButtonCusname.Checked <> False Or RadioButtonMobNo.Checked <> False Or RadioButtonSerial.Checked <> False Then
            If TextBoxSearch.Text <> "" Then
                DataGridViewCompSearch.DataSource = tab

                'Clear the grid
                tab.Columns.Clear()

                'Add Columns to search grid
                tab.Columns.Add("Complaint ID")
                tab.Columns.Add("Customer Name")
                tab.Columns.Add("Serial No")
                tab.Columns.Add("Product Name")
                tab.Columns.Add("Product Type")
                tab.Columns.Add("Product Issue")
                tab.Columns.Add("Cont. No")
                tab.Columns.Add("Address")
                tab.Columns.Add("Status")
                tab.Columns.Add("Complained Date")
                tab.Columns.Add("Purchased Date")
                tab.Columns.Add("Alternative Mobile Numb")

                With DataGridViewCompSearch
                    'Setting the columns Alignment
                    .Columns("Complaint ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns("Customer Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns("Serial No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns("Product Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Product Type").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Product Issue").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Cont. No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Address").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Complained Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Purchased Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("Alternative Mobile Numb").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                    'Setting the columns Width
                    .Columns("Complaint ID").Width = 60
                    .Columns("Customer Name").Width = 70
                    .Columns("Serial No").Width = 70
                    .Columns("Product Name").Width = 70

                    .Columns("Product Type").Width = 70
                    .Columns("Product Issue").Width = 70
                    .Columns("Cont. No").Width = 80
                    .Columns("Address").Width = 70
                    .Columns("Status").Width = 70
                    .Columns("Complained Date").Width = 70
                    .Columns("Purchased Date").Width = 80
                    .Columns("Alternative Mobile Numb").Width = 80

                    'Set Only vertical scrollbar
                    .ScrollBars = ScrollBars.Both
                End With
                DataGridViewCompSearch.Columns("Complaint ID").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Customer Name").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Serial No").SortMode = DataGridViewColumnSortMode.NotSortable

                DataGridViewCompSearch.Columns("Product Name").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Product Type").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Product Issue").SortMode = DataGridViewColumnSortMode.NotSortable

                DataGridViewCompSearch.Columns("Cont. No").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Address").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Status").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Complained Date").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Purchased Date").SortMode = DataGridViewColumnSortMode.NotSortable
                DataGridViewCompSearch.Columns("Alternative Mobile Numb").SortMode = DataGridViewColumnSortMode.NotSortable


                'Call function to set all look and feel parameters of the grid
                Call DefaultGridSettings(DataGridViewCompSearch)

                'Add 1 blank row
                Dim row As DataRow

                row = tab.NewRow()
                tab.Rows.Add(row)
            Else
                MsgBox("Please select employee name or id or Mobile Number")
                Exit Sub
            End If
        End If
        Dim stquery As String
        If RadioButtonSerial.Checked = True Then
            cnnDB.Open()
            stquery = "Select * from sc_complaint_register where st_serail_id like '%" & TextBoxSearch.Text & "%'"

            'Dim cnnDB As New MySqlConnection(myConnectionString)

            ' cmd2.CommandText = stQuery
            ' cmd2.Connection = cnnDB

            Dim cmd2 As New MySqlCommand(stquery, cnnDB)
            myReader = cmd2.ExecuteReader()
            '' cnnDB.Close()
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
                    row("Complaint ID") = myReader.GetString(0)

                    row("Customer Name") = myReader.GetString(1)
                    row("Product Type") = myReader.GetString(3)
                    row("Product Name") = myReader.GetString(2)
                    'If myReader.GetValue(5) = "0" Then
                    '    row("Gender") = "Male"
                    'Else
                    '    row("Gender") = "Female"
                    'End If
                    row("Status") = myReader.GetString(7)
                    row("Serial No") = myReader.GetValue(4)
                    row("Cont. No") = myReader.GetString(6)
                    row("Address") = myReader.GetString(12)
                    row("Product Issue") = myReader.GetValue(8)
                    If Not IsDBNull(myReader.GetString(5)) Then
                        row("Alternative Mobile Numb") = myReader.GetString(5)
                    Else
                        row("Alternative Mobile Numb") = ""
                    End If
                    row("Purchased Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")
                    row("Complained Date") = Format(myReader.GetDateTime(10), "dd-MM-yyyy")


                    tab.Rows.Add(row)
                End While
            End If
        ElseIf RadioButtonMobNo.Checked = True Then
            cnnDB.Open()
            stquery = "Select * from sc_complaint_register where st_mob_no like '%" & TextBoxSearch.Text & "%'"

            ' Dim cnnDB As New MySqlConnection(myConnectionString)

            ' cmd2.CommandText = stQuery
            ' cmd2.Connection = cnnDB

            Dim cmd2 As New MySqlCommand(stquery, cnnDB)
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
                    row("Complaint ID") = myReader.GetString(0)

                    row("Customer Name") = myReader.GetString(1)
                    row("Product Type") = myReader.GetString(3)
                    row("Product Name") = myReader.GetString(2)
                    'If myReader.GetValue(5) = "0" Then
                    '    row("Gender") = "Male"
                    'Else
                    '    row("Gender") = "Female"
                    'End If
                    row("Status") = myReader.GetString(7)
                    row("Serial No") = myReader.GetValue(4)
                    row("Cont. No") = myReader.GetString(6)
                    row("Address") = myReader.GetString(12)
                    row("Product Issue") = myReader.GetValue(8)
                    If Not IsDBNull(myReader.GetString(5)) Then
                        row("Alternative Mobile Numb") = myReader.GetString(5)
                    Else
                        row("Alternative Mobile Numb") = ""
                    End If
                    row("Purchased Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")
                    row("Complained Date") = Format(myReader.GetDateTime(10), "dd-MM-yyyy")


                    tab.Rows.Add(row)
                End While
            End If

        ElseIf RadioButtonCusname.Checked = True Then
            cnnDB.Open()
            stquery = "Select * from sc_complaint_register where st_cust_name like '%" & TextBoxSearch.Text & "%'"

            ' Dim cnnDB As New MySqlConnection(myConnectionString)

            ' cmd2.CommandText = stQuery
            ' cmd2.Connection = cnnDB

            Dim cmd2 As New MySqlCommand(stquery, cnnDB)
            myReader = cmd2.ExecuteReader()
            'cnnDB.Close()
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
                    row("Complaint ID") = myReader.GetValue(0)

                    row("Customer Name") = myReader.GetString(1)
                    row("Product Type") = myReader.GetString(3)
                    row("Product Name") = myReader.GetString(2)
                    row("Status") = myReader.GetValue(7)
                    row("Serial No") = myReader.GetValue(4)
                    row("Cont. No") = myReader.GetString(6)
                    row("Address") = myReader.GetString(12)
                    row("Product Issue") = myReader.GetValue(8)
                    If Not IsDBNull(myReader.GetString(5)) Then
                        row("Alternative Mobile Numb") = myReader.GetString(5)
                    Else
                        row("Alternative Mobile Numb") = ""
                    End If
                    row("Purchased Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")
                    row("Complained Date") = Format(myReader.GetDateTime(10), "dd-MM-yyyy")


                    tab.Rows.Add(row)
                End While
            End If
        End If
        myReader.Close()
        cnnDB.Close()
    End Sub


    Private Sub TextBoxSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSearch.Leave
        TextBoxSearch.Text = UCase(TextBoxSearch.Text)
    End Sub

    Private Sub TextBoxSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSearch.Click
        TextBoxSearch.Text = ""
    End Sub


End Class