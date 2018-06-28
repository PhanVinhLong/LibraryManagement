Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class NhanVienDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaNhanVien(ByRef nextMaNhanVien As Integer) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaNhanVien] "
        sqlQuery &= "FROM [tblNhanVien] "
        sqlQuery &= "ORDER BY [MaNhanVien] DESC "

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
                    Dim maNhanVienOnDB As String = String.Empty
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maNhanVienOnDB = dataReader("MaNhanVien")
                        End While
                    End If
                    nextMaNhanVien = maNhanVienOnDB + 1
                    System.Console.WriteLine(nextMaNhanVien)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã nhân viên kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(nhanVien As NhanVienDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblNhanVien] ([MaNhanVien], [TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien]) "
        sqlQuery &= "VALUES (@MaNhanVien, @TenDangNhap, @HoTen, @MatKhau, @MaLoaiNhanVien) "

        Dim nextMaNhanVien = 0
        Dim result As Result
        result = BuildMaNhanVien(nextMaNhanVien)
        If (result.FlagResult = False) Then
            Return result
        End If
        nhanVien.MaNhanVien = nextMaNhanVien

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien)
                    .Parameters.AddWithValue("@TenDangNhap", nhanVien.TenDangNhap)
                    .Parameters.AddWithValue("@HoTen", nhanVien.HoTen)
                    .Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau)
                    .Parameters.AddWithValue("@MaLoaiNhanVien", nhanVien.MaLoaiNhanVien)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectALL(ByRef listNhanVien As List(Of NhanVienDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaNhanVien], [TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien] "
        sqlQuery &= "FROM [tblNhanVien] "

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
                        listNhanVien.Clear()
                        While reader.Read()
                            listNhanVien.Add(New NhanVienDTO(reader("MaNhanVien"), reader("TenDangNhap"), reader("HoTen"), reader("MatKhau"), reader("MaLoaiNhanVien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(nhanVien As NhanVienDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "UPDATE [tblNhanVien] "
        sqlQuery &= "SET [MaLoaiNhanVien] = @MaLoaiNhanVien, "
        sqlQuery &= "    AND [TenDangNhap] = @TenDangNhap, "
        sqlQuery &= "    AND [HoTen] = @HoTen, "
        sqlQuery &= "    AND [MatKhau] = @MatKhau "
        sqlQuery &= "WHERE [MaNhanVien] = @MaNhanVien "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", nhanVien.TenDangNhap)
                    .Parameters.AddWithValue("@HoTen", nhanVien.HoTen)
                    .Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau)
                    .Parameters.AddWithValue("@MaLoaiNhanVien", nhanVien.MaLoaiNhanVien)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Cập nhật nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaNhanVien As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblNhanVien] "
        sqlQuery &= "WHERE [MaNhanVien] = @MaNhanVien "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaNhanVien", iMaNhanVien)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
