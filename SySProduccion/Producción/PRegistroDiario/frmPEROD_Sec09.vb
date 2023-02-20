Public Class frmPEROD_Sec09
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


    Private Sub frmPEROD_Sec09_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec09_Load")
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

    Private Sub cmdOpe09003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09003.Click
        Try
            vl_sCodOpe = "09003"
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
            MsgBox("Error : cmdOpe09003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09005.Click
        Try
            vl_sCodOpe = "09005"
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
            MsgBox("Error : cmdOpe09005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe09006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09006.Click
        Try
            vl_sCodOpe = "09006"
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
            MsgBox("Error : cmdOpe09006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe09007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09007.Click
        Try
            vl_sCodOpe = "09007"
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
            MsgBox("Error : cmdOpe09007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe09012_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09012.Click
        Try
            vl_sCodOpe = "09012"
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
            MsgBox("Error : cmdOpe09012_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09013.Click
        Try
            vl_sCodOpe = "09013"
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
            MsgBox("Error : cmdOpe09013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09016_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09016.Click
        Try
            vl_sCodOpe = "09016"
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
            MsgBox("Error : cmdOpe09016_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09018_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09018.Click
        Try
            vl_sCodOpe = "09018"
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
            MsgBox("Error : cmdOpe09018_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09023.Click
        Try
            vl_sCodOpe = "09023"
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
            MsgBox("Error : cmdOpe09023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09024_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09024.Click
        Try
            vl_sCodOpe = "09024"
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
            MsgBox("Error : cmdOpe09024_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09029_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09029.Click
        Try
            vl_sCodOpe = "09029"
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
            MsgBox("Error : cmdOpe09029_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09037.Click
        Try
            vl_sCodOpe = "09037"
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
            MsgBox("Error : cmdOpe09037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe09051_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09051.Click
        Try
            vl_sCodOpe = "09051"
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
            MsgBox("Error : cmdOpe09051_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09058.Click
        Try
            vl_sCodOpe = "09058"
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
            MsgBox("Error : cmdOpe09058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe09999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe09999.Click
        Try
            vl_sCodOpe = "09999"
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
            MsgBox("Error : cmdOpe09999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09003" Then
                    cmdOpe09003.BackColor = Color.Thistle
                    cmdOpe09003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09005" Then
                    cmdOpe09005.BackColor = Color.Thistle
                    cmdOpe09005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09006" Then
                    cmdOpe09006.BackColor = Color.Thistle
                    cmdOpe09006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09007" Then
                    cmdOpe09007.BackColor = Color.Thistle
                    cmdOpe09007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09012" Then
                    cmdOpe09012.BackColor = Color.Thistle
                    cmdOpe09012.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09013" Then
                    cmdOpe09013.BackColor = Color.Thistle
                    cmdOpe09013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09018" Then
                    cmdOpe09018.BackColor = Color.Thistle
                    cmdOpe09018.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09023" Then
                    cmdOpe09023.BackColor = Color.Thistle
                    cmdOpe09023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09024" Then
                    cmdOpe09024.BackColor = Color.Thistle
                    cmdOpe09024.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09029" Then
                    cmdOpe09029.BackColor = Color.Thistle
                    cmdOpe09029.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09037" Then
                    cmdOpe09037.BackColor = Color.Thistle
                    cmdOpe09037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09051" Then
                    cmdOpe09051.BackColor = Color.Thistle
                    cmdOpe09051.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09058" Then
                    cmdOpe09058.BackColor = Color.Thistle
                    cmdOpe09058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "09999" Then
                    cmdOpe09999.BackColor = Color.Thistle
                    cmdOpe09999.Enabled = True
                End If

            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe09003.BackColor = Color.Gainsboro
            cmdOpe09005.BackColor = Color.Gainsboro
            cmdOpe09006.BackColor = Color.Gainsboro
            cmdOpe09007.BackColor = Color.Gainsboro
            cmdOpe09012.BackColor = Color.Gainsboro
            cmdOpe09013.BackColor = Color.Gainsboro
            cmdOpe09018.BackColor = Color.Gainsboro
            cmdOpe09023.BackColor = Color.Gainsboro
            cmdOpe09024.BackColor = Color.Gainsboro
            cmdOpe09029.BackColor = Color.Gainsboro
            cmdOpe09037.BackColor = Color.Gainsboro
            cmdOpe09051.BackColor = Color.Gainsboro
            cmdOpe09058.BackColor = Color.Gainsboro
            cmdOpe09999.BackColor = Color.Gainsboro
            cmdOpe09003.Enabled = False
            cmdOpe09005.Enabled = False
            cmdOpe09006.Enabled = False
            cmdOpe09007.Enabled = False
            cmdOpe09012.Enabled = False
            cmdOpe09013.Enabled = False
            cmdOpe09018.Enabled = False
            cmdOpe09023.Enabled = False
            cmdOpe09024.Enabled = False
            cmdOpe09029.Enabled = False
            cmdOpe09037.Enabled = False
            cmdOpe09051.Enabled = False
            cmdOpe09058.Enabled = False
            cmdOpe09999.Enabled = False
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