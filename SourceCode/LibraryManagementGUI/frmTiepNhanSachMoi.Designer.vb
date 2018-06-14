<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiepNhanSachMoi
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
        Me.lblMaSach = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaSach = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenSach = New DevExpress.XtraEditors.TextEdit()
        Me.txtTriGia = New DevExpress.XtraEditors.TextEdit()
        Me.dteNgayNhap = New DevExpress.XtraEditors.DateEdit()
        Me.dteNgayXuatBan = New DevExpress.XtraEditors.DateEdit()
        Me.lueNhaXuatBan = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnTiepNhan = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.lueTacGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTacGia = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.lueTheLoai = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThemTheLoai = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTheLoai = New DevExpress.XtraEditors.LabelControl()
        Me.btnClearTacGia = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClearTheLoai = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTriGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayNhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayXuatBan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayXuatBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNhaXuatBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lueTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.lueTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSach
        '
        Me.lblMaSach.Location = New System.Drawing.Point(16, 15)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(39, 13)
        Me.lblMaSach.TabIndex = 0
        Me.lblMaSach.Text = "Mã sách"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tên sách"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Ngày xuất bản"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(348, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Nhà xuất bản"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(348, 49)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Trị giá"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(348, 79)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Ngày nhập"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(106, 12)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(138, 20)
        Me.txtMaSach.TabIndex = 6
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(106, 42)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(138, 20)
        Me.txtTenSach.TabIndex = 7
        '
        'txtTriGia
        '
        Me.txtTriGia.Location = New System.Drawing.Point(434, 46)
        Me.txtTriGia.Name = "txtTriGia"
        Me.txtTriGia.Size = New System.Drawing.Size(138, 20)
        Me.txtTriGia.TabIndex = 8
        '
        'dteNgayNhap
        '
        Me.dteNgayNhap.EditValue = Nothing
        Me.dteNgayNhap.Location = New System.Drawing.Point(434, 76)
        Me.dteNgayNhap.Name = "dteNgayNhap"
        Me.dteNgayNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayNhap.Size = New System.Drawing.Size(138, 20)
        Me.dteNgayNhap.TabIndex = 9
        '
        'dteNgayXuatBan
        '
        Me.dteNgayXuatBan.EditValue = Nothing
        Me.dteNgayXuatBan.Location = New System.Drawing.Point(106, 72)
        Me.dteNgayXuatBan.Name = "dteNgayXuatBan"
        Me.dteNgayXuatBan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayXuatBan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayXuatBan.Size = New System.Drawing.Size(138, 20)
        Me.dteNgayXuatBan.TabIndex = 10
        '
        'lueNhaXuatBan
        '
        Me.lueNhaXuatBan.Location = New System.Drawing.Point(434, 16)
        Me.lueNhaXuatBan.Name = "lueNhaXuatBan"
        Me.lueNhaXuatBan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNhaXuatBan.Size = New System.Drawing.Size(138, 20)
        Me.lueNhaXuatBan.TabIndex = 11
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.txtMaSach)
        Me.PanelControl1.Controls.Add(Me.lueNhaXuatBan)
        Me.PanelControl1.Controls.Add(Me.lblMaSach)
        Me.PanelControl1.Controls.Add(Me.dteNgayXuatBan)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.dteNgayNhap)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtTriGia)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtTenSach)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Location = New System.Drawing.Point(23, 21)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(590, 226)
        Me.PanelControl1.TabIndex = 12
        '
        'btnTiepNhan
        '
        Me.btnTiepNhan.Location = New System.Drawing.Point(94, 264)
        Me.btnTiepNhan.Name = "btnTiepNhan"
        Me.btnTiepNhan.Size = New System.Drawing.Size(110, 23)
        Me.btnTiepNhan.TabIndex = 13
        Me.btnTiepNhan.Text = "Tiếp nhận"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(262, 264)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "Tiếp nhận và Đóng"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(431, 264)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Đóng"
        '
        'lueTacGia
        '
        Me.lueTacGia.Location = New System.Drawing.Point(57, 5)
        Me.lueTacGia.Name = "lueTacGia"
        Me.lueTacGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTacGia.Size = New System.Drawing.Size(138, 20)
        Me.lueTacGia.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Tác giả"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(204, 5)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(73, 20)
        Me.SimpleButton3.TabIndex = 16
        Me.SimpleButton3.Text = "Thêm"
        '
        'lblTacGia
        '
        Me.lblTacGia.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTacGia.Appearance.Options.UseFont = True
        Me.lblTacGia.Location = New System.Drawing.Point(60, 31)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(106, 13)
        Me.lblTacGia.TabIndex = 19
        Me.lblTacGia.Text = "Tác giả X, Tác giả Y"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnClearTacGia)
        Me.PanelControl2.Controls.Add(Me.lueTacGia)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.lblTacGia)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 104)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(561, 50)
        Me.PanelControl2.TabIndex = 16
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnClearTheLoai)
        Me.PanelControl3.Controls.Add(Me.lueTheLoai)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Controls.Add(Me.btnThemTheLoai)
        Me.PanelControl3.Controls.Add(Me.lblTheLoai)
        Me.PanelControl3.Location = New System.Drawing.Point(11, 162)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(561, 50)
        Me.PanelControl3.TabIndex = 20
        '
        'lueTheLoai
        '
        Me.lueTheLoai.Location = New System.Drawing.Point(57, 5)
        Me.lueTheLoai.Name = "lueTheLoai"
        Me.lueTheLoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTheLoai.Size = New System.Drawing.Size(138, 20)
        Me.lueTheLoai.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Thể loại"
        '
        'btnThemTheLoai
        '
        Me.btnThemTheLoai.Location = New System.Drawing.Point(204, 5)
        Me.btnThemTheLoai.Name = "btnThemTheLoai"
        Me.btnThemTheLoai.Size = New System.Drawing.Size(73, 20)
        Me.btnThemTheLoai.TabIndex = 16
        Me.btnThemTheLoai.Text = "Thêm"
        '
        'lblTheLoai
        '
        Me.lblTheLoai.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTheLoai.Appearance.Options.UseFont = True
        Me.lblTheLoai.Location = New System.Drawing.Point(60, 31)
        Me.lblTheLoai.Name = "lblTheLoai"
        Me.lblTheLoai.Size = New System.Drawing.Size(114, 13)
        Me.lblTheLoai.TabIndex = 19
        Me.lblTheLoai.Text = "Thể loại X, Thể loại Y"
        '
        'btnClearTacGia
        '
        Me.btnClearTacGia.Location = New System.Drawing.Point(285, 5)
        Me.btnClearTacGia.Name = "btnClearTacGia"
        Me.btnClearTacGia.Size = New System.Drawing.Size(73, 20)
        Me.btnClearTacGia.TabIndex = 20
        Me.btnClearTacGia.Text = "Clear"
        '
        'btnClearTheLoai
        '
        Me.btnClearTheLoai.Location = New System.Drawing.Point(285, 5)
        Me.btnClearTheLoai.Name = "btnClearTheLoai"
        Me.btnClearTheLoai.Size = New System.Drawing.Size(73, 20)
        Me.btnClearTheLoai.TabIndex = 20
        Me.btnClearTheLoai.Text = "Clear"
        '
        'frmTiepNhanSachMoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 305)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnTiepNhan)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmTiepNhanSachMoi"
        Me.Text = "Tiếp nhận sách mới"
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTriGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayNhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayXuatBan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayXuatBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNhaXuatBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.lueTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.lueTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMaSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTriGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteNgayNhap As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteNgayXuatBan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueNhaXuatBan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnTiepNhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lueTheLoai As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThemTheLoai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTheLoai As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lueTacGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTacGia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnClearTheLoai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClearTacGia As DevExpress.XtraEditors.SimpleButton
End Class
