Public Class Form1
    Dim Res As Integer
    Dim op As String
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 1
        Else
            Resultat.Text = 1
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 2
        Else
            Resultat.Text = 2
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 3
        Else
            Resultat.Text = 3
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 4
        Else
            Resultat.Text = 4
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 5
        Else
            Resultat.Text = 5
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 6
        Else
            Resultat.Text = 6
        End If
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 7
        Else
            Resultat.Text = 7
        End If

    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 8
        Else
            Resultat.Text = 8
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If (Resultat.Text <> "0") Then
            Resultat.Text = Resultat.Text & 9
        Else
            Resultat.Text = 9
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Resultat.Text = "0") Then
            Resultat.Text = 0
        Else
            Resultat.Text = Resultat.Text & 0
        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        Res = Resultat.Text
        Resultat.Text = ""
        op = "+"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Res = Resultat.Text
        Resultat.Text = ""
        op = "-"
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Res = Resultat.Text
        Resultat.Text = ""
        op = "*"
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Res = Resultat.Text
        Resultat.Text = ""
        op = "/"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

        If (Res <> 0) Then

            If (op = "+") Then
                Resultat.Text = Resultat.Text + Res
            ElseIf (op = "/") Then
                Resultat.Text = Resultat.Text / Res
            ElseIf (op = "-") Then
                Resultat.Text = Resultat.Text - Res
            ElseIf (op = "*") Then
                Resultat.Text = Resultat.Text * Res
            Else
                Resultat.Text = Resultat.Text \ Res

            End If


        End If

    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        If Resultat.Text.Length > 0 Then
            Resultat.Text = Resultat.Text.Remove(Resultat.Text.Length - 1, 1)

        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Resultat.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Resultat.Text = Math.Sqrt(Resultat.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Resultat.Text = 1 / Resultat.Text
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Resultat.Text = Resultat.Text * -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Res = Resultat.Text
        Resultat.Text = 0
        op = "\"
    End Sub
End Class
