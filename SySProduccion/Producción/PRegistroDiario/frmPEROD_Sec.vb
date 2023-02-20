Public Class frmPEROD_Sec
#Region "001 Inicia. wg - vg Definición del variables públicas"
    ' wg - Variables de trabajo globales/públicas parámetro
    ' vp - Variables que corresponde a campos de la BD globles/públicas- parámeto
    Public vg_dFecDoc As Date
    Public vg_sCodTer As String
    Public vg_sHorSys As String
    Public vg_sNomTer As String
    Public vg_nHHIniOpe As Long
    Public vg_nHHFinOpe As Long
    Public vg_nTieCnsOpe As Long
    Public vg_nHHIniAlz As Long
    Public vg_nHHFinAlz As Long
    Public vg_nTieCnsAlz As Long
    Public vg_nHHIniCaf As Long
    Public vg_nHHFinCaf As Long
    Public vg_nTieCnsCaf As Long
    Public vg_sCodDoc As String
    Public vg_nNroDoc As Integer
    Public vg_sCodDocSer As String
    Public vg_sTipMov As String
    Public vg_sEstDoc As String

    Public vg_nTieCns As Long
    Public wg_bAbrirReg As Boolean
    Public wg_bCerrarReg As Boolean
    Public wg_bIniciar As Boolean
    Public wg_bRegNue As String
    Public wg_bSecOk As Boolean
    Public wg_bTerminar As Boolean
    Public wg_ePEROP As New moe_Estructuras.ePEROP
    Public wg_ePLROP1 As New moe_Estructuras.ePLROP1
    Public wg_ePLODP2 As New moe_Estructuras.ePLODP2
    Public wg_aePLODP2() As moe_Estructuras.ePLODP2



    Public wg_nNroEnt As String
    Public wg_sOpc As String

#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"

    'Booleanas
    Dim wl_bOpeAbi As Boolean
    Dim wl_bNoOpeAbi As Boolean
    Dim wl_bAlzAbi As Boolean
    Dim wl_bCafAbi As Boolean
    Dim wl_bEOF As Boolean
    Dim wl_bEOF1 As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bTF As Boolean
    Dim wl_bDocCrd As Boolean

    'String

    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
    Dim wl_sCodDoc As String
    Dim wl_sCodDocBas As String
    Dim wl_nNroDocBas As Integer
    Dim wl_sOpc As String
    Dim wl_bAbrirReg As Boolean
    Dim wl_bCerrarReg As Boolean
    Dim wl_bIniciar As Boolean
    Dim wl_bTerminar As Boolean
    Dim wl_bRegNue As Boolean

    'Numéricas

    Dim wl_nHH As Long
    Dim wl_nMM As Long
    Dim wl_nHHIni As Long
    Dim wl_nMMIni As Long
    Dim wl_nHHFin As Long
    Dim wl_nMMFin As Long
    Dim wl_nHHCns As Long
    Dim wl_nMMCns As Long
    Dim wl_nTieCns As Long
    Dim wl_sHorSys As String
    Dim wl_nCntReg As Long
    Dim wl_nIdPEROP As Long


#End Region
#Region "012 BD - Variables campos BD Locales"


    Dim vl_nId As Long
    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodSer As String
    Dim vl_sTipMov As String
    Dim vl_sEstDoc As String
    Dim vl_dFecCtb As Date
    Dim vl_dFecDoc As Date
    Dim vl_dFecVto As Date
    Dim vl_dFecSys As Date
    Dim vl_sCodTer As String
    Dim vl_sNomTer As String
    Dim vl_sDocRef As String
    Dim vl_nTotHHCns As Long
    Dim vl_nTotMMCns As Long
    Dim vl_nTotTieCns As Double
    Dim vl_nTotDoc As Double
    Dim vl_sCodCte As String
    Dim vl_nNroCte As Long
    Dim vl_sClsDoc As String
    Dim vl_sCmn As String
    Dim vl_sCodCteCtb As String
    Dim vl_nNroCteCtb As Long
    Dim vl_nIdFECCT As Long
    Dim vl_sNitTer As String
    Dim vl_sTipDoc As String
    Dim vl_sCodUsr As String
    Dim vl_bPrp01 As Boolean
    Dim vl_bPrp02 As Boolean
    Dim vl_bPrp03 As Boolean
    Dim vl_nTotHHOpe As Long
    Dim vl_nTotMMOpe As Long
    Dim vl_nTotTieOpe As Double
    Dim vl_nTotHHAlz As Long
    Dim vl_nTotMMAlz As Long
    Dim vl_nTotTieAlz As Double
    Dim vl_nTotHHCaf As Long
    Dim vl_nTotMMCaf As Long
    Dim vl_nTotTieCaf As Double

    Dim vl_nId_l As Long
    Dim vl_sCodDocBas As String '5
    Dim vl_sCodSerBas As String
    Dim vl_nNroDocBas As Long
    Dim vl_sCodItm As String
    Dim vl_nCanItm As Double
    Dim vl_sCodOpe As String
    Dim vl_sNomOpe As String
    Dim vl_nHHIniOpe As Long
    Dim vl_nMMIniOpe As Long
    Dim vl_nHHFinOpe As Long
    Dim vl_nMMFinOpe As Long
    Dim vl_nHHCnsOpe As Long
    Dim vl_nMMCnsOpe As Long
    Dim vl_nTieCnsOpe As Long
    Dim vl_nHHCns As Long
    Dim vl_nMMCns As Long
    Dim vl_nTieCns As Long
    Dim vl_nTieReq As Long
    Dim vl_nPreUni As Long
    Dim vl_nTotLin As Double
    Dim vl_sCodCco As String
    Dim vl_nLinBas As Long
    Dim vl_sCodPdo As String
    Dim vl_sCodCta As String
    Dim vl_sCtaCosVta As String
    Dim vl_bItmBlq As Boolean
    Dim vl_nCanOpeTer As Long
    Dim vl_sCodCtr As String
    Dim vl_nHHIniAlz As Long
    Dim vl_nMMIniAlz As Long
    Dim vl_nHHFinAlz As Long
    Dim vl_nMMFinAlz As Long
    Dim vl_nHHCnsAlz As Long
    Dim vl_nMMCnsAlz As Long
    Dim vl_nTieCnsAlz As Long
    Dim vl_nHHIniCaf As Long
    Dim vl_nMMIniCaf As Long
    Dim vl_nHHFinCaf As Long
    Dim vl_nMMFinCaf As Long
    Dim vl_nHHCnsCaf As Long
    Dim vl_nMMCnsCaf As Long
    Dim vl_nTieCnsCaf As Long

    Dim vl_nNroSig As Long
    Dim vl_sEstPdo As String


#End Region
#Region "014 Objetos locales"
    Dim clnActTab As New ClaseNegocios.clnActTbl
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnPEODP As New ClaseNegocios.clnPEODP
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTLst1 As New DataTable
    Dim wl_DTAPLND1 As New DataTable
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1


#End Region
#Region "015 Estructuras"
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEROP As New moe_Estructuras.ePEROP
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
    Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
    Dim wl_aePLODP2() As moe_Estructuras.ePLODP2
    Dim wl_DT1 As DataTable



#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmPEROD_Sec_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Plo_IniciarVar()
            Plo_HabCmd()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_CrearActualizarPEROP(ByVal wp_sCmdSel As String)
        wl_bTF = False
        wl_nIdPEROP = 0

        Try

            wl_bEOF = True
            vl_sEstPdo = "0"
            wl_bEOF = mov_VdaPdoCtb(vl_dFecDoc, vl_sEstPdo)
            If wl_bEOF = True Then
                MsgBox("Período Contable, para la fecha contable, No Existe")
                cmdCancelar.Focus()
                Return
            Else
                If vl_sEstPdo = "2" Then
                    MsgBox("Período Contable para la fecha contable está Cerrado. No se puede actualizar")
                    cmdCancelar.Focus()
                    Return
                End If
            End If
            wl_bEOF = mov_VdaPdoCtb(vl_dFecDoc, vl_sEstPdo)
            If wl_bEOF = True Then
                MsgBox("Período Contable, para la fecha del documento, No Existe")
                cmdCancelar.Focus()
                Return
            Else
                If vl_sEstPdo = "2" Then
                    MsgBox("Período Contable, para la fecha del documento, Está Cerrado")
                    cmdCancelar.Focus()
                    Return
                End If
            End If
            wg_bVdaE1 = True
            'wl_bTF = clnPEROP.cnCrearAct(wl_ePEROP,
            '                             wr_bEOFE1,
            '                             wp_sCmdSel)

            wl_nIdPEROP = clnPEROP.cnCrearAct(wl_ePEROP,
                                              wr_nIdEnc,
                                              wp_sCmdSel)
            vl_nId = wl_nIdPEROP

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizarPEROP")
        End Try
    End Sub
    Private Sub BD_CrearActualizarPLROP1(ByVal wp_sCmdSel As String)
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bTF = False
        wl_bEOF = True
        wl_bEOF1 = True
        wl_ePLROP1.nIdPEROP = vl_nId
        Try
            clnPEROP.cnCrearActPLROP1(wl_ePLROP1,
                                      wl_bEOF1,
                                      wp_sCmdSel)

            If wl_ePLROP1.sCodDocBas <> Nothing Then
                If wl_bDocCrd = True Then


                    clnPEROP.cnCrearActPLROP1(wl_ePLROP1,
                                                 wl_bEOF,
                                                 wp_sCmdSel)
                    clnPEODP.cnActCnsPLODP2(wl_ePLROP1,
                                            wr_bEOFL1,
                                            wp_sCmdSel)
                    clnPEODP.cnActCnsMODPLODP4(wl_ePLROP1,
                                               wr_bEOFL1,
                                               wp_sCmdSel)
                    clnPEODP.cnActCnsPLODP3(wl_ePLROP1,
                                            wr_bEOFL1,
                                            wp_sCmdSel)
                    clnPEODP.cnActCnsCIFPLODP4(wl_ePLROP1,
                                               wr_bEOFL1,
                                               wp_sCmdSel)
                    clnPEODP.cnRecalPLODP4(wl_ePLROP1.sCodDocBas,
                                           wl_ePLROP1.nNroDocBas)
                    clnPEODP.cnActPorOpeCnsPLODP2(wl_ePLROP1,
                                                  wr_bEOFL1)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : BD_CrearActualizarPLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarPEODP() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePEODP = New moe_Estructuras.ePEODP
            wr_bEOFE2 = mof_fConPEODP(vl_sCodDocBas,
                                      vl_nNroDocBas,
                                      Nothing,
                                      wl_ePEODP)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPEODP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPLODP2() As Boolean
        Try
            wr_bEOFE1 = True
            wl_ePLODP2 = New moe_Estructuras.ePLODP2

            ReDim wl_aePLODP2(0)
            wl_aePLODP2(0) = New moe_Estructuras.ePLODP2
            wl_DT1 = clnPEODP.cndtConsultarPLODP2(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   Nothing,
                                                   wr_bEOFL1)
            moo_aePLODP2_DT(wl_aePLODP2,
                              wl_DT1)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPLODP2")
        End Try
        Return wr_bEOFE2
    End Function
    Private Sub BD_BuscarAPLND1()
        Try
            wl_eAPLND1 = New moe_Estructuras.eAPLND1
            wg_sTblLst1 = "APLND1"
            wr_bEOFLst1 = False
            wg_DTLst1 = clnConTbl.cndtSelSer(wg_sTblLst1,
                                         vl_sCodDoc,
                                         vl_sCodSer,
                                         wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                moo_eAPLND1_DT(wl_eAPLND1,
                           wg_DTLst1,
                           0)
                vl_nNroDoc = wl_eAPLND1.nNroSig
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarAPLND1")
        End Try
    End Sub
    
    Private Function BD_BuscarATCTR() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCTR = New moe_Estructuras.eATCTR
            wr_bEOFE2 = mof_fConATCTR(vl_sCodCtr,
                                      wl_eATCTR)
            If wr_bEOFE2 = False Then
                txtsCodCtr.Text = wl_eATCTR.sCodCtr
                txtsNomCtr.Text = wl_eATCTR.sNomCtr
                vl_nPreUni = wl_eATCTR.nPreUni
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATOPE")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Try
            wg_bSecOk = False
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        Try
            wl_bVda = True
            'txt a var
            Plo_Var_frm()
            'valida
            Plo_VdaDat()
            'Realiza cálculos
            Plo_CalTie()
            'Valida cerrar doc
            Plo_VdaCerDoc()
            'Total documento
            'Mueve variables a estructuras
            Plo_ePEROP_Var()
            Plo_ePLROP1_Var()
            If wl_bVda = True Then
                If wg_bRegNue = True Then
                    'Genera consecutivo
                    BD_BuscarAPLND1()
                    wl_ePEROP.nNroDoc = vl_nNroDoc
                    wl_ePLROP1.nNroDoc = vl_nNroDoc
                    'Crea registro PEROP
                    BD_CrearActualizarPEROP(wp_sCmdSel)
                    BD_CrearActualizarPLROP1(wp_sCmdSel)
                    'Crea registro PLROP1
                    'Suma 1 a  consecutivo
                    PloNroSig_APEND()
                    PloNroSig_APLND1()
                Else
                    'Actualiza registro pEROP
                    'Actualiza registro PLROP1
                    'BD_CrearActualizarPEROP(wp_sCmdSel)
                    BD_CrearActualizarPLROP1(wp_sCmdSel)
                    BD_CrearActualizarPEROP(wp_sCmdSel)
                End If
            End If

            wg_bSecOk = True
            If wl_bVda = True Then
                grl_Cerrar()
            Else
                cmdCancelar.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdODA_Click(sender As System.Object, e As System.EventArgs) Handles cmdODA.Click
        Try
            vl_sCodDocBas = "ODA"
            wl_sCodDocBas = vl_sCodDocBas
            txtsCodDocBas.Text = vl_sCodDocBas
            txtsCodDocBas1.Text = vl_sCodDocBas
            Plo_HabOP()

        Catch ex As Exception
            MsgBox("Error : cmdODA_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdODP_Click(sender As System.Object, e As System.EventArgs) Handles cmdODP.Click
        Try
            vl_sCodDocBas = "ODP"
            wl_sCodDocBas = vl_sCodDocBas
            txtsCodDocBas.Text = vl_sCodDocBas
            txtsCodDocBas1.Text = vl_sCodDocBas
            Plo_HabOP()
            'cmdTecOP.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdODP_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdODR_Click(sender As System.Object, e As System.EventArgs) Handles cmdODR.Click
        Try
            vl_sCodDocBas = "ODR"
            wl_sCodDocBas = vl_sCodDocBas
            txtsCodDocBas.Text = vl_sCodDocBas
            txtsCodDocBas1.Text = vl_sCodDocBas
            Plo_HabOP()
            'cmdTecOP.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdODR_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOPE_Click(sender As System.Object, e As System.EventArgs) Handles cmdOPE.Click
        Try
            vl_sCodDocBas = "OPE"
            wl_sCodDocBas = vl_sCodDocBas
            txtsCodDocBas.Text = vl_sCodDocBas
            txtsCodDocBas1.Text = vl_sCodDocBas
            Plo_HabOP()
            'cmdTecOP.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdOPE_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec01_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec01.Click
        Try
            Dim wl_frmPEROD_Sec01 As New frmPEROD_Sec01
            vl_sCodCtr = "01"
            BD_BuscarATCTR()
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            wl_frmPEROD_Sec01.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec01.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec01.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec01.wg_sNomOpe
            cmdCancelar.Focus()

        Catch ex As Exception
            MsgBox("Error : cmdSec01_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec02_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec02.Click
        Try
            Dim wl_frmPEROD_Sec02 As New frmPEROD_Sec02
            vl_sCodCtr = "02"
            BD_BuscarATCTR()
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            wl_frmPEROD_Sec02.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec02.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec02.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec02.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec02_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec03_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec03.Click
        Try
            Dim wl_frmPEROD_Sec03 As New frmPEROD_Sec03
            vl_sCodCtr = "03"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec03.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec03.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec03.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec03.wg_sNomOpe
            cmdCancelar.Focus()

        Catch ex As Exception
            MsgBox("Error : cmdSec03_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec04_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec04.Click
        Try
            Dim wl_frmPEROD_Sec04 As New frmPEROD_Sec04
            vl_sCodCtr = "04"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec04.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec04.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec04.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec04.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec04_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec05_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec05.Click
        Try
            Dim wl_frmPEROD_Sec05 As New frmPEROD_Sec05
            vl_sCodCtr = "05"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec05.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec05.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec05.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec05.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec05_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec06_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec06.Click
        Try
            Dim wl_frmPEROD_Sec06 As New frmPEROD_Sec06
            vl_sCodCtr = "06"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec06.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec06.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec06.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec06.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec06_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec07_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec07.Click
        Try
            Dim wl_frmPEROD_Sec07 As New frmPEROD_Sec07
            vl_sCodCtr = "07"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec07.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec07.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec07.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec07.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec07_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec08_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec08.Click
        Try
            Dim wl_frmPEROD_Sec08 As New frmPEROD_Sec08
            vl_sCodCtr = "08"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec08.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec08.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec08.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec08.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec08_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec09_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec09.Click
        Try
            Dim wl_frmPEROD_Sec09 As New frmPEROD_Sec09
            vl_sCodCtr = "09"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec09.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec09.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec09.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec09.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec09_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec10_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec10.Click
        Try
            Dim wl_frmPEROD_Sec10 As New frmPEROD_Sec10
            vl_sCodCtr = "10"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec10.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec10.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec10.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec10.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec10_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec14_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec14.Click
        Try
            Dim wl_frmPEROD_Sec14 As New frmPEROD_Sec14
            vl_sCodCtr = "14"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec14.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec14.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec14.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec14.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec14_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec15_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec15.Click
        Try
            Dim wl_frmPEROD_Sec15 As New frmPEROD_Sec15
            vl_sCodCtr = "15"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec15.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec15.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec15.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec15.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec15_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec16_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec16.Click
        Try
            Dim wl_frmPEROD_Sec16 As New frmPEROD_Sec16
            vl_sCodCtr = "16"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec16.wg_aePLODP2 = wl_aePLODP2
            wl_frmPEROD_Sec16.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec16.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec16.wg_sNomOpe
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdSec16_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSec99_Click(sender As System.Object, e As System.EventArgs) Handles cmdSec99.Click
        Try
            Dim wl_frmPEROD_Sec99 As New frmPEROD_Sec99
            vl_sCodCtr = "99"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            BD_BuscarATCTR()
            wl_frmPEROD_Sec99.ShowDialog()
            txtsCodOpe.Text = wl_frmPEROD_Sec99.wg_sCodOpe
            txtsNomOpe.Text = wl_frmPEROD_Sec99.wg_sNomOpe
            cmdCancelar.Focus()

        Catch ex As Exception
            MsgBox("Error : cmdSec99_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdTecOP_Click(sender As System.Object, e As System.EventArgs) Handles cmdTecOP.Click
        Try
            vl_nNroDocBas = 0
            Plo_IniciarVar()
            Dim wl_frmPEROD_TecNum As New frmPEROD_TecNum
            wl_frmPEROD_TecNum.Text = "Número de la Orden de Producción"
            wl_frmPEROD_TecNum.ShowDialog()
            txtsCodDocBas.Text = vl_sCodDocBas
            vl_nNroDocBas = CLng(wl_frmPEROD_TecNum.wg_nNroEnt)
            txtnNroDocBas.Text = CLng(wl_frmPEROD_TecNum.wg_nNroEnt)
            If vl_nNroDocBas <> 0 Then
                Plo_TxtnNroDocKeyUp()
                Plo_Var_ePEODP()
            End If
            ' txtnNroDocBas.Focus()
            
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdTecOpe_Click")
        End Try
    End Sub
#End Region
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_CalTie()
        Try
            ' Operativas
            wl_nHHIni = vl_nHHIniOpe
            wl_nMMIni = vl_nMMIniOpe
            wl_nHHFin = vl_nHHFinOpe
            wl_nMMFin = vl_nMMFinOpe
            wl_nHHCns = vl_nHHCnsOpe
            wl_nMMCns = vl_nMMCnsOpe
            wl_nTieCns = vl_nTieCnsOpe
            mof_fCalTie(wl_nHHIni,
                        wl_nMMIni,
                        wl_nHHFin,
                        wl_nMMFin,
                        wl_nHHCns,
                        wl_nMMCns,
                        wl_nTieCns)
            vl_nHHCnsOpe = wl_nHHCns
            vl_nMMCnsOpe = wl_nMMCns
            vl_nTieCnsOpe = wl_nTieCns
            'Almuerzo
            wl_nHHIni = vl_nHHIniAlz
            wl_nMMIni = vl_nMMIniAlz
            wl_nHHFin = vl_nHHFinAlz
            wl_nMMFin = vl_nMMFinAlz
            wl_nHHCns = vl_nHHCnsAlz
            wl_nMMCns = vl_nMMCnsAlz
            wl_nTieCns = vl_nTieCnsAlz
            mof_fCalTie(wl_nHHIni,
                        wl_nMMIni,
                        wl_nHHFin,
                        wl_nMMFin,
                        wl_nHHCns,
                        wl_nMMCns,
                        wl_nTieCns)
            vl_nHHCnsAlz = wl_nHHCns
            vl_nMMCnsAlz = wl_nMMCns
            vl_nTieCnsAlz = wl_nTieCns
            'Cafeteria
            wl_nHHIni = vl_nHHIniCaf
            wl_nMMIni = vl_nMMIniCaf
            wl_nHHFin = vl_nHHFinCaf
            wl_nMMFin = vl_nMMFinCaf
            wl_nHHCns = vl_nHHCnsCaf
            wl_nMMCns = vl_nMMCnsCaf
            wl_nTieCns = vl_nTieCnsCaf
            mof_fCalTie(wl_nHHIni,
                        wl_nMMIni,
                        wl_nHHFin,
                        wl_nMMFin,
                        wl_nHHCns,
                        wl_nMMCns,
                        wl_nTieCns)
            vl_nHHCnsCaf = wl_nHHCns
            vl_nMMCnsCaf = wl_nMMCns
            vl_nTieCnsCaf = wl_nTieCns
            'Total Consumo Ope - Alz
            wl_nHHIni = vl_nHHCnsAlz
            wl_nMMIni = vl_nMMCnsAlz
            wl_nHHFin = vl_nHHCnsOpe
            wl_nMMFin = vl_nMMCnsOpe
            wl_nHHCns = vl_nHHCns
            wl_nMMCns = vl_nMMCns
            wl_nTieCns = vl_nTieCns
            mof_fCalTie(wl_nHHIni,
                        wl_nMMIni,
                        wl_nHHFin,
                        wl_nMMFin,
                        wl_nHHCns,
                        wl_nMMCns,
                        wl_nTieCns)

            vl_nHHCns = wl_nHHCns
            vl_nMMCns = wl_nMMCns
            vl_nTieCns = wl_nTieCns
            'Total Consumo Ope - Caf
            wl_nHHIni = vl_nHHCnsCaf
            wl_nMMIni = vl_nMMCnsCaf
            wl_nHHFin = vl_nHHCns
            wl_nMMFin = vl_nMMCns
            wl_nHHCns = vl_nHHCns
            wl_nMMCns = vl_nMMCns
            wl_nTieCns = vl_nTieCns
            mof_fCalTie(wl_nHHIni,
                        wl_nMMIni,
                        wl_nHHFin,
                        wl_nMMFin,
                        wl_nHHCns,
                        wl_nMMCns,
                        wl_nTieCns)
            vl_nHHCns = wl_nHHCns
            vl_nMMCns = wl_nMMCns
            vl_nTieCns = wl_nTieCns

            vl_nTotLin = vl_nPreUni * vl_nTieCns

            vl_nTotHHCns = vl_nHHCns
            vl_nTotMMCns = vl_nMMCns
            vl_nTotTieCns = vl_nTieCns
            vl_nTotDoc = vl_nTotLin
            vl_nTotHHOpe = vl_nHHCnsOpe
            vl_nTotMMOpe = vl_nMMCnsOpe
            vl_nTotTieOpe = vl_nTieCnsOpe
            vl_nTotHHAlz = vl_nHHCnsAlz
            vl_nTotMMAlz = vl_nMMCnsAlz
            vl_nTotTieAlz = vl_nTieCnsAlz
            vl_nTotHHCaf = vl_nHHCnsCaf
            vl_nTotMMCaf = vl_nMMCnsCaf
            vl_nTotTieCaf = vl_nTieCnsCaf


        Catch ex As Exception
            MsgBox("Error :  Plo_CalTie")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabCmd()
        Try
            If wl_sOpc = "A" Then
                LblAlz.BackColor = Color.DarkSeaGreen
                Plo_InHabOP()
                Plo_InHabCmdOP()
                cmdSec99.BackColor = Color.Gainsboro
                cmdSec99.Enabled = False
            End If
            If wl_sOpc = "D" Then
                lblCaf.BackColor = Color.DarkSeaGreen
                Plo_InHabOP()
                Plo_InHabCmdOP()
                cmdSec99.BackColor = Color.Gainsboro
                cmdSec99.Enabled = False
            End If
            If wl_sOpc = "N" Then
                lblTrabajo.BackColor = Color.DarkSeaGreen
                Plo_InHabOP()
                Plo_InHabCmdOP()
                cmdSec99.BackColor = Color.Thistle
                cmdSec99.Enabled = True
                If wl_bIniciar = True Then
                    cmdSec99.PerformClick()
                End If
                cmdCancelar.Enabled = True
            End If
            If wl_sOpc = "O" Then
                lblTrabajo.BackColor = Color.DarkSeaGreen
                Plo_HabCmdOP()
                Plo_InHabOP()
                Plo_InHabSec()
                cmdSec99.BackColor = Color.Gainsboro
                cmdSec99.Enabled = False
            End If
            If wl_bIniciar = True Then
                Plo_InHabSec()
                cmdIniciar.Visible = True
                cmdIniciar.Enabled = False
                cmdTerminar.Visible = False
            End If
            If wl_bTerminar = True Then
                Plo_InHabCmdOP()
                Plo_InHabSec()
                cmdSec99.BackColor = Color.Gainsboro
                cmdSec99.Enabled = False
                cmdIniciar.Visible = False
                cmdTerminar.Visible = True
                cmdTerminar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_HabCmd")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_HabCmdOP()
        Try
            cmdODP.BackColor = Color.Thistle
            cmdODA.BackColor = Color.Thistle
            cmdOPE.BackColor = Color.Thistle
            cmdODR.BackColor = Color.Thistle
            cmdODP.Enabled = True
            cmdODA.Enabled = True
            cmdOPE.Enabled = True
            cmdODR.Enabled = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabCmdOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabOP()
        Try

            'txtnNroDocBas.Enabled = True
            cmdTecOP.Enabled = True
            cmdTecOP.PerformClick()
        Catch ex As Exception
            MsgBox("Error : Plo_HabOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabSec()
        Try
            Dim wl_nI As Long
            If wl_DT1 IsNot Nothing Then
                wl_nCntReg = wl_DT1.Rows.Count - 1
            Else
                wl_nCntReg = -1
            End If
            For wl_nI = 0 To wl_nCntReg
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "01" Then
                    cmdSec01.BackColor = Color.Thistle
                    cmdSec01.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "02" Then
                    cmdSec02.BackColor = Color.Thistle
                    cmdSec02.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "03" Then
                    cmdSec03.BackColor = Color.Thistle
                    cmdSec03.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "04" Then
                    cmdSec04.BackColor = Color.Thistle
                    cmdSec04.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "05" Then
                    cmdSec05.BackColor = Color.Thistle
                    cmdSec05.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "06" Then
                    cmdSec06.BackColor = Color.Thistle
                    cmdSec06.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "07" Then
                    cmdSec07.BackColor = Color.Thistle
                    cmdSec07.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "08" Then
                    cmdSec08.BackColor = Color.Thistle
                    cmdSec08.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "09" Then
                    cmdSec09.BackColor = Color.Thistle
                    cmdSec09.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "10" Then
                    cmdSec10.BackColor = Color.Thistle
                    cmdSec10.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "14" Then
                    cmdSec14.BackColor = Color.Thistle
                    cmdSec14.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "15" Then
                    cmdSec15.BackColor = Color.Thistle
                    cmdSec15.Enabled = True
                End If
                If Trim(wl_aePLODP2(wl_nI).sCodCtr) = "16" Then
                    cmdSec16.BackColor = Color.Thistle
                    cmdSec16.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabSec")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabCmdOP()
        Try
            cmdODP.BackColor = Color.Gainsboro
            cmdODA.BackColor = Color.Gainsboro
            cmdOPE.BackColor = Color.Gainsboro
            cmdODR.BackColor = Color.Gainsboro
            cmdODP.Enabled = False
            cmdODA.Enabled = False
            cmdOPE.Enabled = False
            cmdODR.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabOP()
        Try
            ' txtnNroDocBas.Enabled = False
            cmdTecOP.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabSec()
        Try
            cmdSec01.BackColor = Color.Gainsboro
            cmdSec02.BackColor = Color.Gainsboro
            cmdSec03.BackColor = Color.Gainsboro
            cmdSec04.BackColor = Color.Gainsboro
            cmdSec05.BackColor = Color.Gainsboro
            cmdSec06.BackColor = Color.Gainsboro
            cmdSec07.BackColor = Color.Gainsboro
            cmdSec08.BackColor = Color.Gainsboro
            cmdSec09.BackColor = Color.Gainsboro
            cmdSec10.BackColor = Color.Gainsboro
            cmdSec14.BackColor = Color.Gainsboro
            cmdSec15.BackColor = Color.Gainsboro
            cmdSec16.BackColor = Color.Gainsboro
            cmdSec01.Enabled = False
            cmdSec02.Enabled = False
            cmdSec03.Enabled = False
            cmdSec04.Enabled = False
            cmdSec05.Enabled = False
            cmdSec06.Enabled = False
            cmdSec07.Enabled = False
            cmdSec08.Enabled = False
            cmdSec09.Enabled = False
            cmdSec10.Enabled = False
            cmdSec14.Enabled = False
            cmdSec15.Enabled = False
            cmdSec16.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_HabCmd")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            wp_sCmdSel = ""
            vl_sCodDoc = "ROK"
            vl_sCodSer = "RO"
            vl_nNroDoc = 0
            vl_sTipMov = "S"
            vl_sEstDoc = "A"
            vl_dFecCtb = vg_dFecDoc
            vl_dFecDoc = vg_dFecDoc
            vl_dFecVto = vg_dFecDoc
            vl_dFecSys = vg_dFecDoc
            ' Revisar la fecha
            wl_sHorSys = txtdHHMM.Text
            wl_sHorSys = vg_sHorSys
            vl_sCodTer = vg_sCodTer
            vl_sNomTer = vg_sNomTer
            vl_sDocRef = ""
            vl_sCodCte = ""
            vl_nNroCte = 0
            vl_nIdFECCT = 0
            vl_sNitTer = 0
            vl_sTipDoc = ""
            wl_nHH = 0
            wl_nMM = 0
            vl_sCodItm = ""
            vl_nCanItm = 0
            vl_sCodOpe = ""
            vl_sNomOpe = ""
            vl_sCodCco = ""
            vl_nLinBas = 0
            vl_sCodPdo = ""
            vl_sCodCta = ""
            vl_sCtaCosVta = ""
            vl_sClsDoc = "DP"
            vl_sCodCtr = ""
            vl_nHHIniOpe = 0
            vl_nMMIniOpe = 0
            vl_nHHFinOpe = 0
            vl_nMMFinOpe = 0
            vl_nHHCnsOpe = 0
            vl_nMMCnsOpe = 0
            vl_nTieCnsOpe = 0
            vl_nHHIniAlz = 0
            vl_nMMIniAlz = 0
            vl_nHHFinAlz = 0
            vl_nMMFinAlz = 0
            vl_nHHCnsAlz = 0
            vl_nMMCnsAlz = 0
            vl_nTieCnsAlz = 0
            vl_nHHIniCaf = 0
            vl_nMMIniCaf = 0
            vl_nHHFinCaf = 0
            vl_nMMFinCaf = 0
            vl_nHHCnsCaf = 0
            vl_nMMCnsCaf = 0
            vl_nTieCnsCaf = 0
            mof_fCnvHorSys(wl_sHorSys,
                           wl_nHH,
                           wl_nMM)
            wl_sOpc = wg_sOpc
            wl_sCodDoc = ""
            wl_sCodDocBas = ""
            wl_bAbrirReg = wg_bAbrirReg
            wl_bCerrarReg = wg_bCerrarReg
            wl_bIniciar = wg_bIniciar
            wl_bTerminar = wg_bTerminar
            wl_bRegNue = wg_bRegNue
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            If wl_bRegNue = False Then
                wp_sCmdSel = "A"
                wl_ePEROP = wg_ePEROP
                wl_ePLROP1 = wg_ePLROP1
                vl_nNroDoc = wg_ePEROP.nNroDoc
                'txtnNroDocBas.Enabled = False
                Plo_Var_ePLROP1()
            Else
                wp_sCmdSel = "C"
                vl_nNroDocBas = 0
                vl_nPreUni = 0
                vl_sCodOpe = ""
                txtsCodDocBas.Text = ""
                txtnNroDocBas.Text = ""
                txtsCodter.Text = vl_sCodTer
                txtsNomTer.Text = vl_sNomTer
                txtdFecDoc.Text = vl_dFecDoc
            End If
            If wl_sOpc = "O" Or wl_sOpc = "N" Then
                If wl_bIniciar = True Then
                    txtnHHIniOpe.Text = wl_nHH
                    txtnMMIniOpe.Text = wl_nMM
                End If
                If wl_bTerminar = True Then
                    txtnHHFinOpe.Text = wl_nHH
                    txtnMMFinOpe.Text = wl_nMM
                End If

            End If
            If wl_sOpc = "A" Then
                If wl_bIniciar = True Then
                    txtnHHIniAlz.Text = wl_nHH
                    txtnMMIniAlz.Text = wl_nMM
                End If
                If wl_bTerminar = True Then
                    txtnHHFinAlz.Text = wl_nHH
                    txtnMMFinAlz.Text = wl_nMM
                End If

            End If
            If wl_sOpc = "D" Then
                If wl_bIniciar = True Then
                    txtnHHIniCaf.Text = wl_nHH
                    txtnMMIniCaf.Text = wl_nMM
                End If
                If wl_bTerminar = True Then
                    txtnHHFinCaf.Text = wl_nHH
                    txtnMMFinCaf.Text = wl_nMM
                End If

            End If
            mof_fCalTie(wl_nHHIni,
                        wl_nMMIni,
                        wl_nHHFin,
                        wl_nMMFin,
                        wl_nHHCns,
                        wl_nMMCns,
                        wl_nTieCns)

            '           Plo_InHabSec()

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_TxtnNroDocKeyUp()
        Try
            Plo_InHabSec()
            If txtnNroDocBas.Text = "" Or txtnNroDocBas.Text = " " Then
                txtnNroDocBas.Text = 0
            End If
            vl_nNroDocBas = txtnNroDocBas.Text
            BD_BuscarPEODP()
            If wr_bEOFE1 Then
                MsgBox(vl_sCodDocBas & " " & vl_nNroDocBas & " - NO EXISTE")
                cmdTecOP.PerformClick()
            Else
                Select Case wl_ePEODP.sEstOdp
                    Case "3"
                        MsgBox(vl_sCodDocBas & " " & vl_nNroDocBas & " - CERRADA")
                        cmdTecOP.PerformClick()
                    Case "4"
                        MsgBox(vl_sCodDocBas & " " & vl_nNroDocBas & " - ANULADA")
                        cmdTecOP.PerformClick()
                    Case Else
                        BD_BuscarPLODP2()
                        Plo_InHabCmdOP()
                        txtnNroDocBas1.Text = wl_ePEODP.nNroDoc
                        txtsCodItm.Text = wl_ePEODP.sCodItm
                        txtsNomItm.Text = wl_ePEODP.sNomItm
                        txtsCodCtr.Text = ""
                        txtsNomCtr.Text = ""
                        txtsCodOpe.Text = ""
                        txtsNomOpe.Text = ""
                        Plo_Var_frm()
                        Plo_HabSec()
                End Select
            End If
            cmdCancelar.Focus()
            'txtnNroDocBas.Focus()

        Catch ex As Exception
            MsgBox("Error :  Plo_TxtnNroDocKeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePEROP_Var()
        Try
            wl_ePEROP.nId = vl_nId
            wl_ePEROP.sCodDoc = vl_sCodDoc
            wl_ePEROP.sCodSer = vl_sCodSer
            wl_ePEROP.nNroDoc = vl_nNroDoc
            wl_ePEROP.sTipMov = vl_sTipMov
            wl_ePEROP.sEstDoc = vl_sEstDoc
            wl_ePEROP.dFecCtb = vl_dFecCtb
            wl_ePEROP.dFecDoc = vl_dFecDoc
            wl_ePEROP.dFecVto = vl_dFecVto
            wl_ePEROP.dFecSys = vl_dFecSys
            wl_ePEROP.sCodTer = vl_sCodTer
            wl_ePEROP.sNomTer = vl_sNomTer
            wl_ePEROP.sDocRef = vl_sDocRef
            wl_ePEROP.nTotHHCns = vl_nTotHHCns
            wl_ePEROP.nTotMMCns = vl_nTotMMCns
            wl_ePEROP.nTotTieCns = vl_nTotTieCns
            wl_ePEROP.nTotDoc = vl_nTotDoc
            wl_ePEROP.sCodCte = vl_sCodCte
            wl_ePEROP.nNroCte = vl_nNroCte
            wl_ePEROP.sClsDoc = vl_sClsDoc
            wl_ePEROP.sCmn = vl_sCmn
            wl_ePEROP.sCodCteCtb = vl_sCodCteCtb
            wl_ePEROP.nNroCteCtb = vl_nNroCteCtb
            wl_ePEROP.nIdFECCT = vl_nIdFECCT
            wl_ePEROP.sNitTer = vl_sNitTer
            wl_ePEROP.sTipDoc = vl_sTipDoc
            wl_ePEROP.sCodUsr = vl_sCodUsr
            wl_ePEROP.bPrp01 = vl_bPrp01
            wl_ePEROP.bPrp02 = vl_bPrp02
            wl_ePEROP.bPrp03 = vl_bPrp03
            wl_ePEROP.nTotHHOpe = vl_nTotHHOpe
            wl_ePEROP.nTotMMOpe = vl_nTotMMOpe
            wl_ePEROP.nTotTieOpe = vl_nTotTieOpe
            wl_ePEROP.nTotHHAlz = vl_nTotHHAlz
            wl_ePEROP.nTotMMAlz = vl_nTotMMAlz
            wl_ePEROP.nTotTieAlz = vl_nTotTieAlz
            wl_ePEROP.nTotHHCaf = vl_nTotHHCaf
            wl_ePEROP.nTotMMCaf = vl_nTotMMCaf
            wl_ePEROP.nTotTieCaf = vl_nTotTieCaf

        Catch ex As Exception
            MsgBox("Error : Plo_ePLROP1_VarfrmPEROD_Sec")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePLROP1_Var()
        Try
            wl_ePLROP1.sCodDoc = vl_sCodDoc
            wl_ePLROP1.nNroDoc = vl_nNroDoc
            wl_ePLROP1.nIdPEROP = vl_nId
            wl_ePLROP1.sCodSer = vl_sCodSer
            wl_ePLROP1.sTipMov = vl_sTipMov
            wl_ePLROP1.sCodDocBas = vl_sCodDocBas
            wl_ePLROP1.sCodSerBas = vl_sCodSerBas
            wl_ePLROP1.nNroDocBas = vl_nNroDocBas
            wl_ePLROP1.sCodItm = vl_sCodItm
            wl_ePLROP1.nCanItm = vl_nCanItm
            wl_ePLROP1.sCodOpe = vl_sCodOpe
            wl_ePLROP1.sNomOpe = vl_sNomOpe
            wl_ePLROP1.sClsDoc = vl_sClsDoc
            wl_ePLROP1.nHHIniOpe = vl_nHHIniOpe
            wl_ePLROP1.nMMIniOpe = vl_nMMIniOpe
            wl_ePLROP1.nHHFinOpe = vl_nHHFinOpe
            wl_ePLROP1.nMMFinOpe = vl_nMMFinOpe
            wl_ePLROP1.nHHCnsOpe = vl_nHHCnsOpe
            wl_ePLROP1.nMMCnsOpe = vl_nMMCnsOpe
            wl_ePLROP1.nTieCnsOpe = vl_nTieCnsOpe
            wl_ePLROP1.nHHCns = vl_nHHCns
            wl_ePLROP1.nMMCns = vl_nMMCns
            wl_ePLROP1.nTieCns = vl_nTieCns
            wl_ePLROP1.nTieReq = vl_nTieReq
            wl_ePLROP1.nPreUni = vl_nPreUni
            wl_ePLROP1.nTotLin = vl_nTotLin
            wl_ePLROP1.sCodCco = vl_sCodCco
            wl_ePLROP1.nLinBas = vl_nLinBas
            wl_ePLROP1.sCodPdo = vl_sCodPdo
            wl_ePLROP1.sCodCta = vl_sCodCta
            wl_ePLROP1.sCtaCosVta = vl_sCtaCosVta
            wl_ePLROP1.bItmBlq = vl_bItmBlq
            wl_ePLROP1.nCanOpeTer = vl_nCanOpeTer
            wl_ePLROP1.sCodCtr = vl_sCodCtr
            wl_ePLROP1.nHHIniAlz = vl_nHHIniAlz
            wl_ePLROP1.nMMIniAlz = vl_nMMIniAlz
            wl_ePLROP1.nHHFinAlz = vl_nHHFinAlz
            wl_ePLROP1.nMMFinAlz = vl_nMMFinAlz
            wl_ePLROP1.nHHCnsAlz = vl_nHHCnsAlz
            wl_ePLROP1.nMMCnsAlz = vl_nMMCnsAlz
            wl_ePLROP1.nTieCnsAlz = vl_nTieCnsAlz
            wl_ePLROP1.nHHIniCaf = vl_nHHIniCaf
            wl_ePLROP1.nMMIniCaf = vl_nMMIniCaf
            wl_ePLROP1.nHHFinCaf = vl_nHHFinCaf
            wl_ePLROP1.nMMFinCaf = vl_nMMFinCaf
            wl_ePLROP1.nHHCnsCaf = vl_nHHCnsCaf
            wl_ePLROP1.nMMCnsCaf = vl_nMMCnsCaf
            wl_ePLROP1.nTieCnsCaf = vl_nTieCnsCaf
        Catch ex As Exception
            MsgBox("Error : Plo_ePLROP1_VarfrmPEROD_Sec")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_Var_ePEODP()
        Try

            If wl_ePEROP.sCodDoc <> Nothing Then
                vl_sCodDocBas = wl_ePEODP.sCodDoc
                vl_sCodSerBas = wl_ePEODP.sCodSer
                vl_nNroDocBas = wl_ePEODP.nNroDoc
                vl_sCodItm = wl_ePEODP.sCodItm
                vl_nCanItm = wl_ePEODP.nCanOdp
            End If

        Catch ex As Exception
            MsgBox("Error :  Plo_Var_ePEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_Var_frm()
        Try
            vl_sCodOpe = txtsCodOpe.Text
            vl_sNomOpe = txtsNomOpe.Text
            vl_sCodCtr = txtsCodCtr.Text

            vl_nHHIniOpe = Val(txtnHHIniOpe.Text)
            vl_nMMIniOpe = Val(txtnMMIniOpe.Text)
            vl_nHHFinOpe = Val(txtnHHFinOpe.Text)
            vl_nMMFinOpe = Val(txtnMMFinOpe.Text)
            vl_nHHCnsOpe = Val(txtnHHCnsOpe.Text)
            vl_nMMCnsOpe = Val(txtnMMCnsOpe.Text)
            vl_nTieCnsOpe = Val(txtnTieCnsOpe.Text)

            vl_nHHIniAlz = Val(txtnHHIniAlz.Text)
            vl_nMMIniAlz = Val(txtnMMIniAlz.Text)
            vl_nHHFinAlz = Val(txtnHHFinAlz.Text)
            vl_nMMFinAlz = Val(txtnMMFinAlz.Text)
            vl_nHHCnsAlz = Val(txtnHHCnsAlz.Text)
            vl_nMMCnsAlz = Val(txtnMMCnsAlz.Text)
            vl_nTieCnsAlz = Val(txtnTieCnsAlz.Text)

            vl_nHHIniCaf = Val(txtnHHIniCaf.Text)
            vl_nMMIniCaf = Val(txtnMMIniCaf.Text)
            vl_nHHFinCaf = Val(txtnHHFinCaf.Text)
            vl_nMMFinCaf = Val(txtnMMFinCaf.Text)
            vl_nHHCnsCaf = Val(txtnHHCnsCaf.Text)
            vl_nMMCnsCaf = Val(txtnMMCnsCaf.Text)
            vl_nTieCnsCaf = Val(txtnTieCnsCaf.Text)

            vl_sCodItm = txtsCodItm.Text
            vl_sCodOpe = txtsCodOpe.Text
            vl_sNomOpe = txtsNomOpe.Text



        Catch ex As Exception
            MsgBox("Error : PLo_Var_frm")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_VdaDat()
        Try
            ' Vda OP
            If wg_sOpc = "O" Then
                Plo_VdaOpe()
            Else
                If wg_sOpc = "N" Then
                    Plo_VdaNoOpe()
                Else
                    If wg_sOpc = "A" Then
                        Plo_VdaAlz()
                    Else
                        Plo_VdaCaf()

                    End If
                End If
            End If



        Catch ex As Exception
            MsgBox("Error : Plo_VdaDat")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaAlz()
        Try
            If wl_bIniciar = True Then

            End If


        Catch ex As Exception
            MsgBox("Error : Plo_VdaAlz")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaCaf()
        Try



        Catch ex As Exception
            MsgBox("Error : Plo_VdaCaf")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaNoOpe()
        Try


            If vl_sCodOpe = "" Then
                wl_bVda = False
                MsgBox("Debe Seleccionar una Actividad No Operativa")
                cmdCancelar.Focus()
            Else
                wl_bVda = True
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_VdaNoOpe")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaOpe()
        Try
            If vl_nNroDocBas < 1 Then
                wl_bVda = False
                MsgBox("Debe digitar el Nro de la OP")
                cmdTecOP.Focus()
            Else
                If vl_sCodCtr = "" Then
                    wl_bVda = False
                    MsgBox("Debe Seleccionar una Sección")
                    cmdCancelar.Focus()
                Else
                    If vl_sCodOpe = "" Then
                        wl_bVda = False
                        MsgBox("Debe Seleccionar una Operación")
                        cmdCancelar.Focus()
                    Else
                        wl_bVda = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_VdaOpe")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaCerDoc()
        Try
            wl_bDocCrd = False
            If vl_nHHFinOpe <> 0 Or vl_nMMFinOpe <> 0 Then
                vl_sEstDoc = "C"
                wl_bDocCrd = True
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_VdaCerDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_Var_ePLROP1()
        Try
            txtsCodDocBas.Text = wl_ePLROP1.sCodDocBas
            txtnNroDocBas.Text = wl_ePLROP1.nNroDocBas
            txtsCodter.Text = wl_ePEROP.sCodTer
            txtsNomTer.Text = wl_ePEROP.sNomTer
            txtdFecDoc.Text = wl_ePEROP.dFecDoc
            txtsCodDocBas1.Text = wl_ePLROP1.sCodDocBas
            txtnNroDocBas1.Text = wl_ePLROP1.nNroDocBas
            txtsCodItm.Text = wl_ePLROP1.sCodItm
            vl_nCanItm = wl_ePLROP1.nCanItm
            'txtsNomItm.Text = wl_ePLROP1.sNomItm
            txtsCodCtr.Text = wl_ePLROP1.sCodCtr
            txtsCodOpe.Text = wl_ePLROP1.sCodOpe
            txtsNomOpe.Text = wl_ePLROP1.sNomOpe
            txtnHHIniOpe.Text = wl_ePLROP1.nHHIniOpe
            txtnMMIniOpe.Text = wl_ePLROP1.nMMIniOpe
            txtnHHFinOpe.Text = wl_ePLROP1.nHHFinOpe
            txtnMMFinOpe.Text = wl_ePLROP1.nMMFinOpe
            txtnHHCnsOpe.Text = wl_ePLROP1.nHHCnsOpe
            txtnMMCnsOpe.Text = wl_ePLROP1.nMMCnsOpe
            txtnTieCnsOpe.Text = wl_ePLROP1.nTieCnsOpe

            txtnHHIniAlz.Text = wl_ePLROP1.nHHIniAlz
            txtnMMIniAlz.Text = wl_ePLROP1.nMMIniAlz
            txtnHHFinAlz.Text = wl_ePLROP1.nHHFinAlz
            txtnMMFinAlz.Text = wl_ePLROP1.nMMFinAlz
            txtnHHCnsAlz.Text = wl_ePLROP1.nHHCnsAlz
            txtnMMCnsAlz.Text = wl_ePLROP1.nMMCnsAlz
            txtnTieCnsAlz.Text = wl_ePLROP1.nTieCnsAlz

            txtnHHIniCaf.Text = wl_ePLROP1.nHHIniCaf
            txtnMMIniCaf.Text = wl_ePLROP1.nMMIniCaf
            txtnHHFinCaf.Text = wl_ePLROP1.nHHFinCaf
            txtnMMFinCaf.Text = wl_ePLROP1.nMMFinCaf
            txtnHHCnsCaf.Text = wl_ePLROP1.nHHCnsCaf
            txtnMMCnsCaf.Text = wl_ePLROP1.nMMCnsCaf
            txtnTieCnsCaf.Text = wl_ePLROP1.nTieCnsCaf

            vl_nId = wl_ePEROP.nId
            vl_sCodDocBas = wl_ePLROP1.sCodDocBas
            vl_sCodSerBas = wl_ePLROP1.sCodSerBas
            vl_nNroDocBas = wl_ePLROP1.nNroDocBas
            vl_sCodItm = wl_ePLROP1.sCodItm
            vl_nCanItm = wl_ePLROP1.nCanItm
            vl_sCodOpe = wl_ePLROP1.sCodOpe
            vl_sNomOpe = wl_ePLROP1.sNomOpe
            vl_nHHIniOpe = wl_ePLROP1.nHHIniOpe
            vl_nMMIniOpe = wl_ePLROP1.nMMIniOpe
            vl_nHHFinOpe = wl_ePLROP1.nHHFinOpe
            vl_nMMFinOpe = wl_ePLROP1.nMMFinOpe
            vl_nHHCnsOpe = wl_ePLROP1.nHHCnsOpe
            vl_nMMCnsOpe = wl_ePLROP1.nMMCnsOpe
            vl_nTieCnsOpe = wl_ePLROP1.nTieCnsOpe
            vl_nHHCns = wl_ePLROP1.nHHCns
            vl_nMMCns = wl_ePLROP1.nMMCns
            vl_nTieCns = wl_ePLROP1.nTieCns

            vl_nTieReq = wl_ePLROP1.nTieReq
            vl_nPreUni = wl_ePLROP1.nPreUni
            vl_nTotLin = wl_ePLROP1.nTotLin
            vl_sCodCco = wl_ePLROP1.sCodCco
            vl_nLinBas = wl_ePLROP1.nLinBas
            vl_sCodPdo = wl_ePLROP1.sCodPdo
            vl_sCodCta = wl_ePLROP1.sCodCta
            vl_sCtaCosVta = wl_ePLROP1.sCtaCosVta
            vl_bItmBlq = wl_ePLROP1.bItmBlq
            vl_nCanOpeTer = wl_ePLROP1.nCanOpeTer
            vl_sCodCtr = wl_ePLROP1.sCodCtr
            vl_nHHIniAlz = wl_ePLROP1.nHHIniAlz
            vl_nMMIniAlz = wl_ePLROP1.nMMIniAlz
            vl_nHHFinAlz = wl_ePLROP1.nHHFinAlz
            vl_nMMFinAlz = wl_ePLROP1.nMMFinAlz
            vl_nHHCnsAlz = wl_ePLROP1.nHHCnsAlz
            vl_nMMCnsAlz = wl_ePLROP1.nMMCnsAlz
            vl_nTieCnsAlz = wl_ePLROP1.nTieCnsAlz

            vl_nHHIniCaf = wl_ePLROP1.nHHIniCaf
            vl_nMMIniCaf = wl_ePLROP1.nMMIniCaf
            vl_nHHFinCaf = wl_ePLROP1.nHHFinCaf
            vl_nMMFinCaf = wl_ePLROP1.nMMFinCaf
            vl_nHHCnsCaf = wl_ePLROP1.nHHCnsCaf
            vl_nMMCnsCaf = wl_ePLROP1.nMMCnsCaf
            vl_nTieCnsCaf = wl_ePLROP1.nTieCnsCaf
        Catch ex As Exception
            MsgBox("Error : Plo_VarfrmPEROD_Sec_ePLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            txtdHHMM.Text = TimeString.ToString
        Catch ex As Exception
            MsgBox("Error :  Timer1_Tick")
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub PloNroSig_APEND()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = vl_nNroDoc + 1

            wg_sNomTblE2 = "APEND"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = wl_ePEROP.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_ePEROP.sCodSer
            wg_sTipCmpE22 = "S"
            wp_sNomCmp = "nNroSig"
            wp_sDatCmp = vl_nNroSig
            wp_sTipCmp = "N"
            wr_bEOF = True
            wr_bEOF = clnActTbl.cndtActDosLlaUnCmp(wg_sNomTblE2,
                                                   wg_sNomCmpE21,
                                                   wg_sDatCmpE21,
                                                   wg_sTipCmpE21,
                                                   wg_sNomCmpE22,
                                                   wg_sDatCmpE22,
                                                   wg_sTipCmpE22,
                                                   wp_sNomCmp,
                                                   wp_sDatCmp,
                                                   wp_sTipCmp,
                                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : PloNroSig_APEND")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub PloNroSig_APLND1()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = vl_nNroDoc + 1
            wg_sNomTblE2 = "APLND1"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = wl_ePEROP.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_ePEROP.sCodSer
            wg_sTipCmpE22 = "S"
            wp_sNomCmp = "nNroSig"
            wp_sDatCmp = vl_nNroSig
            wp_sTipCmp = "N"

            wr_bEOF = True
            clnActTbl.cndtActDosLlaUnCmp(wg_sNomTblE2,
                                            wg_sNomCmpE21,
                                            wg_sDatCmpE21,
                                            wg_sTipCmpE21,
                                            wg_sNomCmpE22,
                                            wg_sDatCmpE22,
                                            wg_sTipCmpE22,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : PloNroSig_APLND1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region
#Region "082 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"
    Private Sub txtnNroDoc_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtnNroDocBas.KeyUp
        Try
            If e.KeyData = Keys.Enter Then
                Plo_InHabSec()
                Plo_HabSec()
                Plo_TxtnNroDocKeyUp()
                Plo_Var_ePEODP()
            End If
        Catch ex As Exception
            MsgBox("Error : txtnNroDoc_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtnNroDoc_LostFocus(sender As Object, e As System.EventArgs) Handles txtnNroDocBas.LostFocus
        Try
            If txtnNroDocBas.Text = "" Or txtnNroDocBas.Text = " " Then
                txtnNroDocBas.Text = 0
            End If

            If txtnNroDocBas.Text = "" Or txtnNroDocBas.Text = 0 Then
                cmdTecOP.Focus()
            Else
                Plo_InHabSec()
                Plo_HabSec()
                Plo_TxtnNroDocKeyUp()
            End If

        Catch ex As Exception
            MsgBox("Error : txtnNroDoc_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "150 grl Otros"
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_LmpMsgError()
        Me.Close()
        mof_LmpMsgError()
    End Sub
#End Region


End Class