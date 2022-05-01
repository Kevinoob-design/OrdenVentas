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
        public Nuevo_Cliente()
        {
            InitializeComponent();
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
    }
}
