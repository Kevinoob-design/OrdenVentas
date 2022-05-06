namespace OrdenVentas
{
    partial class nuevo_articulo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_idarticulo_nart = new System.Windows.Forms.TextBox();
            this.tb_codigo_nart = new System.Windows.Forms.TextBox();
            this.tb_nombre_nart = new System.Windows.Forms.TextBox();
            this.tb_precio_nart = new System.Windows.Forms.TextBox();
            this.tb_stock_nart = new System.Windows.Forms.TextBox();
            this.tb_descripcion_nart = new System.Windows.Forms.TextBox();
            this.tb_estado_nart = new System.Windows.Forms.TextBox();
            this.comboBox_nart = new System.Windows.Forms.ComboBox();
            this.tb_agregar_nart = new System.Windows.Forms.Button();
            this.bt_actualizar_nart = new System.Windows.Forms.Button();
            this.bt_nuevo_nart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(216, 29);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver al Menu Principal";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(997, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estado";
            // 
            // tb_idarticulo_nart
            // 
            this.tb_idarticulo_nart.Location = new System.Drawing.Point(195, 56);
            this.tb_idarticulo_nart.Name = "tb_idarticulo_nart";
            this.tb_idarticulo_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_idarticulo_nart.TabIndex = 10;
            // 
            // tb_codigo_nart
            // 
            this.tb_codigo_nart.Location = new System.Drawing.Point(195, 126);
            this.tb_codigo_nart.Name = "tb_codigo_nart";
            this.tb_codigo_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_codigo_nart.TabIndex = 11;
            // 
            // tb_nombre_nart
            // 
            this.tb_nombre_nart.Location = new System.Drawing.Point(195, 161);
            this.tb_nombre_nart.Name = "tb_nombre_nart";
            this.tb_nombre_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_nombre_nart.TabIndex = 12;
            // 
            // tb_precio_nart
            // 
            this.tb_precio_nart.Location = new System.Drawing.Point(195, 200);
            this.tb_precio_nart.Name = "tb_precio_nart";
            this.tb_precio_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_precio_nart.TabIndex = 13;
            // 
            // tb_stock_nart
            // 
            this.tb_stock_nart.Location = new System.Drawing.Point(195, 235);
            this.tb_stock_nart.Name = "tb_stock_nart";
            this.tb_stock_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_stock_nart.TabIndex = 14;
            // 
            // tb_descripcion_nart
            // 
            this.tb_descripcion_nart.Location = new System.Drawing.Point(195, 267);
            this.tb_descripcion_nart.Name = "tb_descripcion_nart";
            this.tb_descripcion_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_descripcion_nart.TabIndex = 15;
            // 
            // tb_estado_nart
            // 
            this.tb_estado_nart.Location = new System.Drawing.Point(195, 305);
            this.tb_estado_nart.Name = "tb_estado_nart";
            this.tb_estado_nart.Size = new System.Drawing.Size(173, 26);
            this.tb_estado_nart.TabIndex = 16;
            // 
            // comboBox_nart
            // 
            this.comboBox_nart.FormattingEnabled = true;
            this.comboBox_nart.Location = new System.Drawing.Point(195, 91);
            this.comboBox_nart.Name = "comboBox_nart";
            this.comboBox_nart.Size = new System.Drawing.Size(173, 28);
            this.comboBox_nart.TabIndex = 17;
            // 
            // tb_agregar_nart
            // 
            this.tb_agregar_nart.Location = new System.Drawing.Point(712, 85);
            this.tb_agregar_nart.Name = "tb_agregar_nart";
            this.tb_agregar_nart.Size = new System.Drawing.Size(134, 59);
            this.tb_agregar_nart.TabIndex = 18;
            this.tb_agregar_nart.Text = "Agregar";
            this.tb_agregar_nart.UseVisualStyleBackColor = true;
            // 
            // bt_actualizar_nart
            // 
            this.bt_actualizar_nart.Location = new System.Drawing.Point(712, 165);
            this.bt_actualizar_nart.Name = "bt_actualizar_nart";
            this.bt_actualizar_nart.Size = new System.Drawing.Size(134, 62);
            this.bt_actualizar_nart.TabIndex = 19;
            this.bt_actualizar_nart.Text = "Actualizar";
            this.bt_actualizar_nart.UseVisualStyleBackColor = true;
            // 
            // bt_nuevo_nart
            // 
            this.bt_nuevo_nart.Location = new System.Drawing.Point(712, 250);
            this.bt_nuevo_nart.Name = "bt_nuevo_nart";
            this.bt_nuevo_nart.Size = new System.Drawing.Size(134, 61);
            this.bt_nuevo_nart.TabIndex = 20;
            this.bt_nuevo_nart.Text = "Nueva Entrada";
            this.bt_nuevo_nart.UseVisualStyleBackColor = true;
            // 
            // nuevo_articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 518);
            this.Controls.Add(this.bt_nuevo_nart);
            this.Controls.Add(this.bt_actualizar_nart);
            this.Controls.Add(this.tb_agregar_nart);
            this.Controls.Add(this.comboBox_nart);
            this.Controls.Add(this.tb_estado_nart);
            this.Controls.Add(this.tb_descripcion_nart);
            this.Controls.Add(this.tb_stock_nart);
            this.Controls.Add(this.tb_precio_nart);
            this.Controls.Add(this.tb_nombre_nart);
            this.Controls.Add(this.tb_codigo_nart);
            this.Controls.Add(this.tb_idarticulo_nart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "nuevo_articulo";
            this.Text = "Articulos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_idarticulo_nart;
        private System.Windows.Forms.TextBox tb_codigo_nart;
        private System.Windows.Forms.TextBox tb_nombre_nart;
        private System.Windows.Forms.TextBox tb_precio_nart;
        private System.Windows.Forms.TextBox tb_stock_nart;
        private System.Windows.Forms.TextBox tb_descripcion_nart;
        private System.Windows.Forms.TextBox tb_estado_nart;
        private System.Windows.Forms.ComboBox comboBox_nart;
        private System.Windows.Forms.Button tb_agregar_nart;
        private System.Windows.Forms.Button bt_actualizar_nart;
        private System.Windows.Forms.Button bt_nuevo_nart;
    }
}