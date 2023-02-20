<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFEACO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFEACO))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.lblFecDoc = New System.Windows.Forms.Label()
        Me.lblFecVto = New System.Windows.Forms.Label()
        Me.lblFecCtb = New System.Windows.Forms.Label()
        Me.lblCodDocBas = New System.Windows.Forms.Label()
        Me.lblNroDocBas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNroAsi = New System.Windows.Forms.Label()
        Me.lblRef1 = New System.Windows.Forms.Label()
        Me.lblRef2 = New System.Windows.Forms.Label()
        Me.lblCmn = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(85, 370)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 23
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 370)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 22
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnNroDoc.Location = New System.Drawing.Point(510, 10)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDoc.TabIndex = 204
        Me.lblnNroDoc.Text = "Número:"
        '
        'lblFecDoc
        '
        Me.lblFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecDoc.Location = New System.Drawing.Point(510, 70)
        Me.lblFecDoc.Name = "lblFecDoc"
        Me.lblFecDoc.Size = New System.Drawing.Size(105, 15)
        Me.lblFecDoc.TabIndex = 232
        Me.lblFecDoc.Text = "Fecha documento"
        '
        'lblFecVto
        '
        Me.lblFecVto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecVto.Location = New System.Drawing.Point(510, 50)
        Me.lblFecVto.Name = "lblFecVto"
        Me.lblFecVto.Size = New System.Drawing.Size(139, 13)
        Me.lblFecVto.TabIndex = 231
        Me.lblFecVto.Text = "Fecha vencimiento:"
        '
        'lblFecCtb
        '
        Me.lblFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecCtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecCtb.Location = New System.Drawing.Point(510, 30)
        Me.lblFecCtb.Name = "lblFecCtb"
        Me.lblFecCtb.Size = New System.Drawing.Size(139, 13)
        Me.lblFecCtb.TabIndex = 230
        Me.lblFecCtb.Text = "Fecha de contabilización:"
        '
        'lblCodDocBas
        '
        Me.lblCodDocBas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodDocBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodDocBas.Location = New System.Drawing.Point(5, 96)
        Me.lblCodDocBas.Name = "lblCodDocBas"
        Me.lblCodDocBas.Size = New System.Drawing.Size(104, 14)
        Me.lblCodDocBas.TabIndex = 233
        Me.lblCodDocBas.Text = "Documento origen"
        '
        'lblNroDocBas
        '
        Me.lblNroDocBas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNroDocBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroDocBas.Location = New System.Drawing.Point(117, 96)
        Me.lblNroDocBas.Name = "lblNroDocBas"
        Me.lblNroDocBas.Size = New System.Drawing.Size(122, 14)
        Me.lblNroDocBas.TabIndex = 234
        Me.lblNroDocBas.Text = "Número Doc. origen"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Código transacción"
        '
        'lblNroAsi
        '
        Me.lblNroAsi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNroAsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroAsi.Location = New System.Drawing.Point(5, 10)
        Me.lblNroAsi.Name = "lblNroAsi"
        Me.lblNroAsi.Size = New System.Drawing.Size(139, 14)
        Me.lblNroAsi.TabIndex = 236
        Me.lblNroAsi.Text = "Número contabilización:"
        '
        'lblRef1
        '
        Me.lblRef1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRef1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef1.Location = New System.Drawing.Point(5, 132)
        Me.lblRef1.Name = "lblRef1"
        Me.lblRef1.Size = New System.Drawing.Size(104, 14)
        Me.lblRef1.TabIndex = 237
        Me.lblRef1.Text = "Referencia 1"
        '
        'lblRef2
        '
        Me.lblRef2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef2.Location = New System.Drawing.Point(124, 132)
        Me.lblRef2.Name = "lblRef2"
        Me.lblRef2.Size = New System.Drawing.Size(104, 14)
        Me.lblRef2.TabIndex = 238
        Me.lblRef2.Text = "Referencia 2"
        '
        'lblCmn
        '
        Me.lblCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCmn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmn.Location = New System.Drawing.Point(252, 132)
        Me.lblCmn.Name = "lblCmn"
        Me.lblCmn.Size = New System.Drawing.Size(104, 14)
        Me.lblCmn.TabIndex = 239
        Me.lblCmn.Text = "Comentario"
        '
        'dgv1
        '
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(5, 166)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(735, 177)
        Me.dgv1.TabIndex = 240
        '
        'frmFEACO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(743, 397)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblCmn)
        Me.Controls.Add(Me.lblRef2)
        Me.Controls.Add(Me.lblRef1)
        Me.Controls.Add(Me.lblNroAsi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNroDocBas)
        Me.Controls.Add(Me.lblCodDocBas)
        Me.Controls.Add(Me.lblFecDoc)
        Me.Controls.Add(Me.lblFecVto)
        Me.Controls.Add(Me.lblFecCtb)
        Me.Controls.Add(Me.lblnNroDoc)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFEACO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asientos contables"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents lblFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblFecVto As System.Windows.Forms.Label
    Friend WithEvents lblFecCtb As System.Windows.Forms.Label
    Friend WithEvents lblCodDocBas As System.Windows.Forms.Label
    Friend WithEvents lblNroDocBas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNroAsi As System.Windows.Forms.Label
    Friend WithEvents lblRef1 As System.Windows.Forms.Label
    Friend WithEvents lblRef2 As System.Windows.Forms.Label
    Friend WithEvents lblCmn As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
End Class
