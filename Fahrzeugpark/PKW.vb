Public Class PKW
    Inherits Fahrzeug

    Private _anzahlTueren As Integer
    Public Property AnzahlTueren() As Integer
        Get
            Return _anzahlTueren
        End Get
        Set(ByVal value As Integer)
            _anzahlTueren = value
        End Set
    End Property

    Public Sub New(name As String, maxG As Integer, preis As Double, anzT As Integer)
        MyBase.New(name, maxG, preis)

        _anzahlTueren = anzT
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Der PKW " + MyBase.BeschreibeMich() + $" Er hat {AnzahlTueren} Türen."
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Hup Hup")
    End Sub

End Class
