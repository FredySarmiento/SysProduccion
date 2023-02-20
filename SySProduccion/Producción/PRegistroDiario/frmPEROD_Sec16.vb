Public Class frmPEROD_Sec16
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
    Private Sub frmPEROD_Sec16_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
    Private Sub cmdOpe16003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16003.Click
        Try
            vl_sCodOpe = "16003"
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
            MsgBox("Error : cmdOpe16003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe16005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16005.Click
        Try
            vl_sCodOpe = "16005"
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
            MsgBox("Error : cmdOpe16005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe16006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16006.Click
        Try
            vl_sCodOpe = "16006"
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
            MsgBox("Error : cmdOpe16006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe16036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16036.Click
        Try
            vl_sCodOpe = "16036"
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
            MsgBox("Error : cmdOpe16036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe16043_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16043.Click
        Try
            vl_sCodOpe = "16043"
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
            MsgBox("Error : cmdOpe16043_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe16044_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16044.Click
        Try
            vl_sCodOpe = "16044"
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
            MsgBox("Error : cmdOpe16044_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe16046_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16046.Click
        Try
            vl_sCodOpe = "16046"
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
            MsgBox("Error : cmdOpe16046_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe16077_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16077.Click
        Try
            vl_sCodOpe = "16077"
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
            MsgBox("Error : cmdOpe16077_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe16999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe16999.Click
        Try
            vl_sCodOpe = "16999"
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
            MsgBox("Error : cmdOpe16999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16003" Then
                    cmdOpe16003.BackColor = Color.Thistle
                    cmdOpe16003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16005" Then
                    cmdOpe16005.BackColor = Color.Thistle
                    cmdOpe16005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16006" Then
                    cmdOpe16006.BackColor = Color.Thistle
                    cmdOpe16006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16036" Then
                    cmdOpe16036.BackColor = Color.Thistle
                    cmdOpe16036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16043" Then
                    cmdOpe16043.BackColor = Color.Thistle
                    cmdOpe16043.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16044" Then
                    cmdOpe16044.BackColor = Color.Thistle
                    cmdOpe16044.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16046" Then
                    cmdOpe16046.BackColor = Color.Thistle
                    cmdOpe16046.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16077" Then
                    cmdOpe16077.BackColor = Color.Thistle
                    cmdOpe16077.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "16999" Then
                    cmdOpe16999.BackColor = Color.Thistle
                    cmdOpe16999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe16003.BackColor = Color.Gainsboro
            cmdOpe16005.BackColor = Color.Gainsboro
            cmdOpe16006.BackColor = Color.Gainsboro
            cmdOpe16036.BackColor = Color.Gainsboro
            cmdOpe16043.BackColor = Color.Gainsboro
            cmdOpe16044.BackColor = Color.Gainsboro
            cmdOpe16046.BackColor = Color.Gainsboro
            cmdOpe16077.BackColor = Color.Gainsboro
            cmdOpe16999.BackColor = Color.Gainsboro
            cmdOpe16003.Enabled = False
            cmdOpe16005.Enabled = False
            cmdOpe16006.Enabled = False
            cmdOpe16036.Enabled = False
            cmdOpe16043.Enabled = False
            cmdOpe16044.Enabled = False
            cmdOpe16046.Enabled = False
            cmdOpe16077.Enabled = False
            cmdOpe16999.Enabled = False
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