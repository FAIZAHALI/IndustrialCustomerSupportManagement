
Option Strict Off
Option Explicit Off
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Text
Imports System.Threading
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Imports Microsoft.Win32

Friend Class frm_main
    Inherits System.Windows.Forms.Form


    Private Sub Button_Create_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_emp_register.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'clear the textboxes
        frm_login.txt_user.Text = ""
        frm_login.txt_pws.Text = ""
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_pro_complaint.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_assign.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_datareports.Show()
        Me.Hide()
    End Sub

    Private Sub frm_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
    End Sub
End Class