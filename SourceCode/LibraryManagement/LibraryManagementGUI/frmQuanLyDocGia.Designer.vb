<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyDocGia))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lueChonLoaiDocGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.grcDanhSachDocGia = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachDocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dteNgayLapThe = New DevExpress.XtraEditors.DateEdit()
        Me.dteNgayHetHan = New DevExpress.XtraEditors.DateEdit()
        Me.dteNgaySinh = New DevExpress.XtraEditors.DateEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.txtHoTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.lueLoaiDocGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGiaHanThe = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        Me.btnTimKiem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.lueChonLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dteNgayLapThe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayLapThe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayHetHan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayHetHan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(333, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Loại độc giả"
        '
        'lueChonLoaiDocGia
        '
        Me.lueChonLoaiDocGia.Location = New System.Drawing.Point(399, 9)
        Me.lueChonLoaiDocGia.Name = "lueChonLoaiDocGia"
        Me.lueChonLoaiDocGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueChonLoaiDocGia.Size = New System.Drawing.Size(116, 20)
        Me.lueChonLoaiDocGia.TabIndex = 1
        '
        'grcDanhSachDocGia
        '
        Me.grcDanhSachDocGia.Location = New System.Drawing.Point(14, 50)
        Me.grcDanhSachDocGia.MainView = Me.grvDanhSachDocGia
        Me.grcDanhSachDocGia.Name = "grcDanhSachDocGia"
        Me.grcDanhSachDocGia.Size = New System.Drawing.Size(645, 329)
        Me.grcDanhSachDocGia.TabIndex = 2
        Me.grcDanhSachDocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachDocGia})
        '
        'grvDanhSachDocGia
        '
        Me.grvDanhSachDocGia.GridControl = Me.grcDanhSachDocGia
        Me.grvDanhSachDocGia.Name = "grvDanhSachDocGia"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.PanelControl1.Controls.Add(Me.dteNgayLapThe)
        Me.PanelControl1.Controls.Add(Me.dteNgayHetHan)
        Me.PanelControl1.Controls.Add(Me.dteNgaySinh)
        Me.PanelControl1.Controls.Add(Me.txtEmail)
        Me.PanelControl1.Controls.Add(Me.txtDiaChi)
        Me.PanelControl1.Controls.Add(Me.txtHoTen)
        Me.PanelControl1.Controls.Add(Me.txtMaDocGia)
        Me.PanelControl1.Controls.Add(Me.lueLoaiDocGia)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(665, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(231, 252)
        Me.PanelControl1.TabIndex = 3
        '
        'dteNgayLapThe
        '
        Me.dteNgayLapThe.EditValue = Nothing
        Me.dteNgayLapThe.Location = New System.Drawing.Point(96, 161)
        Me.dteNgayLapThe.Name = "dteNgayLapThe"
        Me.dteNgayLapThe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayLapThe.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayLapThe.Size = New System.Drawing.Size(115, 20)
        Me.dteNgayLapThe.TabIndex = 17
        '
        'dteNgayHetHan
        '
        Me.dteNgayHetHan.EditValue = Nothing
        Me.dteNgayHetHan.Location = New System.Drawing.Point(96, 190)
        Me.dteNgayHetHan.Name = "dteNgayHetHan"
        Me.dteNgayHetHan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayHetHan.Size = New System.Drawing.Size(115, 20)
        Me.dteNgayHetHan.TabIndex = 16
        '
        'dteNgaySinh
        '
        Me.dteNgaySinh.EditValue = Nothing
        Me.dteNgaySinh.Location = New System.Drawing.Point(96, 78)
        Me.dteNgaySinh.Name = "dteNgaySinh"
        Me.dteNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgaySinh.Size = New System.Drawing.Size(115, 20)
        Me.dteNgaySinh.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 133)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(115, 20)
        Me.txtEmail.TabIndex = 14
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(96, 107)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(115, 20)
        Me.txtDiaChi.TabIndex = 13
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(96, 49)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(115, 20)
        Me.txtHoTen.TabIndex = 12
        '
        'txtMaDocGia
        '
        Me.txtMaDocGia.Enabled = False
        Me.txtMaDocGia.Location = New System.Drawing.Point(96, 21)
        Me.txtMaDocGia.Name = "txtMaDocGia"
        Me.txtMaDocGia.Size = New System.Drawing.Size(115, 20)
        Me.txtMaDocGia.TabIndex = 11
        '
        'lueLoaiDocGia
        '
        Me.lueLoaiDocGia.EditValue = ""
        Me.lueLoaiDocGia.Location = New System.Drawing.Point(96, 219)
        Me.lueLoaiDocGia.Name = "lueLoaiDocGia"
        Me.lueLoaiDocGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoaiDocGia.Size = New System.Drawing.Size(115, 20)
        Me.lueLoaiDocGia.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(18, 222)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Loại độc giả"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(18, 193)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Ngày hết hạn"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 164)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "Ngày lập thẻ"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 136)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Email"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(18, 110)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Địa chỉ"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 81)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Ngày sinh"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Họ tên"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mã độc giả"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(790, 354)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(86, 23)
        Me.btnDong.TabIndex = 21
        Me.btnDong.Text = "Đóng"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.Location = New System.Drawing.Point(683, 354)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(86, 23)
        Me.btnXoa.TabIndex = 20
        Me.btnXoa.Text = "Xoá"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(790, 319)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(86, 23)
        Me.btnCapNhat.TabIndex = 19
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnGiaHanThe
        '
        Me.btnGiaHanThe.Location = New System.Drawing.Point(683, 319)
        Me.btnGiaHanThe.Name = "btnGiaHanThe"
        Me.btnGiaHanThe.Size = New System.Drawing.Size(86, 23)
        Me.btnGiaHanThe.TabIndex = 18
        Me.btnGiaHanThe.Text = "Gia hạn"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.Location = New System.Drawing.Point(521, 7)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(88, 23)
        Me.btnTaiLai.TabIndex = 22
        Me.btnTaiLai.Text = "Tải lại"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(47, 9)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(123, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(176, 7)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(88, 23)
        Me.btnTimKiem.TabIndex = 23
        Me.btnTimKiem.Text = "Tìm kiếm"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.Location = New System.Drawing.Point(28, 10)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(16, 16)
        Me.LabelControl10.TabIndex = 24
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnTaiLai)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.lueChonLoaiDocGia)
        Me.PanelControl2.Controls.Add(Me.btnTimKiem)
        Me.PanelControl2.Controls.Add(Me.txtTimKiem)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 8)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(645, 36)
        Me.PanelControl2.TabIndex = 25
        '
        'frmQuanLyDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 395)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnGiaHanThe)
        Me.Controls.Add(Me.grcDanhSachDocGia)
        Me.Name = "frmQuanLyDocGia"
        Me.Text = "Quản lý độc giả"
        CType(Me.lueChonLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dteNgayLapThe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayLapThe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayHetHan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayHetHan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueChonLoaiDocGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grcDanhSachDocGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachDocGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteNgayLapThe As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteNgayHetHan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteNgaySinh As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHoTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueLoaiDocGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGiaHanThe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTimKiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
