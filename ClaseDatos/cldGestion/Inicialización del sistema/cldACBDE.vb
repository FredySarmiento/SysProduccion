Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Imports System.IO
Imports System.Collections


Public Class cldACBDE
    Inherits cldFunciones

    Dim wl_DT As New DataTable

    Dim wp_sCmdSql As String
    Dim wl_sNomBD As String


    Public Function cddtConsultar(ByRef vp_bCiaSel,
                                  ByRef wr_bEOF) As DataTable


        Try
            wl_sNomBD = ""
            wp_sCmdSql = "SELECT * FROM ACBDE T0"
            wp_sCmdSql += " where (bCiaSel = " & vp_bCiaSel
            wp_sCmdSql += ")"


            wl_DT = cdfdtConBDCnf(wp_sCmdSql,
                                  wr_bEOF)
            If wl_DT IsNot Nothing Then
                wl_sNomBD = wl_DT.Rows(0).Item(3)
                cdEscribeBD(wl_sNomBD)
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldACBDE.cddtConsultar")
            Throw ex
            Return Nothing
        End Try
    End Function

    Public Function cdEscribeBD(ByVal wl_sNomBD As String) As Boolean
        Dim oWriter As New StreamWriter("NomBD.txt")
        'Dim oWriter As New StreamWriter("\vbesko\NomBD.txt")
        Try
            oWriter.WriteLine(wl_sNomBD)
            oWriter.Close()
        Catch ex As Exception
            MsgBox("Error : cldACBDE.cdEscribeBD")
            Throw ex
        End Try
        Return Nothing
    End Function
End Class


