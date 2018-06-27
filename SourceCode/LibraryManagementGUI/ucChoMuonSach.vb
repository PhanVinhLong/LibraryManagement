Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucChoMuonSach
    Private sachBUS As SachBUS
    Private theLoaiBUS As TheLoaiBUS
    Private tacGiaBUS As TacGiaBUS
    Private trangThaiBUS As TrangThaiBUS
    Private tacGiaSachBUS As TacGiaSachBUS
    Private theLoaiSachBUS As TheLoaiSachBUS
    Private listSachChon As List(Of SachDTO)
    Private docGia As DocGiaDTO

    Private docGiaBUS As DocGiaBUS
    Private loaiDocGiaBUS As LoaiDocGiaBUS

    Private phieuMuonBUS As PhieuMuonBUS
    Private chiTietPhieuMuonBUS As ChiTietPhieuMuonBUS

    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucChoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        sachBUS = New SachBUS()
        theLoaiBUS = New TheLoaiBUS()
        tacGiaBUS = New TacGiaBUS()
        trangThaiBUS = New TrangThaiBUS()
        tacGiaSachBUS = New TacGiaSachBUS()
        theLoaiSachBUS = New TheLoaiSachBUS()
        listSachChon = New List(Of SachDTO)

        docGiaBUS = New DocGiaBUS()
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()

        phieuMuonBUS = New PhieuMuonBUS()
        chiTietPhieuMuonBUS = New ChiTietPhieuMuonBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Lấy danh sách các thuộc tính lọc (lookupedit)
        Dim listLoaiDocGia As List(Of LoaiDocGiaDTO) = New List(Of LoaiDocGiaDTO)
        result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại độc giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lueChonLoaiDocGia.Properties.ShowHeader = False
        lueChonLoaiDocGia.Properties.ShowFooter = False
        lueChonLoaiDocGia.Properties.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        lueChonLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia"
        lueChonLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia"

        ' Xoá cột ValueMember của ChonLoaiDocGia và LoaiDocGia
        lueChonLoaiDocGia.Properties.PopulateColumns()
        lueChonLoaiDocGia.Properties.Columns("MaLoaiDocGia").Visible = False

        ' Đặt giá trị mặc định cho ChonLoaiDocGia
        lueChonLoaiDocGia.EditValue = 1

        ' Load dữ liệu cho GridView
        LoadListDocGia()

        '-----------------------------

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
        '----
        lueLocTacGia.Properties.ShowHeader = False
        lueLocTacGia.Properties.ShowFooter = False
        lueLocTacGia.Properties.DataSource = New BindingSource(listTacGia, String.Empty)
        lueLocTacGia.Properties.DisplayMember = "TenTacGia"
        lueLocTacGia.Properties.ValueMember = "MaTacGia"

        ' Xoá cột ValueMember
        lueLocTheLoai.Properties.PopulateColumns()
        lueLocTheLoai.Properties.Columns(0).Visible = False
        '--------
        lueLocTacGia.Properties.PopulateColumns()
        lueLocTacGia.Properties.Columns(0).Visible = False

        ' Đặt giá trị mặc định cho Lọc năm xuất bản
        dteLocNamXuatBan.EditValue = Now
        dteLocNamXuatBan.Properties.EditMask = "yyyy"
        dteLocNamXuatBan.Properties.EditFormat.FormatString = "yyyy"
        dteLocNamXuatBan.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteLocNamXuatBan.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView
        dteLocNamXuatBan.Properties.DisplayFormat.FormatString = "yyyy"

        ' Đặt giá trị mặc định
        lueLocTheLoai.EditValue = 1
        lueLocTacGia.EditValue = 1

        ' Load dữ liệu cho GridView
        LoadListSach(-1, -1, 1, -1)

        ' Đặt giá trị mặc định cho Ngày nhập
        dteNgayNhap.Properties.EditMask = "dd/MM/yyyy"
        dteNgayNhap.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        dteNgayNhap.EditValue = Now
    End Sub

    Private Sub CaiDatGridControlDocGia(listDocGia As List(Of DocGiaDTO))
        grcDanhSachDocGia.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachDocGia.BestFitColumns()
        grvDanhSachDocGia.Columns.Clear()
        grcDanhSachDocGia.DataSource = listDocGia
        grvDanhSachDocGia.OptionsBehavior.Editable = False
        grvDanhSachDocGia.OptionsFind.AlwaysVisible = False
        grvDanhSachDocGia.OptionsView.ShowGroupPanel = False
        grvDanhSachDocGia.OptionsFind.FindDelay = 0

        ' Chỉnh độ rộng cột
        grvDanhSachDocGia.Columns("MaDocGia").Width = 70
        grvDanhSachDocGia.Columns("HoTen").Width = 120
        grvDanhSachDocGia.Columns("NgaySinh").Width = 70
        grvDanhSachDocGia.Columns("Email").Width = 120
        grvDanhSachDocGia.Columns("DiaChi").Width = 140
        grvDanhSachDocGia.Columns("NgayLapThe").Width = 70
        grvDanhSachDocGia.Columns("NgayHetHan").Width = 70

        ' Ẩn cột
        'grvDanhSachDocGia.Columns("MaDocLoaiGia").Visible = False

        ' Đổi tên cột
        grvDanhSachDocGia.Columns("MaDocGia").Caption = "Mã độc giả"
        grvDanhSachDocGia.Columns("HoTen").Caption = "Họ tên"
        grvDanhSachDocGia.Columns("NgaySinh").Caption = "Ngày sinh"
        grvDanhSachDocGia.Columns("Email").Caption = "Email"
        grvDanhSachDocGia.Columns("DiaChi").Caption = "Địa chỉ"
        grvDanhSachDocGia.Columns("NgayLapThe").Caption = "Ngày lập thẻ"
        grvDanhSachDocGia.Columns("NgayHetHan").Caption = "Ngày hết hạn"

        grcDanhSachDocGia.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub LoadListDocGia()
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = docGiaBUS.SelectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        CaiDatGridControlDocGia(listDocGia)
    End Sub

    Private Sub txtTimKiemDocGia_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiemDocGia.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiemDocGia.EditValue & """"
        grvDanhSachDocGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub grvDanhSachDocGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachDocGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
            LoadTenSach(lblSachMuonQuaHan, docGiaBUS.SachMuonHetHan(docGia))
            LoadTenSach(lblSachMuonConHan, docGiaBUS.SachMuonConHan(docGia))
            gcDocGia.Text = docGia.HoTen & " - " & docGia.MaDocGia
        End If
    End Sub

    Private Sub ResetDocGia()
        ' Xoá ô tìm kiếm
        txtTimKiemDocGia.EditValue = Nothing

        ' Load lại data
        LoadListDocGia()

        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            Try
                docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
                LoadTenSach(lblSachMuonQuaHan, docGiaBUS.SachMuonHetHan(docGia))
                LoadTenSach(lblSachMuonConHan, docGiaBUS.SachMuonConHan(docGia))
                gcDocGia.Text = docGia.HoTen & " - " & docGia.MaDocGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub LoadTenSach(label As LabelControl, listSach As List(Of SachDTO))
        If listSach.Count < 1 Then
            label.Text = "Không có"
            Return
        End If
        label.Text = String.Empty
        For Each sach In listSach
            label.Text &= sach.TenSach & " (" & sach.MaSach & "), "
        Next
    End Sub

    Private Sub btnTaiLaiDocGia_Click(sender As Object, e As EventArgs) Handles btnTaiLaiDocGia.Click
        ResetDocGia()
    End Sub

    '------------------------------------------------

    Private Sub CaiDatGridControl(listSach As List(Of SachDTO))
        grcDanhSachSach.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachSach.BestFitColumns()
        grvDanhSachSach.Columns.Clear()
        grcDanhSachSach.DataSource = listSach
        grvDanhSachSach.OptionsBehavior.Editable = False
        grvDanhSachSach.OptionsFind.AlwaysVisible = False
        grvDanhSachSach.OptionsView.ShowGroupPanel = False
        grvDanhSachSach.OptionsFind.FindDelay = 0
        grvDanhSachSach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        grvDanhSachSach.OptionsSelection.MultiSelect = True

        grcDanhSachSach.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub Reset()
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachSach.FocusedRowHandle

        ' Thay đổi data ô thông tin sách
        If (-1 < currenRowIndex < grvDanhSachSach.RowCount) Then
            LoadListSach(-1, -1, 1, -1)
            Dim sach = CType(grvDanhSachSach.GetRow(currenRowIndex), SachDTO)
            LoadSach(sach)
            grvDanhSachSach.FocusedRowHandle = currenRowIndex
        End If

        ' Xoá ô tìm kiếm
        txtTimKiem.EditValue = Nothing
    End Sub

    Private Sub LoadListSach(iMaTheLoai As Integer, iMaTacGia As Integer, iMaTrangThai As Integer, iNamXuatBan As Integer)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        ' Chỉ lấy sách đang sẵn sàng để mượn
        iMaTrangThai = 1
        result = sachBUS.SelectByCondition(iMaTheLoai, iMaTacGia, iMaTrangThai, iNamXuatBan, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo điều kiện không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CaiDatGridControl(listSach)
    End Sub

    Private Sub LoadSach(sach As SachDTO)

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
        Reset()
    End Sub

    Private Sub grvDanhSachSach_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grvDanhSachSach.SelectionChanged
        lblSachDaChon.Text = String.Empty
        listSachChon.Clear()
        For Each rowIndex As Integer In grvDanhSachSach.GetSelectedRows
            Dim sach = CType(grvDanhSachSach.GetRow(rowIndex), SachDTO)
            listSachChon.Add(sach)
            lblSachDaChon.Text &= sach.TenSach & " (" & sach.MaSach & "), "
        Next
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        ' Khai báo
        Dim iMaTheLoai As Integer
        Dim iMaTacGia As Integer
        Dim iNamXuatBan As Integer

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

        ' Lọc data
        LoadListSach(iMaTheLoai, iMaTacGia, 1, iNamXuatBan)
    End Sub

    Private Sub btnChoMuon_Click(sender As Object, e As EventArgs) Handles btnChoMuon.Click
        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Kiểm tra
        If dteNgayNhap.EditValue > Now Then
            MessageBox.Show("Ngày nhập không đúng")
            Return
        End If
        ' ----
        If listSachChon.Count < 1 Then
            MessageBox.Show("Bạn chưa chọn sách nào")
            Return
        End If
        ' ----
        If docGia.MaDocGia = Nothing Then
            MessageBox.Show("Bạn chưa chọn độc giả")
            Return
        End If
        '----
        If docGiaBUS.SachMuonHetHan(docGia).Count > 0 Then
            MessageBox.Show("Độc giả còn sách mượn quá hạn chưa trả")
            Return
        End If
        '----
        Dim soSachDangMuon = docGiaBUS.SachMuonConHan(docGia).Count
        If soSachDangMuon + listSachChon.Count > thamSo.SoLuongSachMuonToiDa Then
            MessageBox.Show("Chỉ có thể mượn tối đa 1 lúc " & thamSo.SoLuongSachMuonToiDa & " cuốn. Vui lòng xoá bớt sách hoặc trả sách đang mượn")
            Return
        End If

        ' Lấy Data phiếu mượn
        Dim phieuMuon = New PhieuMuonDTO()
        Dim nextMaPhieuMuon As Integer = Nothing
        Dim result As Result
        result = phieuMuonBUS.BuildMaPhieuMuon(nextMaPhieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Mã phiếu mượn kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        Else
            phieuMuon.MaPhieuMuon = nextMaPhieuMuon
            phieuMuon.MaDocGia = docGia.MaDocGia
            phieuMuon.NgayMuon = dteNgayNhap.EditValue
        End If

        ' Lấy Data list Danh sách Chi tiết phiếu mượn
        Dim listChiTietPhieuMuon = New List(Of ChiTietPhieuMuonDTO)
        listChiTietPhieuMuon.Clear()
        For Each sach As SachDTO In listSachChon
            listChiTietPhieuMuon.Add(New ChiTietPhieuMuonDTO(nextMaPhieuMuon, sach.MaSach))
        Next

        ' Thêm dữ liệu vào database cho Phiếu mượn
        result = phieuMuonBUS.Insert(phieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Phiếu mượn không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Thêm dữ liệu vào database cho List Chi tiết phiếu mượn
        result = chiTietPhieuMuonBUS.InsertList(listChiTietPhieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Chi tiết phiếu mượn không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Thay đổi trạng thái sách
        For Each sach In listSachChon
            sach.MaTrangThai = 2
            result = sachBUS.Update(sach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật trạng thái Sách lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        MessageBox.Show("Đã Lập phiếu mượn")

        ' Reset dữ liệu
        LoadListSach(-1, -1, 1, -1)
        ResetDocGia()
        listSachChon.Clear()
        lblSachDaChon.Text = "Chưa chọn sách"
    End Sub

    Private Sub btnChoMuonVaDong_Click(sender As Object, e As EventArgs) Handles btnChoMuonVaDong.Click
        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Kiểm tra
        If dteNgayNhap.EditValue > Now Then
            MessageBox.Show("Ngày nhập không đúng")
            Return
        End If
        ' ----
        If listSachChon.Count < 1 Then
            MessageBox.Show("Bạn chưa chọn sách nào")
            Return
        End If
        ' ----
        If docGia.MaDocGia = Nothing Then
            MessageBox.Show("Bạn chưa chọn độc giả")
            Return
        End If

        ' Lấy Data phiếu mượn kế tiếp
        Dim phieuMuon = New PhieuMuonDTO()
        Dim nextMaPhieuMuon As Integer = Nothing
        Dim result As Result
        result = phieuMuonBUS.BuildMaPhieuMuon(nextMaPhieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Mã phiếu mượn kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        Else
            phieuMuon.MaPhieuMuon = nextMaPhieuMuon
            phieuMuon.MaDocGia = docGia.MaDocGia
            phieuMuon.NgayMuon = dteNgayNhap.EditValue
        End If

        ' Lấy Data list Danh sách Chi tiết phiếu mượn
        Dim listChiTietPhieuMuon = New List(Of ChiTietPhieuMuonDTO)
        listChiTietPhieuMuon.Clear()
        For Each sach As SachDTO In listSachChon
            listChiTietPhieuMuon.Add(New ChiTietPhieuMuonDTO(nextMaPhieuMuon, sach.MaSach))
        Next

        ' Thêm dữ liệu vào database cho Phiếu mượn
        result = phieuMuonBUS.Insert(phieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Phiếu mượn không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Parent.Dispose()
        End If

        ' Thêm dữ liệu vào database cho List Chi tiết phiếu mượn
        result = chiTietPhieuMuonBUS.InsertList(listChiTietPhieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Chi tiết phiếu mượn không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Parent.Dispose()
        End If

        ' Thay đổi trạng thái sách
        For Each sach In listSachChon
            sach.MaTrangThai = 2
            result = sachBUS.Update(sach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật trạng thái Sách lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Parent.Dispose()
            End If
        Next

        MessageBox.Show("Đã Lập phiếu mượn")
        Me.Parent.Dispose()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
