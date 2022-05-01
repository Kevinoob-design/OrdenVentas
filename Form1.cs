using OrdenVentas.db;
using OrdenVentas.entities;
using OrdenVentas.shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdenVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DbAdapter.InitializeConnection();
            GetDataFromDB();
        }

        public void GetDataFromDB()
        {
            List<User> users = DbAdapter.LoadTable<User>("[USER]");

            Utils.SetControlsChildWithValueFromCollection<User>(users[0], panel1);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Dictionary<string, string> keyValues = Utils.GetCollectionKeyValueFromControlsTags(panel1);

            Console.Write(keyValues);
        }
    }
}
