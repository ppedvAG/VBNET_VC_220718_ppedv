Module Module1

    Sub Main()

        Dim a As Integer = 1
        Dim b As Integer = 23

        If a < b Then

            Console.WriteLine("A ist kleiner als B")
            Dim zahl As Integer = 123
            Console.WriteLine(zahl)

        ElseIf a > b Then

            Console.WriteLine("A ist größer als B")

        Else

            Console.WriteLine("A ist gleich B")

        End If



        While a < b

            Console.WriteLine($"{a} ist kleiner als {b}")

            a += 1

            Continue While

            Console.WriteLine("Wird nie angezeigt")

        End While

        Do

            Console.WriteLine("Soll die Schleife wiederholt werden? (Y/N)")
            If Console.ReadKey(True).Key = ConsoleKey.N Then
                Exit Do
            End If

        Loop While True

        Do
            a -= 1
            Console.WriteLine(a)
        Loop Until a < 0

        For index = 1 To 10

            Console.WriteLine($"Dies ist Durchlauf Nr. {index}")

        Next

        For index = 10 To 1 Step -2

            Console.WriteLine($"Dies ist Durchlauf Nr. {index}")

        Next

        Dim Städte As String() = {"München", "Berlin", "Köln", "Hamburg"}
        Dim zahlen(3) As Integer

        Console.WriteLine(Städte(2))
        Städte(2) = "Düsseldorf"
        Console.WriteLine(Städte(2))

        For index = 0 To Städte.Length - 1
            Console.WriteLine(Städte(index))
        Next

        For Each stadt In Städte

            Console.WriteLine(stadt)

        Next

        ReDim Preserve Städte(4)
        Städte(4) = "Flensburg"

        Console.WriteLine(Städte.Contains("Hamburg"))

        Console.WriteLine("ENDE")
        Console.ReadKey()

    End Sub

End Module
