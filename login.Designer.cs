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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bacceso = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbclave = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bacceso
            // 
            this.bacceso.Location = new System.Drawing.Point(80, 447);
            this.bacceso.Name = "bacceso";
            this.bacceso.Size = new System.Drawing.Size(100, 42);
            this.bacceso.TabIndex = 0;
            this.bacceso.Text = "Acceso";
            this.bacceso.UseVisualStyleBackColor = true;
            this.bacceso.Click += new System.EventHandler(this.bacceso_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(247, 447);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(100, 42);
            this.bsalir.TabIndex = 1;
            this.bsalir.Text = "Cerrar";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(104, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave de acceso";
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(110, 250);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(190, 26);
            this.tbusuario.TabIndex = 4;
            this.tbusuario.Tag = "USUARIO";
            // 
            // tbclave
            // 
            this.tbclave.Location = new System.Drawing.Point(110, 369);
            this.tbclave.Name = "tbclave";
            this.tbclave.Size = new System.Drawing.Size(190, 26);
            this.tbclave.TabIndex = 5;
            this.tbclave.Tag = "PASSWORD";
            this.tbclave.UseSystemPasswordChar = true;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.groupBox1);
            this.LoginPanel.Controls.Add(this.bacceso);
            this.LoginPanel.Controls.Add(this.tbclave);
            this.LoginPanel.Controls.Add(this.bsalir);
            this.LoginPanel.Controls.Add(this.tbusuario);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginPanel.Location = new System.Drawing.Point(1, -3);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(420, 570);
            this.LoginPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Location = new System.Drawing.Point(35, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "All rights reserved © 2022";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(419, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 560);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.bacceso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LoginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choreto app";
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
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
