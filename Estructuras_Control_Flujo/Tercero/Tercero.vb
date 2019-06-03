Imports System

Module Tercero
    Sub Main(args As String())
        Dim a, b, c, d, e As Integer
        Console.Write("Ingrese el primer número: ")
        a = Console.ReadLine
        Console.Write("Ingrese el segundo número: ")
        b = Console.ReadLine
        Console.Write("Ingrese el tercer número: ")
        c = Console.ReadLine
        Console.Write("Ingrese el cuarto número: ")
        d = Console.ReadLine
        Console.Write("Ingrese el quinto número: ")
        e = Console.ReadLine

        If a > b And a > c And a > d And a > e Then
            Console.WriteLine("El primer número es el de mayor valor")
        ElseIf b > c And b > d And b > e Then
            Console.WriteLine("El segundo número es el de mayor valor")
        ElseIf c > d And c > e Then
            Console.WriteLine("El tercer número es el de mayor valor")
        ElseIf d > e Then
            Console.WriteLine("El cuarto número es el de mayor valor")
        Else
            Console.WriteLine("El quinto número es el de mayor valor")
        End If
        Console.Read()
    End Sub
End Module
