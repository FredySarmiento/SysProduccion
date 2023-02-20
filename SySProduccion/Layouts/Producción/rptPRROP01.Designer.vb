<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPRROP01
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPRROP01))
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ePEROPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLROP1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ePEROPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLROP1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PEROP"
        ReportDataSource1.Value = Me.ePEROPBindingSource
        ReportDataSource2.Name = "PLROP1"
        ReportDataSource2.Value = Me.ePLROP1BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.PRROP01.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(584, 412)
        Me.RptVwr.TabIndex = 0
        '
        'ePEROPBindingSource
        '
        Me.ePEROPBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePEROP)
        '
        'ePLROP1BindingSource
        '
        Me.ePLROP1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLROP1)
        '
        'rptPRROP01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptPRROP01"
        Me.Text = "Reporte diario de tiempos"
        CType(Me.ePEROPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLROP1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ePEROPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLROP1BindingSource As System.Windows.Forms.BindingSource
End Class
