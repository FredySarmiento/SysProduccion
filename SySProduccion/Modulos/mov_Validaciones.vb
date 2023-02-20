' mov - Módulo de la validaciones
Module mov_Validaciones
    Dim wl_sNomTbl As String = ""
    Dim wl_sDatCmp As String = ""
    Dim wl_sCodErr As String = ""
    Public Function mov_VdaDat01() As Boolean


        Return True
    End Function


#Region "DGV - Validación de celdas"
    Public Sub mov_dgv_VdaAPQDG(ByRef wp_nColCur As Integer,
                                ByVal wp_nColVda As Integer,
                                ByVal wp_nColSig As Integer,
                                ByVal wp_nRowCur As Integer,
                                ByVal wp_nRowVda As Integer,
                                ByVal wp_nRowSig As Integer,
                                ByRef wp_DGV1 As DataGridView,
                                ByVal wp_aeAPQDG As Object)

        'Fec_Ult_Mod : 2014-10-22

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer
        Dim wl_eAPQDG As moe_Estructuras.eAPQDG
        Dim wl_Qry_eILDMI2 = New moe_Estructuras.Qry_eILDMI2
        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV1.CurrentCellAddress.Y
        wl_nCol = wp_DGV1.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eATCCO = New moe_Estructuras.eATCCO
            Dim wl_eATIVA = New moe_Estructuras.eATIVA
            Dim wl_eATVEN = New moe_Estructuras.eATVEN
            Dim wl_eATALM = New moe_Estructuras.eATALM
            Dim wl_eFTPUC = New moe_Estructuras.eFTPUC
            Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
            Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            Dim wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
            Dim wl_eTEDMT = New moe_Estructuras.eTEDMT
            Dim wl_eILDMI2 = New moe_Estructuras.eILDMI2
            Dim wl_aeATCCO() As moe_Estructuras.eATCCO
            Dim wl_aeATIVA() As moe_Estructuras.eATIVA
            Dim wl_aeATVEN() As moe_Estructuras.eATVEN
            Dim wl_aeATALM() As moe_Estructuras.eATALM
            Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC
            Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
            Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
            Dim wl_aeTEDMT() As moe_Estructuras.eTEDMT
            Dim wl_aeILDMI2() As moe_Estructuras.eILDMI2


            wl_eAPQDG = wp_aeAPQDG(wl_nColVda)
            wl_nColOri = wl_eAPQDG.nColOri
            wl_nNroCol = wl_eAPQDG.nNroCol
            ReDim wl_aeATCCO(0)
            ReDim wl_aeATIVA(0)
            ReDim wl_aeATVEN(0)
            ReDim wl_aeFTPUC(0)
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeIELDMI1(0)
            ReDim wl_aeATALM(0)
            ReDim wl_aeGLMOV1(0)
            ReDim wl_aeTEDMT(0)
            ReDim wl_aeILDMI2(0)
            wl_bEOF = True
            If wl_eAPQDG.sCodStr = "QRY_EILDMI2" Then
                moo_Qry_eILDMI2_DGV(wl_Qry_eILDMI2,
                                    wp_DGV1,
                                    wl_nRow)
                With wl_Qry_eILDMI2
                    '1
                    wl_sCodErr = ""
                    wp_bVdaEOF = True
                    wp_sDatCmp = wl_sCod
                    Select Case UCase(wl_eAPQDG.sNomCmp)
                        Case "SCODITM" '1
                            wp_bVdaEOF = mof_fConIEDMI(.eILDMI2.sCodItm,
                                                      wl_eIEDMI)
                            If wp_bVdaEOF = False Then
                                wl_sCodErr = "10-101"


                            End If
                        Case "SCODTER" '2
                            wp_bVdaEOF = mof_fConTEDMT(.eILDMI2.sCodTer,
                                                       wl_eTEDMT)
                            If wp_bVdaEOF = True Then
                                wl_sCodErr = "10-108"
                            Else
                                .sNomTer = wl_eTEDMT.sNomTer
                            End If
                    End Select
                    If wl_sCodErr <> "" Then
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        wp_nColCur = wl_nColVda
                        wl_nCol = wl_nColVda
                        wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                        Exit Sub
                    Else
                        moo_DGV_Qry_eILDMI2(wp_DGV1,
                                            wl_Qry_eILDMI2,
                                            wl_nRow)
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaAPQDG")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaIEDMI(ByRef wp_nColCur As Integer,
                                ByVal wp_nColVda As Integer,
                                ByVal wp_nColSig As Integer,
                                ByVal wp_nRowCur As Integer,
                                ByVal wp_nRowVda As Integer,
                                ByVal wp_nRowSig As Integer,
                                ByRef wp_DGV1 As DataGridView,
                                ByVal wp_aeAPDGV As Object)

        'Fec_Ult_Mod : 2015.02.03

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer
        Dim wl_eAPDGV As moe_Estructuras.eAPDGV
        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV1.CurrentCellAddress.Y
        wl_nCol = wp_DGV1.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eATALM = New moe_Estructuras.eATALM
            Dim wl_eFTPUC = New moe_Estructuras.eFTPUC
            Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
            Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            Dim wl_eILDMI1 = New moe_Estructuras.eILDMI1
            Dim wl_aeATALM() As moe_Estructuras.eATALM
            Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC
            Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
            Dim wl_aeILDMI1() As moe_Estructuras.eILDMI1

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol

            ReDim wl_aeFTPUC(0)
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeIELDMI1(0)
            ReDim wl_aeATALM(0)
            ReDim wl_aeILDMI1(0)
            wl_bEOF = True
            moo_eILDMI1_DGV(wl_eILDMI1,
                            wp_DGV1,
                            wl_nRow)
            With wl_eILDMI1
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODALM"
                        wp_bVdaEOF = mof_fConATALM(.sCodAlm,
                                                  wl_eATALM)
                        If wp_bVdaEOF = False Then
                            wp_DGV1.Rows(wl_nRow).Cells("sCodAlm").Value = wl_eATALM.sCodAlm
                            .sCodAlm = wl_eATALM.sCodAlm
                            moo_DGVILDMI1_eATALM(wp_DGV1,
                                                 wl_eATALM,
                                                 wl_nRowCur)


                        Else
                            wl_sCodErr = "10-103"
                        End If
                    Case "SCTAINV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaInv,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTACOSVTA"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaCosVta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTATRS"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaTrs,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAING"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaIng,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTADEVVTA"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaDevVta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAVRC"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaVrc,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAGTO"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaGto,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTADOT"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaDot,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTADIFPRE"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaDifPre,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAREV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaRev,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAAUMINV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaAumInv,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAREDINV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaRedInv,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTACOM"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaCom,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTADEVCOM"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaDevCom,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAWIP"
                        wp_bVdaEOF = mof_fConFTPUC(.sCtaWIP,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                End Select
                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaIEDMI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaGLMOV1(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV1 As DataGridView,
                                 ByVal wp_aeAPDGV As Object)

        'Fec_Ult_Mod : 2015.02.03

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        Dim wl_eAPDGV As moe_Estructuras.eAPDGV
        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV1.CurrentCellAddress.Y
        wl_nCol = wp_DGV1.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eATCCO = New moe_Estructuras.eATCCO
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_eATIVA = New moe_Estructuras.eATIVA
            Dim wl_eATVEN = New moe_Estructuras.eATVEN
            Dim wl_eATALM = New moe_Estructuras.eATALM
            Dim wl_eFTPUC = New moe_Estructuras.eFTPUC
            Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
            Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            Dim wl_eGEMOV = New moe_Estructuras.eGEMOV
            Dim wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
            Dim wl_eTEDMT = New moe_Estructuras.eTEDMT
            Dim wl_ePEODP = New moe_Estructuras.ePEODP
            Dim wl_eILDMI2 = New moe_Estructuras.eILDMI2
            Dim wl_aeATCCO() As moe_Estructuras.eATCCO
            Dim wl_aeATIVA() As moe_Estructuras.eATIVA
            Dim wl_aeATVEN() As moe_Estructuras.eATVEN
            Dim wl_aeATALM() As moe_Estructuras.eATALM
            Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC
            Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
            Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
            Dim wl_aeTEDMT() As moe_Estructuras.eTEDMT
            Dim wl_aeILDMI2() As moe_Estructuras.eILDMI2

            Dim vl_sEstOdp As String
            vl_sEstOdp = "2"

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCCO(0)
            ReDim wl_aeATIVA(0)
            ReDim wl_aeATVEN(0)
            ReDim wl_aeFTPUC(0)
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeIELDMI1(0)
            ReDim wl_aeATALM(0)
            ReDim wl_aeGLMOV1(0)
            ReDim wl_aeTEDMT(0)
            ReDim wl_aeILDMI2(0)
            wl_bEOF = True
            If wl_eAPDGV.sCodFrm = "frmILDMI2" Then
                moo_eILDMI2_DGV(wl_eILDMI2,
                                wp_DGV1,
                                wl_nRow)
            Else
                moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                      wp_DGV1,
                                      wl_nRow)
            End If
            With wl_eGLMOV1
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODCCO" '1
                        wp_bVdaEOF = mof_fConATCCO(.sCodCco,
                                                   wl_eATCCO)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-104"
                        End If
                    Case "SCODIVA" '2
                        wp_bVdaEOF = mof_fConATIVA(.sCodIva,
                                                   wl_eATIVA)
                        If wp_bVdaEOF = False Then
                            .sCodIva = wl_eATIVA.sCodIVA
                            .nPorIva = wl_eATIVA.nPorIVA
                        Else
                            wl_sCodErr = "10-105"
                        End If
                    Case "SCODVEN" '3
                        wp_bVdaEOF = mof_fConATVEN(wl_sCod,
                                                  wl_eATVEN)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-107"
                        End If
                    Case "SCODALM" '4 
                        wp_bVdaEOF = mof_fConATALM(.sCodAlm,
                                                  wl_eATALM)
                        If wp_bVdaEOF = False Then
                            .sCodAlm = wl_eATALM.sCodAlm
                            wp_DGV1.Rows(wl_nRow).Cells("sCodAlm").Value = wl_eATALM.sCodAlm
                            If wl_eGLMOV1.sCodItm <> Nothing Then
                                wp_bVdaEOF = False
                                wp_bVdaEOF = mof_fConSdoAlm(wl_eGLMOV1.sCodItm,
                                                            wl_eATALM.sCodAlm,
                                                            wl_eIELDMI1)
                                If wp_bVdaEOF = False Then

                                    .sCodCta = wl_eIELDMI1.eILDMI1.sCtaInv
                                    .sCtaCosVta = wl_eIELDMI1.eILDMI1.sCtaCosVta
                                    .nSdoAlm = wl_eIELDMI1.eILDMI1.nSdoAlm
                                    .nSdoInv = wl_eIELDMI1.eIEDMI.nSdoInv
                                    .nPreUni = wl_eIELDMI1.eILDMI1.nPreUni
                                    .nUltPreEnt = wl_eIELDMI1.eILDMI1.nUltPreEnt
                                    If wl_eAPDGV.sCodFrm = "frmCEODC" Then
                                        .nPreUni = wl_eIELDMI1.eILDMI1.nUltPreEnt
                                    End If

                                Else
                                    wl_sCodErr = "10-117"
                                End If
                            End If
                        Else
                            wl_sCodErr = "10-103"
                        End If
                    Case "SCTAINV" '5
                        wp_bVdaEOF = mof_fConFTPUC(.sCodCta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCODITM" '6
                        wp_bVdaEOF = mof_fConIEDMI(.sCodItm,
                                                  wl_eIEDMI)
                        If wp_bVdaEOF = False Then
                            .sCodItm = wl_eIEDMI.sCodItm
                            .sNomItm = wl_eIEDMI.sNomItm
                            .sCodCco = wl_eIEDMI.sCodCco
                            .sNomAlt = wl_eIEDMI.sNomAlt
                            wp_DGV1.Rows(wl_nRow).Cells("sCodItm").Value = wl_eIEDMI.sCodItm
                            .sUniMedInv = wl_eIEDMI.sUniMedCom
                            If .sClsDoc = "DC" Then
                                .sCodIva = wl_eIEDMI.sCodItoCom
                                .sUniMedInv = wl_eIEDMI.sUniMedCom
                            Else
                                If .sClsDoc = "DV" Then
                                    .sCodIva = wl_eIEDMI.sCodItoVta
                                    .sUniMedInv = wl_eIEDMI.sUniMedVta
                                Else
                                    .sCodIva = ""
                                    .sUniMedInv = wl_eIEDMI.sUniMedInv
                                End If
                            End If
                            If .sCodIva <> "" Then
                                wl_bEOF = mof_fConATIVA(.sCodIva,
                                                        wl_eATIVA)
                                If wl_bEOF = False Then
                                    .nPorIva = wl_eATIVA.nPorIVA
                                Else
                                    .nPorIva = 0
                                End If
                            End If
                            .sCodAlm = wl_eIEDMI.sCodAlm
                            If .sClsDoc = "DC" Then
                                .sCodAlm = wl_eIEDMI.sCodAlmCom
                            End If
                            wp_bVdaEOF = True
                            If .sCodAlm <> "" Then
                                wp_bVdaEOF = mof_fConSdoAlm(.sCodItm,
                                                            .sCodAlm,
                                                            wl_eIELDMI1)
                                If wp_bVdaEOF = False Then
                                    .sCodCta = wl_eIELDMI1.eILDMI1.sCtaInv
                                    .sCtaCosVta = wl_eIELDMI1.eILDMI1.sCtaCosVta
                                    .nSdoAlm = wl_eIELDMI1.eILDMI1.nSdoAlm
                                    .nSdoInv = wl_eIELDMI1.eIEDMI.nSdoInv
                                    .nPreUni = wl_eIELDMI1.eILDMI1.nPreUni
                                    .nUltPreEnt = wl_eIELDMI1.eILDMI1.nUltPreEnt
                                    If wl_eAPDGV.sCodFrm = "frmCEODC" Then
                                        .nPreUni = wl_eIELDMI1.eILDMI1.nUltPreEnt
                                    End If
                                Else
                                    wl_sCodErr = "10-117"
                                End If
                            End If
                            .bIndCan = wl_eIEDMI.bIndCan
                            .bIndCos = wl_eIEDMI.bIndCos
                        Else
                            wl_sCodErr = "10-101"
                        End If
                    Case "NCANITM"
                        If .sCodAlm <> "" Then
                            wp_bVdaEOF = mof_fConSdoAlm(.sCodItm,
                                                        .sCodAlm,
                                                        wl_eIELDMI1)
                            If wp_bVdaEOF = False Then
                                .nSdoAlm = wl_eIELDMI1.eILDMI1.nSdoAlm
                                If wl_eAPDGV.sCodFrm = "frmCEODC" Then
                                    .nSdoCanLin = .nCanItm
                                End If
                            Else
                                wl_sCodErr = "10-117"
                            End If
                        End If
                    Case "NTASCAMUSD"
                        If .nTasCamUsd <> 0 Then
                            If wl_eAPDGV.sCodFrm <> "frmCEODC" Then
                                .nPreUni = .nPreUniUsd * .nTasCamUsd
                            End If

                        End If
                    Case "NNRODOCBAS"
                        wp_bVdaEOF = mof_fConPEODP(.sCodDocBas,
                                                   .nNroDocBas,
                                                   vl_sEstOdp,
                                                   wl_ePEODP)
                        If wp_bVdaEOF = False Then
                            moo_DGVGLMOV1_ePEODP(wp_DGV1,
                                                 wl_ePEODP,
                                                 wl_nRow)
                        End If
                End Select
                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With
            If wg_eAPDGV.sCodFrm <> "frmILDMI2" Then
                moo_DGVGLMOV1_eGLMOV1(wp_DGV1,
                                      wl_eGLMOV1,
                                      wl_nRow)
                'wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
            End If
        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaCel")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaILREV1(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV1 As DataGridView,
                                 ByVal wp_aeAPDGV As Object)

        'Fec_Ult_Mod : 2015.07.10

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer
        Dim wl_eAPDGV As moe_Estructuras.eAPDGV
        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV1.CurrentCellAddress.Y
        wl_nCol = wp_DGV1.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eATALM = New moe_Estructuras.eATALM
            Dim wl_eFTPUC = New moe_Estructuras.eFTPUC
            Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
            Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            Dim wl_eIEREV = New moe_Estructuras.eIEREV
            Dim wl_eILREV1 = New moe_Estructuras.eILREV1

            Dim wl_aeATALM() As moe_Estructuras.eATALM
            Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC
            Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
            Dim wl_aeIEREV() As moe_Estructuras.eIEREV
            Dim wl_aeILREV1() As moe_Estructuras.eILREV1

            Dim vl_sTipRev As String

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATALM(0)
            ReDim wl_aeFTPUC(0)
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeIELDMI1(0)
            wl_bEOF = True
            moo_eILREV1_DGVILREV1(wl_eILREV1,
                                   wp_DGV1,
                                   wl_nRow)

            With wl_eILREV1
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                   
                    Case "SCODALM"
                        wp_bVdaEOF = mof_fConATALM(.sCodAlm,
                                                  wl_eATALM)
                        If wp_bVdaEOF = False Then
                            .sCodAlm = wl_eATALM.sCodAlm
                            If wl_eILREV1.sCodItm <> Nothing Then
                                wp_bVdaEOF = False
                                wp_bVdaEOF = mof_fConSdoAlm(wl_eILREV1.sCodItm,
                                                            wl_eATALM.sCodAlm,
                                                            wl_eIELDMI1)
                                If wp_bVdaEOF = False Then
                                    moo_DGVILREV1_eIELDMI1(wp_DGV1,
                                                           wl_eIELDMI1,
                                                           wl_nRow)
                                Else
                                    wl_sCodErr = "10-117"
                                End If
                            End If
                        Else
                            wl_sCodErr = "10-103"
                        End If
                    Case "SCTAINV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCodCta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTACOSVTA" '5
                        wp_bVdaEOF = mof_fConFTPUC(.sCodCta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAAUMINV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCodCta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCTAREVINV"
                        wp_bVdaEOF = mof_fConFTPUC(.sCodCta,
                                                   wl_eFTPUC)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-106"
                        End If
                    Case "SCODITM" '6
                        wp_bVdaEOF = mof_fConIEDMI(.sCodItm,
                                                  wl_eIEDMI)
                        If wp_bVdaEOF = False Then
                            .sCodItm = wl_eIEDMI.sCodItm
                            .sNomItm = wl_eIEDMI.sNomItm
                            .sNomAlt = wl_eIEDMI.sNomAlt
                            .sUniMedInv = wl_eIEDMI.sUniMedCom
                            .sCodAlm = wl_eIEDMI.sCodAlm
                            wp_bVdaEOF = True
                            If .sCodAlm <> "" Then
                                wp_bVdaEOF = mof_fConSdoAlm(.sCodItm,
                                                            .sCodAlm,
                                                            wl_eIELDMI1)
                                If wp_bVdaEOF = False Then
                                    moo_DGVILREV1_eIELDMI1(wp_DGV1,
                                                           wl_eIELDMI1,
                                                           wl_nRow)
                                Else
                                    wl_sCodErr = "10-117"
                                End If
                            End If
                            .bIndCan = wl_eIEDMI.bIndCan
                            .bIndCos = wl_eIEDMI.bIndCos
                        Else
                            wl_sCodErr = "10-101"
                        End If
                    Case "NCANITM"
                        If .sCodAlm <> "" Then
                            wp_bVdaEOF = mof_fConSdoAlm(.sCodItm,
                                                        .sCodAlm,
                                                        wl_eIELDMI1)
                            If wp_bVdaEOF = False Then
                                .nSdoAlm = wl_eIELDMI1.eILDMI1.nSdoAlm
                            Else
                                wl_sCodErr = "10-117"
                            End If
                        End If
                End Select
                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaCel")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPGFOM1(ByRef wp_nColCur As Integer,
                              ByVal wp_nColVda As Integer,
                              ByVal wp_nColSig As Integer,
                              ByVal wp_nRowCur As Integer,
                              ByVal wp_nRowVda As Integer,
                              ByVal wp_nRowSig As Integer,
                              ByRef wp_DGV As DataGridView,
                              ByVal wp_aeAPDGV As Object,
                              ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2014-12-19

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer
        Dim vl_nId As Integer
        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        vl_nId = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATALM = New moe_Estructuras.eATALM
            Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
            Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            Dim wl_ePEFOM = New moe_Estructuras.ePEFOM
            Dim wl_ePGFOM1 = New moe_Estructuras.ePLFOM1

            Dim wl_aeATALM() As moe_Estructuras.eATALM
            Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
            Dim wl_aePGFOM1() As moe_Estructuras.ePLFOM1
            Dim clnPEFOM As New ClaseNegocios.clnPEFOM
            Dim clnPELIM As New ClaseNegocios.clnPELIM
            Dim wl_DT1 As New DataTable


            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATALM(0)
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeIELDMI1(0)
            ReDim wl_aePGFOM1(0)
            wl_bEOF = True
            Select Case wl_eAPDGV.sCodFrm
                Case "frmPEFOM"
                    moo_ePLFOM1_DGV(wl_ePGFOM1,
                                    wp_DGV,
                                    wl_nRow)
                Case "frmPELIM"
                    '     If wp_DGV.Name = "dgv4" Then
                    'moo_ePLLIM1_DGV(wl_ePGFOM1,
                    '         wp_DGV,
                    '         wl_nRow)
                    'Else
                    moo_ePLLIM1_DGV(wl_ePGFOM1,
                             wp_DGV,
                             wl_nRow)
                    'End If

                Case Else
                    Exit Sub
            End Select



            With (wl_ePGFOM1)
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODCMT" '1
                        vl_nId = wl_ePGFOM1.nId
                        Select Case wl_eAPDGV.sCodFrm
                            Case "frmPEFOM"
                                wp_bVdaEOF = mof_fConIEDMI(.sCodCmt,
                                                            wl_eIEDMI)
                                If wp_bVdaEOF = True Then
                                    wp_bVda = False
                                    wl_sCodErr = "10-101"
                                    wl_sNomTbl = "IEDMI"
                                    wl_sDatCmp = .sCodCmt
                                Else
                                    If vl_nId = 0 Then
                                        wp_bVdaEOF = False
                                        wl_DT1 = clnPEFOM.cndtConCmtPLFOM1(wl_ePGFOM1,
                                                                           wp_bVdaEOF)
                                    Else
                                        wp_bVdaEOF = True
                                    End If
                                    If wp_bVdaEOF = True Then
                                        wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = wl_eIEDMI.sCodItm
                                        wp_DGV.Rows(wl_nRow).Cells("sNomCmt").Value = wl_eIEDMI.sNomItm
                                        wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eIEDMI.nCosItm
                                        wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eIEDMI.sCodAlm
                                        wp_DGV.Rows(wl_nRow).Cells("sUniMedInv").Value = wl_eIEDMI.sUniMedInv
                                    Else
                                        wp_bVda = False
                                        wl_sCodErr = "10-301"
                                        wl_sNomTbl = "PLFOM1"
                                        wl_sDatCmp = .sCodCmt
                                    End If
                                End If
                            Case "frmPELIM"
                                If wp_DGV.Name = "dgv4" Then
                                    wp_bVdaEOF = mof_fConPEFOM(.sCodCmt,
                                                         wl_ePEFOM)
                                    If wp_bVdaEOF = True Then
                                        wp_bVda = False
                                        wl_sCodErr = "10-123"
                                        wl_sNomTbl = "PEFOM"
                                        wl_sDatCmp = .sCodCmt
                                    Else
                                        If vl_nId = 0 Then
                                            wp_bVdaEOF = False
                                            wl_DT1 = clnPELIM.cndtConCmtPLLIM4(wl_ePGFOM1,
                                                                               wp_bVdaEOF)
                                        Else
                                            wp_bVdaEOF = True
                                        End If
                                        If wp_bVdaEOF = True Then
                                            wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = wl_ePEFOM.sCodItm
                                            wp_DGV.Rows(wl_nRow).Cells("sNomCmt").Value = wl_ePEFOM.sNomItm
                                            wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_ePEFOM.nVlrItm
                                            wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_ePEFOM.sCodAlm
                                            wp_DGV.Rows(wl_nRow).Cells("sUniMedInv").Value = wl_ePEFOM.sUniMedInv
                                        Else
                                            wp_bVda = False
                                            wl_sCodErr = "10-301"
                                            wl_sNomTbl = "PLLIM1"
                                            wl_sDatCmp = .sCodCmt
                                        End If
                                       
                                    End If

                                Else
                                    wp_bVdaEOF = mof_fConIEDMI(.sCodCmt,
                                                               wl_eIEDMI)
                                    If wp_bVdaEOF = True Then
                                        wp_bVda = False
                                        wl_sCodErr = "10-101"
                                        wl_sNomTbl = "IEDMI"
                                        wl_sDatCmp = .sCodCmt
                                    Else
                                        If vl_nId = 0 Then
                                            wp_bVdaEOF = False
                                            wl_DT1 = clnPELIM.cndtConCmtPLLIM1(wl_ePGFOM1,
                                                                               wp_bVdaEOF)
                                        Else
                                            wp_bVdaEOF = True
                                        End If
                                        If wp_bVdaEOF = True Then
                                            wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = wl_eIEDMI.sCodItm
                                            wp_DGV.Rows(wl_nRow).Cells("sNomCmt").Value = wl_eIEDMI.sNomItm
                                            wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eIEDMI.nCosItm
                                            wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eIEDMI.sCodAlm
                                            wp_DGV.Rows(wl_nRow).Cells("sUniMedInv").Value = wl_eIEDMI.sUniMedInv
                                        Else
                                            wp_bVda = False
                                            wl_sCodErr = "10-301"
                                            wl_sNomTbl = "PLLIM1"
                                            wl_sDatCmp = .sCodCmt
                                        End If
                                       
                                    End If
                                End If
                        End Select
                    Case "SCODALMCNS" '2
                        wp_bVdaEOF = mof_fConATALM(.sCodAlmCns,
                                                   wl_eATALM)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-103"
                            wl_sNomTbl = "PLLIM1"
                            wl_sDatCmp = .sCodAlmCns


                            wp_bVda = False
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eATALM.sCodAlm
                            .sCodAlmCns = wl_eATALM.sCodAlm
                            If .sCodCmt <> Nothing Then

                                If wp_DGV.Name = "dgv1" Then
                                    wp_bVdaEOF = False
                                    wp_bVdaEOF = mof_fConSdoAlm(.sCodCmt,
                                                                wl_eATALM.sCodAlm,
                                                                wl_eIELDMI1)
                                    If wp_bVdaEOF = False Then
                                        .nPreUni = wl_eIELDMI1.eILDMI1.nPreUni

                                    Else
                                        wl_sNomTbl = "PLLIM1"
                                        wl_sDatCmp = .sCodCmt & " " & .sCodAlmCns
                                        wl_sCodErr = "10-117"
                                    End If
                                End If

                            Else
                                If wl_eAPDGV.sCodFrm = "frmPELIM" Then
                                    wl_sNomTbl = "PLLIM1"
                                Else
                                    wl_sNomTbl = "PLFOM1"
                                End If
                                wl_sDatCmp = .sCodCmt
                                wl_sCodErr = "10-101"
                            End If
                        End If
                    Case "SCODCMTALT" '3
                        wp_bVdaEOF = mof_fConIEDMI(.sCodCmtAlt,
                                                   wl_eIEDMI)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-101"
                            wp_bVda = False
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wl_sNomTbl,
                                 wl_sDatCmp,
                                 wl_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                Else
                    mof_LmpMsgError()
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPGFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPGFOM2(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2014-12-19

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_eATOPE = New moe_Estructuras.eATOPE
            Dim wl_ePGFOM2 = New moe_Estructuras.ePLFOM2


            Dim wl_aeATCTR() As moe_Estructuras.eATCTR
            Dim wl_aeATOPE() As moe_Estructuras.eATOPE
            Dim wl_aePGFOM2() As moe_Estructuras.ePLFOM2

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCTR(0)
            ReDim wl_aeATOPE(0)
            ReDim wl_aePGFOM2(0)
            wl_bEOF = True
            Select Case wl_eAPDGV.sCodFrm
                Case "frmPEFOM"
                    moo_ePLFOM2_DGV(wl_ePGFOM2,
                                    wp_DGV,
                                    wl_nRow)
                Case "frmPELIM"
                    moo_ePLLIM2_DGV(wl_ePGFOM2,
                                    wp_DGV,
                                    wl_nRow)
                Case Else
                    Exit Sub
            End Select



            With wl_ePGFOM2
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODOPE"
                        wp_bVdaEOF = mof_fConATOPE(.sCodOpe,
                                                   wl_eATOPE)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sCodErr = "10-115"
                            wl_sNomTbl = "ATOPE"
                            wl_sDatCmp = .sCodOpe
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sNomOpe").Value = wl_eATOPE.sNomOpe
                            wp_DGV.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATOPE.sCodCtr
                            wp_bVdaEOF = mof_fConATCTR(wl_eATOPE.sCodCtr,
                                                       wl_eATCTR)
                            If Not wp_bVdaEOF Then
                                wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCTR.nPreUni
                            Else
                                wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = 0
                            End If
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wl_sNomTbl,
                                 wl_sDatCmp,
                                 wl_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPGFOM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPGFOM3(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015.04.24

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_eATCIF = New moe_Estructuras.eATCIF
            Dim wl_ePGFOM3 = New moe_Estructuras.ePLFOM3


            Dim wl_aeATCTR() As moe_Estructuras.eATCTR
            Dim wl_aeATCIF() As moe_Estructuras.eATCIF
            Dim wl_aePGFOM3() As moe_Estructuras.ePLFOM3

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCTR(0)
            ReDim wl_aeATCIF(0)
            ReDim wl_aePGFOM3(0)
            wl_bEOF = True
            Select Case wl_eAPDGV.sCodFrm
                Case "frmPEFOM"
                    moo_ePLFOM3_DGV(wl_ePGFOM3,
                                    wp_DGV,
                                    wl_nRow)
                Case "frmPELIM"
                    moo_ePLLIM3_DGV(wl_ePGFOM3,
                                    wp_DGV,
                                    wl_nRow)
                Case Else
                    Exit Sub
            End Select



            With wl_ePGFOM3
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODCIF"
                        wp_bVdaEOF = mof_fConATCIF(.sCodCIF,
                                                   wl_eATCIF)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sCodErr = "10-116"
                            wl_sNomTbl = "ATCIF"
                            wl_sDatCmp = .sCodCIF
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sCodCIF").Value = wl_eATCIF.sCodCIF
                            wp_DGV.Rows(wl_nRow).Cells("sNomCif").Value = wl_eATCIF.sNomCIF
                            wp_DGV.Rows(wl_nRow).Cells("nVlrCIFRea").Value = wl_eATCIF.nVlrCIFRea
                            'wp_DGV.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATOPE.sCodCtr
                            '     wp_bVdaEOF = mof_fConATCTR(wl_eATOPE.sCodCtr,
                            '                                 wl_eATCTR)
                            '      If Not wp_bVdaEOF Then
                            ' wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCTR.nPreUni
                            ' Else
                            ' wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = 0
                            ' End If
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wl_sNomTbl,
                                 wl_sDatCmp,
                                 wl_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPGFOM3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPGFOM5(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2014-12-19

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer
        Dim vl_nId As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        vl_nId = 0

        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATANA = New moe_Estructuras.eATANA
            Dim wl_eATTIA = New moe_Estructuras.eATTIA
            Dim wl_ePGFOM5 = New moe_Estructuras.ePLFOM5

            Dim wl_aeATANA() As moe_Estructuras.eATANA
            Dim wl_aePGFOM5() As moe_Estructuras.ePLFOM5
            Dim clnPEFOM As New ClaseNegocios.clnPEFOM
            Dim wl_DT1 As New DataTable

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATANA(0)
            ReDim wl_aePGFOM5(0)
            wl_bEOF = True
            Select Case wl_eAPDGV.sCodFrm
                Case "frmPEFOM"
                    moo_ePLFOM5_DGV(wl_ePGFOM5,
                                    wp_DGV,
                                    wl_nRow)
                Case Else
                    Exit Sub
            End Select



            With wl_ePGFOM5
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODANA"
                        vl_nId = wl_ePGFOM5.nId
                        wp_bVdaEOF = mof_fConATANA(.sCodAna,
                                                   wl_eATANA)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sNomTbl = "ATANA"
                            wl_sCodErr = "10-120"
                            wl_sDatCmp = .sCodAna
                        Else
                            If vl_nId = 0 Then
                                wp_bVdaEOF = False
                                wl_DT1 = clnPEFOM.cndtConAnaPLFOM5(wl_ePGFOM5,
                                                                   wp_bVdaEOF)
                            Else
                                wp_bVdaEOF = True
                            End If
                            If wp_bVdaEOF = True Then
                                wp_DGV.Rows(wl_nRow).Cells("sCodAna").Value = wl_eATANA.sCodAna
                                wp_DGV.Rows(wl_nRow).Cells("sNomAna").Value = wl_eATANA.sNomAna
                                wp_DGV.Rows(wl_nRow).Cells("sCodTipAna").Value = wl_eATANA.sCodTipAna
                                wp_bVdaEOF = mof_fConATTIA(wl_eATANA.sCodTipAna,
                                                           wl_eATTIA)
                                If Not wp_bVdaEOF Then
                                    wp_DGV.Rows(wl_nRow).Cells("sNomTipAna").Value = wl_eATTIA.sNomTipAna
                                Else
                                    wp_DGV.Rows(wl_nRow).Cells("sNomTipAna").Value = ""
                                End If
                            Else
                                wp_bVda = False
                                wl_sCodErr = "10-301"
                                wl_sNomTbl = "PLLIM1"
                                wl_sDatCmp = .sCodAna
                            End If
                        End If
                End Select
                If wl_sCodErr <> "" Then
                    mof_MsgError(wl_sNomTbl,
                                 wl_sDatCmp,
                                 wl_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPGFOM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPLODP1(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015-03-26

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATALM = New moe_Estructuras.eATALM
            Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
            Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            Dim wl_ePLODP1 = New moe_Estructuras.ePLODP1

            Dim wl_aeATALM() As moe_Estructuras.eATALM
            Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
            Dim wl_aePLODP1() As moe_Estructuras.ePLFOM1

            '  wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATALM(0)
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeIELDMI1(0)
            ReDim wl_aePLODP1(0)
            wl_bEOF = True
            moo_ePLODP1_DGV(wl_ePLODP1,
                            wp_DGV,
                            wl_nRow)



            With wl_ePLODP1
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODCMT" '1
                        wp_bVdaEOF = mof_fConIEDMI(.sCodCmt,
                                                    wl_eIEDMI)
                        If wp_bVdaEOF = True Then
                            wl_sNomTbl = "IEDMI"
                            wp_bVda = False
                            wl_sCodErr = "10-101"
                            wl_sDatCmp = .sCodCmt
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = wl_eIEDMI.sCodItm
                            If .sCodAlmCns <> "" Then
                                mof_fConSdoAlm(.sCodCmt,
                                               .sCodAlmCns,
                                                wl_eIELDMI1)
                                wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = wl_eIELDMI1.eIEDMI.sCodItm
                                wp_DGV.Rows(wl_nRow).Cells("sNomCmt").Value = wl_eIELDMI1.eIEDMI.sNomItm
                                wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eIELDMI1.eILDMI1.nPreUni
                                wp_DGV.Rows(wl_nRow).Cells("sUniMedInv").Value = wl_eIELDMI1.eIEDMI.sUniMedInv
                                wp_DGV.Rows(wl_nRow).Cells("nSdoAlm").Value = wl_eIELDMI1.eILDMI1.nSdoAlm
                                wp_DGV.Rows(wl_nRow).Cells("nSdoInv").Value = wl_eIELDMI1.eIEDMI.nSdoInv

                                'wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eIEDMI.sCodAlm
                            Else
                                wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = wl_eIEDMI.sCodItm
                                wp_DGV.Rows(wl_nRow).Cells("sNomCmt").Value = wl_eIEDMI.sNomItm
                                wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eIEDMI.nCosItm
                                wp_DGV.Rows(wl_nRow).Cells("sUniMedInv").Value = wl_eIEDMI.sUniMedInv
                                wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eIEDMI.sCodAlm
                                wp_DGV.Rows(wl_nRow).Cells("nSdoAlm").Value = 0
                                wp_DGV.Rows(wl_nRow).Cells("nSdoInv").Value = wl_eIEDMI.nSdoInv

                            End If

                            '   wp_DGV.Rows(wl_nRow).Cells("sUniMedInv").Value = wl_eIEDMI.sUniMedInv
                        End If
                    Case "SCODALMCNS" '2
                        wp_bVdaEOF = mof_fConATALM(.sCodAlmCns,
                                                   wl_eATALM)
                        If wp_bVdaEOF = True Then
                            wl_sNomTbl = "ATALM"
                            wl_sCodErr = "10-103"
                            wp_bVda = False
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eATALM.sCodAlm
                            wp_bVdaEOF = mof_fConSdoAlm(.sCodCmt,
                                                       .sCodAlmCns,
                                                       wl_eIELDMI1)


                            If wp_bVdaEOF = True Then
                                wl_sNomTbl = "PLODP1"
                                wl_sCodErr = "10-117"
                                wp_bVda = False
                            Else
                                wp_DGV.Rows(wl_nRow).Cells("nSdoAlm").Value = wl_eIELDMI1.eILDMI1.nSdoAlm
                                wp_DGV.Rows(wl_nRow).Cells("nSdoInv").Value = wl_eIELDMI1.eIEDMI.nSdoInv


                            End If
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wl_sNomTbl,
                                 wl_sDatCmp,
                                 wl_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaLIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPLODP2(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015-03-17

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_eATOPE = New moe_Estructuras.eATOPE
            Dim wl_ePLODP2 = New moe_Estructuras.ePLODP2


            Dim wl_aeATCTR() As moe_Estructuras.eATCTR
            Dim wl_aeATOPE() As moe_Estructuras.eATOPE
            Dim wl_aePLODP2() As moe_Estructuras.ePLODP2

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCTR(0)
            ReDim wl_aeATOPE(0)
            ReDim wl_aePLODP2(0)
            wl_bEOF = True

            moo_ePLODP2_DGV(wl_ePLODP2,
                            wp_DGV,
                            wl_nRow)



            With wl_ePLODP2
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODOPE"
                        wp_bVdaEOF = mof_fConATOPE(.sCodOpe,
                                                   wl_eATOPE)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sCodErr = "10-115"
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sNomOpe").Value = wl_eATOPE.sNomOpe
                            wp_DGV.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATOPE.sCodCtr
                            wp_bVdaEOF = mof_fConATCTR(wl_eATOPE.sCodCtr,
                                                       wl_eATCTR)
                            If Not wp_bVdaEOF Then
                                wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCTR.nPreUni
                            Else
                                wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = 0
                            End If
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPLODP2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPLODP3(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015-03-27

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_eATCIF = New moe_Estructuras.eATCIF
            Dim wl_ePLODP3 = New moe_Estructuras.ePLODP3


            Dim wl_aeATCTR() As moe_Estructuras.eATCTR
            Dim wl_aeATCIF() As moe_Estructuras.eATCIF
            Dim wl_aePLODP3() As moe_Estructuras.ePLODP3

            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCTR(0)
            ReDim wl_aeATCIF(0)
            ReDim wl_aePLODP3(0)
            wl_bEOF = True

            moo_ePLODP3_DGV(wl_ePLODP3,
                            wp_DGV,
                            wl_nRow)
            With wl_ePLODP3
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODCIF"
                        wp_bVdaEOF = mof_fConATCIF(.sCodCIF,
                                                   wl_eATCIF)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sCodErr = "10-116"
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sCodCIF").Value = wl_eATCIF.sCodCIF
                            wp_DGV.Rows(wl_nRow).Cells("sNomCif").Value = wl_eATCIF.sNomCIF
                            wp_DGV.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATCIF.sCodCtr
                            ' wp_bVdaEOF = mof_fConATCTR(wl_eATCIF.sCodCtr,
                            '                           wl_eATCTR)
                            'If Not wp_bVdaEOF Then
                            ' wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCTR.nPreUni
                            ' Else
                            ' wp_DGV.Rows(wl_nRow).Cells("nPreUni").Value = 0
                            'End If
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPLODP5(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015-03-27

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV.CurrentCellAddress.Y
        wl_nCol = wp_DGV.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATANA = New moe_Estructuras.eATANA
            Dim wl_eATTIA = New moe_Estructuras.eATTIA
            Dim wl_ePLODP5 = New moe_Estructuras.ePLODP5

            Dim wl_aeATANA() As moe_Estructuras.eATANA
            Dim wl_aeATTIA() As moe_Estructuras.eATTIA
            Dim wl_aePLODP5() As moe_Estructuras.ePLODP5

            Dim clnPEFOM As New ClaseNegocios.clnPEFOM
            Dim clnPELIM As New ClaseNegocios.clnPELIM
            Dim wl_ePLLIM1 As New moe_Estructuras.ePLLIM1
            Dim wl_ePLFOM5 As New moe_Estructuras.ePLFOM5

            Dim wl_DT1 As New DataTable


            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATANA(0)
            ReDim wl_aeATTIA(0)
            ReDim wl_aePLODP5(0)
            wl_bEOF = True

            moo_ePLODP5_DGV(wl_ePLODP5,
                            wp_DGV,
                            wl_nRow)
            With wl_ePLODP5
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODCMT" '1
                        wp_bVdaEOF = True
                        wl_ePLLIM1.sCodItm = .sCodItm
                        wl_ePLLIM1.sCodCmt = .sCodCmt
                        wl_DT1 = clnPEFOM.cndtConsultarPEFOM(.sCodCmt,
                                                             wp_bVdaEOF)

                        If wp_bVdaEOF = False Then
                            wp_DGV.Rows(wl_nRow).Cells("sCodCmt").Value = .sCodCmt
                        Else
                            wp_bVda = False
                            wl_sCodErr = "10-101"
                            wl_sNomTbl = "PEFOM"
                            wl_sDatCmp = .sCodCmt
                        End If
                    Case "SCODANA"
                        wp_bVdaEOF = True
                        wp_bVdaEOF = mof_fConATANA(.sCodAna,
                                                   wl_eATANA)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sNomTbl = "ATANA"
                            wl_sCodErr = "10-120"
                            wl_sDatCmp = .sCodAna
                        Else
                            wp_DGV.Rows(wl_nRow).Cells("sNomAna").Value = wl_eATANA.sNomAna
                            wp_DGV.Rows(wl_nRow).Cells("sCodTipAna").Value = wl_eATANA.sCodTipAna
                            wp_bVdaEOF = mof_fConATTIA(wl_eATANA.sCodTipAna,
                                                       wl_eATTIA)
                            If Not wp_bVdaEOF Then
                                wp_DGV.Rows(wl_nRow).Cells("sNomTipAna").Value = wl_eATTIA.sNomTipAna
                                wp_bVdaEOF = True
                                wl_ePLFOM5.sCodItm = .sCodCmt
                                wl_ePLFOM5.sCodAna = .sCodAna
                                ' wl_ePLFOM5.sCodAna = .sCodTipAna
                                wl_DT1 = clnPEFOM.cndtConAnaPLFOM5(wl_ePLFOM5,
                                                                   wp_bVdaEOF)

                                If wp_bVdaEOF = True Then
                                    wp_bVda = False
                                    wl_sNomTbl = "PLFOM5"
                                    wl_sCodErr = "10-120"
                                    wl_sDatCmp = .sCodItm & " - " & .sCodAna
                                Else
                                    wp_DGV.Rows(wl_nRow).Cells("sDesAna").Value = wl_DT1.Rows(0).Item("sDesAna")

                                End If
                            Else
                                wp_DGV.Rows(wl_nRow).Cells("sNomTipAna").Value = ""
                            End If
                          

                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wl_sNomTbl,
                                 wl_sDatCmp,
                                 wl_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV.CurrentCell = wp_DGV.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPLRCI1(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV1 As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015-07-17

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV1.CurrentCellAddress.Y
        wl_nCol = wp_DGV1.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATCIF = New moe_Estructuras.eATCIF
            Dim wl_eATCCO = New moe_Estructuras.eATCCO
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_ePEODP = New moe_Estructuras.ePEODP
            Dim wl_ePLRCI1 = New moe_Estructuras.ePLRCI1
            Dim wl_eFTPUC = New moe_Estructuras.eFTPUC

            Dim wl_aeATOPE() As moe_Estructuras.eATOPE
            Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
            Dim wl_aeATCCO() As moe_Estructuras.eATCCO
            Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC

            Dim vl_sEstOdp As String


            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCCO(0)
            ReDim wl_aeFTPUC(0)
            ReDim wl_aeATOPE(0)
            ReDim wl_aePLROP1(0)
            wl_bEOF = True
            Select Case wl_eAPDGV.sCodFrm
                Case "frmPERCI"
                    moo_ePLRCI1_DGV(wl_ePLRCI1,
                                    wp_DGV1,
                                    wl_nRow)

                Case Else
                    Exit Sub
            End Select



            With wl_ePLRCI1
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                vl_sEstOdp = "2"
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODDOCBAS" '1
                        If .sCodDocBas = "" Then
                            wp_bVda = False
                        End If
                    Case "NNRODOCBAS" '2
                        If .sCodDocBas = "" Or .nNroDocBas < 1 Then
                            wp_bVda = False
                        Else
                            wp_bVdaEOF = mof_fConPEODP(.sCodDocBas,
                                                       .nNroDocBas,
                                                       vl_sEstOdp,
                                                       wl_ePEODP)
                            If wp_bVdaEOF = True Then
                                wp_bVda = False
                                wl_sCodErr = "10-119"
                            Else
                                wp_DGV1.Rows(wl_nRow).Cells("sCodItm").Value = wl_ePEODP.sCodItm
                                wp_DGV1.Rows(wl_nRow).Cells("nCanItm").Value = wl_ePEODP.nCanUniOdp
                            End If
                        End If

                    Case "SCODCIF" '2
                        wp_bVdaEOF = mof_fConATCIF(.sCodCIF,
                                                    wl_eATCIF)
                        If wp_bVdaEOF = True Then
                            wp_bVda = False
                            wl_sCodErr = "10-116"
                        Else
                            wp_DGV1.Rows(wl_nRow).Cells("sNomCIF").Value = wl_eATCIF.sNomCIF
                            wp_DGV1.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATCIF.sCodCtr
                            wp_DGV1.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCIF.nVlrCIFRea
                        End If
                    Case "SCODCCO" '3
                        wp_bVdaEOF = mof_fConATCCO(.sCodCco,
                                                   wl_eATCCO)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-104"
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPLRCI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mov_dgv_VdaPLROP1(ByRef wp_nColCur As Integer,
                                 ByVal wp_nColVda As Integer,
                                 ByVal wp_nColSig As Integer,
                                 ByVal wp_nRowCur As Integer,
                                 ByVal wp_nRowVda As Integer,
                                 ByVal wp_nRowSig As Integer,
                                 ByRef wp_DGV1 As DataGridView,
                                 ByVal wp_aeAPDGV As Object,
                                 ByRef wp_bVda As Boolean)

        'Fec_Ult_Mod : 2015-02-02

        Dim wl_nColCur As Integer
        Dim wl_nColVda As Integer
        Dim wl_nColSig As Integer
        Dim wl_nRowCur As Integer
        Dim wl_nRowVda As Integer
        Dim wl_nRowSig As Integer
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_sCod As String
        Dim wl_nNro As Long
        Dim wl_bEOF As Boolean
        Dim wl_sCodErr As String
        Dim wl_nColOri As Integer
        Dim wl_nNroCol As Integer

        wl_nColCur = wp_nColCur
        wl_nColVda = wp_nColVda
        wl_nColSig = wp_nColSig
        wl_nRowCur = wp_nRowCur
        wl_nRowVda = wp_nRowVda
        wl_nRowSig = wp_nRowSig
        wl_nCol = wl_nColCur
        wl_nRow = wp_nRowCur
        wl_nRow = wp_DGV1.CurrentCellAddress.Y
        wl_nCol = wp_DGV1.CurrentCellAddress.X
        wp_nColNom = wp_nColVda
        wp_nColVlr = wp_nColVda
        wp_nColNroBas = wp_nColVda
        wp_nColDocBas = wl_nCol
        wl_nNro = 0
        wl_sCod = ""
        Try
            Dim wl_eAPDGV = New moe_Estructuras.eAPDGV
            Dim wl_eATCTR = New moe_Estructuras.eATCTR
            Dim wl_eATOPE = New moe_Estructuras.eATOPE
            Dim wl_ePEODP = New moe_Estructuras.ePEODP
            Dim wl_ePLODP2 = New moe_Estructuras.ePLODP2


            Dim wl_ePLROP1 = New moe_Estructuras.ePLROP1
            Dim wl_eATCCO = New moe_Estructuras.eATCCO
            Dim wl_eFTPUC = New moe_Estructuras.eFTPUC

            Dim wl_aeATOPE() As moe_Estructuras.eATOPE
            Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
            Dim wl_aeATCCO() As moe_Estructuras.eATCCO
            Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC

            Dim vl_sEstOdp As String


            wl_eAPDGV = wp_aeAPDGV(wl_nColVda)
            wl_nColOri = wl_eAPDGV.nColOri
            wl_nNroCol = wl_eAPDGV.nNroCol
            ReDim wl_aeATCCO(0)
            ReDim wl_aeFTPUC(0)
            ReDim wl_aeATOPE(0)
            ReDim wl_aePLROP1(0)
            wl_bEOF = True
            Select Case wl_eAPDGV.sCodFrm
                Case "frmPEROP"
                    moo_ePLROP1_DGV(wl_ePLROP1,
                                    wp_DGV1,
                                    wl_nRow)

                Case Else
                    Exit Sub
            End Select



            With wl_ePLROP1
                '1
                wl_sCodErr = ""
                wp_bVdaEOF = True
                wp_sDatCmp = wl_sCod
                vl_sEstOdp = "2"
                Select Case UCase(wl_eAPDGV.sNomCmp)
                    Case "SCODDOCBAS" '1
                        If .sCodDocBas = "" Then
                            wp_bVda = True
                        End If
                    Case "NNRODOCBAS" '2
                        If .sCodDocBas = "" Or .nNroDocBas < 1 Then
                            wp_bVda = True
                        Else
                            wp_bVdaEOF = mof_fConPEODP(.sCodDocBas,
                                                       .nNroDocBas,
                                                       vl_sEstOdp,
                                                       wl_ePEODP)
                            If wp_bVdaEOF = True Then
                                wp_bVda = False
                                wl_sCodErr = "10-119"
                            Else
                                wp_DGV1.Rows(wl_nRow).Cells("sCodSerBas").Value = wl_ePEODP.sCodSer
                                wp_DGV1.Rows(wl_nRow).Cells("sCodItm").Value = wl_ePEODP.sCodItm
                                wp_DGV1.Rows(wl_nRow).Cells("nCanItm").Value = wl_ePEODP.nCanUniOdp
                            End If
                        End If

                    Case "SCODOPE" '2
                        'wp_bVdaEOF = mof_fConATOPE(.sCodOpe,
                        '                            wl_eATOPE)
                        If .sCodOpe = "" Then
                            wp_bVda = False
                        Else
                            If .sCodDocBas <> Nothing Then
                                wp_bVdaEOF = mof_fConPLODP2(.sCodDocBas,
                                                         .nNroDocBas,
                                                         .sCodOpe,
                                                          wl_ePLODP2)

                                If wp_bVdaEOF = True Then
                                    wp_bVda = False
                                    wl_sCodErr = "10-115"
                                Else
                                    '  wp_DGV1.Rows(wl_nRow).Cells("sNomOpe").Value = wl_eATOPE.sNomOpe
                                    '  wp_DGV1.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATOPE.sCodCtr
                                    '  wp_bVdaEOF = mof_fConATCTR(wl_eATOPE.sCodCtr,
                                    '                           wl_eATCTR)
                                    wp_DGV1.Rows(wl_nRow).Cells("sNomOpe").Value = wl_ePLODP2.sNomOpe
                                    wp_DGV1.Rows(wl_nRow).Cells("sCodCtr").Value = wl_ePLODP2.sCodCtr
                                    wp_bVdaEOF = mof_fConATCTR(wl_ePLODP2.sCodCtr,
                                                               wl_eATCTR)
                                    If Not wp_bVdaEOF Then
                                        wp_DGV1.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCTR.nPreUni
                                    Else
                                        wp_DGV1.Rows(wl_nRow).Cells("nPreUni").Value = 0
                                    End If
                                    wp_DGV1.Rows(wl_nRow).Cells("nTieReq").Value = wl_ePLODP2.nTieReq

                                End If
                            Else
                                wp_bVdaEOF = mof_fConATOPE(.sCodOpe,
                                                           wl_eATOPE)

                                If wp_bVdaEOF = True Then
                                    wp_bVda = False
                                    wl_sCodErr = "10-115"
                                Else
                                    wp_DGV1.Rows(wl_nRow).Cells("sNomOpe").Value = wl_eATOPE.sNomOpe
                                    wp_DGV1.Rows(wl_nRow).Cells("sCodCtr").Value = wl_eATOPE.sCodCtr
                                    wp_bVdaEOF = mof_fConATCTR(wl_eATOPE.sCodCtr,
                                                               wl_eATCTR)
                                    If Not wp_bVdaEOF Then
                                        wp_DGV1.Rows(wl_nRow).Cells("nPreUni").Value = wl_eATCTR.nPreUni
                                    Else
                                        wp_DGV1.Rows(wl_nRow).Cells("nPreUni").Value = 0
                                    End If
                                    wp_DGV1.Rows(wl_nRow).Cells("nTieReq").Value = 0
                                End If

                            End If
                        End If

                    Case "SCODCCO" '3
                        wp_bVdaEOF = mof_fConATCCO(.sCodCco,
                                                   wl_eATCCO)
                        If wp_bVdaEOF = True Then
                            wl_sCodErr = "10-104"
                        End If
                End Select

                If wl_sCodErr <> "" Then
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    wp_nColCur = wl_nColVda
                    wl_nCol = wl_nColVda
                    wp_DGV1.CurrentCell = wp_DGV1.Rows(wl_nRow).Cells(wl_nCol)
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MsgBox("Error :  mov_dgv_VdaPLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "TXT"
    Public Function mov_VdaTxt(ByRef wl_bVda As Boolean,
                               ByVal wp_cvTXT As TextBox) As Boolean
        Try


            wl_bVda = False

            If wp_cvTXT.Name = "txtsCodItm" Then
                If String.IsNullOrEmpty(wp_cvTXT.Text) Or wp_cvTXT.Text = " " Then
                    wp_sNomTbl = ""
                    wp_sDatCmp = ""
                    wp_sCodErr = "10-401"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    MsgBox("El código del ítem es obligatorio")
                    wp_cvTXT.Focus()
                    Return wl_bVda
                End If
            End If

            If wp_cvTXT.Name = "txtsCodTer" Then
                If String.IsNullOrEmpty(wp_cvTXT.Text) Or wp_cvTXT.Text = " " Then
                    wp_sNomTbl = ""
                    wp_sDatCmp = ""
                    wp_sCodErr = "10-408"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    MsgBox("El código del tercero es obligatorio")
                    wp_cvTXT.Focus()
                    Return wl_bVda
                End If
            End If


            If wp_cvTXT.Name = "txtnNroDoc" Then
                If String.IsNullOrEmpty(wp_cvTXT.Text) Then
                    wp_sNomTbl = ""
                    wp_sDatCmp = ""
                    wp_sCodErr = "11-005"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    MsgBox("El Número del documento es obligatorio")
                    wp_cvTXT.Focus()
                    Return wl_bVda
                End If

                If Not IsNumeric(wp_cvTXT.Text) Or Val(wp_cvTXT.Text) < 0 Then
                    wp_sNomTbl = ""
                    wp_sDatCmp = ""
                    wp_sCodErr = "11-001"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    MsgBox("Valor numérico no válido")
                    wp_cvTXT.Focus()
                    Return wl_bVda

                End If
            End If
            wl_bVda = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en Function: mov_VdaTxt")
        End Try

        Return wl_bVda
    End Function
    Public Function mov_VdaMTB(ByRef wl_bVda As Boolean,
                               ByVal wp_cvTXT As MaskedTextBox) As Boolean
        Try


            wl_bVda = False
            If wp_cvTXT.Name = "mtbsCodItm" Then
                If String.IsNullOrEmpty(wp_cvTXT.Text) Or Mid(wp_cvTXT.Text, 1, 1) = " " Then
                    wp_sNomTbl = ""
                    wp_sDatCmp = ""
                    wp_sCodErr = "10-401"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    MsgBox("El código del ítem es obligatorio")
                    wp_cvTXT.Focus()
                    Return wl_bVda
                End If
            End If
            If wp_cvTXT.Name = "mtbsCodTer" Then
                If String.IsNullOrEmpty(wp_cvTXT.Text) Or wp_cvTXT.Text = " " Then
                    wp_sNomTbl = ""
                    wp_sDatCmp = ""
                    wp_sCodErr = "10-408"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    MsgBox("El código del tercero es obligatorio")
                    wp_cvTXT.Focus()
                    Return wl_bVda
                End If
            End If
            wl_bVda = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en Function: mov_VdaMTB")
        End Try

        Return wl_bVda
    End Function
#End Region

#Region "Valida datos"
    Public Function mov_VdaDatEsNro(ByRef wl_bVda As Boolean,
                                    ByVal wl_nNro As Double) As Boolean
        'wl_bVda= True, el dato es numérico. False, el dato no es numérico
        '2014-08-26
        wl_bVda = False
        If Not IsNumeric(wl_nNro) Or Val(wl_nNro) < 0 Then
            wl_bVda = True
        End If
        Return wl_bVda
    End Function
    Public Function mov_VdaNroPvo(ByRef wl_bVda As Boolean,
                                  ByVal wl_nNro As Double) As Boolean
        wl_bVda = False
        If wl_nNro >= 0 Then
            wl_bVda = True
        End If
        Return wl_bVda
    End Function
    Public Function mov_VdaDatVio(ByRef wl_bVda As Boolean,
                                  ByVal wl_sDat As String) As Boolean
        wl_bVda = False
        If String.IsNullOrEmpty(wl_sDat) Then
            wl_bVda = True
        End If
        Return wl_bVda
    End Function
#End Region

#Region "Valida integridad referencial"
#Region "Valida integridad referencial - ATALM"
    Public Function mov_VdasCodAlm(ByVal vp_sCodAlm As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(13)
            wl_asNomTbl(0) = "CLFAP1"
            wl_asNomTbl(1) = "CLNOC1"
            wl_asNomTbl(2) = "CLNOD1"
            wl_asNomTbl(3) = "CLODC1"
            wl_asNomTbl(4) = "IEDMI"
            wl_asNomTbl(5) = "ILDMI1"
            wl_asNomTbl(6) = "ILMOV1"
            wl_asNomTbl(7) = "PEFOM"
            wl_asNomTbl(8) = "PELIM"
            wl_asNomTbl(9) = "PEODP"
            wl_asNomTbl(10) = "VLFAC1"
            wl_asNomTbl(11) = "VLNOC1"
            wl_asNomTbl(12) = "VLNOD1"
            wl_asNomTbl(13) = "VLPED1"

            wl_sNomCmp = "sCodAlm"
            wl_sDatCmp = vp_sCodAlm
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If
            ReDim wl_asNomTbl(8)

            wl_asNomTbl(0) = "CEFAP"
            wl_asNomTbl(1) = "CENOC"
            wl_asNomTbl(2) = "CENOD"
            wl_asNomTbl(3) = "CEODC"
            wl_asNomTbl(4) = "IEMOV"
            wl_asNomTbl(5) = "VEFAC"
            wl_asNomTbl(6) = "VENOC"
            wl_asNomTbl(7) = "VENOD"
            wl_asNomTbl(8) = "VEPED"

            wl_sNomCmp = "sAlmOri"
            wl_sDatCmp = vp_sCodAlm
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If


            ReDim wl_asNomTbl(2)


            wl_asNomTbl(0) = "PLFOM1"
            wl_asNomTbl(1) = "PLLIM1"
            wl_asNomTbl(2) = "PLODP1"

            wl_sNomCmp = "sCodAlmCns"
            wl_sDatCmp = vp_sCodAlm
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next


        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodAlm")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ATCCO"
    Public Function mov_VdasCodCco(ByVal vp_sCodCco As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(8)
            wl_asNomTbl(0) = "CLFAP1"
            wl_asNomTbl(1) = "CLNOC1"
            wl_asNomTbl(2) = "CLNOD1"
            wl_asNomTbl(3) = "CLODC1"
            wl_asNomTbl(4) = "ILMOV1"
            wl_asNomTbl(5) = "VLFAC1"
            wl_asNomTbl(6) = "VLNOC1"
            wl_asNomTbl(7) = "VLNOD1"
            wl_asNomTbl(8) = "VLPED1"

            wl_sNomCmp = "sCodCco"
            wl_sDatCmp = vp_sCodCco
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If



        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodVen")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region
#Region "Valida integridad referencial - ATCIF"
    Public Function mov_VdasCodCIF(ByVal vp_sCodCIF As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(2)
            wl_asNomTbl(0) = "PLFOM3"
            wl_asNomTbl(1) = "PLLIM3"
            wl_asNomTbl(2) = "PLODP3"

            wl_sNomCmp = "sCodCIF"
            wl_sDatCmp = vp_sCodCIF
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next


        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodCIF")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ATCTR"
    Public Function mov_VdasCodCtr(ByVal vp_sCodCtr As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(6)
            wl_asNomTbl(0) = "PLFOM2"
            wl_asNomTbl(1) = "PLFOM3"
            wl_asNomTbl(2) = "PLLIM2"
            wl_asNomTbl(3) = "PLLIM3"
            wl_asNomTbl(4) = "PLROP1"
            wl_asNomTbl(5) = "PLODP2"
            wl_asNomTbl(6) = "PLODP3"

            wl_sNomCmp = "sCodCtr"
            wl_sDatCmp = vp_sCodCtr
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next


        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodCtr")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region
#Region "Valida integridad referencial - ATGRI"
    Public Function mov_VdasCodGrp(ByVal vp_sCodGrp As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(0)
            wl_asNomTbl(0) = "IEDMI"


            wl_sNomCmp = "sCodGrp"
            wl_sDatCmp = vp_sCodGrp
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodGrp")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region
#Region "Valida integridad referencial - ATOPE"
    Public Function mov_VdasCodOpe(ByVal vp_sCodOpe As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(2)
            wl_asNomTbl(0) = "PLFOM2"
            wl_asNomTbl(1) = "PLLIM2"
            wl_asNomTbl(2) = "PLROP1"


            wl_sNomCmp = "sCodOpe"
            wl_sDatCmp = vp_sCodOpe
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next


        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodOpe")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ATPCO"
    Public Function mov_VdasCodPdo(ByVal vp_sCodPdo As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(0)
            wl_asNomTbl(0) = "PEROP"


            wl_sNomCmp = "sCodPdo"
            wl_sDatCmp = vp_sCodPdo
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodOpe")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ATPOP"
    Public Function mov_VdasCodOperario(ByVal vp_sCodTer As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(0)
            wl_asNomTbl(0) = "PLROP1"


            wl_sNomCmp = "sCodTer"
            wl_sDatCmp = vp_sCodTer
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodOpe")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ATVEN"
    Public Function mov_VdasCodVen(ByVal vp_sCodVen As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(8)
            wl_asNomTbl(0) = "CLFAP1"
            wl_asNomTbl(1) = "CLNOC1"
            wl_asNomTbl(2) = "CLNOD1"
            wl_asNomTbl(3) = "CLODC1"
            wl_asNomTbl(4) = "ILMOV1"
            wl_asNomTbl(5) = "VLFAC1"
            wl_asNomTbl(6) = "VLNOC1"
            wl_asNomTbl(7) = "VLNOD1"
            wl_asNomTbl(8) = "VLPED1"

            wl_sNomCmp = "sCodVen"
            wl_sDatCmp = vp_sCodVen
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If
         


        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodVen")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ATZON"
    Public Function mov_VdasCodZon(ByVal vp_sCodZon As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(0)
            wl_asNomTbl(0) = "ATVEN"


            wl_sNomCmp = "sCodZon"
            wl_sDatCmp = vp_sCodZon
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodZon")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - IEDMI"
    Public Function mov_VdasCodItm(ByVal vp_sCodItm As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String

        Try
            ReDim wl_asNomTbl(13)
            wl_asNomTbl(0) = "CLFAP1"
            wl_asNomTbl(1) = "CLNOC1"
            wl_asNomTbl(2) = "CLNOD1"
            wl_asNomTbl(3) = "CLODC1"
            wl_asNomTbl(4) = "ILMOV1"
            wl_asNomTbl(5) = "PEFOM"
            wl_asNomTbl(6) = "PELIM"
            wl_asNomTbl(7) = "PEODP"
            wl_asNomTbl(8) = "PLODP1"
            wl_asNomTbl(9) = "PLROP1"
            wl_asNomTbl(10) = "VLFAC1"
            wl_asNomTbl(11) = "VLNOC1"
            wl_asNomTbl(12) = "VLNOD1"
            wl_asNomTbl(13) = "VLPED1"

            wl_sNomCmp = "sCodItm"
            wl_sDatCmp = vp_sCodItm
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If

            ReDim wl_asNomTbl(1)
            wl_asNomTbl(0) = "PLFOM1"
            wl_asNomTbl(1) = "PLLIM1"

            wp_bVda = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodItm")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - ILDMI1"
    Public Function mov_VdasCodItmCodAlm(ByVal vp_sCodItm As String,
                                         ByVal vp_sCodAlm As String,
                                         ByRef wp_sNomTbl As String,
                                         ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_sNomCmp1 As String
        Dim wl_sDatCmp1 As String
        Dim wl_sTipCmp1 As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String

        Try
            ReDim wl_asNomTbl(2)
            wl_asNomTbl(0) = "CLODC1"
            wl_asNomTbl(1) = "ILMOV1"
            wl_asNomTbl(2) = "ILREV1"

            wl_sNomCmp = "sCodItm"
            wl_sDatCmp = vp_sCodItm
            wl_sTipCmp = "S"
            wl_sNomCmp1 = "sCodAlm"
            wl_sDatCmp1 = vp_sCodAlm
            wl_sTipCmp1 = "S"

            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)

                wl_bEOF = clnConTbl.cndtConEOF1Tbl2Cmp(wl_sNomTbl,
                                                       wl_sNomCmp,
                                                       wl_sDatCmp,
                                                       wl_sTipCmp,
                                                       wl_sNomCmp1,
                                                       wl_sDatCmp1,
                                                       wl_sTipCmp1,
                                                       wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If


        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodItmCodAlm")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - FTPUC"
    Public Function mov_VdasCodCta(ByVal vp_sCodCta As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Dim wl_asNomCta() As String

        Try
            ReDim wl_asNomTbl(13)
            wl_asNomTbl(0) = "CLFAP1"
            wl_asNomTbl(1) = "CLNOC1"
            wl_asNomTbl(2) = "CLNOD1"
            wl_asNomTbl(3) = "CLODC1"
            wl_asNomTbl(4) = "FLCCT1"
            wl_asNomTbl(5) = "FLMOC1"
            wl_asNomTbl(6) = "FTSAC"
            wl_asNomTbl(7) = "FTSAT"
            wl_asNomTbl(8) = "ILMOV1"
            wl_asNomTbl(9) = "ILDMI1"
            wl_asNomTbl(10) = "VLFAC1"
            wl_asNomTbl(11) = "VLNOC1"
            wl_asNomTbl(12) = "VLNOD1"
            wl_asNomTbl(13) = "VLPED1"

            wl_sNomCmp = "sCodCta"
            wl_sDatCmp = vp_sCodCta
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next
            If wl_bEOF = False Then
                Return wl_bEOF
                Exit Function
            End If

            ReDim wl_asNomTbl(14)
            ReDim wl_asNomCta(13)
            wl_asNomTbl(0) = "ATALM"
            wl_asNomTbl(1) = "ATGRI"
            wl_asNomTbl(2) = "ILDMI1"
            wl_asNomCta(0) = "sCtaInv"
            wl_asNomCta(1) = "sCtaCosVta"
            wl_asNomCta(2) = "sCtaTrs"
            wl_asNomCta(3) = "sCtaIng"
            wl_asNomCta(4) = "sCtaDevVta"
            wl_asNomCta(5) = "sCtaVrc"
            wl_asNomCta(6) = "sCtaGto"
            wl_asNomCta(7) = "sCtaDot"
            wl_asNomCta(8) = "sCtaDifPre"
            wl_asNomCta(9) = "sCtaRev"
            wl_asNomCta(10) = "sCtaAumInv"
            wl_asNomCta(11) = "sCtaRedInv"
            wl_asNomCta(12) = "sCtaCom"
            wl_asNomCta(13) = "sCtaDevCom"
            wl_asNomCta(14) = "sCtaWIP"
            wp_bVda = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                For wl_L = 0 To wl_asNomTbl.Length - 1
                    wl_sNomCmp = wl_asNomTbl(wl_L)
                    wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                                 wl_sNomCmp,
                                                 wl_sDatCmp,
                                                 wl_sTipCmp,
                                                 wl_sCmpOrd,
                                                 wl_sTipOrd,
                                                 wl_bEOF)
                    If wl_bEOF = False Then
                        wp_sNomTbl = wl_sNomTbl
                        wp_bVda = False
                        Exit For
                    End If
                Next
                If wl_bEOF = False Then
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodCta")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - PEFOM"
    Public Function mov_VdasCodFor(ByVal vp_sCodItm As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String

        Try
            ReDim wl_asNomTbl(3)
            wl_asNomTbl(0) = "PELIM"
            wl_asNomTbl(1) = "PLLIM1"
            wl_asNomTbl(2) = "PEODP"
            wl_asNomTbl(3) = "PLODP1"

            wl_sNomCmp = "sCodItm"
            wl_sDatCmp = vp_sCodItm
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodFor")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - PELIM"
    Public Function mov_VdasCodLIM(ByVal vp_sCodItm As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String

        Try
            ReDim wl_asNomTbl(4)
            wl_asNomTbl(0) = "IEDMI"
            wl_asNomTbl(1) = "PEFOM"
            wl_asNomTbl(2) = "PLFOM1"
            wl_asNomTbl(3) = "PEODP"
            wl_asNomTbl(4) = "PLODP1"

            wl_sNomCmp = "sCodItm"
            wl_sDatCmp = vp_sCodItm
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodLIM")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - PEODP"
    Public Function mov_VdaODP(ByVal vp_sCodDoc As String,
                                   ByVal vp_nNroDoc As Long,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_sNomCmp1 As String
        Dim wl_sDatCmp1 As String
        Dim wl_sTipCmp1 As String
        Dim wl_sCmpOrd1 As String
        Dim wl_sTipOrd1 As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(1)
            wl_asNomTbl(0) = "ILMOV1"
            wl_asNomTbl(1) = "PLROP1"

            wl_sNomCmp = "sCodDocBas"
            wl_sDatCmp = vp_sCodDoc
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wl_sNomCmp1 = "nNroDocBas"
            wl_sDatCmp1 = vp_nNroDoc
            wl_sTipCmp1 = "N"
            wl_sCmpOrd1 = ""
            wl_sTipOrd1 = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscarE2(wl_sNomTbl,
                                               wl_sNomCmp,
                                               wl_sDatCmp,
                                               wl_sTipCmp,
                                               wl_sNomCmp1,
                                               wl_sDatCmp1,
                                               wl_sTipCmp1,
                                               wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodTer")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#Region "Valida integridad referencial - TEDMT"
    Public Function mov_VdasCodTer(ByVal vp_sCodTer As String,
                                   ByRef wp_sNomTbl As String,
                                   ByRef wp_bVda As Boolean) As Boolean
        Dim wl_sNomTbl As String
        Dim wl_sNomCmp As String
        Dim wl_sDatCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sCmpOrd As String
        Dim wl_sTipOrd As String
        Dim wl_bEOF As Boolean
        Dim wl_DT As New DataTable
        Dim wl_asNomTbl() As String
        Try
            ReDim wl_asNomTbl(11)
            wl_asNomTbl(0) = "CEFAP"
            wl_asNomTbl(1) = "CENOC"
            wl_asNomTbl(2) = "CENOD"
            wl_asNomTbl(3) = "CEODC"
            wl_asNomTbl(4) = "IEMOV"
            wl_asNomTbl(5) = "ILDMI2"
            wl_asNomTbl(6) = "FLCCT1"
            wl_asNomTbl(7) = "HEDMT"
            wl_asNomTbl(8) = "VEFAC"
            wl_asNomTbl(9) = "VENOC"
            wl_asNomTbl(10) = "VENOD"
            wl_asNomTbl(11) = "VEPED"

            wl_sNomCmp = "sCodTer"
            wl_sDatCmp = vp_sCodTer
            wl_sTipCmp = "S"
            wl_sCmpOrd = ""
            wl_sTipOrd = ""
            wp_bVda = True
            wl_bEOF = True
            For wl_I = 0 To wl_asNomTbl.Length - 1
                wl_sNomTbl = wl_asNomTbl(wl_I)
                wl_DT = clnConTbl.cndtBuscar(wl_sNomTbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_bEOF)
                If wl_bEOF = False Then
                    wp_sNomTbl = wl_sNomTbl
                    wp_bVda = False
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox("Error :  mov_VdasCodTer")
            MsgBox(ex.Message)
        End Try
        Return wl_bEOF
    End Function
#End Region

#End Region


#Region "Valida Período Contable"
    Public Function mov_VdaPdoCtb(ByVal vp_sFecDoc As Date,
                                  ByRef vp_sEstPdo As String) As Boolean
        Dim wl_nAAAA As Integer
        Dim wl_nMM As Integer
        Dim wl_nDD As Integer
        Dim wl_sAAAA As String
        Dim wl_sMM As String
        Dim wl_sDD As String
        Dim vl_sCodPdo As String
        Dim wl_eATPCO = New moe_Estructuras.eATPCO
        Dim wl_DT As New DataTable
        Dim clnATPCO As New ClaseNegocios.clnATPCO
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim vl_sEstPdo As String = "1"
        Try
            wl_nDD = DatePart(DateInterval.Day, vp_sFecDoc)
            wl_nMM = DatePart(DateInterval.Month, vp_sFecDoc)
            wl_nAAAA = DatePart(DateInterval.Year, vp_sFecDoc)

            wl_sDD = CStr(wl_nDD)
            wl_sMM = CStr(wl_nMM)
            wl_sAAAA = CStr(wl_nAAAA)
            If wl_nMM < 10 Then
                wl_sMM = "0" & CStr(wl_nMM)
            End If
            vl_sCodPdo = wl_sAAAA & wl_sMM

            wl_eATPCO.sCodPdo = vl_sCodPdo
            wl_DT = clnATPCO.cndtConATPCO(wl_eATPCO,
                                           wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                vl_sEstPdo = wl_DT.Rows(wl_nRow).Item("sEstPdo")
            End If
            vp_sEstPdo = vl_sEstPdo

        Catch ex As Exception
            MsgBox("Error :  mov_VdaPdoCtb")
            MsgBox(ex.Message)
        End Try
        Return wr_bEOF




        Return True
    End Function

#End Region
End Module
