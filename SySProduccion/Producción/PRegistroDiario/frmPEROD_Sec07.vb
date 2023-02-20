Public Class frmPEROD_Sec07
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
    Private Sub frmPEROD_Sec07_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec07_Load")
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

    Private Sub cmdOpe07003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07003.Click
        Try
            vl_sCodOpe = "07003"
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
            MsgBox("Error : cmdOpe07003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07005.Click
        Try
            vl_sCodOpe = "07005"
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
            MsgBox("Error : cmdOpe07005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe07006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07006.Click
        Try
            vl_sCodOpe = "07006"
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
            MsgBox("Error : cmdOpe07006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07007.Click
        Try
            vl_sCodOpe = "07007"
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
            MsgBox("Error : cmdOpe07007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe07036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07036.Click
        Try
            vl_sCodOpe = "07036"
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
            MsgBox("Error : cmdOpe07036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07037.Click
        Try
            vl_sCodOpe = "07037"
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
            MsgBox("Error : cmdOpe07037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07043_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07043.Click
        Try
            vl_sCodOpe = "07043"
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
            MsgBox("Error : cmdOpe07043_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07046_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07046.Click
        Try
            vl_sCodOpe = "07046"
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
            MsgBox("Error : cmdOpe07046_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07077_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07077.Click
        Try
            vl_sCodOpe = "07077"
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
            MsgBox("Error : cmdOpe07077_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe07999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe07999.Click
        Try
            vl_sCodOpe = "07999"
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
            MsgBox("Error : cmdOpe07999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07003" Then
                    cmdOpe07003.BackColor = Color.Thistle
                    cmdOpe07003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07005" Then
                    cmdOpe07005.BackColor = Color.Thistle
                    cmdOpe07005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07006" Then
                    cmdOpe07006.BackColor = Color.Thistle
                    cmdOpe07006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07007" Then
                    cmdOpe07007.BackColor = Color.Thistle
                    cmdOpe07007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07036" Then
                    cmdOpe07036.BackColor = Color.Thistle
                    cmdOpe07036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07037" Then
                    cmdOpe07037.BackColor = Color.Thistle
                    cmdOpe07037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07043" Then
                    cmdOpe07043.BackColor = Color.Thistle
                    cmdOpe07043.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07046" Then
                    cmdOpe07046.BackColor = Color.Thistle
                    cmdOpe07046.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07077" Then
                    cmdOpe07077.BackColor = Color.Thistle
                    cmdOpe07077.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "07999" Then
                    cmdOpe07999.BackColor = Color.Thistle
                    cmdOpe07999.Enabled = True
                End If



            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe07003.BackColor = Color.Gainsboro
            cmdOpe07005.BackColor = Color.Gainsboro
            cmdOpe07006.BackColor = Color.Gainsboro
            cmdOpe07007.BackColor = Color.Gainsboro
            cmdOpe07036.BackColor = Color.Gainsboro
            cmdOpe07037.BackColor = Color.Gainsboro
            cmdOpe07043.BackColor = Color.Gainsboro
            cmdOpe07046.BackColor = Color.Gainsboro
            cmdOpe07077.BackColor = Color.Gainsboro
            cmdOpe07999.BackColor = Color.Gainsboro
            cmdOpe07003.Enabled = False
            cmdOpe07005.Enabled = False
            cmdOpe07006.Enabled = False
            cmdOpe07007.Enabled = False
            cmdOpe07036.Enabled = False
            cmdOpe07037.Enabled = False
            cmdOpe07043.Enabled = False
            cmdOpe07046.Enabled = False
            cmdOpe07077.Enabled = False
            cmdOpe07999.Enabled = False
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