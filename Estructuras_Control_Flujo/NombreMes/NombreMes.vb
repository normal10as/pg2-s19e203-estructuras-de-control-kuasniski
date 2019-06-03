Imports System

Module NombreMes
    Enum MesesDelAño
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum

    Sub Main(args As String())
        Dim Mes As MesesDelAño

        Console.Write("Ingrese un men en numero: ")
        Mes = Console.ReadLine

        Select Case Mes
            Case 1
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 2
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 3
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 4
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 5
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 6
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 7
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 8
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 9
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 10
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 11
                Console.WriteLine("Mes de: " & Mes.ToString)
            Case 12
                Console.WriteLine("Mes de: " & Mes.ToString)
        End Select
        Console.Read()

    End Sub
End Module
