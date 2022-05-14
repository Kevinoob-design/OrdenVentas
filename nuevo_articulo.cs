using System;
using Libs;
using System;
using OV_Entidad;
using OV_Negocio;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OrdenVentas
{
    public partial class Nuevo_Articulo : Form
    {
        private List<Categoria> categorias = new List<Categoria>();
        public Nuevo_Articulo()
        {
            InitializeComponent();
            LoadCategorias();
            LoadDgv();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver_mm = new MainMenu();
            nVolver_mm.Show();
            this.Hide();
        }

        private void Tb_agregar_nart_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> parameters = Utils.GetCollectionKeyValueFromControlsTags(ArticuloGroupBox);

                parameters["IDCATEGORIA"] = categorias.Find(categoria => categoria.NOMBRE == parameters["IDCATEGORIA"]).IDCATEGORIA.ToString();

                CategoriaDto dto = new CategoriaDto();

                dto.Guardar(StoredProcedures.guardarArticulo, parameters, "IDARTICULO");

                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bt_actualizar_nart_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> parameters = Utils.GetCollectionKeyValueFromControlsTags(ArticuloGroupBox);

                parameters["IDCATEGORIA"] = categorias.Find(categoria => categoria.NOMBRE == parameters["IDCATEGORIA"]).IDCATEGORIA.ToString();

                ArticuloDto dto = new ArticuloDto();

                dto.Actualizar(StoredProcedures.actualizarArticulo, parameters, "IDARTICULO");

                MessageBox.Show($"Articulo {parameters["IDARTICULO"]} actualizado correctamente");

                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bt_nuevo_nart_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            Utils.SetControlsChildWithValueFromCollection(articulo, ArticuloGroupBox);
        }

        private void LoadCategorias()
        {
            try
            {
                CategoriaDto dto = new CategoriaDto();

                categorias = dto.Consultar<Categoria>(StoredProcedures.consultarCategoria);

                Dictionary<int, string> parameters = new Dictionary<int, string>();

                foreach (Categoria categoria in categorias)
                {
                    parameters.Add(categoria.IDCATEGORIA, categoria.NOMBRE);
                }

                comboBox_nart.DataSource = new BindingSource(parameters, null);

                comboBox_nart.DisplayMember = "Value";
                comboBox_nart.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDgv()
        {
            try
            {
                ArticuloDto dto = new ArticuloDto();

                dgv.DataSource = dto.ConsultarToDs(StoredProcedures.consultarArticulo, Tables.ARTICULO);

                dgv.DataMember = Tables.ARTICULO.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView cell = (DataGridView)sender;

            Articulo articulo = new Articulo();

            foreach (DataGridViewCell item in cell.Rows[e.RowIndex].Cells)
            {
                string header = item.OwningColumn.HeaderText;
                object value = item.Value;

                articulo = Utils.MapBoxedFromKeyValue(articulo, header, value);
            }

            Utils.SetControlsChildWithValueFromCollection(articulo, ArticuloGroupBox);
        }
    }
}
