<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChoMuonSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucChoMuonSach))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lueChonLoaiDocGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        Me.grcDanhSachDocGia = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachDocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblSachMuonQuaHan = New DevExpress.XtraEditors.LabelControl()
        Me.lblSachMuonConHan = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.lueChonLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnTaiLai)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.lueChonLoaiDocGia)
        Me.PanelControl2.Controls.Add(Me.txtTimKiem)
        Me.PanelControl2.Location = New System.Drawing.Point(29, 19)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(591, 39)
        Me.PanelControl2.TabIndex = 41
        '
        'btnTaiLai
        '
        Me.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaiLai.ImageOptions.ImageUri.Uri = "Reset;Size16x16;Office2013"
        Me.btnTaiLai.Location = New System.Drawing.Point(477, 8)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(84, 22)
        Me.btnTaiLai.TabIndex = 22
        Me.btnTaiLai.Text = "Tải lại"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl10.Location = New System.Drawing.Point(10, 11)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Tìm kiếm"
        '
        'lueChonLoaiDocGia
        '
        Me.lueChonLoaiDocGia.EditValue = " "
        Me.lueChonLoaiDocGia.Location = New System.Drawing.Point(355, 9)
        Me.lueChonLoaiDocGia.Name = "lueChonLoaiDocGia"
        Me.lueChonLoaiDocGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueChonLoaiDocGia.Size = New System.Drawing.Size(116, 20)
        Me.lueChonLoaiDocGia.TabIndex = 1
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(77, 11)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(126, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'grcDanhSachDocGia
        '
        Me.grcDanhSachDocGia.Location = New System.Drawing.Point(29, 64)
        Me.grcDanhSachDocGia.MainView = Me.grvDanhSachDocGia
        Me.grcDanhSachDocGia.Name = "grcDanhSachDocGia"
        Me.grcDanhSachDocGia.Size = New System.Drawing.Size(591, 135)
        Me.grcDanhSachDocGia.TabIndex = 40
        Me.grcDanhSachDocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachDocGia})
        '
        'grvDanhSachDocGia
        '
        Me.grvDanhSachDocGia.GridControl = Me.grcDanhSachDocGia
        Me.grvDanhSachDocGia.Name = "grvDanhSachDocGia"
        '
        'lblSachMuonQuaHan
        '
        Me.lblSachMuonQuaHan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSachMuonQuaHan.Appearance.Options.UseFont = True
        Me.lblSachMuonQuaHan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSachMuonQuaHan.Location = New System.Drawing.Point(5, 24)
        Me.lblSachMuonQuaHan.Name = "lblSachMuonQuaHan"
        Me.lblSachMuonQuaHan.Size = New System.Drawing.Size(331, 13)
        Me.lblSachMuonQuaHan.TabIndex = 42
        Me.lblSachMuonQuaHan.Text = "Sách XYZ, Sách ABC"
        '
        'lblSachMuonConHan
        '
        Me.lblSachMuonConHan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSachMuonConHan.Appearance.Options.UseFont = True
        Me.lblSachMuonConHan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSachMuonConHan.Location = New System.Drawing.Point(5, 88)
        Me.lblSachMuonConHan.Name = "lblSachMuonConHan"
        Me.lblSachMuonConHan.Size = New System.Drawing.Size(332, 13)
        Me.lblSachMuonConHan.TabIndex = 43
        Me.lblSachMuonConHan.Text = "Sách XYZ, Sách ABC"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Sách mượn quá hạn:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(5, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Sách mượn còn hạn:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.lblSachMuonQuaHan)
        Me.PanelControl1.Controls.Add(Me.lblSachMuonConHan)
        Me.PanelControl1.Location = New System.Drawing.Point(626, 64)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(347, 135)
        Me.PanelControl1.TabIndex = 46
        '
        'ucChoMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grcDanhSachDocGia)
        Me.Name = "ucChoMuonSach"
        Me.Size = New System.Drawing.Size(992, 605)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.lueChonLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueChonLoaiDocGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grcDanhSachDocGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachDocGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblSachMuonQuaHan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSachMuonConHan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
