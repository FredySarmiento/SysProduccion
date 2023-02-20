



Module clpFunciones

#Region "Habilitar botones Toolbar"
    Public Sub clphabTsbBuscar()
        mdiPpal.tsbBuscar.Enabled = True
    End Sub
    Public Sub clphabTsbCrear()
        mdiPpal.tsbCrear.Enabled = True
    End Sub
    Public Sub clphabTsbEliminar()
        mdiPpal.tsbEliminar.Enabled = True
    End Sub
    Public Sub clphabTsbPASU()
        mdiPpal.tsbPrimero.Enabled = True
        mdiPpal.tsbAnterior.Enabled = True
        mdiPpal.tsbSiguiente.Enabled = True
        mdiPpal.tsbUltimo.Enabled = True
    End Sub
    Public Sub clphabVisPrevPrn()
        mdiPpal.tsbVistaPrevia.Enabled = True
        mdiPpal.tsbPrn.Enabled = True
    End Sub

#End Region

#Region "Inhabilitar botones Toolbar"
    Public Sub clpinhabTsbBuscar()
        mdiPpal.tsbBuscar.Enabled = False
    End Sub
    Public Sub clpinhabTsbCrear()
        mdiPpal.tsbCrear.Enabled = False
    End Sub
    Public Sub clpinhabTsbEliminar()
        mdiPpal.tsbEliminar.Enabled = False
    End Sub
    Public Sub clpinhabTsbPASU()
        mdiPpal.tsbPrimero.Enabled = False
        mdiPpal.tsbAnterior.Enabled = False
        mdiPpal.tsbSiguiente.Enabled = False
        mdiPpal.tsbUltimo.Enabled = False
    End Sub
    Public Sub clpInhabVisPrevPrn()
        mdiPpal.tsbVistaPrevia.Enabled = False
        mdiPpal.tsbPrn.Enabled = False
    End Sub

    Public Sub cpfInhabToolbar()
        clpinhabTsbBuscar()
        clpinhabTsbCrear()
        clpinhabTsbPASU()
        clpinhabTsbEliminar()
        clpInhabVisPrevPrn()
    End Sub
#End Region

#Region "Errores"
    Public Sub clp_MsgError(ByVal wp_sNomtbl As String,
                            ByVal wp_sDatCmp As String,
                            ByVal wp_sCoderr As String)
        wp_sDesErr = ""
        wp_sClrErr = ""
        wp_sTipDes = ""

        wg_DTErr1 = clnATERR.cndtConsultar(wp_sCoderr,
                                           wg_bEOFErr1)
        If Not wg_bEOFErr1 Then
            wp_sTipDes = wg_DTErr1.Rows(0).Item(3)
            wp_sClrErr = wg_DTErr1.Rows(0).Item(2)
            mdiPpal.lblMsgErr.BackColor = Color.AliceBlue
            If wp_sClrErr = "RED" Then
                mdiPpal.lblMsgErr.BackColor = Color.Red
            End If
            If wp_sClrErr = "GREEN" Then
                mdiPpal.lblMsgErr.BackColor = Color.Green
            End If
            If wp_sTipDes = "0" Then
                mdiPpal.lblMsgErr.Text = wg_DTErr1.Rows(0).Item(1)
                If wp_sDatCmp <> "" Then
                    mdiPpal.lblMsgErr.Text += " : " & Trim(wp_sDatCmp)
                End If
                If wp_sNomtbl <> "" Then
                    mdiPpal.lblMsgErr.Text += " en " & wp_sNomtbl
                End If
            End If
            If wp_sTipDes = "1" Then
                mdiPpal.lblMsgErr.Text = Trim(wg_DTErr1.Rows(0).Item(1))
            End If
            mdiPpal.Timer3_Timer()



        End If
    End Sub
    Public Sub clp_LmpMsgError()
        mdiPpal.lblMsgErr.BackColor = Color.AliceBlue
        mdiPpal.lblMsgErr.Text = ""
    End Sub
#End Region

#Region "Activar Command Buttons"
    Public Sub clp_ActivarActualizar(ByVal wp_VlrCtrl As Control)
        clp_LmpMsgError()

        clphabTsbBuscar()
        clphabTsbCrear()
        clphabTsbPASU()

        clpinhabTsbEliminar()

        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = False
                    oCtrl.BackColor = wg_ClrEnable
                End If
            End If

            If TypeOf oCtrl Is Button Then
                If oCtrl.name = "cmdActualizar" Then
                    oCtrl.visible = True
                End If
                If oCtrl.name = "cmdBuscar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdCrear" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdEliminar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdOk" Then
                    oCtrl.visible = False
                End If
            End If
            If TypeOf oCtrl Is SplitContainer Then
                clp_ActivarActualizar(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                clp_ActivarActualizar(oCtrl)
            End If
        Next
    End Sub
    Public Sub clp_ActivarBuscar(ByVal wp_VlrCtrl As Control)
        clphabTsbCrear()
        clphabTsbPASU()

        clpinhabTsbBuscar()
        clpinhabTsbEliminar()

        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = True
                End If
            End If

            If TypeOf oCtrl Is Button Then
                If oCtrl.name = "cmdActualizar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdBuscar" Then
                    oCtrl.visible = True
                End If
                If oCtrl.name = "cmdCrear" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdEliminar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdOk" Then
                    oCtrl.visible = False
                End If
            End If
            If TypeOf oCtrl Is SplitContainer Then
                clp_ActivarBuscar(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                clp_ActivarBuscar(oCtrl)
            End If
        Next
    End Sub
    Public Sub clp_ActivarCrear(ByVal wp_VlrCtrl As Control)
        clp_LmpMsgError()

        clphabTsbBuscar()
        clphabTsbPASU()

        clpinhabTsbCrear()
        clpinhabTsbEliminar()

        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = True
                End If
            End If
            If TypeOf oCtrl Is Button Then
                If oCtrl.name = "cmdActualizar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdBuscar" Then
                    oCtrl.visible = False
                End If

                If oCtrl.name = "cmdCrear" Then
                    oCtrl.visible = True
                End If
                If oCtrl.name = "cmdEliminar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdOk" Then
                    oCtrl.visible = False
                End If
            End If
            If TypeOf oCtrl Is SplitContainer Then
                clp_ActivarCrear(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                clp_ActivarCrear(oCtrl)
            End If
        Next
    End Sub
    Public Sub clp_ActivarEliminar(ByVal wp_VlrCtrl As Control)
        clp_LmpMsgError()

        clphabTsbBuscar()
        clphabTsbCrear()
        clphabTsbPASU()

        clpinhabTsbEliminar()

        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = False
                    oCtrl.BackColor = wg_ClrEnable
                End If
                If oCtrl.TabIndex = 2 Then
                    oCtrl.focus()
                End If
            End If

            If TypeOf oCtrl Is Button Then
                If oCtrl.name = "cmdActualizar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdBuscar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdCrear" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdEliminar" Then
                    oCtrl.visible = True
                End If
                If oCtrl.name = "cmdOk" Then
                    oCtrl.visible = False
                End If
            End If
            If TypeOf oCtrl Is SplitContainer Then
                clp_ActivarEliminar(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                clp_ActivarEliminar(oCtrl)
            End If
        Next
    End Sub
    Public Sub clp_ActivarOK(ByVal wp_VlrCtrl As Control)
        clphabTsbBuscar()
        clphabTsbCrear()
        clphabTsbPASU()
        clphabTsbEliminar()

        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = False
                    oCtrl.BackColor = wg_ClrEnable
                End If
                If oCtrl.TabIndex = 2 Then
                    oCtrl.focus()
                End If
            End If

            If TypeOf oCtrl Is Button Then
                If oCtrl.name = "cmdActualizar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdBuscar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdCrear" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdEliminar" Then
                    oCtrl.visible = False
                End If
                If oCtrl.name = "cmdOk" Then
                    oCtrl.visible = True
                    oCtrl.focus()
                End If
            End If
            If TypeOf oCtrl Is SplitContainer Then
                clp_ActivarOK(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                clp_ActivarOK(oCtrl)
            End If
        Next
    End Sub
#End Region

#Region "Ventana de mensajes"
    Public Function clp_fMnjMsg(ByVal wp_nBoxMsg As Integer,
                                ByVal wp_sDesMsg As String,
                                ByVal wp_sTitMsg As String) As Integer

        ' wl_nBoxmsg 2 AbortRetryIgnore
        ' wl_nBoxmsg 0 Ok
        ' wl_nBoxmsg 1 OkCancel
        ' wl_nBoxmsg 5 RetryCancel
        ' wl_nBoxmsg 4 YesNo
        ' wl_nBoxmsg 3 YesNoCancel
        ' wl_nResMsg 3 Abort  
        ' wl_nResMsg 2 Cancel
        ' wl_nResMsg 5 Ignore
        ' wl_nResMsg 7 No
        ' wl_nResMsg 0 None
        ' wl_nResMsg 1 Ok
        ' wl_nResMsg 4 Retry
        ' wl_nResMsg 6 Yes

        Dim wp_nResMsg As Integer
        Try


            If wp_nBoxMsg = 4 Then
                'wl_sResMsg = MsgBox("Este documento no puede modificarse después de crearse. ¿ Continua? ", vbYesNo + vbQuestion, Title:="Entrada de inventarios")

                wp_nResMsg = MessageBox.Show(wp_sDesMsg,
                                             wp_sTitMsg,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information,
                                             MessageBoxDefaultButton.Button1,
                                             MessageBoxOptions.RightAlign)



            End If

        Catch ex As Exception
            MsgBox("Error en : clp_fMnjMsg")
        End Try
        Return wp_nResMsg

    End Function

#End Region

#Region "Funciones sobre Tablas"
    Public Function clp_fConATCCO(ByVal wp_sCod As String,
                                  ByRef wp_eATCCO As Object) As Boolean
        Dim wl_eATCCO As New clpEstructuras.eATCCO
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Try
            wg_sNomTblE1 = "ATCCO"
            wg_sNomCmpE11 = "sCodCco"
            wg_sDatCmpE11 = wp_sCod
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)

            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                cpm_eATCCO_DT(wl_eATCCO,
                              wl_DT,
                              wl_nRow)
                wp_eATCCO = wl_eATCCO
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConATCCO")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConATIVA(ByVal wp_sCod As String,
                                  ByRef wp_eATIVA As Object) As Boolean
        Dim wl_eATIVA As New clpEstructuras.eATIVA
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Try
            wg_sNomTblE1 = "ATIVA"
            wg_sNomCmpE11 = "sCodIVA"
            wg_sDatCmpE11 = wp_sCod
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)

            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                cpm_eATIVA_DT(wl_eATIVA,
                              wl_DT,
                              wl_nRow)
                wp_eATIVA = wl_eATIVA
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConATIVA")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConATVEN(ByVal wp_sCod As String,
                                  ByRef wp_eATVEN As Object) As Boolean
        Dim wl_eATVEN As New clpEstructuras.eATVEN
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Try
            wg_sNomTblE1 = "ATVEN"
            wg_sNomCmpE11 = "sCodVen"
            wg_sDatCmpE11 = wp_sCod
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)

            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                cpm_eATVEN_DT(wl_eATVEN,
                              wl_DT,
                              wl_nRow)
                wp_eATVEN = wl_eATVEN
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConATVEN")
            Return Nothing
        End Try
    End Function
    Public Function clp_fConFTPUC(ByVal wp_sCod As String,
                                  ByRef wp_eFTPUC As Object) As Boolean
        Dim wl_eFTPUC As New clpEstructuras.eFTPUC
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Try
            wg_sNomTblE1 = "FTPUC"
            wg_sNomCmpE11 = "sCodCta"
            wg_sDatCmpE11 = wp_sCod
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)

            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                cpm_eFTPUC_DT(wl_eFTPUC,
                              wl_DT,
                              wl_nRow)
                wp_eFTPUC = wl_eFTPUC
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConFEPUC")
            Return Nothing
        End Try
    End Function
    Public Function clp_fConTEDMT(ByVal wp_sCod As String,
                                  ByRef wp_eTEDMT As Object) As Boolean
        Dim wl_eTEDMT As New clpEstructuras.eTEDMT
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Try
            wg_sNomTblE1 = "TEDMT"
            wg_sNomCmpE11 = "sCodTer"
            wg_sDatCmpE11 = wp_sCod
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                cpm_eTEDMT_DT(wl_eTEDMT,
                              wl_DT,
                              wl_nRow)
                wp_eTEDMT = wl_eTEDMT
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConTEDMT")
            Return Nothing
        End Try
    End Function
    Public Function clp_fConTbl(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal wp_sDatCmp As String,
                                ByVal wp_sTipCmp As String,
                                ByVal wp_sCmpOrd As String,
                                ByVal wp_sTipOrd As String,
                                ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Try
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_sTipCmp,
                                         wp_sCmpOrd,
                                         wp_sTipOrd,
                                         wr_bEOF)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConTbl")
        End Try
        Return wl_DT
    End Function
    Public Function clp_fConTblE2(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sTipCmp As String,
                                  ByVal wp_sNomCmp1 As String,
                                  ByVal wp_sDatCmp1 As String,
                                  ByVal wp_sTipCmp1 As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Try
            wl_DT = clnConTbl.cndtBuscarE2(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_sTipCmp,
                                         wp_sNomCmp1,
                                         wp_sDatCmp1,
                                         wp_sTipCmp1,
                                         wr_bEOF)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConTbl")
        End Try
        Return wl_DT
    End Function
    Public Function clp_fEliReg(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal wp_sDatCmp As String,
                                ByVal wp_sTipCmp As String,
                                ByRef wr_bEOF As Boolean) As Boolean
        Dim wl_YesNo As Boolean = False
        Dim wl_DT As DataTable
        Try
            wr_bEOF = True
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_sTipCmp,
                                         wp_sCmpOrd,
                                         wp_sTipOrd,
                                         wr_bEOF)
            If Not wr_bEOF Then
                wl_YesNo = clnActTbl.cnEliReg(wp_sNomTbl,
                                              wp_sNomCmp,
                                              wp_sDatCmp,
                                              wp_sTipCmp,
                                              wr_bEOF)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: BD_Eliminar")
        End Try
        Return wl_YesNo
    End Function
    Public Function clp_fConAPDGV() As Array
        Dim wl_aeAPDGV As New clpEstructuras.eAPDGV
        ' Dim va_eaAPDGV() As clpEstructuras.eAPDGV
        Dim wl_i As Integer
        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            wg_sNomTblE1 = "APDGV"
            wg_sNomCmpE11 = "sCodFrm"
            wg_sDatCmpE11 = wp_sNomFrm
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = "nNroCol"
            wg_sTipOrdE11 = "A"
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim va_eaAPDGV(wl_nCntReg) As clpEstructuras.eAPDGV
            wg_nColIni = -1
            wg_nColFin = -1
            For wl_i = 0 To wl_nCntReg
                va_eaAPDGV(wl_i) = New clpEstructuras.eAPDGV
                With va_eaAPDGV(wl_i)
                    '0 nId
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(0)) Then
                        .nID = wl_DT.Rows(wl_i).Item(0)
                    Else
                        .nID = 0
                    End If
                    '1 sCodFrm
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(1)) Then
                        .sCodFrm = wl_DT.Rows(wl_i).Item(1)
                    Else
                        .sCodFrm = ""
                    End If
                    '2 sCodDgv
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(2)) Then
                        .sCodDgv = wl_DT.Rows(wl_i).Item(2)
                    Else
                        .sCodDgv = ""
                    End If
                    '3 nColOri
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(3)) Then
                        .nCol = wl_DT.Rows(wl_i).Item(3)
                    Else
                        .nCol = 0
                    End If
                    '4 nNroCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(4)) Then
                        .nNroCol = wl_DT.Rows(wl_i).Item(4)
                    Else
                        .nNroCol = 0
                    End If
                    '5 sTitCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(5)) Then
                        .sTitCol = wl_DT.Rows(wl_i).Item(5)
                    Else
                        .sTitCol = ""
                    End If
                    '6 sTipCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(6)) Then
                        .sTipCol = wl_DT.Rows(wl_i).Item(6)
                    Else
                        .sTipCol = ""
                    End If
                    '7 bColxDef
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(7)) Then
                        .bColxDef = wl_DT.Rows(wl_i).Item(7)
                    Else
                        .bColxDef = False
                    End If
                    '8 bVisible
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(8)) Then
                        .bVisible = wl_DT.Rows(wl_i).Item(8)
                    Else
                        .bVisible = False
                    End If
                    '9 bReadOnly
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(9)) Then
                        .bReadOnly = wl_DT.Rows(wl_i).Item(9)
                    Else
                        .bReadOnly = False
                    End If
                    '10 bColPor
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(10)) Then
                        .bColPor = wl_DT.Rows(wl_i).Item(10)
                    Else
                        .bColPor = False
                    End If
                    '11 nColNom
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(11)) Then
                        .nColNom = wl_DT.Rows(wl_i).Item(11)
                    Else
                        .nColNom = 0
                    End If
                    '12 nColVlr 
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(12)) Then
                        .nColVlr = wl_DT.Rows(wl_i).Item(12)
                    Else
                        .nColVlr = 0
                    End If
                    '13 sNomDat
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(13)) Then
                        .sNomDat = wl_DT.Rows(wl_i).Item(13)
                    Else
                        .sNomDat = ""
                    End If
                    '14 bDatReq
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(14)) Then
                        .bDatReq = wl_DT.Rows(wl_i).Item(14)
                    Else
                        .bDatReq = False
                    End If
                    '15 sRglVdaDat
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(15)) Then
                        .sRglVdaDat = wl_DT.Rows(wl_i).Item(15)
                    Else
                        .sRglVdaDat = ""
                    End If
                    '16 sCodErrDat
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(16)) Then
                        .sCodErrDat = wl_DT.Rows(wl_i).Item(16)
                    Else
                        .sCodErrDat = ""
                    End If
                    '17 sNomTbl
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(17)) Then
                        .sNomTblVda = wl_DT.Rows(wl_i).Item(17)
                    Else
                        .sNomTblVda = ""
                    End If
                    '18 sRglVdaEOF
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(18)) Then
                        .sRglVdaEOF = wl_DT.Rows(wl_i).Item(18)
                    Else
                        .sRglVdaEOF = ""
                    End If
                    '19 sCodErrEOF
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(19)) Then
                        .sCodErrEOF = wl_DT.Rows(wl_i).Item(19)
                    Else
                        .sCodErrEOF = ""
                    End If
                    '20 sDesOpe
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(20)) Then
                        .sDesOpe = wl_DT.Rows(wl_i).Item(20)
                    Else
                        .sDesOpe = ""
                    End If
                    '21 nColRes
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(21)) Then
                        .nColRes = wl_DT.Rows(wl_i).Item(21)
                    Else
                        .nColRes = 0
                    End If
                    '22 sCodErrOpe
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(22)) Then
                        .sCodErrOpe = wl_DT.Rows(wl_i).Item(22)
                    Else
                        .sCodErrOpe = ""
                    End If
                    '23 nColVda
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(23)) Then
                        .nColVda = wl_DT.Rows(wl_i).Item(23)
                    Else
                        .nColVda = 0
                    End If
                    '24 sRglVdaCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(24)) Then
                        .sRglVdaCol = wl_DT.Rows(wl_i).Item(24)
                    Else
                        .sRglVdaCol = ""
                    End If
                    '25 sCodErrCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(25)) Then
                        .sCodErrCol = wl_DT.Rows(wl_i).Item(25)
                    Else
                        .sCodErrCol = ""
                    End If
                    '26 sDatBas
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(26)) Then
                        .sDatBas = wl_DT.Rows(wl_i).Item(26)
                    Else
                        .sDatBas = ""
                    End If
                    '27 bColTot
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(27)) Then
                        .bColTot = wl_DT.Rows(wl_i).Item(27)
                    Else
                        .bColTot = False
                    End If
                    '28 bGQLst
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(28)) Then
                        .bGQLst = wl_DT.Rows(wl_i).Item(28)
                    Else
                        .bGQLst = False
                    End If
                    '29 sCodErrEOF1
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(29)) Then
                        .sCodErrEOF1 = wl_DT.Rows(wl_i).Item(29)
                    Else
                        .sCodErrEOF1 = ""
                    End If
                    '30 nColCtaInv
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(30)) Then
                        .nColRes = wl_DT.Rows(wl_i).Item(30)
                    Else
                        .nColRes = 0
                    End If
                    '31 nColCosVta
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(31)) Then
                        .nColRes = wl_DT.Rows(wl_i).Item(31)
                    Else
                        .nColRes = 0
                    End If
                    '32 sTblOriDat
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(32)) Then
                        .sCodErrEOF1 = wl_DT.Rows(wl_i).Item(32)
                    Else
                        .sCodErrEOF1 = ""
                    End If

                    '33 nCodDocBas
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(33)) Then
                        .nColRes = wl_DT.Rows(wl_i).Item(33)
                    Else
                        .nColRes = 0
                    End If

                    If va_eaAPDGV(wl_i).bVisible = True Then
                        If wg_nColIni = -1 Then
                            wg_nColIni = wl_i
                        End If
                        wg_nColFin = wl_i
                    End If

                End With
            Next
            Return va_eaAPDGV
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConAPDGV")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConAPQDG(ByVal wp_sCodStr) As Array
        Dim wl_aeAPDGV As New clpEstructuras.eAPDGV
        ' Dim va_eaAPDGV() As clpEstructuras.eAPDGV
        Dim wl_i As Integer
        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            wg_sNomTblE1 = "APQDG"
            wg_sNomCmpE11 = "sCodStr"
            wg_sDatCmpE11 = wp_sCodStr
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = "nNroCol"
            wg_sTipOrdE11 = "A"
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim va_eaAPQDG(wl_nCntReg) As clpEstructuras.eAPQDG



            For wl_i = 0 To wl_nCntReg
                va_eaAPQDG(wl_i) = New clpEstructuras.eAPQDG
                With va_eaAPQDG(wl_i)
                    '0 nId
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(0)) Then
                        .nID = wl_DT.Rows(wl_i).Item(0)
                    Else
                        .nID = 0
                    End If
                    '1 sCodStr
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(1)) Then
                        .sCodStr = wl_DT.Rows(wl_i).Item(1)
                    Else
                        .sCodStr = ""
                    End If
                    '2 nColOri
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(2)) Then
                        .nColOri = wl_DT.Rows(wl_i).Item(2)
                    Else
                        .nColOri = 0
                    End If
                    '3 nNroCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(3)) Then
                        .nNroCol = wl_DT.Rows(wl_i).Item(3)
                    Else
                        .nNroCol = 0
                    End If
                    '4 sTitCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(4)) Then
                        .sTitCol = wl_DT.Rows(wl_i).Item(4)
                    Else
                        .sTitCol = ""
                    End If
                    '5 sTipCol
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(5)) Then
                        .sTipCol = wl_DT.Rows(wl_i).Item(5)
                    Else
                        .sTipCol = ""
                    End If
                    '6 bColxDef
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(6)) Then
                        .bColxDef = wl_DT.Rows(wl_i).Item(6)
                    Else
                        .bColxDef = False
                    End If
                    '7 bVisible
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(7)) Then
                        .bVisible = wl_DT.Rows(wl_i).Item(7)
                    Else
                        .bVisible = False
                    End If
                    '8 bReadOnly
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(8)) Then
                        .bReadOnly = wl_DT.Rows(wl_i).Item(8)
                    Else
                        .bReadOnly = False
                    End If

                End With
            Next
            Return va_eaAPQDG
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConAPQDG")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConIEDMI(ByVal wp_sCodItm As String,
                                  ByRef wr_bEOFE1 As Boolean) As Array
        Dim wl_eIEDMI As New clpEstructuras.eIEDMI

        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            wg_sNomTblE1 = "IEDMI"
            wg_sNomCmpE11 = "sCodItm"
            wg_sDatCmpE11 = wp_sCodItm
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim va_eIEDMI(wl_nCntReg) As clpEstructuras.eIEDMI
            For wl_i = 0 To wl_nCntReg
                With wl_eIEDMI
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(0)) Then
                        .nId = wl_DT.Rows(wl_i).Item(0)
                    Else
                        .nId = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(1)) Then
                        .sCodItm = wl_DT.Rows(wl_i).Item(1)
                    Else
                        .sCodItm = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(2)) Then
                        .sCodBar = wl_DT.Rows(wl_i).Item(2)
                    Else
                        .sCodBar = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(3)) Then
                        .sNomItm = wl_DT.Rows(wl_i).Item(3)
                    Else
                        .sNomItm = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(4)) Then
                        .sNomAlt = wl_DT.Rows(wl_i).Item(4)
                    Else
                        .sNomAlt = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(5)) Then
                        .sClsItm = wl_DT.Rows(wl_i).Item(5)
                    Else
                        .sClsItm = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(6)) Then
                        .sCodGrp = wl_DT.Rows(wl_i).Item(6)
                    Else
                        .sCodGrp = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(7)) Then
                        .sCodSgr = wl_DT.Rows(wl_i).Item(7)
                    Else
                        .sCodSgr = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(8)) Then
                        .bItmInv = wl_DT.Rows(wl_i).Item(8)
                    Else
                        .bItmInv = False
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(9)) Then
                        .bItmVta = wl_DT.Rows(wl_i).Item(9)
                    Else
                        .bItmVta = False
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(10)) Then
                        .bItmCom = wl_DT.Rows(wl_i).Item(10)
                    Else
                        .bItmCom = False
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(11)) Then
                        .bIndIVA = wl_DT.Rows(wl_i).Item(11)
                    Else
                        .bIndIVA = False
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(12)) Then
                        .sCodAlt = wl_DT.Rows(wl_i).Item(12)
                    Else
                        .sCodAlt = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(13)) Then
                        .sTipGes = wl_DT.Rows(wl_i).Item(13)
                    Else
                        .sTipGes = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(14)) Then
                        .bItmAct = wl_DT.Rows(wl_i).Item(14)
                    Else
                        .bItmAct = False
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(15)) Then
                        .bItmIna = wl_DT.Rows(wl_i).Item(15)
                    Else
                        .bItmIna = False
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(16)) Then
                        .sCodTerPrv = wl_DT.Rows(wl_i).Item(16)
                    Else
                        .sCodTerPrv = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(17)) Then
                        .sCodTerFte = wl_DT.Rows(wl_i).Item(17)
                    Else
                        .sCodTerFte = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(18)) Then
                        .sCodItmFte = wl_DT.Rows(wl_i).Item(18)
                    Else
                        .sCodItmFte = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(19)) Then
                        .sUniMedCom = wl_DT.Rows(wl_i).Item(19)
                    Else
                        .sUniMedCom = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(20)) Then
                        .nCanUniCom = wl_DT.Rows(wl_i).Item(20)
                    Else
                        .nCanUniCom = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(21)) Then

                        .sUniEmpCom = wl_DT.Rows(wl_i).Item(21)
                    Else
                        .sUniEmpCom = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(22)) Then
                        .nCanUniECom = wl_DT.Rows(wl_i).Item(22)
                    Else
                        .nCanUniECom = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(23)) Then
                        .sCodItoCom = wl_DT.Rows(wl_i).Item(23)
                    Else
                        .sCodItoCom = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(24)) Then
                        .sUniMedVta = wl_DT.Rows(wl_i).Item(24)
                    Else
                        .sUniMedVta = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(25)) Then
                        .nCanUniVta = wl_DT.Rows(wl_i).Item(25)
                    Else
                        .nCanUniVta = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(26)) Then
                        .sUniEmpVta = wl_DT.Rows(wl_i).Item(26)
                    Else
                        .sUniEmpVta = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(27)) Then
                        .nCanUniEVta = wl_DT.Rows(wl_i).Item(27)
                    Else
                        .nCanUniEVta = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(28)) Then
                        .sCodItoVta = wl_DT.Rows(wl_i).Item(28)
                    Else
                        .sCodItoVta = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(29)) Then
                        .sCriCtaCbe = wl_DT.Rows(wl_i).Item(29)
                    Else
                        .sCriCtaCbe = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(30)) Then
                        .sUniMedInv = wl_DT.Rows(wl_i).Item(30)
                    Else
                        .sUniMedInv = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(31)) Then
                        .sMetVlz = wl_DT.Rows(wl_i).Item(31)
                    Else
                        .sMetVlz = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(32)) Then
                        .nCosItm = wl_DT.Rows(wl_i).Item(32)
                    Else
                        .nCosItm = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(33)) Then
                        .sCodAlm = wl_DT.Rows(wl_i).Item(33)
                    Else
                        .sCodAlm = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(34)) Then
                        .nSdoInv = wl_DT.Rows(wl_i).Item(34)
                    Else
                        .nSdoInv = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(35)) Then
                        .sIvaCom = wl_DT.Rows(wl_i).Item(35)
                    Else
                        .sIvaCom = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(36)) Then
                        .sIvaVta = wl_DT.Rows(wl_i).Item(36)
                    Else
                        .sIvaVta = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(37)) Then
                        .sCodCco = wl_DT.Rows(wl_i).Item(37)
                    Else
                        .sCodCco = ""
                    End If
                End With
                va_eIEDMI(wl_i) = wl_eIEDMI
            Next
            Return va_eIEDMI
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConIEDMI")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConILDMI1(ByVal wp_sCodItm As String,
                                   ByRef wr_bEOFE1 As Boolean) As Array
        Dim wl_aeILDMI1 As New clpEstructuras.eILDMI1
        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            wg_sNomTblE1 = "ILDMI1"
            wg_sNomCmpE11 = "sCodItm"
            wg_sDatCmpE11 = wp_sCodItm
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim va_eILDMI1(wl_nCntReg) As clpEstructuras.eILDMI1
            For wl_i = 0 To wl_nCntReg
                With wl_aeILDMI1
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(0)) Then
                        .nId = wl_DT.Rows(wl_i).Item(0)
                    Else
                        .nId = 0
                    End If
                    .sCodItm = wl_DT.Rows(wl_i).Item(1)
                    .sCodAlm = wl_DT.Rows(wl_i).Item(2)
                    .nCanMin = wl_DT.Rows(wl_i).Item(3)
                    .nCanMax = wl_DT.Rows(wl_i).Item(4)
                    .nOrdMin = wl_DT.Rows(wl_i).Item(5)
                    .nSdoAlm = wl_DT.Rows(wl_i).Item(6)
                    .nPreUni = wl_DT.Rows(wl_i).Item(7)
                    .nVlrTot = wl_DT.Rows(wl_i).Item(8)
                    .sCtaInv = wl_DT.Rows(wl_i).Item(9)
                    ' .sCtaCos = wl_DT.Rows(wl_i).Item(10)
                    .sCtaGto = wl_DT.Rows(wl_i).Item(11)
                    .sCtaIng = wl_DT.Rows(wl_i).Item(12)
                    .sCtaDot = wl_DT.Rows(wl_i).Item(13)
                    .sCtaDifPre = wl_DT.Rows(wl_i).Item(14)
                    .sCtaDsv = wl_DT.Rows(wl_i).Item(15)
                    ' .sCtaDev = wl_DT.Rows(wl_i).Item(16)
                    .sCtaRev = wl_DT.Rows(wl_i).Item(17)
                End With
                va_eILDMI1(wl_i) = wl_aeILDMI1
            Next
            Return va_eILDMI1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConstrILDMI1")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConITALM(ByVal wp_sCodAlm As String,
                                  ByRef wr_bEOFE1 As Boolean) As Array
        Dim vl_eITALM As New clpEstructuras.eITALM

        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            wg_sNomTblE1 = "ITALM"
            wg_sNomCmpE11 = "sCodAlm"
            wg_sDatCmpE11 = wp_sCodAlm
            wg_sTipCmpE11 = "S"
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                         wg_sNomCmpE11,
                                         wg_sDatCmpE11,
                                         wg_sTipCmpE11,
                                         wg_sCmpOrdE11,
                                         wg_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim vl_aeITALM(wl_nCntReg) As clpEstructuras.eITALM


            For wl_i = 0 To wl_nCntReg
                vl_eITALM = New clpEstructuras.eITALM

                With vl_eITALM

                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(0)) Then
                        .nId = wl_DT.Rows(wl_i).Item(0)
                    Else
                        .nId = 0
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(1)) Then
                        .sCodAlm = wl_DT.Rows(wl_i).Item(1)
                    Else
                        .sCodAlm = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(2)) Then
                        .sNomAlm = wl_DT.Rows(wl_i).Item(2)
                    Else
                        .sNomAlm = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(3)) Then
                        .sCtaInv = wl_DT.Rows(wl_i).Item(3)
                    Else
                        .sCtaInv = ""
                    End If
                    If Not IsDBNull(wl_DT.Rows(wl_i).Item(4)) Then
                        .sCtaCosVta = wl_DT.Rows(wl_i).Item(4)
                    Else
                        .sCtaCosVta = ""
                    End If
                End With
                vl_aeITALM(wl_i) = vl_eITALM
            Next
            Return vl_aeITALM
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConITALM")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConPEODP(ByVal wp_sCodDoc As String,
                                  ByVal wp_nNroDoc As Long,
                                  ByRef wp_ePEODP As Object) As Boolean
        Dim wl_ePEODP As New clpEstructuras.ePEODP
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPEODP.cndtConsultarPEODP(wp_sCodDoc,
                                                    wp_nNroDoc,
                                                    wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                cpm_ePEODP_DT(wl_ePEODP,
                              wl_DT,
                              wl_nRow)
                wp_ePEODP = wl_ePEODP
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConPEODP")
            Return Nothing
        End Try

    End Function
    Public Function clp_fConSdoAlm(ByVal wp_sCodItm,
                                   ByVal wp_sCodAlm,
                                   ByRef wr_bEOFE2) As Array
        Dim wl_eIELDMI1 As New clpEstructuras.eIELDMI1

        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            wg_sNomTblE2 = "ILDMI1"
            wg_sNomCmpE21 = "sCodItm"
            wg_sDatCmpE21 = wp_sCodItm
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodAlm"
            wg_sDatCmpE22 = wp_sCodAlm
            wg_sTipCmpE22 = "S"
            wr_bEOFE2 = False
            wl_DT = clnIEDMI.cndtConSdoILMDI1(wp_sCodAlm,
                                              wp_sCodItm,
                                              wr_bEOFE2)
            wl_nCntReg = wl_DT.Rows.Count

            ReDim wl_aeIELDMI1(wl_nCntReg)
            cpm_aeIELDMI1_DT(wl_aeIELDMI1,
                            wl_DT)
            Return wl_aeIELDMI1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConSdoAlm")
            Return Nothing
        End Try

    End Function
    Public Function clp_fQ2Cmp(ByVal wp_sNomTbl As String,
                               ByRef wr_sCod As String,
                               ByRef wr_nNro As Long) As Boolean
        Dim wl_frmLst As New frmGQLst
        wg_sTblCon1 = wp_sNomTbl
        wg_sSelCon11 = ""
        wg_sSelCon12 = ""
        wg_nSelCon13 = 0
        wg_nSelCon14 = 0
        wr_bEOFCon1 = True
        wl_frmLst.ShowDialog()
        wr_sCod = wg_sSelCon11
        wr_nNro = wg_nSelCon13
        Return wr_bEOFCon1
    End Function
#End Region
#Region "Limpiar controles"
    Public Sub clp_fLmpCtrl(ByVal wp_VlrCtrl As Control)
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If oCtrl.TabIndex = 1 Then
                oCtrl.Focus()
            End If
            If TypeOf oCtrl Is TextBox Then
                oCtrl.Text = String.Empty
            End If
            If TypeOf oCtrl Is ComboBox Then
                oCtrl.selectedValue = String.Empty
            End If
            If TypeOf oCtrl Is RadioButton Then
                oCtrl.Checked = False
            End If
            If TypeOf oCtrl Is CheckBox Then
                oCtrl.Checked = False
            End If
            If TypeOf oCtrl Is GroupBox Then
                clp_fLmpCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                clp_fLmpCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabControl Then
                clp_fLmpCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabPage Then
                clp_fLmpCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is SplitContainer Then
                clp_fLmpCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is DataTable Then
                oCtrl.Dispose()
            End If
            If TypeOf oCtrl Is DataSet Then
                oCtrl.Dispose()
            End If
            If TypeOf oCtrl Is MaskedTextBox Then
                oCtrl.Text = String.Empty
            End If
            If TypeOf oCtrl Is DataGridView Then
                oCtrl.Rows.Clear()
            End If
        Next
    End Sub
#End Region
#Region "Configurar frm"
    Public Sub clp_ffmrCtrl(ByVal wp_VlrCtrl As Form)
        If vg_sClrFrm = "AliceBlue" Then
            wp_VlrCtrl.BackColor = Color.AliceBlue
        End If
        If vg_sClrFrm = "GhostWhite" Then
            wp_VlrCtrl.BackColor = Color.GhostWhite
        End If
        If vg_sClrFrm = "WhiteSmoke" Then
            wp_VlrCtrl.BackColor = Color.WhiteSmoke
        End If
        If vg_sClrFrm = "OldLace" Then
            wp_VlrCtrl.BackColor = Color.OldLace
        End If

        If vg_sClrFrm = "FloralWhite" Then
            wp_VlrCtrl.BackColor = Color.FloralWhite
        End If
        If vg_sClrFrm = "Snow" Then
            wp_VlrCtrl.BackColor = Color.Snow
        End If
        If vg_sClrFrm = "SeaShell" Then
            wp_VlrCtrl.BackColor = Color.SeaShell
        End If
        If vg_sClrFrm = "Linen" Then
            wp_VlrCtrl.BackColor = Color.Linen
        End If
        If vg_sClrFrm = "Ivory" Then
            wp_VlrCtrl.BackColor = Color.Ivory
        End If
        If vg_sClrFrm = "Honeydew" Then
            wp_VlrCtrl.BackColor = Color.Honeydew
        End If
        If vg_sClrFrm = "MintCream" Then
            wp_VlrCtrl.BackColor = Color.MintCream
        End If
        If vg_sClrFrm = "Azure" Then
            wp_VlrCtrl.BackColor = Color.Azure
        End If
        If vg_sClrFrm = "Lavender" Then
            wp_VlrCtrl.BackColor = Color.Lavender
        End If
    End Sub
#End Region
#Region "Configurar Textbox"
    Public Sub clp_fCnfCtrl(ByVal wp_VlrCtrl As Control)
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                oCtrl.AutoSize = False
                oCtrl.Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                oCtrl.Height = 20
            End If
            If TypeOf oCtrl Is MaskedTextBox Then
                oCtrl.AutoSize = False
                oCtrl.Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                oCtrl.Height = 20
            End If
            If TypeOf oCtrl Is ComboBox Then
                oCtrl.AutoSize = False
                oCtrl.Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                oCtrl.Height = 20
            End If
        Next
    End Sub
#End Region
#Region "Iniciar variables globales"
    Public Sub clp_IniciarVar()

        'Opciones

        wp_sCmdSel = ""

        'Tablas

        wp_sNomTbl = ""
        wp_sNomCmp = ""
        wp_sTipCmp = "" 'wlTipCmp: N umérico. F echa, C adena
        wp_sDatCmp = ""
        wp_sDatSel = ""
        wp_sTitCmp = ""

        wp_sNomCmp1 = ""
        wp_sTipCmp1 = "" 'wlTipCmp1: N umérico. F echa, C adena
        wp_sDatCmp1 = ""
        wp_sDatSel1 = ""
        wp_sTitCmp1 = ""


        wp_sNomLla = ""
        wp_sDatLla = ""
        wp_sTipLla = "" 'wlTipLla : N umérico. F echa, C adena

        'Tablas- Encabezado

        wg_sNomTblE1 = ""
        wg_sNomCmpE11 = ""
        wg_sDatCmpE11 = ""
        wg_sDatSelE11 = ""
        wg_sTipCmpE11 = ""
        wg_sTitCmpE11 = ""
        wg_sNomCmpE12 = ""
        wg_sDatCmpE12 = ""
        wg_sDatSelE12 = ""
        wg_sTipCmpE12 = ""
        wg_sTitCmpE12 = ""


        wg_sNomTblE2 = ""
        wg_sNomCmpE21 = ""
        wg_sDatCmpE21 = ""
        wg_sDatSelE21 = ""
        wg_sTipCmpE21 = ""
        wg_sTitCmpE21 = ""


        'Tablas- Líneas    

        wg_sNomTblL1 = ""
        wg_sNomCmpL11 = ""
        wg_sDatCmpL11 = ""
        wg_sDatSelL11 = ""
        wg_sTipCmpL11 = ""
        wg_sTitCmpL11 = ""
        wg_sNomCmpL12 = ""
        wg_sDatCmpL12 = ""
        wg_sDatSelL12 = ""
        wg_sTipCmpL12 = ""
        wg_sTitCmpL12 = ""


        'Tablas- Listas, ComboBox

        wg_sTblLst1 = ""
        wg_sCmpLst1 = ""
        wg_sDatLst1 = ""
        wg_sTipLst1 = ""

        '
        'Tablas- Listas, Errores, Mensajes

        wg_sTblErr1 = ""

        wg_sCodErrAdi = " "
        wg_sCodErrCon = " "
        wg_sCodErrOk = " "

        wg_sDesMsgEli = ""
        wg_sTitMsgEli = ""
        '

        'Tablas- Consultas

        wg_sTblCon1 = ""
        wg_sCmpCon11 = ""
        wg_sDatCon11 = ""
        wg_sSelCon11 = ""
        wg_sTitCon11 = ""
        wg_sCmpCon12 = ""
        wg_sDatCon12 = ""
        wg_sSelCon12 = ""
        wg_sTitCon12 = ""


        'TSB

        ' wl_nClaPpltsb: 1 - un campo, 2 - dos campos
        ' wl_sCmptsb1: nombre del campo de busqueda
        ' wl_nCmpCla: 1 - nId, 2 - Llave principal 

        wg_nClaPpltsb = 0
        wg_nCmpCla = 0
        wg_sClaPpl = ""
        wg_sCmpTSB = ""
        wg_sDatTSB = ""
        wg_sTipCmpTSB = ""
        wg_sCmpTSB1 = ""
        wg_sDatTSB1 = ""
        wg_sTipCmpTSB1 = ""
        wg_sCmpTSB2 = ""
        wg_sDatTSB2 = ""
        wg_sTipCmpTSB2 = ""

        ' Otras

        wg_sTipTbl = ""
        wg_sNomFrm = ""
        wg_tsbboton = ""

        ' configuración datagridview
        wg_RowAncho = 30
        wg_RowAlto = 10
        wg_ColAlto = 18
        wg_nColFin = 0
        wg_nColIni = 0
    End Sub

#End Region
#Region "Configurar dgv"
    Public Sub clp_ConfigurarDGV(ByVal wp_VlrCtrl As DataGridView,
                                 ByVal wp_nTotCol As Integer)
        Dim wl_dgvrows As New DataGridViewRow
        wl_dgvrows.Height = 15


        wg_ColAlto = 16



        With wp_VlrCtrl
            'Propiedades iniciales
            .AutoSize = False
            .Dock = DockStyle.Fill
            .BackgroundColor = wg_ClrFrm
            .BorderStyle = BorderStyle.FixedSingle
            .TopLeftHeaderCell.Value = "Nro"
            '.Font = New System.Drawing.Font("Sans Serif", 8.0!, System.Drawing.FontStyle.Regular)
            .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
            ' Propiedades
            'Rows

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowTemplate.Height = wg_RowAlto
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AllowUserToResizeRows = False
            .RowHeadersWidth = wg_RowAncho
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty


           

            ' Columns
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .ColumnHeadersHeight = wg_ColAlto
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            ' .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            '.MultiSelect = True
            .EnableHeadersVisualStyles = False
            .ColumnCount = wp_nTotCol

        End With
    End Sub
    Public Sub clp_DGVFormatCol(ByVal wp_VlrCtrl As DataGridView,
                                ByVal wp_nCol As Integer,
                                ByVal wp_sTipCol As String,
                                ByVal wp_bVisible As Boolean,
                                ByVal wp_bReadOnly As Boolean)

        For Each oCtrl As Object In wp_VlrCtrl.Columns
            wp_VlrCtrl.Columns(wp_nCol).Visible = wp_bVisible
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.WrapMode = DataGridViewTriState.False
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.SelectionBackColor = wg_ClrGot
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.ForeColor = Color.Black
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            If wp_sTipCol = "D" Then
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###,###,###,###.##"

                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "N" Then
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###,###,###,###"

                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "C" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###,###,###,###.00"
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "C"
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "S" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.String)
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "F" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.DateTime)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "d"
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "B" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Boolean)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "b"

                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
        Next

    End Sub
    Public Sub clp_DGVFormatRow(ByVal wp_VlrCtrl As DataGridView,
                                  ByVal wp_nCol As Integer,
                                  ByVal wp_sTipCol As String,
                                  ByVal wp_bVisible As Boolean,
                                  ByVal wp_bReadOnly As Boolean)

        For Each oCtrl As Object In wp_VlrCtrl.Columns
            wp_VlrCtrl.Columns(wp_nCol).Visible = wp_bVisible
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.WrapMode = DataGridViewTriState.False
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.SelectionBackColor = wg_ClrGot
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.ForeColor = Color.Black
            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            If wp_sTipCol = "N" Then
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###,###,###,###.00"

                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "C" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###,###,###,###.00"
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "C"
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "S" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.String)
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
            If wp_sTipCol = "D" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.DateTime)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "d"
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bReadOnly Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrEnable
                End If
                Exit For
            End If
        Next

    End Sub


#End Region

#Region "Cálculos"
    Public Sub clp_fOpe_16(ByRef wp_VlrCtrl As DataGridView,
                           ByVal wp_nRow As Integer)

        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(16).Value = .Rows(wp_nRow).Cells(9).Value * .Rows(wp_nRow).Cells(11).Value
            End With

        Catch ex As Exception
            MsgBox("Error : clp_fOpe_16")
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region
End Module

