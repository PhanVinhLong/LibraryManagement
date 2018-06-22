<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemTheLoaiSach
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblGioiHanSoLuong = New DevExpress.XtraEditors.LabelControl()
        Me.lblCanhBao = New DevExpress.XtraEditors.LabelControl()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThemVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
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
        Me.PanelControl1.Location = New System.Drawing.Point(23, 18)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(290, 77)
        Me.PanelControl1.TabIndex = 0
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(125, 43)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(135, 20)
        Me.txtTenTheLoai.TabIndex = 3
        '
        'txtMaTheLoai
        '
        Me.txtMaTheLoai.Enabled = False
        Me.txtMaTheLoai.Location = New System.Drawing.Point(125, 14)
        Me.txtMaTheLoai.Name = "txtMaTheLoai"
        Me.txtMaTheLoai.Size = New System.Drawing.Size(135, 20)
        Me.txtMaTheLoai.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên thể loại sách"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã thể loại sách"
        '
        'lblGioiHanSoLuong
        '
        Me.lblGioiHanSoLuong.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanSoLuong.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanSoLuong.Appearance.Options.UseFont = True
        Me.lblGioiHanSoLuong.Appearance.Options.UseForeColor = True
        Me.lblGioiHanSoLuong.Location = New System.Drawing.Point(43, 104)
        Me.lblGioiHanSoLuong.Name = "lblGioiHanSoLuong"
        Me.lblGioiHanSoLuong.Size = New System.Drawing.Size(147, 13)
        Me.lblGioiHanSoLuong.TabIndex = 4
        Me.lblGioiHanSoLuong.Text = "* Số Thể loại sách/ Tối đa: X/Y"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(43, 120)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(181, 13)
        Me.lblCanhBao.TabIndex = 5
        Me.lblCanhBao.Text = "* Số lượng Thể loại sách đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(26, 140)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Location = New System.Drawing.Point(123, 140)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(92, 23)
        Me.btnThemVaDong.TabIndex = 7
        Me.btnThemVaDong.Text = "Thêm và Đóng"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(236, 140)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 8
        Me.btnDong.Text = "Đóng"
        '
        'frmThemTheLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 178)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblCanhBao)
        Me.Controls.Add(Me.lblGioiHanSoLuong)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmThemTheLoaiSach"
        Me.Text = "Thêm thể loại sách"
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
    Friend WithEvents lblGioiHanSoLuong As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
End Class
