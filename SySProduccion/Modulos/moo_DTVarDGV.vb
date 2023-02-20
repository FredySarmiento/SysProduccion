
' moo - Módulo de asignaciones entre objetos: el obj de la derecha se asigna al de la izq.
Module moo_DTVarDGV
    Dim wl_bSwsColIni As Boolean
#Region "ABESD"
    Public Sub moo_aeABESD_DT(ByRef wp_aeABESD As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABESD As New moe_Estructuras.eABESD
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeABESD(wl_nCntReg) As moe_Estructuras.eABESD
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeABESD(wl_nRow) = New moe_Estructuras.eABESD
                wl_eABESD = New moe_Estructuras.eABESD
                moo_eABESD_DT(wl_eABESD,
                              wp_DT,
                              wl_nRow)
                va_aeABESD(wl_nRow) = wl_eABESD
            Next
            wp_aeABESD = va_aeABESD
        Catch ex As Exception
            MsgBox("Error : moo_aeABESD_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABESD_DT(ByRef wp_aABESD As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABESD As New moe_Estructuras.eABESD
            With wl_eABESD
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .sNomEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomEstDoc")), wp_DT.Rows(wp_nRow).Item("sNomEstDoc"), "")
            End With
            wp_aABESD = wl_eABESD
        Catch ex As Exception
            MsgBox("Error : moo_eABESD_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ABEOC"
    Public Sub moo_aeABEOC_DT(ByRef wp_aeABEOC As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABEOC As New moe_Estructuras.eABEOC
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeABEOC(wl_nCntReg) As moe_Estructuras.eABEOC
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeABEOC(wl_nRow) = New moe_Estructuras.eABEOC
                wl_eABEOC = New moe_Estructuras.eABEOC
                moo_eABEOC_DT(wl_eABEOC,
                              wp_DT,
                              wl_nRow)
                wl_aeABEOC(wl_nRow) = wl_eABEOC
            Next
            wp_aeABEOC = wl_aeABEOC
        Catch ex As Exception
            MsgBox("Error : moo_aeABEOC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABEOC_DGV(ByRef wp_eABEOC As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eABEOC As New moe_Estructuras.eABEOC
            With wl_eABEOC
                .nId = wp_VlrCtrl.Rows(wp_nId).Cells("nId").Value
                .sCodEstODC = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodEstODC").Value
                .sNomEstODC = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomEstODC").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
                .nNroOrd = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroOrd").Value
            End With
            wp_eABEOC = wl_eABEOC
        Catch ex As Exception
            MsgBox("Error : moo_eABEOC_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABEOC_DT(ByRef wp_aABEOC As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABEOC As New moe_Estructuras.eABEOC
            With wl_eABEOC
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodEstODC = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodEstODC")), wp_DT.Rows(wp_nRow).Item("sCodEstODC"), "")
                .sNomEstODC = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomEstODC")), wp_DT.Rows(wp_nRow).Item("sNomEstODC"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
                .nNroOrd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroOrd")), wp_DT.Rows(wp_nRow).Item("nNroOrd"), 0)
            End With
            wp_aABEOC = wl_eABEOC
        Catch ex As Exception
            MsgBox("Error : moo_eABEOC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeABEOC(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeABEOC As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeABEOC)
            Dim wl_aeABEOC(wl_nCntReg) As moe_Estructuras.eABEOC
            wl_aeABEOC = wp_aeABEOC
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eABEOC(wp_VlrCtrl,
                                   wl_aeABEOC(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeABEOC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eABEOC(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eABEOC As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eABEOC.nId
                .Rows(wp_nRow).Cells("sCodEstODC").Value = wp_eABEOC.sCodEstODC
                .Rows(wp_nRow).Cells("sNomEstODC").Value = wp_eABEOC.sNomEstODC
                .Rows(wp_nRow).Cells("bRegAci").Value = wp_eABEOC.bRegAci
                .Rows(wp_nRow).Cells("nNroOrd").Value = wp_eABEOC.nNroOrd
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eABEOC")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ABEOP"
    Public Sub moo_aeABEOP_DT(ByRef wp_aeABEOP As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABEOP As New moe_Estructuras.eABEOP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeABEOP(wl_nCntReg) As moe_Estructuras.eABEOP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeABEOP(wl_nRow) = New moe_Estructuras.eABEOP
                wl_eABEOP = New moe_Estructuras.eABEOP
                moo_eABEOP_DT(wl_eABEOP,
                              wp_DT,
                              wl_nRow)
                wl_aeABEOP(wl_nRow) = wl_eABEOP
            Next
            wp_aeABEOP = wl_aeABEOP
        Catch ex As Exception
            MsgBox("Error : moo_aeABEOP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABEOP_DGV(ByRef wp_eABEOP As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eABEOP As New moe_Estructuras.eABEOP
            With wl_eABEOP
                .nId = wp_VlrCtrl.Rows(wp_nId).Cells("nId").Value
                .sCodEstODP = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodEstODP").Value
                .sNomEstODP = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomEstODP").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
                .nNroOrd = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroOrd").Value
            End With
            wp_eABEOP = wl_eABEOP
        Catch ex As Exception
            MsgBox("Error : moo_eABEOP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABEOP_DT(ByRef wp_aABEOP As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABEOP As New moe_Estructuras.eABEOP
            With wl_eABEOP
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodEstODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodEstODP")), wp_DT.Rows(wp_nRow).Item("sCodEstODP"), "")
                .sNomEstODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomEstODP")), wp_DT.Rows(wp_nRow).Item("sNomEstODP"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
                .nNroOrd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroOrd")), wp_DT.Rows(wp_nRow).Item("nNroOrd"), 0)
            End With
            wp_aABEOP = wl_eABEOP
        Catch ex As Exception
            MsgBox("Error : moo_eABEOP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeABEOP(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeABEOP As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeABEOP)
            Dim wl_aeABEOP(wl_nCntReg) As moe_Estructuras.eABEOP
            wl_aeABEOP = wp_aeABEOP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eABEOP(wp_VlrCtrl,
                                   wl_aeABEOP(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeABEOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eABEOP(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eABEOP As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eABEOP.nId
                .Rows(wp_nRow).Cells("sCodEstODP").Value = wp_eABEOP.sCodEstODP
                .Rows(wp_nRow).Cells("sNomEstODP").Value = wp_eABEOP.sNomEstODP
                .Rows(wp_nRow).Cells("bRegAci").Value = wp_eABEOP.bRegAci
                .Rows(wp_nRow).Cells("nNroOrd").Value = wp_eABEOP.nNroOrd
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eABEOP")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ABEPC"
    Public Sub moo_aeABEPC_DT(ByRef wp_aeABEPC As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABEPC As New moe_Estructuras.eABEPC
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeABEPC(wl_nCntReg) As moe_Estructuras.eABEPC
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeABEPC(wl_nRow) = New moe_Estructuras.eABEPC
                wl_eABEPC = New moe_Estructuras.eABEPC
                moo_eABEPC_DT(wl_eABEPC,
                              wp_DT,
                              wl_nRow)
                wl_aeABEPC(wl_nRow) = wl_eABEPC
            Next
            wp_aeABEPC = wl_aeABEPC
        Catch ex As Exception
            MsgBox("Error : moo_aeABEPC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABEPC_DGV(ByRef wp_eABEPC As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eABEPC As New moe_Estructuras.eABEPC
            With wl_eABEPC
                .sCodEstPdoCbe = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodEstPdoCbe").Value
                .sDesEstPdoCbe = wp_VlrCtrl.Rows(wp_nRow).Cells("sDesEstPdoCbe").Value
            End With
            wp_eABEPC = wl_eABEPC
        Catch ex As Exception
            MsgBox("Error : moo_eABEPC_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABEPC_DT(ByRef wp_aABEPC As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABEPC As New moe_Estructuras.eABEPC
            With wl_eABEPC
                .sCodEstPdoCbe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodEstPdoCbe")), wp_DT.Rows(wp_nRow).Item("sCodEstPdoCbe"), "")
                .sDesEstPdoCbe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDesEstPdoCbe")), wp_DT.Rows(wp_nRow).Item("sDesEstPdoCbe"), "")
            End With
            wp_aABEPC = wl_eABEPC
        Catch ex As Exception
            MsgBox("Error : moo_eABEPC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeABEPC(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeABEPC As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeABEPC)
            Dim wl_aeABEPC(wl_nCntReg) As moe_Estructuras.eABEPC
            wl_aeABEPC = wp_aeABEPC
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eABEPC(wp_VlrCtrl,
                                   wl_aeABEPC(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeABEPC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eABEPC(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eABEPC As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodEstPdoCbe").Value = wp_eABEPC.sCodEstPdoCbe
                .Rows(wp_nRow).Cells("sDesEstPdoCbe").Value = wp_eABEPC.sDesEstPdoCbe

            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eABEPC")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ABODP"
    Public Sub moo_aeABODP_DT(ByRef wp_aeABODP As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABODP As New moe_Estructuras.eABODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeABODP(wl_nCntReg) As moe_Estructuras.eABODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeABODP(wl_nRow) = New moe_Estructuras.eABODP
                wl_eABODP = New moe_Estructuras.eABODP
                moo_eABODP_DT(wl_eABODP,
                              wp_DT,
                              wl_nRow)
                wl_aeABODP(wl_nRow) = wl_eABODP
            Next
            wp_aeABODP = wl_aeABODP
        Catch ex As Exception
            MsgBox("Error : moo_aeABODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABODP_DGV(ByRef wp_eABODP As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eABODP As New moe_Estructuras.eABODP
            With wl_eABODP
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .sDesDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sDesDoc").Value
                .bOdpSel = wp_VlrCtrl.Rows(wp_nRow).Cells("bOdpSel").Value
            End With
            wp_eABODP = wl_eABODP
        Catch ex As Exception
            MsgBox("Error : moo_eABODP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABODP_DT(ByRef wp_aABODP As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABODP As New moe_Estructuras.eABODP
            With wl_eABODP
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .sDesDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDesDoc")), wp_DT.Rows(wp_nRow).Item("sDesDoc"), "")
                .bOdpSel = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bOdpSel")), wp_DT.Rows(wp_nRow).Item("bOdpSel"), False)
            End With
            wp_aABODP = wl_eABODP
        Catch ex As Exception
            MsgBox("Error : moo_eABODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeABODP(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeABODP As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeABODP)
            Dim wl_aeABODP(wl_nCntReg) As moe_Estructuras.eABODP
            wl_aeABODP = wp_aeABODP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eABODP(wp_VlrCtrl,
                                   wl_aeABODP(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeABODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eABODP(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eABODP As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eABODP.sCodDoc
                .Rows(wp_nRow).Cells("sDesDoc").Value = wp_eABODP.sDesDoc
                .Rows(wp_nRow).Cells("bOdpSel").Value = wp_eABODP.bOdpSel
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eABODP")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ABTIR"
    Public Sub moo_aeABTIR_DT(ByRef wp_aeABTIR As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABTIR As New moe_Estructuras.eABTIR
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeABTIR(wl_nCntReg) As moe_Estructuras.eABTIR
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeABTIR(wl_nRow) = New moe_Estructuras.eABTIR
                wl_eABTIR = New moe_Estructuras.eABTIR
                moo_eABTIR_DT(wl_eABTIR,
                              wp_DT,
                              wl_nRow)
                wl_aeABTIR(wl_nRow) = wl_eABTIR
            Next
            wp_aeABTIR = wl_aeABTIR
        Catch ex As Exception
            MsgBox("Error : moo_aeABTIR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABTIR_DT(ByRef wp_aABTIR As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABTIR As New moe_Estructuras.eABTIR
            With wl_eABTIR
                .sTipRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipRev")), wp_DT.Rows(wp_nRow).Item("sTipRev"), "")
                .sNomTipRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTipRev")), wp_DT.Rows(wp_nRow).Item("sNomTipRev"), "")
            End With
            wp_aABTIR = wl_eABTIR
        Catch ex As Exception
            MsgBox("Error : moo_eABTIR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ACUNI"
    Public Sub moo_aeACUNI_DT(ByRef wp_aeACUNI As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eACUNI As New moe_Estructuras.eACUNI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeACUNI(wl_nCntReg) As moe_Estructuras.eACUNI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeACUNI(wl_nRow) = New moe_Estructuras.eACUNI
                wl_eACUNI = New moe_Estructuras.eACUNI
                moo_eACUNI_DT(wl_eACUNI,
                              wp_DT,
                              wl_nRow)
                wl_aeACUNI(wl_nRow) = wl_eACUNI
            Next
            wp_aeACUNI = wl_aeACUNI
        Catch ex As Exception
            MsgBox("Error : moo_aeACUNI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eACUNI_DT(ByRef wp_aACUNI As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eACUNI As New moe_Estructuras.eACUNI
            With wl_eACUNI
                .sCodUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUni")), wp_DT.Rows(wp_nRow).Item("sCodUni"), "")
                .sNomUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomUni")), wp_DT.Rows(wp_nRow).Item("sNomUni"), "")
                .sCodUniBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUniBas")), wp_DT.Rows(wp_nRow).Item("sCodUniBas"), "")
                .nUniBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUniBas")), wp_DT.Rows(wp_nRow).Item("nUniBas"), 0)
            End With
            wp_aACUNI = wl_eACUNI
        Catch ex As Exception
            MsgBox("Error : moo_eACUNI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeACUNI(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeACUNI As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeACUNI)
            Dim wl_aeACUNI(wl_nCntReg) As moe_Estructuras.eACUNI
            wl_aeACUNI = wp_aeACUNI
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eACUNI(wp_VlrCtrl,
                                   wl_aeACUNI(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeACUNI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eACUNI(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eACUNI As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodUni").Value = wp_eACUNI.sCodUni
                .Rows(wp_nRow).Cells("sNomUni").Value = wp_eACUNI.sNomUni
                .Rows(wp_nRow).Cells("sCodUniBas").Value = wp_eACUNI.sCodUniBas
                .Rows(wp_nRow).Cells("nUniBas").Value = wp_eACUNI.nUniBas
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eACUNI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eACUNI_DGV(ByRef wp_eACUNI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eACUNI As New moe_Estructuras.eACUNI
            With wl_eACUNI
                .sCodUni = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUni").Value
                .sNomUni = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomUni").Value
                .sCodUniBas = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUniBas").Value
                .nUniBas = wp_VlrCtrl.Rows(wp_nRow).Cells("nUniBas").Value
            End With
            wp_eACUNI = wl_eACUNI
        Catch ex As Exception
            MsgBox("Error : moo_eACUNI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ACBDE"
    Public Sub moo_eACBDE_DT(ByRef wp_eACBDE As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wp_nRow As Integer
            wp_nRow = 0
            Dim wl_eACBDE As New moe_Estructuras.eACBDE
            With wl_eACBDE
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCia")), wp_DT.Rows(wp_nRow).Item("sCodCia"), "")
                .bCiaSel = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bCiaSel")), wp_DT.Rows(wp_nRow).Item("bCiaSel"), False)
                .sNomBD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomBD")), wp_DT.Rows(wp_nRow).Item("sNomBD"), "")
            End With
            wp_eACBDE = wl_eACBDE
        Catch ex As Exception
            MsgBox("Error : moo_eACBDE_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ACDEM"
    Public Sub moo_eACDEM_DT(ByRef wp_eACDEM As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wp_nRow As Integer
            wp_nRow = 0
            Dim wl_eACDEM As New moe_Estructuras.eACDEM
            With wl_eACDEM
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sNomCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCia")), wp_DT.Rows(wp_nRow).Item("sNomCia"), "")
                .sDirCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDirCia")), wp_DT.Rows(wp_nRow).Item("sDirCia"), "")
                .sCiuCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCiuCia")), wp_DT.Rows(wp_nRow).Item("sCiuCia"), "")
                .sDepCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDepCia")), wp_DT.Rows(wp_nRow).Item("sDepCia"), "")
                .sPaiCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sPaiCia")), wp_DT.Rows(wp_nRow).Item("sPaiCia"), "")
                .sRepLeg = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sRepLeg")), wp_DT.Rows(wp_nRow).Item("sRepLeg"), "")
                .sEmlCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEmlCia")), wp_DT.Rows(wp_nRow).Item("sEmlCia"), "")
                .sTel1Cia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel1Cia")), wp_DT.Rows(wp_nRow).Item("sTel1Cia"), "")
                .sTel2Cia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel2Cia")), wp_DT.Rows(wp_nRow).Item("sTel2Cia"), "")
                .sFaxCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sFaxCia")), wp_DT.Rows(wp_nRow).Item("sFaxCia"), "")
                .sNitCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitCia")), wp_DT.Rows(wp_nRow).Item("sNitCia"), "")
                .sDigVer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDigVer")), wp_DT.Rows(wp_nRow).Item("sDigVer"), "")
                .nAnoSdoIniInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nAnoSdoIniInv")), wp_DT.Rows(wp_nRow).Item("nAnoSdoIniInv"), 0)
                .bInvPte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bInvPte")), wp_DT.Rows(wp_nRow).Item("bInvPte"), False)
                .sTipInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipInv")), wp_DT.Rows(wp_nRow).Item("sTipInv"), "")
                .bCosXBod = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bCosXBod")), wp_DT.Rows(wp_nRow).Item("bCosXBod"), False)
                .bMovSinCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bMovSinCos")), wp_DT.Rows(wp_nRow).Item("bMovSinCos"), False)
                .sCodCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCia")), wp_DT.Rows(wp_nRow).Item("sCodCia"), "")
            End With
            wp_eACDEM = wl_eACDEM
        Catch ex As Exception
            MsgBox("Error : moo_eACDEM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ABOPC"
    Public Sub moo_aeABOPC_DT(ByRef wp_aeABOPC As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eABOPC As New moe_Estructuras.eABOPC
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeABOPC(wl_nCntReg) As moe_Estructuras.eABOPC
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeABOPC(wl_nRow) = New moe_Estructuras.eABOPC
                wl_eABOPC = New moe_Estructuras.eABOPC
                moo_eABOPC_DT(wl_eABOPC,
                              wp_DT,
                              wl_nRow)
                wl_aeABOPC(wl_nRow) = wl_eABOPC
            Next
            wp_aeABOPC = wl_aeABOPC
        Catch ex As Exception
            MsgBox("Error : moo_aeABOPC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eABOPC_DT(ByRef wp_aABOPC As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eABOPC As New moe_Estructuras.eABOPC
            With wl_eABOPC
                .sCodOpc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodOpc")), wp_DT.Rows(wp_nRow).Item("sCodOpc"), "")
                .sNomOpc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpc")), wp_DT.Rows(wp_nRow).Item("sNomOpc"), "")
                .sCodFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodFrm")), wp_DT.Rows(wp_nRow).Item("sCodFrm"), "")
            End With
            wp_aABOPC = wl_eABOPC
        Catch ex As Exception
            MsgBox("Error : moo_eABOPC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ACPAG"
    Public Sub moo_eACPAG_DT(ByRef wp_eACPAG As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wp_nRow As Integer
            wp_nRow = 0
            Dim wl_eACPAG As New moe_Estructuras.eACPAG
            With wl_eACPAG
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodCia = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCia")), wp_DT.Rows(wp_nRow).Item("sCodCia"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .bLmtCre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bLmtCre")), wp_DT.Rows(wp_nRow).Item("bLmtCre"), False)
                .sCndPagxDefCli = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCndPagxDefCli")), wp_DT.Rows(wp_nRow).Item("sCndPagxDefCli"), "")
                .sMetPagxDefCli = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMetPagxDefCli")), wp_DT.Rows(wp_nRow).Item("sMetPagxDefCli"), "")
                .sCndPagxDefPro = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCndPagxDefPro")), wp_DT.Rows(wp_nRow).Item("sCndPagxDefPro"), "")
                .sMetPagxDefPro = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMetPagxDefPro")), wp_DT.Rows(wp_nRow).Item("sMetPagxDefPro"), "")
                .sClrFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClrFrm")), wp_DT.Rows(wp_nRow).Item("sClrFrm"), "")
                .sTipFont = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipFont")), wp_DT.Rows(wp_nRow).Item("sTipFont"), "")
                .nTamFont = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTamFont")), wp_DT.Rows(wp_nRow).Item("nTamFont"), 0)

                .sForFec = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sForFec")), wp_DT.Rows(wp_nRow).Item("sForFec"), "")
                .sForHor = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sForHor")), wp_DT.Rows(wp_nRow).Item("sForHor"), "")
                .nNroDecPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDecPre")), wp_DT.Rows(wp_nRow).Item("nNroDecPre"), 0)
                .nNroDecCan = (IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDecCan")), wp_DT.Rows(wp_nRow).Item("nNroDecCan"), 0))
                .nNroDecPor = (IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDecPor")), wp_DT.Rows(wp_nRow).Item("nNroDecPor"), 0))
                .sCodAlmCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCom")), wp_DT.Rows(wp_nRow).Item("sCodAlmCom"), "")
                .sCodAlmXDef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmXDef")), wp_DT.Rows(wp_nRow).Item("sCodAlmXDef"), "")
                .sCrictaCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCriCtaCtb")), wp_DT.Rows(wp_nRow).Item("sCriCtaCtb"), "")
                .bVisItmIna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bVisItmIna")), wp_DT.Rows(wp_nRow).Item("bVisItmIna"), False)
                .sRutXls = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sRutXls")), wp_DT.Rows(wp_nRow).Item("sRutXls"), "")
                .sTipRegTie = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipRegTie")), wp_DT.Rows(wp_nRow).Item("sTipRegTie"), "")
                .bPrnODPPla = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrnODPPla")), wp_DT.Rows(wp_nRow).Item("bPrnODPPla"), False)
                .nPorGto = (IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorGto")), wp_DT.Rows(wp_nRow).Item("nPorGto"), 0))
                .nPorIto = (IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIto")), wp_DT.Rows(wp_nRow).Item("nPorIto"), 0))
            End With
            wp_eACPAG = wl_eACPAG
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eACPAG_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "APFRM"
    Public Sub moo_aeAPFRM_DT(ByRef wp_aeAPFRM As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPFRM As New moe_Estructuras.eAPFRM
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeAPFRM(wl_nCntReg) As moe_Estructuras.eAPFRM
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPFRM(wl_nRow) = New moe_Estructuras.eAPFRM
                wl_eAPFRM = New moe_Estructuras.eAPFRM
                moo_eAPFRM_DT(wl_eAPFRM,
                              wp_DT,
                              wl_nRow)
                wl_aeAPFRM(wl_nRow) = wl_eAPFRM
            Next
            wp_aeAPFRM = wl_aeAPFRM
        Catch ex As Exception
            MsgBox("Error :  moo_aeAPFRM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPFRM_DGV(ByRef wp_eAPFRM As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eAPFRM As New moe_Estructuras.eAPFRM
            With wl_eAPFRM
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodFrm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodFrm").Value
                .sNomFrm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomFrm").Value
                
            End With
            wp_eAPFRM = wl_eAPFRM
        Catch ex As Exception
            MsgBox("Error : moo_eAPFRM_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPFRM_DT(ByRef wp_eAPFRM As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Long)
        Try
            Dim wl_eAPFRM As New moe_Estructuras.eAPFRM
            With wl_eAPFRM
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodFrm")), wp_DT.Rows(wp_nRow).Item("sCodFrm"), "")
                .sNomFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomFrm")), wp_DT.Rows(wp_nRow).Item("sNomFrm"), "")
            End With
            wp_eAPFRM = wl_eAPFRM
        Catch ex As Exception
            MsgBox("Error : moo_eAPFRM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeAPFRM(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeAPFRM As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeAPFRM)
            Dim wl_aeAPFRM(wl_nCntReg) As moe_Estructuras.eAPFRM
            wl_aeAPFRM = wp_aeAPFRM

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eAPFRM(wp_VlrCtrl,
                                   wl_aeAPFRM(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeAPFRM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eAPFRM(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eAPFRM As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eAPFRM.nId
                .Rows(wp_nRow).Cells("sCodFrm").Value = wp_eAPFRM.sCodFrm
                .Rows(wp_nRow).Cells("sNomFrm").Value = wp_eAPFRM.sNomFrm
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eAPFRM")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "APGQLst"
    Public Sub moo_aeAPGQLst_DT(ByRef wp_aeAPGQLst As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPGQLst As New moe_Estructuras.eAPGQLst
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeAPGQLst(wl_nCntReg) As moe_Estructuras.eAPGQLst
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPGQLst(wl_nRow) = New moe_Estructuras.eAPGQLst
                wl_eAPGQLst = New moe_Estructuras.eAPGQLst
                moo_eAPGQLst_DT(wl_eAPGQLst,
                              wp_DT,
                              wl_nRow)
                wl_aeAPGQLst(wl_nRow) = wl_eAPGQLst
            Next
            wp_aeAPGQLst = wl_aeAPGQLst
        Catch ex As Exception
            MsgBox("Error :  moo_aeAPGQLst_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPGQLst_DGV(ByRef wp_eAPGQLst As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eAPGQLst As New moe_Estructuras.eAPGQLst
            With wl_eAPGQLst
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodStr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodStr").Value
                .sNomStr = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomStr").Value

            End With
            wp_eAPGQLst = wl_eAPGQLst
        Catch ex As Exception
            MsgBox("Error : moo_eAPGQLst_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPGQLst_DT(ByRef wp_eAPGQLst As Object,
                               ByVal wp_DT As DataTable,
                               ByVal wp_nRow As Long)
        Try
            Dim wl_eAPGQLst As New moe_Estructuras.eAPGQLst
            With wl_eAPGQLst
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodStr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodStr")), wp_DT.Rows(wp_nRow).Item("sCodStr"), "")
                .sNomStr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomStr")), wp_DT.Rows(wp_nRow).Item("sNomStr"), "")
            End With
            wp_eAPGQLst = wl_eAPGQLst
        Catch ex As Exception
            MsgBox("Error : moo_eAPGQLst_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeAPGQLst(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeAPGQLst As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeAPGQLst)
            Dim wl_aeAPGQLst(wl_nCntReg) As moe_Estructuras.eAPGQLst
            wl_aeAPGQLst = wp_aeAPGQLst

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eAPGQLst(wp_VlrCtrl,
                                    wl_aeAPGQLst(wl_nRow),
                                    wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeAPGQLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eAPGQLst(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_eAPGQLst As Object,
                                ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eAPGQLst.nId
                .Rows(wp_nRow).Cells("sCodStr").Value = wp_eAPGQLst.sCodStr
                .Rows(wp_nRow).Cells("sNomStr").Value = wp_eAPGQLst.sNomStr
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eAPGQLst")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "APDGV"
    Public Sub moo_aeAPDGV_DT(ByRef wp_aeAPDGV As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
            wl_nCntReg = wp_DT.Rows.Count - 1
            wl_bSwsColIni = False
            Dim wl_aeAPDGV(wl_nCntReg) As moe_Estructuras.eAPDGV
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPDGV(wl_nRow) = New moe_Estructuras.eAPDGV
                wl_eAPDGV = New moe_Estructuras.eAPDGV
                moo_eAPDGV_DT(wl_eAPDGV,
                              wp_DT,
                              wl_nRow)
                wl_aeAPDGV(wl_nRow) = wl_eAPDGV
            Next
            wp_aeAPDGV = wl_aeAPDGV
        Catch ex As Exception
            MsgBox("Error : moo_aeAPDGV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPDGV_DGV(ByRef wp_eAPDGV As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wp_nRow As Long)
        Try
            Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
            With wl_eAPDGV
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodFrm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodFrm").Value
                .sCodDgv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDgv").Value
                .nColOri = wp_VlrCtrl.Rows(wp_nRow).Cells("nColOri").Value
                .nNroCol = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroCol").Value
                .sTitCol = wp_VlrCtrl.Rows(wp_nRow).Cells("sTitCol").Value
                .sTipCol = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipCol").Value
                .bColxDef = wp_VlrCtrl.Rows(wp_nRow).Cells("bColxDef").Value
                .bVisible = wp_VlrCtrl.Rows(wp_nRow).Cells("bVisible").Value
                .bReadOnly = wp_VlrCtrl.Rows(wp_nRow).Cells("bReadOnly").Value
                .sNomCmp = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCmp").Value
                .nTamCmp = wp_VlrCtrl.Rows(wp_nRow).Cells("nTamCmp").Value
            End With
            wp_eAPDGV = wl_eAPDGV
        Catch ex As Exception
            MsgBox("Error : moo_eAPDGV_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPDGV_DT(ByRef wp_aAPDGV As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
            With wl_eAPDGV
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodFrm")), wp_DT.Rows(wp_nRow).Item("sCodFrm"), "")
                .sCodDgv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDgv")), wp_DT.Rows(wp_nRow).Item("sCodDgv"), "")
                .nColOri = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nColOri")), wp_DT.Rows(wp_nRow).Item("nColOri"), 0)
                .nNroCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCol")), wp_DT.Rows(wp_nRow).Item("nNroCol"), 0)
                .sTitCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTitCol")), wp_DT.Rows(wp_nRow).Item("sTitCol"), "")
                .sTipCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCol")), wp_DT.Rows(wp_nRow).Item("sTipCol"), "")
                .bColxDef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bColxDef")), wp_DT.Rows(wp_nRow).Item("bColxDef"), False)
                .bVisible = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bVisible")), wp_DT.Rows(wp_nRow).Item("bVisible"), False)
                .bReadOnly = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bReadOnly")), wp_DT.Rows(wp_nRow).Item("bReadOnly"), False)
                .sNomCmp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCmp")), wp_DT.Rows(wp_nRow).Item("sNomCmp"), "")
                .nTamCmp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTamCmp")), wp_DT.Rows(wp_nRow).Item("nTamCmp"), 0)
                If .bVisible Then
                    If wl_bSwsColIni = False Then
                        wg_nColIni = wp_nRow
                        wl_bSwsColIni = True
                    End If
                End If
                If .bVisible Then
                    wg_nColFin = wp_nRow
                End If
            End With
            wp_aAPDGV = wl_eAPDGV
        Catch ex As Exception
            MsgBox("Error : moo_eAPDGV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeAPDGV(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeAPDGV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeAPDGV)
            Dim wl_aeAPDGV(wl_nCntReg) As moe_Estructuras.eAPDGV
            wl_aeAPDGV = wp_aeAPDGV

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eAPDGV(wp_VlrCtrl,
                                   wl_aeAPDGV(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeAPDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eAPDGV(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eAPDGV As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eAPDGV.nId
                .Rows(wp_nRow).Cells("sCodFrm").Value = wp_eAPDGV.sCodFrm
                .Rows(wp_nRow).Cells("sCodDgv").Value = wp_eAPDGV.sCodDgv
                .Rows(wp_nRow).Cells("nColOri").Value = wp_eAPDGV.nColOri
                .Rows(wp_nRow).Cells("nNroCol").Value = wp_eAPDGV.nNroCol
                .Rows(wp_nRow).Cells("sTitCol").Value = wp_eAPDGV.sTitCol
                .Rows(wp_nRow).Cells("sTipCol").Value = wp_eAPDGV.sTipCol
                .Rows(wp_nRow).Cells("bColxDef").Value = wp_eAPDGV.bColxDef
                .Rows(wp_nRow).Cells("bVisible").Value = wp_eAPDGV.bVisible
                .Rows(wp_nRow).Cells("bReadOnly").Value = wp_eAPDGV.bReadOnly
                .Rows(wp_nRow).Cells("sNomCmp").Value = wp_eAPDGV.sNomCmp
                .Rows(wp_nRow).Cells("nTamCmp").Value = wp_eAPDGV.nTamCmp
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eAPDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "APQDG"
    Public Sub moo_aeAPQDG_DT(ByRef wp_aeAPQDG As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
            wl_nCntReg = wp_DT.Rows.Count - 1
            wl_bSwsColIni = False
            Dim wl_aeAPQDG(wl_nCntReg) As moe_Estructuras.eAPQDG
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPQDG(wl_nRow) = New moe_Estructuras.eAPQDG
                wl_eAPQDG = New moe_Estructuras.eAPQDG
                moo_eAPQDG_DT(wl_eAPQDG,
                              wp_DT,
                              wl_nRow)
                wl_aeAPQDG(wl_nRow) = wl_eAPQDG
            Next
            wp_aeAPQDG = wl_aeAPQDG
        Catch ex As Exception
            MsgBox("Error : moo_aeAPQDG_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPQDG_DGV(ByRef wp_eAPQDG As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wp_nRow As Long)
        Try
            Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
            With wl_eAPQDG
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodStr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodStr").Value
                .nColOri = wp_VlrCtrl.Rows(wp_nRow).Cells("nColOri").Value
                .nNroCol = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroCol").Value
                .sTitCol = wp_VlrCtrl.Rows(wp_nRow).Cells("sTitCol").Value
                .sTipCol = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipCol").Value
                .bColxDef = wp_VlrCtrl.Rows(wp_nRow).Cells("bColxDef").Value
                .bVisible = wp_VlrCtrl.Rows(wp_nRow).Cells("bVisible").Value
                .bReadOnly = wp_VlrCtrl.Rows(wp_nRow).Cells("bReadOnly").Value
                .sNomCmp = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCmp").Value
                .nTamCmp = wp_VlrCtrl.Rows(wp_nRow).Cells("nTamCmp").Value
            End With
            wp_eAPQDG = wl_eAPQDG
        Catch ex As Exception
            MsgBox("Error : moo_eAPQGV_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPQDG_DT(ByRef wp_aAPQDG As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
            With wl_eAPQDG
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodStr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodStr")), wp_DT.Rows(wp_nRow).Item("sCodStr"), "")
                .nColOri = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nColOri")), wp_DT.Rows(wp_nRow).Item("nColOri"), 0)
                .nNroCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCol")), wp_DT.Rows(wp_nRow).Item("nNroCol"), 0)
                .sTitCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTitCol")), wp_DT.Rows(wp_nRow).Item("sTitCol"), "")
                .sTipCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCol")), wp_DT.Rows(wp_nRow).Item("sTipCol"), "")
                .bColxDef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bColxDef")), wp_DT.Rows(wp_nRow).Item("bColxDef"), False)
                .bVisible = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bVisible")), wp_DT.Rows(wp_nRow).Item("bVisible"), False)
                .bReadOnly = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bReadOnly")), wp_DT.Rows(wp_nRow).Item("bReadOnly"), False)
                .sNomCmp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCmp")), wp_DT.Rows(wp_nRow).Item("sNomCmp"), "")
                .nTamCmp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTamCmp")), wp_DT.Rows(wp_nRow).Item("nTamCmp"), 0)
                If .bVisible Then
                    If wl_bSwsColIni = False Then
                        wg_nColIni = wp_nRow
                        wl_bSwsColIni = True
                    End If
                End If
                If .bVisible Then
                    wg_nColFin = wp_nRow
                End If
            End With
            wp_aAPQDG = wl_eAPQDG
        Catch ex As Exception
            MsgBox("Error : moo_eAPQDG_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeAPQDG(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aeAPQDG As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeAPQDG)
            Dim wl_aeAPQDG(wl_nCntReg) As moe_Estructuras.eAPQDG
            wl_aeAPQDG = wp_aeAPQDG

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eAPQDG(wp_VlrCtrl,
                                   wl_aeAPQDG(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeAPQDG")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eAPQDG(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eAPQDG As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eAPQDG.nId
                .Rows(wp_nRow).Cells("sCodStr").Value = wp_eAPQDG.sCodStr
                .Rows(wp_nRow).Cells("nColOri").Value = wp_eAPQDG.nColOri
                .Rows(wp_nRow).Cells("nNroCol").Value = wp_eAPQDG.nNroCol
                .Rows(wp_nRow).Cells("sTitCol").Value = wp_eAPQDG.sTitCol
                .Rows(wp_nRow).Cells("sTipCol").Value = wp_eAPQDG.sTipCol
                .Rows(wp_nRow).Cells("bColxDef").Value = wp_eAPQDG.bColxDef
                .Rows(wp_nRow).Cells("bVisible").Value = wp_eAPQDG.bVisible
                .Rows(wp_nRow).Cells("bReadOnly").Value = wp_eAPQDG.bReadOnly
                .Rows(wp_nRow).Cells("sNomCmp").Value = wp_eAPQDG.sNomCmp
                .Rows(wp_nRow).Cells("nTamCmp").Value = wp_eAPQDG.nTamCmp
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eAPQDG")
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region
#Region "APRGV"
    Public Sub moo_aeAPRDG_DT(ByRef wp_aeAPRDG As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPRDG As New moe_Estructuras.eAPRDG
            wl_nCntReg = wp_DT.Rows.Count - 1
            wl_bSwsColIni = False
            Dim wl_aeAPRDG(wl_nCntReg) As moe_Estructuras.eAPRDG
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPRDG(wl_nRow) = New moe_Estructuras.eAPRDG
                wl_eAPRDG = New moe_Estructuras.eAPRDG
                moo_eAPRDG_DT(wl_eAPRDG,
                              wp_DT,
                              wl_nRow)
                wl_aeAPRDG(wl_nRow) = wl_eAPRDG
            Next
            wp_aeAPRDG = wl_aeAPRDG
        Catch ex As Exception
            MsgBox("Error : moo_aeAPRDG_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPRDG_DT(ByRef wp_aAPRGV As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eAPRDG As New moe_Estructuras.eAPRDG
            With wl_eAPRDG
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodRpt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodRpt")), wp_DT.Rows(wp_nRow).Item("sCodRpt"), "")
                .nColOri = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nColOri")), wp_DT.Rows(wp_nRow).Item("nColOri"), 0)
                .nNroCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCol")), wp_DT.Rows(wp_nRow).Item("nNroCol"), 0)
                .sTitCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTitCol")), wp_DT.Rows(wp_nRow).Item("sTitCol"), "")
                .sTipCol = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCol")), wp_DT.Rows(wp_nRow).Item("sTipCol"), "")
                .bVisible = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bVisible")), wp_DT.Rows(wp_nRow).Item("bVisible"), False)
                .sNomCmp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCmp")), wp_DT.Rows(wp_nRow).Item("sNomCmp"), "")
                .nTamCmp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTamCmp")), wp_DT.Rows(wp_nRow).Item("nTamCmp"), 0)
                If .bVisible Then
                    If wl_bSwsColIni = False Then
                        wg_nColIni = wp_nRow
                        wl_bSwsColIni = True
                    End If
                End If
                If .bVisible Then
                    wg_nColFin = wp_nRow
                End If
            End With
            wp_aAPRGV = wl_eAPRDG
        Catch ex As Exception
            MsgBox("Error : moo_eAPRDG_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "APEND"
    Public Sub moo_aeAPEND_DT(ByRef wp_aeAPEND As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPEND As New moe_Estructuras.eAPEND
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeAPEND(wl_nCntReg) As moe_Estructuras.eAPEND
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPEND(wl_nRow) = New moe_Estructuras.eAPEND
                wl_eAPEND = New moe_Estructuras.eAPEND
                moo_eAPEND_DT(wl_eAPEND,
                              wp_DT,
                              wl_nRow)
                wl_aeAPEND(wl_nRow) = wl_eAPEND
            Next
            wp_aeAPEND = wl_aeAPEND
        Catch ex As Exception
            MsgBox("Error :  moo_aeAPEND_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPEND_DGV(ByRef wp_eAPEND As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eAPEND As New moe_Estructuras.eAPEND
            With wl_eAPEND
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sNomDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomDoc").Value
                .sTipMov = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipMov").Value
                .nNroIni = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroIni").Value
                .nNroSig = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroSig").Value
                .nNroFin = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroFin").Value
                .sClsDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sClsDoc").Value
                .sCodTra = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTra").Value
            End With
            wp_eAPEND = wl_eAPEND


        Catch ex As Exception
            MsgBox("Error : moo_eAPEND_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPEND_DT(ByRef wp_eAPEND As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            Dim wl_eAPEND As New moe_Estructuras.eAPEND
            With wl_eAPEND
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nId")), wp_DT.Rows(wl_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodDoc")), wp_DT.Rows(wl_nRow).Item("sCodDoc"), "")
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodSer")), wp_DT.Rows(wl_nRow).Item("sCodSer"), "")
                .sNomDoc = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sNomDoc")), wp_DT.Rows(wl_nRow).Item("sNomDoc"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sTipMov")), wp_DT.Rows(wl_nRow).Item("sTipMov"), "")
                .nNroIni = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nNroIni")), wp_DT.Rows(wl_nRow).Item("nNroIni"), 0)
                .nNroSig = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nNroSig")), wp_DT.Rows(wl_nRow).Item("nNroSig"), 0)
                .nNroFin = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nNroFin")), wp_DT.Rows(wl_nRow).Item("nNroFin"), 0)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sClsDoc")), wp_DT.Rows(wl_nRow).Item("sClsDoc"), "")
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodTra")), wp_DT.Rows(wl_nRow).Item("sCodTra"), "")
            End With
            wp_eAPEND = wl_eAPEND
        Catch ex As Exception
            MsgBox("Error : moo_eAPEND_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeAPEND(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeAPEND As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeAPEND)
            Dim wl_aeAPEND(wl_nCntReg) As moe_Estructuras.eAPEND
            wl_aeAPEND = wp_aeAPEND

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eAPEND(wp_VlrCtrl,
                                   wl_aeAPEND(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeAPEND")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eAPEND(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eAPEND As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eAPEND.nId
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eAPEND.sCodDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eAPEND.sCodSer
                .Rows(wp_nRow).Cells("sNomDoc").Value = wp_eAPEND.sNomDoc
                .Rows(wp_nRow).Cells("sTipMov").Value = wp_eAPEND.sTipMov
                .Rows(wp_nRow).Cells("nNroIni").Value = wp_eAPEND.nNroIni
                .Rows(wp_nRow).Cells("nNroSig").Value = wp_eAPEND.nNroSig
                .Rows(wp_nRow).Cells("nNroFin").Value = wp_eAPEND.nNroFin
                .Rows(wp_nRow).Cells("sClsDoc").Value = wp_eAPEND.sClsDoc
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eAPEND.sCodTra
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eAPEND")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "APLND1"
    Public Sub moo_aeAPLND1_DT(ByRef wp_aeAPLND1 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeAPLND1(wl_nCntReg) As moe_Estructuras.eAPLND1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeAPLND1(wl_nRow) = New moe_Estructuras.eAPLND1
                wl_eAPLND1 = New moe_Estructuras.eAPLND1
                moo_eAPLND1_DT(wl_eAPLND1,
                              wp_DT,
                              wl_nRow)
                wl_aeAPLND1(wl_nRow) = wl_eAPLND1
            Next
            wp_aeAPLND1 = wl_aeAPLND1
        Catch ex As Exception
            MsgBox("Error :  moo_aeAPLND1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPLND1_DGV(ByRef wp_eAPLND1 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
            With wl_eAPLND1
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .nNroIni = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroIni").Value
                .nNroSig = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroSig").Value
                .nNroFin = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroFin").Value
                .sCodTra = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTra").Value
            End With
            wp_eAPLND1 = wl_eAPLND1
        Catch ex As Exception
            MsgBox("Error : moo_eAPLND1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eAPLND1_DT(ByRef wp_eAPLND1 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Long)
        Try
            Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
            With wl_eAPLND1
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .nNroIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroIni")), wp_DT.Rows(wp_nRow).Item("nNroIni"), 0)
                .nNroSig = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroSig")), wp_DT.Rows(wp_nRow).Item("nNroSig"), 0)
                .nNroFin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroFin")), wp_DT.Rows(wp_nRow).Item("nNroFin"), 0)
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
            End With
            wp_eAPLND1 = wl_eAPLND1
        Catch ex As Exception
            MsgBox("Error : moo_eAPLND1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeAPLND1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeAPLND1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeAPLND1)
            Dim wl_aeAPLND1(wl_nCntReg) As moe_Estructuras.eAPLND1
            wl_aeAPLND1 = wp_aeAPLND1

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eAPLND1(wp_VlrCtrl,
                                   wl_aeAPLND1(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeAPLND1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eAPLND1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eAPLND1 As Object,
                               ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eAPLND1.nId
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eAPLND1.sCodDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eAPLND1.sCodSer
                .Rows(wp_nRow).Cells("nNroIni").Value = wp_eAPLND1.nNroIni
                .Rows(wp_nRow).Cells("nNroSig").Value = wp_eAPLND1.nNroSig
                .Rows(wp_nRow).Cells("nNroFin").Value = wp_eAPLND1.nNroFin
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eAPLND1.sCodTra
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eAPLND1")
            MsgBox(ex.Message)
        End Try
    End Sub



#End Region

#Region "ATALM"
    Public Sub moo_aeATALM_DT(ByRef wp_aeATALM As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATALM As New moe_Estructuras.eATALM
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATALM(wl_nCntReg) As moe_Estructuras.eATALM
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATALM(wl_nRow) = New moe_Estructuras.eATALM
                wl_eATALM = New moe_Estructuras.eATALM
                moo_eATALM_DT(wl_eATALM,
                              wp_DT,
                              wl_nRow)
                va_aeATALM(wl_nRow) = wl_eATALM
            Next
            wp_aeATALM = va_aeATALM
        Catch ex As Exception
            MsgBox("Error :  moo_aeATALM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATALM_DT(ByRef wp_aATALM As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATALM As New moe_Estructuras.eATALM
            With wl_eATALM
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .sNomAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlm")), wp_DT.Rows(wp_nRow).Item("sNomAlm"), "")
                .sUbiAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUbiAlm")), wp_DT.Rows(wp_nRow).Item("sUbiAlm"), "")
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaInv")), wp_DT.Rows(wp_nRow).Item("sCtaInv"), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .sCtaTrs = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaTrs")), wp_DT.Rows(wp_nRow).Item("sCtaTrs"), "")
                .sCtaIng = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaIng")), wp_DT.Rows(wp_nRow).Item("sCtaIng"), "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDevVta")), wp_DT.Rows(wp_nRow).Item("sCtaDevVta"), "")
                .sCtaVrc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaVrc")), wp_DT.Rows(wp_nRow).Item("sCtaVrc"), "")
                .sCtaGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaGto")), wp_DT.Rows(wp_nRow).Item("sCtaGto"), "")
                .sCtaDot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDot")), wp_DT.Rows(wp_nRow).Item("sCtaDot"), "") '10
                .sCtaDifPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDifPre")), wp_DT.Rows(wp_nRow).Item("sCtaDifPre"), "")
                .sCtaRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRev")), wp_DT.Rows(wp_nRow).Item("sCtaRev"), "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaAumInv")), wp_DT.Rows(wp_nRow).Item("sCtaAumInv"), "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRedInv")), wp_DT.Rows(wp_nRow).Item("sCtaRedInv"), "")
                .sCtaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCom")), wp_DT.Rows(wp_nRow).Item("sCtaCom"), "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDevCom")), wp_DT.Rows(wp_nRow).Item("sCtaDevCom"), "")
                .sCtaWIP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaWIP")), wp_DT.Rows(wp_nRow).Item("sCtaWIP"), "")
                .bSelxDef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bSelxDef")), wp_DT.Rows(wp_nRow).Item("bSelxDef"), False)
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)

            End With
            wp_aATALM = wl_eATALM
        Catch ex As Exception
            MsgBox("Error : moo_eATALM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATALM(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATALM As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATALM)
            Dim va_aeATALM(wl_nCntReg) As moe_Estructuras.eATALM
            va_aeATALM = wp_aeATALM
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aeATALM(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodAlm").Value = va_aeATALM(wl_nRow).sCodAlm
                    .Rows(wl_nRow).Cells("sNomAlm").Value = va_aeATALM(wl_nRow).sNomAlm
                    .Rows(wl_nRow).Cells("sUbiAlm").Value = va_aeATALM(wl_nRow).sUbiAlm
                    .Rows(wl_nRow).Cells("sCtaInv").Value = va_aeATALM(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells("sCtaCosVta").Value = va_aeATALM(wl_nRow).sCtaCosVta
                    .Rows(wl_nRow).Cells("sCtaTrs").Value = va_aeATALM(wl_nRow).sCtaTrs
                    .Rows(wl_nRow).Cells("sCtaIng").Value = va_aeATALM(wl_nRow).sCtaIng
                    .Rows(wl_nRow).Cells("sCtaDevVta").Value = va_aeATALM(wl_nRow).sCtaDevVta
                    .Rows(wl_nRow).Cells("sCtaVrc").Value = va_aeATALM(wl_nRow).sCtaVrc
                    .Rows(wl_nRow).Cells("sCtaGto").Value = va_aeATALM(wl_nRow).sCtaGto
                    .Rows(wl_nRow).Cells("sCtaDot").Value = va_aeATALM(wl_nRow).sCtaDot
                    .Rows(wl_nRow).Cells("sCtaDifPre").Value = va_aeATALM(wl_nRow).sCtaDifPre
                    .Rows(wl_nRow).Cells("sCtaRev").Value = va_aeATALM(wl_nRow).sCtaRev
                    .Rows(wl_nRow).Cells("sCtaAumInv").Value = va_aeATALM(wl_nRow).sCtaAumInv
                    .Rows(wl_nRow).Cells("sCtaRedInv").Value = va_aeATALM(wl_nRow).sCtaRedInv
                    .Rows(wl_nRow).Cells("sCtaCom").Value = va_aeATALM(wl_nRow).sCtaCom
                    .Rows(wl_nRow).Cells("sCtaDevCom").Value = va_aeATALM(wl_nRow).sCtaDevCom
                    .Rows(wl_nRow).Cells("sCtaWIP").Value = va_aeATALM(wl_nRow).sCtaWIP
                    .Rows(wl_nRow).Cells("bSelxDef").Value = va_aeATALM(wl_nRow).bSelxDef
                    .Rows(wl_nRow).Cells("bRegAci").Value = va_aeATALM(wl_nRow).bRegAci

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATALM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATALM_DGV(ByRef wp_eATALM As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATALM As New moe_Estructuras.eATALM
            With va_eATALM
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value
                .sNomAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlm").Value
                .sUbiAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sUbiAlm").Value
                .sCtaInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaInv").Value
                .sCtaCosVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCosVta").Value
                .sCtaTrs = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaTrs").Value
                .sCtaIng = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaIng").Value
                .sCtaDevVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevVta").Value
                .sCtaVrc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaVrc").Value
                .sCtaGto = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaGto").Value '10
                .sCtaDot = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDot").Value
                .sCtaDifPre = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDifPre").Value
                .sCtaRev = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRev").Value
                .sCtaAumInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaAumInv").Value
                .sCtaRedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRedInv").Value '15
                .sCtaCom = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCom").Value
                .sCtaDevCom = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevCom").Value
                .sCtaWIP = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaWIP").Value
                .bSelxDef = wp_VlrCtrl.Rows(wp_nRow).Cells("bSelxDef").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value

            End With
            wp_eATALM = va_eATALM
        Catch ex As Exception
            MsgBox("Error : moo_eATALM_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_eATALM(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eATALM As Object,
                                    ByVal wp_nRow As Integer)
        Try

            Dim wl_eATALM As New moe_Estructuras.eATALM
            wl_eATALM = wp_eATALM
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodAlm").Value = wl_eATALM.sCodAlm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_eATALM")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATANA"
    Public Sub moo_aeATANA_DT(ByRef wp_aeATANA As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATANA As New moe_Estructuras.eATANA
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wa_aeATANA(wl_nCntReg) As moe_Estructuras.eATANA
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wa_aeATANA(wl_nRow) = New moe_Estructuras.eATANA
                wl_eATANA = New moe_Estructuras.eATANA
                moo_eATANA_DT(wl_eATANA,
                              wp_DT,
                              wl_nRow)
                wa_aeATANA(wl_nRow) = wl_eATANA
            Next
            wp_aeATANA = wa_aeATANA
        Catch ex As Exception
            MsgBox("Error : moo_aeATANA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATANA_DT(ByRef wp_aATANA As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATANA As New moe_Estructuras.eATANA
            With wl_eATANA
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAna")), wp_DT.Rows(wp_nRow).Item("sCodAna"), "")
                .sNomAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAna")), wp_DT.Rows(wp_nRow).Item("sNomAna"), "")
                .sCodTipAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTipAna")), wp_DT.Rows(wp_nRow).Item("sCodTipAna"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), "")

            End With
            wp_aATANA = wl_eATANA
        Catch ex As Exception
            MsgBox("Error : moo_eATANA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATANA(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATANA As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATANA)
            Dim wa_aeATANA(wl_nCntReg) As moe_Estructuras.eATANA
            wa_aeATANA = wp_aeATANA
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wa_aeATANA(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodAna").Value = wa_aeATANA(wl_nRow).sCodAna
                    .Rows(wl_nRow).Cells("sNomAna").Value = wa_aeATANA(wl_nRow).sNomAna
                    .Rows(wl_nRow).Cells("sCodTipAna").Value = wa_aeATANA(wl_nRow).sCodTipAna
                    .Rows(wl_nRow).Cells("bRegAci").Value = wa_aeATANA(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATANA")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATANA_DGV(ByRef wp_eATANA As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATANA As New moe_Estructuras.eATANA
            With wl_eATANA
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAna").Value
                .sNomAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAna").Value
                .sCodTipAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTipAna").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATANA = wl_eATANA
        Catch ex As Exception
            MsgBox("Error : moo_eATANA_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATASI"
    Public Sub moo_aeATASI_DT(ByRef wp_aeATASI As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATASI As New moe_Estructuras.eATASI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATASI(wl_nCntReg) As moe_Estructuras.eATASI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATASI(wl_nRow) = New moe_Estructuras.eATASI
                wl_eATASI = New moe_Estructuras.eATASI
                moo_eATASI_DT(wl_eATASI,
                              wp_DT,
                              wl_nRow)
                wl_aeATASI(wl_nRow) = wl_eATASI
            Next
            wp_aeATASI = wl_aeATASI
        Catch ex As Exception
            MsgBox("Error : moo_aeATASI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATASI_DT(ByRef wp_eATASI As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATASI As New moe_Estructuras.eATASI
            With wl_eATASI
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .nAnoSdoIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nAnoSdoIni")), wp_DT.Rows(wp_nRow).Item("nAnoSdoIni"), 0)
                .sNomTblEnc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTblEnc")), wp_DT.Rows(wp_nRow).Item("sNomTblEnc"), "")
                .sNomTblDet = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTblDet")), wp_DT.Rows(wp_nRow).Item("sNomTblDet"), "")
                .sNomTblEncSdoIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTblEncSdoIni")), wp_DT.Rows(wp_nRow).Item("sNomTblEncSdoIni"), "")
                .sNomTblDetSdoIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTblDetSdoIni")), wp_DT.Rows(wp_nRow).Item("sNomTblDetSdoIni"), "")
                .dFecIniAno = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecIniAno")), wp_DT.Rows(wp_nRow).Item("dFecIniAno"), "")
                .sEstPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstPdo")), wp_DT.Rows(wp_nRow).Item("sEstPdo"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_eATASI = wl_eATASI
        Catch ex As Exception
            MsgBox("Error : moo_eATASI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATASI(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATASI As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATASI)
            Dim wl_aeATASI(wl_nCntReg) As moe_Estructuras.eATASI
            wl_aeATASI = wp_aeATASI
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wl_aeATASI(wl_nRow).nId
                    .Rows(wl_nRow).Cells("nAnoSdoIni").Value = wl_aeATASI(wl_nRow).nAnoSdoIni
                    .Rows(wl_nRow).Cells("sNomTblEnc").Value = wl_aeATASI(wl_nRow).sNomTblEnc
                    .Rows(wl_nRow).Cells("sNomTblDet").Value = wl_aeATASI(wl_nRow).sNomTblDet
                    .Rows(wl_nRow).Cells("sNomTblEncSdoIni").Value = wl_aeATASI(wl_nRow).sNomTblEncSdoIni
                    .Rows(wl_nRow).Cells("sNomTblDetSdoIni").Value = wl_aeATASI(wl_nRow).sNomTblDetSdoIni
                    .Rows(wl_nRow).Cells("dFecIniAno").Value = wl_aeATASI(wl_nRow).dFecIniAno
                    .Rows(wl_nRow).Cells("sEstPdo").Value = wl_aeATASI(wl_nRow).sEstPdo
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATASI(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATASI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATASI_DGV(ByRef wp_eATASI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATASI As New moe_Estructuras.eATASI
            With wl_eATASI
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .nAnoSdoIni = wp_VlrCtrl.Rows(wp_nRow).Cells("nAnoSdoIni").Value
                .sNomTblEnc = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTblEnc").Value
                .sNomTblDet = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTblDet").Value
                .sNomTblEncSdoIni = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTblEncSdoIni").Value
                .sNomTblDetSdoIni = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTblDetSdoIni").Value
                .dFecIniAno = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecIniAno").Value
                .sEstPdo = wp_VlrCtrl.Rows(wp_nRow).Cells("sEstPdo").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATASI = wl_eATASI
        Catch ex As Exception
            MsgBox("Error : moo_eATASI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ATAUT"
    Public Sub moo_aeATAUT_USR_DT(ByRef wp_aeATUSR As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATUSR As New moe_Estructuras.eATUSR
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATUSR(wl_nCntReg) As moe_Estructuras.eATUSR
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATUSR(wl_nRow) = New moe_Estructuras.eATUSR
                wl_eATUSR = New moe_Estructuras.eATUSR
                moo_eATAUT_USR_DT(wl_eATUSR,
                                  wp_DT,
                                  wl_nRow)
                wl_aeATUSR(wl_nRow) = wl_eATUSR
            Next
            wp_aeATUSR = wl_aeATUSR
        Catch ex As Exception
            MsgBox("Error :  moo_aeATAUT_USR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATAUT_USR_DT(ByRef wp_aATUSR As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim wl_eATUSR As New moe_Estructuras.eATUSR
            With wl_eATUSR
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sNomUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomUsr")), wp_DT.Rows(wp_nRow).Item("sNomUsr"), "")
                .sTipUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipUsr")), wp_DT.Rows(wp_nRow).Item("sTipUsr"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_aATUSR = wl_eATUSR
        Catch ex As Exception
            MsgBox("Error : moo_eATAUT_USR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATAUT_USR(ByVal wp_VlrCtrl As DataGridView,
                                   ByVal wp_aeATUSR As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATUSR)
            Dim wl_aeATUSR(wl_nCntReg) As moe_Estructuras.eATUSR
            wl_aeATUSR = wp_aeATUSR
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = wl_aeATUSR(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodUsr").Value = wl_aeATUSR(wl_nRow).sCodUsr
                    .Rows(wl_nRow).Cells("sNomUsr").Value = wl_aeATUSR(wl_nRow).sNomUsr
                    .Rows(wl_nRow).Cells("sTipUsr").Value = wl_aeATUSR(wl_nRow).sTipUsr
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATUSR(wl_nRow).bRegAci

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATAUT_USR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATAUT_USR_DGV(ByRef wp_eATUSR As Object,
                                  ByVal wp_VlrCtrl As DataGridView,
                                  ByRef wp_nRow As Integer)
        Try
            Dim wl_eATUSR As New moe_Estructuras.eATUSR
            With wl_eATUSR
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value
                .sNomUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomUsr").Value
                .sTipUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipUsr").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATUSR = wl_eATUSR
        Catch ex As Exception
            MsgBox("Error : moo_eATAUT_USR_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eATAUT_USR(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_eATUSR As Object,
                                  ByRef wp_nRow As Integer)
        Try
            With wp_eATUSR
                wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value = .nID
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value = .sCodUsr
                wp_VlrCtrl.Rows(wp_nRow).Cells("sNomUsr").Value = .sNomUsr
                wp_VlrCtrl.Rows(wp_nRow).Cells("sTipUsr").Value = .sTipUsr
                wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value = .bRegAci
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATAUT_USR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeATAUT_DT(ByRef wp_aeATAUT As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATAUT As New moe_Estructuras.eATAUT
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATAUT(wl_nCntReg) As moe_Estructuras.eATAUT
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATAUT(wl_nRow) = New moe_Estructuras.eATAUT
                wl_eATAUT = New moe_Estructuras.eATAUT
                moo_eATAUT_DT(wl_eATAUT,
                              wp_DT,
                              wl_nRow)
                wl_aeATAUT(wl_nRow) = wl_eATAUT
            Next
            wp_aeATAUT = wl_aeATAUT
        Catch ex As Exception
            MsgBox("Error :  moo_aeATAUT_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATAUT_DT(ByRef wp_aATAUT As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATAUT As New moe_Estructuras.eATAUT
            With wl_eATAUT
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sCodFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodFrm")), wp_DT.Rows(wp_nRow).Item("T0.sCodFrm"), "")
                .sCodAut = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAut")), wp_DT.Rows(wp_nRow).Item("T0.sCodAut"), "")
            End With
            wp_aATAUT = wl_eATAUT
        Catch ex As Exception
            MsgBox("Error : moo_eATAUT_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATAUTLst_DT(ByRef wp_aATAUT As Object,
                            ByVal wp_DT As DataTable,
                            ByVal wp_nRow As Integer)
        Try
            Dim wl_eATAUT As New moe_Estructuras.eATAUT
            With wl_eATAUT
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sCodFrm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodFrm")), wp_DT.Rows(wp_nRow).Item("T0.sCodFrm"), "")
                .sNomOpc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpc")), wp_DT.Rows(wp_nRow).Item("sNomOpc"), "")
                .sCodAut = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAut")), wp_DT.Rows(wp_nRow).Item("T0.sCodAut"), "")
                .sNomAut = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAut")), wp_DT.Rows(wp_nRow).Item("sNomAut"), "")
            End With
            wp_aATAUT = wl_eATAUT
        Catch ex As Exception
            MsgBox("Error : moo_eATAUTLst_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATAUT(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATAUT As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATAUT)
            Dim wl_aeATAUT(wl_nCntReg) As moe_Estructuras.eATAUT
            wl_aeATAUT = wp_aeATAUT
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = wl_aeATAUT(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodUsr").Value = wl_aeATAUT(wl_nRow).sCodUsr
                    .Rows(wl_nRow).Cells("sCodFrm").Value = wl_aeATAUT(wl_nRow).sCodFrm
                    .Rows(wl_nRow).Cells("sCodAut").Value = wl_aeATAUT(wl_nRow).sCodAut

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATAUT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATAUT_DGV(ByRef wp_eATAUT As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATAUT As New moe_Estructuras.eATAUT
            With wl_eATAUT
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value
                .sCodFrm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodFrm").Value
                .sCodAut = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAut").Value
            End With
            wp_eATAUT = wl_eATAUT
        Catch ex As Exception
            MsgBox("Error : moo_eATAUT_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eATAUT(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eATUSR As Object,
                              ByRef wp_nRow As Integer)
        Try
            With wp_eATUSR
                wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value = .nID
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value = .sCodUsr
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodFrm").Value = .sCodFrm
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAut").Value = .sCodAut
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATAUT_USR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eATAUTLst(ByRef wp_VlrCtrl As DataGridView,
                            ByVal wp_eATUSR As Object,
                            ByRef wp_nRow As Integer)
        Try
            With wp_eATUSR
                wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value = .nID
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value = .sCodUsr
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodFrm").Value = .sCodFrm
                wp_VlrCtrl.Rows(wp_nRow).Cells("sNomOpc").Value = .sNomOpc
                wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAut").Value = .sCodAut
                wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAut").Value = .sNomAut
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATAUTLst")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATCCO"
    Public Sub moo_aeATCCO_DT(ByRef wp_aeATCCO As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATCCO As New moe_Estructuras.eATCCO
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATCCO(wl_nCntReg) As moe_Estructuras.eATCCO
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATCCO(wl_nRow) = New moe_Estructuras.eATCCO
                wl_eATCCO = New moe_Estructuras.eATCCO
                moo_eATCCO_DT(wl_eATCCO,
                              wp_DT,
                              wl_nRow)
                va_aeATCCO(wl_nRow) = wl_eATCCO
            Next
            wp_aeATCCO = va_aeATCCO
        Catch ex As Exception
            MsgBox("Error : moo_aeATCCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATCCO_DT(ByRef wp_aATCCO As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATCCO As New moe_Estructuras.eATCCO
            With wl_eATCCO
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .sNomCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCco")), wp_DT.Rows(wp_nRow).Item("sNomCco"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_aATCCO = wl_eATCCO
        Catch ex As Exception
            MsgBox("Error : moo_eATCCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATCCO(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATCCO As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATCCO)
            Dim va_aeATCCO(wl_nCntReg) As moe_Estructuras.eATCCO
            va_aeATCCO = wp_aeATCCO
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aeATCCO(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodCco").Value = va_aeATCCO(wl_nRow).sCodCco
                    .Rows(wl_nRow).Cells("sNomCco").Value = va_aeATCCO(wl_nRow).sNomCco
                    .Rows(wl_nRow).Cells("bRegAci").Value = va_aeATCCO(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATCCO")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATCCO_DGV(ByRef wp_eATCCO As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATCCO As New moe_Estructuras.eATCCO
            With va_eATCCO
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodCco = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCco").Value
                .sNomCco = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCco").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATCCO = va_eATCCO
        Catch ex As Exception
            MsgBox("Error : moo_eATCCO_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DgvGLMOV1_eATCCO(ByRef wp_eATCCO As Object,
                                        ByVal wp_VlrCtrl As DataGridView,
                                        ByRef wp_nRow As Long)
        Try
            Dim wl_eATCCO As New moe_Estructuras.eATCCO
            wl_eATCCO = wp_eATCCO
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodCco").Value = wl_eATCCO.sCodCco
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DgvGLMOV1_eATCCO")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATCIF"
    Public Sub moo_aeATCIF_DT(ByRef wp_aeATCIF As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_eATCIF As New moe_Estructuras.eATCIF
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aeATCIF(wl_nCntReg) As moe_Estructuras.eATCIF
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aeATCIF(wl_nRow) = New moe_Estructuras.eATCIF
                vl_eATCIF = New moe_Estructuras.eATCIF
                moo_eATCIF_DT(vl_eATCIF,
                              wp_DT,
                              wl_nRow)
                vl_aeATCIF(wl_nRow) = vl_eATCIF
            Next
            wp_aeATCIF = vl_aeATCIF
        Catch ex As Exception
            MsgBox("Error : moo_aeATCIF_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATCIF_DT(ByRef wp_aATCIF As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim vl_eATCIF As New moe_Estructuras.eATCIF
            With vl_eATCIF
                .sCodCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCIF")), wp_DT.Rows(wp_nRow).Item("sCodCIF"), "")
                .sNomCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCIF")), wp_DT.Rows(wp_nRow).Item("sNomCIF"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "")
                .nTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTasCIF")), wp_DT.Rows(wp_nRow).Item("nTasCIF"), 0)
                .nVlrCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrCIF")), wp_DT.Rows(wp_nRow).Item("nVlrCIF"), 0)
                .nVlrCIFPpo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrCIFPpo")), wp_DT.Rows(wp_nRow).Item("nVlrCIFPpo"), 0)
                .nBasCIFPpo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nBasCIFPpo")), wp_DT.Rows(wp_nRow).Item("nBasCIFPpo"), 0)
                .nVlrCIFRea = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("nVlrCIFRea"), 0)
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)

            End With
            wp_aATCIF = vl_eATCIF

        Catch ex As Exception
            MsgBox("Error : moo_eATCIF_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATCIF(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_aeATCIF As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATCIF)
            With wp_VlrCtrl
                For wl_nRow = 0 To wl_nCntReg
                    .Rows.Add()
                    moo_DGV_eATCIF(wp_VlrCtrl,
                                   wp_aeATCIF(wl_nRow),
                                   wl_nRow)
                Next
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATCIF")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_eATCIF(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eATCIF As Object,
                              ByVal wp_nRow As Integer)
        Try

            Dim vl_eATCIF As New moe_Estructuras.eATCIF

            vl_eATCIF = wp_eATCIF
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodCIF").Value = vl_eATCIF.sCodCIF
                .Rows(wp_nRow).Cells("sNomCIF").Value = vl_eATCIF.sNomCIF
                .Rows(wp_nRow).Cells("sCodCtr").Value = vl_eATCIF.sCodCtr
                .Rows(wp_nRow).Cells("nTasCIF").Value = vl_eATCIF.nTasCIF
                .Rows(wp_nRow).Cells("nVlrCIF").Value = vl_eATCIF.nVlrCIF
                .Rows(wp_nRow).Cells("nVlrCIFPpo").Value = vl_eATCIF.nVlrCIFPpo
                .Rows(wp_nRow).Cells("nBasCIFPpo").Value = vl_eATCIF.nBasCIFPpo
                .Rows(wp_nRow).Cells("nVlrCIFRea").Value = vl_eATCIF.nVlrCIFRea
                .Rows(wp_nRow).Cells("bRegAci").Value = vl_eATCIF.bRegAci
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATCIF")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATCIF_DGV(ByRef wp_eATCIF As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wl_nRow As Integer)
        Try
            Dim vl_eATCIF As New moe_Estructuras.eATCIF

            With vl_eATCIF
                .sCodCIF = wp_VlrCtrl.Rows(wl_nRow).Cells("sCodCIF").Value
                .sNomCIF = wp_VlrCtrl.Rows(wl_nRow).Cells("sNomCIF").Value
                .sCodCtr = wp_VlrCtrl.Rows(wl_nRow).Cells("sCodCtr").Value
                .nTasCIF = wp_VlrCtrl.Rows(wl_nRow).Cells("nTasCIF").Value
                .nVlrCIF = wp_VlrCtrl.Rows(wl_nRow).Cells("nVlrCIF").Value
                .nVlrCIFPpo = wp_VlrCtrl.Rows(wl_nRow).Cells("nVlrCIFPpo").Value
                .nBasCIFPpo = wp_VlrCtrl.Rows(wl_nRow).Cells("nBasCIFPpo").Value
                .nVlrCIFRea = wp_VlrCtrl.Rows(wl_nRow).Cells("nVlrCIFRea").Value
                .bRegAci = wp_VlrCtrl.Rows(wl_nRow).Cells("bRegAci").Value
            End With
            wp_eATCIF = vl_eATCIF
        Catch ex As Exception
            MsgBox("Error : moo_eATOPE_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATCTR"
    Public Sub moo_aeATCTR_DT(ByRef wp_aeATCTR As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATCTR As New moe_Estructuras.eATCTR
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATCTR(wl_nCntReg) As moe_Estructuras.eATCTR
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATCTR(wl_nRow) = New moe_Estructuras.eATCTR
                wl_eATCTR = New moe_Estructuras.eATCTR
                moo_eATCTR_DT(wl_eATCTR,
                              wp_DT,
                              wl_nRow)
                wl_aeATCTR(wl_nRow) = wl_eATCTR
            Next
            wp_aeATCTR = wl_aeATCTR
        Catch ex As Exception
            MsgBox("Error : moo_aeATCTR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATCTR_DT(ByRef wp_aATCTR As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATCTR As New moe_Estructuras.eATCTR
            With wl_eATCTR
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "")
                .sNomCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCtr")), wp_DT.Rows(wp_nRow).Item("sNomCtr"), "")
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .nCosMODFij = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosMODFij")), wp_DT.Rows(wp_nRow).Item("nCosMODFij"), 0)
                .nCosMODVar = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosMODVar")), wp_DT.Rows(wp_nRow).Item("nCosMODVar"), 0)
                .nCosHorCpr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosHorCpr")), wp_DT.Rows(wp_nRow).Item("nCosHorCpr"), 0)
                .nScoVar = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nScoVar")), wp_DT.Rows(wp_nRow).Item("nScoVar"), 0)
                .nCosHorVar = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosHorVar")), wp_DT.Rows(wp_nRow).Item("nCosHorVar"), 0)
                .nCosTotMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotMOD")), wp_DT.Rows(wp_nRow).Item("nCosTotMOD"), 0)
                .nUniTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUniTieOpe")), wp_DT.Rows(wp_nRow).Item("nUniTieOpe"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)

            End With
            wp_aATCTR = wl_eATCTR
        Catch ex As Exception
            MsgBox("Error : moo_eATCTR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATCTR(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATCTR As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATCTR)
            Dim wl_aeATCTR(wl_nCntReg) As moe_Estructuras.eATCTR
            wl_aeATCtr = wp_aeATCTR
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = wl_aeATCTR(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodCtr").Value = wl_aeATCTR(wl_nRow).sCodCtr
                    .Rows(wl_nRow).Cells("sNomCtr").Value = wl_aeATCTR(wl_nRow).sNomCtr
                    .Rows(wl_nRow).Cells("sCodCco").Value = wl_aeATCTR(wl_nRow).sCodCco
                    .Rows(wl_nRow).Cells("nCosMODFij").Value = wl_aeATCTR(wl_nRow).nCosMODFij
                    .Rows(wl_nRow).Cells("nCosMODVar").Value = wl_aeATCTR(wl_nRow).nCosMODVar
                    .Rows(wl_nRow).Cells("nCosHorCpr").Value = wl_aeATCTR(wl_nRow).nCosHorCpr
                    .Rows(wl_nRow).Cells("nScoVar").Value = wl_aeATCTR(wl_nRow).nScoVar
                    .Rows(wl_nRow).Cells("nCosHorVar").Value = wl_aeATCTR(wl_nRow).nCosHorVar
                    .Rows(wl_nRow).Cells("nCosTotMOD").Value = wl_aeATCTR(wl_nRow).nCosTotMOD
                    .Rows(wl_nRow).Cells("nUniTieOpe").Value = wl_aeATCTR(wl_nRow).nUniTieOpe
                    .Rows(wl_nRow).Cells("nPreUni").Value = wl_aeATCTR(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATCTR(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATCTR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATCTR_DGV(ByRef wp_eATCTR As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATCTR As New moe_Estructuras.eATCTR
            With wl_eATCTR
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .sNomCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCtr").Value
                .sCodCco = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCco").Value
                .nCosMODFij = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosMODFij").Value
                .nCosMODVar = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosMODVar").Value
                .nCosHorCpr = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosHorCpr").Value
                .nScoVar = wp_VlrCtrl.Rows(wp_nRow).Cells("nScoVar").Value
                .nCosHorVar = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosHorVar").Value
                .nCosTotMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosTotMOD").Value
                .nUniTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nUniTieOpe").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value

            End With
            wp_eATCTR = wl_eATCTR
        Catch ex As Exception
            MsgBox("Error : moo_eATCTR_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATGRI"
    Public Sub moo_aeATGRI_DT(ByRef wp_aeATGRI As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATGRI As New moe_Estructuras.eATGRI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATGRI(wl_nCntReg) As moe_Estructuras.eATGRI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATGRI(wl_nRow) = New moe_Estructuras.eATGRI
                wl_eATGRI = New moe_Estructuras.eATGRI
                moo_eATGRI_DT(wl_eATGRI,
                              wp_DT,
                              wl_nRow)
                wl_aeATGRI(wl_nRow) = wl_eATGRI
            Next
            wp_aeATGRI = wl_aeATGRI
        Catch ex As Exception
            MsgBox("Error :  moo_aeATGRI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATGRI_DT(ByRef wp_aATGRI As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATGRI As New moe_Estructuras.eATGRI
            With wl_eATGRI
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
                .sNomGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomGrp")), wp_DT.Rows(wp_nRow).Item("sNomGrp"), "")
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaInv")), wp_DT.Rows(wp_nRow).Item("sCtaInv"), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .sCtaTrs = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaTrs")), wp_DT.Rows(wp_nRow).Item("sCtaTrs"), "")
                .sCtaIng = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaIng")), wp_DT.Rows(wp_nRow).Item("sCtaIng"), "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDevVta")), wp_DT.Rows(wp_nRow).Item("sCtaDevVta"), "")
                .sCtaVrc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaVrc")), wp_DT.Rows(wp_nRow).Item("sCtaVrc"), "")
                .sCtaGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaGto")), wp_DT.Rows(wp_nRow).Item("sCtaGto"), "")
                .sCtaDot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDot")), wp_DT.Rows(wp_nRow).Item("sCtaDot"), "") '10
                .sCtaDifPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDifPre")), wp_DT.Rows(wp_nRow).Item("sCtaDifPre"), "")
                .sCtaRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRev")), wp_DT.Rows(wp_nRow).Item("sCtaRev"), "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaAumInv")), wp_DT.Rows(wp_nRow).Item("sCtaAumInv"), "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRedInv")), wp_DT.Rows(wp_nRow).Item("sCtaRedInv"), "")
                .sCtaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCom")), wp_DT.Rows(wp_nRow).Item("sCtaCom"), "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDevCom")), wp_DT.Rows(wp_nRow).Item("sCtaDevCom"), "")
                .sCtaWIP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaWIP")), wp_DT.Rows(wp_nRow).Item("sCtaWIP"), "")
                .sSysInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sSysInv")), wp_DT.Rows(wp_nRow).Item("sSysInv"), "")
                .sMetAba = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMetAba")), wp_DT.Rows(wp_nRow).Item("sMetAba"), "")
                .sMetVlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMetVlz")), wp_DT.Rows(wp_nRow).Item("sMetVlz"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)


            End With
            wp_aATGRI = wl_eATGRI
        Catch ex As Exception
            MsgBox("Error : moo_eATGRI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATGRI(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATGRI As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATGRI)
            Dim wl_aeATGRI(wl_nCntReg) As moe_Estructuras.eATGRI
            wl_aeATGRI = wp_aeATGRI
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = wl_aeATGRI(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodGrp").Value = wl_aeATGRI(wl_nRow).sCodGrp
                    .Rows(wl_nRow).Cells("sNomGrp").Value = wl_aeATGRI(wl_nRow).sNomGrp
                    .Rows(wl_nRow).Cells("sCtaInv").Value = wl_aeATGRI(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells("sCtaCosVta").Value = wl_aeATGRI(wl_nRow).sCtaCosVta
                    .Rows(wl_nRow).Cells("sCtaTrs").Value = wl_aeATGRI(wl_nRow).sCtaTrs
                    .Rows(wl_nRow).Cells("sCtaIng").Value = wl_aeATGRI(wl_nRow).sCtaIng
                    .Rows(wl_nRow).Cells("sCtaDevVta").Value = wl_aeATGRI(wl_nRow).sCtaDevVta
                    .Rows(wl_nRow).Cells("sCtaVrc").Value = wl_aeATGRI(wl_nRow).sCtaVrc
                    .Rows(wl_nRow).Cells("sCtaGto").Value = wl_aeATGRI(wl_nRow).sCtaGto
                    .Rows(wl_nRow).Cells("sCtaDot").Value = wl_aeATGRI(wl_nRow).sCtaDot
                    .Rows(wl_nRow).Cells("sCtaDifPre").Value = wl_aeATGRI(wl_nRow).sCtaDifPre
                    .Rows(wl_nRow).Cells("sCtaRev").Value = wl_aeATGRI(wl_nRow).sCtaRev
                    .Rows(wl_nRow).Cells("sCtaAumInv").Value = wl_aeATGRI(wl_nRow).sCtaAumInv
                    .Rows(wl_nRow).Cells("sCtaRedInv").Value = wl_aeATGRI(wl_nRow).sCtaRedInv
                    .Rows(wl_nRow).Cells("sCtaCom").Value = wl_aeATGRI(wl_nRow).sCtaCom
                    .Rows(wl_nRow).Cells("sCtaDevCom").Value = wl_aeATGRI(wl_nRow).sCtaDevCom
                    .Rows(wl_nRow).Cells("sCtaWIP").Value = wl_aeATGRI(wl_nRow).sCtaWIP
                    .Rows(wl_nRow).Cells("sSysInv").Value = wl_aeATGRI(wl_nRow).sSysInv
                    .Rows(wl_nRow).Cells("sMetAba").Value = wl_aeATGRI(wl_nRow).sMetAba
                    .Rows(wl_nRow).Cells("sMetVlz").Value = wl_aeATGRI(wl_nRow).sMetVlz
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATGRI(wl_nRow).bRegAci

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATGRI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATGRI_DGV(ByRef wp_eATGRI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATGRI As New moe_Estructuras.eATGRI
            With wl_eATGRI
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodGrp = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value
                .sNomGrp = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomGrp").Value
                .sCtaInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaInv").Value
                .sCtaCosVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCosVta").Value
                .sCtaTrs = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaTrs").Value
                .sCtaIng = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaIng").Value
                .sCtaDevVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevVta").Value
                .sCtaVrc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaVrc").Value
                .sCtaGto = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaGto").Value '10
                .sCtaDot = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDot").Value
                .sCtaDifPre = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDifPre").Value
                .sCtaRev = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRev").Value
                .sCtaAumInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaAumInv").Value
                .sCtaRedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRedInv").Value '15
                .sCtaCom = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCom").Value
                .sCtaDevCom = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevCom").Value
                .sCtaWIP = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaWIP").Value
                .sSysInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sSysInv").Value
                .sMetAba = wp_VlrCtrl.Rows(wp_nRow).Cells("sMetAba").Value
                .sMetVlz = wp_VlrCtrl.Rows(wp_nRow).Cells("sMetVlz").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATGRI = wl_eATGRI
        Catch ex As Exception
            MsgBox("Error : moo_eATGRI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATGRV"
    Public Sub moo_aeATGRV_DT(ByRef wp_aeATGRV As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATGRV As New moe_Estructuras.eATGRV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATGRV(wl_nCntReg) As moe_Estructuras.eATGRV
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATGRV(wl_nRow) = New moe_Estructuras.eATGRV
                wl_eATGRV = New moe_Estructuras.eATGRV
                moo_eATGRV_DT(wl_eATGRV,
                              wp_DT,
                              wl_nRow)
                wl_aeATGRV(wl_nRow) = wl_eATGRV
            Next
            wp_aeATGRV = wl_aeATGRV
        Catch ex As Exception
            MsgBox("Error :  moo_aeATGRV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATGRV_DT(ByRef wp_aATGRV As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATGRV As New moe_Estructuras.eATGRV
            With wl_eATGRV
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodGrpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrpVta")), wp_DT.Rows(wp_nRow).Item("sCodGrpVta"), "")
                .sNomGrpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomGrpVta")), wp_DT.Rows(wp_nRow).Item("sNomGrpVta"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_aATGRV = wl_eATGRV
        Catch ex As Exception
            MsgBox("Error : moo_eATGRV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATGRV(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATGRV As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATGRV)
            Dim wl_aeATGRV(wl_nCntReg) As moe_Estructuras.eATGRV
            wl_aeATGRV = wp_aeATGRV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = wl_aeATGRV(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodGrpVta").Value = wl_aeATGRV(wl_nRow).sCodGrpVta
                    .Rows(wl_nRow).Cells("sNomGrpVta").Value = wl_aeATGRV(wl_nRow).sNomGrpVta
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATGRV(wl_nRow).bRegAci

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATGRV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATGRV_DGV(ByRef wp_eATGRV As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATGRV As New moe_Estructuras.eATGRV
            With wl_eATGRV
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodGrpVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrpVta").Value
                .sNomGrpVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomGrpVta").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATGRV = wl_eATGRV
        Catch ex As Exception
            MsgBox("Error : moo_eATGRV_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATIVA"
    Public Sub moo_aeATIVA_DT(ByRef wp_aeATIVA As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATIVA As New moe_Estructuras.eATIVA
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATIVA(wl_nCntReg) As moe_Estructuras.eATIVA
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATIVA(wl_nRow) = New moe_Estructuras.eATIVA
                wl_eATIVA = New moe_Estructuras.eATIVA
                moo_eATIVA_DT(wl_eATIVA,
                              wp_DT,
                              wl_nRow)
                va_aeATIVA(wl_nRow) = wl_eATIVA
            Next
            wp_aeATIVA = va_aeATIVA
        Catch ex As Exception
            MsgBox("Error : moo_aeATIVA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATIVA_DT(ByRef wp_aATIVA As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATIVA As New moe_Estructuras.eATIVA
            With wl_eATIVA
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIVA")), wp_DT.Rows(wp_nRow).Item("sCodIVA"), "")
                .sNomIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomIVA")), wp_DT.Rows(wp_nRow).Item("sNomIVA"), "")
                .nPorIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIVA")), wp_DT.Rows(wp_nRow).Item("nPorIVA"), 0)
                .bVdoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bVdoVta")), wp_DT.Rows(wp_nRow).Item("bVdoVta"), False)
                .sCtaCbeVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCbeVta")), wp_DT.Rows(wp_nRow).Item("sCtaCbeVta"), "")
                .bVdoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bVdoVta")), wp_DT.Rows(wp_nRow).Item("bVdoVta"), False)
                .sCtaCbeCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCbeCom")), wp_DT.Rows(wp_nRow).Item("sCtaCbeCom"), "")
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
            End With
            wp_aATIVA = wl_eATIVA
        Catch ex As Exception
            MsgBox("Error : moo_eATIVA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATIVA(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATIVA As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATIVA)
            Dim va_aeATIVA(wl_nCntReg) As moe_Estructuras.eATIVA
            va_aeATIVA = wp_aeATIVA
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aeATIVA(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodIVA").Value = va_aeATIVA(wl_nRow).sCodIVA
                    .Rows(wl_nRow).Cells("sNomIVA").Value = va_aeATIVA(wl_nRow).sNomIVA
                    .Rows(wl_nRow).Cells("nPorIVA").Value = va_aeATIVA(wl_nRow).nPorIVA
                    .Rows(wl_nRow).Cells("bVdoVta").Value = va_aeATIVA(wl_nRow).bVdoVta
                    .Rows(wl_nRow).Cells("sCtaCbeVta").Value = va_aeATIVA(wl_nRow).sCtaCbeVta
                    .Rows(wl_nRow).Cells("bVdoCom").Value = va_aeATIVA(wl_nRow).bVdoCom
                    .Rows(wl_nRow).Cells("sCtaCbeCom").Value = va_aeATIVA(wl_nRow).sCtaCbeCom
                    .Rows(wl_nRow).Cells("sClsDoc").Value = va_aeATIVA(wl_nRow).sClsDoc
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATIVA")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATIVA_DGV(ByRef wp_eATIVA As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATIVA As New moe_Estructuras.eATIVA
            With va_eATIVA
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodIVA = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodIVA").Value
                .sNomIVA = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomIVA").Value
                .nPorIVA = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorIVA").Value
                .bVdoVta = wp_VlrCtrl.Rows(wp_nRow).Cells("bVdoVta").Value
                .sCtaCbeVta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCbeVta").Value
                .bVdoCom = wp_VlrCtrl.Rows(wp_nRow).Cells("bVdoCom").Value
                .sCtaCbeCom = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCbeCom").Value
                .sClsDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sClsDoc").Value
            End With
            wp_eATIVA = va_eATIVA
        Catch ex As Exception
            MsgBox("Error : moo_eATIVA_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DgvGLMOV1_eATIVA(ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_eATIVA As Object,
                                   ByRef wp_nRow As Long)
        Try

            Dim wl_eATIVA As New moe_Estructuras.eATIVA
            wl_eATIVA = wp_eATIVA
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodIVA").Value = wl_eATIVA.sCodIVA
                .Rows(wp_nRow).Cells("nPorIVA").Value = wl_eATIVA.nPorIVA
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DgvGLMOV1_eATIVA")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATMON"
    Public Sub moo_aeATMON_DT(ByRef wp_aeATMON As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATMON As New moe_Estructuras.eATMON
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATMON(wl_nCntReg) As moe_Estructuras.eATMON
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATMON(wl_nRow) = New moe_Estructuras.eATMON
                wl_eATMON = New moe_Estructuras.eATMON
                moo_eATMON_DT(wl_eATMON,
                              wp_DT,
                              wl_nRow)
                va_aeATMON(wl_nRow) = wl_eATMON
            Next
            wp_aeATMON = va_aeATMON
        Catch ex As Exception
            MsgBox("Error : moo_aeATMON_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATMON_DT(ByRef wp_aATMON As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATMON As New moe_Estructuras.eATMON
            With wl_eATMON
                .sCodMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodMon")), wp_DT.Rows(wp_nRow).Item("sCodMon"), "")
                .sNomMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomMon")), wp_DT.Rows(wp_nRow).Item("sNomMon"), "")
                .sCodIntMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIntMon")), wp_DT.Rows(wp_nRow).Item("sCodIntMon"), 0)

            End With
            wp_aATMON = wl_eATMON
        Catch ex As Exception
            MsgBox("Error : moo_eATMON_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATMON(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATMON As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATMON)
            Dim wa_aeATMON(wl_nCntReg) As moe_Estructuras.eATMON
            wa_aeATMON = wp_aeATMON
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).Cells("sCodMon").Value = wa_aeATMON(wl_nRow).sCodMon
                    .Rows(wl_nRow).Cells("sNomMon").Value = wa_aeATMON(wl_nRow).sNomMon
                    .Rows(wl_nRow).Cells("sCodIntMon").Value = wa_aeATMON(wl_nRow).sCodIntMon
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATMON")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATMON_DGV(ByRef wp_eATMON As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wa_eATMON As New moe_Estructuras.eATMON
            With wa_eATMON
                .sCodMon = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodMon").Value
                .sNomMon = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomMon").Value
                .sCodIntMon = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodIntMon").Value

            End With
            wp_eATMON = wa_eATMON
        Catch ex As Exception
            MsgBox("Error : moo_eATMON_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATOPE"
    Public Sub moo_aeATOPE_DT(ByRef wp_aeATOPE As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_eATOPE As New moe_Estructuras.eATOPE
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aeATOPE(wl_nCntReg) As moe_Estructuras.eATOPE
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aeATOPE(wl_nRow) = New moe_Estructuras.eATOPE
                vl_eATOPE = New moe_Estructuras.eATOPE
                moo_eATOPE_DT(vl_eATOPE,
                              wp_DT,
                              wl_nRow)
                vl_aeATOPE(wl_nRow) = vl_eATOPE
            Next
            wp_aeATOPE = vl_aeATOPE
        Catch ex As Exception
            MsgBox("Error : moo_aeATOPE_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATOPE_DT(ByRef wp_eATOPE As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim vl_eATOPE As New moe_Estructuras.eATOPE
            With vl_eATOPE
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), "")
                .sCodOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodOpe")), wp_DT.Rows(wp_nRow).Item("sCodOpe"), "")
                .sNomOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpe")), wp_DT.Rows(wp_nRow).Item("sNomOpe"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "")
                .nTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieOpe")), wp_DT.Rows(wp_nRow).Item("nTieOpe"), "")
                .nUniTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUniTieOpe")), wp_DT.Rows(wp_nRow).Item("nUniTieOpe"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_eATOPE = vl_eATOPE
        Catch ex As Exception
            MsgBox("Error : moo_eATOPE_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATOPE(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATOPE As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATOPE)
            With wp_VlrCtrl
                For wl_nRow = 0 To wl_nCntReg
                    .Rows.Add()
                    moo_DGV_eATOPE(wp_VlrCtrl,
                                   wp_aeATOPE(wl_nRow),
                                   wl_nRow)
                Next
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATOPE")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_eATOPE(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eATOPE As Object,
                              ByVal wp_nRow As Integer)
        Try

            Dim vl_eATOPE As New moe_Estructuras.eATOPE

            vl_eATOPE = wp_eATOPE
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = vl_eATOPE.nId
                .Rows(wp_nRow).Cells("sCodOpe").Value = vl_eATOPE.sCodOpe
                .Rows(wp_nRow).Cells("sNomOpe").Value = vl_eATOPE.sNomOpe
                .Rows(wp_nRow).Cells("sCodCtr").Value = vl_eATOPE.sCodCtr
                .Rows(wp_nRow).Cells("nTieOpe").Value = vl_eATOPE.nTieOpe
                .Rows(wp_nRow).Cells("nUniTieOpe").Value = vl_eATOPE.nUniTieOpe
                .Rows(wp_nRow).Cells("bRegAci").Value = vl_eATOPE.bRegAci
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATOPE")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATOPE_DGV(ByRef wp_eATOPE As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wl_nRow As Integer)
        Try
            Dim vl_eATOPE As New moe_Estructuras.eATOPE

            With vl_eATOPE
                .nId = wp_VlrCtrl.Rows(wl_nRow).Cells("nId").Value
                .sCodOpe = wp_VlrCtrl.Rows(wl_nRow).Cells("sCodOpe").Value
                .sNomOpe = wp_VlrCtrl.Rows(wl_nRow).Cells("sNomOpe").Value
                .sCodCtr = wp_VlrCtrl.Rows(wl_nRow).Cells("sCodCtr").Value
                .nTieOpe = wp_VlrCtrl.Rows(wl_nRow).Cells("nTieOpe").Value
                .nUniTieOpe = wp_VlrCtrl.Rows(wl_nRow).Cells("nUniTieOpe").Value
                .bRegAci = wp_VlrCtrl.Rows(wl_nRow).Cells("bRegAci").Value
            End With
            wp_eATOPE = vl_eATOPE
        Catch ex As Exception
            MsgBox("Error : moo_eATOPE_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATPCO"
    Public Sub moo_aeATPCO_DT(ByRef wp_aeATPCO As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATPCO As New moe_Estructuras.eATPCO
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATPCO(wl_nCntReg) As moe_Estructuras.eATPCO
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATPCO(wl_nRow) = New moe_Estructuras.eATPCO
                wl_eATPCO = New moe_Estructuras.eATPCO
                moo_eATPCO_DT(wl_eATPCO,
                              wp_DT,
                              wl_nRow)
                wl_aeATPCO(wl_nRow) = wl_eATPCO
            Next
            wp_aeATPCO = wl_aeATPCO
        Catch ex As Exception
            MsgBox("Error : moo_aeATPCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATPCO_DT(ByRef wp_eATPCO As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATPCO As New moe_Estructuras.eATPCO
            With wl_eATPCO
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .sNomPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomPdo")), wp_DT.Rows(wp_nRow).Item("sNomPdo"), "")
                .sEstPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstPdo")), wp_DT.Rows(wp_nRow).Item("sEstPdo"), "")
                .dFecIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecIni")), wp_DT.Rows(wp_nRow).Item("dFecIni"), "")
                .dFecFin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecFin")), wp_DT.Rows(wp_nRow).Item("dFecFin"), "")
                .sCodAno = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAno")), wp_DT.Rows(wp_nRow).Item("sCodAno"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_eATPCO = wl_eATPCO
        Catch ex As Exception
            MsgBox("Error : moo_eATPCO_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATPCO(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATPCO As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATPCO)
            Dim wl_aeATPCO(wl_nCntReg) As moe_Estructuras.eATPCO
            wl_aeATPCO = wp_aeATPCO
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wl_aeATPCO(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodPdo").Value = wl_aeATPCO(wl_nRow).sCodPdo
                    .Rows(wl_nRow).Cells("sNomPdo").Value = wl_aeATPCO(wl_nRow).sNomPdo
                    .Rows(wl_nRow).Cells("sEstPdo").Value = wl_aeATPCO(wl_nRow).sEstPdo
                    .Rows(wl_nRow).Cells("dFecIni").Value = wl_aeATPCO(wl_nRow).dFecIni
                    .Rows(wl_nRow).Cells("dFecFin").Value = wl_aeATPCO(wl_nRow).dFecFin
                    .Rows(wl_nRow).Cells("sCodAno").Value = wl_aeATPCO(wl_nRow).sCodAno
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATPCO(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATPCO")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATPCO_DGV(ByRef wp_eATPCO As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATPCO As New moe_Estructuras.eATPCO
            With wl_eATPCO
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodPdo = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodPdo").Value
                .sNomPdo = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomPdo").Value
                .sEstPdo = wp_VlrCtrl.Rows(wp_nRow).Cells("sEstPdo").Value
                .dFecIni = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecIni").Value
                .dFecFin = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecFin").Value
                .sCodAno = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAno").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATPCO = wl_eATPCO
        Catch ex As Exception
            MsgBox("Error : moo_eATPCO_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region


#Region "ATPOP"
    Public Sub moo_aeATPOP_DT(ByRef wp_aeATPOP As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATPOP As New moe_Estructuras.eATPOP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATPOP(wl_nCntReg) As moe_Estructuras.eATPOP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATPOP(wl_nRow) = New moe_Estructuras.eATPOP
                wl_eATPOP = New moe_Estructuras.eATPOP
                moo_eATPOP_DT(wl_eATPOP,
                              wp_DT,
                              wl_nRow)
                wl_aeATPOP(wl_nRow) = wl_eATPOP
            Next
            wp_aeATPOP = wl_aeATPOP
        Catch ex As Exception
            MsgBox("Error : moo_aeATPOP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATPOP_DT(ByRef wp_eATPOP As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATPOP As New moe_Estructuras.eATPOP
            With wl_eATPOP
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_eATPOP = wl_eATPOP
        Catch ex As Exception
            MsgBox("Error : moo_eATPOP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATPOP(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATPOP As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATPOP)
            Dim wl_aeATPOP(wl_nCntReg) As moe_Estructuras.eATPOP
            wl_aeATPOP = wp_aeATPOP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wl_aeATPOP(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodTer").Value = wl_aeATPOP(wl_nRow).sCodTer
                    .Rows(wl_nRow).Cells("sNomTer").Value = wl_aeATPOP(wl_nRow).sNomTer
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATPOP(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATPOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATPOP_DGV(ByRef wp_eATPOP As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATPOP As New moe_Estructuras.eATPOP
            With wl_eATPOP
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value
                .sNomTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTer").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATPOP = wl_eATPOP
        Catch ex As Exception
            MsgBox("Error : moo_eATPOP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "ATUSR"
    Public Sub moo_aeATUSR_DT(ByRef wp_aeATUSR As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATUSR As New moe_Estructuras.eATUSR
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATUSR(wl_nCntReg) As moe_Estructuras.eATUSR
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATUSR(wl_nRow) = New moe_Estructuras.eATUSR
                wl_eATUSR = New moe_Estructuras.eATUSR
                moo_eATAUT_DT(wl_eATUSR,
                                 wp_DT,
                                 wl_nRow)
                wl_aeATUSR(wl_nRow) = wl_eATUSR
            Next
            wp_aeATUSR = wl_aeATUSR
        Catch ex As Exception
            MsgBox("Error : moo_aeATUSR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATUSR_DT(ByRef wp_aATUSR As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim wl_eATUSR As New moe_Estructuras.eATUSR
            With wl_eATUSR
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sPwdUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sPwdUsr")), wp_DT.Rows(wp_nRow).Item("sPwdUsr"), "")
                .sNomUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomUsr")), wp_DT.Rows(wp_nRow).Item("sNomUsr"), "")
                .sTipUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipUsr")), wp_DT.Rows(wp_nRow).Item("sTipUsr"), "")
                .sEmlUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEmlUsr")), wp_DT.Rows(wp_nRow).Item("sEmlUsr"), "")
                .sTel1Usr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel1Usr")), wp_DT.Rows(wp_nRow).Item("sTel1Usr"), "")
                .sTel2Usr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel2Usr")), wp_DT.Rows(wp_nRow).Item("sTel2Usr"), "")
                .bUsrBlq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bUsrBlq")), wp_DT.Rows(wp_nRow).Item("bUsrBlq"), False)
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_aATUSR = wl_eATUSR
        Catch ex As Exception
            MsgBox("Error : moo_eATUSR_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATUSR(ByVal wp_VlrCtrl As DataGridView,
                                   ByVal wp_aeATUSR As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATUSR)
            Dim wl_aeATUSR(wl_nCntReg) As moe_Estructuras.eATUSR
            wl_aeATUSR = wp_aeATUSR
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eATUSR(wp_VlrCtrl,
                                   wl_aeATUSR(wl_nRow),
                                    wl_nRow)

                End With
            Next

        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATUSR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eATUSR(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eATUSR As Object,
                              ByVal wp_nRow As Integer)
        Try

            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nID").Value = wp_eATUSR.nID
                .Rows(wp_nRow).Cells("sCodUsr").Value = wp_eATUSR.sCodUsr
                .Rows(wp_nRow).Cells("sPwdUsr").Value = wp_eATUSR.sPwdUsr
                .Rows(wp_nRow).Cells("sNomUsr").Value = wp_eATUSR.sNomUsr
                .Rows(wp_nRow).Cells("sTipUsr").Value = wp_eATUSR.sTipUsr
                .Rows(wp_nRow).Cells("sEmlUsr").Value = wp_eATUSR.sEmlUsr
                .Rows(wp_nRow).Cells("sTel1Usr").Value = wp_eATUSR.sTel1Usr
                .Rows(wp_nRow).Cells("sTel2Usr").Value = wp_eATUSR.sTel2Usr
                .Rows(wp_nRow).Cells("bUsrBlq").Value = wp_eATUSR.bUsrBlq
                .Rows(wp_nRow).Cells("bRegAci").Value = wp_eATUSR.bRegAci
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATUSR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eATUSR(ByRef wp_eATUSR As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATUSR As New moe_Estructuras.eATUSR
            With wl_eATUSR
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value
                .sPwdUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sPwdUsr").Value
                .sNomUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomUsr").Value
                .sTipUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipUsr").Value
                .sEmlUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sEmlUsr").Value
                .sTel1Usr = wp_VlrCtrl.Rows(wp_nRow).Cells("sTel1Usr").Value
                .sTel2Usr = wp_VlrCtrl.Rows(wp_nRow).Cells("sTel2Usr").Value
                .bUsrBlq = wp_VlrCtrl.Rows(wp_nRow).Cells("bUsrBlq").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATUSR = wl_eATUSR

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eATUSR")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATTIA"
    Public Sub moo_aeATTIA_DT(ByRef wp_aeATTIA As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATTIA As New moe_Estructuras.eATTIA
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wa_aeATTIA(wl_nCntReg) As moe_Estructuras.eATTIA
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wa_aeATTIA(wl_nRow) = New moe_Estructuras.eATTIA
                wl_eATTIA = New moe_Estructuras.eATTIA
                moo_eATTIA_DT(wl_eATTIA,
                              wp_DT,
                              wl_nRow)
                wa_aeATTIA(wl_nRow) = wl_eATTIA
            Next
            wp_aeATTIA = wa_aeATTIA
        Catch ex As Exception
            MsgBox("Error : moo_aeATTIA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATTIA_DT(ByRef wp_aATTIA As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATTIA As New moe_Estructuras.eATTIA
            With wl_eATTIA
                .sCodTipAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTipAna")), wp_DT.Rows(wp_nRow).Item("sCodTipAna"), "")
                .sNomTipAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTipAna")), wp_DT.Rows(wp_nRow).Item("sNomTipAna"), "")
            End With
            wp_aATTIA = wl_eATTIA
        Catch ex As Exception
            MsgBox("Error : moo_eATTIA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "ATTIN"
    Public Sub moo_aeATTIN_DT(ByRef wp_aeATTIN As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATTIN As New moe_Estructuras.eATTIN
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wa_aeATTIN(wl_nCntReg) As moe_Estructuras.eATTIN
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wa_aeATTIN(wl_nRow) = New moe_Estructuras.eATTIN
                wl_eATTIN = New moe_Estructuras.eATTIN
                moo_eATTIN_DT(wl_eATTIN,
                              wp_DT,
                              wl_nRow)
                wa_aeATTIN(wl_nRow) = wl_eATTIN
            Next
            wp_aeATTIN = wa_aeATTIN
        Catch ex As Exception
            MsgBox("Error : moo_aeATTIN_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATTIN_DT(ByRef wp_aATTIN As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATTIN As New moe_Estructuras.eATTIN
            With wl_eATTIN
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
                .sNomTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTra")), wp_DT.Rows(wp_nRow).Item("sNomTra"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), "")

            End With
            wp_aATTIN = wl_eATTIN
        Catch ex As Exception
            MsgBox("Error : moo_eATTIN_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATTIN(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATTIN As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATTIN)
            Dim wa_aeATTIN(wl_nCntReg) As moe_Estructuras.eATTIN
            wa_aeATTIN = wp_aeATTIN
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wa_aeATTIN(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodTra").Value = wa_aeATTIN(wl_nRow).sCodTra
                    .Rows(wl_nRow).Cells("sNomTra").Value = wa_aeATTIN(wl_nRow).sNomTra
                    .Rows(wl_nRow).Cells("sTipMov").Value = wa_aeATTIN(wl_nRow).sTipMov
                    .Rows(wl_nRow).Cells("bRegAci").Value = wa_aeATTIN(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATTIN")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATTIN_DGV(ByRef wp_eATTIN As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATTIN As New moe_Estructuras.eATTIN
            With wl_eATTIN
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodTra = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTra").Value
                .sNomTra = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTra").Value
                .sTipMov = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipMov").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATTIN = wl_eATTIN
        Catch ex As Exception
            MsgBox("Error : moo_eATTIN_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ATVEN"
    Public Sub moo_aeATVEN_DT(ByRef wp_aeATVEN As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATVEN As New moe_Estructuras.eATVEN
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeATVEN(wl_nCntReg) As moe_Estructuras.eATVEN
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeATVEN(wl_nRow) = New moe_Estructuras.eATVEN
                wl_eATVEN = New moe_Estructuras.eATVEN
                moo_eATVEN_DT(wl_eATVEN,
                              wp_DT,
                              wl_nRow)
                va_aeATVEN(wl_nRow) = wl_eATVEN
            Next
            wp_aeATVEN = va_aeATVEN
        Catch ex As Exception
            MsgBox("Error : moo_aeATVEN_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATVEN_DT(ByRef wp_aATVEN As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATVEN As New moe_Estructuras.eATVEN
            With wl_eATVEN
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodVen")), wp_DT.Rows(wp_nRow).Item("sCodVen"), "")
                .sNomVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomVen")), wp_DT.Rows(wp_nRow).Item("sNomVen"), "")
                .sCodZon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodZon")), wp_DT.Rows(wp_nRow).Item("sCodZon"), "")
                .sTipVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipVen")), wp_DT.Rows(wp_nRow).Item("sTipVen"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_aATVEN = wl_eATVEN
        Catch ex As Exception
            MsgBox("Error : moo_eATVEN_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATVEN(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATVEN As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATVEN)
            Dim va_aeATVEN(wl_nCntReg) As moe_Estructuras.eATVEN
            va_aeATVEN = wp_aeATVEN
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aeATVEN(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodVen").Value = va_aeATVEN(wl_nRow).sCodVen
                    .Rows(wl_nRow).Cells("sNomVen").Value = va_aeATVEN(wl_nRow).sNomVen
                    .Rows(wl_nRow).Cells("sCodZon").Value = va_aeATVEN(wl_nRow).sCodZon
                    .Rows(wl_nRow).Cells("sTipVen").Value = va_aeATVEN(wl_nRow).sTipVen
                    .Rows(wl_nRow).Cells("bRegAci").Value = va_aeATVEN(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATVEN")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATVEN_DGV(ByRef wp_eATVEN As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eATVEN As New moe_Estructuras.eATVEN
            With va_eATVEN
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodVen = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodVen").Value
                .sNomVen = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomVen").Value
                .sCodZon = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodZon").Value
                .sTipVen = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipVen").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value

            End With
            wp_eATVEN = va_eATVEN
        Catch ex As Exception
            MsgBox("Error : moo_eATVEN_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DgvGLMOV1_eATVEN(ByRef wp_eATVEN As Object,
                                        ByVal wp_VlrCtrl As DataGridView,
                                        ByRef wp_nRow As Long)
        Try

            Dim wl_eATVEN As New moe_Estructuras.eATVEN
            wl_eATVEN = wp_eATVEN
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodVen").Value = wl_eATVEN.sCodVen
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DgvGLMOV1_eATVEN")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ATZON"
    Public Sub moo_aeATZON_DT(ByRef wp_aeATZON As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eATZON As New moe_Estructuras.eATZON
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeATZON(wl_nCntReg) As moe_Estructuras.eATZON
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeATZON(wl_nRow) = New moe_Estructuras.eATZON
                wl_eATZON = New moe_Estructuras.eATZON
                moo_eATZON_DT(wl_eATZON,
                              wp_DT,
                              wl_nRow)
                wl_aeATZON(wl_nRow) = wl_eATZON
            Next
            wp_aeATZON = wl_aeATZON
        Catch ex As Exception
            MsgBox("Error : moo_aeATZON_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATZON_DT(ByRef wp_eATZON As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eATZON As New moe_Estructuras.eATZON
            With wl_eATZON
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodZon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodZon")), wp_DT.Rows(wp_nRow).Item("sCodZon"), "")
                .sNomZon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomZon")), wp_DT.Rows(wp_nRow).Item("sNomZon"), "")
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
            End With
            wp_eATZON = wl_eATZON
        Catch ex As Exception
            MsgBox("Error : moo_eATZON_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeATZON(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeATZON As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeATZON)
            Dim wl_aeATZON(wl_nCntReg) As moe_Estructuras.eATZON
            wl_aeATZON = wp_aeATZON
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wl_aeATZON(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodZon").Value = wl_aeATZON(wl_nRow).sCodZon
                    .Rows(wl_nRow).Cells("sNomZon").Value = wl_aeATZON(wl_nRow).sNomZon
                    .Rows(wl_nRow).Cells("bRegAci").Value = wl_aeATZON(wl_nRow).bRegAci
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeATZON")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eATZON_DGV(ByRef wp_eATZON As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eATZON As New moe_Estructuras.eATZON
            With wl_eATZON
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodZon = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodZon").Value
                .sNomZon = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomZon").Value
                .bRegAci = wp_VlrCtrl.Rows(wp_nRow).Cells("bRegAci").Value
            End With
            wp_eATZON = wl_eATZON
        Catch ex As Exception
            MsgBox("Error : moo_eATZON_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "FECTT"
    Public Sub moo_eFECTT_eGEMOV(ByRef wp_eFECTT As Object,
                                 ByVal wp_eGEMOV As Object,
                                 ByVal wp_eFEMOC As Object)
        Try
            Dim wl_eFECTT As New moe_Estructuras.eFECTT
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            Dim vl_eFEMOC As New moe_Estructuras.eFEMOC
            wl_eFECTT = wp_eFECTT
            wl_eGEMOV = wp_eGEMOV
            vl_eFEMOC = wp_eFEMOC
            With wl_eFECTT
                .sCodDocCtb = vl_eFEMOC.sCodDocCtb
                .sCodSer = vl_eFEMOC.sCodSer
                .sCodTra = vl_eFEMOC.sCodTra
                .dFecCtb = wl_eGEMOV.dFecCtb
                .dFecDoc = wl_eGEMOV.dFecDoc
                .dFecVto = wl_eGEMOV.dFecVto
                .dFecSys = Date.Today
                .sCodDocBas = wl_eGEMOV.sCodDoc
                .nNroDocBas = wl_eGEMOV.nNroDoc
                .nTotDeb = wl_eFECTT.nTotDeb
                .nTotCre = wl_eFECTT.nTotCre
            End With

        Catch ex As Exception
            MsgBox("Error : moo_eFECTT_eGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub moo_eFLCTT1_eGLMOV1(ByRef wp_eFLCTT1 As Object,
                                   ByVal wp_eGEMOV As Object,
                                   ByVal wp_eGLMOV1 As Object,
                                   ByVal wp_eFEMOC As Object,
                                   ByVal wp_eFLMOC1 As Object)

        Try
            Dim wl_eFLCTT1 As New moe_Estructuras.eFLCTT1
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
            Dim vl_eFEMOC As New moe_Estructuras.eFEMOC
            Dim vl_eFLMOC1 As New moe_Estructuras.eFLMOC1
            wl_eFLCTT1 = wp_eFLCTT1
            wl_eGLMOV1 = wp_eGLMOV1
            vl_eFEMOC = wp_eFEMOC
            vl_eFLMOC1 = wp_eFLMOC1
            With wl_eFLCTT1
                .sCodDocCtb = vl_eFEMOC.sCodDocCtb
                .sCodSer = vl_eFEMOC.sCodSer
                .sCodTra = vl_eFEMOC.sCodTra
                .sCodCta = wl_eGLMOV1.sCodCta
                .sCodTer = wl_eGEMOV.sCodTer
                .sNitTer = wl_eGEMOV.sNitTer
                .sNomTer = wl_eGEMOV.sNomTer
                If vl_eFLMOC1.sDeb = "s" Then
                    .nVlrDeb = wl_eGLMOV1.nTotLin
                End If
                If vl_eFLMOC1.sCre = "s" Then
                    .nVlrCre = wl_eGLMOV1.nTotLin
                End If
                .sCodDocBas = wl_eGLMOV1.sCodDoc
                .nNroDocBas = wl_eGLMOV1.nNroDoc


                .nTasCamUsd = wl_eGLMOV1.nTasCamUsd
                .nVlrBasUsd = wl_eGLMOV1.nVlrBasUsd
            End With

        Catch ex As Exception
            MsgBox("Error : moo_eFLCTT1_eGLMOV1")
            MsgBox(ex.Message)

        End Try
    End Sub

#End Region
#Region "FTPUC"
    Public Sub moo_aeFTPUC_DT(ByRef wp_aeFTPUC As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eFTPUC As New moe_Estructuras.eFTPUC
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeFTPUC(wl_nCntReg) As moe_Estructuras.eFTPUC
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeFTPUC(wl_nRow) = New moe_Estructuras.eFTPUC
                wl_eFTPUC = New moe_Estructuras.eFTPUC
                moo_eFTPUC_DT(wl_eFTPUC,
                              wp_DT,
                              wl_nRow)
                va_aeFTPUC(wl_nRow) = wl_eFTPUC
            Next
            wp_aeFTPUC = va_aeFTPUC
        Catch ex As Exception
            MsgBox("Error : moo_aeFTPUC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eFTPUC_DT(ByRef wp_aFTPUC As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eFTPUC As New moe_Estructuras.eFTPUC
            With wl_eFTPUC
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .sNomCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCta")), wp_DT.Rows(wp_nRow).Item("sNomCta"), "")
            End With
            wp_aFTPUC = wl_eFTPUC
        Catch ex As Exception
            MsgBox("Error : moo_eFTPUC_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeFTPUC(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeFTPUC As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeFTPUC)
            Dim va_aeFTPUC(wl_nCntReg) As moe_Estructuras.eFTPUC
            va_aeFTPUC = wp_aeFTPUC
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aeFTPUC(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodCta").Value = va_aeFTPUC(wl_nRow).sCodCta
                    .Rows(wl_nRow).Cells("sNomCta").Value = va_aeFTPUC(wl_nRow).sNomCta
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eFTPUC_DGV(ByRef wp_eFTPUC As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eFTPUC As New moe_Estructuras.eFTPUC
            With va_eFTPUC
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodCta = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCta").Value
                .sNomCta = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCta").Value
            End With
            wp_eFTPUC = va_eFTPUC
        Catch ex As Exception
            MsgBox("Error : moo_eFTPUC_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DgvGLMOV1_eFTPUC(ByRef wp_eFTPUC As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Long)
        Try

            Dim wl_eFTPUC As New moe_Estructuras.eFTPUC
            wl_eFTPUC = wp_eFTPUC
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodCta").Value = wl_eFTPUC.sCodCta
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DgvGLMOV1_eFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "HEDMT"
    Public Sub moo_aeHEDMT_DT(ByRef wp_aeHEDMT As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eHEDMT As New moe_Estructuras.eHEDMT
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeHEDMT(wl_nCntReg) As moe_Estructuras.eHEDMT
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeHEDMT(wl_nRow) = New moe_Estructuras.eHEDMT
                wl_eHEDMT = New moe_Estructuras.eHEDMT
                moo_eHEDMT_DT(wl_eHEDMT,
                              wp_DT,
                              wl_nRow)
                va_aeHEDMT(wl_nRow) = wl_eHEDMT
            Next
            wp_aeHEDMT = va_aeHEDMT
        Catch ex As Exception
            MsgBox("Error : moo_aeHEDMT_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eHEDMT_DT(ByRef wp_eHEDMT As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eHEDMT As New moe_Estructuras.eHEDMT
            With wl_eHEDMT
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
                .sTipTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipTer")), wp_DT.Rows(wp_nRow).Item("sTipTer"), "")
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "")
                .sDigVer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDigVer")), wp_DT.Rows(wp_nRow).Item("sDigVer"), "")
                .sDirTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDirTer")), wp_DT.Rows(wp_nRow).Item("sDirTer"), "")
                .sTel1Ter = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel1Ter")), wp_DT.Rows(wp_nRow).Item("sTel1Ter"), "")
                .sTel2Ter = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel2Ter")), wp_DT.Rows(wp_nRow).Item("sTel2Ter"), "")
                .sTelCll = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTelCll")), wp_DT.Rows(wp_nRow).Item("sTelCll"), "")
                .sFax = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sFax")), wp_DT.Rows(wp_nRow).Item("sFax"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
                .sCodGrpTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrpTer")), wp_DT.Rows(wp_nRow).Item("sCodGrpTer"), "")
                .sEmlTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEmlTer")), wp_DT.Rows(wp_nRow).Item("sEmlTer"), "")
                .sNomCtc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCtc")), wp_DT.Rows(wp_nRow).Item("sNomCtc"), "")
                .sTipCtaCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCtaCtb")), wp_DT.Rows(wp_nRow).Item("sTipCtaCtb"), "")
                .sCodCtaCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtaCtb")), wp_DT.Rows(wp_nRow).Item("sCodCtaCtb"), "")
                .sCndPag = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCndPag")), wp_DT.Rows(wp_nRow).Item("sCndPag"), "")
                .sCodLstPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodLstPre")), wp_DT.Rows(wp_nRow).Item("sCodLstPre"), "")
                .nPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorDto")), wp_DT.Rows(wp_nRow).Item("nPorDto"), 0)
                .nLmtCre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLmtCre")), wp_DT.Rows(wp_nRow).Item("nLmtCre"), 0)
                .bAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bAct")), wp_DT.Rows(wp_nRow).Item("bAct"), False)
                .bIna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIna")), wp_DT.Rows(wp_nRow).Item("bIna"), False)
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
            End With
            wp_eHEDMT = wl_eHEDMT
        Catch ex As Exception
            MsgBox("Error : moo_eHEDMT_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeHEDMT(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeHEDMT As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeHEDMT)
            Dim va_aeHEDMT(wl_nCntReg) As moe_Estructuras.eHEDMT
            va_aeHEDMT = wp_aeHEDMT
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()

                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aeHEDMT(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodTer").Value = va_aeHEDMT(wl_nRow).sCodTer
                    .Rows(wl_nRow).Cells("sNomTer").Value = va_aeHEDMT(wl_nRow).sNomTer
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeHEDMT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eHEDMT_DGV(ByRef wp_eHEDMT As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eHEDMT As New moe_Estructuras.eHEDMT
            With va_eHEDMT
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value
                .sNomTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTer").Value

            End With
            wp_eHEDMT = va_eHEDMT
        Catch ex As Exception
            MsgBox("Error : moo_eTEDMT_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "IEDMI"
    Public Sub moo_eIEDMI_DGV(ByRef wp_eIEDMI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eIEDMI As New moe_Estructuras.eIEDMI
            With va_eIEDMI
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, 0)
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .sCodBar = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodBar").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodBar").Value, "")
                .sNomItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value, "")
                .sNomAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value, "")
                .sClsItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sClsItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sClsItm").Value, "")
                .sCodGrp = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value, "")
                .sCodSgr = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSgr").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSgr").Value, "")
                .bItmInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmInv").Value, False)
                .bItmVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmVta").Value, False)
                .bItmCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmCom").Value, False)
                .bIndIVA = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndIVA").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndIVA").Value, False)
                .sCodAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlt").Value, "")
                .sTipGes = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sTipGes").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sTipGes").Value, "")
                .bItmAct = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value, False)
                .bItmIna = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmIna").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmIna").Value, False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerPrv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerPrv").Value, "")
                .sCodTerFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerFte").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerFte").Value, "")
                .sCodItmFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItmFte").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItmFte").Value, "")
                .sUniMedCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedCom").Value, "")
                .nCanUniCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniCom").Value, 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpCom").Value, "")
                .nCanUniECom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniECom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniECom").Value, 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoCom").Value, "")
                .sUniMedVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedVta").Value, "")
                .nCanUniVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniVta").Value, 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpVta").Value, "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniEVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniEVta").Value, 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoVta").Value, "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCriCtaCbe").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCriCtaCbe").Value, "")
                .sUniMedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value, "")
                .sMetVlz = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sMetVlz").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sMetVlz").Value, "")
                .nCosItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCosItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCosItm").Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value, "")
                .nSdoInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoInv").Value, 0)
                .sIvaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaCom").Value, "")
                .sIvaVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaVta").Value, "")
                .sCodCco = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCco").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCco").Value, "")
                .sUbiAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUbiAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUbiAlm").Value, "")
                .bIndCan = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCan").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCan").Value, False)
                .bIndCos = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCos").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCos").Value, False)
                .bIndLibODP = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndLibODP").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndLibODP").Value, False)
                .nUltPreEnt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreEnt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreEnt").Value, 0)
                .sCodAlmCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCom").Value, "")
                .sCodGrpVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrpVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrpVta").Value, "")
                .bIndCanRes = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanRes").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanRes").Value, False)
                .bIndCanPry = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanPry").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanPry").Value, False)
                .nSdoIni = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIni").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIni").Value, "")
                .nSdoIniAno = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAno").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAno").Value, "")
                .nCanResODP = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODP").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODP").Value, "")
                .nSdoFinDis = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDis").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDis").Value, "")
                .nCanPedODC = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanPedODC").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanPedODC").Value, "")
                .nSdoFinPry = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinPry").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinPry").Value, "")
                .nLeadTime = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nLeadTime").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nLeadTime").Value, "")
            End With
            wp_eIEDMI = va_eIEDMI
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMIR_DGV(ByRef wp_eIEDMI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eIEDMI As New moe_Estructuras.eIEDMI
            With va_eIEDMI
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, 0)
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .sNomItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value, "")
                .sNomAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value, "")
            End With
            wp_eIEDMI = va_eIEDMI
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMIR_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIEDMI(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeIEDMI As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIEDMI)
            Dim wl_aeIEDMI(wl_nCntReg) As moe_Estructuras.eIEDMI
            wl_aeIEDMI = wp_aeIEDMI
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eIEDMI(wp_VlrCtrl,
                                   wl_aeIEDMI(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eIEDMI(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eIEDMI As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eIEDMI.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eIEDMI.sCodItm
                .Rows(wp_nRow).Cells("sCodBar").Value = wp_eIEDMI.sCodBar
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eIEDMI.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = wp_eIEDMI.sNomAlt
                .Rows(wp_nRow).Cells("sClsItm").Value = wp_eIEDMI.sClsItm
                .Rows(wp_nRow).Cells("sCodGrp").Value = wp_eIEDMI.sCodGrp
                .Rows(wp_nRow).Cells("sCodSgr").Value = wp_eIEDMI.sCodSgr
                .Rows(wp_nRow).Cells("bItmInv").Value = wp_eIEDMI.bItmInv
                .Rows(wp_nRow).Cells("bItmVta").Value = wp_eIEDMI.bItmVta
                .Rows(wp_nRow).Cells("bItmCom").Value = wp_eIEDMI.bItmCom
                .Rows(wp_nRow).Cells("bIndIVA").Value = wp_eIEDMI.bIndIVA
                .Rows(wp_nRow).Cells("sCodAlt").Value = wp_eIEDMI.sCodAlt
                .Rows(wp_nRow).Cells("sTipGes").Value = wp_eIEDMI.sTipGes
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_eIEDMI.bItmAct
                .Rows(wp_nRow).Cells("bItmIna").Value = wp_eIEDMI.bItmIna
                .Rows(wp_nRow).Cells("sCodTerPrv").Value = wp_eIEDMI.sCodTerPrv
                .Rows(wp_nRow).Cells("sCodTerFte").Value = wp_eIEDMI.sCodTerFte
                .Rows(wp_nRow).Cells("sCodItmFte").Value = wp_eIEDMI.sCodItmFte
                .Rows(wp_nRow).Cells("sUniMedCom").Value = wp_eIEDMI.sUniMedCom
                .Rows(wp_nRow).Cells("nCanUniCom").Value = wp_eIEDMI.nCanUniCom
                .Rows(wp_nRow).Cells("sUniEmpCom").Value = wp_eIEDMI.sUniEmpCom
                .Rows(wp_nRow).Cells("nCanUniECom").Value = wp_eIEDMI.nCanUniECom
                .Rows(wp_nRow).Cells("sCodItoCom").Value = wp_eIEDMI.sCodItoCom
                .Rows(wp_nRow).Cells("sUniMedVta").Value = wp_eIEDMI.sUniMedVta
                .Rows(wp_nRow).Cells("nCanUniVta").Value = wp_eIEDMI.nCanUniVta
                .Rows(wp_nRow).Cells("sUniEmpVta").Value = wp_eIEDMI.sUniEmpVta
                .Rows(wp_nRow).Cells("nCanUniEVta").Value = wp_eIEDMI.nCanUniEVta
                .Rows(wp_nRow).Cells("sCodItoVta").Value = wp_eIEDMI.sCodItoVta
                .Rows(wp_nRow).Cells("sCriCtaCbe").Value = wp_eIEDMI.sCriCtaCbe
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_eIEDMI.sUniMedInv
                .Rows(wp_nRow).Cells("sMetVlz").Value = wp_eIEDMI.sMetVlz
                .Rows(wp_nRow).Cells("nCosItm").Value = wp_eIEDMI.nCosItm
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_eIEDMI.sCodAlm
                .Rows(wp_nRow).Cells("nSdoInv").Value = wp_eIEDMI.nSdoInv
                .Rows(wp_nRow).Cells("sIvaCom").Value = wp_eIEDMI.sIvaCom
                .Rows(wp_nRow).Cells("sIvaVta").Value = wp_eIEDMI.sIvaVta
                .Rows(wp_nRow).Cells("sCodCco").Value = wp_eIEDMI.sCodCco
                .Rows(wp_nRow).Cells("sUbiAlm").Value = wp_eIEDMI.sUbiAlm
                .Rows(wp_nRow).Cells("bIndCan").Value = wp_eIEDMI.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wp_eIEDMI.bIndCos
                .Rows(wp_nRow).Cells("bIndLIBODP").Value = wp_eIEDMI.bIndLIBODP
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = wp_eIEDMI.nUltPreEnt
                .Rows(wp_nRow).Cells("sCodAlmCom").Value = wp_eIEDMI.sCodAlmCom
                .Rows(wp_nRow).Cells("sCodGrpVta").Value = wp_eIEDMI.sCodGrpVta
                .Rows(wp_nRow).Cells("bIndCanRes").Value = wp_eIEDMI.bIndCanRes
                .Rows(wp_nRow).Cells("bIndCanPry").Value = wp_eIEDMI.bIndCanPry
                .Rows(wp_nRow).Cells("nSdoIni").Value = wp_eIEDMI.nSdoIni
                .Rows(wp_nRow).Cells("nSdoIniAno").Value = wp_eIEDMI.nSdoIniAno
                .Rows(wp_nRow).Cells("nCanResODP").Value = wp_eIEDMI.nCanResODP
                .Rows(wp_nRow).Cells("nSdoFinDis").Value = wp_eIEDMI.nSdoFinDis
                .Rows(wp_nRow).Cells("nCanPedODC").Value = wp_eIEDMI.nCanPedODC
                .Rows(wp_nRow).Cells("nSdoFinPry").Value = wp_eIEDMI.nSdoFinPry
                .Rows(wp_nRow).Cells("nLeadTime").Value = wp_eIEDMI.nLeadTime
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIEDMI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeIEDMI_DT(ByRef wp_aeIEDMI As Object,
                             ByVal wp_DT As DataTable)
        Try

            Dim wl_nCntReg As Integer
            Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIEDMI(wl_nCntReg) As moe_Estructuras.eIEDMI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIEDMI(wl_nRow) = New moe_Estructuras.eIEDMI
                wl_eIEDMI = New moe_Estructuras.eIEDMI
                moo_eIEDMI_DT(wl_eIEDMI,
                              wp_DT,
                              wl_nRow)
                wl_aeIEDMI(wl_nRow) = wl_eIEDMI
            Next
            wp_aeIEDMI = wl_aeIEDMI


        Catch ex As Exception
            MsgBox("Error : moo_aeIEDMI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_DT(ByRef wp_eIEDMI As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
            With wl_eIEDMI
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sCodBar = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodBar")), wp_DT.Rows(wp_nRow).Item("sCodBar"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
                .sClsItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsItm")), wp_DT.Rows(wp_nRow).Item("sClsItm"), "")
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
                .sCodSgr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSgr")), wp_DT.Rows(wp_nRow).Item("sCodSgr"), "")
                .bItmInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmInv")), wp_DT.Rows(wp_nRow).Item("bItmInv"), False)
                .bItmVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmVta")), wp_DT.Rows(wp_nRow).Item("bItmVta"), False)
                .bItmCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmCom")), wp_DT.Rows(wp_nRow).Item("bItmCom"), False)
                .bIndIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndIVA")), wp_DT.Rows(wp_nRow).Item("bIndIVA"), False)
                .sCodAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlt")), wp_DT.Rows(wp_nRow).Item("sCodAlt"), "")
                .sTipGes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipGes")), wp_DT.Rows(wp_nRow).Item("sTipGes"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
                .bItmIna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmIna")), wp_DT.Rows(wp_nRow).Item("bItmIna"), False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTerPrv")), wp_DT.Rows(wp_nRow).Item("sCodTerPrv"), "")
                .sCodTerFte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTerFte")), wp_DT.Rows(wp_nRow).Item("sCodTerFte"), "")
                .sCodItmFte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItmFte")), wp_DT.Rows(wp_nRow).Item("sCodItmFte"), "")
                .sUniMedCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedCom")), wp_DT.Rows(wp_nRow).Item("sUniMedCom"), "")
                .nCanUniCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniCom")), wp_DT.Rows(wp_nRow).Item("nCanUniCom"), 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniEmpCom")), wp_DT.Rows(wp_nRow).Item("sUniEmpCom"), "")
                .nCanUniECom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniECom")), wp_DT.Rows(wp_nRow).Item("nCanUniECom"), 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItoCom")), wp_DT.Rows(wp_nRow).Item("sCodItoCom"), "")
                .sUniMedVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedVta")), wp_DT.Rows(wp_nRow).Item("sUniMedVta"), "")
                .nCanUniVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniVta")), wp_DT.Rows(wp_nRow).Item("nCanUniVta"), 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniEmpVta")), wp_DT.Rows(wp_nRow).Item("sUniEmpVta"), "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniEVta")), wp_DT.Rows(wp_nRow).Item("nCanUniEVta"), 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItoVta")), wp_DT.Rows(wp_nRow).Item("sCodItoVta"), "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCriCtaCbe")), wp_DT.Rows(wp_nRow).Item("sCriCtaCbe"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .sMetVlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMetVlz")), wp_DT.Rows(wp_nRow).Item("sMetVlz"), "")
                .nCosItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosItm")), wp_DT.Rows(wp_nRow).Item("nCosItm"), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .sIvaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sIvaCom")), wp_DT.Rows(wp_nRow).Item("sIvaCom"), "")
                .sIvaVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sIvaVta")), wp_DT.Rows(wp_nRow).Item("sIvaVta"), "")
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .sUbiAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUbiAlm")), wp_DT.Rows(wp_nRow).Item("sUbiAlm"), "")
                .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
                .bIndLibODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndLibODP")), wp_DT.Rows(wp_nRow).Item("bIndLibODP"), False)
                .nUltPreEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("nUltPreEnt"), 0)
                .sCodAlmCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCom")), wp_DT.Rows(wp_nRow).Item("sCodAlmCom"), "")
                .sCodGrpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrpVta")), wp_DT.Rows(wp_nRow).Item("sCodGrpVta"), "")

                .bIndCanRes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCanRes")), wp_DT.Rows(wp_nRow).Item("bIndCanRes"), False)
                .bIndCanPry = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCanPry")), wp_DT.Rows(wp_nRow).Item("bIndCanPry"), False)
                .nSdoIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIni")), wp_DT.Rows(wp_nRow).Item("nSdoIni"), 0)
                .nSdoIniAno = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIniAno")), wp_DT.Rows(wp_nRow).Item("nSdoIniAno"), 0)
                .nCanResODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODP")), wp_DT.Rows(wp_nRow).Item("nCanResODP"), 0)
                .nSdoFinDis = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDis")), wp_DT.Rows(wp_nRow).Item("nSdoFinDis"), 0)
                .nCanPedODC = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanPedODC")), wp_DT.Rows(wp_nRow).Item("nCanPedODC"), 0)
                .nSdoFinPry = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinPry")), wp_DT.Rows(wp_nRow).Item("nSdoFinPry"), 0)
                .nLeadTime = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLeadTime")), wp_DT.Rows(wp_nRow).Item("nLeadTime"), 0)
            End With
            wp_eIEDMI = wl_eIEDMI
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DT_aeIEDMI(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wg_DTCon1 As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wg_DTCon1.Rows.Count
            ' wp_VlrCtrl.Rows.Add(wl_nCntReg)
            For wl_nRow = 0 To wl_nCntReg - 1
                wp_VlrCtrl.Rows.Add()
                wp_VlrCtrl.Rows(wl_nRow).Cells("nId").Value = wg_DTCon1.Rows(wl_nRow).Item("nId")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sCodItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodItm")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sNomItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sNomItm")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sNomAlt").Value = wg_DTCon1.Rows(wl_nRow).Item("sNomAlt")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sClsItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sClsItm")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sUniMedInv").Value = wg_DTCon1.Rows(wl_nRow).Item("sUniMedInv")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sCodGrp").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodGrp")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sCodAlm").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodAlm")
                wp_VlrCtrl.Rows(wl_nRow).Cells("nCosItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nCosItm")
            Next

        Catch ex As Exception
            MsgBox("Error : moo_DGV_DT_aeIEDMI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DT_aeIEDMIR(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wg_DTCon1 As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wg_DTCon1.Rows.Count
            ' wp_VlrCtrl.Rows.Add(wl_nCntReg)


            For wl_nRow = 0 To wl_nCntReg - 1
                wp_VlrCtrl.Rows.Add()
                wp_VlrCtrl.Rows(wl_nRow).Cells("nId").Value = wg_DTCon1.Rows(wl_nRow).Item("nId")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sCodItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodItm")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sNomItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sNomItm")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sNomAlt").Value = wg_DTCon1.Rows(wl_nRow).Item("sNomAlt")
                wp_VlrCtrl.Rows(wl_nRow).Cells("sCodAlm").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodAlm")
            Next

        Catch ex As Exception
            MsgBox("Error : moo_DGV_DT_aeIEDMI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eILDMI1_DGV(ByRef wp_eILDMI1 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_eILDMI1 As New moe_Estructuras.eILDMI1
            With wl_eILDMI1
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, "")
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value, "")
                .nCanMin = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanMin").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanMin").Value, 0)
                .nCanMax = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanMax").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanMax").Value, 0)
                .nOrdMin = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nOrdMin").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nOrdMin").Value, 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoAlm").Value, 0)
                .nPreUni = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value, 0)
                .nVlrTot = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTot").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTot").Value, 0)
                .nUltPreEnt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreEnt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreEnt").Value, 0)
                .sCtaInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaInv").Value, "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCosVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCosVta").Value, "")
                .sCtaTrs = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaTrs").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaTrs").Value, "")
                .sCtaIng = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaIng").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaIng").Value, "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevVta").Value, "")
                .sCtaGto = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaGto").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaGto").Value, "")
                .sCtaDot = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDot").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDot").Value, "")
                .sCtaDifPre = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDifPre").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDifPre").Value, "")
                .sCtaVrc = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaVrc").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaVrc").Value, "")
                .sCtaRev = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRev").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRev").Value, "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaAumInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaAumInv").Value, "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRedInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaRedInv").Value, "")
                .sCtaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaCom").Value, "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaDevCom").Value, "")
                .sCtaWIP = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaWIP").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaWIP").Value, "")
                .nSdoIniAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAlm").Value, 0)
                .nSdoIniAnoAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAnoAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAnoAlm").Value, 0)
                .nCanResODPAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODPAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODPAlm").Value, 0)
                .nSdoFinDisAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDisAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDisAlm").Value, 0)
            End With
            wp_eILDMI1 = wl_eILDMI1

        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeILDMI1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aeILDMI1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeILDMI1)
            Dim wl_aeILDMI1(wl_nCntReg) As moe_Estructuras.eILDMI1
            wl_aeILDMI1 = wp_aeILDMI1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows(wl_nRow).Cells("nId").Value = wl_aeILDMI1(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodItm").Value = wl_aeILDMI1(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodAlm").Value = wl_aeILDMI1(wl_nRow).sCodAlm
                    .Rows(wl_nRow).Cells("nCanMin").Value = wl_aeILDMI1(wl_nRow).nCanMin
                    .Rows(wl_nRow).Cells("nCanMax").Value = wl_aeILDMI1(wl_nRow).nCanMax
                    .Rows(wl_nRow).Cells("nOrdMin").Value = wl_aeILDMI1(wl_nRow).nOrdMin
                    .Rows(wl_nRow).Cells("nSdoAlm").Value = wl_aeILDMI1(wl_nRow).nSdoAlm
                    .Rows(wl_nRow).Cells("nPreUni").Value = wl_aeILDMI1(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells("nVlrTot").Value = wl_aeILDMI1(wl_nRow).nVlrTot
                    .Rows(wl_nRow).Cells("nUltPreEnt").Value = wl_aeILDMI1(wl_nRow).nUltPreEnt
                    .Rows(wl_nRow).Cells("sCtaInv").Value = wl_aeILDMI1(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells("sCtaCosVta").Value = wl_aeILDMI1(wl_nRow).sCtaCosVta
                    .Rows(wl_nRow).Cells("sCtaTrs").Value = wl_aeILDMI1(wl_nRow).sCtaTrs
                    .Rows(wl_nRow).Cells("sCtaDevVta").Value = wl_aeILDMI1(wl_nRow).sCtaIng
                    .Rows(wl_nRow).Cells("sCtaDevVta").Value = wl_aeILDMI1(wl_nRow).sCtaDevVta
                    .Rows(wl_nRow).Cells("sCtaGto").Value = wl_aeILDMI1(wl_nRow).sCtaGto
                    .Rows(wl_nRow).Cells("sCtaDot").Value = wl_aeILDMI1(wl_nRow).sCtaDot
                    .Rows(wl_nRow).Cells("sCtaDifPre").Value = wl_aeILDMI1(wl_nRow).sCtaDifPre
                    .Rows(wl_nRow).Cells("sCtaVrc").Value = wl_aeILDMI1(wl_nRow).sCtaVrc
                    .Rows(wl_nRow).Cells("sCtaRev").Value = wl_aeILDMI1(wl_nRow).sCtaRev
                    .Rows(wl_nRow).Cells("sCtaAumInv").Value = wl_aeILDMI1(wl_nRow).sCtaAumInv
                    .Rows(wl_nRow).Cells("sCtaRedInv").Value = wl_aeILDMI1(wl_nRow).sCtaRedInv
                    .Rows(wl_nRow).Cells("sCtaCom").Value = wl_aeILDMI1(wl_nRow).sCtaCom
                    .Rows(wl_nRow).Cells("sCtaDevCom").Value = wl_aeILDMI1(wl_nRow).sCtaDevCom
                    .Rows(wl_nRow).Cells("sCtaWIP").Value = wl_aeILDMI1(wl_nRow).sCtaWIP
                    .Rows(wl_nRow).Cells("nSdoIniAlm").Value = wl_aeILDMI1(wl_nRow).nSdoIniAlm
                    .Rows(wl_nRow).Cells("nSdoIniAnoAlm").Value = wl_aeILDMI1(wl_nRow).nSdoIniAnoAlm
                    .Rows(wl_nRow).Cells("nCanResODPAlm").Value = wl_aeILDMI1(wl_nRow).nCanResODPAlm
                    .Rows(wl_nRow).Cells("nSdoFinDisAlm").Value = wl_aeILDMI1(wl_nRow).nSdoFinDisAlm

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eILDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DT_eILDMI1(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), "")
                .Rows(wp_nRow).Cells("nCanMin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanMin")), wp_DT.Rows(wp_nRow).Item("nCanMin"), 0)
                .Rows(wp_nRow).Cells("nCanMax").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanMax")), wp_DT.Rows(wp_nRow).Item("nCanMax"), 0)
                .Rows(wp_nRow).Cells("nOrdMin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nOrdMin")), wp_DT.Rows(wp_nRow).Item("nOrdMin"), 0)
                .Rows(wp_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .Rows(wp_nRow).Cells("nVlrTot").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTot")), wp_DT.Rows(wp_nRow).Item("nVlrTot"), 0)
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("nUltPreEnt"), 0)
                .Rows(wp_nRow).Cells("sCtaInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaInv")), wp_DT.Rows(wp_nRow).Item("T0.sCtaInv"), "")
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("T0.sCtaCosVta"), "")
                .Rows(wp_nRow).Cells("sCtaTrs").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaTrs")), wp_DT.Rows(wp_nRow).Item("T0.sCtaTrs"), "")
                .Rows(wp_nRow).Cells("sCtaIng").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaIng")), wp_DT.Rows(wp_nRow).Item("T0.sCtaIng"), "")
                .Rows(wp_nRow).Cells("sCtaDevVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaDevVta")), wp_DT.Rows(wp_nRow).Item("T0.sCtaDevVta"), "")
                .Rows(wp_nRow).Cells("sCtaVrc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaVrc")), wp_DT.Rows(wp_nRow).Item("T0.sCtaVrc"), "")
                .Rows(wp_nRow).Cells("sCtaGto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaGto")), wp_DT.Rows(wp_nRow).Item("T0.sCtaGto"), "")
                .Rows(wp_nRow).Cells("sCtaDot").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaDot")), wp_DT.Rows(wp_nRow).Item("T0.sCtaDot"), "")
                .Rows(wp_nRow).Cells("sCtaDifPre").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaDifPre")), wp_DT.Rows(wp_nRow).Item("T0.sCtaDifPre"), "")
                .Rows(wp_nRow).Cells("sCtaRev").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaRev")), wp_DT.Rows(wp_nRow).Item("T0.sCtaRev"), "")
                .Rows(wp_nRow).Cells("sCtaAumInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaAumInv")), wp_DT.Rows(wp_nRow).Item("T0.sCtaAumInv"), "")
                .Rows(wp_nRow).Cells("sCtaRedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaRedInv")), wp_DT.Rows(wp_nRow).Item("T0.sCtaRedInv"), "")
                .Rows(wp_nRow).Cells("sCtaCom").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaCom")), wp_DT.Rows(wp_nRow).Item("T0.sCtaCom"), "")
                .Rows(wp_nRow).Cells("sCtaDevCom").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaDevCom")), wp_DT.Rows(wp_nRow).Item("T0.sCtaDevCom"), "")
                .Rows(wp_nRow).Cells("sCtaWIP").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaWIP")), wp_DT.Rows(wp_nRow).Item("T0.sCtaWIP"), "")
                .Rows(wp_nRow).Cells("nSdoIniAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIniAlm")), wp_DT.Rows(wp_nRow).Item("nSdoIniAlm"), 0)
                .Rows(wp_nRow).Cells("nSdoIniAnoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIniAnoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoIniAnoAlm"), 0)
                .Rows(wp_nRow).Cells("nCanResODPAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODPAlm")), wp_DT.Rows(wp_nRow).Item("nCanResODPAlm"), 0)
                .Rows(wp_nRow).Cells("nSdoFinDisAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm")), wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm"), 0)

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DT_eILDMI1")
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub moo_DGVILDMI1_eATALM(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eATALM As Object,
                                    ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCtaInv").Value = wp_eATALM.sCtaInv
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = wp_eATALM.sCtaCosVta
                .Rows(wp_nRow).Cells("sCtaTrs").Value = wp_eATALM.sCtaTrs
                .Rows(wp_nRow).Cells("sCtaIng").Value = wp_eATALM.sCtaIng
                .Rows(wp_nRow).Cells("sCtaDevVta").Value = wp_eATALM.sCtaDevVta
                .Rows(wp_nRow).Cells("sCtaVrc").Value = wp_eATALM.sCtaVrc
                .Rows(wp_nRow).Cells("sCtaGto").Value = wp_eATALM.sCtaGto
                .Rows(wp_nRow).Cells("sCtaDot").Value = wp_eATALM.sCtaDot
                .Rows(wp_nRow).Cells("sCtaDifPre").Value = wp_eATALM.sCtaDifPre
                .Rows(wp_nRow).Cells("sCtaRev").Value = wp_eATALM.sCtaRev
                .Rows(wp_nRow).Cells("sCtaAumInv").Value = wp_eATALM.sCtaAumInv
                .Rows(wp_nRow).Cells("sCtaRedInv").Value = wp_eATALM.sCtaRedInv
                .Rows(wp_nRow).Cells("sCtaCom").Value = wp_eATALM.sCtaCom
                .Rows(wp_nRow).Cells("sCtaDevCom").Value = wp_eATALM.sCtaDevCom
                .Rows(wp_nRow).Cells("sCtaWIP").Value = wp_eATALM.sCtaWIP
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVILDMI1_eATALM")
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub moo_DGVILDMI1_eATGRI(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eATGRI As Object,
                                    ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCtaInv").Value = wp_eATGRI.sCtaInv
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = wp_eATGRI.sCtaCosVta
                .Rows(wp_nRow).Cells("sCtaTrs").Value = wp_eATGRI.sCtaTrs
                .Rows(wp_nRow).Cells("sCtaIng").Value = wp_eATGRI.sCtaIng
                .Rows(wp_nRow).Cells("sCtaDevVta").Value = wp_eATGRI.sCtaDevVta
                .Rows(wp_nRow).Cells("sCtaVrc").Value = wp_eATGRI.sCtaVrc
                .Rows(wp_nRow).Cells("sCtaGto").Value = wp_eATGRI.sCtaGto
                .Rows(wp_nRow).Cells("sCtaDot").Value = wp_eATGRI.sCtaDot
                .Rows(wp_nRow).Cells("sCtaDifPre").Value = wp_eATGRI.sCtaDifPre
                .Rows(wp_nRow).Cells("sCtaRev").Value = wp_eATGRI.sCtaRev
                .Rows(wp_nRow).Cells("sCtaAumInv").Value = wp_eATGRI.sCtaAumInv
                .Rows(wp_nRow).Cells("sCtaRedInv").Value = wp_eATGRI.sCtaRedInv
                .Rows(wp_nRow).Cells("sCtaCom").Value = wp_eATGRI.sCtaCom
                .Rows(wp_nRow).Cells("sCtaDevCom").Value = wp_eATGRI.sCtaDevCom
                .Rows(wp_nRow).Cells("sCtaWIP").Value = wp_eATGRI.sCtaWIP
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVILDMI1_eATGRI")
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub moo_aeIELDMI1_DT(ByRef wp_aeIELDMI1 As Array,
                                ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIELDMI1(wl_nCntReg) As moe_Estructuras.eIELDMI1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIELDMI1(wl_nRow) = New moe_Estructuras.eIELDMI1
                wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
                moo_eIELDMI1_DT(wl_eIELDMI1,
                                wp_DT,
                                wl_nRow)
                wl_aeIELDMI1(wl_nRow) = wl_eIELDMI1
            Next
            wp_aeIELDMI1 = wl_aeIELDMI1
        Catch ex As Exception
            MsgBox("Error : moo_aeIELDMI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIELDMI1_DT(ByRef wp_eIELDMI1 As Object,
                               ByVal wp_DT As DataTable,
                               ByVal wp_nRow As Integer)
        Try
            Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
            With wl_eIELDMI1.eIEDMI
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sCodBar = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodBar")), wp_DT.Rows(wp_nRow).Item("sCodBar"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
                .sClsItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsItm")), wp_DT.Rows(wp_nRow).Item("sClsItm"), "")
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
                .sCodSgr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSgr")), wp_DT.Rows(wp_nRow).Item("sCodSgr"), "")
                .bItmInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmInv")), wp_DT.Rows(wp_nRow).Item("bItmInv"), False)
                .bItmVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmVta")), wp_DT.Rows(wp_nRow).Item("bItmVta"), False)
                .bItmCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmCom")), wp_DT.Rows(wp_nRow).Item("bItmCom"), False)
                .bIndIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndIVA")), wp_DT.Rows(wp_nRow).Item("bIndIVA"), False)
                .sCodAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlt")), wp_DT.Rows(wp_nRow).Item("sCodAlt"), "")
                .sTipGes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipGes")), wp_DT.Rows(wp_nRow).Item("sTipGes"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
                .bItmIna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmIna")), wp_DT.Rows(wp_nRow).Item("bItmIna"), False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTerPrv")), wp_DT.Rows(wp_nRow).Item("sCodTerPrv"), "")
                .sCodTerFte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTerFte")), wp_DT.Rows(wp_nRow).Item("sCodTerFte"), "")
                .sCodItmFte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItmFte")), wp_DT.Rows(wp_nRow).Item("sCodItmFte"), "")
                .sUniMedCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedCom")), wp_DT.Rows(wp_nRow).Item("sUniMedCom"), "")
                .nCanUniCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniCom")), wp_DT.Rows(wp_nRow).Item("nCanUniCom"), 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniEmpCom")), wp_DT.Rows(wp_nRow).Item("sUniEmpCom"), "")
                .nCanUniECom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniECom")), wp_DT.Rows(wp_nRow).Item("nCanUniECom"), 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItoCom")), wp_DT.Rows(wp_nRow).Item("sCodItoCom"), "")
                .sUniMedVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedVta")), wp_DT.Rows(wp_nRow).Item("sUniMedVta"), "")
                .nCanUniVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniVta")), wp_DT.Rows(wp_nRow).Item("nCanUniVta"), 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniEmpVta")), wp_DT.Rows(wp_nRow).Item("sUniEmpVta"), "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniEVta")), wp_DT.Rows(wp_nRow).Item("nCanUniEVta"), 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItoVta")), wp_DT.Rows(wp_nRow).Item("sCodItoVta"), "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCriCtaCbe")), wp_DT.Rows(wp_nRow).Item("sCriCtaCbe"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .sMetVlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMetVlz")), wp_DT.Rows(wp_nRow).Item("sMetVlz"), "")
                .nCosItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosItm")), wp_DT.Rows(wp_nRow).Item("nCosItm"), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), "")
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .sIvaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sIvaCom")), wp_DT.Rows(wp_nRow).Item("sIvaCom"), "")
                .sIvaVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sIvaVta")), wp_DT.Rows(wp_nRow).Item("sIvaVta"), "")
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .sUbiAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUbiAlm")), wp_DT.Rows(wp_nRow).Item("sUbiAlm"), "")
                .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
                .bIndLibODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndLibODP")), wp_DT.Rows(wp_nRow).Item("bIndLibODP"), False)
                .nUltPreEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("T0.nUltPreEnt"), 0)
                .sCodAlmCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCom")), wp_DT.Rows(wp_nRow).Item("sCodAlmCom"), "")
                .sCodGrpVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrpVta")), wp_DT.Rows(wp_nRow).Item("sCodGrpVta"), "")
                .bIndCanRes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCanRes")), wp_DT.Rows(wp_nRow).Item("bIndCanRes"), False)
                .bIndCanPry = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCanPry")), wp_DT.Rows(wp_nRow).Item("bIndCanPry"), False)
                .nSdoIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIni")), wp_DT.Rows(wp_nRow).Item("nSdoIni"), 0)
                .nSdoIniAno = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIniAno")), wp_DT.Rows(wp_nRow).Item("nSdoIniAno"), 0)
                .nCanResODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODP")), wp_DT.Rows(wp_nRow).Item("nCanResODP"), 0)
                .nSdoFinDis = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDis")), wp_DT.Rows(wp_nRow).Item("nSdoFinDis"), 0)
                .nCanPedODC = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanPedODC")), wp_DT.Rows(wp_nRow).Item("nCanPedODC"), 0)
                .nSdoFinPry = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinPry")), wp_DT.Rows(wp_nRow).Item("nSdoFinPry"), 0)
                .nLeadTime = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLeadTime")), wp_DT.Rows(wp_nRow).Item("nLeadTime"), 0)
            End With
            With wl_eIELDMI1.eILDMI1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nId")), wp_DT.Rows(wp_nRow).Item("T1.nId"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodItm")), wp_DT.Rows(wp_nRow).Item("T1.sCodItm"), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T1.sCodAlm"), "")
                .nCanMin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanMin")), wp_DT.Rows(wp_nRow).Item("nCanMin"), 0)
                .nCanMax = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanMax")), wp_DT.Rows(wp_nRow).Item("nCanMax"), 0)
                .nOrdMin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nOrdMin")), wp_DT.Rows(wp_nRow).Item("nOrdMin"), 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .nVlrTot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTot")), wp_DT.Rows(wp_nRow).Item("nVlrTot"), 0)
                .nUltPreEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("T1.nUltPreEnt"), 0)
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaInv")), wp_DT.Rows(wp_nRow).Item("sCtaInv"), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .sCtaTrs = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaTrs")), wp_DT.Rows(wp_nRow).Item("sCtaTrs"), "")
                .sCtaIng = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaIng")), wp_DT.Rows(wp_nRow).Item("sCtaIng"), "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDevVta")), wp_DT.Rows(wp_nRow).Item("sCtaDevVta"), "")
                .sCtaGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaGto")), wp_DT.Rows(wp_nRow).Item("sCtaGto"), "")
                .sCtaDot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDot")), wp_DT.Rows(wp_nRow).Item("sCtaDot"), "")
                .sCtaDifPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDifPre")), wp_DT.Rows(wp_nRow).Item("sCtaDifPre"), "")
                .sCtaVrc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaVrc")), wp_DT.Rows(wp_nRow).Item("sCtaVrc"), "")
                .sCtaRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRev")), wp_DT.Rows(wp_nRow).Item("sCtaRev"), "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaAumInv")), wp_DT.Rows(wp_nRow).Item("sCtaAumInv"), "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRedInv")), wp_DT.Rows(wp_nRow).Item("sCtaRedInv"), "")
                .sCtaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCom")), wp_DT.Rows(wp_nRow).Item("sCtaCom"), "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaDevCom")), wp_DT.Rows(wp_nRow).Item("sCtaDevCom"), "")
                .sCtaWIP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaWIP")), wp_DT.Rows(wp_nRow).Item("sCtaWIP"), "")
                .nSdoIniAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIniAlm")), wp_DT.Rows(wp_nRow).Item("nSdoIniAlm"), 0)
                .nSdoIniAnoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoIniAnoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoIniAnoAlm"), 0)
                .nCanResODPAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODPAlm")), wp_DT.Rows(wp_nRow).Item("nCanResODPAlm"), 0)
                .nSdoFinDisAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm")), wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm"), 0)
            End With
            wp_eIELDMI1 = wl_eIELDMI1
        Catch ex As Exception
            MsgBox("Error : moo_eIELDMI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DT_eIELDMI1(ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeIELDMI1(wl_nCntReg) As moe_Estructuras.eIELDMI1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeIELDMI1(wl_nRow) = New moe_Estructuras.eIELDMI1
                With va_aeIELDMI1(wl_nRow).eIEDMI
                    wp_DT.Rows(wl_nRow).Item("nId") = .nId
                    wp_DT.Rows(wl_nRow).Item("sCodItm") = .sCodItm
                    wp_DT.Rows(wl_nRow).Item("sCodBar") = .sCodBar
                    wp_DT.Rows(wl_nRow).Item("sNomItm") = .sNomItm
                    wp_DT.Rows(wl_nRow).Item("sNomAlt") = .sNomAlt
                    wp_DT.Rows(wl_nRow).Item("sClsItm") = .sClsItm
                    wp_DT.Rows(wl_nRow).Item("sCodGrp") = .sCodGrp
                    wp_DT.Rows(wl_nRow).Item("sCodSgr") = .sCodSgr
                    wp_DT.Rows(wl_nRow).Item("bItmInv") = .bItmInv
                    wp_DT.Rows(wl_nRow).Item("bItmVta") = .bItmVta
                    wp_DT.Rows(wl_nRow).Item("bItmCom") = .bItmCom
                    wp_DT.Rows(wl_nRow).Item("bIndIVA") = .bIndIVA
                    wp_DT.Rows(wl_nRow).Item("sCodAlt") = .sCodAlt
                    wp_DT.Rows(wl_nRow).Item("sTipGes") = .sTipGes
                    wp_DT.Rows(wl_nRow).Item("bItmAct") = .bItmAct
                    wp_DT.Rows(wl_nRow).Item("bItmIna") = .bItmIna
                    wp_DT.Rows(wl_nRow).Item("sCodTerPrv") = .sCodTerPrv
                    wp_DT.Rows(wl_nRow).Item("sCodTerFte") = .sCodTerFte
                    wp_DT.Rows(wl_nRow).Item("sCodItmFte") = .sCodItmFte
                    wp_DT.Rows(wl_nRow).Item("sUniMedCom") = .sUniMedCom
                    wp_DT.Rows(wl_nRow).Item("nCanUniCom") = .nCanUniCom
                    wp_DT.Rows(wl_nRow).Item("sUniEmpCom") = .sUniEmpCom
                    wp_DT.Rows(wl_nRow).Item("nCanUniECom") = .nCanUniECom
                    wp_DT.Rows(wl_nRow).Item("sCodItoCom") = .sCodItoCom
                    wp_DT.Rows(wl_nRow).Item("sUniMedVta") = .sUniMedVta
                    wp_DT.Rows(wl_nRow).Item("nCanUniVta") = .nCanUniVta
                    wp_DT.Rows(wl_nRow).Item("sUniEmpVta") = .sUniEmpVta
                    wp_DT.Rows(wl_nRow).Item("nCanUniEVta") = .nCanUniEVta
                    wp_DT.Rows(wl_nRow).Item("sCodItoVta") = .sCodItoVta
                    wp_DT.Rows(wl_nRow).Item("sCriCtaCbe") = .sCriCtaCbe
                    wp_DT.Rows(wl_nRow).Item("sUniMedInv") = .sUniMedInv
                    wp_DT.Rows(wl_nRow).Item("sMetVlz") = .sMetVlz
                    wp_DT.Rows(wl_nRow).Item("nCosItm") = .nCosItm
                    wp_DT.Rows(wl_nRow).Item("sCodAlm") = .sCodAlm
                    wp_DT.Rows(wl_nRow).Item("nSdoInv") = .nSdoInv
                    wp_DT.Rows(wl_nRow).Item("sIvaCom") = .sIvaCom
                    wp_DT.Rows(wl_nRow).Item("sIvaVta") = .sIvaVta
                    wp_DT.Rows(wl_nRow).Item("sCodCco") = .sCodCco
                    wp_DT.Rows(wl_nRow).Item("sUbiAlm") = .sUbiAlm
                    wp_DT.Rows(wl_nRow).Item("bIndLibODP") = .bIndLibODP
                    wp_DT.Rows(wl_nRow).Item("nUltPreEnt") = .nUltPreEnt
                    wp_DT.Rows(wl_nRow).Item("sCodAlmCom") = .sCodAlmCom
                    wp_DT.Rows(wl_nRow).Item("sCodGrpVta") = .sCodGrpVta
                    wp_DT.Rows(wl_nRow).Item("bIndCanRes") = .bIndCanRes
                    wp_DT.Rows(wl_nRow).Item("bIndLibODP") = .bIndCanPry
                    wp_DT.Rows(wl_nRow).Item("nSdoIni") = .nSdoIni
                    wp_DT.Rows(wl_nRow).Item("nSdoIniAno") = .nSdoIniAno
                    wp_DT.Rows(wl_nRow).Item("nCanResODP") = .nCanResODP
                    wp_DT.Rows(wl_nRow).Item("nSdoFinDis") = .nSdoFinDis
                    wp_DT.Rows(wl_nRow).Item("nCanPedODC") = .nCanPedODC
                    wp_DT.Rows(wl_nRow).Item("nSdoFinPry") = .nSdoFinPry
                    wp_DT.Rows(wl_nRow).Item("nLeadTime") = .nLeadTime
                End With
                With va_aeIELDMI1(wl_nRow).eILDMI1
                    wp_DT.Rows(wl_nRow).Item("nId") = .nId
                    wp_DT.Rows(wl_nRow).Item("sCodItm") = .sCodItm
                    wp_DT.Rows(wl_nRow).Item("sCodAlm") = .sCodAlm
                    wp_DT.Rows(wl_nRow).Item("nCanMin") = .nCanMin
                    wp_DT.Rows(wl_nRow).Item("nCanMax") = .nCanMax
                    wp_DT.Rows(wl_nRow).Item("nOrdMin") = .nOrdMin
                    wp_DT.Rows(wl_nRow).Item("nSdoAlm") = .nSdoAlm
                    wp_DT.Rows(wl_nRow).Item("nPreUni") = .nPreUni
                    wp_DT.Rows(wl_nRow).Item("nVlrTot") = .nVlrTot
                    wp_DT.Rows(wl_nRow).Item("nUltPreEnt") = .nUltPreEnt
                    wp_DT.Rows(wl_nRow).Item("sCtaInv") = .sCtaInv
                    wp_DT.Rows(wl_nRow).Item("sCtaCosVta") = .sCtaCosVta
                    wp_DT.Rows(wl_nRow).Item("sCtaTrs") = .sCtaTrs
                    wp_DT.Rows(wl_nRow).Item("sCtaIng") = .sCtaIng
                    wp_DT.Rows(wl_nRow).Item("sCtaDevVta") = .sCtaDevVta
                    wp_DT.Rows(wl_nRow).Item("sCtaDot") = .sCtaGto
                    wp_DT.Rows(wl_nRow).Item("sCtaDot") = .sCtaDot
                    wp_DT.Rows(wl_nRow).Item("sCtaDifPre") = .sCtaDifPre
                    wp_DT.Rows(wl_nRow).Item("sCtaVrc") = .sCtaVrc
                    wp_DT.Rows(wl_nRow).Item("sCtaRev") = .sCtaRev
                    wp_DT.Rows(wl_nRow).Item("sCtaAumInv") = .sCtaAumInv
                    wp_DT.Rows(wl_nRow).Item("sCtaRedInv") = .sCtaRedInv
                    wp_DT.Rows(wl_nRow).Item("sCtaCom") = .sCtaCom
                    wp_DT.Rows(wl_nRow).Item("sCtaDevCom") = .sCtaDevCom
                    wp_DT.Rows(wl_nRow).Item("sCtaWIP") = .sCtaWIP
                    wp_DT.Rows(wl_nRow).Item("nSdoIniAlm") = .nSdoIniAlm
                    wp_DT.Rows(wl_nRow).Item("nSdoIniAnoAlm") = .nSdoIniAnoAlm
                    wp_DT.Rows(wl_nRow).Item("nCanResODPAlm") = .nCanResODPAlm
                    wp_DT.Rows(wl_nRow).Item("nSdoFinDisAlm") = .nSdoFinDisAlm
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DT_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIELDMI1_DGV(ByRef wp_eIELDMI1 As Object,
                                ByVal wp_VlrCtrl As DataGridView,
                                ByRef wp_nRow As Integer)
        Try
            Dim va_eIELDMI1 As New moe_Estructuras.eIELDMI1
            With va_eIELDMI1.eIEDMI
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, 0)
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .sCodBar = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodBar").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodBar").Value, "")
                .sNomItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value, "")
                .sNomAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value, "")
                .sClsItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sClsItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sClsItm").Value, "")
                .sCodGrp = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value, "")
                .sCodSgr = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSgr").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSgr").Value, "")
                .bItmInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmInv").Value, False)
                .bItmVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmVta").Value, False)
                .bItmCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmCom").Value, False)
                .bIndIVA = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndIVA").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndIVA").Value, False)
                .sCodAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlt").Value, "")
                .sTipGes = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sTipGes").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sTipGes").Value, "")
                .bItmAct = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value, False)
                .bItmIna = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bItmIna").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bItmIna").Value, False)
                .sCodTerPrv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerPrv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerPrv").Value, "")
                .sCodTerFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerFte").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTerFte").Value, "")
                .sCodItmFte = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItmFte").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedCom").Value, "")
                .sUniMedCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedCom").Value, "")
                .nCanUniCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniCom").Value, 0)
                .sUniEmpCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpCom").Value, "")
                .nCanUniECom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniECom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniECom").Value, 0)
                .sCodItoCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoCom").Value, "")
                .sUniMedVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedVta").Value, "")
                .nCanUniVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniVta").Value, 0)
                .sUniEmpVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniEmpVta").Value, "")
                .nCanUniEVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniEVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniEVta").Value, 0)
                .sCodItoVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItoVta").Value, "")
                .sCriCtaCbe = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCriCtaCbe").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCriCtaCbe").Value, "")
                .sUniMedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value, "")
                .sMetVlz = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sMetVlz").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sMetVlz").Value, "")
                .nCosItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCosItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCosItm").Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value, "")
                .nSdoInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoInv").Value, 0)
                .sIvaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaCom").Value, "")
                .sIvaVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sIvaVta").Value, "")
                .sCodCco = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCco").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCco").Value, "")
                .sUbiAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sUbiAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sUbiAlm").Value, "")
                .bIndLibODP = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndLibODP").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndLibODP").Value, False)
                .nUltPreEnt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreEnt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreEnt").Value, 0)
                .sCodAlmCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCom").Value, "")
                .sCodGrpVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrpVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrpVta").Value, "")

                .bIndCanRes = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanRes").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanRes").Value, False)
                .bIndCanPry = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanPry").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCanPry").Value, False)
                .nSdoIni = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIni").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIni").Value, 0)
                .nSdoIniAno = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAno").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAno").Value, 0)
                .nCanResODP = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODP").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODP").Value, 0)
                .nSdoFinDis = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDis").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDis").Value, 0)
                .nCanPedODC = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanPedODC").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanPedODC").Value, 0)
                .nSdoFinPry = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinPry").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinPry").Value, 0)
                .nLeadTime = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nLeadTime").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nLeadTime").Value, 0)

            End With
            With va_eIELDMI1.eILDMI1
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnId").Value, "")
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCodItm").Value, "")
                .sCodAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCodAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCodAlm").Value, "")
                .nCanMin = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnCanMin").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnCanMin").Value, 0)
                .nCanMax = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnCanMax").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnCanMax").Value, 0)
                .nOrdMin = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnOrdMin").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnOrdMin").Value, 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnSdoAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnSdoAlm").Value, 0)
                .nPreUni = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnPreUni").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnPreUni").Value, 0)
                .nVlrTot = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnVlrTot").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnVlrTot").Value, 0)
                .nUltPreEnt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xnUltPreEnt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xnUltPreEnt").Value, 0)
                .sCtaInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaInv").Value, "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaCosVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaCosVta").Value, "")
                .sCtaTrs = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaTrs").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaTrs").Value, "")
                .sCtaIng = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaIng").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaIng").Value, "")
                .sCtaDevVta = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDevVta").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDevVta").Value, "")
                .sCtaGto = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaGto").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaGto").Value, "")
                .sCtaDot = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDot").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDot").Value, "")
                .sCtaDifPre = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDifPre").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDifPre").Value, "")
                .sCtaVrc = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaVrc").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaVrc").Value, "")
                .sCtaRev = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaRev").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaRev").Value, "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaAumInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaAumInv").Value, "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaRedInv").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaRedInv").Value, "")
                .sCtaCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaCom").Value, "")
                .sCtaDevCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDevCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaDevCom").Value, "")
                .sCtaWIP = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaWIP").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("xsCtaWIP").Value, "")
                .nSdoIniAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAlm").Value, 0)
                .nSdoIniAnoAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAnoAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoIniAnoAlm").Value, 0)
                .nCanResODPAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODPAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODPAlm").Value, 0)
                .nSdoFinDisAlm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDisAlm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDisAlm").Value, 0)

            End With
            wp_eIELDMI1 = va_eIELDMI1
        Catch ex As Exception
            MsgBox("Error : moo_eIELDMI1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIELDMI1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_aeIELDMI1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIELDMI1)
            ' Dim vl_eIELDMI1 As moe_Estructuras.eIELDMI1
            'Dim vl_aeIELDMI1(wl_nCntReg) As moe_Estructuras.eIELDMI1
            ' vl_aeIELDMI1 = wp_aeIELDMI1
            With wp_VlrCtrl
                For wl_nRow = 0 To wl_nCntReg
                    .Rows.Add()
                    '  vl_eIELDMI1 = vl_aeIELDMI1(wl_nRow)
                    moo_DGV_eIELDMI1(wp_VlrCtrl,
                                     wp_aeIELDMI1(wl_nRow),
                                     wl_nRow)
                Next
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIELDMI1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_eIELDMI1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_eIELDMI1 As Object,
                                ByVal wp_nRow As Integer)
        Try


            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eIELDMI1.eIEDMI.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eIELDMI1.eIEDMI.sCodItm
                .Rows(wp_nRow).Cells("sCodBar").Value = wp_eIELDMI1.eIEDMI.sCodBar
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eIELDMI1.eIEDMI.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = wp_eIELDMI1.eIEDMI.sNomAlt
                .Rows(wp_nRow).Cells("sClsItm").Value = wp_eIELDMI1.eIEDMI.sClsItm
                .Rows(wp_nRow).Cells("sCodGrp").Value = wp_eIELDMI1.eIEDMI.sCodGrp
                .Rows(wp_nRow).Cells("sCodSgr").Value = wp_eIELDMI1.eIEDMI.sCodSgr
                .Rows(wp_nRow).Cells("bItmInv").Value = wp_eIELDMI1.eIEDMI.bItmInv
                .Rows(wp_nRow).Cells("bItmVta").Value = wp_eIELDMI1.eIEDMI.bItmVta
                .Rows(wp_nRow).Cells("bIndIVA").Value = wp_eIELDMI1.eIEDMI.bItmCom
                .Rows(wp_nRow).Cells("bIndIVA").Value = wp_eIELDMI1.eIEDMI.bIndIVA
                .Rows(wp_nRow).Cells("sCodAlt").Value = wp_eIELDMI1.eIEDMI.sCodAlt
                .Rows(wp_nRow).Cells("sTipGes").Value = wp_eIELDMI1.eIEDMI.sTipGes
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_eIELDMI1.eIEDMI.bItmAct
                .Rows(wp_nRow).Cells("bItmIna").Value = wp_eIELDMI1.eIEDMI.bItmIna
                .Rows(wp_nRow).Cells("sCodTerPrv").Value = wp_eIELDMI1.eIEDMI.sCodTerPrv
                .Rows(wp_nRow).Cells("sCodTerFte").Value = wp_eIELDMI1.eIEDMI.sCodTerFte
                .Rows(wp_nRow).Cells("sCodItmFte").Value = wp_eIELDMI1.eIEDMI.sCodItmFte
                .Rows(wp_nRow).Cells("sUniMedCom").Value = wp_eIELDMI1.eIEDMI.sUniMedCom
                .Rows(wp_nRow).Cells("nCanUniCom").Value = wp_eIELDMI1.eIEDMI.nCanUniCom
                .Rows(wp_nRow).Cells("sUniEmpCom").Value = wp_eIELDMI1.eIEDMI.sUniEmpCom
                .Rows(wp_nRow).Cells("nCanUniECom").Value = wp_eIELDMI1.eIEDMI.nCanUniECom
                .Rows(wp_nRow).Cells("sCodItoCom").Value = wp_eIELDMI1.eIEDMI.sCodItoCom
                .Rows(wp_nRow).Cells("sUniMedVta").Value = wp_eIELDMI1.eIEDMI.sUniMedVta
                .Rows(wp_nRow).Cells("nCanUniVta").Value = wp_eIELDMI1.eIEDMI.nCanUniVta
                .Rows(wp_nRow).Cells("sUniEmpVta").Value = wp_eIELDMI1.eIEDMI.sUniEmpVta
                .Rows(wp_nRow).Cells("nCanUniEVta").Value = wp_eIELDMI1.eIEDMI.nCanUniEVta
                .Rows(wp_nRow).Cells("sCodItoVta").Value = wp_eIELDMI1.eIEDMI.sCodItoVta
                .Rows(wp_nRow).Cells("sCriCtaCbe").Value = wp_eIELDMI1.eIEDMI.sCriCtaCbe
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_eIELDMI1.eIEDMI.sUniMedInv
                .Rows(wp_nRow).Cells("sMetVlz").Value = wp_eIELDMI1.eIEDMI.sMetVlz
                .Rows(wp_nRow).Cells("nCosItm").Value = wp_eIELDMI1.eIEDMI.nCosItm
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_eIELDMI1.eIEDMI.sCodAlm
                .Rows(wp_nRow).Cells("nSdoInv").Value = wp_eIELDMI1.eIEDMI.nSdoInv
                .Rows(wp_nRow).Cells("sIvaCom").Value = wp_eIELDMI1.eIEDMI.sIvaCom
                .Rows(wp_nRow).Cells("sIvaVta").Value = wp_eIELDMI1.eIEDMI.sIvaVta
                .Rows(wp_nRow).Cells("sCodCco").Value = wp_eIELDMI1.eIEDMI.sCodCco
                .Rows(wp_nRow).Cells("sUbiAlm").Value = wp_eIELDMI1.eIEDMI.sUbiAlm
                .Rows(wp_nRow).Cells("bIndCan").Value = wp_eIELDMI1.eIEDMI.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wp_eIELDMI1.eIEDMI.bIndCos
                .Rows(wp_nRow).Cells("bIndLibODP").Value = wp_eIELDMI1.eIEDMI.bIndLibODP
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = wp_eIELDMI1.eIEDMI.nUltPreEnt
                .Rows(wp_nRow).Cells("sCodAlmCom").Value = wp_eIELDMI1.eIEDMI.sCodAlmCom
                .Rows(wp_nRow).Cells("sCodGrpVta").Value = wp_eIELDMI1.eIEDMI.sCodGrpVta
                .Rows(wp_nRow).Cells("bIndCanRes").Value = wp_eIELDMI1.eIEDMI.bIndCanRes
                .Rows(wp_nRow).Cells("bIndCanPry").Value = wp_eIELDMI1.eIEDMI.bIndCanPry
                .Rows(wp_nRow).Cells("nSdoIni").Value = wp_eIELDMI1.eIEDMI.nSdoIni
                .Rows(wp_nRow).Cells("nSdoIniAno").Value = wp_eIELDMI1.eIEDMI.nSdoIniAno
                .Rows(wp_nRow).Cells("nCanResODP").Value = wp_eIELDMI1.eIEDMI.nCanResODP
                .Rows(wp_nRow).Cells("nSdoFinDis").Value = wp_eIELDMI1.eIEDMI.nSdoFinDis
                .Rows(wp_nRow).Cells("nCanPedODC").Value = wp_eIELDMI1.eIEDMI.nCanPedODC
                .Rows(wp_nRow).Cells("nSdoFinPry").Value = wp_eIELDMI1.eIEDMI.nSdoFinPry
                .Rows(wp_nRow).Cells("nLeadTime").Value = wp_eIELDMI1.eIEDMI.nLeadTime


                .Rows(wp_nRow).Cells("xnId").Value = wp_eIELDMI1.eILDMI1.nId
                .Rows(wp_nRow).Cells("xsCodItm").Value = wp_eIELDMI1.eILDMI1.sCodItm
                .Rows(wp_nRow).Cells("xsCodAlm").Value = wp_eIELDMI1.eILDMI1.sCodAlm
                .Rows(wp_nRow).Cells("xnCanMin").Value = wp_eIELDMI1.eILDMI1.nCanMin
                .Rows(wp_nRow).Cells("xnCanMax").Value = wp_eIELDMI1.eILDMI1.nCanMax
                .Rows(wp_nRow).Cells("xnOrdMin").Value = wp_eIELDMI1.eILDMI1.nOrdMin
                .Rows(wp_nRow).Cells("xnSdoAlm").Value = wp_eIELDMI1.eILDMI1.nSdoAlm
                .Rows(wp_nRow).Cells("xnPreUni").Value = wp_eIELDMI1.eILDMI1.nPreUni
                .Rows(wp_nRow).Cells("xnVlrTot").Value = wp_eIELDMI1.eILDMI1.nVlrTot
                .Rows(wp_nRow).Cells("xnUltPreEnt").Value = wp_eIELDMI1.eILDMI1.nUltPreEnt
                .Rows(wp_nRow).Cells("xsCtaInv").Value = wp_eIELDMI1.eILDMI1.sCtaInv
                .Rows(wp_nRow).Cells("xsCtaCosVta").Value = wp_eIELDMI1.eILDMI1.sCtaCosVta
                .Rows(wp_nRow).Cells("xsCtaTrs").Value = wp_eIELDMI1.eILDMI1.sCtaTrs
                .Rows(wp_nRow).Cells("xsCtaIng").Value = wp_eIELDMI1.eILDMI1.sCtaIng
                .Rows(wp_nRow).Cells("xsCtaDevVta").Value = wp_eIELDMI1.eILDMI1.sCtaDevVta
                .Rows(wp_nRow).Cells("xsCtaVrc").Value = wp_eIELDMI1.eILDMI1.sCtaVrc
                .Rows(wp_nRow).Cells("xsCtaGto").Value = wp_eIELDMI1.eILDMI1.sCtaGto
                .Rows(wp_nRow).Cells("xsCtaDot").Value = wp_eIELDMI1.eILDMI1.sCtaDot
                .Rows(wp_nRow).Cells("xsCtaDifPre").Value = wp_eIELDMI1.eILDMI1.sCtaDifPre
                .Rows(wp_nRow).Cells("xsCtaRev").Value = wp_eIELDMI1.eILDMI1.sCtaRev
                .Rows(wp_nRow).Cells("xsCtaAumInv").Value = wp_eIELDMI1.eILDMI1.sCtaAumInv
                .Rows(wp_nRow).Cells("xsCtaRedInv").Value = wp_eIELDMI1.eILDMI1.sCtaRedInv
                .Rows(wp_nRow).Cells("xsCtaCom").Value = wp_eIELDMI1.eILDMI1.sCtaCom
                .Rows(wp_nRow).Cells("xsCtaDevCom").Value = wp_eIELDMI1.eILDMI1.sCtaDevCom
                .Rows(wp_nRow).Cells("xsCtaWIP").Value = wp_eIELDMI1.eILDMI1.sCtaWIP

                .Rows(wp_nRow).Cells("nSdoIniAlm").Value = wp_eIELDMI1.eIEDMI.nSdoIniAlm
                .Rows(wp_nRow).Cells("nSdoIniAnoAlm").Value = wp_eIELDMI1.eIEDMI.nSdoIniAnoAlm
                .Rows(wp_nRow).Cells("nCanResODPAlm").Value = wp_eIELDMI1.eIEDMI.nCanResODPAlm
                .Rows(wp_nRow).Cells("nSdoFinDisAlm").Value = wp_eIELDMI1.eIEDMI.nSdoFinDisAlm
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_eIELDMI1(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eIELDMI1 As Object,
                                      ByVal wp_nRow As Integer)
        Try

            Dim va_eIELDMI1 As New moe_Estructuras.eIELDMI1
            va_eIELDMI1 = wp_eIELDMI1
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodItm").Value = va_eIELDMI1.eIEDMI.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = va_eIELDMI1.eIEDMI.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = va_eIELDMI1.eIEDMI.sNomAlt
                .Rows(wp_nRow).Cells("sCodAlm").Value = va_eIELDMI1.eILDMI1.sCodAlm
                .Rows(wp_nRow).Cells("sUniMedInv").Value = va_eIELDMI1.eIEDMI.sUniMedInv
                .Rows(wp_nRow).Cells("nPreUni").Value = va_eIELDMI1.eILDMI1.nPreUni
                .Rows(wp_nRow).Cells("nSdoAlm").Value = va_eIELDMI1.eILDMI1.nSdoAlm
                .Rows(wp_nRow).Cells("nSdoInv").Value = va_eIELDMI1.eIEDMI.nSdoInv
                .Rows(wp_nRow).Cells("sCodCta").Value = va_eIELDMI1.eILDMI1.sCtaInv
                .Rows(wp_nRow).Cells("sCodCco").Value = va_eIELDMI1.eIEDMI.sCodCco
                .Rows(wp_nRow).Cells("bIndCan").Value = va_eIELDMI1.eIEDMI.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = va_eIELDMI1.eIEDMI.bIndCos

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVPLODP1_eIELDMI1(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eIELDMI1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            Dim va_eIELDMI1 As New moe_Estructuras.eIELDMI1
            va_eIELDMI1 = wp_eIELDMI1
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodCmt").Value = va_eIELDMI1.eIEDMI.sCodItm
                .Rows(wp_nRow).Cells("sNomCmt").Value = va_eIELDMI1.eIEDMI.sNomItm
                .Rows(wp_nRow).Cells("sUniMedInv").Value = va_eIELDMI1.eIEDMI.sUniMedInv
                .Rows(wp_nRow).Cells("nPreUni").Value = va_eIELDMI1.eILDMI1.nPreUni
                .Rows(wp_nRow).Cells("nSdoAlm").Value = va_eIELDMI1.eILDMI1.nSdoAlm
                .Rows(wp_nRow).Cells("nSdoInv").Value = va_eIELDMI1.eIEDMI.nSdoInv
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = va_eIELDMI1.eILDMI1.sCodAlm
                .Rows(wp_nRow).Cells("sCtaInv").Value = va_eIELDMI1.eILDMI1.sCtaInv
                .Rows(wp_nRow).Cells("bIndCan").Value = va_eIELDMI1.eIEDMI.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = va_eIELDMI1.eIEDMI.bIndCos
                .Rows(wp_nRow).Cells("bIndLibODP").Value = va_eIELDMI1.eIEDMI.bIndLibODP

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeILDMI2_DT(ByRef wp_aeILDMI2 As Array,
                                ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eILDMI2 As New moe_Estructuras.eILDMI2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeILDMI2(wl_nCntReg) As moe_Estructuras.eILDMI2

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeILDMI2(wl_nRow) = New moe_Estructuras.eILDMI2
                wl_eILDMI2 = New moe_Estructuras.eILDMI2
                moo_eILDMI2_DT(wl_eILDMI2,
                                wp_DT,
                                wl_nRow)
                wl_aeILDMI2(wl_nRow) = wl_eILDMI2
            Next
            wp_aeILDMI2 = wl_aeILDMI2
        Catch ex As Exception
            MsgBox("Error : moo_aeILDMI2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_Q1_aeILDMI2_DT(ByRef wp_Q1_aeILDMI2 As Array,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_Q1_eILDMI2 As New moe_Estructuras.Q1_eILDMI2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_Q1_aeILDMI2(wl_nCntReg) As moe_Estructuras.Q1_eILDMI2

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_Q1_aeILDMI2(wl_nRow) = New moe_Estructuras.Q1_eILDMI2
                wl_Q1_eILDMI2 = New moe_Estructuras.Q1_eILDMI2
                moo_Q1_eILDMI2_DT(wl_Q1_eILDMI2,
                                  wp_DT,
                                  wl_nRow)
                wl_Q1_aeILDMI2(wl_nRow) = wl_Q1_eILDMI2
            Next
            wp_Q1_aeILDMI2 = wl_Q1_aeILDMI2
        Catch ex As Exception
            MsgBox("Error : moo_Q1_aeILDMI2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_Q1_eILDMI2_DGV(ByRef wp_eILDMI2 As Object,
                                  ByVal wp_VlrCtrl As DataGridView,
                                  ByRef wp_nRow As Integer)
        Try
            Dim wl_Q1_eILDMI2 As New moe_Estructuras.Q1_eILDMI2
            With wl_Q1_eILDMI2
                .eILDMI2.nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, "")
                .eILDMI2.sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .eILDMI2.sCodTer = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value, "")
                .eILDMI2.sCodLstPre = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value, "")
                .eILDMI2.nUltPreCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreCom").Value, 0)
                .eILDMI2.bTerDfl = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bTerDfl").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bTerDfl").Value, False)
                .sNomItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value, "")
                .sNomAlt = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value, "")
            End With
            wp_eILDMI2 = wl_Q1_eILDMI2

        Catch ex As Exception
            MsgBox("Error : moo_Q1_eILDMI2_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_Qry_aeILDMI2_DT(ByRef wp_Qry_aeILDMI2 As Array,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_Qry_eILDMI2 As New moe_Estructuras.Qry_eILDMI2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_Qry_aeILDMI2(wl_nCntReg) As moe_Estructuras.Qry_eILDMI2

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_Qry_aeILDMI2(wl_nRow) = New moe_Estructuras.Qry_eILDMI2
                wl_Qry_eILDMI2 = New moe_Estructuras.Qry_eILDMI2
                moo_Qry_eILDMI2_DT(wl_Qry_eILDMI2,
                                   wp_DT,
                                   wl_nRow)
                wl_Qry_aeILDMI2(wl_nRow) = wl_Qry_eILDMI2
            Next
            wp_Qry_aeILDMI2 = wl_Qry_aeILDMI2
        Catch ex As Exception
            MsgBox("Error : moo_Qry_aeILDMI2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_Qry_eILDMI2_DGV(ByRef wp_eILDMI2 As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_eILDMI2Qry As New moe_Estructuras.Qry_eILDMI2
            With wl_eILDMI2Qry
                .eILDMI2.nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, "")
                .eILDMI2.sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .eILDMI2.sCodTer = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value, "")
                .eILDMI2.sCodLstPre = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value, "")
                .eILDMI2.nUltPreCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreCom").Value, 0)
                .eILDMI2.bTerDfl = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bTerDfl").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bTerDfl").Value, False)
                .sNomTer = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTer").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTer").Value, "")
            End With
            wp_eILDMI2 = wl_eILDMI2Qry

        Catch ex As Exception
            MsgBox("Error : moo_Qry_eILDMI2_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eILDMI2_DGV(ByRef wp_eILDMI2 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByRef wp_nRow As Integer)
        Try
            Dim wl_eILDMI2 As New moe_Estructuras.eILDMI2
            With wl_eILDMI2
                .nId = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value, "")
                .sCodItm = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value, "")
                .sCodTer = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value, "")
                .sCodLstPre = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value, "")
                .nUltPreCom = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreCom").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("nUltPreCom").Value, 0)
                .bTerDfl = IIf(Not IsDBNull(wp_VlrCtrl.Rows(wp_nRow).Cells("bTerDfl").Value), wp_VlrCtrl.Rows(wp_nRow).Cells("bTerDfl").Value, False)
            End With
            wp_eILDMI2 = wl_eILDMI2

        Catch ex As Exception
            MsgBox("Error : moo_eILDMI2_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeILDMI2(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeILDMI2 As Array)
        Try


            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeILDMI2)
            Dim wl_aeILDMI2(wl_nCntReg) As moe_Estructuras.eILDMI2
            wl_aeILDMI2 = wp_aeILDMI2
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wl_aeILDMI2(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodItm").Value = wl_aeILDMI2(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodTer").Value = wl_aeILDMI2(wl_nRow).sCodTer
                    .Rows(wl_nRow).Cells("sCodLstPre").Value = wl_aeILDMI2(wl_nRow).sCodLstPre
                    .Rows(wl_nRow).Cells("nUltPreCom").Value = wl_aeILDMI2(wl_nRow).nUltPreCom
                    .Rows(wl_nRow).Cells("bTerDfl").Value = wl_aeILDMI2(wl_nRow).bTerDfl
                    '  .Rows(wl_nRow).Cells(6).Value = wl_aeILDMI2(wl_nRow).sNomItm
                    ' .Rows(wl_nRow).Cells(7).Value = wl_aeILDMI2(wl_nRow).sNomAlt
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_Q1_aeILDMI2(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_Q1_aeILDMI2 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_Q1_aeILDMI2)
            Dim wl_Q1_aeILDMI2(wl_nCntReg) As moe_Estructuras.Q1_eILDMI2
            wl_Q1_aeILDMI2 = wp_Q1_aeILDMI2
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = wl_Q1_aeILDMI2(wl_nRow).eILDMI2.nId
                    .Rows(wl_nRow).Cells("sCodItm").Value = wl_Q1_aeILDMI2(wl_nRow).eILDMI2.sCodItm
                    .Rows(wl_nRow).Cells("sCodTer").Value = wl_Q1_aeILDMI2(wl_nRow).eILDMI2.sCodTer
                    .Rows(wl_nRow).Cells("sCodLstPre").Value = wl_Q1_aeILDMI2(wl_nRow).eILDMI2.sCodLstPre
                    .Rows(wl_nRow).Cells("nUltPreCom").Value = wl_Q1_aeILDMI2(wl_nRow).eILDMI2.nUltPreCom
                    .Rows(wl_nRow).Cells("bTerDfl").Value = wl_Q1_aeILDMI2(wl_nRow).eILDMI2.bTerDfl
                    .Rows(wl_nRow).Cells("sNomItm").Value = wl_Q1_aeILDMI2(wl_nRow).sNomItm
                    .Rows(wl_nRow).Cells("sNomAlt").Value = wl_Q1_aeILDMI2(wl_nRow).sNomAlt
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_Qry_aeILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_Qry_aeILDMI2(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_Qry_aeILDMI2 As Array)
        Try


            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_Qry_aeILDMI2)
            Dim wl_Qry_aeILDMI2(wl_nCntReg) As moe_Estructuras.Qry_eILDMI2
            Dim wl_Qry_eILDMI2 As moe_Estructuras.Qry_eILDMI2
            wl_Qry_aeILDMI2 = wp_Qry_aeILDMI2
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    wl_Qry_eILDMI2 = New moe_Estructuras.Qry_eILDMI2
                    wl_Qry_eILDMI2 = wl_Qry_aeILDMI2(wl_nRow)
                    moo_DGV_Qry_eILDMI2(wp_VlrCtrl,
                                        wl_Qry_eILDMI2,
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_Qry_aeILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_Qry_eILDMI2(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_Qry_eILDMI2 As Object,
                                   ByVal wp_nRow As Integer)
        Try
            Dim wl_Qry_eILDMI2 As moe_Estructuras.Qry_eILDMI2
            wl_Qry_eILDMI2 = wp_Qry_eILDMI2
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wl_Qry_eILDMI2.eILDMI2.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wl_Qry_eILDMI2.eILDMI2.sCodItm
                .Rows(wp_nRow).Cells("sCodTer").Value = wl_Qry_eILDMI2.eILDMI2.sCodTer
                .Rows(wp_nRow).Cells("sCodLstPre").Value = wl_Qry_eILDMI2.eILDMI2.sCodLstPre
                .Rows(wp_nRow).Cells("nUltPreCom").Value = wl_Qry_eILDMI2.eILDMI2.nUltPreCom
                .Rows(wp_nRow).Cells("bTerDfl").Value = wl_Qry_eILDMI2.eILDMI2.bTerDfl
                .Rows(wp_nRow).Cells("sNomTer").Value = wl_Qry_eILDMI2.sNomTer
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_Qry_eILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eILDMI2_DT(ByRef wp_eILDMI2 As Object,
                               ByVal wp_DT As DataTable,
                               ByVal wp_nRow As Integer)
        Try
            Dim wl_eILDMI2 As New moe_Estructuras.eILDMI2
            With wl_eILDMI2
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sCodLstPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodLstPre")), wp_DT.Rows(wp_nRow).Item("sCodLstPre"), "")
                .nUltPreCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreCom")), wp_DT.Rows(wp_nRow).Item("nUltPreCom"), 0)
                .bTerDfl = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bTerDfl")), wp_DT.Rows(wp_nRow).Item("bTerDfl"), False)
                '   .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(6)), wp_DT.Rows(wp_nRow).Item(6), "")
                '   .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item(7)), wp_DT.Rows(wp_nRow).Item(7), "")

            End With
            wp_eILDMI2 = wl_eILDMI2
        Catch ex As Exception
            MsgBox("Error : moo_eIELDMI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_Q1_eILDMI2_DT(ByRef wp_Q1_eILDMI2 As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim wl_Q1_eILDMI2 As New moe_Estructuras.Q1_eILDMI2
            With wl_Q1_eILDMI2
                .eILDMI2.nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .eILDMI2.sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .eILDMI2.sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .eILDMI2.sCodLstPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodLstPre")), wp_DT.Rows(wp_nRow).Item("sCodLstPre"), "")
                .eILDMI2.nUltPreCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("")), wp_DT.Rows(wp_nRow).Item(""), 0)
                .eILDMI2.bTerDfl = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreCom")), wp_DT.Rows(wp_nRow).Item("nUltPreCom"), False)
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
            End With
            wp_Q1_eILDMI2 = wl_Q1_eILDMI2
        Catch ex As Exception
            MsgBox("Error : moo_Q1_eILDMI2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_Qry_eILDMI2_DT(ByRef wp_Qry_eILDMI2 As Object,
                               ByVal wp_DT As DataTable,
                               ByVal wp_nRow As Integer)
        Try
            Dim wl_Qry_eILDMI2 As New moe_Estructuras.Qry_eILDMI2
            With wl_Qry_eILDMI2
                .eILDMI2.nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .eILDMI2.sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .eILDMI2.sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .eILDMI2.sCodLstPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodLstPre")), wp_DT.Rows(wp_nRow).Item("sCodLstPre"), "")
                .eILDMI2.nUltPreCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("")), wp_DT.Rows(wp_nRow).Item(""), 0)
                .eILDMI2.bTerDfl = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreCom")), wp_DT.Rows(wp_nRow).Item("nUltPreCom"), False)
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
            End With
            wp_Qry_eILDMI2 = wl_Qry_eILDMI2
        Catch ex As Exception
            MsgBox("Error : moo_Qry_eILDMI2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DT_eILDMI2(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)


        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodTer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .Rows(wp_nRow).Cells("sCodLstPre").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodLstPre")), wp_DT.Rows(wp_nRow).Item("sCodLstPre"), "")
                .Rows(wp_nRow).Cells("nUltPreCom").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreCom")), wp_DT.Rows(wp_nRow).Item("nUltPreCom"), 0)
                .Rows(wp_nRow).Cells("bTerDfl").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bTerDfl")), wp_DT.Rows(wp_nRow).Item("bTerDfl"), False)
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DT_eILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeIELDMI1Rpt_aeIELDMI1(ByRef wp_aeIELDMI1_Rpt As Object,
                                          ByVal wp_aeIELDMI1 As Object)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIELDMI1) - 1
            Dim wl_aeIELDMI1_Rpt() As moe_Estructuras.eIELDMI1_Rpt
            ReDim wl_aeIELDMI1_Rpt(wl_nCntReg)
            Dim wl_eIELDMI1_Rpt As New moe_Estructuras.eIELDMI1_Rpt

            For wl_nRow = 0 To wl_nCntReg
                wl_eIELDMI1_Rpt = New moe_Estructuras.eIELDMI1_Rpt
                With wl_eIELDMI1_Rpt
                    .nId = wp_aeIELDMI1(wl_nRow).eIEDMI.nId
                    .sCodItm = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodItm
                    .sCodBar = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodBar
                    .sNomItm = wp_aeIELDMI1(wl_nRow).eIEDMI.sNomItm
                    .sNomAlt = wp_aeIELDMI1(wl_nRow).eIEDMI.sNomAlt
                    .sClsItm = wp_aeIELDMI1(wl_nRow).eIEDMI.sClsItm
                    .sCodGrp = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodGrp
                    .sCodSgr = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodSgr
                    .bItmInv = wp_aeIELDMI1(wl_nRow).eIEDMI.bItmInv
                    .bItmVta = wp_aeIELDMI1(wl_nRow).eIEDMI.bItmVta
                    .bIndIVA = wp_aeIELDMI1(wl_nRow).eIEDMI.bItmCom
                    .bIndIVA = wp_aeIELDMI1(wl_nRow).eIEDMI.bIndIVA
                    .sCodAlt = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodAlt
                    .sTipGes = wp_aeIELDMI1(wl_nRow).eIEDMI.sTipGes
                    .bItmAct = wp_aeIELDMI1(wl_nRow).eIEDMI.bItmAct
                    .bItmIna = wp_aeIELDMI1(wl_nRow).eIEDMI.bItmIna
                    .sCodTerPrv = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodTerPrv
                    .sCodTerFte = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodTerFte
                    .sCodItmFte = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodItmFte
                    .sUniMedCom = wp_aeIELDMI1(wl_nRow).eIEDMI.sUniMedCom
                    .nCanUniCom = wp_aeIELDMI1(wl_nRow).eIEDMI.nCanUniCom
                    .sUniEmpCom = wp_aeIELDMI1(wl_nRow).eIEDMI.sUniEmpCom
                    .nCanUniECom = wp_aeIELDMI1(wl_nRow).eIEDMI.nCanUniECom
                    .sCodItoCom = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodItoCom
                    .sUniMedVta = wp_aeIELDMI1(wl_nRow).eIEDMI.sUniMedVta
                    .nCanUniVta = wp_aeIELDMI1(wl_nRow).eIEDMI.nCanUniVta
                    .sUniEmpVta = wp_aeIELDMI1(wl_nRow).eIEDMI.sUniEmpVta
                    .nCanUniEVta = wp_aeIELDMI1(wl_nRow).eIEDMI.nCanUniEVta
                    .sCodItoVta = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodItoVta
                    .sCriCtaCbe = wp_aeIELDMI1(wl_nRow).eIEDMI.sCriCtaCbe
                    .sUniMedInv = wp_aeIELDMI1(wl_nRow).eIEDMI.sUniMedInv
                    .sMetVlz = wp_aeIELDMI1(wl_nRow).eIEDMI.sMetVlz
                    .nCosItm = wp_aeIELDMI1(wl_nRow).eIEDMI.nCosItm
                    .sCodAlm = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodAlm
                    .nSdoInv = wp_aeIELDMI1(wl_nRow).eIEDMI.nSdoInv
                    .sIvaCom = wp_aeIELDMI1(wl_nRow).eIEDMI.sIvaCom
                    .sIvaVta = wp_aeIELDMI1(wl_nRow).eIEDMI.sIvaVta
                    .sCodCco = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodCco
                    .sUbiAlm = wp_aeIELDMI1(wl_nRow).eIEDMI.sUbiAlm
                    .bIndCan = wp_aeIELDMI1(wl_nRow).eIEDMI.bIndCan
                    .bIndCos = wp_aeIELDMI1(wl_nRow).eIEDMI.bIndCos
                    .bIndLibODP = wp_aeIELDMI1(wl_nRow).eIEDMI.bIndLibODP
                    .sCodAlmCom = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodAlmCom
                    .sCodGrpVta = wp_aeIELDMI1(wl_nRow).eIEDMI.sCodGrpVta
                    .bIndCanRes = wp_aeIELDMI1(wl_nRow).eIEDMI.bIndCanRes
                    .bIndCanPry = wp_aeIELDMI1(wl_nRow).eIEDMI.bIndCanPry
                    .nSdoIni = wp_aeIELDMI1(wl_nRow).eIEDMI.nSdoIni
                    .nSdoIniAno = wp_aeIELDMI1(wl_nRow).eIEDMI.nSdoIniAno
                    .nCanResODP = wp_aeIELDMI1(wl_nRow).eIEDMI.nCanResODP
                    .nSdoFinDis = wp_aeIELDMI1(wl_nRow).eIEDMI.nSdoFinDis
                    .nCanPedODC = wp_aeIELDMI1(wl_nRow).eIEDMI.nCanPedODC
                    .nSdoFinPry = wp_aeIELDMI1(wl_nRow).eIEDMI.nSdoFinPry
                    .nLeadTime = wp_aeIELDMI1(wl_nRow).eIEDMI.nLeadTime

                    .xnId = wp_aeIELDMI1(wl_nRow).eILDMI1.nId
                    .xsCodItm = wp_aeIELDMI1(wl_nRow).eILDMI1.sCodItm
                    .xsCodAlm = wp_aeIELDMI1(wl_nRow).eILDMI1.sCodAlm
                    .xnCanMin = wp_aeIELDMI1(wl_nRow).eILDMI1.nCanMin
                    .xnCanMax = wp_aeIELDMI1(wl_nRow).eILDMI1.nCanMax
                    .xnOrdMin = wp_aeIELDMI1(wl_nRow).eILDMI1.nOrdMin
                    .xnSdoAlm = wp_aeIELDMI1(wl_nRow).eILDMI1.nSdoAlm
                    .xnPreUni = wp_aeIELDMI1(wl_nRow).eILDMI1.nPreUni
                    .xnVlrTot = wp_aeIELDMI1(wl_nRow).eILDMI1.nVlrTot
                    .xnUltPreEnt = wp_aeIELDMI1(wl_nRow).eILDMI1.nUltPreEnt
                    .xsCtaInv = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaInv
                    .xsCtaCosVta = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaCosVta
                    .xsCtaTrs = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaTrs
                    .xsCtaIng = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaIng
                    .xsCtaDevVta = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaDevVta
                    .xsCtaVrc = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaVrc
                    .xsCtaGto = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaGto
                    .xsCtaDot = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaDot
                    .xsCtaDifPre = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaDifPre
                    .xsCtaRev = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaRev
                    .xsCtaAumInv = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaAumInv
                    .xsCtaRedInv = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaRedInv
                    .xsCtaCom = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaCom
                    .xsCtaDevCom = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaDevCom
                    .xsCtaWIP = wp_aeIELDMI1(wl_nRow).eILDMI1.sCtaWIP
                    .xnSdoIniAlm = wp_aeIELDMI1(wl_nRow).eILDMI1.nSdoIniAlm
                    .xnSdoIniAnoAlm = wp_aeIELDMI1(wl_nRow).eILDMI1.nSdoIniAnoAlm
                    .xnCanResODPAlm = wp_aeIELDMI1(wl_nRow).eILDMI1.nCanResODPAlm
                    .xnSdoFinDisAlm = wp_aeIELDMI1(wl_nRow).eILDMI1.nSdoFinDis
                End With
                wl_aeIELDMI1_Rpt(wl_nRow) = wl_eIELDMI1_Rpt
            Next
            wp_aeIELDMI1_Rpt = wl_aeIELDMI1_Rpt
        Catch ex As Exception
            MsgBox("Error : moo_aeIELDMI1Rpt_aeIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "IEDMI_QItm"
    Public Sub moo_aeIEDMI_QItm_DT(ByRef wp_aeIEDMI_QItm As Array,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eIEDMI_QItm As New moe_Estructuras.eIEDMI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIEDMI_QItm(wl_nCntReg) As moe_Estructuras.eIEDMI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIEDMI_QItm(wl_nRow) = New moe_Estructuras.eIEDMI
                wl_eIEDMI_QItm = New moe_Estructuras.eIEDMI
                moo_eIEDMI_QItm_DT(wl_eIEDMI_QItm,
                                   wp_DT,
                                   wl_nRow)
                wl_aeIEDMI_QItm(wl_nRow) = wl_eIEDMI_QItm
            Next
            wp_aeIEDMI_QItm = wl_aeIEDMI_QItm
        Catch ex As Exception
            MsgBox("Error : moo_aeIEDMI_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_QItm_DT(ByRef wp_aIEDMI_QItm As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_eIEDMI_QItm As New moe_Estructuras.eIEDMI

            With wl_eIEDMI_QItm
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
            End With
            wp_aIEDMI_QItm = wl_eIEDMI_QItm

        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIEDMI_QItm(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aeIEDMI_QItm As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIEDMI_QItm)
            Dim wl_aeIEDMI_QItm(wl_nCntReg) As moe_Estructuras.eIEDMI
            wl_aeIEDMI_QItm = wp_aeIEDMI_QItm
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eIEDMI_QItm(wp_VlrCtrl,
                                        wl_aeIEDMI_QItm(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeIEDMI_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eIEDMI_QItm(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_eIEDMI_QItm As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eIEDMI_QItm.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eIEDMI_QItm.sNomItm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIEDMI_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_QItm_DGV(ByRef wp_eIEDMI_QItm As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_eIEDMI_QItm As New moe_Estructuras.eIEDMI
            With wl_eIEDMI_QItm
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value
            End With
            wp_eIEDMI_QItm = wl_eIEDMI_QItm
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_QItm_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIEDMI_QItm_DT(ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIEDMI_QItm(wl_nCntReg) As moe_Estructuras.eIEDMI
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodItm")), wp_DT.Rows(wl_nRow).Item("sCodItm"), "")
                    .Rows(wl_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sNomItm")), wp_DT.Rows(wl_nRow).Item("sNomItm"), "")
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeIEDMI_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "IEDMI_QAlm"
    Public Sub moo_aeIEDMI_QAlm_DT(ByRef wp_aeIEDMI_QAlm As Array,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eIEDMI_QAlm As New moe_Estructuras.eIEDMI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIEDMI_QAlm(wl_nCntReg) As moe_Estructuras.eIEDMI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIEDMI_QAlm(wl_nRow) = New moe_Estructuras.eIEDMI
                wl_eIEDMI_QAlm = New moe_Estructuras.eIEDMI
                moo_eIEDMI_QAlm_DT(wl_eIEDMI_QAlm,
                                   wp_DT,
                                   wl_nRow)
                wl_aeIEDMI_QAlm(wl_nRow) = wl_eIEDMI_QAlm
            Next
            wp_aeIEDMI_QAlm = wl_aeIEDMI_QAlm
        Catch ex As Exception
            MsgBox("Error : moo_aeIEDMI_QAlm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_QAlm_DT(ByRef wp_aIEDMI_QAlm As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_eIEDMI_QAlm As New moe_Estructuras.eIEDMI

            With wl_eIEDMI_QAlm
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
            End With
            wp_aIEDMI_QAlm = wl_eIEDMI_QAlm

        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_QAlm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIEDMI_QAlm(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aeIEDMI_QAlm As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIEDMI_QAlm)
            Dim wl_aeIEDMI_QAlm(wl_nCntReg) As moe_Estructuras.eIEDMI
            wl_aeIEDMI_QAlm = wp_aeIEDMI_QAlm
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eIEDMI_QAlm(wp_VlrCtrl,
                                        wl_aeIEDMI_QAlm(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeIEDMI_QAlm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eIEDMI_QAlm(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_eIEDMI_QAlm As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_eIEDMI_QAlm.sCodAlm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIEDMI_QAlm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_QAlm_DGV(ByRef wp_eIEDMI_QAlm As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_eIEDMI_QAlm As New moe_Estructuras.eIEDMI
            With wl_eIEDMI_QAlm
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value
            End With
            wp_eIEDMI_QAlm = wl_eIEDMI_QAlm
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_QAlm_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "IEDMI_QGrp"
    Public Sub moo_aeIEDMI_QGrp_DT(ByRef wp_aeIEDMI_QGrp As Array,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eIEDMI_QGrp As New moe_Estructuras.eIEDMI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIEDMI_QGrp(wl_nCntReg) As moe_Estructuras.eIEDMI
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIEDMI_QGrp(wl_nRow) = New moe_Estructuras.eIEDMI
                wl_eIEDMI_QGrp = New moe_Estructuras.eIEDMI
                moo_eIEDMI_QGrp_DT(wl_eIEDMI_QGrp,
                                   wp_DT,
                                   wl_nRow)
                wl_aeIEDMI_QGrp(wl_nRow) = wl_eIEDMI_QGrp
            Next
            wp_aeIEDMI_QGrp = wl_aeIEDMI_QGrp
        Catch ex As Exception
            MsgBox("Error : moo_aeIEDMI_QGrp_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_QGrp_DT(ByRef wp_aIEDMI_QGrp As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_eIEDMI_QGrp As New moe_Estructuras.eIEDMI

            With wl_eIEDMI_QGrp
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
            End With
            wp_aIEDMI_QGrp = wl_eIEDMI_QGrp
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_QGrp_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIEDMI_QGrp(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aeIEDMI_QGrp As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIEDMI_QGrp)
            Dim wl_aeIEDMI_QGrp(wl_nCntReg) As moe_Estructuras.eIEDMI
            wl_aeIEDMI_QGrp = wp_aeIEDMI_QGrp
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eIEDMI_QGrp(wp_VlrCtrl,
                                        wl_aeIEDMI_QGrp(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeIEDMI_QGrp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eIEDMI_QGrp(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_eIEDMI_QGrp As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodgrp").Value = wp_eIEDMI_QGrp.sCodGrp
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIEDMI_QAlm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEDMI_QGrp_DGV(ByRef wp_eIEDMI_QGrp As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_eIEDMI_QGrp As New moe_Estructuras.eIEDMI
            With wl_eIEDMI_QGrp
                .sCodGrp = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value
            End With
            wp_eIEDMI_QGrp = wl_eIEDMI_QGrp
        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_QGrp_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "IEMOV"
    Public Sub moo_aeGEMOV_DT(ByRef wp_eaGEMOV As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_DT(wl_eGEMOV,
                              wp_DT,
                              wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_DT(ByRef wp_eGEMOV As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecCtb")), wp_DT.Rows(wp_nRow).Item("dFecCtb"), #1/1/1901#)
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecVto")), wp_DT.Rows(wp_nRow).Item("dFecVto"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
                .nPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorDto")), wp_DT.Rows(wp_nRow).Item("nPorDto"), 0)
                .sAlmOri = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sAlmOri")), wp_DT.Rows(wp_nRow).Item("sAlmOri"), "")
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .nTotBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotBas")), wp_DT.Rows(wp_nRow).Item("nTotBas"), 0)
                .nTotDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDto")), wp_DT.Rows(wp_nRow).Item("nTotDto"), 0)
                .nTotGtoAdi = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotGtoAdi")), wp_DT.Rows(wp_nRow).Item("nTotGtoAdi"), 0)
                .nTotIvaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotIvaCom")), wp_DT.Rows(wp_nRow).Item("nTotIvaCom"), 0)
                .nTotIvaVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotIvaVta")), wp_DT.Rows(wp_nRow).Item("nTotIvaVta"), 0)
                .nVlrRdd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrRdd")), wp_DT.Rows(wp_nRow).Item("nVlrRdd"), 0)
                .nTotDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDoc")), wp_DT.Rows(wp_nRow).Item("nTotDoc"), 0)
                .sCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .nNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .sCndPag = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCndPag")), wp_DT.Rows(wp_nRow).Item("sCndPag"), "")
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .sTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipDoc")), wp_DT.Rows(wp_nRow).Item("sTipDoc"), "")
                .sCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodVen")), wp_DT.Rows(wp_nRow).Item("sCodVen"), "")
                .sDirTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDirTer")), wp_DT.Rows(wp_nRow).Item("sDirTer"), "")
                .sCiuter = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCiuter")), wp_DT.Rows(wp_nRow).Item("sCiuter"), "")
                .sDepTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDepTer")), wp_DT.Rows(wp_nRow).Item("sDepTer"), "")
                .sPaiTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sPaiTer")), wp_DT.Rows(wp_nRow).Item("sPaiTer"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                .sCodCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCteCtb")), wp_DT.Rows(wp_nRow).Item("sCodCteCtb"), "")
                .nNroCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCteCtb")), wp_DT.Rows(wp_nRow).Item("nNroCteCtb"), 0)
                .nIdFECCT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdFECCT")), wp_DT.Rows(wp_nRow).Item("nIdFECCT"), 0)
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "")
                .sCodMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodMon")), wp_DT.Rows(wp_nRow).Item("sCodMon"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sCodAut = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAut")), wp_DT.Rows(wp_nRow).Item("sCodAut"), "")
                .bPrp01 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp01")), wp_DT.Rows(wp_nRow).Item("bPrp01"), False)
                .bPrp02 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp02")), wp_DT.Rows(wp_nRow).Item("bPrp02"), False)
                .bPrp03 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp03")), wp_DT.Rows(wp_nRow).Item("bPrp03"), False)
            End With


            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodDoc_DGV(ByRef wp_aGEMOV As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                      ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QCodMOv_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodSer_DGV(ByRef wp_aGEMOV As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QCodSer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodTra_DGV(ByRef wp_aGEMOV As Object,
                                  ByVal wp_VlrCtrl As DataGridView,
                                  ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.sCodTra = .Rows(wl_nRow).Cells("sCodTra").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QCodTra_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodTer_DGV(ByRef wp_aGEMOV As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.sCodTer = .Rows(wl_nRow).Cells("sCodTer").Value
                wl_eGEMOV.sNomTer = .Rows(wl_nRow).Cells("sNomter").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QCodTer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QEstDoc_DGV(ByRef wp_aGEMOV As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.sEstDoc = .Rows(wl_nRow).Cells("sEstDoc").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QEstDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QNroDoc_DGV(ByRef wp_aGEMOV As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QNroDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QTipMov_DGV(ByRef wp_aGEMOV As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_QTipMov_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QTipMov_DT(ByRef wp_eaGEMOV As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QTipMov_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QTipMov_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
            End With


            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QTipMov_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QCodDoc_DT(ByRef wp_eaGEMOV As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QCodDoc_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_QCodDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodDoc_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
            End With


            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QTipMov_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QCodSer_DT(ByRef wp_eaGEMOV As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QCodSer_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodSer_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
            End With
            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QNroDoc_DT(ByRef wp_eaGEMOV As Object,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QNroDoc_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_QNroDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QNroDoc_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
            End With


            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QNroDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QCodTer_DT(ByRef wp_eaGEMOV As Object,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QCodTer_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_QCodTer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodTer_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
            End With
            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QCodTer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QCodTra_DT(ByRef wp_eaGEMOV As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QCodTra_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_QCodTra_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QCodTra_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
            End With


            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_QEstDoc_DT(ByRef wp_eaGEMOV As Object,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_QEstDoc_DT(wl_eGEMOV,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_eaGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_QEstDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_QEstDoc_DT(ByRef wp_eGEMOV As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
            End With
            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_QEstDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_DT(ByRef wp_eaGELMOV1 As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_DT(wl_eGELMOV1,
                              wp_DT,
                              wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_DT(ByRef wp_eGELMOV1 As Object,
                              ByVal wp_DT As DataTable,
                              ByRef wp_nRow As Integer)
        'Fecha última actualización: 2015.04.09
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sTipMov")), wp_DT.Rows(wp_nRow).Item("T0.sTipMov"), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecCtb")), wp_DT.Rows(wp_nRow).Item("dFecCtb"), #1/1/1901#)
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecVto")), wp_DT.Rows(wp_nRow).Item("dFecVto"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
                .nPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPorDto")), wp_DT.Rows(wp_nRow).Item("T0.nPorDto"), 0)
                .sAlmOri = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sAlmOri")), wp_DT.Rows(wp_nRow).Item("sAlmOri"), "")
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .nTotBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotBas")), wp_DT.Rows(wp_nRow).Item("nTotBas"), 0)
                .nTotDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDto")), wp_DT.Rows(wp_nRow).Item("nTotDto"), 0)
                .nTotGtoAdi = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotGtoAdi")), wp_DT.Rows(wp_nRow).Item("nTotGtoAdi"), 0)
                .nTotIvaCom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotIvaCom")), wp_DT.Rows(wp_nRow).Item("nTotIvaCom"), 0)
                .nTotIvaVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotIvaVta")), wp_DT.Rows(wp_nRow).Item("nTotIvaVta"), 0)
                .nVlrRdd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrRdd")), wp_DT.Rows(wp_nRow).Item("nVlrRdd"), 0)
                .nTotDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDoc")), wp_DT.Rows(wp_nRow).Item("nTotDoc"), 0)
                .sCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDocBas")), wp_DT.Rows(wp_nRow).Item("T0.sCodDocBas"), "")
                .nNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDocBas")), wp_DT.Rows(wp_nRow).Item("T0.nNroDocBas"), 0)
                .sCndPag = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCndPag")), wp_DT.Rows(wp_nRow).Item("sCndPag"), "")
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T0.sClsDoc"), "")
                .sTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipDoc")), wp_DT.Rows(wp_nRow).Item("sTipDoc"), "")
                .sCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodVen")), wp_DT.Rows(wp_nRow).Item("T0.sCodVen"), "")
                .sDirTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDirTer")), wp_DT.Rows(wp_nRow).Item("sDirTer"), "")
                .sCiuter = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCiuter")), wp_DT.Rows(wp_nRow).Item("sCiuter"), "")
                .sDepTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDepTer")), wp_DT.Rows(wp_nRow).Item("sDepTer"), "")
                .sPaiTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sPaiTer")), wp_DT.Rows(wp_nRow).Item("sPaiTer"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                .sCodCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCteCtb")), wp_DT.Rows(wp_nRow).Item("sCodCteCtb"), "")
                .nNroCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCteCtb")), wp_DT.Rows(wp_nRow).Item("nNroCteCtb"), 0)
                .nIdFECCT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdFECCT")), wp_DT.Rows(wp_nRow).Item("nIdFECCT"), 0)
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "")
                .sCodMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodMon")), wp_DT.Rows(wp_nRow).Item("T0.sCodMon"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sCodAut = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAut")), wp_DT.Rows(wp_nRow).Item("sCodAut"), "")
                .bPrp01 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp01")), wp_DT.Rows(wp_nRow).Item("bPrp01"), False)
                .bPrp02 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp02")), wp_DT.Rows(wp_nRow).Item("bPrp02"), False)
                .bPrp03 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp03")), wp_DT.Rows(wp_nRow).Item("bPrp03"), False)

                .xnID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nID")), wp_DT.Rows(wp_nRow).Item("T1.nID"), 0) '0
                .xsCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T1.sCodDoc"), "")
                .xnNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T1.nNroDoc"), 0)
                .xsCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodSer")), wp_DT.Rows(wp_nRow).Item("T1.sCodSer"), "")
                .xsTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sTipMov")), wp_DT.Rows(wp_nRow).Item("T1.sTipMov"), "")
                .xsCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodDocBas")), wp_DT.Rows(wp_nRow).Item("T1.sCodDocBas"), "")
                .xsCodSerBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .xnNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nNroDocBas")), wp_DT.Rows(wp_nRow).Item("T1.nNroDocBas"), 0)
                .xsCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodItm")), wp_DT.Rows(wp_nRow).Item("T1.sCodItm"), "")
                .xsNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sNomItm")), wp_DT.Rows(wp_nRow).Item("T1.sNomItm"), "")
                .xsNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sNomAlt")), wp_DT.Rows(wp_nRow).Item("T1.sNomAlt"), "")
                .xsCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T1.sCodAlm"), "")
                .xnCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0) '10
                .xsUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv"), "")
                .xnPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nPreUni")), wp_DT.Rows(wp_nRow).Item("T1.nPreUni"), 0)
                .xnVlrBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBas")), wp_DT.Rows(wp_nRow).Item("nVlrBas"), 0)
                .xnPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nPorDto")), wp_DT.Rows(wp_nRow).Item("T1.nPorDto"), 0)
                .xnVlrDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDto")), wp_DT.Rows(wp_nRow).Item("nVlrDto"), 0)
                .xnPreDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreDto")), wp_DT.Rows(wp_nRow).Item("nPreDto"), 0)
                .xnVlrDtoLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDtoLin")), wp_DT.Rows(wp_nRow).Item("nVlrDtoLin"), 0)
                .xsCodIva = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIva")), wp_DT.Rows(wp_nRow).Item("sCodIva"), "")
                .xnPorIva = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIva")), wp_DT.Rows(wp_nRow).Item("nPorIva"), 0)
                .xnVlrIva = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIva")), wp_DT.Rows(wp_nRow).Item("nVlrIva"), 0) '20
                .xnVlrIvaLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIvaLin")), wp_DT.Rows(wp_nRow).Item("nVlrIvaLin"), 0)
                .xnPreBru = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreBru")), wp_DT.Rows(wp_nRow).Item("nPreBru"), 0)
                .xnTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .xnPorCms = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCms")), wp_DT.Rows(wp_nRow).Item("nPorCms"), 0)
                .xsCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodCco")), wp_DT.Rows(wp_nRow).Item("T1.sCodCco"), "")
                .xsTipLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipLIM")), wp_DT.Rows(wp_nRow).Item("sTipLIM"), "")
                .xsCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodVen")), wp_DT.Rows(wp_nRow).Item("T1.sCodVen"), "")
                .xnLinBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .xsCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .xsCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "") '30
                .xbSolIto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bSolIto")), wp_DT.Rows(wp_nRow).Item("bSolIto"), False)
                .xsCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("T1.sCtaCosVta"), "")
                .xbItmBlq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .xsClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T1.sClsDoc"), "")
                .xnTasCamUsd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTasCamUsd")), wp_DT.Rows(wp_nRow).Item("nTasCamUsd"), 0)
                .xnPreUniUsd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUniUsd")), wp_DT.Rows(wp_nRow).Item("nPreUniUsd"), 0)
                .xnVlrBasUsd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBasUsd")), wp_DT.Rows(wp_nRow).Item("nVlrBasUsd"), 0)
                .xsCodRch = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodRch")), wp_DT.Rows(wp_nRow).Item("sCodRch"), "")
                .xsNroLot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNroLot")), wp_DT.Rows(wp_nRow).Item("sNroLot"), "") '40
                .xnSdoCanLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoCanLin")), wp_DT.Rows(wp_nRow).Item("nSdoCanLin"), 0)
                .xnPesProm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesProm")), wp_DT.Rows(wp_nRow).Item("nPesProm"), 0)

                '.xsCodMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodMon")), wp_DT.Rows(wp_nRow).Item("sCodMon"), "") '40
                '.xnUltPreEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("nUltPreEnt"), 0)
                .xbIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .xbIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
                '.xnSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                ' .xnSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
            End With
            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_DT")
            MsgBox(ex.Message)


        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QItm(ByVal wp_VlrCtrl As DataGridView,
                                      ByVal wp_aeKARDEX_QItm As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeKARDEX_QItm)
            Dim wl_aeKARDEX_QItm(wl_nCntReg) As moe_Estructuras.eKARDEX
            wl_aeKARDEX_QItm = wp_aeKARDEX_QItm
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QItm(wp_VlrCtrl,
                                        wl_aeKARDEX_QItm(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeKARDEX_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QItm(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eKARDEX_QItm As Object,
                                    ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("xsCodItm").Value = wp_eKARDEX_QItm.sCodItm
                .Rows(wp_nRow).Cells("xSNomItm").Value = wp_eKARDEX_QItm.sNomItm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eKARDEX_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QTipMov_DT(ByRef wp_eaGELMOV1 As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QTipMov_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_aeGELMOV1_QTipMov_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QTipMov_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
            End With


            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QTipMov_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QCodDoc_DT(ByRef wp_eaGELMOV1 As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QCodDoc_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_QCodDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodDoc_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
            End With


            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QCodDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QCodSer_DT(ByRef wp_eaGELMOV1 As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QCodSer_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodSer_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
            End With
            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QNroDoc_DT(ByRef wp_eaGELMOV1 As Object,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QNroDoc_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_QNroDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QNroDoc_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
            End With
            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QNroDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QCodTer_DT(ByRef wp_eaGELMOV1 As Object,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QCodTer_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_QCodTer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodTer_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
            End With
            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QCodTer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QCodTra_DT(ByRef wp_eaGELMOV1 As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QCodTra_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_QCodTra_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodTra_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
            End With
            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QCodTra_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGELMOV1_QCodItm_DT(ByRef wp_eaGELMOV1 As Object,
                                    ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGELMOV1(wl_nRow) = New moe_Estructuras.eGELMOV1
                wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                moo_eGELMOV1_QCodItm_DT(wl_eGELMOV1,
                                      wp_DT,
                                      wl_nRow)
                wl_aeGELMOV1(wl_nRow) = wl_eGELMOV1
            Next
            wp_eaGELMOV1 = wl_aeGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGELMOV1_QCodItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodItm_DT(ByRef wp_eGELMOV1 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
            With wl_eGELMOV1
                .xsCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .xsNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
            End With


            wp_eGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGELMOV1_QCodItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGLMOV1_DT(ByRef wp_eaGLMOV1 As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeGLMOV1(wl_nCntReg) As moe_Estructuras.eGLMOV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeGLMOV1(wl_nRow) = New moe_Estructuras.eGLMOV1
                wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                moo_eGLMOV1_DT(wl_eGLMOV1,
                              wp_DT,
                              wl_nRow)
                wl_aeGLMOV1(wl_nRow) = wl_eGLMOV1
            Next
            wp_eaGLMOV1 = wl_aeGLMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGLMOV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGLMOV1_DT(ByRef wp_eGLMOV1 As Object,
                              ByVal wp_DT As DataTable,
                              ByRef wp_nRow As Integer)
        'Fecha última actualización: 2015.04.09
        Try
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
            With wl_eGLMOV1
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nID")), wp_DT.Rows(wp_nRow).Item("T0.nID"), 0) '0
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .sCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .sCodSerBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .nNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomItm")), wp_DT.Rows(wp_nRow).Item("T0.sNomItm"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomAlt")), wp_DT.Rows(wp_nRow).Item("T0.sNomAlt"), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), "")
                .nCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0) '10
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .nVlrBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBas")), wp_DT.Rows(wp_nRow).Item("nVlrBas"), 0)
                .nPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorDto")), wp_DT.Rows(wp_nRow).Item("nPorDto"), 0)
                .nVlrDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDto")), wp_DT.Rows(wp_nRow).Item("nVlrDto"), 0)
                .nPreDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreDto")), wp_DT.Rows(wp_nRow).Item("nPreDto"), 0)
                .nVlrDtoLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDtoLin")), wp_DT.Rows(wp_nRow).Item("nVlrDtoLin"), 0)
                .sCodIva = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIva")), wp_DT.Rows(wp_nRow).Item("sCodIva"), "")
                .nPorIva = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIva")), wp_DT.Rows(wp_nRow).Item("nPorIva"), 0)
                .nVlrIva = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIva")), wp_DT.Rows(wp_nRow).Item("nVlrIva"), 0) '20
                .nVlrIvaLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIvaLin")), wp_DT.Rows(wp_nRow).Item("nVlrIvaLin"), 0)
                .nPreBru = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreBru")), wp_DT.Rows(wp_nRow).Item("nPreBru"), 0)
                .nTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .nPorCms = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCms")), wp_DT.Rows(wp_nRow).Item("nPorCms"), 0)
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCco")), wp_DT.Rows(wp_nRow).Item("T0.sCodCco"), "")
                .sTipLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipLIM")), wp_DT.Rows(wp_nRow).Item("sTipLIM"), "")
                .sCodVen = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodVen")), wp_DT.Rows(wp_nRow).Item("sCodVen"), "")
                .nLinBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .sCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .sCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "") '30
                .bSolIto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bSolIto")), wp_DT.Rows(wp_nRow).Item("bSolIto"), False)
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("T2.sCtaCosVta"), "")
                .bItmBlq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .nTasCamUsd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTasCamUsd")), wp_DT.Rows(wp_nRow).Item("nTasCamUsd"), 0)
                .nPreUniUsd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUniUsd")), wp_DT.Rows(wp_nRow).Item("nPreUniUsd"), 0)
                .nVlrBasUsd = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBasUsd")), wp_DT.Rows(wp_nRow).Item("nVlrBasUsd"), 0)
                .sCodRch = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodRch")), wp_DT.Rows(wp_nRow).Item("sCodRch"), "") '39
                .sNroLot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNroLot")), wp_DT.Rows(wp_nRow).Item("sNroLot"), "") '40
                .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .nSdoCanLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoCanLin")), wp_DT.Rows(wp_nRow).Item("nSdoCanLin"), 0)
                .nUltPreEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("T1.nUltPreEnt"), 0)
                .nPesProm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesProm")), wp_DT.Rows(wp_nRow).Item("nPesProm"), 0)
                '.sCodMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodMon")), wp_DT.Rows(wp_nRow).Item("sCodMon"), "") '40
                .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
            End With
            wp_eGLMOV1 = wl_eGLMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGLMOV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGEMOV_aeGELMOV1(ByRef wp_aeGEMOV As Object,
                                     ByVal wp_aeGELMOV1 As Object)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            wl_nCntReg = wp_aeGELMOV1.Length - 1
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            Dim wl_eGELMOV1 = New moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_aeGELMOV1.Length - 1

                wl_aeGEMOV(wl_nRow) = New moe_Estructuras.eGEMOV
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                moo_eGEMOV_eGELMOV1(wl_eGEMOV,
                                    wp_aeGELMOV1,
                                    wl_nRow)
                wl_aeGEMOV(wl_nRow) = wl_eGEMOV
            Next
            wp_aeGEMOV = wl_aeGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_aeGEMOV_aeGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_eGELMOV1(ByRef wp_eGEMOV As Object,
                                   ByVal wp_aeGELMOV1 As Object,
                                   ByVal wp_nRow As Integer)

        Try
            Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .nID = wp_aeGELMOV1(wp_nRow).nId
                .sCodDoc = wp_aeGELMOV1(wp_nRow).sCodDoc
                .nNroDoc = wp_aeGELMOV1(wp_nRow).nNroDoc
                .sCodSer = wp_aeGELMOV1(wp_nRow).sCodSer
                .sCodTra = wp_aeGELMOV1(wp_nRow).sCodTra
                .sEstDoc = wp_aeGELMOV1(wp_nRow).sEstDoc
                .sTipMov = wp_aeGELMOV1(wp_nRow).sTipMov
                .dFecCtb = wp_aeGELMOV1(wp_nRow).dFecCtb
                .dFecDoc = wp_aeGELMOV1(wp_nRow).dFecDoc
                .dFecVto = wp_aeGELMOV1(wp_nRow).dFecVto
                .dFecSys = wp_aeGELMOV1(wp_nRow).dFecSys
                .sCodTer = wp_aeGELMOV1(wp_nRow).sCodTer
                .sNomTer = wp_aeGELMOV1(wp_nRow).sNomTer
                .nPorDto = wp_aeGELMOV1(wp_nRow).nPorDto
                .sAlmOri = wp_aeGELMOV1(wp_nRow).sAlmOri
                .sDocRef = wp_aeGELMOV1(wp_nRow).sDocRef
                .nTotBas = wp_aeGELMOV1(wp_nRow).nTotBas
                .nTotDto = wp_aeGELMOV1(wp_nRow).nTotDto
                .nTotGtoAdi = wp_aeGELMOV1(wp_nRow).nTotGtoAdi
                .nTotIvaCom = wp_aeGELMOV1(wp_nRow).nTotIvaCom
                .nTotIvaVta = wp_aeGELMOV1(wp_nRow).nTotIvaVta
                .nVlrRdd = wp_aeGELMOV1(wp_nRow).nVlrRdd
                .nTotDoc = wp_aeGELMOV1(wp_nRow).nTotDoc
                .sCodDocBas = wp_aeGELMOV1(wp_nRow).sCodDocBas
                .nNroDocBas = wp_aeGELMOV1(wp_nRow).nNroDocBas
                .sCndPag = wp_aeGELMOV1(wp_nRow).sCndPag
                .sClsDoc = wp_aeGELMOV1(wp_nRow).sClsDoc
                .sTipDoc = wp_aeGELMOV1(wp_nRow).sTipDoc
                .sCodVen = wp_aeGELMOV1(wp_nRow).sCodVen
                .sDirTer = wp_aeGELMOV1(wp_nRow).sDirTer
                .sCiuter = wp_aeGELMOV1(wp_nRow).sCiuter
                .sDepTer = wp_aeGELMOV1(wp_nRow).sDepTer
                .sPaiTer = wp_aeGELMOV1(wp_nRow).sPaiTer
                .sCmn = wp_aeGELMOV1(wp_nRow).sCmn
                .sCodCteCtb = wp_aeGELMOV1(wp_nRow).sCodCteCtb
                .nNroCteCtb = wp_aeGELMOV1(wp_nRow).nNroCteCtb
                .nIdFECCT = wp_aeGELMOV1(wp_nRow).nIdFECCT
                .sNitTer = wp_aeGELMOV1(wp_nRow).sNitTer
                .sCodMon = wp_aeGELMOV1(wp_nRow).sCodMon
                .sCodUsr = wp_aeGELMOV1(wp_nRow).sCodUsr
                .sCodAut = wp_aeGELMOV1(wp_nRow).sCodAut
                .bPrp01 = wp_aeGELMOV1(wp_nRow).bPrp01
                .bPrp02 = wp_aeGELMOV1(wp_nRow).bPrp02
                .bPrp03 = wp_aeGELMOV1(wp_nRow).bPrp03
            End With
            wp_eGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGEMOV_eGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeGLMOV1_aeGELMOV1(ByRef wp_aeGLMOV1 As Object,
                                   ByVal wp_aeGELMOV1 As Object)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1

            If wp_aeGELMOV1(0).sCodDoc Is Nothing Then
                ReDim wp_aeGELMOV1(0)
                wp_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            End If

            wl_nCntReg = wp_aeGELMOV1.Length - 1
            Dim wl_aeGLMOV1(wl_nCntReg) As moe_Estructuras.eGLMOV1
            Dim wl_eGELMOV1 = New moe_Estructuras.eGELMOV1

            For wl_nRow = 0 To wp_aeGELMOV1.Length - 1

                wl_aeGLMOV1(wl_nRow) = New moe_Estructuras.eGLMOV1
                wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                moo_eGLMOV1_eGELMOV1(wl_eGLMOV1,
                                    wp_aeGELMOV1,
                                    wl_nRow)
                wl_aeGLMOV1(wl_nRow) = wl_eGLMOV1
            Next
            wp_aeGLMOV1 = wl_aeGLMOV1
        Catch ex As Exception
            MsgBox("Error : moo_aeGLMOV1_aeGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGLMOV1_eGELMOV1(ByRef wp_eGLMOV1 As Object,
                                ByVal wp_aeGELMOV1 As Object,
                                ByVal wp_nRow As Integer)

        Try
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
            With wl_eGLMOV1
                .nID = wp_aeGELMOV1(wp_nRow).xnId
                .sCodDoc = wp_aeGELMOV1(wp_nRow).sCodDoc
                .nNroDoc = wp_aeGELMOV1(wp_nRow).nNroDoc
                .sCodSer = wp_aeGELMOV1(wp_nRow).sCodSer
                .sTipMov = wp_aeGELMOV1(wp_nRow).sTipMov
                .sCodDocBas = wp_aeGELMOV1(wp_nRow).xsCodDocBas
                .nNroDocBas = wp_aeGELMOV1(wp_nRow).xnNroDocBas
                .sCodSerBas = wp_aeGELMOV1(wp_nRow).xsCodSerBas
                .sCodItm = wp_aeGELMOV1(wp_nRow).xsCodItm
                .sNomItm = wp_aeGELMOV1(wp_nRow).xsNomItm
                .sNomAlt = wp_aeGELMOV1(wp_nRow).xsNomAlt
                .sCodAlm = wp_aeGELMOV1(wp_nRow).xsCodAlm
                .nCanItm = wp_aeGELMOV1(wp_nRow).xnCanItm
                .sUniMedInv = wp_aeGELMOV1(wp_nRow).xsUniMedInv
                .nPreUni = wp_aeGELMOV1(wp_nRow).xnPreUni
                .nVlrBas = wp_aeGELMOV1(wp_nRow).xnVlrBas
                .nPorDto = wp_aeGELMOV1(wp_nRow).xnPorDto
                .nVlrDto = wp_aeGELMOV1(wp_nRow).xnVlrDto
                .nPreDto = wp_aeGELMOV1(wp_nRow).xnPreDto
                .nVlrDtoLin = wp_aeGELMOV1(wp_nRow).xnVlrDtoLin
                .sCodIva = wp_aeGELMOV1(wp_nRow).xsCodIva '20
                .nPorIva = wp_aeGELMOV1(wp_nRow).xnPorIva
                .nVlrIva = wp_aeGELMOV1(wp_nRow).xnVlrIva
                .nVlrIvaLin = wp_aeGELMOV1(wp_nRow).xnVlrIvaLin
                .nPreBru = wp_aeGELMOV1(wp_nRow).xnPreBru
                .nTotLin = wp_aeGELMOV1(wp_nRow).xnTotLin
                .nPorCms = wp_aeGELMOV1(wp_nRow).xnPorCms
                .sCodCco = wp_aeGELMOV1(wp_nRow).xsCodCco
                .sTipLIM = wp_aeGELMOV1(wp_nRow).xsTipLIM
                .sCodVen = wp_aeGELMOV1(wp_nRow).xsCodVen
                .nLinBas = wp_aeGELMOV1(wp_nRow).xnLinBas '30
                .sCodPdo = wp_aeGELMOV1(wp_nRow).xsCodPdo
                .sCodCta = wp_aeGELMOV1(wp_nRow).xsCodCta
                .bSolIto = wp_aeGELMOV1(wp_nRow).xbSolIto
                .sCtaCosVta = wp_aeGELMOV1(wp_nRow).xsCtaCosVta
                .bItmBlq = wp_aeGELMOV1(wp_nRow).xbItmBlq
                .sClsDoc = wp_aeGELMOV1(wp_nRow).xsClsDoc
                .nTasCamUsd = wp_aeGELMOV1(wp_nRow).xnTasCamUsd
                .nPreUniUsd = wp_aeGELMOV1(wp_nRow).xnPreUniUsd
                .nVlrBasUsd = wp_aeGELMOV1(wp_nRow).xnVlrBasUsd
                .sCodRch = wp_aeGELMOV1(wp_nRow).xsCodRch '40
                .sNroLot = wp_aeGELMOV1(wp_nRow).xsNroLot
                .nSdoCanLin = wp_aeGELMOV1(wp_nRow).xnSdoCanLin
                .nPesProm = wp_aeGELMOV1(wp_nRow).xnPesProm
                '.sCodMon = wp_aeGELMOV1(wp_nRow).sCodMon
                .bIndCan = wp_aeGELMOV1(wp_nRow).XbIndCan
                .bIndCos = wp_aeGELMOV1(wp_nRow).XbIndCos
            End With
            wp_eGLMOV1 = wl_eGLMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eGLMOV1_eGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTaeGELMOV(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_DTCon1 As DataTable)
        'Fecha última actualización: 2015.01.29
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DTCon1.Rows.Count
            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).Cells("nId").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("T0.nId")), wg_DTCon1.Rows(wl_nRow).Item("T0.nId"), 0)
                    .Rows(wl_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("T0.sCodDoc")), wg_DTCon1.Rows(wl_nRow).Item("T0.sCodDoc"), "")
                    .Rows(wl_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("T0.nNroDoc")), wg_DTCon1.Rows(wl_nRow).Item("T0.nNroDoc"), 0)
                    .Rows(wl_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("T0.sCodSer")), wg_DTCon1.Rows(wl_nRow).Item("T0.sCodSer"), "")
                    .Rows(wl_nRow).Cells("sCodTra").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodTra")), wg_DTCon1.Rows(wl_nRow).Item("sCodTra"), "")
                    .Rows(wl_nRow).Cells("sEstDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sEstDoc")), wg_DTCon1.Rows(wl_nRow).Item("sEstDoc"), "")
                    .Rows(wl_nRow).Cells("sTipMov").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("T0.TipMov")), wg_DTCon1.Rows(wl_nRow).Item("T0.sTipMov"), "")
                    .Rows(wl_nRow).Cells("dFecCtb").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("dFecCtb")), wg_DTCon1.Rows(wl_nRow).Item("dFecCtb"), #1/1/1901#)
                    .Rows(wl_nRow).Cells("dFecDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("dFecDoc")), wg_DTCon1.Rows(wl_nRow).Item("dFecDoc"), #1/1/1901#)
                    .Rows(wl_nRow).Cells("dFecVto").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("dFecVto")), wg_DTCon1.Rows(wl_nRow).Item("dFecVto"), #1/1/1901#)
                    .Rows(wl_nRow).Cells("dFecSys").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("dFecSys")), wg_DTCon1.Rows(wl_nRow).Item("dFecSys"), #1/1/1901#)
                    .Rows(wl_nRow).Cells("sCodTer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodTer")), wg_DTCon1.Rows(wl_nRow).Item("sCodTer"), "")
                    .Rows(wl_nRow).Cells("sNomTer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sNomTer")), wg_DTCon1.Rows(wl_nRow).Item("sNomTer"), "")
                    .Rows(wl_nRow).Cells("nPorDto").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nPorDto")), wg_DTCon1.Rows(wl_nRow).Item("nPorDto"), 0)
                    .Rows(wl_nRow).Cells("sAlmOri").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sAlmOri")), wg_DTCon1.Rows(wl_nRow).Item("sAlmOri"), "")
                    .Rows(wl_nRow).Cells("sDocRef").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sDocRef")), wg_DTCon1.Rows(wl_nRow).Item("sDocRef"), "")
                    .Rows(wl_nRow).Cells("nTotBas").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nTotBas")), wg_DTCon1.Rows(wl_nRow).Item("nTotBas"), 0)
                    .Rows(wl_nRow).Cells("nTotDto").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nTotDto")), wg_DTCon1.Rows(wl_nRow).Item("nTotDto"), 0)
                    .Rows(wl_nRow).Cells("nTotGtoAdi").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nTotGtoAdi")), wg_DTCon1.Rows(wl_nRow).Item("nTotGtoAdi"), 0)
                    .Rows(wl_nRow).Cells("nTotIvaCom").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nTotIvaCom")), wg_DTCon1.Rows(wl_nRow).Item("nTotIvaCom"), 0)
                    .Rows(wl_nRow).Cells("nTotIvaVta").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nTotIvaVta")), wg_DTCon1.Rows(wl_nRow).Item("nTotIvaVta"), 0)
                    .Rows(wl_nRow).Cells("nVlrRdd").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nVlrRdd")), wg_DTCon1.Rows(wl_nRow).Item("nVlrRdd"), 0)
                    .Rows(wl_nRow).Cells("nTotDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nTotDoc")), wg_DTCon1.Rows(wl_nRow).Item("nTotDoc"), 0)
                    .Rows(wl_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodDocBas")), wg_DTCon1.Rows(wl_nRow).Item("sCodDocBas"), "")
                    .Rows(wl_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nNroDocBas")), wg_DTCon1.Rows(wl_nRow).Item("nNroDocBas"), 0)
                    .Rows(wl_nRow).Cells("sCndPag").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCndPag")), wg_DTCon1.Rows(wl_nRow).Item("sCndPag"), "")
                    .Rows(wl_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sClsDoc")), wg_DTCon1.Rows(wl_nRow).Item("sClsDoc"), "")
                    .Rows(wl_nRow).Cells("sTipDoc").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sTipDoc")), wg_DTCon1.Rows(wl_nRow).Item("sTipDoc"), "")
                    .Rows(wl_nRow).Cells("sCodVen").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodVen")), wg_DTCon1.Rows(wl_nRow).Item("sCodVen"), "")
                    .Rows(wl_nRow).Cells("sDirter").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sDirter")), wg_DTCon1.Rows(wl_nRow).Item("sDirter"), "")
                    .Rows(wl_nRow).Cells("sCiuTer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCiuTer")), wg_DTCon1.Rows(wl_nRow).Item("sCiuTer"), "")
                    .Rows(wl_nRow).Cells("sDepTer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sDepTer")), wg_DTCon1.Rows(wl_nRow).Item("sDepTer"), "")
                    .Rows(wl_nRow).Cells("sPaiTer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sPaiTer")), wg_DTCon1.Rows(wl_nRow).Item("sPaiTer"), "")
                    .Rows(wl_nRow).Cells("sCmn").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCmn")), wg_DTCon1.Rows(wl_nRow).Item("sCmn"), "")
                    .Rows(wl_nRow).Cells("sCodCteCtb").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodCteCtb")), wg_DTCon1.Rows(wl_nRow).Item("sCodCteCtb"), "")
                    .Rows(wl_nRow).Cells("nNroCteCtb").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nNroCteCtb")), wg_DTCon1.Rows(wl_nRow).Item(""), 0)
                    .Rows(wl_nRow).Cells("nIdFECCT").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("nIdFECCT")), wg_DTCon1.Rows(wl_nRow).Item("nIdFECCT"), 0)
                    .Rows(wl_nRow).Cells("sNitTer").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sNitTer")), wg_DTCon1.Rows(wl_nRow).Item("sNitTer"), "")
                    .Rows(wl_nRow).Cells("sCodMon").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodMon")), wg_DTCon1.Rows(wl_nRow).Item("sCodMon"), "")
                    .Rows(wl_nRow).Cells("sCodUsr").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodUsr")), wg_DTCon1.Rows(wl_nRow).Item("sCodUsr"), "")
                    .Rows(wl_nRow).Cells("sCodAut").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("sCodAut")), wg_DTCon1.Rows(wl_nRow).Item("sCodAut"), "")
                    .Rows(wl_nRow).Cells("bPrp01").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("bPrp01")), wg_DTCon1.Rows(wl_nRow).Item("bPrp01"), False)
                    .Rows(wl_nRow).Cells("bPrp02").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("bPrp02")), wg_DTCon1.Rows(wl_nRow).Item("bPrp02"), False)
                    .Rows(wl_nRow).Cells("bPrp03").Value = IIf(Not IsDBNull(wg_DTCon1.Rows(wl_nRow).Item("bPrp03")), wg_DTCon1.Rows(wl_nRow).Item("bPrp03"), False)

                    .Rows(wl_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nId")), wp_DTCon1.Rows(wl_nRow).Item("nId"), 0)
                    .Rows(wl_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodDoc")), wp_DTCon1.Rows(wl_nRow).Item("sCodDoc"), "")
                    .Rows(wl_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nNroDoc")), wp_DTCon1.Rows(wl_nRow).Item("nNroDoc"), 0)
                    .Rows(wl_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodSer")), wp_DTCon1.Rows(wl_nRow).Item("sCodSer"), "")
                    .Rows(wl_nRow).Cells("sTipMov").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sTipMov")), wp_DTCon1.Rows(wl_nRow).Item("sTipMov"), "")
                    .Rows(wl_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodDocBas")), wp_DTCon1.Rows(wl_nRow).Item("sCodDocBas"), "")
                    .Rows(wl_nRow).Cells("sCodSerBas").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodSerBas")), wp_DTCon1.Rows(wl_nRow).Item("sCodSerBas"), "")
                    .Rows(wl_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nNroDocBas")), wp_DTCon1.Rows(wl_nRow).Item("nNroDocBas"), "")
                    .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodItm")), wp_DTCon1.Rows(wl_nRow).Item("sCodItm"), "")
                    .Rows(wl_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sNomItm")), wp_DTCon1.Rows(wl_nRow).Item("sNomItm"), "")
                    .Rows(wl_nRow).Cells("sNomAlt").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sNomAlt")), wp_DTCon1.Rows(wl_nRow).Item("sNomAlt"), "")
                    .Rows(wl_nRow).Cells("sCodAlm").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodAlm")), wp_DTCon1.Rows(wl_nRow).Item("sCodAlm"), 0)
                    .Rows(wl_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nCanItm")), wp_DTCon1.Rows(wl_nRow).Item("nCanItm"), "")
                    .Rows(wl_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sUniMedInv")), wp_DTCon1.Rows(wl_nRow).Item("sUniMedInv"), 0)
                    .Rows(wl_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPreUni")), wp_DTCon1.Rows(wl_nRow).Item("nPreUni"), 0)
                    .Rows(wl_nRow).Cells("nVlrBas").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nVlrBas")), wp_DTCon1.Rows(wl_nRow).Item("nVlrBas"), 0)
                    .Rows(wl_nRow).Cells("nPorDto").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPorDto")), wp_DTCon1.Rows(wl_nRow).Item("nPorDto"), 0)
                    .Rows(wl_nRow).Cells("nVlrDto").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nVlrDto")), wp_DTCon1.Rows(wl_nRow).Item("nVlrDto"), 0)
                    .Rows(wl_nRow).Cells("nPreDto").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPreDto")), wp_DTCon1.Rows(wl_nRow).Item("nPreDto"), 0)
                    .Rows(wl_nRow).Cells("nVlrDtoLin").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nVlrDtoLin")), wp_DTCon1.Rows(wl_nRow).Item("nVlrDtoLin"), "")
                    .Rows(wl_nRow).Cells("sCodIva").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodIva")), wp_DTCon1.Rows(wl_nRow).Item("sCodIva"), 0)
                    .Rows(wl_nRow).Cells("nPorIva").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPorIva")), wp_DTCon1.Rows(wl_nRow).Item("nPorIva"), 0)
                    .Rows(wl_nRow).Cells("nVlrIva").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nVlrIva")), wp_DTCon1.Rows(wl_nRow).Item("nVlrIva"), 0)
                    .Rows(wl_nRow).Cells("nVlrIvaLin").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nVlrIvaLin")), wp_DTCon1.Rows(wl_nRow).Item("nVlrIvaLin"), 0)
                    .Rows(wl_nRow).Cells("nPreBru").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPreBru")), wp_DTCon1.Rows(wl_nRow).Item("nPreBru"), 0)
                    .Rows(wl_nRow).Cells("nTotLin").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nTotLin")), wp_DTCon1.Rows(wl_nRow).Item("nTotLin"), "")
                    .Rows(wl_nRow).Cells("nPorCms").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPorCms")), wp_DTCon1.Rows(wl_nRow).Item("nPorCms"), 0) '25
                    .Rows(wl_nRow).Cells("sCodCco").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodCco")), wp_DTCon1.Rows(wl_nRow).Item("sCodCco"), "")
                    .Rows(wl_nRow).Cells("sTipLIM").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sTipLIM")), wp_DTCon1.Rows(wl_nRow).Item("sTipLIM"), "") '27
                    .Rows(wl_nRow).Cells("sCodVen").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodVen")), wp_DTCon1.Rows(wl_nRow).Item("sCodVen"), "")
                    .Rows(wl_nRow).Cells("nLinBas").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nLinBas")), wp_DTCon1.Rows(wl_nRow).Item("nLinBas"), 0)
                    .Rows(wl_nRow).Cells("sCodPdo").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodPdo")), wp_DTCon1.Rows(wl_nRow).Item("sCodPdo"), "")
                    .Rows(wl_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodCta")), wp_DTCon1.Rows(wl_nRow).Item("sCodCta"), "")
                    .Rows(wl_nRow).Cells("bSolIto").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("bSolIto")), wp_DTCon1.Rows(wl_nRow).Item("bSolIto"), False)
                    .Rows(wl_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCtaCosVta")), wp_DTCon1.Rows(wl_nRow).Item("sCtaCosVta"), "")
                    .Rows(wl_nRow).Cells("bItmBlq").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("bItmBlq")), wp_DTCon1.Rows(wl_nRow).Item("bItmBlq"), False)
                    .Rows(wl_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sClsDoc")), wp_DTCon1.Rows(wl_nRow).Item("sClsDoc"), "")
                    .Rows(wl_nRow).Cells("nTasCamUsd").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nTasCamUsd")), wp_DTCon1.Rows(wl_nRow).Item("nTasCamUsd"), 0)
                    .Rows(wl_nRow).Cells("nPreUniUsd").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPreUniUsd")), wp_DTCon1.Rows(wl_nRow).Item("nPreUniUsd"), 0)
                    .Rows(wl_nRow).Cells("nVlrBasUsd").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nVlrBasUsd")), wp_DTCon1.Rows(wl_nRow).Item("nVlrBasUsd"), "")
                    .Rows(wl_nRow).Cells("sCodRch").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodRch")), wp_DTCon1.Rows(wl_nRow).Item("sCodRch"), "")
                    .Rows(wl_nRow).Cells("sNroLot").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sNroLot")), wp_DTCon1.Rows(wl_nRow).Item("sNroLot"), "")
                    .Rows(wl_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nSdoAlm")), wp_DTCon1.Rows(wl_nRow).Item("nSdoAlm"), 0)
                    .Rows(wl_nRow).Cells("nSdoInv").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nSdoInv")), wp_DTCon1.Rows(wl_nRow).Item("nSdoInv"), 0)
                    .Rows(wl_nRow).Cells("nSdoCanLin").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nSdoCanLin")), wp_DTCon1.Rows(wl_nRow).Item("nSdoCanLin"), 0)
                    .Rows(wl_nRow).Cells("nPesProm").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nPesProm")), wp_DTCon1.Rows(wl_nRow).Item("nPesProm"), 0)
                    '.Rows(wl_nRow).Cells("sCodMon").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("sCodMon")), wp_DTCon1.Rows(wl_nRow).Item("sCodMon"), "")
                    .Rows(wl_nRow).Cells("nUltPreEnt").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("nUltPreEnt")), wp_DTCon1.Rows(wl_nRow).Item("nUltPreEnt"), 0)
                    .Rows(wl_nRow).Cells("bIndCan").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("bIndCan")), wp_DTCon1.Rows(wl_nRow).Item("bIndCan"), False)
                    .Rows(wl_nRow).Cells("bIndCos").Value = IIf(Not IsDBNull(wp_DTCon1.Rows(wl_nRow).Item("bIndCos")), wp_DTCon1.Rows(wl_nRow).Item("bIndCos"), False)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTaeGELMOV")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_eGLMOV1_DGVGLMOV1(ByRef wp_eGLMOV1 As Object,
                                     ByVal wp_VlrCtrl As DataGridView,
                                     ByRef wp_nRow As Integer)
        'Fecha última actualización: 2014.09.12
        Try
            Dim va_eGLMOV1 As New moe_Estructuras.eGLMOV1
            'va_eGLMOV1 = wp_eGLMOV1
            With wp_VlrCtrl
                va_eGLMOV1.nID = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nID").Value), .Rows(wp_nRow).Cells("nID").Value, 0) '0
                va_eGLMOV1.sCodDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodDoc").Value), .Rows(wp_nRow).Cells("sCodDoc").Value, "")
                va_eGLMOV1.nNroDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nNroDoc").Value), .Rows(wp_nRow).Cells("nNroDoc").Value, 0)
                va_eGLMOV1.sCodSer = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodSer").Value), .Rows(wp_nRow).Cells("sCodSer").Value, "")
                va_eGLMOV1.sTipMov = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sTipMov").Value), .Rows(wp_nRow).Cells("sTipMov").Value, "")
                va_eGLMOV1.sCodDocBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodDocBas").Value), .Rows(wp_nRow).Cells("sCodDocBas").Value, "")
                va_eGLMOV1.sCodSerBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodSerBas").Value), .Rows(wp_nRow).Cells("sCodSerBas").Value, "")
                va_eGLMOV1.nNroDocBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nNroDocBas").Value), .Rows(wp_nRow).Cells("nNroDocBas").Value, 0)
                va_eGLMOV1.sCodItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodItm").Value), .Rows(wp_nRow).Cells("sCodItm").Value, "")
                va_eGLMOV1.sNomItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sNomItm").Value), .Rows(wp_nRow).Cells("sNomItm").Value, "")
                va_eGLMOV1.sNomAlt = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sNomAlt").Value), .Rows(wp_nRow).Cells("sNomAlt").Value, "")
                va_eGLMOV1.sCodAlm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodAlm").Value), .Rows(wp_nRow).Cells("sCodAlm").Value, "")
                va_eGLMOV1.nCanItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nCanItm").Value), .Rows(wp_nRow).Cells("nCanItm").Value, 0) '10
                va_eGLMOV1.sUniMedInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sUniMedInv").Value), .Rows(wp_nRow).Cells("sUniMedInv").Value, "")
                va_eGLMOV1.nPreUni = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPreUni").Value), .Rows(wp_nRow).Cells("nPreUni").Value, 0)
                va_eGLMOV1.nVlrBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nVlrBas").Value), .Rows(wp_nRow).Cells("nVlrBas").Value, 0)
                va_eGLMOV1.nPorDto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPorDto").Value), .Rows(wp_nRow).Cells("nVlrDto").Value, 0)
                va_eGLMOV1.nVlrDto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nVlrDto").Value), .Rows(wp_nRow).Cells("nVlrDto").Value, 0)
                va_eGLMOV1.nPreDto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPreDto").Value), .Rows(wp_nRow).Cells("nPreDto").Value, 0)
                va_eGLMOV1.nVlrDtoLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nVlrDtoLin").Value), .Rows(wp_nRow).Cells("nVlrDtoLin").Value, 0)
                va_eGLMOV1.sCodIva = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodIva").Value), .Rows(wp_nRow).Cells("sCodIva").Value, "")
                va_eGLMOV1.nPorIva = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPorIva").Value), .Rows(wp_nRow).Cells("nPorIva").Value, 0)
                va_eGLMOV1.nVlrIva = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nVlrIva").Value), .Rows(wp_nRow).Cells("nVlrIva").Value, 0) '20
                va_eGLMOV1.nVlrIvaLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nVlrIvaLin").Value), .Rows(wp_nRow).Cells("nVlrIvaLin").Value, 0)
                va_eGLMOV1.nPreBru = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPreBru").Value), .Rows(wp_nRow).Cells("nPreBru").Value, 0)
                va_eGLMOV1.nTotLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nTotLin").Value), .Rows(wp_nRow).Cells("nTotLin").Value, 0)
                va_eGLMOV1.nSdoInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nSdoAlm").Value), .Rows(wp_nRow).Cells("nSdoAlm").Value, 0)
                va_eGLMOV1.nPorCms = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPorCms").Value), .Rows(wp_nRow).Cells("nPorCms").Value, 0)
                va_eGLMOV1.sCodCco = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodCco").Value), .Rows(wp_nRow).Cells("sCodCco").Value, "")
                va_eGLMOV1.sTipLIM = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sTipLIM").Value), .Rows(wp_nRow).Cells("sTipLIM").Value, "")
                va_eGLMOV1.sCodVen = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodVen").Value), .Rows(wp_nRow).Cells("sCodVen").Value, "")
                va_eGLMOV1.nLinBas = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nLinBas").Value), .Rows(wp_nRow).Cells("nLinBas").Value, 0)
                va_eGLMOV1.sCodPdo = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodPdo").Value), .Rows(wp_nRow).Cells("sCodPdo").Value, "")
                va_eGLMOV1.sCodCta = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodCta").Value), .Rows(wp_nRow).Cells("sCodCta").Value, "") '30
                va_eGLMOV1.bSolIto = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("bSolIto").Value), .Rows(wp_nRow).Cells("bSolIto").Value, False)
                va_eGLMOV1.sCtaCosVta = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCtaCosVta").Value), .Rows(wp_nRow).Cells("sCtaCosVta").Value, "")
                va_eGLMOV1.bItmBlq = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("bItmBlq").Value), .Rows(wp_nRow).Cells("bItmBlq").Value, False)
                va_eGLMOV1.sClsDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sClsDoc").Value), .Rows(wp_nRow).Cells("sClsDoc").Value, "")
                va_eGLMOV1.nTasCamUsd = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nTasCamUsd").Value), .Rows(wp_nRow).Cells("nTasCamUsd").Value, 0)
                va_eGLMOV1.nPreUniUsd = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPreUniUsd").Value), .Rows(wp_nRow).Cells("nPreUniUsd").Value, 0)
                va_eGLMOV1.nVlrBasUsd = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nVlrBasUsd").Value), .Rows(wp_nRow).Cells("nVlrBasUsd").Value, 0)
                va_eGLMOV1.sCodRch = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodRch").Value), .Rows(wp_nRow).Cells("sCodRch").Value, "")
                va_eGLMOV1.sNroLot = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sNroLot").Value), .Rows(wp_nRow).Cells("sNroLot").Value, "") '40
                va_eGLMOV1.nSdoAlm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nSdoAlm").Value), .Rows(wp_nRow).Cells("nSdoAlm").Value, 0)
                va_eGLMOV1.nSdoInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nSdoInv").Value), .Rows(wp_nRow).Cells("nSdoInv").Value, 0)
                va_eGLMOV1.nSdoCanLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nSdoCanLin").Value), .Rows(wp_nRow).Cells("nSdoCanLin").Value, 0)
                va_eGLMOV1.nUltPreEnt = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nUltPreEnt").Value), .Rows(wp_nRow).Cells("nUltPreEnt").Value, 0)
                va_eGLMOV1.nPesProm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPesProm").Value), .Rows(wp_nRow).Cells("nPesProm").Value, 0)
                va_eGLMOV1.bIndCan = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("bIndCan").Value), .Rows(wp_nRow).Cells("bIndCan").Value, False)
                va_eGLMOV1.bIndCos = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("bIndCos").Value), .Rows(wp_nRow).Cells("bIndCos").Value, False)
            End With
            wp_eGLMOV1 = va_eGLMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGLMOV1_DGVGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTeILMOV1(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)

        'Fecha última actualización: 2014.09.12
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0) '0
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .Rows(wp_nRow).Cells("sTipMov").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .Rows(wp_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .Rows(wp_nRow).Cells("sCodSerBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .Rows(wp_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomItm")), wp_DT.Rows(wp_nRow).Item("T0.sNomItm"), "")
                .Rows(wp_nRow).Cells("sNomAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomAlt")), wp_DT.Rows(wp_nRow).Item("T0.sNomAlt"), "")
                .Rows(wp_nRow).Cells("sCodAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), "")
                .Rows(wp_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0) '10
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv"), "")
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .Rows(wp_nRow).Cells("nVlrBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBas")), wp_DT.Rows(wp_nRow).Item("nVlrBas"), 0)
                .Rows(wp_nRow).Cells("nPorDto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorDto")), wp_DT.Rows(wp_nRow).Item("nPorDto"), 0)
                .Rows(wp_nRow).Cells("nVlrDto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDto")), wp_DT.Rows(wp_nRow).Item("nVlrDto"), 0)
                .Rows(wp_nRow).Cells("nPreDto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreDto")), wp_DT.Rows(wp_nRow).Item("nPreDto"), 0)
                .Rows(wp_nRow).Cells("nVlrDtoLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDtoLin")), wp_DT.Rows(wp_nRow).Item("nVlrDtoLin"), 0)
                .Rows(wp_nRow).Cells("sCodIva").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIva")), wp_DT.Rows(wp_nRow).Item("sCodIva"), "")
                .Rows(wp_nRow).Cells("nPorIva").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIva")), wp_DT.Rows(wp_nRow).Item("nPorIva"), 0)
                .Rows(wp_nRow).Cells("nVlrIva").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIva")), wp_DT.Rows(wp_nRow).Item("nVlrIva"), 0) '20
                .Rows(wp_nRow).Cells("nVlrIvaLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIvaLin")), wp_DT.Rows(wp_nRow).Item("nVlrIvaLin"), 0)
                .Rows(wp_nRow).Cells("nPreBru").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreBru")), wp_DT.Rows(wp_nRow).Item("nPreBru"), 0)
                .Rows(wp_nRow).Cells("nTotLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .Rows(wp_nRow).Cells("nPorCms").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCms")), wp_DT.Rows(wp_nRow).Item("nPorCms"), 0)
                .Rows(wp_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0) '25
                .Rows(wp_nRow).Cells("sCodCco").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCco")), wp_DT.Rows(wp_nRow).Item("T0.sCodCco"), "")
                .Rows(wp_nRow).Cells("sTipLIM").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipLIM")), wp_DT.Rows(wp_nRow).Item("sTipLIM"), "")
                .Rows(wp_nRow).Cells("sCodVen").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodVen")), wp_DT.Rows(wp_nRow).Item("sCodVen"), "")
                .Rows(wp_nRow).Cells("nLinBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .Rows(wp_nRow).Cells("sCodPdo").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .Rows(wp_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .Rows(wp_nRow).Cells("bSolIto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bSolIto")), wp_DT.Rows(wp_nRow).Item("bSolIto"), False)
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("T0.sCtaCosVta"), "")
                .Rows(wp_nRow).Cells("bItmBlq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .Rows(wp_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .Rows(wp_nRow).Cells("nTasCamUsd").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTasCamUsd")), wp_DT.Rows(wp_nRow).Item("nTasCamUsd"), 0)
                .Rows(wp_nRow).Cells("nPreUniUsd").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUniUsd")), wp_DT.Rows(wp_nRow).Item("nPreUniUsd"), 0)
                .Rows(wp_nRow).Cells("nVlrBasUsd").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBasUsd")), wp_DT.Rows(wp_nRow).Item("nVlrBasUsd"), 0)
                .Rows(wp_nRow).Cells("sCodRch").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodRch")), wp_DT.Rows(wp_nRow).Item("sCodRch"), "")
                .Rows(wp_nRow).Cells("sNroLot").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNroLot")), wp_DT.Rows(wp_nRow).Item("sNroLot"), "")
                .Rows(wp_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .Rows(wp_nRow).Cells("nSdoInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .Rows(wp_nRow).Cells("nSdoCanLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoCanLin")), wp_DT.Rows(wp_nRow).Item("nSdoCanLin"), 0)
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("T2.nUltPreEnt"), 0)
                .Rows(wp_nRow).Cells("nPesProm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesProm")), wp_DT.Rows(wp_nRow).Item("nPesProm"), 0)
                '.Rows(wp_nRow).Cells("sCodMon").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodMon")), wp_DT.Rows(wp_nRow).Item("sCodMon"), "")
                .Rows(wp_nRow).Cells("bIndCan").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .Rows(wp_nRow).Cells("bIndCos").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTeILMOV1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_SolDTeILMOV1(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)

        'Fecha última actualización: 2014.09.12
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0) '0
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .Rows(wp_nRow).Cells("sTipMov").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sTipMov")), wp_DT.Rows(wp_nRow).Item("T0.sTipMov"), "")
                .Rows(wp_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodDocBas")), wp_DT.Rows(wp_nRow).Item("T1.sCodDocBas"), "")
                .Rows(wp_nRow).Cells("sCodSerBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .Rows(wp_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nNroDocBas")), wp_DT.Rows(wp_nRow).Item("T1.nNroDocBas"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .Rows(wp_nRow).Cells("sNomAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
                .Rows(wp_nRow).Cells("sCodAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .Rows(wp_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0) '10
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .Rows(wp_nRow).Cells("nVlrBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBas")), wp_DT.Rows(wp_nRow).Item("nVlrBas"), 0)
                .Rows(wp_nRow).Cells("nPorDto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPorDto")), wp_DT.Rows(wp_nRow).Item("T0.nPorDto"), 0)
                .Rows(wp_nRow).Cells("nVlrDto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDto")), wp_DT.Rows(wp_nRow).Item("nVlrDto"), 0)
                .Rows(wp_nRow).Cells("nPreDto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreDto")), wp_DT.Rows(wp_nRow).Item("nPreDto"), 0)
                .Rows(wp_nRow).Cells("nVlrDtoLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrDtoLin")), wp_DT.Rows(wp_nRow).Item("nVlrDtoLin"), 0)
                .Rows(wp_nRow).Cells("sCodIva").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIva")), wp_DT.Rows(wp_nRow).Item("sCodIva"), "")
                .Rows(wp_nRow).Cells("nPorIva").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIva")), wp_DT.Rows(wp_nRow).Item("nPorIva"), 0)
                .Rows(wp_nRow).Cells("nVlrIva").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIva")), wp_DT.Rows(wp_nRow).Item("nVlrIva"), 0) '20
                .Rows(wp_nRow).Cells("nVlrIvaLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrIvaLin")), wp_DT.Rows(wp_nRow).Item("nVlrIvaLin"), 0)
                .Rows(wp_nRow).Cells("nPreBru").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreBru")), wp_DT.Rows(wp_nRow).Item("nPreBru"), 0)
                .Rows(wp_nRow).Cells("nTotLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .Rows(wp_nRow).Cells("nPorCms").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCms")), wp_DT.Rows(wp_nRow).Item("nPorCms"), 0)
                .Rows(wp_nRow).Cells("nSdoAlm").Value = 0 '25
                .Rows(wp_nRow).Cells("sCodCco").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .Rows(wp_nRow).Cells("sTipLIM").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipLIM")), wp_DT.Rows(wp_nRow).Item("sTipLIM"), "")
                .Rows(wp_nRow).Cells("sCodVen").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodVen")), wp_DT.Rows(wp_nRow).Item("T0.sCodVen"), "")
                .Rows(wp_nRow).Cells("nLinBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .Rows(wp_nRow).Cells("sCodPdo").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .Rows(wp_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .Rows(wp_nRow).Cells("bSolIto").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bSolIto")), wp_DT.Rows(wp_nRow).Item("bSolIto"), False)
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("SCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .Rows(wp_nRow).Cells("bItmBlq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .Rows(wp_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T0.sClsDoc"), "")
                .Rows(wp_nRow).Cells("nTasCamUsd").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTasCamUsd")), wp_DT.Rows(wp_nRow).Item("nTasCamUsd"), 0)
                .Rows(wp_nRow).Cells("nPreUniUsd").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUniUsd")), wp_DT.Rows(wp_nRow).Item("nPreUniUsd"), 0)
                .Rows(wp_nRow).Cells("nVlrBasUsd").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrBasUsd")), wp_DT.Rows(wp_nRow).Item("nVlrBasUsd"), 0)
                .Rows(wp_nRow).Cells("sCodRch").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodRch")), wp_DT.Rows(wp_nRow).Item("sCodRch"), "")
                .Rows(wp_nRow).Cells("sNroLot").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNroLot")), wp_DT.Rows(wp_nRow).Item("sNroLot"), "")
                .Rows(wp_nRow).Cells("nSdoAlm").Value = 0
                .Rows(wp_nRow).Cells("nSdoInv").Value = 0
                .Rows(wp_nRow).Cells("nSdoCanLin").Value = 0
                .Rows(wp_nRow).Cells("nPesProm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesProm")), wp_DT.Rows(wp_nRow).Item("nPesProm"), 0)
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = 0
                .Rows(wp_nRow).Cells("bIndCan").Value = False
                .Rows(wp_nRow).Cells("bIndCos").Value = False
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTeILMOV1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_aeGEMOV(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV(wp_VlrCtrl,
                                   wl_aeGEMOV(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eGEMOV As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nID").Value = wp_eGEMOV.nID
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eGEMOV.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_eGEMOV.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eGEMOV.sCodSer
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eGEMOV.sCodTra
                .Rows(wp_nRow).Cells("sEstDoc").Value = wp_eGEMOV.sEstDoc
                .Rows(wp_nRow).Cells("sTipMov").Value = wp_eGEMOV.sTipMov
                .Rows(wp_nRow).Cells("dFecCtb").Value = wp_eGEMOV.dFecCtb
                .Rows(wp_nRow).Cells("dFecDoc").Value = wp_eGEMOV.dFecDoc
                .Rows(wp_nRow).Cells("dFecVto").Value = wp_eGEMOV.dFecVto
                .Rows(wp_nRow).Cells("dFecSys").Value = wp_eGEMOV.dFecSys
                .Rows(wp_nRow).Cells("sCodTer").Value = wp_eGEMOV.sCodTer
                .Rows(wp_nRow).Cells("sNomTer").Value = wp_eGEMOV.sNomTer
                .Rows(wp_nRow).Cells("nPorDto").Value = wp_eGEMOV.nPorDto
                .Rows(wp_nRow).Cells("sAlmOri").Value = wp_eGEMOV.sAlmOri
                .Rows(wp_nRow).Cells("sDocRef").Value = wp_eGEMOV.sDocRef
                .Rows(wp_nRow).Cells("nTotBas").Value = wp_eGEMOV.nTotBas
                .Rows(wp_nRow).Cells("nTotDto").Value = wp_eGEMOV.nTotDto
                .Rows(wp_nRow).Cells("nTotGtoAdi").Value = wp_eGEMOV.nTotGtoAdi
                .Rows(wp_nRow).Cells("nTotIvaCom").Value = wp_eGEMOV.nTotIvaCom
                .Rows(wp_nRow).Cells("nTotIvaVta").Value = wp_eGEMOV.nTotIvaVta
                .Rows(wp_nRow).Cells("nVlrRdd").Value = wp_eGEMOV.nVlrRdd
                .Rows(wp_nRow).Cells("nTotDoc").Value = wp_eGEMOV.nTotDoc '20
                .Rows(wp_nRow).Cells("sCodDocBas").Value = wp_eGEMOV.sCodDocBas
                .Rows(wp_nRow).Cells("nNroDocBas").Value = wp_eGEMOV.nNroDocBas
                .Rows(wp_nRow).Cells("sCndPag").Value = wp_eGEMOV.sCndPag
                .Rows(wp_nRow).Cells("sClsDoc").Value = wp_eGEMOV.sClsDoc
                .Rows(wp_nRow).Cells("sTipDoc").Value = wp_eGEMOV.sTipDoc
                .Rows(wp_nRow).Cells("sCodVen").Value = wp_eGEMOV.sCodVen
                .Rows(wp_nRow).Cells("sDirTer").Value = wp_eGEMOV.sDirTer
                .Rows(wp_nRow).Cells("sCiuter").Value = wp_eGEMOV.sCiuter
                .Rows(wp_nRow).Cells("sDepTer").Value = wp_eGEMOV.sDepTer '30
                .Rows(wp_nRow).Cells("sPaiTer").Value = wp_eGEMOV.sPaiTer
                .Rows(wp_nRow).Cells("sCmn").Value = wp_eGEMOV.sCmn
                .Rows(wp_nRow).Cells("sCodCteCtb").Value = wp_eGEMOV.sCodCteCtb
                .Rows(wp_nRow).Cells("nNroCteCtb").Value = wp_eGEMOV.nNroCteCtb
                .Rows(wp_nRow).Cells("nIdFECCT").Value = wp_eGEMOV.nIdFECCT
                .Rows(wp_nRow).Cells("sNitTer").Value = wp_eGEMOV.sNitTer
                .Rows(wp_nRow).Cells("sCodMon").Value = wp_eGEMOV.sCodMon
                .Rows(wp_nRow).Cells("sCodUsr").Value = wp_eGEMOV.sCodUsr
                .Rows(wp_nRow).Cells("sCodAut").Value = wp_eGEMOV.sCodAut
                .Rows(wp_nRow).Cells("bPrp01").Value = wp_eGEMOV.bPrp01
                .Rows(wp_nRow).Cells("bPrp02").Value = wp_eGEMOV.bPrp02
                .Rows(wp_nRow).Cells("bPrp03").Value = wp_eGEMOV.bPrp03
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QCodDoc(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QCodDoc(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QCodDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QCodDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGEMOV As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eGEMOV.sCodDoc

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV_QCodDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QCodSer(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QCodSer(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QCodSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QCodSer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGEMOV As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eGEMOV.sCodSer

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV_QCodSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QCodTer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QCodTer(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QCodTer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QCodTer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGEMOV As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodTer").Value = wp_eGEMOV.sCodTer
                .Rows(wp_nRow).Cells("sNomTer").Value = wp_eGEMOV.sNomTer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV_QCodTer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QCodTra(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QCodTra(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QCodTra")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QCodTra(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGEMOV As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eGEMOV.sCodTra

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV_QCodTra")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QEstDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QEstDoc(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QEstDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QEstDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGEMOV As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sEstDoc").Value = wp_eGEMOV.sEstDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV_QEstDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QNroDoc(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QNroDoc(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QNroDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QNroDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGEMOV As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_eGEMOV.nNroDoc

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGEMOV_QNroDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGEMOV_QTipMov(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_eaGEMOV As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGEMOV)
            Dim wl_aeGEMOV(wl_nCntReg) As moe_Estructuras.eGEMOV
            wl_aeGEMOV = wp_eaGEMOV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGEMOV_QTipMov(wp_VlrCtrl,
                                           wl_aeGEMOV(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_QTipMov")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGEMOV_QTipMov(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eGEMOV As Object,
                                       ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sTipMov").Value = wp_eGEMOV.sTipMov

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGEMOV_qTipMov")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGEMOV_DGV(ByRef wp_aGEMOV As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wl_nRow As Integer)
        Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
        Try
            With wp_VlrCtrl
                wl_eGEMOV.nID = .Rows(wl_nRow).Cells("nID").Value
                wl_eGEMOV.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_eGEMOV.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_eGEMOV.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_eGEMOV.sCodTra = .Rows(wl_nRow).Cells("sCodTra").Value
                wl_eGEMOV.sEstDoc = .Rows(wl_nRow).Cells("sEstDoc").Value
                wl_eGEMOV.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
                wl_eGEMOV.dFecCtb = .Rows(wl_nRow).Cells("dFecCtb").Value
                wl_eGEMOV.dFecDoc = .Rows(wl_nRow).Cells("dFecDoc").Value
                wl_eGEMOV.dFecVto = .Rows(wl_nRow).Cells("dFecVto").Value
                wl_eGEMOV.dFecSys = .Rows(wl_nRow).Cells("dFecSys").Value
                wl_eGEMOV.sCodTer = .Rows(wl_nRow).Cells("sCodTer").Value
                wl_eGEMOV.sNomTer = .Rows(wl_nRow).Cells("sNomTer").Value
                wl_eGEMOV.nPorDto = .Rows(wl_nRow).Cells("nPorDto").Value
                wl_eGEMOV.sAlmOri = .Rows(wl_nRow).Cells("sAlmOri").Value
                wl_eGEMOV.sDocRef = .Rows(wl_nRow).Cells("sDocRef").Value
                wl_eGEMOV.nTotBas = .Rows(wl_nRow).Cells("nTotBas").Value
                wl_eGEMOV.nTotDto = .Rows(wl_nRow).Cells("nTotDto").Value
                wl_eGEMOV.nTotGtoAdi = .Rows(wl_nRow).Cells("nTotGtoAdi").Value
                wl_eGEMOV.nTotIvaCom = .Rows(wl_nRow).Cells("nTotIvaCom").Value
                wl_eGEMOV.nTotIvaVta = .Rows(wl_nRow).Cells("nTotIvaVta").Value
                wl_eGEMOV.nVlrRdd = .Rows(wl_nRow).Cells("nVlrRdd").Value
                wl_eGEMOV.nTotDoc = .Rows(wl_nRow).Cells("nTotDoc").Value
                wl_eGEMOV.sCodDocBas = .Rows(wl_nRow).Cells("sCodDocBas").Value
                wl_eGEMOV.nNroDocBas = .Rows(wl_nRow).Cells("nNroDocBas").Value
                wl_eGEMOV.sCndPag = .Rows(wl_nRow).Cells("sCndPag").Value
                wl_eGEMOV.sClsDoc = .Rows(wl_nRow).Cells("sClsDoc").Value
                wl_eGEMOV.sTipDoc = .Rows(wl_nRow).Cells("sTipDoc").Value
                wl_eGEMOV.sCodVen = .Rows(wl_nRow).Cells("sCodVen").Value
                wl_eGEMOV.sDirTer = .Rows(wl_nRow).Cells("sDirTer").Value
                wl_eGEMOV.sCiuter = .Rows(wl_nRow).Cells("sCiuter").Value
                wl_eGEMOV.sDepTer = .Rows(wl_nRow).Cells("sDepTer").Value
                wl_eGEMOV.sPaiTer = .Rows(wl_nRow).Cells("sPaiTer").Value
                wl_eGEMOV.sCmn = .Rows(wl_nRow).Cells("sCmn").Value
                wl_eGEMOV.sCodCteCtb = .Rows(wl_nRow).Cells("sCodCteCtb").Value
                wl_eGEMOV.nNroCteCtb = .Rows(wl_nRow).Cells("nNroCteCtb").Value
                wl_eGEMOV.nIdFECCT = .Rows(wl_nRow).Cells("nIdFECCT").Value
                wl_eGEMOV.sNitTer = .Rows(wl_nRow).Cells("sNitTer").Value
                wl_eGEMOV.sCodMon = .Rows(wl_nRow).Cells("sCodMon").Value
                wl_eGEMOV.sCodUsr = .Rows(wl_nRow).Cells("sCodUsr").Value
                wl_eGEMOV.sCodAut = .Rows(wl_nRow).Cells("sCodAut").Value
                wl_eGEMOV.bPrp01 = .Rows(wl_nRow).Cells("bPrp01").Value
                wl_eGEMOV.bPrp02 = .Rows(wl_nRow).Cells("bPrp02").Value
                wl_eGEMOV.bPrp03 = .Rows(wl_nRow).Cells("bPrp03").Value
            End With
            wp_aGEMOV = wl_eGEMOV
        Catch ex As Exception
            MsgBox("Error : moo_eGEMOV_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_DGV(ByRef wp_aGELMOV1 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.nID = .Rows(wl_nRow).Cells("nID").Value
                wl_eGELMOV1.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_eGELMOV1.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_eGELMOV1.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_eGELMOV1.sCodTra = .Rows(wl_nRow).Cells("sCodTra").Value
                wl_eGELMOV1.sEstDoc = .Rows(wl_nRow).Cells("sEstDoc").Value
                wl_eGELMOV1.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
                wl_eGELMOV1.dFecCtb = .Rows(wl_nRow).Cells("dFecCtb").Value
                wl_eGELMOV1.dFecDoc = .Rows(wl_nRow).Cells("dFecDoc").Value
                wl_eGELMOV1.dFecVto = .Rows(wl_nRow).Cells("dFecVto").Value
                wl_eGELMOV1.dFecSys = .Rows(wl_nRow).Cells("dFecSys").Value
                wl_eGELMOV1.sCodTer = .Rows(wl_nRow).Cells("sCodTer").Value
                wl_eGELMOV1.sNomTer = .Rows(wl_nRow).Cells("sNomTer").Value
                wl_eGELMOV1.nPorDto = .Rows(wl_nRow).Cells("nPorDto").Value
                wl_eGELMOV1.sAlmOri = .Rows(wl_nRow).Cells("sAlmOri").Value
                wl_eGELMOV1.sDocRef = .Rows(wl_nRow).Cells("sDocRef").Value
                wl_eGELMOV1.nTotBas = .Rows(wl_nRow).Cells("nTotBas").Value
                wl_eGELMOV1.nTotDto = .Rows(wl_nRow).Cells("nTotDto").Value
                wl_eGELMOV1.nTotGtoAdi = .Rows(wl_nRow).Cells("nTotGtoAdi").Value
                wl_eGELMOV1.nTotIvaCom = .Rows(wl_nRow).Cells("nTotIvaCom").Value
                wl_eGELMOV1.nTotIvaVta = .Rows(wl_nRow).Cells("nTotIvaVta").Value
                wl_eGELMOV1.nVlrRdd = .Rows(wl_nRow).Cells("nVlrRdd").Value
                wl_eGELMOV1.nTotDoc = .Rows(wl_nRow).Cells("nTotDoc").Value
                wl_eGELMOV1.sCodDocBas = .Rows(wl_nRow).Cells("sCodDocBas").Value
                wl_eGELMOV1.nNroDocBas = .Rows(wl_nRow).Cells("nNroDocBas").Value
                wl_eGELMOV1.sCndPag = .Rows(wl_nRow).Cells("sCndPag").Value
                wl_eGELMOV1.sClsDoc = .Rows(wl_nRow).Cells("sClsDoc").Value
                wl_eGELMOV1.sTipDoc = .Rows(wl_nRow).Cells("sTipDoc").Value
                wl_eGELMOV1.sCodVen = .Rows(wl_nRow).Cells("sCodVen").Value
                wl_eGELMOV1.sDirTer = .Rows(wl_nRow).Cells("sDirTer").Value
                wl_eGELMOV1.sCiuter = .Rows(wl_nRow).Cells("sCiuter").Value
                wl_eGELMOV1.sDepTer = .Rows(wl_nRow).Cells("sDepTer").Value
                wl_eGELMOV1.sPaiTer = .Rows(wl_nRow).Cells("sPaiTer").Value
                wl_eGELMOV1.sCmn = .Rows(wl_nRow).Cells("sCmn").Value
                wl_eGELMOV1.sCodCteCtb = .Rows(wl_nRow).Cells("sCodCteCtb").Value
                wl_eGELMOV1.nNroCteCtb = .Rows(wl_nRow).Cells("nNroCteCtb").Value
                wl_eGELMOV1.nIdFECCT = .Rows(wl_nRow).Cells("nIdFECCT").Value
                wl_eGELMOV1.sNitTer = .Rows(wl_nRow).Cells("sNitTer").Value
                wl_eGELMOV1.sCodMon = .Rows(wl_nRow).Cells("sCodMon").Value
                wl_eGELMOV1.sCodUsr = .Rows(wl_nRow).Cells("sCodUsr").Value
                wl_eGELMOV1.sCodAut = .Rows(wl_nRow).Cells("sCodAut").Value
                wl_eGELMOV1.bPrp01 = .Rows(wl_nRow).Cells("bPrp01").Value
                wl_eGELMOV1.bPrp02 = .Rows(wl_nRow).Cells("bPrp02").Value
                wl_eGELMOV1.bPrp03 = .Rows(wl_nRow).Cells("bPrp03").Value
                wl_eGELMOV1.xnID = .Rows(wl_nRow).Cells("xnID").Value
                wl_eGELMOV1.xsCodDoc = .Rows(wl_nRow).Cells("xsCodDoc").Value
                wl_eGELMOV1.xnNroDoc = .Rows(wl_nRow).Cells("xnNroDoc").Value
                wl_eGELMOV1.xsCodSer = .Rows(wl_nRow).Cells("xsCodSer").Value
                wl_eGELMOV1.xsTipMov = .Rows(wl_nRow).Cells("xsTipMov").Value
                wl_eGELMOV1.xsCodDocBas = .Rows(wl_nRow).Cells("xsCodDocBas").Value
                wl_eGELMOV1.xsCodSerBas = .Rows(wl_nRow).Cells("xsCodSerBas").Value
                wl_eGELMOV1.xnNroDocBas = .Rows(wl_nRow).Cells("xnNroDocBas").Value
                wl_eGELMOV1.xsCodItm = .Rows(wl_nRow).Cells("xsCodItm").Value
                wl_eGELMOV1.xsNomItm = .Rows(wl_nRow).Cells("xsNomItm").Value
                wl_eGELMOV1.xsNomAlt = .Rows(wl_nRow).Cells("xsNomAlt").Value
                wl_eGELMOV1.xsCodAlm = .Rows(wl_nRow).Cells("xsCodAlm").Value
                wl_eGELMOV1.xnCanItm = .Rows(wl_nRow).Cells("xnCanItm").Value
                wl_eGELMOV1.xsUniMedInv = .Rows(wl_nRow).Cells("xsUniMedInv").Value
                wl_eGELMOV1.xnPreUni = .Rows(wl_nRow).Cells("xnPreUni").Value
                wl_eGELMOV1.xnVlrBas = .Rows(wl_nRow).Cells("xnVlrBas").Value
                wl_eGELMOV1.xnPorDto = .Rows(wl_nRow).Cells("xnPorDto").Value
                wl_eGELMOV1.xnVlrDto = .Rows(wl_nRow).Cells("xnVlrDto").Value
                wl_eGELMOV1.xnPreDto = .Rows(wl_nRow).Cells("xnPreDto").Value
                wl_eGELMOV1.xnVlrDtoLin = .Rows(wl_nRow).Cells("xnVlrDtoLin").Value
                wl_eGELMOV1.xsCodIva = .Rows(wl_nRow).Cells("xsCodIva").Value
                wl_eGELMOV1.xnPorIva = .Rows(wl_nRow).Cells("xnPorIva").Value
                wl_eGELMOV1.xnVlrIva = .Rows(wl_nRow).Cells("xnVlrIva").Value
                wl_eGELMOV1.xnVlrIvaLin = .Rows(wl_nRow).Cells("xnVlrIvaLin").Value
                wl_eGELMOV1.xnPreBru = .Rows(wl_nRow).Cells("xnPreBru").Value
                wl_eGELMOV1.xnTotLin = .Rows(wl_nRow).Cells("xnTotLin").Value
                wl_eGELMOV1.xsCodCco = .Rows(wl_nRow).Cells("xsCodCco").Value
                wl_eGELMOV1.xsTipLIM = .Rows(wl_nRow).Cells("xsTipLIM").Value
                wl_eGELMOV1.xsCodVen = .Rows(wl_nRow).Cells("xsCodVen").Value
                wl_eGELMOV1.xnLinBas = .Rows(wl_nRow).Cells("xnLinBas").Value
                wl_eGELMOV1.xsCodPdo = .Rows(wl_nRow).Cells("xsCodPdo").Value
                wl_eGELMOV1.xsCodCta = .Rows(wl_nRow).Cells("xsCodCta").Value
                wl_eGELMOV1.xbSolIto = .Rows(wl_nRow).Cells("xbSolIto").Value
                wl_eGELMOV1.xsCtaCosVta = .Rows(wl_nRow).Cells("xsCtaCosVta").Value
                wl_eGELMOV1.xbItmBlq = .Rows(wl_nRow).Cells("xbItmBlq").Value
                wl_eGELMOV1.xsClsDoc = .Rows(wl_nRow).Cells("xsClsDoc").Value
                wl_eGELMOV1.xnTasCamUsd = .Rows(wl_nRow).Cells("xnTasCamUsd").Value
                wl_eGELMOV1.xnPreUniUsd = .Rows(wl_nRow).Cells("xnPreUniUsd").Value
                wl_eGELMOV1.xnVlrBasUsd = .Rows(wl_nRow).Cells("xnVlrBasUsd").Value
                wl_eGELMOV1.xsCodRch = .Rows(wl_nRow).Cells("xsCodRch").Value
                wl_eGELMOV1.xsNroLot = .Rows(wl_nRow).Cells("xsNroLot").Value
                wl_eGELMOV1.xnSdoCanLin = .Rows(wl_nRow).Cells("xnSdoCanLin").Value
                wl_eGELMOV1.xnPesProm = .Rows(wl_nRow).Cells("xnPesProm").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodDoc_DGV(ByRef wp_aGELMOV1 As Object,
                                     ByVal wp_VlrCtrl As DataGridView,
                                     ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QCodDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodSer_DGV(ByRef wp_aGELMOV1 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QCodSer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodTra_DGV(ByRef wp_aGELMOV1 As Object,
                                  ByVal wp_VlrCtrl As DataGridView,
                                  ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.sCodTra = .Rows(wl_nRow).Cells("sCodTra").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QCodTra_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodTer_DGV(ByRef wp_aGELMOV1 As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.sCodTer = .Rows(wl_nRow).Cells("sCodTer").Value
                wl_eGELMOV1.sNomTer = .Rows(wl_nRow).Cells("sNomter").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QCodTer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QEstDoc_DGV(ByRef wp_aGELMOV1 As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.sEstDoc = .Rows(wl_nRow).Cells("sEstDoc").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QEstDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QNroDoc_DGV(ByRef wp_aGELMOV1 As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QNroDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QTipMov_DGV(ByRef wp_aGELMOV1 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QTipMov_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eGELMOV1_QCodItm_DGV(ByRef wp_aGELMOV1 As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                      ByVal wl_nRow As Integer)
        Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
        Try
            With wp_VlrCtrl
                wl_eGELMOV1.xsCodItm = .Rows(wl_nRow).Cells("sCodItm").Value
                wl_eGELMOV1.xsNomItm = .Rows(wl_nRow).Cells("sNomItm").Value
            End With
            wp_aGELMOV1 = wl_eGELMOV1
        Catch ex As Exception
            MsgBox("Error : moo_eGELMOV1_QCodItm_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGLMOV1(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eGLMOV1 As Object,
                                    ByVal wl_nRow As Integer)
        Try
            ''Dim wl_nCntReg As Integer
            '  wl_nCntReg = UBound(wp_aeGLMOV1)
            Dim wl_eGLMOV1 As moe_Estructuras.eGLMOV1
            wl_eGLMOV1 = wp_eGLMOV1
            With wp_VlrCtrl
                .Rows(wl_nRow).Cells("nID").Value = wp_eGLMOV1.nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_eGLMOV1.sCodDoc
                .Rows(wl_nRow).Cells("nNrodoc").Value = wp_eGLMOV1.nNrodoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_eGLMOV1.sCodSer
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_eGLMOV1.sTipMov
                .Rows(wl_nRow).Cells("sCodDocBas").Value = wp_eGLMOV1.sCodDocBas
                .Rows(wl_nRow).Cells("sCodSerBas").Value = wp_eGLMOV1.sCodSerBas
                .Rows(wl_nRow).Cells("nNroDocBas").Value = wp_eGLMOV1.nNroDocBas
                .Rows(wl_nRow).Cells("sCodItm").Value = wp_eGLMOV1.sCodItm
                .Rows(wl_nRow).Cells("sNomItm").Value = wp_eGLMOV1.sNomItm
                .Rows(wl_nRow).Cells("sNomAlt").Value = wp_eGLMOV1.sNomAlt
                .Rows(wl_nRow).Cells("sCodAlm").Value = wp_eGLMOV1.sCodAlm
                .Rows(wl_nRow).Cells("nCanItm").Value = wp_eGLMOV1.nCanItm '10
                .Rows(wl_nRow).Cells("sUniMedInv").Value = wp_eGLMOV1.sUniMedInv
                .Rows(wl_nRow).Cells("nPreUni").Value = wp_eGLMOV1.nPreUni
                .Rows(wl_nRow).Cells("nVlrBas").Value = wp_eGLMOV1.nVlrBas
                .Rows(wl_nRow).Cells("nPorDto").Value = wp_eGLMOV1.nPorDto
                .Rows(wl_nRow).Cells("nVlrDto").Value = wp_eGLMOV1.nVlrDto
                .Rows(wl_nRow).Cells("nPreDto").Value = wp_eGLMOV1.nPreDto
                .Rows(wl_nRow).Cells("nVlrDtoLin").Value = wp_eGLMOV1.nVlrDtoLin
                .Rows(wl_nRow).Cells("sCodIva").Value = wp_eGLMOV1.sCodIva
                .Rows(wl_nRow).Cells("nPorIva").Value = wp_eGLMOV1.nPorIva
                .Rows(wl_nRow).Cells("nVlrIva").Value = wp_eGLMOV1.nVlrIva '20
                .Rows(wl_nRow).Cells("nVlrIvaLin").Value = wp_eGLMOV1.nVlrIvaLin
                .Rows(wl_nRow).Cells("nPreBru").Value = wp_eGLMOV1.nPreBru
                .Rows(wl_nRow).Cells("nTotLin").Value = wp_eGLMOV1.nTotLin
                .Rows(wl_nRow).Cells("nPorCms").Value = wp_eGLMOV1.nPorCms
                .Rows(wl_nRow).Cells("sCodCco").Value = wp_eGLMOV1.sCodCco '25
                .Rows(wl_nRow).Cells("sTipLIM").Value = wp_eGLMOV1.sTipLIM
                .Rows(wl_nRow).Cells("sCodVen").Value = wp_eGLMOV1.sCodVen
                .Rows(wl_nRow).Cells("nLinBas").Value = wp_eGLMOV1.nLinBas
                .Rows(wl_nRow).Cells("sCodPdo").Value = wp_eGLMOV1.sCodPdo
                .Rows(wl_nRow).Cells("sCodCta").Value = wp_eGLMOV1.sCodCta '30
                .Rows(wl_nRow).Cells("bSolIto").Value = wp_eGLMOV1.bSolIto
                .Rows(wl_nRow).Cells("sCtaCosVta").Value = wp_eGLMOV1.sCtaCosVta
                .Rows(wl_nRow).Cells("bItmBlq").Value = wp_eGLMOV1.bItmBlq
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_eGLMOV1.sClsDoc
                .Rows(wl_nRow).Cells("nTasCamUsd").Value = wp_eGLMOV1.nTasCamUsd
                .Rows(wl_nRow).Cells("nPreUniUsd").Value = wp_eGLMOV1.nPreUniUsd
                .Rows(wl_nRow).Cells("nVlrBasUsd").Value = wp_eGLMOV1.nVlrBasUsd
                .Rows(wl_nRow).Cells("sCodRch").Value = wp_eGLMOV1.sCodRch
                .Rows(wl_nRow).Cells("sNroLot").Value = wp_eGLMOV1.sNroLot
                .Rows(wl_nRow).Cells("nSdoAlm").Value = wp_eGLMOV1.nSdoalm
                .Rows(wl_nRow).Cells("nSdoInv").Value = wp_eGLMOV1.nSdoInv
                .Rows(wl_nRow).Cells("nSdoCanLin").Value = wp_eGLMOV1.nSdoCanLin
                .Rows(wl_nRow).Cells("nPesProm").Value = wp_eGLMOV1.nPesProm
                .Rows(wl_nRow).Cells("nUltPreEnt").Value = wp_eGLMOV1.nUltPreEnt
                .Rows(wl_nRow).Cells("bIndCan").Value = wp_eGLMOV1.bIndCan
                .Rows(wl_nRow).Cells("bIndCos").Value = wp_eGLMOV1.bIndCos
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_aeGLMOV1(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_aeGLMOV1 As Array)

        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeGLMOV1)
            Dim va_aeGLMOV1(wl_nCntReg) As moe_Estructuras.eGLMOV1
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1

            va_aeGLMOV1 = wp_aeGLMOV1

            For wl_nRow = 0 To wl_nCntReg - 1
                wl_eGLMOV1 = va_aeGLMOV1(wl_nRow)
                moo_DGVGLMOV1_eGLMOV1(wp_VlrCtrl,
                                      wl_eGLMOV1,
                                      wl_nRow)
            Next

        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_aeGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_eGLMOV1(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_eGLMOV1 As Object,
                                     ByVal wp_nRow As Integer)
        'Fec_Ult_Act : 2014-04-24
        Try
            Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
            wl_eGLMOV1 = wp_eGLMOV1

            With wp_VlrCtrl
                '             .Rows.Add()
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nID").Value = wl_eGLMOV1.nID
                .Rows(wp_nRow).Cells("sCodDoc").Value = wl_eGLMOV1.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wl_eGLMOV1.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wl_eGLMOV1.sCodSer
                .Rows(wp_nRow).Cells("sTipMov").Value = wl_eGLMOV1.sTipMov
                .Rows(wp_nRow).Cells("sCodDocBas").Value = wl_eGLMOV1.sCodDocBas
                .Rows(wp_nRow).Cells("sCodSerBas").Value = wl_eGLMOV1.sCodSerBas
                .Rows(wp_nRow).Cells("nNroDocBas").Value = wl_eGLMOV1.nNroDocBas
                .Rows(wp_nRow).Cells("sCodItm").Value = wl_eGLMOV1.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wl_eGLMOV1.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = wl_eGLMOV1.sNomAlt
                .Rows(wp_nRow).Cells("sCodAlm").Value = wl_eGLMOV1.sCodAlm
                .Rows(wp_nRow).Cells("nCanItm").Value = wl_eGLMOV1.nCanItm
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wl_eGLMOV1.sUniMedInv
                .Rows(wp_nRow).Cells("nPreUni").Value = wl_eGLMOV1.nPreUni
                .Rows(wp_nRow).Cells("nVlrBas").Value = wl_eGLMOV1.nVlrBas
                .Rows(wp_nRow).Cells("nPorDto").Value = wl_eGLMOV1.nPorDto
                .Rows(wp_nRow).Cells("nVlrDto").Value = wl_eGLMOV1.nVlrDto
                .Rows(wp_nRow).Cells("nPreDto").Value = wl_eGLMOV1.nPreDto
                .Rows(wp_nRow).Cells("nVlrDtoLin").Value = wl_eGLMOV1.nVlrDtoLin
                .Rows(wp_nRow).Cells("sCodIva").Value = wl_eGLMOV1.sCodIva
                .Rows(wp_nRow).Cells("nPorIva").Value = wl_eGLMOV1.nPorIva
                .Rows(wp_nRow).Cells("nVlrIva").Value = wl_eGLMOV1.nVlrIva
                .Rows(wp_nRow).Cells("nVlrIvaLin").Value = wl_eGLMOV1.nVlrIvaLin
                .Rows(wp_nRow).Cells("nPreBru").Value = wl_eGLMOV1.nPreBru
                .Rows(wp_nRow).Cells("nTotLin").Value = wl_eGLMOV1.nTotLin
                .Rows(wp_nRow).Cells("nSdoAlm").Value = wl_eGLMOV1.nSdoInv
                .Rows(wp_nRow).Cells("nPorCms").Value = wl_eGLMOV1.nPorCms
                .Rows(wp_nRow).Cells("sCodCco").Value = wl_eGLMOV1.sCodCco
                .Rows(wp_nRow).Cells("sTipLIM").Value = wl_eGLMOV1.sTipLIM
                .Rows(wp_nRow).Cells("sCodVen").Value = wl_eGLMOV1.sCodVen
                .Rows(wp_nRow).Cells("nLinBas").Value = wl_eGLMOV1.nLinBas
                .Rows(wp_nRow).Cells("sCodPdo").Value = wl_eGLMOV1.sCodPdo
                .Rows(wp_nRow).Cells("sCodCta").Value = wl_eGLMOV1.sCodCta
                .Rows(wp_nRow).Cells("bSolIto").Value = wl_eGLMOV1.bSolIto
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = wl_eGLMOV1.sCtaCosVta
                .Rows(wp_nRow).Cells("bItmBlq").Value = wl_eGLMOV1.bItmBlq
                .Rows(wp_nRow).Cells("sClsDoc").Value = wl_eGLMOV1.sClsDoc
                .Rows(wp_nRow).Cells("nTasCamUsd").Value = wl_eGLMOV1.nTasCamUsd
                .Rows(wp_nRow).Cells("nPreUniUsd").Value = wl_eGLMOV1.nPreUniUsd
                .Rows(wp_nRow).Cells("nVlrBasUsd").Value = wl_eGLMOV1.nVlrBasUsd
                .Rows(wp_nRow).Cells("sCodRch").Value = wl_eGLMOV1.sCodRch
                .Rows(wp_nRow).Cells("sNroLot").Value = wl_eGLMOV1.sNroLot
                .Rows(wp_nRow).Cells("nSdoAlm").Value = wl_eGLMOV1.nSdoAlm
                .Rows(wp_nRow).Cells("nSdoInv").Value = wl_eGLMOV1.nSdoInv
                .Rows(wp_nRow).Cells("nSdoCanLin").Value = wl_eGLMOV1.nSdoCanLin
                .Rows(wp_nRow).Cells("nPesProm").Value = wl_eGLMOV1.nPesProm
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = wl_eGLMOV1.nUltPreEnt
                .Rows(wp_nRow).Cells("bIndCan").Value = wl_eGLMOV1.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wl_eGLMOV1.bIndCos
            End With
            wp_eGLMOV1 = wl_eGLMOV1
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_eGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1(wp_VlrCtrl,
                                     wl_aeGELMOV1(wl_nRow),
                                     wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eGELMOV1 As Object,
                                    ByVal wl_nRow As Integer)
        Try
            ''Dim wl_nCntReg As Integer
            '  wl_nCntReg = UBound(wp_aeGLMOV1)
            Dim wl_eGELMOV1 As moe_Estructuras.eGELMOV1
            wl_eGELMOV1 = wp_eGELMOV1
            With wp_VlrCtrl
                .Rows(wl_nRow).Cells("nID").Value = wp_eGELMOV1.nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_eGELMOV1.sCodDoc
                .Rows(wl_nRow).Cells("nNroDoc").Value = wp_eGELMOV1.nNroDoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_eGELMOV1.sCodSer
                .Rows(wl_nRow).Cells("sCodTra").Value = wp_eGELMOV1.sCodTra
                .Rows(wl_nRow).Cells("sEstDoc").Value = wp_eGELMOV1.sEstDoc
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_eGELMOV1.sTipMov
                .Rows(wl_nRow).Cells("dFecCtb").Value = wp_eGELMOV1.dFecCtb
                .Rows(wl_nRow).Cells("dFecDoc").Value = wp_eGELMOV1.dFecDoc
                .Rows(wl_nRow).Cells("dFecVto").Value = wp_eGELMOV1.dFecVto
                .Rows(wl_nRow).Cells("dFecSys").Value = wp_eGELMOV1.dFecSys
                .Rows(wl_nRow).Cells("sCodTer").Value = wp_eGELMOV1.sCodTer
                .Rows(wl_nRow).Cells("sNomTer").Value = wp_eGELMOV1.sNomTer
                .Rows(wl_nRow).Cells("nPorDto").Value = wp_eGELMOV1.nPorDto
                .Rows(wl_nRow).Cells("sAlmOri").Value = wp_eGELMOV1.sAlmOri
                .Rows(wl_nRow).Cells("sDocRef").Value = wp_eGELMOV1.sDocRef
                .Rows(wl_nRow).Cells("nTotBas").Value = wp_eGELMOV1.nTotBas
                .Rows(wl_nRow).Cells("nTotDto").Value = wp_eGELMOV1.nTotDto
                .Rows(wl_nRow).Cells("nTotGtoAdi").Value = wp_eGELMOV1.nTotGtoAdi
                .Rows(wl_nRow).Cells("nTotIvaCom").Value = wp_eGELMOV1.nTotIvaCom
                .Rows(wl_nRow).Cells("nTotIvaVta").Value = wp_eGELMOV1.nTotIvaVta
                .Rows(wl_nRow).Cells("nVlrRdd").Value = wp_eGELMOV1.nVlrRdd
                .Rows(wl_nRow).Cells("nTotDoc").Value = wp_eGELMOV1.nTotDoc '20
                .Rows(wl_nRow).Cells("sCodDocBas").Value = wp_eGELMOV1.sCodDocBas
                .Rows(wl_nRow).Cells("nNroDocBas").Value = wp_eGELMOV1.nNroDocBas
                .Rows(wl_nRow).Cells("sCndPag").Value = wp_eGELMOV1.sCndPag
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_eGELMOV1.sClsDoc
                .Rows(wl_nRow).Cells("sTipDoc").Value = wp_eGELMOV1.sTipDoc
                .Rows(wl_nRow).Cells("sCodVen").Value = wp_eGELMOV1.sCodVen
                .Rows(wl_nRow).Cells("sDirTer").Value = wp_eGELMOV1.sDirTer
                .Rows(wl_nRow).Cells("sCiuter").Value = wp_eGELMOV1.sCiuter
                .Rows(wl_nRow).Cells("sDepTer").Value = wp_eGELMOV1.sDepTer '30
                .Rows(wl_nRow).Cells("sPaiTer").Value = wp_eGELMOV1.sPaiTer
                .Rows(wl_nRow).Cells("sCmn").Value = wp_eGELMOV1.sCmn
                .Rows(wl_nRow).Cells("sCodCteCtb").Value = wp_eGELMOV1.sCodCteCtb
                .Rows(wl_nRow).Cells("nNroCteCtb").Value = wp_eGELMOV1.nNroCteCtb
                .Rows(wl_nRow).Cells("nIdFECCT").Value = wp_eGELMOV1.nIdFECCT
                .Rows(wl_nRow).Cells("sNitTer").Value = wp_eGELMOV1.sNitTer
                .Rows(wl_nRow).Cells("sCodMon").Value = wp_eGELMOV1.sCodMon
                .Rows(wl_nRow).Cells("sCodUsr").Value = wp_eGELMOV1.sCodUsr
                .Rows(wl_nRow).Cells("sCodAut").Value = wp_eGELMOV1.sCodAut
                .Rows(wl_nRow).Cells("bPrp01").Value = wp_eGELMOV1.bPrp01
                .Rows(wl_nRow).Cells("bPrp02").Value = wp_eGELMOV1.bPrp02
                .Rows(wl_nRow).Cells("bPrp03").Value = wp_eGELMOV1.bPrp03

                .Rows(wl_nRow).Cells("xnID").Value = wp_eGELMOV1.xnID
                .Rows(wl_nRow).Cells("xsCodDoc").Value = wp_eGELMOV1.xsCodDoc
                .Rows(wl_nRow).Cells("xnNrodoc").Value = wp_eGELMOV1.xnNrodoc
                .Rows(wl_nRow).Cells("xsCodSer").Value = wp_eGELMOV1.xsCodSer
                .Rows(wl_nRow).Cells("xsTipMov").Value = wp_eGELMOV1.xsTipMov
                .Rows(wl_nRow).Cells("xsCodDocBas").Value = wp_eGELMOV1.xsCodDocBas
                .Rows(wl_nRow).Cells("xsCodSerBas").Value = wp_eGELMOV1.xsCodSerBas
                .Rows(wl_nRow).Cells("xnNroDocBas").Value = wp_eGELMOV1.xnNroDocBas
                .Rows(wl_nRow).Cells("xsCodItm").Value = wp_eGELMOV1.xsCodItm
                .Rows(wl_nRow).Cells("xsNomItm").Value = wp_eGELMOV1.xsNomItm
                .Rows(wl_nRow).Cells("xsNomAlt").Value = wp_eGELMOV1.xsNomAlt
                .Rows(wl_nRow).Cells("xsCodAlm").Value = wp_eGELMOV1.xsCodAlm
                .Rows(wl_nRow).Cells("xnCanItm").Value = wp_eGELMOV1.xnCanItm '10
                .Rows(wl_nRow).Cells("xsUniMedInv").Value = wp_eGELMOV1.xsUniMedInv
                .Rows(wl_nRow).Cells("xnPreUni").Value = wp_eGELMOV1.xnPreUni
                .Rows(wl_nRow).Cells("xnVlrBas").Value = wp_eGELMOV1.xnVlrBas
                .Rows(wl_nRow).Cells("xnPorDto").Value = wp_eGELMOV1.xnPorDto
                .Rows(wl_nRow).Cells("xnVlrDto").Value = wp_eGELMOV1.xnVlrDto
                .Rows(wl_nRow).Cells("xnPreDto").Value = wp_eGELMOV1.xnPreDto
                .Rows(wl_nRow).Cells("xnVlrDtoLin").Value = wp_eGELMOV1.xnVlrDtoLin
                .Rows(wl_nRow).Cells("xsCodIva").Value = wp_eGELMOV1.xsCodIva
                .Rows(wl_nRow).Cells("xnPorIva").Value = wp_eGELMOV1.xnPorIva
                .Rows(wl_nRow).Cells("xnVlrIva").Value = wp_eGELMOV1.xnVlrIva '20
                .Rows(wl_nRow).Cells("xnVlrIvaLin").Value = wp_eGELMOV1.xnVlrIvaLin
                .Rows(wl_nRow).Cells("xnPreBru").Value = wp_eGELMOV1.xnPreBru
                .Rows(wl_nRow).Cells("xnTotLin").Value = wp_eGELMOV1.xnTotLin
                .Rows(wl_nRow).Cells("xnPorCms").Value = wp_eGELMOV1.xnPorCms
                .Rows(wl_nRow).Cells("xsCodCco").Value = wp_eGELMOV1.xsCodCco '25
                .Rows(wl_nRow).Cells("xsTipLIM").Value = wp_eGELMOV1.xsTipLIM
                .Rows(wl_nRow).Cells("xsCodVen").Value = wp_eGELMOV1.xsCodVen
                .Rows(wl_nRow).Cells("xnLinBas").Value = wp_eGELMOV1.xnLinBas
                .Rows(wl_nRow).Cells("xsCodPdo").Value = wp_eGELMOV1.xsCodPdo
                .Rows(wl_nRow).Cells("xsCodCta").Value = wp_eGELMOV1.xsCodCta '30
                .Rows(wl_nRow).Cells("xbSolIto").Value = wp_eGELMOV1.xbSolIto
                .Rows(wl_nRow).Cells("xsCtaCosVta").Value = wp_eGELMOV1.xsCtaCosVta
                .Rows(wl_nRow).Cells("xbItmBlq").Value = wp_eGELMOV1.xbItmBlq
                .Rows(wl_nRow).Cells("xsClsDoc").Value = wp_eGELMOV1.xsClsDoc
                .Rows(wl_nRow).Cells("xnTasCamUsd").Value = wp_eGELMOV1.xnTasCamUsd
                .Rows(wl_nRow).Cells("xnPreUniUsd").Value = wp_eGELMOV1.xnPreUniUsd
                .Rows(wl_nRow).Cells("xnVlrBasUsd").Value = wp_eGELMOV1.xnVlrBasUsd
                .Rows(wl_nRow).Cells("xsCodRch").Value = wp_eGELMOV1.xsCodRch
                .Rows(wl_nRow).Cells("xsNroLot").Value = wp_eGELMOV1.xsNroLot
                .Rows(wl_nRow).Cells("xnSdoCanLin").Value = wp_eGELMOV1.xnSdoCanLin
                .Rows(wl_nRow).Cells("xnpesProm").Value = wp_eGELMOV1.xnPesProm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QCodDoc(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QCodDoc(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QCodDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QCodDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eGELMOV1.sCodDoc

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QCodDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QTipMov(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QTipMov(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QTipMov")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QTipMov(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eGELMOV1 As Object,
                                       ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sTipMov").Value = wp_eGELMOV1.sTipMov

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_qTipMov")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QCodSer(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QCodSer(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QCodSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QCodSer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eGELMOV1.sCodSer

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QCodSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QCodTer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QCodTer(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QCodTer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QCodTer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodTer").Value = wp_eGELMOV1.sCodTer
                .Rows(wp_nRow).Cells("sNomTer").Value = wp_eGELMOV1.sNomTer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QCodTer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QCodTra(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QCodTra(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QCodTra")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QCodTra(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eGELMOV1.sCodTra

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QCodTra")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QEstDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QEstDoc(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QEstDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QEstDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sEstDoc").Value = wp_eGELMOV1.sEstDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QEstDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QNroDoc(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QNroDoc(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QNroDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QNroDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_eGELMOV1.nNroDoc

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QNroDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeGELMOV1_QCodItm(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_eaGELMOV1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaGELMOV1)
            Dim wl_aeGELMOV1(wl_nCntReg) As moe_Estructuras.eGELMOV1
            wl_aeGELMOV1 = wp_eaGELMOV1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eGELMOV1_QCodItm(wp_VlrCtrl,
                                           wl_aeGELMOV1(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeGELMOV1_QCodItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eGELMOV1_QCodItm(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eGELMOV1 As Object,
                                       ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eGELMOV1.xsCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eGELMOV1.xsNomItm

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eGELMOV1_QCodItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeKARDEX_DT(ByRef wp_aeKARDEX As Array,
                               ByVal wp_DT1 As DataTable,
                               ByVal wp_dFecDocIni As Date,
                               ByVal wp_dFecDocFin As Date,
                               ByVal wp_eKARDEXSdoAnt As Object)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eKARDEX As New moe_Estructuras.eKARDEX
            Dim wl_sCodItmAnt As String
            Dim wl_nCanItmSdo As Double
            Dim wl_nTotLinSdo As Double

            wl_sCodItmAnt = ""
            wl_nCanItmSdo = 0
            wl_nTotLinSdo = 0

            wl_nCntReg = wp_DT1.Rows.Count + 1
            Dim wl_aeKARDEX(wl_nCntReg) As moe_Estructuras.eKARDEX
            wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
            moo_aeKARDEX_wp_aeKARDEXSdoAnt(wl_aeKARDEX,
                                           wl_sCodItmAnt,
                                           wl_nCanItmSdo,
                                           wl_nTotLinSdo,
                                           wp_dFecDocIni,
                                           wp_dFecDocFin,
                                           wp_eKARDEXSdoAnt)

            For wl_nRow = 0 To wp_DT1.Rows.Count - 1
                wl_aeKARDEX(wl_nRow + 1) = New moe_Estructuras.eKARDEX
                wl_eKARDEX = New moe_Estructuras.eKARDEX
                moo_eKARDEX_DT(wl_eKARDEX,
                              wp_DT1,
                              wl_nRow,
                              wl_sCodItmAnt,
                              wl_nCanItmSdo,
                              wl_nTotLinSdo,
                              wp_dFecDocIni,
                              wp_dFecDocFin)
                wl_aeKARDEX(wl_nRow + 1) = wl_eKARDEX
            Next
            wp_aeKARDEX = wl_aeKARDEX
        Catch ex As Exception
            MsgBox("Error : moo_aeKARDEX_DT")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_aeKARDEX_wp_aeKARDEXSdoAnt(ByRef wp_aeKARDEX As Array,
                                              ByRef wp_sCodItmAnt As String,
                                              ByRef wp_nCanItmSdo As Double,
                                              ByRef wp_nTotLinDto As Double,
                                              ByVal wp_dFecDocIni As Date,
                                              ByVal wp_dFecDocFin As Date,
                                              ByVal wp_eKARDEXSdoAnt As Object)
        Try
            With wp_eKARDEXSdoAnt
                wp_aeKARDEX(0).nId = .nId
                wp_aeKARDEX(0).sCodItm = .sCodItm
                wp_aeKARDEX(0).sNomItm = .sNomItm
                wp_aeKARDEX(0).sNomAlt = .sNomAlt
                wp_aeKARDEX(0).sCodGrp = .sCodGrp
                wp_aeKARDEX(0).sUniMedInv = .sUniMedInv
                wp_aeKARDEX(0).dFecDoc = .dFecDoc
                wp_aeKARDEX(0).sTipMov = .sTipMov
                wp_aeKARDEX(0).sCodDoc = .sCodDoc
                wp_aeKARDEX(0).nNroDoc = .nNroDoc
                wp_aeKARDEX(0).sCodSer = .sCodSer
                wp_aeKARDEX(0).sCodTra = .sCodTra
                wp_aeKARDEX(0).sDocRef = .sDocRef
                wp_aeKARDEX(0).sCodDocBas = .sCodDocBas
                wp_aeKARDEX(0).sCodSerBas = .sCodSerBas
                wp_aeKARDEX(0).nNroDocBas = .nNroDocBas
                wp_aeKARDEX(0).sCodAlm = .sCodAlm
                wp_aeKARDEX(0).nCanItm = .nCanItm
                wp_aeKARDEX(0).nPreUni = .nPreUni
                wp_aeKARDEX(0).nTotLin = .nTotLin
                wp_aeKARDEX(0).sCmn = .sCmn
                wp_aeKARDEX(0).nCanItmEnt = .nCanItmEnt
                wp_aeKARDEX(0).nTotLinEnt = .nTotLinEnt
                wp_aeKARDEX(0).nCanItmSal = .nCanItmSal
                wp_aeKARDEX(0).nTotLinSal = .nTotLinSal
                wp_aeKARDEX(0).nCanItmSdo = .nCanItmSdo
                wp_aeKARDEX(0).nTotLinSdo = .nTotLinSdo
                wp_aeKARDEX(0).dFecDocIni = wp_dFecDocIni
                wp_aeKARDEX(0).dFecDocFin = wp_dFecDocFin
                wp_nCanItmSdo = .nCanItmEnt
                wp_nCanItmSdo = .nCanItmSdo
                wp_nTotLinDto = .nTotLinSdo
                wp_sCodItmAnt = .sCodItm
            End With


        Catch ex As Exception
            MsgBox("Error : moo_aeKARDEX_wp_aeKARDEXSdoAnt")
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub moo_eKARDEX_DT(ByRef wp_eKARDEX As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer,
                              ByRef wp_sCodItmAnt As String,
                              ByRef wp_nCanItmSdo As Double,
                              ByRef wp_nTotLinSdo As Double,
                              ByVal wp_dFecDocIni As Date,
                              ByVal wp_dFecDocFin As Date)

        ' FUA: 2015.06.25
        ' Incluye la actualización del saldo final
        Try
            Dim wl_eKARDEX As New moe_Estructuras.eKARDEX
            With wl_eKARDEX
                If wp_sCodItmAnt = "" Then
                    wp_sCodItmAnt = wp_DT.Rows(wp_nRow).Item("t0.sCodItm")
                End If
                If wp_sCodItmAnt <> wp_DT.Rows(wp_nRow).Item("t0.sCodItm") Then
                    wp_sCodItmAnt = wp_DT.Rows(wp_nRow).Item("t0.sCodItm")
                    wp_nCanItmSdo = 0
                    wp_nTotLinSdo = 0
                End If
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("t0.nId")), wp_DT.Rows(wp_nRow).Item("t0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("t0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomItm")), wp_DT.Rows(wp_nRow).Item("T0.sNomItm"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomAlt")), wp_DT.Rows(wp_nRow).Item("T0.sNomAlt"), "")
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sTipMov")), wp_DT.Rows(wp_nRow).Item("T0.sTipMov"), "")
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .sCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDocBas")), wp_DT.Rows(wp_nRow).Item("T0.sCodDocBas"), "")
                .sCodSerBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .nNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDocBas")), wp_DT.Rows(wp_nRow).Item("T0.nNroDocBas"), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), 0)
                .nCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .nTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                If wp_DT.Rows(wp_nRow).Item("T0.sTipMov") = "E" Then
                    .nCanItmEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                    .nTotLinEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                    .nCanItmSal = 0
                    .nTotLinSal = 0
                    wp_nCanItmSdo = wp_nCanItmSdo + wp_DT.Rows(wp_nRow).Item("nCanItm")
                    wp_nTotLinSdo = wp_nTotLinSdo + wp_DT.Rows(wp_nRow).Item("nTotLin")

                End If
                If wp_DT.Rows(wp_nRow).Item("T0.sTipMov") = "S" Then
                    .nCanItmEnt = 0
                    .nTotLinEnt = 0
                    .nCanItmSal = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                    .nTotLinSal = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                    wp_nCanItmSdo = wp_nCanItmSdo - wp_DT.Rows(wp_nRow).Item("nCanItm")
                    wp_nTotLinSdo = wp_nTotLinSdo - wp_DT.Rows(wp_nRow).Item("nTotLin")
                End If
                .nCanItmSdo = wp_nCanItmSdo
                .nTotLinSdo = wp_nTotLinSdo
                .dFecDocIni = wp_dFecDocIni
                .dFecDocFin = wp_dFecDocFin
            End With
            wp_eKARDEX = wl_eKARDEX
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eKARDEX_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeKARDEX(ByVal wp_VlrCtrl As DataGridView,
                                ByVal wp_aeKARDEX As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeKARDEX)
            Dim wl_aeKARDEX(wl_nCntReg) As moe_Estructuras.eKARDEX
            wl_aeKARDEX = wp_aeKARDEX
            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eKARDEX(wp_VlrCtrl,
                                    wl_aeKARDEX(wl_nRow),
                                    wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeKARDEX_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eKARDEX(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eKARDEX As Object,
                               ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nID").Value = wp_eKARDEX.nID
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eKARDEX.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eKARDEX.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = wp_eKARDEX.sNomAlt
                .Rows(wp_nRow).Cells("sCodGrp").Value = wp_eKARDEX.sCodGrp
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_eKARDEX.sUniMedInv
                .Rows(wp_nRow).Cells("dFecDoc").Value = wp_eKARDEX.dFecDoc
                .Rows(wp_nRow).Cells("sTipMov").Value = wp_eKARDEX.sTipMov
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eKARDEX.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_eKARDEX.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eKARDEX.sCodSer
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eKARDEX.sCodTra
                .Rows(wp_nRow).Cells("sDocRef").Value = wp_eKARDEX.sDocRef
                .Rows(wp_nRow).Cells("sCodDocBas").Value = wp_eKARDEX.sCodDocBas
                .Rows(wp_nRow).Cells("sCodSerBas").Value = wp_eKARDEX.sCodSerBas
                .Rows(wp_nRow).Cells("nNroDocBas").Value = wp_eKARDEX.nNroDocBas
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_eKARDEX.sCodAlm
                .Rows(wp_nRow).Cells("nCanItm").Value = wp_eKARDEX.nCanItm
                .Rows(wp_nRow).Cells("nPreUni").Value = wp_eKARDEX.nPreUni
                .Rows(wp_nRow).Cells("nTotLin").Value = wp_eKARDEX.nTotLin
                .Rows(wp_nRow).Cells("sCmn").Value = wp_eKARDEX.sCmn
                .Rows(wp_nRow).Cells("nCanItmEnt").Value = wp_eKARDEX.nCanItmEnt
                .Rows(wp_nRow).Cells("nTotLinEnt").Value = wp_eKARDEX.nTotLinEnt
                .Rows(wp_nRow).Cells("nCanItmSal").Value = wp_eKARDEX.nCanItmSal
                .Rows(wp_nRow).Cells("nTotLinSal").Value = wp_eKARDEX.nTotLinSal
                .Rows(wp_nRow).Cells("nCanItmSdo").Value = wp_eKARDEX.nCanItmSdo
                .Rows(wp_nRow).Cells("nTotLinSdo").Value = wp_eKARDEX.nTotLinSdo
                .Rows(wp_nRow).Cells("dFecDocIni").Value = wp_eKARDEX.dFecDocIni
                .Rows(wp_nRow).Cells("dFecDocFin").Value = wp_eKARDEX.dFecDocFin
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eKARDEX")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eKARDEX_DGV(ByRef wp_aKARDEX As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wl_nRow As Integer)

        Dim wl_eKARDEX As New moe_Estructuras.eKARDEX
        Try
            With wp_VlrCtrl
                wl_eKARDEX.nId = .Rows(wl_nRow).Cells("nID").Value
                wl_eKARDEX.sCodItm = .Rows(wl_nRow).Cells("sCodItm").Value
                wl_eKARDEX.sNomItm = .Rows(wl_nRow).Cells("sNomItm").Value
                wl_eKARDEX.sNomAlt = .Rows(wl_nRow).Cells("sNomAlt").Value
                wl_eKARDEX.sCodGrp = .Rows(wl_nRow).Cells("sCodGrp").Value
                wl_eKARDEX.sUniMedInv = .Rows(wl_nRow).Cells("sUniMedInv").Value
                wl_eKARDEX.dFecDoc = .Rows(wl_nRow).Cells("dFecDoc").Value
                wl_eKARDEX.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
                wl_eKARDEX.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_eKARDEX.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_eKARDEX.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_eKARDEX.sCodTra = .Rows(wl_nRow).Cells("sCodTra").Value
                wl_eKARDEX.sDocRef = .Rows(wl_nRow).Cells("sDocRef").Value
                wl_eKARDEX.sCodDocBas = .Rows(wl_nRow).Cells("sCodDocBas").Value
                wl_eKARDEX.sCodSerBas = .Rows(wl_nRow).Cells("sCodSerBas").Value
                wl_eKARDEX.nNroDocBas = .Rows(wl_nRow).Cells("nNroDocBas").Value
                wl_eKARDEX.sCodAlm = .Rows(wl_nRow).Cells("sCodAlm").Value
                wl_eKARDEX.nCanItm = .Rows(wl_nRow).Cells("nCanItm").Value
                wl_eKARDEX.nPreUni = .Rows(wl_nRow).Cells("nPreUni").Value
                wl_eKARDEX.nTotLin = .Rows(wl_nRow).Cells("nTotLin").Value
                wl_eKARDEX.sCmn = .Rows(wl_nRow).Cells("sCmn").Value
                wl_eKARDEX.nCanItmEnt = .Rows(wl_nRow).Cells("nCanItmEnt").Value
                wl_eKARDEX.nTotLinEnt = .Rows(wl_nRow).Cells("nTotLinEnt").Value
                wl_eKARDEX.nCanItmSal = .Rows(wl_nRow).Cells("nCanItmSal").Value
                wl_eKARDEX.nTotLinSal = .Rows(wl_nRow).Cells("nTotLinSal").Value
                wl_eKARDEX.nCanItmSdo = .Rows(wl_nRow).Cells("nCanItmSdo").Value
                wl_eKARDEX.nTotLinSdo = .Rows(wl_nRow).Cells("nTotLinSdo").Value
                wl_eKARDEX.dFecDocIni = .Rows(wl_nRow).Cells("dFecDocIni").Value
                wl_eKARDEX.dFecDocFin = .Rows(wl_nRow).Cells("dFecDocFin").Value
            End With
            wp_aKARDEX = wl_eKARDEX

        Catch ex As Exception
            MsgBox("Error : moo_eKARDEX_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeKARDEXSdoAnt_DT(ByRef wp_aeKARDEX As Object,
                                     ByVal wp_DT1 As DataTable,
                                     ByVal wp_dFecDocIni As Date,
                                     ByVal wp_dFecDocFin As Date)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eKARDEX As New moe_Estructuras.eKARDEX
            Dim wl_sCodItmAnt As String
            Dim wl_nCanItmSdo As Double
            Dim wl_nTotLinSdo As Double

            wl_sCodItmAnt = ""
            wl_nCanItmSdo = 0
            wl_nTotLinSdo = 0

            wl_nCntReg = wp_DT1.Rows.Count - 1
            Dim wl_aeKARDEX(wl_nCntReg) As moe_Estructuras.eKARDEX
            For wl_nRow = 0 To wp_DT1.Rows.Count - 1
                wl_aeKARDEX(wl_nRow) = New moe_Estructuras.eKARDEX
                wl_eKARDEX = New moe_Estructuras.eKARDEX
                moo_eKARDEXSdoAnt_DT(wl_eKARDEX,
                                    wp_DT1,
                                    wl_nRow,
                                    wl_sCodItmAnt,
                                    wl_nCanItmSdo,
                                    wl_nTotLinSdo,
                                    wp_dFecDocIni,
                                    wp_dFecDocFin)
                wl_aeKARDEX(wl_nRow) = wl_eKARDEX
            Next
            wp_aeKARDEX = wl_aeKARDEX
        Catch ex As Exception
            MsgBox("Error : moo_aeKARDEXSdoAnt_DT")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_eKARDEXSdoAnt_DT(ByRef wp_eKARDEX As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer,
                              ByRef wp_sCodItmAnt As String,
                              ByRef wp_nCanItmSdo As Double,
                              ByRef wp_nTotLinSdo As Double,
                              ByVal wp_dFecDocIni As Date,
                              ByVal wp_dFecDocFin As Date)

        ' FUA: 2015.06.25
        ' Incluye la actualización del saldo final
        Try
            Dim wl_eKARDEX As New moe_Estructuras.eKARDEX
            Dim wl_nCanItmEnt As Double
            Dim wl_nTotLinEnt As Double
            Dim wl_nCanItmSal As Double
            Dim wl_nTotLinSal As Double
            wp_nCanItmSdo = 0
            wp_nTotLinSdo = 0
            With wl_eKARDEX
                If wp_sCodItmAnt = "" Then
                    wp_sCodItmAnt = wp_DT.Rows(wp_nRow).Item("sCodItm")
                End If
                If wp_sCodItmAnt <> wp_DT.Rows(wp_nRow).Item("sCodItm") Then
                    wp_sCodItmAnt = wp_DT.Rows(wp_nRow).Item("sCodItm")
                    wp_nCanItmSdo = 0
                    wp_nTotLinSdo = 0
                End If
                .nId = 0
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = ""
                .sNomAlt = ""
                .sCodGrp = ""
                .sUniMedInv = ""
                .dFecDoc = wp_dFecDocIni
                .sTipMov = ""
                .sCodDoc = ""
                .nNroDoc = 0
                .sCodSer = ""
                .sCodTra = ""
                .sDocRef = ""
                .sCodDocBas = ""
                .sCodSerBas = ""
                .nNroDocBas = 0
                .sCodAlm = ""
                .nCanItm = 0
                .nPreUni = 0
                .nTotLin = 0
                .sCmn = ""
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .nCanItmEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItmEnt")), wp_DT.Rows(wp_nRow).Item("nCanItmEnt"), 0)
                .nTotLinEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLinEnt")), wp_DT.Rows(wp_nRow).Item("nTotLinEnt"), 0)
                .nCanItmSal = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItmSal")), wp_DT.Rows(wp_nRow).Item("nCanItmSal"), 0)
                .nTotLinSal = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLinSal")), wp_DT.Rows(wp_nRow).Item("nTotLinSal"), 0)
                wl_nCanItmEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItmEnt")), wp_DT.Rows(wp_nRow).Item("nCanItmEnt"), 0)
                wl_nTotLinEnt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLinEnt")), wp_DT.Rows(wp_nRow).Item("nTotLinEnt"), 0)
                wl_nCanItmSal = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItmSal")), wp_DT.Rows(wp_nRow).Item("nCanItmSal"), 0)
                wl_nTotLinSal = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLinSal")), wp_DT.Rows(wp_nRow).Item("nTotLinSal"), 0)
                wp_nCanItmSdo = wl_nCanItmEnt - wl_nCanItmSal
                wp_nTotLinSdo = wl_nTotLinEnt - wl_nTotLinSal
                .nCanItmSdo = wp_nCanItmSdo
                .nTotLinSdo = wp_nTotLinSdo
                .dFecDocIni = wp_dFecDocIni
                .dFecDocFin = wp_dFecDocFin
            End With
            wp_eKARDEX = wl_eKARDEX
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eKARDEXSdoAnt_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeKARDEX_eKARDEXSdoAnt(ByRef wp_aeKARDEX As Array,
                                          ByVal wp_eKARDEX As Object)

        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_aeKARDEX.Length + 1
            If wp_aeKARDEX(0).sCodItm <> "" Then
                wl_nCntReg = wp_aeKARDEX.Length + 1
            Else
                wl_nCntReg = 1
            End If

            Dim wl_aeKARDEX(wl_nCntReg) As moe_Estructuras.eKARDEX

            wl_aeKARDEX(0) = wp_eKARDEX
            For wl_nRow = 1 To wl_nCntReg - 1
                With wp_aeKARDEX
                    wl_aeKARDEX(wl_nRow) = wp_aeKARDEX(wl_nRow - 1)
                End With
            Next
            wp_aeKARDEX = wl_aeKARDEX

        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_aeKARDEX_eKARDEXSdoAnt")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "IEREV"
    Public Sub moo_aeIEREV_DT(ByRef wp_aeIEREV As Object,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eIEREV As New moe_Estructuras.eIEREV
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeIEREV(wl_nCntReg) As moe_Estructuras.eIEREV

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeIEREV(wl_nRow) = New moe_Estructuras.eIEREV
                wl_eIEREV = New moe_Estructuras.eIEREV
                moo_eIEREV_DT(wl_eIEREV,
                              wp_DT,
                              wl_nRow)
                wl_aeIEREV(wl_nRow) = wl_eIEREV
            Next
            wp_aeIEREV = wl_aeIEREV
        Catch ex As Exception
            MsgBox("Error : moo_aeIEREV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEREV_DT(ByRef wp_eIEREV As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eIEREV As New moe_Estructuras.eIEREV
            With wl_eIEREV
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodTra = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTra")), wp_DT.Rows(wp_nRow).Item("sCodTra"), "")
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .sTipRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipRev")), wp_DT.Rows(wp_nRow).Item("sTipRev"), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecCtb")), wp_DT.Rows(wp_nRow).Item("dFecCtb"), #1/1/1901#)
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecVto")), wp_DT.Rows(wp_nRow).Item("dFecVto"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .nTotDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDoc")), wp_DT.Rows(wp_nRow).Item("nTotDoc"), 0)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                .sCodCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCteCtb")), wp_DT.Rows(wp_nRow).Item("sCodCteCtb"), "")
                .nNroCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCteCtb")), wp_DT.Rows(wp_nRow).Item("nNroCteCtb"), 0)
                .nIdFECCT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdFECCT")), wp_DT.Rows(wp_nRow).Item("nIdFECCT"), 0)
                .sCodMon = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodMon")), wp_DT.Rows(wp_nRow).Item("sCodMon"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sCodAut = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAut")), wp_DT.Rows(wp_nRow).Item("sCodAut"), "")
            End With
            wp_eIEREV = wl_eIEREV
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eIEREV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeIEREV(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aeIEREV As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeIEREV)
            Dim wl_aeIEREV(wl_nCntReg) As moe_Estructuras.eIEREV
            wl_aeIEREV = wp_aeIEREV
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eIEREV(wp_VlrCtrl,
                                   wl_aeIEREV(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeIEREV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTeILREV1(ByRef wp_VlrCtrl As DataGridView,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)

        'Fecha última actualización: 2015.07.10
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0) '0
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .Rows(wp_nRow).Cells("sTipRev").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipRev")), wp_DT.Rows(wp_nRow).Item("sTipRev"), "")
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomItm")), wp_DT.Rows(wp_nRow).Item("T0.sNomItm"), "")
                .Rows(wp_nRow).Cells("sNomAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sNomAlt")), wp_DT.Rows(wp_nRow).Item("T0.sNomAlt"), "")
                .Rows(wp_nRow).Cells("sCodAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), "")
                .Rows(wp_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0) '10
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv"), "")
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .Rows(wp_nRow).Cells("nPreAnt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreAnt")), wp_DT.Rows(wp_nRow).Item("nPreAnt"), 0)
                .Rows(wp_nRow).Cells("nDifPre").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nDifPre")), wp_DT.Rows(wp_nRow).Item("nDifPre"), 0)
                .Rows(wp_nRow).Cells("nTotLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .Rows(wp_nRow).Cells("sCodPdo").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .Rows(wp_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("T0.sCtaCosVta"), "")
                .Rows(wp_nRow).Cells("sCtaAumInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaAumInv")), wp_DT.Rows(wp_nRow).Item("T0.sCtaAumInv"), "")
                .Rows(wp_nRow).Cells("sCtaRedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCtaRedInv")), wp_DT.Rows(wp_nRow).Item("T0.sCtaRedInv"), "")
                .Rows(wp_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")

                .Rows(wp_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .Rows(wp_nRow).Cells("nSdoInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .Rows(wp_nRow).Cells("nUltPreEnt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.nUltPreEnt")), wp_DT.Rows(wp_nRow).Item("T2.nUltPreEnt"), 0)
                .Rows(wp_nRow).Cells("bIndCan").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .Rows(wp_nRow).Cells("bIndCos").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTeILREV1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_eIEREV(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_eIEREV As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nID").Value = wp_eIEREV.nID
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_eIEREV.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_eIEREV.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_eIEREV.sCodSer
                .Rows(wp_nRow).Cells("sCodTra").Value = wp_eIEREV.sCodTra
                .Rows(wp_nRow).Cells("sEstDoc").Value = wp_eIEREV.sEstDoc
                .Rows(wp_nRow).Cells("sTipRev").Value = wp_eIEREV.sTipRev
                .Rows(wp_nRow).Cells("dFecCtb").Value = wp_eIEREV.dFecCtb
                .Rows(wp_nRow).Cells("dFecDoc").Value = wp_eIEREV.dFecDoc
                .Rows(wp_nRow).Cells("dFecVto").Value = wp_eIEREV.dFecVto
                .Rows(wp_nRow).Cells("dFecSys").Value = wp_eIEREV.dFecSys
                .Rows(wp_nRow).Cells("sDocRef").Value = wp_eIEREV.sDocRef
                .Rows(wp_nRow).Cells("nTotDoc").Value = wp_eIEREV.nTotDoc
                .Rows(wp_nRow).Cells("sClsDoc").Value = wp_eIEREV.sClsDoc
                .Rows(wp_nRow).Cells("sCmn").Value = wp_eIEREV.sCmn
                .Rows(wp_nRow).Cells("sCodCteCtb").Value = wp_eIEREV.sCodCteCtb
                .Rows(wp_nRow).Cells("nNroCteCtb").Value = wp_eIEREV.nNroCteCtb
                .Rows(wp_nRow).Cells("nIdFECCT").Value = wp_eIEREV.nIdFECCT
                .Rows(wp_nRow).Cells("sCodMon").Value = wp_eIEREV.sCodMon
                .Rows(wp_nRow).Cells("sCodUsr").Value = wp_eIEREV.sCodUsr
                .Rows(wp_nRow).Cells("sCodAut").Value = wp_eIEREV.sCodAut
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eIEREV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVILREV1_eIELDMI1(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_eIELDMI1 As Object,
                                      ByVal wp_nRow As Integer)
        Try

            Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
            wl_eIELDMI1 = wp_eIELDMI1
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodItm").Value = wl_eIELDMI1.eIEDMI.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wl_eIELDMI1.eIEDMI.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = wl_eIELDMI1.eIEDMI.sNomAlt
                .Rows(wp_nRow).Cells("sCodAlm").Value = wl_eIELDMI1.eILDMI1.sCodAlm
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wl_eIELDMI1.eIEDMI.sUniMedInv
                .Rows(wp_nRow).Cells("nPreUni").Value = wl_eIELDMI1.eILDMI1.nPreUni
                .Rows(wp_nRow).Cells("nPreAnt").Value = wl_eIELDMI1.eILDMI1.nPreUni
                .Rows(wp_nRow).Cells("nSdoAlm").Value = wl_eIELDMI1.eILDMI1.nSdoAlm
                .Rows(wp_nRow).Cells("sCodCta").Value = wl_eIELDMI1.eILDMI1.sCtaInv
                .Rows(wp_nRow).Cells("sCtaCosVta").Value = wl_eIELDMI1.eILDMI1.sCtaCosVta
                .Rows(wp_nRow).Cells("sCtaAumInv").Value = wl_eIELDMI1.eILDMI1.sCtaAumInv
                .Rows(wp_nRow).Cells("sCtaRedInv").Value = wl_eIELDMI1.eILDMI1.sCtaRedInv
                .Rows(wp_nRow).Cells("bIndCan").Value = wl_eIELDMI1.eIEDMI.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wl_eIELDMI1.eIEDMI.bIndCos

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVILREV1_eIELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eIEREV_DGV(ByRef wp_aIEREV As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wl_nRow As Integer)
        Dim wl_eIEREV As New moe_Estructuras.eIEREV
        Try
            With wp_VlrCtrl
                wl_eIEREV.nID = .Rows(wl_nRow).Cells("nID").Value
                wl_eIEREV.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_eIEREV.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_eIEREV.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_eIEREV.sCodTra = .Rows(wl_nRow).Cells("sCodTra").Value
                wl_eIEREV.sEstDoc = .Rows(wl_nRow).Cells("sEstDoc").Value
                wl_eIEREV.sTipRev = .Rows(wl_nRow).Cells("sTipRev").Value
                wl_eIEREV.dFecCtb = .Rows(wl_nRow).Cells("dFecCtb").Value
                wl_eIEREV.dFecDoc = .Rows(wl_nRow).Cells("dFecDoc").Value
                wl_eIEREV.dFecVto = .Rows(wl_nRow).Cells("dFecVto").Value
                wl_eIEREV.dFecSys = .Rows(wl_nRow).Cells("dFecSys").Value
                wl_eIEREV.sDocRef = .Rows(wl_nRow).Cells("sDocRef").Value
                wl_eIEREV.nTotDoc = .Rows(wl_nRow).Cells("nTotDoc").Value
                wl_eIEREV.sClsDoc = .Rows(wl_nRow).Cells("sClsDoc").Value
                wl_eIEREV.sCmn = .Rows(wl_nRow).Cells("sCmn").Value
                wl_eIEREV.sCodCteCtb = .Rows(wl_nRow).Cells("sCodCteCtb").Value
                wl_eIEREV.nNroCteCtb = .Rows(wl_nRow).Cells("nNroCteCtb").Value
                wl_eIEREV.nIdFECCT = .Rows(wl_nRow).Cells("nIdFECCT").Value
                wl_eIEREV.sCodMon = .Rows(wl_nRow).Cells("sCodMon").Value
                wl_eIEREV.sCodUsr = .Rows(wl_nRow).Cells("sCodUsr").Value
                wl_eIEREV.sCodAut = .Rows(wl_nRow).Cells("sCodAut").Value
            End With
            wp_aIEREV = wl_eIEREV
        Catch ex As Exception
            MsgBox("Error : moo_eIEREV_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeILREV1_DT(ByRef wp_aeILREV1 As Object,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eILREV1 As New moe_Estructuras.eILREV1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeILREV1(wl_nCntReg) As moe_Estructuras.eILREV1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeILREV1(wl_nRow) = New moe_Estructuras.eILREV1
                wl_eILREV1 = New moe_Estructuras.eILREV1
                moo_eILREV1_DT(wl_eILREV1,
                              wp_DT,
                              wl_nRow)
                wl_aeILREV1(wl_nRow) = wl_eILREV1
            Next
            wp_aeILREV1 = wl_aeILREV1
        Catch ex As Exception
            MsgBox("Error : moo_aeILREV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eILREV1_DT(ByRef wp_eILREV1 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_eILREV1 As New moe_Estructuras.eILREV1
            With wl_eILREV1
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sTipRev = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipRev")), wp_DT.Rows(wp_nRow).Item("sTipRev"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .nCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .nPreant = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreAnt")), wp_DT.Rows(wp_nRow).Item("nPreAnt"), 0)
                .nDifPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nDifPre")), wp_DT.Rows(wp_nRow).Item("nDifPre"), 0)
                .nTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .sCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .sCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .sCtaAumInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaAumInv")), wp_DT.Rows(wp_nRow).Item("sCtaAumInv"), "")
                .sCtaRedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaRedInv")), wp_DT.Rows(wp_nRow).Item("sCtaRedInv"), "")
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
            End With
            wp_eILREV1 = wl_eILREV1
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_eILREV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eILREV1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eILREV1 As Object,
                               ByVal wl_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wl_nRow).Cells("nID").Value = wp_eILREV1.nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_eILREV1.sCodDoc
                .Rows(wl_nRow).Cells("nNrodoc").Value = wp_eILREV1.nNrodoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_eILREV1.sCodSer
                .Rows(wl_nRow).Cells("sTipRev").Value = wp_eILREV1.sTipRev
                .Rows(wl_nRow).Cells("sCodItm").Value = wp_eILREV1.sCodItm
                .Rows(wl_nRow).Cells("sNomItm").Value = wp_eILREV1.sNomItm
                .Rows(wl_nRow).Cells("sNomAlt").Value = wp_eILREV1.sNomAlt
                .Rows(wl_nRow).Cells("sCodAlm").Value = wp_eILREV1.sCodAlm
                .Rows(wl_nRow).Cells("nCanItm").Value = wp_eILREV1.nCanItm
                .Rows(wl_nRow).Cells("sUniMedInv").Value = wp_eILREV1.sUniMedInv '10
                .Rows(wl_nRow).Cells("nPreUni").Value = wp_eILREV1.nPreUni
                .Rows(wl_nRow).Cells("nPreAnt").Value = wp_eILREV1.nPreAnt
                .Rows(wl_nRow).Cells("nDifPre").Value = wp_eILREV1.nDifPre
                .Rows(wl_nRow).Cells("nTotLin").Value = wp_eILREV1.nTotLin
                .Rows(wl_nRow).Cells("sCodPdo").Value = wp_eILREV1.sCodPdo
                .Rows(wl_nRow).Cells("sCodCta").Value = wp_eILREV1.sCodCta
                .Rows(wl_nRow).Cells("sCtaCosVta").Value = wp_eILREV1.sCtaCosVta
                .Rows(wl_nRow).Cells("sCtaAumInv").Value = wp_eILREV1.sCtaAumInv
                .Rows(wl_nRow).Cells("sCtaRedInv").Value = wp_eILREV1.sCtaRedInv
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_eILREV1.sClsDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eILREV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eILREV1_DGVILREV1(ByRef wp_eILREV1 As Object,
                                     ByVal wp_VlrCtrl As DataGridView,
                                     ByRef wp_nRow As Integer)
        'Fecha última actualización: 2015.07.09
        Try
            Dim wl_eILREV1 As New moe_Estructuras.eILREV1
            With wp_VlrCtrl
                wl_eILREV1.nID = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nID").Value), .Rows(wp_nRow).Cells("nID").Value, 0) '0
                wl_eILREV1.sCodDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodDoc").Value), .Rows(wp_nRow).Cells("sCodDoc").Value, "")
                wl_eILREV1.nNroDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nNroDoc").Value), .Rows(wp_nRow).Cells("nNroDoc").Value, 0)
                wl_eILREV1.sCodSer = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodSer").Value), .Rows(wp_nRow).Cells("sCodSer").Value, "")
                wl_eILREV1.sTipRev = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sTipRev").Value), .Rows(wp_nRow).Cells("sTipRev").Value, "")
                wl_eILREV1.sCodItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodItm").Value), .Rows(wp_nRow).Cells("sCodItm").Value, "")
                wl_eILREV1.sNomItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sNomItm").Value), .Rows(wp_nRow).Cells("sNomItm").Value, "")
                wl_eILREV1.sNomAlt = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sNomAlt").Value), .Rows(wp_nRow).Cells("sNomAlt").Value, "")
                wl_eILREV1.sCodAlm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodAlm").Value), .Rows(wp_nRow).Cells("sCodAlm").Value, "")
                wl_eILREV1.nCanItm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nCanItm").Value), .Rows(wp_nRow).Cells("nCanItm").Value, 0) '10
                wl_eILREV1.sUniMedInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sUniMedInv").Value), .Rows(wp_nRow).Cells("sUniMedInv").Value, "")
                wl_eILREV1.nPreUni = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPreUni").Value), .Rows(wp_nRow).Cells("nPreUni").Value, 0)
                wl_eILREV1.nPreant = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nPreAnt").Value), .Rows(wp_nRow).Cells("nPreAnt").Value, 0)
                wl_eILREV1.nDifPre = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nDifPre").Value), .Rows(wp_nRow).Cells("nDifPre").Value, 0)
                wl_eILREV1.nTotLin = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nTotLin").Value), .Rows(wp_nRow).Cells("nTotLin").Value, 0)
                wl_eILREV1.sCodPdo = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodPdo").Value), .Rows(wp_nRow).Cells("sCodPdo").Value, "")
                wl_eILREV1.sCodCta = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCodCta").Value), .Rows(wp_nRow).Cells("sCodCta").Value, "") '30
                wl_eILREV1.sCtaCosVta = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCtaCosVta").Value), .Rows(wp_nRow).Cells("sCtaCosVta").Value, "")
                wl_eILREV1.sCtaAumInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCtaAumInv").Value), .Rows(wp_nRow).Cells("sCtaAumInv").Value, "")
                wl_eILREV1.sCtaRedInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sCtaRedInv").Value), .Rows(wp_nRow).Cells("sCtaRedInv").Value, "")
                wl_eILREV1.sClsDoc = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("sClsDoc").Value), .Rows(wp_nRow).Cells("sClsDoc").Value, "")

                wl_eILREV1.nSdoAlm = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nSdoAlm").Value), .Rows(wp_nRow).Cells("nSdoAlm").Value, 0)
                wl_eILREV1.nSdoInv = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nSdoInv").Value), .Rows(wp_nRow).Cells("nSdoInv").Value, 0)
                wl_eILREV1.nUltPreEnt = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("nUltPreEnt").Value), .Rows(wp_nRow).Cells("nUltPreEnt").Value, 0)
                wl_eILREV1.bIndCan = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("bIndCan").Value), .Rows(wp_nRow).Cells("bIndCan").Value, False)
                wl_eILREV1.bIndCos = IIf(Not IsDBNull(.Rows(wp_nRow).Cells("bIndCos").Value), .Rows(wp_nRow).Cells("bIndCos").Value, False)
            End With
            wp_eILREV1 = wl_eILREV1
        Catch ex As Exception
            MsgBox("Error : moo_eGLMOV1_DGVGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "KARDEX_QItm"
    Public Sub moo_aeKARDEX_QItm_DT(ByRef wp_aeKARDEX_QItm As Array,
                                    ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eKARDEX_QItm As New moe_Estructuras.eKARDEX
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeKARDEX_QItm(wl_nCntReg) As moe_Estructuras.eKARDEX
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeKARDEX_QItm(wl_nRow) = New moe_Estructuras.eKARDEX
                wl_eKARDEX_QItm = New moe_Estructuras.eKARDEX
                moo_eKARDEX_QItm_DT(wl_eKARDEX_QItm,
                                   wp_DT,
                                   wl_nRow)
                wl_aeKARDEX_QItm(wl_nRow) = wl_eKARDEX_QItm
            Next
            wp_aeKARDEX_QItm = wl_aeKARDEX_QItm
        Catch ex As Exception
            MsgBox("Error : moo_aeKARDEX_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eKARDEX_QItm_DT(ByRef wp_aKARDEX_QItm As Object,
                                   ByVal wp_DT As DataTable,
                                   ByVal wp_nRow As Integer)
        Try
            Dim wl_eKARDEX_QItm As New moe_Estructuras.eKARDEX

            With wl_eKARDEX_QItm
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
            End With
            wp_aKARDEX_QItm = wl_eKARDEX_QItm

        Catch ex As Exception
            MsgBox("Error : moo_eKARDEX_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeKARDEX_QItm(ByVal wp_VlrCtrl As DataGridView,
                                     ByVal wp_aeKARDEX_QItm As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeKARDEX_QItm)
            Dim wl_aeKARDEX_QItm(wl_nCntReg) As moe_Estructuras.eKARDEX
            wl_aeKARDEX_QItm = wp_aeKARDEX_QItm
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eKARDEX_QItm(wp_VlrCtrl,
                                        wl_aeKARDEX_QItm(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeKARDEX_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eKARDEX_QItm(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_eKARDEX_QItm As Object,
                                    ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eKARDEX_QItm.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eKARDEX_QItm.sNomItm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eKARDEX_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eKARDEX_QItm_DGV(ByRef wp_eKARDEX_QItm As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try
            Dim wl_eKARDEX_QItm As New moe_Estructuras.eKARDEX
            With wl_eKARDEX_QItm
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value
            End With
            wp_eKARDEX_QItm = wl_eKARDEX_QItm
        Catch ex As Exception
            MsgBox("Error : moo_eKARDEX_QItm_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeKARDEX_QItm_DT(ByVal wp_VlrCtrl As DataGridView,
                                        ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeKARDEX_QItm(wl_nCntReg) As moe_Estructuras.eKARDEX
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodItm")), wp_DT.Rows(wl_nRow).Item("sCodItm"), "")
                    .Rows(wl_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sNomItm")), wp_DT.Rows(wl_nRow).Item("sNomItm"), "")
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeKARDEX_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "KARDEX_QAlm"
    Public Sub moo_aeKARDEX_QAlm_DT(ByRef wp_aeKARDEX_QAlm As Array,
                                    ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eKARDEX_QAlm As New moe_Estructuras.eKARDEX
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeKARDEX_QAlm(wl_nCntReg) As moe_Estructuras.eKARDEX
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeKARDEX_QAlm(wl_nRow) = New moe_Estructuras.eKARDEX
                wl_eKARDEX_QAlm = New moe_Estructuras.eKARDEX
                moo_eKARDEX_QAlm_DT(wl_eKARDEX_QAlm,
                                   wp_DT,
                                   wl_nRow)
                wl_aeKARDEX_QAlm(wl_nRow) = wl_eKARDEX_QAlm
            Next
            wp_aeKARDEX_QAlm = wl_aeKARDEX_QAlm
        Catch ex As Exception
            MsgBox("Error : moo_aeKARDEX_QAlm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eKARDEX_QAlm_DT(ByRef wp_aKARDEX_QAlm As Object,
                                   ByVal wp_DT As DataTable,
                                   ByVal wp_nRow As Integer)
        Try
            Dim wl_eKARDEX_QAlm As New moe_Estructuras.eKARDEX
            With wl_eKARDEX_QAlm
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
            End With
            wp_aKARDEX_QAlm = wl_eKARDEX_QAlm
        Catch ex As Exception
            MsgBox("Error : moo_eKARDEX_QAlm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeKARDEX_QAlm(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aeKARDEX_QAlm As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeKARDEX_QAlm)
            Dim wl_aeKARDEX_QAlm(wl_nCntReg) As moe_Estructuras.eKARDEX
            wl_aeKARDEX_QAlm = wp_aeKARDEX_QAlm
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eKARDEX_QAlm(wp_VlrCtrl,
                                        wl_aeKARDEX_QAlm(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeKARDEX_QAlm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eKARDEX_QAlm(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_eKARDEX_QAlm As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_eKARDEX_QAlm.sCodAlm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eKARDEX_QAlm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eKARDEX_QAlm_DGV(ByRef wp_eKARDEX_QAlm As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try
            Dim wl_eKARDEX_QAlm As New moe_Estructuras.eKARDEX
            With wl_eKARDEX_QAlm
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value
            End With
            wp_eKARDEX_QAlm = wl_eKARDEX_QAlm
        Catch ex As Exception
            MsgBox("Error : moo_eKARDEX_QAlm_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "PEFOM"
#Region "ePEFOM"
    Public Sub moo_aePEFOM_DT(ByRef wp_aePEFOM As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePEFOM As New moe_Estructuras.ePEFOM
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePEFOM(wl_nCntReg) As moe_Estructuras.ePEFOM
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePEFOM(wl_nRow) = New moe_Estructuras.ePEFOM
                vl_ePEFOM = New moe_Estructuras.ePEFOM
                moo_ePEFOM_DT(vl_ePEFOM,
                              wp_DT,
                              wl_nRow)
                vl_aePEFOM(wl_nRow) = vl_ePEFOM
            Next
            wp_aePEFOM = vl_aePEFOM
        Catch ex As Exception
            MsgBox("Error : moo_aePEFOM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEFOM_DT(ByRef wp_ePEFOM As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim vl_ePEFOM As New moe_Estructuras.ePEFOM
            With vl_ePEFOM
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .nCanLotStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanLotStn")), wp_DT.Rows(wp_nRow).Item("nCanLotStn"), 0)
                .sUniMedStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedStn")), wp_DT.Rows(wp_nRow).Item("sUniMedStn"), "")
                .nCanUniStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniStn")), wp_DT.Rows(wp_nRow).Item("nCanUniStn"), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .sTipLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipLIM")), wp_DT.Rows(wp_nRow).Item("sTipLIM"), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .nPesItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesItm")), wp_DT.Rows(wp_nRow).Item("nPesItm"), 0)
                .nPorItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorItm")), wp_DT.Rows(wp_nRow).Item("nPorItm"), 0)
                .nTieItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieItm")), wp_DT.Rows(wp_nRow).Item("nTieItm"), 0)
                .nCIFItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCIFItm")), wp_DT.Rows(wp_nRow).Item("nCIFItm"), 0)
                .nVlrItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrItm")), wp_DT.Rows(wp_nRow).Item("nVlrItm"), 0)
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
                .sRegSan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sRegSan")), wp_DT.Rows(wp_nRow).Item("sRegSan"), "")
            End With
            wp_ePEFOM = vl_ePEFOM
        Catch ex As Exception
            MsgBox("Error : moo_ePEFOM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEFOM(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aePEFOM As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEFOM)
            Dim vl_aePEFOM(wl_nCntReg) As moe_Estructuras.ePEFOM
            vl_aePEFOM = wp_aePEFOM
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEFOM(wp_VlrCtrl,
                                   vl_aePEFOM(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEFOM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEFOM(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_ePEFOM As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePEFOM.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePEFOM.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_ePEFOM.sNomItm
                .Rows(wp_nRow).Cells("nCanLotStn").Value = wp_ePEFOM.nCanLotStn
                .Rows(wp_nRow).Cells("sUniMedStn").Value = wp_ePEFOM.sUniMedStn
                .Rows(wp_nRow).Cells("nCanUniStn").Value = wp_ePEFOM.nCanUniStn
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_ePEFOM.sUniMedInv
                .Rows(wp_nRow).Cells("sTipLIM").Value = wp_ePEFOM.sTipLIM
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_ePEFOM.sCodAlm
                .Rows(wp_nRow).Cells("nPesItm").Value = wp_ePEFOM.nPesItm
                .Rows(wp_nRow).Cells("nPorItm").Value = wp_ePEFOM.nPorItm
                .Rows(wp_nRow).Cells("nTieItm").Value = wp_ePEFOM.nTieItm
                .Rows(wp_nRow).Cells("nCIFItm").Value = wp_ePEFOM.nCIFItm
                .Rows(wp_nRow).Cells("nVlrItm").Value = wp_ePEFOM.nVlrItm
                .Rows(wp_nRow).Cells("bRegAci").Value = wp_ePEFOM.bRegAci
                .Rows(wp_nRow).Cells("sRegSan").Value = wp_ePEFOM.sRegSan
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEFOM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePEFOM(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wg_DTCon1 As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wg_DTCon1.Rows.Count
            For wl_nRow = 0 To wl_nCntReg - 1
                wp_VlrCtrl.Rows.Add()
                With wp_VlrCtrl
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nId").Value = wg_DTCon1.Rows(wl_nRow).Item("nId")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sCodItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sNomItm").Value = wg_DTCon1.Rows(wl_nRow).Item("sNomItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nCanLotStn").Value = wg_DTCon1.Rows(wl_nRow).Item("nCanLotStn")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sUniMedStn").Value = wg_DTCon1.Rows(wl_nRow).Item("sUniMedStn")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nCanUniStn").Value = wg_DTCon1.Rows(wl_nRow).Item("nCanUniStn")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sUniMedInv").Value = wg_DTCon1.Rows(wl_nRow).Item("sUniMedInv")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sTipLIM").Value = wg_DTCon1.Rows(wl_nRow).Item("sTipLIM")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sCodAlm").Value = wg_DTCon1.Rows(wl_nRow).Item("sCodAlm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nPesItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nPesItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nPorItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nPorItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nTieItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nTieItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nCIFItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nCIFItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nVlrItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nVlrItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("bRegAci").Value = wg_DTCon1.Rows(wl_nRow).Item("bRegAci")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sRegSan").Value = wg_DTCon1.Rows(wl_nRow).Item("sRegSan")

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePEFOM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEFOM_DGV(ByRef wp_ePEFOM As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wp_nRow As Integer)
        Try
            Dim vl_ePEFOM As New moe_Estructuras.ePEFOM
            With wp_VlrCtrl
                vl_ePEFOM.nId = .Rows(wp_nRow).Cells("nId").Value
                vl_ePEFOM.sCodItm = .Rows(wp_nRow).Cells("sCodItm").Value
                vl_ePEFOM.sNomItm = .Rows(wp_nRow).Cells("sNomItm").Value
                vl_ePEFOM.nCanLotStn = .Rows(wp_nRow).Cells("nCanLotStn").Value
                vl_ePEFOM.sUniMedStn = .Rows(wp_nRow).Cells("sUniMedStn").Value
                vl_ePEFOM.nCanUniStn = .Rows(wp_nRow).Cells("nCanUniStn").Value
                vl_ePEFOM.sUniMedInv = .Rows(wp_nRow).Cells("sUniMedInv").Value
                vl_ePEFOM.sTipLIM = .Rows(wp_nRow).Cells("sTipLIM").Value
                vl_ePEFOM.sCodAlm = .Rows(wp_nRow).Cells("sCodAlm").Value
                vl_ePEFOM.nPesItm = .Rows(wp_nRow).Cells("nPesItm").Value
                vl_ePEFOM.nPorItm = .Rows(wp_nRow).Cells("nPorItm").Value
                vl_ePEFOM.nTieItm = .Rows(wp_nRow).Cells("nTieItm").Value
                vl_ePEFOM.nCIFItm = .Rows(wp_nRow).Cells("nCIFItm").Value
                vl_ePEFOM.nVlrItm = .Rows(wp_nRow).Cells("nVlrItm").Value
                vl_ePEFOM.bRegAci = .Rows(wp_nRow).Cells("bRegAci").Value
                vl_ePEFOM.sRegSan = .Rows(wp_nRow).Cells("sRegSan").Value
            End With
            wp_ePEFOM = vl_ePEFOM
        Catch ex As Exception
            MsgBox("Error : moo_ePEFOM_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLFOM1"
    Public Sub moo_aePLFOM1_DT(ByRef wp_aePLFOM1 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLFOM1 As New moe_Estructuras.ePLFOM1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLFOM1(wl_nCntReg) As moe_Estructuras.ePLFOM1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLFOM1(wl_nRow) = New moe_Estructuras.ePLFOM1
                vl_ePLFOM1 = New moe_Estructuras.ePLFOM1
                moo_ePLFOM1_DT(vl_ePLFOM1,
                               wp_DT,
                               wl_nRow)
                vl_aePLFOM1(wl_nRow) = vl_ePLFOM1
            Next
            wp_aePLFOM1 = vl_aePLFOM1
        Catch ex As Exception
            MsgBox("Error : moo_aePLFOM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM1_DT(ByRef wp_ePLFOM1 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLFOM1 As New moe_Estructuras.ePLFOM1
            With vl_ePLFOM1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .nCanCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .nPesCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesCmt")), wp_DT.Rows(wp_nRow).Item("nPesCmt"), 0)
                .nPorCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCmt")), wp_DT.Rows(wp_nRow).Item("nPorCmt"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .sCodAlmCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .sTipCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCmt")), wp_DT.Rows(wp_nRow).Item("sTipCmt"), "")
                .sCodCmtAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.bItmAct")), wp_DT.Rows(wp_nRow).Item("T0.bItmAct"), False)
                .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
                .sNomCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
            End With
            wp_ePLFOM1 = vl_ePLFOM1
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLFOM1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLFOM1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLFOM1)
            Dim vl_aePLFOM1(wl_nCntReg) As moe_Estructuras.ePLFOM1
            vl_aePLFOM1 = wp_aePLFOM1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLFOM1(wp_VlrCtrl,
                                   vl_aePLFOM1(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLFOM1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_ePLFOM1 As Object,
                               ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLFOM1.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLFOM1.sCodItm
                .Rows(wp_nRow).Cells("sCodCmt").Value = wp_ePLFOM1.sCodCmt
                .Rows(wp_nRow).Cells("nCanCmt").Value = wp_ePLFOM1.nCanCmt
                .Rows(wp_nRow).Cells("nPesCmt").Value = wp_ePLFOM1.nPesCmt
                .Rows(wp_nRow).Cells("nPorCmt").Value = wp_ePLFOM1.nPorCmt
                .Rows(wp_nRow).Cells("nPreUni").Value = wp_ePLFOM1.nPreUni
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = wp_ePLFOM1.sCodAlmCns
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_ePLFOM1.sUniMedInv
                .Rows(wp_nRow).Cells("sTipCmt").Value = wp_ePLFOM1.sTipCmt
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = wp_ePLFOM1.sCodCmtAlt
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLFOM1.bItmAct
                .Rows(wp_nRow).Cells("bIndCan").Value = wp_ePLFOM1.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wp_ePLFOM1.bIndCos
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM1_DGV(ByRef wp_ePLFOM1 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLFOM1
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .nCanCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanCmt").Value
                .nPesCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nPesCmt").Value
                .nPorCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorCmt").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .sCodAlmCns = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCns").Value
                .sCodAlmCns = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCns").Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value
                .sTipCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipCmt").Value
                .sCodCmtAlt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmtAlt").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
                .bIndCan = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCan").Value
                .bIndCos = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCos").Value

            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLFOM1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .Rows(wp_nRow).Cells("nCanCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .Rows(wp_nRow).Cells("nPesCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesCmt")), wp_DT.Rows(wp_nRow).Item("nPesCmt"), 0)
                .Rows(wp_nRow).Cells("nPorCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCmt")), wp_DT.Rows(wp_nRow).Item("nPorCmt"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.nPreUni")), wp_DT.Rows(wp_nRow).Item("T2.nPreUni"), 0)
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .Rows(wp_nRow).Cells("sTipCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCmt")), wp_DT.Rows(wp_nRow).Item("sTipCmt"), "")
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.bItmAct")), wp_DT.Rows(wp_nRow).Item("T0.bItmAct"), "")
                .Rows(wp_nRow).Cells("sNomCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .Rows(wp_nRow).Cells("bIndCan").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), "")
                .Rows(wp_nRow).Cells("bIndCos").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLFOM1")

            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLFOM2 - OPE"
    Public Sub moo_aePLFOM2_DT(ByRef wp_aePLFOM2 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLFOM2 As New moe_Estructuras.ePLFOM2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLFOM2(wl_nCntReg) As moe_Estructuras.ePLFOM2
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLFOM2(wl_nRow) = New moe_Estructuras.ePLFOM2
                vl_ePLFOM2 = New moe_Estructuras.ePLFOM2
                moo_ePLFOM2_DT(vl_ePLFOM2,
                               wp_DT,
                               wl_nRow)
                vl_aePLFOM2(wl_nRow) = vl_ePLFOM2
            Next
            wp_aePLFOM2 = vl_aePLFOM2
        Catch ex As Exception
            MsgBox("Error : moo_aePLFOM2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM2_DT(ByRef wp_ePLFOM2 As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLFOM2 As New moe_Estructuras.ePLFOM2
            With vl_ePLFOM2
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nPosOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpe")), wp_DT.Rows(wp_nRow).Item("nPosOpe"), 0)
                .sCodOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodOpe")), wp_DT.Rows(wp_nRow).Item("sCodOpe"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "")
                .nTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieOpe")), wp_DT.Rows(wp_nRow).Item("nTieOpe"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .nCanBasPro = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanBasPro")), wp_DT.Rows(wp_nRow).Item("nCanBasPro"), 0)
                .nTotTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOpe")), wp_DT.Rows(wp_nRow).Item("nTotTieOpe"), 0)
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
            End With
            wp_ePLFOM2 = vl_ePLFOM2
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLFOM2(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLFOM2 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLFOM2)
            Dim vl_aePLFOM2(wl_nCntReg) As moe_Estructuras.ePLFOM2
            vl_aePLFOM2 = wp_aePLFOM2
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLFOM2(wp_VlrCtrl,
                                   vl_aePLFOM2(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLFOM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLFOM2(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_ePLFOM2 As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLFOM2.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLFOM2.sCodItm
                .Rows(wp_nRow).Cells("nPosOpe").Value = wp_ePLFOM2.nPosOpe
                .Rows(wp_nRow).Cells("sCodOpe").Value = wp_ePLFOM2.sCodOpe
                .Rows(wp_nRow).Cells("sCodCtr").Value = wp_ePLFOM2.sCodCtr
                .Rows(wp_nRow).Cells("nTieOpe").Value = wp_ePLFOM2.nTieOpe
                .Rows(wp_nRow).Cells("nPreUni").Value = wp_ePLFOM2.nPreUni
                .Rows(wp_nRow).Cells("nCanBasPro").Value = wp_ePLFOM2.nCanBasPro
                .Rows(wp_nRow).Cells("nTotTieOpe").Value = wp_ePLFOM2.nTotTieOpe
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLFOM2.bItmAct
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLFOM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM2_DGV(ByRef wp_ePLFOM2 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLFOM2
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .nPosOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nPosOpe").Value
                .sCodOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodOpe").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .nTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieOpe").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .nCanBasPro = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanBasPro").Value
                .nTotTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieOpe").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM2_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLFOM2(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_DT As DataTable,
                                    ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("nPosOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPosOpe")), wp_DT.Rows(wp_nRow).Item("nPosOpe"), "")
                .Rows(wp_nRow).Cells("sCodOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodOpe")), wp_DT.Rows(wp_nRow).Item("T0.sCodOpe"), "")
                .Rows(wp_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .Rows(wp_nRow).Cells("nTieOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTieOpe")), wp_DT.Rows(wp_nRow).Item("T0.nTieOpe"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .Rows(wp_nRow).Cells("nCanBasPro").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanBasPro")), wp_DT.Rows(wp_nRow).Item("nCanBasPro"), 0)
                .Rows(wp_nRow).Cells("nTotTieOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOpe")), wp_DT.Rows(wp_nRow).Item("nTotTieOpe"), 0)
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLFOM2")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLFOM3 - CIF"
    Public Sub moo_aePLFOM3_DT(ByRef wp_aePLFOM3 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLFOM3 As New moe_Estructuras.ePLFOM3
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLFOM3(wl_nCntReg) As moe_Estructuras.ePLFOM3
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLFOM3(wl_nRow) = New moe_Estructuras.ePLFOM3
                vl_ePLFOM3 = New moe_Estructuras.ePLFOM3
                moo_ePLFOM3_DT(vl_ePLFOM3,
                               wp_DT,
                               wl_nRow)
                vl_aePLFOM3(wl_nRow) = vl_ePLFOM3
            Next
            wp_aePLFOM3 = vl_aePLFOM3
        Catch ex As Exception
            MsgBox("Error : moo_aePLFOM3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM3_DT(ByRef wp_ePLFOM3 As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLFOM3 As New moe_Estructuras.ePLFOM3
            With vl_ePLFOM3
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sCodCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCIF")), wp_DT.Rows(wp_nRow).Item("T0.sCodCIF"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .nVlrCIFRea = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea"), 0)
                .nTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTasCIF")), wp_DT.Rows(wp_nRow).Item("T0.nTasCIF"), 0)
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
            End With
            wp_ePLFOM3 = vl_ePLFOM3
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLFOM3(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aePLFOM3 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLFOM3)
            Dim vl_aePLFOM3(wl_nCntReg) As moe_Estructuras.ePLFOM3
            vl_aePLFOM3 = wp_aePLFOM3
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLFOM3(wp_VlrCtrl,
                                   vl_aePLFOM3(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLFOM3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLFOM3(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_ePLFOM3 As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLFOM3.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLFOM3.sCodItm
                .Rows(wp_nRow).Cells("sCodCIF").Value = wp_ePLFOM3.sCodCIF
                .Rows(wp_nRow).Cells("sCodCtr").Value = wp_ePLFOM3.sCodCtr
                .Rows(wp_nRow).Cells("nVlrCIF").Value = wp_ePLFOM3.nVlrCIF
                .Rows(wp_nRow).Cells("nTasCIF").Value = wp_ePLFOM3.nTasCIF
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLFOM3.bItmAct
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLFOM3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM3_DGV(ByRef wp_ePLFOM3 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLFOM3
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCIF").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .nVlrCIFRea = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrCIFRea").Value
                .nTasCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nTasCIF").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM3_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLFOM3(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCIF")), wp_DT.Rows(wp_nRow).Item("T0.sCodCIF"), "")
                .Rows(wp_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .Rows(wp_nRow).Cells("nVlrCIFRea").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea"), 0)
                .Rows(wp_nRow).Cells("nTasCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTasCIF")), wp_DT.Rows(wp_nRow).Item("T0.nTasCIF"), 0)
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLFOM3")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLFOM5 - ANA"
    Public Sub moo_aePLFOM5_DT(ByRef wp_aePLFOM5 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLFOM5 As New moe_Estructuras.ePLFOM5
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePLFOM5(wl_nCntReg) As moe_Estructuras.ePLFOM5
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePLFOM5(wl_nRow) = New moe_Estructuras.ePLFOM5
                wl_ePLFOM5 = New moe_Estructuras.ePLFOM5
                moo_ePLFOM5_DT(wl_ePLFOM5,
                               wp_DT,
                               wl_nRow)
                wl_aePLFOM5(wl_nRow) = wl_ePLFOM5
            Next
            wp_aePLFOM5 = wl_aePLFOM5
        Catch ex As Exception
            MsgBox("Error : moo_aePLFOM5_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM5_DT(ByRef wp_ePLFOM5 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLFOM5 As New moe_Estructuras.ePLFOM5
            With wl_ePLFOM5
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("t0.nId")), wp_DT.Rows(wp_nRow).Item("t0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sCodAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodAna"), "")
                .sDesAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDesAna")), wp_DT.Rows(wp_nRow).Item("sDesAna"), "")
                .sCodTipAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
            End With
            wp_ePLFOM5 = wl_ePLFOM5
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM5_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLFOM5(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLFOM5 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLFOM5)
            Dim wl_aePLFOM5(wl_nCntReg) As moe_Estructuras.ePLFOM5
            wl_aePLFOM5 = wp_aePLFOM5
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLFOM5(wp_VlrCtrl,
                                    wl_aePLFOM5(wl_nRow),
                                    wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLFOM5")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLFOM5(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_ePLFOM5 As Object,
                               ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLFOM5.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLFOM5.sCodItm
                .Rows(wp_nRow).Cells("sCodAna").Value = wp_ePLFOM5.sCodAna
                .Rows(wp_nRow).Cells("sDesAna").Value = wp_ePLFOM5.sDesAna
                .Rows(wp_nRow).Cells("sCodTipAna").Value = wp_ePLFOM5.sCodTipAna
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLFOM5.bItmAct
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLFOM5")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLFOM5_DGV(ByRef wp_ePLFOM5 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLFOM5
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAna").Value
                .sDesAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sDesAna").Value
                .sCodTipAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTipAna").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLFOM5_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLFOM5(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodAna"), "")
                .Rows(wp_nRow).Cells("sDesAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDesAna")), wp_DT.Rows(wp_nRow).Item("sDesAna"), "")
                .Rows(wp_nRow).Cells("sCodTipAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna"), "")
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLFOM5")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "PELIM"
#Region "ePELIM"
    Public Sub moo_aePELIM_DT(ByRef wp_aePELIM As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePELIM As New moe_Estructuras.ePELIM
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePELIM(wl_nCntReg) As moe_Estructuras.ePELIM
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePELIM(wl_nRow) = New moe_Estructuras.ePELIM
                vl_ePELIM = New moe_Estructuras.ePELIM
                moo_ePELIM_DT(vl_ePELIM,
                              wp_DT,
                              wl_nRow)
                vl_aePELIM(wl_nRow) = vl_ePELIM
            Next
            wp_aePELIM = vl_aePELIM
        Catch ex As Exception
            MsgBox("Error : moo_aePELIM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePELIM_DT(ByRef wp_ePELIM As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim vl_ePELIM As New moe_Estructuras.ePELIM
            With vl_ePELIM
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sNomItm")), wp_DT.Rows(wp_nRow).Item("T1.sNomItm"), "")
                .nCanLotStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanLotStn")), wp_DT.Rows(wp_nRow).Item("nCanLotStn"), 0)
                .sUniMedStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedStn")), wp_DT.Rows(wp_nRow).Item("sUniMedStn"), "")
                .nCanUniStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniStn")), wp_DT.Rows(wp_nRow).Item("nCanUniStn"), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .sTipLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipLIM")), wp_DT.Rows(wp_nRow).Item("sTipLIM"), "")
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAlm")), wp_DT.Rows(wp_nRow).Item("T0.sCodAlm"), "")
                .nPesItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesItm")), wp_DT.Rows(wp_nRow).Item("nPesItm"), 0)
                .nPorItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorItm")), wp_DT.Rows(wp_nRow).Item("nPorItm"), 0)
                .nTieItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieItm")), wp_DT.Rows(wp_nRow).Item("nTieItm"), 0)
                .nCIFItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCIFItm")), wp_DT.Rows(wp_nRow).Item("nCIFItm"), 0)
                .nVlrItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrItm")), wp_DT.Rows(wp_nRow).Item("nVlrItm"), 0)
                .bRegAci = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bRegAci")), wp_DT.Rows(wp_nRow).Item("bRegAci"), False)
                .sRegSan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sRegSan")), wp_DT.Rows(wp_nRow).Item("sRegSan"), "")
                .nPreVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreVta")), wp_DT.Rows(wp_nRow).Item("nPreVta"), 0)
                .bIndCanRes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.bIndCanRes")), wp_DT.Rows(wp_nRow).Item("T1.bIndCanRes"), 0)
                .bIndCanPry = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.bIndCanPry")), wp_DT.Rows(wp_nRow).Item("T1.bIndCanPry"), 0)
            End With
            wp_ePELIM = vl_ePELIM
        Catch ex As Exception
            MsgBox("Error : moo_ePELIM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePELIM(ByRef wp_VlrCtrl As DataGridView,
                             ByVal wp_aePELIM As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePELIM)
            Dim vl_aePELIM(wl_nCntReg) As moe_Estructuras.ePELIM
            vl_aePELIM = wp_aePELIM
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePELIM(wp_VlrCtrl,
                                   vl_aePELIM(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_eIEDMI_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePELIM(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_ePELIM As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePELIM.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePELIM.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_ePELIM.sNomItm
                .Rows(wp_nRow).Cells("sNomAlt").Value = wp_ePELIM.sNomAlt
                .Rows(wp_nRow).Cells("nCanLotStn").Value = wp_ePELIM.nCanLotStn
                .Rows(wp_nRow).Cells("sUniMedStn").Value = wp_ePELIM.sUniMedStn
                .Rows(wp_nRow).Cells("nCanUniStn").Value = wp_ePELIM.nCanUniStn
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_ePELIM.sUniMedInv
                .Rows(wp_nRow).Cells("sTipLIM").Value = wp_ePELIM.sTipLIM
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_ePELIM.sCodAlm
                .Rows(wp_nRow).Cells("nPesItm").Value = wp_ePELIM.nPesItm
                .Rows(wp_nRow).Cells("nPorItm").Value = wp_ePELIM.nPorItm
                .Rows(wp_nRow).Cells("nTieItm").Value = wp_ePELIM.nTieItm
                .Rows(wp_nRow).Cells("nCIFItm").Value = wp_ePELIM.nCIFItm
                .Rows(wp_nRow).Cells("nVlrItm").Value = wp_ePELIM.nVlrItm
                .Rows(wp_nRow).Cells("bRegAci").Value = wp_ePELIM.bRegAci
                .Rows(wp_nRow).Cells("sRegSan").Value = wp_ePELIM.sRegSan
                .Rows(wp_nRow).Cells("nPreVta").Value = wp_ePELIM.nPreVta
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePELIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePELIM(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wg_DTCon1 As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_nRow As Integer

            wl_nCntReg = wg_DTCon1.Rows.Count

            wl_nRow = 0
            For wl_nRow = 0 To wl_nCntReg - 1
                ' Do Until wl_nRow = wl_nCntReg
                ' Do While wl_nRow < wl_nCntReg


                wp_VlrCtrl.Rows.Add()
                With wp_VlrCtrl
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nId").Value = wg_DTCon1.Rows(wl_nRow).Item("T0.nId")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sCodItm").Value = wg_DTCon1.Rows(wl_nRow).Item("T0.sCodItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sNomItm").Value = wg_DTCon1.Rows(wl_nRow).Item("T1.sNomItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sNomAlt").Value = wg_DTCon1.Rows(wl_nRow).Item("sNomAlt")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nCanLotStn").Value = wg_DTCon1.Rows(wl_nRow).Item("nCanLotStn")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sUniMedStn").Value = wg_DTCon1.Rows(wl_nRow).Item("sUniMedStn")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nCanUniStn").Value = wg_DTCon1.Rows(wl_nRow).Item("nCanUniStn")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sUniMedInv").Value = wg_DTCon1.Rows(wl_nRow).Item("T0.sUniMedInv")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sTipLIM").Value = wg_DTCon1.Rows(wl_nRow).Item("sTipLIM")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sCodAlm").Value = wg_DTCon1.Rows(wl_nRow).Item("T0.sCodAlm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nPesItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nPesItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nPorItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nPorItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nTieItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nTieItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nCIFItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nCIFItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nVlrItm").Value = wg_DTCon1.Rows(wl_nRow).Item("nVlrItm")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("bRegAci").Value = wg_DTCon1.Rows(wl_nRow).Item("bRegAci")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("sRegSan").Value = wg_DTCon1.Rows(wl_nRow).Item("sRegSan")
                    wp_VlrCtrl.Rows(wl_nRow).Cells("nPreVta").Value = wg_DTCon1.Rows(wl_nRow).Item("nPreVta")
                End With
            Next
            ' wl_nRow = wl_nRow + 1
            '            Loop

        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePELIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePELIM_DGV(ByRef wp_ePELIMeIEDMI As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePELIMeIEDMI As New moe_Estructuras.Q_ePELIM_eIEDMI
            With wp_VlrCtrl
                wl_ePELIMeIEDMI.ePELIM.nId = .Rows(wp_nRow).Cells("nId").Value
                wl_ePELIMeIEDMI.ePELIM.sCodItm = .Rows(wp_nRow).Cells("sCodItm").Value
                wl_ePELIMeIEDMI.ePELIM.nCanLotStn = .Rows(wp_nRow).Cells("nCanLotStn").Value
                wl_ePELIMeIEDMI.ePELIM.sUniMedStn = .Rows(wp_nRow).Cells("sUniMedStn").Value
                wl_ePELIMeIEDMI.ePELIM.nCanUniStn = .Rows(wp_nRow).Cells("nCanUniStn").Value
                wl_ePELIMeIEDMI.ePELIM.sUniMedInv = .Rows(wp_nRow).Cells("sUniMedInv").Value
                wl_ePELIMeIEDMI.ePELIM.sTipLIM = .Rows(wp_nRow).Cells("sTipLIM").Value
                wl_ePELIMeIEDMI.ePELIM.sCodAlm = .Rows(wp_nRow).Cells("sCodAlm").Value
                wl_ePELIMeIEDMI.ePELIM.nPesItm = .Rows(wp_nRow).Cells("nPesItm").Value
                wl_ePELIMeIEDMI.ePELIM.nPorItm = .Rows(wp_nRow).Cells("nPorItm").Value
                wl_ePELIMeIEDMI.ePELIM.nTieItm = .Rows(wp_nRow).Cells("nTieItm").Value
                wl_ePELIMeIEDMI.ePELIM.nCIFItm = .Rows(wp_nRow).Cells("nCIFItm").Value
                wl_ePELIMeIEDMI.ePELIM.nVlrItm = .Rows(wp_nRow).Cells("nVlrItm").Value
                wl_ePELIMeIEDMI.ePELIM.bRegAci = .Rows(wp_nRow).Cells("bRegAci").Value
                wl_ePELIMeIEDMI.ePELIM.sRegSan = .Rows(wp_nRow).Cells("sRegSan").Value
                wl_ePELIMeIEDMI.ePELIM.nPreVta = .Rows(wp_nRow).Cells("nPreVta").Value
                wl_ePELIMeIEDMI.sNomItm = .Rows(wp_nRow).Cells("sNomItm").Value
                wl_ePELIMeIEDMI.sNomAlt = .Rows(wp_nRow).Cells("sNomAlt").Value
            End With
            wp_ePELIMeIEDMI = wl_ePELIMeIEDMI
        Catch ex As Exception
            MsgBox("Error : moo_ePELIM_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLLIM1 - LIM"
    Public Sub moo_aePLLIM1_DT(ByRef wp_aePLLIM1 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLLIM1 As New moe_Estructuras.ePLLIM1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLLIM1(wl_nCntReg) As moe_Estructuras.ePLLIM1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLLIM1(wl_nRow) = New moe_Estructuras.ePLLIM1
                vl_ePLLIM1 = New moe_Estructuras.ePLLIM1
                moo_ePLLIM1_DT(vl_ePLLIM1,
                               wp_DT,
                               wl_nRow)
                vl_aePLLIM1(wl_nRow) = vl_ePLLIM1
            Next
            wp_aePLLIM1 = vl_aePLLIM1
        Catch ex As Exception
            MsgBox("Error : moo_aePLLIM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM1_DT(ByRef wp_ePLLIM1 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLLIM1 As New moe_Estructuras.ePLLIM1
            With vl_ePLLIM1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .nCanCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .nPesCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesCmt")), wp_DT.Rows(wp_nRow).Item("nPesCmt"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .nPorCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCmt")), wp_DT.Rows(wp_nRow).Item("nPorCmt"), 0)
                .sCodAlmCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .sTipCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCmt")), wp_DT.Rows(wp_nRow).Item("sTipCmt"), "")
                .sCodCmtAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.bItmAct")), wp_DT.Rows(wp_nRow).Item("T0.bItmAct"), "")
                .sNomCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomitm")), wp_DT.Rows(wp_nRow).Item("sNomitm"), "")
            End With
            wp_ePLLIM1 = vl_ePLLIM1
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLLIM1(ByRef wp_VlrCtrl As DataGridView,
                            ByVal wp_aePLLIM1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLLIM1)
            Dim vl_aePLLIM1(wl_nCntReg) As moe_Estructuras.ePLLIM1
            vl_aePLLIM1 = wp_aePLLIM1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLLIM1(wp_VlrCtrl,
                                   vl_aePLLIM1(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLLIM1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_ePLLIM1 As Object,
                               ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLLIM1.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLLIM1.sCodItm
                .Rows(wp_nRow).Cells("sCodCmt").Value = wp_ePLLIM1.sCodCmt
                .Rows(wp_nRow).Cells("nCanCmt").Value = wp_ePLLIM1.nCanCmt
                .Rows(wp_nRow).Cells("nPesCmt").Value = wp_ePLLIM1.nPesCmt
                .Rows(wp_nRow).Cells("nPorCmt").Value = wp_ePLLIM1.nPorCmt
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_ePLLIM1.sCodAlm
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = wp_ePLLIM1.sCodAlmCns
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_ePLLIM1.sUniMedInv
                .Rows(wp_nRow).Cells("sTipCmt").Value = wp_ePLLIM1.sTipCmt
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = wp_ePLLIM1.sCodCmtAlt
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLLIM1.bItmAct
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM1_DGV(ByRef wp_ePLLIM1 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLLIM1
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .nCanCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanCmt").Value
                .nPesCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nPesCmt").Value
                .nPorCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorCmt").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .sCodAlmCns = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCns").Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value
                .sTipCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipCmt").Value
                .sCodCmtAlt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmtAlt").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLLIM1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .Rows(wp_nRow).Cells("nCanCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .Rows(wp_nRow).Cells("nPesCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesCmt")), wp_DT.Rows(wp_nRow).Item("nPesCmt"), 0)
                .Rows(wp_nRow).Cells("nPorCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCmt")), wp_DT.Rows(wp_nRow).Item("nPorCmt"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.nPreUni")), wp_DT.Rows(wp_nRow).Item("T2.nPreUni"), 0)
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv"), "")
                .Rows(wp_nRow).Cells("sTipCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCmt")), wp_DT.Rows(wp_nRow).Item("sTipCmt"), "")
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.bItmAct")), wp_DT.Rows(wp_nRow).Item("T0.bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLLIM1")

            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLLIM2 - OPE"
    Public Sub moo_aePLLIM2_DT(ByRef wp_aePLLIM2 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLLIM2 As New moe_Estructuras.ePLLIM2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLLIM2(wl_nCntReg) As moe_Estructuras.ePLLIM2
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLLIM2(wl_nRow) = New moe_Estructuras.ePLLIM2
                vl_ePLLIM2 = New moe_Estructuras.ePLLIM2
                moo_ePLLIM2_DT(vl_ePLLIM2,
                               wp_DT,
                               wl_nRow)
                vl_aePLLIM2(wl_nRow) = vl_ePLLIM2
            Next
            wp_aePLLIM2 = vl_aePLLIM2
        Catch ex As Exception
            MsgBox("Error : moo_aePLLIM2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM2_DT(ByRef wp_ePLLIM2 As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLLIM2 As New moe_Estructuras.ePLLIM2
            With vl_ePLLIM2
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nPosOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpe")), wp_DT.Rows(wp_nRow).Item("nPosOpe"), 0)
                .sCodOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodOpe")), wp_DT.Rows(wp_nRow).Item("T0.sCodOpe"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .nTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTieOpe")), wp_DT.Rows(wp_nRow).Item("T0.nTieOpe"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .nPorOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpe")), wp_DT.Rows(wp_nRow).Item("nPorOpe"), 0)
                .nCanBasPro = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanBasPro")), wp_DT.Rows(wp_nRow).Item("nCanBasPro"), 0)
                .nTotTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOpe")), wp_DT.Rows(wp_nRow).Item("nTotTieOpe"), 0)
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
            wp_ePLLIM2 = vl_ePLLIM2
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLLIM2(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aePLLIM2 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLLIM2)
            Dim vl_aePLLIM2(wl_nCntReg) As moe_Estructuras.ePLLIM2
            vl_aePLLIM2 = wp_aePLLIM2
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLLIM2(wp_VlrCtrl,
                                   vl_aePLLIM2(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLLIM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLLIM2(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_ePLLIM2 As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLLIM2.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLLIM2.sCodItm
                .Rows(wp_nRow).Cells("nPosOpe").Value = wp_ePLLIM2.nPosOpe
                .Rows(wp_nRow).Cells("sCodOpe").Value = wp_ePLLIM2.sCodOpe
                .Rows(wp_nRow).Cells("sCodCtr").Value = wp_ePLLIM2.sCodCtr
                .Rows(wp_nRow).Cells("nTieOpe").Value = wp_ePLLIM2.nTieOpe
                .Rows(wp_nRow).Cells("nPreUni").Value = wp_ePLLIM2.nPreUni
                .Rows(wp_nRow).Cells("nPorOpe").Value = wp_ePLLIM2.nPorOpe
                .Rows(wp_nRow).Cells("nCanBasPro").Value = wp_ePLLIM2.nCanBasPro
                .Rows(wp_nRow).Cells("nTotTieOpe").Value = wp_ePLLIM2.nTotTieOpe
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLLIM2.bItmAct
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLLIM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM2_DGV(ByRef wp_ePLLIM2 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLLIM2
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .nPosOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nPosOpe").Value
                .sCodOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodOpe").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .nTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieOpe").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .nPorOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorOpe").Value
                .nCanBasPro = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanBasPro").Value
                .nTotTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieOpe").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM2_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLLIM2(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_DT As DataTable,
                                    ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("nPosOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPosOpe")), wp_DT.Rows(wp_nRow).Item("nPosOpe"), "")
                .Rows(wp_nRow).Cells("sCodOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodOpe")), wp_DT.Rows(wp_nRow).Item("T0.sCodOpe"), "")
                .Rows(wp_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .Rows(wp_nRow).Cells("nTieOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTieOpe")), wp_DT.Rows(wp_nRow).Item("T0.nTieOpe"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .Rows(wp_nRow).Cells("nPorOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpe")), wp_DT.Rows(wp_nRow).Item("nPorOpe"), 0)
                .Rows(wp_nRow).Cells("nCanBasPro").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanBasPro")), wp_DT.Rows(wp_nRow).Item("nCanBasPro"), 0)
                .Rows(wp_nRow).Cells("nTotTieOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOpe")), wp_DT.Rows(wp_nRow).Item("nTotTieOpe"), 0)
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLLIM2")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLLIM3 - CIF"
    Public Sub moo_aePLLIM3_DT(ByRef wp_aePLLIM3 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLLIM3 As New moe_Estructuras.ePLLIM3
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLLIM3(wl_nCntReg) As moe_Estructuras.ePLLIM3
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLLIM3(wl_nRow) = New moe_Estructuras.ePLLIM3
                vl_ePLLIM3 = New moe_Estructuras.ePLLIM3
                moo_ePLLIM3_DT(vl_ePLLIM3,
                               wp_DT,
                               wl_nRow)
                vl_aePLLIM3(wl_nRow) = vl_ePLLIM3
            Next
            wp_aePLLIM3 = vl_aePLLIM3
        Catch ex As Exception
            MsgBox("Error : moo_aePLLIM3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM3_DT(ByRef wp_ePLLIM3 As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLLIM3 As New moe_Estructuras.ePLLIM3
            With vl_ePLLIM3
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sCodCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCIF")), wp_DT.Rows(wp_nRow).Item("T0.sCodCIF"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .nVlrCIFRea = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea"), 0)
                .nTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTasCIF")), wp_DT.Rows(wp_nRow).Item("T0.nTasCIF"), 0)
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
            wp_ePLLIM3 = vl_ePLLIM3
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLLIM3(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aePLLIM3 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLLIM3)
            Dim vl_aePLLIM3(wl_nCntReg) As moe_Estructuras.ePLLIM3
            vl_aePLLIM3 = wp_aePLLIM3
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLLIM3(wp_VlrCtrl,
                                   vl_aePLLIM3(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLLIM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLLIM3(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_ePLLIM3 As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLLIM3.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLLIM3.sCodItm
                .Rows(wp_nRow).Cells("sCodCIF").Value = wp_ePLLIM3.sCodCIF
                .Rows(wp_nRow).Cells("sCodCtr").Value = wp_ePLLIM3.sCodCtr
                .Rows(wp_nRow).Cells("nVlrCIFRea").Value = wp_ePLLIM3.nVlrCIFRea
                .Rows(wp_nRow).Cells("nTasCIF").Value = wp_ePLLIM3.nTasCIF
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLLIM3.bItmAct
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLLIM3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM3_DGV(ByRef wp_ePLLIM3 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLLIM3
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCIF").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .nVlrCIFRea = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrCIFRea").Value
                .nTasCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nTasCIF").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM3_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLLIM3(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCIF")), wp_DT.Rows(wp_nRow).Item("T0.sCodCIF"), "")
                .Rows(wp_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .Rows(wp_nRow).Cells("nVlrCIFRea").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea"), 0)
                .Rows(wp_nRow).Cells("nTasCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTasCIF")), wp_DT.Rows(wp_nRow).Item("T0.nTasCIF"), 0)
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLLIM3")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ePLLIM4 - FM"
    Public Sub moo_aePLLIM4_DT(ByRef wp_aePLLIM4 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim vl_ePLLIM4 As New moe_Estructuras.ePLLIM4
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLLIM4(wl_nCntReg) As moe_Estructuras.ePLLIM4
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLLIM4(wl_nRow) = New moe_Estructuras.ePLLIM4
                vl_ePLLIM4 = New moe_Estructuras.ePLLIM4
                moo_ePLLIM1_DT(vl_ePLLIM4,
                               wp_DT,
                               wl_nRow)
                vl_aePLLIM4(wl_nRow) = vl_ePLLIM4
            Next
            wp_aePLLIM4 = vl_aePLLIM4
        Catch ex As Exception
            MsgBox("Error : moo_aePLLIM4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM4_DT(ByRef wp_ePLLIM4 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim vl_ePLLIM4 As New moe_Estructuras.ePLLIM4
            With vl_ePLLIM4
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .nCanCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .nPesCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesCmt")), wp_DT.Rows(wp_nRow).Item("nPesCmt"), 0)
                .nPorCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCmt")), wp_DT.Rows(wp_nRow).Item("nPorCmt"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .sCodAlmCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .sTipCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCmt")), wp_DT.Rows(wp_nRow).Item("sTipCmt"), "")
                .sCodCmtAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.bItmAct")), wp_DT.Rows(wp_nRow).Item("T0.bItmAct"), "")
            End With
            wp_ePLLIM4 = vl_ePLLIM4
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLLIM4(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLLIM4 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLLIM4)
            Dim vl_aePLLIM4(wl_nCntReg) As moe_Estructuras.ePLLIM4
            vl_aePLLIM4 = wp_aePLLIM4
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLLIM4(wp_VlrCtrl,
                                   vl_aePLLIM4(wl_nRow),
                                   wl_nRow)
                End With
            Next


        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLLIM4")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLLIM4(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_ePLLIM4 As Object,
                               ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_ePLLIM4.nId
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePLLIM4.sCodItm
                .Rows(wp_nRow).Cells("sCodCmt").Value = wp_ePLLIM4.sCodCmt
                .Rows(wp_nRow).Cells("nCanCmt").Value = wp_ePLLIM4.nCanCmt
                .Rows(wp_nRow).Cells("nPesCmt").Value = wp_ePLLIM4.nPesCmt
                .Rows(wp_nRow).Cells("nPorCmt").Value = wp_ePLLIM4.nPorCmt
                .Rows(wp_nRow).Cells("nPreUni").Value = wp_ePLLIM4.nPreUni
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = wp_ePLLIM4.sCodAlmCns
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_ePLLIM4.sUniMedInv
                .Rows(wp_nRow).Cells("sTipCmt").Value = wp_ePLLIM4.sTipCmt
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = wp_ePLLIM4.sCodCmtAlt
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_ePLLIM4.bItmAct

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLLIM4")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLLIM4_DGV(ByRef wp_ePLLIM4 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_nRow As Integer)
        Try
            With wp_ePLLIM4
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .nCanCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanCmt").Value
                .nPesCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nPesCmt").Value
                .nPorCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorCmt").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .sCodAlmCns = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCns").Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value
                .sTipCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipCmt").Value
                .sCodCmtAlt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmtAlt").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value

            End With
        Catch ex As Exception
            MsgBox("Error : moo_ePLLIM4_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLLIM4(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .Rows(wp_nRow).Cells("nCanCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .Rows(wp_nRow).Cells("nPesCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPesCmt")), wp_DT.Rows(wp_nRow).Item("nPesCmt"), 0)
                .Rows(wp_nRow).Cells("nPorCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorCmt")), wp_DT.Rows(wp_nRow).Item("nPorCmt"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .Rows(wp_nRow).Cells("sTipCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCmt")), wp_DT.Rows(wp_nRow).Item("sTipCmt"), "")
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .Rows(wp_nRow).Cells("bItmAct").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLLIM4")

            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#End Region

#Region "PERCI"
    Public Sub moo_aePERCI_DT(ByRef wp_eaPERCI As Object,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePERCI As New moe_Estructuras.ePERCI
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePERCI(wl_nCntReg) As moe_Estructuras.ePERCI

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePERCI(wl_nRow) = New moe_Estructuras.ePERCI
                wl_ePERCI = New moe_Estructuras.ePERCI
                moo_ePERCI_DT(wl_ePERCI,
                              wp_DT,
                              wl_nRow)
                wl_aePERCI(wl_nRow) = wl_ePERCI
            Next
            wp_eaPERCI = wl_aePERCI
        Catch ex As Exception
            MsgBox("Error : moo_aePERCI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePERCI_DT(ByRef wp_ePERCI As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_ePERCI As New moe_Estructuras.ePERCI
            With wl_ePERCI
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecCtb")), wp_DT.Rows(wp_nRow).Item("dFecCtb"), #1/1/1901#)
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecVto")), wp_DT.Rows(wp_nRow).Item("dFecVto"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "") '11
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .nTotHHCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHCIF")), wp_DT.Rows(wp_nRow).Item("nTotHHCIF"), 0)
                .nTotMMCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMCIF")), wp_DT.Rows(wp_nRow).Item("nTotMMCIF"), 0)
                .nTotTieCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCIF")), wp_DT.Rows(wp_nRow).Item("nTotTieCIF"), 0)
                .nTotDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDoc")), wp_DT.Rows(wp_nRow).Item("nTotDoc"), 0)
                .sCodCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCte")), wp_DT.Rows(wp_nRow).Item("sCodCte"), "")
                .nNroCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCte")), wp_DT.Rows(wp_nRow).Item("nNroCte"), 0)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                .sCodCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCteCtb")), wp_DT.Rows(wp_nRow).Item("sCodCteCtb"), "")
                .nNroCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCteCtb")), wp_DT.Rows(wp_nRow).Item("nNroCteCtb"), 0)
                .nIdFECCT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdFECCT")), wp_DT.Rows(wp_nRow).Item("nIdFECCT"), 0)
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "") '22
                .sTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipDoc")), wp_DT.Rows(wp_nRow).Item("sTipDoc"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
            End With
            wp_ePERCI = wl_ePERCI
        Catch ex As Exception
            MsgBox("Error : moo_ePERCI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePERCI(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eaPERCI As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaPERCI)
            Dim wl_aePERCI(wl_nCntReg) As moe_Estructuras.ePERCI
            wl_aePERCI = wp_eaPERCI
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePELIM(wp_VlrCtrl,
                                   wl_aePERCI(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePERCI")
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub moo_DGV_ePERCI(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aePERCI As Object,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl
                .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                .Rows(wl_nRow).Cells("nId").Value = wp_aePERCI(wl_nRow).nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_aePERCI(wl_nRow).sCodDoc
                .Rows(wl_nRow).Cells("nNroDoc").Value = wp_aePERCI(wl_nRow).nNroDoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_aePERCI(wl_nRow).sCodSer
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_aePERCI(wl_nRow).sTipMov
                .Rows(wl_nRow).Cells("sEstDoc").Value = wp_aePERCI(wl_nRow).sEstDoc
                .Rows(wl_nRow).Cells("dFecCtb").Value = wp_aePERCI(wl_nRow).dFecCtb
                .Rows(wl_nRow).Cells("dFecDoc").Value = wp_aePERCI(wl_nRow).dFecDoc
                .Rows(wl_nRow).Cells("dFecVto").Value = wp_aePERCI(wl_nRow).dFecVto
                .Rows(wl_nRow).Cells("dFecSys").Value = wp_aePERCI(wl_nRow).dFecSys
                .Rows(wl_nRow).Cells("sCodTer").Value = wp_aePERCI(wl_nRow).sCodTer
                .Rows(wl_nRow).Cells("sNomTer").Value = wp_aePERCI(wl_nRow).sNomTer
                .Rows(wl_nRow).Cells("sDocRef").Value = wp_aePERCI(wl_nRow).sDocRef
                .Rows(wl_nRow).Cells("nTotHHCIF").Value = wp_aePERCI(wl_nRow).nTotHHCIF
                .Rows(wl_nRow).Cells("nTotMMCIF").Value = wp_aePERCI(wl_nRow).nTotMMCIF
                .Rows(wl_nRow).Cells("nTotTieCIF").Value = wp_aePERCI(wl_nRow).nTotTieCIF
                .Rows(wl_nRow).Cells("nTotDoc").Value = wp_aePERCI(wl_nRow).nTotDoc
                .Rows(wl_nRow).Cells("sCodCte").Value = wp_aePERCI(wl_nRow).sCodCte
                .Rows(wl_nRow).Cells("nNroCte").Value = wp_aePERCI(wl_nRow).nNroCte
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_aePERCI(wl_nRow).sClsDoc
                .Rows(wl_nRow).Cells("sCmn").Value = wp_aePERCI(wl_nRow).sCmn
                .Rows(wl_nRow).Cells("sCodCteCtb").Value = wp_aePERCI(wl_nRow).sCodCteCtb
                .Rows(wl_nRow).Cells("nNroCteCtb").Value = wp_aePERCI(wl_nRow).nNroCteCtb
                .Rows(wl_nRow).Cells("nIdFECCT").Value = wp_aePERCI(wl_nRow).nIdFECCT
                .Rows(wl_nRow).Cells("sNitTer").Value = wp_aePERCI(wl_nRow).sNitTer
                .Rows(wl_nRow).Cells("sTipDoc").Value = wp_aePERCI(wl_nRow).sTipDoc
                .Rows(wl_nRow).Cells("sCodUsr").Value = wp_aePERCI(wl_nRow).sCodUsr
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePERCI")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PLRCI1"
    Public Sub moo_aePLRCI1_DT(ByRef wp_eaPLRCI1 As Object,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLRCI1 As New moe_Estructuras.ePLRCI1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePLRCI1(wl_nCntReg) As moe_Estructuras.ePLRCI1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePLRCI1(wl_nRow) = New moe_Estructuras.ePLRCI1
                wl_ePLRCI1 = New moe_Estructuras.ePLRCI1
                moo_ePLRCI1_DT(wl_ePLRCI1,
                              wp_DT,
                              wl_nRow)
                wl_aePLRCI1(wl_nRow) = wl_ePLRCI1
            Next
            wp_eaPLRCI1 = wl_aePLRCI1
        Catch ex As Exception
            MsgBox("Error : moo_aePLRCI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLRCI1_DT(ByRef wp_ePLRCI1 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLRCI1 As New moe_Estructuras.ePLRCI1
            With wl_ePLRCI1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0) '0
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .sCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .nNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .sCodCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCIF")), wp_DT.Rows(wp_nRow).Item("sCodCIF"), "")
                .sNomCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCIF")), wp_DT.Rows(wp_nRow).Item("sNomCIF"), "") '10
                .nHHCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCns")), wp_DT.Rows(wp_nRow).Item("nHHCns"), 0)
                .nMMCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCns")), wp_DT.Rows(wp_nRow).Item("nMMCns"), 0)
                .nTieCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .nTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "") '20
                .nLinBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .sCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .sCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .bItmBlq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .nCanOpeTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOpeTer")), wp_DT.Rows(wp_nRow).Item("nCanOpeTer"), 0)
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "") '28
            End With
            wp_ePLRCI1 = wl_ePLRCI1
        Catch ex As Exception
            MsgBox("Error : moo_ePLRCI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLRCI1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_eaPLRCI1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaPLRCI1)
            Dim wL_eaPLRCI1(wl_nCntReg) As moe_Estructuras.ePLRCI1
            wL_eaPLRCI1 = wp_eaPLRCI1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLRCI1(wp_VlrCtrl,
                                   wp_eaPLRCI1(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLRCI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLRCI1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aePLRCI1 As Object,
                               ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl
                .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                .Rows(wl_nRow).Cells("nId").Value = wp_aePLRCI1(wl_nRow).nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_aePLRCI1(wl_nRow).sCodDoc
                .Rows(wl_nRow).Cells("nNroDoc").Value = wp_aePLRCI1(wl_nRow).nNroDoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_aePLRCI1(wl_nRow).sCodSer
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_aePLRCI1(wl_nRow).sTipMov
                .Rows(wl_nRow).Cells("sCodDocBas").Value = wp_aePLRCI1(wl_nRow).sCodDocBas
                .Rows(wl_nRow).Cells("nNroDocBas").Value = wp_aePLRCI1(wl_nRow).nNroDocBas
                .Rows(wl_nRow).Cells("sCodItm").Value = wp_aePLRCI1(wl_nRow).sCodItm
                .Rows(wl_nRow).Cells("nCanItm").Value = wp_aePLRCI1(wl_nRow).nCanItm
                .Rows(wl_nRow).Cells("sCodCIF").Value = wp_aePLRCI1(wl_nRow).sCodCIF
                .Rows(wl_nRow).Cells("sNomCIF").Value = wp_aePLRCI1(wl_nRow).sNomCIF
                .Rows(wl_nRow).Cells("nHHCns").Value = wp_aePLRCI1(wl_nRow).nHHCns
                .Rows(wl_nRow).Cells("nMMCns").Value = wp_aePLRCI1(wl_nRow).nMMCns
                .Rows(wl_nRow).Cells("nTieCns").Value = wp_aePLRCI1(wl_nRow).nTieCns
                .Rows(wl_nRow).Cells("nPreUni").Value = wp_aePLRCI1(wl_nRow).nPreUni
                .Rows(wl_nRow).Cells("nTotLin").Value = wp_aePLRCI1(wl_nRow).nTotLin
                .Rows(wl_nRow).Cells("sCodCco").Value = wp_aePLRCI1(wl_nRow).sCodCco
                .Rows(wl_nRow).Cells("nLinBas").Value = wp_aePLRCI1(wl_nRow).nLinBas
                .Rows(wl_nRow).Cells("sCodPdo").Value = wp_aePLRCI1(wl_nRow).sCodPdo
                .Rows(wl_nRow).Cells("sCodCta").Value = wp_aePLRCI1(wl_nRow).sCodCta
                .Rows(wl_nRow).Cells("sCtaCosVta").Value = wp_aePLRCI1(wl_nRow).sCtaCosVta
                .Rows(wl_nRow).Cells("bItmBlq").Value = wp_aePLRCI1(wl_nRow).bItmBlq
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_aePLRCI1(wl_nRow).sClsDoc
                .Rows(wl_nRow).Cells("nCanOpeTer").Value = wp_aePLRCI1(wl_nRow).nCanOpeTer
                .Rows(wl_nRow).Cells("sCodCtr").Value = wp_aePLRCI1(wl_nRow).sCodCtr
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLRCI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLRCI1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl
                .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                .Rows(wl_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wl_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .Rows(wl_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .Rows(wl_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .Rows(wl_nRow).Cells("sTipMov").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sTipMov")), wp_DT.Rows(wp_nRow).Item("T0.sTipMov"), "")
                .Rows(wl_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .Rows(wl_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wl_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .Rows(wl_nRow).Cells("sCodCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCIF")), wp_DT.Rows(wp_nRow).Item("sCodCIF"), "")
                .Rows(wl_nRow).Cells("sNomCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCIF")), wp_DT.Rows(wp_nRow).Item("sNomCIF"), "")
                .Rows(wl_nRow).Cells("nHHCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCns")), wp_DT.Rows(wp_nRow).Item("nHHCns"), 0)
                .Rows(wl_nRow).Cells("nMMCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCns")), wp_DT.Rows(wp_nRow).Item("nMMCns"), 0)
                .Rows(wl_nRow).Cells("nTieCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .Rows(wl_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .Rows(wl_nRow).Cells("nTotLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .Rows(wl_nRow).Cells("sCodCco").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .Rows(wl_nRow).Cells("nLinBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0) '17
                .Rows(wl_nRow).Cells("sCodPdo").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .Rows(wl_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .Rows(wl_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .Rows(wl_nRow).Cells("bItmBlq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .Rows(wl_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T0.sClsDoc"), "")
                .Rows(wl_nRow).Cells("nCanOpeTer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOpeTer")), wp_DT.Rows(wp_nRow).Item("nCanOpeTer"), 0)
                .Rows(wl_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), 0)
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLRCI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLRCI1_DGV(ByRef wp_ePLRCI1 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wl_nRow As Integer)
        Try
            Dim wl_ePLRCI1 As New moe_Estructuras.ePLRCI1
            With wp_VlrCtrl
                wl_ePLRCI1.nId = .Rows(wl_nRow).Cells("nID").Value
                wl_ePLRCI1.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_ePLRCI1.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_ePLRCI1.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_ePLRCI1.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
                wl_ePLRCI1.sCodDocBas = .Rows(wl_nRow).Cells("sCodDocBas").Value
                wl_ePLRCI1.nNroDocBas = .Rows(wl_nRow).Cells("nNroDocBas").Value
                wl_ePLRCI1.sCodItm = .Rows(wl_nRow).Cells("sCodItm").Value
                wl_ePLRCI1.nCanItm = .Rows(wl_nRow).Cells("nCanItm").Value
                wl_ePLRCI1.sCodCIF = .Rows(wl_nRow).Cells("sCodCIF").Value
                wl_ePLRCI1.sNomCIF = .Rows(wl_nRow).Cells("sNomCIF").Value
                wl_ePLRCI1.nHHCns = .Rows(wl_nRow).Cells("nHHCns").Value
                wl_ePLRCI1.nMMCns = .Rows(wl_nRow).Cells("nMMCns").Value
                wl_ePLRCI1.nTieCns = .Rows(wl_nRow).Cells("nTieCns").Value
                wl_ePLRCI1.nPreUni = .Rows(wl_nRow).Cells("nPreUni").Value
                wl_ePLRCI1.nTotLin = .Rows(wl_nRow).Cells("nTotLin").Value
                wl_ePLRCI1.sCodCco = .Rows(wl_nRow).Cells("sCodCco").Value
                wl_ePLRCI1.nLinBas = .Rows(wl_nRow).Cells("nLinBas").Value
                wl_ePLRCI1.sCodPdo = .Rows(wl_nRow).Cells("sCodPdo").Value
                wl_ePLRCI1.sCodCta = .Rows(wl_nRow).Cells("sCodCta").Value
                wl_ePLRCI1.sCtaCosVta = .Rows(wl_nRow).Cells("sCtaCosVta").Value
                wl_ePLRCI1.bItmBlq = .Rows(wl_nRow).Cells("bItmBlq").Value
                wl_ePLRCI1.sClsDoc = .Rows(wl_nRow).Cells("sClsDoc").Value
                wl_ePLRCI1.nCanOpeTer = .Rows(wl_nRow).Cells("nCanOpeTer").Value
                wl_ePLRCI1.sCodCtr = .Rows(wl_nRow).Cells("sCodCtr").Value
            End With
            wp_ePLRCI1 = wl_ePLRCI1
        Catch ex As Exception
            MsgBox("Error : moo_ePLRCI1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "PEROP"
    Public Sub moo_aePEROP_DT(ByRef wp_eaPEROP As Object,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEROP(wl_nRow) = New moe_Estructuras.ePEROP
                wl_ePEROP = New moe_Estructuras.ePEROP
                moo_ePEROP_DT(wl_ePEROP,
                              wp_DT,
                              wl_nRow)
                wl_aePEROP(wl_nRow) = wl_ePEROP
            Next
            wp_eaPEROP = wl_aePEROP
        Catch ex As Exception
            MsgBox("Error : moo_aePEROP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_DT(ByRef wp_ePEROP As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            With wl_ePEROP
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecCtb")), wp_DT.Rows(wp_nRow).Item("dFecCtb"), #1/1/1901#)
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecVto")), wp_DT.Rows(wp_nRow).Item("dFecVto"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "") '11
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .nTotHHCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHCns")), wp_DT.Rows(wp_nRow).Item("nTotHHCns"), 0)
                .nTotMMCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMCns")), wp_DT.Rows(wp_nRow).Item("nTotMMCns"), 0)
                .nTotTieCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCns")), wp_DT.Rows(wp_nRow).Item("nTotTieCns"), 0)
                .nTotDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDoc")), wp_DT.Rows(wp_nRow).Item("nTotDoc"), 0)
                .sCodCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCte")), wp_DT.Rows(wp_nRow).Item("sCodCte"), "")
                .nNroCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCte")), wp_DT.Rows(wp_nRow).Item("nNroCte"), 0)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                .sCodCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCteCtb")), wp_DT.Rows(wp_nRow).Item("sCodCteCtb"), "")
                .nNroCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCteCtb")), wp_DT.Rows(wp_nRow).Item("nNroCteCtb"), 0)
                .nIdFECCT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdFECCT")), wp_DT.Rows(wp_nRow).Item("nIdFECCT"), 0)
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "") '22
                .sTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipDoc")), wp_DT.Rows(wp_nRow).Item("sTipDoc"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .bPrp01 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp01")), wp_DT.Rows(wp_nRow).Item("bPrp01"), False)
                .bPrp02 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp02")), wp_DT.Rows(wp_nRow).Item("bPrp02"), False)
                .bPrp03 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp03")), wp_DT.Rows(wp_nRow).Item("bPrp03"), False)
                .nTotHHOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHOpe")), wp_DT.Rows(wp_nRow).Item("nTotHHOpe"), 0)
                .nTotMMOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMOpe")), wp_DT.Rows(wp_nRow).Item("nTotMMOpe"), 0)
                .nTotTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOpe")), wp_DT.Rows(wp_nRow).Item("nTotTieOpe"), 0)
                .nTotHHAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHAlz")), wp_DT.Rows(wp_nRow).Item("nTotHHAlz"), 0)
                .nTotMMAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMAlz")), wp_DT.Rows(wp_nRow).Item("nTotMMAlz"), 0)
                .nTotTieAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieAlz")), wp_DT.Rows(wp_nRow).Item("nTotTieAlz"), 0)
                .nTotHHCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHCaf")), wp_DT.Rows(wp_nRow).Item("nTotHHCaf"), 0)
                .nTotMMCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMCaf")), wp_DT.Rows(wp_nRow).Item("nTotMMCaf"), 0)
                .nTotTieCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCaf")), wp_DT.Rows(wp_nRow).Item("nTotTieCaf"), 0)
            End With
            wp_ePEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_ePEROP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_QCodSer_DGV(ByRef wp_aPEROP As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wl_nRow As Integer)
        Dim wl_ePEROP As New moe_Estructuras.ePEROP
        Try
            With wp_VlrCtrl
                wl_ePEROP.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
            End With
            wp_aPEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_ePEROP_QCodSer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_QCodTer_DGV(ByRef wp_aPEROP As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_ePEROP As New moe_Estructuras.ePEROP
        Try
            With wp_VlrCtrl
                wl_ePEROP.sCodTer = .Rows(wl_nRow).Cells("sCodTer").Value
                wl_ePEROP.sNomTer = .Rows(wl_nRow).Cells("sNomter").Value
            End With
            wp_aPEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_ePEROP_QCodTer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_QNroDoc_DGV(ByRef wp_aPEROP As Object,
                                      ByVal wp_VlrCtrl As DataGridView,
                                       ByVal wl_nRow As Integer)
        Dim wl_ePEROP As New moe_Estructuras.ePEROP
        Try
            With wp_VlrCtrl
                wl_ePEROP.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
            End With
            wp_aPEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_ePEROP_QNroDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aePEROP_QCodSer_DT(ByRef wp_eaPEROP As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEROP(wl_nRow) = New moe_Estructuras.ePEROP
                wl_ePEROP = New moe_Estructuras.ePEROP
                moo_ePEROP_QCodSer_DT(wl_ePEROP,
                                      wp_DT,
                                      wl_nRow)
                wl_aePEROP(wl_nRow) = wl_ePEROP
            Next
            wp_eaPEROP = wl_aePEROP
        Catch ex As Exception
            MsgBox("Error : moo_aePEROP_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_QCodSer_DT(ByRef wp_ePEROP As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            With wl_ePEROP
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
            End With
            wp_ePEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_ePEROP_QCodSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aePEROP_QCodTer_DT(ByRef wp_eaPEROP As Object,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEROP(wl_nRow) = New moe_Estructuras.ePEROP
                wl_ePEROP = New moe_Estructuras.ePEROP
                moo_ePEROP_QCodTer_DT(wl_ePEROP,
                                      wp_DT,
                                      wl_nRow)
                wl_aePEROP(wl_nRow) = wl_ePEROP
            Next
            wp_eaPEROP = wl_aePEROP
        Catch ex As Exception
            MsgBox("Error : moo_aePEROP_QCodTer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_QCodTer_DT(ByRef wp_ePEROP As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            With wl_ePEROP
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
            End With
            wp_ePEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_ePEROP_QCodTer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aePEROP_QNroDoc_DT(ByRef wp_eaPEROP As Object,
                                      ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEROP(wl_nRow) = New moe_Estructuras.ePEROP
                wl_ePEROP = New moe_Estructuras.ePEROP
                moo_ePEROP_QNroDoc_DT(wl_ePEROP,
                                      wp_DT,
                                      wl_nRow)
                wl_aePEROP(wl_nRow) = wl_ePEROP
            Next
            wp_eaPEROP = wl_aePEROP
        Catch ex As Exception
            MsgBox("Error : moo_aePEROP_QNroDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_QNroDoc_DT(ByRef wp_ePEROP As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            With wl_ePEROP
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
            End With
            wp_ePEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_DTVarDGV.moo_ePEROP_QNroDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEROP(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_eaPEROP As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaPEROP)
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP
            wl_aePEROP = wp_eaPEROP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEROP(wp_VlrCtrl,
                                   wl_aePEROP(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEROP")
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub moo_DGV_ePEROP(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aePEROP As Object,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl
                .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                .Rows(wl_nRow).Cells("nId").Value = wp_aePEROP.nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_aePEROP.sCodDoc
                .Rows(wl_nRow).Cells("nNroDoc").Value = wp_aePEROP.nNroDoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_aePEROP.sCodSer
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_aePEROP.sTipMov
                .Rows(wl_nRow).Cells("sEstDoc").Value = wp_aePEROP.sEstDoc
                .Rows(wl_nRow).Cells("dFecCtb").Value = wp_aePEROP.dFecCtb
                .Rows(wl_nRow).Cells("dFecDoc").Value = wp_aePEROP.dFecDoc
                .Rows(wl_nRow).Cells("dFecVto").Value = wp_aePEROP.dFecVto
                .Rows(wl_nRow).Cells("dFecSys").Value = wp_aePEROP.dFecSys
                .Rows(wl_nRow).Cells("sCodTer").Value = wp_aePEROP.sCodTer
                .Rows(wl_nRow).Cells("sNomTer").Value = wp_aePEROP.sNomTer
                .Rows(wl_nRow).Cells("sDocRef").Value = wp_aePEROP.sDocRef
                .Rows(wl_nRow).Cells("nTotHHCns").Value = wp_aePEROP.nTotHHCns
                .Rows(wl_nRow).Cells("nTotMMCns").Value = wp_aePEROP.nTotMMCns
                .Rows(wl_nRow).Cells("nTotTieCns").Value = wp_aePEROP.nTotTieCns
                .Rows(wl_nRow).Cells("nTotDoc").Value = wp_aePEROP.nTotDoc
                .Rows(wl_nRow).Cells("sCodCte").Value = wp_aePEROP.sCodCte
                .Rows(wl_nRow).Cells("nNroCte").Value = wp_aePEROP.nNroCte
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_aePEROP.sClsDoc
                .Rows(wl_nRow).Cells("sCmn").Value = wp_aePEROP.sCmn
                .Rows(wl_nRow).Cells("sCodCteCtb").Value = wp_aePEROP.sCodCteCtb
                .Rows(wl_nRow).Cells("nNroCteCtb").Value = wp_aePEROP.nNroCteCtb
                .Rows(wl_nRow).Cells("nIdFECCT").Value = wp_aePEROP.nIdFECCT
                .Rows(wl_nRow).Cells("sNitTer").Value = wp_aePEROP.sNitTer
                .Rows(wl_nRow).Cells("sTipDoc").Value = wp_aePEROP.sTipDoc
                .Rows(wl_nRow).Cells("sCodUsr").Value = wp_aePEROP.sCodUsr
                .Rows(wl_nRow).Cells("bPrp01").Value = wp_aePEROP.bPrp01
                .Rows(wl_nRow).Cells("bPrp02").Value = wp_aePEROP.bPrp02
                .Rows(wl_nRow).Cells("bPrp03").Value = wp_aePEROP.bPrp03
                .Rows(wl_nRow).Cells("nTotHHOpe").Value = wp_aePEROP.nTotHHOpe
                .Rows(wl_nRow).Cells("nTotMMOpe").Value = wp_aePEROP.nTotMMOpe
                .Rows(wl_nRow).Cells("nTotTieOpe").Value = wp_aePEROP.nTotTieOpe
                .Rows(wl_nRow).Cells("nTotHHAlz").Value = wp_aePEROP.nTotHHAlz
                .Rows(wl_nRow).Cells("nTotMMAlz").Value = wp_aePEROP.nTotMMAlz
                .Rows(wl_nRow).Cells("nTotTieAlz").Value = wp_aePEROP.nTotTieAlz
                .Rows(wl_nRow).Cells("nTotHHCaf").Value = wp_aePEROP.nTotHHCaf
                .Rows(wl_nRow).Cells("nTotMMCaf").Value = wp_aePEROP.nTotMMCaf
                .Rows(wl_nRow).Cells("nTotTieCaf").Value = wp_aePEROP.nTotTieCaf
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEROP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEROP_QCodSer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_aePEROP As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEROP)
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP
            wl_aePEROP = wp_aePEROP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEROP_QCodSer(wp_VlrCtrl,
                                           wl_aePEROP(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEROP_QCodSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEROP_QCodSer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_ePEROP As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_ePEROP.sCodSer

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEROP_QCodSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEROP_QCodTer(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaPEROP As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaPEROP)
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP
            wl_aePEROP = wp_eaPEROP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEROP_QCodTer(wp_VlrCtrl,
                                           wl_aePEROP(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEROP_QCodTer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEROP_QCodTer(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_ePEROP As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("sCodTer").Value = wp_ePEROP.sCodTer
                .Rows(wp_nRow).Cells("sNomTer").Value = wp_ePEROP.sNomTer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEROP_QCodTer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEROP_QNroDoc(ByRef wp_VlrCtrl As DataGridView,
                                       ByVal wp_eaPEROP As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaPEROP)
            Dim wl_aePEROP(wl_nCntReg) As moe_Estructuras.ePEROP
            wl_aePEROP = wp_eaPEROP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEROP_QNroDoc(wp_VlrCtrl,
                                           wl_aePEROP(wl_nRow),
                                           wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEROP_QNroDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEROP_QNroDoc(ByRef wp_VlrCtrl As DataGridView,
                                      ByVal wp_ePEROP As Object,
                                      ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).HeaderCell.Value = (wp_nRow + 1).ToString
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_ePEROP.nNroDoc

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEROP_QNroDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEROP_DGV(ByRef wp_ePEROP As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEROP As New moe_Estructuras.ePEROP
            With wl_ePEROP
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sTipMov = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipMov").Value
                .sEstDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sEstDoc").Value
                .dFecCtb = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecCtb").Value
                .dFecDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecDoc").Value
                .dFecVto = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecVto").Value
                .dFecSys = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecSys").Value
                .sCodTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value
                .sNomTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTer").Value
                .sDocRef = wp_VlrCtrl.Rows(wp_nRow).Cells("sDocRef").Value
                .nTotHHCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotHHCns").Value
                .nTotMMCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotMMCns").Value
                .nTotTieCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieCns").Value
                .nTotDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotDoc").Value
                .sCodCte = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCte").Value
                .nNroCte = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroCte").Value
                .sClsDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sClsDoc").Value
                .sCmn = wp_VlrCtrl.Rows(wp_nRow).Cells("sCmn").Value
                .sCodCteCtb = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCteCtb").Value
                .nNroCteCtb = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroCteCtb").Value
                .nIdFECCT = wp_VlrCtrl.Rows(wp_nRow).Cells("nIdFECCT").Value
                .sNitTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sNitTer").Value
                .sTipDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipDoc").Value
                .sCodUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value
                .bPrp01 = wp_VlrCtrl.Rows(wp_nRow).Cells("bPrp01").Value
                .bPrp02 = wp_VlrCtrl.Rows(wp_nRow).Cells("bPrp02").Value
                .bPrp03 = wp_VlrCtrl.Rows(wp_nRow).Cells("bPrp03").Value
                .nTotHHOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotHHOpe").Value
                .nTotMMOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotMMOpe").Value
                .nTotTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieOpe").Value
                .nTotHHAlz = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotHHAlz").Value
                .nTotMMAlz = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotMMAlz").Value
                .nTotTieAlz = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieAlz").Value
                .nTotHHCaf = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotHHCaf").Value
                .nTotMMCaf = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotMMCaf").Value
                .nTotTieCaf = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieCaf").Value
            End With
            wp_ePEROP = wl_ePEROP
        Catch ex As Exception
            MsgBox("Error : moo_ePEROP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PLROP1"
    Public Sub moo_aePELROP1_DT(ByRef wp_eaPELROP1 As Object,
                                ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePELROP1 As New moe_Estructuras.ePELROP1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePELROP1(wl_nCntReg) As moe_Estructuras.ePELROP1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePELROP1(wl_nRow) = New moe_Estructuras.ePELROP1
                wl_ePELROP1 = New moe_Estructuras.ePELROP1
                moo_ePELROP1_DT(wl_ePELROP1,
                                wp_DT,
                                wl_nRow)
                wl_aePELROP1(wl_nRow) = wl_ePELROP1
            Next
            wp_eaPELROP1 = wl_aePELROP1
        Catch ex As Exception
            MsgBox("Error : moo_aePELROP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePELROP1_DT(ByRef wp_ePELROP1 As Object,
                                ByVal wp_DT As DataTable,
                                ByVal wp_nRow As Integer)
        Try
            Dim wl_ePELROP1 As New moe_Estructuras.ePELROP1
            With wl_ePELROP1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sTipMov")), wp_DT.Rows(wp_nRow).Item("T0.sTipMov"), "")
                .sEstDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstDoc")), wp_DT.Rows(wp_nRow).Item("sEstDoc"), "")
                .dFecCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecCtb")), wp_DT.Rows(wp_nRow).Item("dFecCtb"), #1/1/1901#)
                .dFecDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecDoc")), wp_DT.Rows(wp_nRow).Item("dFecDoc"), #1/1/1901#)
                .dFecVto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecVto")), wp_DT.Rows(wp_nRow).Item("dFecVto"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "") '11
                .sDocRef = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDocRef")), wp_DT.Rows(wp_nRow).Item("sDocRef"), "")
                .nTotHHCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHCns")), wp_DT.Rows(wp_nRow).Item("nTotHHCns"), 0)
                .nTotMMCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMCns")), wp_DT.Rows(wp_nRow).Item("nTotMMCns"), 0)
                .nTotTieCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCns")), wp_DT.Rows(wp_nRow).Item("nTotTieCns"), 0)
                .nTotDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotDoc")), wp_DT.Rows(wp_nRow).Item("nTotDoc"), 0)
                .sCodCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCte")), wp_DT.Rows(wp_nRow).Item("sCodCte"), "")
                .nNroCte = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCte")), wp_DT.Rows(wp_nRow).Item("nNroCte"), 0)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T0.sClsDoc"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
                .sCodCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCteCtb")), wp_DT.Rows(wp_nRow).Item("sCodCteCtb"), "")
                .nNroCteCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroCteCtb")), wp_DT.Rows(wp_nRow).Item("nNroCteCtb"), 0)
                .nIdFECCT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdFECCT")), wp_DT.Rows(wp_nRow).Item("nIdFECCT"), 0)
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "") '22
                .sTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipDoc")), wp_DT.Rows(wp_nRow).Item("sTipDoc"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .bPrp01 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp01")), wp_DT.Rows(wp_nRow).Item("bPrp01"), False)
                .bPrp02 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp02")), wp_DT.Rows(wp_nRow).Item("bPrp02"), False)
                .bPrp03 = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bPrp03")), wp_DT.Rows(wp_nRow).Item("bPrp03"), False)
                .nTotHHOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHOpe")), wp_DT.Rows(wp_nRow).Item("nTotHHOpe"), 0)
                .nTotMMOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMOpe")), wp_DT.Rows(wp_nRow).Item("nTotMMOpe"), 0)
                .nTotTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOpe")), wp_DT.Rows(wp_nRow).Item("nTotTieOpe"), 0)
                .nTotHHAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHAlz")), wp_DT.Rows(wp_nRow).Item("nTotHHAlz"), 0)
                .nTotMMAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMAlz")), wp_DT.Rows(wp_nRow).Item("nTotMMAlz"), 0)
                .nTotTieAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieAlz")), wp_DT.Rows(wp_nRow).Item("nTotTieAlz"), 0)
                .nTotHHCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotHHCaf")), wp_DT.Rows(wp_nRow).Item("nTotHHCaf"), 0)
                .nTotMMCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotMMCaf")), wp_DT.Rows(wp_nRow).Item("nTotMMCaf"), 0)
                .nTotTieCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCaf")), wp_DT.Rows(wp_nRow).Item("nTotTieCaf"), 0)

                .xnId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nId")), wp_DT.Rows(wp_nRow).Item("T1.nId"), 0) '0
                .xnIdPEROP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdPEROP")), wp_DT.Rows(wp_nRow).Item("nIdPEROP"), 0) '0
                .xsCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T1.sCodDoc"), "")
                .xnNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T1.nNroDoc"), 0)
                .xsCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodSer")), wp_DT.Rows(wp_nRow).Item("T1.sCodSer"), "")
                .xsTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sTipMov")), wp_DT.Rows(wp_nRow).Item("T1.sTipMov"), "")
                .xsCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .xsCodSerBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .xnNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .xsCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .xnCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .xsCodOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodOpe")), wp_DT.Rows(wp_nRow).Item("sCodOpe"), "")
                .xsNomOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpe")), wp_DT.Rows(wp_nRow).Item("sNomOpe"), "") '10
                .xnHHIniOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniOpe")), wp_DT.Rows(wp_nRow).Item("nHHIniOpe"), 0)
                .xnMMIniOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniOpe")), wp_DT.Rows(wp_nRow).Item("nMMIniOpe"), 0)
                .xnHHFinOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinOpe")), wp_DT.Rows(wp_nRow).Item("nHHFinOpe"), 0)
                .xnMMFinOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinOpe")), wp_DT.Rows(wp_nRow).Item("nMMFinOpe"), 0)
                .xnHHCnsOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsOpe")), wp_DT.Rows(wp_nRow).Item("nHHCnsOpe"), 0)
                .xnMMCnsOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsOpe")), wp_DT.Rows(wp_nRow).Item("nMMCnsOpe"), 0)
                .xnTieCnsOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsOpe")), wp_DT.Rows(wp_nRow).Item("nTieCnsOpe"), 0)
                .xnHHCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCns")), wp_DT.Rows(wp_nRow).Item("nHHCns"), 0)
                .xnMMCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCns")), wp_DT.Rows(wp_nRow).Item("nMMCns"), 0)
                .xnTieCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .xnTieReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieReq")), wp_DT.Rows(wp_nRow).Item("nTieReq"), 0)
                .xnPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .xnTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .xsCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "") '20
                .xnLinBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .xsCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .xsCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .xsCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .xbItmBlq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .xsClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T1.sClsDoc"), "")
                .xnCanOpeTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOpeTer")), wp_DT.Rows(wp_nRow).Item("nCanOpeTer"), 0)
                .xsCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "") '28
                .xnHHIniAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniAlz")), wp_DT.Rows(wp_nRow).Item("nHHIniALz"), 0)
                .xnMMIniAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniAlz")), wp_DT.Rows(wp_nRow).Item("nMMIniAlz"), 0)
                .xnHHFinAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinAlz")), wp_DT.Rows(wp_nRow).Item("nHHFinAlz"), 0)
                .xnMMFinAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinAlz")), wp_DT.Rows(wp_nRow).Item("nMMFinAlz"), 0)
                .xnHHCnsAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsAlz")), wp_DT.Rows(wp_nRow).Item("nHHCnsAlz"), 0)
                .xnMMCnsAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsAlz")), wp_DT.Rows(wp_nRow).Item("nMMCnsAlz"), 0)
                .xnTieCnsAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsAlz")), wp_DT.Rows(wp_nRow).Item("nTieCnsAlz"), 0)
                .xnHHIniCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniCaf")), wp_DT.Rows(wp_nRow).Item("nHHIniCaf"), 0)
                .xnMMIniCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniCaf")), wp_DT.Rows(wp_nRow).Item("nMMIniCaf"), 0)
                .xnHHFinCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinCaf")), wp_DT.Rows(wp_nRow).Item("nHHFinCaf"), 0)
                .xnMMFinCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinCaf")), wp_DT.Rows(wp_nRow).Item("nMMFinCaf"), 0)
                .xnHHCnsCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsCaf")), wp_DT.Rows(wp_nRow).Item("nHHCnsCaf"), 0)
                .xnMMCnsCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsCaf")), wp_DT.Rows(wp_nRow).Item("nMMCnsCaf"), 0)
                .xnTieCnsCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsCaf")), wp_DT.Rows(wp_nRow).Item("nTieCnsCaf"), 0)
            End With
            wp_ePELROP1 = wl_ePELROP1
        Catch ex As Exception
            MsgBox("Error : moo_ePELROP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLEROP1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_aePELROP1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePELROP1)
            Dim wl_eaPELROP1(wl_nCntReg) As moe_Estructuras.ePELROP1
            wl_eaPELROP1 = wp_aePELROP1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePELROP1(wp_VlrCtrl,
                                   wl_eaPELROP1(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLEROP1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub moo_DGV_ePELROP1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePELROP1 As Object,
                                ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl

                .Rows(wl_nRow).Cells("nId").Value = wp_aePELROP1.nID
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_aePELROP1.sCodDoc
                .Rows(wl_nRow).Cells("nNroDoc").Value = wp_aePELROP1.nNroDoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_aePELROP1.sCodSer
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_aePELROP1.sTipMov
                .Rows(wl_nRow).Cells("sEstDoc").Value = wp_aePELROP1.sEstDoc
                .Rows(wl_nRow).Cells("dFecCtb").Value = wp_aePELROP1.dFecCtb
                .Rows(wl_nRow).Cells("dFecDoc").Value = wp_aePELROP1.dFecDoc
                .Rows(wl_nRow).Cells("dFecVto").Value = wp_aePELROP1.dFecVto
                .Rows(wl_nRow).Cells("dFecSys").Value = wp_aePELROP1.dFecSys
                .Rows(wl_nRow).Cells("sCodTer").Value = wp_aePELROP1.sCodTer
                .Rows(wl_nRow).Cells("sNomTer").Value = wp_aePELROP1.sNomTer
                .Rows(wl_nRow).Cells("sDocRef").Value = wp_aePELROP1.sDocRef
                .Rows(wl_nRow).Cells("nTotHHCns").Value = wp_aePELROP1.nTotHHCns
                .Rows(wl_nRow).Cells("nTotMMCns").Value = wp_aePELROP1.nTotMMCns
                .Rows(wl_nRow).Cells("nTotTieCns").Value = wp_aePELROP1.nTotTieCns
                .Rows(wl_nRow).Cells("nTotDoc").Value = wp_aePELROP1.nTotDoc
                .Rows(wl_nRow).Cells("sCodCte").Value = wp_aePELROP1.sCodCte
                .Rows(wl_nRow).Cells("nNroCte").Value = wp_aePELROP1.nNroCte
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_aePELROP1.sClsDoc
                .Rows(wl_nRow).Cells("sCmn").Value = wp_aePELROP1.sCmn
                .Rows(wl_nRow).Cells("sCodCteCtb").Value = wp_aePELROP1.sCodCteCtb
                .Rows(wl_nRow).Cells("nNroCteCtb").Value = wp_aePELROP1.nNroCteCtb
                .Rows(wl_nRow).Cells("nIdFECCT").Value = wp_aePELROP1.nIdFECCT
                .Rows(wl_nRow).Cells("sNitTer").Value = wp_aePELROP1.sNitTer
                .Rows(wl_nRow).Cells("sTipDoc").Value = wp_aePELROP1.sTipDoc
                .Rows(wl_nRow).Cells("sCodUsr").Value = wp_aePELROP1.sCodUsr
                .Rows(wl_nRow).Cells("bPrp01").Value = wp_aePELROP1.bPrp01
                .Rows(wl_nRow).Cells("bPrp02").Value = wp_aePELROP1.bPrp02
                .Rows(wl_nRow).Cells("bPrp03").Value = wp_aePELROP1.bPrp03
                .Rows(wl_nRow).Cells("nTotHHOpe").Value = wp_aePELROP1.nTotHHOpe
                .Rows(wl_nRow).Cells("nTotMMOpe").Value = wp_aePELROP1.nTotMMOPe
                .Rows(wl_nRow).Cells("nTotTieOpe").Value = wp_aePELROP1.nTotTieOpe
                .Rows(wl_nRow).Cells("nTotHHAlz").Value = wp_aePELROP1.nTotHHAlz
                .Rows(wl_nRow).Cells("nTotMMAlz").Value = wp_aePELROP1.nTotMMAlz
                .Rows(wl_nRow).Cells("nTotTieAlz").Value = wp_aePELROP1.nTotTieAlz
                .Rows(wl_nRow).Cells("nTotHHAlz").Value = wp_aePELROP1.nTotHHCaf
                .Rows(wl_nRow).Cells("nTotMMAlz").Value = wp_aePELROP1.nTotMMCaf
                .Rows(wl_nRow).Cells("nTotTieAlz").Value = wp_aePELROP1.nTotTieCaf


                .Rows(wl_nRow).Cells("xnId").Value = wp_aePELROP1.xnID
                .Rows(wl_nRow).Cells("xnIdPEROP").Value = wp_aePELROP1.xnIDPEROP
                .Rows(wl_nRow).Cells("xsCodDoc").Value = wp_aePELROP1.xsCodDoc
                .Rows(wl_nRow).Cells("xnNroDoc").Value = wp_aePELROP1.xnNroDoc
                .Rows(wl_nRow).Cells("xsCodSer").Value = wp_aePELROP1.xsCodSer
                .Rows(wl_nRow).Cells("xsTipMov").Value = wp_aePELROP1.xsTipMov
                .Rows(wl_nRow).Cells("xsCodDocBas").Value = wp_aePELROP1.xsCodDocBas
                .Rows(wl_nRow).Cells("xsCodSerBas").Value = wp_aePELROP1.xsCodSerBas
                .Rows(wl_nRow).Cells("xnNroDocBas").Value = wp_aePELROP1.xnNroDocBas
                .Rows(wl_nRow).Cells("xsCodItm").Value = wp_aePELROP1.xsCodItm
                .Rows(wl_nRow).Cells("xnCanItm").Value = wp_aePELROP1.xnCanItm
                .Rows(wl_nRow).Cells("xsCodOpe").Value = wp_aePELROP1.xsCodOpe
                .Rows(wl_nRow).Cells("xsNomOpe").Value = wp_aePELROP1.xsNomOpe
                .Rows(wl_nRow).Cells("xnHHIniOpe").Value = wp_aePELROP1.xnHHIniOpe
                .Rows(wl_nRow).Cells("xnMMIniOpe").Value = wp_aePELROP1.xnMMIniOpe
                .Rows(wl_nRow).Cells("xnHHFinOpe").Value = wp_aePELROP1.xnHHFinOpe
                .Rows(wl_nRow).Cells("xnMMFinOpe").Value = wp_aePELROP1.xnMMFinOpe
                .Rows(wl_nRow).Cells("xnHHCnsOpe").Value = wp_aePELROP1.xnHHCnsOpe
                .Rows(wl_nRow).Cells("xnMMCnsOpe").Value = wp_aePELROP1.xnMMCnsOpe
                .Rows(wl_nRow).Cells("xnTieCnsOpe").Value = wp_aePELROP1.xnTieCnsOpe
                .Rows(wl_nRow).Cells("xnHHCns").Value = wp_aePELROP1.xnHHCns
                .Rows(wl_nRow).Cells("xnMMCns").Value = wp_aePELROP1.xnMMCns
                .Rows(wl_nRow).Cells("xnTieCns").Value = wp_aePELROP1.xnTieCns
                .Rows(wl_nRow).Cells("xnTieReq").Value = wp_aePELROP1.xnTieReq
                .Rows(wl_nRow).Cells("xnPreUni").Value = wp_aePELROP1.xnPreUni
                .Rows(wl_nRow).Cells("xnTotLin").Value = wp_aePELROP1.xnTotLin
                .Rows(wl_nRow).Cells("xsCodCco").Value = wp_aePELROP1.xsCodCco
                .Rows(wl_nRow).Cells("xnLinBas").Value = wp_aePELROP1.xnLinBas
                .Rows(wl_nRow).Cells("xsCodPdo").Value = wp_aePELROP1.xsCodPdo
                .Rows(wl_nRow).Cells("xsCodCta").Value = wp_aePELROP1.xsCodCta
                .Rows(wl_nRow).Cells("xsCtaCosVta").Value = wp_aePELROP1.xsCtaCosVta
                .Rows(wl_nRow).Cells("xbItmBlq").Value = wp_aePELROP1.xbItmBlq
                .Rows(wl_nRow).Cells("xsClsDoc").Value = wp_aePELROP1.xsClsDoc
                .Rows(wl_nRow).Cells("xnCanOpeTer").Value = wp_aePELROP1.xnCanOpeTer
                .Rows(wl_nRow).Cells("xsCodCtr").Value = wp_aePELROP1.xsCodCtr
                .Rows(wl_nRow).Cells("xnHHIniAlz").Value = wp_aePELROP1.xnHHIniAlz
                .Rows(wl_nRow).Cells("xnMMIniAlz").Value = wp_aePELROP1.xnMMIniAlz
                .Rows(wl_nRow).Cells("xnHHFinAlz").Value = wp_aePELROP1.xnHHFinAlz
                .Rows(wl_nRow).Cells("xnMMFinAlz").Value = wp_aePELROP1.xnMMFinAlz
                .Rows(wl_nRow).Cells("xnHHCnsAlz").Value = wp_aePELROP1.xnHHCnsAlz
                .Rows(wl_nRow).Cells("xnMMCnsAlz").Value = wp_aePELROP1.xnMMCnsAlz
                .Rows(wl_nRow).Cells("xnTieCnsAlz").Value = wp_aePELROP1.xnTieCnsAlz
                .Rows(wl_nRow).Cells("xnHHIniCaf").Value = wp_aePELROP1.xnHHIniCaf
                .Rows(wl_nRow).Cells("xnMMIniCaf").Value = wp_aePELROP1.xnMMIniCaf
                .Rows(wl_nRow).Cells("xnHHFinCaf").Value = wp_aePELROP1.xnHHFinCaf
                .Rows(wl_nRow).Cells("xnMMFinCaf").Value = wp_aePELROP1.xnMMFinCaf
                .Rows(wl_nRow).Cells("xnHHCnsCaf").Value = wp_aePELROP1.xnHHCnsCaf
                .Rows(wl_nRow).Cells("xnMMCnsCaf").Value = wp_aePELROP1.xnMMCnsCaf
                .Rows(wl_nRow).Cells("xnTieCnsCaf").Value = wp_aePELROP1.xnTieCnsCaf

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePELROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePELROP1_DGV(ByRef wp_ePELROP1 As Object,
                           ByVal wp_VlrCtrl As DataGridView,
                           ByVal wl_nRow As Integer)
        Try
            Dim wl_ePELROP1 As New moe_Estructuras.ePELROP1
            With wp_VlrCtrl
                wl_ePELROP1.nId = .Rows(wl_nRow).Cells("nId").Value
                wl_ePELROP1.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_ePELROP1.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_ePELROP1.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_ePELROP1.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
                wl_ePELROP1.sEstDoc = .Rows(wl_nRow).Cells("sEstDoc").Value
                wl_ePELROP1.dFecCtb = .Rows(wl_nRow).Cells("dFecCtb").Value
                wl_ePELROP1.dFecDoc = .Rows(wl_nRow).Cells("dFecDoc").Value
                wl_ePELROP1.dFecVto = .Rows(wl_nRow).Cells("dFecVto").Value
                wl_ePELROP1.dFecSys = .Rows(wl_nRow).Cells("dFecSys").Value
                wl_ePELROP1.sCodTer = .Rows(wl_nRow).Cells("sCodTer").Value
                wl_ePELROP1.sNomTer = .Rows(wl_nRow).Cells("sNomTer").Value
                wl_ePELROP1.sDocRef = .Rows(wl_nRow).Cells("sDocRef").Value
                wl_ePELROP1.nTotHHCns = .Rows(wl_nRow).Cells("nTotHHCns").Value
                wl_ePELROP1.nTotMMCns = .Rows(wl_nRow).Cells("nTotMMCns").Value
                wl_ePELROP1.nTotTieCns = .Rows(wl_nRow).Cells("nTotTieCns").Value
                wl_ePELROP1.nTotDoc = .Rows(wl_nRow).Cells("nTotDoc").Value
                wl_ePELROP1.sCodCte = .Rows(wl_nRow).Cells("sCodCte").Value
                wl_ePELROP1.nNroCte = .Rows(wl_nRow).Cells("nNroCte").Value
                wl_ePELROP1.sClsDoc = .Rows(wl_nRow).Cells("sClsDoc").Value
                wl_ePELROP1.sCmn = .Rows(wl_nRow).Cells("sCmn").Value
                wl_ePELROP1.sCodCteCtb = .Rows(wl_nRow).Cells("sCodCteCtb").Value
                wl_ePELROP1.nNroCteCtb = .Rows(wl_nRow).Cells("nNroCteCtb").Value
                wl_ePELROP1.nIdFECCT = .Rows(wl_nRow).Cells("nIdFECCT").Value
                wl_ePELROP1.sNitTer = .Rows(wl_nRow).Cells("sNitTer").Value
                wl_ePELROP1.sTipDoc = .Rows(wl_nRow).Cells("sTipDoc").Value
                wl_ePELROP1.sCodUsr = .Rows(wl_nRow).Cells("sCodUsr").Value
                wl_ePELROP1.bPrp01 = .Rows(wl_nRow).Cells("bPrp01").Value
                wl_ePELROP1.bPrp02 = .Rows(wl_nRow).Cells("bPrp02").Value
                wl_ePELROP1.bPrp03 = .Rows(wl_nRow).Cells("bPrp03").Value
                wl_ePELROP1.nTotHHOpe = .Rows(wl_nRow).Cells("nTotHHOpe").Value
                wl_ePELROP1.nTotMMOpe = .Rows(wl_nRow).Cells("nTotMMOpe").Value
                wl_ePELROP1.nTotTieOpe = .Rows(wl_nRow).Cells("nTotTieOpe").Value
                wl_ePELROP1.nTotHHAlz = .Rows(wl_nRow).Cells("nTotHHAlz").Value
                wl_ePELROP1.nTotMMAlz = .Rows(wl_nRow).Cells("nTotMMAlz").Value
                wl_ePELROP1.nTotTieAlz = .Rows(wl_nRow).Cells("nTotTieAlz").Value
                wl_ePELROP1.nTotHHCaf = .Rows(wl_nRow).Cells("nTotHHAlz").Value
                wl_ePELROP1.nTotMMCaf = .Rows(wl_nRow).Cells("nTotMMAlz").Value
                wl_ePELROP1.nTotTieCaf = .Rows(wl_nRow).Cells("nTotTieAlz").Value


                wl_ePELROP1.xnId = .Rows(wl_nRow).Cells("xnID").Value
                wl_ePELROP1.xnIdPEROP = .Rows(wl_nRow).Cells("xnIDPEROP").Value
                wl_ePELROP1.xsCodDoc = .Rows(wl_nRow).Cells("xsCodDoc").Value
                wl_ePELROP1.xnNroDoc = .Rows(wl_nRow).Cells("xnNroDoc").Value
                wl_ePELROP1.xsCodSer = .Rows(wl_nRow).Cells("xsCodSer").Value
                wl_ePELROP1.xsTipMov = .Rows(wl_nRow).Cells("xsTipMov").Value
                wl_ePELROP1.xsCodDocBas = .Rows(wl_nRow).Cells("xsCodDocBas").Value
                wl_ePELROP1.xsCodSerBas = .Rows(wl_nRow).Cells("xsCodSerBas").Value
                wl_ePELROP1.xnNroDocBas = .Rows(wl_nRow).Cells("xnNroDocBas").Value
                wl_ePELROP1.xsCodItm = .Rows(wl_nRow).Cells("xsCodItm").Value
                wl_ePELROP1.xnCanItm = .Rows(wl_nRow).Cells("xnCanItm").Value
                wl_ePELROP1.xsCodOpe = .Rows(wl_nRow).Cells("xsCodOpe").Value
                wl_ePELROP1.xsNomOpe = .Rows(wl_nRow).Cells("xsNomOpe").Value
                wl_ePELROP1.xnHHIniOpe = .Rows(wl_nRow).Cells("xnHHIniOpe").Value
                wl_ePELROP1.xnMMIniOpe = .Rows(wl_nRow).Cells("xnMMIniOpe").Value
                wl_ePELROP1.xnHHFinOpe = .Rows(wl_nRow).Cells("xnMMFinOpe").Value
                wl_ePELROP1.xnMMFinOpe = .Rows(wl_nRow).Cells("xnMMFinOpe").Value
                wl_ePELROP1.xnHHCnsOpe = .Rows(wl_nRow).Cells("xnHHCnsOpe").Value
                wl_ePELROP1.xnMMCnsOpe = .Rows(wl_nRow).Cells("xnMMCnsOpe").Value
                wl_ePELROP1.xnTieCnsOpe = .Rows(wl_nRow).Cells("xnTieCnsOpe").Value
                wl_ePELROP1.xnHHCns = .Rows(wl_nRow).Cells("xnHHCns").Value
                wl_ePELROP1.xnMMCns = .Rows(wl_nRow).Cells("xnMMCns").Value
                wl_ePELROP1.xnTieCns = .Rows(wl_nRow).Cells("xnTieCns").Value
                wl_ePELROP1.xnTieReq = .Rows(wl_nRow).Cells("xnTieReq").Value
                wl_ePELROP1.xnPreUni = .Rows(wl_nRow).Cells("xnPreUni").Value
                wl_ePELROP1.xnTotLin = .Rows(wl_nRow).Cells("xnTotLin").Value
                wl_ePELROP1.xsCodCco = .Rows(wl_nRow).Cells("xsCodCco").Value
                wl_ePELROP1.xnLinBas = .Rows(wl_nRow).Cells("xnLinBas").Value
                wl_ePELROP1.xsCodPdo = .Rows(wl_nRow).Cells("xsCodPdo").Value
                wl_ePELROP1.xsCodCta = .Rows(wl_nRow).Cells("xsCodCta").Value
                wl_ePELROP1.xsCtaCosVta = .Rows(wl_nRow).Cells("xsCtaCosVta").Value
                wl_ePELROP1.xbItmBlq = .Rows(wl_nRow).Cells("xbItmBlq").Value
                wl_ePELROP1.sClsDoc = .Rows(wl_nRow).Cells("xsClsDoc").Value
                wl_ePELROP1.xnCanOpeTer = .Rows(wl_nRow).Cells("xnCanOpeTer").Value
                wl_ePELROP1.xsCodCtr = .Rows(wl_nRow).Cells("xsCodCtr").Value
                wl_ePELROP1.xnHHIniAlz = .Rows(wl_nRow).Cells("xnHHIniAlz").Value
                wl_ePELROP1.xnMMIniAlz = .Rows(wl_nRow).Cells("xnMMIniAlz").Value
                wl_ePELROP1.xnHHFinAlz = .Rows(wl_nRow).Cells("xnMMFinAlz").Value
                wl_ePELROP1.xnMMFinAlz = .Rows(wl_nRow).Cells("xnMMFinAlz").Value
                wl_ePELROP1.xnHHCnsAlz = .Rows(wl_nRow).Cells("xnHHCnsAlz").Value
                wl_ePELROP1.xnMMCnsAlz = .Rows(wl_nRow).Cells("xnMMCnsAlz").Value
                wl_ePELROP1.xnTieCnsAlz = .Rows(wl_nRow).Cells("xnTieCnsAlz").Value
                wl_ePELROP1.xnHHIniCaf = .Rows(wl_nRow).Cells("xnHHIniCaf").Value
                wl_ePELROP1.xnMMIniCaf = .Rows(wl_nRow).Cells("xnMMIniCaf").Value
                wl_ePELROP1.xnHHFinCaf = .Rows(wl_nRow).Cells("xnHHFinCaf").Value
                wl_ePELROP1.xnMMFinCaf = .Rows(wl_nRow).Cells("xnMMFinCaf").Value
                wl_ePELROP1.xnHHCnsCaf = .Rows(wl_nRow).Cells("xnHHCnsCaf").Value
                wl_ePELROP1.xnMMCnsCaf = .Rows(wl_nRow).Cells("xnMMCnsCaf").Value
                wl_ePELROP1.xnTieCnsCaf = .Rows(wl_nRow).Cells("xnTieCnsCaf").Value
            End With
            wp_ePELROP1 = wl_ePELROP1
        Catch ex As Exception
            MsgBox("Error : moo_ePELROP1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aePLROP1_DT(ByRef wp_eaPLROP1 As Object,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePLROP1(wl_nCntReg) As moe_Estructuras.ePLROP1

            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePLROP1(wl_nRow) = New moe_Estructuras.ePLROP1
                wl_ePLROP1 = New moe_Estructuras.ePLROP1
                moo_ePLROP1_DT(wl_ePLROP1,
                              wp_DT,
                              wl_nRow)
                wl_aePLROP1(wl_nRow) = wl_ePLROP1
            Next
            wp_eaPLROP1 = wl_aePLROP1
        Catch ex As Exception
            MsgBox("Error : moo_aePLROP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLROP1_DT(ByRef wp_ePLROP1 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
            With wl_ePLROP1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0) '0
                .nIdPEROP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nIdPEROP")), wp_DT.Rows(wp_nRow).Item("nIdPEROP"), 0) '0
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sTipMov = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipMov")), wp_DT.Rows(wp_nRow).Item("sTipMov"), "")
                .sCodDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .sCodSerBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .nNroDocBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nCanItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .sCodOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodOpe")), wp_DT.Rows(wp_nRow).Item("sCodOpe"), "")
                .sNomOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpe")), wp_DT.Rows(wp_nRow).Item("sNomOpe"), "") '10
                .nHHIniOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniOpe")), wp_DT.Rows(wp_nRow).Item("nHHIniOpe"), 0)
                .nMMIniOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniOpe")), wp_DT.Rows(wp_nRow).Item("nMMIniOpe"), 0)
                .nHHFinOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinOpe")), wp_DT.Rows(wp_nRow).Item("nHHFinOpe"), 0)
                .nMMFinOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinOpe")), wp_DT.Rows(wp_nRow).Item("nMMFinOpe"), 0)
                .nHHCnsOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsOpe")), wp_DT.Rows(wp_nRow).Item("nHHCnsOpe"), 0)
                .nMMCnsOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsOpe")), wp_DT.Rows(wp_nRow).Item("nMMCnsOpe"), 0)
                .nTieCnsOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsOpe")), wp_DT.Rows(wp_nRow).Item("nTieCnsOpe"), 0)
                .nHHCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCns")), wp_DT.Rows(wp_nRow).Item("nHHCns"), 0)
                .nMMCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCns")), wp_DT.Rows(wp_nRow).Item("nMMCns"), 0)
                .nTieCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .nTieReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieReq")), wp_DT.Rows(wp_nRow).Item("nTieReq"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .nTotLin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .sCodCco = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "") '20
                .nLinBas = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0)
                .sCodPdo = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .sCodCta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .sCtaCosVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .bItmBlq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .nCanOpeTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOpeTer")), wp_DT.Rows(wp_nRow).Item("nCanOpeTer"), 0)
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), "") '28
                .nHHIniAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniAlz")), wp_DT.Rows(wp_nRow).Item("nHHIniAlz"), 0)
                .nMMIniAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniAlz")), wp_DT.Rows(wp_nRow).Item("nMMIniAlz"), 0)
                .nHHFinAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinAlz")), wp_DT.Rows(wp_nRow).Item("nHHFinAlz"), 0)
                .nMMFinAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinAlz")), wp_DT.Rows(wp_nRow).Item("nMMFinAlz"), 0)
                .nHHCnsAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsAlz")), wp_DT.Rows(wp_nRow).Item("nHHCnsAlz"), 0)
                .nMMCnsAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsAlz")), wp_DT.Rows(wp_nRow).Item("nMMCnsAlz"), 0)
                .nTieCnsAlz = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsAlz")), wp_DT.Rows(wp_nRow).Item("nTieCnsAlz"), 0)
                .nHHIniCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniCaf")), wp_DT.Rows(wp_nRow).Item("nHHIniCaf"), 0)
                .nMMIniCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniCaf")), wp_DT.Rows(wp_nRow).Item("nMMIniCaf"), 0)
                .nHHFinCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinCaf")), wp_DT.Rows(wp_nRow).Item("nHHFinCaf"), 0)
                .nMMFinCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinCaf")), wp_DT.Rows(wp_nRow).Item("nMMFinCaf"), 0)
                .nHHCnsCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsCaf")), wp_DT.Rows(wp_nRow).Item("nHHCnsCaf"), 0)
                .nMMCnsCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsCaf")), wp_DT.Rows(wp_nRow).Item("nMMCnsCaf"), 0)
                .nTieCnsCaf = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsCaf")), wp_DT.Rows(wp_nRow).Item("nTieCnsCaf"), 0)
            End With
            wp_ePLROP1 = wl_ePLROP1
        Catch ex As Exception
            MsgBox("Error : moo_ePLROP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLROP1(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_eaPLROP1 As Array)
        Try

            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_eaPLROP1)
            Dim wL_eaPLROP1(wl_nCntReg) As moe_Estructuras.ePLROP1
            wL_eaPLROP1 = wp_eaPLROP1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePLROP1(wp_VlrCtrl,
                                   wp_eaPLROP1(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePLROP1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aePLROP1 As Object,
                               ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl
                .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                .Rows(wl_nRow).Cells("nId").Value = wp_aePLROP1(wl_nRow).nID
                .Rows(wl_nRow).Cells("nIdPEROP").Value = wp_aePLROP1(wl_nRow).nIdPEROP
                .Rows(wl_nRow).Cells("sCodDoc").Value = wp_aePLROP1(wl_nRow).sCodDoc
                .Rows(wl_nRow).Cells("nNroDoc").Value = wp_aePLROP1(wl_nRow).nNroDoc
                .Rows(wl_nRow).Cells("sCodSer").Value = wp_aePLROP1(wl_nRow).sCodSer
                .Rows(wl_nRow).Cells("sTipMov").Value = wp_aePLROP1(wl_nRow).sTipMov
                .Rows(wl_nRow).Cells("sCodDocBas").Value = wp_aePLROP1(wl_nRow).sCodDocBas
                .Rows(wl_nRow).Cells("sCodSerBas").Value = wp_aePLROP1(wl_nRow).sCodSerBas
                .Rows(wl_nRow).Cells("nNroDocBas").Value = wp_aePLROP1(wl_nRow).nNroDocBas
                .Rows(wl_nRow).Cells("sCodItm").Value = wp_aePLROP1(wl_nRow).sCodItm
                .Rows(wl_nRow).Cells("nCanItm").Value = wp_aePLROP1(wl_nRow).nCanItm
                .Rows(wl_nRow).Cells("sCodOpe").Value = wp_aePLROP1(wl_nRow).sCodOpe
                .Rows(wl_nRow).Cells("sNomOpe").Value = wp_aePLROP1(wl_nRow).sNomOpe
                .Rows(wl_nRow).Cells("nHHIniOpe").Value = wp_aePLROP1(wl_nRow).nHHIniOpe
                .Rows(wl_nRow).Cells("nMMIniOpe").Value = wp_aePLROP1(wl_nRow).nMMIniOpe
                .Rows(wl_nRow).Cells("nHHFinOpe").Value = wp_aePLROP1(wl_nRow).nHHFinOpe
                .Rows(wl_nRow).Cells("nMMFinOpe").Value = wp_aePLROP1(wl_nRow).nMMFinOpe
                .Rows(wl_nRow).Cells("nHHCnsOpe").Value = wp_aePLROP1(wl_nRow).nHHCnsOpe
                .Rows(wl_nRow).Cells("nMMCnsOpe").Value = wp_aePLROP1(wl_nRow).nMMCnsOpe
                .Rows(wl_nRow).Cells("nTieCnsOpe").Value = wp_aePLROP1(wl_nRow).nTieCnsOpe
                .Rows(wl_nRow).Cells("nHHCns").Value = wp_aePLROP1(wl_nRow).nHHCns
                .Rows(wl_nRow).Cells("nMMCns").Value = wp_aePLROP1(wl_nRow).nMMCns
                .Rows(wl_nRow).Cells("nTieCns").Value = wp_aePLROP1(wl_nRow).nTieCns
                .Rows(wl_nRow).Cells("nTieReq").Value = wp_aePLROP1(wl_nRow).nTieReq
                .Rows(wl_nRow).Cells("nPreUni").Value = wp_aePLROP1(wl_nRow).nPreUni
                .Rows(wl_nRow).Cells("nTotLin").Value = wp_aePLROP1(wl_nRow).nTotLin
                .Rows(wl_nRow).Cells("sCodCco").Value = wp_aePLROP1(wl_nRow).sCodCco
                .Rows(wl_nRow).Cells("nLinBas").Value = wp_aePLROP1(wl_nRow).nLinBas
                .Rows(wl_nRow).Cells("sCodPdo").Value = wp_aePLROP1(wl_nRow).sCodPdo
                .Rows(wl_nRow).Cells("sCodCta").Value = wp_aePLROP1(wl_nRow).sCodCta
                .Rows(wl_nRow).Cells("sCtaCosVta").Value = wp_aePLROP1(wl_nRow).sCtaCosVta
                .Rows(wl_nRow).Cells("bItmBlq").Value = wp_aePLROP1(wl_nRow).bItmBlq
                .Rows(wl_nRow).Cells("sClsDoc").Value = wp_aePLROP1(wl_nRow).sClsDoc
                .Rows(wl_nRow).Cells("nCanOpeTer").Value = wp_aePLROP1(wl_nRow).nCanOpeTer
                .Rows(wl_nRow).Cells("sCodCtr").Value = wp_aePLROP1(wl_nRow).sCodCtr
                .Rows(wl_nRow).Cells("nHHIniAlz").Value = wp_aePLROP1(wl_nRow).nHHIniAlz
                .Rows(wl_nRow).Cells("nMMIniAlz").Value = wp_aePLROP1(wl_nRow).nMMIniAlz
                .Rows(wl_nRow).Cells("nHHFinAlz").Value = wp_aePLROP1(wl_nRow).nHHFinAlz
                .Rows(wl_nRow).Cells("nMMFinAlz").Value = wp_aePLROP1(wl_nRow).nMMFinAlz
                .Rows(wl_nRow).Cells("nHHCnsAlz").Value = wp_aePLROP1(wl_nRow).nHHCnsAlz
                .Rows(wl_nRow).Cells("nMMCnsAlz").Value = wp_aePLROP1(wl_nRow).nMMCnsAlz
                .Rows(wl_nRow).Cells("nTieCnsAlz").Value = wp_aePLROP1(wl_nRow).nTieCnsAlz
                .Rows(wl_nRow).Cells("nHHIniCaf").Value = wp_aePLROP1(wl_nRow).nHHIniCaf
                .Rows(wl_nRow).Cells("nMMIniCaf").Value = wp_aePLROP1(wl_nRow).nMMIniCaf
                .Rows(wl_nRow).Cells("nHHFinCaf").Value = wp_aePLROP1(wl_nRow).nHHFinCaf
                .Rows(wl_nRow).Cells("nMMFinCaf").Value = wp_aePLROP1(wl_nRow).nMMFinCaf
                .Rows(wl_nRow).Cells("nHHCnsCaf").Value = wp_aePLROP1(wl_nRow).nHHCnsCaf
                .Rows(wl_nRow).Cells("nMMCnsCaf").Value = wp_aePLROP1(wl_nRow).nMMCnsCaf
                .Rows(wl_nRow).Cells("nTieCnsCaf").Value = wp_aePLROP1(wl_nRow).nTieCnsCaf
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLROP1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_nRow
            With wp_VlrCtrl
                .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                .Rows(wl_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wl_nRow).Cells("nIdPEROP").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nIdPEROP")), wp_DT.Rows(wp_nRow).Item("T0.nIdPEROP"), 0)
                .Rows(wl_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .Rows(wl_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .Rows(wl_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .Rows(wl_nRow).Cells("sTipMov").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sTipMov")), wp_DT.Rows(wp_nRow).Item("T0.sTipMov"), "")
                .Rows(wl_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDocBas")), wp_DT.Rows(wp_nRow).Item("sCodDocBas"), "")
                .Rows(wl_nRow).Cells("sCodSerBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSerBas")), wp_DT.Rows(wp_nRow).Item("sCodSerBas"), "")
                .Rows(wl_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDocBas")), wp_DT.Rows(wp_nRow).Item("nNroDocBas"), 0)
                .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wl_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanItm")), wp_DT.Rows(wp_nRow).Item("nCanItm"), 0)
                .Rows(wl_nRow).Cells("sCodOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodOpe")), wp_DT.Rows(wp_nRow).Item("sCodOpe"), "")
                .Rows(wl_nRow).Cells("sNomOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpe")), wp_DT.Rows(wp_nRow).Item("sNomOpe"), "")
                .Rows(wl_nRow).Cells("nHHIniOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniOpe")), wp_DT.Rows(wp_nRow).Item("nHHIniOpe"), 0)
                .Rows(wl_nRow).Cells("nMMIniOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniOpe")), wp_DT.Rows(wp_nRow).Item("nMMIniOpe"), 0)
                .Rows(wl_nRow).Cells("nHHFinOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinOpe")), wp_DT.Rows(wp_nRow).Item("nHHFinOpe"), 0)
                .Rows(wl_nRow).Cells("nMMFinOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinOpe")), wp_DT.Rows(wp_nRow).Item("nMMFinOpe"), 0)
                .Rows(wl_nRow).Cells("nHHCnsOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsOpe")), wp_DT.Rows(wp_nRow).Item("nHHCnsOpe"), 0)
                .Rows(wl_nRow).Cells("nMMCnsOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsOpe")), wp_DT.Rows(wp_nRow).Item("nMMCnsOpe"), 0)
                .Rows(wl_nRow).Cells("nTieCnsOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsOpe")), wp_DT.Rows(wp_nRow).Item("nTieCnsOpe"), 0)
                .Rows(wl_nRow).Cells("nHHCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCns")), wp_DT.Rows(wp_nRow).Item("nHHCns"), 0)
                .Rows(wl_nRow).Cells("nMMCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCns")), wp_DT.Rows(wp_nRow).Item("nMMCns"), 0)
                .Rows(wl_nRow).Cells("nTieCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .Rows(wl_nRow).Cells("nTieReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieReq")), wp_DT.Rows(wp_nRow).Item("nTieReq"), 0)
                .Rows(wl_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                .Rows(wl_nRow).Cells("nTotLin").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotLin")), wp_DT.Rows(wp_nRow).Item("nTotLin"), 0)
                .Rows(wl_nRow).Cells("sCodCco").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCco")), wp_DT.Rows(wp_nRow).Item("sCodCco"), "")
                .Rows(wl_nRow).Cells("nLinBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLinBas")), wp_DT.Rows(wp_nRow).Item("nLinBas"), 0) '17
                .Rows(wl_nRow).Cells("sCodPdo").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodPdo")), wp_DT.Rows(wp_nRow).Item("sCodPdo"), "")
                .Rows(wl_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCta")), wp_DT.Rows(wp_nRow).Item("sCodCta"), "")
                .Rows(wl_nRow).Cells("sCtaCosVta").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaCosVta")), wp_DT.Rows(wp_nRow).Item("sCtaCosVta"), "")
                .Rows(wl_nRow).Cells("bItmBlq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmBlq")), wp_DT.Rows(wp_nRow).Item("bItmBlq"), False)
                .Rows(wl_nRow).Cells("sClsDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sClsDoc")), wp_DT.Rows(wp_nRow).Item("T0.sClsDoc"), "")
                .Rows(wl_nRow).Cells("nCanOpeTer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOpeTer")), wp_DT.Rows(wp_nRow).Item("nCanOpeTer"), 0)
                .Rows(wl_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtr")), wp_DT.Rows(wp_nRow).Item("sCodCtr"), 0)
                .Rows(wl_nRow).Cells("nHHIniAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniAlz")), wp_DT.Rows(wp_nRow).Item("nHHIniAlz"), 0)
                .Rows(wl_nRow).Cells("nMMIniAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniAlz")), wp_DT.Rows(wp_nRow).Item("nMMIniAlz"), 0)
                .Rows(wl_nRow).Cells("nHHFinAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinAlz")), wp_DT.Rows(wp_nRow).Item("nHHFinAlz"), 0)
                .Rows(wl_nRow).Cells("nMMFinAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinAlz")), wp_DT.Rows(wp_nRow).Item("nMMFinAlz"), 0)
                .Rows(wl_nRow).Cells("nHHCnsAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsAlz")), wp_DT.Rows(wp_nRow).Item("nHHCnsAlz"), 0)
                .Rows(wl_nRow).Cells("nMMCnsAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsAlz")), wp_DT.Rows(wp_nRow).Item("nMMCnsAlz"), 0)
                .Rows(wl_nRow).Cells("nTieCnsAlz").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsAlz")), wp_DT.Rows(wp_nRow).Item("nTieCnsAlz"), 0)
                .Rows(wl_nRow).Cells("nHHIniCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHIniCaf")), wp_DT.Rows(wp_nRow).Item("nHHIniCaf"), 0)
                .Rows(wl_nRow).Cells("nMMIniCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMIniCaf")), wp_DT.Rows(wp_nRow).Item("nMMIniCaf"), 0)
                .Rows(wl_nRow).Cells("nHHFinCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHFinCaf")), wp_DT.Rows(wp_nRow).Item("nHHFinCaf"), 0)
                .Rows(wl_nRow).Cells("nMMFinCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMFinCaf")), wp_DT.Rows(wp_nRow).Item("nMMFinCaf"), 0)
                .Rows(wl_nRow).Cells("nHHCnsCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nHHCnsCaf")), wp_DT.Rows(wp_nRow).Item("nHHCnsCaf"), 0)
                .Rows(wl_nRow).Cells("nMMCnsCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nMMCnsCaf")), wp_DT.Rows(wp_nRow).Item("nMMCnsCaf"), 0)
                .Rows(wl_nRow).Cells("nTieCnsCaf").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCnsCaf")), wp_DT.Rows(wp_nRow).Item("nTieCnsCaf"), 0)
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLROP1_DGV(ByRef wp_ePLROP1 As Object,
                               ByVal wp_VlrCtrl As DataGridView,
                               ByVal wl_nRow As Integer)
        Try
            Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
            With wp_VlrCtrl
                wl_ePLROP1.nId = .Rows(wl_nRow).Cells("nID").Value
                wl_ePLROP1.nIdPEROP = .Rows(wl_nRow).Cells("nIDPEROP").Value
                wl_ePLROP1.sCodDoc = .Rows(wl_nRow).Cells("sCodDoc").Value
                wl_ePLROP1.nNroDoc = .Rows(wl_nRow).Cells("nNroDoc").Value
                wl_ePLROP1.sCodSer = .Rows(wl_nRow).Cells("sCodSer").Value
                wl_ePLROP1.sTipMov = .Rows(wl_nRow).Cells("sTipMov").Value
                wl_ePLROP1.sCodDocBas = .Rows(wl_nRow).Cells("sCodDocBas").Value
                wl_ePLROP1.sCodSerBas = .Rows(wl_nRow).Cells("sCodSerBas").Value
                wl_ePLROP1.nNroDocBas = .Rows(wl_nRow).Cells("nNroDocBas").Value
                wl_ePLROP1.sCodItm = .Rows(wl_nRow).Cells("sCodItm").Value
                wl_ePLROP1.nCanItm = .Rows(wl_nRow).Cells("nCanItm").Value
                wl_ePLROP1.sCodOpe = .Rows(wl_nRow).Cells("sCodOpe").Value
                wl_ePLROP1.sNomOpe = .Rows(wl_nRow).Cells("sNomOpe").Value
                wl_ePLROP1.nHHIniOpe = .Rows(wl_nRow).Cells("nHHIniOpe").Value
                wl_ePLROP1.nMMIniOpe = .Rows(wl_nRow).Cells("nMMIniOpe").Value
                wl_ePLROP1.nHHFinOpe = .Rows(wl_nRow).Cells("nHHFinOpe").Value
                wl_ePLROP1.nMMFinOpe = .Rows(wl_nRow).Cells("nMMFinOpe").Value
                wl_ePLROP1.nHHCnsOpe = .Rows(wl_nRow).Cells("nHHCnsOpe").Value
                wl_ePLROP1.nMMCnsOpe = .Rows(wl_nRow).Cells("nMMCnsOpe").Value
                wl_ePLROP1.nTieCnsOpe = .Rows(wl_nRow).Cells("nTieCnsOpe").Value
                wl_ePLROP1.nHHCns = .Rows(wl_nRow).Cells("nHHCns").Value
                wl_ePLROP1.nMMCns = .Rows(wl_nRow).Cells("nMMCns").Value
                wl_ePLROP1.nTieCns = .Rows(wl_nRow).Cells("nTieCns").Value
                wl_ePLROP1.nTieReq = .Rows(wl_nRow).Cells("nTieReq").Value
                wl_ePLROP1.nPreUni = .Rows(wl_nRow).Cells("nPreUni").Value
                wl_ePLROP1.nTotLin = .Rows(wl_nRow).Cells("nTotLin").Value
                wl_ePLROP1.sCodCco = .Rows(wl_nRow).Cells("sCodCco").Value
                wl_ePLROP1.nLinBas = .Rows(wl_nRow).Cells("nLinBas").Value
                wl_ePLROP1.sCodPdo = .Rows(wl_nRow).Cells("sCodPdo").Value
                wl_ePLROP1.sCodCta = .Rows(wl_nRow).Cells("sCodCta").Value
                wl_ePLROP1.sCtaCosVta = .Rows(wl_nRow).Cells("sCtaCosVta").Value
                wl_ePLROP1.bItmBlq = .Rows(wl_nRow).Cells("bItmBlq").Value
                wl_ePLROP1.sClsDoc = .Rows(wl_nRow).Cells("sClsDoc").Value
                wl_ePLROP1.nCanOpeTer = .Rows(wl_nRow).Cells("nCanOpeTer").Value
                wl_ePLROP1.sCodCtr = .Rows(wl_nRow).Cells("sCodCtr").Value
                wl_ePLROP1.nHHIniAlz = .Rows(wl_nRow).Cells("nHHIniAlz").Value
                wl_ePLROP1.nMMIniAlz = .Rows(wl_nRow).Cells("nMMIniAlz").Value
                wl_ePLROP1.nHHFinAlz = .Rows(wl_nRow).Cells("nHHFinAlz").Value
                wl_ePLROP1.nMMFinAlz = .Rows(wl_nRow).Cells("nMMFinAlz").Value
                wl_ePLROP1.nHHCnsAlz = .Rows(wl_nRow).Cells("nHHCnsAlz").Value
                wl_ePLROP1.nMMCnsAlz = .Rows(wl_nRow).Cells("nMMCnsAlz").Value
                wl_ePLROP1.nTieCnsAlz = .Rows(wl_nRow).Cells("nTieCnsAlz").Value
                wl_ePLROP1.nHHIniCaf = .Rows(wl_nRow).Cells("nHHIniCaf").Value
                wl_ePLROP1.nMMIniCaf = .Rows(wl_nRow).Cells("nMMIniCaf").Value
                wl_ePLROP1.nHHFinCaf = .Rows(wl_nRow).Cells("nHHFinCaf").Value
                wl_ePLROP1.nMMFinCaf = .Rows(wl_nRow).Cells("nMMFinCaf").Value
                wl_ePLROP1.nHHCnsCaf = .Rows(wl_nRow).Cells("nHHCnsCaf").Value
                wl_ePLROP1.nMMCnsCaf = .Rows(wl_nRow).Cells("nMMCnsCaf").Value
                wl_ePLROP1.nTieCnsCaf = .Rows(wl_nRow).Cells("nTieCnsCaf").Value
            End With
            wp_ePLROP1 = wl_ePLROP1
        Catch ex As Exception
            MsgBox("Error : moo_ePLROP1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "PEODP"
    Public Sub moo_aePEODP_DT(ByRef wp_aePEODP As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePEODP(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePEODP(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP = New moe_Estructuras.ePEODP
                moo_ePEODP_DT(wl_ePEODP,
                              wp_DT,
                              wl_nRow)
                vl_aePEODP(wl_nRow) = wl_ePEODP
            Next
            wp_aePEODP = vl_aePEODP
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_DT(ByRef wp_aPEODP As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP As New moe_Estructuras.ePEODP
            With wl_ePEODP
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sNroLot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNroLot")), wp_DT.Rows(wp_nRow).Item("sNroLot"), "")
                .sEstOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstOdp")), wp_DT.Rows(wp_nRow).Item("sEstOdp"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nCanLotStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanLotStn")), wp_DT.Rows(wp_nRow).Item("nCanLotStn"), 0)
                .sUniMedStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedStn")), wp_DT.Rows(wp_nRow).Item("sUniMedStn"), "")
                .nCanUniStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniStn")), wp_DT.Rows(wp_nRow).Item("nCanUniStn"), 0)
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .nCanOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOdp")), wp_DT.Rows(wp_nRow).Item("nCanOdp"), 0)
                .sUniMedOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedOdp")), wp_DT.Rows(wp_nRow).Item("sUniMedOdp"), "")
                .nCanUniOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniOdp")), wp_DT.Rows(wp_nRow).Item("nCanUniOdp"), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .nCanUniEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniEdp")), wp_DT.Rows(wp_nRow).Item("nCanUniEdp"), 0)
                .nTieItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieItm")), wp_DT.Rows(wp_nRow).Item("nTieItm"), 0)
                .nTotTieOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOdp")), wp_DT.Rows(wp_nRow).Item("nTotTieOdp"), 0)
                .nTotTieEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieEdp")), wp_DT.Rows(wp_nRow).Item("nTotTieEdp"), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .dFecEmi = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecEmi")), wp_DT.Rows(wp_nRow).Item("dFecEmi"), #1/1/1901#)
                .dFecIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecIni")), wp_DT.Rows(wp_nRow).Item("dFecIni"), #1/1/1901#)
                .dFecFin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecFin")), wp_DT.Rows(wp_nRow).Item("dFecFin"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sRegSan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sRegSan")), wp_DT.Rows(wp_nRow).Item("sRegSan"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")

                '   .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                '   .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)

                '  .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                ' .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                '  .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreUni")), wp_DT.Rows(wp_nRow).Item("nPreUni"), 0)
                ' .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                '  .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaInv")), wp_DT.Rows(wp_nRow).Item("sCtaInv"), "")
            End With
            wp_aPEODP = wl_ePEODP
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aePEODP As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP)
            Dim va_aePEODP(wl_nCntReg) As moe_Estructuras.ePEODP
            va_aePEODP = wp_aePEODP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP(wp_VlrCtrl,
                                   va_aePEODP(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP(ByRef wp_VlrCtrl As DataGridView,
                              ByVal wp_aePEODP As Object,
                              ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_aePEODP.nId
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_aePEODP.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_aePEODP.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_aePEODP.sCodSer
                .Rows(wp_nRow).Cells("sNroLot").Value = wp_aePEODP.sNroLot
                .Rows(wp_nRow).Cells("sEstOdp").Value = wp_aePEODP.sEstOdp
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_aePEODP.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_aePEODP.sNomItm
                .Rows(wp_nRow).Cells("nCanLotStn").Value = wp_aePEODP.nCanLotStn
                .Rows(wp_nRow).Cells("sUniMedStn").Value = wp_aePEODP.sUniMedStn
                .Rows(wp_nRow).Cells("nCanUniStn").Value = wp_aePEODP.nCanUniStn
                .Rows(wp_nRow).Cells("nCanOdp").Value = wp_aePEODP.nCanOdp
                .Rows(wp_nRow).Cells("sUniMedOdp").Value = wp_aePEODP.sUniMedOdp
                .Rows(wp_nRow).Cells("nCanUniOdp").Value = wp_aePEODP.nCanUniOdp
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_aePEODP.sUniMedInv
                .Rows(wp_nRow).Cells("nCanUniEdp").Value = wp_aePEODP.nCanUniEdp
                .Rows(wp_nRow).Cells("nTieItm").Value = wp_aePEODP.nTieItm
                .Rows(wp_nRow).Cells("nTotTieOdp").Value = wp_aePEODP.nTotTieOdp
                .Rows(wp_nRow).Cells("nTotTieEdp").Value = wp_aePEODP.nTotTieEdp
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_aePEODP.sCodAlm
                .Rows(wp_nRow).Cells("dFecEmi").Value = wp_aePEODP.dFecEmi
                .Rows(wp_nRow).Cells("dFecIni").Value = wp_aePEODP.dFecIni
                .Rows(wp_nRow).Cells("dFecFin").Value = wp_aePEODP.dFecFin
                .Rows(wp_nRow).Cells("dFecSys").Value = wp_aePEODP.dFecSys
                .Rows(wp_nRow).Cells("sClsDoc").Value = wp_aePEODP.sClsDoc
                .Rows(wp_nRow).Cells("sCodUsr").Value = wp_aePEODP.sCodUsr
                .Rows(wp_nRow).Cells("sRegSan").Value = wp_aePEODP.sRegSan
                .Rows(wp_nRow).Cells("sCmn").Value = wp_aePEODP.sCmn
                .Rows(wp_nRow).Cells("bIndCan").Value = wp_aePEODP.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wp_aePEODP.bIndCos

            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_DGV(ByRef wp_ePEODP As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePEODP As New moe_Estructuras.ePEODP
            With va_ePEODP
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sNroLot = wp_VlrCtrl.Rows(wp_nRow).Cells("sNroLot").Value
                .sEstOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("sEstOdp").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value
                .nCanLotStn = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanLotStn").Value
                .sUniMedStn = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedStn").Value
                .nCanUniStn = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniStn").Value
                .nCanOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanOdp").Value
                .sUniMedOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedOdp").Value
                .nCanUniOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniOdp").Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value
                .nCanUniEdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniEdp").Value
                .nTieItm = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieItm").Value
                .nTotTieOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieOdp").Value
                .nTotTieEdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieEdp").Value
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value
                .dFecEmi = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecEmi").Value
                .dFecIni = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecIni").Value
                .dFecFin = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecFin").Value
                .dFecSys = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecSys").Value
                .sClsDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sClsDoc").Value
                .sCodUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value
                .sRegSan = wp_VlrCtrl.Rows(wp_nRow).Cells("sRegSan").Value
                .sCmn = wp_VlrCtrl.Rows(wp_nRow).Cells("sCmn").Value
            End With
            wp_ePEODP = va_ePEODP
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_ePEODP(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_ePEODP As Object,
                                    ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP As New moe_Estructuras.ePEODP
            wl_ePEODP = wp_ePEODP
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDocBas").Value = wl_ePEODP.sCodDoc
                .Rows(wp_nRow).Cells("nNroDocBas").Value = wl_ePEODP.nNroDoc
                '.Rows(wp_nRow).Cells("sCodSer").Value = wl_ePEODP.sCodSer
                '.Rows(wp_nRow).Cells("sNroLot").Value = wl_ePEODP.sNroLot
                .Rows(wp_nRow).Cells("sCodItm").Value = wl_ePEODP.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wl_ePEODP.sNomItm
                .Rows(wp_nRow).Cells("sCodAlm").Value = wl_ePEODP.sCodAlm
                .Rows(wp_nRow).Cells("nCanItm").Value = wl_ePEODP.nCanUniOdp
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wl_ePEODP.sUniMedInv
                '.Rows(wp_nRow).Cells("sUniMedOdp").Value = wl_ePEODP.sUniMedOdp
                '.Rows(wp_nRow).Cells("nCanUniEdp").Value = wl_ePEODP.nCanUniEdp
                '.Rows(wp_nRow).Cells("nPreUni").Value = wl_ePEODP.nPreUni
                '.Rows(wp_nRow).Cells("nSdoAlm").Value = wl_ePEODP.nSdoAlm
                '.Rows(wp_nRow).Cells("sCtaInv").Value = wl_ePEODP.sCtaInv
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_ePEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PLODP1"
    Public Sub moo_aePLODP1_DT(ByRef wp_aePLODP1 As Array,
                             ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLODP1(wl_nCntReg) As moe_Estructuras.ePLODP1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLODP1(wl_nRow) = New moe_Estructuras.ePLODP1
                wl_ePLODP1 = New moe_Estructuras.ePLODP1
                moo_ePLODP1_DT(wl_ePLODP1,
                              wp_DT,
                              wl_nRow)
                vl_aePLODP1(wl_nRow) = wl_ePLODP1
            Next
            wp_aePLODP1 = vl_aePLODP1
        Catch ex As Exception
            MsgBox("Error : moo_aePLODP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP1_DT(ByRef wp_aPLODP1 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1
            With wl_ePLODP1
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .sNomCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .nCanCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .nCanReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanReq")), wp_DT.Rows(wp_nRow).Item("nCanReq"), 0)
                .nCanCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCns")), wp_DT.Rows(wp_nRow).Item("nCanCns"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .nVlrTotReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReq")), wp_DT.Rows(wp_nRow).Item("nVlrTotReq"), 0)
                .nVlrTotCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCns")), wp_DT.Rows(wp_nRow).Item("nVlrTotCns"), 0)
                .sCodAlmCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .sCodCmtAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)

                .bIndLibODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndLibODP")), wp_DT.Rows(wp_nRow).Item("bIndLibODP"), False)
                .nSdoInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .nSdoAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .sCtaInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaInv")), wp_DT.Rows(wp_nRow).Item("sCtaInv"), "")
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
                .sUniMedInvIEDMI = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv"), "")
                .nCanResODP = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODP")), wp_DT.Rows(wp_nRow).Item("nCanResODP"), 0)
                .nCanResODPAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODPAlm")), wp_DT.Rows(wp_nRow).Item("nCanResODPAlm"), 0)
                .nSdoFinDis = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDis")), wp_DT.Rows(wp_nRow).Item("nSdoFinDis"), 0)
                .nSdoFinDisAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm")), wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm"), 0)
                .nCanPedODC = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanPedODC")), wp_DT.Rows(wp_nRow).Item("nCanPedODC"), 0)
                .nSdoFinPry = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinPry")), wp_DT.Rows(wp_nRow).Item("nSdoFinPry"), 0)

            End With
            wp_aPLODP1 = wl_ePLODP1
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLODP1(ByRef wp_VlrCtrl As DataGridView,
                               ByVal wp_aePLODP1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP1)
            Dim va_aePLODP1(wl_nCntReg) As moe_Estructuras.ePLODP1
            va_aePLODP1 = wp_aePLODP1
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aePLODP1(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP1(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP1(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP1(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP1(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodCmt").Value = va_aePLODP1(wl_nRow).sCodCmt
                    .Rows(wl_nRow).Cells("sNomCmt").Value = va_aePLODP1(wl_nRow).sNomCmt
                    .Rows(wl_nRow).Cells("sUniMedInv").Value = va_aePLODP1(wl_nRow).sUniMedInv
                    .Rows(wl_nRow).Cells("nCanCmt").Value = va_aePLODP1(wl_nRow).nCanCmt
                    .Rows(wl_nRow).Cells("nCanReq").Value = va_aePLODP1(wl_nRow).nCanReq
                    .Rows(wl_nRow).Cells("nCanCns").Value = va_aePLODP1(wl_nRow).nCanCns
                    .Rows(wl_nRow).Cells("nPreUni").Value = va_aePLODP1(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells("nVlrTotReq").Value = va_aePLODP1(wl_nRow).nVlrTotReq
                    .Rows(wl_nRow).Cells("nVlrTotCns").Value = va_aePLODP1(wl_nRow).nVlrTotCns
                    .Rows(wl_nRow).Cells("sCodAlmCns").Value = va_aePLODP1(wl_nRow).sCodAlmCns
                    .Rows(wl_nRow).Cells("sCodCmtAlt").Value = va_aePLODP1(wl_nRow).sCodCmtAlt

                    .Rows(wl_nRow).Cells("nSdoInv").Value = va_aePLODP1(wl_nRow).nSdoInv
                    .Rows(wl_nRow).Cells("nSdoAlm").Value = va_aePLODP1(wl_nRow).nSdoAlm
                    .Rows(wl_nRow).Cells("sCtaInv").Value = va_aePLODP1(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells("bIndCan").Value = va_aePLODP1(wl_nRow).bIndCan
                    .Rows(wl_nRow).Cells("bIndCos").Value = va_aePLODP1(wl_nRow).bIndCos
                    .Rows(wl_nRow).Cells("bIndLIbODP").Value = va_aePLODP1(wl_nRow).bIndLibODP
                    .Rows(wl_nRow).Cells("sUniMedInvIEDMI").Value = va_aePLODP1(wl_nRow).sUniMedInvIEDMI

                    .Rows(wl_nRow).Cells("nCanResODP").Value = va_aePLODP1(wl_nRow).nCanResODP
                    .Rows(wl_nRow).Cells("nCanResODPAlm").Value = va_aePLODP1(wl_nRow).nCanResODPAlm
                    .Rows(wl_nRow).Cells("nSdoFinDis").Value = va_aePLODP1(wl_nRow).nSdoFinDis
                    .Rows(wl_nRow).Cells("nSdoFinDisAlm").Value = va_aePLODP1(wl_nRow).nSdoFinDisAlm
                    .Rows(wl_nRow).Cells("nCanPedODC").Value = va_aePLODP1(wl_nRow).nCanPedODC
                    .Rows(wl_nRow).Cells("nSdoFinPry").Value = va_aePLODP1(wl_nRow).nSdoFinPry

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVMov1_aePLODP1(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePLODP1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP1)
            '  wl_nCntReg = wp_aePLODP1.Length
            Dim va_aePLODP1(wl_nCntReg) As moe_Estructuras.ePLODP1
            va_aePLODP1 = wp_aePLODP1
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg
                ' - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aePLODP1(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP1(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP1(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP1(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP1(wl_nRow).sCodCmt
                    .Rows(wl_nRow).Cells("sNomItm").Value = va_aePLODP1(wl_nRow).sNomCmt
                    .Rows(wl_nRow).Cells("sCodAlm").Value = va_aePLODP1(wl_nRow).sCodAlmCns
                    .Rows(wl_nRow).Cells("nCanItm").Value = va_aePLODP1(wl_nRow).nCanReq

                    .Rows(wl_nRow).Cells("sUniMedInv").Value = va_aePLODP1(wl_nRow).sUniMedInv
                    .Rows(wl_nRow).Cells("nCanItm").Value = va_aePLODP1(wl_nRow).nCanReq
                    .Rows(wl_nRow).Cells("nPreUni").Value = va_aePLODP1(wl_nRow).nPreUni
                    If va_aePLODP1(wl_nRow).sUniMedInvIEDMI = "gr" Then
                        .Rows(wl_nRow).Cells("sUniMedInv").Value = va_aePLODP1(wl_nRow).sUniMedInvIEDMI
                        .Rows(wl_nRow).Cells("nCanItm").Value = va_aePLODP1(wl_nRow).nCanReq * 1000
                        .Rows(wl_nRow).Cells("nPreUni").Value = va_aePLODP1(wl_nRow).nPreUni / 1000
                    End If

                    .Rows(wl_nRow).Cells("nSdoAlm").Value = va_aePLODP1(wl_nRow).nSdoAlm
                    .Rows(wl_nRow).Cells("sCodCta").Value = va_aePLODP1(wl_nRow).sCtaInv
                    .Rows(wl_nRow).Cells("bIndCan").Value = va_aePLODP1(wl_nRow).bIndCan
                    .Rows(wl_nRow).Cells("bIndCos").Value = va_aePLODP1(wl_nRow).bIndCos
                    .Rows(wl_nRow).Cells("bIndLibODP").Value = va_aePLODP1(wl_nRow).bIndLibODP

                    .Rows(wl_nRow).Cells("nCanResODP").Value = va_aePLODP1(wl_nRow).nCanResODP
                    .Rows(wl_nRow).Cells("nCanResODPAlm").Value = va_aePLODP1(wl_nRow).nCanResODPAlm
                    .Rows(wl_nRow).Cells("nSdoFinDis").Value = va_aePLODP1(wl_nRow).nSdoFinDis
                    .Rows(wl_nRow).Cells("nSdoFinDisAlm").Value = va_aePLODP1(wl_nRow).nSdoFinDisAlm
                    .Rows(wl_nRow).Cells("nCanPedODC").Value = va_aePLODP1(wl_nRow).nCanPedODC
                    .Rows(wl_nRow).Cells("nSdoFinPry").Value = va_aePLODP1(wl_nRow).nSdoFinPry

                    '     .Rows(wl_nRow).Cells("sUniMedInvIEDMI").Value = va_aePLODP1(wl_nRow).sUniMedInvIEDMI
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVMov1_DTePLODP1(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DT.Rows.Count

            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("T0.nId")), wp_DT.Rows(wl_nRow).Item("T0.nId"), 0)
                    .Rows(wl_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodDoc")), wp_DT.Rows(wl_nRow).Item("sCodDoc"), "")
                    .Rows(wl_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nNroDoc")), wp_DT.Rows(wl_nRow).Item("nNroDoc"), 0)
                    .Rows(wl_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodSer")), wp_DT.Rows(wl_nRow).Item("sCodSer"), "")
                    .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodCmt")), wp_DT.Rows(wl_nRow).Item("sCodCmt"), "")
                    .Rows(wl_nRow).Cells("sNomItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sNomItm")), wp_DT.Rows(wl_nRow).Item("sNomItm"), "")
                    .Rows(wl_nRow).Cells("sCodAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodAlmCns")), wp_DT.Rows(wl_nRow).Item("sCodAlmCns"), "")
                    .Rows(wl_nRow).Cells("nCanItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nCanReq")), wp_DT.Rows(wl_nRow).Item("nCanReq"), 0)
                    .Rows(wl_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wl_nRow).Item("T0.sUniMedInv"), "")
                    .Rows(wl_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("T2.nPreUni")), wp_DT.Rows(wl_nRow).Item("T2.nPreUni"), 0)
                    .Rows(wl_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nSdoAlm")), wp_DT.Rows(wl_nRow).Item("nSdoAlm"), 0)
                    .Rows(wl_nRow).Cells("sCodCta").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCtaInv")), wp_DT.Rows(wl_nRow).Item("sCtaInv"), "")
                    .Rows(wl_nRow).Cells("bIndCan").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("bIndCan")), wp_DT.Rows(wl_nRow).Item("bIndCan"), False)
                    .Rows(wl_nRow).Cells("bIndCos").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("bIndCos")), wp_DT.Rows(wl_nRow).Item("bIndCos"), False)
                    .Rows(wl_nRow).Cells("sUniMedInvIEDMI").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wl_nRow).Item("T1.sUniMedInv"), "")

                    .Rows(wl_nRow).Cells("bIndCanRes").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("bIndCanRes")), wp_DT.Rows(wl_nRow).Item("bIndCanRes"), False)
                    .Rows(wl_nRow).Cells("bIndCanPry").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("bIndCanPry")), wp_DT.Rows(wl_nRow).Item("bIndCanPry"), False)
                    .Rows(wl_nRow).Cells("nCanResODP").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nCanResODP")), wp_DT.Rows(wl_nRow).Item("nCanResODP"), 0)
                    .Rows(wl_nRow).Cells("nCanResODPAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nCanResODPAlm")), wp_DT.Rows(wl_nRow).Item("nCanResODPAlm"), 0)
                    .Rows(wl_nRow).Cells("nSdoFinDis").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nSdoFinDis")), wp_DT.Rows(wl_nRow).Item("nSdoFinDis"), 0)
                    .Rows(wl_nRow).Cells("nSdoFinDisAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nSdoFinDisAlm")), wp_DT.Rows(wl_nRow).Item("nSdoFinDisAlm"), 0)
                    .Rows(wl_nRow).Cells("nCanPedODC").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nCanPedODC")), wp_DT.Rows(wl_nRow).Item("nCanPedODC"), 0)
                    .Rows(wl_nRow).Cells("nSdoFinPry").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nSdoFinPry")), wp_DT.Rows(wl_nRow).Item("nSdoFinPry"), 0)


                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGVMov1_DTePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP1_DGV(ByRef wp_ePLODP1 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePLODP1 As New moe_Estructuras.ePLODP1
            With va_ePLODP1
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .sNomCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCmt").Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value
                .nCanCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanCmt").Value
                .nCanReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanReq").Value
                .nCanCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanCns").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .nVlrTotReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReq").Value
                .nVlrTotCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotCns").Value
                .sCodAlmCns = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlmCns").Value
                ' .sCodCmtAlt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmtAlt").Value

                .nSdoInv = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoInv").Value
                .nSdoAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoAlm").Value
                .sCtaInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sCtaInv").Value
                .bIndCan = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCan").Value
                .bIndCos = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCos").Value
                .bIndLibODP = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndLibODP").Value
                .sUniMedInvIEDMI = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInvIEDMI").Value

                .nCanResODP = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODP").Value
                .nSdoFinDis = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDis").Value
                .nCanPedODC = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanPedODC").Value
                .nSdoFinPry = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinPry").Value
                .nCanResODPAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanResODPAlm").Value
                .nSdoFinDisAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinDisAlm").Value

            End With
            wp_ePLODP1 = va_ePLODP1
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_ePLODP1(ByRef wp_ePLODP1 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try

            Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1
            wl_ePLODP1 = wp_ePLODP1
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDoc").Value = wl_ePLODP1.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wl_ePLODP1.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wl_ePLODP1.sCodSer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_ePLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLODP1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), 0)
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .Rows(wp_nRow).Cells("sNomCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomitm"), "")
                .Rows(wp_nRow).Cells("nCanCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCmt")), wp_DT.Rows(wp_nRow).Item("nCanCmt"), 0)
                .Rows(wp_nRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T0.sUniMedInv"), "")
                .Rows(wp_nRow).Cells("nCanReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanReq")), wp_DT.Rows(wp_nRow).Item("nCanReq"), 0)
                .Rows(wp_nRow).Cells("nCanCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanCns")), wp_DT.Rows(wp_nRow).Item("nCanCns"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .Rows(wp_nRow).Cells("nVlrTotReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReq")), wp_DT.Rows(wp_nRow).Item("nVlrTotReq"), 0)
                .Rows(wp_nRow).Cells("nVlrTotCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCns")), wp_DT.Rows(wp_nRow).Item("nVlrTotCns"), 0)
                .Rows(wp_nRow).Cells("sCodAlmCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlmCns")), wp_DT.Rows(wp_nRow).Item("sCodAlmCns"), "")
                .Rows(wp_nRow).Cells("sCodCmtAlt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmtAlt")), wp_DT.Rows(wp_nRow).Item("sCodCmtAlt"), "")
                .Rows(wp_nRow).Cells("bIndCan").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .Rows(wp_nRow).Cells("bIndCos").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
                .Rows(wp_nRow).Cells("bIndLibOdp").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndLibOdp")), wp_DT.Rows(wp_nRow).Item("bIndLibOdp"), False)
                .Rows(wp_nRow).Cells("nSdoInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoInv")), wp_DT.Rows(wp_nRow).Item("nSdoInv"), 0)
                .Rows(wp_nRow).Cells("nSdoAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoAlm")), wp_DT.Rows(wp_nRow).Item("nSdoAlm"), 0)
                .Rows(wp_nRow).Cells("sUniMedInvIEDMI").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv")), wp_DT.Rows(wp_nRow).Item("T1.sUniMedInv"), "")

                .Rows(wp_nRow).Cells("bIndCanRes").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCanRes")), wp_DT.Rows(wp_nRow).Item("bIndCanRes"), False)
                .Rows(wp_nRow).Cells("bIndCanPry").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCanPry")), wp_DT.Rows(wp_nRow).Item("bIndCanPry"), False)

                .Rows(wp_nRow).Cells("nCanResODP").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODP")), wp_DT.Rows(wp_nRow).Item("NCanResODP"), 0)
                .Rows(wp_nRow).Cells("nSdoFinDis").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDis")), wp_DT.Rows(wp_nRow).Item("nSdoFinDis"), 0)
                .Rows(wp_nRow).Cells("nCanPedODC").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanPedODC")), wp_DT.Rows(wp_nRow).Item("nCanPedODC"), 0)
                .Rows(wp_nRow).Cells("nSdoFinPry").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinPry")), wp_DT.Rows(wp_nRow).Item("nSdoFinPry"), 0)
                .Rows(wp_nRow).Cells("nCanResODPAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanResODPAlm")), wp_DT.Rows(wp_nRow).Item("nCanResODPAlm"), 0)
                .Rows(wp_nRow).Cells("nSdoFinDisAlm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm")), wp_DT.Rows(wp_nRow).Item("nSdoFinDisAlm"), 0)

                '.Rows(wp_nRow).Cells("sCtaInv").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCtaInv")), wp_DT.Rows(wp_nRow).Item("sCtaInv"), "")
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLODP1")
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region
#Region "PLODP2"
    Public Sub moo_aePLODP2_DT(ByRef wp_aePLODP2 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLODP2(wl_nCntReg) As moe_Estructuras.ePLODP2
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLODP2(wl_nRow) = New moe_Estructuras.ePLODP2
                wl_ePLODP2 = New moe_Estructuras.ePLODP2
                moo_ePLODP2_DT(wl_ePLODP2,
                              wp_DT,
                              wl_nRow)
                vl_aePLODP2(wl_nRow) = wl_ePLODP2
            Next
            wp_aePLODP2 = vl_aePLODP2
        Catch ex As Exception
            MsgBox("Error : moo_aePLODP2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP2_DT(ByRef wp_aPLODP2 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
            With wl_ePLODP2
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nPosOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPosOpe")), wp_DT.Rows(wp_nRow).Item("nPosOpe"), 0)
                .sCodOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodOpe")), wp_DT.Rows(wp_nRow).Item("T0.sCodOpe"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .nTieOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTieOpe")), wp_DT.Rows(wp_nRow).Item("T0.nTieOpe"), 0)
                .nTieReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieReq")), wp_DT.Rows(wp_nRow).Item("nTieReq"), 0)
                .nTieCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .nPreUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .nVlrTotReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReq")), wp_DT.Rows(wp_nRow).Item("nVlrTotReq"), 0)
                .nVlrTotCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCns")), wp_DT.Rows(wp_nRow).Item("nVlrTotCns"), 0)
                .nPorOpeReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpeReq")), wp_DT.Rows(wp_nRow).Item("nPorOpeReq"), 0)
                .nPorOpeCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpeCns")), wp_DT.Rows(wp_nRow).Item("nPorOpeCns"), 0)
                .nVrcPorOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcPorOpe")), wp_DT.Rows(wp_nRow).Item("nVrcPorOpe"), 0)
                .sNomOpe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpe")), wp_DT.Rows(wp_nRow).Item("sNomOpe"), "")
                .sNomCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCtr")), wp_DT.Rows(wp_nRow).Item("sNomCtr"), "")
            End With
            wp_aPLODP2 = wl_ePLODP2
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLODP2(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLODP2 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP2)
            Dim va_aePLODP2(wl_nCntReg) As moe_Estructuras.ePLODP2
            va_aePLODP2 = wp_aePLODP2
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aePLODP2(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP2(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP2(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP2(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP2(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("nPosOpe").Value = va_aePLODP2(wl_nRow).nPosOpe
                    .Rows(wl_nRow).Cells("sCodOpe").Value = va_aePLODP2(wl_nRow).sCodOpe
                    .Rows(wl_nRow).Cells("sNomOpe").Value = va_aePLODP2(wl_nRow).sNomOpe
                    .Rows(wl_nRow).Cells("sCodCtr").Value = va_aePLODP2(wl_nRow).sCodCtr
                    .Rows(wl_nRow).Cells("nTieOpe").Value = va_aePLODP2(wl_nRow).nTieOpe
                    .Rows(wl_nRow).Cells("nTieReq").Value = va_aePLODP2(wl_nRow).nTieReq
                    .Rows(wl_nRow).Cells("nTieCns").Value = va_aePLODP2(wl_nRow).nTieCns
                    .Rows(wl_nRow).Cells("nPreUni").Value = va_aePLODP2(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells("nVlrTotReq").Value = va_aePLODP2(wl_nRow).nVlrTotReq
                    .Rows(wl_nRow).Cells("nVlrTotCns").Value = va_aePLODP2(wl_nRow).nVlrTotCns
                    .Rows(wl_nRow).Cells("nPorOpeReq").Value = va_aePLODP2(wl_nRow).nPorOpeReq
                    .Rows(wl_nRow).Cells("nPorOpeCns").Value = va_aePLODP2(wl_nRow).nPorOpeCns
                    .Rows(wl_nRow).Cells("nVrcPorOpe").Value = va_aePLODP2(wl_nRow).nVrcPorOpe
                    ' .Rows(wl_nRow).Cells("sNomCtr").Value = va_aePLODP2(wl_nRow).sNomCtr
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLODP2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVMov2_aePLODP2(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePLODP2 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP2)
            Dim va_aePLODP2(wl_nCntReg) As moe_Estructuras.ePLODP2
            va_aePLODP2 = wp_aePLODP2
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aePLODP2(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP2(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP2(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP2(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP2(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("nPosOpe").Value = va_aePLODP2(wl_nRow).nPosOpe
                    .Rows(wl_nRow).Cells("sCodOpe").Value = va_aePLODP2(wl_nRow).sCodOpe
                    .Rows(wl_nRow).Cells("sCodCtr").Value = va_aePLODP2(wl_nRow).sCodCtr
                    .Rows(wl_nRow).Cells("nTieOpe").Value = va_aePLODP2(wl_nRow).nTieOpe
                    .Rows(wl_nRow).Cells("nTieReq").Value = va_aePLODP2(wl_nRow).nTieReq
                    .Rows(wl_nRow).Cells("nTieCns").Value = va_aePLODP2(wl_nRow).nTieCns
                    .Rows(wl_nRow).Cells("nPreUni").Value = va_aePLODP2(wl_nRow).nPreUni
                    .Rows(wl_nRow).Cells("nVlrTotReq").Value = va_aePLODP2(wl_nRow).nVlrTotReq
                    .Rows(wl_nRow).Cells("nVlrTotCns").Value = va_aePLODP2(wl_nRow).nVlrTotCns
                    .Rows(wl_nRow).Cells("nPorOpeReq").Value = va_aePLODP2(wl_nRow).nPorOpeReq
                    .Rows(wl_nRow).Cells("nPorOpeCns").Value = va_aePLODP2(wl_nRow).nPorOpeCns
                    .Rows(wl_nRow).Cells("nVrcPorOpe").Value = va_aePLODP2(wl_nRow).nVrcPorOpe
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGVMov2_aePLODP2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP2_DGV(ByRef wp_ePLODP2 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePLODP2 As New moe_Estructuras.ePLODP2
            With va_ePLODP2
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .nPosOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nPosOpe").Value
                .sCodOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodOpe").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .nTieOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieOpe").Value
                .nTieReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieReq").Value
                .nTieCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieCns").Value
                .nPreUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreUni").Value
                .nVlrTotReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReq").Value
                .nVlrTotCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotCns").Value
                .nPorOpeReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorOpeReq").Value
                .nPorOpeCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorOpeCns").Value
                .nVrcPorOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcPorOpe").Value
                .sNomOpe = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomOpe").Value
            End With
            wp_ePLODP2 = va_ePLODP2
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP2_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV2_ePLODP2(ByRef wp_ePLODP2 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try
            Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
            wl_ePLODP2 = wp_ePLODP2
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDoc").Value = wl_ePLODP2.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wl_ePLODP2.nNroDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV2_ePLODP2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLODP2(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("nPosOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPosOpe")), wp_DT.Rows(wp_nRow).Item("nPosOpe"), 0)
                .Rows(wp_nRow).Cells("sCodOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodOpe")), wp_DT.Rows(wp_nRow).Item("T0.sCodOpe"), "")
                .Rows(wp_nRow).Cells("sNomOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomOpe")), wp_DT.Rows(wp_nRow).Item("sNomOpe"), "")
                .Rows(wp_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .Rows(wp_nRow).Cells("nTieOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTieOpe")), wp_DT.Rows(wp_nRow).Item("T0.nTieOpe"), 0)
                .Rows(wp_nRow).Cells("nTieReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieReq")), wp_DT.Rows(wp_nRow).Item("nTieReq"), 0)
                .Rows(wp_nRow).Cells("nTieCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieCns")), wp_DT.Rows(wp_nRow).Item("nTieCns"), 0)
                .Rows(wp_nRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nPreUni")), wp_DT.Rows(wp_nRow).Item("T0.nPreUni"), 0)
                .Rows(wp_nRow).Cells("nVlrTotReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReq")), wp_DT.Rows(wp_nRow).Item("nVlrTotReq"), 0)
                .Rows(wp_nRow).Cells("nVlrTotCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCns")), wp_DT.Rows(wp_nRow).Item("nVlrTotCns"), 0)
                .Rows(wp_nRow).Cells("nPorOpeReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpeReq")), wp_DT.Rows(wp_nRow).Item("nPorOpeReq"), 0)
                .Rows(wp_nRow).Cells("nPorOpeCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorOpeCns")), wp_DT.Rows(wp_nRow).Item("nPorOpeCns"), 0)
                .Rows(wp_nRow).Cells("nVrcPorOpe").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcPorOpe")), wp_DT.Rows(wp_nRow).Item("nVrcPorOpe"), 0)
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLODP2")
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region
#Region "PLODP3"
    Public Sub moo_aePLODP3_DT(ByRef wp_aePLODP3 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLODP3 As New moe_Estructuras.ePLODP3
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLODP3(wl_nCntReg) As moe_Estructuras.ePLODP3
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLODP3(wl_nRow) = New moe_Estructuras.ePLODP3
                wl_ePLODP3 = New moe_Estructuras.ePLODP3
                moo_ePLODP3_DT(wl_ePLODP3,
                              wp_DT,
                              wl_nRow)
                vl_aePLODP3(wl_nRow) = wl_ePLODP3
            Next
            wp_aePLODP3 = vl_aePLODP3
        Catch ex As Exception
            MsgBox("Error : moo_aePLODP3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP3_DT(ByRef wp_aPLODP3 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLODP3 As New moe_Estructuras.ePLODP3
            With wl_ePLODP3
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sCodCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCIF")), wp_DT.Rows(wp_nRow).Item("T0.sCodCIF"), "")
                .sCodCtr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .nVlrCIFRea = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea"), "")
                .nVlrReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrReq")), wp_DT.Rows(wp_nRow).Item("nVlrReq"), 0)
                .nVlrCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrCns")), wp_DT.Rows(wp_nRow).Item("nVlrCns"), 0)
                .nTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTasCIF")), wp_DT.Rows(wp_nRow).Item("T0.nTasCIF"), 0)
                .nVlrTotReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReq")), wp_DT.Rows(wp_nRow).Item("nVlrTotReq"), 0)
                .nVlrTotCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCns")), wp_DT.Rows(wp_nRow).Item("nVlrTotCns"), 0)
                .sNomCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCIF")), wp_DT.Rows(wp_nRow).Item("sNomCIF"), "")
            End With
            wp_aPLODP3 = wl_ePLODP3
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLODP3(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLODP3 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP3)
            Dim va_aePLODP3(wl_nCntReg) As moe_Estructuras.ePLODP3
            va_aePLODP3 = wp_aePLODP3
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aePLODP3(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP3(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP3(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP3(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP3(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodCIF").Value = va_aePLODP3(wl_nRow).sCodCIF
                    .Rows(wl_nRow).Cells("sCodCtr").Value = va_aePLODP3(wl_nRow).sCodCtr
                    .Rows(wl_nRow).Cells("nVlrCIFRea").Value = va_aePLODP3(wl_nRow).nVlrCIFRea
                    .Rows(wl_nRow).Cells("nVlrReq").Value = va_aePLODP3(wl_nRow).nVlrReq
                    .Rows(wl_nRow).Cells("nVlrCns").Value = va_aePLODP3(wl_nRow).nVlrCns
                    .Rows(wl_nRow).Cells("nTasCIF").Value = va_aePLODP3(wl_nRow).nTasCIF
                    .Rows(wl_nRow).Cells("nVlrTotReq").Value = va_aePLODP3(wl_nRow).nVlrTotReq
                    .Rows(wl_nRow).Cells("nVlrTotCns").Value = va_aePLODP3(wl_nRow).nVlrTotCns
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVMov3_aePLODP3(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePLODP3 As Array)

        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP3)
            Dim va_aePLODP3(wl_nCntReg) As moe_Estructuras.ePLODP3
            va_aePLODP3 = wp_aePLODP3
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aePLODP3(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP3(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP3(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP3(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP3(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodCIF").Value = va_aePLODP3(wl_nRow).sCodCIF
                    .Rows(wl_nRow).Cells("sCodCtr").Value = va_aePLODP3(wl_nRow).sCodCtr
                    .Rows(wl_nRow).Cells("nVlrCIFRea").Value = va_aePLODP3(wl_nRow).nVlrCIFRea
                    .Rows(wl_nRow).Cells("nVlrReq").Value = va_aePLODP3(wl_nRow).nVlrReq
                    .Rows(wl_nRow).Cells("nVlrCns").Value = va_aePLODP3(wl_nRow).nVlrCns
                    .Rows(wl_nRow).Cells("nTasCIF").Value = va_aePLODP3(wl_nRow).nTasCIF
                    .Rows(wl_nRow).Cells("nVlrTotReq").Value = va_aePLODP3(wl_nRow).nVlrTotReq
                    .Rows(wl_nRow).Cells("nVlrTotCns").Value = va_aePLODP3(wl_nRow).nVlrTotCns
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGVMov3_aePLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP3_DGV(ByRef wp_ePLODP3 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePLODP3 As New moe_Estructuras.ePLODP3
            With va_ePLODP3
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCIF").Value
                .sCodCtr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtr").Value
                .nVlrCIFRea = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrCIFRea").Value
                .nVlrReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrReq").Value
                .nVlrCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrCns").Value
                .nTasCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nTasCIF").Value
                .nVlrTotReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReq").Value
                .nVlrTotCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotCns").Value
            End With
            wp_ePLODP3 = va_ePLODP3
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP3_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVMov3_DTePLODP3(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = wp_DT.Rows.Count

            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("T0.nId")), wp_DT.Rows(wl_nRow).Item("T0.nId"), 0)
                    .Rows(wl_nRow).Cells("sCodDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodDoc")), wp_DT.Rows(wl_nRow).Item("sCodDoc"), "")
                    .Rows(wl_nRow).Cells("nNroDocBas").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("nNroDoc")), wp_DT.Rows(wl_nRow).Item("nNroDoc"), 0)
                    .Rows(wl_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodSer")), wp_DT.Rows(wl_nRow).Item("sCodSer"), "")
                    .Rows(wl_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wl_nRow).Item("sCodCmt")), wp_DT.Rows(wl_nRow).Item("sCodCmt"), "")

                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGVMov3_DTePLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV3_ePLODP3(ByRef wp_ePLODP3 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try
            Dim wl_ePLODP3 As New moe_Estructuras.ePLODP3
            wl_ePLODP3 = wp_ePLODP3
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDoc").Value = wl_ePLODP3.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wl_ePLODP3.nNroDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV3_ePLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLODP3(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)

        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCIF")), wp_DT.Rows(wp_nRow).Item("T0.sCodCIF"), "")
                .Rows(wp_nRow).Cells("sNomCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCIF")), wp_DT.Rows(wp_nRow).Item("sNomCIF"), "")
                .Rows(wp_nRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodCtr")), wp_DT.Rows(wp_nRow).Item("T0.sCodCtr"), "")
                .Rows(wp_nRow).Cells("nVlrCIFRea").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea")), wp_DT.Rows(wp_nRow).Item("T0.nVlrCIFRea"), 0)
                .Rows(wp_nRow).Cells("nVlrReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrReq")), wp_DT.Rows(wp_nRow).Item("nVlrReq"), 0)
                .Rows(wp_nRow).Cells("nVlrCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrCns")), wp_DT.Rows(wp_nRow).Item("nVlrCns"), 0)
                .Rows(wp_nRow).Cells("nTasCIF").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nTasCIF")), wp_DT.Rows(wp_nRow).Item("T0.nTasCIF"), 0)
                .Rows(wp_nRow).Cells("nVlrTotReq").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReq")), wp_DT.Rows(wp_nRow).Item("nVlrTotReq"), 0)
                .Rows(wp_nRow).Cells("nVlrTotCns").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCns")), wp_DT.Rows(wp_nRow).Item("nVlrTotCns"), 0)
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLODP3")
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region
#Region "PLODP4"
    Public Sub moo_aePLODP4_DT(ByRef wp_aePLODP4 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLODP4 As New moe_Estructuras.ePLODP4
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePLODP4(wl_nCntReg) As moe_Estructuras.ePLODP4
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePLODP4(wl_nRow) = New moe_Estructuras.ePLODP4
                wl_ePLODP4 = New moe_Estructuras.ePLODP4
                moo_ePLODP4_DT(wl_ePLODP4,
                              wp_DT,
                              wl_nRow)
                wl_aePLODP4(wl_nRow) = wl_ePLODP4
            Next
            wp_aePLODP4 = wl_aePLODP4
        Catch ex As Exception
            MsgBox("Error : moo_aePLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP4_DT(ByRef wp_aPLODP4 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLODP4 As New moe_Estructuras.ePLODP4
            With wl_ePLODP4
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .nCanOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanOdp")), wp_DT.Rows(wp_nRow).Item("nCanOdp"), 0)
                .nCanUniEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniEdp")), wp_DT.Rows(wp_nRow).Item("nCanUniEdp"), 0)
                .nVrcCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCan")), wp_DT.Rows(wp_nRow).Item("nVrcCan"), 0)
                .nVlrTotReqMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqMPD")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqMPD"), 0)
                .nVlrTotCnsMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMPD")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMPD"), 0)
                .nVrcTotMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotMPD")), wp_DT.Rows(wp_nRow).Item("nVrcTotMPD"), 0)
                .nTotTieReqMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieReqMOD")), wp_DT.Rows(wp_nRow).Item("nTotTieReqMOD"), 0)
                .nTotTieCnsMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCnsMOD")), wp_DT.Rows(wp_nRow).Item("nTotTieCnsMOD"), 0)
                .nVrcTieMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTieMOD")), wp_DT.Rows(wp_nRow).Item("nVrcTieMOD"), 0)
                .nVlrTotReqMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqMOD")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqMOD"), 0)
                .nVlrTotCnsMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMOD")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMOD"), 0)
                .nVrcTotMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotMOD")), wp_DT.Rows(wp_nRow).Item("nVrcTotMOD"), 0)
                .nTotTasReqCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTasReqCIF")), wp_DT.Rows(wp_nRow).Item("nTotTasReqCIF"), 0)
                .nTotTasCnsCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTasCnsCIF")), wp_DT.Rows(wp_nRow).Item("nTotTasCnsCIF"), 0)
                .nVrcTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTasCIF")), wp_DT.Rows(wp_nRow).Item("nVrcTasCIF"), 0)
                .nVlrTotReqCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqCIF")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqCIF"), 0)
                .nVlrTotCnsCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsCIF")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsCIF"), 0)
                .nVrcTotCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotCIF")), wp_DT.Rows(wp_nRow).Item("nVrcTotCIF"), 0)
                .nCosTotReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotReq")), wp_DT.Rows(wp_nRow).Item("nCosTotReq"), 0)
                .nCosTotCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotCns")), wp_DT.Rows(wp_nRow).Item("nCosTotCns"), 0)
                .nVrcCosTot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCosTot")), wp_DT.Rows(wp_nRow).Item("nVrcCosTot"), 0)
                .nTotUniReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotUniReq")), wp_DT.Rows(wp_nRow).Item("nTotUniReq"), 0)
                .nTotUniCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotUniCns")), wp_DT.Rows(wp_nRow).Item("nTotUniCns"), 0)
                .nVrcUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcUni")), wp_DT.Rows(wp_nRow).Item("nVrcUni"), 0)
                .nCosUniReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosUniReq")), wp_DT.Rows(wp_nRow).Item("nCosUniReq"), 0)
                .nCosUniCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosUniCns")), wp_DT.Rows(wp_nRow).Item("nCosUniCns"), 0)
                .nVrcCosUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCosUni")), wp_DT.Rows(wp_nRow).Item("nVrcCosUni"), 0)
                .nPreVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreVta")), wp_DT.Rows(wp_nRow).Item("nPreVta"), 0)
                .nPorGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorGto")), wp_DT.Rows(wp_nRow).Item("nPorGto"), 0)
                .nPorIto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIto")), wp_DT.Rows(wp_nRow).Item("nPorIto"), 0)
            End With
            wp_aPLODP4 = wl_ePLODP4
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeItmPLODP4_DT(ByRef wp_aeItmPLODP4 As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eItmPLODP4 As New moe_Estructuras.ePLODP4
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeItmPLODP4(wl_nCntReg) As moe_Estructuras.ePLODP4
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeItmPLODP4(wl_nRow) = New moe_Estructuras.ePLODP4
                wl_eItmPLODP4 = New moe_Estructuras.ePLODP4
                moo_eItmPLODP4_DT(wl_eItmPLODP4,
                              wp_DT,
                              wl_nRow)
                wl_aeItmPLODP4(wl_nRow) = wl_eItmPLODP4
            Next
            wp_aeItmPLODP4 = wl_aeItmPLODP4
        Catch ex As Exception
            MsgBox("Error : moo_aeItmPLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eItmPLODP4_DT(ByRef wp_aItmPLODP4 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_eItmPLODP4 As New moe_Estructuras.ePLODP4
            With wl_eItmPLODP4
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .nCanOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nCanOdp")), wp_DT.Rows(wp_nRow).Item("T0.nCanOdp"), 0)
                .nCanUniEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nCanUniEdp")), wp_DT.Rows(wp_nRow).Item("T0.nCanUniEdp"), 0)
                .nVrcCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCan")), wp_DT.Rows(wp_nRow).Item("nVrcCan"), 0)
                .nVlrTotReqMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqMPD")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqMPD"), 0)
                .nVlrTotCnsMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMPD")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMPD"), 0)
                .nVrcTotMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotMPD")), wp_DT.Rows(wp_nRow).Item("nVrcTotMPD"), 0)
                .nTotTieReqMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieReqMOD")), wp_DT.Rows(wp_nRow).Item("nTotTieReqMOD"), 0)
                .nTotTieCnsMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCnsMOD")), wp_DT.Rows(wp_nRow).Item("nTotTieCnsMOD"), 0)
                .nVrcTieMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTieMOD")), wp_DT.Rows(wp_nRow).Item("nVrcTieMOD"), 0)
                .nVlrTotReqMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqMOD")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqMOD"), 0)
                .nVlrTotCnsMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMOD")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMOD"), 0)
                .nVrcTotMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotMOD")), wp_DT.Rows(wp_nRow).Item("nVrcTotMOD"), 0)
                .nTotTasReqCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTasReqCIF")), wp_DT.Rows(wp_nRow).Item("nTotTasReqCIF"), 0)
                .nTotTasCnsCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTasCnsCIF")), wp_DT.Rows(wp_nRow).Item("nTotTasCnsCIF"), 0)
                .nVrcTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTasCIF")), wp_DT.Rows(wp_nRow).Item("nVrcTasCIF"), 0)
                .nVlrTotReqCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqCIF")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqCIF"), 0)
                .nVlrTotCnsCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsCIF")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsCIF"), 0)
                .nVrcTotCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotCIF")), wp_DT.Rows(wp_nRow).Item("nVrcTotCIF"), 0)
                .nCosTotReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotReq")), wp_DT.Rows(wp_nRow).Item("nCosTotReq"), 0)
                .nCosTotCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotCns")), wp_DT.Rows(wp_nRow).Item("nCosTotCns"), 0)
                .nVrcCosTot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCosTot")), wp_DT.Rows(wp_nRow).Item("nVrcCosTot"), 0)
                .nTotUniReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotUniReq")), wp_DT.Rows(wp_nRow).Item("nTotUniReq"), 0)
                .nTotUniCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotUniCns")), wp_DT.Rows(wp_nRow).Item("nTotUniCns"), 0)
                .nVrcUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcUni")), wp_DT.Rows(wp_nRow).Item("nVrcUni"), 0)
                .nCosUniReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosUniReq")), wp_DT.Rows(wp_nRow).Item("nCosUniReq"), 0)
                .nCosUniCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosUniCns")), wp_DT.Rows(wp_nRow).Item("nCosUniCns"), 0)
                .nVrcCosUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCosUni")), wp_DT.Rows(wp_nRow).Item("nVrcCosUni"), 0)
                .nPreVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreVta")), wp_DT.Rows(wp_nRow).Item("nPreVta"), 0)
                .nPorGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorGto")), wp_DT.Rows(wp_nRow).Item("nPorGto"), 0)
                .nPorIto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIto")), wp_DT.Rows(wp_nRow).Item("nPorIto"), 0)
            End With
            wp_aItmPLODP4 = wl_eItmPLODP4
        Catch ex As Exception
            MsgBox("Error : moo_eItmPLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PLODP5"
    Public Sub moo_aePLODP5_DT(ByRef wp_aePLODP5 As Array,
                               ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePLODP5 As New moe_Estructuras.ePLODP5
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePLODP5(wl_nCntReg) As moe_Estructuras.ePLODP5
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePLODP5(wl_nRow) = New moe_Estructuras.ePLODP5
                wl_ePLODP5 = New moe_Estructuras.ePLODP5
                moo_ePLODP5_DT(wl_ePLODP5,
                              wp_DT,
                              wl_nRow)
                vl_aePLODP5(wl_nRow) = wl_ePLODP5
            Next
            wp_aePLODP5 = vl_aePLODP5
        Catch ex As Exception
            MsgBox("Error : moo_aePLODP5_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP5_DT(ByRef wp_aPLODP5 As Object,
                              ByVal wp_DT As DataTable,
                              ByVal wp_nRow As Integer)
        Try
            Dim wl_ePLODP5 As New moe_Estructuras.ePLODP5
            With wl_ePLODP5
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sCodAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodAna"), "")
                .sNomAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAna")), wp_DT.Rows(wp_nRow).Item("sNomAna"), "")
                .sDesAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDesAna")), wp_DT.Rows(wp_nRow).Item("sDesAna"), "")
                .sCodTipAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna"), "")
                '            .sNomtipAna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomtipAna")), wp_DT.Rows(wp_nRow).Item("sNomtipAna"), "")
            End With
            wp_aPLODP5 = wl_ePLODP5
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP5_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePLODP5(ByRef wp_VlrCtrl As DataGridView,
                                ByVal wp_aePLODP5 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP5)
            Dim va_aePLODP5(wl_nCntReg) As moe_Estructuras.ePLODP5
            va_aePLODP5 = wp_aePLODP5
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nID").Value = va_aePLODP5(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP5(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP5(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP5(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP5(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodAna").Value = va_aePLODP5(wl_nRow).sCodAna
                    .Rows(wl_nRow).Cells("sNomAna").Value = va_aePLODP5(wl_nRow).sNomAna
                    .Rows(wl_nRow).Cells("sDesAna").Value = va_aePLODP5(wl_nRow).sDesAna
                    .Rows(wl_nRow).Cells("sCodTipAna").Value = va_aePLODP5(wl_nRow).sCodTipAna
                    .Rows(wl_nRow).Cells("sNomTipAna").Value = va_aePLODP5(wl_nRow).sNomtipAna
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePLODP5")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVMov5_aePLODP5(ByRef wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePLODP5 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePLODP5)
            Dim va_aePLODP5(wl_nCntReg) As moe_Estructuras.ePLODP5
            va_aePLODP5 = wp_aePLODP5
            ' wp_VlrCtrl.Rows.Clear()

            For wl_nRow = 0 To wl_nCntReg - 1
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aePLODP5(wl_nRow).nId
                    .Rows(wl_nRow).Cells("sCodDoc").Value = va_aePLODP5(wl_nRow).sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = va_aePLODP5(wl_nRow).nNroDoc
                    .Rows(wl_nRow).Cells("sCodSer").Value = va_aePLODP5(wl_nRow).sCodSer
                    .Rows(wl_nRow).Cells("sCodItm").Value = va_aePLODP5(wl_nRow).sCodItm
                    .Rows(wl_nRow).Cells("sCodAna").Value = va_aePLODP5(wl_nRow).sCodAna
                    .Rows(wl_nRow).Cells("sNomAna").Value = va_aePLODP5(wl_nRow).sNomAna
                    .Rows(wl_nRow).Cells("sDesAna").Value = va_aePLODP5(wl_nRow).sDesAna
                    .Rows(wl_nRow).Cells("sCodTipAna").Value = va_aePLODP5(wl_nRow).sCodTipAna
                    .Rows(wl_nRow).Cells("sNomTipAna").Value = va_aePLODP5(wl_nRow).sNomtipAna
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGVMov5_aePLODP5")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePLODP5_DGV(ByRef wp_ePLODP5 As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_ePLODP5 As New moe_Estructuras.ePLODP5
            With va_ePLODP5
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .sCodAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAna").Value
                .sNomAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomana").Value
                .sDesAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sDesAna").Value
                .sCodTipAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTipAna").Value
                .sNomtipAna = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTipAna").Value
            End With
            wp_ePLODP5 = va_ePLODP5
        Catch ex As Exception
            MsgBox("Error : moo_ePLODP5_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV5_ePLODP5(ByRef wp_ePLODP5 As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try
            Dim wl_ePLODP5 As New moe_Estructuras.ePLODP5
            wl_ePLODP5 = wp_ePLODP5
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDoc").Value = wl_ePLODP5.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wl_ePLODP5.nNroDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV5_ePLODP5")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_DTePLODP5(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)

        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .Rows(wp_nRow).Cells("sCodDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")
                .Rows(wp_nRow).Cells("nNroDoc").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)
                .Rows(wp_nRow).Cells("sCodSer").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")
                .Rows(wp_nRow).Cells("sCodItm").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .Rows(wp_nRow).Cells("sCodCmt").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .Rows(wp_nRow).Cells("sCodAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodAna"), "")
                .Rows(wp_nRow).Cells("sNomAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAna")), wp_DT.Rows(wp_nRow).Item("sNomAna"), "")
                .Rows(wp_nRow).Cells("sDesAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDesAna")), wp_DT.Rows(wp_nRow).Item("sDesAna"), "")
                .Rows(wp_nRow).Cells("sCodTipAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna")), wp_DT.Rows(wp_nRow).Item("T0.sCodTipAna"), "")
                '    .Rows(wp_nRow).Cells("sNomTipAna").Value = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTipAna")), wp_DT.Rows(wp_nRow).Item("sNomTipAna"), "")
            End With

        Catch ex As Exception
            MsgBox("Error : moo_DGV_DTePLODP5")
            MsgBox(ex.Message)
        End Try


    End Sub


#End Region

#Region "PEODP_PLODP4"
    Public Sub moo_aePEODP_PLODP4_DT(ByRef wp_aePEODP_PLODP4 As Array,
                                     ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_PLODP4 As New moe_Estructuras.ePEODP_PLODP4
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim vl_aePEODP_PLODP4(wl_nCntReg) As moe_Estructuras.ePEODP_PLODP4
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                vl_aePEODP_PLODP4(wl_nRow) = New moe_Estructuras.ePEODP_PLODP4
                wl_ePEODP_PLODP4 = New moe_Estructuras.ePEODP_PLODP4
                moo_ePEODP_PLODP4_DT(wl_ePEODP_PLODP4,
                                     wp_DT,
                                     wl_nRow)
                vl_aePEODP_PLODP4(wl_nRow) = wl_ePEODP_PLODP4
            Next
            wp_aePEODP_PLODP4 = vl_aePEODP_PLODP4
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_PLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_PLODP4_DT(ByRef wp_aPEODP_PLODP4 As Object,
                                     ByVal wp_DT As DataTable,
                                     ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_PLODP4 As New moe_Estructuras.ePEODP_PLODP4
            With wl_ePEODP_PLODP4
                .nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nId")), wp_DT.Rows(wp_nRow).Item("T0.nId"), 0)
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T0.sCodDoc"), "")
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T0.nNroDoc"), 0)
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodSer")), wp_DT.Rows(wp_nRow).Item("T0.sCodSer"), "")
                .sNroLot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNroLot")), wp_DT.Rows(wp_nRow).Item("sNroLot"), "")
                .sEstOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstOdp")), wp_DT.Rows(wp_nRow).Item("sEstOdp"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T1.sCodItm"), "")
                .nCanLotStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanLotStn")), wp_DT.Rows(wp_nRow).Item("nCanLotStn"), 0)
                .sUniMedStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedStn")), wp_DT.Rows(wp_nRow).Item("sUniMedStn"), "")
                .nCanUniStn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCanUniStn")), wp_DT.Rows(wp_nRow).Item("nCanUniStn"), 0)
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .nCanOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nCanOdp")), wp_DT.Rows(wp_nRow).Item("T0.nCanOdp"), 0)
                .sUniMedOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedOdp")), wp_DT.Rows(wp_nRow).Item("sUniMedOdp"), "")
                .nCanUniOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nCanUniOdp")), wp_DT.Rows(wp_nRow).Item("T0.nCanUniOdp"), 0)
                .sUniMedInv = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sUniMedInv")), wp_DT.Rows(wp_nRow).Item("sUniMedInv"), "")
                .nCanUniEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.nCanUniEdp")), wp_DT.Rows(wp_nRow).Item("T0.nCanUniEdp"), 0)
                .nTieItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTieItm")), wp_DT.Rows(wp_nRow).Item("nTieItm"), 0)
                .nTotTieOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieOdp")), wp_DT.Rows(wp_nRow).Item("nTotTieOdp"), 0)
                .nTotTieEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieEdp")), wp_DT.Rows(wp_nRow).Item("nTotTieEdp"), 0)
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .dFecEmi = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecEmi")), wp_DT.Rows(wp_nRow).Item("dFecEmi"), #1/1/1901#)
                .dFecIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecIni")), wp_DT.Rows(wp_nRow).Item("dFecIni"), #1/1/1901#)
                .dFecFin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecFin")), wp_DT.Rows(wp_nRow).Item("dFecFin"), #1/1/1901#)
                .dFecSys = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecSys")), wp_DT.Rows(wp_nRow).Item("dFecSys"), #1/1/1901#)
                .sClsDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sClsDoc")), wp_DT.Rows(wp_nRow).Item("sClsDoc"), "")
                .sCodUsr = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodUsr")), wp_DT.Rows(wp_nRow).Item("sCodUsr"), "")
                .sRegSan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sRegSan")), wp_DT.Rows(wp_nRow).Item("sRegSan"), "")
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")

                .T1nId = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nId")), wp_DT.Rows(wp_nRow).Item("T1.nId"), 0)
                .T1sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodDoc")), wp_DT.Rows(wp_nRow).Item("T1.sCodDoc"), "")
                .T1nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nNroDoc")), wp_DT.Rows(wp_nRow).Item("T1.nNroDoc"), 0)
                .T1sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodSer")), wp_DT.Rows(wp_nRow).Item("T1.sCodSer"), "")
                .T1sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sCodItm")), wp_DT.Rows(wp_nRow).Item("T1.sCodItm"), "")
                .T1nCanOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nCanOdp")), wp_DT.Rows(wp_nRow).Item("T1.nCanOdp"), 0)
                .nCanUniOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nCanUniOdp")), wp_DT.Rows(wp_nRow).Item("T1.nCanUniOdp"), 0)
                .nCanUniEdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.nCanUniEdp")), wp_DT.Rows(wp_nRow).Item("T1.nCanUniEdp"), 0)
                .nVrcCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCan")), wp_DT.Rows(wp_nRow).Item("nVrcCan"), 0)
                .nVlrTotReqMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqMPD")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqMPD"), 0)
                .nVlrTotCnsMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMPD")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMPD"), 0)
                .nVrcTotMPD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotMPD")), wp_DT.Rows(wp_nRow).Item("nVrcTotMPD"), 0)
                .nTotTieReqMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieReqMOD")), wp_DT.Rows(wp_nRow).Item("nTotTieReqMOD"), 0)
                .nTotTieCnsMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTieCnsMOD")), wp_DT.Rows(wp_nRow).Item("nTotTieCnsMOD"), 0)
                .nVrcTieMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTieMOD")), wp_DT.Rows(wp_nRow).Item("nVrcTieMOD"), 0)
                .nVlrTotReqMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqMOD")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqMOD"), 0)
                .nVlrTotCnsMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMOD")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsMOD"), 0)
                .nVrcTotMOD = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotMOD")), wp_DT.Rows(wp_nRow).Item("nVrcTotMOD"), 0)
                .nTotTasReqCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTasReqCIF")), wp_DT.Rows(wp_nRow).Item("nTotTasReqCIF"), 0)
                .nTotTasCnsCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotTasCnsCIF")), wp_DT.Rows(wp_nRow).Item("nTotTasCnsCIF"), 0)
                .nVrcTasCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTasCIF")), wp_DT.Rows(wp_nRow).Item("nVrcTasCIF"), 0)
                .nVlrTotReqCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotReqCIF")), wp_DT.Rows(wp_nRow).Item("nVlrTotReqCIF"), 0)
                .nVlrTotCnsCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVlrTotCnsCIF")), wp_DT.Rows(wp_nRow).Item("nVlrTotCnsCIF"), 0)
                .nVrcTotCIF = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcTotCIF")), wp_DT.Rows(wp_nRow).Item("nVrcTotCIF"), 0)
                .nCosTotReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotReq")), wp_DT.Rows(wp_nRow).Item("nCosTotReq"), 0)
                .nCosTotCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosTotCns")), wp_DT.Rows(wp_nRow).Item("nCosTotCns"), 0)
                .nVrcCosTot = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCosTot")), wp_DT.Rows(wp_nRow).Item("nVrcCosTot"), 0)
                .nTotUniReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotUniReq")), wp_DT.Rows(wp_nRow).Item("nTotUniReq"), 0)
                .nTotUniCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nTotUniCns")), wp_DT.Rows(wp_nRow).Item("nTotUniCns"), 0)
                .nVrcUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcUni")), wp_DT.Rows(wp_nRow).Item("nVrcUni"), 0)
                .nCosUniReq = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosUniReq")), wp_DT.Rows(wp_nRow).Item("nCosUniReq"), 0)
                .nCosUniCns = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nCosUniCns")), wp_DT.Rows(wp_nRow).Item("nCosUniCns"), 0)
                .nVrcCosUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nVrcCosUni")), wp_DT.Rows(wp_nRow).Item("nVrcCosUni"), 0)
                .nPreVta = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPreVta")), wp_DT.Rows(wp_nRow).Item("nPreVta"), 0)
                .nPorGto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorGto")), wp_DT.Rows(wp_nRow).Item("nPorGto"), 0)
                .nPorIto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorIto")), wp_DT.Rows(wp_nRow).Item("nPorIto"), 0)
            End With
            wp_aPEODP_PLODP4 = wl_ePEODP_PLODP4
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_PLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_PLODP4(ByVal wp_VlrCtrl As DataGridView,
                                      ByVal wp_aePEODP_PLODP4 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_PLODP4)
            Dim va_aePEODP_PLODP4(wl_nCntReg) As moe_Estructuras.ePEODP_PLODP4
            va_aePEODP_PLODP4 = wp_aePEODP_PLODP4
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_PLODP4(wp_VlrCtrl,
                                   va_aePEODP_PLODP4(wl_nRow),
                                   wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_PLODP4")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_PLODP4(ByRef wp_VlrCtrl As DataGridView,
                                     ByVal wp_aePEODP_PLODP4 As Object,
                                     ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_aePEODP_PLODP4.nId
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_aePEODP_PLODP4.sCodDoc
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_aePEODP_PLODP4.nNroDoc
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_aePEODP_PLODP4.sCodSer
                .Rows(wp_nRow).Cells("sNroLot").Value = wp_aePEODP_PLODP4.sNroLot
                .Rows(wp_nRow).Cells("sEstOdp").Value = wp_aePEODP_PLODP4.sEstOdp
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_aePEODP_PLODP4.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_aePEODP_PLODP4.sNomItm
                .Rows(wp_nRow).Cells("nCanLotStn").Value = wp_aePEODP_PLODP4.nCanLotStn
                .Rows(wp_nRow).Cells("sUniMedStn").Value = wp_aePEODP_PLODP4.sUniMedStn
                .Rows(wp_nRow).Cells("nCanUniStn").Value = wp_aePEODP_PLODP4.nCanUniStn
                .Rows(wp_nRow).Cells("nCanOdp").Value = wp_aePEODP_PLODP4.nCanOdp
                .Rows(wp_nRow).Cells("sUniMedOdp").Value = wp_aePEODP_PLODP4.sUniMedOdp
                .Rows(wp_nRow).Cells("nCanUniOdp").Value = wp_aePEODP_PLODP4.nCanUniOdp
                .Rows(wp_nRow).Cells("sUniMedInv").Value = wp_aePEODP_PLODP4.sUniMedInv
                .Rows(wp_nRow).Cells("nCanUniEdp").Value = wp_aePEODP_PLODP4.nCanUniEdp
                .Rows(wp_nRow).Cells("nTieItm").Value = wp_aePEODP_PLODP4.nTieItm
                .Rows(wp_nRow).Cells("nTotTieOdp").Value = wp_aePEODP_PLODP4.nTotTieOdp
                .Rows(wp_nRow).Cells("nTotTieEdp").Value = wp_aePEODP_PLODP4.nTotTieEdp
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_aePEODP_PLODP4.sCodAlm
                .Rows(wp_nRow).Cells("dFecEmi").Value = wp_aePEODP_PLODP4.dFecEmi
                .Rows(wp_nRow).Cells("dFecIni").Value = wp_aePEODP_PLODP4.dFecIni
                .Rows(wp_nRow).Cells("dFecFin").Value = wp_aePEODP_PLODP4.dFecFin
                .Rows(wp_nRow).Cells("dFecSys").Value = wp_aePEODP_PLODP4.dFecSys
                .Rows(wp_nRow).Cells("sClsDoc").Value = wp_aePEODP_PLODP4.sClsDoc
                .Rows(wp_nRow).Cells("sCodUsr").Value = wp_aePEODP_PLODP4.sCodUsr
                .Rows(wp_nRow).Cells("sRegSan").Value = wp_aePEODP_PLODP4.sRegSan
                .Rows(wp_nRow).Cells("sCmn").Value = wp_aePEODP_PLODP4.sCmn
                '     .Rows(wp_nRow).Cells("bIndCan").Value = wp_aePEODP_PLODP4.bIndCan
                '    .Rows(wp_nRow).Cells("bIndCos").Value = wp_aePEODP_PLODP4.bIndCos

                .Rows(wp_nRow).Cells("T1nId").Value = wp_aePEODP_PLODP4.T1nId
                .Rows(wp_nRow).Cells("T1sCodDoc").Value = wp_aePEODP_PLODP4.T1sCodDoc
                .Rows(wp_nRow).Cells("T1nNroDoc").Value = wp_aePEODP_PLODP4.T1nNroDoc
                .Rows(wp_nRow).Cells("T1sCodSer").Value = wp_aePEODP_PLODP4.T1sCodSer
                .Rows(wp_nRow).Cells("T1sCodItm").Value = wp_aePEODP_PLODP4.T1sCodItm
                .Rows(wp_nRow).Cells("T1nCanOdp").Value = wp_aePEODP_PLODP4.T1nCanOdp
                .Rows(wp_nRow).Cells("T1nCanUniOdp").Value = wp_aePEODP_PLODP4.T1nCanUniOdp
                .Rows(wp_nRow).Cells("T1nCanUniEdp").Value = wp_aePEODP_PLODP4.T1nCanUniEdp

                .Rows(wp_nRow).Cells("nVrcCan").Value = wp_aePEODP_PLODP4.nVrcCan
                .Rows(wp_nRow).Cells("nVlrTotReqMPD").Value = wp_aePEODP_PLODP4.nVlrTotReqMPD
                .Rows(wp_nRow).Cells("nVlrTotCnsMPD").Value = wp_aePEODP_PLODP4.nVlrTotCnsMPD
                .Rows(wp_nRow).Cells("nVrcTotMPD").Value = wp_aePEODP_PLODP4.nVrcTotMPD
                .Rows(wp_nRow).Cells("nTotTieReqMOD").Value = wp_aePEODP_PLODP4.nTotTieReqMOD
                .Rows(wp_nRow).Cells("nTotTieCnsMOD").Value = wp_aePEODP_PLODP4.nTotTieCnsMOD
                .Rows(wp_nRow).Cells("nVrcTieMOD").Value = wp_aePEODP_PLODP4.nVrcTieMOD
                .Rows(wp_nRow).Cells("nVlrTotReqMOD").Value = wp_aePEODP_PLODP4.nVlrTotReqMOD
                .Rows(wp_nRow).Cells("nVlrTotCnsMOD").Value = wp_aePEODP_PLODP4.nVlrTotCnsMOD
                .Rows(wp_nRow).Cells("nVrcTotMOD").Value = wp_aePEODP_PLODP4.nVrcTotMOD
                .Rows(wp_nRow).Cells("nTotTasReqCIF").Value = wp_aePEODP_PLODP4.nTotTasReqCIF
                .Rows(wp_nRow).Cells("nTotTasCnsCIF").Value = wp_aePEODP_PLODP4.nTotTasCnsCIF
                .Rows(wp_nRow).Cells("nVrcTasCIF").Value = wp_aePEODP_PLODP4.nVrcTasCIF
                .Rows(wp_nRow).Cells("nVlrTotReqCIF").Value = wp_aePEODP_PLODP4.nVlrTotReqCIF
                .Rows(wp_nRow).Cells("nVlrTotCnsCIF").Value = wp_aePEODP_PLODP4.nVlrTotCnsCIF
                .Rows(wp_nRow).Cells("nVrcTotCIF").Value = wp_aePEODP_PLODP4.nVrcTotCIF
                .Rows(wp_nRow).Cells("nCosTotReq").Value = wp_aePEODP_PLODP4.nCosTotReq
                .Rows(wp_nRow).Cells("nCosTotCns").Value = wp_aePEODP_PLODP4.nCosTotCns
                .Rows(wp_nRow).Cells("nVrcCosTot").Value = wp_aePEODP_PLODP4.nVrcCosTot
                .Rows(wp_nRow).Cells("nTotUniReq").Value = wp_aePEODP_PLODP4.nTotUniReq
                .Rows(wp_nRow).Cells("nTotUniCns").Value = wp_aePEODP_PLODP4.nTotUniCns
                .Rows(wp_nRow).Cells("nVrcUni").Value = wp_aePEODP_PLODP4.nVrcUni
                .Rows(wp_nRow).Cells("nCosUniReq").Value = wp_aePEODP_PLODP4.nCosUniReq
                .Rows(wp_nRow).Cells("nCosUniCns").Value = wp_aePEODP_PLODP4.nCosUniCns
                .Rows(wp_nRow).Cells("nVrcCosUni").Value = wp_aePEODP_PLODP4.nVrcCosUni
                .Rows(wp_nRow).Cells("nPreVta").Value = wp_aePEODP_PLODP4.nPreVta
                .Rows(wp_nRow).Cells("nPorGto").Value = wp_aePEODP_PLODP4.nPorGto
                .Rows(wp_nRow).Cells("nPorIto").Value = wp_aePEODP_PLODP4.nPorIto




            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_PLODP4")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_PLODP4_DGV(ByRef wp_ePEODP_PLODP4 As Object,
                                     ByVal wp_VlrCtrl As DataGridView,
                                     ByRef wp_nRow As Integer)
        Try
            Dim va_ePEODP_PLODP4 As New moe_Estructuras.ePEODP_PLODP4
            With va_ePEODP_PLODP4
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
                .sNroLot = wp_VlrCtrl.Rows(wp_nRow).Cells("sNroLot").Value
                .sEstOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("sEstOdp").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value
                .nCanLotStn = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanLotStn").Value
                .sUniMedStn = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedStn").Value
                .nCanUniStn = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniStn").Value
                .nCanOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanOdp").Value
                .sUniMedOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedOdp").Value
                .nCanUniOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniOdp").Value
                .sUniMedInv = wp_VlrCtrl.Rows(wp_nRow).Cells("sUniMedInv").Value
                .nCanUniEdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nCanUniEdp").Value
                .nTieItm = wp_VlrCtrl.Rows(wp_nRow).Cells("nTieItm").Value
                .nTotTieOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieOdp").Value
                .nTotTieEdp = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieEdp").Value
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value
                .dFecEmi = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecEmi").Value
                .dFecIni = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecIni").Value
                .dFecFin = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecFin").Value
                .dFecSys = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecSys").Value
                .sClsDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sClsDoc").Value
                .sCodUsr = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodUsr").Value
                .sRegSan = wp_VlrCtrl.Rows(wp_nRow).Cells("sRegSan").Value
                .sCmn = wp_VlrCtrl.Rows(wp_nRow).Cells("sCmn").Value
                .T1nId = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.nId").Value
                .T1sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.sCodDoc").Value
                .T1nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.nNroDoc").Value
                .T1sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.sCodSer").Value
                .T1sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.sCodItm").Value
                .T1nCanOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.nCanOdp").Value
                .T1nCanUniOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.nCanUniOdp").Value
                .T1nCanUniEdp = wp_VlrCtrl.Rows(wp_nRow).Cells("T1.nCanUniEdp").Value

                .nVrcCan = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcCan").Value
                .nVlrTotReqMPD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReqMPD").Value
                .nVlrTotReqMPD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReqMPD").Value
                .nVlrTotCnsMPD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotCnsMPD").Value
                .nVrcTotMPD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcTotMPD").Value
                .nTotTieReqMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieReqMOD").Value
                .nTotTieCnsMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTieCnsMOD").Value
                .nVrcTieMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcTieMOD").Value
                .nVlrTotReqMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReqMOD").Value
                .nVlrTotCnsMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotCnsMOD").Value
                .nVrcTotMOD = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcTotMOD").Value
                .nTotTasReqCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTasReqCIF").Value
                .nTotTasCnsCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotTasCnsCIF").Value
                .nVrcTasCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcTasCIF").Value
                .nVlrTotReqCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotReqCIF").Value
                .nVlrTotCnsCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nVlrTotCnsCIF").Value
                .nVrcTotCIF = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcTotCIF").Value
                .nCosTotReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosTotReq").Value
                .nCosTotCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosTotCns").Value
                .nVrcCosTot = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcCosTot").Value
                .nTotUniReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotUniReq").Value
                .nTotUniCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nTotUniCns").Value
                .nCosUniReq = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosUniReq").Value
                .nCosUniCns = wp_VlrCtrl.Rows(wp_nRow).Cells("nCosUniCns").Value
                .nVrcCosUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nVrcCosUni").Value
                .nPreVta = wp_VlrCtrl.Rows(wp_nRow).Cells("nPreVta").Value
                .nPorGto = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorGto").Value
                .nPorIto = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorIto").Value





            End With
            wp_ePEODP_PLODP4 = va_ePEODP_PLODP4
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_PLODP4_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
   
#End Region

#Region "PEODP_QCDoc"
    Public Sub moo_aePEODP_QCDoc_DT(ByRef wp_aePEODP_QCDoc As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QCDoc As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QCDoc(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QCDoc(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QCDoc = New moe_Estructuras.ePEODP
                moo_ePEODP_QCDoc_DT(wl_ePEODP_QCDoc,
                                   wp_DT,
                                   wl_nRow)
                wl_aePEODP_QCDoc(wl_nRow) = wl_ePEODP_QCDoc
            Next
            wp_aePEODP_QCDoc = wl_aePEODP_QCDoc
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QCDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QCDoc_DT(ByRef wp_aPEODP_QCDoc As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QCDoc As New moe_Estructuras.ePEODP

            With wl_ePEODP_QCDoc
                .sCodDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodDoc")), wp_DT.Rows(wp_nRow).Item("sCodDoc"), "")

            End With
            wp_aPEODP_QCDoc = wl_ePEODP_QCDoc

        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QCDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QCDoc(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePEODP_QCDoc As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QCDoc)
            Dim wl_aePEODP_QCDoc(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QCDoc = wp_aePEODP_QCDoc
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QCDoc(wp_VlrCtrl,
                                        wl_aePEODP_QCDoc(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QCDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QCDoc(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QCDoc As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodDoc").Value = wp_ePEODP_QCDoc.sCodDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QCDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QCDoc_DGV(ByRef wp_ePEODP_QCDoc As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QCDoc As New moe_Estructuras.ePEODP
            With wl_ePEODP_QCDoc
                .sCodDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodDoc").Value
            End With
            wp_ePEODP_QCDoc = wl_ePEODP_QCDoc
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QCDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "PEODP_QCSer"
    Public Sub moo_aePEODP_QCSer_DT(ByRef wp_aePEODP_QCSer As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QCSer As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QCSer(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QCSer(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QCSer = New moe_Estructuras.ePEODP
                moo_ePEODP_QCSer_DT(wl_ePEODP_QCSer,
                                   wp_DT,
                                   wl_nRow)
                wl_aePEODP_QCSer(wl_nRow) = wl_ePEODP_QCSer
            Next
            wp_aePEODP_QCSer = wl_aePEODP_QCSer
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QCSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QCSer_DT(ByRef wp_aPEODP_QCSer As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QCSer As New moe_Estructuras.ePEODP

            With wl_ePEODP_QCSer
                .sCodSer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodSer")), wp_DT.Rows(wp_nRow).Item("sCodSer"), "")

            End With
            wp_aPEODP_QCSer = wl_ePEODP_QCSer

        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QCSer_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QCSer(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePEODP_QCSer As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QCSer)
            Dim wl_aePEODP_QCSer(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QCSer = wp_aePEODP_QCSer
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QCSer(wp_VlrCtrl,
                                        wl_aePEODP_QCSer(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QCSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QCSer(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QCSer As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodSer").Value = wp_ePEODP_QCSer.sCodSer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QCSer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QCSer_DGV(ByRef wp_ePEODP_QCSer As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QCSer As New moe_Estructuras.ePEODP
            With wl_ePEODP_QCSer
                .sCodSer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodSer").Value
            End With
            wp_ePEODP_QCSer = wl_ePEODP_QCSer
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QCSer_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "PEODP_QEstODP"
    Public Sub moo_aePEODP_QEstODP_DT(ByRef wp_aePEODP_QEstODP As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QEstODP As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QEstODP(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QEstODP(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QEstODP = New moe_Estructuras.ePEODP
                moo_ePEODP_QEstODP_DT(wl_ePEODP_QEstODP,
                                   wp_DT,
                                   wl_nRow)
                wl_aePEODP_QEstODP(wl_nRow) = wl_ePEODP_QEstODP
            Next
            wp_aePEODP_QEstODP = wl_aePEODP_QEstODP
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QEstODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QEstODP_DT(ByRef wp_aPEODP_QEstODP As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QEstODP As New moe_Estructuras.ePEODP

            With wl_ePEODP_QEstODP
                .sEstOdp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEstODP")), wp_DT.Rows(wp_nRow).Item("sEstODP"), "")

            End With
            wp_aPEODP_QEstODP = wl_ePEODP_QEstODP

        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QEstODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QEstODP(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePEODP_QEstODP As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QEstODP)
            Dim wl_aePEODP_QEstODP(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QEstODP = wp_aePEODP_QEstODP
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QEstODP(wp_VlrCtrl,
                                        wl_aePEODP_QEstODP(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QEstODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QEstODP(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QEstODP As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sEstODP").Value = wp_ePEODP_QEstODP.sEstODP
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QEstODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QEstODP_DGV(ByRef wp_ePEODP_QEstODP As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QEstODP As New moe_Estructuras.ePEODP
            With wl_ePEODP_QEstODP
                .sEstOdp = wp_VlrCtrl.Rows(wp_nRow).Cells("sEstODP").Value
            End With
            wp_ePEODP_QEstODP = wl_ePEODP_QEstODP
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QEstODP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "PEODP_QFEmi"
    Public Sub moo_aePEODP_QFEmi_DT(ByRef wp_aePEODP_QFEmi As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QFEmi As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QFEmi(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QFEmi(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QFEmi = New moe_Estructuras.ePEODP
                moo_ePEODP_QFEmi_DT(wl_ePEODP_QFEmi,
                                    wp_DT,
                                    wl_nRow)
                wl_aePEODP_QFEmi(wl_nRow) = wl_ePEODP_QFEmi
            Next
            wp_aePEODP_QFEmi = wl_aePEODP_QFEmi
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QFEmi_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QFEmi_DT(ByRef wp_aPEODP_QFEmi As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QFEmi As New moe_Estructuras.ePEODP

            With wl_ePEODP_QFEmi
                .dFecEmi = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecEmi")), wp_DT.Rows(wp_nRow).Item("dFecEmi"), #1/1/1901#)
            End With
            wp_aPEODP_QFEmi = wl_ePEODP_QFEmi

        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QFEmi_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QFEmi(ByVal wp_VlrCtrl As DataGridView,
                                     ByVal wp_aePEODP_QFEmi As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QFEmi)
            Dim wl_aePEODP_QFEmi(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QFEmi = wp_aePEODP_QFEmi
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QFEmi(wp_VlrCtrl,
                                        wl_aePEODP_QFEmi(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QFEmi")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QFEmi(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QFEmi As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("dFecEmi").Value = wp_ePEODP_QFEmi.dFecEmi
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QFEmi_DGV(ByRef wp_ePEODP_QFEmi As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QFEmi As New moe_Estructuras.ePEODP
            With wl_ePEODP_QFEmi
                .dFecEmi = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecEmi").Value
            End With
            wp_ePEODP_QFEmi = wl_ePEODP_QFEmi
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QFEmi_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PEODP_QFFin"
    Public Sub moo_aePEODP_QFFin_DT(ByRef wp_aePEODP_QFFin As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QFFin As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QFFin(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QFFin(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QFFin = New moe_Estructuras.ePEODP
                moo_ePEODP_QFFin_DT(wl_ePEODP_QFFin,
                                    wp_DT,
                                    wl_nRow)
                wl_aePEODP_QFFin(wl_nRow) = wl_ePEODP_QFFin
            Next
            wp_aePEODP_QFFin = wl_aePEODP_QFFin
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QFFin_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QFFin_DT(ByRef wp_aPEODP_QFFin As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QFFin As New moe_Estructuras.ePEODP

            With wl_ePEODP_QFFin
                .dFecFin = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecFin")), wp_DT.Rows(wp_nRow).Item("dFecFin"), #1/1/1901#)
            End With
            wp_aPEODP_QFFin = wl_ePEODP_QFFin
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QFFin_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QFFin(ByVal wp_VlrCtrl As DataGridView,
                                     ByVal wp_aePEODP_QFFin As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QFFin)
            Dim wl_aePEODP_QFFin(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QFFin = wp_aePEODP_QFFin
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QFFin(wp_VlrCtrl,
                                        wl_aePEODP_QFFin(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QFFin_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QFFin(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QFFin As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("dFecFin").Value = wp_ePEODP_QFFin.dFecfin
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QFFin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QFFin_DGV(ByRef wp_ePEODP_QFFin As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QFFin As New moe_Estructuras.ePEODP
            With wl_ePEODP_QFFin
                .dFecFin = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecFin").Value
            End With
            wp_ePEODP_QFFin = wl_ePEODP_QFFin
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QFFin_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PEODP_QFIni"
    Public Sub moo_aePEODP_QFIni_DT(ByRef wp_aePEODP_QFIni As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QFIni As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QFIni(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QFIni(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QFIni = New moe_Estructuras.ePEODP
                moo_ePEODP_QFIni_DT(wl_ePEODP_QFIni,
                                    wp_DT,
                                    wl_nRow)
                wl_aePEODP_QFIni(wl_nRow) = wl_ePEODP_QFIni
            Next
            wp_aePEODP_QFIni = wl_aePEODP_QFIni
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QFIni_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QFIni_DT(ByRef wp_aPEODP_QFIni As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QFIni As New moe_Estructuras.ePEODP

            With wl_ePEODP_QFIni
                .dFecIni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dFecIni")), wp_DT.Rows(wp_nRow).Item("dFecIni"), #1/1/1901#)
            End With
            wp_aPEODP_QFIni = wl_ePEODP_QFIni
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QFIni_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QFIni(ByVal wp_VlrCtrl As DataGridView,
                                        ByVal wp_aePEODP_QFIni As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QFIni)
            Dim wl_aePEODP_QFIni(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QFIni = wp_aePEODP_QFIni
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QFIni(wp_VlrCtrl,
                                        wl_aePEODP_QFIni(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QFIni_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QFIni(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QFIni As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("dFecIni").Value = wp_ePEODP_QFIni.dFecIni
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QFIni")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QFIni_DGV(ByRef wp_ePEODP_QFIni As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QFIni As New moe_Estructuras.ePEODP
            With wl_ePEODP_QFIni
                .dFecIni = wp_VlrCtrl.Rows(wp_nRow).Cells("dFecIni").Value
            End With
            wp_ePEODP_QFIni = wl_ePEODP_QFIni
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QFIni_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "PEODP_QItm"
    Public Sub moo_aePEODP_QItm_DT(ByRef wp_aePEODP_QItm As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QItm As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QItm(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QItm(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QItm = New moe_Estructuras.ePEODP
                moo_ePEODP_QItm_DT(wl_ePEODP_QItm,
                                   wp_DT,
                                   wl_nRow)
                wl_aePEODP_QItm(wl_nRow) = wl_ePEODP_QItm
            Next
            wp_aePEODP_QItm = wl_aePEODP_QItm
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QItm_DT(ByRef wp_aPEODP_QItm As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QItm As New moe_Estructuras.ePEODP

            With wl_ePEODP_QItm
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")

            End With
            wp_aPEODP_QItm = wl_ePEODP_QItm

        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QItm_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QItm(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePEODP_QItm As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QItm)
            Dim wl_aePEODP_QItm(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QItm = wp_aePEODP_QItm
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QItm(wp_VlrCtrl,
                                        wl_aePEODP_QItm(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QItm(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QItm As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_ePEODP_QItm.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_ePEODP_QItm.sNomItm
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QItm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QItm_DGV(ByRef wp_ePEODP_QItm As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QItm As New moe_Estructuras.ePEODP
            With wl_ePEODP_QItm
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value
            End With
            wp_ePEODP_QItm = wl_ePEODP_QItm
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "PEODP_QNDoc"
    Public Sub moo_aePEODP_QNDoc_DT(ByRef wp_aePEODP_QNDoc As Array,
                                  ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_ePEODP_QNDoc As New moe_Estructuras.ePEODP
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aePEODP_QNDoc(wl_nCntReg) As moe_Estructuras.ePEODP
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aePEODP_QNDoc(wl_nRow) = New moe_Estructuras.ePEODP
                wl_ePEODP_QNDoc = New moe_Estructuras.ePEODP
                moo_ePEODP_QNDoc_DT(wl_ePEODP_QNDoc,
                                   wp_DT,
                                   wl_nRow)
                wl_aePEODP_QNDoc(wl_nRow) = wl_ePEODP_QNDoc
            Next
            wp_aePEODP_QNDoc = wl_aePEODP_QNDoc
        Catch ex As Exception
            MsgBox("Error : moo_aePEODP_QNDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QNDoc_DT(ByRef wp_aPEODP_QNDoc As Object,
                                  ByVal wp_DT As DataTable,
                                  ByVal wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QNDoc As New moe_Estructuras.ePEODP

            With wl_ePEODP_QNDoc
                .nNroDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nNroDoc")), wp_DT.Rows(wp_nRow).Item("nNroDoc"), 0)

            End With
            wp_aPEODP_QNDoc = wl_ePEODP_QNDoc

        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QNDoc_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aePEODP_QNDoc(ByVal wp_VlrCtrl As DataGridView,
                                    ByVal wp_aePEODP_QNDoc As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aePEODP_QNDoc)
            Dim wl_aePEODP_QNDoc(wl_nCntReg) As moe_Estructuras.ePEODP
            wl_aePEODP_QNDoc = wp_aePEODP_QNDoc
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_ePEODP_QNDoc(wp_VlrCtrl,
                                        wl_aePEODP_QNDoc(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aePEODP_QNDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_ePEODP_QNDoc(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_ePEODP_QNDoc As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nNroDoc").Value = wp_ePEODP_QNDoc.nNroDoc
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_ePEODP_QNDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_ePEODP_QNDoc_DGV(ByRef wp_ePEODP_QNDoc As Object,
                                   ByVal wp_VlrCtrl As DataGridView,
                                   ByRef wp_nRow As Integer)
        Try
            Dim wl_ePEODP_QNDoc As New moe_Estructuras.ePEODP
            With wl_ePEODP_QNDoc
                .nNroDoc = wp_VlrCtrl.Rows(wp_nRow).Cells("nNroDoc").Value
            End With
            wp_ePEODP_QNDoc = wl_ePEODP_QNDoc
        Catch ex As Exception
            MsgBox("Error : moo_ePEODP_QNDoc_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Q_PQFOM1"
    Public Sub moo_aeQ_PQFOM1_DT(ByRef wp_aeQ_PQFOM1 As Array,
                                 ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eQ_PQFOM1 As New moe_Estructuras.eQ_PQFOM1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeQ_PQFOM1(wl_nCntReg) As moe_Estructuras.eQ_PQFOM1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeQ_PQFOM1(wl_nRow) = New moe_Estructuras.eQ_PQFOM1
                wl_eQ_PQFOM1 = New moe_Estructuras.eQ_PQFOM1
                moo_eQ_PQFOM1_DT(wl_eQ_PQFOM1,
                                 wp_DT,
                                 wl_nRow)
                wl_aeQ_PQFOM1(wl_nRow) = wl_eQ_PQFOM1
            Next
            wp_aeQ_PQFOM1 = wl_aeQ_PQFOM1
        Catch ex As Exception
            MsgBox("Error : moo_aeQ_PQFOM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eQ_PQFOM1_DT(ByRef wp_eQ_PQFOM1 As Object,
                                ByVal wp_DT As DataTable,
                                ByVal wp_nRow As Integer)
        Try
            Dim wl_eQ_PQFOM1 As New moe_Estructuras.eQ_PQFOM1

            With wl_eQ_PQFOM1
                .nId = wp_nRow
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .sNomCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sNomItm")), wp_DT.Rows(wp_nRow).Item("T1.sNomItm"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
                .sCodLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.sCodItm")), wp_DT.Rows(wp_nRow).Item("T2.sCodItm"), "")
                .sNomLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T3.sNomItm")), wp_DT.Rows(wp_nRow).Item("T3.sNomItm"), "")
                .sCodFOM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T0.sCodItm")), wp_DT.Rows(wp_nRow).Item("T0.sCodItm"), "")
                .sNomFOM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T4.sNomItm")), wp_DT.Rows(wp_nRow).Item("T4.sNomItm"), "")
            End With
            wp_eQ_PQFOM1 = wl_eQ_PQFOM1

        Catch ex As Exception
            MsgBox("Error : moo_eQ_PQFOM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeQ_PQFOM1(ByVal wp_VlrCtrl As DataGridView,
                                  ByVal wp_aeQ_PQFOM1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeQ_PQFOM1)
            Dim wl_aeQ_PQFOM1(wl_nCntReg) As moe_Estructuras.eQ_PQFOM1
            wl_aeQ_PQFOM1 = wp_aeQ_PQFOM1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eQ_PQFOM1(wp_VlrCtrl,
                                      wl_aeQ_PQFOM1(wl_nRow),
                                      wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeQ_PQFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eQ_PQFOM1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_eQ_PQFOM1 As Object,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eQ_PQFOM1.nId
                .Rows(wp_nRow).Cells("sCodCmt").Value = wp_eQ_PQFOM1.sCodCmt
                .Rows(wp_nRow).Cells("sNomCmt").Value = wp_eQ_PQFOM1.sNomCmt
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_eQ_PQFOM1.bItmAct
                .Rows(wp_nRow).Cells("sCodLIM").Value = wp_eQ_PQFOM1.sCodLIM
                .Rows(wp_nRow).Cells("sNomLIM").Value = wp_eQ_PQFOM1.sNomLIM
                .Rows(wp_nRow).Cells("sCodFOM").Value = wp_eQ_PQFOM1.sCodFOM
                .Rows(wp_nRow).Cells("sNomFOM").Value = wp_eQ_PQFOM1.sNomFOM
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eQ_PQFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eQ_PQFOM1_DGV(ByRef wp_eQ_PQFOM1 As Object,
                                 ByVal wp_VlrCtrl As DataGridView,
                                 ByRef wp_nRow As Integer)
        Try
            Dim wl_eQ_PQFOM1 As New moe_Estructuras.eQ_PQFOM1
            With wl_eQ_PQFOM1
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .sNomCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCmt").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
                .sCodLIM = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLIM").Value
                .sNomLIM = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomLIM").Value
                .sCodFOM = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodFOM").Value
                .sNomFOM = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomFOM").Value
            End With
            wp_eQ_PQFOM1 = wl_eQ_PQFOM1
        Catch ex As Exception
            MsgBox("Error : moo_eQ_PQFOM1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Q_PQLIM1"
    Public Sub moo_aeQ_PQLIM1_DT(ByRef wp_aeQ_PQLIM1 As Array,
                                 ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eQ_PQLIM1 As New moe_Estructuras.eQ_PQLIM1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeQ_PQLIM1(wl_nCntReg) As moe_Estructuras.eQ_PQLIM1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeQ_PQLIM1(wl_nRow) = New moe_Estructuras.eQ_PQLIM1
                wl_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1
                moo_eQ_PQLIM1_DT(wl_eQ_PQLIM1,
                                 wp_DT,
                                 wl_nRow)
                wl_aeQ_PQLIM1(wl_nRow) = wl_eQ_PQLIM1
            Next
            wp_aeQ_PQLIM1 = wl_aeQ_PQLIM1
        Catch ex As Exception
            MsgBox("Error : moo_aeQ_PQLIM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eQ_PQLIM1_DT(ByRef wp_eQ_PQLIM1 As Object,
                                ByVal wp_DT As DataTable,
                                ByVal wp_nRow As Integer)
        Try
            Dim wl_eQ_PQLIM1 As New moe_Estructuras.eQ_PQLIM1

            With wl_eQ_PQLIM1
                .nId = wp_nRow
                .sCodCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCmt")), wp_DT.Rows(wp_nRow).Item("sCodCmt"), "")
                .sNomCmt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T1.sNomItm")), wp_DT.Rows(wp_nRow).Item("T1.sNomItm"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
                .sCodLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomLIM = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("T2.sNomItm")), wp_DT.Rows(wp_nRow).Item("T2.sNomItm"), "")
            End With
            wp_eQ_PQLIM1 = wl_eQ_PQLIM1

        Catch ex As Exception
            MsgBox("Error : moo_eQ_PQLIM1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeQ_PQLIM1(ByVal wp_VlrCtrl As DataGridView,
                                  ByVal wp_aeQ_PQLIM1 As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeQ_PQLIM1)
            Dim wl_aeQ_PQLIM1(wl_nCntReg) As moe_Estructuras.eQ_PQLIM1
            wl_aeQ_PQLIM1 = wp_aeQ_PQLIM1
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eQ_PQLIM1(wp_VlrCtrl,
                                      wl_aeQ_PQLIM1(wl_nRow),
                                      wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeQ_PQLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eQ_PQLIM1(ByRef wp_VlrCtrl As DataGridView,
                                 ByVal wp_eQ_PQLIM1 As Object,
                                 ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eQ_PQLIM1.nId
                .Rows(wp_nRow).Cells("sCodCmt").Value = wp_eQ_PQLIM1.sCodCmt
                .Rows(wp_nRow).Cells("sNomCmt").Value = wp_eQ_PQLIM1.sNomCmt
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_eQ_PQLIM1.bItmAct
                .Rows(wp_nRow).Cells("sCodLIM").Value = wp_eQ_PQLIM1.sCodLIM
                .Rows(wp_nRow).Cells("sNomLIM").Value = wp_eQ_PQLIM1.sNomLIM
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eQ_PQLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eQ_PQLIM1_DGV(ByRef wp_eQ_PQLIM1 As Object,
                                 ByVal wp_VlrCtrl As DataGridView,
                                 ByRef wp_nRow As Integer)
        Try
            Dim wl_eQ_PQLIM1 As New moe_Estructuras.eQ_PQLIM1
            With wl_eQ_PQLIM1
                .sCodCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCmt").Value
                .sNomCmt = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCmt").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
                .sCodLIM = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLIM").Value
                .sNomLIM = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomLIM").Value
                
            End With
            wp_eQ_PQLIM1 = wl_eQ_PQLIM1
        Catch ex As Exception
            MsgBox("Error : moo_eQ_PQLIM1_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "QConSdoFIn"
    Public Sub moo_aeQConSdoFin_DT(ByRef wp_aeQConSdoFIn As Array,
                                   ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eQConSdoFin As New moe_Estructuras.eQConSdoFin
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim wl_aeQConSdoFIn(wl_nCntReg) As moe_Estructuras.eQConSdoFin
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                wl_aeQConSdoFIn(wl_nRow) = New moe_Estructuras.eQConSdoFin
                wl_eQConSdoFin = New moe_Estructuras.eQConSdoFin
                moo_eQConSdoFin_DT(wl_eQConSdoFin,
                                   wp_DT,
                                   wl_nRow)
                wl_aeQConSdoFIn(wl_nRow) = wl_eQConSdoFin
            Next
            wp_aeQConSdoFIn = wl_aeQConSdoFIn
        Catch ex As Exception
            MsgBox("Error : moo_aeQConSdoFin_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eQConSdoFin_DT(ByRef wp_eQConSdoFin As Object,
                                 ByVal wp_DT As DataTable,
                                 ByVal wp_nRow As Integer)
        Try
            Dim wl_eQConSdoFin As New moe_Estructuras.eQConSdoFin

            With wl_eQConSdoFin
                .nId = wp_nRow
                .sCodAlm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodAlm")), wp_DT.Rows(wp_nRow).Item("sCodAlm"), "")
                .sCodGrp = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrp")), wp_DT.Rows(wp_nRow).Item("sCodGrp"), "")
                .sCodItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodItm")), wp_DT.Rows(wp_nRow).Item("sCodItm"), "")
                .sNomItm = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomItm")), wp_DT.Rows(wp_nRow).Item("sNomItm"), "")
                .bItmAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bItmAct")), wp_DT.Rows(wp_nRow).Item("bItmAct"), False)
                .bIndCan = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCan")), wp_DT.Rows(wp_nRow).Item("bIndCan"), False)
                .bIndCos = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIndCos")), wp_DT.Rows(wp_nRow).Item("bIndCos"), False)
                .nSdoFinUni = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinUni")), wp_DT.Rows(wp_nRow).Item("nSdoFinUni"), 0)
                .nSdoFinPes = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nSdoFinPes")), wp_DT.Rows(wp_nRow).Item("nSdoFinPes"), 0)
            End With
            wp_eQConSdoFin = wl_eQConSdoFin

        Catch ex As Exception
            MsgBox("Error : moo_eQConSdoFin_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeQConSdoFin_DT(ByVal wp_VlrCtrl As DataGridView,
                                        ByVal wp_aeQConSdoFin As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeQConSdoFin)
            Dim wl_aeQConSdoFin(wl_nCntReg) As moe_Estructuras.eQConSdoFin
            wl_aeQConSdoFin = wp_aeQConSdoFin
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    moo_DGV_eQConSdoFin(wp_VlrCtrl,
                                        wl_aeQConSdoFin(wl_nRow),
                                        wl_nRow)
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeQConSdoFin_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_eQConSdoFin(ByRef wp_VlrCtrl As DataGridView,
                                   ByVal wp_eQConSdoFin As Object,
                                   ByVal wp_nRow As Integer)
        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nId").Value = wp_eQConSdoFin.nId
                .Rows(wp_nRow).Cells("sCodAlm").Value = wp_eQConSdoFin.sCodAlm
                .Rows(wp_nRow).Cells("sCodGrp").Value = wp_eQConSdoFin.sCodGrp
                .Rows(wp_nRow).Cells("sCodItm").Value = wp_eQConSdoFin.sCodItm
                .Rows(wp_nRow).Cells("sNomItm").Value = wp_eQConSdoFin.sNomItm
                .Rows(wp_nRow).Cells("bItmAct").Value = wp_eQConSdoFin.bItmAct
                .Rows(wp_nRow).Cells("bIndCan").Value = wp_eQConSdoFin.bIndCan
                .Rows(wp_nRow).Cells("bIndCos").Value = wp_eQConSdoFin.bIndCos
                .Rows(wp_nRow).Cells("nSdoFinUni").Value = wp_eQConSdoFin.nSdoFinUni
                .Rows(wp_nRow).Cells("nSdoFinPes").Value = wp_eQConSdoFin.nSdoFinPes
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGV_eQConSdoFin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eQConSdoFin_DGV(ByRef wp_eQConSdoFin As Object,
                                 ByVal wp_VlrCtrl As DataGridView,
                                 ByRef wp_nRow As Integer)
        Try
            Dim wl_eQConSdoFin As New moe_Estructuras.eQConSdoFin
            With wl_eQConSdoFin
                .nId = wp_VlrCtrl.Rows(wp_nRow).Cells("nId").Value
                .sCodAlm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodAlm").Value
                .sCodGrp = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrp").Value
                .sCodItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodItm").Value
                .sNomItm = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomItm").Value
                .bItmAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bItmAct").Value
                .bIndCan = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCan").Value
                .bIndCos = wp_VlrCtrl.Rows(wp_nRow).Cells("bIndCos").Value
                .nSdoFinUni = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinUni").Value
                .nSdoFinPes = wp_VlrCtrl.Rows(wp_nRow).Cells("nSdoFinPes").Value
            End With
            wp_eQConSdoFin = wl_eQConSdoFin
        Catch ex As Exception
            MsgBox("Error : moo_eQConSdoFin_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "TEDMT"
    Public Sub moo_aeTEDMT_DT(ByRef wp_aeTEDMT As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeTEDMT(wl_nCntReg) As moe_Estructuras.eTEDMT
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeTEDMT(wl_nRow) = New moe_Estructuras.eTEDMT
                wl_eTEDMT = New moe_Estructuras.eTEDMT
                moo_eTEDMT_DT(wl_eTEDMT,
                              wp_DT,
                              wl_nRow)
                va_aeTEDMT(wl_nRow) = wl_eTEDMT
            Next
            wp_aeTEDMT = va_aeTEDMT
        Catch ex As Exception
            MsgBox("Error : moo_aeTEDMA_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eTEDMT_DT(ByRef wp_eTEDMT As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
            With wl_eTEDMT
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nId")), wp_DT.Rows(wp_nRow).Item("nId"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomTer")), wp_DT.Rows(wp_nRow).Item("sNomTer"), "")
                .sTipTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipTer")), wp_DT.Rows(wp_nRow).Item("sTipTer"), "")
                .sNitTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNitTer")), wp_DT.Rows(wp_nRow).Item("sNitTer"), "")
                .sDigVer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDigVer")), wp_DT.Rows(wp_nRow).Item("sDigVer"), "")
                .sDirTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDirTer")), wp_DT.Rows(wp_nRow).Item("sDirTer"), "")
                .sTel1Ter = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel1Ter")), wp_DT.Rows(wp_nRow).Item("sTel1Ter"), "")
                .sTel2Ter = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTel2Ter")), wp_DT.Rows(wp_nRow).Item("sTel2Ter"), "")
                .sTelCll = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTelCll")), wp_DT.Rows(wp_nRow).Item("sTelCll"), "")
                .sFax = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sFax")), wp_DT.Rows(wp_nRow).Item("sFax"), "")
                .sNomAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomAlt")), wp_DT.Rows(wp_nRow).Item("sNomAlt"), "")
                .sCodGrpTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodGrpTer")), wp_DT.Rows(wp_nRow).Item("sCodGrpTer"), "")
                .sEmlTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sEmlTer")), wp_DT.Rows(wp_nRow).Item("sEmlTer"), "")
                .sNomCtc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sNomCtc")), wp_DT.Rows(wp_nRow).Item("sNomCtc"), "")
                .sTipCtaCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sTipCtaCtb")), wp_DT.Rows(wp_nRow).Item("sTipCtaCtb"), "")
                .sCodCtaCtb = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodCtaCtb")), wp_DT.Rows(wp_nRow).Item("sCodCtaCtb"), "")
                .sCndPag = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCndPag")), wp_DT.Rows(wp_nRow).Item("sCndPag"), "")
                .sCodLstPre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodLstPre")), wp_DT.Rows(wp_nRow).Item("sCodLstPre"), "")
                .nPorDto = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nPorDto")), wp_DT.Rows(wp_nRow).Item("nPorDto"), 0)
                .nLmtCre = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nLmtCre")), wp_DT.Rows(wp_nRow).Item("nLmtCre"), 0)
                .bAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bAct")), wp_DT.Rows(wp_nRow).Item("bAct"), False)
                .bIna = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bIna")), wp_DT.Rows(wp_nRow).Item("bIna"), False)
                .sCmn = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCmn")), wp_DT.Rows(wp_nRow).Item("sCmn"), "")
            End With
            wp_eTEDMT = wl_eTEDMT
        Catch ex As Exception
            MsgBox("Error : moo_eTEDMT_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeTLDMT1_DT(ByRef wp_aeTLDMT1 As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eTLDMT1 As New moe_Estructuras.eTLDMT1
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeTLDMT1(wl_nCntReg) As moe_Estructuras.eTLDMT1
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeTLDMT1(wl_nRow) = New moe_Estructuras.eTLDMT1
                wl_eTLDMT1 = New moe_Estructuras.eTLDMT1
                moo_eTLDMT1_DT(wl_eTLDMT1,
                              wp_DT,
                              wl_nRow)
                va_aeTLDMT1(wl_nRow) = wl_eTLDMT1
            Next
            wp_aeTLDMT1 = va_aeTLDMT1
        Catch ex As Exception
            MsgBox("Error : moo_aeTLDMT1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eTLDMT1_DT(ByRef wp_eTLDMT1 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eTLDMT1 As New moe_Estructuras.eTLDMT1
            With wl_eTLDMT1
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sDirTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDirTer")), wp_DT.Rows(wp_nRow).Item("sDirTer"), "")
                .sCiuTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCiuTer")), wp_DT.Rows(wp_nRow).Item("sCiuTer"), "")
                .sDepTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sDepTer")), wp_DT.Rows(wp_nRow).Item("sDepTer"), "")
                .sPaiTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sPaiTer")), wp_DT.Rows(wp_nRow).Item("sPaiTer"), "")
                .bDirDfl = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bDirDfl")), wp_DT.Rows(wp_nRow).Item("bDirDfl"), False)
            End With
            wp_eTLDMT1 = wl_eTLDMT1
        Catch ex As Exception
            MsgBox("Error : moo_eTLDMT1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeTLDMT2_DT(ByRef wp_aeTLDMT2 As Array,
                              ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eTLDMT2 As New moe_Estructuras.eTLDMT2
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeTLDMT2(wl_nCntReg) As moe_Estructuras.eTLDMT2
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeTLDMT2(wl_nRow) = New moe_Estructuras.eTLDMT2
                wl_eTLDMT2 = New moe_Estructuras.eTLDMT2
                moo_eTLDMT2_DT(wl_eTLDMT2,
                              wp_DT,
                              wl_nRow)
                va_aeTLDMT2(wl_nRow) = wl_eTLDMT2
            Next
            wp_aeTLDMT2 = va_aeTLDMT2
        Catch ex As Exception
            MsgBox("Error : moo_aeTLDMT2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eTLDMT2_DT(ByRef wp_eTLDMT2 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eTLDMT2 As New moe_Estructuras.eTLDMT2
            With wl_eTLDMT2
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sCodRet = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodRet")), wp_DT.Rows(wp_nRow).Item("sCodRet"), "")
                .bAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bAct")), wp_DT.Rows(wp_nRow).Item("bAct"), False)
            End With
            wp_eTLDMT2 = wl_eTLDMT2
        Catch ex As Exception
            MsgBox("Error : moo_eTLDMT2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeTLDMT3_DT(ByRef wp_aeTLDMT3 As Array,
                            ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eTLDMT3 As New moe_Estructuras.eTLDMT3
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeTLDMT3(wl_nCntReg) As moe_Estructuras.eTLDMT3
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeTLDMT3(wl_nRow) = New moe_Estructuras.eTLDMT3
                wl_eTLDMT3 = New moe_Estructuras.eTLDMT3
                moo_eTLDMT3_DT(wl_eTLDMT3,
                              wp_DT,
                              wl_nRow)
                va_aeTLDMT3(wl_nRow) = wl_eTLDMT3
            Next
            wp_aeTLDMT3 = va_aeTLDMT3
        Catch ex As Exception
            MsgBox("Error : moo_aeTLDMT3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eTLDMT3_DT(ByRef wp_eTLDMT3 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eTLDMT3 As New moe_Estructuras.eTLDMT3
            With wl_eTLDMT3
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sCodIVA = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodIVA")), wp_DT.Rows(wp_nRow).Item("sCodIVA"), "")
                .bAct = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("bAct")), wp_DT.Rows(wp_nRow).Item("bAct"), False)
            End With
            wp_eTLDMT3 = wl_eTLDMT3
        Catch ex As Exception
            MsgBox("Error : moo_eTLDMT3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_aeTLDMT4_DT(ByRef wp_aeTLDMT4 As Array,
                            ByVal wp_DT As DataTable)
        Try
            Dim wl_nCntReg As Integer
            Dim wl_eTLDMT4 As New moe_Estructuras.eTLDMT4
            wl_nCntReg = wp_DT.Rows.Count - 1
            Dim va_aeTLDMT4(wl_nCntReg) As moe_Estructuras.eTLDMT4
            For wl_nRow = 0 To wp_DT.Rows.Count - 1
                va_aeTLDMT4(wl_nRow) = New moe_Estructuras.eTLDMT4
                wl_eTLDMT4 = New moe_Estructuras.eTLDMT4
                moo_eTLDMT4_DT(wl_eTLDMT4,
                              wp_DT,
                              wl_nRow)
                va_aeTLDMT4(wl_nRow) = wl_eTLDMT4
            Next
            wp_aeTLDMT4 = va_aeTLDMT4
        Catch ex As Exception
            MsgBox("Error : moo_aeTLDMT4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eTLDMT4_DT(ByRef wp_eTLDMT4 As Object,
                             ByVal wp_DT As DataTable,
                             ByVal wp_nRow As Integer)
        Try
            Dim wl_eTLDMT4 As New moe_Estructuras.eTLDMT4
            With wl_eTLDMT4
                .nID = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("nID")), wp_DT.Rows(wp_nRow).Item("nID"), 0)
                .sCodTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sCodTer")), wp_DT.Rows(wp_nRow).Item("sCodTer"), "")
                .sMMTipDoc = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMTipDoc")), wp_DT.Rows(wp_nRow).Item("sMMTipDoc"), "")
                .sMMNomTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMNomTer")), wp_DT.Rows(wp_nRow).Item("sMMNomTer"), "")
                .sMMPriNom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMPriNom")), wp_DT.Rows(wp_nRow).Item("sMMPriNom"), "")
                .sMMSegNom = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMSegNom")), wp_DT.Rows(wp_nRow).Item("sMMSegNom"), "")
                .sMMPriApe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMPriApe")), wp_DT.Rows(wp_nRow).Item("sMMPriApe"), "")
                .sMMSegApe = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMSegApe")), wp_DT.Rows(wp_nRow).Item("sMMSegApe"), "")
                .sMMDirTer = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMDirTer")), wp_DT.Rows(wp_nRow).Item("sMMDirTer"), "")
                .sMMCodDep = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMCodDep")), wp_DT.Rows(wp_nRow).Item("sMMCodDep"), "")
                .sMMCodCiu = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMCodCiu")), wp_DT.Rows(wp_nRow).Item("sMMCodCiu"), "")
                .sMMCodPai = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMCodPai")), wp_DT.Rows(wp_nRow).Item("sMMCodPai"), "")
                .dMMFecRUT = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("dMMFecRUT")), wp_DT.Rows(wp_nRow).Item("dMMFecRUT"), "")
                .sMMCodAcvPpl = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMCodAcvPpl")), wp_DT.Rows(wp_nRow).Item("sMMCodAcvPpl"), "")
                .sMMCodAcvAlt = IIf(Not IsDBNull(wp_DT.Rows(wp_nRow).Item("sMMCodAcvAlt")), wp_DT.Rows(wp_nRow).Item("sMMCodAcvAlt"), "")
            End With
            wp_eTLDMT4 = wl_eTLDMT4
        Catch ex As Exception
            MsgBox("Error : moo_eTLDMT4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGV_aeTEDMT(ByVal wp_VlrCtrl As DataGridView,
                               ByVal wp_aeTEDMT As Array)
        Try
            Dim wl_nCntReg As Integer
            wl_nCntReg = UBound(wp_aeTEDMT)
            Dim va_aeTEDMT(wl_nCntReg) As moe_Estructuras.eTEDMT
            va_aeTEDMT = wp_aeTEDMT
            For wl_nRow = 0 To wl_nCntReg
                With wp_VlrCtrl
                    .Rows.Add()
                    .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                    .Rows(wl_nRow).Cells("nId").Value = va_aeTEDMT(wl_nRow).nID
                    .Rows(wl_nRow).Cells("sCodTer").Value = va_aeTEDMT(wl_nRow).sCodTer
                    .Rows(wl_nRow).Cells("sNomTer").Value = va_aeTEDMT(wl_nRow).sNomTer
                    .Rows(wl_nRow).Cells("sTipTer").Value = va_aeTEDMT(wl_nRow).sTipTer
                    .Rows(wl_nRow).Cells("sNitTer").Value = va_aeTEDMT(wl_nRow).sNitTer
                    .Rows(wl_nRow).Cells("sDigVer").Value = va_aeTEDMT(wl_nRow).sDigVer
                    .Rows(wl_nRow).Cells("sDirTer").Value = va_aeTEDMT(wl_nRow).sDirTer
                    .Rows(wl_nRow).Cells("sTel1Ter").Value = va_aeTEDMT(wl_nRow).sTel1Ter
                    .Rows(wl_nRow).Cells("sTel2Ter").Value = va_aeTEDMT(wl_nRow).sTel2Ter
                    .Rows(wl_nRow).Cells("sTelCll").Value = va_aeTEDMT(wl_nRow).sTelCll
                    .Rows(wl_nRow).Cells("sFax").Value = va_aeTEDMT(wl_nRow).sFax
                    .Rows(wl_nRow).Cells("sNomAlt").Value = va_aeTEDMT(wl_nRow).sNomAlt
                    .Rows(wl_nRow).Cells("sCodGrpTer").Value = va_aeTEDMT(wl_nRow).sCodGrpTer
                    .Rows(wl_nRow).Cells("sEmlTer").Value = va_aeTEDMT(wl_nRow).sEmlTer
                    .Rows(wl_nRow).Cells("sNomCtc").Value = va_aeTEDMT(wl_nRow).sNomCtc
                    .Rows(wl_nRow).Cells("sTipCtaCtb").Value = va_aeTEDMT(wl_nRow).sTipCtaCtb
                    .Rows(wl_nRow).Cells("sCodCtaCtb").Value = va_aeTEDMT(wl_nRow).sCodCtaCtb
                    .Rows(wl_nRow).Cells("sCndPag").Value = va_aeTEDMT(wl_nRow).sCndPag
                    .Rows(wl_nRow).Cells("sCodLstPre").Value = va_aeTEDMT(wl_nRow).sCodLstPre
                    .Rows(wl_nRow).Cells("nPorDto").Value = va_aeTEDMT(wl_nRow).nPorDto
                    .Rows(wl_nRow).Cells("nLmtCre").Value = va_aeTEDMT(wl_nRow).nLmtCre
                    .Rows(wl_nRow).Cells("bAct").Value = va_aeTEDMT(wl_nRow).bAct
                    .Rows(wl_nRow).Cells("bIna").Value = va_aeTEDMT(wl_nRow).bIna
                    .Rows(wl_nRow).Cells("sCmn").Value = va_aeTEDMT(wl_nRow).sCmn
                End With
            Next
        Catch ex As Exception
            MsgBox("Error : moo_DGV_aeTEDMT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_eTEDMT_DGV(ByRef wp_eTEDMT As Object,
                              ByVal wp_VlrCtrl As DataGridView,
                              ByRef wp_nRow As Integer)
        Try
            Dim va_eTEDMT As New moe_Estructuras.eTEDMT
            With va_eTEDMT
                .nID = wp_VlrCtrl.Rows(wp_nRow).Cells("nID").Value
                .sCodTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodTer").Value
                .sNomTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomTer").Value
                .sTipTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipTer").Value
                .sNitTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sNitTer").Value
                .sDigVer = wp_VlrCtrl.Rows(wp_nRow).Cells("sDigVer").Value
                .sDirTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sDirTer").Value
                .sTel1Ter = wp_VlrCtrl.Rows(wp_nRow).Cells("sTel1Ter").Value
                .sTel2Ter = wp_VlrCtrl.Rows(wp_nRow).Cells("sTel2Ter").Value
                .sTelCll = wp_VlrCtrl.Rows(wp_nRow).Cells("sTelCll").Value
                .sFax = wp_VlrCtrl.Rows(wp_nRow).Cells("sFax").Value
                .sNomAlt = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomAlt").Value
                .sCodGrpTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodGrpTer").Value
                .sEmlTer = wp_VlrCtrl.Rows(wp_nRow).Cells("sEmlTer").Value
                .sNomCtc = wp_VlrCtrl.Rows(wp_nRow).Cells("sNomCtc").Value
                .sTipCtaCtb = wp_VlrCtrl.Rows(wp_nRow).Cells("sTipCtaCtb").Value
                .sCodCtaCtb = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodCtaCtb").Value
                .sCndPag = wp_VlrCtrl.Rows(wp_nRow).Cells("sCndPag").Value
                .sCodLstPre = wp_VlrCtrl.Rows(wp_nRow).Cells("sCodLstPre").Value
                .nPorDto = wp_VlrCtrl.Rows(wp_nRow).Cells("nPorDto").Value
                .nLmtCre = wp_VlrCtrl.Rows(wp_nRow).Cells("nLmtCre").Value
                .bAct = wp_VlrCtrl.Rows(wp_nRow).Cells("bAct").Value
                .bIna = wp_VlrCtrl.Rows(wp_nRow).Cells("bIna").Value
                .sCmn = wp_VlrCtrl.Rows(wp_nRow).Cells("sCmn").Value
            End With
            wp_eTEDMT = va_eTEDMT
        Catch ex As Exception
            MsgBox("Error : moo_eTEDMT_DGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVGLMOV1_eTEDMT(ByRef wp_eTEDMT As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try

            Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
            wl_eTEDMT = wp_eTEDMT
            With wp_VlrCtrl
                ' .Rows(wp_nRow).Cells(8).Value = wl_eTEDMT.sCodTer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVGLMOV1_eTEDMT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub moo_DGVILDMI2_eTEDMT(ByRef wp_eTEDMT As Object,
                                    ByVal wp_VlrCtrl As DataGridView,
                                    ByRef wp_nRow As Integer)
        Try

            Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
            wl_eTEDMT = wp_eTEDMT
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells("nID").Value = wl_eTEDMT.nID
                .Rows(wp_nRow).Cells("sNomTer").Value = wl_eTEDMT.sNomTer
            End With
        Catch ex As Exception
            MsgBox("Error : moo_DGVILDMI2_eTEDMT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Module
