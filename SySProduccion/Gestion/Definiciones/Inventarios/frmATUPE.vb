Public Class frmATUPE

    Private Sub frmATUPE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd_LlenaDGV()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


#Region "DataGridView"

    Private Sub cmd_LlenaDGV()
        Dim wp_sNomTbl As String
        Dim wp_bEOF1 As Boolean
        Dim vl_DT1 As New DataTable
        Dim clnConTbl As New ClaseNegocios.clnConTbl


        wp_sNomTbl = "ATUPE"
        wp_bEOF1 = True
        vl_DT1 = clnConTbl.cndtCargarLista(wp_sNomTbl, wp_bEOF1)
        If Not wp_bEOF1 Then
            With dgv1
                .DataSource = vl_DT1
                .AllowUserToAddRows = False
                .Columns(0).HeaderText = "Unidad de medida"
                .Columns(1).HeaderText = "Descripción"
                .Columns(2).HeaderText = "Peso*/Volumen"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(2).DefaultCellStyle.Format = "###,###.######"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        End If
    End Sub

#End Region


End Class