Module Module4
    Sub Main()
        Dim numero, sumas As Integer

        Console.WriteLine("NUMERO PERFECTO")
        Console.WriteLine("---------------")
        Console.Write("INGRESE NUMERO: ")

        numero = Console.ReadLine()
        sumas = 0
        For i = 1 To numero - 1
            If numero Mod i = 0 Then sumas = sumas + i
        Next
        If sumas = numero Then
            Console.WriteLine(numero & " ES UN NUMERO PERFECTO")
        Else
            Console.WriteLine(numero & " NO ES UN NUMERO PERFECTO")
        End If

        Console.Read()
    End Sub
End Module
