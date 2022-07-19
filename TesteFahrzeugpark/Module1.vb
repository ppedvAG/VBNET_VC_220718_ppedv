Imports Fahrzeugpark

Module Module1

    Sub Main()
#Region "Modul 05 OOP"

        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 240)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 250)

        'Console.WriteLine(fz1.Name)

        'fz1.Name = "Audi"
        'Console.WriteLine(fz1.Name)

        'Console.WriteLine(fz2.Name)

        'Console.WriteLine(fz1.BeschreibeMich())

#End Region

#Region "Lab 05 Fahrzeug-Klasse"

        ''Deklaration der Fahrzeugvariablen und Initialisierung der Fahrzeugobjekte
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 260, 28000)

        ''Ausgabe der Name-Property von fz1 (über deren Getter)
        'Console.WriteLine(fz1.Name)

        ''Ausführen von Methoden von fz1
        'fz1.StarteMotor()
        'fz1.Beschleunige(80)

        ''Ausgabe der AktGeschwindigkeit-Properties
        'Console.WriteLine(fz1.AktGeschwindigkeit)
        'Console.WriteLine(fz2.AktGeschwindigkeit)

        ''Ausführen einer Methode von fz1
        'fz1.Beschleunige(300)

        ''Ausgabe der BeschreibeMich()-Methoden
        'Console.WriteLine(fz1.BeschreibeMich())
        'Console.WriteLine(fz2.BeschreibeMich())

#End Region


        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        Dim pkw1 As PKW = New PKW("Mercedes", 230, 25000, 5)
        pkw1 = New PKW("Mercedes", 230, 25000, 5)
        pkw1 = New PKW("Mercedes", 230, 25000, 5)
        pkw1 = New PKW("Mercedes", 230, 25000, 5)
        pkw1 = New PKW("Mercedes", 230, 25000, 5)
        pkw1 = New PKW("Mercedes", 230, 25000, 5)
        pkw1 = New PKW("Mercedes", 230, 25000, 5)

        pkw1.StarteMotor()
        pkw1.Beschleunige(200)

        Console.WriteLine(pkw1.BeschreibeMich())

        Console.WriteLine(pkw1)

        pkw1.Hupen()

        Console.WriteLine(Fahrzeug.AnzahlFahrzeuge)

        Fahrzeug.ZeigeAnzahlAllerFahrzeuge()

        Console.ReadKey()
    End Sub

End Module
