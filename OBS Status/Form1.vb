Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() 'Start timer


        'check to see if OBS is running'''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub



    Public checkOBSStart As Boolean = True


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If checkOBSStart = True Then
            CheckIfRunning()
        Else

        End If




        If (GetAsyncKeyState(33)) Then 'Page up key
            Label1.Text = ("Recording")
            PictureBox1.Image = My.Resources.red_status

        ElseIf (GetAsyncKeyState(34)) Then 'Page down key
            Label1.Text = ("Idle")
            PictureBox1.Image = My.Resources.idle_status
        End If
    End Sub



    'Dragable panel'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

        'Right click open options'''''''''''''''''''''''''''''''''''''''
        If e.Button = MouseButtons.Right Then
            Form2.Show()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    'Click through the whole form including panel1'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Protected Overrides ReadOnly Property CreateParams() As CreateParams
    'Get
    'Const WS_EX_TRANSPARENT As Integer = &H20
    'Dim params As CreateParams = MyBase.CreateParams
    '       params.ExStyle = params.ExStyle Or WS_EX_TRANSPARENT
    'Return params
    'End Get
    'End Property




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    Dim p() As Process
    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName("obs64")
        If p.Count > 0 Then
            ' Process is running
            Label1.Text = ("Ready")
        Else
            Form3.Show()
            Me.Hide()
            Label1.Text = ("Recording Status")

        End If
    End Sub


End Class
