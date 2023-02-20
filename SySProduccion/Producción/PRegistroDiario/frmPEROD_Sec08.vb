Public Class frmPEROD_Sec08
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
    Private Sub frmPEROD_Sec08_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec08_Load")
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

    Private Sub cmdOpe08003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08003.Click
        Try
            vl_sCodOpe = "08003"
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
            MsgBox("Error : cmdOpe08003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe08005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08005.Click
        Try
            vl_sCodOpe = "08005"
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
            MsgBox("Error : cmdOpe08005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe08006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08006.Click
        Try
            vl_sCodOpe = "08006"
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
            MsgBox("Error : cmdOpe08006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe08016_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08016.Click
        Try
            vl_sCodOpe = "08016"
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
            MsgBox("Error : cmdOpe08016_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe08037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08037.Click
        Try
            vl_sCodOpe = "08037"
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
            MsgBox("Error : cmdOpe08037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe08044_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08044.Click
        Try
            vl_sCodOpe = "08044"
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
            MsgBox("Error : cmdOpe08044_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe08999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe08999.Click
        Try
            vl_sCodOpe = "08999"
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
            MsgBox("Error : cmdOpe08999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08003" Then
                    cmdOpe08003.BackColor = Color.Thistle
                    cmdOpe08003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08005" Then
                    cmdOpe08005.BackColor = Color.Thistle
                    cmdOpe08005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08006" Then
                    cmdOpe08006.BackColor = Color.Thistle
                    cmdOpe08006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08016" Then
                    cmdOpe08016.BackColor = Color.Thistle
                    cmdOpe08016.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08037" Then
                    cmdOpe08037.BackColor = Color.Thistle
                    cmdOpe08037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08044" Then
                    cmdOpe08044.BackColor = Color.Thistle
                    cmdOpe08044.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "08999" Then
                    cmdOpe08999.BackColor = Color.Thistle
                    cmdOpe08999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe08003.BackColor = Color.Gainsboro
            cmdOpe08005.BackColor = Color.Gainsboro
            cmdOpe08006.BackColor = Color.Gainsboro
            cmdOpe08016.BackColor = Color.Gainsboro
            cmdOpe08037.BackColor = Color.Gainsboro
            cmdOpe08044.BackColor = Color.Gainsboro
            cmdOpe08999.BackColor = Color.Gainsboro
            cmdOpe08003.Enabled = False
            cmdOpe08005.Enabled = False
            cmdOpe08006.Enabled = False
            cmdOpe08016.Enabled = False
            cmdOpe08037.Enabled = False
            cmdOpe08044.Enabled = False
            cmdOpe08999.Enabled = False
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