Public Class Form2
    Dim sz As Boolean
    Dim at As Boolean


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName.ToString()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox2.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        TextBox3.Text = HScrollBar2.Value
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Val(TextBox2.Text) <= 100 Then
            HScrollBar1.Value = Val(TextBox2.Text)
        Else
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If Val(TextBox3.Text) <= 100 Then
            HScrollBar2.Value = Val(TextBox3.Text)
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim code As String
        Dim src As String
        Dim size As String
        Dim alt As String
        size = " height=" + Label8.Text + TextBox2.Text + "%" + Label8.Text + " width=" + Label8.Text + TextBox3.Text + "%" + Label8.Text
        src = " src=" + Label8.Text + TextBox1.Text + Label8.Text
        alt = " alt=" + Label8.Text + TextBox4.Text + Label8.Text
        code = "<img"
        If at = True And sz = True Then
            TextBox5.Text = code + src + size + alt + ">"
        ElseIf at = True And sz = False Then
            TextBox5.Text = code + src + alt + ">"
        ElseIf at = False And sz = True Then
            TextBox5.Text = code + src + size + ">"
        Else
            TextBox5.Text = code + src + ">"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            HScrollBar1.Enabled = True
            HScrollBar2.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            sz = True
        Else
            HScrollBar1.Enabled = False
            HScrollBar2.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            sz = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox4.Enabled = True
            at = True
        Else
            TextBox4.Enabled = False
            at = False
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sz = False
        at = False
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox5.SelectAll()
        TextBox5.Copy()
        If input.Text = "main" Then
            Form1.TextBox1.Paste()
        ElseIf input.Text = "link" Then
            link.TextBox1.Paste()
        End If
        Me.Close()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.TextLength > 1 Then
            Button3.Enabled = True
        End If
    End Sub
End Class