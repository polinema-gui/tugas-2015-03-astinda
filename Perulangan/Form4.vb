﻿Public Class Form4
    Dim look As Boolean = True


    

    Private Sub convertToArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.look) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = Txb_matrik1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = Txb_matrik2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub

    Private Sub result(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim tmp As Boolean = True
        For baris = 0 To baris1 - 2
            If (Txb_matrik1.Lines.ElementAt(baris).Split(" ").Length <> Txb_matrik1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For baris = 0 To baris2 - 2
            If (Txb_matrik2.Lines.ElementAt(baris).Split(" ").Length <> Txb_matrik2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.look = False
            Convert.ToInt32(Txb_matrik1.Text)
            Convert.ToInt32(Txb_matrik2.Text)
            MsgBox("Matriks Tidak Valid")
        ElseIf (baris1 = baris2 And kolom1 = kolom2) Then
            Me.look = True
        Else
            Me.look = False
            MsgBox("Baris dan Kolom Semua Matriks Harus Sama")
        End If
    End Sub

    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.look) Then
            Select Case Cmb_operasi.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            Txb_hasil.Text = hasil
        End If
    End Sub

    Private Sub Txb_matrik1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txb_matrik2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
    End Sub




    Private Sub Matriks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_proses_Click_1(sender As Object, e As EventArgs) Handles Btn_proses.Click
        Try
            Dim barisMatriks1 As Integer = Txb_matrik1.Lines.Count
            Dim kolomMatriks1 As Integer = Txb_matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatriks2 As Integer = Txb_matrik1.Lines.Count
            Dim kolomMatriks2 As Integer = Txb_matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim copyMatriks1(barisMatriks1, kolomMatriks1) As Integer
            Dim copyMatriks2(barisMatriks2, kolomMatriks2) As Integer
            result(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2)
            convertToArray(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2, copyMatriks1, copyMatriks2)
            operasi(copyMatriks1, copyMatriks2, barisMatriks1, kolomMatriks2)
        Catch ex As Exception
            MsgBox("Masukan Bukan Angka")
        End Try
    End Sub

    Private Sub Cmb_operasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_operasi.SelectedIndexChanged

    End Sub

    Private Sub Txb_matrik1_TextChanged_1(sender As Object, e As EventArgs) Handles Txb_matrik1.TextChanged

    End Sub

    Private Sub Txb_matrik2_TextChanged_1(sender As Object, e As EventArgs) Handles Txb_matrik2.TextChanged

    End Sub

    Private Sub Txb_hasil_TextChanged(sender As Object, e As EventArgs) Handles Txb_hasil.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Lbl_hasil_Click(sender As Object, e As EventArgs) Handles Lbl_hasil.Click

    End Sub

    Private Sub Lbl_operasi_Click(sender As Object, e As EventArgs) Handles Lbl_operasi.Click

    End Sub

    Private Sub Lbl_matrik1_Click(sender As Object, e As EventArgs) Handles Lbl_matrik1.Click

    End Sub
End Class