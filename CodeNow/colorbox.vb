Public Class colorbox
    Dim r As String
    Dim g As String
    Dim b As string
    Dim red As String
    Dim gree As String
    Dim blue As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        TextBox1.Text = ColorDialog1.Color.R.ToString
        TextBox2.Text = ColorDialog1.Color.G.ToString
        TextBox3.Text = ColorDialog1.Color.B.ToString
        TextBox4.Text = ColorDialog1.Color.Name.ToString
        TextBox6.BackColor = ColorDialog1.Color
        r = Hex(Val(ColorDialog1.Color.R.ToString))
        g = Hex(Val(ColorDialog1.Color.G.ToString))
        b = Hex(Val(ColorDialog1.Color.B.ToString))
        red = r
        gree = g
        blue = b
        If r.Length = 1 Then
            red = "0" + red
        End If
        If g.Length = 1 Then
            gree = "0" + gree
        End If
        If b.Length = 1 Then
            blue = "0" + blue
        End If
        TextBox5.Text = "#" + red + gree + blue
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label6.Text = "txt" Then
            txt.TextBox2.Text = TextBox5.Text
        End If
        Me.Close()
    End Sub
End Class