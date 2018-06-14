Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class ThamSoBUS
    Private thamSoDAL As ThamSoDAL

    Public Sub New()
        thamSoDAL = New ThamSoDAL
    End Sub

    Public Sub New(ConnectionString)
        thamSoDAL = New ThamSoDAL(ConnectionString)
    End Sub

    Public Function GetData(ByRef thamSo As ThamSoDTO) As Result
        Return thamSoDAL.GetData(thamSo)
    End Function
End Class
