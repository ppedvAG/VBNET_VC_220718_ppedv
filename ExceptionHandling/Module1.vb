'Mittels Exception-Handling führt man eine Bearbeitung von Laufzeitfehlern im Programm durch.
Module Module1

    'Eigene Exceptions müssen von der Exception-Klasse erben und können dann manuell mittels des throw-Stichworts
    ''geworfen werden
    Public Class MeineException
        Inherits Exception

        Public Sub New()
            MyBase.New("Dies ist mein Fehler")
        End Sub

    End Class

    Sub Main()
        Dim wiederholen As Boolean = False

        Do
            'In einen TRY-Block werden die Programmteile geschrieben, welche möglicherweise zur Laufzeit einen Fehler
            ''produzieren (z.B. die Integer.Parse()-Funktion). Kommt es zu einem Fehler wird eine EXCEPTION geworfen,
            ''die Ausführung des Try-Blocks wird abgebrochen und die Exception muss von einem passenden CATCH-Block 
            ''abgefangen werden.
            Try

                'Dim eingabe As String
                'eingabe = Console.ReadLine()

                'Dim eingabeAsInteger As Integer
                'eingabeAsInteger = Integer.Parse(eingabe)

                ''Methode, welche eine Exception provozieren kann (s.u.)
                Dim eingabe As Integer = BenutzerEingabe()

                Console.WriteLine(eingabe * 2)
                wiederholen = False

                'Mittels des THROW-Stichworts können Exceptions manuell geworfen werden
                Throw New MeineException()

            Catch ex As FormatException
                'Jedem Try-Block muss mindestens ein Catch-Block folgen, in welchem die geworfenen Fehler abgefangen 
                ''werden. Im Catch-Block kann definiert werden, welche Exceptions abgefangen werden (Signatur) und 
                ''wie sie bearbeitet werden (Körper). Nach der Bearbeitung Nicht abgefangene Exceptions werden an 
                ''den Benutzer durchgereicht und führen zum Programmabbruch.

                Console.WriteLine("Du musst eine Zahl eingeben! " + ex.Message)
                wiederholen = True

            Catch ex As OverflowException

                Console.WriteLine("Deine Zahl ist zu groß/klein. " + ex.Message)
                wiederholen = True

            Catch ex As Exception

                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex.Message)

                'Ein Throw-Befehl in einem Catch-Block schmeißt die Exception eine Ebene höher
                Throw

            Finally
                'Der optionale FINALLY-Block wird, egal ob es zu einem Fehler kam oder nicht, immer ausgeführt

                Console.WriteLine("WIRD IMMER AUSGEFÜHRT")

            End Try
        Loop While wiederholen

        Console.WriteLine("ENDE DES TRY-BLOCKS")

        Console.ReadKey()

    End Sub

    Function BenutzerEingabe() As Integer
        Dim eingabe As String
        eingabe = Console.ReadLine()

        Dim eingabeAsInteger As Integer

        'Möglicher Exceptionwurf
        eingabeAsInteger = Integer.Parse(eingabe)

        Return eingabeAsInteger
    End Function

End Module
