Public Class Fahrzeug

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            If value.Length > 0 Then
                _name = value
            End If
        End Set
    End Property


    Private _maxGeschwindigkeit As Integer
    Public Property MaxGeschwindigkeit() As Integer
        Get
            Return _maxGeschwindigkeit
        End Get
        Private Set(ByVal value As Integer)
            _maxGeschwindigkeit = value
        End Set
    End Property

    Function BeschreibeMich() As String
        Return $"{Name} kann maximal {MaxGeschwindigkeit} km/h fahren."
    End Function

    Sub New(name As String, maxG As Integer)
        _name = name
        _maxGeschwindigkeit = maxG
    End Sub

End Class
