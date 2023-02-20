<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptCOOC001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCOOC001))
        Me.eGEMOVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eGLMOV1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eATVENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eTEDMTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eTLDMT4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.eGEMOVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGLMOV1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eATVENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTEDMTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTLDMT4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eGEMOVBindingSource
        '
        Me.eGEMOVBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eGEMOV)
        '
        'eGLMOV1BindingSource
        '
        Me.eGLMOV1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eGLMOV1)
        '
        'eATVENBindingSource
        '
        Me.eATVENBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eATVEN)
        '
        'eTEDMTBindingSource
        '
        Me.eTEDMTBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eTEDMT)
        '
        'eTLDMT4BindingSource
        '
        Me.eTLDMT4BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eTLDMT4)
        '
        'RptVwr
        '
        Me.RptVwr.AutoScroll = True
        Me.RptVwr.AutoSize = True
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.eGEMOVBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.eGLMOV1BindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.eATVENBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.eTEDMTBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.eTLDMT4BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource4)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource5)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.COOC001.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.ServerReport.BearerToken = Nothing
        Me.RptVwr.Size = New System.Drawing.Size(584, 412)
        Me.RptVwr.TabIndex = 0
        '
        'rptCOOC001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptCOOC001"
        Me.Text = "Orden de Compra"
        CType(Me.eGEMOVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGLMOV1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eATVENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTEDMTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTLDMT4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eGEMOVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGLMOV1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eATVENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eTEDMTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eTLDMT4BindingSource As System.Windows.Forms.BindingSource
End Class
