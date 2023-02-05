Imports MySql.Data.MySqlClient

Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader



    Sub Connection()
        Try
            With cn
                .ConnectionString = "server=localhost;user id=root;password=;database=rentaldb;"
                .Open()
                .Close()
            End With


        Catch sqle As MySqlException
            MsgBox("Unable to connect to server. Check connection", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Server Error")
            Application.Exit()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")

        End Try
    End Sub

    Public Function IS_EMPTY(ByRef sText As Object) As Boolean
        On Error Resume Next
        If sText.Text = "" Then
            IS_EMPTY = True
            MsgBox("Warning: Required missing field.", vbExclamation)
            sText.BackColor = Color.LemonChiffon
            sText.SetFocus()
        Else
            IS_EMPTY = False
            sText.BackColor = Color.White
        End If
        Return IS_EMPTY
    End Function

End Module
