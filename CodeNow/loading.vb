Public Class loading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = "100" Then
            Timer1.Enabled = False
            newf.Show()
            Me.Visible = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If

    End Sub

    Private Sub loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Boolean
        x = My.Computer.FileSystem.FileExists("data\def.cndf")
        If x = True Then
            Timer1.Enabled = True
            ProgressBar1.Value = ProgressBar1.Value + 5
            Timer1.Enabled = False
        Else
            MsgBox("'' def.cndf '' file is missing.")
        End If
        If My.Computer.FileSystem.FileExists("data\defcss.cndf") Then
            Timer1.Enabled = True
            ProgressBar1.Value = ProgressBar1.Value + 10
            Timer1.Enabled = False
        End If
        If My.Computer.FileSystem.FileExists("data\rpf.cndf") Then
            Timer1.Enabled = True
            ProgressBar1.Value = ProgressBar1.Value + 10
            Timer1.Interval = "50"
        Else
            My.Computer.FileSystem.WriteAllText("data\rpf.cndf", "" & "", True)
            Timer1.Enabled = True
            ProgressBar1.Value = ProgressBar1.Value + 10
            Timer1.Interval = "50"
        End If
    End Sub
End Class