﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dteNamXuatBan = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNamXuatBan = New DevExpress.XtraEditors.LabelControl()
        Me.txtNhaXuatBan = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gleTheLoai = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnXoaTheLoai = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThemTheLoai = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTheLoai = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gleTacGia = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnXoaTacGia = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThemTacGia = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTacGia = New DevExpress.XtraEditors.LabelControl()
        Me.btnTiepNhan = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblGioiHanNamXuatBan = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTriGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayNhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNamXuatBan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNamXuatBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtNhaXuatBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gleTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gleTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Năm xuất bản"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(348, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Nhà xuất bản"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(348, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Trị giá"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(348, 75)
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
        Me.txtTriGia.Location = New System.Drawing.Point(434, 42)
        Me.txtTriGia.Name = "txtTriGia"
        Me.txtTriGia.Size = New System.Drawing.Size(110, 20)
        Me.txtTriGia.TabIndex = 8
        '
        'dteNgayNhap
        '
        Me.dteNgayNhap.EditValue = Nothing
        Me.dteNgayNhap.Location = New System.Drawing.Point(434, 72)
        Me.dteNgayNhap.Name = "dteNgayNhap"
        Me.dteNgayNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayNhap.Size = New System.Drawing.Size(138, 20)
        Me.dteNgayNhap.TabIndex = 9
        '
        'dteNamXuatBan
        '
        Me.dteNamXuatBan.EditValue = Nothing
        Me.dteNamXuatBan.Location = New System.Drawing.Point(106, 72)
        Me.dteNamXuatBan.Name = "dteNamXuatBan"
        Me.dteNamXuatBan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNamXuatBan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNamXuatBan.Size = New System.Drawing.Size(138, 20)
        Me.dteNamXuatBan.TabIndex = 10
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.lblNamXuatBan)
        Me.PanelControl1.Controls.Add(Me.txtNhaXuatBan)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.txtMaSach)
        Me.PanelControl1.Controls.Add(Me.lblMaSach)
        Me.PanelControl1.Controls.Add(Me.dteNamXuatBan)
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
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(546, 44)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 16)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "VNĐ"
        '
        'lblNamXuatBan
        '
        Me.lblNamXuatBan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblNamXuatBan.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblNamXuatBan.Appearance.Options.UseFont = True
        Me.lblNamXuatBan.Appearance.Options.UseForeColor = True
        Me.lblNamXuatBan.Location = New System.Drawing.Point(248, 75)
        Me.lblNamXuatBan.Name = "lblNamXuatBan"
        Me.lblNamXuatBan.Size = New System.Drawing.Size(68, 13)
        Me.lblNamXuatBan.TabIndex = 22
        Me.lblNamXuatBan.Text = "Đã XB xx năm"
        '
        'txtNhaXuatBan
        '
        Me.txtNhaXuatBan.Location = New System.Drawing.Point(434, 12)
        Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
        Me.txtNhaXuatBan.Size = New System.Drawing.Size(138, 20)
        Me.txtNhaXuatBan.TabIndex = 21
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.gleTheLoai)
        Me.PanelControl3.Controls.Add(Me.btnXoaTheLoai)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Controls.Add(Me.btnThemTheLoai)
        Me.PanelControl3.Controls.Add(Me.lblTheLoai)
        Me.PanelControl3.Location = New System.Drawing.Point(11, 162)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(561, 50)
        Me.PanelControl3.TabIndex = 20
        '
        'gleTheLoai
        '
        Me.gleTheLoai.Location = New System.Drawing.Point(57, 5)
        Me.gleTheLoai.Name = "gleTheLoai"
        Me.gleTheLoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleTheLoai.Properties.PopupView = Me.GridView1
        Me.gleTheLoai.Size = New System.Drawing.Size(141, 20)
        Me.gleTheLoai.TabIndex = 22
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnXoaTheLoai
        '
        Me.btnXoaTheLoai.Location = New System.Drawing.Point(285, 5)
        Me.btnXoaTheLoai.Name = "btnXoaTheLoai"
        Me.btnXoaTheLoai.Size = New System.Drawing.Size(73, 20)
        Me.btnXoaTheLoai.TabIndex = 20
        Me.btnXoaTheLoai.Text = "Xoá"
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
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gleTacGia)
        Me.PanelControl2.Controls.Add(Me.btnXoaTacGia)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.btnThemTacGia)
        Me.PanelControl2.Controls.Add(Me.lblTacGia)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 104)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(561, 50)
        Me.PanelControl2.TabIndex = 16
        '
        'gleTacGia
        '
        Me.gleTacGia.Location = New System.Drawing.Point(57, 5)
        Me.gleTacGia.Name = "gleTacGia"
        Me.gleTacGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleTacGia.Properties.PopupView = Me.GridLookUpEdit1View
        Me.gleTacGia.Size = New System.Drawing.Size(141, 20)
        Me.gleTacGia.TabIndex = 21
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnXoaTacGia
        '
        Me.btnXoaTacGia.Location = New System.Drawing.Point(285, 5)
        Me.btnXoaTacGia.Name = "btnXoaTacGia"
        Me.btnXoaTacGia.Size = New System.Drawing.Size(73, 20)
        Me.btnXoaTacGia.TabIndex = 20
        Me.btnXoaTacGia.Text = "Xoá"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Tác giả"
        '
        'btnThemTacGia
        '
        Me.btnThemTacGia.Location = New System.Drawing.Point(204, 5)
        Me.btnThemTacGia.Name = "btnThemTacGia"
        Me.btnThemTacGia.Size = New System.Drawing.Size(73, 20)
        Me.btnThemTacGia.TabIndex = 16
        Me.btnThemTacGia.Text = "Thêm"
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
        'btnTiepNhan
        '
        Me.btnTiepNhan.Location = New System.Drawing.Point(90, 271)
        Me.btnTiepNhan.Name = "btnTiepNhan"
        Me.btnTiepNhan.Size = New System.Drawing.Size(110, 23)
        Me.btnTiepNhan.TabIndex = 13
        Me.btnTiepNhan.Text = "Tiếp nhận"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(258, 271)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "Tiếp nhận và Đóng"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(427, 271)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Đóng"
        '
        'lblGioiHanNamXuatBan
        '
        Me.lblGioiHanNamXuatBan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanNamXuatBan.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanNamXuatBan.Appearance.Options.UseFont = True
        Me.lblGioiHanNamXuatBan.Appearance.Options.UseForeColor = True
        Me.lblGioiHanNamXuatBan.Location = New System.Drawing.Point(34, 249)
        Me.lblGioiHanNamXuatBan.Name = "lblGioiHanNamXuatBan"
        Me.lblGioiHanNamXuatBan.Size = New System.Drawing.Size(184, 13)
        Me.lblGioiHanNamXuatBan.TabIndex = 24
        Me.lblGioiHanNamXuatBan.Text = "* Chỉ nhận sách xuất bản trong X năm"
        '
        'frmTiepNhanSachMoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 305)
        Me.Controls.Add(Me.lblGioiHanNamXuatBan)
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
        CType(Me.dteNamXuatBan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNamXuatBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtNhaXuatBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.gleTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.gleTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents dteNamXuatBan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnTiepNhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThemTheLoai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTheLoai As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThemTacGia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTacGia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnXoaTheLoai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoaTacGia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNhaXuatBan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNamXuatBan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gleTheLoai As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleTacGia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanNamXuatBan As DevExpress.XtraEditors.LabelControl
End Class
