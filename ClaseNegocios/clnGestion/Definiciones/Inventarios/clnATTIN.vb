Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATTIN
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATTIN
    Public Function cndtConATTIN(ByVal wp_eATTIN As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldATTIN

            wl_DT = oAccDat.cddtConATTIN(wp_eATTIN,
                                            wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATTIN.cndtConATTIN")
        End Try
        Return wl_DT

    End Function
    Public Function cnCrearActATTIN(ByVal wp_eATTIN As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oAccDat.cdCrearActATTIN(wp_eATTIN,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATclnATTINALM.cnCrearActATTIN")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATTIN(ByVal wp_eATTIN As Object,
                                 ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATTIN(wp_eATTIN,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATTIN.cnEliATTIN")
        End Try
        Return wl_YesNo

    End Function
End Class
