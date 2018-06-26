<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemTacGia
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
        Me.lblGioiHanSoLuong = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenTacGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaTacGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(245, 143)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Location = New System.Drawing.Point(124, 143)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(94, 23)
        Me.btnThemVaDong.TabIndex = 10
        Me.btnThemVaDong.Text = "Thêm và Đóng"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(20, 143)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(40, 122)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(153, 13)
        Me.lblCanhBao.TabIndex = 8
        Me.lblCanhBao.Text = "* Số lượng Tác giả đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'lblGioiHanSoLuong
        '
        Me.lblGioiHanSoLuong.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanSoLuong.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanSoLuong.Appearance.Options.UseFont = True
        Me.lblGioiHanSoLuong.Appearance.Options.UseForeColor = True
        Me.lblGioiHanSoLuong.Location = New System.Drawing.Point(40, 107)
        Me.lblGioiHanSoLuong.Name = "lblGioiHanSoLuong"
        Me.lblGioiHanSoLuong.Size = New System.Drawing.Size(117, 13)
        Me.lblGioiHanSoLuong.TabIndex = 7
        Me.lblGioiHanSoLuong.Text = "* Số tác giả/ Tối đa: X/Y"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTenTacGia)
        Me.PanelControl1.Controls.Add(Me.txtMaTacGia)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(20, 19)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(300, 80)
        Me.PanelControl1.TabIndex = 6
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(115, 46)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(159, 20)
        Me.txtTenTacGia.TabIndex = 3
        '
        'txtMaTacGia
        '
        Me.txtMaTacGia.Enabled = False
        Me.txtMaTacGia.Location = New System.Drawing.Point(115, 14)
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.Size = New System.Drawing.Size(159, 20)
        Me.txtMaTacGia.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên tác giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã tác giả"
        '
        'ucThemTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblCanhBao)
        Me.Controls.Add(Me.lblGioiHanSoLuong)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ucThemTacGia"
        Me.Size = New System.Drawing.Size(344, 180)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanSoLuong As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenTacGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaTacGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
