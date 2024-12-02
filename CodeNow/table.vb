Public Class table
    Dim x As String
    Dim lastcol As String
    Private Sub createtb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createtb.Click
        TextBox1.Text = "<table caption=" + x + caption_t.Text + x + " border=" + x + border_t.Text + x + " height =" + x + height_t.Text + x + " width=" + x + width_t.Text + x + " cellpadding=" + x + cellp_t.Text + x + " cellspacing=" + x + cells_t.Text + x + "><tr>"
    End Sub

    Private Sub table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x = Label7.Text
    End Sub

    Private Sub addrowb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addrowb.Click
        TextBox1.Text = TextBox1.Text + "</tr><tr>"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        WebBrowser1.DocumentText = TextBox1.Text
    End Sub

    Private Sub addcoloumb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addcoloumb.Click
        TextBox1.Text = TextBox1.Text + "<td "

        addb.Enabled = True
    End Sub

    Private Sub addb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addb.Click
        TextBox1.Text = TextBox1.Text + data_t.Text + "</td>"
        addb.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub colspanb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colspanb.Click
        TextBox1.Text = TextBox1.Text + "colspan=" + Label7.Text + span_t.Text + Label7.Text + ">"
    End Sub
End Class