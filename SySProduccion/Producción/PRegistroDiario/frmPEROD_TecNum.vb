Public Class frmPEROD_TecNum
#Region "001 Inicia. wg - vg Definición del variables públicas"
    ' wg - Variables de trabajo globales/públicas parámetro
    ' vp - Variables que corresponde a campos de la BD globles/públicas- parámeto
    Public wg_nNroEnt As String

#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmPEROD_TecNum_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MsgBox("Error : frmPEROD_TecNum_Load")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            wg_nNroEnt = 0
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        Try
            wg_nNroEnt = txtnNroEnt.Text
            If wg_nNroEnt = "" Then
                wg_nNroEnt = 0
            End If

            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiar.Click
        Try
            wg_nNroEnt = ""
            txtnNroEnt.Text = ""
        Catch ex As Exception
            MsgBox("Error :  cmdLimpiar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
   
    Private Sub cmdNro0_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro0.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "0"
        Catch ex As Exception
            MsgBox("Error :  cmdNro0_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro1_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro1.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "1"
        Catch ex As Exception
            MsgBox("Error :  cmdNro1_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro2_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro2.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "2"
        Catch ex As Exception
            MsgBox("Error :  cmdNro2_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro3_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro3.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "3"
        Catch ex As Exception
            MsgBox("Error :  cmdNro3_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro4_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro4.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "4"
        Catch ex As Exception
            MsgBox("Error :  cmdNro4_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro5_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro5.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "5"
        Catch ex As Exception
            MsgBox("Error :  cmdNro5_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro6_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro6.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "6"
        Catch ex As Exception
            MsgBox("Error :  cmdNro6_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro7_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro7.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "7"
        Catch ex As Exception
            MsgBox("Error :  cmdNro7_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cndNro8_Click(sender As System.Object, e As System.EventArgs) Handles cndNro8.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "8"
        Catch ex As Exception
            MsgBox("Error :  cmdNro8_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNro9_Click(sender As System.Object, e As System.EventArgs) Handles cmdNro9.Click
        Try
            txtnNroEnt.Text = txtnNroEnt.Text & "9"
        Catch ex As Exception
            MsgBox("Error :  cmdNro9_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "080 Plo Procedimientos del Formulario. Personalizados"
#End Region

#Region "150 grl Otros"
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_LmpMsgError()
        Me.Close()
        mof_LmpMsgError()
    End Sub
#End Region














End Class