Module Module15
    Sub Main()
        Dim numero, sumas, cont As Integer

        Console.WriteLine("NUMERO PERFECTO")
        Console.WriteLine("---------------")
        Console.Write("INGRESE NUMERO: ")

        sumas = 0

        While (cont < 3)

            Console.WriteLine(numero)
            For i = 1 To numero - 1
                If numero Mod i = 0 Then
                    sumas = sumas + i
                End If
            Next
            If sumas = numero Then
                Console.WriteLine(numero & " ES UN NUMERO PERFECTO")
            Else
                Console.WriteLine(numero & " NO ES UN NUMERO PERFECTO")
            End If
            numero = numero + 1
            cont = cont + 1
        End While
       

        Console.Read()
    End Sub
End Module
