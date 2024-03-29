﻿Module Module1

    'Methoden sind Programmteile, von denen jeder eine sehr spezielle und kleinteilige Aufgabe ausführt.
    ''Es wird unterschieden zwischen Prozeduren, welche keinen Rückgabewert besitzen und mit dem Stichwort
    ''SUB gekennzeichnet sind...
    Sub AddiereUndGibAus(a As Integer, b As Integer)
        Dim summe = a + b
        Console.WriteLine(summe)
    End Sub

    '...und Funktionen, die einen Rückgabewert besitzen und mit dem Stichwort FUNCTION markiert werden.
    ''Jede Methode besteht aus einem Kopf (einer Signatur) in welchem der Zugriff und die Methodenart
    ''definiert werden, ein Bezeichner für die Methode bestimmt wird und Übergabeparameter (und Rückgabe-
    ''wert bei Funktionen) definiert werden... 
    Function Addiere(a As Integer, b As Integer) As Integer

        '...und einem Körper, in welchem die Programmlogik hinterlegt wird.
        ''Mittels des RETURN-Befehls wird in Funktionen der Rückgabewert an den Aufrufer gesand und die
        ''Ausführung der Methode unterbrochen
        Dim summe = a + b
        Return summe

    End Function

    'Methoden, welche den gleichen Bezeichner haben aber unterschiedliche Übergabeparameter heißen 'ÜBERLADENE
    ''Methoden'. Eine Eindeutigkeit wird durch die verschiedenen Übergabeparameter erzielt. 
    Function Addiere(a As Double, b As Double) As Double

        Return a + b

    End Function

    'Mit dem OPTIONAL-Stichwort kann man Default-Werte für die Übergabeparameter definieren. Diese werden
    ''bei Nicht-Angabe der Parameter während des Methodenaufrufs eingesetzt.
    Function Addiere(a As Integer, b As Integer, c As Integer, Optional d As Integer = 0) As Integer
        Dim summe = a + b + c + d
        Return summe

    End Function

    'Mittels des PARAMARRAY-Stichwort können beliebig viele Parameter eines Datentyps übergeben werden, welche 
    ''Methodenintern als Array interpretiert werden
    Public Function BildeSumme(ParamArray summanden() As Integer) As Integer
        Dim summe As Integer = 0
        For Each summand In summanden
            summe += summand
        Next
        Return summe
    End Function

    Sub Main()

        'Bsp-Variablen
        Dim zahl1, zahl2 As Integer
        zahl1 = 123
        zahl2 = 234

        'SUB-Aufruf mit Übergabe der Variablen
        AddiereUndGibAus(zahl1, zahl2)

        'FUNCTION-Aufruf mit Variablen-Übergabe und Speichern des Rückgabewerts in einer weiteren Variablen
        Dim ergebnis As Integer
        ergebnis = Addiere(zahl1, zahl2)

        'Verwendung des Rückgabewerts
        ergebnis = ergebnis * 2
        Console.WriteLine($"Das Ergebnis ist {ergebnis}.")

        'Bsp eines Aufrufs der überladenen Funktion
        Dim dblZahl1, dblZahl2 As Double
        dblZahl1 = 123.34
        dblZahl2 = 234.56
        Dim dblErgebnis As Double = Addiere(dblZahl1, dblZahl2)

        'Bsp eines Aufrufs der Funktion mit optionalem Parameter
        Addiere(zahl1, zahl2, 56)

        'Bsp eines Aufrufs der ParamArray-Funktion
        ergebnis = BildeSumme(1, 34, zahl1, 123, zahl2, -345, 0, -999, 1024)
        Console.WriteLine(ergebnis)

        Console.ReadKey()
    End Sub

End Module
