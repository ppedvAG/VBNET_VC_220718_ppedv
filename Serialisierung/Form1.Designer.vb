<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbx_Fahrzeuge = New System.Windows.Forms.ListBox()
        Me.Btn_Neu = New System.Windows.Forms.Button()
        Me.Btn_Löschen = New System.Windows.Forms.Button()
        Me.Btn_Speichern = New System.Windows.Forms.Button()
        Me.Btn_Laden = New System.Windows.Forms.Button()
        Me.Lbl_Beschreibung = New System.Windows.Forms.Label()
        Me.Btn_StarteMotor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbx_Fahrzeuge
        '
        Me.Lbx_Fahrzeuge.FormattingEnabled = True
        Me.Lbx_Fahrzeuge.ItemHeight = 25
        Me.Lbx_Fahrzeuge.Location = New System.Drawing.Point(12, 12)
        Me.Lbx_Fahrzeuge.Name = "Lbx_Fahrzeuge"
        Me.Lbx_Fahrzeuge.Size = New System.Drawing.Size(426, 404)
        Me.Lbx_Fahrzeuge.TabIndex = 0
        '
        'Btn_Neu
        '
        Me.Btn_Neu.Location = New System.Drawing.Point(460, 12)
        Me.Btn_Neu.Name = "Btn_Neu"
        Me.Btn_Neu.Size = New System.Drawing.Size(185, 60)
        Me.Btn_Neu.TabIndex = 1
        Me.Btn_Neu.Text = "Neues FZ"
        Me.Btn_Neu.UseVisualStyleBackColor = True
        '
        'Btn_Löschen
        '
        Me.Btn_Löschen.Location = New System.Drawing.Point(460, 78)
        Me.Btn_Löschen.Name = "Btn_Löschen"
        Me.Btn_Löschen.Size = New System.Drawing.Size(185, 60)
        Me.Btn_Löschen.TabIndex = 2
        Me.Btn_Löschen.Text = "Lösche FZ"
        Me.Btn_Löschen.UseVisualStyleBackColor = True
        '
        'Btn_Speichern
        '
        Me.Btn_Speichern.Location = New System.Drawing.Point(460, 144)
        Me.Btn_Speichern.Name = "Btn_Speichern"
        Me.Btn_Speichern.Size = New System.Drawing.Size(185, 60)
        Me.Btn_Speichern.TabIndex = 3
        Me.Btn_Speichern.Text = "Speichere FZ"
        Me.Btn_Speichern.UseVisualStyleBackColor = True
        '
        'Btn_Laden
        '
        Me.Btn_Laden.Location = New System.Drawing.Point(460, 210)
        Me.Btn_Laden.Name = "Btn_Laden"
        Me.Btn_Laden.Size = New System.Drawing.Size(185, 60)
        Me.Btn_Laden.TabIndex = 4
        Me.Btn_Laden.Text = "Lade FZ"
        Me.Btn_Laden.UseVisualStyleBackColor = True
        '
        'Lbl_Beschreibung
        '
        Me.Lbl_Beschreibung.AutoSize = True
        Me.Lbl_Beschreibung.Location = New System.Drawing.Point(48, 534)
        Me.Lbl_Beschreibung.Name = "Lbl_Beschreibung"
        Me.Lbl_Beschreibung.Size = New System.Drawing.Size(0, 25)
        Me.Lbl_Beschreibung.TabIndex = 5
        '
        'Btn_StarteMotor
        '
        Me.Btn_StarteMotor.Location = New System.Drawing.Point(460, 312)
        Me.Btn_StarteMotor.Name = "Btn_StarteMotor"
        Me.Btn_StarteMotor.Size = New System.Drawing.Size(185, 60)
        Me.Btn_StarteMotor.TabIndex = 6
        Me.Btn_StarteMotor.Text = "Moterstart"
        Me.Btn_StarteMotor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 633)
        Me.Controls.Add(Me.Btn_StarteMotor)
        Me.Controls.Add(Me.Lbl_Beschreibung)
        Me.Controls.Add(Me.Btn_Laden)
        Me.Controls.Add(Me.Btn_Speichern)
        Me.Controls.Add(Me.Btn_Löschen)
        Me.Controls.Add(Me.Btn_Neu)
        Me.Controls.Add(Me.Lbx_Fahrzeuge)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbx_Fahrzeuge As ListBox
    Friend WithEvents Btn_Neu As Button
    Friend WithEvents Btn_Löschen As Button
    Friend WithEvents Btn_Speichern As Button
    Friend WithEvents Btn_Laden As Button
    Friend WithEvents Lbl_Beschreibung As Label
    Friend WithEvents Btn_StarteMotor As Button
End Class
