<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmASRES_LeeOdp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmASRES_LeeOdp))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.txtsCodDocIni = New System.Windows.Forms.TextBox()
        Me.lblsCodDoc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(85, 134)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 135
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 134)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 134
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(124, 55)
        Me.txtnNroDocIni.MaxLength = 10
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 137
        Me.txtnNroDocIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsCodDocIni
        '
        Me.txtsCodDocIni.Location = New System.Drawing.Point(124, 28)
        Me.txtsCodDocIni.MaxLength = 3
        Me.txtsCodDocIni.Name = "txtsCodDocIni"
        Me.txtsCodDocIni.Size = New System.Drawing.Size(56, 20)
        Me.txtsCodDocIni.TabIndex = 136
        '
        'lblsCodDoc
        '
        Me.lblsCodDoc.AutoSize = True
        Me.lblsCodDoc.Location = New System.Drawing.Point(28, 34)
        Me.lblsCodDoc.Name = "lblsCodDoc"
        Me.lblsCodDoc.Size = New System.Drawing.Size(62, 13)
        Me.lblsCodDoc.TabIndex = 138
        Me.lblsCodDoc.Text = "Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Número"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(284, 161)
        Me.ShapeContainer1.TabIndex = 140
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 34
        Me.LineShape2.X2 = 163
        Me.LineShape2.Y1 = 48
        Me.LineShape2.Y2 = 45
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 34
        Me.LineShape1.X2 = 211
        Me.LineShape1.Y1 = 73
        Me.LineShape1.Y2 = 73
        '
        'frmASRES_LeeOdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblsCodDoc)
        Me.Controls.Add(Me.txtnNroDocIni)
        Me.Controls.Add(Me.txtsCodDocIni)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmASRES_LeeOdp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Producción"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodDoc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
