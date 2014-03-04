Module Module1

    Sub Main()
        Dim num_pares As Integer

        Console.WriteLine(" NUMEROS PARES DE DOS CIFRAS ")
        num_pares = 0
        While (num_pares <= 96)
            num_pares = num_pares + 2

            Console.WriteLine("NUMEROS: " & num_pares)
        End While


        Console.Read()
    End Sub

End Module
