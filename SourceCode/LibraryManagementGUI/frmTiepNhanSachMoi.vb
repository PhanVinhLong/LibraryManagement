Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class frmTiepNhanSachMoi
    Private sachBUS As sachBUS
    Private tacGiaBUS As TacGiaBUS
    Private theLoaiBUS As TheLoaiBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub frmTiepNhanSachMoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Cài đặt form
        Me.Location = New Point(0, 0)
    End Sub
End Class