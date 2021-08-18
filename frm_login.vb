Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frm_login
    Dim stQuery As String

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader




    Private Sub Form_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'clear the textboxes
        txt_user.Text = ""
        txt_pws.Text = ""

        'database connection

        Dim myConnectionString As String
        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        Try
            cnnDB.Open()
        Catch ex As Exception
            MsgBox("DataBase Connection Failed")
            'End
            Application.Exit()
            Exit Sub
        End Try


    End Sub

    'LinkLabel1 is to log in

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click


        Dim myConnectionString As String
        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim uname, pwd As String
        Dim authority As Short
        uname = Replace(txt_user.Text, "\", "\\")
        uname = Replace(uname, "'", "''")

        pwd = Replace(txt_pws.Text, "\", "\\")
        pwd = Replace(pwd, "'", "''")


        'If there is no username entered appropriate message
        If txt_user.Text = "" Then
            MsgBox("User Name Can Not Be Blank")
            txt_user.Focus()
            Exit Sub
        End If

        'If there is no password entered appropriate message
        If txt_pws.Text = "" Then
            MsgBox("Password Can Not Be Blank")
            txt_pws.Focus()
            Exit Sub
        End If

        stQuery = "select * from sc_usr where st_usr_name = '" & Trim(uname) & _
                                                                    "'and ch_statu = '1'"

        Dim cmd As New MySqlCommand(stQuery, cnnDB)

        'Open the connection.
        cnnDB.Open()
        myReader = cmd.ExecuteReader()
        '  cnnDB.Close()

        If myReader.HasRows = False Then
            myReader.Close()
            MsgBox("Invalid User Name")
            txt_user.Focus()
            txt_user.Text = ""
            Exit Sub
        End If

        'Read The first record
        myReader.Read()


        'Check For Valid Password
        If myReader.GetString(2) <> pwd Then

            MsgBox("Invalid Password")
            txt_pws.Focus()
            txt_pws.Text = ""
            Exit Sub
        End If

        Dim stQuery1 As String

        stQuery1 = "SELECT ch_athority FROM sc_usr WHERE st_usr_name = '" & Trim(myReader.GetString(1)) & "'"

        Dim cmd2 As New MySqlCommand(stQuery1, cnnDB)
        '  cnnDB.Open()
        myReader.Close()

        myReader1 = cmd2.ExecuteReader()

        'cnnDB.Close()
        If myReader1.HasRows = False Then
            myReader1.Close()
            Exit Sub
        End If
        If myReader1.HasRows = True Then
            myReader1.Read()
            authority = myReader1.GetInt16(0)
            myReader1.Close()
            cnnDB.Close()
        End If


        '1;"ADMIN"
        '2;"FRONT END EXECUTIVE"
        '3;"CUSTOMER SUPPORT EXECUTIVE"
        '4;"CUSTOMER SUPPORT MANAGER"

        If authority = "1" Then
            frm_admin.Show()
            Me.Hide()
        ElseIf authority = "2" Then
            frm_main.Show()
            Me.Hide()
        ElseIf authority = "3" Then

            frm_View.Show()
            Me.Hide()
        ElseIf authority = "4" Then
            frm_assign.Show()
            Me.Hide()


        End If
        myReader.Close()
        cnnDB.Close()
    End Sub

    'Button4 is used to log out

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub frm_login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call LinkLabel1_LinkClicked(sender, New System.EventArgs)
        End If
    End Sub

End Class
