<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPREDP01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPREDP01))
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.eIEREVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eILREV1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eGEMOVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eGLMOV1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.eIEREVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eILREV1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGEMOVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGLMOV1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "GEMOV"
        ReportDataSource1.Value = Me.eGEMOVBindingSource
        ReportDataSource2.Name = "GLMOV1"
        ReportDataSource2.Value = Me.eGLMOV1BindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.PREDP01.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(484, 362)
        Me.RptVwr.TabIndex = 0
        '
        'eIEREVBindingSource
        '
        Me.eIEREVBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eIEREV)
        '
        'eILREV1BindingSource
        '
        Me.eILREV1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eILREV1)
        '
        'eGEMOVBindingSource
        '
        Me.eGEMOVBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eGEMOV)
        '
        'eGLMOV1BindingSource
        '
        Me.eGLMOV1BindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eGLMOV1)
        '
        'rptPREDP01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptPREDP01"
        Me.Text = "Entrada de producción"
        CType(Me.eIEREVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eILREV1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGEMOVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGLMOV1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eIEREVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eILREV1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGEMOVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eGLMOV1BindingSource As System.Windows.Forms.BindingSource
End Class
