Imports LibraryManagementBUS
Imports LibraryManagementDTO

Public Class xrpPhieuMuonSach
    Public Sub Init(nhanVien As NhanVienDTO, phieuMuon As PhieuMuonDTO, listSach As List(Of HienThiSachDTO))
        Dim docGiaBUS As DocGiaBUS = New DocGiaBUS()
        Dim docGia = docGiaBUS.SelectByDocGia(phieuMuon.MaDocGia)

        DSSach.DataSource = listSach
        dateNgayLap.Text = phieuMuon.NgayMuon.ToShortDateString
        txtMaPhieuMuon.Text = phieuMuon.MaPhieuMuon
        txtMaDocGia.Text = phieuMuon.MaDocGia
        txtHoTen.Text = docGia.HoTen
        txtHoTen2.Text = docGia.HoTen
        txtNhanVien.Text = nhanVien.HoTen
    End Sub
End Class