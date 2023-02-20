Public Class frmPEROD_Sec14
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
    Private Sub frmPEROD_Sec14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
    Private Sub cmdOpe14003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14003.Click
        Try
            vl_sCodOpe = "14003"
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
            MsgBox("Error : cmdOpe14003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe14005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14005.Click
        Try
            vl_sCodOpe = "14005"
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
            MsgBox("Error : cmdOpe14005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe14006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14006.Click
        Try
            vl_sCodOpe = "14006"
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
            MsgBox("Error : cmdOpe14006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe14007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14007.Click
        Try
            vl_sCodOpe = "14007"
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
            MsgBox("Error : cmdOpe14007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe14016_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14016.Click
        Try
            vl_sCodOpe = "14016"
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
            MsgBox("Error : cmdOpe14016_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe14029_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14029.Click
        Try
            vl_sCodOpe = "14029"
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
            MsgBox("Error : cmdOpe14029_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe14036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14036.Click
        Try
            vl_sCodOpe = "14036"
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
            MsgBox("Error : cmdOpe14036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe14037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14037.Click
        Try
            vl_sCodOpe = "14037"
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
            MsgBox("Error : cmdOpe14037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe14038_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14038.Click
        Try
            vl_sCodOpe = "14038"
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
            MsgBox("Error : cmdOpe14038_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe14039_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14039.Click
        Try
            vl_sCodOpe = "14039"
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
            MsgBox("Error : cmdOpe14039_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe14058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14058.Click
        Try
            vl_sCodOpe = "14058"
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
            MsgBox("Error : cmdOpe14058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe14999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe14999.Click
        Try
            vl_sCodOpe = "14999"
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
            MsgBox("Error : cmdOpe14999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14003" Then
                    cmdOpe14003.BackColor = Color.Thistle
                    cmdOpe14003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14005" Then
                    cmdOpe14005.BackColor = Color.Thistle
                    cmdOpe14005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14006" Then
                    cmdOpe14006.BackColor = Color.Thistle
                    cmdOpe14006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14007" Then
                    cmdOpe14007.BackColor = Color.Thistle
                    cmdOpe14007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14016" Then
                    cmdOpe14016.BackColor = Color.Thistle
                    cmdOpe14016.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14029" Then
                    cmdOpe14029.BackColor = Color.Thistle
                    cmdOpe14029.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14036" Then
                    cmdOpe14036.BackColor = Color.Thistle
                    cmdOpe14036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14037" Then
                    cmdOpe14037.BackColor = Color.Thistle
                    cmdOpe14037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14038" Then
                    cmdOpe14038.BackColor = Color.Thistle
                    cmdOpe14038.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14039" Then
                    cmdOpe14039.BackColor = Color.Thistle
                    cmdOpe14039.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14058" Then
                    cmdOpe14058.BackColor = Color.Thistle
                    cmdOpe14058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "14999" Then
                    cmdOpe14999.BackColor = Color.Thistle
                    cmdOpe14999.Enabled = True
                End If

            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe14003.BackColor = Color.Gainsboro
            cmdOpe14005.BackColor = Color.Gainsboro
            cmdOpe14006.BackColor = Color.Gainsboro
            cmdOpe14007.BackColor = Color.Gainsboro
            cmdOpe14016.BackColor = Color.Gainsboro
            cmdOpe14029.BackColor = Color.Gainsboro
            cmdOpe14036.BackColor = Color.Gainsboro
            cmdOpe14037.BackColor = Color.Gainsboro
            cmdOpe14038.BackColor = Color.Gainsboro
            cmdOpe14039.BackColor = Color.Gainsboro
            cmdOpe14058.BackColor = Color.Gainsboro
            cmdOpe14999.BackColor = Color.Gainsboro
            cmdOpe14003.Enabled = False
            cmdOpe14005.Enabled = False
            cmdOpe14006.Enabled = False
            cmdOpe14007.Enabled = False
            cmdOpe14016.Enabled = False
            cmdOpe14029.Enabled = False
            cmdOpe14036.Enabled = False
            cmdOpe14037.Enabled = False
            cmdOpe14038.Enabled = False
            cmdOpe14039.Enabled = False
            cmdOpe14058.Enabled = False
            cmdOpe14999.Enabled = False
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