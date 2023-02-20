Imports Microsoft.Reporting.WinForms


Public Class rptCODC001
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"

    ' Estructuras
    Public Property wl_sTitRpt As String
    Public Property wl_sNomCia As String

    Public Property wl_aeGEMOV As Array
    Public Property wl_aeGLMOV1 As Array
    Public Property wl_aeATVEN As Array
    Public Property wl_aeTEDMT As Array
    Public Property wl_aeTLDMT4 As Array

    Dim wl_PrmRpt As ReportParameter() = New ReportParameter(1) {}


#End Region
#Region "011 frm - Variables Locales"


    Private Sub rptCODC001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim rpt_ODC As New ReportParameter()
            '   rpt_ODC.Name = "CODC002"


            RptVwr.LocalReport.DataSources.Clear()

            '     wl_PrmRpt(0) = New ReportParameter("RptPrmTit", wl_sTitRpt)
            '    wl_PrmRpt(1) = New ReportParameter("RptPrmCia", wl_sNomCia)
            '   RptVwr.LocalReport.SetParameters(wl_PrmRpt)
            '  RptVwr.LocalReport.DisplayName = "CODC002.rdlc"
            '     RptVwr.LocalReport.ReportEmbeddedResource = "CODC002.rdlc"

            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", wl_aeGEMOV))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet2", wl_aeGLMOV1))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet3", wl_aeATVEN))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet4", wl_aeTEDMT))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet5", wl_aeTLDMT4))

            RptVwr.LocalReport.Refresh()
            Me.RptVwr.RefreshReport()
           
        Catch ex As Exception
            MsgBox("Error :  rptCODC001_Load")
            MsgBox(ex.Message)
        End Try

    End Sub

    
#End Region

#Region "080 Plo - Procedimientos del formulario personalizados"
   

#End Region

    
    Private Sub RptVwr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RptVwr.Load

    End Sub
End Class