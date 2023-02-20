Public Class frmPEROD_Sec15
#Region "001 Inicia. wg - vg Definición del variables públicas"
    ' wg - Variables de trabajo globales/públicas parámetro
    ' vp - Variables que corresponde a campos de la BD globles/públicas- parámeto
    Public wg_sCodOpe As String
    Public wg_sNomOpe As String
    Public wg_aePLODP2() As moe_Estructuras.ePLODP2
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto

    Dim wl_eATOPE As New moe_Estructuras.eATOPE
    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
    Dim wl_nCntReg As Long

#End Region
#Region "011 frm - Variables Locales"
    Dim wl_bEOF As Boolean
    Dim wr_bEOFE2 As Boolean
#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_sCodOpe As String
    Dim vl_sNomOpe As String

#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmPEROD_Sec15_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec10_Load")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "042 BD Busquedas"
    Private Function BD_BuscarATOPE() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATOPE = New moe_Estructuras.eATOPE
            wr_bEOFE2 = mof_fConATOPE(vl_sCodOpe,
                                      wl_eATOPE)
            If wr_bEOFE2 = False Then
                vl_sCodOpe = wl_eATOPE.sCodOpe
                vl_sNomOpe = wl_eATOPE.sNomOpe
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATOPE")
        End Try
        Return wr_bEOFE2
    End Function
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Try
            wg_sCodOpe = ""
            wg_sNomOpe = ""
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdCerrar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdOpe15003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15003.Click
        Try
            vl_sCodOpe = "15003"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15005.Click
        Try
            vl_sCodOpe = "15005"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15006.Click
        Try
            vl_sCodOpe = "15006"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15016_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15016.Click
        Try
            vl_sCodOpe = "15016"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15016_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15036.Click
        Try
            vl_sCodOpe = "15036"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15037.Click
        Try
            vl_sCodOpe = "15037"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15038_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15038.Click
        Try
            vl_sCodOpe = "15038"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15038_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15039_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15039.Click
        Try
            vl_sCodOpe = "15039"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15039_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe15999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe15999.Click
        Try
            vl_sCodOpe = "15999"
            vl_sNomOpe = ""
            wl_bEOF = False
            BD_BuscarATOPE()
            If wl_bEOF = False Then
                vl_sNomOpe = wl_eATOPE.sNomOpe
                wg_sCodOpe = wl_eATOPE.sCodOpe
                wg_sNomOpe = wl_eATOPE.sNomOpe
            End If
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOpe15999_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            wl_eATOPE = New moe_Estructuras.eATOPE
            vl_sCodOpe = ""
            vl_sNomOpe = ""
            wg_sCodOpe = ""
            wg_sNomOpe = ""
            Plo_InHabOpe()
            Plo_HabOpe()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabOpe()
        Try
            Dim wl_nI As Long
            wl_nCntReg = wg_aePLODP2.Length - 1
            For wl_nI = 0 To wl_nCntReg
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15003" Then
                    cmdOpe15003.BackColor = Color.Thistle
                    cmdOpe15003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15005" Then
                    cmdOpe15005.BackColor = Color.Thistle
                    cmdOpe15005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15006" Then
                    cmdOpe15006.BackColor = Color.Thistle
                    cmdOpe15006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15016" Then
                    cmdOpe15016.BackColor = Color.Thistle
                    cmdOpe15016.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15036" Then
                    cmdOpe15036.BackColor = Color.Thistle
                    cmdOpe15036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15037" Then
                    cmdOpe15037.BackColor = Color.Thistle
                    cmdOpe15037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15038" Then
                    cmdOpe15038.BackColor = Color.Thistle
                    cmdOpe15038.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15039" Then
                    cmdOpe15039.BackColor = Color.Thistle
                    cmdOpe15039.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "15999" Then
                    cmdOpe15999.BackColor = Color.Thistle
                    cmdOpe15999.Enabled = True
                End If


            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe15003.BackColor = Color.Gainsboro
            cmdOpe15005.BackColor = Color.Gainsboro
            cmdOpe15006.BackColor = Color.Gainsboro
            cmdOpe15016.BackColor = Color.Gainsboro
            cmdOpe15036.BackColor = Color.Gainsboro
            cmdOpe15037.BackColor = Color.Gainsboro
            cmdOpe15038.BackColor = Color.Gainsboro
            cmdOpe15039.BackColor = Color.Gainsboro
            cmdOpe15999.BackColor = Color.Gainsboro
            cmdOpe15003.Enabled = False
            cmdOpe15005.Enabled = False
            cmdOpe15006.Enabled = False
            cmdOpe15016.Enabled = False
            cmdOpe15036.Enabled = False
            cmdOpe15037.Enabled = False
            cmdOpe15038.Enabled = False
            cmdOpe15039.Enabled = False
            cmdOpe15999.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
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
