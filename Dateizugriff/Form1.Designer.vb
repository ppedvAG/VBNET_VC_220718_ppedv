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
        Me.Tbx_Eingabe = New System.Windows.Forms.TextBox()
        Me.Btn_Speichern = New System.Windows.Forms.Button()
        Me.Btn_Laden = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tbx_Eingabe
        '
        Me.Tbx_Eingabe.AcceptsReturn = True
        Me.Tbx_Eingabe.Location = New System.Drawing.Point(12, 12)
        Me.Tbx_Eingabe.Multiline = True
        Me.Tbx_Eingabe.Name = "Tbx_Eingabe"
        Me.Tbx_Eingabe.Size = New System.Drawing.Size(330, 502)
        Me.Tbx_Eingabe.TabIndex = 0
        '
        'Btn_Speichern
        '
        Me.Btn_Speichern.Location = New System.Drawing.Point(348, 12)
        Me.Btn_Speichern.Name = "Btn_Speichern"
        Me.Btn_Speichern.Size = New System.Drawing.Size(132, 69)
        Me.Btn_Speichern.TabIndex = 1
        Me.Btn_Speichern.Text = "Speichern"
        Me.Btn_Speichern.UseVisualStyleBackColor = True
        '
        'Btn_Laden
        '
        Me.Btn_Laden.Location = New System.Drawing.Point(348, 87)
        Me.Btn_Laden.Name = "Btn_Laden"
        Me.Btn_Laden.Size = New System.Drawing.Size(132, 69)
        Me.Btn_Laden.TabIndex = 2
        Me.Btn_Laden.Text = "Laden"
        Me.Btn_Laden.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 550)
        Me.Controls.Add(Me.Btn_Laden)
        Me.Controls.Add(Me.Btn_Speichern)
        Me.Controls.Add(Me.Tbx_Eingabe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbx_Eingabe As TextBox
    Friend WithEvents Btn_Speichern As Button
    Friend WithEvents Btn_Laden As Button
End Class
