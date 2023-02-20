Imports Microsoft.Reporting.WinForms
Public Class rptRIREV01
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

    Public Property wp_aeIEREV As Array
    Public Property wp_aeILREV1 As Array
    Public Property wp_aeABTRI As Array
    Public Property wp_sNroALetras As String


    Dim wl_PrmRpt As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptNomCia As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptNomRpt As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptNitCia As ReportParameter() = New ReportParameter(0) {}
    Dim wl_PrmRptDigVer As ReportParameter() = New ReportParameter(0) {}

#End Region
#Region "020 - Principal"

    Private Sub rptRIREV01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim rpt_ODC As New ReportParameter()
        Try

            RptVwr.LocalReport.DataSources.Clear()
            wl_PrmRpt(0) = New ReportParameter("RptPrm1", wp_sNroALetras)
            wl_PrmRptNomCia(0) = New ReportParameter("RptPrmNomCia", vg_sNomCia)
            wl_PrmRptNomRpt(0) = New ReportParameter("RptPrmNomRpt", Me.Text)
            wl_PrmRptNitCia(0) = New ReportParameter("RptPrmNitCia", vg_sNitCia)
            wl_PrmRptDigVer(0) = New ReportParameter("RptPrmDigVer", vg_sDigVer)

            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("IEREV", wp_aeIEREV))
            RptVwr.LocalReport.DataSources.Add(New ReportDataSource("ILREV1", wp_aeILREV1))

            RptVwr.LocalReport.SetParameters(wl_PrmRptNomCia)
            RptVwr.LocalReport.SetParameters(wl_PrmRptNomRpt)
            RptVwr.LocalReport.SetParameters(wl_PrmRptNitCia)
            RptVwr.LocalReport.SetParameters(wl_PrmRptDigVer)
            RptVwr.LocalReport.Refresh()
            Me.RptVwr.RefreshReport()
            Me.RptVwr.SetDisplayMode(DisplayMode.PrintLayout)


        Catch ex As Exception
            MsgBox("Error :  rptRIREV01_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class