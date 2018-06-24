<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTheLoaiSach
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
        Me.grcDanhSachTheLoai = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachTheLoai = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMaTheLoai = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grcDanhSachTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcDanhSachTheLoai
        '
        Me.grcDanhSachTheLoai.Location = New System.Drawing.Point(21, 22)
        Me.grcDanhSachTheLoai.MainView = Me.grvDanhSachTheLoai
        Me.grcDanhSachTheLoai.Name = "grcDanhSachTheLoai"
        Me.grcDanhSachTheLoai.Size = New System.Drawing.Size(264, 173)
        Me.grcDanhSachTheLoai.TabIndex = 0
        Me.grcDanhSachTheLoai.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachTheLoai})
        '
        'grvDanhSachTheLoai
        '
        Me.grvDanhSachTheLoai.GridControl = Me.grcDanhSachTheLoai
        Me.grvDanhSachTheLoai.Name = "grvDanhSachTheLoai"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtMaTheLoai)
        Me.PanelControl1.Controls.Add(Me.txtTenTheLoai)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(295, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(254, 91)
        Me.PanelControl1.TabIndex = 1
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(108, 51)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(125, 20)
        Me.txtTenTheLoai.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên thể loại"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã thể loại"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.Location = New System.Drawing.Point(310, 130)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(100, 23)
        Me.btnTaiLai.TabIndex = 2
        Me.btnTaiLai.Text = "Tải lại"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(438, 130)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(100, 23)
        Me.btnCapNhat.TabIndex = 3
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(310, 165)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xoá"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(438, 165)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(100, 23)
        Me.btnDong.TabIndex = 5
        Me.btnDong.Text = "Đóng"
        '
        'txtMaTheLoai
        '
        Me.txtMaTheLoai.Enabled = False
        Me.txtMaTheLoai.Location = New System.Drawing.Point(108, 20)
        Me.txtMaTheLoai.Name = "txtMaTheLoai"
        Me.txtMaTheLoai.Size = New System.Drawing.Size(125, 20)
        Me.txtMaTheLoai.TabIndex = 4
        '
        'frmQuanLyTheLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 214)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnTaiLai)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.grcDanhSachTheLoai)
        Me.Name = "frmQuanLyTheLoaiSach"
        Me.Text = "Quản lý thể loại sách"
        CType(Me.grcDanhSachTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grcDanhSachTheLoai As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachTheLoai As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaTheLoai As DevExpress.XtraEditors.TextEdit
End Class
