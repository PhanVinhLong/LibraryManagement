<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemTheLoai
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThemVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCanhBao = New DevExpress.XtraEditors.LabelControl()
        Me.lblGioiHanSoLuong = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTenTheLoai)
        Me.PanelControl1.Controls.Add(Me.txtMaTheLoai)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(29, 19)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(290, 77)
        Me.PanelControl1.TabIndex = 9
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(129, 44)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(135, 20)
        Me.txtTenTheLoai.TabIndex = 3
        '
        'txtMaTheLoai
        '
        Me.txtMaTheLoai.Enabled = False
        Me.txtMaTheLoai.Location = New System.Drawing.Point(129, 15)
        Me.txtMaTheLoai.Name = "txtMaTheLoai"
        Me.txtMaTheLoai.Size = New System.Drawing.Size(135, 20)
        Me.txtMaTheLoai.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên thể loại sách"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã thể loại sách"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(242, 141)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 14
        Me.btnDong.Text = "Đóng"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Location = New System.Drawing.Point(129, 141)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(92, 23)
        Me.btnThemVaDong.TabIndex = 13
        Me.btnThemVaDong.Text = "Thêm và Đóng"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(32, 141)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(49, 121)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(181, 13)
        Me.lblCanhBao.TabIndex = 11
        Me.lblCanhBao.Text = "* Số lượng Thể loại sách đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'lblGioiHanSoLuong
        '
        Me.lblGioiHanSoLuong.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanSoLuong.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanSoLuong.Appearance.Options.UseFont = True
        Me.lblGioiHanSoLuong.Appearance.Options.UseForeColor = True
        Me.lblGioiHanSoLuong.Location = New System.Drawing.Point(49, 105)
        Me.lblGioiHanSoLuong.Name = "lblGioiHanSoLuong"
        Me.lblGioiHanSoLuong.Size = New System.Drawing.Size(147, 13)
        Me.lblGioiHanSoLuong.TabIndex = 10
        Me.lblGioiHanSoLuong.Text = "* Số Thể loại sách/ Tối đa: X/Y"
        '
        'ucThemTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblCanhBao)
        Me.Controls.Add(Me.lblGioiHanSoLuong)
        Me.Name = "ucThemTheLoai"
        Me.Size = New System.Drawing.Size(346, 181)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanSoLuong As DevExpress.XtraEditors.LabelControl
End Class
