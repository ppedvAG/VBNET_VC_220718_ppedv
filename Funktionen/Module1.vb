Module Module1

    Sub Main()

        Dim zahl1, zahl2 As Integer
        zahl1 = 123
        zahl2 = 234

        AddiereUndGibAus(zahl1, zahl2)

        Dim ergebnis As Integer
        ergebnis = Addiere(zahl1, zahl2)

        ergebnis = ergebnis * 2
        Console.WriteLine($"Das Ergebnis ist {ergebnis}.")

        Dim dblZahl1, dblZahl2 As Double
        dblZahl1 = 123.34
        dblZahl2 = 234.56
        Dim dblErgebnis As Double = Addiere(dblZahl1, dblZahl2)

        Addiere(zahl1, zahl2, 56, 34)

        ergebnis = BildeSumme(1, 34, zahl1, 123, zahl2, -345, 0, -999, 1024)
        Console.WriteLine(ergebnis)

        Console.ReadKey()
    End Sub

    Sub AddiereUndGibAus(a As Integer, b As Integer)
        Dim summe As Integer = a + b
        Console.WriteLine(summe)
    End Sub

    Function Addiere(a As Integer, b As Integer) As Integer
        Dim summe As Integer = a + b
        Return summe
    End Function

    Function Addiere(a As Double, b As Double) As Double
        Return a + b
    End Function

    Function Addiere(a As Integer, b As Integer, c As Integer, Optional d As Integer = 0) As Integer
        Return a + b + c + d
    End Function

    Function BildeSumme(ParamArray summanden() As Integer) As Integer
        Dim summe As Integer = 0
        For Each summand In summanden
            summe += summand
        Next
        Return summe
    End Function

End Module
