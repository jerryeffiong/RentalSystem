Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click, TextBox1.GotFocus
        TextBox1.Text = ""
        TextBox1.UseSystemPasswordChar = Enabled
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Connection()

        Dim Passtext As String = TextBox1.Text

        Dim Password As String
        Try
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
                frmMain.Show()
                Me.Hide()
            ElseIf Passtext = "" Or Passtext = "Enter Password" Then
                MsgBox("Enter system password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Else
                MsgBox("Incorrect password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.Close()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(Nothing, Nothing)
            e.Handled = True
        End If
    End Sub

End Class