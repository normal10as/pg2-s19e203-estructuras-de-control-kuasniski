Imports System

Module Tercero
    Sub Main(args As String())
        Dim a, b, c, d, e As Integer
        Console.Write("Ingrese el primer n�mero: ")
        a = Console.ReadLine
        Console.Write("Ingrese el segundo n�mero: ")
        b = Console.ReadLine
        Console.Write("Ingrese el tercer n�mero: ")
        c = Console.ReadLine
        Console.Write("Ingrese el cuarto n�mero: ")
        d = Console.ReadLine
        Console.Write("Ingrese el quinto n�mero: ")
        e = Console.ReadLine

        If a > b And a > c And a > d And a > e Then
            Console.WriteLine("El primer n�mero es el de mayor valor")
        ElseIf b > c And b > d And b > e Then
            Console.WriteLine("El segundo n�mero es el de mayor valor")
        ElseIf c > d And c > e Then
            Console.WriteLine("El tercer n�mero es el de mayor valor")
        ElseIf d > e Then
            Console.WriteLine("El cuarto n�mero es el de mayor valor")
        Else
            Console.WriteLine("El quinto n�mero es el de mayor valor")
        End If
        Console.Read()
    End Sub
End Module
