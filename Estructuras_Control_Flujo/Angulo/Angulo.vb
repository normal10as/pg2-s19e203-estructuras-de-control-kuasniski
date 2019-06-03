Imports System

Module Angulo
    Sub Main(args As String())
        Dim TamañoAngulo As Int16
        Console.Write("Ingrese el tamaño de un angulo en grados: ")
        TamañoAngulo = Console.ReadLine

        Select Case TamañoAngulo
            Case 0 To 90
                Console.WriteLine("Agudo.")
            Case 90
                Console.WriteLine("Recto.")
            Case 90 To 179
                Console.WriteLine("Obtuso.")
            Case 180
                Console.WriteLine("Llano.")
            Case 180 To 359
                Console.WriteLine("Cóncavo.")
            Case < 0
                Console.WriteLine("Error.")
            Case > 360
                Console.WriteLine("Error.")

        End Select
        Console.Read()

    End Sub
End Module
