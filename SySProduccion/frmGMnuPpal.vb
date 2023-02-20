
Public Class frmGMnuPpal
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2015-05-17
#Region "011 frm - Variables Locales"
    Dim wl_sCodAut As String
    Dim wl_sCodFrm As String
    Dim wl_sCodOpc As String
    Dim wl_sNomOpc As String
    Dim wl_bEOF As Boolean

#End Region
#Region "014 Objetos locales"
    Dim clnACPAG As New ClaseNegocios.clnACPAG
    Dim clnABOPC As New ClaseNegocios.clnConTbl
#End Region
#Region "015 Estructuras"
    Dim wl_eACPAG As New moe_Estructuras.eACPAG
    Dim wl_eABOPC As New moe_Estructuras.eABOPC


#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region


#End Region


#Region "Programa principal"
    Private Sub frmMnuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim vl_sTipFont As String
        Dim vl_nTamFont As Double
        leeACPAG()

        vl_sTipFont = wg_eACPAG.sTipFont
        vl_nTamFont = wg_eACPAG.nTamFont
        If vl_sTipFont = "" Then
            vl_sTipFont = "Microsoft Sans Serif"
        End If

        If vl_nTamFont < 8 Or vl_nTamFont > 16 Then
            vl_nTamFont = 8
        End If
        TextBox1.Text = "  " & vg_sNomCia & vbCrLf & "  " & vg_sCodUsr
        With TabControl1

        End With
        With TreeView1
            .ShowLines = True
            .ShowRootLines = True
            .Scrollable = True
            .BackColor = wg_ClrTree
            .FullRowSelect = True
            .HotTracking = False
            .Font = New Font(""" & vl_sTipFont & """, vl_nTamFont)
        End With
        TreeView1.CollapseAll()
    End Sub
#End Region

#Region "040 BD Procedimientos sobre la BD"
    Private Function BD_BuscarABOPC() As Boolean
        Try
            wl_bEOF = True
            wl_eABOPC = New moe_Estructuras.eABOPC
            wl_bEOF = mof_fConABOPC(wl_sCodFrm,
                                    wl_eABOPC)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarABOPC")
        End Try
        Return wl_bEOF
    End Function
#End Region

    Public Function leeACPAG()
        Dim clnConTbl As New ClaseNegocios.clnConTbl

        wr_bEOF = True
        wp_sNomTbl = "ACPAG"
        wp_sNomCmp = "sCodcia"
        wp_sDatCmp = vg_sCodcia
        wp_sTipCmp = "S"
        wp_sCmpOrd = ""
        wp_sTipOrd = ""

        wl_eACPAG = New moe_Estructuras.eACPAG
        wg_eACPAG = New moe_Estructuras.eACPAG
        wl_eACPAG.sCodCia = vg_sCodcia
        wl_eACPAG.sCodUsr = UCase(vg_sCodUsr)
        wg_DTE1 = clnACPAG.cndtConACPAG(wl_eACPAG,
                                        wr_bEOF)


        If Not wr_bEOF Then
            moo_eACPAG_DT(wl_eACPAG,
                          wg_DTE1)
            wg_eACPAG = New moe_Estructuras.eACPAG

            wg_eACPAG = wl_eACPAG

        End If
        Return (Nothing)
    End Function


#Region "Eventos TreeView"
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            '        Dim wl_frm As New Form


            wl_sCodAut = "2"
            wl_sCodFrm = TreeView1.SelectedNode.Name
            BD_BuscarABOPC()

            wl_sNomOpc = wl_eABOPC.sNomOpc

            Select Case wl_sCodFrm
                Case "frmABAUT"
                Case "frmABCLC"
                Case "frmABCLD"
                Case "frmABCLR"
                Case "frmABEOC"
                    Dim wl_frm As New frmABEOC
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmABEOP"
                    Dim wl_frm As New frmABEOP
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmABEPC"
                Case "frmABESD"
                Case "frmABFMT"
                Case "frmABLIM"
                Case "frmABODP"
                Case "frmABROP"
                Case "frmABTID"
                Case "frmABTIR"
                Case "frmABTIT"
                Case "frmABTRT"
                Case "frmABTUS"

                Case "frmACDEM"
                    Dim wl_frm As New frmACDEM
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmACPAG"
                    Dim wl_frm As New frmACPAG
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmACUNI"
                    Dim wl_frm As New frmACUNI
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAFCOT"
                Case "frmAPDGV"
                    Dim wl_frm As New frmAPDGV
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPDOC"
                    Dim wl_frm As New frmAPDOC
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPEND"
                    Dim wl_frm As New frmAPEND
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPFRM"
                    Dim wl_frm As New frmAPFRM
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPGQlst"
                    Dim wl_frm As New frmAPGQLst
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPLND1"
                    Dim wl_frm As New frmAPLND1
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPPRN"
                    Dim wl_frm As New frmAPPRN
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)

                Case "frmAPGQLst"
                    Dim wl_frm As New frmAPGQLst
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmAPRDG"
                Case "frmASRES"
                    Dim wl_frm As New frmASRES
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATALM"
                    Dim wl_frm As New frmATALM
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATANA"
                    Dim wl_frm As New frmATANA
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATAUT"
                    Dim wl_frm As New frmATAUT
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATBCO"
                    'Dim wl_frm As New frmATBCO
                    'Plo_LoadFrm(wl_frm,
                    '            wl_sCodFrm,
                    '            wl_sCodAut)
                Case "frmATCCC"
                Case "frmATCCO"
                    Dim wl_frm As New frmATCCO
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATCIF"
                    Dim wl_frm As New frmATCIF
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATCLI"
                    Dim wl_frm As New frmATCLI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATCOP"
                    Dim wl_frm As New frmATCOP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATCTC"
                    Dim wl_frm As New frmATCTC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATCTR"
                    Dim wl_frm As New frmATCTR
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATECO"
                Case "frmATERR"
                Case "frmATGRI"
                    Dim wl_frm As New frmATGRI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATIVA"
                    Dim wl_frm As New frmATIVA
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATMEP"
                    'Dim wl_frm As New frmATMEP
                    'Plo_LoadFrm(wl_frm,
                    '           wl_sCodFrm,
                    '           wl_sCodAut)
                Case "frmATMEV"
                Case "frmATMON"
                Case "frmATOPE"
                    Dim wl_frm As New frmATOPE
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATPAC"
                    Dim wl_frm As New frmATPAC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATPCO"
                    Dim wl_frm As New frmATPCO
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATPOP"
                    Dim wl_frm As New frmATPOP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATPUS"
                Case "frmATRCH"
                Case "frmATRET"
                    Dim wl_frm As New frmATRET
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATSGI"
                    Dim wl_frm As New frmATSGI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATTAC"
                Case "frmATTCM"
                Case "frmATTCO"
                Case "frmABTGE"
                Case "frmATTIA"
                    Dim wl_frm As New frmATTIA
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATTIN"
                    Dim wl_frm As New frmATTIN
                    Plo_LoadFrm(wl_frm,
                                wl_sCodFrm,
                                wl_sCodAut)
                Case "frmATUME"
                Case "frmATUPE"
                Case "frmATUSR"
                    Dim wl_frm As New frmATUSR
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATVEN"
                    Dim wl_frm As New frmATVEN
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmATZON"
                    Dim wl_frm As New frmATZON
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCEENI"
                    Dim wl_frm As New frmCEENI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCEFAP"
                    Dim wl_frm As New frmCEFAP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCENOC"
                    Dim wl_frm As New frmCENOC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCENOD"
                    Dim wl_frm As New frmCENOD
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCEODC"
                    Dim wl_frm As New frmCEODC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCR001"
                    Dim wl_frm As New frmCR001
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCR002"
                    Dim wl_frm As New frmCR002
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmCRODC01"
                    Dim wl_frm As New frmCRODC01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)

                Case "frmCESAI"
                    Dim wl_frm As New frmCESAI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmFECTT"
                Case "frmFEMOC"
                Case "frmFTNPU"
                Case "frmFTNSA"
                Case "frmFTNST"
                Case "frmFTPUC"
                    Dim wl_frm As New frmFTPUC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmFTSAC"
                Case "frmFTSAT"
                Case "frmGAPUS"
                    Dim wl_frm As New frmGAPUS
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmHEDME"
                Case "frmIEDMI"
                    Dim wl_frm As New frmIEDMI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmIEENI"
                    Dim wl_frm As New frmIEENI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmIELIP"
                Case "frmIEREV"
                    Dim wl_frm As New frmIEREV
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmIESAI"
                    Dim wl_frm As New frmIESAI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmIETRI"
                    Dim wl_frm As New frmIETRI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmRIDMI01"
                    Dim wl_frm As New frmRIDMI01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmRIDMI02"
                    Dim wl_frm As New frmRIDMI02
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmRIDMI03"
                    Dim wl_frm As New frmRIDMI03
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                              wl_sCodAut)
                Case "frmRIDMI04"
                    Dim wl_frm As New frmRIDMI04
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmRIMOV01"
                    Dim wl_frm As New frmRIMOV01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)

                Case "frmRIMOV02"
                    Dim wl_frm As New frmRIMOV02
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)

                Case "frmRIMOV03"
                    Dim wl_frm As New frmIRMOV03
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPEEDM"
                    Dim wl_frm As New frmPEEDM
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPEEDP"
                    Dim wl_frm As New frmPEEDP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPEFOM"
                    Dim wl_frm As New frmPEFOM
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPELIM"
                    Dim wl_frm As New frmPELIM
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPEODP"
                    Dim wl_frm As New frmPEODP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPERCI"
                    Dim wl_frm As New frmPERCI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmActPEROD"
                    Dim wl_frm As New frmActPEROD
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPEROD"
                    Dim wl_frm As New frmPEROD
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPRROD01"
                    Dim wl_frm As New frmPRROD01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPEROP"
                    Dim wl_frm As New frmPEROP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPESDM"
                    Dim wl_frm As New frmPESDM
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPESDP"
                    Dim wl_frm As New frmPESDP
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPQLIM01"
                    Dim wl_frm As New frmPQLIM01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPQLIM02"
                    Dim wl_frm As New frmPQLIM02
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPQROP01"
                    Dim wl_frm As New frmPQROP01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPQROP02"
                    Dim wl_frm As New frmPQROP02
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPRODP01"
                    Dim wl_frm As New frmPRODP01
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPRODP02"
                    Dim wl_frm As New frmPRODP02
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPRODP03"
                    Dim wl_frm As New frmPRODP03
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPRODP04"
                    Dim wl_frm As New frmPRODP04
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmPRODP05"
                    Dim wl_frm As New frmPRODP05
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmTEDMT"
                    Dim wl_frm As New frmTEDMT
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmVEENI"
                    Dim wl_frm As New frmVEENI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmVEFAC"
                    Dim wl_frm As New frmVEFAC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmVENOC"
                    Dim wl_frm As New frmVENOC
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmVENOD"
                    Dim wl_frm As New frmVENOD
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmVEPED"
                    Dim wl_frm As New frmVEPED
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmVESAI"
                    Dim wl_frm As New frmVESAI
                    Plo_LoadFrm(wl_frm,
                               wl_sCodFrm,
                               wl_sCodAut)
                Case "frmWTCAE"
                Case "frmWTCIU"
                Case "frmWTDEP"
                Case "frmWTPAI"
                Case "frmWTTID"
            End Select
            '     TreeView1.SelectedNode = Nothing
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarABOPC")
        End Try

    End Sub

#End Region

    ' Private Sub TreeView1_BeforeSelect(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeSelect
    '    TreeView1.SelectedNode = Nothing
    'End Sub

    Private Sub TreeView1_Click(sender As Object, e As System.EventArgs) Handles TreeView1.Click
        Try
            TreeView1.SelectedNode = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarABOPC")
        End Try

    End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Node.Name = "Nodo00" Then
            TreeView1.Nodes(1).Collapse()
            TreeView1.Nodes(2).Collapse()
            TreeView1.Nodes(3).Collapse()
            TreeView1.Nodes(4).Collapse()
            TreeView1.Nodes(5).Collapse()
        End If
        If e.Node.Name = "Nodo02" Then
            TreeView1.Nodes(0).Collapse()
            TreeView1.Nodes(2).Collapse()
            TreeView1.Nodes(3).Collapse()
            TreeView1.Nodes(4).Collapse()
            TreeView1.Nodes(5).Collapse()
        End If
        If e.Node.Name = "Nodo03" Then
            TreeView1.Nodes(0).Collapse()
            TreeView1.Nodes(1).Collapse()
            TreeView1.Nodes(3).Collapse()
            TreeView1.Nodes(4).Collapse()
            TreeView1.Nodes(5).Collapse()
        End If
        If e.Node.Name = "Nodo04" Then
            TreeView1.Nodes(0).Collapse()
            TreeView1.Nodes(1).Collapse()
            TreeView1.Nodes(2).Collapse()
            TreeView1.Nodes(4).Collapse()
            TreeView1.Nodes(5).Collapse()
        End If
        If e.Node.Name = "Nodo06" Then
            TreeView1.Nodes(0).Collapse()
            TreeView1.Nodes(1).Collapse()
            TreeView1.Nodes(2).Collapse()
            TreeView1.Nodes(3).Collapse()
            TreeView1.Nodes(5).Collapse()
        End If
        If e.Node.Name = "Nodo07" Then
            TreeView1.Nodes(0).Collapse()
            TreeView1.Nodes(1).Collapse()
            TreeView1.Nodes(2).Collapse()
            TreeView1.Nodes(3).Collapse()
            TreeView1.Nodes(4).Collapse()
        End If



    End Sub

#Region "080 Plo Procedimientos del Formulario"
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_LoadFrm(ByVal wp_frm As Form,
                            ByVal wp_sCodFrm As String,
                            ByRef wp_sCodAut As String)
        Try
            Dim wl_nCntRow As Integer

            wl_nCntRow = wg_aeATAUT.Count - 1
            If wl_nCntRow > 0 Then
                For wl_i = 0 To wg_aeATAUT.Count - 1
                    If wg_aeATAUT(wl_i).sCodFrm = wp_sCodFrm Then
                        wp_sCodAut = wg_aeATAUT(wl_i).sCodAut
                        Exit For
                    End If
                Next
            Else
                wp_sCodAut = "0"
            End If

            If wp_sCodAut <> "0" Then
                wp_frm.MdiParent = mdiPpal
                wp_frm.Activate()
                wp_frm.Show()
            Else
                MsgBox("Opción no autorizada")
            End If
        Catch ex As Exception
            MsgBox("Error :  Plo_LoadFrm")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


#End Region

#End Region

End Class