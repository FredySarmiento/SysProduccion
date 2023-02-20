<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPROP003
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPROP003))
        Me.ePEODPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePLODP2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ePEODPBindingSource
        '
        Me.ePEODPBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePEODP)
        '
        'ePLODP2BindingSource
        '
        Me.ePLODP2BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.ePLODP2)
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ePEODPBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ePLODP2BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.PROP003.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(584, 412)
        Me.RptVwr.TabIndex = 0
        '
        'rptPROP003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptPROP003"
        Me.Text = "Operaciones"
        CType(Me.ePEODPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePLODP2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ePEODPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ePLODP2BindingSource As System.Windows.Forms.BindingSource
End Class
