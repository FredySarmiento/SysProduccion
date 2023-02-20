<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPRRP001
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPRRP001))
        Me.ePEODPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ePEODPBindingSource
        '
        Me.ePEODPBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePEODP)
        '
        'ePLODP1BindingSource
        '
        Me.ePLODP1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP1)
        '
        'ePLODP2BindingSource
        '
        Me.ePLODP2BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP2)
        '
        'ePLODP3BindingSource
        '
        Me.ePLODP3BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP3)
        '
        'ePLODP4BindingSource
        '
        Me.ePLODP4BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP4)
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ePEODPBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ePLODP1BindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.ePLODP2BindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.ePLODP3BindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.ePLODP4BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource4)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource5)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.PRRP001.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(484, 362)
        Me.RptVwr.TabIndex = 0
        '
        'rptPRRP001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptPRRP001"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de producción con costos"
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ePEODPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP4BindingSource As System.Windows.Forms.BindingSource
End Class
