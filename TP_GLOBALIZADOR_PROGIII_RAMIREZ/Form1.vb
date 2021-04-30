Imports System.IO

'EN EL ENUNCIADO NO DICE ESPECIFICAMENTE DE USAR LA HERRAMIENTA SAVEFILEDIALOG PARA EXPORTAR
'ME PARECIO CONVENIENTE USARLA, YA QUE PARA EXPORTAR CUMPLE SU FUNCION

Public Class frmExportar

    Private Sub frmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        CargarGrilla()

        pbBarra.Visible = False

    End Sub

    Private Sub CargarGrilla()

        Dim CadenaSQL As String
        Dim Tabla As DataTable

        If txtVariedad.Text.Trim = String.Empty Then

            CadenaSQL = " SELECT Variedades.IdVariedad, Variedades.Codigo, Variedades.Variedad, Variedades.Precio, Variedades.FechaPublicacion, Variedades.Estado, Categorias.IdCategoria, Categorias.Categoria"
            CadenaSQL = CadenaSQL & " FROM Variedades,Categorias"
            CadenaSQL = CadenaSQL & " WHERE Variedades.IdCategoria = Categorias.IdCategoria"

        Else

            CadenaSQL = "SELECT Variedades.IdVariedad, Variedades.Codigo, Variedades.Variedad, Variedades.Precio, Variedades.FechaPublicacion, Variedades.Estado, Categorias.IdCategoria, Categorias.Categoria"
            CadenaSQL = CadenaSQL & " FROM Variedades,Categorias"
            CadenaSQL = CadenaSQL & " WHERE Variedades.IdCategoria = Categorias.IdCategoria and Variedad like '" & txtVariedad.Text.Trim & "%' order by Variedad asc"

        End If

        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        DGVProductos.DataSource = Tabla
        DGVProductos.Columns("IdVariedad").Visible = False
        DGVProductos.Columns("IdCategoria").Visible = False
        DGVProductos.AllowUserToAddRows = False
        DGVProductos.AllowUserToDeleteRows = False
        DGVProductos.ReadOnly = True
        DGVProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub BarraProgreso()

        pbBarra.Minimum = 0
        pbBarra.Maximum = DGVProductos.Rows.Count

        For i = 0 To DGVProductos.Rows.Count - 1

            pbBarra.Visible = True
            pbBarra.Increment(+1)
            pbBarra.Value = i + 1

        Next

    End Sub

    Private Sub txtVariedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVariedad.KeyPress

        CargarGrilla()

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click

        Dim Archivo As FileStream
        Dim Grabador As StreamWriter
        Dim Linea As String = Nothing

        SFDExportar.AddExtension = True
        SFDExportar.DefaultExt = "*.txt"
        SFDExportar.Filter = "Archivo de texto (.txt)|*.txt"
        SFDExportar.InitialDirectory = Application.StartupPath
        SFDExportar.OverwritePrompt = False
        SFDExportar.FileName = String.Empty

        If DGVProductos.Rows.Count = 0 Then

            MessageBox.Show("No hay registros a exportar", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVariedad.Text = String.Empty
            CargarGrilla()

        Else

            If SFDExportar.ShowDialog = DialogResult.OK Then

                Archivo = New FileStream(SFDExportar.FileName, FileMode.Append)
                Grabador = New StreamWriter(Archivo)

                With DGVProductos

                    For i = 0 To .RowCount - 1

                        Linea = .Rows(i).Cells(1).Value.ToString + ";" &
                                .Rows(i).Cells(2).Value.ToString + ";" &
                                .Rows(i).Cells(3).Value.ToString + ";" &
                                .Rows(i).Cells(4).Value.ToString + ";" &
                                .Rows(i).Cells(5).Value.ToString + ";" &
                                .Rows(i).Cells(7).Value.ToString

                        BarraProgreso()
                        Grabador.WriteLine(Linea)

                    Next

                    MessageBox.Show("Proceso de Exportacion Finalizado.", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtVariedad.Text = String.Empty
                    pbBarra.Value = 0
                    pbBarra.Visible = False

                End With

                Grabador.Close()
                Archivo.Close()

            End If

        End If

    End Sub

End Class
