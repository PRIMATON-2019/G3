namespace Primaton.Front.Formularios
{
    partial class frm_Personal
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnIzquierda = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnGrande = new System.Windows.Forms.Panel();
            this.btBeneficio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pnTop.SuspendLayout();
            this.pnIzquierda.SuspendLayout();
            this.pnGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.DarkGray;
            this.pnTop.Controls.Add(this.pictureBox4);
            this.pnTop.Controls.Add(this.pictureBox3);
            this.pnTop.Controls.Add(this.pictureBox2);
            this.pnTop.Controls.Add(this.pbMenu);
            this.pnTop.Location = new System.Drawing.Point(187, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(893, 41);
            this.pnTop.TabIndex = 45;
            // 
            // pnIzquierda
            // 
            this.pnIzquierda.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnIzquierda.Controls.Add(this.btBeneficio);
            this.pnIzquierda.Controls.Add(this.pictureBox1);
            this.pnIzquierda.Controls.Add(this.btnPerfil);
            this.pnIzquierda.Controls.Add(this.btnCambiar);
            this.pnIzquierda.Controls.Add(this.btnRegistro);
            this.pnIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pnIzquierda.Name = "pnIzquierda";
            this.pnIzquierda.Size = new System.Drawing.Size(191, 728);
            this.pnIzquierda.TabIndex = 44;
            // 
            // pnGrande
            // 
            this.pnGrande.BackColor = System.Drawing.Color.Teal;
            this.pnGrande.Controls.Add(this.pictureBox13);
            this.pnGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrande.Location = new System.Drawing.Point(0, 0);
            this.pnGrande.Name = "pnGrande";
            this.pnGrande.Size = new System.Drawing.Size(1080, 728);
            this.pnGrande.TabIndex = 43;
            // 
            // btBeneficio
            // 
            this.btBeneficio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBeneficio.FlatAppearance.BorderSize = 0;
            this.btBeneficio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBeneficio.Image = global::Primaton.Properties.Resources.compras_48px;
            this.btBeneficio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBeneficio.Location = new System.Drawing.Point(-3, 366);
            this.btBeneficio.Name = "btBeneficio";
            this.btBeneficio.Size = new System.Drawing.Size(191, 66);
            this.btBeneficio.TabIndex = 67;
            this.btBeneficio.Text = "    Cambiar Puntos";
            this.btBeneficio.UseVisualStyleBackColor = true;
            this.btBeneficio.Click += new System.EventHandler(this.BtBeneficio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primaton.Properties.Resources.eco_sistema_fondo_transparente_recuadro;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerfil.Image = global::Primaton.Properties.Resources.Businessman_48px;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 182);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(191, 66);
            this.btnPerfil.TabIndex = 66;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiar.Image = global::Primaton.Properties.Resources.Ventas_48px;
            this.btnCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiar.Location = new System.Drawing.Point(0, 245);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(191, 65);
            this.btnCambiar.TabIndex = 48;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistro.Image = global::Primaton.Properties.Resources.Combo_Chart_64px;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 307);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(191, 64);
            this.btnRegistro.TabIndex = 49;
            this.btnRegistro.Text = "       Registros";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.Image = global::Primaton.Properties.Resources.Restore_Window_2_48px;
            this.pictureBox13.Location = new System.Drawing.Point(971, 43);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(48, 34);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 47;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            this.pictureBox13.Click += new System.EventHandler(this.PictureBox13_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Primaton.Properties.Resources.Close_Window__2_48px;
            this.pictureBox4.Location = new System.Drawing.Point(838, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Primaton.Properties.Resources.Maximize_Window_2_48px;
            this.pictureBox3.Location = new System.Drawing.Point(784, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Primaton.Properties.Resources.Minimize_Window_2_48px;
            this.pictureBox2.Location = new System.Drawing.Point(737, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.Image = global::Primaton.Properties.Resources.Menu_48px;
            this.pbMenu.Location = new System.Drawing.Point(3, 4);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(55, 34);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.PbMenu_Click);
            // 
            // frm_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 728);
            this.Controls.Add(this.pnIzquierda);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnGrande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_nuevousuario";
            this.pnTop.ResumeLayout(false);
            this.pnIzquierda.ResumeLayout(false);
            this.pnGrande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnIzquierda;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnGrande;
        private System.Windows.Forms.Button btBeneficio;
    }
}