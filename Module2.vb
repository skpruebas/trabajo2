Module Module2
    Sub Main()
        Dim rs, numero, cont As Integer
        Console.WriteLine("FACTORIAL DE UN NUMERO")
        numero = Console.ReadLine()

        rs = 1
        cont = 1

        While (cont <= numero)
            rs = rs * cont
            cont = cont + 1
            Console.WriteLine(rs)

        End While
        Console.WriteLine("EL FACTORIAL DE " & numero & " ES " & rs)

        Console.Read()
    End Sub
End Module
