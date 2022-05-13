namespace OrdenVentas
{
    partial class Detalle_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_Ventas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_dv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_no_detalle_dv = new System.Windows.Forms.TextBox();
            this.tb_no_venta_dv = new System.Windows.Forms.TextBox();
            this.tb_no_arti_dv = new System.Windows.Forms.TextBox();
            this.tb_precio_dv = new System.Windows.Forms.TextBox();
            this.tb_guardar_dv = new System.Windows.Forms.Button();
            this.bt_consultar_dv = new System.Windows.Forms.Button();
            this.bt_nuevo_dv = new System.Windows.Forms.Button();
            this.comboBox_desc_dv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dv)).BeginInit();
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
            this.nuevaVentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(217, 29);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver al Menu principal";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // dataGridView_dv
            // 
            this.dataGridView_dv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dv.Location = new System.Drawing.Point(12, 346);
            this.dataGridView_dv.Name = "dataGridView_dv";
            this.dataGridView_dv.RowHeadersWidth = 62;
            this.dataGridView_dv.RowTemplate.Height = 28;
            this.dataGridView_dv.Size = new System.Drawing.Size(969, 150);
            this.dataGridView_dv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Detalle Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Articulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descuento %";
            // 
            // tb_no_detalle_dv
            // 
            this.tb_no_detalle_dv.Location = new System.Drawing.Point(13, 57);
            this.tb_no_detalle_dv.Name = "tb_no_detalle_dv";
            this.tb_no_detalle_dv.Size = new System.Drawing.Size(133, 26);
            this.tb_no_detalle_dv.TabIndex = 8;
            // 
            // tb_no_venta_dv
            // 
            this.tb_no_venta_dv.Location = new System.Drawing.Point(174, 56);
            this.tb_no_venta_dv.Name = "tb_no_venta_dv";
            this.tb_no_venta_dv.Size = new System.Drawing.Size(150, 26);
            this.tb_no_venta_dv.TabIndex = 9;
            // 
            // tb_no_arti_dv
            // 
            this.tb_no_arti_dv.Location = new System.Drawing.Point(351, 56);
            this.tb_no_arti_dv.Name = "tb_no_arti_dv";
            this.tb_no_arti_dv.Size = new System.Drawing.Size(172, 26);
            this.tb_no_arti_dv.TabIndex = 10;
            // 
            // tb_precio_dv
            // 
            this.tb_precio_dv.Location = new System.Drawing.Point(559, 56);
            this.tb_precio_dv.Name = "tb_precio_dv";
            this.tb_precio_dv.Size = new System.Drawing.Size(148, 26);
            this.tb_precio_dv.TabIndex = 11;
            // 
            // tb_guardar_dv
            // 
            this.tb_guardar_dv.Location = new System.Drawing.Point(524, 211);
            this.tb_guardar_dv.Name = "tb_guardar_dv";
            this.tb_guardar_dv.Size = new System.Drawing.Size(119, 66);
            this.tb_guardar_dv.TabIndex = 13;
            this.tb_guardar_dv.Text = "Guardar";
            this.tb_guardar_dv.UseVisualStyleBackColor = true;
            // 
            // bt_consultar_dv
            // 
            this.bt_consultar_dv.Location = new System.Drawing.Point(666, 211);
            this.bt_consultar_dv.Name = "bt_consultar_dv";
            this.bt_consultar_dv.Size = new System.Drawing.Size(116, 66);
            this.bt_consultar_dv.TabIndex = 14;
            this.bt_consultar_dv.Text = "Consultar";
            this.bt_consultar_dv.UseVisualStyleBackColor = true;
            // 
            // bt_nuevo_dv
            // 
            this.bt_nuevo_dv.Location = new System.Drawing.Point(813, 211);
            this.bt_nuevo_dv.Name = "bt_nuevo_dv";
            this.bt_nuevo_dv.Size = new System.Drawing.Size(116, 66);
            this.bt_nuevo_dv.TabIndex = 15;
            this.bt_nuevo_dv.Text = "Nueva Entrada";
            this.bt_nuevo_dv.UseVisualStyleBackColor = true;
            // 
            // comboBox_desc_dv
            // 
            this.comboBox_desc_dv.FormattingEnabled = true;
            this.comboBox_desc_dv.Location = new System.Drawing.Point(740, 57);
            this.comboBox_desc_dv.Name = "comboBox_desc_dv";
            this.comboBox_desc_dv.Size = new System.Drawing.Size(101, 28);
            this.comboBox_desc_dv.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_desc_dv);
            this.groupBox1.Controls.Add(this.bt_nuevo_dv);
            this.groupBox1.Controls.Add(this.bt_consultar_dv);
            this.groupBox1.Controls.Add(this.tb_guardar_dv);
            this.groupBox1.Controls.Add(this.tb_precio_dv);
            this.groupBox1.Controls.Add(this.tb_no_arti_dv);
            this.groupBox1.Controls.Add(this.tb_no_venta_dv);
            this.groupBox1.Controls.Add(this.tb_no_detalle_dv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 292);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Detalle_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_dv);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Detalle_Ventas";
            this.Text = "Choreto App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_dv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_no_detalle_dv;
        private System.Windows.Forms.TextBox tb_no_venta_dv;
        private System.Windows.Forms.TextBox tb_no_arti_dv;
        private System.Windows.Forms.TextBox tb_precio_dv;
        private System.Windows.Forms.Button tb_guardar_dv;
        private System.Windows.Forms.Button bt_consultar_dv;
        private System.Windows.Forms.Button bt_nuevo_dv;
        private System.Windows.Forms.ComboBox comboBox_desc_dv;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}