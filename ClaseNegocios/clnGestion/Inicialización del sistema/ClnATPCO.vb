Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATPCO
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATPCO
    Public Function cndtConATPCO(ByVal wp_eATPCO As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
           

            wl_DT = oAccDat.cddtConATPCO(wp_eATPCO,
                                            wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATPCO.cndtConATPCO")
        End Try
        Return wl_DT

    End Function
    Public Function cnCrearActATPCO(ByVal wp_eATPCO As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oAccDat.cdCrearActATPCO(wp_eATPCO,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATPCO.cnCrearActATPCO")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATPCO(ByVal wp_eATPCO As Object,
                                 ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATPCO(wp_eATPCO,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATPCO.cnEliATPCO")
        End Try
        Return wl_YesNo

    End Function
End Class
