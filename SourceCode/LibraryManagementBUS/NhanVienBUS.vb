Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class NhanVienBUS
    Private nhanVienDAL As NhanVienDAL

    Public Sub New()
        nhanVienDAL = New NhanVienDAL()
    End Sub

    Public Sub New(connectionString As String)
        nhanVienDAL = New NhanVienDAL(connectionString)
    End Sub

    Public Function IsValidHoTen(nhanVien As NhanVienDTO) As Boolean
        If (nhanVien.HoTen = Nothing) Then
            Return False
        ElseIf (nhanVien.HoTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsValidMatKhauSpace(nhanVien As NhanVienDTO) As Boolean
        For Each c As Char In nhanVien.MatKhau
            If c = " " Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function IsValidMatKhauLength(nhanVien As NhanVienDTO) As Boolean
        If nhanVien.MatKhau.Length >= 6 And nhanVien.MatKhau.Length <= 15 Then
            Return True
        End If
        Return False
    End Function

    Public Function BuildMaNhanVien(ByRef nextMaNhanVien As Integer) As Result
        Return nhanVienDAL.BuildMaNhanVien(nextMaNhanVien)
    End Function

    Public Function Insert(nhanVien As NhanVienDTO) As Result
        Return nhanVienDAL.Insert(nhanVien)
    End Function

    Public Function SelectALL(ByRef listNhanVien As List(Of NhanVienDTO)) As Result
        Return nhanVienDAL.SelectALL(listNhanVien)
    End Function
End Class
