Public Class frmAPNDO
#Region "Configuración del formulario"


#End Region

    Dim wp_sNomTbl As String
    Dim wp_bEOF1 As Boolean = True

    Dim vl_DT1 As New DataTable
    Dim clnConTbl As New ClaseNegocios.clnConTbl

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub frmAPNDO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd_LlenaDGV()
    End Sub
#Region "DataGridView"
    Private Sub cmd_DibujaDGV()
        With dgv1
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = True
            .ColumnCount = 7
            .Columns(2).Visible = False
            .Columns(0).HeaderText = "Documento"
            .Columns(1).HeaderText = "Nombre documento"
            .Columns(3).HeaderText = "Serie"
            .Columns(4).HeaderText = "Número inicial"
            .Columns(5).HeaderText = "Siguiente número"
            .Columns(6).HeaderText = "Número final"
            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 160
            .Columns(5).Width = 160
            .Columns(6).Width = 160



        End With

    End Sub
    Private Sub cmd_AdiLinBlancoDGV()
        With dgv1
            For i = 1 To 10
                .Rows.Add()
            Next
            For i = 1 To 10
                .CurrentRow.Height = 15
            Next
        End With
    End Sub
    Private Sub cmd_LlenaDGV()
        wp_sNomTbl = "APNDO"
        wp_bEOF1 = True
        vl_DT1 = clnConTbl.cndtCargarLista(wp_sNomTbl, wp_bEOF1)
        If Not wp_bEOF1 Then
            With dgv1
                .DataSource = vl_DT1
                .AllowUserToAddRows = False
                .Columns(2).Visible = False
                .Columns(0).HeaderText = "Documento"
                .Columns(1).HeaderText = "Nombre documento"
                .Columns(3).HeaderText = "Serie"
                .Columns(4).HeaderText = "Número inicial"
                .Columns(5).HeaderText = "Siguiente número"
                .Columns(6).HeaderText = "Número final"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).Width = 100
                .Columns(6).Width = 100
                .Columns(4).DefaultCellStyle.Format = "###,###,###"
                .Columns(5).DefaultCellStyle.Format = "###,###,###"
                .Columns(6).DefaultCellStyle.Format = "###,###,###"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
        End If
    End Sub

#End Region
End Class