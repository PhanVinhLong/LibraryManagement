Imports LibraryManagementDTO

Public Class frmPrint
    Public Sub InitTinhHinhMuonSach(ngayThongKe As DateTime, list As List(Of TinhHinhMuonSachDTO))
        Dim report = New xrpTinhHinhMuonSach()
        report.Init(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub

    Public Sub InitThongKeSachTraTre(ngayThongKe As DateTime, list As List(Of SachTraTreDTO))
        Dim report = New xrpThongKeSachTraTre()
        report.Init(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class