Imports Microsoft.Reporting.WinForms
Public Class rptPRLIM01
#Region "000 Inicia. Definición de variables"
#Region "001 Inicia. wg - vg Definición del variables públicas"

    Public Property wp_sTitRpt As String
    Public Property wp_sNomCia As String

    Public Property wp_aePELIM As Array
    Public Property wp_aePLLIM1 As Array
    Public Property wp_aePLLIM2 As Array
    Public Property wp_aePLLIM3 As Array
    Public Property wp_aePLLIM4 As Array
    Public Property wp_sNroALetras As String
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    Dim wl_PrmRpt As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptNomCia As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptNomRpt As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptNitCia As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptDigVer As ReportParameter() = New ReportParameter(0) {}
#End Region

#End Region
    Private Sub rptPRLIM01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim rpt_ODC As New ReportParameter()

            RptVwr.LocalReport.DataSources.Clear()

            wl_PrmRptNomCia(0) = New ReportParameter("RptPrmNomCia", vg_sNomCia)
            wl_PrmRptNomRpt(0) = New ReportParameter("RptPrmNomRpt", Me.Text)
            wl_PrmRptNitCia(0) = New ReportParameter("RptPrmNitCia", vg_sNitCia)
            wl_PrmRptDigVer(0) = New ReportParameter("RptPrmDigVer", vg_sDigVer)

            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("PELIM", wp_aePELIM))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("PLLIM1", wp_aePLLIM1))

            RptVwr.LocalReport.SetParameters(wl_PrmRptNomCia)
            RptVwr.LocalReport.SetParameters(wl_PrmRptNomRpt)
            RptVwr.LocalReport.SetParameters(wl_PrmRptNitCia)
            RptVwr.LocalReport.SetParameters(wl_PrmRptDigVer)
            RptVwr.LocalReport.Refresh()
            Me.RptVwr.RefreshReport()
            Me.RptVwr.SetDisplayMode(DisplayMode.PrintLayout)


        Catch ex As Exception
            MsgBox("Error :  rptPRLIM01_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class