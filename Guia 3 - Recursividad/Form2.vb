'Nombre:Josue Isaias Martinez
'N° cuenta: 20201002923
'Descripción:
'2. Desarrolle un programa que solicite dos valores enteros positivos y retorne la multiplicación 
'de estos, no utilice el carácter * para la multiplicación. Su programa deberá invocar una 
'función recursiva que retorne la multiplicación.


Public Class Form2
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim multiplicando, multiplicador, result As Integer


        multiplicando = CInt(TextBox1.Text)
        multiplicador = CInt(TextBox2.Text)

        result = recursiveMultiplication(multiplicando, multiplicador)
        TextBox3.Text = Str(result)
    End Sub

    Public Function recursiveMultiplication(multiplincado As Integer, multiplicador As Integer) As Integer
        If multiplicador = 1 Then
            Return multiplincado
        Else
            Return multiplincado + recursiveMultiplication(multiplincado, multiplicador - 1)
        End If
    End Function
End Class