Imports System.IO
Imports Fahrzeugpark
Imports Newtonsoft.Json

Public Class Form1
    'Event-Handler der Click-Events der Buttons
    Private Sub Btn_Neu_Click(sender As Object, e As EventArgs) Handles Btn_Neu.Click
        'Hinzufügen eines Neuen Fahrzeugs zur ListBox
        Lbx_Fahrzeuge.Items.Add(ErstelleNeuesFahrzeug())
    End Sub

    Private Sub Btn_Löschen_Click(sender As Object, e As EventArgs) Handles Btn_Löschen.Click
        'Löschen eines in der LIstBox markierten Fahrzeugs (mit Prüfung, ob ein Fz markiert wurde)
        If Not IsNothing(Lbx_Fahrzeuge.SelectedItem) Then
            LöscheFahrzeug(Lbx_Fahrzeuge.SelectedItem)
        End If
    End Sub

    Private Sub Btn_Speichern_Click(sender As Object, e As EventArgs) Handles Btn_Speichern.Click
        'Speichern der ListBox-Liste
        SpeichereFz(Lbx_Fahrzeuge.Items)
    End Sub
    Private Sub Btn_Laden_Click(sender As Object, e As EventArgs) Handles Btn_Laden.Click
        'Löschen des Inhalts der ListBox
        Lbx_Fahrzeuge.Items.Clear()

        'Laden einer Fahrzeugliste und Übertrag in die ListBox
        For Each fz In LadeFz()
            Lbx_Fahrzeuge.Items.Add(fz)
        Next

    End Sub

    'Methode und Generator zur zufälligen Erstellung eines Fahrzeugs
    Private generator As Random = New Random()
    Private Function ErstelleNeuesFahrzeug() As Fahrzeug

        Select Case generator.Next(1, 4)
            Case 1
                Return PKW.ErstelleZufälligesFahzeug()
            Case 2
                Return New Schiff($"Titanic", 50, 3000000, Schiff.Schiffstreibstoff.Dampf)
            Case 3
                Return New Flugzeug($"Boing", 800, 2900000, 9900)
        End Select

        Throw New Exception()
    End Function

    'Methode zum Löschen eines übergebenen Fahrzeugs aus der ListBox
    Private Sub LöscheFahrzeug(fz As Fahrzeug)
        Lbx_Fahrzeuge.Items.Remove(fz)
    End Sub

    'Methode zum Speichern einer übergebenen Fahrzeug-Liste (vgl. auch Modul14)
    Private Sub SpeichereFz(fzListe As IList)

        Dim writer As StreamWriter

        Try
            'Initialisierung des StreamWriters mit Übergabe des Speicherorts
            writer = New StreamWriter("fahrzeugliste.txt")

            'Erstellen von Settings für den Serialisierer
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            'Einstellung, damit der Objekttyp mitgespeichert wird
            settings.TypeNameHandling = TypeNameHandling.Objects

            'Schleife über die Liste
            For Each fz In fzListe

                'Serialisierung eines Fahrzeugs in einen String
                Dim fahrzeugAlsString As String = JsonConvert.SerializeObject(fz, settings)
                'Speichern des Fahrzeug-Strings in der Datei
                writer.WriteLine(fahrzeugAlsString)

            Next


            'Ausgabe einer Erfolgsnachricht
            MessageBox.Show("Speichern erfolgreich")


        Catch ex As Exception
            'Ausgabe einer Fehlermeldung
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally

            writer?.Close()

        End Try
    End Sub

    'Methode zum Laden einer Fahrzeugliste (vgl. auch Modul14)
    Private Function LadeFz() As List(Of Fahrzeug)

        'Liste zum Zwischenspeichern der geladenen Fahrzeuge
        Dim fzList As List(Of Fahrzeug) = New List(Of Fahrzeug)()
        Dim reader As StreamReader

        Try
            'Setzen der Einstellungen
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            reader = New StreamReader("fahrzeugliste.txt")

            'Schleife über die Datei
            While Not reader.EndOfStream
                'Laden und Deserialisieren des Strings in ein Fahrzeug, sowie Hinzufügen zu der Liste
                fzList.Add(JsonConvert.DeserializeObject(Of Fahrzeug)(reader.ReadLine(), settings))

            End While


            MessageBox.Show("Laden erfolgreich")

        Catch ex As Exception

            MessageBox.Show("Laden fehlgeschlagen")

        Finally

            reader?.Close()

        End Try

        Return fzList
    End Function

    'Event, welches auf eine Neuauswahl in der ListBox reagiert
    Private Sub Lbx_Fahrzeuge_SelectedValueChanged(sender As Object, e As EventArgs) Handles Lbx_Fahrzeuge.SelectedValueChanged
        'Übertrag der BeschreibeMich()-Funktion des markierten Fahrzeugs in das Label
        Lbl_Beschreibung.Text = DirectCast(Lbx_Fahrzeuge.SelectedItem, Fahrzeug).BeschreibeMich()
    End Sub

    'Event, welches auf den Motorstart-Button reagiert
    Private Sub Btn_StarteMotor_Click(sender As Object, e As EventArgs) Handles Btn_StarteMotor.Click
        'Aufruf von Funktionen des markierten Fahrzeugs
        DirectCast(Lbx_Fahrzeuge.SelectedItem, Fahrzeug).StarteMotor()
        DirectCast(Lbx_Fahrzeuge.SelectedItem, Fahrzeug).Beschleunige(100)
        'Aufruf des obigen Events (damit das Label aktualisiert wird)
        Lbx_Fahrzeuge_SelectedValueChanged(sender, e)
    End Sub
End Class
