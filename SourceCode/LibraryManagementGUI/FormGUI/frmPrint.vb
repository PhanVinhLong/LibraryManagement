Imports LibraryManagementDTO

Public Class frmPrint
    Public Sub New(ngayThongKe As DateTime, list As List(Of TinhHinhMuonSachDTO))
        Dim report = New xrpTinhHinhMuonSach()
        report.Init(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub

    Public Sub New(ngayThongKe As DateTime, list As List(Of SachTraTreDTO))
        Dim report = New xrpThongKeSachTraTre()
        report.Init(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub

    Public Sub New(nhanVien As NhanVienDTO, phieuMuon As PhieuMuonDTO, listSach As List(Of HienThiSachDTO))
        Dim report = New xrpPhieuMuonSach()
        report.Init(nhanVien, phieuMuon, listSach)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class