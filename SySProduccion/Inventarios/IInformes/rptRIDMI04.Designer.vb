﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptRIDMI04
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptRIDMI04))
        Me.eIEDMIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.eQConSdoFinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.eIEDMIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQConSdoFinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eIEDMIBindingSource
        '
        Me.eIEDMIBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eIEDMI)
        '
        'RptVwr
        '
        Me.RptVwr.BackColor = System.Drawing.Color.AliceBlue
        Me.RptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "QConSdoFin"
        ReportDataSource1.Value = Me.eQConSdoFinBindingSource
        Me.RptVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptVwr.LocalReport.ReportEmbeddedResource = "SySProduccion.RIDMI04.rdlc"
        Me.RptVwr.Location = New System.Drawing.Point(0, 0)
        Me.RptVwr.Name = "RptVwr"
        Me.RptVwr.Size = New System.Drawing.Size(484, 362)
        Me.RptVwr.TabIndex = 1
        '
        'eQConSdoFinBindingSource
        '
        Me.eQConSdoFinBindingSource.DataSource = GetType(SySProduccion.moe_Estructuras.eQConSdoFin)
        '
        'rptRIDMI04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.RptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptRIDMI04"
        Me.Text = "Reporte Saldos Inventarios fechas anteriores"
        CType(Me.eIEDMIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQConSdoFinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eIEDMIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eQConSdoFinBindingSource As System.Windows.Forms.BindingSource
End Class