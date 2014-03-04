Module Module6
    Sub Main()
        Dim numero, cont, i As Integer
        Console.WriteLine("SERIE DE NUMEROS")
        Console.Write("INGRESE NUMERO: ")
        numero = Console.ReadLine()
        Console.WriteLine("----------------")

        While (cont <= numero)
            i = cont

            If (i Mod 2 = 0) Then
                i = i * -1
                Console.WriteLine(i)
            Else
                Console.WriteLine(cont)
            End If

            cont = cont + 1


        End While

        Console.Read()
    End Sub
End Module
