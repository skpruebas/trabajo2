Module Module8
    Sub Main()
        Dim alumnos, edades, cont, mayor, menor As Integer
        Dim prom, suma, temp As Double

        mayor = 0
        menor = 0


        cont = 1

        Console.Write("INGRESE CANTIDAD DE ALUMNOS: ")
        alumnos = Console.ReadLine()
        While (cont <= alumnos)
            Console.WriteLine("INGRESE LAS EDADES: ")
            edades = Console.ReadLine()

            temp = edades
            
            If (mayor < edades) Then
                mayor = edades
            End If
            If (edades < mayor) Then
                menor = edades
            End If
            suma = suma + edades

            cont = cont + 1
        End While
        prom = suma / alumnos
        Console.WriteLine("SUMA: " & suma)
        Console.WriteLine("PROMEDIO: " & prom)
        Console.WriteLine("MAYOR: " & mayor)
        Console.WriteLine("MENOR: " & menor)
        Console.Read()
    End Sub
End Module
