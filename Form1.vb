Public Class Form1
    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Dim f2 As New Form2()
        f2.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim Message As String
        Message = "This program is designed by AIMAN HAZIQ BIN AMIR, 10DDT20F1063, JTMK"
        MessageBox.Show(Message, "Verification ")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        For Each Form In My.Application.OpenForms
            Form.Close()
        Next

    End Sub
End Class
