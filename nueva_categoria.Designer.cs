namespace OrdenVentas
{
    partial class Nueva_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Categoria));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_nctg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_categoria_nctg = new System.Windows.Forms.TextBox();
            this.tb_nombre_nctg = new System.Windows.Forms.TextBox();
            this.tb_descripcion_nctg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bagregar_nctg = new System.Windows.Forms.Button();
            this.bactualizar_nctg = new System.Windows.Forms.Button();
            this.bnueva_entrada_nctg = new System.Windows.Forms.Button();
            this.CategoriaPanel = new System.Windows.Forms.Panel();
            this.dataGridView_nctg = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.CategoriaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nctg)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 33);
            this.menuStrip1.TabIndex = 1;
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
            // comboBox_nctg
            // 
            this.comboBox_nctg.FormattingEnabled = true;
            this.comboBox_nctg.Location = new System.Drawing.Point(423, 51);
            this.comboBox_nctg.Name = "comboBox_nctg";
            this.comboBox_nctg.Size = new System.Drawing.Size(172, 28);
            this.comboBox_nctg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTA CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "INGRESE NUEVA CATEGORIA";
            // 
            // tb_id_categoria_nctg
            // 
            this.tb_id_categoria_nctg.Enabled = false;
            this.tb_id_categoria_nctg.Location = new System.Drawing.Point(168, 58);
            this.tb_id_categoria_nctg.Name = "tb_id_categoria_nctg";
            this.tb_id_categoria_nctg.ReadOnly = true;
            this.tb_id_categoria_nctg.Size = new System.Drawing.Size(168, 26);
            this.tb_id_categoria_nctg.TabIndex = 5;
            this.tb_id_categoria_nctg.Tag = "IDCATEGORIA";
            // 
            // tb_nombre_nctg
            // 
            this.tb_nombre_nctg.Location = new System.Drawing.Point(168, 105);
            this.tb_nombre_nctg.Name = "tb_nombre_nctg";
            this.tb_nombre_nctg.Size = new System.Drawing.Size(168, 26);
            this.tb_nombre_nctg.TabIndex = 6;
            this.tb_nombre_nctg.Tag = "NOMBRE";
            // 
            // tb_descripcion_nctg
            // 
            this.tb_descripcion_nctg.Location = new System.Drawing.Point(168, 154);
            this.tb_descripcion_nctg.Name = "tb_descripcion_nctg";
            this.tb_descripcion_nctg.Size = new System.Drawing.Size(168, 26);
            this.tb_descripcion_nctg.TabIndex = 7;
            this.tb_descripcion_nctg.Tag = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion";
            // 
            // bagregar_nctg
            // 
            this.bagregar_nctg.Location = new System.Drawing.Point(801, 57);
            this.bagregar_nctg.Name = "bagregar_nctg";
            this.bagregar_nctg.Size = new System.Drawing.Size(138, 58);
            this.bagregar_nctg.TabIndex = 13;
            this.bagregar_nctg.Text = "Agregar";
            this.bagregar_nctg.UseVisualStyleBackColor = true;
            this.bagregar_nctg.Click += new System.EventHandler(this.Bagregar_nctg_Click);
            // 
            // bactualizar_nctg
            // 
            this.bactualizar_nctg.Location = new System.Drawing.Point(801, 132);
            this.bactualizar_nctg.Name = "bactualizar_nctg";
            this.bactualizar_nctg.Size = new System.Drawing.Size(138, 58);
            this.bactualizar_nctg.TabIndex = 14;
            this.bactualizar_nctg.Text = "Actualizar";
            this.bactualizar_nctg.UseVisualStyleBackColor = true;
            this.bactualizar_nctg.Click += new System.EventHandler(this.Bactualizar_nctg_Click);
            // 
            // bnueva_entrada_nctg
            // 
            this.bnueva_entrada_nctg.Location = new System.Drawing.Point(801, 208);
            this.bnueva_entrada_nctg.Name = "bnueva_entrada_nctg";
            this.bnueva_entrada_nctg.Size = new System.Drawing.Size(138, 58);
            this.bnueva_entrada_nctg.TabIndex = 15;
            this.bnueva_entrada_nctg.Text = "Nueva Entrada";
            this.bnueva_entrada_nctg.UseVisualStyleBackColor = true;
            this.bnueva_entrada_nctg.Click += new System.EventHandler(this.Bnueva_entrada_nctg_Click);
            // 
            // CategoriaPanel
            // 
            this.CategoriaPanel.Controls.Add(this.label2);
            this.CategoriaPanel.Controls.Add(this.bnueva_entrada_nctg);
            this.CategoriaPanel.Controls.Add(this.comboBox_nctg);
            this.CategoriaPanel.Controls.Add(this.bactualizar_nctg);
            this.CategoriaPanel.Controls.Add(this.label1);
            this.CategoriaPanel.Controls.Add(this.bagregar_nctg);
            this.CategoriaPanel.Controls.Add(this.tb_id_categoria_nctg);
            this.CategoriaPanel.Controls.Add(this.tb_nombre_nctg);
            this.CategoriaPanel.Controls.Add(this.label5);
            this.CategoriaPanel.Controls.Add(this.tb_descripcion_nctg);
            this.CategoriaPanel.Controls.Add(this.label4);
            this.CategoriaPanel.Controls.Add(this.label3);
            this.CategoriaPanel.Location = new System.Drawing.Point(18, 42);
            this.CategoriaPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoriaPanel.Name = "CategoriaPanel";
            this.CategoriaPanel.Size = new System.Drawing.Size(1062, 280);
            this.CategoriaPanel.TabIndex = 16;
            // 
            // dataGridView_nctg
            // 
            this.dataGridView_nctg.AllowUserToAddRows = false;
            this.dataGridView_nctg.AllowUserToDeleteRows = false;
            this.dataGridView_nctg.AllowUserToOrderColumns = true;
            this.dataGridView_nctg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_nctg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_nctg.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_nctg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nctg.Location = new System.Drawing.Point(18, 329);
            this.dataGridView_nctg.Name = "dataGridView_nctg";
            this.dataGridView_nctg.ReadOnly = true;
            this.dataGridView_nctg.RowHeadersWidth = 62;
            this.dataGridView_nctg.RowTemplate.Height = 33;
            this.dataGridView_nctg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_nctg.Size = new System.Drawing.Size(1062, 254);
            this.dataGridView_nctg.TabIndex = 17;
            this.dataGridView_nctg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // Nueva_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 600);
            this.Controls.Add(this.dataGridView_nctg);
            this.Controls.Add(this.CategoriaPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nueva_Categoria";
            this.Text = "Choreto App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CategoriaPanel.ResumeLayout(false);
            this.CategoriaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nctg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_nctg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_categoria_nctg;
        private System.Windows.Forms.TextBox tb_nombre_nctg;
        private System.Windows.Forms.TextBox tb_descripcion_nctg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bagregar_nctg;
        private System.Windows.Forms.Button bactualizar_nctg;
        private System.Windows.Forms.Button bnueva_entrada_nctg;
        private System.Windows.Forms.Panel CategoriaPanel;
        private System.Windows.Forms.DataGridView dataGridView_nctg;
    }
}