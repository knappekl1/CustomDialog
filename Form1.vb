Public Class Form1
    Public Dialog As NewDialog
    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        Dialog = New NewDialog
        Dialog.tbxBookName.Text = tbxName.Text
        If Dialog.ShowDialog() = DialogResult.OK Then
            tbxName.Text = Dialog.tbxBookName.Text

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
