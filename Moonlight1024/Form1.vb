Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Timer1.Start()
        Try
            IO.File.WriteAllBytes(TextBox1.Text & "\Data\etc\env.sce", My.Resources.env)
            My.Settings.marker = TextBox1.Text
            My.Settings.Save()
            MsgBox("Moonlight Done.", MsgBoxStyle.Information, "MoonLight RebirthRC")
        Catch ex As Exception
            MsgBox("คุณเลือกโฟลเดอร์ผิด กรุณาเลือกโฟลเดอร์เกม Rebirth-Raycity.", MsgBoxStyle.Critical, "MoonLight RebirthRC")
        End Try
        
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.marker
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
        'Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Timer1.Stop()
        'Timer2.Stop()
        'MsgBox("Have Fun !! :)", , "Rebirh-Moonlight 2.0")
        'End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            IO.File.WriteAllBytes(TextBox1.Text & "\Data\etc\env.sce", My.Resources.env2)
            My.Settings.marker = TextBox1.Text
            My.Settings.Save()
            MsgBox("Daylight Done.", MsgBoxStyle.Information, "MoonLight RebirthRC")
        Catch ex As Exception
            MsgBox("คุณเลือกโฟลเดอร์ผิด กรุณาเลือกโฟลเดอร์เกม Rebirth-Raycity.", MsgBoxStyle.Critical, "MoonLight RebirthRC")
        End Try
    End Sub
End Class
