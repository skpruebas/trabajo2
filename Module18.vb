Module Module18
    Sub Main()
        Dim a As Integer
        Dim numero As Integer

        Console.WriteLine("NUMERO PRIMO")
        For numero = 0 To 100
            For i As Integer = 1 To numero + 1
                If (numero Mod i = 0) Then
                    a = a + 1
                End If
            Next
            If (a <> 2) Then
                Console.WriteLine(numero & " NO ES NUMERO PRIMO ")
            Else
                Console.WriteLine(numero & " SI ES NUMERO PRIMO ")
            End If
        Next
        Console.Read()
    End Sub
End Module
