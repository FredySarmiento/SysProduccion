Imports System.Data
Imports ClaseDatos
Public Class clnTblAB
    Dim wl_DT As New DataTable
    Dim oAccDat As New ClaseDatos.cldTblAB
    Public Function cndtCrgABEOC(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConABEOC(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgABEOC ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgABEOP(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConABEOP(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgABEOP ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgABODP(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConABODP(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgABODP ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgABTIR(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConABTIR(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgABTIR ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgACUNI(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConACUNI(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgACUNI")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgAPFRM(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConAPFRM(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgAPFRM")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgAPEND(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConAPEND(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgAPEND ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATALM(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATALM(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATALM ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATCCO(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATCCO(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATCTR ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATCIF(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATCIF(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATCIF ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATCTR(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATCTR(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATCTR ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATGRI(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATGRI(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATGRI")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATOPE(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATOPE(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATOPE ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATPCO(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATPCO(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATPCO ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATPOP(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATPOP(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATPOP ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATTIN(ByVal wp_eATTIN As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATTIN(wp_eATTIN,
                                         wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATTIN ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATUSR(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATUSR(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATUSR ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATVEN(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATVEN(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATVEN ")
            Throw ex
        End Try
    End Function
    Public Function cndtCrgATZON(ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATZON(wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox("Error en: cndtCrgATZON ")
            Throw ex
        End Try
    End Function
End Class
