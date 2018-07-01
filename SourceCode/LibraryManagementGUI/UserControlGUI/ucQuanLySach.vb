﻿Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel

Public Class ucQuanLySach
    Private sachBUS As SachBUS
    Private theLoaiBUS As TheLoaiBUS
    Private tacGiaBUS As TacGiaBUS
    Private trangThaiBUS As TrangThaiBUS
    Private tacGiaSachBUS As TacGiaSachBUS
    Private theLoaiSachBUS As TheLoaiSachBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result
    Private maTheLoaiDuocChon As Integer
    Private maTacGiaDuocChon As Integer
    Private lTacGia As List(Of TacGiaDTO)
    Private lTheLoai As List(Of TheLoaiDTO)
    Private sach As SachDTO

    Private Sub ucQuanLySach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        sachBUS = New SachBUS()
        theLoaiBUS = New TheLoaiBUS()
        tacGiaBUS = New TacGiaBUS()
        trangThaiBUS = New TrangThaiBUS()
        tacGiaSachBUS = New TacGiaSachBUS()
        theLoaiSachBUS = New TheLoaiSachBUS()
        thamSoBUS = New ThamSoBUS()
        lTacGia = New List(Of TacGiaDTO)
        lTheLoai = New List(Of TheLoaiDTO)
        sach = New SachDTO()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Lấy danh sách các thuộc tính lọc (lookupedit)
        Dim listTheLoai = New List(Of TheLoaiDTO)
        result = theLoaiBUS.SelectAll(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Thể loại không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '----
        Dim listTacGia = New List(Of TacGiaDTO)
        result = tacGiaBUS.SelectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Tác giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '----
        Dim listTrangThai = New List(Of TrangThaiDTO)
        result = trangThaiBUS.SelectALL(listTrangThai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Trạng thái không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lueLocTheLoai.Properties.ShowHeader = False
        lueLocTheLoai.Properties.ShowFooter = False
        lueLocTheLoai.Properties.DataSource = New BindingSource(listTheLoai, String.Empty)
        lueLocTheLoai.Properties.DisplayMember = "TenTheLoai"
        lueLocTheLoai.Properties.ValueMember = "MaTheLoai"
        lueLocTheLoai.Properties.TextEditStyle = TextEditStyles.Standard
        lueLocTheLoai.Properties.SearchMode = SearchMode.AutoFilter
        '----
        gleTacGia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        gleTacGia.Properties.ShowFooter = False
        gleTacGia.Properties.DataSource = New BindingSource(listTacGia, String.Empty)
        gleTacGia.Properties.DisplayMember = "TenTacGia"
        gleTacGia.Properties.ValueMember = "MaTacGia"
        gleTacGia.Properties.TextEditStyle = TextEditStyles.Standard
        gleTacGia.Properties.View.OptionsView.ShowAutoFilterRow = SearchMode.AutoFilter
        '----
        lueLocTacGia.Properties.ShowHeader = False
        lueLocTacGia.Properties.ShowFooter = False
        lueLocTacGia.Properties.DataSource = New BindingSource(listTacGia, String.Empty)
        lueLocTacGia.Properties.DisplayMember = "TenTacGia"
        lueLocTacGia.Properties.ValueMember = "MaTacGia"
        lueLocTacGia.Properties.TextEditStyle = TextEditStyles.Standard
        lueLocTacGia.Properties.SearchMode = SearchMode.AutoFilter
        '----
        gleTheLoai.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        gleTheLoai.Properties.ShowFooter = False
        gleTheLoai.Properties.DataSource = New BindingSource(listTheLoai, String.Empty)
        gleTheLoai.Properties.DisplayMember = "TenTheLoai"
        gleTheLoai.Properties.ValueMember = "MaTheLoai"
        gleTheLoai.Properties.TextEditStyle = TextEditStyles.Standard
        gleTheLoai.Properties.View.OptionsView.ShowAutoFilterRow = SearchMode.AutoFilter
        '----
        lueLocTrangThai.Properties.ShowHeader = False
        lueLocTrangThai.Properties.ShowFooter = False
        lueLocTrangThai.Properties.DataSource = New BindingSource(listTrangThai, String.Empty)
        lueLocTrangThai.Properties.DisplayMember = "TenTrangThai"
        lueLocTrangThai.Properties.ValueMember = "MaTrangThai"

        ' Xoá cột ValueMember
        lueLocTheLoai.Properties.PopulateColumns()
        lueLocTheLoai.Properties.Columns(0).Visible = False
        '--------
        lueLocTacGia.Properties.PopulateColumns()
        lueLocTacGia.Properties.Columns(0).Visible = False
        '--------
        lueLocTrangThai.Properties.PopulateColumns()
        lueLocTrangThai.Properties.Columns(0).Visible = False

        ' Đặt giá trị mặc định cho Năm xuất bản
        dteNamXuatBan.EditValue = Now
        dteNamXuatBan.Properties.EditMask = "yyyy"
        dteNamXuatBan.Properties.EditFormat.FormatString = "yyyy"
        dteNamXuatBan.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNamXuatBan.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView
        dteNamXuatBan.Properties.DisplayFormat.FormatString = "yyyy"

        ' Đặt giá trị mặc định cho Lọc năm xuất bản
        dteLocNamXuatBan.EditValue = Now
        dteLocNamXuatBan.Properties.EditMask = "yyyy"
        dteLocNamXuatBan.Properties.EditFormat.FormatString = "yyyy"
        dteLocNamXuatBan.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteLocNamXuatBan.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView
        dteLocNamXuatBan.Properties.DisplayFormat.FormatString = "yyyy"

        ' Đặt giá trị mặc định cho Ngày nhập
        dteNgayNhap.Properties.EditMask = "dd/MM/yyyy"
        dteNgayNhap.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        dteNgayNhap.EditValue = Now

        ' Đặt giá trị mặc định
        gleTacGia.EditValue = 1
        gleTheLoai.EditValue = 1
        lueLocTheLoai.EditValue = 1
        lueLocTrangThai.EditValue = 1
        lueLocTacGia.EditValue = 1

        ' Load dữ liệu cho GridView
        LoadListSach()

        ' Text mặc định cho folder picker
        btnChoosePath.Text = "D:\LibraryManagement\"

        ' Text mặc định cho filename
        txtFileName.EditValue = "DuLieuSach-" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
    End Sub

    Private Sub CaiDatGridControl(listSach As List(Of SachDTO))
        Dim hienThiSachBUS = New HienThiSachBUS()
        Dim listHienThiSach As List(Of HienThiSachDTO)
        listHienThiSach = hienThiSachBUS.ConvertListData(listSach)
        grcDanhSachSach.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachSach.BestFitColumns()
        grvDanhSachSach.Columns.Clear()
        grcDanhSachSach.DataSource = listHienThiSach
        grvDanhSachSach.OptionsBehavior.Editable = False
        grvDanhSachSach.OptionsFind.AlwaysVisible = False
        grvDanhSachSach.OptionsView.ShowGroupPanel = False
        grvDanhSachSach.OptionsFind.FindDelay = 0
        grvDanhSachSach.BestFitColumns()

        ' Thay đổi tên cột
        grvDanhSachSach.Columns("MaSach").Caption = "Mã sách"
        grvDanhSachSach.Columns("TenSach").Caption = "Tên sách"
        grvDanhSachSach.Columns("NamXuatBan").Caption = "Năm xuất bản"
        grvDanhSachSach.Columns("NhaXuatBan").Caption = "Nhà xuất bản"
        grvDanhSachSach.Columns("TriGia").Caption = "Trị giá"
        grvDanhSachSach.Columns("NgayNhap").Caption = "Ngày nhập"
        grvDanhSachSach.Columns("TrangThai").Caption = "Trạng thái"
        grvDanhSachSach.Columns("TacGia").Caption = "Tác giả"
        grvDanhSachSach.Columns("TheLoai").Caption = "Thể loại"

        grcDanhSachSach.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub LoadSach(sach As SachDTO)
        txtMaSach.EditValue = sach.MaSach
        txtTenSach.EditValue = sach.TenSach
        dteNamXuatBan.EditValue = Now.AddYears(-Now.Year + sach.NamXuatBan)
        txtNhaXuatBan.EditValue = sach.NhaXuatBan
        txtTriGia.EditValue = sach.TriGia
        dteNgayNhap.EditValue = sach.NgayNhap

        ' Load tác giả
        tacGiaBUS.SelectByMaSach(sach.MaSach, lTacGia)
        theLoaiBUS.SelectByMaSach(sach.MaSach, lTheLoai)
        UpdateTacGia()
        UpdateTheLoai()
    End Sub

    Private Sub Reset()
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachSach.FocusedRowHandle

        ' Thay đổi data ô thông tin sách
        If (-1 < currenRowIndex < grvDanhSachSach.RowCount) Then
            LoadListSach()
            sach = sachBUS.SelectByMaSach(CType(grvDanhSachSach.GetRow(currenRowIndex), HienThiSachDTO).MaSach)
            LoadSach(sach)
            grvDanhSachSach.FocusedRowHandle = currenRowIndex
        End If

        ' Xoá ô tìm kiếm
        txtTimKiem.EditValue = Nothing
    End Sub

    Private Sub LoadListSach()
        Dim listSach As List(Of SachDTO) = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.SelectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        CaiDatGridControl(listSach)
    End Sub

    Private Sub LoadListSach(iMaTheLoai As Integer, iMaTacGia As Integer, iMaTrangThai As Integer, iNamXuatBan As Integer)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.SelectByCondition(iMaTheLoai, iMaTacGia, iMaTrangThai, iNamXuatBan, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo điều kiện không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CaiDatGridControl(listSach)
    End Sub

    Private Sub dteNamXuatBan_EditValueChanged(sender As Object, e As EventArgs) Handles dteNamXuatBan.EditValueChanged
        If dteNamXuatBan.EditValue = Nothing Then
            dteNamXuatBan.EditValue = Now
        End If
        lblNamXuatBan.Text = "Đã XB " & (Now.Year - dteNamXuatBan.EditValue.Year).ToString & " năm"
    End Sub

    Private Sub UpdateTacGia()
        For Each tacGia As TacGiaDTO In lTacGia
            If tacGia.MaTacGia = lTacGia.First.MaTacGia Then
                lblTacGia.Text = tacGia.TenTacGia
            Else
                lblTacGia.Text = tacGia.TenTacGia & ", " & lblTacGia.Text
            End If
        Next
    End Sub

    Private Sub UpdateTheLoai()
        For Each theLoai As TheLoaiDTO In lTheLoai
            If theLoai.MaTheLoai = lTheLoai.First.MaTheLoai Then
                lblTheLoai.Text = theLoai.TenTheLoai
            Else
                lblTheLoai.Text = theLoai.TenTheLoai & ", " & lblTheLoai.Text
            End If
        Next
    End Sub

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachSach.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs)
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachSach.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        ckeTheLoai.Checked = False
        ckeTacGia.Checked = False
        ckeNamXuatBan.Checked = False
        ckeTrangThai.Checked = False
        Reset()
    End Sub

    Private Sub grvDanhSachSach_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachSach.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachSach.FocusedRowHandle

        ' Thay đổi data ô thông tin sách
        If (-1 < currenRowIndex < grvDanhSachSach.RowCount) Then
            Try
                sach = sachBUS.SelectByMaSach(CType(grvDanhSachSach.GetRow(currenRowIndex), HienThiSachDTO).MaSach)
                LoadSach(sach)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        ' Khai báo
        Dim iMaTheLoai As Integer
        Dim iMaTacGia As Integer
        Dim iNamXuatBan As Integer
        Dim iMaTrangThai As Integer

        ' Lấy dữ liệu từ GUI
        If ckeTheLoai.Checked = False Then
            iMaTheLoai = -1
        Else
            iMaTheLoai = lueLocTheLoai.EditValue
        End If
        If ckeTacGia.Checked = False Then
            iMaTacGia = -1
        Else
            iMaTacGia = lueLocTacGia.EditValue
        End If
        If ckeNamXuatBan.Checked = False Then
            iNamXuatBan = -1
        Else
            iNamXuatBan = dteLocNamXuatBan.EditValue.Year
        End If
        If ckeTrangThai.Checked = False Then
            iMaTrangThai = -1
        Else
            iMaTrangThai = lueLocTrangThai.EditValue
        End If

        ' Lọc data
        LoadListSach(iMaTheLoai, iMaTacGia, iMaTrangThai, iNamXuatBan)
    End Sub

    Private Sub btnThemTacGia_Click(sender As Object, e As EventArgs) Handles btnThemTacGia.Click
        Dim tacGia As TacGiaDTO = tacGiaBUS.SelectByMaTacGia(gleTacGia.EditValue)
        For Each tg In lTacGia
            If tacGia.MaTacGia = tg.MaTacGia Then
                Return
            End If
        Next
        lTacGia.Add(tacGia)
        UpdateTacGia()
    End Sub

    Private Sub btnXoaTacGia_Click(sender As Object, e As EventArgs) Handles btnXoaTacGia.Click
        If lTacGia.Count > 0 Then
            lTacGia.Remove(lTacGia.Last)
            UpdateTacGia()
        End If
    End Sub

    Private Sub btnThemTheLoai_Click(sender As Object, e As EventArgs) Handles btnThemTheLoai.Click
        Dim theLoai As TheLoaiDTO = theLoaiBUS.SelectByMaTheLoai(gleTheLoai.EditValue)
        For Each tl In lTheLoai
            If theLoai.MaTheLoai = tl.MaTheLoai Then
                Return
            End If
        Next
        lTheLoai.Add(theLoai)
        UpdateTheLoai()
    End Sub

    Private Sub btnXoaTheLoai_Click(sender As Object, e As EventArgs) Handles btnXoaTheLoai.Click
        If lTheLoai.Count > 0 Then
            lTheLoai.Remove(lTheLoai.Last)
            UpdateTheLoai()
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachSach.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachSach.RowCount) Then
            Dim sach = New SachDTO()

            ' Lấy dữ liệu tham số
            thamSoBUS = New ThamSoBUS()
            Dim thamSo As ThamSoDTO = New ThamSoDTO
            thamSoBUS.GetData(thamSo)

            ' Chuyển data từ GUI thành DTO
            sach.MaSach = txtMaSach.EditValue
            sach.TenSach = txtTenSach.EditValue
            sach.NamXuatBan = dteNamXuatBan.EditValue.Year
            sach.NhaXuatBan = If(String.IsNullOrWhiteSpace(txtNhaXuatBan.EditValue) Or txtNhaXuatBan.EditValue = "trống", "trống", txtNhaXuatBan.EditValue)
            sach.TriGia = txtTriGia.EditValue
            sach.NgayNhap = dteNgayNhap.EditValue
            sach.MaTrangThai = 1

            ' Kiểm tra tính đúng đắn dữ liệu
            If sachBUS.IsValidTenSach(sach) = False Then
                MessageBox.Show("Tên sách không hợp lệ")
                txtTenSach.Focus()
            End If
            '----
            If sachBUS.IsValidNamXuatBan(sach) = False Then
                MessageBox.Show("Năm xuất bản không hợp lệ")
                dteNamXuatBan.Focus()
            End If
            '----
            If sachBUS.IsValidTriGia(sach) = False Then
                MessageBox.Show("Trị giá sách không hợp lệ")
                txtTriGia.Focus()
            End If
            '----
            If lTheLoai.Count < 1 Then
                MessageBox.Show("Bạn chưa chọn thể loại")
                Return
            End If
            '----
            If lTacGia.Count < 1 Then
                MessageBox.Show("Bạn chưa chọn tác giả")
                Return
            End If

            ' Thêm dữ liệu vào database
            Dim result As Result
            result = sachBUS.Update(sach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Sách không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            ' Xoá dữ liệu thể loại trước đó
            result = theLoaiSachBUS.DeleteByMaSach(sach.MaSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá chi tiết Thể loại không thành công")
                Return
            End If

            ' Xoá dữ liệu tác giả trước đó
            result = tacGiaSachBUS.DeleteByMaSach(sach.MaSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá chi tiết Tác giả không thành công")
                Return
            End If

            ' Thêm dữ liệu cho thể loại
            Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
            If lTheLoai.Count < 1 Then
                lblTheLoai.Text = "Chưa chọn thể loại"
            Else
                For Each theLoai In lTheLoai
                    listTheLoaiSach.Add(New TheLoaiSachDTO(theLoai.MaTheLoai, Convert.ToInt32(txtMaSach.EditValue)))
                Next
            End If
            result = theLoaiSachBUS.InsertList(listTheLoaiSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Chi tiết thể loại không thành công")
                Return
            End If

            ' Thêm dữ liệu cho tác giả
            Dim listTacGiaSach = New List(Of TacGiaSachDTO)
            If lTacGia.Count < 1 Then
                lblTheLoai.Text = "Chưa chọn tác giả"
            Else
                For Each tacGia In lTacGia
                    listTacGiaSach.Add(New TacGiaSachDTO(tacGia.MaTacGia, Convert.ToInt32(txtMaSach.EditValue)))
                Next
            End If
            result = tacGiaSachBUS.InsertList(listTacGiaSach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Thêm Chi tiết tác giả không thành công")
            End If
            Reset()
            MessageBox.Show("Thêm Sách thành công")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Lấy dòng hiện tại
        Dim currentRowIndex As Integer
        currentRowIndex = grvDanhSachSach.FocusedRowHandle

        If (-1 < currentRowIndex < grvDanhSachSach.RowCount) Then
            Select Case MessageBox.Show("Bạn chắc chắn muốn xoá Sách " & txtTenSach.EditValue & " với Mã số " & txtMaSach.EditValue & "?", "Xoá Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Try
                        Dim result As Result
                        result = sachBUS.Delete(txtMaSach.EditValue)
                        If (result.FlagResult = True) Then
                            MessageBox.Show("Xóa Sách thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Reset()
                            If (currentRowIndex >= grvDanhSachSach.RowCount) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                grvDanhSachSach.FocusedRowHandle = currentRowIndex
                            End If
                        Else
                            MessageBox.Show("Xóa Sách không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case DialogResult.No
                    Return
            End Select
        End If
    End Sub

    Private Sub btnXoaLichSuMuon_Click(sender As Object, e As EventArgs) Handles btnXoaLichSuMuon.Click
        If MessageBox.Show("Bạn có chắc chắn muốn xoá Lịch sử mượn và trả của sách " & sach.TenSach & " với mã số " & sach.MaSach & "?", "Xoá lịch sử mượn/ trả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnChoosePath_Click(sender As Object, e As EventArgs) Handles btnChoosePath.Click
        xfbChoosePath.ShowDialog()
        btnChoosePath.Text = xfbChoosePath.SelectedPath
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        ' Khai báo & khởi tạo
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        Dim dt = ConvertToDataTable(Of HienThiSachDTO)(grvDanhSachSach.DataSource)
        Dim dc As DataColumn
        Dim dr As DataRow

        xlWorkSheet.Range("A1", "J1").Merge()
        xlWorkSheet.Cells(1, 1) = "DANH SÁCH SÁCH NGÀY " & Now.ToShortDateString & " - UIT LIBRARY"

        Dim colIndex As Integer = 1
        Dim rowIndex As Integer = 2
        Dim stt As Integer = 0

        ' Tên cột excel
        xlWorkSheet.Cells(rowIndex, 1) = "STT"
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            xlWorkSheet.Cells(rowIndex, colIndex) = dc.ColumnName
        Next
        ' Thêm dữ liệu excel
        For Each dr In dt.Rows
            stt = stt + 1
            rowIndex = rowIndex + 1
            colIndex = 1
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                xlWorkSheet.Cells(rowIndex, 1) = "'" & stt
                If colIndex = 2 Then
                    xlWorkSheet.Cells(rowIndex, colIndex) = "'" & dr(dc.ColumnName)
                Else
                    xlWorkSheet.Cells(rowIndex, colIndex) = dr(dc.ColumnName)
                End If

            Next
        Next

        ' Auto fit cột excel
        xlWorkSheet.Columns("A:J").AutoFit

        ' Lưu file
        Try
            xlWorkBook.SaveAs(btnChoosePath.EditValue & txtFileName.EditValue, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            If MessageBox.Show("Xuất file exel thành công. Bạn có muốn mở file?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Process.Start(btnChoosePath.EditValue & txtFileName.EditValue)
            End If
        Catch
            MessageBox.Show("ERROR")
        End Try
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()
        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Shared Function ConvertToDataTable(Of HienThiSachDTO)(ByVal list As IList(Of HienThiSachDTO)) As System.Data.DataTable
        Dim table As New System.Data.DataTable()
        Dim fields() = list.First.GetType.GetProperties
        For Each field In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next
        For Each item In list
            Dim row As DataRow = table.NewRow()
            For Each field In fields
                Dim p = item.GetType.GetProperty(field.Name)
                row(field.Name) = p.GetValue(item, Nothing)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function
End Class
