'Nombre:Josue Isaias Martinez
'N° cuenta: 20201002923
'Descripción:
'3. Desarrolle un programa que calcule el factorial de un número, el programa debe solicitar al 
'usuario ingresar un entero positivo, invocar una función recursiva que retornará el factorial 
'de ese número. Si el usuario ingresa 4, la función debe retornar 24 dado que 4! es igual a 
'1*2*3*4.
Public Class Form3
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim number As Integer
        Dim result As Integer

        number = CInt(TextBox1.Text)

        result = Factorial(number)
        TextBox2.Text = Str(result)
    End Sub

    Public Function Factorial(number As Integer) As Integer

        If number = 1 Then
            Return 1
        Else
            Return number * Factorial(number - 1)
        End If


    End Function
End Class