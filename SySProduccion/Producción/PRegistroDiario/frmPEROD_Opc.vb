Public Class frmPEROD_Opc
#Region "001 Inicia. wg - vg Definición del variables públicas"
    ' wg - Variables de trabajo globales/públicas parámetro
    ' vp - Variables que corresponde a campos de la BD globles/públicas- parámeto
    Public wg_nNroEnt As String
    Public vg_sCodTer As String
    Public vg_sNomTer As String
    Public vg_dFecDoc As Date
    Public vg_sHorSys As String
    Public wg_bAbrirReg As Boolean
    Public wg_bCerrarReg As Boolean
    Public wg_bRegNue As Boolean
    Public wg_bOpcOk As Boolean
    Public wg_ePEROP As New moe_Estructuras.ePEROP
    Public wg_ePLROP1 As New moe_Estructuras.ePLROP1
    Public wg_bOpeAbi As Boolean
    Public wg_bNoOpeAbi As Boolean
    Public wg_bAlzAbi As Boolean
    Public wg_bCafAbi As Boolean

#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region

#Region "011 frm - Variables Locales"
    Dim wl_ePEFOM As New moe_Estructuras.ePEFOM
    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
    Dim wl_bIniciar As Boolean
    Dim wl_bTerminar As Boolean
    Dim wl_sOpc As String
    Dim wl_sOpcOpe As String
    Dim wl_sOpcDes As String
    Dim wl_bSecOk As Boolean
    Dim wl_sAlmDesSel As String
    ' A abierto
    ' C Cerrado
    Dim wl_sAlmDesEst As String

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_sCodDoc As String
    Dim vl_sCodCtr As String
    Dim vl_sCodOpe As String
    Dim vl_sNomOpe As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodTer As String
    Dim vl_sNomTer As String
    Dim vl_dFecDoc As Date
    Dim vl_sHorSys As String
    Dim vl_nPreUni As Double
#End Region
#Region "014 Objetos locales"
    Dim clnActTab As New ClaseNegocios.clnActTbl
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnPEODP As New ClaseNegocios.clnPEODP
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTLst1 As New DataTable
    Dim wl_DTAPLND1 As New DataTable

#End Region
#Region "015 Estructuras"
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEROP As New moe_Estructuras.ePEROP
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmPEROD_Opc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
           
            Plo_InHabCmd()
            Plo_IniciarVar()
            If wg_bRegNue = True Then
                Plo_HabRegNue()
            Else
                Plo_HabDes()
            End If

        Catch ex As Exception
            MsgBox("Error : frmPEROD_Opc_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdCerrar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"


    Private Sub cmdTerminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdTerminar.Click
        Try
            wl_bIniciar = False
            wl_bTerminar = True
            wl_sOpc = wl_sOpcOpe
            If wl_sOpcDes = "D" Or wl_sOpcDes = "A" Then
                wl_sOpc = wl_sOpcDes
            End If
            Plo_frmPEROD_Sec()

        Catch ex As Exception
            MsgBox("Error : cmdTerminar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOperacional_Click(sender As System.Object, e As System.EventArgs) Handles cmdOperaciones.Click
        Try
            wl_sOpc = "O"
            wl_sOpcOpe = "O"
            wl_sOpcDes = ""
            wl_bIniciar = True
            wl_bTerminar = False
            Plo_frmPEROD_Sec()

        Catch ex As Exception
            MsgBox("Error : cmdOperacional_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdDescanso_Click(sender As System.Object, e As System.EventArgs) Handles cmdDescanso.Click
        Try
            wl_sOpc = "D"
            wl_sOpcDes = "D"

            wl_bIniciar = True
            wl_bTerminar = False
            Plo_frmPEROD_Sec()

        Catch ex As Exception
            MsgBox("Error : cmdDescanso_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdNoOperacional_Click(sender As System.Object, e As System.EventArgs) Handles cmdNoOperativas.Click
        Try
            wl_sOpc = "N"
            wl_sOpcOpe = "N"
            wl_sOpcDes = ""
            wl_bIniciar = True
            wl_bTerminar = False
            Plo_frmPEROD_Sec()

        Catch ex As Exception
            MsgBox("Error : cmdNoOperacional_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdAlmuerzo_Click(sender As System.Object, e As System.EventArgs) Handles cmdAlmuerzo.Click
        Try
            wl_sOpc = "A"
            wl_sOpcDes = "A"
            wl_bIniciar = True
            wl_bTerminar = False
            Plo_frmPEROD_Sec()

        Catch ex As Exception
            MsgBox("Error : cmdAlmuerzo_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "080 Plo Procedimientos del Formulario. Personalizados"


    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            wl_sOpc = ""
            wl_sOpcDes = ""
            wl_sOpcOpe = ""
            wl_bIniciar = False
            wl_bTerminar = False
            vl_sCodTer = vg_sCodTer
            vl_sNomTer = vg_sNomTer
            vl_dFecDoc = vg_dFecDoc
            vl_sHorSys = vg_sHorSys
            '         vl_sHorSys = frmPEROD.txtdHHMM.Text
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            wl_ePEROP = wg_ePEROP
            wl_ePLROP1 = wg_ePLROP1

           
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_frmPEROD_Sec()

        Try
            Dim wl_frmPEROD_Sec As New frmPEROD_Sec
            wl_frmPEROD_Sec.vg_sCodTer = vl_sCodTer
            wl_frmPEROD_Sec.vg_sNomTer = vl_sNomTer
            wl_frmPEROD_Sec.vg_dFecDoc = vl_dFecDoc
            wl_frmPEROD_Sec.vg_sHorSys = vl_sHorSys
            wl_frmPEROD_Sec.wg_sOpc = wl_sOpc
            wl_frmPEROD_Sec.wg_bAbrirReg = wg_bAbrirReg
            wl_frmPEROD_Sec.wg_bCerrarReg = wg_bCerrarReg
            wl_frmPEROD_Sec.wg_bIniciar = wl_bIniciar
            wl_frmPEROD_Sec.wg_bTerminar = wl_bTerminar
            wl_bSecOk = False
            wl_frmPEROD_Sec.wg_ePEROP = wl_ePEROP
            wl_frmPEROD_Sec.wg_ePLROP1 = wl_ePLROP1
            wl_frmPEROD_Sec.wg_bRegNue = wg_bRegNue
            wl_frmPEROD_Sec.ShowDialog()
            '  wl_sOpc = ""
            ' wl_sOpcDes = ""
            wl_bSecOk = wl_frmPEROD_Sec.wg_bSecOk
            wg_bOpcOk = wl_frmPEROD_Sec.wg_bSecOk
            If wl_bSecOk = False Then
                wl_sOpcDes = ""
                If wl_sAlmDesSel = "A" And wl_sAlmDesEst = "A" Then
                    wl_sOpcDes = "A"
                End If
                If wl_sAlmDesSel = "D" And wl_sAlmDesEst = "A" Then
                    wl_sOpcDes = "D"
                End If
                cmdCancelar.Focus()
            Else
                cmdCancelar.PerformClick()
                '  cmdOk.Enabled = True
                ' cmdOk.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_frmPEROD_Sec")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Plo_HabOpe()
        ' datos por del formulario
        Try
            cmdNoOperativas.BackColor = Color.Thistle
            cmdOperaciones.BackColor = Color.Thistle
            cmdNoOperativas.Enabled = True
            cmdOperaciones.Enabled = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpe")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabDes()
        Try
            'Actividad Iniciada, valida descanso
            wl_sOpcDes = ""
            cmdAlmuerzo.BackColor = Color.Linen
            cmdDescanso.BackColor = Color.Linen
            cmdAlmuerzo.Enabled = True
            cmdDescanso.Enabled = True
            cmdTerminar.Enabled = False
            If (wl_ePLROP1.nHHIniCaf = 0 And wl_ePLROP1.nMMIniCaf = 0 And wl_ePLROP1.nTieCnsCaf = 0) Then
                'Descanso No iniciado
                cmdDescanso.BackColor = Color.Linen
                cmdDescanso.Enabled = True
                cmdTerminar.Enabled = True
                wl_bIniciar = True
            Else

                'Descanso iniciado
                cmdDescanso.BackColor = Color.Linen
                cmdDescanso.Enabled = False
                If (wl_ePLROP1.nHHFinCaf = 0 And wl_ePLROP1.nMMFinCaf = 0 And wl_ePLROP1.nTieCnsCaf = 0) Then
                    'Descanso No Terminado
                    wl_sOpcDes = "D"
                    wl_sAlmDesSel = "D"
                    wl_sAlmDesEst = "A"
                    cmdTerminar.Text = "Terminar Descanso"
                    cmdDescanso.BackColor = Color.Linen
                    cmdAlmuerzo.BackColor = Color.Gainsboro
                    cmdDescanso.Enabled = False
                    cmdAlmuerzo.Enabled = False
                    cmdTerminar.Enabled = True
                    wl_bIniciar = False
                Else
                    'Descanso terminado
                    cmdDescanso.BackColor = Color.Gainsboro
                    cmdAlmuerzo.BackColor = Color.Gainsboro
                    cmdDescanso.Enabled = False
                    cmdTerminar.Enabled = True
                    cmdAlmuerzo.Enabled = True
                    wl_sOpcDes = ""
                    wl_sAlmDesSel = "D"
                    wl_sAlmDesEst = "C"
                    wl_bIniciar = True
                End If
            End If


            'Descanso No Iniciado
            If wl_sOpcDes = "" Then


                If (wl_ePLROP1.nHHIniAlz = 0 And wl_ePLROP1.nMMIniAlz = 0 And wl_ePLROP1.nTieCnsAlz = 0) Then
                    'Almuerzo No iniciado
                    cmdAlmuerzo.BackColor = Color.Linen
                    cmdAlmuerzo.Enabled = True
                    cmdTerminar.Enabled = True
                    wl_bIniciar = True
                Else

                    'Almuerzo Iniciado
                    cmdAlmuerzo.BackColor = Color.Gainsboro
                    cmdDescanso.BackColor = Color.Gainsboro
                    cmdAlmuerzo.Enabled = False
                    cmdDescanso.Enabled = False
                    cmdTerminar.Enabled = True
                    If (wl_ePLROP1.nHHFinAlz = 0 And wl_ePLROP1.nMMFinAlz = 0 And wl_ePLROP1.nTieCnsAlz = 0) Then
                        'Almuerzo No Terminado
                        cmdTerminar.Text = "Terminar Almuerzo"
                        wl_sAlmDesSel = "A"
                        wl_sAlmDesEst = "A"
                        wl_sOpcDes = "A"
                        cmdAlmuerzo.BackColor = Color.Linen
                        cmdAlmuerzo.Enabled = False
                        cmdTerminar.Enabled = True
                        wl_bIniciar = False
                    Else
                        'Almuerzo terminado
                        wl_sAlmDesSel = "A"
                        wl_sAlmDesEst = "C"
                        cmdAlmuerzo.BackColor = Color.Gainsboro
                        cmdAlmuerzo.Enabled = False
                        cmdTerminar.Enabled = True
                        wl_bIniciar = False
                        wl_sOpcDes = ""
                    End If
                End If
            End If
            If wl_ePLROP1.sCodCtr <> "99" Then
                cmdNoOperativas.BackColor = Color.Gainsboro
                cmdOperaciones.BackColor = Color.Thistle
                wl_sOpcOpe = "O"
            Else
                cmdNoOperativas.BackColor = Color.Thistle
                cmdOperaciones.BackColor = Color.Gainsboro
                wl_sOpcOpe = "N"
            End If
            

        Catch ex As Exception
            MsgBox("Error : Plo_HabDes")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabRegAct()
        Try
            cmdTerminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabRegNue()
        ' datos por del formulario
        Try
            cmdNoOperativas.BackColor = Color.Thistle
            cmdOperaciones.BackColor = Color.Thistle
            cmdOperaciones.Enabled = True
            cmdNoOperativas.Enabled = True
            cmdTerminar.Enabled = False
            wl_bIniciar = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabOpc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabCmd()
        ' datos por del formulario
        Try

            cmdTerminar.Enabled = False
            cmdNoOperativas.BackColor = Color.Gainsboro
            cmdOperaciones.BackColor = Color.Gainsboro
            cmdAlmuerzo.BackColor = Color.Gainsboro
            cmdDescanso.BackColor = Color.Gainsboro
            cmdNoOperativas.Enabled = False
            cmdOperaciones.Enabled = False
            cmdAlmuerzo.Enabled = False
            cmdDescanso.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabCmd")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabOpe()
        ' datos por del formulario
        Try
            cmdNoOperativas.Enabled = False
            cmdOperaciones.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabOpe")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabDes()
        ' datos por del formulario
        Try
            cmdAlmuerzo.Enabled = False
            cmdDescanso.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabDes")
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