<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restaurants_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Login = New Button()
        Label2 = New Label()
        Password = New TextBox()
        Label1 = New Label()
        Email_Phone = New TextBox()
        Label10 = New Label()
        Label15 = New Label()
        Panel2 = New Panel()
        GetStarted = New Button()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Login)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Password)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Email_Phone)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label15)
        Panel1.Location = New Point(861, 105)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(452, 627)
        Panel1.TabIndex = 0
        ' 
        ' Login
        ' 
        Login.BackColor = Color.Black
        Login.FlatStyle = FlatStyle.Popup
        Login.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.ForeColor = Color.Transparent
        Login.Location = New Point(31, 495)
        Login.Name = "Login"
        Login.Size = New Size(383, 46)
        Login.TabIndex = 26
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(31, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 28)
        Label2.TabIndex = 25
        Label2.Text = "Welcome Back"
        ' 
        ' Password
        ' 
        Password.BackColor = SystemColors.ControlLight
        Password.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(31, 326)
        Password.Name = "Password"
        Password.Size = New Size(383, 34)
        Password.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 287)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 23
        Label1.Text = "Password"
        ' 
        ' Email_Phone
        ' 
        Email_Phone.BackColor = SystemColors.ControlLight
        Email_Phone.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Email_Phone.Location = New Point(31, 222)
        Email_Phone.Name = "Email_Phone"
        Email_Phone.Size = New Size(383, 34)
        Email_Phone.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(31, 183)
        Label10.Name = "Label10"
        Label10.Size = New Size(271, 25)
        Label10.TabIndex = 15
        Label10.Text = "Phone Number / Email ID"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.FlatStyle = FlatStyle.Popup
        Label15.Font = New Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(31, 33)
        Label15.Name = "Label15"
        Label15.Size = New Size(265, 43)
        Label15.TabIndex = 7
        Label15.Text = "RMS Merchants "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSalmon
        Panel2.Controls.Add(GetStarted)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(0, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1478, 75)
        Panel2.TabIndex = 4
        ' 
        ' GetStarted
        ' 
        GetStarted.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GetStarted.Location = New Point(1240, 21)
        GetStarted.Name = "GetStarted"
        GetStarted.Size = New Size(140, 29)
        GetStarted.TabIndex = 9
        GetStarted.Text = "Get started"
        GetStarted.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.RMS
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(104, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 52)
        Label3.TabIndex = 6
        Label3.Text = "RMS" & vbCrLf & "for Merchants" & vbCrLf
        ' 
        ' Restaurants_login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._51951042270_78ea1e8590_h_7
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1420, 794)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Restaurants_login"
        Text = "Restaurants_login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Email_Phone As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GetStarted As Button
    Friend WithEvents Login As Button
End Class
