Module Module1

    'Delegates sind Datentypen, deren Variablen Refernzen auf Methoden aufnehmen können. Bei Aufruf der
    ''Variablen werden dann die Methoden ausgeführt. Jeder Delegatetyp kann die Methoden aufnehmen, welche
    ''seiner Signatur entsprechen

    'Defnition eines Delegate-Datentypen
    Public Delegate Function MeinDelegate(zahl1 As Integer, zahl2 As Integer) As Integer

    Sub Main()

        'Deklaration einer Delegatevariablen
        'Mittels des ADDRESSOF-Stichworts können Methoden den Delegate-Variablen zugeordnet werden 
        Dim delegateVariable As MeinDelegate = AddressOf Addiere
        Console.WriteLine(delegateVariable(12, 45))

        'Neuzuweisung der Variablen
        delegateVariable = AddressOf Subtrahiere
        Console.WriteLine(delegateVariable(12, 45))

        'Übergabe einer Methode an eine andere Methode (mittels Delegate-Übergabeparameter)
        RechneUndGibAus(delegateVariable)
        RechneUndGibAus(AddressOf Addiere)
        RechneUndGibAus(AddressOf Subtrahiere)

        'Deklaration eines Funcs (generischer Delegate) und Initialisierung mit einer Methode
        Dim myFunc As Func(Of Integer, Integer, Integer)
        myFunc = AddressOf Addiere
        'Ausführung des Funcs
        Console.WriteLine(myFunc(123, -45))

        'Bsp-Liste für folgende Anwendungen
        Dim städteliste As List(Of String) = New List(Of String)()
        städteliste.Add("Hannover")
        städteliste.Add("Köln")
        städteliste.Add("München")
        städteliste.Add("Leipzig")
        städteliste.Add("Berlin")

        'Verschiedene Ausführungen der Befüllung der Find()-Funktion einer Liste:
        ''Übergabe einer Methode (für Methode s.u.)
        Dim ergbnis As String = städteliste.Find(AddressOf SucheStadtMitH)
        Console.WriteLine(ergbnis)

        ''Übergabe einer anonymen Methode <- Methode, welche keinen Bezeichner hat und nur ein einem Delegate existiert
        ergbnis = städteliste.Find(Function(stadt As String) As Boolean
                                       Return stadt.StartsWith("H")
                                   End Function)
        Console.WriteLine(ergbnis)

        ''Übergabe der anonymen Methode in KurzSchreibweise
        ergbnis = städteliste.Find(Function(stadt) stadt.StartsWith("H"))
        Console.WriteLine(ergbnis)

        'Weiteres Bsp für das Durchsuchen einer Liste mit externer Logik (als volle Methode und als anonyme Kurzschreibweise)
        ergbnis = städteliste.Find(AddressOf SucheStadtMitSechsBuchstaben)
        Console.WriteLine(ergbnis)
        ergbnis = städteliste.Find(Function(stadt) stadt.Length = 6)
        Console.WriteLine(ergbnis)

        'Sortieren einer Liste nach dem Alphabet (Volle Methode und anonyme Kurzschreibweise) und Ausgabe per ForEach-Schleife
        städteliste = städteliste.OrderBy(AddressOf SortiereNachAlphabet).ToList()
        For Each stadt In städteliste
            Console.WriteLine(stadt)
        Next
        städteliste = städteliste.OrderBy(Function(stadt) stadt(0)).ToList()
        For Each stadt In städteliste
            Console.WriteLine(stadt)
        Next

        'Sortieren der Liste nach Wortlänge per Kurzschreibweise
        städteliste = städteliste.OrderByDescending(Function(stadt) stadt.Length).ToList()
        For Each stadt In städteliste
            Console.WriteLine(stadt)
        Next


        Console.ReadKey()

    End Sub

    'Beispielmethoden:
    ''Methode für die Sortierung nach dem Alphabet
    Public Function SortiereNachAlphabet(stadt As String) As Char
        Return stadt(0)
    End Function

    ''Methoden, welche die Suchlogik für die Find()-Funktion beinhaltet
    Public Function SucheStadtMitH(stadt As String) As Boolean
        Dim beginntMitH As Boolean = stadt.StartsWith("H")
        Return beginntMitH
    End Function

    Public Function SucheStadtMitSechsBuchstaben(stadt As String) As Boolean
        Return stadt.Length = 6
    End Function

    ''Methode, welche einen Delegate als Übegabeparameter verlangt
    Public Sub RechneUndGibAus(methode As MeinDelegate)
        Console.WriteLine(methode(-99, 56))
    End Sub

    ''Bsp-Methoden zur Befüllung der Delegates
    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Addiere")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Subtrahiere")
        Return a - b
    End Function

End Module
