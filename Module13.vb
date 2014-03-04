Module Module13
    Sub Main()
        Dim numero, cuadrado, i As Integer
        Console.WriteLine("SERIE DE NUMEROS AL CUADRADO")
        Console.Write("INGRESE NUMERO: ")
        numero = Console.ReadLine()
        Console.WriteLine("----------------")

        For i = 0 To numero
            cuadrado = i ^ 2
            Console.WriteLine(cuadrado)
        Next
        Console.Read()
    End Sub
End Module
