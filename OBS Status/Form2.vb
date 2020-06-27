Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Show()
        TrackBar1.Minimum = 5
        TrackBar1.Maximum = 100
    End Sub

    Dim OpSliderValue As Integer
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label2.Text = TrackBar1.Value.ToString()
        Form1.Opacity = TrackBar1.Value / 100
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString
            Case "Default (White)"
                Form1.BackColor = Color.White
            Case "DimGray"
                Form1.BackColor = Color.DimGray
            Case "Gray"
                Form1.BackColor = Color.Gray
            Case "DarkGray"
                Form1.BackColor = Color.DarkGray
            Case "Silver"
                Form1.BackColor = Color.Silver
            Case "LightGray"
                Form1.BackColor = Color.LightGray


        End Select
    End Sub


End Class