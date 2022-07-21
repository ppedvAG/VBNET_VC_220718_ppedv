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
        Me.Btn_Links = New System.Windows.Forms.Button()
        Me.Btn_Rechts = New System.Windows.Forms.Button()
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Links
        '
        Me.Btn_Links.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Links.Name = "Btn_Links"
        Me.Btn_Links.Size = New System.Drawing.Size(153, 104)
        Me.Btn_Links.TabIndex = 0
        Me.Btn_Links.Text = "LINKS"
        Me.Btn_Links.UseVisualStyleBackColor = True
        '
        'Btn_Rechts
        '
        Me.Btn_Rechts.Location = New System.Drawing.Point(1333, 12)
        Me.Btn_Rechts.Name = "Btn_Rechts"
        Me.Btn_Rechts.Size = New System.Drawing.Size(153, 104)
        Me.Btn_Rechts.TabIndex = 1
        Me.Btn_Rechts.Text = "RECHTS"
        Me.Btn_Rechts.UseVisualStyleBackColor = True
        '
        'Btn_Start
        '
        Me.Btn_Start.Location = New System.Drawing.Point(12, 122)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(1474, 56)
        Me.Btn_Start.TabIndex = 2
        Me.Btn_Start.Text = "START"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 243)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Btn_Rechts)
        Me.Controls.Add(Me.Btn_Links)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Links As Button
    Friend WithEvents Btn_Rechts As Button
    Friend WithEvents Btn_Start As Button
End Class
