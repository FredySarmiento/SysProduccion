<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptCODC001
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
        Me.eGEMOVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eGLMOV1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.eGEMOVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGLMOV1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RptVwr
        '
        Me.RptVwr.AutoScroll = True
        Me.RptVwr.AutoSize = True
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.eGEMOVBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.eGLMOV1BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.CODC001.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(564, 481)
        Me.RptVwr.TabIndex = 0
        '
        'rptCODC001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(564, 481)
        Me.Controls.Add(Me.RptVwr)
        Me.Name = "rptCODC001"
        Me.Text = "Orden de Compra"
        CType(Me.eGEMOVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGLMOV1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eGEMOVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGLMOV1BindingSource As System.Windows.Forms.BindingSource
End Class
