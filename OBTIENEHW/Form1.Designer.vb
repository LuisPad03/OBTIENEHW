<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lInfoSistemaOperativo = New System.Windows.Forms.TextBox()
        Me.lInfoVersionSistemaOperativo = New System.Windows.Forms.TextBox()
        Me.lInfoNumeroCoresCPU = New System.Windows.Forms.TextBox()
        Me.lInfoArquitecturaCPU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lInfoNumeroCoresCPUF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lInfoSistemaOperativo
        '
        Me.lInfoSistemaOperativo.Enabled = False
        Me.lInfoSistemaOperativo.Location = New System.Drawing.Point(106, 15)
        Me.lInfoSistemaOperativo.Name = "lInfoSistemaOperativo"
        Me.lInfoSistemaOperativo.Size = New System.Drawing.Size(202, 20)
        Me.lInfoSistemaOperativo.TabIndex = 0
        '
        'lInfoVersionSistemaOperativo
        '
        Me.lInfoVersionSistemaOperativo.Enabled = False
        Me.lInfoVersionSistemaOperativo.Location = New System.Drawing.Point(106, 41)
        Me.lInfoVersionSistemaOperativo.Name = "lInfoVersionSistemaOperativo"
        Me.lInfoVersionSistemaOperativo.Size = New System.Drawing.Size(202, 20)
        Me.lInfoVersionSistemaOperativo.TabIndex = 0
        '
        'lInfoNumeroCoresCPU
        '
        Me.lInfoNumeroCoresCPU.Enabled = False
        Me.lInfoNumeroCoresCPU.Location = New System.Drawing.Point(106, 90)
        Me.lInfoNumeroCoresCPU.Name = "lInfoNumeroCoresCPU"
        Me.lInfoNumeroCoresCPU.Size = New System.Drawing.Size(202, 20)
        Me.lInfoNumeroCoresCPU.TabIndex = 0
        '
        'lInfoArquitecturaCPU
        '
        Me.lInfoArquitecturaCPU.Enabled = False
        Me.lInfoArquitecturaCPU.Location = New System.Drawing.Point(106, 116)
        Me.lInfoArquitecturaCPU.Name = "lInfoArquitecturaCPU"
        Me.lInfoArquitecturaCPU.Size = New System.Drawing.Size(202, 20)
        Me.lInfoArquitecturaCPU.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "S.O.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PROCESADOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NUCLEOS LOG.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "FREC. (GHz):"
        '
        'lInfoNumeroCoresCPUF
        '
        Me.lInfoNumeroCoresCPUF.Enabled = False
        Me.lInfoNumeroCoresCPUF.Location = New System.Drawing.Point(106, 65)
        Me.lInfoNumeroCoresCPUF.Name = "lInfoNumeroCoresCPUF"
        Me.lInfoNumeroCoresCPUF.Size = New System.Drawing.Size(202, 20)
        Me.lInfoNumeroCoresCPUF.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NUCLEOS FIS.:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 150)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lInfoArquitecturaCPU)
        Me.Controls.Add(Me.lInfoNumeroCoresCPU)
        Me.Controls.Add(Me.lInfoNumeroCoresCPUF)
        Me.Controls.Add(Me.lInfoVersionSistemaOperativo)
        Me.Controls.Add(Me.lInfoSistemaOperativo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OBTIENE DATOS PC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lInfoSistemaOperativo As TextBox
    Friend WithEvents lInfoVersionSistemaOperativo As TextBox
    Friend WithEvents lInfoNumeroCoresCPU As TextBox
    Friend WithEvents lInfoArquitecturaCPU As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lInfoNumeroCoresCPUF As TextBox
    Friend WithEvents Label5 As Label
End Class
