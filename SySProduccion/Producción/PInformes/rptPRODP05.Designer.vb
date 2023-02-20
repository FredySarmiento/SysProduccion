<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPRODP05
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPRODP05))
        Me.ePEODPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePEODP_PLODP4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eIEDMIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eATALMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ePLODP2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePEODP_PLODP4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eIEDMIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eATALMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ePEODPBindingSource
        '
        Me.ePEODPBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePEODP)
        '
        'ePEODP_PLODP4BindingSource
        '
        Me.ePEODP_PLODP4BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePEODP_PLODP4)
        '
        'eIEDMIBindingSource
        '
        Me.eIEDMIBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eIEDMI)
        '
        'ePLODP5BindingSource
        '
        Me.ePLODP5BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP5)
        '
        'eATALMBindingSource
        '
        Me.eATALMBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eATALM)
        '
        'ePLODP1BindingSource
        '
        Me.ePLODP1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP1)
        '
        'ePLODP4BindingSource
        '
        Me.ePLODP4BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP4)
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PEODP"
        ReportDataSource1.Value = Me.ePEODPBindingSource
        ReportDataSource2.Name = "PEODP_PLODP4"
        ReportDataSource2.Value = Me.ePEODP_PLODP4BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.PRODP05.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(484, 362)
        Me.RptVwr.TabIndex = 1
        '
        'ePLODP2BindingSource
        '
        Me.ePLODP2BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP2)
        '
        'rptPRODP05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptPRODP05"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen OP con  Costos"
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePEODP_PLODP4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eIEDMIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eATALMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents eIEDMIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePEODPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eATALMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ePLODP2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePEODP_PLODP4BindingSource As System.Windows.Forms.BindingSource
End Class
