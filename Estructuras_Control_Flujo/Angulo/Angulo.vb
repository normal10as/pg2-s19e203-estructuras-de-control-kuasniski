Imports System

Module Angulo
    Sub Main(args As String())
        Dim Tama�oAngulo As Int16
        Console.Write("Ingrese el tama�o de un angulo en grados: ")
        Tama�oAngulo = Console.ReadLine

        Select Case Tama�oAngulo
            Case 0 To 90
                Console.WriteLine("Agudo.")
            Case 90
                Console.WriteLine("Recto.")
            Case 90 To 179
                Console.WriteLine("Obtuso.")
            Case 180
                Console.WriteLine("Llano.")
            Case 180 To 359
                Console.WriteLine("C�ncavo.")
            Case < 0
                Console.WriteLine("Error.")
            Case > 360
                Console.WriteLine("Error.")

        End Select
        Console.Read()

    End Sub
End Module
