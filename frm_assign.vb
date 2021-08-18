Option Strict Off
Option Explicit Off
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Text
Imports System.Threading
Imports System.IO
Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32


Imports MySql.Data
Imports MySql.Data.MySqlClient


Friend Class frm_assign
    Inherits System.Windows.Forms.Form
    Dim close_flag As Boolean
    Dim stQuery As String
    Dim tab As New DataTable("Search")
    Dim stQuery11 As String
    Dim cnnDB As SqlClient.SqlConnection

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader

   


    Private Sub frm_assign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        cnnDB.Open()
        stQuery = "SELECT st_expertise FROM sc_cmp_assign ORDER BY st_expertise"


        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        
        myReader = cmd2.ExecuteReader()



        While myReader.Read
            cmb_exp.Items.Add(myReader.GetString(0))
        End While

        myReader.Close()
        '' myReader.Close()
        stQuery2 = "SELECT st_name FROM sc_employee ORDER BY st_name"


        Dim cmd3 As New MySqlCommand(stQuery2, cnnDB)


        myReader1 = cmd3.ExecuteReader()



        While myReader1.Read
            Txt_empname.Items.Add(myReader1.GetString(0))
        End While
        myReader1.Close()
        myReader.Close()
        cnnDB.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clear.Click
        txt_cusname.Text = ""
        txt_proname.Text = ""
        txt_slno.Text = ""
        Txt_empname.Text = ""
        cmb_status.Text = ""
        cmb_exp.Text = ""
        Txt_cmpid.Text = ""


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click



        Dim myconnectionstring As String
        myConnectionString = "server=localhost;" _
                   & "database=Support_db;" _
                   & "uid=root;" _
                   & "pwd=support;" _
                   & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        cnnDB.Open()
        Call DataGridViewAssign_init(DataGridViewAssign, tab)
        ''cnnDB.Open()
        stQuery = "Select * from sc_complaint_register where ch_status = '0'"



        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)

        myReader = cmd2.ExecuteReader()

        If myReader.HasRows = False Then
            MsgBox("No Records found")
            Exit Sub
        Else

            tab.Clear()
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
                Dim empname As String = ""
                If Not getassigendinfo(empname, myReader.GetValue(0)) Then
                    row("Employee Name") = empname
                Else
                    row("Employee Name") = "Not Assigned"
                End If


                tab.Rows.Add(row)
            End While

        End If
        myReader.Close()
        cnnDB.Close()
    End Sub
    Public Function getassigendinfo(ByRef empname As String, ByVal stPreName As String)

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim myReader10 As MySqlDataReader

        Try

            getassigendinfo = False

            cnnDB.Open()



            Dim stQuery As String
            stQuery = "SELECT *  FROM sc_cmp_assign WHERE st_cmp_id = '" & Trim(stPreName) & "'"

            Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
           

            myReader10 = cmd2.ExecuteReader()

            If myReader10.HasRows = False Then
                myReader10.Close()
                Exit Function
            End If

            myReader10.Read()
            empname = myReader10.GetValue(4)
            myReader10.Close()

            getassigendinfo = True

        Catch ex As Exception
            MsgBox(ex.Message)
            'Do nothing as the error is taken care at calling place
        End Try

        cnnDB.Close()
    End Function
    Public Function getassigenddate(ByRef assdate As Date, ByVal stPreName As String)

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        Dim myReader10 As MySqlDataReader

        Try

            getassigenddate = False

            cnnDB.Open()

            Dim stQuery As String
            stQuery = "SELECT *  FROM sc_cmp_assign WHERE st_cmp_id = '" & Trim(stPreName) & "'"


            Dim cmd2 As New MySqlCommand(stQuery, cnnDB)



            myReader10 = cmd2.ExecuteReader()


            If myReader10.HasRows = False Then
                myReader10.Close()
                Exit Function
            End If

            myReader10.Read()
            assdate = myReader10.GetDateTime(8)
            myReader10.Close()

            getassigenddate = True

        Catch ex As Exception
            MsgBox(ex.Message)
            'Do nothing as the error is taken care at calling place
        End Try
        cnnDB.Close()

    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        Dim empname As String = ""
        If CheckBoxOpen.Checked <> False Or CheckBoxClose.Checked <> False Then
            cnnDB.Open()
            Call DataGridViewAssign_init(DataGridViewAssign, tab)
            If CheckBoxOpen.Checked = True Then
                stQuery = "Select * from sc_complaint_register where si_cmp_date  <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND si_cmp_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND ch_status = '1'"

                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)

                
                myReader = cmd2.ExecuteReader()
                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                Else

                    tab.Clear()
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


                        If Not getassigendinfo(empname, myReader.GetValue(0)) Then
                            row("Employee Name") = "Not Assigned"
                        Else
                            row("Employee Name") = empname
                        End If
                        Dim assdate As Date
                        If Not getassigenddate(assdate, myReader.GetValue(0)) Then
                            row("Assigned Date") = "Not Assigned"
                        Else
                            row("Assigned Date") = Format(assdate, "dd-MM-yyyy")
                        End If


                        tab.Rows.Add(row)
                    End While
                End If
            ElseIf CheckBoxClose.Checked = True Then
                stQuery = "Select * from sc_complaint_register where si_cmp_date  <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND si_cmp_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND ch_status = '0'"

                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
               

                myReader3 = cmd2.ExecuteReader()

                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                Else
                    tab.Clear()
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


                        If Not getassigendinfo(empname, myReader.GetValue(0)) Then
                            row("Employee Name") = empname
                        Else
                            row("Employee Name") = "Not Assigned"
                        End If


                        tab.Rows.Add(row)
                    End While

                End If
            End If
        Else
            MsgBox("Please check whether open complaints or closed clomplaints")
            Exit Sub
        End If
        myReader.Close()
        cnnDB.Close()

    End Sub
    Public Function DataGridViewAssign_Init(ByRef grid As DataGridView, ByRef tab As DataTable)

        Dim ColWidth As Short

        grid.DataSource = tab

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
        tab.Columns.Add("Employee Name")
        tab.Columns.Add("Assigned Date")



        With grid
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
            .Columns("Employee Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '' tab.Columns.Add("Assigned Date
            .Columns("Assigned Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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
            .Columns("Assigned Date").Width = 80

            .Columns("Employee Name").Width = 80


            'Set Only vertical scrollbar
            .ScrollBars = ScrollBars.Both
        End With
        grid.Columns("Complaint ID").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Customer Name").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Serial No").SortMode = DataGridViewColumnSortMode.NotSortable

        grid.Columns("Product Name").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Product Type").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Product Issue").SortMode = DataGridViewColumnSortMode.NotSortable

        grid.Columns("Cont. No").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Address").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Status").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Complained Date").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Purchased Date").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Alternative Mobile Numb").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Employee Name").SortMode = DataGridViewColumnSortMode.NotSortable

        grid.Columns("Assigned Date").SortMode = DataGridViewColumnSortMode.NotSortable


        'Call function to set all look and feel parameters of the grid
        Call DefaultGridSettings(grid)

        'Add 1 blank row
        Dim row As DataRow

        row = tab.NewRow()
        tab.Rows.Add(row)

    End Function
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Call DataGridViewAssign_init(DataGridViewAssign, tab)
        cnnDB.Open()
        stQuery = "Select * from sc_complaint_register where ch_status = '1'"

        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)


        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB
        '' cnnDB.Open()
        myReader = cmd2.ExecuteReader()

        If myReader.HasRows = False Then
            MsgBox("No Records found")
            Exit Sub
        Else
            tab.Clear()
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


                If Not getassigendinfo(empname, myReader.GetValue(0)) Then
                    row("Employee Name") = empname
                Else
                    row("Employee Name") = "Not Assigned"
                End If


                tab.Rows.Add(row)
            End While

        End If
        myReader.Close()
        cnnDB.Close()
    End Sub

    Private Sub DataGridViewAssign_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewAssign.DoubleClick

        Txt_cmpid.Enabled = False
        If IsDBNull(DataGridViewAssign.CurrentRow.Cells.Item(1).Value) Then
            Exit Sub
        End If

        Txt_cmpid.Text = DataGridViewAssign.CurrentRow.Cells.Item(0).Value


        Txt_empname.Text = DataGridViewAssign.CurrentRow.Cells.Item(12).Value
        txt_cusname.Text = DataGridViewAssign.CurrentRow.Cells.Item(1).Value
        cmb_status.Text = DataGridViewAssign.CurrentRow.Cells.Item(8).Value

        txt_proname.Text = DataGridViewAssign.CurrentRow.Cells.Item(3).Value
        txt_slno.Text = DataGridViewAssign.CurrentRow.Cells.Item(2).Value


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myConnectionString As String
        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        ' cnnDB.ConnectionString = "server=localhost;uid=root;pwd=support;database=Support_db;"
        'cnnDB.ConnectionString = myConnectionString
        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim cmp_id As String = ""
        Dim cmpname As String = ""
        Dim empname As String = ""
        Dim empexpertise As String = ""
        Dim assign_id As String = ""

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


        'Is the Name entered
        If Trim(Txt_empname.Text) = "" Then
            MsgBox("Please enter the problem")
            Txt_empname.Focus()
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

        If Trim(cmb_exp.Text) = "" Then
            MsgBox("Please enter Expertise")
            txt_slno.Focus()
            Exit Sub
        End If

        Dim stQuery As String

        cmpname = Replace(Trim(txt_cusname.Text), "\", "\\")
        cmpname = Replace(cmpname, "'", "''")

        empname = Replace(Trim(Txt_empname.Text), "\", "\\")
        empname = Replace(empname, "'", "''")

        expertise = Replace(Trim(cmb_exp.Text), "\", "\\")
        expertise = Replace(expertise, "'", "''")

        proname = Replace(txt_proname.Text, "\", "\\")
        proname = Replace(proname, "'", "''")

        serailno = Replace(txt_slno.Text, "\", "\\")
        serailno = Replace(serailno, "'", "''")

        cmp_id = Replace(Txt_cmpid.Text, "\", "\\")
        cmp_id = Replace(cmp_id, "'", "''")



        Dim stat As Short

        If cmb_status.Text = "open" Then
            stat = 1
        Else
            stat = 0
        End If

        Dim as_id As String = ""
        If Not getCmpAssignedId(as_id) Then
            MsgBox("Error Fetching Assigned Number")
            Exit Sub
        End If


        cnnDB.Open()
        stQuery = "insert into sc_cmp_assign values('" & as_id & "','" & cmp_id & "','" & cmpname & _
                                                      "','" & proname & "','" & empname & "','" & expertise & _
                                                    "','" & serailno & "' ,'" & cmb_status.Text & _
                                             "','" & Format(DateTimePickerAssDate.Value, "yyyy-MM-dd") & "','" & stat & "')"
        'Dim cmd8 As MySqlCommand = New MySqlCommand
        'cmd8 = New MySqlCommand(stQuery, cnnDB)
        'cnnDB.Open()


        'cmd8.ExecuteNonQuery()
        'cnnDB.Close()

        Dim Command As New MySqlCommand(stQuery, cnnDB)
        Dim rd As MySqlDataReader
        rd = Command.ExecuteReader()

        'Display a confermation msg that user is created
        MsgBox("ASSIGNED SUCCESSFULLY")
        cnnDB.Close()

        Call Button2_Click(Button_clear, New System.EventArgs())
    End Sub
    Public Function getCmpAssignedId(ByRef assign_id As String) As Boolean
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        getCmpAssignedId = False
        Dim stquery As String = ""
        Dim ass_cur_no As String
        Dim ass_curr As String
        Dim YYYMM As String
        Dim month As String
        Dim ym As String
        Dim pre As String
        Dim ass_exist_no As String
        YYYMM = readSettingIdValue(9)
        month = readSettingIdValue(10)
        pre = readSettingIdValue(12)

        am = YYYMM & month

        ass_exist_no = readSettingIdValue(11)


        If ass_exist_no <> "ERROR" Then
            ass_cur_no = prepad(ass_exist_no + 1, 7)

            assign_id = pre & am & ass_cur_no

            getCmpAssignedId = True
        Else
            Exit Function
        End If
        cnnDB.Open()
        stquery = "update sc_setting set st_value = '" & ass_cur_no & "' where si_setting_id='11'"

        'Dim cmd7 As MySqlCommand = New MySqlCommand
        'cmd7.CommandText = stquery
        'cmd7.Connection = cnnDB
        'cnnDB.Open()
        'cmd7.ExecuteNonQuery()

        Dim Command1 As New MySqlCommand(stquery, cnnDB)

        Command1.ExecuteNonQuery()
        cnnDB.Close()

    End Function
    Public Function prepad(ByVal no As String, ByVal length As Short) As String
        Dim i As Short

        For i = Len(no) To length - 1
            no = "0" & no
        Next

        prepad = no

    End Function
    Public Function readSettingIdValue(ByVal settingId As Short) As String
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        Dim stQuery As String

        readSettingIdValue = "ERROR"

        Dim myReader1 As MySqlDataReader = Nothing

        'Read the Value for the setting ID
        cnnDB.Open()
        stQuery = "SELECT st_value FROM sc_setting WHERE si_setting_id = " & settingId

        ' Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB
        ' cnnDB.Open()
        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader1 = cmd2.ExecuteReader()
        If myReader1.HasRows = False Then
            myReader1.Close()
            Exit Function
        End If

        myReader1.Read()
        If Not IsDBNull(myReader1.GetValue(0)) Then
            readSettingIdValue = myReader1.GetString(0)
        End If

        myReader1.Close()
        cnnDB.Close()
    End Function

    Private Sub Txt_cmpid_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_cmpid.Leave
        Txt_cmpid.Text = UCase(Txt_cmpid.Text)
    End Sub

    Private Sub Txt_empname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txt_empname.Text = UCase(Txt_empname.Text)
    End Sub

    Private Sub cmb_exp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_exp.Leave
        cmb_exp.Text = UCase(cmb_exp.Text)
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myConnectionString As String
        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        ' cnnDB.ConnectionString = "server=localhost;uid=root;pwd=support;database=Support_db;"
        'cnnDB.ConnectionString = myConnectionString
        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim cmp_id As String = ""
        Dim cmpname As String = ""
        Dim empname As String = ""
        Dim empexpertise As String = ""
        Dim assign_id As String = ""

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


        'Is the Name entered
        If Trim(Txt_empname.Text) = "" Then
            MsgBox("Please enter the problem")
            Txt_empname.Focus()
            Exit Sub
        End If

        ''Is the Mobile Number entered
        'If Trim(txt_proname.Text) = "" Then
        '    MsgBox("Please enter product name")
        '    txt_proname.Focus()
        '    Exit Sub
        'End If

        'Is the Mobile Number entered
        'If Trim(Txt_empname.Text) = "" Then
        '    MsgBox("Please enter employee name")
        '    Txt_empname.Focus()
        '    Exit Sub
        'End If
        ''Is the Mobile Number entered
        'If Trim(txt_slno.Text) = "" Then
        '    MsgBox("Please enter serial num")
        '    txt_slno.Focus()
        '    Exit Sub
        'End If

        If Trim(cmb_exp.Text) = "" Then
            MsgBox("Please enter Expertise")
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

        cmp_id = Replace(Txt_cmpid.Text, "\", "\\")
        cmp_id = Replace(cmp_id, "'", "''")

        empname = Replace(Txt_empname.Text, "\", "\\")
        empname = Replace(empname, "'", "''")




        Dim stat As Short

        If cmb_status.Text = "open" Then
            stat = 1
        Else
            stat = 0
        End If

        cnnDB.Open()
        stQuery = "update sc_cmp_assign set st_cust_name = '" & cmpname & "',st_pro_name='" & proname & "',st_emp_name='" & empname & _
                                                "',st_expertise='" & empexpertise & "',st_serail_id='" & serailno & _
                                                  "', ch_status_ep='" & cmb_status.Text & _
                                             "',si_assign_date='" & Format(DateTimePickerAssDate.Value, "yyyy-MM-dd") & _
                                             "',ch_status='" & stat & "' where st_cmp_id= '" & Txt_cmpid.Text & "'"

        Dim Command1 As New MySqlCommand(stQuery, cnnDB)

        Command1.ExecuteNonQuery()
        cnnDB.Close()


        cnnDB.Open()
        stQuery = "update sc_complaint_register set ch_status_ep='" & cmb_status.Text & "' where st_cmp_id= '" & Txt_cmpid.Text & "'"

        Dim Command2 As New MySqlCommand(stQuery, cnnDB)

        Command2.ExecuteNonQuery()
        cnnDB.Close()

        cnnDB.Open()
        stQuery = "update sc_complaint_register set ch_status='0' where st_cmp_id= '" & Txt_cmpid.Text & "'"

        Dim Command3 As New MySqlCommand(stQuery, cnnDB)

        Command3.ExecuteNonQuery()
        cnnDB.Close()
        'Display a confermation msg that user is created
        MsgBox("Deatils Updated Successfully")


        Call Button2_Click(Button_clear, New System.EventArgs())
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'clear the textboxes
        frm_login.txt_user.Text = ""
        frm_login.txt_pws.Text = ""
        frm_login.Show()
        Me.Hide()
    End Sub
End Class