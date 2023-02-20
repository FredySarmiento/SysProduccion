﻿Public Class frmATCIF
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2015-03-09
#End Region
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
    Dim wl_bEOF As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bYesNo As Boolean

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
    Dim vl_sCodCIF As String
    Dim vl_sNomCIF As String
    Dim vl_sCodCtr As String
    Dim vl_nTasCIF As Double
    Dim vl_nVlrCIF As Double
    Dim vl_nVlrCIFPpo As Double
    Dim vl_nBasCIFPpo As Double
    Dim vl_nVlrCIFRea As Double
    Dim vl_bRegAci As Boolean

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
#End Region
#Region "014 Objetos locales"
    Dim clnATCIF As New ClaseNegocios.clnATCIF
    Dim clnATCTR As New ClaseNegocios.clnATCTR
    Dim clnPEFOM As New ClaseNegocios.clnPEFOM
    Dim clnPELIM As New ClaseNegocios.clnPELIM
    Dim clnTblAB As ClaseNegocios.clnTblAB
    Dim wl_DTCbo As DataTable
    Dim wl_DTE1 As DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_aeATCIF() As moe_Estructuras.eATCIF
    Dim wl_aeATCTR() As moe_Estructuras.eATCTR
    Dim wl_eATCIF As New moe_Estructuras.eATCIF
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
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
#Region "020 frm Eventos - Principal"

    Private Sub frmATCIF_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
        Catch ex As Exception
            MsgBox("Error : frmATCIF_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmATCIF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            MsgBox("Error : frmATCIF_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarATCTR()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarATCTR()
        Try
            '  cboABESD.Enabled = False
            wl_DTCbo = New DataTable
            wl_sNomTblCbo = "ATCTR"
            wr_bEOFLst1 = True
            wl_DTCbo = clnConTbl.cndtCargarLista(wl_sNomTblCbo,
                                                 wr_bEOFLst1)


            If Not wr_bEOFLst1 Then
                cboATCTR.DataSource = wl_DTCbo
                cboATCTR.ValueMember = wl_DTCbo.Columns("sCodCtr").Caption.ToString
                cboATCTR.DisplayMember = wl_DTCbo.Columns("sNomCtr").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATCCO")
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
            BD_eATCIF_Var()
            wl_bYesNo = clnATCIF.cnCrearActATCIF(wl_eATCIF,
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
            wl_sNomTblE1 = "ATCIF"
            wl_sNomCmpE11 = "sCodCIF"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código CIF "
            wl_sDatCmpE11 = txtsCodCIF.Text
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
            wl_sCmpTSB1 = "sCodCIF"
            wl_sDatTSB = ""
            wl_sTipCmpTSB = "S"
            wl_sTipCmpTSB1 = "S"
            wl_sCmpTSB2 = ""
            wl_sTipCmpTSB2 = ""
            Select Case wl_nCmpCla
                Case 1
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_eATCIF.nID
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
    Private Sub BD_eATCIF_Var()
        Try
            With wl_eATCIF
                .sCodCIF = vl_sCodCIF
                .sNomCIF = vl_sNomCIF
                .sCodCtr = vl_sCodCtr
                .nTasCIF = vl_nTasCIF
                .nVlrCIF = vl_nVlrCIF
                .nVlrCIFPpo = vl_nVlrCIFPpo
                .nBasCIFPpo = vl_nBasCIFPpo
                .nVlrCIFRea = vl_nVlrCIFRea
                .bRegAci = vl_bRegAci
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eATCIF_Var")
        End Try
    End Sub
    Private Sub BD_Var_eATCIF()
        Try
            With wl_eATCIF
                vl_sCodCIF = .sCodCIF
                vl_sNomCIF = .sNomCIF
                vl_sCodCtr = .sCodCtr
                vl_nTasCIF = .nTasCIF
                vl_nVlrCIF = .nVlrCIF
                vl_nVlrCIFPpo = .nVlrCIFPpo
                vl_nBasCIFPpo = .nBasCIFPpo
                vl_nVlrCIFRea = .nVlrCIFRea
                vl_bRegAci = .bRegAci
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eATCIF")
        End Try
    End Sub
    Private Sub BD_eATCIF_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eATCIF = New moe_Estructuras.eATCIF
            moo_eATCIF_DT(wl_eATCIF,
                          wp_DTE1,
                          wl_nRow)

            vl_sCodCtr = wl_eATCIF.sCodCtr
            BD_BuscarATCIF()
            cboATCTR.SelectedValue = wl_eATCIF.sCodCtr
            wl_sDatCmpE12 = txtsCodCIF.Text
        Catch ex As Exception
            MsgBox("Error :  BD_eATCIF_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            Plo_ActivarCmpAct()
            cmdActCos.Enabled = True
            txtsCodCIF.Enabled = False
            vl_sCodCIF = wl_DTE1.Rows(0).Item("sCodCIF")
            wl_sDatCmpE11 = vl_sCodCIF
            BD_BuscarATCIF()
            BD_Var_eATCIF()
            Plo_Frm_Var()
            mof_ActivarOK(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try

    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarATCIF() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCIF = New moe_Estructuras.eATCIF
            wr_bEOFE2 = mof_fConATCIF(vl_sCodCIF,
                                      wl_eATCIF)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCIF")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATCTR() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCTR = New moe_Estructuras.eATCTR
            wr_bEOFE2 = mof_fConATCTR(vl_sCodCtr,
                                      wl_eATCTR)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCTR")
        End Try
        Return wr_bEOFE2
    End Function

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmATCIF()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATCIF = New moe_Estructuras.eATCIF
            wg_sTblCon1 = "ATCIF"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATCIF.sCodCIF <> "" Then
                wl_eATCIF = wl_frmLst.wp_eATCIF
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATCIF")
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
                txtsCodCIF.Focus()
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
            vl_sCodCtr = txtsCodCIF.Text
            If txtsCodCIF.Text <> "" Then
                BD_DatPrmTipTbl(wl_sTipTbl)
                wl_sCmpOrdE11 = ""
                wl_sTipOrdE11 = ""
                BD_BuscarATCTR()
                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtsCodCIF.Text
                    wp_sCodErr = wl_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodCIF.Focus()
                Else
                    BD_Var_eATCIF()
                    Plo_Frm_Var()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    cmdActCos.Enabled = True
                End If
            End If
            txtsCodCIF.Focus()

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
            If txtsCodCIF.Text <> "" Then
                vl_sCodCtr = txtsCodCIF.Text
                BD_DatPrmTipTbl(wl_sTipTbl)
                wr_bEOFE1 = mof_fConATCTR(vl_sCodCIF,
                                          wl_eATCTR)
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
                    wp_sDatCmp = txtsCodCIF.Text
                    wp_sCodErr = wl_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodCIF.Focus()
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

            If txtsCodCIF.Text <> "" Then
                vl_sCodCtr = txtsCodCIF.Text
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
                        BD_eATCIF_DT(wl_DTE1)
                        wl_bVda = False
                        wp_sNomTbl = ""
                        wl_bYesNo = mov_VdasCodCIF(vl_sCodCIF,
                                                   wp_sNomTbl,
                                                   wl_bVda)
                        If wl_bVda = True Then
                            wl_bYesNo = clnATCIF.cnEliATCIF(wl_eATCIF,
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
                                txtsCodCIF.Focus()
                            End If
                        Else
                            wp_sDatCmp = vl_sCodCIF
                            wp_sCodErr = "10-616"
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
    Private Sub cmdActCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActCos.Click
        Try
            If txtsCodCIF.Text <> "" Then
                wp_nBoxMsg = 4
                wp_sDesMsg = "Este proceso modifica los precios unitarios de la lista de materiales."
                wp_sDesMsg += vbCr
                wp_sDesMsg += " No se puede revesar"
                wp_sDesMsg += vbCr
                wp_sDesMsg += " Continua ?"
                wp_sTitMsg = wl_sTitMsgEli
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                If wp_nResMsg = 6 Then
                    wl_bEOF = True
                    wl_bYesNo = clnPEFOM.cnActPLFOM3nVlrCIFRea(wl_eATCIF,
                                                               wl_bEOF)
                    wl_bYesNo = clnPELIM.cnActPLLIM3nVlrCIFRea(wl_eATCIF,
                                                                wl_bEOF)

                    mof_ActivarBuscar(Me)
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = ""
                    wp_sCodErr = wl_sCodErrOk
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mof_ActivarOK(Me)
                End If
            End If
            cmdActCos.Enabled = False
        Catch ex As Exception
            MsgBox("Error: cmdActCos_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLstATCIF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstATCIF.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmATCIF()
            If wl_eATCIF.sCodCIF <> "" Then
                BD_Var_eATCIF()
                Plo_Frm_Var()
                txtsNomCIF.Focus()
                mof_ActivarOK(Me)
            Else
                If txtsCodCIF.Text <> "" Then
                    mof_ActivarOK(Me)
                Else
                    mof_ActivarBuscar(Me)
                End If

            End If
        Catch ex As Exception
            MsgBox("Error en: cmdLstATCTR_Click")
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeATCIF(0)
            ReDim wl_aeATCTR(0)
            wl_eATCIF = New moe_Estructuras.eATCIF
            wl_eATCTR = New moe_Estructuras.eATCTR
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmATCIF"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_sCodErrAdi = "10-316"
            wl_sCodErrCon = "10-116"
            wl_sCodErrOk = "20-001"
            wl_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
            wl_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wl_sCmpTSB = "sCodCIF"

            ' De la BD
            vl_nId = 0
            vl_sCodCIF = ""
            vl_sNomCIF = ""
            vl_sCodCtr = ""
            vl_nTasCIF = 0
            vl_nVlrCIF = 0
            vl_nVlrCIFPpo = 0
            vl_nBasCIFPpo = 0
            vl_nVlrCIFRea = 0
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
            txtsCodCIF.Text = vl_sCodCIF
            txtsNomCIF.Text = vl_sNomCIF
            cboATCTR.SelectedValue = vl_sCodCtr
            txtnTasCIF.Text = vl_nTasCIF
            txtnVlrCIF.Text = vl_nVlrCIF
            txtnVlrCIFPpo.Text = vl_nVlrCIFPpo
            txtnBasCIFPpo.Text = vl_nBasCIFPpo
            txtnVlrCIFRea.Text = vl_nVlrCIFRea
            chbbRegAci.Checked = vl_bRegAci
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Frm_Var")
        End Try
    End Sub
    Private Sub Plo_Var_Frm()
        Try
            vl_sCodCIF = txtsCodCIF.Text
            vl_sNomCIF = txtsNomCIF.Text
            vl_sCodCtr = cboATCTR.SelectedValue
            vl_nTasCIF = CDbl(txtnTasCIF.Text)
            vl_nVlrCIF = CDbl(txtnVlrCIF.Text)
            vl_nVlrCIFPpo = CDbl(txtnVlrCIFPpo.Text)
            vl_nBasCIFPpo = CDbl(txtnBasCIFPpo.Text)
            vl_nVlrCIFRea = CDbl(txtnVlrCIFRea.Text)
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
            txtsCodCIF.Focus()
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
            cmdActCos.Enabled = False
            txtsCodCIF.Focus()

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_ActivarCmpAct()
        Try
            txtsCodCIF.Enabled = True
            txtsNomCIF.Enabled = True
            cboATCTR.Enabled = True
            txtnTasCIF.Enabled = True
            txtnVlrCIF.Enabled = True
            txtnVlrCIFPpo.Enabled = True
            txtnBasCIFPpo.Enabled = True
            txtnVlrCIFRea.Enabled = True
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactivarCmpAct()
        Try
            txtsCodCIF.Enabled = False
            txtsNomCIF.Enabled = False
            cboATCTR.Enabled = False
            txtnTasCIF.Enabled = False
            txtnVlrCIF.Enabled = False
            txtnVlrCIFPpo.Enabled = False
            txtnBasCIFPpo.Enabled = False
            txtnVlrCIFRea.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
#End Region
#Region "082 Elo Eventos locales del Formulario"

    Private Sub txtsCodCIF_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCodCIF.KeyUp
        Try
            If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: txtsCodCIF_KeyUp")
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
        If DirectCast(sender, TextBox).Name = "txtsCodCIF" Then
            wl_sClaPpl = txtsCodCIF.Text
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
                If wl_cvTxt.Name = "txtsCodCIF" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodCIF)
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
                If wl_cvTxt.Name = "txtsCodCIF" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodCIF)
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