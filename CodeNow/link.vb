Public Class link


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Form2.input.Text = "link"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim txt As String
        Dim url As String
        Dim code As String
        txt = TextBox1.Text
        url = TextBox2.Text
        code = "<a href="
        TextBox3.Text = code + Label3.Text + url + Label3.Text + ">" + txt + "</a>"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.SelectAll()
        TextBox3.Copy()
        Form1.TextBox1.Paste()
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength > 1 Then
            Button3.Enabled = True
        End If
    End Sub
End Class