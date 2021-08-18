Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


Friend Class frm_View
    Inherits System.Windows.Forms.Form
    Dim close_flag As Boolean
    Dim stQuery As String
    Dim tab As New DataTable("Search")
    Dim stQuery11 As String
    Dim cnnDB As SqlClient.SqlConnection

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader
    Public Function DataGridViewAssign_Init(ByRef grid As DataGridView, ByRef tab As DataTable)

        DataGridView4.DataSource = tab

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


        With DataGridView4
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
        DataGridView4.Columns("Complaint ID").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Customer Name").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Assigned ID").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Product Name").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Status").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Serial No").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Employee Name").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView4.Columns("Assigned Date").SortMode = DataGridViewColumnSortMode.NotSortable


        'Call function to set all look and feel parameters of the grid
        Call DefaultGridSettings(DataGridView4)

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

        Dim empname As String = ""

        cnnDB.Open()
        Call DataGridViewAssign_Init(DataGridView4, tab)

        stQuery = "Select * from sc_cmp_assign where st_emp_name = '" & UCase(Txt_Curusr.Text) & "' and ch_status = '1'"

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
                row("Complaint ID") = myReader.GetString(1)
                row("Customer Name") = myReader.GetString(2)
                row("Product Name") = myReader.GetString(3)


                ''   row("Product Type") = myReader.GetString(3)

                row("Status") = myReader.GetString(7)
                row("Serial No") = myReader.GetValue(6)

                row("Assigned Date") = Format(myReader.GetDateTime(8), "dd-MM-yyyy")

                row("Employee Name") = myReader.GetString(4)

                row("Assigned ID") = myReader.GetValue(0)


                tab.Rows.Add(row)
            End While
        End If
       
        myReader.Close()
        cnnDB.Close()
    End Sub

   
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
            Call DataGridViewAssign_Init(DataGridView4, tab)
            If CheckBoxOpen.Checked = True Then
                stQuery = "Select * from sc_cmp_assign where si_assign_date  <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND si_assign_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND st_emp_name = '" & UCase(Txt_Curusr.Text) & "' and ch_status = '1'"

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
                        row("Complaint ID") = myReader.GetString(1)
                        row("Customer Name") = myReader.GetString(2)
                        row("Product Name") = myReader.GetString(3)


                        ''   row("Product Type") = myReader.GetString(3)

                        row("Status") = myReader.GetString(7)
                        row("Serial No") = myReader.GetValue(6)

                        row("Assigned Date") = Format(myReader.GetDateTime(8), "dd-MM-yyyy")

                        row("Employee Name") = myReader.GetString(4)

                        row("Assigned ID") = myReader.GetValue(0)


                        tab.Rows.Add(row)
                    End While
                End If
            ElseIf CheckBoxClose.Checked = True Then
                stQuery = "Select * from sc_serexe where closed_date  <= '"

                Dim DtTempDateTime As DateTime = DateTimePickerTo.Value

                DtTempDateTime = DateAdd(DateInterval.Day, 1, DtTempDateTime)


                stQuery &= Format(DtTempDateTime, "yyyy-MM-dd") & "' AND closed_date >= '"

                stQuery &= Format(DateTimePickerFrom.Value, "yyyy-MM-dd") & "'"

                stQuery &= " AND emp_name = '" & UCase(Txt_Curusr.Text) & "' and status = '0'"

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

                        row("Complaint ID") = myReader.GetString(1)
                        row("Customer Name") = myReader.GetString(2)
                        row("Product Name") = myReader.GetString(0)


                        ''   row("Product Type") = myReader.GetString(3)

                        row("Status") = myReader.GetString(5)
                        row("Serial No") = myReader.GetValue(1)

                        row("Assigned Date") = Format(myReader.GetDateTime(3), "dd-MM-yyyy")

                        row("Employee Name") = myReader.GetString(4)

                        '' row("Assigned ID") = myReader.GetValue(3)
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

    Private Sub frm_View_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim name As String
        name = UCase(frm_login.txt_user.Text)
        Txt_Curusr.Text = name
    End Sub

    Private Sub DataGridView4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView4.DoubleClick
        Txt_cmpid.Enabled = False
        If IsDBNull(DataGridView4.CurrentRow.Cells.Item(1).Value) Then
            Exit Sub
        End If




        Txt_cmpid.Text = DataGridView4.CurrentRow.Cells.Item(0).Value


        txt_empname.Text = DataGridView4.CurrentRow.Cells.Item(6).Value
        txt_cusname.Text = DataGridView4.CurrentRow.Cells.Item(1).Value
        cmb_status.Text = DataGridView4.CurrentRow.Cells.Item(4).Value


        txt_proname.Text = DataGridView4.CurrentRow.Cells.Item(3).Value
        txt_slno.Text = DataGridView4.CurrentRow.Cells.Item(5).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        Dim empname As String = ""

        cnnDB.Open()
        Call DataGridViewAssign_Init(DataGridView4, tab)

        stQuery = "Select * from sc_cmp_assign where st_emp_name = '" & UCase(Txt_Curusr.Text) & "' and ch_status = '0'"

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
                row("Complaint ID") = myReader.GetString(1)
                row("Customer Name") = myReader.GetString(2)
                row("Product Name") = myReader.GetString(3)


                ''   row("Product Type") = myReader.GetString(3)

                row("Status") = myReader.GetString(7)
                row("Serial No") = myReader.GetValue(6)

                row("Assigned Date") = Format(myReader.GetDateTime(8), "dd-MM-yyyy")

                row("Employee Name") = myReader.GetString(4)

                row("Assigned ID") = myReader.GetValue(0)


                tab.Rows.Add(row)
            End While
        End If

        myReader.Close()
        cnnDB.Close()
    End Sub

    Private Sub Button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clear.Click
        Txt_cmpid.Text = ""
        txt_cusname.Text = ""
        txt_empname.Text = ""
        txt_proname.Text = ""
        txt_slno.Text = ""
        cmb_status.Text = ""
        TextBoxRes.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim cmp_id As String = ""
        Dim cmpname As String = ""
        Dim resovediss As String
        Dim proname As String
        Dim problem As String = ""
        Dim mob, mob1 As String



        Dim address, serailno, UsrNameEscStr As String


        Dim stQuery As String

      
        Dim flg_gen As Short
      

        If cmb_status.Text = "open" Then
            flg_gen = 1
        Else
            flg_gen = 0
        End If





        cnnDB.Open()
        stQuery = "insert into sc_serexe values('" & txt_proname.Text & "','" & txt_slno.Text & _
        "','" & txt_cusname.Text & "','" & Format(DateTimePickercloseDate.Value, "yyyy-MM-dd") & _
        "','" & Txt_cmpid.Text & "','" & txt_empname.Text & "','" & cmb_status.Text & "','" & TextBoxRes.Text & "','" & flg_gen & "')"
                                             

        Dim Command As New MySqlCommand(stQuery, cnnDB)
        Dim rd As MySqlDataReader
        rd = Command.ExecuteReader()

        rd.Close()
        Dim stquery1 As String
        stquery1 = "update sc_cmp_assign set ch_status ='0' where st_cmp_id='" & Txt_cmpid.Text & "'"
        Dim Command1 As New MySqlCommand(stquery1, cnnDB)

        Command1.ExecuteNonQuery()

        Dim stquery2 As String
        stquery2 = "update sc_cmp_assign set ch_status_ep ='Close' where st_cmp_id='" & Txt_cmpid.Text & "'"
        Dim Command2 As New MySqlCommand(stquery1, cnnDB)

        Command2.ExecuteNonQuery()

        'Display a confermation msg that user is created
        MsgBox("Updated Successfully")


        Call Button_clear_Click(Button_clear, New System.EventArgs())
    End Sub
End Class