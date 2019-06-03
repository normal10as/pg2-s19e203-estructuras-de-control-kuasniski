Imports System

Module Comparar
    Sub Main(args As String())
        Dim ValorIngresado1, ValorIngresado2 As Integer
        Console.Write("Ingrese un valor: ")
        ValorIngresado1 = Console.ReadLine
        Console.Write("Ingrese otro valor: ")
        ValorIngresado2 = Console.ReadLine
        If ValorIngresado1 > ValorIngresado2 Then
            Console.WriteLine("El primer valor ingresado es mayor al segundo.")
        ElseIf ValorIngresado2 > ValorIngresado1 Then
            Console.WriteLine("El segundo valor ingresado es mayor al primero.")
        End If
        If ValorIngresado1 = ValorIngresado2 Then
            Console.WriteLine("Los valores ingresados son iguales.")
        End If
        Console.Read()

    End Sub
End Module
