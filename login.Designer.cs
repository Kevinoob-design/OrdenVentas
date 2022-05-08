namespace OrdenVentas
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bacceso = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bacceso
            // 
            this.bacceso.Location = new System.Drawing.Point(37, 153);
            this.bacceso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bacceso.Name = "bacceso";
            this.bacceso.Size = new System.Drawing.Size(67, 27);
            this.bacceso.TabIndex = 0;
            this.bacceso.Text = "Acceso";
            this.bacceso.UseVisualStyleBackColor = true;
            this.bacceso.Click += new System.EventHandler(this.bacceso_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(154, 153);
            this.bsalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(67, 27);
            this.bsalir.TabIndex = 1;
            this.bsalir.Text = "Cerrar";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLAVE";
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(109, 77);
            this.tbusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(112, 20);
            this.tbusuario.TabIndex = 4;
            this.tbusuario.Tag = "USUARIO";
            // 
            // tbclave
            // 
            this.tbclave.Location = new System.Drawing.Point(109, 113);
            this.tbclave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbclave.Name = "tbclave";
            this.tbclave.Size = new System.Drawing.Size(112, 20);
            this.tbclave.TabIndex = 5;
            this.tbclave.Tag = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(52, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sistema de Orden de Ventas Grupo 3";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.bacceso);
            this.LoginPanel.Controls.Add(this.tbclave);
            this.LoginPanel.Controls.Add(this.bsalir);
            this.LoginPanel.Controls.Add(this.tbusuario);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Location = new System.Drawing.Point(12, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(297, 189);
            this.LoginPanel.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 221);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(338, 260);
            this.MinimumSize = new System.Drawing.Size(338, 260);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN DE USUARIO";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bacceso;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LoginPanel;
    }
}
