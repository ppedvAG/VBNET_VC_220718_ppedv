Public Class Form1
    Private btn_Links_Start As Integer
    Private btn_Rechts_Start As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Links_Start = Btn_Links.Left
        btn_Rechts_Start = Btn_Rechts.Left
    End Sub
    Private Sub Btn_Links_Click(sender As Object, e As EventArgs) Handles Btn_Links.Click
        Btn_Links.Left += 5
    End Sub

    Private Sub Btn_Rechts_Click(sender As Object, e As EventArgs) Handles Btn_Rechts.Click
        Btn_Rechts.Left -= 5
    End Sub

    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Btn_Links_Click(sender, e)
        Btn_Rechts_Click(sender, e)

        If Btn_Links.Right >= Btn_Rechts.Left Then
            If MessageBox.Show($"Die Buttons berühren sich!{Environment.NewLine}Sollen die Buttons zurückgesetzt werden?", "Berührung", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Btn_Links.Left = btn_Links_Start
                Btn_Rechts.Left = btn_Rechts_Start
            End If
        End If
    End Sub

End Class
