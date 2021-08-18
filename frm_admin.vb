Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Text
Imports System.Threading
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32


Friend Class frm_admin
    Inherits System.Windows.Forms.Form
    Dim WithEvents ComPort As New System.IO.Ports.SerialPort
   
    Private Sub frm_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_edit_user.Click
        frm_edit_user.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Create_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Create_user.Click
        frm_user.Show()
        Me.Hide()
    End Sub

    'Button4 is to log out


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frm_login.Show()
        Me.Hide()
    End Sub

    'Button1 is to register customer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_emp_register.Show()
        Me.Hide()
    End Sub
End Class