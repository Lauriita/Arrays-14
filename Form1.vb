Public Class Form1

    Dim a(10) As Integer
    Dim cadena As String
    Dim contador As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For contador = 0 To 9

            a(contador) = InputBox("introduce un numero si es -1 para")
            If a(contador) = -1 Then
                contador = 9
            End If
            cadena = (cadena & " " & a(contador))
        Next
        cadena = (cadena & vbNewLine)
        TextBox1.Text = cadena
    End Sub


End Class
