namespace OrdenVentas
{
    partial class Consulta_Cliente
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
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bConsultar_cc = new System.Windows.Forms.Button();
            this.bLimpiar_cc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCC = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcodigo_cliente_cc = new System.Windows.Forms.TextBox();
            this.tbnombre_cliente_cc = new System.Windows.Forms.TextBox();
            this.tbnum_documento_cc = new System.Windows.Forms.TextBox();
            this.ConsultaClientePanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCC)).BeginInit();
            this.ConsultaClientePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuPrincipalToolStripMenuItem,
            this.nuevoClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
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
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // bConsultar_cc
            // 
            this.bConsultar_cc.Location = new System.Drawing.Point(518, 9);
            this.bConsultar_cc.Margin = new System.Windows.Forms.Padding(2);
            this.bConsultar_cc.Name = "bConsultar_cc";
            this.bConsultar_cc.Size = new System.Drawing.Size(124, 32);
            this.bConsultar_cc.TabIndex = 1;
            this.bConsultar_cc.Text = "Consultar";
            this.bConsultar_cc.UseVisualStyleBackColor = true;
            // 
            // bLimpiar_cc
            // 
            this.bLimpiar_cc.Location = new System.Drawing.Point(518, 47);
            this.bLimpiar_cc.Margin = new System.Windows.Forms.Padding(2);
            this.bLimpiar_cc.Name = "bLimpiar_cc";
            this.bLimpiar_cc.Size = new System.Drawing.Size(124, 32);
            this.bLimpiar_cc.TabIndex = 2;
            this.bLimpiar_cc.Text = "Nueva Consulta";
            this.bLimpiar_cc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // dataGridViewCC
            // 
            this.dataGridViewCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCC.Location = new System.Drawing.Point(0, 124);
            this.dataGridViewCC.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCC.Name = "dataGridViewCC";
            this.dataGridViewCC.RowHeadersWidth = 62;
            this.dataGridViewCC.RowTemplate.Height = 33;
            this.dataGridViewCC.Size = new System.Drawing.Size(799, 164);
            this.dataGridViewCC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Num Documento";
            // 
            // tbcodigo_cliente_cc
            // 
            this.tbcodigo_cliente_cc.Location = new System.Drawing.Point(96, 9);
            this.tbcodigo_cliente_cc.Margin = new System.Windows.Forms.Padding(2);
            this.tbcodigo_cliente_cc.Name = "tbcodigo_cliente_cc";
            this.tbcodigo_cliente_cc.Size = new System.Drawing.Size(130, 20);
            this.tbcodigo_cliente_cc.TabIndex = 8;
            // 
            // tbnombre_cliente_cc
            // 
            this.tbnombre_cliente_cc.Location = new System.Drawing.Point(96, 36);
            this.tbnombre_cliente_cc.Margin = new System.Windows.Forms.Padding(2);
            this.tbnombre_cliente_cc.Name = "tbnombre_cliente_cc";
            this.tbnombre_cliente_cc.Size = new System.Drawing.Size(130, 20);
            this.tbnombre_cliente_cc.TabIndex = 9;
            // 
            // tbnum_documento_cc
            // 
            this.tbnum_documento_cc.Location = new System.Drawing.Point(96, 59);
            this.tbnum_documento_cc.Margin = new System.Windows.Forms.Padding(2);
            this.tbnum_documento_cc.Name = "tbnum_documento_cc";
            this.tbnum_documento_cc.Size = new System.Drawing.Size(130, 20);
            this.tbnum_documento_cc.TabIndex = 10;
            // 
            // ConsultaClientePanel
            // 
            this.ConsultaClientePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaClientePanel.Controls.Add(this.tbnum_documento_cc);
            this.ConsultaClientePanel.Controls.Add(this.bConsultar_cc);
            this.ConsultaClientePanel.Controls.Add(this.tbnombre_cliente_cc);
            this.ConsultaClientePanel.Controls.Add(this.bLimpiar_cc);
            this.ConsultaClientePanel.Controls.Add(this.tbcodigo_cliente_cc);
            this.ConsultaClientePanel.Controls.Add(this.label1);
            this.ConsultaClientePanel.Controls.Add(this.label3);
            this.ConsultaClientePanel.Controls.Add(this.label2);
            this.ConsultaClientePanel.Location = new System.Drawing.Point(0, 27);
            this.ConsultaClientePanel.Name = "ConsultaClientePanel";
            this.ConsultaClientePanel.Size = new System.Drawing.Size(799, 92);
            this.ConsultaClientePanel.TabIndex = 11;
            // 
            // Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 299);
            this.Controls.Add(this.dataGridViewCC);
            this.Controls.Add(this.ConsultaClientePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulta_Cliente";
            this.Text = "Consulta_Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCC)).EndInit();
            this.ConsultaClientePanel.ResumeLayout(false);
            this.ConsultaClientePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.Button bConsultar_cc;
        private System.Windows.Forms.Button bLimpiar_cc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcodigo_cliente_cc;
        private System.Windows.Forms.TextBox tbnombre_cliente_cc;
        private System.Windows.Forms.TextBox tbnum_documento_cc;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.Panel ConsultaClientePanel;
    }
}