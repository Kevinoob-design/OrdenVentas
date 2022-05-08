using OrdenVentas.shared;
using OV_Entidad;
using OV_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenVentas
{
    public partial class Nuevo_Cliente : Form
    {
        public Nuevo_Cliente(int? ID = 0)
        {
            if (ID > 0) tbcodigo_nc.Text = ID.ToString();

            InitializeComponent();
            LoadClientesDgv();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver = new MainMenu();
            nVolver.Show();
            this.Hide();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Cliente nVolver_CC = new Consulta_Cliente();
            nVolver_CC.Show();
            this.Hide();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> clienteParams = Utils.GetCollectionKeyValueFromControlsTags(MantenimientoClientePanel);

            ClienteDto clienteDto = new ClienteDto();

            clienteDto.guardar(clienteParams);

            LoadClientesDgv();
        }

        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> clienteParams = Utils.GetCollectionKeyValueFromControlsTags(MantenimientoClientePanel);

                ClienteDto clienteDto = new ClienteDto();

                clienteDto.actualizar(clienteParams);

                LoadClientesDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadClientesDgv()
        {
            try
            {
                Dictionary<string, string> clienteParams = new Dictionary<string, string>();

                ClienteDto clienteDto = new ClienteDto();

                DataSet ds = clienteDto.consultar(clienteParams);

                ClientesDgv.DataSource = ds;

                string tableConsultarClientes = tables.CLIENTES.ToString();

                ClientesDgv.DataMember = tableConsultarClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
