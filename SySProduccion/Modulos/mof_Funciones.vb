' mof - Modulo de las funciones generales
'Imports System.Data.OleDb

Module mof_Funciones
#Region "Habilitar botones Toolbar"
    Public Sub mof_habTsbBuscar()
        mdiPpal.tsbBuscar.Enabled = True
    End Sub
    Public Sub mof_habTsbCrear()
        mdiPpal.tsbCrear.Enabled = True
    End Sub
    Public Sub mof_habTsbEliminar()
        mdiPpal.tsbEliminar.Enabled = True
    End Sub
    Public Sub mof_habTsbExcel()
        mdiPpal.tsbAExcel.Enabled = True
    End Sub
    Public Sub mof_habTsbPASU()
        mdiPpal.tsbPrimero.Enabled = True
        mdiPpal.tsbAnterior.Enabled = True
        mdiPpal.tsbSiguiente.Enabled = True
        mdiPpal.tsbUltimo.Enabled = True
    End Sub
    Public Sub mof_habVwvPrevPrn()
        mdiPpal.tsbVwvPrv.Enabled = True
        mdiPpal.tsbPrn.Enabled = True
    End Sub
#End Region
#Region "Inhabilitar botones Toolbar"
    Public Sub mof_inhabTsbBuscar()
        mdiPpal.tsbBuscar.Enabled = False
    End Sub
    Public Sub mof_inhabTsbCrear()
        mdiPpal.tsbCrear.Enabled = False
    End Sub
    Public Sub mof_inhabTsbEliminar()
        mdiPpal.tsbEliminar.Enabled = False
    End Sub
    Public Sub mof_inhabTsbExcel()
        mdiPpal.tsbAExcel.Enabled = False
    End Sub
    Public Sub mof_inhabTsbPASU()
        mdiPpal.tsbPrimero.Enabled = False
        mdiPpal.tsbAnterior.Enabled = False
        mdiPpal.tsbSiguiente.Enabled = False
        mdiPpal.tsbUltimo.Enabled = False
    End Sub
    Public Sub mof_inhabVwvPrvPrn()
        mdiPpal.tsbVwvPrv.Enabled = False
        mdiPpal.tsbPrn.Enabled = False
    End Sub
    Public Sub mof_inhabToolbar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_inhabVwvPrvPrn()
    End Sub
#End Region
#Region "Errores"
    Public Sub mof_MsgError(ByVal wp_sNomtbl As String,
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
                mdiPpal.lblMsgErr.Text = wg_DTErr1.Rows(0).Item("sDesErr")
                If wp_sDatCmp <> "" Then
                    mdiPpal.lblMsgErr.Text += " : " & Trim(wp_sDatCmp)
                End If
                If wp_sNomtbl <> "" Then
                    mdiPpal.lblMsgErr.Text += " en " & wp_sNomtbl
                End If
            End If
            If wp_sTipDes = "1" Then
                mdiPpal.lblMsgErr.Text = Trim(wg_DTErr1.Rows(0).Item("sDesErr"))
            End If
            mdiPpal.Timer3_Timer()



        End If
    End Sub
    Public Sub mof_LmpMsgError()
        mdiPpal.lblMsgErr.BackColor = Color.AliceBlue
        mdiPpal.lblMsgErr.Text = ""
    End Sub
#End Region
#Region "Exportar a Excel"
    Public Sub mof_Exp_DGV_Excel1(ByVal wp_sRutArc As String,
                                 ByVal wp_VlrCtrl As DataGridView)

        Try
            Dim wl_xlApp As Object = CreateObject("Excel.Application&quo­t") 'crear una nueva hoja de calculo 
            Dim wl_xlWB As Object = wl_xlApp.WorkBooks.add
            Dim wl_xlWS As Object = wl_xlWB.WorkSheets(1) 'exportamos los caracteres de las columnas 
            For c As Integer = 0 To wp_VlrCtrl.Columns.Count - 1
                wl_xlWS.cells(1, c + 1).value = wp_VlrCtrl.Columns(c).HeaderText
            Next 'exportamos las cabeceras de columnas 
            For r As Integer = 0 To wp_VlrCtrl.RowCount - 1
                For c As Integer = 0 To wp_VlrCtrl.Columns.Count - 1
                    wl_xlWS.cells(r + 2, c + 1).value = wp_VlrCtrl.Item(c, r).Value
                Next
            Next 'guardamos la hoja de calculo en la ruta especificada 
            wl_xlWB.saveas(wp_sRutArc)
            wl_xlWS = Nothing
            wl_xlWB = Nothing
            wl_xlApp.quit()
            wl_xlApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_Exp_DGV_Excel")
        End Try
    End Sub

    ' Esta parte va en el formulario

    Private Sub Button1_Click()
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' mof_Exp_DGV_Excel(Me.DataGridView1, save.FileName)
        End If
    End Sub
    Private Sub mof_Exp_DGV_Excel(ByRef wp_worksheet As Microsoft.Office.Interop.Excel._Worksheet,
                                  ByVal wp_VlrCtrl As DataGridView)
        Try
            'Export Header Names Start
            Dim columnsCount As Integer = wp_VlrCtrl.Columns.Count
            For Each column In wp_VlrCtrl.Columns
                wp_worksheet.Cells(1, column.Index + 1).Value = column.Name
            Next
            'Export Header Name End

            'Export Each Row Start

            For i As Integer = 0 To wp_VlrCtrl.Rows.Count - 1
                Dim columnIndex As Integer = 0
                Do Until columnIndex = columnsCount
                    wp_worksheet.Cells(i + 2, columnIndex + 1).Value = wp_VlrCtrl.Item(columnIndex, i).Value.ToString
                    columnIndex += 1
                Loop
            Next
            'Export Each Row End
        Catch ex As Exception
            MsgBox("Error en: Export_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "Activar Command Buttons"
    Public Sub mof_ActivarActualizar(ByVal wp_VlrCtrl As Control)
        Try
            mof_LmpMsgError()
            mof_habTsbBuscar()
            mof_habTsbCrear()
            mof_habTsbPASU()
            mof_inhabTsbEliminar()
            For Each oCtrl As Object In wp_VlrCtrl.Controls
                If TypeOf oCtrl Is TextBox Then
                    If oCtrl.TabIndex = 1 Then
                        oCtrl.Enabled = False
                        oCtrl.BackColor = wg_ClrEnableF
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
                    mof_ActivarActualizar(oCtrl)
                End If
                If TypeOf oCtrl Is Panel Then
                    mof_ActivarActualizar(oCtrl)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: mof_ActivarActualizar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mof_ActivarBuscar(ByVal wp_VlrCtrl As Control)
        mof_habTsbCrear()
        mof_habTsbPASU()
        mof_habVwvPrevPrn()
        mof_inhabTsbBuscar()
        mof_inhabTsbEliminar()

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


                If oCtrl.name = "cmdCpa" Then
                    If oCtrl.visible = True Then
                        oCtrl.enabled = True
                    End If
                End If
                If oCtrl.name = "cmdCpd" Then
                    If oCtrl.visible = True Then
                        oCtrl.enabled = True
                    End If
                End If
            End If
            If TypeOf oCtrl Is SplitContainer Then
                mof_ActivarBuscar(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                mof_ActivarBuscar(oCtrl)
            End If
        Next
    End Sub
    Public Sub mof_ActivarCrear(ByVal wp_VlrCtrl As Control)
        ' Fec_Ult_Act : 2014.05.01

        Try


            mof_LmpMsgError()
            mof_habTsbBuscar()
            mof_habTsbPASU()
            mof_inhabTsbCrear()
            mof_inhabTsbEliminar()

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
                    If oCtrl.name = "cmdCpa" Then
                        If oCtrl.visible = True Then
                            oCtrl.enabled = False
                        End If
                    End If
                    If oCtrl.name = "cmdCpd" Then
                        If oCtrl.visible = True Then
                            oCtrl.enabled = False
                        End If
                    End If
                End If

                If TypeOf oCtrl Is SplitContainer Then
                    mof_ActivarCrear(oCtrl)
                End If
                If TypeOf oCtrl Is Panel Then
                    mof_ActivarCrear(oCtrl)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_ActivarCrear")
        End Try
    End Sub
    Public Sub mof_ActivarEliminar(ByVal wp_VlrCtrl As Control)
        mof_LmpMsgError()

        mof_habTsbBuscar()
        mof_habTsbCrear()
        mof_habTsbPASU()

        mof_inhabTsbEliminar()

        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = False
                    oCtrl.BackColor = wg_ClrEnableF
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
                mof_ActivarEliminar(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                mof_ActivarEliminar(oCtrl)
            End If
        Next
    End Sub
    Public Sub mof_ActivarOK(ByVal wp_VlrCtrl As Control)
        mof_habTsbBuscar()
        mof_habTsbCrear()
        mof_habTsbPASU()
        mof_habTsbEliminar()
        mof_habVwvPrevPrn()
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                If oCtrl.TabIndex = 1 Then
                    oCtrl.Enabled = False
                    oCtrl.BackColor = wg_ClrEnableF
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
                mof_ActivarOK(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                mof_ActivarOK(oCtrl)
            End If
        Next
    End Sub
#End Region
#Region "Ventana de mensajes"
    Public Function mof_fMnjMsg(ByVal wp_nBoxMsg As Integer,
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
                'wl_sResMsg = MsgBox("Este documwl_sInto no puede modificarse después de crearse. ¿ Continua? ", vbYesNo + vbQuestion, Title:="wl_sIntrada de invwl_sIntarios")

                wp_nResMsg = MessageBox.Show(wp_sDesMsg,
                                             wp_sTitMsg,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information,
                                             MessageBoxDefaultButton.Button2,
                                             MessageBoxOptions.RightAlign)
            End If
            If wp_nBoxMsg = 0 Then
                'wl_sResMsg = MsgBox("Este documwl_sInto no puede modificarse después de crearse. ¿ Continua? ", vbYesNo + vbQuestion, Title:="wl_sIntrada de invwl_sIntarios")

                wp_nResMsg = MessageBox.Show(wp_sDesMsg,
                                             wp_sTitMsg)

                '   MessageBoxButtons.YesNo,
                '  MessageBoxIcon.Information,
                ' MessageBoxDefaultButton.Button2,
                'MessageBoxOptions.RightAlign)
            End If
        Catch ex As Exception
            MsgBox("Error en : mof_fMnjMsg")
        End Try
        Return wp_nResMsg

    End Function
#End Region
#Region "Consultas genéricas"
    Public Function mof_fConTbl(ByVal wp_sNomTbl As String,
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
            MsgBox("Error: mof_fConTbl")
        End Try
        Return wl_DT
    End Function
    Public Function mof_fConTblE2(ByVal wp_sNomTbl As String,
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
            MsgBox("Error: mof_fConTbl")
        End Try
        Return wl_DT
    End Function
    Public Function mof_fEliReg(ByVal wp_sNomTbl As String,
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
    Public Function mof_fQ2Cmp(ByVal wp_sNomTbl As String,
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
#Region "Consultas sobre Tablas"

    Public Function mof_fConABEOC(ByVal wp_sCod As String,
                                  ByRef vp_eABEOC As Object) As Boolean
        'Fec_Ult_Mod : 2014-08-11
        Dim vl_eABEOC As New moe_Estructuras.eABEOC
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String


        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ABEOC"
            wp_sNomCmpE11 = "sCodEstODC"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eABEOC_DT(vl_eABEOC,
                              wl_DT,
                              wl_nRow)
                vp_eABEOC = vl_eABEOC
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConABEOC")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConABEOP(ByVal wp_sCod As String,
                                  ByRef vp_eABEOC As Object) As Boolean
        'Fec_Ult_Mod : 2014-08-11
        Dim vl_eABEOP As New moe_Estructuras.eABEOP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String


        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ABEOP"
            wp_sNomCmpE11 = "sCodEstODP"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eABEOP_DT(vl_eABEOP,
                              wl_DT,
                              wl_nRow)
                vp_eABEOC = vl_eABEOP
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConABEOP")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConABESD(ByVal wp_sCod As String,
                                  ByRef vp_eABESD As Object) As Boolean
        'Fec_Ult_Mod : 2014-08-11
        Dim vl_eABESD As New moe_Estructuras.eABESD
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String


        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ABESD"
            wp_sNomCmpE11 = "sEstDoc"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eABESD_DT(vl_eABESD,
                              wl_DT,
                              wl_nRow)
                vp_eABESD = vl_eABESD
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConABESD")
        End Try
        Return wr_bEOF
    End Function


    Public Function mof_fConABTIR(ByVal wp_sCod As String,
                                  ByRef wp_eABTIR As Object) As Boolean
        'Fec_Ult_Mod : 2015-07-09
        Dim wl_eABTIR As New moe_Estructuras.eABTIR
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String


        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ABTIR"
            wp_sNomCmpE11 = "sTipRev"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eABTIR_DT(wl_eABTIR,
                              wl_DT,
                              wl_nRow)
                wp_eABTIR = wl_eABTIR
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConABTIR")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConABOPC(ByVal wp_sCod As String,
                                  ByRef wr_eABOPC As Object) As Boolean
        Dim wl_eABOPC As New moe_Estructuras.eABOPC
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True

        Try
            wr_bEOF = False
            wl_DT = clnConTbl.cndtConABOPC(wp_sCod,
                                           wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eABOPC_DT(wl_eABOPC,
                              wl_DT,
                              wl_nRow)
                wr_eABOPC = wl_eABOPC
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConABOPC")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConABEPC(ByVal wp_sCod As String,
                                  ByRef wr_eABEPC As Object) As Boolean
        Dim wl_eABEPC As New moe_Estructuras.eABEPC
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True

        Try
            wr_bEOF = False
            wl_DT = clnConTbl.cndtConABEPC(wp_sCod,
                                           wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eABEPC_DT(wl_eABEPC,
                              wl_DT,
                              wl_nRow)
                wr_eABEPC = wl_eABEPC
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConABEPC")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConAPDGV(ByVal wp_sNomFrm,
                                  ByVal wp_sCodDgv) As Array
        Dim wl_nRow As Long
        Dim wl_DT As New DataTable

        Try
            wp_sNomTbl = "APDGV"
            wp_sNomCmp = "sCodFrm"
            wp_sDatCmp = wp_sNomFrm
            wp_sTipCmp = "S"
            wp_sNomCmp1 = "sCodDgv"
            wp_sDatCmp1 = wp_sCodDgv
            wp_sTipCmp1 = "S"

            wp_sCmpOrd = "nNroCol"
            wp_sTipOrd = "A"
            wr_bEOF = False
            wl_DT = clnConTbl.cndtAPDGV(wp_sNomTbl,
                                        wp_sNomCmp,
                                        wp_sDatCmp,
                                        wp_sTipCmp,
                                        wp_sNomCmp1,
                                        wp_sDatCmp1,
                                        wp_sTipCmp1,
                                        wp_sCmpOrd,
                                        wr_bEOF)
            wl_nRow = wl_DT.Rows.Count - 1
            Dim wl_aeAPDGV(wl_nRow) As moe_Estructuras.eAPDGV

            If wr_bEOF = False Then
                moo_aeAPDGV_DT(wl_aeAPDGV,
                               wl_DT)
            End If

            Return wl_aeAPDGV
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConAPDGV")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConAPQDG(ByVal wp_sCodStr) As Array
        Dim wl_aeAPDGV As New moe_Estructuras.eAPDGV
        ' Dim va_eaAPDGV() As clpEstructuras.eAPDGV
        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Try
            Dim wp_sNomTblE1 As String
            Dim wp_sNomCmpE11 As String
            Dim wp_sDatCmpE11 As String
            Dim wp_sTipCmpE11 As String
            Dim wp_sCmpOrdE11 As String
            Dim wp_sTipOrdE11 As String

            wp_sNomTblE1 = "APQDG"
            wp_sNomCmpE11 = "sCodStr"
            wp_sDatCmpE11 = wp_sCodStr
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = "nColOri"
            wp_sTipOrdE11 = "A"
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim va_eaAPQDG(wl_nCntReg) As moe_Estructuras.eAPQDG

            If wr_bEOFE1 = False Then
                moo_aeAPQDG_DT(va_eaAPQDG,
                               wl_DT)
            End If

            Return va_eaAPQDG
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConAPQDG")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConAPRDG(ByVal wp_sCodRpt) As Array
        Dim wl_aeAPDGV As New moe_Estructuras.eAPDGV
        ' Dim va_eaAPDGV() As clpEstructuras.eAPDGV

        Dim wl_DT As New DataTable
        Dim wl_nCntReg As Long
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String


        Try

            wp_sNomTblE1 = "APRDG"
            wp_sNomCmpE11 = "sCodRpt"
            wp_sDatCmpE11 = wp_sCodRpt
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = "nColOri"
            wp_sTipOrdE11 = "A"
            wr_bEOFE1 = False



            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOFE1)
            wl_nCntReg = wl_DT.Rows.Count - 1
            Dim va_eaAPRDG(wl_nCntReg) As moe_Estructuras.eAPRDG

            If wr_bEOFE1 = False Then
                moo_aeAPRDG_DT(va_eaAPRDG,
                               wl_DT)
            End If



            Return va_eaAPRDG
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConAPQDG")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConATALM(ByVal wp_sCodAlm As String,
                                  ByRef vp_eATALM As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eATALM As New moe_Estructuras.eATALM
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATALM"
            wp_sNomCmpE11 = "sCodAlm"
            wp_sDatCmpE11 = wp_sCodAlm
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATALM_DT(wl_eATALM,
                              wl_DT,
                              wl_nRow)
                vp_eATALM = wl_eATALM
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATALM")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATANA(ByVal wp_sCodAna As String,
                                  ByRef wp_eATANA As Object) As Boolean
        'Fec_Ult_Mod : 2015-02-26
        Dim wl_eATANA As New moe_Estructuras.eATANA
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATANA"
            wp_sNomCmpE11 = "sCodAna"
            wp_sDatCmpE11 = wp_sCodAna
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATANA_DT(wl_eATANA,
                              wl_DT,
                              wl_nRow)
                wp_eATANA = wl_eATANA
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATANA")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATCIF(ByVal wp_sCod As String,
                                 ByRef vp_eATCIF As Object) As Boolean
        'Fec_Ult_Mod : 2014-10-24
        Dim vl_eATCIF As New moe_Estructuras.eATCIF
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATCIF"
            wp_sNomCmpE11 = "sCodCIF"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATCIF_DT(vl_eATCIF,
                              wl_DT,
                              wl_nRow)
                vp_eATCIF = vl_eATCIF
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATCIF")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATCCO(ByVal wp_sCod As String,
                                  ByRef vp_eATCCO As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim vl_eATCCO As New moe_Estructuras.eATCCO
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATCCO"
            wp_sNomCmpE11 = "sCodCco"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATCCO_DT(vl_eATCCO,
                              wl_DT,
                              wl_nRow)
                vp_eATCCO = vl_eATCCO
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATCCO")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATCTR(ByVal wp_sCod As String,
                                  ByRef wp_eATCCO As Object) As Boolean
        'Fec_Ult_Mod : 2015-02-03
        Dim wl_eATCTR As New moe_Estructuras.eATCTR
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATCTR"
            wp_sNomCmpE11 = "sCodCtr"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATCTR_DT(wl_eATCTR,
                              wl_DT,
                              wl_nRow)
                wp_eATCCO = wl_eATCTR
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATCTR")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATGRI(ByVal wp_sCod As String,
                                  ByRef wp_eATGRI As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eATGRI As New moe_Estructuras.eATGRI
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATGRI"
            wp_sNomCmpE11 = "sCodGrp"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATGRI_DT(wl_eATGRI,
                              wl_DT,
                              wl_nRow)
                wp_eATGRI = wl_eATGRI
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATGRI")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATGRV(ByVal wp_sCod As String,
                                  ByRef wp_eATGRV As Object) As Boolean
        'Fec_Ult_Mod : 2016-11-02
        Dim wl_eATGRV As New moe_Estructuras.eATGRV
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATGRV"
            wp_sNomCmpE11 = "sCodGrpVta"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATGRV_DT(wl_eATGRV,
                              wl_DT,
                              wl_nRow)
                wp_eATGRV = wl_eATGRV
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATGRV")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATIVA(ByVal wp_sCod As String,
                                  ByRef vp_eATIVA As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eATIVA As New moe_Estructuras.eATIVA
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATIVA"
            wp_sNomCmpE11 = "sCodIVA"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATIVA_DT(wl_eATIVA,
                              wl_DT,
                              wl_nRow)
                vp_eATIVA = wl_eATIVA
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATIVA")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATOPE(ByVal wp_sCod As String,
                                  ByRef vp_eATOPE As Object) As Boolean
        'Fec_Ult_Mod : 2014-10-24
        Dim vl_eATOPE As New moe_Estructuras.eATOPE
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATOPE"
            wp_sNomCmpE11 = "sCodOPE"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATOPE_DT(vl_eATOPE,
                              wl_DT,
                              wl_nRow)
                vp_eATOPE = vl_eATOPE
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATOPE")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATPCO(ByVal wp_sCod As String,
                                  ByRef vp_eATPCO As Object) As Boolean
        'Fec_Ult_Mod : 2015-04-06
        Dim wl_eATPCO As New moe_Estructuras.eATPCO
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATPCO"
            wp_sNomCmpE11 = "sCodPdo"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATPCO_DT(wl_eATPCO,
                              wl_DT,
                              wl_nRow)
                vp_eATPCO = wl_eATPCO
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATPCO")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATPOP(ByVal wp_sCod As String,
                                  ByRef vp_eATOPE As Object) As Boolean
        'Fec_Ult_Mod : 2015-04-06
        Dim wl_eATPOP As New moe_Estructuras.eATPOP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATPOP"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATPOP_DT(wl_eATPOP,
                              wl_DT,
                              wl_nRow)
                vp_eATOPE = wl_eATPOP
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATPOP")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATTIA(ByVal wp_sCodTipAna As String,
                                  ByRef wp_eATTIA As Object) As Boolean
        'Fec_Ult_Mod : 2015-02-25
        Dim wl_eATTIA As New moe_Estructuras.eATTIA
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATTIA"
            wp_sNomCmpE11 = "sCodTipAna"
            wp_sDatCmpE11 = wp_sCodTipAna
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATTIA_DT(wl_eATTIA,
                              wl_DT,
                              wl_nRow)
                wp_eATTIA = wl_eATTIA
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATTIA")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATVEN(ByVal wp_sCod As String,
                                  ByRef vp_eATVEN As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eATVEN As New moe_Estructuras.eATVEN
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATVEN"
            wp_sNomCmpE11 = "sCodVen"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATVEN_DT(wl_eATVEN,
                              wl_DT,
                              wl_nRow)
                vp_eATVEN = wl_eATVEN
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATVEN")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATTIN(ByVal wp_sCodTra As String,
                                  ByRef wp_eATTIN As Object) As Boolean
        'Fec_Ult_Mod : 2016-02-23
        Dim wl_eATTIN As New moe_Estructuras.eATTIN
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ATTIN"
            wp_sNomCmpE11 = "sCodTra"
            wp_sDatCmpE11 = wp_sCodTra
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATTIN_DT(wl_eATTIN,
                              wl_DT,
                              wl_nRow)
                wp_eATTIN = wl_eATTIN
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATTIN")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConATZON(ByVal wp_sCod As String,
                                  ByRef vp_eATZON As Object) As Boolean
        'Fec_Ult_Mod : 2015-04-06
        Dim wl_eATZON As New moe_Estructuras.eATZON
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        wr_bEOF = True
        Try
            wp_sNomTblE1 = "ATZON"
            wp_sNomCmpE11 = "sCodZon"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eATZON_DT(wl_eATZON,
                              wl_DT,
                              wl_nRow)
                vp_eATZON = wl_eATZON
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConATZON")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConFTPUC(ByVal wp_sCod As String,
                                  ByRef wp_eFTPUC As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eFTPUC As New moe_Estructuras.eFTPUC
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "FTPUC"
            wp_sNomCmpE11 = "sCodCta"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eFTPUC_DT(wl_eFTPUC,
                              wl_DT,
                              wl_nRow)
                wp_eFTPUC = wl_eFTPUC
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: clp_fConFEPUC")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConHEDMT(ByVal wp_sCodTer As String,
                                  ByRef wp_eHEDMT As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eHEDMT As New moe_Estructuras.eHEDMT
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "HEDMT"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCodTer
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""

            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eHEDMT_DT(wl_eHEDMT,
                              wl_DT,
                              wl_nRow)
                wp_eHEDMT = wl_eHEDMT
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConHEDMT")

        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConIEDMI(ByVal wp_sCod As String,
                                  ByRef vp_eIEDMI As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24

        Dim vl_eIEDMI As New moe_Estructuras.eIEDMI
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "IEDMI"
            wp_sNomCmpE11 = "sCodItm"
            wp_sDatCmpE11 = wp_sCod
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_nRow = -1
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eIEDMI_DT(vl_eIEDMI,
                              wl_DT,
                              wl_nRow)
                vp_eIEDMI = vl_eIEDMI
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConIEDMI")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConIELDMI1(ByVal wp_sCodItm As String,
                                    ByRef wr_eIELDMI1 As Object) As Boolean
        Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wl_bEOF As Boolean
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "ILDMI1"
            wp_sNomCmpE11 = "sCodItm"
            wp_sDatCmpE11 = wp_sCodItm
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wl_bEOF = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wl_bEOF)

            If wl_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eIELDMI1_DT(wl_eIELDMI1,
                              wl_DT,
                              wl_nRow)
                wr_eIELDMI1 = wl_eIELDMI1
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConIELDMI1")
        End Try
        Return wl_bEOF
    End Function
    Public Function mof_fConPEFOM(ByVal vp_sCodItm As String,
                                  ByRef vp_ePEFOM As Object) As Boolean
        'Fec_Ult_Mod : 2014-11-12
        Dim vl_ePEFOM As New moe_Estructuras.ePEFOM
        Dim clnPEFOM As New ClaseNegocios.clnPEFOM
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPEFOM.cndtConsultarPEFOM(vp_sCodItm,
                                                wr_bEOFE1)

            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_ePEFOM_DT(vl_ePEFOM,
                              wl_DT,
                              wl_nRow)
                vp_ePEFOM = vl_ePEFOM
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConPEFOM")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConPELIM(ByVal vp_sCodItm As String,
                                  ByRef vp_ePELIM As Object) As Boolean
        'Fec_Ult_Mod : 2014-11-12
        Dim vl_ePELIM As New moe_Estructuras.ePELIM
        Dim clnPELIM As New ClaseNegocios.clnPELIM
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPELIM.cndtConsultarPELIM(vp_sCodItm,
                                                wr_bEOFE1)

            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_ePELIM_DT(vl_ePELIM,
                              wl_DT,
                              wl_nRow)
                vp_ePELIM = vl_ePELIM

            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConPELIM")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConPEODP(ByVal wp_sCodDoc As String,
                                  ByVal wp_nNroDoc As Long,
                                  ByVal vp_sEstOdp As String,
                                  ByRef wp_ePEODP As Object) As Boolean
        Dim wl_ePEODP As New moe_Estructuras.ePEODP
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPEODP.cndtConsultarPEODP(wp_sCodDoc,
                                                wp_nNroDoc,
                                                vp_sEstOdp,
                                                Nothing,
                                                wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_ePEODP_DT(wl_ePEODP,
                              wl_DT,
                              wl_nRow)
                wp_ePEODP = wl_ePEODP
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConPEODP")
            Return Nothing
        End Try
    End Function
    Public Function mof_fConPLODP1(ByVal wp_sCodDoc As String,
                                   ByVal wp_nNroDoc As Long,
                                   ByRef wp_ePLODP1 As Object) As Boolean
        Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPEODP.cndtConsultarPLODP1(wp_sCodDoc,
                                                 wp_nNroDoc,
                                                 wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_ePLODP1_DT(wl_ePLODP1,
                               wl_DT,
                               wl_nRow)
                wp_ePLODP1 = wl_ePLODP1
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConPLODP1")
            Return Nothing
        End Try
    End Function
    Public Function mof_fConPLODP2(ByVal wp_sCodDoc As String,
                                   ByVal wp_nNroDoc As Long,
                                   ByVal wp_sCodOpe As String,
                                   ByRef wp_ePLODP2 As Object) As Boolean
        Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPEODP.cndtConsultarPLODP2(wp_sCodDoc,
                                                 wp_nNroDoc,
                                                 wp_sCodOpe,
                                                 wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_ePLODP2_DT(wl_ePLODP2,
                               wl_DT,
                               wl_nRow)
                wp_ePLODP2 = wl_ePLODP2
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConPLODP2")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConPLODP3(ByVal wp_sCodDoc As String,
                                   ByVal wp_nNroDoc As Long,
                                   ByRef wp_ePLODP3 As Object) As Boolean
        Dim wl_ePLODP3 As New moe_Estructuras.ePLODP3
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        wr_bEOFE1 = False
        Try
            wl_DT = clnPEODP.cndtConsultarPLODP3(wp_sCodDoc,
                                                 wp_nNroDoc,
                                                 wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_ePLODP3_DT(wl_ePLODP3,
                               wl_DT,
                               wl_nRow)
                wp_ePLODP3 = wl_ePLODP3
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConPLODP3")
            Return Nothing
        End Try

    End Function
    Public Function mof_fConSdoAlm(ByVal wp_sCodItm,
                                   ByVal wp_sCodAlm,
                                   ByRef vp_eIELDMI1) As Boolean

        'Fec_Ult_Mod : 2014.04.22
        Dim vl_eIELDMI1 As New moe_Estructuras.eIELDMI1
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE2 As String
        Dim wp_sNomCmpE21 As String
        Dim wp_sDatCmpE21 As String
        Dim wp_sTipCmpE21 As String
        Dim wp_sCmpOrdE21 As String
        Dim wp_sTipOrdE21 As String
        Dim wp_sNomCmpE22 As String
        Dim wp_sDatCmpE22 As String
        Dim wp_sTipCmpE22 As String




        Try
            wp_sNomTblE2 = "ILDMI1"
            wp_sNomCmpE21 = "sCodItm"
            wp_sDatCmpE21 = wp_sCodItm
            wp_sTipCmpE21 = "S"
            wp_sNomCmpE22 = "sCodAlm"
            wp_sDatCmpE22 = wp_sCodAlm
            wp_sTipCmpE22 = "S"
            wl_DT = clnIEDMI.cndtConSdoILMDI1(wp_sCodAlm,
                                              wp_sCodItm,
                                              wr_bEOF)

            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eIELDMI1_DT(vl_eIELDMI1,
                                wl_DT,
                                wl_nRow)
                vp_eIELDMI1 = vl_eIELDMI1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConSdoAlm")
        End Try
        Return wr_bEOF
    End Function
    Public Function mof_fConTLDMT1(ByVal wp_sCodTer As String,
                                   ByRef wp_eTLDMT1 As Object) As Boolean
        Dim wl_eTLDMT1 As New moe_Estructuras.eTLDMT1
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "TLDMT1"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCodTer
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eTLDMT1_DT(wl_eTLDMT1,
                              wl_DT,
                              wl_nRow)
                wp_eTLDMT1 = wl_eTLDMT1
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConTLDMT1")
            Return Nothing
        End Try
    End Function
    Public Function mof_fConTLDMT2(ByVal wp_sCodTer As String,
                                   ByRef wp_eTLDMT2 As Object) As Boolean
        Dim wl_eTLDMT2 As New moe_Estructuras.eTLDMT2
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "TLDMT2"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCodTer
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eTLDMT2_DT(wl_eTLDMT2,
                              wl_DT,
                              wl_nRow)
                wp_eTLDMT2 = wl_eTLDMT2
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConTLDMT2")
            Return Nothing
        End Try
    End Function
    Public Function mof_fConTLDMT3(ByVal wp_sCodTer As String,
                                   ByRef wp_eTLDMT3 As Object) As Boolean
        Dim wl_eTLDMT3 As New moe_Estructuras.eTLDMT3
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "TLDMT3"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCodTer
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eTLDMT3_DT(wl_eTLDMT3,
                              wl_DT,
                              wl_nRow)
                wp_eTLDMT3 = wl_eTLDMT3
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConTLDMT3")
            Return Nothing
        End Try
    End Function
    Public Function mof_fConTLDMT4(ByVal wp_sCodTer As String,
                                   ByRef wp_eTLDMT4 As Object) As Boolean
        Dim wl_eTLDMT4 As New moe_Estructuras.eTLDMT4
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "TLDMT4"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCodTer
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""
            wr_bEOFE1 = False
            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOFE1)
            If wr_bEOFE1 = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eTLDMT4_DT(wl_eTLDMT4,
                              wl_DT,
                              wl_nRow)
                wp_eTLDMT4 = wl_eTLDMT4
            End If
            Return wr_bEOFE1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConTLDMT4")
            Return Nothing
        End Try
    End Function
    Public Function mof_fConTEDMT(ByVal wp_sCodTer As String,
                                     ByRef vp_eTEDMT As Object) As Boolean
        'Fec_Ult_Mod : 2014-04-24
        Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
        Dim wl_DT As New DataTable
        Dim wl_nRow As Long
        Dim wr_bEOF As Boolean
        wr_bEOF = True
        Dim wp_sNomTblE1 As String
        Dim wp_sNomCmpE11 As String
        Dim wp_sDatCmpE11 As String
        Dim wp_sTipCmpE11 As String
        Dim wp_sCmpOrdE11 As String
        Dim wp_sTipOrdE11 As String

        Try
            wp_sNomTblE1 = "TEDMT"
            wp_sNomCmpE11 = "sCodTer"
            wp_sDatCmpE11 = wp_sCodTer
            wp_sTipCmpE11 = "S"
            wp_sCmpOrdE11 = ""
            wp_sTipOrdE11 = ""

            wl_DT = clnConTbl.cndtBuscar(wp_sNomTblE1,
                                         wp_sNomCmpE11,
                                         wp_sDatCmpE11,
                                         wp_sTipCmpE11,
                                         wp_sCmpOrdE11,
                                         wp_sTipOrdE11,
                                         wr_bEOF)
            If wr_bEOF = False Then
                wl_nRow = wl_DT.Rows.Count - 1
                moo_eTEDMT_DT(wl_eTEDMT,
                              wl_DT,
                              wl_nRow)
                vp_eTEDMT = wl_eTEDMT
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: mof_fConTEDMT")

        End Try
        Return wr_bEOF
    End Function
#End Region


#Region "Cargar de Tablas a Arreglos"
    Public Sub mof_CargarPEODP(ByRef vl_sCodDoc As String,
                               ByRef vl_nNroDoc As Long,
                               ByRef vl_sEstOdp As String,
                               ByRef wl_dFecIniOdp As Date,
                               ByRef wl_bEOF As Boolean,
                               ByRef wp_aePEODP As Object)
        Dim wl_DTE1 As DataTable
        Dim wl_aePEODP() As moe_Estructuras.ePEODP
        Dim clnPEODP As New ClaseNegocios.clnPEODP


        Try

            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPEODP(vl_sCodDoc,
                                                  vl_nNroDoc,
                                                  vl_sEstOdp,
                                                  wl_dFecIniOdp,
                                                  wl_bEOF)
            ReDim wl_aePEODP(0)
            wl_aePEODP(0) = New moe_Estructuras.ePEODP
            If wl_bEOF = False Then
                moo_aePEODP_DT(wl_aePEODP,
                               wl_DTE1)
                wp_aePEODP = wl_aePEODP
            End If

        Catch ex As Exception
            MsgBox("Error :  mof_CargarPEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mof_CargarGELMOV1(ByRef wp_dFecFin As Date,
                                 ByRef wl_bEOF As Boolean,
                                 ByRef wp_eATASI As Object,
                                 ByRef wp_eIEDMI As Object,
                                 ByRef wp_aeGELMOV1 As Object)
        Dim wl_DTE1 As DataTable
        Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
        Dim wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Dim wl_sNomtbl As String
        Dim wl_sNomTblL As String

        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_sNomtbl = "IEMOV"
            wl_sNomTblL = "ILMOV1"
            wl_eGELMOV1.xsCodItm = wp_eIEDMI.sCodItm
            wl_eGELMOV1.dFecDoc = wp_eATASI.dFecIniAno
            wl_eGELMOV1.dFecVto = wp_dFecFin

            wl_DTE1 = clnIEINV.cndtCargarGELMOV1(wl_sNomtbl,
                                                 wl_sNomTblL,
                                                 wl_eGELMOV1,
                                                 wl_bEOF)
            ReDim wl_aeGELMOV1(0)
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            '    ReDim wl_aeGEMOV(0)
            '   wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
            If wl_bEOF = False Then
                moo_aeGELMOV1_DT(wl_aeGELMOV1,
                               wl_DTE1)
                wp_aeGELMOV1 = wl_aeGELMOV1

            End If

        Catch ex As Exception
            MsgBox("Error :  mof_CargarGELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "Limpiar controles"
    Public Sub mof_fLmpCtrl(ByVal wp_VlrCtrl As Control)
        Try

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
                    mof_fLmpCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is Panel Then
                    mof_fLmpCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is TabControl Then
                    mof_fLmpCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is TabPage Then
                    mof_fLmpCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is SplitContainer Then
                    mof_fLmpCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is DataTable Then
                    oCtrl.Dispose()
                End If
                If TypeOf oCtrl Is DataSet Then
                    oCtrl.Dispose()
                End If
                If TypeOf oCtrl Is DateTimePicker Then
                    oCtrl.value = Date.Today
                End If
                If TypeOf oCtrl Is MaskedTextBox Then
                    oCtrl.Text = String.Empty
                End If
                If TypeOf oCtrl Is DataGridView Then
                    oCtrl.Rows.Clear()
                End If
            Next

        Catch ex As Exception
            MsgBox("Error: mof_fLmpCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Hab/Inhabilitar controles"
    Public Sub mof_HabCtrl(ByVal wp_VlrCtrl As Control)
        Try

            For Each oCtrl As Object In wp_VlrCtrl.Controls
                '     If oCtrl.TabIndex = 1 Then
                'oCtrl.Focus()
                'End If
                If TypeOf oCtrl Is TextBox Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is ComboBox Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is RadioButton Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is CheckBox Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is GroupBox Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is MaskedTextBox Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is DataGridView Then
                    oCtrl.enabled = True
                End If
                If TypeOf oCtrl Is Panel Then
                    mof_HabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is TabControl Then
                    mof_HabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is TabPage Then
                    mof_HabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is SplitContainer Then
                    mof_HabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is Button Then
                    If oCtrl.Name <> "cmdAceptar" Then
                        If oCtrl.Name <> "cmdCancelar" Then
                            If oCtrl.Name <> "cmdOk" Then
                                oCtrl.Enabled = True
                            End If
                        End If
                    End If

                End If
            Next

        Catch ex As Exception
            MsgBox("Error: mof_HabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mof_InhabCtrl(ByVal wp_VlrCtrl As Control)
        Try
            For Each oCtrl As Object In wp_VlrCtrl.Controls
                If TypeOf oCtrl Is TextBox Then
                    oCtrl.Enabled = False
                End If
                If TypeOf oCtrl Is ComboBox Then
                    oCtrl.Enabled = False
                End If
                If TypeOf oCtrl Is RadioButton Then
                    oCtrl.Enabled = False
                End If
                If TypeOf oCtrl Is CheckBox Then
                    oCtrl.Enabled = False
                End If
                If TypeOf oCtrl Is GroupBox Then
                    oCtrl.Enabled = False
                End If

                If TypeOf oCtrl Is MaskedTextBox Then
                    oCtrl.Enabled = False
                End If

                If TypeOf oCtrl Is DataGridView Then
                    oCtrl.enabled = False
                End If
                If TypeOf oCtrl Is Button Then
                    If oCtrl.Name <> "cmdAceptar" Then
                        If oCtrl.Name <> "cmdCancelar" Then
                            If oCtrl.Name <> "cmdOk" Then
                                oCtrl.Enabled = False
                            End If
                        End If
                    End If

                End If
                If TypeOf oCtrl Is Panel Then
                    mof_InhabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is TabControl Then
                    mof_InhabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is TabPage Then
                    mof_InhabCtrl(oCtrl)
                End If
                If TypeOf oCtrl Is SplitContainer Then
                    mof_InhabCtrl(oCtrl)
                End If
            Next

        Catch ex As Exception
            MsgBox("Error: mof_InhabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Habilitar opciones menú"
    Public Sub mof_habTsmDatos(ByVal vp_bbuscar As Boolean,
                               ByVal vp_bcrear As Boolean,
                               ByVal vp_bPrimReg As Boolean,
                               ByVal vp_bUltReg As Boolean,
                               ByVal vp_bAntReg As Boolean,
                               ByVal vp_bSigReg As Boolean,
                               ByVal vp_bEli As Boolean,
                               ByVal vp_bAdiLin As Boolean,
                               ByVal vp_bEliLin As Boolean)
        Try
            mdiPpal.BuscarToolStripMenuItem.Enabled = vp_bbuscar
            mdiPpal.CrearToolStripMenuItem.Enabled = vp_bcrear
            mdiPpal.PrimerRegistroDatosToolStripMenuItem.Enabled = vp_bPrimReg
            mdiPpal.ÚltimoRegdatosToolStripMenuItem.Enabled = vp_bUltReg
            mdiPpal.RegistroDeDatosAnteriorToolStripMenuItem.Enabled = vp_bAntReg
            mdiPpal.RegistroDeDatosSiguienteToolStripMenuItem.Enabled = vp_bSigReg
            mdiPpal.EliminarToolStripMenuItem.Enabled = vp_bEli
            mdiPpal.AñadirLíneaToolStripMenuItem.Enabled = vp_bAdiLin
            mdiPpal.EliminarLíneaToolStripMenuItem.Enabled = vp_bEliLin
        Catch ex As Exception
            MsgBox("Error : mof_habTsmDatos")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "Inhabilitar opciones menú"

#End Region
#Region "Configurar frm"
    Public Sub mof_ffmrCtrl(ByVal wp_VlrCtrl As Form)
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
    Public Sub mof_fCnfCtrl(ByVal wp_VlrCtrl As Control)
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is TextBox Then
                oCtrl.AutoSize = False
                oCtrl.Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                oCtrl.Height = 20
                oCtrl.text = ""
            End If
            If TypeOf oCtrl Is MaskedTextBox Then
                oCtrl.AutoSize = False
                oCtrl.Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                oCtrl.Height = 20
                oCtrl.text = ""
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
    Public Sub mof_IniciarVar()

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

        ' Datos globales
        wg_sCodItm = ""
        wg_sCodTer = ""

    End Sub
#End Region

#Region "Configurar dgv"
    Public Sub mof_ConfigurarDGV(ByVal wp_VlrCtrl As DataGridView,
                                 ByVal wp_nTotCol As Integer)
        Dim wl_dgvrows As New DataGridViewRow
        wl_dgvrows.Height = 15
        Try

       

        wg_ColAlto = 20

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
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black

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
        Catch ex As Exception
            MsgBox("Error : mof_ConfigurarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mof_DGVFormatCol(ByVal wp_VlrCtrl As DataGridView,
                                ByVal wp_nCol As Integer,
                                ByVal wp_sTipCol As String,
                                ByVal wp_bVisible As Boolean,
                                ByVal wp_bReadOnly As Boolean,
                                ByVal vp_sNomCmp As String,
                                ByVal vp_nTamCmp As Integer,
                                ByVal vp_sTitCol As String)
        ' wp_VlrCtrl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Try
            Dim wp_ChbCol As New DataGridViewCheckBoxColumn()

            For Each oCtrl As Object In wp_VlrCtrl.Columns
                If wp_sTipCol = "B" Then
                    '2015.01.16
                    wp_VlrCtrl.Columns.RemoveAt(wp_nCol)
                    wp_VlrCtrl.Columns.Insert(wp_nCol, wp_ChbCol)
                End If
                wp_VlrCtrl.Columns(wp_nCol).Visible = wp_bVisible
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.WrapMode = DataGridViewTriState.False
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.SelectionBackColor = wg_ClrGot
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.ForeColor = Color.Black
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                wp_VlrCtrl.Columns(wp_nCol).Name = vp_sNomCmp
                wp_VlrCtrl.Columns(wp_nCol).HeaderText = vp_sTitCol
                If vp_nTamCmp <> 0 Then
                    wp_VlrCtrl.Columns(wp_nCol).Width = vp_nTamCmp
                Else
                    wp_VlrCtrl.Columns(wp_nCol).Width = 80
                End If
                ' Campo boleano
                If wp_sTipCol = "B" Then
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Boolean)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "b"
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If
                    Exit For
                End If
                ' Campu Currency
                If wp_sTipCol = "C" Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                    ' wp_VlrCtrl.Columns(wp_nCol).Width = 100
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###.###.###.###,00"
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "C"
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If
                    Exit For
                End If
                ' Campo Integer
                If wp_sTipCol = "I" Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Int64)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "############"
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                        Exit For
                    End If
                End If
                ' Campo Fecha
                If wp_sTipCol = "F" Then
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.DateTime)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "d"
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If
                    Exit For
                End If
                ' Campo hora
                If wp_sTipCol = "H" Then
                    '  wp_VlrCtrl.Columns(wp_nCol).Width = 90
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.DateTime)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "t"
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If
                    Exit For
                End If
                ' Numérico 2 decimales
                If wp_sTipCol = "N" Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###.###.###.###,0000"
                    wp_VlrCtrl.Columns(wp_nCol).Width = 100
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If

                    Exit For
                End If
                ' Numérico 4 decimales
                If wp_sTipCol = "L" Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###.###.###.###,000000"
                    wp_VlrCtrl.Columns(wp_nCol).Width = 100
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If

                    Exit For
                End If
                ' Numérico 6 decimales
                If wp_sTipCol = "D" Then
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###.###.###.###,000000"
                    wp_VlrCtrl.Columns(wp_nCol).Width = 100
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If

                    Exit For
                End If
                If wp_sTipCol = "M" Then
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.String)
                    ' Multiples lineas en una celda
                    ' wp_VlrCtrl.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True 
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###-###"


                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If
                    Exit For
                End If

                If wp_sTipCol = "S" Then
                    wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.String)
                    ' Multiples lineas en una celda
                    ' wp_VlrCtrl.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True 
                    wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                    If wp_bVisible = True Then
                        If wp_bReadOnly Then
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                        Else
                            wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                        End If
                    End If
                    Exit For
                End If

            Next
        Catch ex As Exception
            MsgBox("Error : mof_DGVFormatCol")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mof_DGVFormatRow(ByVal wp_VlrCtrl As DataGridView,
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
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###.###.###.###,00"

                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bVisible = True Then
                    If wp_bReadOnly Then
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                    Else
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                    End If
                End If
                Exit For
            End If
            If wp_sTipCol = "C" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.Double)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "###.###.###.###,00"
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "C"
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bVisible = True Then
                    If wp_bReadOnly Then
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                    Else
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                    End If

                End If
                Exit For
            End If
            If wp_sTipCol = "S" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.String)
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bVisible = True Then
                    If wp_bReadOnly Then
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                    Else
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                    End If

                End If
                Exit For
            End If
            If wp_sTipCol = "D" Then
                wp_VlrCtrl.Columns(wp_nCol).ValueType = GetType(System.DateTime)
                wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.Format = "d"
                wp_VlrCtrl.Columns(wp_nCol).ReadOnly = wp_bReadOnly
                If wp_bVisible = True Then
                    If wp_bReadOnly Then
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                    Else
                        wp_VlrCtrl.Columns(wp_nCol).DefaultCellStyle.BackColor = wg_ClrReadOnlyF
                    End If
                End If
                Exit For
            End If
        Next

    End Sub
#End Region
#Region "dgv"
    Private Sub mof_dgvAvanzaCol(ByVal wl_nCol As Long,
                                 ByVal wl_nrow As Long,
                                 ByVal wl_nTotCol As Long,
                                 ByVal vl_nColFin As Long,
                                 ByVal wl_nColIniGrl As Long,
                                 ByVal wl_nCntRow As Long,
                                 ByRef wl_CtrlDgv As DataGridView)
        'FUA : 2015.02.25
        Dim wl_i As Integer
        Dim wl_bVdaRow As Boolean
        Try
            wl_i = wl_nCol
            For wl_i = wl_nCol To wl_nTotCol - 1
                If wl_CtrlDgv.Rows(wl_nrow).Cells(wl_i).Visible = False Then
                    Continue For
                End If
                If wl_CtrlDgv.Rows(wl_nrow).Cells(wl_i).ReadOnly = True Then
                    Continue For
                End If
                If wl_i = wl_nTotCol - 1 Then
                    If wl_CtrlDgv.Rows(wl_nrow).Cells(wl_i).Visible = True Then
                        Continue For
                    End If
                End If
                Exit For
            Next
            wl_nCol = wl_i
            If wl_nCol > vl_nColFin Then
                wl_bVdaRow = True
                '    wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nrow < wl_nCntRow - 1 Then
                        wl_nrow = wl_nrow + 1
                    Else
                        '                   dgv_AdiRow()
                        wl_nrow = wl_CtrlDgv.CurrentCellAddress.Y
                    End If
                End If
                wl_nCol = wl_nColIniGrl
            End If
        Catch ex As Exception
            MsgBox("Error :  mof_dgvAvanzaCol")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function mof_dgvSigCol(ByRef wp_nCol As Long,
                                   ByRef wp_nrow As Long,
                                   ByVal wp_nTotCol As Long,
                                   ByVal wp_nColFin As Long,
                                   ByVal wp_nColIniGrl As Long,
                                   ByVal wp_nCntRow As Long,
                                   ByRef wp_CtrlDgv As DataGridView,
                                   ByRef wp_bAdiRow As Boolean) As Boolean
        Dim wl_i As Integer
        Dim wl_bFnc As Boolean
        wl_bFnc = True
        wp_bAdiRow = False
        Try
            wl_i = wp_nCol
            For wl_i = wp_nCol To wp_nTotCol - 1
                If wp_CtrlDgv.Rows(wp_nrow).Cells(wl_i).Visible = False Then
                    Continue For
                End If
                If wp_CtrlDgv.Rows(wp_nrow).Cells(wl_i).ReadOnly = True Then
                    Continue For
                End If
                If wl_i = wp_nTotCol - 1 Then
                    If wp_CtrlDgv.Rows(wp_nrow).Cells(wl_i).Visible = True Then
                        Exit For
                        'Continue For
                    End If
                End If
                Exit For
            Next
            wp_nCol = wl_i
            If wp_nCol > wp_nColFin Then
                If wp_nrow < wp_nCntRow - 1 Then
                    wp_nrow = wp_nrow + 1
                Else
                    wp_bAdiRow = True
                End If
                wp_nCol = wp_nColIniGrl
            End If
        Catch ex As Exception
            MsgBox("Error :  mof_dgvSigCol")
            MsgBox(ex.Message)
        End Try
        Return wl_bFnc
    End Function
    Public Function mof_dgvPrvCol(ByRef wp_nCol As Long,
                                   ByRef wp_nrow As Long,
                                   ByVal wp_nTotCol As Long,
                                   ByVal wp_nColFin As Long,
                                   ByVal wp_nColIniGrl As Long,
                                   ByVal wp_nCntRow As Long,
                                   ByRef wp_CtrlDgv As DataGridView,
                                   ByRef wp_nColKD As Long) As Boolean
        Dim wl_i As Integer
        Dim wl_bFnc As Boolean
        wl_bFnc = True
        Try
            wl_i = wp_nColKD - 1
            wp_nCol = wl_i
            For wl_i = wp_nCol To wp_nColIniGrl Step -1
                If wp_CtrlDgv.Rows(wp_nrow).Cells(wl_i).Visible = False Then
                    Continue For
                End If
                If wp_CtrlDgv.Rows(wp_nrow).Cells(wl_i).ReadOnly = True Then
                    Continue For
                End If
                If wl_i = wp_nTotCol - 1 Then
                    If wp_CtrlDgv.Rows(wp_nrow).Cells(wl_i).Visible = True Then
                        Continue For
                    End If
                End If
                Exit For
            Next
            wp_nCol = wl_i
            If wp_nCol < wp_nColIniGrl Then
                If wp_nrow > 0 Then
                    wp_nrow = wp_nrow - 1
                Else
                    wp_nrow = 0
                End If
                wp_nCol = wp_nColFin
            End If
        Catch ex As Exception
            MsgBox("Error :  mof_dgvPrvCol")
            MsgBox(ex.Message)
        End Try
        Return wl_bFnc
    End Function
#End Region

#Region "Cálculos"
    Public Sub mof_fOpe_11(ByRef wp_VlrCtrl As DataGridView,
                           ByVal wp_nRow As Integer)

        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(16).Value = .Rows(wp_nRow).Cells(9).Value * .Rows(wp_nRow).Cells(11).Value
            End With

        Catch ex As Exception
            MsgBox("Error : mof_fOpe_11")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mof_fOpe_16(ByRef wp_VlrCtrl As DataGridView,
                           ByVal wp_nRow As Integer)

        Try
            With wp_VlrCtrl
                .Rows(wp_nRow).Cells(16).Value = .Rows(wp_nRow).Cells(9).Value * .Rows(wp_nRow).Cells(11).Value
            End With

        Catch ex As Exception
            MsgBox("Error : mof_fOpe_16")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function mof_fCanReq(ByVal wp_nCanLotStn As Double,
                                ByVal wp_sUniMedStn As String,
                                ByVal wp_nCanUniStn As Double,
                                ByVal wp_sUniMedInv As String,
                                ByVal wp_nCanOdp As Double,
                                ByVal wp_sUniMedOdp As String,
                                ByVal wp_nCanCmt As Double,
                                ByVal wp_sUniMedCmt As String,
                                ByRef wp_nCanReq As Double,
                                ByVal wp_sUniMedReq As String) As Double


        Dim wl_nCanLotStn As Double = 0
        Dim wl_nCanUniStn As Double = 0
        Dim wl_nCanOdp As Double = 0
        Dim wl_nCanCmt As Double = 0
        Dim wl_nCanReq As Double = 0
        Dim wl_nCanOdpTmp As Double = 0
        If wp_nCanLotStn = 0 Then
            Return 0
        End If


        Try
            wl_nCanLotStn = wp_nCanLotStn
            wl_nCanUniStn = wp_nCanUniStn
            wl_nCanOdp = wp_nCanOdp
            wl_nCanCmt = wp_nCanCmt
            wl_nCanReq = 0
            If wp_sUniMedStn = "Kg" And wp_sUniMedOdp = "Kg" And wp_sUniMedCmt <> "U" Then
                If wl_nCanLotStn <> 0 Then
                    wl_nCanReq = wl_nCanCmt * wl_nCanOdp / wl_nCanLotStn
                End If
            End If
            If wp_sUniMedStn = "U" And wp_sUniMedOdp = "U" And wp_sUniMedCmt = "U" Then
                If wl_nCanLotStn <> 0 Then
                    wl_nCanReq = Math.Round(wl_nCanCmt * wl_nCanOdp / wl_nCanLotStn, 0)
                End If
            End If
            If wp_sUniMedStn = "Kg" And wp_sUniMedOdp = "Kg" And wp_sUniMedCmt = "U" Then
                If wl_nCanLotStn <> 0 Then
                    wl_nCanReq = Math.Round(wl_nCanCmt * wl_nCanOdp / wl_nCanLotStn, 0)
                End If
            End If
            If wp_sUniMedStn = "Kg" And wp_sUniMedOdp = "U" And wp_sUniMedCmt = "Kg" Then
                wl_nCanOdpTmp = 0
                If wl_nCanUniStn > 0 Then
                    wl_nCanOdpTmp = wl_nCanOdp * wl_nCanLotStn / wl_nCanUniStn
                    If wl_nCanLotStn <> 0 Then
                        wl_nCanReq = wl_nCanCmt * wl_nCanOdpTmp / wl_nCanLotStn
                    End If
                End If
            End If
            If wp_sUniMedStn = "Kg" And wp_sUniMedOdp = "U" And wp_sUniMedCmt = "U" Then
                wl_nCanOdpTmp = 0
                If wl_nCanUniStn > 0 Then
                    wl_nCanOdpTmp = wl_nCanOdp * wl_nCanLotStn / wl_nCanUniStn
                    If wl_nCanLotStn > 0 Then
                        wl_nCanReq = Math.Round(wl_nCanCmt * wl_nCanOdpTmp / wl_nCanLotStn, 0)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : mof_fCanReq")
            MsgBox(ex.Message)
        End Try
        wp_nCanReq = wl_nCanReq

        Return wp_nCanReq
    End Function
    Public Function mof_fDecASex(ByVal wp_nTieDec) As Double
        ' FUA : 2014.11.27
        ' Decimal a Sexadecimal
        Dim wl_nHH As Double
        Dim wl_nMM As Double
        Dim wl_nSS As Double
        Dim wl_nTieSex As Double
        Try
            wl_nHH = Int(wp_nTieDec)
            wl_nMM = (Int((wp_nTieDec - wl_nHH) * 100) / 100) * 60
            wl_nSS = (wp_nTieDec - wl_nHH - wl_nMM)
            wl_nTieSex = wl_nHH + wl_nMM * 0.6 + wl_nSS * 0.6
        Catch ex As Exception
            MsgBox("Error : mof_fDecASex")
            MsgBox(ex.Message)
        End Try
        Return wl_nTieSex

    End Function
    Public Function mof_fSexADec(ByVal wp_nTieSex) As Double
        ' FUA : 2014.11.27
        ' Sexadecimal a Decimal
        Dim wl_nHH As Double
        Dim wl_nMM As Double
        Dim wl_nSS As Double
        Dim wl_nTieDec As Double
        Try
            wl_nHH = Int(wp_nTieSex)
            wl_nMM = Int((wp_nTieSex - wl_nHH) * 100) / 100
            wl_nSS = (wp_nTieSex - wl_nHH - wl_nMM)
            wl_nTieDec = wl_nHH + wl_nMM / 0.6 + wl_nSS / 0.6
        Catch ex As Exception
            MsgBox("Error : mof_fSexADec")
            MsgBox(ex.Message)
        End Try
        Return wl_nTieDec
    End Function
#End Region
#Region "Cálculos GEMOV, GLMOV1"
    Public Sub mof_fGEMOVTotDoc(ByVal vp_nTotBas As Double,
                                ByVal vp_nPorDto As Double,
                                ByRef vp_nTotDto As Double,
                                ByVal vp_nTotGtoAdi As Double,
                                ByVal vp_nTotIvaCom As Double,
                                ByVal vp_nTotIvaVta As Double,
                                ByVal vp_nVlrRdd As Double,
                                ByRef vp_nTotDoc As Double)

        'Fec_Ult_Mod : 2014.04.22

        Try
            If vp_nPorDto > 0 Then
                vp_nTotDto = vp_nTotBas - (vp_nTotBas * vp_nPorDto) / 100
            End If
            vp_nTotDoc = vp_nTotBas + vp_nTotGtoAdi + vp_nTotIvaCom + vp_nTotIvaVta
            vp_nTotDoc = vp_nTotDoc - vp_nTotDto
            vp_nTotDoc = vp_nTotDoc + vp_nVlrRdd
        Catch ex As Exception
            MsgBox("Error: mof_fGEMOVTotDoc")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mof_fGLMOV1TotLin(ByVal vp_nCanItm As Double,
                                 ByRef vp_nPreUni As Double,
                                 ByRef vp_nVlrBas As Double,
                                 ByVal vp_nPorDto As Double,
                                 ByRef vp_nVlrDto As Double,
                                 ByRef vp_nPreDto As Double,
                                 ByRef vp_nVlrDtoLin As Double,
                                 ByVal vp_nPorIva As Double,
                                 ByRef vp_nVlrIva As Double,
                                 ByRef vp_nVlrIvaLin As Double,
                                 ByRef vp_nPreBru As Double,
                                 ByRef vp_nTasCamUsd As Double,
                                 ByRef vp_nPreUniUsd As Double,
                                 ByRef vp_nVlrBasUsd As Double,
                                 ByRef vp_nTotLin As Double)

        'Fec_Ult_Mod : 2014.09.12
        Try
            vp_nVlrBasUsd = vp_nCanItm * vp_nPreUniUsd

            vp_nVlrBas = vp_nCanItm * vp_nPreUni
            vp_nPreDto = vp_nPreUni - (vp_nPreUni * vp_nPorDto) / 100
            vp_nVlrDto = vp_nPreUni - vp_nPreDto
            vp_nVlrDtoLin = vp_nCanItm * vp_nVlrDto
            vp_nPreBru = vp_nPreDto + (vp_nPreDto * vp_nPorIva) / 100
            vp_nVlrIva = vp_nPreBru - vp_nPreDto
            vp_nVlrIvaLin = vp_nCanItm * vp_nVlrIva
            vp_nTotLin = vp_nVlrBas - vp_nVlrDtoLin
            vp_nTotLin = vp_nTotLin + vp_nVlrIvaLin

        Catch ex As Exception
            MsgBox("Error: mof_fGLMOV1TotLin")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mof_fGLMOV1SumLin(ByVal vp_nVlrBas As Double,
                                 ByVal vp_nVlrDtoLin As Double,
                                 ByVal vp_nVlrIvaLin As Double,
                                 ByVal vp_nTotLin As Double,
                                 ByRef vp_nTotBas As Double,
                                 ByRef vp_nTotDto As Double,
                                 ByRef vp_nTotIvaCom As Double,
                                 ByRef vp_nTotIvaVta As Double,
                                 ByRef vp_nTotDoc As Double,
                                 ByVal vp_sClsDoc As String)
        'Fec_Ult_Mod : 2014.04.22
        Try
            vp_nTotBas = vp_nTotBas + vp_nVlrBas
            vp_nTotDto = vp_nTotDto + vp_nVlrDtoLin
            If vp_sClsDoc = "DV" Then
                vp_nTotIvaVta = vp_nTotIvaVta + vp_nVlrIvaLin
            Else
                If vp_sClsDoc = "DC" Then
                    vp_nTotIvaCom = vp_nTotIvaCom + vp_nVlrIvaLin
                Else
                    vp_nTotIvaVta = 0
                    vp_nTotIvaCom = 0
                End If
            End If

            vp_nTotDoc = vp_nTotDoc + vp_nTotLin

        Catch ex As Exception
            MsgBox("Error: mof_fGLMOV1SumLin")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Cálculos IEREV, ILREV1"
    Public Sub mof_fILREV1TotLin(ByVal vp_nCanItm As Double,
                                 ByRef vp_nPreUni As Double,
                                 ByVal vp_nPreant As Double,
                                 ByRef vp_nDifPre As Double,
                                 ByRef vp_nTotLin As Double,
                                 ByVal vp_sTipRev As String)
        'Fec_Ult_Mod : 2015.07.10
        Dim vl_nPreUni As Double
        Dim vl_nDifPre As Double
        Dim vl_nTotLin As Double

        Try
            vl_nPreUni = vp_nPreUni
            vl_nDifPre = vp_nDifPre
            vl_nTotLin = 0
            If vp_sTipRev = "2" Then
                vl_nPreUni = vp_nPreant
                vl_nDifPre = 0
                If vp_nCanItm <> 0 Then
                    vl_nDifPre = vp_nTotLin / vp_nCanItm
                End If
                vl_nPreUni = vl_nPreUni + vl_nDifPre
                vl_nTotLin = vp_nTotLin
            End If
            vp_nPreUni = vl_nPreUni
            vp_nDifPre = vp_nPreUni - vp_nPreant
            If vp_sTipRev = "1" Then
                vp_nTotLin = vp_nDifPre * vp_nCanItm
            End If
        Catch ex As Exception
            MsgBox("Error: mof_fILREV1TotLin")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mof_fILREV1SumLin(ByVal vp_nPreUni As Double,
                                 ByVal vp_nPreAnt As Double,
                                 ByVal vp_nDifPre As Double,
                                 ByVal vp_nTotLin As Double,
                                 ByRef vp_nTotDoc As Double)
        'Fec_Ult_Mod : 2015.07.15

        Try
            vp_nTotDoc = vp_nTotDoc + vp_nTotLin
        Catch ex As Exception
            MsgBox("Error: mof_fILREV1SumLin")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Cálculos PLROP1"
    Public Sub mof_fCnvHorSys(ByVal wp_sHorSys As String,
                              ByRef wp_nHH As Long,
                              ByRef wp_nMM As Long)

        'Fec_Ult_Mod : 2019.03.07
        Try
            Dim wl_sHH As String
            Dim wl_sMM As String
            Dim wl_nPos As Long

            wl_nPos = InStr(1, wp_sHorSys, ":")
            wl_sHH = Mid(wp_sHorSys, 1, wl_nPos - 1)
            wl_sMM = Mid(wp_sHorSys, 4, wl_nPos + 1)
            wp_nHH = Val(wl_sHH)
            wp_nMM = Val(wl_sMM)
        Catch ex As Exception
            MsgBox("Error: mof_fcnvHorSys")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub mof_fSumHHMMXXX(ByVal wp_nHHIni As Long,
                            ByVal wp_nMMIni As Long,
                            ByVal wp_nHHFin As Long,
                            ByVal wp_nMMFin As Long,
                            ByRef wp_nHHCns As Long,
                            ByRef wp_nMMcns As Long,
                            ByRef wp_nTotCns As Long)

        'Fec_Ult_Mod : 2019.03.07
        Try
            Dim wl_nHH As Long
            Dim wl_nMM As Long

            wl_nHH = wp_nHHFin - wp_nHHIni
            wl_nMM = wp_nMMFin - wp_nMMIni
            If wl_nMM < 0 Then
                wl_nMM = wl_nMM + 60
                wl_nHH = wl_nHH - 1
            End If
            If wl_nHH < 0 Then
                wl_nMM = 0
                wl_nHH = 0
            End If
            wp_nMMcns = wl_nMM
            wp_nHHCns = wl_nHH
            wp_nTotCns = wl_nHH * 60 + wl_nMM


        Catch ex As Exception
            MsgBox("Error: mof_fSumHHMM")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mof_fPLRCI1TotLin(ByVal vp_nCanItm As Double,
                                 ByVal vp_nPreUni As Double,
                                 ByRef vp_nHHCns As Long,
                                 ByRef vp_nMMCns As Long,
                                 ByRef vp_nTieCns As Double,
                                 ByRef vp_nTotLin As Double,
                                 ByVal wp_sTipRegTie As String)

        'Fec_Ult_Mod : 2015.03.17

        'tipo de registro tiempo
        ' 1 HHII HHFF
        ' 2 HHCns
        ' 3 TotTie
        Try
            vp_nTieCns = vp_nHHCns * 60 + vp_nMMCns
            vp_nTotLin = vp_nPreUni * (Int(vp_nTieCns) * 60) + vp_nPreUni * ((vp_nTieCns - Int(vp_nTieCns)) * 60)


        Catch ex As Exception
            MsgBox("Error: mof_fPLRCI1TotLin")
            MsgBox(ex.Message)
        End Try

    End Sub


#End Region

#Region "Cálculos PLROP1"
    Public Sub mof_fPLROP1TotLin(ByVal vp_nCanItm As Double,
                                 ByVal vp_nPreUni As Double,
                                 ByRef vp_nHHIni As Long,
                                 ByRef vp_nMMIni As Long,
                                 ByVal vp_nHHFin As Long,
                                 ByRef vp_nMMFin As Long,
                                 ByRef vp_nHHCns As Long,
                                 ByRef vp_nMMCns As Long,
                                 ByRef vp_nTieCns As Double,
                                 ByRef vp_nTotLin As Double,
                                 ByVal wp_sTipRegTie As String)

        'Fec_Ult_Mod : 2015.03.06
        Dim vl_nHHIni As Long
        Dim vl_nMMIni As Long
        Dim vl_nHHFin As Long
        Dim vl_nMMFin As Long
        vl_nHHIni = vp_nHHIni
        vl_nMMIni = vp_nMMIni
        vl_nHHFin = vp_nHHFin
        vl_nMMFin = vp_nMMFin
        'tipo de registro tiempo
        ' 1 HHII HHFF
        ' 2 HHCns
        ' 3 TotTie
        Try
            If wp_sTipRegTie = "1" Then
                If vl_nHHIni <> 0 Or vl_nMMIni <> 0 Or vl_nHHFin <> 0 Or vl_nMMFin Then
                    If vl_nMMIni <> 0 Or vl_nMMIni <> 0 Then
                        If vl_nHHIni <> 0 Or vl_nMMIni <> 0 Then
                            If vl_nMMIni = 0 Then
                                vl_nHHIni = vl_nMMIni + 60
                                vl_nHHIni = vl_nHHIni - 1
                            End If
                        End If
                        If vl_nHHFin <> 0 Or vl_nMMFin <> 0 Then
                            If vl_nMMFin = 0 Then
                                vl_nMMFin = vl_nMMFin + 60
                                vl_nHHFin = vl_nHHFin - 1
                            End If
                            If vl_nMMFin < vl_nMMIni Then
                                vl_nMMFin = vl_nMMFin + 60
                                vl_nHHFin = vl_nHHFin - 1
                            End If
                        End If
                    End If
                End If
                vp_nHHCns = vl_nHHFin - vl_nHHIni
                vp_nMMCns = vl_nMMFin - vl_nMMIni
                vp_nTieCns = vp_nHHCns * 60 + vp_nMMCns
            End If
            If wp_sTipRegTie = "2" Then
                vp_nTieCns = vp_nHHCns * 60 + vp_nMMCns
            End If
            If wp_sTipRegTie = "3" Then
                vp_nTieCns = (Int(vp_nTieCns) * 60) + ((vp_nTieCns - Int(vp_nTieCns)) * 60)
            End If
            '   vp_nTotLin = vp_nPreUni * (Int(vp_nTieCns) * 60) + vp_nPreUni * ((vp_nTieCns - Int(vp_nTieCns)) * 60)
            vp_nTotLin = vp_nPreUni * vp_nTieCns


        Catch ex As Exception
            MsgBox("Error: mof_fPLROP1TotLin")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mof_fCalTie(ByRef wp_nHHIni As Long,
                           ByRef wp_nMMIni As Long,
                           ByRef wp_nHHFin As Long,
                           ByRef wp_nMMFin As Long,
                           ByRef wp_nHHCns As Long,
                           ByRef wp_nMMCns As Long,
                           ByRef wp_nTieCns As Double)
        'Fec_Ult_Mod : 2019.03.13
        Dim wl_nHHIni As Long
        Dim wl_nMMIni As Long
        Dim wl_nHHFin As Long
        Dim wl_nMMFin As Long
        Dim wl_nHHCns As Long
        Dim wl_nMMCns As Long
        Dim wl_nTieCns As Long
        wl_nHHIni = wp_nHHIni
        wl_nMMIni = wp_nMMIni
        wl_nHHFin = wp_nHHFin
        wl_nMMFin = wp_nMMFin
        wl_nHHCns = wp_nHHCns
        wl_nMMCns = wp_nMMCns
        'tipo de registro tiempo
        ' 1 HHII HHFF
        ' 2 HHCns
        ' 3 TotTie

        Try
            wl_nHHCns = wl_nHHFin - wl_nHHIni
            wl_nMMCns = wl_nMMFin - wl_nMMIni
            If wl_nMMCns < 0 Then
                wl_nMMCns = wl_nMMCns + 60
                wl_nHHCns = wl_nHHCns - 1
            End If

            If wl_nHHCns < 0 Then
                wl_nMMCns = 0
                wl_nHHCns = 0
            End If


            wp_nHHCns = wl_nHHCns
            wp_nMMCns = wl_nMMCns
            wl_nTieCns = wp_nHHCns * 60 + wp_nMMCns
            wp_nTieCns = wl_nTieCns

        Catch ex As Exception
            MsgBox("Error: mof_fCalTie")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region


#Region "Valor a Letras"
    Public Function mof_NroALetras(ByVal wp_sNroOri As String,
                                   ByVal wp_sCodMon As String) As String
        Dim wl_sNroOri As String
        Dim wl_sCodMon As String
        Dim wl_sNomMon As String
        Dim wl_sCad As String = ""
        Dim wl_sInt As String = ""
        Dim wl_sDec As String = ""
        Dim wl_bToF As Boolean
        '  Dim wl_nNro As Integer
        Dim wl_nX As Integer
        Dim wl_nY As Integer

        wl_bToF = False
        wl_sNroOri = wp_sNroOri
        wl_sCodMon = wp_sCodMon
        wl_sNomMon = "pesos "
        If wl_sCodMon = "USD" Then
            wl_sNomMon = "dólares "
        End If
        If wl_sCodMon = "EUR" Then
            wl_sNomMon = "euros "
        End If

        '*Número Negativo
        If Mid(wl_sNroOri, 1, 1) = "-" Then
            wl_sNroOri = Mid(wl_sNroOri, 2, wl_sNroOri.ToString.Length - 1).ToString
            wl_sCad = "menos "
        End If

        'Si tiene ceros a la izquierda*************
        For wl_nX = 1 To wl_sNroOri.ToString.Length
            If Mid(wl_sNroOri, 1, 1) = "0" Then
                wl_sNroOri = Trim(Mid(wl_sNroOri, 2, wl_sNroOri.ToString.Length).ToString)
                If Trim(wl_sNroOri.ToString.Length) = 0 Then wl_sCad = ""
            Else
                Exit For
            End If
        Next

        'Dividir parte Entera y decimal
        For wl_nY = 1 To Len(wl_sNroOri)
            If Mid(wl_sNroOri, wl_nY, 1) = "." Then
                wl_bToF = True
            Else
                If wl_bToF = False Then
                    wl_sInt = wl_sInt + Mid(wl_sNroOri, wl_nY, 1)
                Else
                    wl_sDec = wl_sDec + Mid(wl_sNroOri, wl_nY, 1)
                End If
            End If
        Next wl_nY

        If Len(wl_sDec) = 1 Then wl_sDec = wl_sDec & "0"

        '**********proceso de conversión***********
        wl_bToF = False

        If Val(wl_sNroOri) <= 999999999 Then
            For y = Len(wl_sInt) To 1 Step -1
                wl_sNroOri = Len(wl_sInt) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las wl_sCad para las centenas***********
                        Select Case Mid(wl_sInt, wl_sNroOri, 1)
                            Case "1"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" And Mid(wl_sInt, wl_sNroOri + 2, 1) = "0" Then
                                    wl_sCad = wl_sCad & "cien "
                                Else
                                    wl_sCad = wl_sCad & "ciento "
                                End If
                            Case "2"
                                wl_sCad = wl_sCad & "doscientos "
                            Case "3"
                                wl_sCad = wl_sCad & "trescientos "
                            Case "4"
                                wl_sCad = wl_sCad & "cuatrocientos "
                            Case "5"
                                wl_sCad = wl_sCad & "quinientos "
                            Case "6"
                                wl_sCad = wl_sCad & "seiscientos "
                            Case "7"
                                wl_sCad = wl_sCad & "setecientos "
                            Case "8"
                                wl_sCad = wl_sCad & "ochocientos "
                            Case "9"
                                wl_sCad = wl_sCad & "novecientos "
                        End Select
                    Case 2, 5, 8
                        'Asigna las wl_sCad para las wl_sDec
                        Select Case Mid(wl_sInt, wl_sNroOri, 1)
                            Case "1"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_bToF = True
                                    wl_sCad = wl_sCad & "diez "
                                End If
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "1" Then
                                    wl_bToF = True
                                    wl_sCad = wl_sCad & "once "
                                End If
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "2" Then
                                    wl_bToF = True
                                    wl_sCad = wl_sCad & "doce "
                                End If
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "3" Then
                                    wl_bToF = True
                                    wl_sCad = wl_sCad & "trece "
                                End If
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "4" Then
                                    wl_bToF = True
                                    wl_sCad = wl_sCad & "catorce "
                                End If
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "5" Then
                                    wl_bToF = True
                                    wl_sCad = wl_sCad & "quince "
                                End If
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) > "5" Then
                                    '     wl_bToF = True
                                    wl_bToF = False
                                    wl_sCad = wl_sCad & "dieci"
                                End If
                            Case "2"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "veinte "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "veinti"
                                    wl_bToF = False
                                End If
                            Case "3"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "treinta "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "treinta y "
                                    wl_bToF = False
                                End If
                            Case "4"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "cuarenta "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "cuarenta y "
                                    wl_bToF = False
                                End If
                            Case "5"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "cincuenta "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "cincuenta y "
                                    wl_bToF = False
                                End If
                            Case "6"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "sesenta "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "sesenta y "
                                    wl_bToF = False
                                End If
                            Case "7"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "setenta "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "setenta y "
                                    wl_bToF = False
                                End If
                            Case "8"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "ochenta "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "ochenta y "
                                    wl_bToF = False
                                End If
                            Case "9"
                                If Mid(wl_sInt, wl_sNroOri + 1, 1) = "0" Then
                                    wl_sCad = wl_sCad & "noventa "
                                    wl_bToF = True
                                Else
                                    wl_sCad = wl_sCad & "noventa y "
                                    wl_bToF = False
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las wl_sCad para las unidades*********
                        Select Case Mid(wl_sInt, wl_sNroOri, 1)
                            Case "1"
                                If wl_bToF = False Then
                                    If y = 1 Then
                                        wl_sCad = wl_sCad & "uno "
                                    Else
                                        wl_sCad = wl_sCad & "un "
                                    End If
                                End If
                            Case "2"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "dos "
                            Case "3"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "tres "
                            Case "4"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "cuatro "
                            Case "5"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "cinco "
                            Case "6"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "seis "
                            Case "7"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "siete "
                            Case "8"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "ocho "
                            Case "9"
                                If wl_bToF = False Then wl_sCad = wl_sCad & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(wl_sInt, 6, 1) <> "0" Or Mid(wl_sInt, 5, 1) <> "0" Or Mid(wl_sInt, 4, 1) <> "0" Or _
                    (Mid(wl_sInt, 6, 1) = "0" And Mid(wl_sInt, 5, 1) = "0" And Mid(wl_sInt, 4, 1) = "0" And _
                    Len(wl_sInt) <= 6) Then wl_sCad = wl_sCad & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(wl_sInt) = 7 And Mid(wl_sInt, 1, 1) = "1" Then
                        wl_sCad = wl_sCad & "millón "
                    Else
                        wl_sCad = wl_sCad & "millones "
                    End If
                End If
            Next y

            ' Une la parte entrera y la parte Decimal


            If wl_sDec <> "" Then
                mof_NroALetras = UCase(Mid(wl_sCad, 1, 1)) & Mid(wl_sCad, 2, wl_sCad.ToString.Length) & wl_sNomMon & " con " & wl_sDec & " centavos"
            Else
                mof_NroALetras = UCase(Mid(wl_sCad, 1, 1)) & Mid(wl_sCad, 2, wl_sCad.ToString.Length) & wl_sNomMon
            End If
        Else
            mof_NroALetras = ""
        End If

    End Function
#End Region

End Module

