Public Class frmPEROD_Sec02
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
    Private Sub frmPEROD_Sec02_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
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
    Private Sub cmdOpe02001_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02001.Click
        Try
            vl_sCodOpe = "02001"
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
            MsgBox("Error : cmdOpe02001_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02003.Click
        Try
            vl_sCodOpe = "02003"
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
            MsgBox("Error : cmdOpe02003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02005.Click
        Try
            vl_sCodOpe = "02005"
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
            MsgBox("Error : cmdOpe02005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02006.Click
        Try
            vl_sCodOpe = "02006"
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
            MsgBox("Error : cmdOpe02006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02007.Click
        Try
            vl_sCodOpe = "02007"
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
            MsgBox("Error : cmdOpe02007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02012_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02012.Click
        Try
            vl_sCodOpe = "02012"
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
            MsgBox("Error : cmdOpe02012_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02013.Click
        Try
            vl_sCodOpe = "02013"
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
            MsgBox("Error : cmdOpe02013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02017_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02017.Click
        Try
            vl_sCodOpe = "02017"
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
            MsgBox("Error : cmdOpe02017_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02018_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02018.Click
        Try
            vl_sCodOpe = "02018"
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
            MsgBox("Error : cmdOpe02018_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02020_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02020.Click
        Try
            vl_sCodOpe = "02020"
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
            MsgBox("Error : cmdOpe02020_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02023.Click
        Try
            vl_sCodOpe = "02023"
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
            MsgBox("Error : cmdOpe02023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02024_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02024.Click
        Try
            vl_sCodOpe = "02024"
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
            MsgBox("Error : cmdOpe02024_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02037.Click
        Try
            vl_sCodOpe = "02037"
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
            MsgBox("Error : cmdOpe02037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02051_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02051.Click
        Try
            vl_sCodOpe = "02051"
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
            MsgBox("Error : cmdOpe02051_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02058.Click
        Try
            vl_sCodOpe = "02058"
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
            MsgBox("Error : cmdOpe02058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02059_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02059.Click
        Try
            vl_sCodOpe = "02059"
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
            MsgBox("Error : cmdOpe02059_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02078_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02078.Click
        Try
            vl_sCodOpe = "02078"
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
            MsgBox("Error : cmdOpe02078_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe02999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe02999.Click
        Try
            vl_sCodOpe = "02999"
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
            MsgBox("Error : cmdOpe02999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02001" Then
                    cmdOpe02001.BackColor = Color.Thistle
                    cmdOpe02001.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02003" Then
                    cmdOpe02003.BackColor = Color.Thistle
                    cmdOpe02003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02005" Then
                    cmdOpe02005.BackColor = Color.Thistle
                    cmdOpe02005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02006" Then
                    cmdOpe02006.BackColor = Color.Thistle
                    cmdOpe02006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02007" Then
                    cmdOpe02007.BackColor = Color.Thistle
                    cmdOpe02007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02012" Then
                    cmdOpe02012.BackColor = Color.Thistle
                    cmdOpe02012.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02013" Then
                    cmdOpe02013.BackColor = Color.Thistle
                    cmdOpe02013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02017" Then
                    cmdOpe02017.BackColor = Color.Thistle
                    cmdOpe02017.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02018" Then
                    cmdOpe02018.BackColor = Color.Thistle
                    cmdOpe02018.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02020" Then
                    cmdOpe02020.BackColor = Color.Thistle
                    cmdOpe02020.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02023" Then
                    cmdOpe02023.BackColor = Color.Thistle
                    cmdOpe02023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02024" Then
                    cmdOpe02024.BackColor = Color.Thistle
                    cmdOpe02024.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02037" Then
                    cmdOpe02037.BackColor = Color.Thistle
                    cmdOpe02037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02051" Then
                    cmdOpe02051.BackColor = Color.Thistle
                    cmdOpe02051.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02058" Then
                    cmdOpe02001.BackColor = Color.Thistle
                    cmdOpe02058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02059" Then
                    cmdOpe02059.BackColor = Color.Thistle
                    cmdOpe02059.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02078" Then
                    cmdOpe02078.BackColor = Color.Thistle
                    cmdOpe02078.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "02999" Then
                    cmdOpe02999.BackColor = Color.Thistle
                    cmdOpe02999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe02001.BackColor = Color.Gainsboro
            cmdOpe02003.BackColor = Color.Gainsboro
            cmdOpe02005.BackColor = Color.Gainsboro
            cmdOpe02006.BackColor = Color.Gainsboro
            cmdOpe02007.BackColor = Color.Gainsboro
            cmdOpe02012.BackColor = Color.Gainsboro
            cmdOpe02013.BackColor = Color.Gainsboro
            cmdOpe02017.BackColor = Color.Gainsboro
            cmdOpe02018.BackColor = Color.Gainsboro
            cmdOpe02020.BackColor = Color.Gainsboro
            cmdOpe02023.BackColor = Color.Gainsboro
            cmdOpe02024.BackColor = Color.Gainsboro
            cmdOpe02037.BackColor = Color.Gainsboro
            cmdOpe02051.BackColor = Color.Gainsboro
            cmdOpe02058.BackColor = Color.Gainsboro
            cmdOpe02059.BackColor = Color.Gainsboro
            cmdOpe02078.BackColor = Color.Gainsboro
            cmdOpe02999.BackColor = Color.Gainsboro
            cmdOpe02001.Enabled = False
            cmdOpe02003.Enabled = False
            cmdOpe02005.Enabled = False
            cmdOpe02006.Enabled = False
            cmdOpe02007.Enabled = False
            cmdOpe02012.Enabled = False
            cmdOpe02013.Enabled = False
            cmdOpe02017.Enabled = False
            cmdOpe02018.Enabled = False
            cmdOpe02020.Enabled = False
            cmdOpe02023.Enabled = False
            cmdOpe02024.Enabled = False
            cmdOpe02037.Enabled = False
            cmdOpe02051.Enabled = False
            cmdOpe02058.Enabled = False
            cmdOpe02059.Enabled = False
            cmdOpe02078.Enabled = False
            cmdOpe02999.Enabled = False

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