Public Class newf

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rpf As String
        Dim vrpf As Integer
        Dim loc As String
        rpf = My.Computer.FileSystem.ReadAllText("data\rpf.cndf")

        Select Case rpf
            Case ""
                My.Computer.FileSystem.DeleteFile("data\rpf\d1.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d1.rpdf", "" & TextBox1.Text, True)
            Case "1"
                My.Computer.FileSystem.DeleteFile("data\rpf\d2.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d2.rpdf", "" & TextBox1.Text, True)
            Case "2"
                My.Computer.FileSystem.DeleteFile("data\rpf\d3.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d3.rpdf", "" & TextBox1.Text, True)
            Case "3"
                My.Computer.FileSystem.DeleteFile("data\rpf\d4.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d4.rpdf", "" & TextBox1.Text, True)
            Case "4"
                My.Computer.FileSystem.DeleteFile("data\rpf\d5.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d5.rpdf", "" & TextBox1.Text, True)
            Case "5"
                My.Computer.FileSystem.DeleteFile("data\rpf\d6.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d6.rpdf", "" & TextBox1.Text, True)
            Case "6"
                My.Computer.FileSystem.DeleteFile("data\rpf\d7.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d7.rpdf", "" & TextBox1.Text, True)
            Case "7"
                My.Computer.FileSystem.DeleteFile("data\rpf\d8.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d8.rpdf", "" & TextBox1.Text, True)
            Case "8"
                My.Computer.FileSystem.DeleteFile("data\rpf\d9.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d9.rpdf", "" & TextBox1.Text, True)
            Case "9"
                My.Computer.FileSystem.DeleteFile("data\rpf\d10.rpdf")
                My.Computer.FileSystem.WriteAllText("data\rpf\d10.rpdf", "" & TextBox1.Text, True)
        End Select
        TextBox3.Text = rpf
        vrpf = Val(TextBox3.Text)
        If vrpf < 10 Then
            vrpf = vrpf + 1
            TextBox3.Text = vrpf
            rpf = TextBox3.Text
            My.Computer.FileSystem.DeleteFile("data\rpf.cndf")
            My.Computer.FileSystem.WriteAllText("data\rpf.cndf", "" & TextBox3.Text, True)
        Else
            rpf = ""
        End If
        Form1.Show()
        Form1.TextBox2.Text = TextBox2.Text + "\" + TextBox1.Text + ".html"
        loc = TextBox2.Text + "\" + TextBox1.Text + ".html"
        My.Computer.FileSystem.WriteAllText(loc, "" & "", True)
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Panel2.Width = "420" Then
        Else
            Timer1.Enabled = True
        End If
        Label1.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d1.rpdf")
        Label4.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d2.rpdf")
        Label5.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d3.rpdf")
        Label6.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d4.rpdf")
        Label7.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d5.rpdf")
        Label8.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d6.rpdf")
        Label9.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d7.rpdf")
        Label10.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d8.rpdf")
        Label12.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d9.rpdf")
        Label13.Text = My.Computer.FileSystem.ReadAllText("data\rpf\d10.rpdf")
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.Gray
    End Sub

    Private Sub Button4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        Button4.BackColor = Color.DarkGray
    End Sub

    Private Sub newf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button4.BackColor = Color.Gray
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Panel2.Width = "420" Then
            Timer1.Enabled = False
        Else
            Panel2.Width = Panel2.Width + 10
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox2.Text = FolderBrowserDialog1.SelectedPath

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox2.TextLength < 0 And TextBox1.TextLength < 0 Then
            Button1.Enabled = True
        ElseIf TextBox1.TextLength = 0 Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength < 0 And TextBox1.TextLength < 0 Then
            Button1.Enabled = True
        ElseIf TextBox2.TextLength = 0 Then
            Button1.Enabled = False
        End If
    End Sub
End Class