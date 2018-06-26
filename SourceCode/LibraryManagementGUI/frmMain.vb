Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports Utility

Public Class frmMain
    Dim clsAddTab As AddTab = New AddTab()

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tắt QuickAccessBar của RibbonControl

        ' Cài đặt giao diện
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Bezier"

        ' Mở UC Thông tin
        clsAddTab.AddTab(xtcMain, "Thông tin", New ucThongTin())
    End Sub

    ' Event đóng tab control
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Hiện thông báo khi tắt phần mềm
        e.Cancel = (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) = DialogResult.No)
    End Sub

    Private Sub xtcMain_CloseButtonClick(sender As Object, e As EventArgs) Handles xtcMain.CloseButtonClick
        xtcMain.TabPages.RemoveAt(xtcMain.SelectedTabPageIndex)
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Me.Close()
    End Sub

    Private Sub btnChoMuonSach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChoMuonSach.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Cho mượn sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Cho mượn sách", New ucChoMuonSach())
        End If
    End Sub

    Private Sub btnLapTheDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapTheDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Lập thẻ độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Lập thẻ độc giả", New ucLapTheDocGia())
        End If
    End Sub

    Private Sub btnQuanLyDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý độc giả", New ucQuanLyDocGia())
        End If
    End Sub

    Private Sub btnQuanLyLoaiDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyLoaiDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý loại độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý loại độc giả", New ucQuanLyLoaiDocGia())
        End If
    End Sub

    Private Sub btnQuanLySach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLySach.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý sách", New ucQuanLySach())
        End If
    End Sub

    Private Sub btnQuanLyTacGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyTacGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý tác giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý tác giả", New ucQuanLyDocGia())
        End If
    End Sub

    Private Sub btnQuanLyTheLoai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyTheLoai.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý thể loại" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý thể loại", New ucQuanLyTheLoaiSach())
        End If
    End Sub

    Private Sub btnThemLoaiDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemLoaiDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thêm loại độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thêm loại độc giả", New ucQuanLyDocGia())
        End If
    End Sub

    Private Sub btnThemTacGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemTacGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thêm tác giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thêm tác giả", New ucQuanLyTacGia())
        End If
    End Sub

    Private Sub btnThemTheLoai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemTheLoai.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thêm thể loại" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thêm thể loại", New ucThemTheLoai())
        End If
    End Sub

    Private Sub btnTiepNhanSachMoi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTiepNhanSachMoi.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Tiếp nhận sách mới" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Tiếp nhận sách mới", New ucTiepNhanSachMoi())
        End If
    End Sub

    Private Sub btnThongTin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThongTin.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thông tin" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thông tin", New ucThongTin())
        End If
    End Sub

    Private Sub nbiChoMuonSach_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiChoMuonSach.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Cho mượn sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Cho mượn sách", New ucChoMuonSach())
        End If
    End Sub

    Private Sub nbiNhanTraSach_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiNhanTraSach.LinkClicked

    End Sub

    Private Sub nbiTiepNhanSach_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTiepNhanSach.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Tiếp nhận sách mới" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Tiếp nhận sách mới", New ucTiepNhanSachMoi())
        End If
    End Sub

    Private Sub nbiLapTheDocGia_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiLapTheDocGia.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Lập thẻ độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Lập thẻ độc giả", New ucLapTheDocGia())
        End If
    End Sub

    Private Sub nbiDoiMatKhau_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDoiMatKhau.LinkClicked

    End Sub

    Private Sub nbiDangXuat_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDangXuat.LinkClicked

    End Sub
End Class