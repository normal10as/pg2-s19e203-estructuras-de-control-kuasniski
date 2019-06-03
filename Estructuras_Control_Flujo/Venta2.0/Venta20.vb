Imports System

Module Venta20
    Sub Main(args As String())
        Dim PorcentajeDescuento, CantidadIngresada As Int16
        Dim PrecioUnitario, SubTotal, DescuentoMonto, Total As Decimal
        Console.Write("Ingrese la cantidad: ")
        CantidadIngresada = Console.ReadLine
        Console.Write("Ingrese el precio unitario: ")
        PrecioUnitario = Console.ReadLine

        Select Case CantidadIngresada
            Case > 250
                SubTotal = CantidadIngresada * PrecioUnitario
                DescuentoMonto = (SubTotal * 20) / 100
                Total = SubTotal - DescuentoMonto
                PorcentajeDescuento = 20
            Case > 50
                SubTotal = CantidadIngresada * PrecioUnitario
                DescuentoMonto = (SubTotal * 10) / 100
                Total = SubTotal - DescuentoMonto
                PorcentajeDescuento = 10
            Case >= 10
                SubTotal = CantidadIngresada * PrecioUnitario
                DescuentoMonto = (SubTotal * 5) / 100
                Total = SubTotal - DescuentoMonto
                PorcentajeDescuento = 5

        End Select
        Console.WriteLine("Subtotal: " & SubTotal)
        Console.WriteLine("Descuento del {0}%", PorcentajeDescuento)
        Console.WriteLine("Monto descontado: " & DescuentoMonto)
        Console.WriteLine("Total: " & Total)
        Console.Read()
    End Sub
End Module
