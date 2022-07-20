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

#Region "Modul 07 Vererbung"
        'Dim pkw1 As PKW = New PKW("BMW", 260, 28000, 5)

        'Console.WriteLine(pkw1.BeschreibeMich())

        'Console.WriteLine(pkw1)

        ''Dim fz1 As Fahrzeug = New Fahrzeug()

        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()

        'pkw1.Hupen()
#End Region

#Region "Lab 07 Schiffs-, PKW-, Flugzeug-Klassen"
        ''Deklaration und Initialisierung der spezifischen Fahrzeuge sowie Aufruf der BeschreibeMich()-Methoden
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Console.WriteLine(pkw1.BeschreibeMich())

        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        'Console.WriteLine(flugzeug1.BeschreibeMich())

        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)
        'Console.WriteLine(schiff1.BeschreibeMich())

        ''Aufruf der abstarkten Methoden Hupen()
        'pkw1.Hupen()
        'schiff1.Hupen()
        'flugzeug1.Hupen()

        ''Ausgabe des Shared Members der Fahrzeug-Klasse
        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()
#End Region

        'Dim pkw1 As PKW = New PKW("BMW", 230, 25000, 5)
        'Dim fz1 As Fahrzeug = pkw1
        'Dim bewegbaresObjekt As IBewegbar = pkw1

        'Console.WriteLine(pkw1.AnzahlTueren)

        'Console.WriteLine(fz1.Preis)

        'bewegbaresObjekt.Crash()

        'Dim bewegbarArray(1) As IBewegbar

        'bewegbarArray(0) = pkw1
        'bewegbarArray(1) = New Flugzeug("Boing", 8000, 500000000, 9999)

        'bewegbarArray(1).Crash()

        'MontiereNeuesRad(pkw1)

        'MontiereNeuesRad(bewegbarArray(1))


        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        BeladeFahrzeuge(pkw1, flugzeug1)
        Console.WriteLine()

        BeladeFahrzeuge(pkw1, schiff1)
        Console.WriteLine()

        BeladeFahrzeuge(schiff1, flugzeug1)
        Console.WriteLine()

        Console.WriteLine(schiff1.Ladung.Name)
        Console.WriteLine(schiff1.BeschreibeMich())

        Console.ReadKey()
    End Sub

    Public Sub BeladeFahrzeuge(fz1 As Fahrzeug, fz2 As Fahrzeug)

        If TypeOf fz1 Is IBeladbar Then
            Dim beladbaresObjekt As IBeladbar = DirectCast(fz1, IBeladbar)
            beladbaresObjekt.Beladen(fz2)
        ElseIf TypeOf fz2 Is IBeladbar Then
            DirectCast(fz2, IBeladbar).Beladen(fz1)
        Else
            Console.WriteLine("Kein Fahrzeug hat einen Laderaum")
        End If

    End Sub

    Sub MontiereNeuesRad(bewegbaresO As IBewegbar)

        bewegbaresO.AnzahlRäder += 1

        If TypeOf bewegbaresO Is PKW Then

            Dim pkw1 As PKW = DirectCast(bewegbaresO, PKW)
            pkw1.AnzahlTueren += 1

        End If

    End Sub

End Module
