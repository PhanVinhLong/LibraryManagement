Imports System.Configuration
Imports System.Data.SqlClient
    Imports LibraryManagementDTO
    Imports Utility

Public Class SachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaSach(ByRef nextMaSach As Integer) As Result
        nextMaSach = 0
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaSach] "
        sqlQuery &= "FROM [tblSach] "
        sqlQuery &= "ORDER BY [MaSach] DESC "

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
                    Dim maSachOnDB As Integer = 0
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maSachOnDB = dataReader("MaSach")
                        End While
                    End If
                    nextMaSach = maSachOnDB + 1
                    System.Console.WriteLine(nextMaSach)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã sách kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(sach As SachDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "INSERT INTO [tblSach]([MaSach], [TenSach], [NgayXuatBan], [MaNhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai] "
        sqlQuery &= "VALUES(@MaSach, @TenSach, @NgayXuatBan, @MaNhaXuatBan, @TriGia, @NgayNhap, @MaTrangThai "

        ' Lấy MaDocGia kế tiếp
        Dim nextMaSach = 0
        BuildMaSach(nextMaSach)
        sach.MaSach = nextMaSach
        sach.MaTrangThai = 1

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                    .Parameters.AddWithValue("@TenSach", sach.TenSach)
                    .Parameters.AddWithValue("@NgayXuatBan", sach.NgayXuatBan)
                    .Parameters.AddWithValue("@MaNhaXuatBan", sach.MaNhaXuatBan)
                    .Parameters.AddWithValue("@TriGia", sach.TriGia)
                    .Parameters.AddWithValue("@NgayNhap", sach.NgayNhap)
                    .Parameters.AddWithValue("@MaTrangThai", sach.MaTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Sách không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectAll(ByRef listSach As List(Of SachDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaSach], [TenSach], [NgayXuatBan], [MaNhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai] "
        sqlQuery &= "FROM [tblSach]"

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
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            listSach.Add(New SachDTO(dataReader("MaSach"), dataReader("TenSach"), dataReader("NgayXuatBan"), dataReader("MaNhaXuatBan"), dataReader("TriGia"), dataReader("NgayNhap"), dataReader("MaTrangThai")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByCondition(iMaTheLoai As Integer, iMaNhaXuatBan As Integer, iMaTacGia As Integer, iMaTrangThai As Integer, ByRef listSach As List(Of SachDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [tblSach].[MaSach], [TenSach], [NgayXuatBan], [tblSach].[MaNhaXuatBan], [TriGia], [NgayNhap], [tblSach].[MaTrangThai] "
        sqlQuery &= "FROM [tblSach], [tblTacGiaSach], [tblTheLoaiSach] "
        sqlQuery &= "WHERE [tblSach].[MaSach] = [tblTacGiaSach].[MaSach] "
        sqlQuery &= "      AND [tblSach].[MaSach] = [tblTheLoaiSach].[MaSach] "
        If (iMaTheLoai <> Nothing) Then
            sqlQuery &= "AND [MaTheLoai] = @MaTheLoai "
        End If
        If (iMaNhaXuatBan <> Nothing) Then
            sqlQuery &= "AND [MaNhaXuatBan] = @MaNhaXuatBan "
        End If
        If (iMaTacGia <> Nothing) Then
            sqlQuery &= "AND [MaTacGia] = @MaTacGia "
        End If
        If (iMaTrangThai <> Nothing) Then
            sqlQuery &= "AND [MaTrangThai] = @MaTrangThai "
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                    .Parameters.AddWithValue("@MaNhaXuatBan", iMaNhaXuatBan)
                    .Parameters.AddWithValue("@MaTrangThai", iMaTrangThai)
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            listSach.Add(New SachDTO(dataReader("MaSach"), dataReader("TenSach"), dataReader("NgayXuatBan"), dataReader("MaNhaXuatBan"), dataReader("TriGia"), dataReader("NgayNhap"), dataReader("MaTrangThai")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Sách theo yêu cầu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(sach As SachDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "UPDATE [tblSach] SET "
        sqlQuery &= "[TenSach] = @TenSach, "
        sqlQuery &= "[NgayXuatBan] = @NgayXuatBan, "
        sqlQuery &= "[MaNhaXuatBan] = @MaNhaXuatBan, "
        sqlQuery &= "[TriGia] = @TriGia, "
        sqlQuery &= "[NgayNhap] = @NgayNhap, "
        sqlQuery &= "[MaTrangThai] = @MaTrangThai, "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenSach", sach.TenSach)
                    .Parameters.AddWithValue("@NgayXuatBan", sach.NgayXuatBan)
                    .Parameters.AddWithValue("@MaNhaXuatBan", sach.MaNhaXuatBan)
                    .Parameters.AddWithValue("@TriGia", sach.TriGia)
                    .Parameters.AddWithValue("@NgayNhap", sach.NgayNhap)
                    .Parameters.AddWithValue("@MaTrangThai", sach.MaTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Sửa thông tin Độc giả không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaSach As Integer)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "DELETE FROM [tblSach] "
        sqlQuery &= "WHERE [MaSach] = @MaSach "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xoá Độc giả không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
