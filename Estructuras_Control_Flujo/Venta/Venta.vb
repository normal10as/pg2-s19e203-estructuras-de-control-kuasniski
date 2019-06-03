Imports System
Imports System.Math
Module Venta
    Sub Main(args As String())
        Dim PorcentajeDescuento, CantidadIngresada As Int16
        Dim PrecioUnitario, SubTotal, DescuentoMonto, Total As Decimal
        Console.Write("Ingrese la cantidad: ")
        CantidadIngresada = Console.ReadLine
        Console.Write("Ingrese el precio unitario: ")
        PrecioUnitario = Console.ReadLine

        If CantidadIngresada >= 10 And CantidadIngresada <= 50 Then
            SubTotal = CantidadIngresada * PrecioUnitario
            DescuentoMonto = (SubTotal * 5) / 100
            Total = SubTotal - DescuentoMonto
            PorcentajeDescuento = 5

        ElseIf CantidadIngresada >= 51 And CantidadIngresada <= 250 Then
            SubTotal = CantidadIngresada * PrecioUnitario
            DescuentoMonto = (SubTotal * 10) / 100
            Total = SubTotal - DescuentoMonto
            PorcentajeDescuento = 10

        ElseIf CantidadIngresada >= 251 Then
            SubTotal = CantidadIngresada * PrecioUnitario
            DescuentoMonto = (SubTotal * 20) / 100
            Total = SubTotal - DescuentoMonto


        End If

        Console.WriteLine("Subtotal: " & SubTotal)
        Console.WriteLine("Descuento del {0}%", PorcentajeDescuento)
        Console.WriteLine("Monto descontado: " & DescuentoMonto)
        Console.WriteLine("Total: " & Total)
        Console.Read()

    End Sub
End Module
