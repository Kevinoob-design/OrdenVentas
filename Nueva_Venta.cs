using System;
using System.Collections.Generic;
using Libs;
using OV_Entidad;
using OV_Negocio;
using System.Windows.Forms;

namespace OrdenVentas
{
    public partial class Nueva_Venta : Form
    {
        private List<Contacto> contactos = new List<Contacto>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Articulo> articulos = new List<Articulo>();

        public Nueva_Venta()
        {
            InitializeComponent();
            LoadAll();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver_mm = new MainMenu();
            nVolver_mm.Show();
            this.Hide();
        }

        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Ventas nVolver_dvent = new Detalle_Ventas();
            nVolver_dvent.Show();
            this.Hide();
        }

        private void Bt_guardar_nv_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<dynamic, string> parameters = Utils.GetCollectionKeyValueFromControlsTags(VentaGroupBx);

                parameters["IDUSUARIO"] = "1"; // usuarios.Find(usuario => usuario.NOMBRE == parameters["IDUSUARIO"]).IDUSUARIO.ToString();

                parameters["IDCLIENTE"] = contactos.Find(contacto => contacto.NOMBRE == parameters["IDCLIENTE"]).IDCLIENTE.ToString();

                Articulo articulo = articulos.Find(usuario => usuario.NOMBRE == parameters["IDARTICULO"]);

                parameters["IDARTICULO"] = articulo.IDARTICULO.ToString();

                parameters["TOTAL"] = (articulo.PRECIO_VENTA - Convert.ToInt32(parameters["DESCUENTO"])).ToString();

                // parameters["FECHA_HORA"] = DateTime.Now.ToString("dd/MM/yyyy");

                ContactoDto dto = new ContactoDto();

                dto.Guardar(StoredProcedures.guardarVenta, parameters, "IDVENTA");

                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bt_consultar_nv_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void Bt_nueva_nv_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            Utils.SetControlsChildWithValueFromCollection(venta, VentaGroupBx);
        }

        private void LoadAll()
        {
            try
            {
                LoadUsuarios();
                LoadContactos();
                LoadArticulos();
                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadContactos()
        {
            try
            {
                ContactoDto dto = new ContactoDto();

                contactos = dto.Consultar<Contacto>(StoredProcedures.consultarClientes);

                Dictionary<int, string> parameters = new Dictionary<int, string>();

                foreach (Contacto contacto in contactos)
                {
                    parameters.Add(contacto.IDCLIENTE, contacto.NOMBRE);
                }

                comboClientes.DataSource = new BindingSource(parameters, null);

                comboClientes.DisplayMember = "Value";
                comboClientes.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadUsuarios()
        {
            try
            {
                ContactoDto dto = new ContactoDto();

                usuarios = dto.Consultar<Usuario>(StoredProcedures.consultarUsuario);

                Dictionary<int, string> parameters = new Dictionary<int, string>();

                foreach (Usuario usuario in usuarios)
                {
                    parameters.Add(usuario.IDUSUARIO, usuario.NOMBRE);
                }

                comboVendedor.DataSource = new BindingSource(parameters, null);

                comboVendedor.DisplayMember = "Value";
                comboVendedor.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadArticulos()
        {
            try
            {
                ArticuloDto dto = new ArticuloDto();

                articulos = dto.Consultar<Articulo>(StoredProcedures.consultarArticulo);

                Dictionary<int, string> parameters = new Dictionary<int, string>();

                foreach (Articulo articulo in articulos)
                {
                    parameters.Add(articulo.IDARTICULO, articulo.NOMBRE);
                }

                comboBoxArticulos.DataSource = new BindingSource(parameters, null);

                comboBoxArticulos.DisplayMember = "Value";
                comboBoxArticulos.ValueMember = "Key";
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
                VentaDto dto = new VentaDto();

                dgv.DataSource = dto.ConsultarToDs(StoredProcedures.consultarVentas, Tables.VENTA);

                dgv.DataMember = Tables.VENTA.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
