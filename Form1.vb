Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim MyText As String
        MyText = "Visual Basic"

        MsgBox(Microsoft.VisualBasic.Right(MyText, 4))

    End Sub



End Class
