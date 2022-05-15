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

        public Nueva_Venta()
        {
            InitializeComponent();
            LoadContactos();
            LoadDgv();
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
                Dictionary<string, string> parameters = Utils.GetCollectionKeyValueFromControlsTags(VentaGroupBx);

                parameters["IDUSUARIO"] = usuarios.Find(usuario => usuario.NOMBRE == parameters["IDUSUARIO"]).IDUSUARIO.ToString();

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

        private void LoadContactos()
        {
            try
            {
                ContactoDto dto = new ContactoDto();

                contactos = dto.Consultar<Contacto>(StoredProcedures.consultarClientes);

                usuarios = dto.Consultar<Usuario>(StoredProcedures.consultarUsuario);

                Dictionary<int, string> parameters = new Dictionary<int, string>();

                foreach (Contacto contacto in contactos)
                {
                    parameters.Add(contacto.IDCLIENTE, contacto.NOMBRE);
                }

                foreach (Usuario usuario in usuarios)
                {
                    parameters.Add(usuario.IDUSUARIO, usuario.NOMBRE);
                }

                comboVendedor.DataSource = new BindingSource(parameters, null);

                comboVendedor.DisplayMember = "Value";
                comboVendedor.ValueMember = "Key";
                comboClientes.DisplayMember = "Value";
                comboClientes.ValueMember = "Key";
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
