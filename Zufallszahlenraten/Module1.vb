Module Module1

    Sub Main()

        Dim generator As Random = New Random()

        Do
            Dim zufälligeZahl As Integer = generator.Next(1, 6)
            Dim eingabe As Integer

            Do
                Console.Write("Gib eine Zahl zwischen 1 und 5 ein: ")
                eingabe = Integer.Parse(Console.ReadLine())

                If eingabe < zufälligeZahl Then
                    Console.WriteLine("Deine Zahl ist zu klein")

                ElseIf eingabe > zufälligeZahl Then
                    Console.WriteLine("Deine Zahl ist zu groß")

                Else
                    Console.WriteLine("Herzlichen Glückwunsch. Du hast die richtige Zahl erraten.")

                End If

            Loop While eingabe <> zufälligeZahl

            Console.WriteLine("Möchtest du das Programm wiederholen? (Y/N)")
        Loop While Console.ReadKey().Key = ConsoleKey.Y

        Console.ReadKey()

    End Sub

End Module
