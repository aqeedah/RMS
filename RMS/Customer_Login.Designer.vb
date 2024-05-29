<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Login))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label15 = New Label()
        Label16 = New Label()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Login = New Button()
        Label2 = New Label()
        Password = New TextBox()
        Label1 = New Label()
        Email_Phone = New TextBox()
        Label10 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(700, 874)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.c9252e6c6cd289c588c3381bc77b1dfc
        PictureBox2.Image = My.Resources.Resources.c9252e6c6cd289c588c3381bc77b1dfc
        PictureBox2.Location = New Point(699, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(712, 874)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSalmon
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(-5, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1421, 72)
        Panel2.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1262, 25)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 29
        PictureBox4.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.FlatStyle = FlatStyle.Popup
        Label15.Font = New Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ButtonHighlight
        Label15.Location = New Point(109, 20)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 34)
        Label15.TabIndex = 44
        Label15.Text = "RMS"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(1291, 18)
        Label16.Name = "Label16"
        Label16.Size = New Size(109, 36)
        Label16.TabIndex = 28
        Label16.Text = "Sign up"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.RMS
        PictureBox3.Location = New Point(4, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(101, 72)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 43
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Login)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Password)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Email_Phone)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(648, 97)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(452, 627)
        Panel1.TabIndex = 5
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(31, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(244, 43)
        Label3.TabIndex = 7
        Label3.Text = "RMS Customer"
        ' 
        ' Customer_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1398, 874)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Customer_Login"
        Text = "Customer_Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Email_Phone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
End Class
