<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BJCA_JP2S_ExtensionsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ok
        '
        Me.Ok.Location = New System.Drawing.Point(308, 231)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(75, 23)
        Me.Ok.TabIndex = 0
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'BJCA_JP2S_ExtensionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ok)
        Me.Name = "BJCA_JP2S_ExtensionsForm"
        Me.Text = "JP2S_Extensions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ok As Button
End Class
