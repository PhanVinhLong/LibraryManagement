<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyLoaiDocGia
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
        Me.grcDanhSachLoaiDocGia = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachLoaiDocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grcDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcDanhSachLoaiDocGia
        '
        Me.grcDanhSachLoaiDocGia.Location = New System.Drawing.Point(21, 20)
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
        Me.PanelControl1.Location = New System.Drawing.Point(293, 20)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(251, 94)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã loại độc giả"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(17, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên loại độc giả"
        '
        'txtMaLoaiDocGia
        '
        Me.txtMaLoaiDocGia.Enabled = False
        Me.txtMaLoaiDocGia.Location = New System.Drawing.Point(108, 22)
        Me.txtMaLoaiDocGia.Name = "txtMaLoaiDocGia"
        Me.txtMaLoaiDocGia.Size = New System.Drawing.Size(125, 20)
        Me.txtMaLoaiDocGia.TabIndex = 2
        '
        'txtTenLoaiDocGia
        '
        Me.txtTenLoaiDocGia.Location = New System.Drawing.Point(108, 51)
        Me.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia"
        Me.txtTenLoaiDocGia.Size = New System.Drawing.Size(125, 20)
        Me.txtTenLoaiDocGia.TabIndex = 3
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(429, 129)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(97, 23)
        Me.btnCapNhat.TabIndex = 2
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(310, 165)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 23)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xoá"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(429, 165)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(97, 23)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Đóng"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.Location = New System.Drawing.Point(310, 129)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(97, 23)
        Me.btnTaiLai.TabIndex = 5
        Me.btnTaiLai.Text = "Tải lại"
        '
        'frmQuanLyLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 210)
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
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
