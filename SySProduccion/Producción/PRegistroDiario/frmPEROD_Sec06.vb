Public Class frmPEROD_Sec06
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
    Private Sub frmPEROD_Sec06_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Plo_IniciarVar()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : frmPEROD_Sec06_Load")
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
            MsgBox("Error : cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdOpe06001_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06001.Click
        Try
            vl_sCodOpe = "06001"
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
            MsgBox("Error : cmdOpe06001_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06003_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06003.Click
        Try
            vl_sCodOpe = "06003"
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
            MsgBox("Error : cmdOpe06003_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06005_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06005.Click
        Try
            vl_sCodOpe = "06005"
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
            MsgBox("Error : cmdOpe06005_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe06006_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06006.Click
        Try
            vl_sCodOpe = "06006"
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
            MsgBox("Error : cmdOpe06006_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06007_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06007.Click
        Try
            vl_sCodOpe = "06007"
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
            MsgBox("Error : cmdOpe06007_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06009_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06009.Click
        Try
            vl_sCodOpe = "06009"
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
            MsgBox("Error : cmdOpe06009_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06011_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06011.Click
        Try
            vl_sCodOpe = "06011"
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
            MsgBox("Error : cmdOpe06011_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06013_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06013.Click
        Try
            vl_sCodOpe = "06013"
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
            MsgBox("Error : cmdOpe06013_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06021_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06021.Click
        Try
            vl_sCodOpe = "06021"
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
            MsgBox("Error : cmdOpe06021_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06023_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06023.Click
        Try
            vl_sCodOpe = "06023"
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
            MsgBox("Error : cmdOpe06023_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06024_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06024.Click
        Try
            vl_sCodOpe = "06024"
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
            MsgBox("Error : cmdOpe06024_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06025_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06025.Click
        Try
            vl_sCodOpe = "06025"
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
            MsgBox("Error : cmdOpe06025_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe06030_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06030.Click
        Try
            vl_sCodOpe = "06030"
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
            MsgBox("Error : cmdOpe06030_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe06031_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06031.Click
        Try
            vl_sCodOpe = "06031"
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
            MsgBox("Error : cmdOpe06031_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe06035_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06035.Click
        Try
            vl_sCodOpe = "06035"
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
            MsgBox("Error : cmdOpe06035_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06036_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06036.Click
        Try
            vl_sCodOpe = "06036"
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
            MsgBox("Error : cmdOpe06036_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06037_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06037.Click
        Try
            vl_sCodOpe = "06037"
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
            MsgBox("Error : cmdOpe06037_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06038_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06038.Click
        Try
            vl_sCodOpe = "06038"
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
            MsgBox("Error : cmdOpe06038_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe06039_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06039.Click
        Try
            vl_sCodOpe = "06039"
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
            MsgBox("Error : cmdOpe06039_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06040_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06040.Click
        Try
            vl_sCodOpe = "06040"
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
            MsgBox("Error : cmdOpe06040_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06041_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06041.Click
        Try
            vl_sCodOpe = "06041"
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
            MsgBox("Error : cmdOpe06041_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06042_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06042.Click
        Try
            vl_sCodOpe = "06042"
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
            MsgBox("Error : cmdOpe06042_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06043_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06043.Click
        Try
            vl_sCodOpe = "06043"
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
            MsgBox("Error : cmdOpe06043_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06044_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06044.Click
        Try
            vl_sCodOpe = "06044"
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
            MsgBox("Error : cmdOpe06044_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06046_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06046.Click
        Try
            vl_sCodOpe = "06046"
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
            MsgBox("Error : cmdOpe06046_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06047_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06047.Click
        Try
            vl_sCodOpe = "06047"
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
            MsgBox("Error : cmdOpe06047_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06050_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06050.Click
        Try
            vl_sCodOpe = "06050"
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
            MsgBox("Error : cmdOpe06050_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06051_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06051.Click
        Try
            vl_sCodOpe = "06051"
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
            MsgBox("Error : cmdOpe06051_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06058_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06058.Click
        Try
            vl_sCodOpe = "06058"
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
            MsgBox("Error : cmdOpe06058_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06077_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06077.Click
        Try
            vl_sCodOpe = "06077"
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
            MsgBox("Error : cmdOpe06077_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06078_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06078.Click
        Try
            vl_sCodOpe = "06078"
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
            MsgBox("Error : cmdOpe06078_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdOpe06306_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06306.Click
        Try
            vl_sCodOpe = "06306"
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
            MsgBox("Error : cmdOpe06306_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06818_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06818.Click
        Try
            vl_sCodOpe = "06818"
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
            MsgBox("Error : cmdOpe06818_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOpe06999_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpe06999.Click
        Try
            vl_sCodOpe = "06999"
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
            MsgBox("Error : cmdOpe06999_Click")
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
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06001" Then
                    cmdOpe06001.BackColor = Color.Thistle
                    cmdOpe06001.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06003" Then
                    cmdOpe06003.BackColor = Color.Thistle
                    cmdOpe06003.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06005" Then
                    cmdOpe06005.BackColor = Color.Thistle
                    cmdOpe06005.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06006" Then
                    cmdOpe06006.BackColor = Color.Thistle
                    cmdOpe06006.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06007" Then
                    cmdOpe06007.BackColor = Color.Thistle
                    cmdOpe06007.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06009" Then
                    cmdOpe06009.BackColor = Color.Thistle
                    cmdOpe06009.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06011" Then
                    cmdOpe06011.BackColor = Color.Thistle
                    cmdOpe06011.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06013" Then
                    cmdOpe06013.BackColor = Color.Thistle
                    cmdOpe06013.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06021" Then
                    cmdOpe06021.BackColor = Color.Thistle
                    cmdOpe06021.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06023" Then
                    cmdOpe06023.BackColor = Color.Thistle
                    cmdOpe06023.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06024" Then
                    cmdOpe06024.BackColor = Color.Thistle
                    cmdOpe06024.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06025" Then
                    cmdOpe06025.BackColor = Color.Thistle
                    cmdOpe06025.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06030" Then
                    cmdOpe06030.BackColor = Color.Thistle
                    cmdOpe06030.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06031" Then
                    cmdOpe06031.BackColor = Color.Thistle
                    cmdOpe06031.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06035" Then
                    cmdOpe06035.BackColor = Color.Thistle
                    cmdOpe06035.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06036" Then
                    cmdOpe06036.BackColor = Color.Thistle
                    cmdOpe06036.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06037" Then
                    cmdOpe06037.BackColor = Color.Thistle
                    cmdOpe06037.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06038" Then
                    cmdOpe06038.BackColor = Color.Thistle
                    cmdOpe06038.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06039" Then
                    cmdOpe06039.BackColor = Color.Thistle
                    cmdOpe06039.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06040" Then
                    cmdOpe06040.BackColor = Color.Thistle
                    cmdOpe06040.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06041" Then
                    cmdOpe06041.BackColor = Color.Thistle
                    cmdOpe06041.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06042" Then
                    cmdOpe06042.BackColor = Color.Thistle
                    cmdOpe06042.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06043" Then
                    cmdOpe06043.BackColor = Color.Thistle
                    cmdOpe06043.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06044" Then
                    cmdOpe06044.BackColor = Color.Thistle
                    cmdOpe06044.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06046" Then
                    cmdOpe06046.BackColor = Color.Thistle
                    cmdOpe06046.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06047" Then
                    cmdOpe06047.BackColor = Color.Thistle
                    cmdOpe06047.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06050" Then
                    cmdOpe06050.BackColor = Color.Thistle
                    cmdOpe06050.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06051" Then
                    cmdOpe06051.BackColor = Color.Thistle
                    cmdOpe06051.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06058" Then
                    cmdOpe06058.BackColor = Color.Thistle
                    cmdOpe06058.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06077" Then
                    cmdOpe06077.BackColor = Color.Thistle
                    cmdOpe06077.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06078" Then
                    cmdOpe06078.BackColor = Color.Thistle
                    cmdOpe06078.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06306" Then
                    cmdOpe06306.BackColor = Color.Thistle
                    cmdOpe06306.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06818" Then
                    cmdOpe06818.BackColor = Color.Thistle
                    cmdOpe06818.Enabled = True
                End If
                If Trim(wg_aePLODP2(wl_nI).sCodOpe) = "06999" Then
                    cmdOpe06999.BackColor = Color.Thistle
                    cmdOpe06999.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_InHabOpe()
        Try
            cmdOpe06001.BackColor = Color.Gainsboro
            cmdOpe06003.BackColor = Color.Gainsboro
            cmdOpe06005.BackColor = Color.Gainsboro
            cmdOpe06006.BackColor = Color.Gainsboro
            cmdOpe06007.BackColor = Color.Gainsboro
            cmdOpe06009.BackColor = Color.Gainsboro
            cmdOpe06011.BackColor = Color.Gainsboro
            cmdOpe06013.BackColor = Color.Gainsboro
            cmdOpe06021.BackColor = Color.Gainsboro
            cmdOpe06023.BackColor = Color.Gainsboro
            cmdOpe06024.BackColor = Color.Gainsboro
            cmdOpe06025.BackColor = Color.Gainsboro
            cmdOpe06030.BackColor = Color.Gainsboro
            cmdOpe06031.BackColor = Color.Gainsboro
            cmdOpe06035.BackColor = Color.Gainsboro
            cmdOpe06036.BackColor = Color.Gainsboro
            cmdOpe06037.BackColor = Color.Gainsboro
            cmdOpe06038.BackColor = Color.Gainsboro
            cmdOpe06039.BackColor = Color.Gainsboro
            cmdOpe06040.BackColor = Color.Gainsboro
            cmdOpe06041.BackColor = Color.Gainsboro
            cmdOpe06042.BackColor = Color.Gainsboro
            cmdOpe06043.BackColor = Color.Gainsboro
            cmdOpe06044.BackColor = Color.Gainsboro
            cmdOpe06046.BackColor = Color.Gainsboro
            cmdOpe06047.BackColor = Color.Gainsboro
            cmdOpe06050.BackColor = Color.Gainsboro
            cmdOpe06051.BackColor = Color.Gainsboro
            cmdOpe06058.BackColor = Color.Gainsboro
            cmdOpe06077.BackColor = Color.Gainsboro
            cmdOpe06078.BackColor = Color.Gainsboro
            cmdOpe06306.BackColor = Color.Gainsboro
            cmdOpe06818.BackColor = Color.Gainsboro
            cmdOpe06999.BackColor = Color.Gainsboro
            cmdOpe06001.Enabled = False
            cmdOpe06003.Enabled = False
            cmdOpe06005.Enabled = False
            cmdOpe06006.Enabled = False
            cmdOpe06007.Enabled = False
            cmdOpe06009.Enabled = False
            cmdOpe06011.Enabled = False
            cmdOpe06013.Enabled = False
            cmdOpe06021.Enabled = False
            cmdOpe06023.Enabled = False
            cmdOpe06024.Enabled = False
            cmdOpe06025.Enabled = False
            cmdOpe06030.Enabled = False
            cmdOpe06031.Enabled = False
            cmdOpe06035.Enabled = False
            cmdOpe06036.Enabled = False
            cmdOpe06037.Enabled = False
            cmdOpe06038.Enabled = False
            cmdOpe06039.Enabled = False
            cmdOpe06040.Enabled = False
            cmdOpe06041.Enabled = False
            cmdOpe06042.Enabled = False
            cmdOpe06043.Enabled = False
            cmdOpe06044.Enabled = False
            cmdOpe06046.Enabled = False
            cmdOpe06047.Enabled = False
            cmdOpe06050.Enabled = False
            cmdOpe06051.Enabled = False
            cmdOpe06058.Enabled = False
            cmdOpe06077.Enabled = False
            cmdOpe06078.Enabled = False
            cmdOpe06306.Enabled = False
            cmdOpe06818.Enabled = False
            cmdOpe06999.Enabled = False
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