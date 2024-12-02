Public Class list
    Dim x As String
    Dim listmode As String
    Dim listtype As String
    Dim li(1000) As String
    Dim selectednum As Integer
    Dim lic As Integer

    Sub ref()
        Dim cnt As Integer
        cnt = 0
        TextBox1.Text = listmode + "type=" + Label1.Text + listtype + Label1.Text + ">"
        ComboBox3.Items.Clear()
        Do Until cnt = lic
            TextBox1.Text = TextBox1.Text + "<li>" + li(cnt) + "</li>"
            ComboBox3.Items.Add(li(cnt))
            cnt += 1
        Loop

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'TextBox1.Text = "<ol type=" + Label1.Text
        'TextBox1.Text = TextBox1.Text + ComboBox1.SelectedItem.ToString + Label1.Text + ">"
        listtype = ComboBox1.SelectedItem.ToString
        ref()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            x = "</ol>"
            listmode = "<ol "
            ComboBox1.Enabled = True
            ComboBox2.Enabled = False
            TextBox1.Text = ""
            TextBox1.Text = "<ol type=" + Label1.Text
            ref()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            x = "</ul>"
            listmode = "<ul "
            ComboBox1.Enabled = False
            ComboBox2.Enabled = True
            TextBox1.Text = ""
            TextBox1.Text = "<ul type=" + Label1.Text
            ref()
        End If
    End Sub

    Private Sub list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'TextBox1.Text = "<ul type=" + Label1.Text
        'TextBox1.Text = TextBox1.Text + ComboBox2.SelectedItem.ToString + Label1.Text + ">"
        listtype = ComboBox2.SelectedItem.ToString
        ref()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Add item" Then
            'TextBox1.Text = TextBox1.Text + "<li>" + TextBox2.Text + "</li>"
            li(lic) = TextBox2.Text
            lic += 1
            WebBrowser1.DocumentText = TextBox1.Text
            TextBox2.Clear()
            TextBox2.Focus()
            Button1.Enabled = False
            ref()
        ElseIf Button1.Text = "Change item" Then
            li(selectednum) = TextBox2.Text
            Button1.Text = "Add item"
            ref()
            TextBox2.Clear()
            TextBox2.Focus()
            ComboBox3.Text = ""
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + x
        TextBox1.SelectAll()
        TextBox1.Copy()
        Form1.TextBox1.Paste()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ref()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        WebBrowser1.DocumentText = TextBox1.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox2.Text = ComboBox3.SelectedItem.ToString
        selectednum = ComboBox3.SelectedIndex
        Button1.Text = "Change item"
        TextBox2.Focus()
        Button3.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox2.Text = ComboBox3.SelectedItem.ToString
        selectednum = ComboBox3.SelectedIndex
        Button1.Text = "Change item"
        TextBox2.Focus()
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim cnt As Integer
        cnt = selectednum


        Do Until cnt = lic
            li(cnt) = li(cnt + 1)
            cnt += 1
        Loop
        lic = lic - 1
        Button1.Text = "Add item"
        ref()
        TextBox2.Clear()
        TextBox2.Focus()
        Button1.Enabled = False
        Button3.Enabled = False
        ComboBox3.Text = ""
    End Sub
End Class