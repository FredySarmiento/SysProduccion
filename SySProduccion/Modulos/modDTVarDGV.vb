Module modDTVarDGV
#Region "ATCCO"
    Public Sub cpm_aeATCCO_DT(ByRef wp_aeATCCO As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATCCO As New clpEstructuras.eATCCO
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATCCO(wl_nCntReg) As clpEstructuras.eATCCO
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATCCO(wl_nRow) = New clpEstructuras.eATCCO
                wl_eATCCO = New clpEstructuras.eATCCO
                cpm_eATCCO_DT(wl_eATCCO,
                              wp_DT,
                              wl_nRow)
                va_aeATCCO(wl_nRow) = wl_eATCCO
            Next
            wp_aeATCCO = va_aeATCCO
        Catch ex As Exception
            MsgBox("Error : cpm_aeATCCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eATCCO_DT(ByRef wp_aATCCO As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATCCO As New clpEstructuras.eATCCO
            With wl_eATCCO
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sNomCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
            End With
            wp_aATCCO = wl_eATCCO
        Catch ex As Exception
            MsgBox("Error : cpm_eATCCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aeATCCO(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATCCO As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATCCO)
            Dim va_aeATCCO(wl_nCntReg) As clpEstructuras.eATCCO
            va_aeATCCO = wp_aeATCCO
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeATCCO(wl_nRow).nID
                    .Rows(wl_nRow).Cells(1).Value = va_aeATCCO(wl_nRow).sCodCco
                    .Rows(wl_nRow).Cells(2).Value = va_aeATCCO(wl_nRow).sNomCco
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aeATCCO")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eATCCO_DGV(ByRef wp_eATCCO As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATCCO As New clpEstructuras.eATCCO
            With va_eATCCO
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodCco = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .sNomCco = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value

            End With
            wp_eATCCO = va_eATCCO
        Catch ex As Exception
            MsgBox("Error : cpm_eATCCO_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DgvGLMOV1_eATCCO(ByRef wp_eATCCO As Object,
                                        ByVal wp_VlrCtrl As DataGridView,
                                        ByRef wp_nRow As Long)
        Try
            Dim wl_eATCCO As New clpEstructuras.eATCCO
            wl_eATCCO = wp_eATCCO
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(26).Value = wl_eATCCO.sCodCco
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DgvGLMOV1_eATCCO")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATIVA"
    Public Sub cpm_aeATIVA_DT(ByRef wp_aeATIVA As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATIVA As New clpEstructuras.eATIVA
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATIVA(wl_nCntReg) As clpEstructuras.eATIVA
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATIVA(wl_nRow) = New clpEstructuras.eATIVA
                wl_eATIVA = New clpEstructuras.eATIVA
                cpm_eATIVA_DT(wl_eATIVA,
                              wp_DT,
                              wl_nRow)
                va_aeATIVA(wl_nRow) = wl_eATIVA
            Next
            wp_aeATIVA = va_aeATIVA
        Catch ex As Exception
            MsgBox("Error : cpm_aeATIVA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eATIVA_DT(ByRef wp_aATIVA As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATIVA As New clpEstructuras.eATIVA
            With wl_eATIVA
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sNomIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
                .nPorIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(3)), wp_DT.Rows(wp_nRow).Item(3), 0)
                .bVdoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(4)), wp_DT.Rows(wp_nRow).Item(4), False)
                .sCtaCbeVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(5)), wp_DT.Rows(wp_nRow).Item(5), "")
                .bVdoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(6)), wp_DT.Rows(wp_nRow).Item(6), False)
                .sCtaCbeCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), "")
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), "")
            End With
            wp_aATIVA = wl_eATIVA
        Catch ex As Exception
            MsgBox("Error : cpm_eATIVA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aeATIVA(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATIVA As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATIVA)
            Dim va_aeATIVA(wl_nCntReg) As clpEstructuras.eATIVA
            va_aeATIVA = wp_aeATIVA
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeATIVA(wl_nRow).nID
                    .Rows(wl_nRow).Cells(1).Value = va_aeATIVA(wl_nRow).sCodIVA
                    .Rows(wl_nRow).Cells(2).Value = va_aeATIVA(wl_nRow).sNomIVA
                    .Rows(wl_nRow).Cells(3).Value = va_aeATIVA(wl_nRow).nPorIVA
                    .Rows(wl_nRow).Cells(4).Value = va_aeATIVA(wl_nRow).bVdoVta
                    .Rows(wl_nRow).Cells(5).Value = va_aeATIVA(wl_nRow).sCtaCbeVta
                    .Rows(wl_nRow).Cells(6).Value = va_aeATIVA(wl_nRow).bVdoCom
                    .Rows(wl_nRow).Cells(7).Value = va_aeATIVA(wl_nRow).sCtaCbeCom
                    .Rows(wl_nRow).Cells(8).Value = va_aeATIVA(wl_nRow).sClsDoc
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aeATIVA")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eATIVA_DGV(ByRef wp_eATIVA As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATIVA As New clpEstructuras.eATIVA
            With va_eATIVA
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodIVA = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .sNomIVA = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
                .nPorIVA = wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value
                .bVdoVta = wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value
                .sCtaCbeVta = wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value
                .bVdoCom = wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value
                .sCtaCbeCom = wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value
                .sClsDoc = wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value
            End With
            wp_eATIVA = va_eATIVA
        Catch ex As Exception
            MsgBox("Error : cpm_eATIVA_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DgvGLMOV1_eATIVA(ByRef wp_eATIVA As Object,
                                        ByVal wp_VlrCtrl As DataGridView,
                                        ByRef wp_nRow As Long)
        Try

            Dim wl_eATIVA As New clpEstructuras.eATIVA
            wl_eATIVA = wp_eATIVA
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(17).Value = wl_eATIVA.sCodIVA
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DgvGLMOV1_eATIVA")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATVEN"
    Public Sub cpm_aeATVEN_DT(ByRef wp_aeATVEN As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATVEN As New clpEstructuras.eATVEN
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATVEN(wl_nCntReg) As clpEstructuras.eATVEN
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATVEN(wl_nRow) = New clpEstructuras.eATVEN
                wl_eATVEN = New clpEstructuras.eATVEN
                cpm_eATVEN_DT(wl_eATVEN,
                              wp_DT,
                              wl_nRow)
                va_aeATVEN(wl_nRow) = wl_eATVEN
            Next
            wp_aeATVEN = va_aeATVEN
        Catch ex As Exception
            MsgBox("Error : cpm_aeATVEN_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eATVEN_DT(ByRef wp_aATVEN As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATVEN As New clpEstructuras.eATVEN
            With wl_eATVEN
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sNomVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
            End With
            wp_aATVEN = wl_eATVEN
        Catch ex As Exception
            MsgBox("Error : cpm_eATVEN_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aeATVEN(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATVEN As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATVEN)
            Dim va_aeATVEN(wl_nCntReg) As clpEstructuras.eATVEN
            va_aeATVEN = wp_aeATVEN
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeATVEN(wl_nRow).nID
                    .Rows(wl_nRow).Cells(1).Value = va_aeATVEN(wl_nRow).sCodVen
                    .Rows(wl_nRow).Cells(2).Value = va_aeATVEN(wl_nRow).sNomVen
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aeATVEN")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eATVEN_DGV(ByRef wp_eATVEN As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATVEN As New clpEstructuras.eATVEN
            With va_eATVEN
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodVen = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .sNomVen = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
                
            End With
            wp_eATVEN = va_eATVEN
        Catch ex As Exception
            MsgBox("Error : cpm_eATVEN_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DgvGLMOV1_eATVEN(ByRef wp_eATVEN As Object,
                                        ByVal wp_VlrCtrl As DataGridView,
                                        ByRef wp_nRow As Long)
        Try

            Dim wl_eATVEN As New clpEstructuras.eATVEN
            wl_eATVEN = wp_eATVEN
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(28).Value = wl_eATVEN.sCodVen
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DgvGLMOV1_eATVEN")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "FTPUC"
    Public Sub cpm_aeFTPUC_DT(ByRef wp_aeFTPUC As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eFTPUC As New clpEstructuras.eFTPUC
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeFTPUC(wl_nCntReg) As clpEstructuras.eFTPUC
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeFTPUC(wl_nRow) = New clpEstructuras.eFTPUC
                wl_eFTPUC = New clpEstructuras.eFTPUC
                cpm_eFTPUC_DT(wl_eFTPUC,
                              wp_DT,
                              wl_nRow)
                va_aeFTPUC(wl_nRow) = wl_eFTPUC
            Next
            wp_aeFTPUC = va_aeFTPUC
        Catch ex As Exception
            MsgBox("Error : cpm_aeFTPUC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eFTPUC_DT(ByRef wp_aFTPUC As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eFTPUC As New clpEstructuras.eFTPUC
            With wl_eFTPUC
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sNomCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
            End With
            wp_aFTPUC = wl_eFTPUC
        Catch ex As Exception
            MsgBox("Error : cpm_eFTPUC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aeFTPUC(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeFTPUC As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeFTPUC)
            Dim va_aeFTPUC(wl_nCntReg) As clpEstructuras.eFTPUC
            va_aeFTPUC = wp_aeFTPUC
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeFTPUC(wl_nRow).nID
                    .Rows(wl_nRow).Cells(1).Value = va_aeFTPUC(wl_nRow).sCodCta
                    .Rows(wl_nRow).Cells(2).Value = va_aeFTPUC(wl_nRow).sNomCta
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aeFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eFTPUC_DGV(ByRef wp_eFTPUC As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eFTPUC As New clpEstructuras.eFTPUC
            With va_eFTPUC
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodCta = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .sNomCta = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
            End With
            wp_eFTPUC = va_eFTPUC
        Catch ex As Exception
            MsgBox("Error : cpm_eFTPUC_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DgvGLMOV1_eFTPUC(ByRef wp_eFTPUC As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Long)
        Try

            Dim wl_eFTPUC As New clpEstructuras.eFTPUC
            wl_eFTPUC = wp_eFTPUC
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(24).Value = wl_eFTPUC.sCodCta
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DgvGLMOV1_eFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "IEDMI"
    Public Sub cpm_aeIELDMI1_DT(ByRef wp_aeIELDMI1 As Array,
                                ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eIELDMI1 As New clpEstructuras.eIELDMI1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIELDMI1(wl_nCntReg) As clpEstructuras.eIELDMI1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIELDMI1(wl_nRow) = New clpEstructuras.eIELDMI1
                wl_eIELDMI1 = New clpEstructuras.eIELDMI1
                cpm_eIELDMI1_DT(wl_eIELDMI1,
                                wp_DT,
                                wl_nRow)
                wl_aeIELDMI1(wl_nRow) = wl_eIELDMI1
            Next
            wp_aeIELDMI1 = wl_aeIELDMI1
        Catch ex As Exception
            MsgBox("Error : cpm_aeIELDMI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eIELDMI1_DT(ByRef wp_eIELDMI1 As Object,
                               ByVal wp_DT As DataTable,
                               ByVal wp_nRow As Integer)
        Try
            Dim wl_eIELDMI1 As New clpEstructuras.eIELDMI1
            With wl_eIELDMI1.eIEDMI
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sCodBar = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(3)), wp_DT.Rows(wp_nRow).Item(3), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(4)), wp_DT.Rows(wp_nRow).Item(4), "")
                .sClsItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(5)), wp_DT.Rows(wp_nRow).Item(5), "")
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(6)), wp_DT.Rows(wp_nRow).Item(6), "")
                .sCodSgr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), "")
                .bItmInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(8)), wp_DT.Rows(wp_nRow).Item(8), False)
                .bItmVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(9)), wp_DT.Rows(wp_nRow).Item(9), False)
                .bItmCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(10), False)
                .bIndIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(11)), wp_DT.Rows(wp_nRow).Item(11), False)
                .sCodAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(12)), wp_DT.Rows(wp_nRow).Item(12), "")
                .sTipGes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(13)), wp_DT.Rows(wp_nRow).Item(13), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(14)), wp_DT.Rows(wp_nRow).Item(14), False)
                .bItmIna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(15)), wp_DT.Rows(wp_nRow).Item(15), False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(16)), wp_DT.Rows(wp_nRow).Item(16), "")
                .sCodTerFte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(17)), wp_DT.Rows(wp_nRow).Item(17), "")
                .sCodItmFte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(18)), wp_DT.Rows(wp_nRow).Item(18), "")
                .sUniMedCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(19)), wp_DT.Rows(wp_nRow).Item(19), "")
                .nCanUniCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(20)), wp_DT.Rows(wp_nRow).Item(20), 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(21)), wp_DT.Rows(wp_nRow).Item(21), "")
                .nCanUniECom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(22)), wp_DT.Rows(wp_nRow).Item(22), 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(23)), wp_DT.Rows(wp_nRow).Item(23), "")
                .sUniMedVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(24)), wp_DT.Rows(wp_nRow).Item(24), "")
                .nCanUniVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(25)), wp_DT.Rows(wp_nRow).Item(25), 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(26)), wp_DT.Rows(wp_nRow).Item(26), "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(27)), wp_DT.Rows(wp_nRow).Item(27), 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(28)), wp_DT.Rows(wp_nRow).Item(28), "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(29)), wp_DT.Rows(wp_nRow).Item(29), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(30)), wp_DT.Rows(wp_nRow).Item(30), "")
                .sMetVlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(31)), wp_DT.Rows(wp_nRow).Item(31), "")
                .nCosItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(32)), wp_DT.Rows(wp_nRow).Item(32), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(33)), wp_DT.Rows(wp_nRow).Item(33), "")
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(34)), wp_DT.Rows(wp_nRow).Item(34), 0)
                .sIvaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(35)), wp_DT.Rows(wp_nRow).Item(35), "")
                .sIvaVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(36)), wp_DT.Rows(wp_nRow).Item(36), "")
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(37)), wp_DT.Rows(wp_nRow).Item(37), "")
            End With
            With wl_eIELDMI1.eILDMI1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(38)), wp_DT.Rows(wp_nRow).Item(38), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(39)), wp_DT.Rows(wp_nRow).Item(39), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(40)), wp_DT.Rows(wp_nRow).Item(40), "")
                .nCanMin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(41)), wp_DT.Rows(wp_nRow).Item(41), 0)
                .nCanMax = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(42)), wp_DT.Rows(wp_nRow).Item(42), 0)
                .nOrdMin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(43)), wp_DT.Rows(wp_nRow).Item(43), 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(44)), wp_DT.Rows(wp_nRow).Item(44), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(45)), wp_DT.Rows(wp_nRow).Item(45), 0)
                .nVlrTot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(46)), wp_DT.Rows(wp_nRow).Item(46), 0)
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(47)), wp_DT.Rows(wp_nRow).Item(47), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(48)), wp_DT.Rows(wp_nRow).Item(48), "")
                .sCtaTrs = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(49)), wp_DT.Rows(wp_nRow).Item(49), "")
                .sCtaIng = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(50)), wp_DT.Rows(wp_nRow).Item(50), "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(51)), wp_DT.Rows(wp_nRow).Item(51), "")
                .sCtaGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(52)), wp_DT.Rows(wp_nRow).Item(52), "")
                .sCtaDot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(53)), wp_DT.Rows(wp_nRow).Item(53), "")
                .sCtaDifPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(54)), wp_DT.Rows(wp_nRow).Item(54), "")
                .sCtaDsv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(55)), wp_DT.Rows(wp_nRow).Item(55), "")
                .sCtaRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(56)), wp_DT.Rows(wp_nRow).Item(56), "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(57)), wp_DT.Rows(wp_nRow).Item(57), "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(58)), wp_DT.Rows(wp_nRow).Item(58), "")
                .sCtaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(59)), wp_DT.Rows(wp_nRow).Item(59), "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(60)), wp_DT.Rows(wp_nRow).Item(60), "")
            End With
            wp_eIELDMI1 = wl_eIELDMI1
        Catch ex As Exception
            MsgBox("Error : cpm_eIELDMI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_eIELDMI1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aeIELDMI1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIELDMI1)
            Dim va_aeIELDMI1(wl_nCntReg) As clpEstructuras.eIELDMI1
            va_aeIELDMI1 = wp_aeIELDMI1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nId
                    .Rows(wl_nRow).Cells(1).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodItm
                    .Rows(wl_nRow).Cells(2).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodBar
                    .Rows(wl_nRow).Cells(3).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sNomItm
                    .Rows(wl_nRow).Cells(4).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sNomAlt
                    .Rows(wl_nRow).Cells(5).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sClsItm
                    .Rows(wl_nRow).Cells(6).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodGrp
                    .Rows(wl_nRow).Cells(7).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodSgr
                    .Rows(wl_nRow).Cells(8).Value = va_aeIELDMI1(wl_nRow).eIEDMI.bItmInv
                    .Rows(wl_nRow).Cells(9).Value = va_aeIELDMI1(wl_nRow).eIEDMI.bItmVta
                    .Rows(wl_nRow).Cells(10).Value = va_aeIELDMI1(wl_nRow).eIEDMI.bItmCom
                    .Rows(wl_nRow).Cells(11).Value = va_aeIELDMI1(wl_nRow).eIEDMI.bIndIVA
                    .Rows(wl_nRow).Cells(12).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodAlt
                    .Rows(wl_nRow).Cells(13).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sTipGes
                    .Rows(wl_nRow).Cells(14).Value = va_aeIELDMI1(wl_nRow).eIEDMI.bItmAct
                    .Rows(wl_nRow).Cells(15).Value = va_aeIELDMI1(wl_nRow).eIEDMI.bItmIna
                    .Rows(wl_nRow).Cells(16).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodTerPrv
                    .Rows(wl_nRow).Cells(17).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodTerFte
                    .Rows(wl_nRow).Cells(18).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodItmFte
                    .Rows(wl_nRow).Cells(19).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sUniMedCom
                    .Rows(wl_nRow).Cells(20).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nCanUniCom
                    .Rows(wl_nRow).Cells(21).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sUniEmpCom
                    .Rows(wl_nRow).Cells(22).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nCanUniECom
                    .Rows(wl_nRow).Cells(23).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodItoCom
                    .Rows(wl_nRow).Cells(24).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sUniMedVta
                    .Rows(wl_nRow).Cells(25).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nCanUniVta
                    .Rows(wl_nRow).Cells(26).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sUniEmpVta
                    .Rows(wl_nRow).Cells(27).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nCanUniEVta
                    .Rows(wl_nRow).Cells(28).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodItoVta
                    .Rows(wl_nRow).Cells(29).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCriCtaCbe
                    .Rows(wl_nRow).Cells(30).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sUniMedInv
                    .Rows(wl_nRow).Cells(31).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sMetVlz
                    .Rows(wl_nRow).Cells(32).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nCosItm
                    .Rows(wl_nRow).Cells(33).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodAlm
                    .Rows(wl_nRow).Cells(34).Value = va_aeIELDMI1(wl_nRow).eIEDMI.nSdoInv
                    .Rows(wl_nRow).Cells(35).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sIvaCom
                    .Rows(wl_nRow).Cells(36).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sIvaVta
                    .Rows(wl_nRow).Cells(37).Value = va_aeIELDMI1(wl_nRow).eIEDMI.sCodCco
                    .Rows(wl_nRow).Cells(38).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nId
                    .Rows(wl_nRow).Cells(39).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCodItm
                    .Rows(wl_nRow).Cells(40).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCodAlm
                    .Rows(wl_nRow).Cells(41).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nCanMin
                    .Rows(wl_nRow).Cells(42).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nCanMax
                    .Rows(wl_nRow).Cells(43).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nOrdMin
                    .Rows(wl_nRow).Cells(44).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nSdoAlm
                    .Rows(wl_nRow).Cells(45).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nPreUni
                    .Rows(wl_nRow).Cells(46).Value = va_aeIELDMI1(wl_nRow).eILDMI1.nVlrTot
                    .Rows(wl_nRow).Cells(47).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaInv
                    .Rows(wl_nRow).Cells(48).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaCosVta
                    .Rows(wl_nRow).Cells(49).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaTrs
                    .Rows(wl_nRow).Cells(50).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaIng
                    .Rows(wl_nRow).Cells(51).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaDevVta
                    .Rows(wl_nRow).Cells(52).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaGto
                    .Rows(wl_nRow).Cells(53).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaDot
                    .Rows(wl_nRow).Cells(54).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaDifPre
                    .Rows(wl_nRow).Cells(55).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaDsv
                    .Rows(wl_nRow).Cells(56).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaRev
                    .Rows(wl_nRow).Cells(57).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaAumInv
                    .Rows(wl_nRow).Cells(58).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaRedInv
                    .Rows(wl_nRow).Cells(59).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaCom
                    .Rows(wl_nRow).Cells(60).Value = va_aeIELDMI1(wl_nRow).eILDMI1.sCtaDevCom
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eIELDMI1_DGV(ByRef wp_eIELDMI1 As Object,
                                ByVal wp_VlrCtrl As DataGridView,
                                ByRef wp_nRow As Integer)
        Try
            Dim va_eIELDMI1 As New clpEstructuras.eIELDMI1
            With va_eIELDMI1.eIEDMI
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value, 0)
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value, "")
                .sCodBar = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value, "")
                .sNomItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value, "")
                .sNomAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value, "")
                .sClsItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value, "")
                .sCodGrp = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value, "")
                .sCodSgr = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value, "")
                .bItmInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value, False)
                .bItmVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(9).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(9).Value, False)
                .bItmCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(10).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(10).Value, False)
                .bIndIVA = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(11).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(11).Value, False)
                .sCodAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(12).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(12).Value, "")
                .sTipGes = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(13).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(13).Value, "")
                .bItmAct = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(14).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(14).Value, False)
                .bItmIna = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(15).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(15).Value, False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(16).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(16).Value, "")
                .sCodTerFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(17).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(17).Value, "")
                .sCodItmFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(18).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(18).Value, "")
                .sUniMedCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(19).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(19).Value, "")
                .nCanUniCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(20).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(20).Value, 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(21).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(21).Value, "")
                .nCanUniECom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(22).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(22).Value, 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(23).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(23).Value, "")
                .sUniMedVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(24).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(24).Value, "")
                .nCanUniVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(25).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(25).Value, 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(26).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(26).Value, "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(27).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(27).Value, 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(28).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(28).Value, "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(29).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(29).Value, "")
                .sUniMedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(30).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(30).Value, "")
                .sMetVlz = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(31).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(31).Value, "")
                .nCosItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(32).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(32).Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(33).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(33).Value, "")
                .nSdoInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(34).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(34).Value, 0)
                .sIvaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(35).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(35).Value, "")
                .sIvaVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(36).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(36).Value, "")
                .sCodCco = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(37).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(37).Value, "")
            End With
            With va_eIELDMI1.eILDMI1
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(38).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(38).Value, "")
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(39).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(39).Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(40).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(40).Value, "")
                .nCanMin = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(41).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(41).Value, 0)
                .nCanMax = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(42).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(42).Value, 0)
                .nOrdMin = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(43).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(43).Value, 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(44).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(44).Value, 0)
                .nPreUni = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(45).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(45).Value, 0)
                .nVlrTot = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(46).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(46).Value, 0)
                .sCtaInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(47).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(47).Value, "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(48).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(48).Value, "")
                .sCtaTrs = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(49).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(49).Value, "")
                .sCtaIng = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(50).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(50).Value, "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(51).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(51).Value, "")
                .sCtaGto = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(52).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(52).Value, "")
                .sCtaDot = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(53).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(53).Value, "")
                .sCtaDifPre = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(54).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(54).Value, "")
                .sCtaDsv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(55).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(55).Value, "")
                .sCtaRev = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(56).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(56).Value, "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(57).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(57).Value, "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(58).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(58).Value, "")
                .sCtaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(59).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(59).Value, "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(60).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(60).Value, "")
            End With
            wp_eIELDMI1 = va_eIELDMI1
        Catch ex As Exception
            MsgBox("Error : cpm_eIELDMI1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DT_eIELDMI1(ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeIELDMI1(wl_nCntReg) As clpEstructuras.eIELDMI1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeIELDMI1(wl_nRow) = New clpEstructuras.eIELDMI1
                With va_aeIELDMI1(wl_nRow).eIEDMI
                    wp_DT.Rows(wl_nRow).Item(0) = .nId
                    wp_DT.Rows(wl_nRow).Item(1) = .sCodItm
                    wp_DT.Rows(wl_nRow).Item(2) = .sCodBar
                    wp_DT.Rows(wl_nRow).Item(3) = .sNomItm
                    wp_DT.Rows(wl_nRow).Item(4) = .sNomAlt
                    wp_DT.Rows(wl_nRow).Item(5) = .sClsItm
                    wp_DT.Rows(wl_nRow).Item(6) = .sCodGrp
                    wp_DT.Rows(wl_nRow).Item(7) = .sCodSgr
                    wp_DT.Rows(wl_nRow).Item(8) = .bItmInv
                    wp_DT.Rows(wl_nRow).Item(9) = .bItmVta
                    wp_DT.Rows(wl_nRow).Item(10) = .bItmCom
                    wp_DT.Rows(wl_nRow).Item(11) = .bIndIVA
                    wp_DT.Rows(wl_nRow).Item(12) = .sCodAlt
                    wp_DT.Rows(wl_nRow).Item(13) = .sTipGes
                    wp_DT.Rows(wl_nRow).Item(14) = .bItmAct
                    wp_DT.Rows(wl_nRow).Item(15) = .bItmIna
                    wp_DT.Rows(wl_nRow).Item(16) = .sCodTerPrv
                    wp_DT.Rows(wl_nRow).Item(17) = .sCodTerFte
                    wp_DT.Rows(wl_nRow).Item(18) = .sCodItmFte
                    wp_DT.Rows(wl_nRow).Item(19) = .sUniMedCom
                    wp_DT.Rows(wl_nRow).Item(20) = .nCanUniCom
                    wp_DT.Rows(wl_nRow).Item(21) = .sUniEmpCom
                    wp_DT.Rows(wl_nRow).Item(22) = .nCanUniECom
                    wp_DT.Rows(wl_nRow).Item(23) = .sCodItoCom
                    wp_DT.Rows(wl_nRow).Item(24) = .sUniMedVta
                    wp_DT.Rows(wl_nRow).Item(25) = .nCanUniVta
                    wp_DT.Rows(wl_nRow).Item(26) = .sUniEmpVta
                    wp_DT.Rows(wl_nRow).Item(27) = .nCanUniEVta
                    wp_DT.Rows(wl_nRow).Item(28) = .sCodItoVta
                    wp_DT.Rows(wl_nRow).Item(29) = .sCriCtaCbe
                    wp_DT.Rows(wl_nRow).Item(30) = .sUniMedInv
                    wp_DT.Rows(wl_nRow).Item(31) = .sMetVlz
                    wp_DT.Rows(wl_nRow).Item(32) = .nCosItm
                    wp_DT.Rows(wl_nRow).Item(33) = .sCodAlm
                    wp_DT.Rows(wl_nRow).Item(34) = .nSdoInv
                    wp_DT.Rows(wl_nRow).Item(35) = .sIvaCom
                    wp_DT.Rows(wl_nRow).Item(36) = .sIvaVta
                    wp_DT.Rows(wl_nRow).Item(37) = .sCodCco
                End With
                With va_aeIELDMI1(wl_nRow).eILDMI1
                    wp_DT.Rows(wl_nRow).Item(38) = .nId
                    wp_DT.Rows(wl_nRow).Item(39) = .sCodItm
                    wp_DT.Rows(wl_nRow).Item(40) = .sCodAlm
                    wp_DT.Rows(wl_nRow).Item(41) = .nCanMin
                    wp_DT.Rows(wl_nRow).Item(42) = .nCanMax
                    wp_DT.Rows(wl_nRow).Item(43) = .nOrdMin
                    wp_DT.Rows(wl_nRow).Item(44) = .nSdoAlm
                    wp_DT.Rows(wl_nRow).Item(45) = .nPreUni
                    wp_DT.Rows(wl_nRow).Item(46) = .nVlrTot
                    wp_DT.Rows(wl_nRow).Item(47) = .sCtaInv
                    wp_DT.Rows(wl_nRow).Item(48) = .sCtaCosVta
                    wp_DT.Rows(wl_nRow).Item(49) = .sCtaTrs
                    wp_DT.Rows(wl_nRow).Item(50) = .sCtaIng
                    wp_DT.Rows(wl_nRow).Item(51) = .sCtaDevVta
                    wp_DT.Rows(wl_nRow).Item(52) = .sCtaGto
                    wp_DT.Rows(wl_nRow).Item(53) = .sCtaDot
                    wp_DT.Rows(wl_nRow).Item(54) = .sCtaDifPre
                    wp_DT.Rows(wl_nRow).Item(55) = .sCtaDsv
                    wp_DT.Rows(wl_nRow).Item(56) = .sCtaRev
                    wp_DT.Rows(wl_nRow).Item(57) = .sCtaAumInv
                    wp_DT.Rows(wl_nRow).Item(58) = .sCtaRedInv
                    wp_DT.Rows(wl_nRow).Item(59) = .sCtaCom
                    wp_DT.Rows(wl_nRow).Item(60) = .sCtaDevCom
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DT_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eIEDMI_DGV(ByRef wp_eIEDMI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eIEDMI As New clpEstructuras.eIEDMI
            With va_eIEDMI
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value, 0)
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value, "")
                .sCodBar = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value, "")
                .sNomItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value, "")
                .sNomAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value, "")
                .sClsItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value, "")
                .sCodGrp = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value, "")
                .sCodSgr = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value, "")
                .bItmInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value, False)
                .bItmVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(9).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(9).Value, False)
                .bItmCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(10).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(10).Value, False)
                .bIndIVA = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(11).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(11).Value, False)
                .sCodAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(12).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(12).Value, "")
                .sTipGes = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(13).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(13).Value, "")
                .bItmAct = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(14).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(14).Value, False)
                .bItmIna = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(15).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(15).Value, False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(16).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(16).Value, "")
                .sCodTerFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(17).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(17).Value, "")
                .sCodItmFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(18).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(18).Value, "")
                .sUniMedCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(19).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(19).Value, "")
                .nCanUniCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(20).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(20).Value, 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(21).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(21).Value, "")
                .nCanUniECom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(22).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(22).Value, 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(23).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(23).Value, "")
                .sUniMedVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(24).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(24).Value, "")
                .nCanUniVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(25).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(25).Value, 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(26).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(26).Value, "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(27).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(27).Value, 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(28).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(28).Value, "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(29).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(29).Value, "")
                .sUniMedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(30).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(30).Value, "")
                .sMetVlz = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(31).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(31).Value, "")
                .nCosItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(32).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(32).Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(33).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(33).Value, "")
                .nSdoInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(34).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(34).Value, 0)
                .sIvaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(35).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(35).Value, "")
                .sIvaVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(36).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(36).Value, "")
                .sCodCco = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells(37).Value), wp_VlrCtrl.Rows(wp_nRow).Cells(36).Value, "")
            End With
            wp_eIEDMI = va_eIEDMI
        Catch ex As Exception
            MsgBox("Error : cpm_eIEDMI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGVGLMOV1_eIELDMI1(ByRef wp_eIELDMI1 As Object,
                                          ByVal wp_VlrCtrl As DataGridView,
                                          ByRef wp_nRow As Integer)
        Try

            Dim va_eIELDMI1 As New clpEstructuras.eIELDMI1
            va_eIELDMI1 = wp_eIELDMI1
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(6).Value = va_eIELDMI1.eIEDMI.sCodItm
                .Rows(wp_nRow).Cells(7).Value = va_eIELDMI1.eIEDMI.sNomItm
                .Rows(wp_nRow).Cells(8).Value = va_eIELDMI1.eILDMI1.sCodAlm
                .Rows(wp_nRow).Cells(10).Value = va_eIELDMI1.eIEDMI.sUniMedInv
                .Rows(wp_nRow).Cells(11).Value = va_eIELDMI1.eILDMI1.nPreUni
                .Rows(wp_nRow).Cells(23).Value = va_eIELDMI1.eILDMI1.nSdoAlm
                .Rows(wp_nRow).Cells(24).Value = va_eIELDMI1.eILDMI1.sCtaInv
                .Rows(wp_nRow).Cells(26).Value = va_eIELDMI1.eIEDMI.sCodCco
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DGVGLMOV1_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "IEMOV"
    Public Sub cpm_DGVGLMOV1_aeGLMOV1(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_aeGLMOV1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeGLMOV1)
            Dim va_aeGLMOV1(wl_nCntReg) As clpEstructuras.eGLMOV1
            va_aeGLMOV1 = wp_aeGLMOV1
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeGLMOV1(wl_nRow).nID
                    .Rows(wl_nRow).Cells(1).Value = va_aeGLMOV1(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells(2).Value = va_aeGLMOV1(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells(3).Value = va_aeGLMOV1(wl_nRow).sTipMov
                    .Rows(wl_nRow).Cells(4).Value = va_aeGLMOV1(wl_nRow).sCodDocBas
                    .Rows(wl_nRow).Cells(5).Value = va_aeGLMOV1(wl_nRow).nNroDocBas
                    .Rows(wl_nRow).Cells(6).Value = va_aeGLMOV1(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells(7).Value = va_aeGLMOV1(wl_nRow).sDesItm
                    .Rows(wl_nRow).Cells(8).Value = va_aeGLMOV1(wl_nRow).sCodAlm
                    .Rows(wl_nRow).Cells(9).Value = va_aeGLMOV1(wl_nRow).nCanItm
                    .Rows(wl_nRow).Cells(10).Value = va_aeGLMOV1(wl_nRow).sUniMedInv
                    .Rows(wl_nRow).Cells(11).Value = va_aeGLMOV1(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells(12).Value = va_aeGLMOV1(wl_nRow).nPorDto
                    .Rows(wl_nRow).Cells(13).Value = va_aeGLMOV1(wl_nRow).nVlrDto
                    .Rows(wl_nRow).Cells(14).Value = va_aeGLMOV1(wl_nRow).nPreDto
                    .Rows(wl_nRow).Cells(15).Value = va_aeGLMOV1(wl_nRow).nVlrDtoLin
                    .Rows(wl_nRow).Cells(16).Value = va_aeGLMOV1(wl_nRow).nVlrTot
                    .Rows(wl_nRow).Cells(17).Value = va_aeGLMOV1(wl_nRow).sCodIva
                    .Rows(wl_nRow).Cells(18).Value = va_aeGLMOV1(wl_nRow).nPorIva
                    .Rows(wl_nRow).Cells(19).Value = va_aeGLMOV1(wl_nRow).nVlrIva
                    .Rows(wl_nRow).Cells(20).Value = va_aeGLMOV1(wl_nRow).nVlrIvaLin
                    .Rows(wl_nRow).Cells(21).Value = va_aeGLMOV1(wl_nRow).nPreBru
                    .Rows(wl_nRow).Cells(22).Value = va_aeGLMOV1(wl_nRow).nTotLin
                    .Rows(wl_nRow).Cells(24).Value = va_aeGLMOV1(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells(25).Value = va_aeGLMOV1(wl_nRow).nPorCms
                    .Rows(wl_nRow).Cells(26).Value = va_aeGLMOV1(wl_nRow).sCodCco
                    .Rows(wl_nRow).Cells(27).Value = va_aeGLMOV1(wl_nRow).sTipLIM
                    .Rows(wl_nRow).Cells(28).Value = va_aeGLMOV1(wl_nRow).sCodVen
                    .Rows(wl_nRow).Cells(29).Value = va_aeGLMOV1(wl_nRow).nLinBas
                    .Rows(wl_nRow).Cells(30).Value = va_aeGLMOV1(wl_nRow).sCodPdo
                    .Rows(wl_nRow).Cells(31).Value = va_aeGLMOV1(wl_nRow).bSolIto
                    .Rows(wl_nRow).Cells(32).Value = va_aeGLMOV1(wl_nRow).sCtaCosVta
                    .Rows(wl_nRow).Cells(33).Value = va_aeGLMOV1(wl_nRow).bItmBlq
                    .Rows(wl_nRow).Cells(34).Value = va_aeGLMOV1(wl_nRow).sCodSer
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGVGLMOV1_aeGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eGEMOV_DT(ByRef wp_eGEMOV As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New clpEstructuras.eGEMOV
            With wl_eGEMOV
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), 0)
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(3)), wp_DT.Rows(wp_nRow).Item(3), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(4)), wp_DT.Rows(wp_nRow).Item(4), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(5)), wp_DT.Rows(wp_nRow).Item(5), "")
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(6)), wp_DT.Rows(wp_nRow).Item(6), "")
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), "")
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(8)), wp_DT.Rows(wp_nRow).Item(8), "")
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(9)), wp_DT.Rows(wp_nRow).Item(9), "")
                .sDesTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(10), "")
                .nPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(11)), wp_DT.Rows(wp_nRow).Item(11), 0)
                .sAlmOri = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(12)), wp_DT.Rows(wp_nRow).Item(12), "")
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(13)), wp_DT.Rows(wp_nRow).Item(13), "")
                .nTotDtoLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(14)), wp_DT.Rows(wp_nRow).Item(14), 0)
                .nTotTot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(15)), wp_DT.Rows(wp_nRow).Item(15), 0)
                .nTotIvaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(16)), wp_DT.Rows(wp_nRow).Item(16), 0)
                .nTotIvaVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(17)), wp_DT.Rows(wp_nRow).Item(17), 0)
                .nVlrTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(18)), wp_DT.Rows(wp_nRow).Item(18), 0)
                .sCodCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(19)), wp_DT.Rows(wp_nRow).Item(19), "")
                .nNroCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(20)), wp_DT.Rows(wp_nRow).Item(20), 0)
                .sCndPag = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(21)), wp_DT.Rows(wp_nRow).Item(21), "")
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(22)), wp_DT.Rows(wp_nRow).Item(22), "")
                .sTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(23)), wp_DT.Rows(wp_nRow).Item(23), "")
                .sCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(24)), wp_DT.Rows(wp_nRow).Item(24), "")
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(24)), wp_DT.Rows(wp_nRow).Item(25), "")
            End With
            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : cpm_eGEMOV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eGLMOV1_DGVGLMOV1(ByRef wp_eGLMOV1 As Object,
                                     ByVal wp_VlrCtrl As DataGridView,
                                     ByRef wp_nRow As Integer)
        Try
            Dim va_eGLMOV1 As New clpEstructuras.eGLMOV1
            With wp_VlrCtrl
                va_eGLMOV1.nID = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(0).Value), .Rows(wp_nRow).Cells(0).Value, 0)
                va_eGLMOV1.sCodDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(1).Value), .Rows(wp_nRow).Cells(1).Value, "")
                va_eGLMOV1.nNroDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(2).Value), .Rows(wp_nRow).Cells(2).Value, 0)
                va_eGLMOV1.sTipMov = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(3).Value), .Rows(wp_nRow).Cells(3).Value, "")
                va_eGLMOV1.sCodDocBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(4).Value), .Rows(wp_nRow).Cells(4).Value, "")
                va_eGLMOV1.nNroDocBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(5).Value), .Rows(wp_nRow).Cells(5).Value, 0)
                va_eGLMOV1.sCodItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(6).Value), .Rows(wp_nRow).Cells(6).Value, "")
                va_eGLMOV1.sDesItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(7).Value), .Rows(wp_nRow).Cells(7).Value, "")
                va_eGLMOV1.sCodAlm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(8).Value), .Rows(wp_nRow).Cells(8).Value, "")
                va_eGLMOV1.nCanItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(9).Value), .Rows(wp_nRow).Cells(9).Value, 0)
                va_eGLMOV1.sUniMedInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(10).Value), .Rows(wp_nRow).Cells(10).Value, "")
                va_eGLMOV1.nPreUni = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(11).Value), .Rows(wp_nRow).Cells(11).Value, 0)
                va_eGLMOV1.nPorDto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(12).Value), .Rows(wp_nRow).Cells(12).Value, 0)
                va_eGLMOV1.nVlrDto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(13).Value), .Rows(wp_nRow).Cells(13).Value, 0)
                va_eGLMOV1.nPreDto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(14).Value), .Rows(wp_nRow).Cells(14).Value, 0)
                va_eGLMOV1.nVlrDtoLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(15).Value), .Rows(wp_nRow).Cells(15).Value, 0)
                va_eGLMOV1.nVlrTot = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(16).Value), .Rows(wp_nRow).Cells(16).Value, 0)
                va_eGLMOV1.sCodIva = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(17).Value), .Rows(wp_nRow).Cells(17).Value, "")
                va_eGLMOV1.nPorIva = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(18).Value), .Rows(wp_nRow).Cells(18).Value, 0)
                va_eGLMOV1.nVlrIva = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(19).Value), .Rows(wp_nRow).Cells(19).Value, 0)
                va_eGLMOV1.nVlrIvaLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(20).Value), .Rows(wp_nRow).Cells(20).Value, 0)
                va_eGLMOV1.nPreBru = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(21).Value), .Rows(wp_nRow).Cells(21).Value, 0)
                va_eGLMOV1.nTotLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(22).Value), .Rows(wp_nRow).Cells(22).Value, 0)
                va_eGLMOV1.sCtaInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(24).Value), .Rows(wp_nRow).Cells(24).Value, "")
                va_eGLMOV1.nPorCms = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(25).Value), .Rows(wp_nRow).Cells(25).Value, 0)
                va_eGLMOV1.sCodCco = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(26).Value), .Rows(wp_nRow).Cells(26).Value, "")
                va_eGLMOV1.sTipLIM = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(27).Value), .Rows(wp_nRow).Cells(27).Value, "")
                va_eGLMOV1.sCodVen = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(28).Value), .Rows(wp_nRow).Cells(28).Value, "")
                va_eGLMOV1.nLinBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(29).Value), .Rows(wp_nRow).Cells(29).Value, 0)
                va_eGLMOV1.sCodPdo = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(30).Value), .Rows(wp_nRow).Cells(30).Value, "")
                va_eGLMOV1.bSolIto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(31).Value), .Rows(wp_nRow).Cells(31).Value, False)
                va_eGLMOV1.sCtaCosVta = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(32).Value), .Rows(wp_nRow).Cells(32).Value, "")
                va_eGLMOV1.bItmBlq = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(33).Value), .Rows(wp_nRow).Cells(33).Value, False)
                va_eGLMOV1.sCodSer = IIf(Not IsDBNull(.Rows(wp_nRow).Cells(33).Value), .Rows(wp_nRow).Cells(34).Value, False)
            End With
            wp_eGLMOV1 = va_eGLMOV1
        Catch ex As Exception
            MsgBox("Error : cpm_eIELDMI1_DGVGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ITALM"
    Public Sub cpm_aeITALM_DT(ByRef wp_aeITALM As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eITALM As New clpEstructuras.eITALM
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeITALM(wl_nCntReg) As clpEstructuras.eITALM
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeITALM(wl_nRow) = New clpEstructuras.eITALM
                wl_eITALM = New clpEstructuras.eITALM
                cpm_eITALM_DT(wl_eITALM,
                              wp_DT,
                              wl_nRow)
                va_aeITALM(wl_nRow) = wl_eITALM
            Next
            wp_aeITALM = va_aeITALM
        Catch ex As Exception
            MsgBox("Error : cpm_eaITALM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eITALM_DT(ByRef wp_aITALM As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eITALM As New clpEstructuras.eITALM
            With wl_eITALM
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sNomAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(3)), wp_DT.Rows(wp_nRow).Item(3), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(4)), wp_DT.Rows(wp_nRow).Item(4), "")
            End With
            wp_aITALM = wl_eITALM
        Catch ex As Exception
            MsgBox("Error : cpm_eITALM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aeITALM(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeITALM As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeITALM)
            Dim va_aeITALM(wl_nCntReg) As clpEstructuras.eITALM
            va_aeITALM = wp_aeITALM
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeITALM(wl_nRow).nId
                    .Rows(wl_nRow).Cells(1).Value = va_aeITALM(wl_nRow).sCodAlm
                    .Rows(wl_nRow).Cells(2).Value = va_aeITALM(wl_nRow).sNomAlm
                    .Rows(wl_nRow).Cells(3).Value = va_aeITALM(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells(4).Value = va_aeITALM(wl_nRow).sCtaCosVta
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_eITALM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eITALM_DGV(ByRef wp_eITALM As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eITALM As New clpEstructuras.eITALM
            With va_eITALM
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .sNomAlm = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
                .sCtaInv = wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value
                .sCtaCosVta = wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value
            End With
            wp_eITALM = va_eITALM
        Catch ex As Exception
            MsgBox("Error : cpm_eITALM_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGVGLMOV1_eITALM(ByRef wp_eITALM As Object,
                                        ByVal wp_VlrCtrl As DataGridView,
                                        ByRef wp_nRow As Integer)
        Try

            Dim wl_eITALM As New clpEstructuras.eITALM
            wl_eITALM = wp_eITALM
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(8).Value = wl_eITALM.sCodAlm
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DGVGLMOV1_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PEODP"
    Public Sub cpm_aePEODP_DT(ByRef wp_aePEODP As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP As New clpEstructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePEODP(wl_nCntReg) As clpEstructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePEODP(wl_nRow) = New clpEstructuras.ePEODP
                wl_ePEODP = New clpEstructuras.ePEODP
                cpm_ePEODP_DT(wl_ePEODP,
                              wp_DT,
                              wl_nRow)
                vl_aePEODP(wl_nRow) = wl_ePEODP
            Next
            wp_aePEODP = vl_aePEODP
        Catch ex As Exception
            MsgBox("Error : cpm_aePEODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_ePEODP_DT(ByRef wp_aPEODP As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP As New clpEstructuras.ePEODP
            With wl_ePEODP
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), 0)
                .sEstOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(3)), wp_DT.Rows(wp_nRow).Item(3), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(4)), wp_DT.Rows(wp_nRow).Item(4), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(5)), wp_DT.Rows(wp_nRow).Item(5), "")
                .nCanOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(6)), wp_DT.Rows(wp_nRow).Item(6), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), "")
                .dFecEmi = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(8)), wp_DT.Rows(wp_nRow).Item(8), "")
                .dFecIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(9)), wp_DT.Rows(wp_nRow).Item(9), "")
                .dFecFin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(10), "")
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(11), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(12), "")
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(13), 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(14), 0)
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(15), "")
            End With
            wp_aPEODP = wl_ePEODP
        Catch ex As Exception
            MsgBox("Error : cpm_ePEODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aePEODP(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aePEODP As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP)
            Dim va_aePEODP(wl_nCntReg) As clpEstructuras.ePEODP
            va_aePEODP = wp_aePEODP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aePEODP(wl_nRow).nId
                    .Rows(wl_nRow).Cells(1).Value = va_aePEODP(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells(2).Value = va_aePEODP(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells(3).Value = va_aePEODP(wl_nRow).sEstOdp
                    .Rows(wl_nRow).Cells(4).Value = va_aePEODP(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells(5).Value = va_aePEODP(wl_nRow).sNomItm
                    .Rows(wl_nRow).Cells(6).Value = va_aePEODP(wl_nRow).nCanOdp
                    .Rows(wl_nRow).Cells(7).Value = va_aePEODP(wl_nRow).sCodAlm
                    .Rows(wl_nRow).Cells(8).Value = va_aePEODP(wl_nRow).dFecEmi
                    .Rows(wl_nRow).Cells(9).Value = va_aePEODP(wl_nRow).dFecIni
                    .Rows(wl_nRow).Cells(10).Value = va_aePEODP(wl_nRow).dFecFin
                    .Rows(wl_nRow).Cells(11).Value = va_aePEODP(wl_nRow).nSdoInv
                    .Rows(wl_nRow).Cells(12).Value = va_aePEODP(wl_nRow).sUniMedInv
                    .Rows(wl_nRow).Cells(13).Value = va_aePEODP(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells(14).Value = va_aePEODP(wl_nRow).nSdoAlm
                    .Rows(wl_nRow).Cells(15).Value = va_aePEODP(wl_nRow).sCtaInv
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aePEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_ePEODP_DGV(ByRef wp_ePEODP As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePEODP As New clpEstructuras.ePEODP
            With va_ePEODP
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
                .sEstOdp = wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value
                .nCanOdp = wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value
                .dFecEmi = wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value
                .dFecIni = wp_VlrCtrl.Rows(wp_nRow).Cells(9).Value
                .dFecFin = wp_VlrCtrl.Rows(wp_nRow).Cells(10).Value
            End With
            wp_ePEODP = va_ePEODP
        Catch ex As Exception
            MsgBox("Error : cpm_ePEODP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGVGLMOV1_ePEODP(ByRef wp_ePEODP As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try

            Dim wl_ePEODP As New clpEstructuras.ePEODP
            wl_ePEODP = wp_ePEODP
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(4).Value = wl_ePEODP.sCodDoc
                .Rows(wp_nRow).Cells(5).Value = wl_ePEODP.nNroDoc
                .Rows(wp_nRow).Cells(6).Value = wl_ePEODP.sCodItm
                .Rows(wp_nRow).Cells(7).Value = wl_ePEODP.sNomItm
                .Rows(wp_nRow).Cells(8).Value = wl_ePEODP.sCodAlm
                .Rows(wp_nRow).Cells(9).Value = wl_ePEODP.nCanOdp
                .Rows(wp_nRow).Cells(10).Value = wl_ePEODP.sUniMedInv
                .Rows(wp_nRow).Cells(11).Value = wl_ePEODP.nPreUni
                .Rows(wp_nRow).Cells(23).Value = wl_ePEODP.nSdoAlm
                .Rows(wp_nRow).Cells(24).Value = wl_ePEODP.sCtaInv
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DGVGLMOV1_ePEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PLEODP1"
    Public Sub cpm_aePLODP1_DT(ByRef wp_aePLODP1 As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLODP1 As New clpEstructuras.ePLODP1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLODP1(wl_nCntReg) As clpEstructuras.ePLODP1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLODP1(wl_nRow) = New clpEstructuras.ePLODP1
                wl_ePLODP1 = New clpEstructuras.ePLODP1
                cpm_ePLODP1_DT(wl_ePLODP1,
                              wp_DT,
                              wl_nRow)
                vl_aePLODP1(wl_nRow) = wl_ePLODP1
            Next
            wp_aePLODP1 = vl_aePLODP1
        Catch ex As Exception
            MsgBox("Error : cpm_aePLODP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_ePLODP1_DT(ByRef wp_aPLODP1 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLODP1 As New clpEstructuras.ePLODP1
            With wl_ePLODP1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(3)), wp_DT.Rows(wp_nRow).Item(3), "")
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(4)), wp_DT.Rows(wp_nRow).Item(4), "")
                .sNomCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(5)), wp_DT.Rows(wp_nRow).Item(5), "")
                .nCanCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(6)), wp_DT.Rows(wp_nRow).Item(6), 0)
                .nCanReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), 0)
                .nCanCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(8)), wp_DT.Rows(wp_nRow).Item(8), 0)
                .sCodAlmCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(9)), wp_DT.Rows(wp_nRow).Item(9), "")
                .sCodCmtAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(10)), wp_DT.Rows(wp_nRow).Item(10), "")
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(11)), wp_DT.Rows(wp_nRow).Item(11), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(12)), wp_DT.Rows(wp_nRow).Item(12), "")
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(13)), wp_DT.Rows(wp_nRow).Item(13), 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(14)), wp_DT.Rows(wp_nRow).Item(14), 0)
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(15)), wp_DT.Rows(wp_nRow).Item(15), "")
            End With
            wp_aPLODP1 = wl_ePLODP1
        Catch ex As Exception
            MsgBox("Error : cpm_ePLODP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aePLODP1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aePLODP1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP1)
            Dim va_aePLODP1(wl_nCntReg) As clpEstructuras.ePLODP1
            va_aePLODP1 = wp_aePLODP1
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aePLODP1(wl_nRow).nId
                    .Rows(wl_nRow).Cells(1).Value = va_aePLODP1(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells(2).Value = va_aePLODP1(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells(3).Value = va_aePLODP1(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells(4).Value = va_aePLODP1(wl_nRow).sCodCmt
                    .Rows(wl_nRow).Cells(5).Value = va_aePLODP1(wl_nRow).sNomCmt
                    .Rows(wl_nRow).Cells(6).Value = va_aePLODP1(wl_nRow).nCanCmt
                    .Rows(wl_nRow).Cells(7).Value = va_aePLODP1(wl_nRow).nCanReq
                    .Rows(wl_nRow).Cells(8).Value = va_aePLODP1(wl_nRow).nCanCns
                    .Rows(wl_nRow).Cells(9).Value = va_aePLODP1(wl_nRow).sCodAlmCns
                    .Rows(wl_nRow).Cells(10).Value = va_aePLODP1(wl_nRow).sCodCmtAlt
                    .Rows(wl_nRow).Cells(11).Value = va_aePLODP1(wl_nRow).nSdoInv
                    .Rows(wl_nRow).Cells(12).Value = va_aePLODP1(wl_nRow).sUniMedInv
                    .Rows(wl_nRow).Cells(13).Value = va_aePLODP1(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells(14).Value = va_aePLODP1(wl_nRow).nSdoAlm
                    .Rows(wl_nRow).Cells(15).Value = va_aePLODP1(wl_nRow).sCtaInv
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGVMov1_aePLODP1(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePLODP1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP1)
            Dim va_aePLODP1(wl_nCntReg) As clpEstructuras.ePLODP1
            va_aePLODP1 = wp_aePLODP1
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aePLODP1(wl_nRow).nId
                    .Rows(wl_nRow).Cells(4).Value = va_aePLODP1(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells(5).Value = va_aePLODP1(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells(6).Value = va_aePLODP1(wl_nRow).sCodCmt
                    .Rows(wl_nRow).Cells(7).Value = va_aePLODP1(wl_nRow).sNomCmt
                    .Rows(wl_nRow).Cells(8).Value = va_aePLODP1(wl_nRow).sCodAlmCns
                    .Rows(wl_nRow).Cells(9).Value = va_aePLODP1(wl_nRow).nCanCmt
                    .Rows(wl_nRow).Cells(10).Value = va_aePLODP1(wl_nRow).sUniMedInv
                    .Rows(wl_nRow).Cells(11).Value = va_aePLODP1(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells(23).Value = va_aePLODP1(wl_nRow).nSdoAlm
                    .Rows(wl_nRow).Cells(24).Value = va_aePLODP1(wl_nRow).sCtaInv
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_ePLODP1_DGV(ByRef wp_ePLODP1 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePLODP1 As New clpEstructuras.ePLODP1
            With va_ePLODP1
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells(3).Value
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells(4).Value
                .sNomCmt = wp_VlrCtrl.Rows(wp_nRow).Cells(5).Value
                .nCanCmt = wp_VlrCtrl.Rows(wp_nRow).Cells(6).Value
                .nCanReq = wp_VlrCtrl.Rows(wp_nRow).Cells(7).Value
                .nCanCns = wp_VlrCtrl.Rows(wp_nRow).Cells(8).Value
                .sCodAlmCns = wp_VlrCtrl.Rows(wp_nRow).Cells(9).Value
                .sCodCmtAlt = wp_VlrCtrl.Rows(wp_nRow).Cells(10).Value
                .nSdoInv = wp_VlrCtrl.Rows(wp_nRow).Cells(11).Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells(12).Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells(13).Value
                .nSdoAlm = wp_VlrCtrl.Rows(wp_nRow).Cells(14).Value
                .sCtaInv = wp_VlrCtrl.Rows(wp_nRow).Cells(15).Value
            End With
            wp_ePLODP1 = va_ePLODP1
        Catch ex As Exception
            MsgBox("Error : cpm_ePLODP1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGVGLMOV1_ePLODP1(ByRef wp_ePLODP1 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try

            Dim wl_ePLODP1 As New clpEstructuras.ePLODP1
            wl_ePLODP1 = wp_ePLODP1
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(4).Value = wl_ePLODP1.sCodDoc
                .Rows(wp_nRow).Cells(5).Value = wl_ePLODP1.nNroDoc
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DGVGLMOV1_ePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "TEDMT"
    Public Sub cpm_aeTEDMA_DT(ByRef wp_aeTEDMT As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eTEDMT As New clpEstructuras.eTEDMT
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeTEDMT(wl_nCntReg) As clpEstructuras.eTEDMT
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeTEDMT(wl_nRow) = New clpEstructuras.eTEDMT
                wl_eTEDMT = New clpEstructuras.eTEDMT
                cpm_eTEDMT_DT(wl_eTEDMT,
                              wp_DT,
                              wl_nRow)
                va_aeTEDMT(wl_nRow) = wl_eTEDMT
            Next
            wp_aeTEDMT = va_aeTEDMT
        Catch ex As Exception
            MsgBox("Error : cpm_aeTEDMA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eTEDMT_DT(ByRef wp_aTEDMT As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eTEDMT As New clpEstructuras.eTEDMT
            With wl_eTEDMT
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(0)), wp_DT.Rows(wp_nRow).Item(0), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(1)), wp_DT.Rows(wp_nRow).Item(1), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(2)), wp_DT.Rows(wp_nRow).Item(2), "")
            End With
            wp_aTEDMT = wl_eTEDMT
        Catch ex As Exception
            MsgBox("Error : cpm_eTEDMT_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGV_aeTEDMT(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeTEDMT As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeTEDMT)
            Dim va_aeTEDMT(wl_nCntReg) As clpEstructuras.eTEDMT
            va_aeTEDMT = wp_aeTEDMT
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells(0).Value = va_aeTEDMT(wl_nRow).nID
                    .Rows(wl_nRow).Cells(1).Value = va_aeTEDMT(wl_nRow).sCodTer
                    .Rows(wl_nRow).Cells(2).Value = va_aeTEDMT(wl_nRow).sNomTer
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : cpm_DGV_aeTEDMT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_eTEDMT_DGV(ByRef wp_eTEDMT As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eTEDMT As New clpEstructuras.eTEDMT
            With va_eTEDMT
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells(0).Value
                .sCodTer = wp_VlrCtrl.Rows(wp_nRow).Cells(1).Value
                .sNomTer = wp_VlrCtrl.Rows(wp_nRow).Cells(2).Value
               
            End With
            wp_eTEDMT = va_eTEDMT
        Catch ex As Exception
            MsgBox("Error : cpm_eTEDMT_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cpm_DGVGLMOV1_eTEDMT(ByRef wp_eTEDMT As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try

            Dim wl_eTEDMT As New clpEstructuras.eTEDMT
            wl_eTEDMT = wp_eTEDMT
            With wp_VlrCtrl
                ' .Rows(wp_nRow).Cells(8).Value = wl_eTEDMT.sCodTer
            End With
        Catch ex As Exception
            MsgBox("Error : cpm_DGVGLMOV1_eTEDMT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Module
