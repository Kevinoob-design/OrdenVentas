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
    public partial class Consulta_Cliente : Form
    {
        public Consulta_Cliente()
        {
            InitializeComponent();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver = new MainMenu();
            nVolver.Show();
            this.Hide();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Cliente nVolver_nc = new Nuevo_Cliente();
            nVolver_nc.Show();
            this.Hide();
        }
    }
}
