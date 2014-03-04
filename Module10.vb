Module Module10
    Sub Main()
        Dim i, j, cociente, base, nro, sumador, resto, resultado As Integer
        Console.WriteLine("CAMBIO DE BASE N A BASE 10")
        Console.WriteLine("")
        Console.WriteLine("INGRESE EL NUMERO ")
        nro = Console.ReadLine()
        Console.WriteLine("INGRESE LA BASE ")
        base = Console.ReadLine()

        For i = 0 To 10
            If nro >= base Then
                resto = nro Mod 10
                If resto < base Then
                    cociente = nro \ 10
                    sumador = sumador + resto * base ^ i
                    nro = cociente
                    j = i + 1
                Else
                    Console.WriteLine("NINGUN DIGITO DEL NUMERO PUEDE SER MAYOR")
                    sumador = 0
                    nro = 0
                    i = 10
                End If
            End If
        Next
        
        resultado = sumador + nro * base ^ j
        Console.WriteLine("RESULTADO :  " & resultado)

        Console.Read()
    End Sub
End Module
