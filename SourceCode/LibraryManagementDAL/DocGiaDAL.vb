Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class DocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaDocGia(ByRef nextMaDocGia As String) As Result
        nextMaDocGia = String.Empty
        nextMaDocGia = "00000000"
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaDocGia] "
        sqlQuery &= "FROM [tblDocGia] "
        sqlQuery &= "ORDER BY [MaDocGia] DESC "

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
                    Dim maDocGiaOnDB As String = Nothing
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maDocGiaOnDB = dataReader("MaDocGia")
                        End While
                    End If
                    Dim dMaDocGia As Decimal = 0
                    If (maDocGiaOnDB <> Nothing) Then
                        dMaDocGia = Convert.ToDecimal(maDocGiaOnDB)
                    End If
                    dMaDocGia = dMaDocGia + 1
                    nextMaDocGia = dMaDocGia.ToString
                    nextMaDocGia = nextMaDocGia.PadLeft(8 - nextMaDocGia.Length, "0")
                    System.Console.WriteLine(nextMaDocGia)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy MaDocGia kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(docGia As DocGiaDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "INSERT INTO [tblDocGia]([MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) "
        sqlQuery &= "VALUES(@MaDocGia, @HoTen, @NgaySinh, @DiaChi, @Email, @NgayLapThe, @NgayHetHan, @MaLoaiDocGia) "

        ' Lấy MaDocGia kế tiếp
        Dim nextMaDocGia = "00000001"
        BuildMaDocGia(nextMaDocGia)
        docGia.MaDocGia = nextMaDocGia

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                    .Parameters.AddWithValue("@HoTen", docGia.HoTen)
                    .Parameters.AddWithValue("@NgaySinh", docGia.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", If(String.IsNullOrWhiteSpace(docGia.DiaChi), "trống", docGia.DiaChi))
                    .Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(docGia.Email), "trống", docGia.Email))
                    .Parameters.AddWithValue("@NgayLapThe", docGia.NgayLapThe)
                    .Parameters.AddWithValue("@NgayHetHan", docGia.NgayHetHan)
                    .Parameters.AddWithValue("@MaLoaiDocGia", docGia.MaLoaiDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm DocGia không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectAll(ByRef listDocGia As List(Of DocGiaDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia] "
        sqlQuery &= "FROM [tblDocGia]"

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
                            listDocGia.Add(New DocGiaDTO(dataReader("MaDocGia"), dataReader("HoTen"), dataReader("NgaySinh"), dataReader("DiaChi"), dataReader("Email"), dataReader("NgayLapThe"), dataReader("NgayHetHan"), dataReader("MaLoaiDocGia")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByLoaiDocGia(iMaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia] "
        sqlQuery &= "FROM [tblDocGia] "
        sqlQuery &= "WHERE [MaLoaiDocGia] = @MaLoaiDocGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaLoaiDocGia", iMaLoaiDocGia)
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            listDocGia.Add(New DocGiaDTO(dataReader("MaDocGia"), dataReader("HoTen"), dataReader("NgaySinh"), dataReader("DiaChi"), dataReader("Email"), dataReader("NgayLapThe"), dataReader("NgayHetHan"), dataReader("MaLoaiDocGia")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Độc giả theo Loại độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(docGia As DocGiaDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "UPDATE [tblDocGia] SET "
        sqlQuery &= "[HoTen] = @HoTen, "
        sqlQuery &= "[NgaySinh] = @NgaySinh, "
        sqlQuery &= "[DiaChi] = @DiaChi, "
        sqlQuery &= "[Email] = @Email, "
        sqlQuery &= "[NgayLapThe] = @NgayLapThe, "
        sqlQuery &= "[NgayHetHan] = @NgayHetHan, "
        sqlQuery &= "[MaLoaiDocGia] = @MaLoaiDocGia "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                    .Parameters.AddWithValue("@HoTen", docGia.HoTen)
                    .Parameters.AddWithValue("@NgaySinh", docGia.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", docGia.DiaChi)
                    .Parameters.AddWithValue("@Email", docGia.Email)
                    .Parameters.AddWithValue("@NgayLapThe", docGia.NgayLapThe)
                    .Parameters.AddWithValue("@NgayHetHan", docGia.NgayHetHan)
                    .Parameters.AddWithValue("@MaLoaiDocGia", docGia.MaLoaiDocGia)
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

    Public Function Delete(iMaDocGia As Integer)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "DELETE FROM [tblDocGia] "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia"

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
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xoá Độc giả không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
