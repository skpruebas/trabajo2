Module Module3
    Sub Main()
        Dim a As Integer
        Dim numero As Integer

        Console.WriteLine("NUMERO PRIMO")
        Console.Write("INGRESE NUMERO: ")
        numero = Console.ReadLine()
        For i As Integer = 1 To numero + 1
            If (numero Mod i = 0) Then
                a = a + 1
            End If
        Next
        If (a <> 2) Then
            Console.WriteLine("NO ES NUMERO PRIMO ")
        Else
            Console.WriteLine("SI ES NUMERO PRIMO ")
        End If

        Console.Read()
    End Sub
End Module
