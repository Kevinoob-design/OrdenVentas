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

        //private void consultaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
         //  consulta_categoria nVolver_cctg = new consulta_categoria();
          // nVolver_cctg.Show();
          // this.Hide();
       // }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        //private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            //nueva_categoria nVolver_nctg = new nueva_categoria();
            //nVolver_nctg.Show();
            //this.Hide();
       // }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nueva_Categoria nVolver_nctg = new Nueva_Categoria();
            nVolver_nctg.Show();
            this.Hide();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo nVolver_nart = new Nuevo_Articulo();
            nVolver_nart.Show();
            this.Hide();
        }

        private void detallesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nueva_Venta nVolver_nvent = new Nueva_Venta();
            nVolver_nvent.Show();
            this.Hide();
        }

        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Ventas nVolver_dvent = new Detalle_Ventas();
            nVolver_dvent.Show();
            this.Hide();
        }
    }
}
