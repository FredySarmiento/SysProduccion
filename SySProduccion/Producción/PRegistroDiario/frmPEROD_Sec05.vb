Public Class frmPEROD_Sec05
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
    Private Sub frmPEROD_Sec05_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec05_Load")
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
    Private Sub cmdOpe05001_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05001.Click
        Try
            vl_sCodOpe = "05001"
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
            MsgBox("Error : cmdOpe05001_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05003.Click
        Try
            vl_sCodOpe = "05003"
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
            MsgBox("Error : cmdOpe05003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05005.Click
        Try
            vl_sCodOpe = "05005"
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
            MsgBox("Error : cmdOpe05005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05006.Click
        Try
            vl_sCodOpe = "05006"
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
            MsgBox("Error : cmdOpe05006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05013.Click
        Try
            vl_sCodOpe = "05013"
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
            MsgBox("Error : cmdOpe05013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05018_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05018.Click
        Try
            vl_sCodOpe = "05018"
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
            MsgBox("Error : cmdOpe05018_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05019_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05019.Click
        Try
            vl_sCodOpe = "05019"
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
            MsgBox("Error : cmdOpe05019_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05023.Click
        Try
            vl_sCodOpe = "05023"
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
            MsgBox("Error : cmdOpe05023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05029_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05029.Click
        Try
            vl_sCodOpe = "05029"
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
            MsgBox("Error : cmdOpe05029_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05036.Click
        Try
            vl_sCodOpe = "05036"
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
            MsgBox("Error : cmdOpe05036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05051_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05051.Click
        Try
            vl_sCodOpe = "05051"
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
            MsgBox("Error : cmdOpe05051_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe05052_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05052.Click
        Try
            vl_sCodOpe = "05052"
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
            MsgBox("Error : cmdOpe05052_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05053_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05053.Click
        Try
            vl_sCodOpe = "05053"
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
            MsgBox("Error : cmdOpe05053_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05056_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05056.Click
        Try
            vl_sCodOpe = "05056"
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
            MsgBox("Error : cmdOpe05056_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05058.Click
        Try
            vl_sCodOpe = "05058"
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
            MsgBox("Error : cmdOpe05058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05059_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05059.Click
        Try
            vl_sCodOpe = "05059"
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
            MsgBox("Error : cmdOpe05059_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe05999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe05999.Click
        Try
            vl_sCodOpe = "05999"
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
            MsgBox("Error : cmdOpe05999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05001" Then
                    cmdOpe05001.BackColor = Color.Thistle
                    cmdOpe05001.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05003" Then
                    cmdOpe05003.BackColor = Color.Thistle
                    cmdOpe05003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05005" Then
                    cmdOpe05005.BackColor = Color.Thistle
                    cmdOpe05005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05006" Then
                    cmdOpe05006.BackColor = Color.Thistle
                    cmdOpe05006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05013" Then
                    cmdOpe05013.BackColor = Color.Thistle
                    cmdOpe05013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05018" Then
                    cmdOpe05018.BackColor = Color.Thistle
                    cmdOpe05018.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05019" Then
                    cmdOpe05019.BackColor = Color.Thistle
                    cmdOpe05019.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05023" Then
                    cmdOpe05023.BackColor = Color.Thistle
                    cmdOpe05023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05029" Then
                    cmdOpe05029.BackColor = Color.Thistle
                    cmdOpe05029.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05036" Then
                    cmdOpe05036.BackColor = Color.Thistle
                    cmdOpe05036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05051" Then
                    cmdOpe05051.BackColor = Color.Thistle
                    cmdOpe05051.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05052" Then
                    cmdOpe05052.BackColor = Color.Thistle
                    cmdOpe05052.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05053" Then
                    cmdOpe05053.BackColor = Color.Thistle
                    cmdOpe05053.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05056" Then
                    cmdOpe05056.BackColor = Color.Thistle
                    cmdOpe05056.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05058" Then
                    cmdOpe05058.BackColor = Color.Thistle
                    cmdOpe05058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05059" Then
                    cmdOpe05059.BackColor = Color.Thistle
                    cmdOpe05059.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "05999" Then
                    cmdOpe05999.BackColor = Color.Thistle
                    cmdOpe05999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe05001.BackColor = Color.Gainsboro
            cmdOpe05003.BackColor = Color.Gainsboro
            cmdOpe05005.BackColor = Color.Gainsboro
            cmdOpe05006.BackColor = Color.Gainsboro
            cmdOpe05013.BackColor = Color.Gainsboro
            cmdOpe05018.BackColor = Color.Gainsboro
            cmdOpe05019.BackColor = Color.Gainsboro
            cmdOpe05023.BackColor = Color.Gainsboro
            cmdOpe05029.BackColor = Color.Gainsboro
            cmdOpe05036.BackColor = Color.Gainsboro
            cmdOpe05051.BackColor = Color.Gainsboro
            cmdOpe05052.BackColor = Color.Gainsboro
            cmdOpe05053.BackColor = Color.Gainsboro
            cmdOpe05056.BackColor = Color.Gainsboro
            cmdOpe05058.BackColor = Color.Gainsboro
            cmdOpe05059.BackColor = Color.Gainsboro
            cmdOpe05999.BackColor = Color.Gainsboro
            cmdOpe05001.Enabled = False
            cmdOpe05003.Enabled = False
            cmdOpe05005.Enabled = False
            cmdOpe05006.Enabled = False
            cmdOpe05013.Enabled = False
            cmdOpe05018.Enabled = False
            cmdOpe05019.Enabled = False
            cmdOpe05023.Enabled = False
            cmdOpe05029.Enabled = False
            cmdOpe05036.Enabled = False
            cmdOpe05051.Enabled = False
            cmdOpe05052.Enabled = False
            cmdOpe05053.Enabled = False
            cmdOpe05056.Enabled = False
            cmdOpe05058.Enabled = False
            cmdOpe05059.Enabled = False
            cmdOpe05999.Enabled = False
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