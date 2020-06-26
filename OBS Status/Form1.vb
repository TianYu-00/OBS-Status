Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() 'Start timer


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(33)) Then 'Page up key
            Label1.Text = ("Recording")
            PictureBox1.Image = My.Resources.red_status

        ElseIf (GetAsyncKeyState(34)) Then 'Page down key
            Label1.Text = ("Idle")
            PictureBox1.Image = My.Resources.idle_status
        End If
    End Sub
End Class
