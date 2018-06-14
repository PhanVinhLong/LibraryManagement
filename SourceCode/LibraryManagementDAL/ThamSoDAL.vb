Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class ThamSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function GetData(ByRef thamSo As ThamSoDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TuoiToiThieu],[TuoiToiDa],[ThoiHanSuDung],[GioiHanNamXuatBan],[SoLuongTacGia],[SoLuongSachMuonToiDa],[NgayMuonToiDa],[SoLuongTheLoai],[SoLuongLoaiDocGia] "
        sqlQuery &= "FROM [tblThamSo] "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            thamSo = New ThamSoDTO(reader("TuoiToiThieu"), reader("TuoiToiDa"), reader("ThoiHanSuDung"), reader("GioiHanNamXuatBan"), reader("SoLuongTacGia"), reader("SoLuongSachMuonToiDa"), reader("NgayMuonToiDa"), reader("SoLuongTheLoai"), reader("SoLuongLoaiDocGia"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy dữ liệu ThamSo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
