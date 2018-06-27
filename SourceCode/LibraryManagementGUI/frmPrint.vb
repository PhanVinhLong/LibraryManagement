Imports LibraryManagementDTO

Public Class frmPrint
    Public Sub InitTinhHinhMuonSach(ngayThongKe As DateTime, list As List(Of TinhHinhMuonSachDTO))
        Dim report = New xrpTinhHinhMuonSach()
        report.InitTinhHinhMuonSach(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class