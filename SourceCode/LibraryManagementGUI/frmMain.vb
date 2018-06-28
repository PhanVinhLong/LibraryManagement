﻿Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
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

        ' Cài đặt biến global
        GlobalControl.GetControl(txtThongTin, txtLoaiTaiKhoan, txtTenTaiKhoan)
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
        GlobalControl.ChangeStatus("Cho mượn sách")
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
        GlobalControl.ChangeStatus("Lập thẻ độc giả")
    End Sub

    Private Sub btnNhanTraSach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNhanTraSach.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Nhận trả sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Nhận trả sách", New ucNhanTraSach())
        End If
        GlobalControl.ChangeStatus("Nhận trả sách")
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
        GlobalControl.ChangeStatus("Quản lý độc giả")
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
        GlobalControl.ChangeStatus("Quản lý loại độc giả")
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
        GlobalControl.ChangeStatus("Quản lý sách")
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
            clsAddTab.AddTab(xtcMain, "Quản lý tác giả", New ucQuanLyTacGia())
        End If
        GlobalControl.ChangeStatus("Quản lý tác giả")
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
        GlobalControl.ChangeStatus("Quản lý thể loại")
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
            clsAddTab.AddTab(xtcMain, "Thêm loại độc giả", New ucThemLoaiDocGia())
        End If
        GlobalControl.ChangeStatus("Thêm loại độc giả")
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
            clsAddTab.AddTab(xtcMain, "Thêm tác giả", New ucThemTacGia())
        End If
        GlobalControl.ChangeStatus("Thêm tác giả")
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
        GlobalControl.ChangeStatus("Thêm thể loại")
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
        GlobalControl.ChangeStatus("Tiếp nhận sách mới")
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
        GlobalControl.ChangeStatus("Thông tin")
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
        GlobalControl.ChangeStatus("Cho mượn sách")
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
        GlobalControl.ChangeStatus("Tiếp nhận sách mới")
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
        GlobalControl.ChangeStatus("Lập thẻ độc giả")
    End Sub

    Private Sub btnThayDoiQuyDinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThayDoiQuyDinh.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thay đổi quy định" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thay đổi quy định", New ucThayDoiQuyDinh())
        End If
        GlobalControl.ChangeStatus("Thay đổi quy định")
    End Sub

    Private Sub btnThongKeTinhHinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThongKeTinhHinh.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thống kê tình hình mượn" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thống kê tình hình mượn", New ucThongKeTinhHinhMuonSach())
        End If
        GlobalControl.ChangeStatus("Thống kê tình hình mượn")
    End Sub

    Private Sub btnThongKeSachTraTre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThongKeSachTraTre.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thống kê sách trả trễ" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thống kê sách trả trễ", New ucThongKeTraSachTre())
        End If
        GlobalControl.ChangeStatus("Thống kê sách trả trễ")
    End Sub

    Private Sub nbiDoiMatKhau_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDoiMatKhau.LinkClicked
        GlobalControl.ChangeStatus("Đổi mật khẩu")
    End Sub

    Private Sub nbiDangXuat_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDangXuat.LinkClicked
    End Sub
End Class

Public Class GlobalControl
    Shared txtStatus As BarStaticItem
    Shared txtAccountType As BarStaticItem
    Shared txtStatName As BarStaticItem

    Public Shared Sub GetControl(statusControl As BarStaticItem, accountTypeControl As BarStaticItem, statNameControl As BarStaticItem)
        txtStatus = statusControl
        txtAccountType = accountTypeControl
        txtStatName = statNameControl
    End Sub

    Public Shared Sub ChangeStatus(strStatus As String)
        txtStatus.Caption = strStatus
    End Sub

    Public Shared Sub ChangeAccountType(maLoaiTaiKhoan As Integer)
        'lblAccountType.Caption = loaiTaiKhoanBUS.GetName(maLoaiTaiKhoan)
    End Sub

    Public Shared Sub ChangeAccountName(maNhanVien As Integer)
        'lblStatName.Caption = nhanVienBUS.GetName(maNhanVien)
    End Sub
End Class