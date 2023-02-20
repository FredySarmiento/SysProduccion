Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldFunciones
    Inherits ClaseConexion.clcConexion

    Dim oCnn As clcConexion
    Dim oCmdSql As OleDbCommand

    Dim wl_DA As OleDbDataAdapter
    Dim wl_DT As New DataTable
    Dim wl_DT1 As New DataTable
    Dim wl_DS As New DataSet
    Dim wl_nCntReg As Integer
    Dim oTransaccion As OleDbTransaction
    Dim wl_DR As OleDbDataReader
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim vl_sNomBD As String = " "
    Dim wl_nId As Long
#Region "OleDb"
    Public Function cdfEjecutarCmdSql(ByVal vp_sCmdSql) As Boolean
        oCmdSql = New Data.OleDb.OleDbCommand
        wl_YesNo = False
        Try
            Dim oCnn As clcConexion
            oCnn = New clcConexion
            oCnn.ccConectarBD()
            oCmdSql.Connection = oCnn.oConexion
            oTransaccion = oCnn.oConexion.BeginTransaction

            oCmdSql.CommandType = CommandType.Text
            oCmdSql.CommandText = vp_sCmdSql
            oCmdSql.Transaction = oTransaccion

            wl_nCntReg = oCmdSql.ExecuteNonQuery
            oTransaccion.Commit()
            ccDesconectarBD()
            oCnn.ccClose()

            wl_YesNo = True
        Catch ex As Exception
            oTransaccion.Rollback()
            wl_YesNo = False
            '2018-07-13
            MsgBox("Error en Función : cldFunciones.cdfEjecutarCmdSql : ¡¡¡ " & ex.Message & " !!!")
            ' MsgBox(ex.Message)
            Return wl_YesNo
            'Fin 2018-07-13
        Finally
            ccDesconectarBD()
        End Try
        Return wl_YesNo
    End Function
    Public Function cdfDevuelveID(ByVal vp_sCmdSql) As Long
        oCmdSql = New Data.OleDb.OleDbCommand
        wl_YesNo = False
        wl_nId = 0
        Try
            Dim oCnn As ClcConexion
            oCnn = New ClcConexion
            oCnn.CcConectarBD()
            oCmdSql.Connection = oCnn.oConexion
            oTransaccion = oCnn.oConexion.BeginTransaction

            oCmdSql.CommandType = CommandType.Text
            oCmdSql.CommandText = vp_sCmdSql
            oCmdSql.Transaction = oTransaccion

            wl_nId = oCmdSql.ExecuteScalar
            oTransaccion.Commit()
            CcDesconectarBD()
            oCnn.CcClose()

            wl_YesNo = True
        Catch ex As Exception
            oTransaccion.Rollback()
            wl_nId = 0
            wl_YesNo = False
            'Ini 2022-10-24
            MsgBox("Error en Función : cldFunciones.cdfDevuelveID : ¡¡¡ " & ex.Message & " !!!")
            ' MsgBox(ex.Message)
            Return wl_nId
            'Fin 2022-10-24
        Finally
            CcDesconectarBD()
        End Try
        Return wl_nId
    End Function
    Public Function cdfdtConsultar(ByVal vp_sCmdSql,
                                   ByRef wr_bEOF) As DataTable
        'Fec_Ult_Mod: 2014.05.05
        oCmdSql = New Data.OleDb.OleDbCommand
        Try
            oCnn = New clcConexion
            oCnn.ccConectarBD()
            oCmdSql.Connection = oCnn.oConexion
            wl_DA = New OleDbDataAdapter(vp_sCmdSql, oCmdSql.Connection)
            wl_DT = New DataTable
            wl_nCntReg = 0

            wl_DA.Fill(wl_DT)
            wl_nCntReg = wl_DT.Rows.Count
            ' wl_DT.


            If wl_nCntReg = 0 Then
                wr_bEOF = True
            Else
                wr_bEOF = False
            End If
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : cldFunciones.cdfdtConsultar")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ccDesconectarBD()
        End Try
    End Function
    Public Function cdfdtConBDCnf(ByVal vp_sCmdSql,
                                  ByRef wr_bEOF) As DataTable
        'Fec_Ult_Mod: 2014.05.06
        oCmdSql = New Data.OleDb.OleDbCommand
        Try
            oCnn = New clcConexion
            oCnn.ccConectarBDConfig()
            oCmdSql.Connection = oCnn.oConexion
            wl_DA = New OleDbDataAdapter(vp_sCmdSql, oCmdSql.Connection)
            wl_DT = New DataTable
            wl_nCntReg = 0
            wl_DA.Fill(wl_DT)
            wl_nCntReg = wl_DT.Rows.Count
            If wl_nCntReg = 0 Then
                wr_bEOF = True
            Else
                wr_bEOF = False
            End If
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : cldFunciones.cdfdtConBDCnf")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ccDesconectarBD()
        End Try
    End Function
    Public Function cdfdsConsultar(ByVal vp_sCmdSql, ByRef wr_bEOF) As DataSet
        oCmdSql = New Data.OleDb.OleDbCommand
        Dim wl_DS As New DataSet
        Try
            oCnn = New clcConexion
            oCnn.ccConectarBD()
            oCmdSql.Connection = oCnn.oConexion
            wl_DA = New OleDbDataAdapter(vp_sCmdSql, oCmdSql.Connection)
            wl_DA.Fill(wl_DS, "Tabla")
            wl_nCntReg = wl_DS.Tables("Tabla").Rows.Count
            If wl_nCntReg = 0 Then
                wr_bEOF = True
            Else
                wr_bEOF = False
            End If
            Return wl_DS
        Catch ex As Exception
            MsgBox("Error : cldFunciones.cdfdsConsultar")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ccDesconectarBD()
        End Try
    End Function
    Public Function cdfdrsConsultar(ByVal vp_sCmdSql) As DataSet
        oCmdSql = New Data.OleDb.OleDbCommand

        Dim wl_DT As New Data.DataTable("Tabla")

        Try
            oCnn = New clcConexion
            oCnn.ccConectarBD()
            oCmdSql.Connection = oCnn.oConexion
            wl_DA = New OleDbDataAdapter(vp_sCmdSql, oCmdSql.Connection)
            wl_DR = oCmdSql.ExecuteReader
            If wl_DR.HasRows Then
                While wl_DR.Read
                    For intIndex As Integer = 0 To wl_DR.FieldCount - 1
                        Console.WriteLine(wl_DR.Item(intIndex).ToString & ",")
                    Next
                End While
            End If

            Return Nothing
        Catch ex As Exception
            MsgBox("Error : cldFunciones.cdfdrsConsultar")
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ccDesconectarBD()
        End Try
    End Function

#End Region

#Region "Funciones de cálculo"
    Public Function cdf_ActSdoInv(ByVal wr_eGLMOV1 As Object) As Boolean
        Dim cldIEDMI As New cldIEDMI

        Dim vl_nId As Long
        Dim vl_nCanItm As Double
        Dim vl_nNroDoc As Long
        Dim vl_nPreuni As Double
        Dim vl_nTotLin As Double
        Dim vl_sCodAlm As String
        Dim vl_sCodDoc As String
        Dim vl_sCodSer As String
        Dim vl_sCodItm As String
        Dim vl_sTipMov As String
        Dim wl_nSdoAlm As Double
        Dim wl_nSdoInv As Double
        Dim wl_nTVlrTotGrl As Double
        Dim wl_nPreuni As Double
        Dim wl_nCosItm As Double
        Dim wl_nPreAnt As Double
        Dim wl_nVlrTot As Double
        Dim wl_nSdoIni As Double
        Dim wl_nSdoIniAno As Double
        Dim wl_nCanResODP As Double
        Dim wl_nSdoFinDis As Double
        Dim wl_nCanPedODC As Double
        Dim wl_nSdoFinPry As Double
        Dim wl_nSdoIniAlm As Double
        Dim wl_nSdoIniAnoAlm As Double
        Dim wl_nCanResODPAlm As Double
        Dim wl_nSdoFinDisAlm As Double

        Dim wl_nPrePro As Double
        Dim wr_bEOF As Boolean
        Dim wr_bEOF1 As Boolean
        Dim vl_bIndCan As Boolean
        Dim vl_bIndCos As Boolean
        Dim vl_bIndCanRes As Boolean
        Dim vl_bIndCanPry As Boolean


        Try
            wl_YesNo = False
            With wr_eGLMOV1
                vl_nId = .nId
                vl_sCodDoc = .sCodDoc
                vl_nNroDoc = .nNroDoc
                vl_sCodSer = .sCodSer
                vl_sTipMov = .sTipmov
                vl_sCodAlm = .sCodAlm
                vl_sCodItm = .sCodItm
                vl_nCanItm = .nCanItm
                vl_nPreuni = .nPreuni
                vl_nTotLin = .nTotLin
                vl_bIndCan = .bIndCan
                vl_bIndCos = .bIndCos
                vl_bIndCanRes = .bIndCanRes
                vl_bIndCanPry = .bIndCanPry

            End With
            wl_nSdoInv = 0
            wl_nSdoAlm = 0
            wl_nVlrTot = 0
            wl_nPreuni = 0
            wl_nSdoIni = 0
            wl_nSdoIniAno = 0
            wl_nCanResODP = 0
            wl_nSdoFinDis = 0
            wl_nCanPedODC = 0
            wl_nSdoFinPry = 0
            wl_nCanResODPAlm = 0
            wl_nSdoFinDisAlm = 0


            ' If vl_sCodDoc = "SDC" Then
            'MsgBox("AquiVa")
            'End If

            If vl_sTipMov = " " Then
                Return wl_YesNo
                Exit Function
            End If
            If vl_bIndCan = False Then
                Return wl_YesNo
                Exit Function
            End If

            wl_DT = cldIEDMI.cddtConSdoILMDI1(vl_sCodAlm,
                                              vl_sCodItm,
                                              wr_bEOF)


            wl_DT1 = cldIEDMI.cddtConSdoIEDMI(vl_sCodItm,
                                              wr_bEOF1)

            If Not wr_bEOF1 Then
                wl_nPrePro = wl_DT.Rows(0).Item("nCosItm")
                wl_nTVlrTotGrl = wl_DT.Rows(0).Item("nCosItm") * wl_DT.Rows(0).Item("nSdoInv")
                wl_nCanResODP = wl_DT.Rows(0).Item("nCanResODP")
                wl_nCanPedODC = wl_DT.Rows(0).Item("nCanPedODC")
            End If

            If Not wr_bEOF Then
                wl_nSdoInv = wl_DT.Rows(0).Item("nSdoInv")
                wl_nSdoAlm = wl_DT.Rows(0).Item("nSdoAlm")
                '   wl_nPreuni = wl_DT.Rows(0).Item("nPreUni")
                '   wl_nPreAnt = wl_DT.Rows(0).Item("nPreUni")
                wl_nPreuni = wl_DT.Rows(0).Item("nCosItm")
                wl_nPreAnt = wl_DT.Rows(0).Item("nCosItm")
                wl_nCanResODPAlm = wl_DT.Rows(0).Item("nCanResODPAlm")
                wl_nSdoFinDisAlm = wl_DT.Rows(0).Item("nSdoFinDisAlm")

                wl_nVlrTot = wl_DT.Rows(0).Item("nVlrTot")

                If vl_bIndCos = False Then
                    vl_nPreuni = 0
                End If
                '                If vl_sCodDoc = "EDM" Or
                If vl_sCodDoc = "EIT" Or
                    vl_sCodDoc = "EDV" Then
                    vl_nPreuni = wl_nPreAnt
                    vl_nPreuni = wl_nPrePro

                End If



                If vl_sTipMov = "E" Then
                    wl_nSdoAlm = wl_nSdoAlm + vl_nCanItm
                    wl_nSdoInv = wl_nSdoInv + vl_nCanItm

                    wl_nTVlrTotGrl = wl_nTVlrTotGrl + (vl_nPreuni * vl_nCanItm)

                    If wl_nSdoInv > 0 Then
                        wl_nPrePro = wl_nTVlrTotGrl / wl_nSdoInv
                    End If
                    '  wl_nVlrTot = wl_nVlrTot + (wl_nPrePro * vl_nCanItm)
                End If

                If vl_sTipMov = "S" Then
                    'Activar de nuevo
                    If vl_nCanItm > wl_nSdoAlm Then
                        '  MsgBox(vl_sCodDoc & " " & vl_nNroDoc.ToString & " " & vl_sCodItm & " tiene saldo negativo")
                        wp_sCmdSql = "INSERT INTO TmpErrMovInv "
                        wp_sCmdSql += "(sCodDoc, "
                        wp_sCmdSql += "nNroDoc, "
                        wp_sCmdSql += "sTipMov, "
                        wp_sCmdSql += "sCodItm, "
                        wp_sCmdSql += "nCanItm, "
                        wp_sCmdSql += "nPreUni, "
                        wp_sCmdSql += "nSdoCanLin "
                        wp_sCmdSql += ")"
                        wp_sCmdSql += " values "
                        wp_sCmdSql += "('" & vl_sCodDoc & "', "
                        wp_sCmdSql += vl_nNroDoc & ", "
                        wp_sCmdSql += "'" & vl_sTipMov & "', "
                        wp_sCmdSql += "'" & vl_sCodItm & "', "
                        wp_sCmdSql += vl_nCanItm & " ,"
                        wp_sCmdSql += vl_nPreuni & " ,"
                        wp_sCmdSql += wl_nSdoAlm & ")"

                        wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                    End If

                    If vl_sCodDoc <> "SDC" Then
                        vl_nPreuni = wl_nPreAnt
                        vl_nPreuni = wl_nPrePro
                    End If


                    If vl_bIndCos = False Then
                        vl_nPreuni = 0
                    End If
                    wl_nSdoAlm = wl_nSdoAlm - vl_nCanItm
                    wl_nSdoInv = wl_nSdoInv - vl_nCanItm
                    '  wl_nVlrTot = wl_nVlrTot - (vl_nPreuni * vl_nCanItm)
                    wl_nTVlrTotGrl = wl_nTVlrTotGrl - (vl_nPreuni * vl_nCanItm)
                End If
                If wl_nSdoInv > 0 Then
                    wl_nPrePro = wl_nTVlrTotGrl / wl_nSdoInv
                End If

                ' If wl_nSdoAlm > 1 Then
                ' wl_nPreuni = wl_nVlrTot / wl_nSdoAlm
                ' Else
                '    If wl_nSdoAlm > 0 Then
                'wl_nPreuni = wl_nVlrTot / wl_nSdoAlm
                'End If
                ' End If
                wl_nPreuni = wl_nPrePro
                wl_nCosItm = wl_nPreuni
                wl_nVlrTot = wl_nSdoAlm * wl_nCosItm
                wl_nSdoFinDis = wl_nSdoInv - wl_nCanResODP
                wl_nSdoFinPry = wl_nSdoInv - wl_nCanResODP + wl_nCanPedODC

                wl_nSdoFinDisAlm = wl_nSdoAlm - wl_nCanResODPAlm

                wp_sCmdSql = "Update ILDMI1 SET "
                wp_sCmdSql += "nSdoAlm     = " & wl_nSdoAlm & " , "
                wp_sCmdSql += "nVlrTot     = " & wl_nVlrTot & " , "
                wp_sCmdSql += "nSdoFinDisAlm = " & wl_nSdoFinDisAlm & " ,"
                ' wp_sCmdSql += "nPreUni     = " & wl_nPreuni
                wp_sCmdSql += "nPreUni     = " & wl_nCosItm
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & vl_sCodItm & "' and "
                wp_sCmdSql += " sCodAlm     = '" & vl_sCodAlm & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

                wp_sCmdSql = "Update IEDMI SET "
                wp_sCmdSql += "nCosItm     = " & wl_nCosItm & " ,"
                wp_sCmdSql += "nSdoInv     = " & wl_nSdoInv & " ,"
                'wp_sCmdSql += "nSdoIni     = " & wl_nSdoIni & " ,"
                'wp_sCmdSql += "nSdoIniAno  = " & wl_nSdoIniAno & " ,"
                'wp_sCmdSql += "nCanResODP  = " & wl_nCanResODP & " ,"
                wp_sCmdSql += "nSdoFinDis  = " & wl_nSdoFinDis & " ,"
                wp_sCmdSql += "nCanPedODC  = " & wl_nCanPedODC & " ,"
                wp_sCmdSql += "nSdoFinPry  = " & wl_nSdoFinPry
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & vl_sCodItm & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


                'If vl_sCodDoc = "EDM" Or
                If vl_sCodDoc = "EDV" Or
                   vl_sCodDoc = "EIT" Or
                   vl_sCodDoc = "SAL" Or
                   vl_sCodDoc = "SDM" Or
                   vl_sCodDoc = "SDP" Or
                   vl_sCodDoc = "SDV" Or
                   vl_sCodDoc = "SIT" Then
                    wp_sCmdSql = "Update ILMOV1 SET "
                    wp_sCmdSql += "nPreUni     = " & wl_nPreuni & " , "
                    wp_sCmdSql += "nPreDto     = " & wl_nPreuni & " , "
                    wp_sCmdSql += "nPreBru     = " & wl_nPreuni & " , "
                    wp_sCmdSql += "nVlrBas     = " & wl_nPreuni & " * nCanItm, "
                    wp_sCmdSql += "nTotLin     = " & wl_nPreuni & " * nCanItm "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodDoc    = '" & vl_sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "nNroDoc    = " & vl_nNroDoc
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "sCodItm    = '" & vl_sCodItm & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "nId    = " & vl_nId
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

            Else
                MsgBox(vl_sCodItm & " " & vl_sCodAlm & "  No Existe")
            End If
        Catch ex As Exception
            MsgBox("Error: cldFunciones.cdf_ActSdoInv")
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cdf_RevSdoInv(ByVal wr_eILREV1 As Object) As Boolean
        Dim cldIEDMI As New cldIEDMI

        Dim vl_nCanItm As Double
        Dim vl_nNroDoc As Long
        Dim vl_nPreuni As Double
        Dim vl_nPreAnt As Double
        Dim vl_nDifPre As Double
        Dim vl_nTotLin As Double
        Dim vl_sCodAlm As String
        Dim vl_sCodDoc As String
        Dim vl_sCodItm As String
        Dim vl_sTipRev As String
        Dim wl_nSdoAlm As Double
        Dim wl_nSdoInv As Double
        Dim wl_nPreuni As Double
        Dim wl_nCosItm As Double
        Dim wl_nVlrTot As Double
        Dim wl_nUltPreEnt As Double


        Dim wr_bEOF As Boolean
        Dim vl_bIndCan As Boolean
        Dim vl_bIndCos As Boolean

        Try
            wl_YesNo = False
            With wr_eILREV1
                vl_sCodDoc = .sCodDoc
                vl_nNroDoc = .nNroDoc
                vl_sTipRev = .sTipRev
                vl_sCodItm = .sCodItm
                vl_sCodAlm = .sCodAlm
                vl_nCanItm = .nCanItm
                vl_nPreuni = .nPreuni
                vl_nPreAnt = .nPreAnt
                vl_nDifPre = .nDifPre
                vl_nTotLin = .nTotLin
                wl_nUltPreEnt = .nPreuni
                vl_bIndCan = .bIndCan
                vl_bIndCos = .bIndCos
            End With
            wl_nSdoInv = 0
            wl_nSdoAlm = 0
            wl_nVlrTot = 0
            wl_nPreuni = 0
            If vl_sTipRev = " " Then
                Return wl_YesNo
                Exit Function
            End If
            If vl_bIndCan = False Then
                Return wl_YesNo
                Exit Function
            End If

            wl_DT = cldIEDMI.cddtConSdoILMDI1(vl_sCodAlm,
                                              vl_sCodItm,
                                               wr_bEOF)
            If Not wr_bEOF Then
                wl_nSdoInv = wl_DT.Rows(0).Item("nSdoInv")
                wl_nSdoAlm = wl_DT.Rows(0).Item("nSdoAlm")
                wl_nPreuni = wl_DT.Rows(0).Item("nPreUni")
                wl_nVlrTot = wl_DT.Rows(0).Item("nVlrTot")
                '  wl_nUltPreEnt = wl_DT.Rows(0).Item("T1.nUltPreEnt")


                If vl_bIndCos = False Then
                    vl_nPreuni = 0
                End If
                wl_nVlrTot = wl_nVlrTot + vl_nTotLin
                If wl_nSdoAlm <> 0 Then
                    wl_nPreuni = wl_nVlrTot / wl_nSdoAlm
                End If


                wl_nCosItm = wl_nPreuni
                wp_sCmdSql = "Update ILDMI1 SET "
                wp_sCmdSql += "nSdoAlm     = " & wl_nSdoAlm & " , "
                wp_sCmdSql += "nVlrTot     = " & wl_nVlrTot & " , "
                wp_sCmdSql += "nPreUni     = " & wl_nPreuni & " , "
                wp_sCmdSql += "nUltPreEnt     = " & wl_nUltPreEnt
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & vl_sCodItm & "' and "
                wp_sCmdSql += " sCodAlm     = '" & vl_sCodAlm & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

                wp_sCmdSql = "Update IEDMI SET "
                wp_sCmdSql += "nCosItm     = " & wl_nCosItm & " ,"
                wp_sCmdSql += "nSdoInv     = " & wl_nSdoInv & " ,"
                wp_sCmdSql += "nUltPreEnt     = " & wl_nUltPreEnt
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & vl_sCodItm & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If
        Catch ex As Exception
            MsgBox("Error: cldFunciones.cdf_ActSdoInv")
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cdf_CalcPromedio() As Boolean
        Return wl_YesNo
    End Function
#End Region

#Region "Funciones de fecha"
    Public Function cdf_dDMY_MDY(ByVal wp_dFecMDA As Date) As String
        Try
            Dim wl_sDDIni As String
            Dim wl_sMMMIni As String
            Dim wl_nMMIni As Integer
            Dim wl_sYYYYIni As String
            Dim wl_sFecDMA As String

            wl_sDDIni = DatePart(DateInterval.Day, wp_dFecMDA)
            wl_nMMIni = DatePart(DateInterval.Month, wp_dFecMDA)
            wl_sYYYYIni = DatePart(DateInterval.Year, wp_dFecMDA)
            wl_sMMMIni = MonthName(wl_nMMIni, True)

            Select Case wl_nMMIni
                Case 1
                    wl_sMMMIni = "jan"
                Case 2
                    wl_sMMMIni = "feb"
                Case 3
                    wl_sMMMIni = "mar"
                Case 4
                    wl_sMMMIni = "apr"
                Case 5
                    wl_sMMMIni = "may"
                Case 6
                    wl_sMMMIni = "jun"
                Case 7
                    wl_sMMMIni = "jul"
                Case 8
                    wl_sMMMIni = "aug"
                Case 9
                    wl_sMMMIni = "sep"
                Case 10
                    wl_sMMMIni = "oct"
                Case 11
                    wl_sMMMIni = "nov"
                Case 12
                    wl_sMMMIni = "dec"
            End Select
            wl_sFecDMA = wl_sDDIni & "-" & wl_sMMMIni & "-" & wl_sYYYYIni
            Return wl_sFecDMA
        Catch ex As Exception
            MsgBox("Error: cldFunciones.cdf_dDMY_MDY")
            MsgBox(ex.Message)
            Return ""
        End Try
    End Function
#End Region
#Region "Funciones de texto"
    Public Function cdf_VdaCarEsp(ByVal wr_sCad As String) As Boolean
        Return True

    End Function
#End Region

End Class
