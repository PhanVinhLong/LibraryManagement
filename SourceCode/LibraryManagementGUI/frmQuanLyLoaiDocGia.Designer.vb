<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyLoaiDocGia
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyLoaiDocGia))
        Me.grcDanhSachLoaiDocGia = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachLoaiDocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grcDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcDanhSachLoaiDocGia
        '
        Me.grcDanhSachLoaiDocGia.Location = New System.Drawing.Point(21, 47)
        Me.grcDanhSachLoaiDocGia.MainView = Me.grvDanhSachLoaiDocGia
        Me.grcDanhSachLoaiDocGia.Name = "grcDanhSachLoaiDocGia"
        Me.grcDanhSachLoaiDocGia.Size = New System.Drawing.Size(257, 172)
        Me.grcDanhSachLoaiDocGia.TabIndex = 0
        Me.grcDanhSachLoaiDocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachLoaiDocGia})
        '
        'grvDanhSachLoaiDocGia
        '
        Me.grvDanhSachLoaiDocGia.GridControl = Me.grcDanhSachLoaiDocGia
        Me.grvDanhSachLoaiDocGia.Name = "grvDanhSachLoaiDocGia"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTenLoaiDocGia)
        Me.PanelControl1.Controls.Add(Me.txtMaLoaiDocGia)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(293, 47)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(251, 94)
        Me.PanelControl1.TabIndex = 1
        '
        'txtTenLoaiDocGia
        '
        Me.txtTenLoaiDocGia.Location = New System.Drawing.Point(108, 51)
        Me.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia"
        Me.txtTenLoaiDocGia.Size = New System.Drawing.Size(125, 20)
        Me.txtTenLoaiDocGia.TabIndex = 3
        '
        'txtMaLoaiDocGia
        '
        Me.txtMaLoaiDocGia.Enabled = False
        Me.txtMaLoaiDocGia.Location = New System.Drawing.Point(108, 22)
        Me.txtMaLoaiDocGia.Name = "txtMaLoaiDocGia"
        Me.txtMaLoaiDocGia.Size = New System.Drawing.Size(125, 20)
        Me.txtMaLoaiDocGia.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(17, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên loại độc giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã loại độc giả"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(429, 156)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(97, 23)
        Me.btnCapNhat.TabIndex = 2
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(310, 192)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 23)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xoá"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(429, 192)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(97, 23)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Đóng"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.Location = New System.Drawing.Point(310, 156)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(97, 23)
        Me.btnTaiLai.TabIndex = 5
        Me.btnTaiLai.Text = "Tải lại"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.btnClear)
        Me.PanelControl2.Controls.Add(Me.txtTimKiem)
        Me.PanelControl2.Location = New System.Drawing.Point(21, 5)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(257, 36)
        Me.PanelControl2.TabIndex = 26
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.Location = New System.Drawing.Point(7, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(16, 16)
        Me.LabelControl10.TabIndex = 24
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(27, 8)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(141, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'frmQuanLyLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 234)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.btnTaiLai)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.grcDanhSachLoaiDocGia)
        Me.Name = "frmQuanLyLoaiDocGia"
        Me.Text = "Quản lý loại độc giả"
        CType(Me.grcDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grcDanhSachLoaiDocGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachLoaiDocGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
End Class
