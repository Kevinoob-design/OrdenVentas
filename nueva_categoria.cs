using Libs;
using System;
using OV_Entidad;
using OV_Negocio;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OrdenVentas
{
    public partial class Nueva_Categoria : Form
    {
        public Nueva_Categoria()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver_mm = new MainMenu();
            nVolver_mm.Show();
            this.Hide();
        }

        private void Bagregar_nctg_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> parameters = Utils.GetCollectionKeyValueFromControlsTags(CategoriaPanel);

                CategoriaDto dto = new CategoriaDto();

                dto.Guardar(StoredProcedures.guardarCategoria, parameters, "IDCATEGORIA");

                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bactualizar_nctg_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> parameters = Utils.GetCollectionKeyValueFromControlsTags(CategoriaPanel);

                CategoriaDto dto = new CategoriaDto();

                dto.Actualizar(StoredProcedures.actualizarCategoria, parameters, "IDCATEGORIA");

                MessageBox.Show($"Categoria {parameters["IDCATEGORIA"]} actualizada correctamente");

                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bnueva_entrada_nctg_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            Utils.SetControlsChildWithValueFromCollection(categoria, CategoriaPanel);
        }

        private void LoadDgv()
        {
            try
            {
                CategoriaDto dto = new CategoriaDto();

                dataGridView_nctg.DataSource = dto.ConsultarToDs(StoredProcedures.consultarCategoria, Tables.CATEGORIA);

                dataGridView_nctg.DataMember = Tables.CATEGORIA.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0) return;

            DataGridView cell = (DataGridView)sender;

            Categoria categoria = new Categoria();

            foreach (DataGridViewCell item in cell.Rows[e.RowIndex].Cells)
            {
                string header = item.OwningColumn.HeaderText;
                object value = item.Value;

                categoria = Utils.MapBoxedFromKeyValue(categoria, header, value);
            }

            Utils.SetControlsChildWithValueFromCollection(categoria, CategoriaPanel);
        }
    }
}
