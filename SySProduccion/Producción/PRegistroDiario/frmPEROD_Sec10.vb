Public Class frmPEROD_Sec10
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
    Private Sub frmPEROD_Sec10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmdOpe10001_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10001.Click
        Try
            vl_sCodOpe = "10001"
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
            MsgBox("Error : cmdOpe10001_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe10003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10003.Click
        Try
            vl_sCodOpe = "10003"
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
            MsgBox("Error : cmdOpe10003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10005.Click
        Try
            vl_sCodOpe = "10005"
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
            MsgBox("Error : cmdOpe10005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe10006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10006.Click
        Try
            vl_sCodOpe = "10006"
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
            MsgBox("Error : cmdOpe10006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe10013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10013.Click
        Try
            vl_sCodOpe = "10013"
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
            MsgBox("Error : cmdOpe10013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10018_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10018.Click
        Try
            vl_sCodOpe = "10018"
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
            MsgBox("Error : cmdOpe10018_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe10021_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10021.Click
        Try
            vl_sCodOpe = "10021"
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
            MsgBox("Error : cmdOpe10021_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10023.Click
        Try
            vl_sCodOpe = "10023"
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
            MsgBox("Error : cmdOpe10023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10036.Click
        Try
            vl_sCodOpe = "10036"
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
            MsgBox("Error : cmdOpe10036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10037.Click
        Try
            vl_sCodOpe = "10037"
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
            MsgBox("Error : cmdOpe10037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10039_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10039.Click
        Try
            vl_sCodOpe = "10039"
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
            MsgBox("Error : cmdOpe10039_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10042_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10042.Click
        Try
            vl_sCodOpe = "10042"
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
            MsgBox("Error : cmdOpe10042_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10043_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10043.Click
        Try
            vl_sCodOpe = "10043"
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
            MsgBox("Error : cmdOpe10043_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10051_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10051.Click
        Try
            vl_sCodOpe = "10051"
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
            MsgBox("Error : cmdOpe10051_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10059_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10059.Click
        Try
            vl_sCodOpe = "10059"
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
            MsgBox("Error : cmdOpe10059_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10810_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10810.Click
        Try
            vl_sCodOpe = "10810"
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
            MsgBox("Error : cmdOpe10810_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe10999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe10999.Click
        Try
            vl_sCodOpe = "10999"
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
            MsgBox("Error : cmdOpe10999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10001" Then
                    cmdOpe10001.BackColor = Color.Thistle
                    cmdOpe10001.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10003" Then
                    cmdOpe10003.BackColor = Color.Thistle
                    cmdOpe10003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10005" Then
                    cmdOpe10005.BackColor = Color.Thistle
                    cmdOpe10005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10006" Then
                    cmdOpe10006.BackColor = Color.Thistle
                    cmdOpe10006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10013" Then
                    cmdOpe10013.BackColor = Color.Thistle
                    cmdOpe10013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10018" Then
                    cmdOpe10018.BackColor = Color.Thistle
                    cmdOpe10018.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10021" Then
                    cmdOpe10021.BackColor = Color.Thistle
                    cmdOpe10021.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10023" Then
                    cmdOpe10023.BackColor = Color.Thistle
                    cmdOpe10023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10036" Then
                    cmdOpe10036.BackColor = Color.Thistle
                    cmdOpe10036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10037" Then
                    cmdOpe10037.BackColor = Color.Thistle
                    cmdOpe10037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10039" Then
                    cmdOpe10039.BackColor = Color.Thistle
                    cmdOpe10039.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10042" Then
                    cmdOpe10042.BackColor = Color.Thistle
                    cmdOpe10042.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10043" Then
                    cmdOpe10043.BackColor = Color.Thistle
                    cmdOpe10043.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10051" Then
                    cmdOpe10051.BackColor = Color.Thistle
                    cmdOpe10051.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10059" Then
                    cmdOpe10059.BackColor = Color.Thistle
                    cmdOpe10059.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10810" Then
                    cmdOpe10810.BackColor = Color.Thistle
                    cmdOpe10810.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "10999" Then
                    cmdOpe10999.BackColor = Color.Thistle
                    cmdOpe10999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe10001.BackColor = Color.Gainsboro
            cmdOpe10003.BackColor = Color.Gainsboro
            cmdOpe10005.BackColor = Color.Gainsboro
            cmdOpe10006.BackColor = Color.Gainsboro
            cmdOpe10013.BackColor = Color.Gainsboro
            cmdOpe10018.BackColor = Color.Gainsboro
            cmdOpe10021.BackColor = Color.Gainsboro
            cmdOpe10023.BackColor = Color.Gainsboro
            cmdOpe10036.BackColor = Color.Gainsboro
            cmdOpe10037.BackColor = Color.Gainsboro
            cmdOpe10039.BackColor = Color.Gainsboro
            cmdOpe10042.BackColor = Color.Gainsboro
            cmdOpe10043.BackColor = Color.Gainsboro
            cmdOpe10051.BackColor = Color.Gainsboro
            cmdOpe10059.BackColor = Color.Gainsboro
            cmdOpe10810.BackColor = Color.Gainsboro
            cmdOpe10999.BackColor = Color.Gainsboro
            cmdOpe10001.Enabled = False
            cmdOpe10003.Enabled = False
            cmdOpe10005.Enabled = False
            cmdOpe10006.Enabled = False
            cmdOpe10013.Enabled = False
            cmdOpe10018.Enabled = False
            cmdOpe10021.Enabled = False
            cmdOpe10023.Enabled = False
            cmdOpe10036.Enabled = False
            cmdOpe10037.Enabled = False
            cmdOpe10039.Enabled = False
            cmdOpe10042.Enabled = False
            cmdOpe10043.Enabled = False
            cmdOpe10051.Enabled = False
            cmdOpe10059.Enabled = False
            cmdOpe10810.Enabled = False
            cmdOpe10999.Enabled = False
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