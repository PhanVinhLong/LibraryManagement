Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class PhieuMuonDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaPhieuMuon(ByRef nextMaPhieuMuon As Integer) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaPhieuMuon] "
        sqlQuery &= "FROM [tblPhieuMuon] "
        sqlQuery &= "ORDER BY [MaPhieuMuon] DESC "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    Dim maPhieuMuonOnDB As String
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maPhieuMuonOnDB = dataReader("MaPhieuMuon")
                        End While
                    End If
                    nextMaPhieuMuon = maPhieuMuonOnDB + 1
                    System.Console.WriteLine(nextMaPhieuMuon)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã phiếu mượn kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(phieuMuon As PhieuMuonDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) "
        sqlQuery &= "VALUES (@MaPhieuMuon, @MaDocGia, @NgayMuon) "

        Dim nextMaPhieuMuon = 0
        Dim result As Result
        result = BuildMaPhieuMuon(nextMaPhieuMuon)
        If (result.FlagResult = False) Then
            Return result
        End If
        phieuMuon.MaPhieuMuon = nextMaPhieuMuon

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaPhieuMuon", phieuMuon.MaPhieuMuon)
                    .Parameters.AddWithValue("@MaDocGia", phieuMuon.MaDocGia)
                    .Parameters.AddWithValue("@NgayMuon", phieuMuon.NgayMuon)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Phiếu mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function DeleteByMaDocGia(iMaDocGia As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblPhieuMuon] "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", iMaDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa Phiếu mượn theo độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
