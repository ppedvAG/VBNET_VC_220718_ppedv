Public Class Schiff
    'Mittels des INHERITS-Stichwort wird diese Klasse zur erbenden Klasse der Fahrzeugklasse. Damit übernimmt diese Klasse
    ''alle Eigenschaften und Methoden der Mutterklasse
    Inherits Fahrzeug
    Implements IBeladbar

    'Klasseneigener (dh nur für diese Klasse gültiger) Enumerator
    Enum Schiffstreibstoff
        Diesel
        Schweröl
        Dampf
        Wind
        Muskelkraft
    End Enum

    'Eigene Property der Kindklasse
    Private _treibstoff As Schiffstreibstoff
    Public Property Treibstoff() As Schiffstreibstoff
        Get
            Return _treibstoff
        End Get
        Set(ByVal value As Schiffstreibstoff)
            _treibstoff = value
        End Set
    End Property

    Private _ladung As Fahrzeug
    Public Property Ladung As Fahrzeug Implements IBeladbar.Ladung
        Get
            Return _ladung
        End Get
        Set(value As Fahrzeug)
            _ladung = value
        End Set
    End Property

    'Konstruktor der Kindklasse
    Public Sub New(name As String, preis As Double, maxG As Integer, treibstoff As Schiffstreibstoff)
        'Mittels des MYBASE-Stichworts wird Bezug auf die Mutterklasse genommen. Im Konstruktor muss dieser Bezug vorhanden
        ''sein: Es wird zuerst der Konstruktor der Mutterklasse aufgerufen, bevor Kindklassen-spezifische Eigenschaften
        ''gesetzt werden
        MyBase.New(name, preis, maxG)
        _treibstoff = treibstoff
    End Sub

    'Mittels des OVERRIDES-Stichwort können in der Mutterklasse als 'Overridable' und 'MustOverride' markierte Methoden
    ''überschrieben werden. Damit wird bei einem Methodenaufruf die Methode der Kindklasse und nicht jene der Mutterklasse
    ''aufgerufen
    Public Overrides Function BeschreibeMich() As String
        If IsNothing(Ladung) Then
            Return "Das Schiff " + MyBase.BeschreibeMich() + $" Es fährt mit {Treibstoff}."
        Else
            Return "Das Schiff " + MyBase.BeschreibeMich() + $" Es fährt mit {Treibstoff} und hat {Ladung.Name} geladen."
        End If
    End Function

    'Durch abstrakte Methode der Mutterklasse verlangte Methode
    Public Overrides Sub Hupen()
        Console.WriteLine("Trööööt")
    End Sub

    Public Sub Beladen(fz1 As Fahrzeug) Implements IBeladbar.Beladen
        If fz1.Equals(Me) Then
            Console.WriteLine("Das Schiff kann nicht auf sich selbst geladen werden.")
        ElseIf IsNothing(Ladung) Then
            Ladung = fz1
            Console.WriteLine("Ladevorgang erfolgreich")
        Else
            Console.WriteLine("Ladeplatz schon belegt")
        End If
    End Sub

    Public Function Entladen() As Fahrzeug Implements IBeladbar.Entladen
        Dim ladungTemp As Fahrzeug = Ladung
        If IsNothing(Ladung) Then
            Console.WriteLine("Ladung ist nicht vorhanden")
        Else
            Ladung = Nothing
            Console.WriteLine("Ladung wurde erfolgreich geöscht")
        End If
        Return ladungTemp
    End Function
End Class
