Public Class frmConsultar

#Region "02 Definición del variables Locales"

    ' Variables Campos de la BD


    ' Objetos del formulario


#End Region

#Region "03 Programa principal"

    Private Sub frmConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Stop

    End Sub
    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = wg_ClrFrm
        dgv_Configurar()
        dgv_Con2Cmp()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "06 - 2 Plo Procedimientos Locales"
    Private Sub Plo_DevSel()
        wg_sSelCon11 = dgv1.CurrentRow.Cells(0).Value
        wg_sSelCon12 = dgv1.CurrentRow.Cells(1).Value
        MsgBox(wg_sSelCon11 & " " & wg_sSelCon12)

    End Sub

#End Region
#Region "07 Procedimientos Controladores de Eventos (Remitente_evento)"
    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        Plo_DevSel()
        Me.Close()
    End Sub
#End Region
#Region "20  Eventos del datagridview"
    Private Sub dgv_Con2Cmp()
        wg_DTCon1 = clnConTbl.cndtCon2Cmp(wg_sTblCon1,
                                         wg_sCmpCon11,
                                         wg_sCmpCon12,
                                         wr_bEOFCon1)
        If Not wr_bEOFCon1 Then
            With dgv1
                .DataSource = wg_DTCon1
                .Columns(0).HeaderText = wg_sTitCon11
                .Columns(1).HeaderText = wg_sTitCon12
            End With
            '   TextBox1.AutoCompleteCustomSource


        End If
    End Sub
    Private Sub dgv_Configurar()
        With dgv1

            ' Apariencia
            .ColumnHeadersHeight = 18
            .RowTemplate.Height = 18
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ' comportamiento
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' diseño
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


            ' Varios columnas



        End With
    End Sub
    Private Sub dgv1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentDoubleClick
        If dgv1.CurrentRow.Cells(0).Selected Or
          dgv1.CurrentRow.Cells(1).Selected Or
          dgv1.CurrentRow.HeaderCell.Selected Then
            Plo_DevSel()
            Me.Close()
        End If

    End Sub
#End Region

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

End Class