Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With OpenFileDialog1
            .InitialDirectory = "C:\Users\Arthur\Downloads\"
        End With
        Dim lijn, school, klas, naam, filterklas, filterschool, totaalllnschool As String
        Dim einde As Boolean
        Dim totaalllnklas As Integer
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            Try
                lijn = LineInput(1)
                school = lijn.Substring(0, 29).Trim
                klas = lijn.Substring(29, 5).Trim
                naam = lijn.Substring(33).Trim
            Catch ex As Exception
                einde = True
            End Try
            Do While Not einde
                filterschool = school
                totaalllnschool = 0
                ListBox1.Items.Add("Het aantal leerlingen van " & filterschool & " is:")
                Do While Not einde And school = filterschool
                    totaalllnschool += totaalllnklas
                    filterklas = klas
                    totaalllnklas = 0
                    Do While Not einde And klas = filterklas
                        totaalllnklas += 1
                        Try
                            lijn = LineInput(1)
                            school = lijn.Substring(0, 29).Trim
                            klas = lijn.Substring(29, 5).Trim
                            naam = lijn.Substring(33).Trim
                        Catch ex As Exception
                            einde = True
                        End Try

                    Loop
                    ListBox1.Items.Add("Het aantal leerlingen van " & filterklas & " is " & totaalllnklas)
                Loop
                ListBox1.Items.Add(vbCrLf)
                ListBox1.Items.Add("Het totaal is: " & totaalllnschool)
                ListBox1.Items.Add(vbCrLf)
            Loop

        End If

    End Sub
End Class
