Module Module14
    Sub Main()
        Dim aux, numero, cont, razon As Integer
        aux = 3
        razon = 5
        Console.WriteLine("SERIE DE NUMEROS")
        Console.Write("INGRESE NUMERO: ")
        numero = Console.ReadLine()
        For cont = 0 To numero
            Console.WriteLine(aux)
            aux = aux + razon
            razon = razon + 2
        Next

        Console.Read()
    End Sub
End Module
