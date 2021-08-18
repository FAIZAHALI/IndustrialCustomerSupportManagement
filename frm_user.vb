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

Friend Class frm_user
    Inherits System.Windows.Forms.Form
    Dim WithEvents ComPort As New System.IO.Ports.SerialPort

    Dim stQuery As String
    Private Sub frm_user_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)

        txt_add_pwd1.Text = ""
        txt_add_pwd2.Text = ""
        cmb_add_auth.Items.Clear()

        cnnDB.Open()
        stQuery = "SELECT st_login_type FROM sc_login_types ORDER BY st_login_type"


        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()
        'cnnDB.Close()

        While myReader.Read
            cmb_add_auth.Items.Add(myReader.GetString(0))
        End While

        myReader.Close()
        cnnDB.Close()
    End Sub

    Private Sub Button_Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Register.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim user_ID As Short
        Dim snd_string, PasswordEscStr, UsrNameEscStr As String

        snd_string = Replace(Trim(txt_add_usr.Text), "\", "\\")
        snd_string = Replace(snd_string, "'", "''")

        PasswordEscStr = Replace(txt_add_pwd1.Text, "\", "\\")
        PasswordEscStr = Replace(PasswordEscStr, "'", "''")

        UsrNameEscStr = Replace(Trim(txt_add_name.Text), "\", "\\")
        UsrNameEscStr = Replace(UsrNameEscStr, "'", "''")

        'Is the User name entered
        If Trim(txt_add_usr.Text) = "" Then
            MsgBox("Please enter User Name")
            txt_add_usr.Focus()
            Exit Sub
        End If

        'Is the user type selected
        If Trim(cmb_add_auth.Text) = "" Then
            MsgBox("Please Select User type")
            cmb_add_auth.Focus()
            Exit Sub
        End If

      

        'Is the Password re-entered
        If Trim(txt_add_pwd2.Text) = "" Then
            MsgBox("Please re-enter Password")
            txt_add_pwd2.Focus()
            Exit Sub
        End If


        'Is the Name entered
        If Trim(txt_add_name.Text) = "" Then
            MsgBox("Please enter Name")
            txt_add_name.Focus()
            Exit Sub
        End If



        'Is the Mobile Number entered
        If Trim(MaskedTextBoxMobileNo.Text) = "" Then
            MsgBox("Please enter mobile number")
            MaskedTextBoxMobileNo.Focus()
            Exit Sub
        End If
        'Are both the passwords matching
        If StrComp(txt_add_pwd1.Text, txt_add_pwd2.Text) Then
            MsgBox("Passwords entered do not match.Please Re-enter the password.")
            txt_add_pwd1.Text = ""
            txt_add_pwd2.Text = ""
            txt_add_pwd1.Focus()
            Exit Sub
        End If

        'NAV_050511_3266: New lines added
        If RadioButtonMale.Checked = False And RadioButtonFemale.Checked = False Then
            MsgBox("Please Select Gender(Male or Female)")
            Exit Sub
        End If

        Dim stQuery As String

        'Check id the user exist??
        cnnDB.Open()
        stQuery = "select * from sc_usr where st_usr_name = '" & snd_string & "'"
        '
        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()
        ' cnnDB.Close()

        If myReader.HasRows = True Then
            myReader.Close()
            MsgBox("User already Exists")
            Exit Sub
        End If
        myReader.Close()
        'Get the higest si_user_id from the database
        stQuery = "select max(si_user_id) as count from sc_usr"

        ' cnnDB.Open()
        Dim cmd3 As New MySqlCommand(stQuery, cnnDB)
        Dim myReader1 As MySqlDataReader
        myReader1 = cmd3.ExecuteReader()
        'cnnDB.Close()

        If myReader1.HasRows = False Then
            MsgBox("User Id is Not Created")
            Application.Exit()
        Else
            myReader1.Read()
            user_ID = myReader1.GetInt16(0) + 1
        End If

        myReader1.Close()
    
        'Get the user auth
        stQuery = "SELECT si_login_id FROM sc_login_types WHERE st_login_type = '" & _
                           Trim(cmb_add_auth.Text) & "'"

        'cnnDB.Open()
        Dim cmd8 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd8.ExecuteReader()
        '  cnnDB.Close()

        'If there is any error
        If closeApplication = "1" Then
            Me.Close()
            frm_login.Show()
            Exit Sub
        End If

        If myReader.HasRows = False Then
            MsgBox("User Type Auth info not found. User of this type can not be created")
            Exit Sub
        End If

        myReader.Read()

        Dim usrAuth As Short

        usrAuth = myReader.GetInt16(0)


        Dim flg_gen As Short
        Dim Address As String

        If RadioButtonMale.Checked = True Then
            flg_gen = 0
        Else
            flg_gen = 1
        End If

        Address = Replace(TextBoxAddr.Text, "\", "\\")
        Address = Replace(Address, "'", "''")
        '  cnnDB.Open()
        myReader.Close()
        stQuery = "insert into sc_usr values(" & _
                                               user_ID & _
                                               ",'" & snd_string & _
                                               "','" & PasswordEscStr _
                                               & "','" & usrAuth & _
                                               "','1','" & UsrNameEscStr _
                                              & "','FormRegister','" & MaskedTextBoxMobileNo.Text & " " & MaskedTextBoxMobileNo2.Text & "','" & flg_gen & "','" & Address & "')"


        Dim cmd4 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd4.ExecuteReader()

       
        'Display a confermation msg that user is created
        MsgBox("USER CREATED " & vbNewLine & vbNewLine & "User Name" & vbTab & _
               ":" & txt_add_usr.Text & vbTab & vbNewLine & "Authority" & vbTab & _
               vbTab & ":" & cmb_add_auth.Text & vbTab & vbNewLine & "Name" & vbTab & _
               vbTab & ":" & Trim(txt_add_name.Text) & vbTab)
        cnnDB.Close()

        Call Button_clear_Click(Button_clear, New System.EventArgs())


    End Sub
    Public Function prepad(ByVal no As String, ByVal length As Short) As String
        Dim i As Short

        For i = Len(no) To length - 1
            no = "0" & no
        Next

        prepad = no

    End Function

    Private Sub Button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clear.Click
        'Cancel of add user
        txt_add_usr.Text = ""
        txt_add_pwd1.Text = ""
        txt_add_pwd2.Text = ""
        txt_add_name.Text = ""
        cmb_add_auth.Items.Clear()
        TextBoxAddr.Text = ""

        MaskedTextBoxMobileNo.Clear()
        MaskedTextBoxMobileNo2.Clear()

    End Sub

    Private Sub Button_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_back.Click
        'clear the textboxes
        'frm_login.txt_user.Text = ""
        'frm_login.txt_pws.Text = ""
        'frm_login.Show()
        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub txt_add_name_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_add_name.Leave
        txt_add_name.Text = UCase(txt_add_name.Text)
    End Sub
End Class