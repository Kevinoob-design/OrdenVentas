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
            this.dataGridView_nv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Num_Comp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_idusuario = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo_comp = new System.Windows.Forms.ComboBox();
            this.tb_idventa_nv = new System.Windows.Forms.TextBox();
            this.tb_idcliente_nv = new System.Windows.Forms.TextBox();
            this.tb_se_combrobante = new System.Windows.Forms.TextBox();
            this.tb_fecha_nv = new System.Windows.Forms.TextBox();
            this.tb_imp_nv = new System.Windows.Forms.TextBox();
            this.tb_total_nv = new System.Windows.Forms.TextBox();
            this.tb_estado_nv = new System.Windows.Forms.TextBox();
            this.bt_guardar_nv = new System.Windows.Forms.Button();
            this.bt_consultar_nv = new System.Windows.Forms.Button();
            this.bt_nueva_nv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuPrincipalToolStripMenuItem,
            this.detalleVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(216, 29);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver al Menu Principal";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // detalleVentasToolStripMenuItem
            // 
            this.detalleVentasToolStripMenuItem.Name = "detalleVentasToolStripMenuItem";
            this.detalleVentasToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.detalleVentasToolStripMenuItem.Text = "Detalle Ventas";
            this.detalleVentasToolStripMenuItem.Click += new System.EventHandler(this.detalleVentasToolStripMenuItem_Click);
            // 
            // dataGridView_nv
            // 
            this.dataGridView_nv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nv.Location = new System.Drawing.Point(12, 342);
            this.dataGridView_nv.Name = "dataGridView_nv";
            this.dataGridView_nv.RowHeadersWidth = 62;
            this.dataGridView_nv.RowTemplate.Height = 28;
            this.dataGridView_nv.Size = new System.Drawing.Size(1028, 150);
            this.dataGridView_nv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(874, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "NCF -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Serie Comprobante";
            // 
            // lb_Num_Comp
            // 
            this.lb_Num_Comp.AutoSize = true;
            this.lb_Num_Comp.Location = new System.Drawing.Point(930, 18);
            this.lb_Num_Comp.Name = "lb_Num_Comp";
            this.lb_Num_Comp.Size = new System.Drawing.Size(83, 20);
            this.lb_Num_Comp.TabIndex = 9;
            this.lb_Num_Comp.Text = "B0200540";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(586, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Imps %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(715, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(895, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Estado";
            // 
            // comboBox_idusuario
            // 
            this.comboBox_idusuario.FormattingEnabled = true;
            this.comboBox_idusuario.Location = new System.Drawing.Point(14, 41);
            this.comboBox_idusuario.Name = "comboBox_idusuario";
            this.comboBox_idusuario.Size = new System.Drawing.Size(161, 28);
            this.comboBox_idusuario.TabIndex = 13;
            // 
            // comboBox_tipo_comp
            // 
            this.comboBox_tipo_comp.FormattingEnabled = true;
            this.comboBox_tipo_comp.Location = new System.Drawing.Point(632, 41);
            this.comboBox_tipo_comp.Name = "comboBox_tipo_comp";
            this.comboBox_tipo_comp.Size = new System.Drawing.Size(161, 28);
            this.comboBox_tipo_comp.TabIndex = 14;
            // 
            // tb_idventa_nv
            // 
            this.tb_idventa_nv.Location = new System.Drawing.Point(6, 154);
            this.tb_idventa_nv.Name = "tb_idventa_nv";
            this.tb_idventa_nv.Size = new System.Drawing.Size(112, 26);
            this.tb_idventa_nv.TabIndex = 15;
            // 
            // tb_idcliente_nv
            // 
            this.tb_idcliente_nv.Location = new System.Drawing.Point(130, 154);
            this.tb_idcliente_nv.Name = "tb_idcliente_nv";
            this.tb_idcliente_nv.Size = new System.Drawing.Size(129, 26);
            this.tb_idcliente_nv.TabIndex = 16;
            // 
            // tb_se_combrobante
            // 
            this.tb_se_combrobante.Location = new System.Drawing.Point(276, 154);
            this.tb_se_combrobante.Name = "tb_se_combrobante";
            this.tb_se_combrobante.Size = new System.Drawing.Size(165, 26);
            this.tb_se_combrobante.TabIndex = 17;
            // 
            // tb_fecha_nv
            // 
            this.tb_fecha_nv.Location = new System.Drawing.Point(459, 154);
            this.tb_fecha_nv.Name = "tb_fecha_nv";
            this.tb_fecha_nv.Size = new System.Drawing.Size(113, 26);
            this.tb_fecha_nv.TabIndex = 18;
            // 
            // tb_imp_nv
            // 
            this.tb_imp_nv.Location = new System.Drawing.Point(590, 154);
            this.tb_imp_nv.Name = "tb_imp_nv";
            this.tb_imp_nv.Size = new System.Drawing.Size(111, 26);
            this.tb_imp_nv.TabIndex = 19;
            // 
            // tb_total_nv
            // 
            this.tb_total_nv.Location = new System.Drawing.Point(719, 154);
            this.tb_total_nv.Name = "tb_total_nv";
            this.tb_total_nv.Size = new System.Drawing.Size(164, 26);
            this.tb_total_nv.TabIndex = 20;
            // 
            // tb_estado_nv
            // 
            this.tb_estado_nv.Location = new System.Drawing.Point(899, 154);
            this.tb_estado_nv.Name = "tb_estado_nv";
            this.tb_estado_nv.Size = new System.Drawing.Size(100, 26);
            this.tb_estado_nv.TabIndex = 21;
            // 
            // bt_guardar_nv
            // 
            this.bt_guardar_nv.Location = new System.Drawing.Point(652, 211);
            this.bt_guardar_nv.Name = "bt_guardar_nv";
            this.bt_guardar_nv.Size = new System.Drawing.Size(119, 59);
            this.bt_guardar_nv.TabIndex = 22;
            this.bt_guardar_nv.Text = "Guardar";
            this.bt_guardar_nv.UseVisualStyleBackColor = true;
            // 
            // bt_consultar_nv
            // 
            this.bt_consultar_nv.Location = new System.Drawing.Point(777, 211);
            this.bt_consultar_nv.Name = "bt_consultar_nv";
            this.bt_consultar_nv.Size = new System.Drawing.Size(106, 59);
            this.bt_consultar_nv.TabIndex = 23;
            this.bt_consultar_nv.Text = "Consultar";
            this.bt_consultar_nv.UseVisualStyleBackColor = true;
            // 
            // bt_nueva_nv
            // 
            this.bt_nueva_nv.Location = new System.Drawing.Point(890, 211);
            this.bt_nueva_nv.Name = "bt_nueva_nv";
            this.bt_nueva_nv.Size = new System.Drawing.Size(116, 59);
            this.bt_nueva_nv.TabIndex = 24;
            this.bt_nueva_nv.Text = "Nueva Entrada";
            this.bt_nueva_nv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_estado_nv);
            this.groupBox1.Controls.Add(this.bt_nueva_nv);
            this.groupBox1.Controls.Add(this.tb_total_nv);
            this.groupBox1.Controls.Add(this.bt_consultar_nv);
            this.groupBox1.Controls.Add(this.bt_guardar_nv);
            this.groupBox1.Controls.Add(this.tb_imp_nv);
            this.groupBox1.Controls.Add(this.tb_fecha_nv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_se_combrobante);
            this.groupBox1.Controls.Add(this.tb_idcliente_nv);
            this.groupBox1.Controls.Add(this.tb_idventa_nv);
            this.groupBox1.Controls.Add(this.comboBox_tipo_comp);
            this.groupBox1.Controls.Add(this.comboBox_idusuario);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_Num_Comp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 300);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // Nueva_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_nv);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nueva_Venta";
            this.Text = "Choreto App";
            this.Load += new System.EventHandler(this.Nueva_Venta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleVentasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_nv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Num_Comp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_idusuario;
        private System.Windows.Forms.ComboBox comboBox_tipo_comp;
        private System.Windows.Forms.TextBox tb_idventa_nv;
        private System.Windows.Forms.TextBox tb_idcliente_nv;
        private System.Windows.Forms.TextBox tb_se_combrobante;
        private System.Windows.Forms.TextBox tb_fecha_nv;
        private System.Windows.Forms.TextBox tb_imp_nv;
        private System.Windows.Forms.TextBox tb_total_nv;
        private System.Windows.Forms.TextBox tb_estado_nv;
        private System.Windows.Forms.Button bt_guardar_nv;
        private System.Windows.Forms.Button bt_consultar_nv;
        private System.Windows.Forms.Button bt_nueva_nv;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}