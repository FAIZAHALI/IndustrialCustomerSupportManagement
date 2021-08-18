Imports MySql.Data
Imports MySql.Data.MySqlClient
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

Friend Class frm_edit_user
    Inherits System.Windows.Forms.Form
    Dim WithEvents ComPort As New System.IO.Ports.SerialPort
    Dim close_flag As Boolean
    Dim stQuery As String
    Dim cnnDB As SqlClient.SqlConnection

    Dim myCmd As New MySqlCommand
    Public myReader As MySqlDataReader

    Public myReader1 As MySqlDataReader

    Private Sub frm_edit_user_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        cnnDB.Open()
        stQuery = "SELECT st_login_type FROM sc_login_types ORDER BY st_login_type"


        'Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB
        '' cnnDB.Open()
        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()


        While myReader.Read
            Cmbo_logintypes.Items.Add(myReader.GetString(0))
        End While

        myReader.Close()
        cnnDB.Close()

    End Sub

    Private Sub cmb_login_names_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_login_names.SelectedIndexChanged

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        cnnDB.Open()
        Dim newname As String = ""
        Dim newloginname As String = ""
        Dim pwd As String = ""
        Dim auth As Short
        Dim logintype As String = ""

        If Cmbo_logintypes.Text = "" Then
            MsgBox("Please select the login type")
            Exit Sub
        End If

        'Authority
        If Trim(Cmbo_logintypes.Text) = "ADMIN" Then
            auth = 1
        ElseIf Trim(Cmbo_logintypes.Text) = "FRONT END EXECUTIVE" Then
            auth = 2
        ElseIf Trim(Cmbo_logintypes.Text) = "CUSTOMER SUPPORT EXECUTIVE" Then
            auth = 3
        ElseIf Trim(Cmbo_logintypes.Text) = "CUSTOMER SUPPORT MANAGER" Then
            auth = 4
        End If

        stQuery = "SELECT * FROM sc_usr WHERE st_usr_name = '" & Trim(cmb_login_names.Text) & "'"

        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()


        If myReader.HasRows Then

            myReader.Read()
            Txt_new_login_name.Text = myReader.GetString(1)
            txt_new_uname.Text = myReader.GetString(5)
            MaskedTextBoxMobileNo.Text = myReader.GetString(7)
            TextBoxAddr.Text = myReader.GetString(9)

        End If


        myReader.Close()

        cnnDB.Close()
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_new_login_name.Leave
        Txt_new_login_name.Text = UCase(Txt_new_login_name.Text)
    End Sub

    Private Sub Cmbo_logintypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbo_logintypes.SelectedIndexChanged

        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        cnnDB.Open()
        Dim auth As Short

        'Authority
        If Trim(Cmbo_logintypes.Text) = "ADMIN" Then
            auth = 1
        ElseIf Trim(Cmbo_logintypes.Text) = "FRONT END EXECUTIVE" Then
            auth = 2
        ElseIf Trim(Cmbo_logintypes.Text) = "EXECUTIVE" Then
            auth = 3
        ElseIf Trim(Cmbo_logintypes.Text) = "MANAGER" Then
            auth = 4
        End If



        stQuery = "SELECT st_usr_name FROM sc_usr where ch_statu='1' and ch_athority = '" & auth & "' ORDER BY st_usr_name"

        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()
        cmb_login_names.Items.Clear()


        While myReader.Read
            cmb_login_names.Items.Add(myReader.GetString(0))
        End While

        myReader.Close()
        cnnDB.Close()

    End Sub

    Private Sub Button_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Apply.Click
        Dim myConnectionString As String

        myConnectionString = "server=localhost;" _
                    & "database=Support_db;" _
                    & "uid=root;" _
                    & "pwd=support;" _
                    & "port=3306;"

        Dim cnnDB As New MySqlConnection(myConnectionString)
        Dim user_ID As Short
        Dim auth As Short
        Dim newname, Password, UsrName As String

        UsrName = Trim(Txt_new_login_name.Text)


        newname = Trim(txt_new_uname.Text)


        Password = txt_add_pwd1.Text


        'Authority
        If Trim(Cmbo_logintypes.Text) = "ADMIN" Then
            auth = 1
        ElseIf Trim(Cmbo_logintypes.Text) = "FRONT END EXECUTIVE" Then
            auth = 2
        ElseIf Trim(Cmbo_logintypes.Text) = "EXECUTIVE" Then
            auth = 3
        ElseIf Trim(Cmbo_logintypes.Text) = "MANAGER" Then
            auth = 4
        End If




        'Is the Mobile Number entered
        If Trim(MaskedTextBoxMobileNo.Text) = "" Then
            MsgBox("Please enter mobile number")
            MaskedTextBoxMobileNo.Focus()
            Exit Sub
        End If



        cnnDB.Open()
        stQuery = "SELECT * FROM sc_usr WHERE st_usr_name = '" & Trim(cmb_login_names.Text) & "'"

        'Dim cnnDB As New MySqlConnection(myConnectionString)

        ' cmd2.CommandText = stQuery
        ' cmd2.Connection = cnnDB
        ''  cnnDB.Open()
        Dim cmd2 As New MySqlCommand(stQuery, cnnDB)
        myReader = cmd2.ExecuteReader()



        If myReader.HasRows Then
            myReader.Read()
            If txt_Currpwd.Text <> myReader.GetString(2) Then

                MsgBox("Invalid Current Password")
                txt_Currpwd.Text = ""
                txt_Currpwd.Focus()
                Exit Sub
            End If
        End If


        'Is the Password entered
        If Trim(txt_add_pwd1.Text) = "" Then
            MsgBox("Please enter Password")
            txt_add_pwd1.Focus()
            Exit Sub
        End If


        'Is the Password re-entered
        If Trim(txt_add_pwd2.Text) = "" Then
            MsgBox("Please re-enter Password")
            txt_add_pwd2.Focus()
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


        If RadioButtonMale.Checked = False And RadioButtonFemale.Checked = False Then
            MsgBox("Please Select Gender(Male or Female)")
            Exit Sub
        End If

        Dim flg_gen As Short
        Dim Address As String
        Dim status As Short

        If RadioButtonMale.Checked = True Then
            flg_gen = 0
        Else
            flg_gen = 1
        End If

        Address = Replace(TextBoxAddr.Text, "\", "\\")
        Address = Replace(Address, "'", "''")

        If RadioButtonStatus.Checked = True Then
            status = 1
        Else
            status = 0
        End If
        Dim stquery6 As String
        cnnDB.Close()
        cnnDB.Open()
        stquery6 = "update sc_usr  set  st_usr_name = '" & Txt_new_login_name.Text & "',st_name ='" & txt_new_uname.Text & _
        "', st_password   ='" & Password & "',ch_athority='" & auth & "',ch_statu = '" & status & _
        "',st_name ='" & newname & "',st_def_screen = 'Frm_main',st_mob_no= '" & MaskedTextBoxMobileNo.Text & "',ch_gender ='" & flg_gen & "',st_addr= '" & Address & "' where st_usr_name = '" & cmb_login_names.Text & "'"

        Dim Command1 As New MySqlCommand(stquery6, cnnDB)

        Command1.ExecuteNonQuery()

        'stQuery = "update sc_usr set st_usr_name = '" & UsrName & "',st_password = '" & Password & "',st_mob_noo = '" & mobile2 & "',ch_gender = '" & flg_gen & "',st_email = '" & mailid & "',si_age = '" & age & "',f_rate = '" & Rate() & "',st_designation = '" & designation & "' where st_emp_id='" & txt_empid.Text & "'"





        MsgBox("Updated Succesfuly")
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

    Private Sub Button_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_back.Click
        'clear the textboxes
        ' frm_login.txt_user.Text = ""
        'frm_login.txt_pws.Text = ""
        'frm_login.Show()

        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clear.Click
        'Cancel of add user
        txt_new_uname.Text = ""
        txt_add_pwd1.Text = ""
        txt_add_pwd2.Text = ""
        Txt_new_login_name.Text = ""
        cmb_login_names.Items.Clear()
        TextBoxAddr.Text = ""

        MaskedTextBoxMobileNo.Clear()
        MaskedTextBoxMobileNo2.Clear()

    End Sub
End Class