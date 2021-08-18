Option Strict Off
Option Explicit On
Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Friend Class frm_datareports
    Inherits System.Windows.Forms.Form
    Dim WithEvents comport As New System.IO.Ports.SerialPort
    Dim close_flag As Boolean
    Dim tab As New DataTable("Search")
    Dim stQuery As String
    Dim cnnDB As SqlClient.SqlConnection

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader
    Dim row As DataRow
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
    Public Function DataGridView_Init_Search(ByRef grid As DataGridView, ByRef tab As DataTable)

        Dim ColWidth As Short

        grid.DataSource = tab

        'Clear the grid
        tab.Columns.Clear()

        'Add Columns to search grid
        tab.Columns.Add("Employee Name")
        tab.Columns.Add("Designation")
        tab.Columns.Add("Gender")
        tab.Columns.Add("Employee ID")
        tab.Columns.Add("Cont. No")
        tab.Columns.Add("Age")
        tab.Columns.Add("Rate Per HR")
        tab.Columns.Add("Address")
        tab.Columns.Add("Alternative Mobile Numb")
        tab.Columns.Add("Employee No")
        tab.Columns.Add("Mail ID")


        With grid
            'Setting the columns Alignment
            .Columns("Age").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("Employee Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("Gender").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("Designation").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Cont. No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Mail ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Address").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Rate Per Hr").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Employee ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Employee No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            'Setting the columns Width
            .Columns("Age").Width = 60
            .Columns("Employee Name").Width = 70
            .Columns("Gender").Width = 70
            .Columns("Designation").Width = 70

            .Columns("Address").Width = 70
            .Columns("Employee ID").Width = 70
            .Columns("Cont. No").Width = 80
            .Columns("Address").Width = 70
            .Columns("Mail ID").Width = 70
            .Columns("Rate Per Hr").Width = 70
            '.Columns("Purchased Date").Width = 80
            .Columns("Alternative Mobile Numb").Width = 80

            .Columns("Employee No").Width = 80


            'Set Only vertical scrollbar
            .ScrollBars = ScrollBars.Both
        End With
        grid.Columns("Employee ID").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Employee Name").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Age").SortMode = DataGridViewColumnSortMode.NotSortable

        grid.Columns("Designation").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Gender").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Designation").SortMode = DataGridViewColumnSortMode.NotSortable

        grid.Columns("Cont. No").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Address").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Rate Per Hr").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Mail ID").SortMode = DataGridViewColumnSortMode.NotSortable
        'grid.Columns("Purchased Date").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Alternative Mobile Numb").SortMode = DataGridViewColumnSortMode.NotSortable
        grid.Columns("Employee No").SortMode = DataGridViewColumnSortMode.NotSortable



        'Call function to set all look and feel parameters of the grid
        Call DefaultGridSettings(grid)

        'Add 1 blank row
        Dim row As DataRow

        row = tab.NewRow()
        tab.Rows.Add(row)

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        'If CheckBoxbtw.Checked = False Or CheckBoxall.Checked = False Then
        '    MsgBox("Check any box to generate a report")
        '    Exit Sub
        'End If

        If ComboBoxtype.Text = "" Then
            MsgBox("Select a report type")
            Exit Sub
        End If
        cnnDB.Open()

        If ComboBoxtype.Text = "Employee Details" Then
            Call DataGridView_Init_Search(DataGridViewdataRep, tab)

            If CheckBoxbtw.Checked = True Then

                stQuery = "Select * from sc_employee where dt_reg_date <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND dt_reg_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND ch_status = '1' order by dt_reg_date"
                '  Dim cnnDB As New MySqlConnection(myConnectionString)

                ' cmd2.CommandText = stQuery
                ' cmd2.Connection = cnnDB

                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
                myReader = cmd2.ExecuteReader()
                '' cnnDB.Close()
                tab.Clear()
                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                End If

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

            If CheckBoxall.Checked = True Then
                stQuery = "Select * from sc_employee where ch_status = '1' order by dt_reg_date"
                ' Dim cnnDB As New MySqlConnection(myConnectionString)

                ' cmd2.CommandText = stQuery
                ' cmd2.Connection = cnnDB
                ''  cnnDB.Open()
                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
                myReader = cmd2.ExecuteReader()
                '' cnnDB.Close()
                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                End If

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
        End If

        If ComboBoxtype.Text = "Closed Complaints" Then
            DataGridViewdataRep.DataSource = tab

            'Clear the grid
            tab.Columns.Clear()

            'Add Columns to search grid
            tab.Columns.Add("Complaint ID")
            tab.Columns.Add("Customer Name")
            tab.Columns.Add("Assigned ID")
            tab.Columns.Add("Product Name")
            tab.Columns.Add("Status")
            tab.Columns.Add("Serial No")
            tab.Columns.Add("Employee Name")
            tab.Columns.Add("Assigned Date")


            With DataGridViewdataRep
                'Setting the columns Alignment
                .Columns("Complaint ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("Customer Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("Product Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Serial No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Employee Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Assigned Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns("Complaint ID").Width = 70
                .Columns("Customer Name").Width = 70
                .Columns("Assigned ID").Width = 80
                .Columns("Product Name").Width = 70
                .Columns("Status").Width = 70
                .Columns("Serial No").Width = 70
                .Columns("Employee Name").Width = 80
                .Columns("Assigned Date").Width = 80

                'Set Only vertical scrollbar
                .ScrollBars = ScrollBars.Both
            End With
            DataGridViewdataRep.Columns("Complaint ID").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Customer Name").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Assigned ID").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Product Name").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Status").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Serial No").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Employee Name").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Assigned Date").SortMode = DataGridViewColumnSortMode.NotSortable


            'Call function to set all look and feel parameters of the grid
            Call DefaultGridSettings(DataGridViewdataRep)

            'Add 1 blank row
            Dim row As DataRow

            row = tab.NewRow()
            tab.Rows.Add(row)
            If CheckBoxbtw.Checked = True Then
                stQuery = "Select * from sc_cmp_assign where si_assign_date  <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND si_assign_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND ch_status = '0'"

                ' Dim cnnDB As New MySqlConnection(myConnectionString)

                ' cmd2.CommandText = stQuery
                ' cmd2.Connection = cnnDB
                ''  cnnDB.Open()
                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
                myReader = cmd2.ExecuteReader()
                ''  cnnDB.Close()

                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                End If
                tab.Clear()

                Dim q_count As Double
                While myReader.Read
                    q_count = q_count + 1

                    row = tab.NewRow()

                    'Populate DataGrid_search
                    row("Complaint ID") = myReader.GetString(0)

                    row("Customer Name") = myReader.GetString(1)
                    row("Assigned ID") = myReader.GetString(3)
                    row("Product Name") = myReader.GetString(2)
                    row("Status") = myReader.GetString(7)
                    row("Serial No") = myReader.GetValue(4)
                    row("Employee Name") = myReader.GetString(6)

                    row("Assigned Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")



                    tab.Rows.Add(row)
                End While

            End If
            If CheckBoxall.Checked = True Then


                stQuery = "Select * from sc_complaint_register where ch_status = '0' order by si_cmp_date "

                ' Dim cnnDB As New MySqlConnection(myConnectionString)

                ' cmd2.CommandText = stQuery
                ' cmd2.Connection = cnnDB
                '' cnnDB.Open()
                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
                myReader = cmd2.ExecuteReader()
                ''  cnnDB.Close()
                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                End If
                tab.Clear()
                Dim q_count As Double
                While myReader.Read
                    q_count = q_count + 1

                    row = tab.NewRow()
                    'Populate DataGrid_search
                    row("Complaint ID") = myReader.GetString(0)

                    row("Customer Name") = myReader.GetString(1)
                    row("Assigned ID") = myReader.GetString(3)
                    row("Product Name") = myReader.GetString(2)
                    row("Status") = myReader.GetString(7)
                    row("Serial No") = myReader.GetValue(4)
                    row("Employee Name") = myReader.GetString(6)

                    row("Assigned Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")

                    tab.Rows.Add(row)
                End While

            End If
        End If


        If ComboBoxtype.Text = "Open Complaints" Then
            DataGridViewdataRep.DataSource = tab

            'Clear the grid
            tab.Columns.Clear()

            'Add Columns to search grid
            tab.Columns.Add("Complaint ID")
            tab.Columns.Add("Customer Name")
            tab.Columns.Add("Assigned ID")
            tab.Columns.Add("Product Name")
            tab.Columns.Add("Status")
            tab.Columns.Add("Serial No")
            tab.Columns.Add("Employee Name")
            tab.Columns.Add("Assigned Date")


            With DataGridViewdataRep
                'Setting the columns Alignment
                .Columns("Complaint ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("Customer Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("Product Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Serial No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns("Employee Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Assigned Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns("Complaint ID").Width = 70
                .Columns("Customer Name").Width = 70
                .Columns("Assigned ID").Width = 80
                .Columns("Product Name").Width = 70
                .Columns("Status").Width = 70
                .Columns("Serial No").Width = 70
                .Columns("Employee Name").Width = 80
                .Columns("Assigned Date").Width = 80

                'Set Only vertical scrollbar
                .ScrollBars = ScrollBars.Both
            End With
            DataGridViewdataRep.Columns("Complaint ID").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Customer Name").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Assigned ID").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Product Name").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Status").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Serial No").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Employee Name").SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridViewdataRep.Columns("Assigned Date").SortMode = DataGridViewColumnSortMode.NotSortable


            'Call function to set all look and feel parameters of the grid
            Call DefaultGridSettings(DataGridViewdataRep)

            'Add 1 blank row
            Dim row As DataRow

            row = tab.NewRow()
            tab.Rows.Add(row)
            If CheckBoxbtw.Checked = True Then
                stQuery = "Select * from sc_complaint_register where si_cmp_date  <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND si_cmp_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND ch_status = '1'"

                'Dim cnnDB As New MySqlConnection(myConnectionString)

                ' cmd2.CommandText = stQuery
                ' cmd2.Connection = cnnDB
                '' cnnDB.Open()
                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
                myReader = cmd2.ExecuteReader()
                '' cnnDB.Close()

                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                End If
                tab.Clear()

                Dim q_count As Double
                While myReader.Read
                    q_count = q_count + 1

                    row = tab.NewRow()

                    'Populate DataGrid_search
                    row("Complaint ID") = myReader.GetString(0)

                    row("Customer Name") = myReader.GetString(1)
                    row("Assigned ID") = myReader.GetString(3)
                    row("Product Name") = myReader.GetString(2)
                    row("Status") = myReader.GetString(7)
                    row("Serial No") = myReader.GetValue(4)
                    row("Employee Name") = myReader.GetString(6)

                    row("Assigned Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")

                    tab.Rows.Add(row)
                End While

            End If
            If CheckBoxall.Checked = True Then
                stQuery = "Select * from sc_complaint_register where ch_status = '1' order by si_cmp_date "

                ' Dim cnnDB As New MySqlConnection(myConnectionString)

                ' cmd2.CommandText = stQuery
                ' cmd2.Connection = cnnDB
                '' cnnDB.Open()
                Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
                myReader = cmd2.ExecuteReader()
                '' cnnDB.Close()

                If myReader.HasRows = False Then
                    MsgBox("No Records found")
                    Exit Sub
                Else
                    tab.Clear()

                    Dim q_count As Double
                    While myReader.Read
                        q_count = q_count + 1

                        row = tab.NewRow()
                        'Populate DataGrid_search
                        row("Complaint ID") = myReader.GetString(0)

                        row("Customer Name") = myReader.GetString(1)
                        row("Assigned ID") = myReader.GetString(3)
                        row("Product Name") = myReader.GetString(2)
                        row("Status") = myReader.GetString(7)
                        row("Serial No") = myReader.GetValue(4)
                        row("Employee Name") = myReader.GetString(6)

                        row("Assigned Date") = Format(myReader.GetDateTime(9), "dd-MM-yyyy")


                        tab.Rows.Add(row)
                    End While

                End If
            End If
        End If
        myReader.Close()
        cnnDB.Close()
    End Sub

    Private Sub CheckBoxbtw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxbtw.CheckedChanged
        CheckBoxall.Checked = False
    End Sub

    Private Sub CheckBoxall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxall.CheckedChanged
        CheckBoxbtw.Checked = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
        frm_main.Show()
        Me.Hide()
    End Sub

    Private Sub frm_datareports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim surverIp As String = "localhost"
        'Dim dbPassword As String = "f18K0972fn05ti09rn2"
        'Dim port As String = "5432"
        'Dim dbname As String = "Support_db"


        'cnnDB.ConnectionString = "SERVER=" & surverIp & ";DATABASE= " & dbname & _
        '                              ";USER ID=postgres;PASSWORD=" & dbPassword & _
        '                              ";Preload Reader = True;PORT= " & port
    End Sub
End Class