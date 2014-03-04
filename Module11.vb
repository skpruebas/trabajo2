Module Module11
    Sub Main()
        Dim numero, cont As Integer
        cont = 1
        Console.WriteLine("DIVISORES DE UN NUMERO: ")
        Console.WriteLine("-------------------------")
        Console.WriteLine("INGERESE NUMERO: ")
        numero = Console.ReadLine()
        Console.WriteLine("-------------------------")
        While cont <= numero

            If numero Mod cont = 0 Then
                Console.WriteLine(cont)

            End If
            cont = cont + 1
        End While

        Console.Read()

    End Sub
End Module
