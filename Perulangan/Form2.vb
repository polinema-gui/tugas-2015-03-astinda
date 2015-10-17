Public Class Form2
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LapisanBawah, LapisanAtas, Kolom, InputKolom As Integer
        Dim InputBaris = Val(Inputan.Text)
        Dim JmlhBaris As Integer = 1
        Dim Hasil As String
        InputKolom = (InputBaris * 2) - 1
        If TombolPilih.Text = "Pyramid" Then
            LapisanAtas = InputBaris + 1
            LapisanBawah = InputBaris - 1
            For JmlhBaris = 1 To InputBaris
                For Kolom = 1 To InputKolom
                    If Kolom > LapisanBawah And Kolom < LapisanAtas Then
                        Hasil += "1"
                    Else
                        Hasil += "0"
                    End If
                Next
                LapisanBawah -= 1
                LapisanAtas += 1
                Hasil &= vbCrLf  
            Next
            Output.Text = Hasil
            '---------------------------------------------------------------------------
        ElseIf TombolPilih.Text = "Hollow Pyramid" Then
            LapisanAtas = InputBaris
            LapisanBawah = InputBaris
            For JmlhBaris = 1 To InputBaris
                If JmlhBaris = InputBaris Then
                    For Kolom = 1 To InputKolom
                        Hasil += "1"
                    Next

                Else
                    For Kolom = 1 To InputKolom
                        If Kolom = LapisanBawah Or Kolom = LapisanAtas Then
                            Hasil += "1"
                        Else
                            Hasil += "0"
                        End If
                    Next
                End If
                LapisanBawah -= 1
                LapisanAtas += 1
                Hasil &= vbCrLf
                
            Next
            Output.Text = Hasil
            
            '-------------------------------------------------------------------------------
        ElseIf TombolPilih.Text = "Inverter Pyramid" Then
            LapisanAtas = InputKolom
            LapisanBawah = 1
            For jmlbaris = 1 To InputBaris
                For Kolom = 1 To InputKolom
                    If Kolom >= LapisanBawah And Kolom <= LapisanAtas Then
                        Hasil += "1"
                    Else
                        Hasil += "0"
                    End If
                Next
                LapisanBawah += 1
                LapisanAtas -= 1
                Hasil &= vbCrLf
            Next
            Output.Text = Hasil
            '-------------------------------------------------------------------------------
        ElseIf TombolPilih.Text = "Hollow Inverter Pyramid" Then
            LapisanAtas = InputBaris
            LapisanBawah = InputBaris
            For baris = 1 To InputBaris
                If baris = 1 Then
                    For Kolom = 1 To InputKolom
                        Hasil += "1"
                    Next
                Else
                    For Kolom = 1 To InputKolom
                        If Kolom = baris Or Kolom = InputKolom + 1 - baris Then
                            Hasil += "1"
                        Else
                            Hasil += "0"
                        End If
                    Next
                End If
                LapisanBawah -= 1
                LapisanAtas += 1
                Hasil &= vbCrLf
            Next
            Output.Text = Hasil

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Inputan.TextChanged

    End Sub

    Private Sub Output_TextChanged(sender As Object, e As EventArgs) Handles Output.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class