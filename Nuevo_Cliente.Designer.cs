namespace OrdenVentas
{
    partial class Nuevo_Cliente
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
            this.consultaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesDgv = new System.Windows.Forms.DataGridView();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.ActualizarCliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcodigo_nc = new System.Windows.Forms.TextBox();
            this.tbnombre_nc = new System.Windows.Forms.TextBox();
            this.tbnum_documento_nc = new System.Windows.Forms.TextBox();
            this.tb_direccion_nc = new System.Windows.Forms.TextBox();
            this.tb_telefono_nc = new System.Windows.Forms.TextBox();
            this.tb_correo_nc = new System.Windows.Forms.TextBox();
            this.MantenimientoClientePanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).BeginInit();
            this.MantenimientoClientePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuPrincipalToolStripMenuItem,
            this.consultaClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver al Menu Principal";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // consultaClienteToolStripMenuItem
            // 
            this.consultaClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.consultaClienteToolStripMenuItem.Name = "consultaClienteToolStripMenuItem";
            this.consultaClienteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.consultaClienteToolStripMenuItem.Text = "Consulta Cliente";
            this.consultaClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaClienteToolStripMenuItem_Click);
            // 
            // ClientesDgv
            // 
            this.ClientesDgv.AllowUserToAddRows = false;
            this.ClientesDgv.AllowUserToDeleteRows = false;
            this.ClientesDgv.AllowUserToOrderColumns = true;
            this.ClientesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ClientesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDgv.Location = new System.Drawing.Point(11, 254);
            this.ClientesDgv.Margin = new System.Windows.Forms.Padding(2);
            this.ClientesDgv.Name = "ClientesDgv";
            this.ClientesDgv.ReadOnly = true;
            this.ClientesDgv.RowHeadersWidth = 62;
            this.ClientesDgv.RowTemplate.Height = 33;
            this.ClientesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDgv.Size = new System.Drawing.Size(803, 207);
            this.ClientesDgv.TabIndex = 1;
            this.ClientesDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDgv_CellClick);
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.Location = new System.Drawing.Point(527, 12);
            this.AgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(100, 25);
            this.AgregarCliente.TabIndex = 2;
            this.AgregarCliente.Text = "Agregar";
            this.AgregarCliente.UseVisualStyleBackColor = true;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // ActualizarCliente
            // 
            this.ActualizarCliente.Location = new System.Drawing.Point(527, 52);
            this.ActualizarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarCliente.Name = "ActualizarCliente";
            this.ActualizarCliente.Size = new System.Drawing.Size(100, 25);
            this.ActualizarCliente.TabIndex = 3;
            this.ActualizarCliente.Text = "Actualizar";
            this.ActualizarCliente.UseVisualStyleBackColor = true;
            this.ActualizarCliente.Click += new System.EventHandler(this.ActualizarCliente_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 96);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nueva Entrada";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Num Documento";
            // 
            // tbcodigo_nc
            // 
            this.tbcodigo_nc.Location = new System.Drawing.Point(120, 9);
            this.tbcodigo_nc.Margin = new System.Windows.Forms.Padding(2);
            this.tbcodigo_nc.Name = "tbcodigo_nc";
            this.tbcodigo_nc.ReadOnly = true;
            this.tbcodigo_nc.Size = new System.Drawing.Size(233, 20);
            this.tbcodigo_nc.TabIndex = 12;
            this.tbcodigo_nc.Tag = "IDCLIENTE";
            // 
            // tbnombre_nc
            // 
            this.tbnombre_nc.Location = new System.Drawing.Point(120, 60);
            this.tbnombre_nc.Margin = new System.Windows.Forms.Padding(2);
            this.tbnombre_nc.Name = "tbnombre_nc";
            this.tbnombre_nc.Size = new System.Drawing.Size(233, 20);
            this.tbnombre_nc.TabIndex = 13;
            this.tbnombre_nc.Tag = "NOMBRE";
            // 
            // tbnum_documento_nc
            // 
            this.tbnum_documento_nc.Location = new System.Drawing.Point(120, 111);
            this.tbnum_documento_nc.Margin = new System.Windows.Forms.Padding(2);
            this.tbnum_documento_nc.Name = "tbnum_documento_nc";
            this.tbnum_documento_nc.Size = new System.Drawing.Size(233, 20);
            this.tbnum_documento_nc.TabIndex = 15;
            this.tbnum_documento_nc.Tag = "NUM_DOCUMENTO";
            // 
            // tb_direccion_nc
            // 
            this.tb_direccion_nc.Location = new System.Drawing.Point(120, 135);
            this.tb_direccion_nc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_direccion_nc.Name = "tb_direccion_nc";
            this.tb_direccion_nc.Size = new System.Drawing.Size(233, 20);
            this.tb_direccion_nc.TabIndex = 16;
            this.tb_direccion_nc.Tag = "DIRECCION";
            // 
            // tb_telefono_nc
            // 
            this.tb_telefono_nc.Location = new System.Drawing.Point(120, 159);
            this.tb_telefono_nc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_telefono_nc.Name = "tb_telefono_nc";
            this.tb_telefono_nc.Size = new System.Drawing.Size(233, 20);
            this.tb_telefono_nc.TabIndex = 17;
            this.tb_telefono_nc.Tag = "TELEFONO";
            // 
            // tb_correo_nc
            // 
            this.tb_correo_nc.Location = new System.Drawing.Point(120, 183);
            this.tb_correo_nc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_correo_nc.Name = "tb_correo_nc";
            this.tb_correo_nc.Size = new System.Drawing.Size(233, 20);
            this.tb_correo_nc.TabIndex = 18;
            this.tb_correo_nc.Tag = "EMAIL";
            // 
            // MantenimientoClientePanel
            // 
            this.MantenimientoClientePanel.Controls.Add(this.comboBox2);
            this.MantenimientoClientePanel.Controls.Add(this.label8);
            this.MantenimientoClientePanel.Controls.Add(this.comboBox1);
            this.MantenimientoClientePanel.Controls.Add(this.label1);
            this.MantenimientoClientePanel.Controls.Add(this.tb_correo_nc);
            this.MantenimientoClientePanel.Controls.Add(this.AgregarCliente);
            this.MantenimientoClientePanel.Controls.Add(this.tb_telefono_nc);
            this.MantenimientoClientePanel.Controls.Add(this.ActualizarCliente);
            this.MantenimientoClientePanel.Controls.Add(this.tb_direccion_nc);
            this.MantenimientoClientePanel.Controls.Add(this.button3);
            this.MantenimientoClientePanel.Controls.Add(this.tbnum_documento_nc);
            this.MantenimientoClientePanel.Controls.Add(this.label2);
            this.MantenimientoClientePanel.Controls.Add(this.label3);
            this.MantenimientoClientePanel.Controls.Add(this.tbnombre_nc);
            this.MantenimientoClientePanel.Controls.Add(this.label4);
            this.MantenimientoClientePanel.Controls.Add(this.tbcodigo_nc);
            this.MantenimientoClientePanel.Controls.Add(this.label5);
            this.MantenimientoClientePanel.Controls.Add(this.label7);
            this.MantenimientoClientePanel.Controls.Add(this.label6);
            this.MantenimientoClientePanel.Location = new System.Drawing.Point(0, 27);
            this.MantenimientoClientePanel.Name = "MantenimientoClientePanel";
            this.MantenimientoClientePanel.Size = new System.Drawing.Size(633, 222);
            this.MantenimientoClientePanel.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte"});
            this.comboBox2.Location = new System.Drawing.Point(120, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Tag = "TIPO_DOCUMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor"});
            this.comboBox1.Location = new System.Drawing.Point(120, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Tag = "TIPO_CLIENTE";
            // 
            // Nuevo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 469);
            this.Controls.Add(this.MantenimientoClientePanel);
            this.Controls.Add(this.ClientesDgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nuevo_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo_Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).EndInit();
            this.MantenimientoClientePanel.ResumeLayout(false);
            this.MantenimientoClientePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.DataGridView ClientesDgv;
        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.Button ActualizarCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcodigo_nc;
        private System.Windows.Forms.TextBox tbnombre_nc;
        private System.Windows.Forms.TextBox tbnum_documento_nc;
        private System.Windows.Forms.TextBox tb_direccion_nc;
        private System.Windows.Forms.TextBox tb_telefono_nc;
        private System.Windows.Forms.TextBox tb_correo_nc;
        private System.Windows.Forms.ToolStripMenuItem consultaClienteToolStripMenuItem;
        private System.Windows.Forms.Panel MantenimientoClientePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}