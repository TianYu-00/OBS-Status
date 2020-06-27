Public Class Form3
    ''Close
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        Me.Close()


    End Sub

    ''Not using OBS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.checkOBSStart = False
        Form1.Show()
        Form1.Label1.Text = ("Ready")
    End Sub
End Class