Imports MySql.Data.MySqlClient
Public Class frmPassword
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim Passtext As String = txtOldPass.Text
            Dim Password As String

            cn.Open()
            cm = New MySqlCommand("Select * from tbluser", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                Password = dr.Item("password").ToString

            End If
            dr.Close()
            cn.Close()



            If Passtext = Password Then

                If txtNewPass.Text <> "" And txtNewPass.Text <> "Enter new password" Then

                    If txtNewPass.Text = txtConfirm.Text Then



                        cn.Open()
                        'cm = New MySqlCommand("insert into tbluser (password) values ('" & txtNewPass.Text & "')", cn)
                        cm = New MySqlCommand("UPDATE `tbluser` SET `password` = ('" & txtNewPass.Text & "') WHERE `tbluser`.`id` = 1 ", cn)
                        cm.ExecuteNonQuery()

                        MsgBox("Password has been successfully changed.", vbInformation)

                        txtOldPass.Text = "Enter old password"
                        txtNewPass.Text = "Enter new password"
                        txtConfirm.Text = "Confirm new password"
                        txtNewPass.UseSystemPasswordChar = False
                        txtOldPass.UseSystemPasswordChar = False
                        txtConfirm.UseSystemPasswordChar = False

                        Me.Close()
                        cn.Close()

                    Else
                        MsgBox("New password does not match with confirmation", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                    End If

                Else
                    MsgBox("Enter new system password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                End If

            ElseIf Passtext = "" Or Passtext = "Enter Password" Then
                MsgBox("Enter old system password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Else
                MsgBox("The old system password is incorrect. Try again", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub txtNewPass_Click(sender As Object, e As EventArgs) Handles txtNewPass.Click, txtNewPass.GotFocus
        txtNewPass.Text = ""
        txtNewPass.UseSystemPasswordChar = Enabled
        If txtOldPass.Text = "" Then
            txtOldPass.Text = "Enter old password"
            txtOldPass.UseSystemPasswordChar = False
        End If
        If txtConfirm.Text = "" Then
            txtConfirm.Text = "Confirm new password"
            txtConfirm.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtOldPass_Click(sender As Object, e As EventArgs) Handles txtOldPass.Click, txtOldPass.GotFocus

        txtOldPass.Text = ""
        txtOldPass.UseSystemPasswordChar = Enabled
        If txtNewPass.Text = "" Then
            txtNewPass.Text = "Enter new password"
            txtNewPass.UseSystemPasswordChar = False
        End If
        If txtConfirm.Text = "" Then
            txtConfirm.Text = "Confirm new password"
            txtConfirm.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtConfirm_Click(sender As Object, e As EventArgs) Handles txtConfirm.Click, txtConfirm.GotFocus

        txtConfirm.Text = ""
        txtConfirm.UseSystemPasswordChar = Enabled
        If txtNewPass.Text = "" Then
            txtNewPass.Text = "Enter new password"
            txtNewPass.UseSystemPasswordChar = False
        End If
        If txtOldPass.Text = "" Then
            txtOldPass.Text = "Enter old password"
            txtOldPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtOldPass.Text = "Enter old password"
        txtNewPass.Text = "Enter new password"
        txtConfirm.Text = "Confirm new password"
        txtNewPass.UseSystemPasswordChar = False
        txtOldPass.UseSystemPasswordChar = False
        txtConfirm.UseSystemPasswordChar = False
        Me.Close()
    End Sub
End Class