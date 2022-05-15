using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OV_Negocio;
using Libs;

namespace OrdenVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bacceso_Click(object sender, EventArgs e)
        {

            Dictionary<dynamic, string> usuarioParams = Utils.GetCollectionKeyValueFromControlsTags(LoginPanel);

            UsuarioDto usuarioDto = new UsuarioDto();

            bool isUsuarioLogedIn = usuarioDto.Login(usuarioParams);

            if (isUsuarioLogedIn)
            {
                MainMenu nMainMenu = new MainMenu();
                nMainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecto");
            }
        }
    }
}
