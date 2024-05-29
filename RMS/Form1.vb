Public Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim ratioheight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim ratiowidth As Double = (Me.Width - CuRWidth) / CuRWidth

        For Each CtrL As Control In Controls
            CtrL.Width += CtrL.Width * ratiowidth
            CtrL.Left += CtrL.Left * ratiowidth
            CtrL.Top += CtrL.Top * ratioheight
            CtrL.Height += CtrL.Height * ratioheight

        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
