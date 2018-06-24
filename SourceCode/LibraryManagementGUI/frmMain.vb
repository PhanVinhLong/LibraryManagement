Imports DevExpress.XtraBars.Ribbon

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tắt QuickAccessBar của RibbonControl
        rbcMain.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden
        ' Cài đặt giao diện
        LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Blue)
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Hiện thông báo khi tắt phần mềm
        e.Cancel = (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) = DialogResult.No)
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Me.Close()
    End Sub

    Private Sub btnLapTheDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapTheDocGia.ItemClick
        Dim frmLTDG As frmLapTheDocGia
        frmLTDG = New frmLapTheDocGia()
        frmLTDG.MdiParent = Me
        frmLTDG.Show()
    End Sub

    Private Sub btnQuanLyDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyDocGia.ItemClick
        Dim frmQLDG As frmQuanLyDocGia
        frmQLDG = New frmQuanLyDocGia()
        frmQLDG.MdiParent = Me
        frmQLDG.Show()
    End Sub

    Private Sub btnTiepNhanSachMoi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTiepNhanSachMoi.ItemClick
        Dim frmTNSM As frmTiepNhanSachMoi
        frmTNSM = New frmTiepNhanSachMoi()
        frmTNSM.MdiParent = Me
        frmTNSM.Show()
    End Sub

    Private Sub btnThemLoaiDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemLoaiDocGia.ItemClick
        Dim frmTLDG As frmThemLoaiDocGia
        frmTLDG = New frmThemLoaiDocGia
        frmTLDG.MdiParent = Me
        frmTLDG.Show()
    End Sub

    Private Sub btnQuanLyLoaiDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyLoaiDocGia.ItemClick
        Dim frmQLLDG As frmQuanLyLoaiDocGia
        frmQLLDG = New frmQuanLyLoaiDocGia()
        frmQLLDG.MdiParent = Me
        frmQLLDG.Show()
    End Sub

    Private Sub btnThemTheLoai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemTheLoai.ItemClick
        Dim frmTTL As frmThemTheLoaiSach
        frmTTL = New frmThemTheLoaiSach()
        frmTTL.MdiParent = Me
        frmTTL.Show()
    End Sub

    Private Sub btnThemTacGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemTacGia.ItemClick
        Dim frmTTG As frmThemTacGia
        frmTTG = New frmThemTacGia()
        frmTTG.MdiParent = Me
        frmTTG.Show()
    End Sub

    Private Sub btnQuanLyTacGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyTacGia.ItemClick
        Dim frmQLTC As frmQuanLyTacGia
        frmQLTC = New frmQuanLyTacGia()
        frmQLTC.MdiParent = Me
        frmQLTC.Show()
    End Sub

    Private Sub btnQuanLyTheLoai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyTheLoai.ItemClick
        Dim frmQLTL As frmQuanLyTheLoaiSach
        frmQLTL = New frmQuanLyTheLoaiSach()
        frmQLTL.MdiParent = Me
        frmQLTL.Show()
    End Sub
End Class