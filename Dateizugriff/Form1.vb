Imports System.IO

Public Class Form1
    'Events-Handler der Click-Events der Buttons
    Private Sub Btn_Speichern_Click(sender As Object, e As EventArgs) Handles Btn_Speichern.Click

        'Aufruf der Speichern-Funktion mit Übergabe des TextBox-Inhalts
        SpeichereText(Tbx_Eingabe.Text)

    End Sub

    Private Sub Btn_Laden_Click(sender As Object, e As EventArgs) Handles Btn_Laden.Click
        'Einfügen des geladenenen Texts in die TextBox
        Tbx_Eingabe.Text = LadeText(Tbx_Eingabe.Text)
    End Sub

    'Methode zum Laden eines Strings aus der Datei (vgl. SpeichereText())
    Private Function LadeText(text As String) As String

        Dim geladenerText As String = text

        Dim openDialog As OpenFileDialog = New OpenFileDialog()

        openDialog.FileName = "TestText.txt"
        openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

        If openDialog.ShowDialog() = DialogResult.OK Then

            Dim reader As StreamReader

            Try

                geladenerText = ""

                reader = New StreamReader(openDialog.FileName)

                ''Lesen des gesamten Texts der Datei
                geladenerText = reader.ReadToEnd()

                ''Alterativ: Lesen jeder einzelnen Zeile in der Datei
                'While Not reader.EndOfStream
                '    geladenerText = geladenerText + reader.ReadLine() + Environment.NewLine
                'End While

                MessageBox.Show("Laden erfolgreich")

            Catch ex As Exception

                MessageBox.Show("Laden fehlgeschlagen")

            Finally

                reader?.Close()

            End Try

        End If

        'Rückgabe des geladenen Texts
        Return geladenerText

    End Function

    'Methode zum Speichern eines Strings
    Private Sub SpeichereText(text As String)
        'Deklarierung der StreamWriter-Vatiablen vor dem Try-Block
        Dim writer As StreamWriter

        Try
            'Initialisierung des SaveFileDialogs
            Dim saveDialog As SaveFileDialog = New SaveFileDialog()

            'Einstellungen des SaveDialogs
            ''Standart-Dateiname
            saveDialog.FileName = "testText.txt"
            ''Standart-Dateipfad
            saveDialog.InitialDirectory = "C:\"
            ''Verwendung eines Standart-Ordners (hier MyDocuments)
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            ''Dateityp-Filterliste
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            'Öffnen des Dialogs und Abfrage der Antwort
            If saveDialog.ShowDialog() = DialogResult.OK Then
                'Initialisierung des StreamWriters mit Übergabe des Speicherorts
                writer = New StreamWriter(saveDialog.FileName)
                'Schreiben des Texts in die Datei
                writer.WriteLine(text)
                'Schreiben einer zusätzlichen Zeile in die Datei
                writer.Write("ENDE DER DATEI")
                'Ausgabe einer Erfolgsnachricht
                MessageBox.Show("Speichern erfolgreich")

            End If

        Catch ex As Exception
            'Ausgabe einer Fehlermeldung
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally

            'Prüfung, ob der StreamWriter initialisiert wurde
            If Not IsNothing(writer) Then
                'Schließen des Streams zur Freigabe der Datei für andere Applikationen
                writer.Close()
            End If

            ''Alternative Null-Prüfung
            'writer?.Close()

        End Try

    End Sub

End Class
