Imports Microsoft.Reporting.WinForms

Public Class rptCOOS001

#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"

    ' Estructuras
    Public Property wp_sTitRpt As String
    Public Property wp_sNomCia As String

    Public Property wp_aeGEMOV As Array
    Public Property wp_aeGLMOV1 As Array
    Public Property wp_aeATVEN As Array
    Public Property wp_aeATVEN_Aut As Array
    Public Property wp_aeTEDMT As Array
    Public Property wp_aeTLDMT1 As Array
    Public Property wp_aeTLDMT4 As Array
    Public Property wp_sNroALetras As String

    Dim wl_PrmRpt As ReportParameter() = New ReportParameter(0) {}


#End Region

    Private Sub rptCOOS001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim rpt_ODC As New ReportParameter()
            '   rpt_ODC.Name = "CODC002"

            RptVwr.LocalReport.DataSources.Clear()
            wl_PrmRpt(0) = New ReportParameter("RptPrm1", wp_sNroALetras)

            '     wl_PrmRpt(0) = New ReportParameter("RptPrmTit", wl_sTitRpt)
            '    wl_PrmRpt(1) = New ReportParameter("RptPrmCia", wl_sNomCia)
            '   RptVwr.LocalReport.SetParameters(wl_PrmRpt)
            '  RptVwr.LocalReport.DisplayName = "CODC002.rdlc"
            '     RptVwr.LocalReport.ReportEmbeddedResource = "CODC002.rdlc"

            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", wp_aeGEMOV))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet2", wp_aeGLMOV1))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet3", wp_aeATVEN))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet4", wp_aeTEDMT))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet5", wp_aeTLDMT4))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("DataSet6", wp_aeATVEN_Aut))
            RptVwr.LocalReport.SetParameters(wl_PrmRpt)
            RptVwr.LocalReport.Refresh()
            Me.RptVwr.RefreshReport()
            Me.RptVwr.SetDisplayMode(DisplayMode.PrintLayout)

        Catch ex As Exception
            MsgBox("Error :  rptCODC001_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
End Class