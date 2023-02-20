Public Class frmATPCO
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
    Dim wl_sNroALetras As String

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nId As Long
    Dim vl_sCodPdo As String
    Dim vl_sNomPdo As String
    Dim vl_sEstPdo As String
    Dim vl_dFecIni As Date
    Dim vl_dFecFin As Date
    Dim vl_sCodAno As String
    Dim vl_bRegAci As Boolean
#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sPdoLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnATPCO As New ClaseNegocios.clnATPCO

    Dim wl_DTCbo As DataTable
    Dim wl_DTE1 As DataTable


    Dim clnTblAB As ClaseNegocios.clnTblAB

#End Region
#Region "015 Estructuras"
    Dim wl_aeATPCO() As moe_Estructuras.eATPCO
    Dim wl_eATPCO As New moe_Estructuras.eATPCO
    Dim wl_aeABEPC() As moe_Estructuras.eABEPC
    Dim wl_eABEPC As New moe_Estructuras.eABEPC
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


    Private Sub frmATPCO_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
        Catch ex As Exception
            MsgBox("Error : frmATPCO_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub frmATPCO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            MsgBox("Error : frmATPCO_Load")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region


#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarABEPC()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABEPC()
        Try
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABEPC"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABEPC.DataSource = wg_DTLst1
                cboABEPC.ValueMember = wg_DTLst1.Columns("sCodEstPdoCbe").Caption.ToString
                cboABEPC.DisplayMember = wg_DTLst1.Columns("sDesEstPdoCbe").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABEPC")
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
            BD_eATPCO_Var()
            wl_bYesNo = clnATPCO.cnCrearActATPCO(wl_eATPCO,
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
            wl_sNomTblE1 = "ATPCO"
            wl_sNomCmpE11 = "sCodPdo"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código Pdo "
            wl_sDatCmpE11 = txtsCodPdo.Text
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
            wl_sCmpTSB1 = "sCodPdo"
            wl_sDatTSB = ""
            wl_sTipCmpTSB = "S"
            wl_sTipCmpTSB1 = "S"
            wl_sCmpTSB2 = ""
            wl_sTipCmpTSB2 = ""
            Select Case wl_nCmpCla
                Case 1
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_eATPCO.nId
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
    Private Sub BD_eATPCO_Var()
        Try
            With wl_eATPCO
                .sCodPdo = vl_sCodPdo
                .sNomPdo = vl_sNomPdo
                .sEstPdo = vl_sEstPdo
                .dFecIni = vl_dFecIni
                .dFecFin = vl_dFecFin
                .sCodAno = vl_sCodAno
                .bRegAci = vl_bRegAci
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eATPCO_Var")
        End Try
    End Sub
    Private Sub BD_Var_eATPCO()
        Try
            With wl_eATPCO
                vl_sCodPdo = .sCodPdo
                vl_sNomPdo = .sNomPdo
                vl_sEstPdo = .sEstPdo
                vl_dFecIni = .dFecIni
                vl_dFecFin = .dFecFin
                vl_sCodAno = .sCodAno
                vl_bRegAci = .bRegAci
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eATPCO")
        End Try
    End Sub
    Private Sub BD_eATPCO_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eATPCO = New moe_Estructuras.eATPCO
            moo_eATPCO_DT(wl_eATPCO,
                          wp_DTE1,
                          wl_nRow)

            vl_sEstPdo = wl_eABEPC.sCodEstPdoCbe
            BD_BuscarABEPC()
            cboABEPC.SelectedValue = wl_eATPCO.sCodPdo
            wl_sDatCmpE12 = txtsCodPdo.Text

        Catch ex As Exception
            MsgBox("Error :  BD_eATPCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            Plo_ActivarCmpAct()
            txtsCodPdo.Enabled = False
            vl_sCodPdo = wl_DTE1.Rows(0).Item("sCodPdo")
            wl_sDatCmpE11 = vl_sCodPdo
            BD_BuscarATPCO()
            BD_Var_eATPCO()
            Plo_Frm_Var()
            mof_ActivarOK(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try

    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarABEPC() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eABEPC = New moe_Estructuras.eABEPC
            wr_bEOFE2 = mof_fConABEPC(vl_sCodPdo,
                                      wl_eABEPC)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarABEPC")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATPCO() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATPCO = New moe_Estructuras.eATPCO
            wr_bEOFE2 = mof_fConATPCO(vl_sCodPdo,
                                      wl_eATPCO)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATPCO")
        End Try
        Return wr_bEOFE2
    End Function

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmATPCO()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATPCO = New moe_Estructuras.eATPCO
            wg_sTblCon1 = "ATPCO"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATPCO.sCodPdo <> "" Then
                wl_eATPCO = wl_frmLst.wp_eATPCO
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATPCO")
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
                txtsCodPdo.Focus()
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
            vl_sCodPdo = txtsCodPdo.Text
            If txtsCodPdo.Text <> "" Then
                BD_DatPrmTipTbl(wl_sTipTbl)
                wl_sCmpOrdE11 = ""
                wl_sTipOrdE11 = ""
                wr_bEOFE1 = BD_BuscarATPCO()
                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtsCodPdo.Text
                    wp_sCodErr = wl_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodPdo.Focus()
                Else
                    BD_Var_eATPCO()
                    Plo_Frm_Var()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()

                End If
            End If
            txtsCodPdo.Focus()

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
            If txtsCodPdo.Text <> "" Then
                vl_sCodPdo = txtsCodPdo.Text
                BD_DatPrmTipTbl(wl_sTipTbl)
                wr_bEOFE1 = mof_fConATPCO(vl_sCodPdo,
                                          wl_eATPCO)
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
                    wp_sDatCmp = txtsCodPdo.Text
                    wp_sCodErr = wl_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodPdo.Focus()
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

            If txtsCodPdo.Text <> "" Then
                vl_sCodPdo = txtsCodPdo.Text
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
                        BD_eATPCO_DT(wl_DTE1)
                        wl_bVda = False
                        wp_sNomTbl = ""
                        wl_bYesNo = mov_VdasCodPdo(vl_sCodPdo,
                                                   wp_sNomTbl,
                                                   wl_bVda)
                        If wl_bVda = True Then
                            wl_bYesNo = clnATPCO.cnEliATPCO(wl_eATPCO,
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
                                txtsCodPdo.Focus()
                            End If
                        Else
                            wp_sDatCmp = vl_sCodPdo
                            wp_sCodErr = "10-615"
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
    Private Sub cmdLstATPCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstATPCO.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmATPCO()
            If wl_eATPCO.sCodPdo <> "" Then
                BD_Var_eATPCO()
                Plo_Frm_Var()
                txtsNomPdo.Focus()
                mof_ActivarOK(Me)
            Else
                If txtsCodPdo.Text <> "" Then
                    mof_ActivarOK(Me)
                Else
                    mof_ActivarBuscar(Me)
                End If

            End If




        Catch ex As Exception
            MsgBox("Error en: cmdLstATPCO_Click")
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
            ReDim wl_aeATPCO(0)
            ReDim wl_aeABEPC(0)
            wl_eATPCO = New moe_Estructuras.eATPCO
            wl_eABEPC = New moe_Estructuras.eABEPC
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmATPCO"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_sCodErrAdi = "10-315"
            wl_sCodErrCon = "10-115"
            wl_sCodErrOk = "20-001"
            wl_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
            wl_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wl_sCmpTSB = "sCodPdo"

            ' De la BD
            vl_nId = 0
            vl_sCodPdo = ""
            vl_sNomPdo = ""
            vl_sEstPdo = ""
            vl_dFecIni = Today
            vl_dFecFin = Today
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
            txtsCodPdo.Text = vl_sCodPdo
            txtsNomPdo.Text = vl_sNomPdo
            cboABEPC.SelectedValue = vl_sEstPdo
            dtpFecIni.Text = vl_dFecIni
            dtpFecFin.Text = vl_dFecFin
            txtsCodAno.Text = vl_sCodAno
            chbbRegAci.Checked = vl_bRegAci
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Frm_Var")
        End Try
    End Sub
    Private Sub Plo_Var_Frm()
        Try
            vl_sCodPdo = txtsCodPdo.Text
            vl_sNomPdo = txtsNomPdo.Text
            vl_sEstPdo = cboABEPC.SelectedValue
            vl_dFecIni = dtpFecIni.Text
            vl_dFecFin = dtpFecFin.Text
            vl_sCodAno = txtsCodAno.Text
            vl_bRegAci = chbbRegAci.Checked
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ePEODP")
        End Try
    End Sub
#End Region

#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarBuscar()
        Try
            mof_HabCtrl(Me)
            Plo_IniciarVar()
            mof_ActivarBuscar(Me)
            txtsCodPdo.Focus()
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
            txtsCodPdo.Focus()

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_ActivarCmpAct()
        Try
            txtsCodPdo.Enabled = True
            txtsNomPdo.Enabled = True
            cboABEPC.Enabled = True
            dtpFecIni.Enabled = True
            dtpFecFin.Enabled = True
            txtsCodAno.Enabled = True
            chbbRegAci.Enabled = True
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactivarCmpAct()
        Try
            txtsCodPdo.Enabled = False
            txtsNomPdo.Enabled = False
            cboABEPC.Enabled = False
            dtpFecIni.Enabled = False
            dtpFecFin.Enabled = False
            txtsCodAno.Enabled = False
            chbbRegAci.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpAct")
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
        If DirectCast(sender, TextBox).Name = "txtsCodPdo" Then
            wl_sClaPpl = txtsCodPdo.Text
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
                If wl_cvTxt.Name = "txtsCodPdo" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodPdo)
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
                If wl_cvTxt.Name = "txtsCodPdo" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodPdo)
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