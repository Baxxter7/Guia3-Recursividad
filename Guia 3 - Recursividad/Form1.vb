'Nombre:Josue Isaias Martinez
'N° cuenta: 20201002923
'Descripción:
'1. Desarrolle un programa que solicite un entero positivo e invoque una función recursiva que 
'retorne la suma de todos los enteros positivos desde 1 hasta el número ingresado por el 
'usuario, despliegue el resultado en un textbox. Por ejemplo, si se ingresa 4, la respuesta 
'debería ser 10 dado que 1+2+3+4 es 10

Public Class Form1
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim number As Integer
        Dim result As Integer

        number = CInt(TextBox1.Text)

        result = sum(number)
        TextBox1.Text = Str(result)
    End Sub

    Public Function sum(number As Integer) As Integer
        'Para funciones recursivas debemos tener un caso base
        If number = 1 Then
            Return 1
        Else
            Return number + sum(number - 1) 'Si dejamos solo number se hara un loop infinito
        End If
    End Function
End Class
