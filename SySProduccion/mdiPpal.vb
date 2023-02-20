'Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Globalization

Public Class mdiPpal
#Region "01 Configuracicón del formulario"
    Public Event wg_tsbBuscar()
    Public Event wg_tsbCrear()
    Public Event wg_tsbEliminar()
    Public Event wg_tsbPrimero()
    Public Event wg_tsbAnterior()
    Public Event wg_tsbSiguiente()
    Public Event wg_tsbUltimo()
    Public Event wg_tsbVistaPrevia()
    Public Event wg_tsbPrn()
    Public Event wg_tsmiCrearLinea()
    Public Event wg_tsmiEliminarLinea()

    ' Public vg_sCodCia As String
    'Public vg_sNomCia As String

#End Region
#Region "vl - wl Definición del variables Locales"
    ' variables locales dgv


    ' Variables Locales
    Dim wl_segIni As Integer
    Dim wl_segFin As Integer

    ' Variables Campos de la BD



    ' objetos locales


    ' Otras variables


#End Region
#Region "03 Programa principal"

    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        '  System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","



        Dim wl_oCtl As Control
        Dim wl_octlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each wl_oCtl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                wl_octlMDI = CType(wl_oCtl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                wl_octlMDI.BackColor = Me.BackColor
                '   wl_octlMDI.BackgroundImage = Me.BackgroundImage

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
        vg_sCodcia = ""
        vg_sCodcia = SeleccionarCia()

        Dim wl_frm As New Form
        wl_frm = frmGLogin
        wl_frm.Show()

        leeACPAG()
        mof_inhabToolbar()

        Me.Text += "  -  " + vg_sNomCia
    End Sub
#End Region

    Private Sub FinalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizarToolStripMenuItem.Click
        Dim wl_frm As Form
        For Each wl_frm In Me.MdiChildren
            wl_frm.Close()
        Next
        Me.Close()
        Application.Exit()
    End Sub


    Private Sub MenúPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        frmGMnuPpal.MdiParent = Me
        frmGMnuPpal.Show()
    End Sub


    Private Sub EnCascadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnCascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblStatusReloj.Text = TimeString.ToString
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblStatusFecha.Text = DateString.ToString
    End Sub

    Private Sub GestiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónToolStripMenuItem.Click

    End Sub
#Region "Funciones locales"
    Public Function SeleccionarCia()
        Dim clnACBDE As New ClaseNegocios.clnACBDE
        Dim clnConTbl As New ClaseNegocios.clnConTbl

        Dim wl_eACBDE As New moe_Estructuras.eACBDE
        Dim wl_eACDEM As New moe_Estructuras.eACDEM


        'Dim wl_DT As DataTable
        Dim vp_bCiaSel As Boolean

        vg_sCodcia = " "
        vg_sNomCia = " "
        vg_sNitCia = " "
        vg_sNomBD = " "
        vg_nAnoSdoIniInv = 0
        vp_bCiaSel = True
        wr_bEOF = True
        wg_DTE1 = clnACBDE.cndtConsultar(vp_bCiaSel,
                                         wr_bEOF)

        If Not wr_bEOF Then
            moo_eACBDE_DT(wl_eACBDE,
                          wg_DTE1)
            vg_sCodcia = wl_eACBDE.sCodCia
            vg_sNomBD = wl_eACBDE.sNomBD

            wp_sNomTbl = "ACDEM"
            wp_sNomCmp = "sCodcia"
            wp_sDatCmp = vg_sCodcia
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            wg_DTE1 = clnConTbl.cndtBuscar(wp_sNomTbl,
                                           wp_sNomCmp,
                                           wp_sDatCmp,
                                           wp_sTipCmp,
                                           wp_sCmpOrd,
                                           wp_sTipOrd,
                                           wr_bEOF)

            moo_eACDEM_DT(wl_eACDEM,
                          wg_DTE1)

            vg_eACDEM = wl_eACDEM
            vg_sNomCia = wl_eACDEM.sNomCia
            vg_sNitCia = wl_eACDEM.sNitCia
            vg_sDigVer = wl_eACDEM.sDigVer
            vg_nAnoSdoIniInv = wl_eACDEM.nAnoSdoIniInv
            Return (vg_sCodcia)
        Else
            Return Nothing
            finalizar()
        End If

    End Function
    Public Function leeACPAG()
        Dim clnConTbl As New ClaseNegocios.clnConTbl
        Dim vl_eACPAG As New moe_Estructuras.eACPAG

        wr_bEOF = True
        wp_sNomTbl = "ACPAG"
        wp_sNomCmp = "sCodcia"
        wp_sDatCmp = vg_sCodcia
        wp_sTipCmp = "S"
        wp_sCmpOrd = ""
        wp_sTipOrd = ""

        wg_DTE1 = clnConTbl.cndtBuscar(wp_sNomTbl,
                                       wp_sNomCmp,
                                       wp_sDatCmp,
                                       wp_sTipCmp,
                                       wp_sCmpOrd,
                                       wp_sTipOrd,
                                       wr_bEOF)


        If Not wr_bEOF Then
            moo_eACPAG_DT(vl_eACPAG,
                          wg_DTE1)
            wg_eACPAG = New moe_Estructuras.eACPAG

            wg_eACPAG = vl_eACPAG


            vg_bLmtCre = vl_eACPAG.bLmtCre
            vg_sCndPagxDefCli = vl_eACPAG.sCndPagxDefCli
            vg_sMetPagxDefCli = vl_eACPAG.sMetPagxDefCli
            vg_sCndPagxDefPro = vl_eACPAG.sCndPagxDefPro
            vg_sMetPagxDefPro = vl_eACPAG.sMetPagxDefPro
            vg_sClrFrm = vl_eACPAG.sClrFrm
            vg_sForFec = vl_eACPAG.sForFec
            vg_sForHor = vl_eACPAG.sForHor
            vg_nNroDecPre = vl_eACPAG.nNroDecPre
            vg_nNroDecCan = vl_eACPAG.nNroDecCan
            vg_nNroDecPor = vl_eACPAG.nNroDecPor
            vg_sCodAlmXDef = vl_eACPAG.sCodAlmXDef
            vg_sCrictaCtb = vl_eACPAG.sCriCtaCtb
            vg_bVisItmIna = vl_eACPAG.bVisItmIna
            vg_sRutXls = vl_eACPAG.sRutXls
            vg_nPorGto = vl_eACPAG.nPorGto
            vg_nPorIto = vl_eACPAG.nPorIto
        End If
        Return (Nothing)
    End Function


#End Region


#Region "Procedimientos Locales"
    Public Sub finalizar()
        Me.Close()
    End Sub
    Private Sub Plo_IniciarVar()

    End Sub
#End Region




#Region "ToolStrip Eventos"
    Private Sub tsbAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnterior.Click
        RaiseEvent wg_tsbAnterior()
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        RaiseEvent wg_tsbBuscar()
    End Sub
    Private Sub tsbCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCrear.Click
        RaiseEvent wg_tsbCrear()
    End Sub
    Private Sub tsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrimero.Click
        RaiseEvent wg_tsbPrimero()
    End Sub
    Private Sub tsbPrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrn.Click
        RaiseEvent wg_tsbPrn()
    End Sub
    Private Sub tsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSiguiente.Click
        RaiseEvent wg_tsbSiguiente()
    End Sub
    Private Sub tsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUltimo.Click
        RaiseEvent wg_tsbUltimo()
    End Sub
    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        RaiseEvent wg_tsbEliminar()
    End Sub
    Private Sub tsbVwvPrv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVwvPrv.Click
        RaiseEvent wg_tsbVistaPrevia()
    End Sub
#End Region

#Region "ToolStripMenuItem Eventos"
   Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Dim wl_frm As Form
        For Each wl_frm In Me.MdiChildren
            wl_frm.Close()
        Next
    End Sub
   

  

    Private Sub AñadirLíneaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirLíneaToolStripMenuItem.Click
        RaiseEvent wg_tsmiCrearLinea()
    End Sub
    Private Sub EliminarLíneaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarLíneaToolStripMenuItem.Click
        RaiseEvent wg_tsmiEliminarLinea()
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        RaiseEvent wg_tsbEliminar()
    End Sub
#Region "Módulos"
    Private Sub ModulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModulosToolStripMenuItem.Click

    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim vl_frm As New frmATUSR
        vl_frm.MdiParent = Me
        vl_frm.Activate()
        vl_frm.Show()
    End Sub

    Private Sub FórmulaMaestraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FórmulaMaestraToolStripMenuItem.Click
        Dim vl_frm As New frmPEFOM
        vl_frm.MdiParent = Me
        vl_frm.Activate()
        vl_frm.Show()
    End Sub
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosEmpresaToolStripMenuItem.Click
        Dim vl_frm As New frmACDEM
        vl_frm.MdiParent = Me
        vl_frm.Activate()
        vl_frm.Show()
    End Sub
    Private Sub DatosMaestroDeItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosMaestroDeItemsToolStripMenuItem.Click
        Dim vl_frm As New frmIEDMI
        vl_frm.MdiParent = Me
        vl_frm.Activate()
        vl_frm.Show()
        vl_frm.Close()

    End Sub
    Private Sub EntradasDeInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasDeInventarioToolStripMenuItem.Click
        Dim vl_frm As New frmIEENI
        vl_frm.MdiParent = Me
        vl_frm.Activate()
        vl_frm.Show()
    End Sub


    Private Sub CentrosDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentrosDeTrabajoToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmATCTR
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : CentrosDeTrabajoToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CIFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CIFToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmATCIF
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : CIFToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DevoluciónDeMaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluciónDeMaterialesToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmPEEDM
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : DevoluciónDeMaterialesToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EntradaDeProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeProducciónToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmPEEDP
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : EntradaDeProducciónToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListaDeMaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeMaterialesToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmPELIM
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : ListaDeMaterialesToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub OperacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperacionesToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmATOPE
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : OperacionesToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub OrdenDeProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeProducciónToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmPEODP
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : OrdenDeProducciónToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RegistroDeOperacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeOperacionesToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmPEROP
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : RegistroDeOperacionesToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SalidaParaProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaParaProducciónToolStripMenuItem.Click
        Try
            Dim vl_frm As New frmPESDM
            vl_frm.MdiParent = Me
            vl_frm.Activate()
            vl_frm.Show()
        Catch ex As Exception
            MsgBox("Error : SalidaParaProducciónToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region



#End Region
#Region "Reloj"
    Public Sub Timer3_Timer()
        Timer3.Interval = 1000
        Timer3.Enabled = True
        Timer3.Start()
        wl_segFin = 10
        wl_segIni = 0
        Timer3_Tick(Nothing, Nothing)

    End Sub
    Public Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Timer3.Interval < 1 Then
            mof_LmpMsgError()
            Timer3.Enabled = False
        End If
    End Sub
#End Region

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim wl_frm As New frmAcerca

        wl_frm.ShowDialog()

    End Sub

    
End Class
