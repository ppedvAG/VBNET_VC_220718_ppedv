Module Module1

    Sub Main()

        Dim meinString As String

        meinString = "Hallo Welt"

        Console.WriteLine(meinString)

        Console.WriteLine("Auch hallo")

        meinString = "Ciao"

        Console.WriteLine(meinString)

        Dim Alter As Integer = 31

        Dim Stadt As String = "Berlin"

        Dim DoppeltesAlter As Integer = Alter * 2

        Console.WriteLine(DoppeltesAlter)
        Console.WriteLine(Alter * 2)

        Dim kombinierterString As String = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + "."
        Stadt = "München"
        Console.WriteLine(kombinierterString)
        Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".")

        Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt)

        kombinierterString = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}."
        Console.WriteLine(kombinierterString)
        Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.")

        Console.WriteLine($"Dies ist ein Zeilenumbruch {Environment.NewLine} und dies ein {vbTab} horizontaler Tab.")

        Const Pi As Double = 3.15
        Console.WriteLine(Pi)

        Console.Write("Bitte gib eine Zahl ein: ")
        Dim benutzerEingabe As String = Console.ReadLine()
        Console.WriteLine($"Dein Eingabe ist: {benutzerEingabe}")

        Dim ungewandelteZahl As Integer = Integer.Parse(benutzerEingabe)
        Console.WriteLine(ungewandelteZahl * 2)

        Dim gedrückteTaste As ConsoleKeyInfo = Console.ReadKey(True)
        Console.WriteLine($"Du hast folgende Taste gedrückt: {gedrückteTaste.Key}")


        Dim gleitkommazahl As Double = 45.62444564243
        Dim ganzzahl As Integer = gleitkommazahl
        Console.WriteLine(ganzzahl)
        Console.WriteLine(CInt(gleitkommazahl))

        Dim a As Integer = 15
        Dim b As Integer = 0
        Dim erg As Double = a / b
        Console.WriteLine(erg)

        Console.ReadKey()

    End Sub

End Module
