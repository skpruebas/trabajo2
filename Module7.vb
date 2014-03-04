Module Module7
    Sub Main()
        Dim numero, suma As Integer
        Dim unidad, decena, centena As Integer

        numero = 100
        
        Console.WriteLine("SUMA DE NUMEROS IMPARES DIFERENTES DE TRES CIFRAS")

        While (numero < 1000)

            unidad = numero Mod 10
            decena = (numero \ 10) Mod 10
            centena = numero \ 100

            If (centena Mod 2 <> 0 And decena Mod 2 <> 0 And unidad Mod 2 <> 0 And centena <> decena And decena <> unidad And unidad <> centena) Then

                Console.WriteLine("NUMERO: " & numero)
                suma = suma + numero

            End If

            numero = numero + 1

        End While

        Console.WriteLine("SUMA: " & suma)
        Console.WriteLine(" c " & centena & " d " & decena & " u " & unidad)

        Console.Read()
    End Sub
End Module
