using System;
using System.Windows.Forms;
using OV_Datos;

namespace OrdenVentas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbAdapter.InitializeConnection();
            Application.Run(new MainMenu());
        }
    }
}
