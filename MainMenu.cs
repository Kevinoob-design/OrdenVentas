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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Cliente nConsultaC = new Consulta_Cliente();
            nConsultaC.Show();
            this.Hide();
        }

        private void nuevoClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nuevo_Cliente nCliente = new Nuevo_Cliente();
            nCliente.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login nVolver_lg = new Login();
            nVolver_lg.Show();
            this.Hide();
        }

        private void consultaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // consulta_categoria nVolver_cctg = new consulta_categoria();
           // nVolver_cctg.Show();
            //this.Hide();
        }
    }
}
