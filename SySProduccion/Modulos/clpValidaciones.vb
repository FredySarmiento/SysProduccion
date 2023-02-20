Module clpValidaciones


    Public Function cpf_VdaDat01() As Boolean


        Return True
    End Function
    
    Public Function cpf_VdaATCCO(ByVal wp_sCod As String,
                                 ByRef wl_eATCCO As Object) As Boolean
        Try
            Dim va_eATCCO As New clpEstructuras.eATCCO

            wg_sTblCon1 = "ATCCO"
            wg_sCmpCon11 = "sCodCCo"
            wg_sDatCon11 = wp_sCod
            wg_sTipCon11 = "S"
            wg_sCmpOrdE21 = ""
            wg_sTipOrdE21 = ""
            wr_bEOFE2 = False
            wg_DTE2 = clnConTbl.cndtBuscar(wg_sTblCon1,
                                           wg_sCmpCon11,
                                           wg_sDatCon11,
                                           wg_sTipCon11,
                                           wg_sCmpOrdE21,
                                           wg_sTipOrdE21,
                                           wr_bEOFE2)

            If Not wr_bEOFE2 Then



                wl_eATCCO = va_eATCCO
            End If
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaATCCO")
            Throw ex
        End Try
        Return wr_bEOFE2
    End Function
    Public Function cpf_VdaATIVA(ByVal wp_sCod As String,
                                 ByRef wp_sNom As String,
                                 ByRef wp_nVlr As Double,
                                 ByVal vp_sClsDoc As String) As Boolean
        Try
            wp_sNom = ""
            wp_nVlr = 0
            wg_sTblCon2 = "ATIVA"
            wg_sCmpCon21 = "sCodIva"
            wg_sDatCon21 = wp_sCod
            wg_sTipCon21 = "S"
            wg_sCmpCon21 = "sClsDoc"
            wg_sDatCon21 = vp_sClsDoc
            wg_sDatCon21 = wp_sCod
            wg_sTipCon21 = "B"
            wr_bEOFE2 = False
            wg_DTE2 = clnConTbl.cndtBuscarE2(wg_sTblCon1,
                                             wg_sCmpCon11,
                                             wg_sDatCon11,
                                             wg_sTipCon11,
                                             wp_sNomCmp1,
                                             wg_sDatCon21,
                                             wg_sTipCon21,
                                             wr_bEOFE2)
            If Not wr_bEOFE2 Then
                wp_sNom = wg_DTE2.Rows(0).Item(2)
                wp_nVlr = wg_DTE2.Rows(0).Item(3)
            End If
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaATIVA")
            Throw ex
        End Try
        Return wr_bEOFE2
    End Function
    Public Function cpf_VdaATVEN(ByVal wp_sCod As String,
                                 ByRef wp_sNom As String) As Boolean
        Try
            wp_sNom = ""
            wg_sTblCon1 = "ATVEN"
            wg_sCmpCon11 = "sCodVen"
            wg_sDatCon11 = wp_sCod
            wg_sTipCon11 = "S"
            wg_sCmpOrdE21 = ""
            wg_sTipOrdE21 = ""
            wr_bEOFE2 = False
            wg_DTE2 = clnConTbl.cndtBuscar(wg_sTblCon1,
                                           wg_sCmpCon11,
                                           wg_sDatCon11,
                                           wg_sTipCon11,
                                           wg_sCmpOrdE21,
                                           wg_sTipOrdE21,
                                           wr_bEOFE2)
            If Not wr_bEOFE2 Then
                wp_sNom = wg_DTE2.Rows(0).Item(2)
            End If
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaATVEN")
            Throw ex
        End Try
        Return wr_bEOFE2

    End Function

    Public Function cpf_VdaIEDMI(ByVal wp_sCod As String,
                                 ByRef wl_aeIEDMI As Array) As Boolean
        Try
            wr_bEOFE2 = False
            wl_aeIEDMI = clp_fConIEDMI(wp_sCod,
                                       wr_bEOFE2)
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaIEDMI")
            Throw ex
        End Try
        Return wr_bEOFE2
    End Function

    Public Function cpf_VdaSdoAlm(ByVal wp_sCodItm As String,
                                  ByVal wp_sCodAlm As String,
                                  ByRef wp_aeIELDMI1 As Array) As Boolean

        Try
            wr_bEOFE2 = False
            wp_aeIELDMI1 = clp_fConSdoAlm(wp_sCodItm,
                                          wp_sCodAlm,
                                          wr_bEOFE2)
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaSdoAlm")
            Throw ex
        End Try
        Return wr_bEOFE2
    End Function
    Public Function cpf_VdaITALM(ByVal wp_sCod As String,
                                 ByRef wl_aeITALM As Array) As Boolean
        Try
            wg_sTblCon1 = "ITALM"
            wg_sCmpCon11 = "sCodAlm"
            wg_sDatCon11 = wp_sCod
            wg_sTipCon11 = "S"
            wg_sCmpOrdE21 = ""
            wg_sTipOrdE21 = ""
            wr_bEOFE2 = False
            wg_DTE2 = clnConTbl.cndtBuscar(wg_sTblCon1,
                                           wg_sCmpCon11,
                                           wg_sDatCon11,
                                           wg_sTipCon11,
                                           wg_sCmpOrdE21,
                                           wg_sTipOrdE21,
                                           wr_bEOFE2)
            wl_aeITALM = clp_fConITALM(wp_sCod,
                                       wr_bEOFE2)


            ' If Not wr_bEOFE2 Then
            'wp_sNom = wg_DTE2.Rows(0).Item(2)
            'End If
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaITALM")
            Throw ex
        End Try
        Return wr_bEOFE2
    End Function
    Public Function cpf_VdaFTPUC(ByVal wp_sCod As String,
                                 ByRef wp_sNom As String) As Boolean
        Try
            wp_sNom = ""
            wg_sTblCon1 = "FTPUC"
            wg_sCmpCon11 = "sCodCta"
            wg_sDatCon11 = wp_sCod
            wg_sTipCon11 = "S"
            wg_sCmpOrdE21 = ""
            wg_sTipOrdE21 = ""
            wr_bEOFE2 = False
            wg_DTE2 = clnConTbl.cndtBuscar(wg_sTblCon1,
                                           wg_sCmpCon11,
                                           wg_sDatCon11,
                                           wg_sTipCon11,
                                           wg_sCmpOrdE21,
                                           wg_sTipOrdE21,
                                           wr_bEOFE2)
            If Not wr_bEOFE2 Then
                wp_sNom = wg_DTE2.Rows(0).Item(2)
            End If
        Catch ex As Exception
            MsgBox("Error : clpValidaciones.cpf_VdaFTPUC")
            Throw ex
        End Try
        Return wr_bEOFE2
    End Function

    Public Function cpf_VdaPEODP() As Boolean

        Return True
    End Function
    Public Function cpf_VdaTEDMT() As Boolean

        Return True
    End Function
#Region "DGV"
    Public Sub clp_dgv_VdaCel(ByVal wp_nColCur As Integer,
                              ByVal wp_nColVda As Integer,
                              ByVal wp_nColSig As Integer,
                              ByVal wp_nRowCur As Integer,
                              ByVal wp_nRowVda As Integer,
                              ByVal wp_nRowSig As Integer,
                              ByVal wp_DGV1 As DataGridView)

        Dim wl_nColCur As Integer
        Dim wl_nColAnt As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long


        wg_eAPDGV = New clpEstructuras.eAPDGV

        wl_nColCur = wp_nColCur
        wl_nColAnt = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nRow = wp_nRowCur
        wl_nCol = wl_nColCur

        Try
            With wp_DGV1

                wl_eATCCO = New clpEstructuras.eATCCO
                wl_eATIVA = New clpEstructuras.eATIVA
                wl_eATVEN = New clpEstructuras.eATVEN
                wl_eFTPUC = New clpEstructuras.eFTPUC
                wl_eIEDMI = New clpEstructuras.eIEDMI
                wl_eIELDMI1 = New clpEstructuras.eIELDMI1
                wl_eITALM = New clpEstructuras.eITALM
                wl_eGLMOV1 = New clpEstructuras.eGLMOV1
                wl_eTEDMT = New clpEstructuras.eTEDMT

                ReDim wl_aeATCCO(0)
                ReDim wl_aeATIVA(0)
                ReDim wl_aeATVEN(0)
                ReDim wl_aeFTPUC(0)
                ReDim wl_aeIEDMI(0)
                ReDim wl_aeIELDMI1(0)
                ReDim wl_aeITALM(0)
                ReDim wl_aeGLMOV1(0)
                ReDim wl_aeTEDMT(0)

                cpm_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                      wp_DGV1,
                                      wl_nRow)
                wl_nRow = wp_DGV1.CurrentCellAddress.Y
                wl_nCol = wp_DGV1.CurrentCellAddress.X
                wp_nColNom = wp_nColVda
                wp_nColVlr = wp_nColVda
                wp_nColNroBas = wp_nColVda
                wp_nColDocBas = wl_nCol
                wp_sNomTbl = ""
                wp_sCodErr = ""
                wg_eAPDGV = wg_aeAPDGV(wp_nColVda)
                wl_nNro = 0
                wl_sCod = ""
                If wg_eAPDGV.sTipCol = "N" Then
                    wl_nNro = wp_DGV1.CurrentRow.Cells(wp_nColVda).Value
                Else
                    wl_sCod = wp_DGV1.CurrentRow.Cells(wp_nColVda).Value
                End If


                If wg_eAPDGV.sRglVdaEOF <> "" Then
                    wp_bVdaEOF = True
                    '  wp_sRglVdaEOF = wl_eAPDGV.sRglVdaEOF
                    wp_sNomTbl = wg_eAPDGV.sNomTblVda
                    wp_sCodErr = wg_eAPDGV.sCodErrEOF
                    wp_sCodErrEOF1 = wg_eAPDGV.sCodErrEOF1
                    wp_nColRes = wg_eAPDGV.nColRes
                    wp_nColNom = wg_eAPDGV.nColNom
                    wp_nColDocBas = wg_eAPDGV.nColDocBas
                    wp_nColVlr = wg_eAPDGV.nColVlr
                    ' wp_nColDocBas = wl_eAPDGV.nColDocBas
                    If wl_sCod = Nothing Then
                        wp_bVdaEOF = True
                        wp_bVdaEOF = clp_fQ2Cmp(wp_sNomTbl,
                                                wl_sCod,
                                                wl_nNro)
                        wp_nColSig = wg_eAPDGV.nColVda
                    End If
                    If wl_sCod = Nothing Then
                        wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nColAnt)
                        Exit Sub
                    End If
                    wg_eGLMOV1 = New clpEstructuras.eGLMOV1
                    cpm_eGLMOV1_DGVGLMOV1(wg_eGLMOV1,
                                          wp_DGV1,
                                          wl_nRow)

                    Select Case wg_eAPDGV.sRglVdaEOF
                        Case "cpf_VdaATCCO"
                            wp_bVdaEOF = clp_fConATCCO(wl_sCod,
                                                       wl_eATCCO)
                            If wp_bVdaEOF = False Then
                                cpm_DgvGLMOV1_eATCCO(wl_eATCCO,
                                                     wp_DGV1,
                                                     wl_nRow)
                            End If
                        Case "cpf_VdaATIVA"
                            wp_bVdaEOF = clp_fConATIVA(wl_sCod,
                                                       wl_eATIVA)
                            If wp_bVdaEOF = False Then
                                cpm_DgvGLMOV1_eATIVA(wl_eATIVA,
                                                     wp_DGV1,
                                                     wl_nRow)
                            End If
                        Case "cpf_VdaATVEN"
                            wp_bVdaEOF = clp_fConATVEN(wl_sCod,
                                                      wl_eATVEN)
                            If wp_bVdaEOF = False Then
                                cpm_DgvGLMOV1_eATVEN(wl_eATVEN,
                                                     wp_DGV1,
                                                     wl_nRow)
                            End If
                        Case "cpf_VdaFTPUC"
                            wp_bVdaEOF = clp_fConFTPUC(wl_sCod,
                                                       wl_eFTPUC)
                            If wp_bVdaEOF = False Then
                                cpm_DgvGLMOV1_eFTPUC(wl_eFTPUC,
                                                     wp_DGV1,
                                                     wl_nRow)
                            End If
                        Case "cpf_VdaIEDMI"
                            wp_bVdaEOF = cpf_VdaIEDMI(wl_sCod,
                                                      wg_aeIEDMI)
                            If wp_bVdaEOF = False Then
                                wl_eIEDMI = wg_aeIEDMI(0)
                                wp_bVdaEOF = False
                                wp_sCodErr = wp_sCodErrEOF1
                                wp_bVdaEOF = cpf_VdaSdoAlm(wl_eIEDMI.sCodItm,
                                                           wl_eIEDMI.sCodAlm,
                                                           wg_aeIELDMI1)
                                If wp_bVdaEOF = False Then
                                    wl_eIELDMI1 = wg_aeIELDMI1(0)
                                    cpm_DGVGLMOV1_eIELDMI1(wl_eIELDMI1,
                                                           wp_DGV1,
                                                           wl_nRow)
                                End If
                            End If
                        Case "cpf_VdaIELDMI1"
                            wp_bVdaEOF = cpf_VdaITALM(wl_sCod,
                                                      wg_aeITALM)

                            If wp_bVdaEOF = False Then
                                wl_eITALM = wg_aeITALM(0)
                                If wl_eGLMOV1.sCodItm = Nothing Then
                                    cpm_DGVGLMOV1_eITALM(wl_eITALM,
                                                         wp_DGV1,
                                                         wl_nRow)
                                Else
                                    wp_bVdaEOF = False
                                    wp_sCodErr = wp_sCodErrEOF1
                                    wp_bVdaEOF = cpf_VdaSdoAlm(wl_eGLMOV1.sCodItm,
                                                               wl_eITALM.sCodAlm,
                                                               wg_aeIELDMI1)
                                    If wp_bVdaEOF = False Then
                                        wl_eIELDMI1 = wg_aeIELDMI1(0)
                                        cpm_DGVGLMOV1_eIELDMI1(wl_eIELDMI1,
                                                               wp_DGV1,
                                                               wl_nRow)
                                    End If
                                End If
                            End If

                        Case "cpf_VdaPEODP"
                            wp_bVdaEOF = clp_fConPEODP(wl_sCod,
                                                       wl_nNro,
                                                       wl_ePEODP)
                            If wp_bVdaEOF = False Then
                                cpm_DGVGLMOV1_ePEODP(wl_ePEODP,
                                                     wp_DGV1,
                                                     wl_nRow)
                            End If

                        Case "cpf_VdaTEDMT"
                            wp_bVdaEOF = clp_fConTEDMT(wl_sCod,
                                                       wl_eTEDMT)
                            If wp_bVdaEOF = False Then
                                cpm_DGVGLMOV1_eTEDMT(wl_eTEDMT,
                                                     wp_DGV1,
                                                     wl_nRow)
                            End If
                    End Select
                End If
                If wp_bVdaEOF = True Then
                    clp_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wl_nCol = wl_nColAnt
                    wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

            'dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColSig)
        Catch ex As Exception
            MsgBox("Error :  dgv_VdaCel")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


End Module
