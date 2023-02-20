Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATTIN
    Inherits cldConTbl
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim wp_sNomTbl As String
    Dim wp_sNomCmp As String
    Dim wp_sDatCmp As String
    Dim wp_sTipCmp As String
    Dim wp_sCmpOrd As String
    Dim wp_sTipOrd As String
    Public Function cddtConATTIN(ByVal wp_eATTIN As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            With wp_eATTIN

                wp_sCmdSql = "SELECT * FROM ATTIN T0 "
                If .sCodTra <> "" Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "T0.sCodTra = "
                    wp_sCmdSql += "'" & .sCodTra & "'"
                End If
                wp_sCmdSql += " ORDER BY T0.sCodTra "

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldATTIN.cddtConATTIN")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActATTIN(ByVal wp_eATTIN As Object,
                                   ByRef wr_bEOF As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try

            With wp_eATTIN
                wl_YesNo = True
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into ATTIN "
                    wp_sCmdSql += "(sCodTra) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTra & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update ATTIN "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomTra     = """ & .sNomTra & """, "
                    wp_sCmdSql += "sTipMov     = '" & .sTipMov & "', "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "sCodTra = '" & .sCodTra & "' "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: cldATTIN.cdCrearActualizar ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATTIN(ByVal wp_eATTIN As Object,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATTIN
                wp_sCmdSql = "Delete * from  ATTIN "
                wp_sCmdSql += "where sCodTra = '" & .sCodTra & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATTIN.cdEliATTIN")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class
