using System;
using System.Collections.Generic;
using Libs;
using OV_Entidad;
using OV_Negocio;
using System.Windows.Forms;

namespace OrdenVentas
{
    public partial class Detalle_Ventas : Form
    {
        public Detalle_Ventas()
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

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nueva_Venta nVolver_nvent = new Nueva_Venta();
            nVolver_nvent.Show();
            this.Hide();
        }

        private void LoadDgv()
        {
            try
            {
                DetalleVentaDto dto = new DetalleVentaDto();

                dgv.DataSource = dto.ConsultarToDs(StoredProcedures.consultarDetalleVentas, Tables.VENTA);

                dgv.DataMember = Tables.VENTA.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
