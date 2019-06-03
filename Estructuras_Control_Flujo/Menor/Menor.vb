Imports System

Module Menor
    Sub Main(args As String())
        Dim ValorIngresado1, ValorIngresado2, ValorIngresado3 As Integer
        Console.Write("Ingrese el primer valor: ")
        ValorIngresado1 = Console.ReadLine
        Console.Write("Ingrese el segundo valor: ")
        ValorIngresado2 = Console.ReadLine
        Console.Write("Ingrese el tercer valor: ")
        ValorIngresado3 = Console.ReadLine

        If ValorIngresado1 < ValorIngresado2 Then
            Console.WriteLine(ValorIngresado1)
        ElseIf ValorIngresado2 < ValorIngresado3 Then
            Console.WriteLine(ValorIngresado2)
        Else
            Console.WriteLine(ValorIngresado3)
        End If
        Console.Read()

    End Sub
End Module
