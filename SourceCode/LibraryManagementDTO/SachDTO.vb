﻿Public Class SachDTO
    Private iMaSach As Integer
    Private strTenSach As String
    Private dateNgayXuatBan As DateTime
    Private strNhaXuatBan As String
    Private iTriGia As Integer
    Private dateNgayNhap As DateTime
    Private iMaTrangThai As Integer

    Public Sub New()
    End Sub

    Public Sub New(iMaSach As Integer, strTenSach As String, dateNgayXuatBan As DateTime, strNhaXuatBan As String, iTriGia As Integer, dateNgayNhap As DateTime, iMaTrangThai As Integer)
        Me.iMaSach = iMaSach
        Me.strTenSach = strTenSach
        Me.dateNgayXuatBan = dateNgayXuatBan
        Me.strNhaXuatBan = strNhaXuatBan
        Me.iTriGia = iTriGia
        Me.dateNgayNhap = dateNgayNhap
        Me.iMaTrangThai = iMaTrangThai
    End Sub

    Public Property MaSach As Integer
        Get
            Return iMaSach
        End Get
        Set(value As Integer)
            iMaSach = value
        End Set
    End Property

    Public Property TenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property NgayXuatBan As Date
        Get
            Return dateNgayXuatBan
        End Get
        Set(value As Date)
            dateNgayXuatBan = value
        End Set
    End Property

    Public Property NhaXuatBan As String
        Get
            Return strNhaXuatBan
        End Get
        Set(value As String)
            strNhaXuatBan = value
        End Set
    End Property

    Public Property TriGia As Integer
        Get
            Return iTriGia
        End Get
        Set(value As Integer)
            iTriGia = value
        End Set
    End Property

    Public Property NgayNhap As Date
        Get
            Return dateNgayNhap
        End Get
        Set(value As Date)
            dateNgayNhap = value
        End Set
    End Property

    Public Property MaTrangThai As Integer
        Get
            Return iMaTrangThai
        End Get
        Set(value As Integer)
            iMaTrangThai = value
        End Set
    End Property
End Class