Imports System.Data
Imports ClaseDatos
Public Class clnFunciones

    Dim wl_YesNo As Boolean = False
    Dim oFnc As New ClaseDatos.cldFunciones

#Region "Funciones de cálculo"
    Public Function cnf_ActSdoInv(ByVal wp_eGLMOV1 As Object) As Boolean

        Try
            wl_YesNo = False
            wl_YesNo = oFnc.cdf_ActSdoInv(wp_eGLMOV1)

        Catch ex As Exception
            MsgBox("Error: clnFunciones.cnf_ActSdoInv")
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cdf_CalcPromedio() As Boolean
        Return wl_YesNo
    End Function
#End Region
End Class
