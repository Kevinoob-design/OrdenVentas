namespace OrdenVentas
{
    partial class Nueva_Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Venta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboVendedor = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo_comp = new System.Windows.Forms.ComboBox();
            this.tb_idventa_nv = new System.Windows.Forms.TextBox();
            this.tb_se_combrobante = new System.Windows.Forms.TextBox();
            this.tb_imp_nv = new System.Windows.Forms.TextBox();
            this.tb_total_nv = new System.Windows.Forms.TextBox();
            this.bt_guardar_nv = new System.Windows.Forms.Button();
            this.bt_consultar_nv = new System.Windows.Forms.Button();
            this.bt_nueva_nv = new System.Windows.Forms.Button();
            this.VentaGroupBx = new System.Windows.Forms.GroupBox();
            this.comboBoxArticulos = new System.Windows.Forms.ComboBox();
            this.ArticuloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.VentaGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuPrincipalToolStripMenuItem,
            this.detalleVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver al Menu Principal";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // detalleVentasToolStripMenuItem
            // 
            this.detalleVentasToolStripMenuItem.Name = "detalleVentasToolStripMenuItem";
            this.detalleVentasToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.detalleVentasToolStripMenuItem.Text = "Detalle Ventas";
            this.detalleVentasToolStripMenuItem.Click += new System.EventHandler(this.detalleVentasToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NCF -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Serie Comprobante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Imps %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total";
            // 
            // comboVendedor
            // 
            this.comboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVendedor.FormattingEnabled = true;
            this.comboVendedor.Location = new System.Drawing.Point(15, 27);
            this.comboVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.comboVendedor.Name = "comboVendedor";
            this.comboVendedor.Size = new System.Drawing.Size(109, 21);
            this.comboVendedor.TabIndex = 13;
            this.comboVendedor.Tag = "IDUSUARIO";
            // 
            // comboBox_tipo_comp
            // 
            this.comboBox_tipo_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_comp.FormattingEnabled = true;
            this.comboBox_tipo_comp.Items.AddRange(new object[] {
            "Consumidor",
            "Credito Fiscal"});
            this.comboBox_tipo_comp.Location = new System.Drawing.Point(311, 27);
            this.comboBox_tipo_comp.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_tipo_comp.Name = "comboBox_tipo_comp";
            this.comboBox_tipo_comp.Size = new System.Drawing.Size(109, 21);
            this.comboBox_tipo_comp.TabIndex = 14;
            this.comboBox_tipo_comp.Tag = "TIPO_COMPROBANTE";
            // 
            // tb_idventa_nv
            // 
            this.tb_idventa_nv.Enabled = false;
            this.tb_idventa_nv.Location = new System.Drawing.Point(11, 105);
            this.tb_idventa_nv.Margin = new System.Windows.Forms.Padding(2);
            this.tb_idventa_nv.Name = "tb_idventa_nv";
            this.tb_idventa_nv.ReadOnly = true;
            this.tb_idventa_nv.Size = new System.Drawing.Size(76, 20);
            this.tb_idventa_nv.TabIndex = 15;
            this.tb_idventa_nv.Tag = "IDVENTA";
            // 
            // tb_se_combrobante
            // 
            this.tb_se_combrobante.Location = new System.Drawing.Point(626, 107);
            this.tb_se_combrobante.Margin = new System.Windows.Forms.Padding(2);
            this.tb_se_combrobante.Name = "tb_se_combrobante";
            this.tb_se_combrobante.Size = new System.Drawing.Size(111, 20);
            this.tb_se_combrobante.TabIndex = 17;
            this.tb_se_combrobante.Tag = "SERIE_COMPROBANTE";
            // 
            // tb_imp_nv
            // 
            this.tb_imp_nv.Enabled = false;
            this.tb_imp_nv.Location = new System.Drawing.Point(432, 107);
            this.tb_imp_nv.Margin = new System.Windows.Forms.Padding(2);
            this.tb_imp_nv.Name = "tb_imp_nv";
            this.tb_imp_nv.ReadOnly = true;
            this.tb_imp_nv.Size = new System.Drawing.Size(75, 20);
            this.tb_imp_nv.TabIndex = 19;
            this.tb_imp_nv.Tag = "IMPUESTO";
            this.tb_imp_nv.Text = "18";
            // 
            // tb_total_nv
            // 
            this.tb_total_nv.Enabled = false;
            this.tb_total_nv.Location = new System.Drawing.Point(511, 107);
            this.tb_total_nv.Margin = new System.Windows.Forms.Padding(2);
            this.tb_total_nv.Name = "tb_total_nv";
            this.tb_total_nv.ReadOnly = true;
            this.tb_total_nv.Size = new System.Drawing.Size(111, 20);
            this.tb_total_nv.TabIndex = 20;
            this.tb_total_nv.Tag = "TOTAL";
            // 
            // bt_guardar_nv
            // 
            this.bt_guardar_nv.Location = new System.Drawing.Point(505, 153);
            this.bt_guardar_nv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_guardar_nv.Name = "bt_guardar_nv";
            this.bt_guardar_nv.Size = new System.Drawing.Size(79, 38);
            this.bt_guardar_nv.TabIndex = 22;
            this.bt_guardar_nv.Text = "Guardar";
            this.bt_guardar_nv.UseVisualStyleBackColor = true;
            this.bt_guardar_nv.Click += new System.EventHandler(this.Bt_guardar_nv_Click);
            // 
            // bt_consultar_nv
            // 
            this.bt_consultar_nv.Location = new System.Drawing.Point(588, 153);
            this.bt_consultar_nv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_consultar_nv.Name = "bt_consultar_nv";
            this.bt_consultar_nv.Size = new System.Drawing.Size(71, 38);
            this.bt_consultar_nv.TabIndex = 23;
            this.bt_consultar_nv.Text = "Consultar";
            this.bt_consultar_nv.UseVisualStyleBackColor = true;
            this.bt_consultar_nv.Click += new System.EventHandler(this.Bt_consultar_nv_Click);
            // 
            // bt_nueva_nv
            // 
            this.bt_nueva_nv.Location = new System.Drawing.Point(663, 153);
            this.bt_nueva_nv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_nueva_nv.Name = "bt_nueva_nv";
            this.bt_nueva_nv.Size = new System.Drawing.Size(77, 38);
            this.bt_nueva_nv.TabIndex = 24;
            this.bt_nueva_nv.Text = "Nueva Entrada";
            this.bt_nueva_nv.UseVisualStyleBackColor = true;
            this.bt_nueva_nv.Click += new System.EventHandler(this.Bt_nueva_nv_Click);
            // 
            // VentaGroupBx
            // 
            this.VentaGroupBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VentaGroupBx.Controls.Add(this.comboBoxArticulos);
            this.VentaGroupBx.Controls.Add(this.ArticuloLabel);
            this.VentaGroupBx.Controls.Add(this.label1);
            this.VentaGroupBx.Controls.Add(this.textBox2);
            this.VentaGroupBx.Controls.Add(this.textBox1);
            this.VentaGroupBx.Controls.Add(this.comboClientes);
            this.VentaGroupBx.Controls.Add(this.bt_nueva_nv);
            this.VentaGroupBx.Controls.Add(this.tb_total_nv);
            this.VentaGroupBx.Controls.Add(this.bt_consultar_nv);
            this.VentaGroupBx.Controls.Add(this.bt_guardar_nv);
            this.VentaGroupBx.Controls.Add(this.tb_imp_nv);
            this.VentaGroupBx.Controls.Add(this.label2);
            this.VentaGroupBx.Controls.Add(this.label4);
            this.VentaGroupBx.Controls.Add(this.tb_se_combrobante);
            this.VentaGroupBx.Controls.Add(this.tb_idventa_nv);
            this.VentaGroupBx.Controls.Add(this.comboBox_tipo_comp);
            this.VentaGroupBx.Controls.Add(this.comboVendedor);
            this.VentaGroupBx.Controls.Add(this.label10);
            this.VentaGroupBx.Controls.Add(this.label9);
            this.VentaGroupBx.Controls.Add(this.label7);
            this.VentaGroupBx.Controls.Add(this.label6);
            this.VentaGroupBx.Controls.Add(this.label5);
            this.VentaGroupBx.Controls.Add(this.label3);
            this.VentaGroupBx.Location = new System.Drawing.Point(0, 26);
            this.VentaGroupBx.Margin = new System.Windows.Forms.Padding(2);
            this.VentaGroupBx.Name = "VentaGroupBx";
            this.VentaGroupBx.Padding = new System.Windows.Forms.Padding(2);
            this.VentaGroupBx.Size = new System.Drawing.Size(747, 195);
            this.VentaGroupBx.TabIndex = 25;
            this.VentaGroupBx.TabStop = false;
            // 
            // comboBoxArticulos
            // 
            this.comboBoxArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticulos.FormattingEnabled = true;
            this.comboBoxArticulos.Location = new System.Drawing.Point(204, 106);
            this.comboBoxArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArticulos.Name = "comboBoxArticulos";
            this.comboBoxArticulos.Size = new System.Drawing.Size(109, 21);
            this.comboBoxArticulos.TabIndex = 30;
            this.comboBoxArticulos.Tag = "IDARTICULO";
            // 
            // ArticuloLabel
            // 
            this.ArticuloLabel.AutoSize = true;
            this.ArticuloLabel.Location = new System.Drawing.Point(201, 81);
            this.ArticuloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArticuloLabel.Name = "ArticuloLabel";
            this.ArticuloLabel.Size = new System.Drawing.Size(42, 13);
            this.ArticuloLabel.TabIndex = 29;
            this.ArticuloLabel.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descuentos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 107);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Tag = "DESCUENTO";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(485, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Tag = "NUM_COMPROBANTE";
            this.textBox1.Text = "B0200540";
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(91, 105);
            this.comboClientes.Margin = new System.Windows.Forms.Padding(2);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(109, 21);
            this.comboClientes.TabIndex = 25;
            this.comboClientes.Tag = "IDCONTACTO";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 221);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(747, 302);
            this.dgv.TabIndex = 26;
            // 
            // Nueva_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 534);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.VentaGroupBx);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nueva_Venta";
            this.Text = "Choreto App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.VentaGroupBx.ResumeLayout(false);
            this.VentaGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleVentasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboVendedor;
        private System.Windows.Forms.ComboBox comboBox_tipo_comp;
        private System.Windows.Forms.TextBox tb_idventa_nv;
        private System.Windows.Forms.TextBox tb_se_combrobante;
        private System.Windows.Forms.TextBox tb_imp_nv;
        private System.Windows.Forms.TextBox tb_total_nv;
        private System.Windows.Forms.Button bt_guardar_nv;
        private System.Windows.Forms.Button bt_consultar_nv;
        private System.Windows.Forms.Button bt_nueva_nv;
        private System.Windows.Forms.GroupBox VentaGroupBx;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxArticulos;
        private System.Windows.Forms.Label ArticuloLabel;
        private System.Windows.Forms.DataGridView dgv;
    }
}