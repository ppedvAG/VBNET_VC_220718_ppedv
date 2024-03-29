﻿Module Module1

    Sub Main()

        'Variablendeklaration
        Dim eingabeInt As Integer
        Dim eingabeDbl As Double

        'Initialisierung der Variablen durch Benutzereingabe (Eingabe -> Parsen -> Speichern in Variable)
        Console.Write("Gib eine Integer-Zahl ein: ")
        Dim eingabeIntAsString As String = Console.ReadLine()
        eingabeInt = Integer.Parse(eingabeIntAsString)
        Console.Write("Gib eine Double-Zahl ein: ")
        eingabeDbl = Double.Parse(Console.ReadLine())

        'Ausgabe der Additionen
        Console.WriteLine($"{Environment.NewLine}Ergebnis als Integer: {eingabeInt} + {eingabeDbl} = {eingabeInt + CInt(eingabeDbl)}")  'Ausgabe als Integer erfordert Umwandlung des Doublewerts
        Console.WriteLine($"Ergebnis als Double: {eingabeInt + eingabeDbl}")              'Ausgabe als Double erfolgt implizit, da sich ein Doublewert in der Addition befindet

        'Berechnung und Ausgabe der Division mittels Hilfsvariablen
        Dim min = Math.Min(eingabeInt, eingabeDbl)
        Dim max = Math.Max(eingabeInt, eingabeDbl)
        Dim quotient = max / min
        Console.WriteLine($"{max} / {min} = {quotient}")

        'Brechnung und Ausgabe der Division ohne Hilfsvariablen
        Console.WriteLine($"{Math.Max(eingabeInt, eingabeDbl)} / {Math.Min(eingabeInt, eingabeDbl)} = {Math.Max(eingabeInt, eingabeDbl) / Math.Min(eingabeInt, eingabeDbl)}")

        'Programmpause
        Console.ReadKey()

    End Sub

End Module
