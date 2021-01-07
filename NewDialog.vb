Public Class NewDialog

    Private Sub btnCOnfirm_Click(sender As Object, e As EventArgs) Handles btnCOnfirm.Click
        If tbxBookName.Text.Length = 0 Then
            MessageBox.Show("Enter a Name")
            tbxBookName.Focus()
        Else
            Me.DialogResult() = DialogResult.OK
        End If
    End Sub
End Class