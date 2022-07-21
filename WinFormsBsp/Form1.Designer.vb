<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_KlickMich = New System.Windows.Forms.Button()
        Me.Cbx_Haken = New System.Windows.Forms.CheckBox()
        Me.Cbb_Auswahl = New System.Windows.Forms.ComboBox()
        Me.Lbl_Anweisung = New System.Windows.Forms.Label()
        Me.Lbx_Auswahl = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mit_Schließen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mit_Dialog = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mit_Fenster = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Tbx_Eingabe = New System.Windows.Forms.TextBox()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_KlickMich
        '
        Me.Btn_KlickMich.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_KlickMich.Location = New System.Drawing.Point(150, 108)
        Me.Btn_KlickMich.Name = "Btn_KlickMich"
        Me.Btn_KlickMich.Size = New System.Drawing.Size(340, 167)
        Me.Btn_KlickMich.TabIndex = 0
        Me.Btn_KlickMich.Text = "Klick Mich"
        Me.Btn_KlickMich.UseVisualStyleBackColor = True
        '
        'Cbx_Haken
        '
        Me.Cbx_Haken.AutoSize = True
        Me.Cbx_Haken.Location = New System.Drawing.Point(636, 148)
        Me.Cbx_Haken.Name = "Cbx_Haken"
        Me.Cbx_Haken.Size = New System.Drawing.Size(163, 29)
        Me.Cbx_Haken.TabIndex = 1
        Me.Cbx_Haken.Text = "Hak mich ab"
        Me.Cbx_Haken.UseVisualStyleBackColor = True
        '
        'Cbb_Auswahl
        '
        Me.Cbb_Auswahl.FormattingEnabled = True
        Me.Cbb_Auswahl.Items.AddRange(New Object() {"Item1", "Item2", "Item3", "Item4"})
        Me.Cbb_Auswahl.Location = New System.Drawing.Point(571, 251)
        Me.Cbb_Auswahl.Name = "Cbb_Auswahl"
        Me.Cbb_Auswahl.Size = New System.Drawing.Size(261, 33)
        Me.Cbb_Auswahl.TabIndex = 2
        '
        'Lbl_Anweisung
        '
        Me.Lbl_Anweisung.AutoSize = True
        Me.Lbl_Anweisung.Location = New System.Drawing.Point(95, 352)
        Me.Lbl_Anweisung.Name = "Lbl_Anweisung"
        Me.Lbl_Anweisung.Size = New System.Drawing.Size(253, 25)
        Me.Lbl_Anweisung.TabIndex = 3
        Me.Lbl_Anweisung.Text = "HALLO, ich bin ein String"
        '
        'Lbx_Auswahl
        '
        Me.Lbx_Auswahl.FormattingEnabled = True
        Me.Lbx_Auswahl.ItemHeight = 25
        Me.Lbx_Auswahl.Items.AddRange(New Object() {"Item1", "Item2", "Item3", "Item4"})
        Me.Lbx_Auswahl.Location = New System.Drawing.Point(571, 352)
        Me.Lbx_Auswahl.Name = "Lbx_Auswahl"
        Me.Lbx_Auswahl.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lbx_Auswahl.Size = New System.Drawing.Size(261, 229)
        Me.Lbx_Auswahl.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 40)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.Mit_Schließen})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(90, 36)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(149, 36)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mit_Dialog, Me.Mit_Fenster})
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'Mit_Schließen
        '
        Me.Mit_Schließen.Name = "Mit_Schließen"
        Me.Mit_Schließen.Size = New System.Drawing.Size(359, 44)
        Me.Mit_Schließen.Text = "Schließen"
        '
        'Mit_Dialog
        '
        Me.Mit_Dialog.Name = "Mit_Dialog"
        Me.Mit_Dialog.Size = New System.Drawing.Size(359, 44)
        Me.Mit_Dialog.Text = "Neuer Dialog"
        '
        'Mit_Fenster
        '
        Me.Mit_Fenster.Name = "Mit_Fenster"
        Me.Mit_Fenster.Size = New System.Drawing.Size(359, 44)
        Me.Mit_Fenster.Text = "Neues Fenster"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(179, 611)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(179, 647)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(179, 683)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 647)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 163)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(17, 36)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(17, 72)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Tbx_Eingabe
        '
        Me.Tbx_Eingabe.AcceptsReturn = True
        Me.Tbx_Eingabe.AcceptsTab = True
        Me.Tbx_Eingabe.Location = New System.Drawing.Point(100, 431)
        Me.Tbx_Eingabe.Multiline = True
        Me.Tbx_Eingabe.Name = "Tbx_Eingabe"
        Me.Tbx_Eingabe.Size = New System.Drawing.Size(351, 107)
        Me.Tbx_Eingabe.TabIndex = 10
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(150, 759)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(136, 50)
        Me.Btn_Ok.TabIndex = 11
        Me.Btn_Ok.Text = "OK"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AcceptButton = Me.Btn_KlickMich
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(974, 856)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.Tbx_Eingabe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Lbx_Auswahl)
        Me.Controls.Add(Me.Lbl_Anweisung)
        Me.Controls.Add(Me.Cbb_Auswahl)
        Me.Controls.Add(Me.Cbx_Haken)
        Me.Controls.Add(Me.Btn_KlickMich)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.Text = "Mein besonders schönes Fenster"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_KlickMich As Button
    Friend WithEvents Cbx_Haken As CheckBox
    Friend WithEvents Cbb_Auswahl As ComboBox
    Friend WithEvents Lbl_Anweisung As Label
    Friend WithEvents Lbx_Auswahl As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mit_Dialog As ToolStripMenuItem
    Friend WithEvents Mit_Fenster As ToolStripMenuItem
    Friend WithEvents Mit_Schließen As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Tbx_Eingabe As TextBox
    Friend WithEvents Btn_Ok As Button
End Class
