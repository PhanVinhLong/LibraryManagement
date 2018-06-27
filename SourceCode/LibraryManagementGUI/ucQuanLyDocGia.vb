Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucQuanLyDocGia
    Private docGiaBUS As DocGiaBUS
    Private loaiDocGiaBUS As LoaiDocGiaBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucQuanLyDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        docGiaBUS = New DocGiaBUS()
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Lấy danh sách ChonLoaiDocGia và LoaiDocGia
        Dim listLoaiDocGia As List(Of LoaiDocGiaDTO) = New List(Of LoaiDocGiaDTO)
        result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách LoaiDocGia không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lueChonLoaiDocGia.Properties.ShowHeader = False
        lueChonLoaiDocGia.Properties.ShowFooter = False
        lueChonLoaiDocGia.Properties.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        lueChonLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia"
        lueChonLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia"
        '------------
        lueLoaiDocGia.Properties.ShowHeader = False
        lueLoaiDocGia.Properties.ShowFooter = False
        lueLoaiDocGia.Properties.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        lueLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia"
        lueLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia"

        ' Xoá cột ValueMember của ChonLoaiDocGia và LoaiDocGia
        lueChonLoaiDocGia.Properties.PopulateColumns()
        lueChonLoaiDocGia.Properties.Columns("MaLoaiDocGia").Visible = False
        '------------
        lueLoaiDocGia.Properties.PopulateColumns()
        lueLoaiDocGia.Properties.Columns("MaLoaiDocGia").Visible = False

        ' Đặt giá trị mặc định cho ChonLoaiDocGia
        lueChonLoaiDocGia.EditValue = 1

        ' Load dữ liệu cho GridView
        LoadListDocGia()
        Reset()

        ' Hiển thị button gia hạn
        btnGiaHanThe.Text = "Gia hạn " & thamSo.ThoiHanSuDung & " tháng"
    End Sub

    Private Sub CaiDatGridControl(listDocGia As List(Of DocGiaDTO))
        grcDanhSachDocGia.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachDocGia.Columns.Clear()
        grcDanhSachDocGia.DataSource = listDocGia
        grvDanhSachDocGia.OptionsBehavior.Editable = False
        grvDanhSachDocGia.Columns("MaLoaiDocGia").Visible = False
        grvDanhSachDocGia.OptionsFind.AlwaysVisible = False
        grvDanhSachDocGia.OptionsView.ShowGroupPanel = False
        grvDanhSachDocGia.OptionsFind.FindDelay = 100
        grvDanhSachDocGia.OptionsBehavior.AllowIncrementalSearch = True

        ' Chỉnh độ rộng cột
        grvDanhSachDocGia.Columns("MaDocGia").Width = 70
        grvDanhSachDocGia.Columns("HoTen").Width = 120
        grvDanhSachDocGia.Columns("NgaySinh").Width = 70
        grvDanhSachDocGia.Columns("Email").Width = 120
        grvDanhSachDocGia.Columns("DiaChi").Width = 140
        grvDanhSachDocGia.Columns("NgayLapThe").Width = 70
        grvDanhSachDocGia.Columns("NgayHetHan").Width = 70

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
                LoadDocGia(docGia)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub LoadListDocGia()
        Dim listDocGia As List(Of DocGiaDTO) = New List(Of DocGiaDTO)
        Dim result As Result
        result = docGiaBUS.SelectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tất cả Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CaiDatGridControl(listDocGia)
    End Sub

    Private Sub lueChonLoaiDocGia_EditValueChanged(sender As Object, e As EventArgs) Handles lueChonLoaiDocGia.EditValueChanged
        Try
            Dim maLoaiDocGia As Integer
            maLoaiDocGia = Convert.ToInt32(lueChonLoaiDocGia.EditValue)
            LoadListDocGia(maLoaiDocGia)
        Catch ex As Exception
            MessageBox.Show("Chọn Loại độc giả lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadListDocGia(maLoaiDocGia As Integer)
        Dim listDocGia As List(Of DocGiaDTO) = New List(Of DocGiaDTO)
        Dim result As Result
        result = docGiaBUS.SellectByMaDocGia(maLoaiDocGia, listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tất cả Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CaiDatGridControl(listDocGia)
    End Sub

    Private Sub LoadDocGia(docGia As DocGiaDTO)
        txtMaDocGia.EditValue = docGia.MaDocGia
        txtHoTen.EditValue = docGia.HoTen
        dteNgaySinh.EditValue = docGia.NgaySinh
        txtDiaChi.EditValue = docGia.DiaChi
        txtEmail.EditValue = docGia.Email
        dteNgayLapThe.EditValue = docGia.NgayLapThe
        dteNgayHetHan.EditValue = docGia.NgayHetHan
        lueLoaiDocGia.EditValue = docGia.MaLoaiDocGia
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        Reset()
    End Sub

    Private Sub grvDanhSachDocGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachDocGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            Try
                Dim docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
                LoadDocGia(docGia)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            Try
                Dim docGia As DocGiaDTO
                docGia = New DocGiaDTO

                ' Chuyển data từ GUI thành DTO
                docGia.MaDocGia = txtMaDocGia.EditValue
                docGia.HoTen = txtHoTen.EditValue
                docGia.NgaySinh = dteNgaySinh.EditValue
                docGia.DiaChi = txtDiaChi.EditValue
                docGia.Email = txtEmail.EditValue
                docGia.NgayLapThe = dteNgayLapThe.EditValue
                docGia.NgayHetHan = dteNgayHetHan.EditValue
                docGia.MaLoaiDocGia = lueLoaiDocGia.EditValue

                ' Kiểm tra tính đúng đắn dữ liệu
                If (docGiaBUS.IsValidHoTen(docGia) = False) Then
                    MessageBox.Show("Tên độc giả không hợp lệ!")
                    txtHoTen.Focus()
                    Return
                End If
                '------
                If (docGiaBUS.IsValidNgayLapThe(docGia) = False) Then
                    MessageBox.Show("Ngày lập thẻ không hợp lệ!")
                    dteNgayLapThe.Focus()
                    Return
                End If
                '------
                If (docGiaBUS.IsValidNgaySinh(docGia) = False) Then
                    MessageBox.Show("Ngày sinh không hợp lệ!")
                    dteNgaySinh.Focus()
                    Return
                End If
                '------
                ' Thêm dữ liệu vào database
                Dim result As Result
                result = docGiaBUS.Update(docGia)
                If (result.FlagResult) Then
                    MessageBox.Show("Cập nhật thông tin độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Reset()
                Else
                    MessageBox.Show("Cập nhật thông tin độc giả không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnGiaHanThe_Click(sender As Object, e As EventArgs) Handles btnGiaHanThe.Click
        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Lấy data dòng hiện tại
        Dim docGia As DocGiaDTO
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
        End If

        ' Gia hạn Ngày hết hạn 
        docGia.NgayHetHan = docGia.NgayHetHan.AddMonths(6)

        Dim result As Result
        result = docGiaBUS.Update(docGia)
        If (result.FlagResult) Then
            MessageBox.Show("Gia hạn thẻ độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        Else
            MessageBox.Show("Gia hạn thẻ độc giả không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Lấy dòng hiện tại
        Dim currentRowIndex As Integer
        currentRowIndex = grvDanhSachDocGia.FocusedRowHandle

        If (-1 < currentRowIndex < grvDanhSachDocGia.RowCount) Then
            Select Case MessageBox.Show("Bạn chắc chắn muốn xoá Độc giả " & txtHoTen.EditValue & " với Mã số " & txtMaDocGia.EditValue & "?", "Xoá Độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Try
                        Dim result As Result
                        result = docGiaBUS.Delete(txtMaDocGia.EditValue)
                        If (result.FlagResult = True) Then
                            MessageBox.Show("Xóa Độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Reset()
                            If (currentRowIndex >= grvDanhSachDocGia.RowCount) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                grvDanhSachDocGia.FocusedRowHandle = (currentRowIndex)
                            End If
                        Else
                            MessageBox.Show("Xóa Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachDocGia.ApplyFindFilter(filterString)
    End Sub
End Class
