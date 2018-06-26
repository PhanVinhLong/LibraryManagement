<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemLoaiDocGia
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThemVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCanhBao = New DevExpress.XtraEditors.LabelControl()
        Me.lblGioiHanLoaiDocGia = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(255, 152)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(84, 23)
        Me.btnDong.TabIndex = 14
        Me.btnDong.Text = "Đóng"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Location = New System.Drawing.Point(142, 152)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(84, 23)
        Me.btnThemVaDong.TabIndex = 13
        Me.btnThemVaDong.Text = "Thêm và Đóng"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(28, 152)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 23)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(53, 131)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(172, 13)
        Me.lblCanhBao.TabIndex = 11
        Me.lblCanhBao.Text = "* Số lượng loại độc giả đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'lblGioiHanLoaiDocGia
        '
        Me.lblGioiHanLoaiDocGia.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanLoaiDocGia.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanLoaiDocGia.Appearance.Options.UseFont = True
        Me.lblGioiHanLoaiDocGia.Appearance.Options.UseForeColor = True
        Me.lblGioiHanLoaiDocGia.Location = New System.Drawing.Point(53, 113)
        Me.lblGioiHanLoaiDocGia.Name = "lblGioiHanLoaiDocGia"
        Me.lblGioiHanLoaiDocGia.Size = New System.Drawing.Size(141, 13)
        Me.lblGioiHanLoaiDocGia.TabIndex = 10
        Me.lblGioiHanLoaiDocGia.Text = "* Số Loại độc giả/ Tối đa: X/Y"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTenLoaiDocGia)
        Me.PanelControl1.Controls.Add(Me.txtMaLoaiDocGia)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(28, 21)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(311, 83)
        Me.PanelControl1.TabIndex = 9
        '
        'txtTenLoaiDocGia
        '
        Me.txtTenLoaiDocGia.Location = New System.Drawing.Point(127, 49)
        Me.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia"
        Me.txtTenLoaiDocGia.Size = New System.Drawing.Size(139, 20)
        Me.txtTenLoaiDocGia.TabIndex = 3
        '
        'txtMaLoaiDocGia
        '
        Me.txtMaLoaiDocGia.Enabled = False
        Me.txtMaLoaiDocGia.Location = New System.Drawing.Point(127, 15)
        Me.txtMaLoaiDocGia.Name = "txtMaLoaiDocGia"
        Me.txtMaLoaiDocGia.Size = New System.Drawing.Size(139, 20)
        Me.txtMaLoaiDocGia.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên loại độc giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã loại độc giả"
        '
        'ucThemLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblCanhBao)
        Me.Controls.Add(Me.lblGioiHanLoaiDocGia)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ucThemLoaiDocGia"
        Me.Size = New System.Drawing.Size(367, 193)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanLoaiDocGia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
