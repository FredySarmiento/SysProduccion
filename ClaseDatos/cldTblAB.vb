Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
' Consulta de tablas AB - Modulo Administración
Public Class cldTblAB
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    'wl_YesNo = Yes,operacion correcta. No, operación incorrecta
    Dim wl_YesNo As Boolean
    Dim wl_sCmdSql As String

#Region "ABEOC"
    Public Function cddtConABEOC(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ABEOC WHERE bRegAct = True ORDER BY nNroOrd"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConABEOC ")
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region


    Public Function cddtConABEOP(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ABEOP WHERE bRegAci = True ORDER BY nNroOrd"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConABEOP ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConABODP(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ABODP ORDER BY bOdpSel,sCodDoc"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConABODP ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConABTIR(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ABTIR ORDER BY sTipRev"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConABTIR ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConACUNI(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ACUNI ORDER BY sCodUni"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConACUNI")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConAPFRM(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from APFRM ORDER BY sNomFrm"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConAPFRM")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConAPEND(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            'wl_sCmdSql = "select * from APEND WHERE bRegAct = true ORDER BY sCodDoc,sCodSer "
            wl_sCmdSql = "select * from APEND  ORDER BY sCodDoc,sCodSer "
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConAPEND ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATALM(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATALM T0 "
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodAlm"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATALM ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATCCO(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATCCO ORDER BY sCodCco"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATCCO ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATCIF(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATCIF T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodCIF"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATCIF ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATCTR(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATCTR T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodctr"
            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATCTR")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATGRI(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATGRI T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodGrp"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATGRI")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATOPE(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""
            wl_sCmdSql = "SELECT * from ATOPE T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodOpe"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATOPE ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATPCO(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""
            wl_sCmdSql = "SELECT * from ATPCO T0 "
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodPdo"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATPCO ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATPOP(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATPOP T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodTer"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATPOP ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATTIN(ByVal wp_eATTIN As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""
            With wp_eATTIN
                wl_sCmdSql = "SELECT * from ATTIN T0 "
                wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
                If wp_eATTIN.sTipMov <> " " Then
                    wl_sCmdSql += " AND T0.sTipMov = '" & .sTipMov & "'"
                End If
                wl_sCmdSql += " ORDER BY T0.sNomTra"
            End With

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATTIN ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATUSR(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATUSR T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodUsr"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATUSR ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATVEN(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATVen T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodVen"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATVEN ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConATZON(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_sCmdSql = ""

            wl_sCmdSql = "select * from ATZON T0"
            wl_sCmdSql += " WHERE T0.bRegAci = TRUE"
            wl_sCmdSql += " ORDER BY T0.sCodZon"

            wl_DT = cdfdtConsultar(wl_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldTblAB.cddtConATZON ")
            Return Nothing
            Throw ex
        End Try
    End Function
End Class
