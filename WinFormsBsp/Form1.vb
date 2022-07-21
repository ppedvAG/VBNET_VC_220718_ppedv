Public Class MainWindow
    'Events, welche von GUI-Elementen unter bestimmten Umständen geworfen werden, sind spezielle Delegates.
    ''Methoden, welche durch diese Events ausgeführt werden sollen, können mittels des HANDLES-Stichworts an
    ''Events gebunden werden

    'Event, welches durch den Klick auf den KlickMich-Button ausgelöst wird (definiert durch HANDLES-Stichwort)
    Private Sub Btn_KlickMich_Click(sender As Object, e As EventArgs) Handles Btn_KlickMich.Click

        'Die einzelnen GUI-Elemenete sind auch OOP-Objekte. Sie besitzen diverse Properties, welche manipuliert werden können.
        ''Manipulation der Button-Beschriftung des Buttons Btn_KlickMich
        Btn_KlickMich.Text = "Button wurde geklickt"

        ''Manipulation der Width-Eigenschaft des Buttons über den Sender-Parameter des Events
        DirectCast(sender, Button).Width = 200

        ''Prüfung, ob die CheckBox abgehakt ist
        If Cbx_Haken.Checked Then
            ''Manipulation der Hintergrundfarbe des Fensters (Me)
            Me.BackColor = Color.LightGreen
        End If

        ''Prüfung, ob in der ComboBox etwas ausgewählt ist
        If Not IsNothing(Cbb_Auswahl.SelectedItem) Then
            ''Übertrag der ComboBox-Auswahl in den Titel des Fensters
            Me.Text = Cbb_Auswahl.SelectedItem.ToString()
        End If

        ''Prüfung, ob in der ListBox etwas ausgewählt ist
        If Not IsNothing(Lbx_Auswahl.SelectedItem) Then
            ''Übertrag der ListBox-Auswahl in das Label
            Lbl_Anweisung.Text = Lbx_Auswahl.SelectedItem.ToString()
        End If

        ''Übertrag des TextBox-Inhalts in die Beschriftung der CheckBox
        Cbx_Haken.Text = Tbx_Eingabe.Text

    End Sub

    'Event, welches beim Laden des Fensters ausgelöst wird
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Hinzufügen eines Items zu ComboBox bzw ListBox
        Cbb_Auswahl.Items.Add("Eintrag5")
        Lbx_Auswahl.Items.Add("Eintrag5")

    End Sub

    'Event, welches durch den Klick auf Schließen-MenüEintrag ausgelöst wird
    Private Sub Mit_Schließen_Click(sender As Object, e As EventArgs) Handles Mit_Schließen.Click

        'Mittels Message-Boxen können simple Benutzerabfragen gestartet Werden. Diese geben ein DialogResult-Objekt zurück, das die Antwort des
        ''Benutzers beinhaltet und das in einer If-Abfrage überprüft werden kann.
        If MessageBox.Show("Möchstest du das Fenster wirklich schließen?", "Fenster schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ''Schließen des Fensters
            Me.Close()

        End If

        ''Schließen der Applikation
        'Application.Exit()
    End Sub

    'Event, welches durch den Klick auf Fenster-MenüEintrag ausgelöst wird
    Private Sub Mit_Fenster_Click(sender As Object, e As EventArgs) Handles Mit_Fenster.Click

        'Instanziieren eines neuen Fensters
        Dim neuesFenster As MainWindow = New MainWindow()

        'Manipulation von Eigenschaften des neuen Fensters
        neuesFenster.Text = "Dies ist ein zweites Fenster"
        neuesFenster.Lbl_Anweisung.Text = "Hallo Welt"

        'Zeigen des Fensters als gleichberechtigtes Fenster
        neuesFenster.Show()

    End Sub

    'Event, welches durch den Klick auf Dialog-MenüEintrag ausgelöst wird
    Private Sub Mit_Dialog_Click(sender As Object, e As EventArgs) Handles Mit_Dialog.Click

        Dim neuesFenster As MainWindow = New MainWindow()
        neuesFenster.Text = "Dies ist ein Dialog-Fenster"
        neuesFenster.Lbl_Anweisung.Text = "Hallo Dialog"

        'Zeigen des Fensters als Dialogfenster und Abfrage des DialogResults (s.u.)
        If neuesFenster.ShowDialog() = DialogResult.OK Then
            Lbl_Anweisung.Text = "Du hast auf OK geklickt"
        End If

    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click

        'Setzen des DialogResults eines Fensters (wird bei Aufruf durch ShowDialog() zurückgegeben)
        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub
End Class
