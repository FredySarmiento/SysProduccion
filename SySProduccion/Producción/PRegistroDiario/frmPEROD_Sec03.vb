Public Class frmPEROD_Sec03
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
    Private Sub frmPEROD_Sec03_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec03_Load")
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
    Private Sub cmdOpe03003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03003.Click
        Try
            vl_sCodOpe = "03003"
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
            MsgBox("Error : cmdOpe03003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe03005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03005.Click
        Try
            vl_sCodOpe = "03005"
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
            MsgBox("Error : cmdOpe03005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03006.Click
        Try
            vl_sCodOpe = "03006"
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
            MsgBox("Error : cmdOpe03006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03007.Click
        Try
            vl_sCodOpe = "03007"
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
            MsgBox("Error : cmdOpe03007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03012_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03012.Click
        Try
            vl_sCodOpe = "03012"
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
            MsgBox("Error : cmdOpe03012_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03013.Click
        Try
            vl_sCodOpe = "03013"
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
            MsgBox("Error : cmdOpe03013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03018_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03018.Click
        Try
            vl_sCodOpe = "03018"
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
            MsgBox("Error : cmdOpe03018_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03023.Click
        Try
            vl_sCodOpe = "03023"
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
            MsgBox("Error : cmdOpe03023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03024_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03024.Click
        Try
            vl_sCodOpe = "03024"
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
            MsgBox("Error : cmdOpe03024_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03037.Click
        Try
            vl_sCodOpe = "03037"
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
            MsgBox("Error : cmdOpe03037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03051_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03051.Click
        Try
            vl_sCodOpe = "03051"
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
            MsgBox("Error : cmdOpe03051_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe03058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03058.Click
        Try
            vl_sCodOpe = "03058"
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
            MsgBox("Error : cmdOpe03058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe03999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe03999.Click
        Try
            vl_sCodOpe = "03999"
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
            MsgBox("Error : cmdOpe03999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03003" Then
                    cmdOpe03003.BackColor = Color.thistle
                    cmdOpe03003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03005" Then
                    cmdOpe03005.BackColor = Color.thistle
                    cmdOpe03005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03006" Then
                    cmdOpe03006.BackColor = Color.thistle
                    cmdOpe03006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03007" Then
                    cmdOpe03007.BackColor = Color.thistle
                    cmdOpe03007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03012" Then
                    cmdOpe03012.BackColor = Color.thistle
                    cmdOpe03012.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03013" Then
                    cmdOpe03013.BackColor = Color.thistle
                    cmdOpe03013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03018" Then
                    cmdOpe03018.BackColor = Color.thistle
                    cmdOpe03018.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03023" Then
                    cmdOpe03018.BackColor = Color.thistle
                    cmdOpe03023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03024" Then
                    cmdOpe03024.BackColor = Color.thistle
                    cmdOpe03024.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03037" Then
                    cmdOpe03037.BackColor = Color.thistle
                    cmdOpe03037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03051" Then
                    cmdOpe03051.BackColor = Color.thistle
                    cmdOpe03051.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03058" Then
                    cmdOpe03058.BackColor = Color.thistle
                    cmdOpe03058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "03999" Then
                    cmdOpe03999.BackColor = Color.Thistle
                    cmdOpe03999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe03003.BackColor = Color.thistle
            cmdOpe03005.BackColor = Color.thistle
            cmdOpe03006.BackColor = Color.thistle
            cmdOpe03007.BackColor = Color.thistle
            cmdOpe03012.BackColor = Color.thistle
            cmdOpe03013.BackColor = Color.thistle
            cmdOpe03018.BackColor = Color.thistle
            cmdOpe03023.BackColor = Color.thistle
            cmdOpe03024.BackColor = Color.thistle
            cmdOpe03037.BackColor = Color.thistle
            cmdOpe03051.BackColor = Color.thistle
            cmdOpe03058.BackColor = Color.Thistle
            cmdOpe03999.BackColor = Color.Thistle
            cmdOpe03003.Enabled = False
            cmdOpe03005.Enabled = False
            cmdOpe03006.Enabled = False
            cmdOpe03007.Enabled = False
            cmdOpe03012.Enabled = False
            cmdOpe03013.Enabled = False
            cmdOpe03018.Enabled = False
            cmdOpe03023.Enabled = False
            cmdOpe03024.Enabled = False
            cmdOpe03037.Enabled = False
            cmdOpe03051.Enabled = False
            cmdOpe03058.Enabled = False
            cmdOpe03999.Enabled = False
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