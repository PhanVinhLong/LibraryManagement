Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucChoMuonSach
    Private docGiaBUS As DocGiaBUS
    Private loaiDocGiaBUS As LoaiDocGiaBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucChoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        docGiaBUS = New DocGiaBUS()
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()

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
    End Sub

    Private Sub CaiDatGridControl(listDocGia As List(Of DocGiaDTO))
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
        CaiDatGridControl(listDocGia)
    End Sub

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachDocGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs)
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachDocGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub grvDanhSachDocGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachDocGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            Dim docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
            LoadTenSach(lblSachMuonQuaHan, docGiaBUS.SachMuonHetHan(docGia))
            LoadTenSach(lblSachMuonConHan, docGiaBUS.SachMuonConHan(docGia))
        End If
    End Sub

    Private Sub Reset()
        ' Xoá ô tìm kiếm
        txtTimKiem.EditValue = Nothing

        ' Load lại data
        LoadListDocGia()

        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            Try
                Dim docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
                LoadTenSach(lblSachMuonQuaHan, docGiaBUS.SachMuonHetHan(docGia))
                LoadTenSach(lblSachMuonConHan, docGiaBUS.SachMuonConHan(docGia))
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

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        Reset()
    End Sub
End Class
