Module Module5
    Sub Main()
        Dim numero, cont As Integer
        Dim suma As Double

        cont = 0

        Console.Write("INGRESE UN NUMERO: ")
        numero = Console.ReadLine()

        While (cont < numero)

            If (cont Mod 2 <> 0) Then

                suma = suma + cont
            End If
            cont = cont + 1
        End While

        Console.WriteLine("SUMA: " & suma)
        Console.Read()
    End Sub
End Module
