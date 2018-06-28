Imports LibraryManagementBUS
Imports LibraryManagementDTO

Public Class ucThayDoiQuyDinh
    Dim thamSoBUS As ThamSoBUS
    Dim thamSo As ThamSoDTO

    Private Sub ucThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thamSoBUS = New ThamSoBUS()
        thamSo = New ThamSoDTO()
        ReLoad()
    End Sub

    Private Sub ReLoad()
        thamSoBUS.GetData(thamSo)
        txtTuoiToiThieu.EditValue = thamSo.TuoiToiThieu
        txtTuoiToiDa.EditValue = thamSo.TuoiToiDa
        txtThoiHanThe.EditValue = thamSo.ThoiHanSuDung
        txtNamXuatBan.EditValue = thamSo.GioiHanNamXuatBan
        txtSoLuongTheLoai.EditValue = thamSo.SoLuongTheLoai
        txtSachMuonToiDa.EditValue = thamSo.SoLuongSachMuonToiDa
        txtThoiGianMuonToiDa.EditValue = thamSo.SoNgayMuonToiDa
        txtSoLuongTacGia.EditValue = thamSo.SoLuongTacGia
        txtSoLuongLoaiDocGia.EditValue = thamSo.SoLuongLoaiDocGia
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        ReLoad()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If thamSoBUS.Update(txtTuoiToiThieu.EditValue, txtTuoiToiDa.EditValue, txtThoiHanThe.EditValue, txtNamXuatBan.EditValue, txtSoLuongTacGia.EditValue, txtSachMuonToiDa.EditValue, txtThoiGianMuonToiDa.EditValue, txtSoLuongTheLoai.EditValue, txtSoLuongLoaiDocGia.EditValue).FlagResult = False Then
            MessageBox.Show("Cập nhật Quy định không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lỗi: Cập nhật Quy định không thành công")
            Return
        Else
            MessageBox.Show("Đã cập nhật quy định")
            GlobalControl.ChangeStatus("Cập nhật Quy định thành công")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
