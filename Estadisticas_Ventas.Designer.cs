namespace OrdenVentas
{
    partial class Estadisticas_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas_Ventas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_ev = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_excel_ev = new System.Windows.Forms.Button();
            this.bt_pdf_ev = new System.Windows.Forms.Button();
            this.tb_ver_ev = new System.Windows.Forms.Button();
            this.tb_no_arti_ev = new System.Windows.Forms.TextBox();
            this.tb_no_venta_ev = new System.Windows.Forms.TextBox();
            this.tb_no_cliente_ev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vendedor_ev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ev)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(954, 33);
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
            // dataGridView_ev
            // 
            this.dataGridView_ev.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_ev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ev.Location = new System.Drawing.Point(12, 349);
            this.dataGridView_ev.Name = "dataGridView_ev";
            this.dataGridView_ev.RowHeadersWidth = 62;
            this.dataGridView_ev.RowTemplate.Height = 28;
            this.dataGridView_ev.Size = new System.Drawing.Size(930, 150);
            this.dataGridView_ev.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_vendedor_ev);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bt_excel_ev);
            this.groupBox1.Controls.Add(this.bt_pdf_ev);
            this.groupBox1.Controls.Add(this.tb_ver_ev);
            this.groupBox1.Controls.Add(this.tb_no_arti_ev);
            this.groupBox1.Controls.Add(this.tb_no_venta_ev);
            this.groupBox1.Controls.Add(this.tb_no_cliente_ev);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 307);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // bt_excel_ev
            // 
            this.bt_excel_ev.Location = new System.Drawing.Point(813, 211);
            this.bt_excel_ev.Name = "bt_excel_ev";
            this.bt_excel_ev.Size = new System.Drawing.Size(116, 66);
            this.bt_excel_ev.TabIndex = 15;
            this.bt_excel_ev.Text = "Reporte Excel";
            this.bt_excel_ev.UseVisualStyleBackColor = true;
            // 
            // bt_pdf_ev
            // 
            this.bt_pdf_ev.Location = new System.Drawing.Point(666, 211);
            this.bt_pdf_ev.Name = "bt_pdf_ev";
            this.bt_pdf_ev.Size = new System.Drawing.Size(116, 66);
            this.bt_pdf_ev.TabIndex = 14;
            this.bt_pdf_ev.Text = "Reporte PDF";
            this.bt_pdf_ev.UseVisualStyleBackColor = true;
            // 
            // tb_ver_ev
            // 
            this.tb_ver_ev.Location = new System.Drawing.Point(524, 211);
            this.tb_ver_ev.Name = "tb_ver_ev";
            this.tb_ver_ev.Size = new System.Drawing.Size(119, 66);
            this.tb_ver_ev.TabIndex = 13;
            this.tb_ver_ev.Text = "Mostrar ";
            this.tb_ver_ev.UseVisualStyleBackColor = true;
            // 
            // tb_no_arti_ev
            // 
            this.tb_no_arti_ev.Location = new System.Drawing.Point(229, 57);
            this.tb_no_arti_ev.Name = "tb_no_arti_ev";
            this.tb_no_arti_ev.Size = new System.Drawing.Size(172, 26);
            this.tb_no_arti_ev.TabIndex = 10;
            // 
            // tb_no_venta_ev
            // 
            this.tb_no_venta_ev.Location = new System.Drawing.Point(17, 152);
            this.tb_no_venta_ev.Name = "tb_no_venta_ev";
            this.tb_no_venta_ev.Size = new System.Drawing.Size(150, 26);
            this.tb_no_venta_ev.TabIndex = 9;
            // 
            // tb_no_cliente_ev
            // 
            this.tb_no_cliente_ev.Location = new System.Drawing.Point(13, 57);
            this.tb_no_cliente_ev.Name = "tb_no_cliente_ev";
            this.tb_no_cliente_ev.Size = new System.Drawing.Size(154, 26);
            this.tb_no_cliente_ev.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Cliente";
            // 
            // tb_vendedor_ev
            // 
            this.tb_vendedor_ev.Location = new System.Drawing.Point(229, 152);
            this.tb_vendedor_ev.Name = "tb_vendedor_ev";
            this.tb_vendedor_ev.Size = new System.Drawing.Size(172, 26);
            this.tb_vendedor_ev.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "No. Vendedor";
            // 
            // Estadisticas_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_ev);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Estadisticas_Ventas";
            this.Text = "Choreto App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ev)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_ev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_vendedor_ev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_excel_ev;
        private System.Windows.Forms.Button bt_pdf_ev;
        private System.Windows.Forms.Button tb_ver_ev;
        private System.Windows.Forms.TextBox tb_no_arti_ev;
        private System.Windows.Forms.TextBox tb_no_venta_ev;
        private System.Windows.Forms.TextBox tb_no_cliente_ev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}