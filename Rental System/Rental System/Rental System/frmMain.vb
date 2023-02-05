Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection()
        Timer1.Enabled = True
        frmLogin.Close()



    End Sub

    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        With frmRental
            .LoadAutoNo()
            .AutoSuggestModule1()
            .AutoSuggestModule()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        With frmReturn
            .ShowDialog()
        End With
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        With frmCustomer
            .TopLevel = False
            Panel5.Controls.Add(frmCustomer)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMotor_Click(sender As Object, e As EventArgs) Handles btnMotor.Click
        With frmMotorList
            .TopLevel = False
            Panel5.Controls.Add(frmMotorList)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnIncome.Click
        With frmIncome
            .TopLevel = False
            Panel5.Controls.Add(frmIncome)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        With frmTransactionLog
            .TopLevel = False
            Panel5.Controls.Add(frmTransactionLog)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        With frmBrand
            .TopLevel = False
            Panel5.Controls.Add(frmBrand)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("HH")
        If Integer.Parse(Label3.Text) >= 12 And Integer.Parse(Label3.Text) < 16 Then
            Label2.Text = "Good Afternoon!"
        ElseIf Integer.Parse(Label3.Text) >= 0 And Integer.Parse(Label3.Text) < 12 Then
            Label2.Text = "Good Morning!"
        Else
            Label2.Text = "Good Evening!"
        End If
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        frmPassword.ShowDialog()
    End Sub



End Class
