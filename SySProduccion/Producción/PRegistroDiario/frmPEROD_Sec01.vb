Public Class frmPEROD_Sec01
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
    Private Sub frmPEROD_Sec01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            Plo_InHabOpe()
            Plo_HabOpe()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec01_Load")
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
    Private Sub cmdOpe01001_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01001.Click
        Try
            vl_sCodOpe = "01001"
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
            MsgBox("Error : cmdOpe01001_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe01003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01003.Click
        Try
            vl_sCodOpe = "01003"
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
            MsgBox("Error : cmdOpe01003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe01006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01006.Click
        Try
            vl_sCodOpe = "01006"
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
            MsgBox("Error : cmdOpe01006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe01007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01007.Click
        Try
            vl_sCodOpe = "01007"
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
            MsgBox("Error : cmdOpe01007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe01013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01013.Click
        Try
            vl_sCodOpe = "01013"
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
            MsgBox("Error : cmdOpe01013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe01023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01023.Click
        Try
            vl_sCodOpe = "01023"
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
            MsgBox("Error : cmdOpe01023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe01058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01058.Click
        Try
            vl_sCodOpe = "01058"
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
            MsgBox("Error : cmdOpe01058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe01999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe01999.Click
        Try
            vl_sCodOpe = "01999"
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
            MsgBox("Error : cmdOpe01999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01001" Then
                    cmdOpe01001.BackColor = Color.Thistle
                    cmdOpe01001.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01003" Then
                    cmdOpe01003.BackColor = Color.Thistle
                    cmdOpe01003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01006" Then
                    cmdOpe01006.BackColor = Color.Thistle
                    cmdOpe01006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01007" Then
                    cmdOpe01007.BackColor = Color.Thistle
                    cmdOpe01007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01013" Then
                    cmdOpe01013.BackColor = Color.Thistle
                    cmdOpe01013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01023" Then
                    cmdOpe01023.BackColor = Color.Thistle
                    cmdOpe01023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01058" Then
                    cmdOpe01058.BackColor = Color.Thistle
                    cmdOpe01058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "01999" Then
                    cmdOpe01999.BackColor = Color.Thistle
                    cmdOpe01999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe01001.BackColor = Color.Gainsboro
            cmdOpe01003.BackColor = Color.Gainsboro
            cmdOpe01006.BackColor = Color.Gainsboro
            cmdOpe01007.BackColor = Color.Gainsboro
            cmdOpe01013.BackColor = Color.Gainsboro
            cmdOpe01023.BackColor = Color.Gainsboro
            cmdOpe01058.BackColor = Color.Gainsboro
            cmdOpe01999.BackColor = Color.Gainsboro
            cmdOpe01001.Enabled = False
            cmdOpe01003.Enabled = False
            cmdOpe01006.Enabled = False
            cmdOpe01007.Enabled = False
            cmdOpe01013.Enabled = False
            cmdOpe01023.Enabled = False
            cmdOpe01058.Enabled = False
            cmdOpe01999.Enabled = False
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