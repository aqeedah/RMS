<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Reg))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Confirmpassword = New TextBox()
        Label3 = New Label()
        Label17 = New Label()
        Password = New TextBox()
        Submit = New Button()
        Mobilenumber = New TextBox()
        ComboBox2 = New ComboBox()
        Label12 = New Label()
        Lastname = New TextBox()
        Email = New TextBox()
        Firstname = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        StoreAddress = New TextBox()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        Label15 = New Label()
        PictureBox4 = New PictureBox()
        Label16 = New Label()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(700, 867)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.c9252e6c6cd289c588c3381bc77b1dfc
        PictureBox2.Image = My.Resources.Resources.c9252e6c6cd289c588c3381bc77b1dfc
        PictureBox2.Location = New Point(704, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(712, 867)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(StoreAddress)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Confirmpassword)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Password)
        Panel1.Controls.Add(Submit)
        Panel1.Controls.Add(Mobilenumber)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Lastname)
        Panel1.Controls.Add(Email)
        Panel1.Controls.Add(Firstname)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(550, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(589, 785)
        Panel1.TabIndex = 2
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
        Panel2.TabIndex = 3
        ' 
        ' Confirmpassword
        ' 
        Confirmpassword.BackColor = SystemColors.ControlLight
        Confirmpassword.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Confirmpassword.Location = New Point(27, 531)
        Confirmpassword.Name = "Confirmpassword"
        Confirmpassword.Size = New Size(531, 34)
        Confirmpassword.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 503)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 25)
        Label3.TabIndex = 39
        Label3.Text = "Confirm Password"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(27, 417)
        Label17.Name = "Label17"
        Label17.Size = New Size(109, 25)
        Label17.TabIndex = 38
        Label17.Text = "Password"
        ' 
        ' Password
        ' 
        Password.BackColor = SystemColors.ControlLight
        Password.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(30, 445)
        Password.Name = "Password"
        Password.Size = New Size(531, 34)
        Password.TabIndex = 37
        ' 
        ' Submit
        ' 
        Submit.BackColor = Color.Black
        Submit.FlatStyle = FlatStyle.Popup
        Submit.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Submit.ForeColor = Color.Transparent
        Submit.Location = New Point(30, 693)
        Submit.Name = "Submit"
        Submit.Size = New Size(531, 46)
        Submit.TabIndex = 36
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' Mobilenumber
        ' 
        Mobilenumber.BackColor = SystemColors.ControlLight
        Mobilenumber.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Mobilenumber.Location = New Point(121, 264)
        Mobilenumber.Name = "Mobilenumber"
        Mobilenumber.Size = New Size(435, 34)
        Mobilenumber.TabIndex = 35
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ControlLight
        ComboBox2.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"🇨🇦            Canada             +1"})
        ComboBox2.Location = New Point(30, 264)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(65, 34)
        ComboBox2.TabIndex = 34
        ComboBox2.Text = "CA"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(27, 324)
        Label12.Name = "Label12"
        Label12.Size = New Size(68, 25)
        Label12.TabIndex = 33
        Label12.Text = "Email"
        ' 
        ' Lastname
        ' 
        Lastname.BackColor = SystemColors.ControlLight
        Lastname.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lastname.Location = New Point(317, 106)
        Lastname.Name = "Lastname"
        Lastname.Size = New Size(241, 34)
        Lastname.TabIndex = 32
        ' 
        ' Email
        ' 
        Email.BackColor = SystemColors.ControlLight
        Email.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Email.Location = New Point(27, 352)
        Email.Name = "Email"
        Email.Size = New Size(531, 34)
        Email.TabIndex = 31
        ' 
        ' Firstname
        ' 
        Firstname.BackColor = SystemColors.ControlLight
        Firstname.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Firstname.Location = New Point(27, 106)
        Firstname.Name = "Firstname"
        Firstname.Size = New Size(241, 34)
        Firstname.TabIndex = 30
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(317, 78)
        Label11.Name = "Label11"
        Label11.Size = New Size(117, 25)
        Label11.TabIndex = 29
        Label11.Text = "Last name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(27, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(234, 25)
        Label10.TabIndex = 28
        Label10.Text = "Mobile phone number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(27, 78)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 25)
        Label9.TabIndex = 27
        Label9.Text = "First name"
        ' 
        ' StoreAddress
        ' 
        StoreAddress.BackColor = SystemColors.ControlLight
        StoreAddress.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StoreAddress.Location = New Point(27, 184)
        StoreAddress.Name = "StoreAddress"
        StoreAddress.Size = New Size(531, 34)
        StoreAddress.TabIndex = 42
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 25)
        Label1.TabIndex = 41
        Label1.Text = "Address"
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
        ' PictureBox4
        ' 
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1273, 25)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 23)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 29
        PictureBox4.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(1303, 18)
        Label16.Name = "Label16"
        Label16.Size = New Size(85, 36)
        Label16.TabIndex = 28
        Label16.Text = "Login"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(44, 630)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(462, 48)
        CheckBox1.TabIndex = 44
        CheckBox1.Text = "     I agree to RMS's Terms of Service, Privacy Policy " & vbCrLf & "     and Content Policies"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calisto MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(44, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 42)
        Label2.TabIndex = 45
        Label2.Text = "Sign up"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(44, 588)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(195, 23)
        LinkLabel1.TabIndex = 47
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Have a referral code?"
        ' 
        ' Customer_Reg
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1414, 868)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Customer_Reg"
        Text = "Customer_Reg"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Confirmpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Mobilenumber As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Lastname As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents StoreAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
