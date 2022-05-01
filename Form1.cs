﻿using OV_Datos;
using OV_Entidad;
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
            GetDataFromDB();
        }

        public void GetDataFromDB()
        {
            List<UserForTest> users = DbAdapter.LoadTable<UserForTest>("[USER]");

            Utils.SetControlsChildWithValueFromCollection(users[0], panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> keyValues = Utils.GetCollectionKeyValueFromControlsTags(panel1);

            Console.Write(keyValues);
        }
    }
}
