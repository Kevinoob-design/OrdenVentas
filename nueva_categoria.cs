﻿using System;
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
    public partial class nueva_categoria : Form
    {
        public nueva_categoria()
        {
            InitializeComponent();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu nVolver_mm = new MainMenu();
            nVolver_mm.Show();
            this.Hide();
        }
    }
}