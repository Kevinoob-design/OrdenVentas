using Libs;
using OV_Entidad;
using OV_Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdenVentas
{
    public partial class Nuevo_Contacto : Form
    {
        public Nuevo_Contacto(int? ID = 0)
        {
            if (ID > 0) tbcodigo_nc.Text = ID.ToString();

            InitializeComponent();
            LoadDgv();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver = new MainMenu();
            nVolver.Show();
            this.Hide();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Contacto nVolver_CC = new Consulta_Contacto();
            nVolver_CC.Show();
            this.Hide();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> clienteParams = Utils.GetCollectionKeyValueFromControlsTags(MantenimientoClientePanel);

            ClienteDto clienteDto = new ClienteDto();

            clienteDto.Guardar(StoredProcedures.guardarCliente, clienteParams, "IDCLIENTE");

            LoadDgv();
        }

        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> clienteParams = Utils.GetCollectionKeyValueFromControlsTags(MantenimientoClientePanel);

                ClienteDto clienteDto = new ClienteDto();

                clienteDto.Actualizar(StoredProcedures.actualizarCliente, clienteParams, "IDCLIENTE");

                MessageBox.Show($"Contacto {clienteParams["IDCLIENTE"]} actualizado correctamente");

                LoadDgv();
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
                ClienteDto clienteDto = new ClienteDto();

                ClientesDgv.DataSource = clienteDto.ConsultarToDs(StoredProcedures.consultarClientes, Tables.CLIENTES);

                string tableConsultarClientes = Tables.CLIENTES.ToString();

                ClientesDgv.DataMember = tableConsultarClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView cell = (DataGridView)sender;

            Cliente cliente = new Cliente();

            foreach (DataGridViewCell item in cell.Rows[e.RowIndex].Cells)
            {
                string header = item.OwningColumn.HeaderText;
                object value = item.Value;

                cliente = Utils.MapBoxedFromKeyValue(cliente, header, value);
            }

            Utils.SetControlsChildWithValueFromCollection(cliente, MantenimientoClientePanel);
        }

        private void NuevaEntrada_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            Utils.SetControlsChildWithValueFromCollection(cliente, MantenimientoClientePanel);
        }
    }
}
