Public Class Form1
    Dim autosv As Boolean
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        loading.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Height = Me.Height - 25
        TextBox1.Width = Me.Width - 16
        TextBox1.Text = My.Computer.FileSystem.ReadAllText("data\def.cndf")
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        If TextBox2.Text = "" Then
            MsgBox("Please select a place to save", MsgBoxStyle.Critical)
            SaveFileDialog1.ShowDialog()
            TextBox2.Text = SaveFileDialog1.FileName
        Else
            My.Computer.FileSystem.DeleteFile(TextBox2.Text)
            My.Computer.FileSystem.WriteAllText(TextBox2.Text, "" & TextBox1.Text, True)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        If TextBox2.Text = "" Then
            MsgBox("Please select a place to save", MsgBoxStyle.Critical)
            SaveFileDialog1.ShowDialog()
            TextBox2.Text = SaveFileDialog1.FileName
        Else
            My.Computer.FileSystem.DeleteFile(TextBox2.Text)
            My.Computer.FileSystem.WriteAllText(TextBox2.Text, "" & TextBox1.Text, True)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.ShowDialog()
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        TextBox2.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        webbrow.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        webbrow.WebBrowser1.DocumentText = TextBox1.Text
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        webbrow.WebBrowser1.DocumentText = TextBox1.Text
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub StatusStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StatusStrip1.MouseMove

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim time As Integer
        time = time + 1
        If time > 300 Then
            autosv = True
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        My.Computer.FileSystem.DeleteFile("data/autosave.cndf")
        My.Computer.FileSystem.WriteAllText("data/autosave.cndf", "" & TextBox1.Text, True)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Form2.Show()
        Form2.input.Text = "main"
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        link.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        txt.Show()
    End Sub
End Class