Public Class frmATGRI
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2015-03-09

#Region "001 Inicia. wp - vp Definición del variables públicas"
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"
    ' vl numéricas

    ' wl Booleanas
    Dim wl_bYesNo As Boolean
    Dim wl_bVda As Boolean

    ' wl numéricas
    Dim wl_sNomTblCbo As String
    Dim wl_sNomFrm As String

    Dim wl_nCmpCla As String

    Dim wl_sCmpTSB As String
    Dim wl_sDatTSB As String
    Dim wl_sTipCmpTSB As String

    Dim wl_sCmpTSB1 As String
    Dim wl_sDatTSB1 As String
    Dim wl_sTipCmpTSB1 As String

    Dim wl_sCmpTSB2 As String
    Dim wl_sDatTSB2 As String
    Dim wl_sTipCmpTSB2 As String

    Dim wp_sTipCmp As String
    Dim wl_sTipTbl As String

    Dim wl_sClaPpl As String
    Dim wl_sClaPPl1 As String
    Dim wl_sClaPPl2 As String
    Dim wl_sDatCmpE11 As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNomCmpE11 As String
    Dim wl_sTipCmpE11 As String
    Dim wl_sTitCmpE11 As String
    Dim wl_sDatCmpE12 As String
    Dim wl_sNomTblE2 As String
    Dim wl_sNomCmpE12 As String
    Dim wl_sTipCmpE12 As String
    Dim wl_sTitCmpE12 As String
    Dim wl_sCmpOrdE11 As String
    Dim wl_sTipOrdE11 As String
#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nId As Long
    Dim vl_sCodGrp As String
    Dim vl_sNomGrp As String
    Dim vl_sCtaInv As String
    Dim vl_sCtaCosVta As String
    Dim vl_sCtaTrs As String
    Dim vl_sCtaIng As String
    Dim vl_sCtaDevVta As String
    Dim vl_sCtaVrc As String
    Dim vl_sCtaGto As String
    Dim vl_sCtaDot As String
    Dim vl_sCtaDifPre As String
    Dim vl_sCtaRev As String
    Dim vl_sCtaAumInv As String
    Dim vl_sCtaRedInv As String
    Dim vl_sCtaCom As String
    Dim vl_sCtaDevCom As String
    Dim vl_sCtaWIP As String
    Dim vl_sSysInv As String
    Dim vl_sMetAba As String
    Dim vl_sMetVlz As String
    Dim vl_bRegAci As Boolean

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnATGRI As New ClaseNegocios.clnATGRI
    Dim clnFTPUC As New ClaseNegocios.clnFTPUC
    Dim wl_DTCbo As DataTable
    Dim wl_DTE1 As DataTable

#End Region
#Region "015 Estructuras"
    Dim wl_aeATGRI() As moe_Estructuras.eATGRI
    Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC
    Dim wl_eATGRI As New moe_Estructuras.eATGRI
    Dim wl_eFTPUC As New moe_Estructuras.eFTPUC

#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
    Dim wl_sCodErrAdi As String
    Dim wl_sCodErrCon As String
    Dim wl_sCodErrOk As String
    Dim wl_sDesMsgEli As String
    Dim wl_sTitMsgEli As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#End Region

#Region "020 frm Eventos - Principal"

    Private Sub frmATGRI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
        Catch ex As Exception
            MsgBox("Error : frmATGRI_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmATGRI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_RemoveHandler()
            grl_AddHandler()
            mof_fCnfCtrl(Me)
            mof_IniciarVar()

            Plo_IniciarEst()
            Plo_IniciarFrm()
            Plo_IniciarVar()
            wl_sTipTbl = "E1"

            BD_DatPrmTipTbl(wl_sTipTbl)
            grl_EventCtrl(Me)
            Cbo_CargarLst()
            Plo_ActivarCrear()
        Catch ex As Exception
            MsgBox("Error : frmATGRI_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CtaInvFTPUC()
            Cbo_CtaCosVtaFTPUC()
            Cbo_CtaTrsFTPUC()
            Cbo_CtaIngFTPUC()
            Cbo_CtaDevVtaTPUC()
            Cbo_CtaVrcTPUC()
            Cbo_CtaGtoFTPUC()
            Cbo_CtaDotFTPUC()
            Cbo_CtaDifPreTPUC()
            Cbo_CtaRevFTPUC()
            Cbo_CtaAumInvFTPUC()
            Cbo_CtaRedInvFTPUC()
            Cbo_CtaComFTPUC()
            Cbo_CtaDevComFTPUC()
            Cbo_CtaWIPFTPUC()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaInvFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaInv.DataSource = wl_DTCbo
                cboCtaInv.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaInv.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaInvFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaCosVtaFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaCosVta.DataSource = wl_DTCbo
                cboCtaCosVta.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaCosVta.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaCosVtaFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaTrsFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaTrs.DataSource = wl_DTCbo
                cboCtaTrs.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaTrs.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaTrsFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaIngFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaIng.DataSource = wl_DTCbo
                cboCtaIng.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaIng.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaIngFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaDevVtaTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaDevVta.DataSource = wl_DTCbo
                cboCtaDevVta.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaDevVta.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaDevVtaTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaVrcTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaVrc.DataSource = wl_DTCbo
                cboCtaVrc.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaVrc.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaVrcTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaGtoFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaGto.DataSource = wl_DTCbo
                cboCtaGto.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaGto.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaGtoFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaDotFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaDot.DataSource = wl_DTCbo
                cboCtaDot.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaDot.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaDotFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaDifPreTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaDifPre.DataSource = wl_DTCbo
                cboCtaDifPre.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaDifPre.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaDifPreTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaRevFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaRev.DataSource = wl_DTCbo
                cboCtaRev.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaRev.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaRevFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaAumInvFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaAumInv.DataSource = wl_DTCbo
                cboCtaAumInv.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaAumInv.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaAumInvFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaRedInvFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaRedInv.DataSource = wl_DTCbo
                cboCtaRedInv.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaRedInv.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaRedInvFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaComFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaCom.DataSource = wl_DTCbo
                cboCtaCom.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaCom.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaComFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaDevComFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaDevCom.DataSource = wl_DTCbo
                cboCtaDevCom.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaDevCom.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaDevComFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CtaWIPFTPUC()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "FTPUC"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCtaWIP.DataSource = wl_DTCbo
                cboCtaWIP.ValueMember = wl_DTCbo.Columns("sCodCta").Caption.ToString
                cboCtaWIP.DisplayMember = wl_DTCbo.Columns("sNomCta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CtaWIPFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            Plo_Var_Frm()
            BD_eATGRI_Var()
            wl_bYesNo = clnATGRI.cnCrearActATGRI(wl_eATGRI,
                                                 wr_bEOFE1,
                                                 wp_sCmdSel)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function

    Private Sub BD_DatPrmTipTbl(ByRef wl_sTipTbl As String)
        Try
            wl_sNomTblE1 = "ATgri"
            wl_sNomCmpE11 = "sCodGrp"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código Grp "
            wl_sDatCmpE11 = txtsCodGrp.Text
            wl_sClaPPl1 = wl_sDatCmpE11
            wr_bEOFE1 = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_DatPrmTipTbl")
        End Try
    End Sub
    Private Sub BD_DatPrmTSB() 'Constante
        Try
            '1 nId
            '2 NroDoc
            '3. CodDoc + NroDoc
            '4 Cod

            wl_nCmpCla = 4
            wl_sCmpTSB1 = "sCodGrp"
            wl_sDatTSB = ""
            wl_sTipCmpTSB = "S"
            wl_sTipCmpTSB1 = "S"
            wl_sCmpTSB2 = ""
            wl_sTipCmpTSB2 = ""
            Select Case wl_nCmpCla
                Case 1
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_eATGRI.nId
                    wl_sTipCmpTSB = "N"

                Case 2
                    wl_sCmpTSB = wl_sCmpTSB2
                    wl_sDatTSB = wl_sClaPpl
                    wl_sTipCmpTSB = "N"
                Case 3
                    wl_sDatTSB1 = wl_sClaPPl1
                    wl_sTipCmpTSB1 = "S"
                    wl_sDatTSB2 = wl_sClaPPl2
                    wl_sTipCmpTSB2 = "N"
                Case 4
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_sClaPpl
                    wl_sTipCmpTSB = "S"
            End Select
        Catch ex As Exception
            MsgBox("Error :  BD_DatPrmTSB")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BD_eATGRI_Var()
        Try
            With wl_eATGRI
                .sCodGrp = vl_sCodGrp
                .sNomGrp = vl_sNomGrp
                .sCtaInv = vl_sCtaInv
                .sCtaCosVta = vl_sCtaCosVta
                .sCtaTrs = vl_sCtaTrs
                .sCtaIng = vl_sCtaIng
                .sCtaDevVta = vl_sCtaDevVta
                .sCtaVrc = vl_sCtaVrc
                .sCtaGto = vl_sCtaGto
                .sCtaDot = vl_sCtaDot
                .sCtaDifPre = vl_sCtaDifPre
                .sCtaRev = vl_sCtaRev
                .sCtaAumInv = vl_sCtaAumInv
                .sCtaRedInv = vl_sCtaRedInv
                .sCtaCom = vl_sCtaCom
                .sCtaDevCom = vl_sCtaDevCom
                .sCtaWIP = vl_sCtaWIP
                .sSysInv = vl_sSysInv
                .sMetAba = vl_sMetAba
                .sMetVlz = vl_sMetVlz
                .bRegAci = vl_bRegAci
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eATGRI_Var")
        End Try
    End Sub
    Private Sub BD_Var_eATGRI()
        Try
            With wl_eATGRI
                vl_sCodGrp = .sCodGrp
                vl_sNomGrp = .sNomGrp
                vl_sCtaInv = .sCtaInv
                vl_sCtaCosVta = .sCtaCosVta
                vl_sCtaTrs = .sCtaTrs
                vl_sCtaIng = .sCtaIng
                vl_sCtaDevVta = .sCtaDevVta
                vl_sCtaVrc = .sCtaVrc
                vl_sCtaGto = .sCtaGto
                vl_sCtaDot = .sCtaDot
                vl_sCtaDifPre = .sCtaDifPre
                vl_sCtaRev = .sCtaRev
                vl_sCtaAumInv = .sCtaAumInv
                vl_sCtaRedInv = .sCtaRedInv
                vl_sCtaCom = .sCtaCom
                vl_sCtaDevCom = .sCtaDevCom
                vl_sCtaWIP = .sCtaWIP
                vl_sSysInv = .sSysInv
                vl_sMetAba = .sMetAba
                vl_sMetVlz = .sMetVlz
                vl_bRegAci = .bRegAci
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eATGRI")
        End Try
    End Sub
    Private Sub BD_eATGRI_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eATGRI = New moe_Estructuras.eATGRI
            moo_eATGRI_DT(wl_eATGRI,
                          wp_DTE1,
                         wl_nRow)
            wl_sDatCmpE12 = txtsCodGrp.Text

        Catch ex As Exception
            MsgBox("Error :  BD_eATGRI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            Plo_ActivarCmpAct()
            txtsCodGrp.Enabled = False
            vl_sCodGrp = wl_DTE1.Rows(0).Item("sCodGrp")
            wl_sDatCmpE11 = vl_sCodGrp
            BD_BuscarATGRI()
            BD_Var_eATGRI()
            Plo_Frm_Var()
            mof_ActivarOK(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try

    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarATGRI() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATGRI = New moe_Estructuras.eATGRI
            wr_bEOFE2 = mof_fConATGRI(vl_sCodGrp,
                                      wl_eATGRI)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATGRI")
        End Try
        Return wr_bEOFE2
    End Function

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmATGRI()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATGRI = New moe_Estructuras.eATGRI
            wg_sTblCon1 = "ATGRI"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATGRI.sCodGRP <> "" Then
                wl_eATGRI = wl_frmLst.wp_eATGRI
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_frmATGRI")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            wp_sCmdSel = "A"
            wl_bYesNo = False
            wr_bEOFE1 = True
            wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
            If wl_bYesNo Then
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = ""
                wp_sCodErr = wl_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                Plo_InactivarCmpAct()
                mof_ActivarOK(Me)
                cmdOk.Focus()
            Else
                txtsCodGrp.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error :  cmdActualizar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            wp_sCmdSel = "B"
            wl_bYesNo = False
            mof_LmpMsgError()
            vl_sCodGrp = txtsCodGrp.Text
            If txtsCodGrp.Text <> "" Then
                BD_DatPrmTipTbl(wl_sTipTbl)
                wl_sCmpOrdE11 = ""
                wl_sTipOrdE11 = ""
                BD_BuscarATGRI()
                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtsCodGrp.Text
                    wp_sCodErr = wl_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodGrp.Focus()
                Else
                    BD_Var_eATGRI()
                    Plo_Frm_Var()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()

                End If
            End If
            txtsCodGrp.Focus()

        Catch ex As Exception
            MsgBox("Error :  cmdBuscar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Try
            wp_sCmdSel = "C"
            wr_bEOFE1 = False
            mof_LmpMsgError()
            If txtsCodGrp.Text <> "" Then
                vl_sCodGrp = txtsCodGrp.Text
                BD_DatPrmTipTbl(wl_sTipTbl)
                wr_bEOFE1 = mof_fConATGRI(vl_sCodGrp,
                                          wl_eATGRI)
                If wr_bEOFE1 Then
                    wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                    If wl_bYesNo Then
                        wp_sNomTbl = wl_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = wl_sCodErrOk
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        mof_ActivarOK(Me)
                        mof_habTsbCrear()
                        mof_inhabTsbEliminar()
                        cmdOk.Focus()
                        Plo_InactivarCmpAct()
                    End If
                Else
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtsCodGrp.Text
                    wp_sCodErr = wl_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodGrp.Focus()
                End If

            End If


        Catch ex As Exception
            MsgBox("Error :  cmdCrear_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            wp_sCmdSel = "E"
            wl_bYesNo = False
            mof_LmpMsgError()

            If txtsCodGrp.Text <> "" Then
                vl_sCodGrp = txtsCodGrp.Text
                wp_nBoxMsg = 4
                wp_sDesMsg = wl_sDesMsgEli
                wp_sTitMsg = wl_sTitMsgEli
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                If wp_nResMsg = 6 Then
                    BD_DatPrmTipTbl(wl_sTipTbl)
                    wl_sCmpOrdE11 = ""
                    wl_sTipOrdE11 = ""
                    wl_DTE1 = clnConTbl.cndtBuscar(wl_sNomTblE1,
                                                   wl_sNomCmpE11,
                                                   wl_sDatCmpE11,
                                                   wl_sTipCmpE11,
                                                   wl_sCmpOrdE11,
                                                   wl_sTipOrdE11,
                                                   wr_bEOFE1)
                    If Not wr_bEOFE1 Then
                        BD_eATGRI_DT(wl_DTE1)
                        wl_bVda = False
                        wp_sNomTbl = ""
                        wl_bYesNo = mov_VdasCodGrp(vl_sCodGrp,
                                                   wp_sNomTbl,
                                                   wl_bVda)
                        If wl_bVda = True Then
                            wl_bYesNo = clnATGRI.cnEliATGRI(wl_eATGRI,
                                                            wr_bEOF)
                            If wl_bYesNo Then

                                mof_ActivarBuscar(Me)
                                wp_sNomTbl = wl_sNomTblE1
                                wp_sDatCmp = ""
                                wp_sCodErr = wl_sCodErrOk
                                mof_MsgError(wp_sNomTbl,
                                             wp_sDatCmp,
                                             wp_sCodErr)
                                mof_ActivarOK(Me)
                            Else
                                txtsCodGrp.Focus()
                            End If
                        Else
                            wp_sDatCmp = vl_sCodGrp
                            wp_sCodErr = "10-613"
                            mof_MsgError(wp_sNomTbl,
                                         wp_sDatCmp,
                                         wp_sCodErr)
                            Plo_InactivarCmpAct()
                            mof_ActivarOK(Me)
                            cmdOk.Focus()

                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cmdEliminar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdLstATGRI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstATGRI.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmATGRI()
            If wl_eATGRI.sCodGrp <> "" Then
                BD_Var_eATGRI()
                Plo_Frm_Var()
                txtsNomGrp.Focus()
                mof_ActivarOK(Me)
            Else
                If txtsCodGrp.Text <> "" Then
                    mof_ActivarOK(Me)
                Else
                    mof_ActivarBuscar(Me)
                End If

            End If

        Catch ex As Exception
            MsgBox("Error en: cmdLstATOPE_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region


#Region "070 DGV "
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeATGRI(0)
            wl_eATGRI = New moe_Estructuras.eATGRI
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmATGRI"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_sCodErrAdi = "10-313"
            wl_sCodErrCon = "10-113"
            wl_sCodErrOk = "20-001"
            wl_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
            wl_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wl_sCmpTSB = "sCodGrp"

            ' De la BD
            vl_nId = 0
            vl_sCodGrp = ""
            vl_sNomGrp = ""
            vl_sCtaInv = ""
            vl_sCtaCosVta = ""
            vl_sCtaTrs = ""
            vl_sCtaIng = ""
            vl_sCtaDevVta = ""
            vl_sCtaVrc = ""
            vl_sCtaGto = ""
            vl_sCtaDot = ""
            vl_sCtaDifPre = ""
            vl_sCtaRev = ""
            vl_sCtaAumInv = ""
            vl_sCtaRedInv = ""
            vl_sCtaCom = ""
            vl_sCtaDevCom = ""
            vl_sCtaWIP = ""
            vl_sSysInv = ""
            vl_sMetAba = ""
            vl_sMetVlz = ""
            vl_bRegAci = False
            Plo_ActivarCmpAct()
            mof_ActivarCrear(Me)

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_Frm_Var()
        Try
            txtsCodGrp.Text = vl_sCodGrp
            txtsNomGrp.Text = vl_sNomGrp
            cboCtaInv.SelectedValue = vl_sCtaInv
            cboCtaCosVta.SelectedValue = vl_sCtaCosVta
            cboCtaTrs.SelectedValue = vl_sCtaTrs
            cboCtaIng.SelectedValue = vl_sCtaIng
            cboCtaDevVta.SelectedValue = vl_sCtaDevVta
            cboCtaVrc.SelectedValue = vl_sCtaVrc
            cboCtaGto.SelectedValue = vl_sCtaGto
            cboCtaDot.SelectedValue = vl_sCtaDot
            cboCtaDifPre.SelectedValue = vl_sCtaDifPre
            cboCtaRev.SelectedValue = vl_sCtaRev
            cboCtaAumInv.SelectedValue = vl_sCtaAumInv
            cboCtaRedInv.SelectedValue = vl_sCtaRedInv
            cboCtaCom.SelectedValue = vl_sCtaCom
            cboCtaDevCom.SelectedValue = vl_sCtaDevCom
            cboCtaWIP.SelectedValue = vl_sCtaWIP
            txtsMetAba.Text = vl_sMetAba
            txtsMetVlz.Text = vl_sMetVlz
            chbbRegAci.Checked = vl_bRegAci

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Frm_Var")
        End Try
    End Sub
    Private Sub Plo_Var_Frm()
        Try

            vl_sCodGrp = txtsCodGrp.Text
            vl_sNomGrp = txtsNomGrp.Text
            vl_sCtaInv = cboCtaInv.SelectedValue
            vl_sCtaCosVta = cboCtaCosVta.SelectedValue
            vl_sCtaTrs = cboCtaTrs.SelectedValue
            vl_sCtaIng = cboCtaIng.SelectedValue
            vl_sCtaDevVta = cboCtaDevVta.SelectedValue
            vl_sCtaVrc = cboCtaVrc.SelectedValue
            vl_sCtaGto = cboCtaGto.SelectedValue
            vl_sCtaDot = cboCtaDot.SelectedValue
            vl_sCtaDifPre = cboCtaDifPre.SelectedValue
            vl_sCtaRev = cboCtaRev.SelectedValue
            vl_sCtaAumInv = cboCtaAumInv.SelectedValue
            vl_sCtaRedInv = cboCtaRedInv.SelectedValue
            vl_sCtaCom = cboCtaCom.SelectedValue
            vl_sCtaDevCom = cboCtaDevCom.SelectedValue
            vl_sCtaWIP = cboCtaWIP.SelectedValue
            vl_sMetAba = txtsMetAba.Text
            vl_sMetVlz = txtsMetVlz.Text
            vl_bRegAci = chbbRegAci.Checked
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Var_Frm")
        End Try
    End Sub
#End Region

#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarBuscar()
        Try
            mof_HabCtrl(Me)
            Plo_IniciarVar()
            mof_ActivarBuscar(Me)
            txtsCodGrp.Focus()
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarBuscar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCrear()
        Try
            mof_ActivarCrear(Me)
            Plo_IniciarFrm()
            Plo_IniciarVar()
            txtsCodGrp.Focus()


        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_ActivarCmpAct()
        Try
            txtsCodGrp.Enabled = True
            txtsNomGrp.Enabled = True
            cboCtaInv.Enabled = True
            cboCtaCosVta.Enabled = True
            cboCtaTrs.Enabled = True
            cboCtaIng.Enabled = True
            cboCtaDevVta.Enabled = True
            cboCtaVrc.Enabled = True
            cboCtaGto.Enabled = True
            cboCtaDot.Enabled = True
            cboCtaDifPre.Enabled = True
            cboCtaRev.Enabled = True
            cboCtaAumInv.Enabled = True
            cboCtaRedInv.Enabled = True
            cboCtaCom.Enabled = True
            cboCtaDevCom.Enabled = True
            cboCtaWIP.Enabled = True
            txtsMetAba.Enabled = True
            txtsMetVlz.Enabled = True
            chbbRegAci.Enabled = True

        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactivarCmpAct()
        Try
            txtsCodGrp.Enabled = False
            txtsNomGrp.Enabled = False
            cboCtaInv.Enabled = False
            cboCtaCosVta.Enabled = False
            cboCtaTrs.Enabled = False
            cboCtaIng.Enabled = False
            cboCtaDevVta.Enabled = False
            cboCtaVrc.Enabled = False
            cboCtaGto.Enabled = False
            cboCtaDot.Enabled = False
            cboCtaDifPre.Enabled = False
            cboCtaRev.Enabled = False
            cboCtaAumInv.Enabled = False
            cboCtaRedInv.Enabled = False
            cboCtaCom.Enabled = False
            cboCtaDevCom.Enabled = False
            cboCtaWIP.Enabled = False

            txtsMetAba.Enabled = False
            txtsMetVlz.Enabled = False

            chbbRegAci.Enabled = False


        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
#End Region
#Region "082 Elo Eventos locales del Formulario"
    Private Sub txtsCodGrp_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCodGrp.KeyUp
        Try
            If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: txtsCodOpe_KeyUp")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#End Region


#Region "PROCEDIMIENTOS EVENTOS COMUNES"

#Region "110 grl Changed"
    Private Sub grl_Cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Chb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_mtb_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Txt_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DirectCast(sender, TextBox).Name = "txtsCodGrp" Then
            wl_sClaPpl = txtsCodGrp.Text
            mof_LmpMsgError()
        Else
            grl_TextChange()
        End If
    End Sub
#End Region

#Region "120 grl Eventos"
    Public Sub grl_EventCtrl(ByVal wp_VlrCtrl As Control)
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is ComboBox Then
                AddHandler DirectCast(oCtrl, ComboBox).GotFocus, AddressOf grl_Cbo_GotFocus
                AddHandler DirectCast(oCtrl, ComboBox).LostFocus, AddressOf grl_Cbo_LostFocus
                AddHandler DirectCast(oCtrl, ComboBox).SelectedIndexChanged, AddressOf grl_Cbo_SelectedIndexChanged
            End If
            If TypeOf oCtrl Is CheckBox Then
                AddHandler DirectCast(oCtrl, CheckBox).GotFocus, AddressOf grl_Chb_GotFocus
                AddHandler DirectCast(oCtrl, CheckBox).LostFocus, AddressOf grl_Chb_LostFocus
                AddHandler DirectCast(oCtrl, CheckBox).CheckedChanged, AddressOf grl_Chb_CheckedChanged
            End If
            If TypeOf oCtrl Is MaskedTextBox Then
                AddHandler DirectCast(oCtrl, MaskedTextBox).GotFocus, AddressOf grl_mtb_GotFocus
                AddHandler DirectCast(oCtrl, MaskedTextBox).LostFocus, AddressOf grl_mtb_LostFocus
                AddHandler DirectCast(oCtrl, MaskedTextBox).TextChanged, AddressOf grl_mtb_Changed
            End If
            If TypeOf oCtrl Is RadioButton Then
                AddHandler DirectCast(oCtrl, RadioButton).GotFocus, AddressOf grl_Rdb_GotFocus
                AddHandler DirectCast(oCtrl, RadioButton).LostFocus, AddressOf grl_Rdb_LostFocus
                AddHandler DirectCast(oCtrl, RadioButton).CheckedChanged, AddressOf grl_Rdb_CheckedChanged
            End If
            If TypeOf oCtrl Is TextBox Then
                AddHandler DirectCast(oCtrl, TextBox).GotFocus, AddressOf grl_Txt_GotFocus
                AddHandler DirectCast(oCtrl, TextBox).LostFocus, AddressOf grl_Txt_LostFocus
                AddHandler DirectCast(oCtrl, TextBox).TextChanged, AddressOf grl_Txt_Changed
                AddHandler DirectCast(oCtrl, TextBox).KeyUp, AddressOf grl_Txt_KeyUp
            End If
            If TypeOf oCtrl Is GroupBox Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is SplitContainer Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabControl Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabPage Then
                grl_EventCtrl(oCtrl)
            End If
        Next
    End Sub
    Private Sub grl_AddHandler()
        AddHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        AddHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        AddHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        AddHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        AddHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        AddHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        AddHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VwvPrv
        AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        AddHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        AddHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
    End Sub
    Private Sub grl_RemoveHandler()
        RemoveHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        RemoveHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        RemoveHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        RemoveHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        RemoveHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        RemoveHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        RemoveHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VwvPrv
        RemoveHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        RemoveHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        RemoveHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
    End Sub
#End Region

#Region "130 grl Got Focus"
    Private Sub grl_Cbo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Chb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_mtb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrGot
        DirectCast(sender, MaskedTextBox).SelectionStart = 0
        DirectCast(sender, MaskedTextBox).SelectionLength = DirectCast(sender, MaskedTextBox).Text.Length
    End Sub
    Private Sub grl_Rdb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = wg_ClrGot
        DirectCast(sender, TextBox).SelectionStart = 0
        DirectCast(sender, TextBox).SelectionLength = DirectCast(sender, TextBox).Text.Length
        DirectCast(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "140 grl Lost Focus. Personalizados"
    ' Private Sub grl_Txt_KeyUp(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub grl_Txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        ' mof_LmpMsgError()
        wl_cvTxt = GetNextControl(wl_cvTxt, False)
        If cmdCancelar.Focused = False Then
            If wl_cvTxt IsNot Nothing Then
                If wl_cvTxt.Name = "txtsCodGrp" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodGrp)
                End If
            End If
        End If

        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        ' mof_LmpMsgError()
        wl_cvTxt = GetNextControl(wl_cvTxt, False)
        If cmdCancelar.Focused = False Then
            If wl_cvTxt IsNot Nothing Then
                If wl_cvTxt.Name = "txtsCodGrp" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodGrp)
                End If
            End If
        End If
        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
#End Region
#Region "141 grl Lost Focus. Comunes"
    Private Sub grl_Cbo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Chb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_mtb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Rdb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrLost
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
    Public Sub grl_TextChange()
        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region

#Region "160 TSB ToolStrip Procedimientos eventos de la barra de herramientas:BCPASUE"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
        Plo_ActivarBuscar()
    End Sub
    Private Sub tsb_Primero()
        BD_DatPrmTSB()
        ' mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtPrimero(wl_sNomTblE1,
                                                    wl_sCmpTSB,
                                                    wl_sDatTSB,
                                                    wr_bEOFE1)

                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtPrimeroMov(wl_sNomTblE1,
                                                       wl_sNomCmpE11,
                                                       wl_sDatCmpE11,
                                                       wl_sTipCmpE11,
                                                       wl_sNomCmpE12,
                                                       wl_sDatCmpE12,
                                                       wl_sTipCmpE12,
                                                       wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If

            End If


        Catch ex As Exception
            MsgBox("Error en: tsb_Primero")
        End Try

    End Sub
    Private Sub tsb_Anterior()
        BD_DatPrmTSB()
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtAnterior(wl_sNomTblE1,
                                                     wl_sCmpTSB,
                                                     wl_sDatTSB,
                                                     wl_sTipCmpTSB,
                                                     wr_bEOFE1)
                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtAnteriorMov(wl_sNomTblE1,
                                                        wl_sNomCmpE11,
                                                        wl_sDatCmpE11,
                                                        wl_sTipCmpE11,
                                                        wl_sNomCmpE12,
                                                        wl_sDatCmpE12,
                                                        wl_sTipCmpE12,
                                                        wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Anterior")
        End Try

    End Sub
    Private Sub tsb_Siguiente()
        BD_DatPrmTSB()
        '  mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtSiguiente(wl_sNomTblE1,
                                                      wl_sCmpTSB,
                                                      wl_sDatTSB,
                                                      wl_sTipCmpTSB,
                                                      wr_bEOFE1)
                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtSiguienteMov(wl_sNomTblE1,
                                                         wl_sNomCmpE11,
                                                         wl_sDatCmpE11,
                                                         wl_sTipCmpE11,
                                                         wl_sNomCmpE12,
                                                         wl_sDatCmpE12,
                                                         wl_sTipCmpE12,
                                                         wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If

            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Siguiente")
        End Try

    End Sub
    Private Sub tsb_Ultimo()
        BD_DatPrmTSB()
        mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtUltimo(wl_sNomTblE1,
                                                   wl_sCmpTSB,
                                                   wl_sDatTSB,
                                                   wr_bEOFE1)
                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtUltimoMov(wl_sNomTblE1,
                                                      wl_sNomCmpE11,
                                                      wl_sDatCmpE11,
                                                      wl_sTipCmpE11,
                                                      wl_sNomCmpE12,
                                                      wl_sDatCmpE12,
                                                      wl_sTipCmpE12,
                                                      wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Ultimo")
        End Try
    End Sub
    Public Sub tsb_Crear()
        mof_fLmpCtrl(Me)
        Plo_ActivarCrear()

    End Sub
    Public Sub tsb_Eliminar()
        mof_ActivarEliminar(Me)
    End Sub
#End Region

#Region "161 TSB ToolStrip Procedimientos eventos de la barra de herramientas:VI"
    Private Sub tsb_VwvPrv()
        Try
            '   Rpt_PrmRpt()
        Catch ex As Exception
            MsgBox("Error :  tsb_VisVwV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
#End Region

#Region "170 TSMI ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
        Try

        Catch ex As Exception
            MsgBox("Error : tsmi_CrearLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsmi_EliminarLinea()
        Try

        Catch ex As Exception
            MsgBox("Error : tsmi_EliminarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#End Region
End Class