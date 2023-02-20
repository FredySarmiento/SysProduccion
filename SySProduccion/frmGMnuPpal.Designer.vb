<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGMnuPpal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos de la Empresa")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parametrizaciones generales")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Períodos Contables")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Numeración de Documentos")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inicialización del Sistema", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Encargados Compras/Ventas")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Zonas/Territorios")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuarios")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar clave de Acceso")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizaciones generales")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguridades", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estados Orden de Compra")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compras", New System.Windows.Forms.TreeNode() {TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Condiciones de pago")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grupos de clientes")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grupos de proveedores")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Terceros", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Almacenes")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grupos de inventarios")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transacciones de inventarios")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unidades de medida ")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventarios", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Centros de trabajo")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C.I.F.")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estados Orden de Producción")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operaciones")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operarios")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Análisis")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Producción", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Definiciones", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode14, TreeNode18, TreeNode23, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cierre de período")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Utilidades", New System.Windows.Forms.TreeNode() {TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parametrización de formularios")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parametrización de listas")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recalcular saldos ")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Herramientas", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestión del sistema                      ", -2, -2, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode31, TreeNode33, TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pedido del cliente")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de despacho")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Devoluciones")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes de ventas")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas - Clientes               ", New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode40, TreeNode41, TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de compra")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada de compras")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Devoluciones a proveedores")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nota crédito proveedores")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Documentos abiertos")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compras")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes de compras", New System.Windows.Forms.TreeNode() {TreeNode48, TreeNode49})
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compras - Proveedores     ", New System.Windows.Forms.TreeNode() {TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode50})
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos Maestros de Terceros")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Terceros", New System.Windows.Forms.TreeNode() {TreeNode52})
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos maestros ítems")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada de inventario")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salida de inventario")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transferencias de inventario")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operaciones de Inventarios", New System.Windows.Forms.TreeNode() {TreeNode55, TreeNode56, TreeNode57})
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saldos de inventarios a la fecha")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saldos de inventarios por almacén a la fecha")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saldos Inventarios fecha Anterior")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de mínimos de inventarios")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movimiento de inventarios")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Documentos grabados")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta de datos del movimiento")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes de inventarios", New System.Windows.Forms.TreeNode() {TreeNode59, TreeNode60, TreeNode61, TreeNode62, TreeNode63, TreeNode64, TreeNode65})
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventarios", New System.Windows.Forms.TreeNode() {TreeNode54, TreeNode58, TreeNode66})
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fórmulas maestra")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lista de materiales")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de producción")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salida materiales para producción")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada de producción")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registro Operaciones por Operario")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Devolución de materiales")
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salida de producto de producción")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Componentes Comunes")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas de Producción", New System.Windows.Forms.TreeNode() {TreeNode76})
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ordenes de producción costeadas")
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Requerimiento de MP y MEE")
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reportes de orden de producción")
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de OP con Costos")
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de MDO y CIF")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes de Producción", New System.Windows.Forms.TreeNode() {TreeNode78, TreeNode79, TreeNode80, TreeNode81, TreeNode82})
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Actualizar Registro Diario Operaciones")
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registro Diario Operaciones")
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte Registro Diario de Operaciones")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registro Diario Operaciones", New System.Windows.Forms.TreeNode() {TreeNode84, TreeNode85, TreeNode86})
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Producción", New System.Windows.Forms.TreeNode() {TreeNode68, TreeNode69, TreeNode70, TreeNode71, TreeNode72, TreeNode73, TreeNode74, TreeNode75, TreeNode77, TreeNode83, TreeNode87})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGMnuPpal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.AliceBlue
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.MinimumSize = New System.Drawing.Size(40, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(235, 335)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 25)
        Me.TextBox1.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(235, 306)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(227, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Módulos"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "frmACDEM"
        TreeNode1.Tag = ""
        TreeNode1.Text = "Datos de la Empresa"
        TreeNode2.Name = "frmACPAG"
        TreeNode2.Text = "Parametrizaciones generales"
        TreeNode3.Name = "frmATPCO"
        TreeNode3.Text = "Períodos Contables"
        TreeNode4.Name = "frmAPEND"
        TreeNode4.Text = "Numeración de Documentos"
        TreeNode5.Name = "Nodo000"
        TreeNode5.Text = "Inicialización del Sistema"
        TreeNode6.Name = "frmATVEN"
        TreeNode6.Text = "Encargados Compras/Ventas"
        TreeNode7.Name = "frmATZON"
        TreeNode7.Text = "Zonas/Territorios"
        TreeNode8.Name = "frmATUSR"
        TreeNode8.Text = "Usuarios"
        TreeNode9.Name = "frmGAPUS"
        TreeNode9.Text = "Modificar clave de Acceso"
        TreeNode10.Name = "frmATAUT"
        TreeNode10.Text = "Autorizaciones generales"
        TreeNode11.Name = "Nodo00101"
        TreeNode11.Text = "Seguridades"
        TreeNode12.Name = "Nodo0010"
        TreeNode12.Text = "General"
        TreeNode13.Name = "frmABEOC"
        TreeNode13.Text = "Estados Orden de Compra"
        TreeNode14.Name = "Nodo0012"
        TreeNode14.Text = "Compras"
        TreeNode15.Name = "frmATCOP"
        TreeNode15.Text = "Condiciones de pago"
        TreeNode16.Name = "frmATGCL"
        TreeNode16.Text = "Grupos de clientes"
        TreeNode17.Name = "frmATGPR"
        TreeNode17.Text = "Grupos de proveedores"
        TreeNode18.Name = "Nodo0013"
        TreeNode18.Text = "Terceros"
        TreeNode19.Name = "frmATALM"
        TreeNode19.Text = "Almacenes"
        TreeNode20.Name = "frmATGRI"
        TreeNode20.Text = "Grupos de inventarios"
        TreeNode21.Name = "frmATTIN"
        TreeNode21.Text = "Transacciones de inventarios"
        TreeNode22.Name = "frmACUNI"
        TreeNode22.Text = "Unidades de medida "
        TreeNode23.Name = "Nodo0015"
        TreeNode23.Text = "Inventarios"
        TreeNode24.Name = "frmATCTR"
        TreeNode24.Text = "Centros de trabajo"
        TreeNode25.Name = "frmATCIF"
        TreeNode25.Text = "C.I.F."
        TreeNode26.Name = "frmABEOP"
        TreeNode26.Text = "Estados Orden de Producción"
        TreeNode27.Name = "frmATOPE"
        TreeNode27.Text = "Operaciones"
        TreeNode28.Name = "frmATPOP"
        TreeNode28.Text = "Operarios"
        TreeNode29.Name = "frmATANA"
        TreeNode29.Text = "Análisis"
        TreeNode30.Name = "Nodo0016"
        TreeNode30.Text = "Producción"
        TreeNode31.Name = "Nodo001"
        TreeNode31.Text = "Definiciones"
        TreeNode32.Name = "frmGCCIP"
        TreeNode32.Text = "Cierre de período"
        TreeNode33.Name = "Nodo002"
        TreeNode33.Text = "Utilidades"
        TreeNode34.Name = "frmAPFRM"
        TreeNode34.Text = "Parametrización de formularios"
        TreeNode35.Name = "frmAPGQLst"
        TreeNode35.Text = "Parametrización de listas"
        TreeNode36.Name = "frmASRES"
        TreeNode36.Text = "Recalcular saldos "
        TreeNode37.Name = "Nodo003"
        TreeNode37.Text = "Herramientas"
        TreeNode38.ImageIndex = -2
        TreeNode38.Name = "Nodo00"
        TreeNode38.SelectedImageIndex = -2
        TreeNode38.Tag = ""
        TreeNode38.Text = "Gestión del sistema                      "
        TreeNode39.Name = "frmVEPED"
        TreeNode39.Text = "Pedido del cliente"
        TreeNode40.Name = "frmVESAI"
        TreeNode40.Text = "Orden de despacho"
        TreeNode41.Name = "frmVEENI"
        TreeNode41.Text = "Devoluciones"
        TreeNode42.Name = "Nodo029"
        TreeNode42.Text = "Informes de ventas"
        TreeNode43.Name = "Nodo02"
        TreeNode43.Text = "Ventas - Clientes               "
        TreeNode44.Name = "frmCEODC"
        TreeNode44.Text = "Orden de compra"
        TreeNode45.Name = "frmCEENI"
        TreeNode45.Text = "Entrada de compras"
        TreeNode46.Name = "frmCESAI"
        TreeNode46.Text = "Devoluciones a proveedores"
        TreeNode47.Name = "frmCENOC"
        TreeNode47.Text = "Nota crédito proveedores"
        TreeNode48.Name = "frmCR001"
        TreeNode48.Text = "Documentos abiertos"
        TreeNode49.Name = "frmCRODC01"
        TreeNode49.Text = "Compras"
        TreeNode50.Name = "Nodo039"
        TreeNode50.Text = "Informes de compras"
        TreeNode51.Name = "Nodo03"
        TreeNode51.Text = "Compras - Proveedores     "
        TreeNode52.Name = "frmTEDMT"
        TreeNode52.Text = "Datos Maestros de Terceros"
        TreeNode53.Name = "Nodo04"
        TreeNode53.Text = "Terceros"
        TreeNode54.Name = "frmIEDMI"
        TreeNode54.Text = "Datos maestros ítems"
        TreeNode55.Name = "frmIEENI"
        TreeNode55.Text = "Entrada de inventario"
        TreeNode56.Name = "frmIESAI"
        TreeNode56.Text = "Salida de inventario"
        TreeNode57.Name = "frmIETRI"
        TreeNode57.Text = "Transferencias de inventario"
        TreeNode58.Name = "Nodo061"
        TreeNode58.Text = "Operaciones de Inventarios"
        TreeNode59.Name = "frmRIDMI03"
        TreeNode59.Text = "Saldos de inventarios a la fecha"
        TreeNode60.Name = "frmRIDMI01"
        TreeNode60.Text = "Saldos de inventarios por almacén a la fecha"
        TreeNode61.Name = "frmRIDMI04"
        TreeNode61.Text = "Saldos Inventarios fecha Anterior"
        TreeNode62.Name = "frmRIDMI02"
        TreeNode62.Text = "Reporte de mínimos de inventarios"
        TreeNode63.Name = "frmRIMOV01"
        TreeNode63.Text = "Movimiento de inventarios"
        TreeNode64.Name = "frmRIMOV02"
        TreeNode64.Text = "Documentos grabados"
        TreeNode65.Name = "frmRIMOV03"
        TreeNode65.Text = "Consulta de datos del movimiento"
        TreeNode66.Name = "Nodo069"
        TreeNode66.Text = "Informes de inventarios"
        TreeNode67.Name = "Nodo06"
        TreeNode67.Text = "Inventarios"
        TreeNode68.Name = "frmPEFOM"
        TreeNode68.Text = "Fórmulas maestra"
        TreeNode69.Name = "frmPELIM"
        TreeNode69.Text = "Lista de materiales"
        TreeNode70.Name = "frmPEODP"
        TreeNode70.Text = "Orden de producción"
        TreeNode71.Name = "frmPESDM"
        TreeNode71.Text = "Salida materiales para producción"
        TreeNode72.Name = "frmPEEDP"
        TreeNode72.Text = "Entrada de producción"
        TreeNode73.Name = "frmPEROP"
        TreeNode73.Text = "Registro Operaciones por Operario"
        TreeNode74.Name = "frmPEEDM"
        TreeNode74.Text = "Devolución de materiales"
        TreeNode75.Name = "frmPESDP"
        TreeNode75.Text = "Salida de producto de producción"
        TreeNode76.Name = "frmPQLIM01"
        TreeNode76.Text = "Componentes Comunes"
        TreeNode77.Name = "Nodo078"
        TreeNode77.Text = "Consultas de Producción"
        TreeNode78.Name = "frmPRODP01"
        TreeNode78.Text = "Ordenes de producción costeadas"
        TreeNode79.Name = "frmPRODP04"
        TreeNode79.Text = "Requerimiento de MP y MEE"
        TreeNode80.Name = "frmPRODP02"
        TreeNode80.Text = "Reportes de orden de producción"
        TreeNode81.Name = "frmPRODP05"
        TreeNode81.Text = "Reporte de OP con Costos"
        TreeNode82.Name = "frmPRODP03"
        TreeNode82.Text = "Reporte de MDO y CIF"
        TreeNode83.Name = "Nodo079"
        TreeNode83.Text = "Informes de Producción"
        TreeNode84.Name = "frmActPEROD"
        TreeNode84.Text = "Actualizar Registro Diario Operaciones"
        TreeNode85.Name = "frmPEROD"
        TreeNode85.Text = "Registro Diario Operaciones"
        TreeNode86.Name = "frmPRROD01"
        TreeNode86.Text = "Reporte Registro Diario de Operaciones"
        TreeNode87.Name = "Nodo071"
        TreeNode87.Text = "Registro Diario Operaciones"
        TreeNode88.Name = "Nodo07"
        TreeNode88.Text = "Producción"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode43, TreeNode51, TreeNode53, TreeNode67, TreeNode88})
        Me.TreeView1.ShowLines = False
        Me.TreeView1.Size = New System.Drawing.Size(221, 274)
        Me.TreeView1.TabIndex = 9
        '
        'frmGMnuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(235, 335)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGMnuPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Menú Principal"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
