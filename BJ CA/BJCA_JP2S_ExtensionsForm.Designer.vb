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
        Me.Read = New System.Windows.Forms.Button()
        Me.Abort = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ok
        '
        Me.Ok.Location = New System.Drawing.Point(636, 51)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(137, 23)
        Me.Ok.TabIndex = 0
        Me.Ok.Text = "Ignore Extensions"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'Read
        '
        Me.Read.Location = New System.Drawing.Point(636, 98)
        Me.Read.Name = "Read"
        Me.Read.Size = New System.Drawing.Size(137, 23)
        Me.Read.TabIndex = 0
        Me.Read.Text = "Process History File"
        Me.Read.UseVisualStyleBackColor = True
        '
        'Abort
        '
        Me.Abort.Location = New System.Drawing.Point(636, 145)
        Me.Abort.Name = "Abort"
        Me.Abort.Size = New System.Drawing.Size(137, 23)
        Me.Abort.TabIndex = 0
        Me.Abort.Text = "Abort File Processing"
        Me.Abort.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(636, 398)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(137, 23)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'BJCA_JP2S_ExtensionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Abort)
        Me.Controls.Add(Me.Read)
        Me.Controls.Add(Me.Ok)
        Me.Name = "BJCA_JP2S_ExtensionsForm"
        Me.Text = "JP2S_Extensions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ok As Button
    Friend WithEvents Read As Button
    Friend WithEvents Abort As Button
    Friend WithEvents Close_Button As Button
End Class
