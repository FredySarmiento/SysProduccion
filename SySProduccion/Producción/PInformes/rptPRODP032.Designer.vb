<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPRODP032
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPRODP032))
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ePELROP1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePEODPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eGELMOV1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ePELROP1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGELMOV1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PELROP1"
        ReportDataSource1.Value = Me.ePELROP1BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.PRODP032.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(484, 362)
        Me.RptVwr.TabIndex = 2
        '
        'ePELROP1BindingSource
        '
        Me.ePELROP1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePELROP1)
        '
        'ePEODPBindingSource
        '
        Me.ePEODPBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePEODP)
        '
        'ePLODP4BindingSource
        '
        Me.ePLODP4BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP4)
        '
        'eGELMOV1BindingSource
        '
        Me.eGELMOV1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eGELMOV1)
        '
        'ePLODP1BindingSource
        '
        Me.ePLODP1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP1)
        '
        'ePLODP3BindingSource
        '
        Me.ePLODP3BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP3)
        '
        'ePLODP2BindingSource
        '
        Me.ePLODP2BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP2)
        '
        'rptPRODP032
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptPRODP032"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de consumos de MDO y CIF Resumen"
        CType(Me.ePELROP1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGELMOV1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ePELROP1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePEODPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGELMOV1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ePLODP2BindingSource As System.Windows.Forms.BindingSource
End Class
