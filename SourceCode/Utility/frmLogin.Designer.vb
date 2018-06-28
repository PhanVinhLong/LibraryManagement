<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnSetting = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btnSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.BunifuGradientPanel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuFlatButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnSetting)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnClose)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtPassword)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtUsername)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(364, 459)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetting.Image = Global.Utility.My.Resources.Resources.setting_01
        Me.btnSetting.ImageActive = Nothing
        Me.btnSetting.Location = New System.Drawing.Point(302, 4)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(25, 25)
        Me.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSetting.TabIndex = 6
        Me.btnSetting.TabStop = False
        Me.btnSetting.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Image = Global.Utility.My.Resources.Resources.cancel
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(333, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.Utility.My.Resources.Resources.librarylogo2_01
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(104, 45)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(160, 160)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtPassword.BackgroundImage = CType(resources.GetObject("txtPassword.BackgroundImage"), System.Drawing.Image)
        Me.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPassword.ForeColor = System.Drawing.Color.LightGray
        Me.txtPassword.Icon = CType(resources.GetObject("txtPassword.Icon"), System.Drawing.Image)
        Me.txtPassword.Location = New System.Drawing.Point(72, 299)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(225, 42)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.text = ""
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtUsername.BackgroundImage = CType(resources.GetObject("txtUsername.BackgroundImage"), System.Drawing.Image)
        Me.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUsername.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsername.Icon = CType(resources.GetObject("txtUsername.Icon"), System.Drawing.Image)
        Me.txtUsername.Location = New System.Drawing.Point(72, 241)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(225, 42)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.text = ""
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Teal
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Đăng Nhập"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(72, 369)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(225, 50)
        Me.BunifuFlatButton1.TabIndex = 8
        Me.BunifuFlatButton1.Text = "Đăng Nhập"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 459)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Text = "Đăng nhập"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.btnSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnSetting As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
