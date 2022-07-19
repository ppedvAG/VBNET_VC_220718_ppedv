Imports Fahrzeugpark
Module Module1

    Sub Main()

        Dim a, b As Integer

        a = 50
        b = a

        Console.WriteLine($"a:{a}")
        Console.WriteLine($"b:{b}")

        a = 100

        Console.WriteLine($"a:{a}")
        Console.WriteLine($"b:{b}")

        Dim fz1, fz2 As Fahrzeug

        fz1 = New Fahrzeug("BMW", 270, 25000)
        fz2 = fz1

        Console.WriteLine($"fz1: {fz1.Name}")
        Console.WriteLine($"fz2: {fz2.Name}")

        fz1.Name = "Mercedes"

        Console.WriteLine($"fz1: {fz1.Name}")
        Console.WriteLine($"fz2: {fz2.Name}")

        Dim cPerson As C_Person = New C_Person("Anna", 35)
        Dim sPerson As S_Person = New S_Person("Hugo", 35)

        Console.WriteLine($"{cPerson.Name}: {cPerson.Alter}")
        Console.WriteLine($"{sPerson.Name}: {sPerson.Alter}")

        Altern(cPerson)
        Altern(sPerson)

        Console.WriteLine($"{cPerson.Name}: {cPerson.Alter}")
        Console.WriteLine($"{sPerson.Name}: {sPerson.Alter}")

        WirklichAltern(sPerson)
        Console.WriteLine($"{sPerson.Name}: {sPerson.Alter}")

        Dim eingabe As String = "asfgsdh"
        Dim eingabeAlsInteger As Integer

        If Integer.TryParse(eingabe, eingabeAlsInteger) Then

            Console.WriteLine(eingabeAlsInteger * 2)

        End If

        Console.ReadKey()
    End Sub

    Sub Altern(person As C_Person)
        person.Alter += 1
    End Sub

    Sub Altern(person As S_Person)
        person.Alter += 1
    End Sub

    Sub WirklichAltern(ByRef person As S_Person)
        person.Alter += 1
    End Sub

End Module

Public Class C_Person

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _alter As Integer
    Public Property Alter() As Integer
        Get
            Return _alter
        End Get
        Set(ByVal value As Integer)
            _alter = value
        End Set
    End Property

    Public Sub New(name As String, alter As Integer)
        _name = name
        _alter = alter
    End Sub

End Class

Public Structure S_Person

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _alter As Integer
    Public Property Alter() As Integer
        Get
            Return _alter
        End Get
        Set(ByVal value As Integer)
            _alter = value
        End Set
    End Property

    Public Sub New(name As String, alter As Integer)
        _name = name
        _alter = alter
    End Sub

End Structure
