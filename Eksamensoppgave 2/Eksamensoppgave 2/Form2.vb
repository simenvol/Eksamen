Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim budsjett As Integer
        budsjett = Form1.antall(1)
        Label2.Text = budsjett & " kroner"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vinner
        vinner = Form1.Winner
        MsgBox(vinner)
    End Sub
End Class