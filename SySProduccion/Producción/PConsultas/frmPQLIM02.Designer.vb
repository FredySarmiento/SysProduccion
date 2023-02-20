<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPQLIM02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPQLIM02))
        Me.cmdLstCodDocIni = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdLstPEODProDocIni = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.txtsCodDocIni = New System.Windows.Forms.TextBox()
        Me.lblsCodDoc = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdLstPEODPIni = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLstCodDocIni
        '
        Me.cmdLstCodDocIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstCodDocIni.Location = New System.Drawing.Point(197, 34)
        Me.cmdLstCodDocIni.Name = "cmdLstCodDocIni"
        Me.cmdLstCodDocIni.Size = New System.Drawing.Size(80, 80)
        Me.cmdLstCodDocIni.TabIndex = 582
        Me.cmdLstCodDocIni.Text = "Lst"
        Me.cmdLstCodDocIni.UseVisualStyleBackColor = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 31)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 76
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 33)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 20)
        Me.cmdOk.TabIndex = 74
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdLstPEODProDocIni
        '
        Me.cmdLstPEODProDocIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODProDocIni.Location = New System.Drawing.Point(5, 10)
        Me.cmdLstPEODProDocIni.Name = "cmdLstPEODProDocIni"
        Me.cmdLstPEODProDocIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstPEODProDocIni.TabIndex = 583
        Me.cmdLstPEODProDocIni.Text = "Lst"
        Me.cmdLstPEODProDocIni.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblnNroDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstPEODPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 362)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 584
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.AutoSize = True
        Me.lblnNroDoc.Location = New System.Drawing.Point(104, 97)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(44, 13)
        Me.lblnNroDoc.TabIndex = 21
        Me.lblnNroDoc.Text = "Número"
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(219, 92)
        Me.txtnNroDocIni.MaxLength = 10
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 26
        Me.txtnNroDocIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsCodDocIni
        '
        Me.txtsCodDocIni.Location = New System.Drawing.Point(219, 63)
        Me.txtsCodDocIni.MaxLength = 3
        Me.txtsCodDocIni.Name = "txtsCodDocIni"
        Me.txtsCodDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodDocIni.TabIndex = 10
        '
        'lblsCodDoc
        '
        Me.lblsCodDoc.AutoSize = True
        Me.lblsCodDoc.Location = New System.Drawing.Point(104, 68)
        Me.lblsCodDoc.Name = "lblsCodDoc"
        Me.lblsCodDoc.Size = New System.Drawing.Size(68, 13)
        Me.lblsCodDoc.TabIndex = 9
        Me.lblsCodDoc.Text = "Documento :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 107
        Me.LineShape3.X2 = 320
        Me.LineShape3.Y1 = 110
        Me.LineShape3.Y2 = 111
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 106
        Me.LineShape1.X2 = 321
        Me.LineShape1.Y1 = 81
        Me.LineShape1.Y2 = 81
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 32)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 75
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdLstPEODPIni
        '
        Me.cmdLstPEODPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODPIni.Location = New System.Drawing.Point(342, 90)
        Me.cmdLstPEODPIni.Name = "cmdLstPEODPIni"
        Me.cmdLstPEODPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstPEODPIni.TabIndex = 585
        Me.cmdLstPEODPIni.Text = "Lst"
        Me.cmdLstPEODPIni.UseVisualStyleBackColor = False
        '
        'frmPQLIM02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmdLstCodDocIni)
        Me.Controls.Add(Me.cmdLstPEODProDocIni)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPQLIM02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimientos de MP y MEE por OP"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdLstCodDocIni As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdLstPEODProDocIni As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodDoc As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdLstPEODPIni As System.Windows.Forms.Button
End Class
