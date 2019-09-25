namespace Primaton.Front.Formularios
{
    partial class frm_Pesaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pesaje));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTotaldePuntos = new System.Windows.Forms.Label();
            this.lblPuntosGanados = new System.Windows.Forms.Label();
            this.btnPesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVidrio = new System.Windows.Forms.Button();
            this.btnPlastico = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnBio = new System.Windows.Forms.Button();
            this.lblQuepeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(695, 354);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 36);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(495, 364);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(54, 17);
            this.lblPeso.TabIndex = 36;
            this.lblPeso.Text = "asbdak";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(707, 210);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(149, 17);
            this.lbl_cantidad.TabIndex = 35;
            this.lbl_cantidad.Text = "El peso ingresado es: ";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(395, 203);
            this.lblinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(158, 25);
            this.lblinfo.TabIndex = 34;
            this.lblinfo.Text = "Estás pesando:  ";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(388, 514);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(119, 36);
            this.btCancelar.TabIndex = 33;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(549, 514);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(119, 36);
            this.btVolver.TabIndex = 32;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(710, 514);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(119, 36);
            this.btSiguiente.TabIndex = 31;
            this.btSiguiente.Text = "Finalizar";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.BtSiguiente_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(661, 23);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(120, 25);
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "Usuario: xxx";
            // 
            // lblTotaldePuntos
            // 
            this.lblTotaldePuntos.AutoSize = true;
            this.lblTotaldePuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaldePuntos.Location = new System.Drawing.Point(404, 456);
            this.lblTotaldePuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotaldePuntos.Name = "lblTotaldePuntos";
            this.lblTotaldePuntos.Size = new System.Drawing.Size(264, 25);
            this.lblTotaldePuntos.TabIndex = 30;
            this.lblTotaldePuntos.Text = "Total de puntos acumulados:";
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosGanados.Location = new System.Drawing.Point(404, 422);
            this.lblPuntosGanados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(160, 25);
            this.lblPuntosGanados.TabIndex = 28;
            this.lblPuntosGanados.Text = "Puntos ganados:";
            // 
            // btnPesar
            // 
            this.btnPesar.Location = new System.Drawing.Point(400, 243);
            this.btnPesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(181, 59);
            this.btnPesar.TabIndex = 27;
            this.btnPesar.Text = "Pesar";
            this.btnPesar.UseVisualStyleBackColor = true;
            this.btnPesar.Click += new System.EventHandler(this.BtnPesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 203);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 71);
            this.label1.TabIndex = 25;
            this.label1.Text = "Deposita los residuos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Hora";
            // 
            // btnVidrio
            // 
            this.btnVidrio.BackColor = System.Drawing.Color.Transparent;
            this.btnVidrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVidrio.Location = new System.Drawing.Point(122, 73);
            this.btnVidrio.Name = "btnVidrio";
            this.btnVidrio.Size = new System.Drawing.Size(148, 100);
            this.btnVidrio.TabIndex = 39;
            this.btnVidrio.Text = "Vidrio";
            this.btnVidrio.UseVisualStyleBackColor = false;
            this.btnVidrio.Click += new System.EventHandler(this.BtnVidrio_Click);
            // 
            // btnPlastico
            // 
            this.btnPlastico.BackColor = System.Drawing.Color.Transparent;
            this.btnPlastico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlastico.Location = new System.Drawing.Point(301, 73);
            this.btnPlastico.Name = "btnPlastico";
            this.btnPlastico.Size = new System.Drawing.Size(148, 100);
            this.btnPlastico.TabIndex = 40;
            this.btnPlastico.Text = "Plastico";
            this.btnPlastico.UseVisualStyleBackColor = false;
            this.btnPlastico.Click += new System.EventHandler(this.BtnPlastico_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Transparent;
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Location = new System.Drawing.Point(483, 73);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(148, 100);
            this.btnPapel.TabIndex = 41;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            // 
            // btnBio
            // 
            this.btnBio.BackColor = System.Drawing.Color.Transparent;
            this.btnBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBio.Location = new System.Drawing.Point(657, 73);
            this.btnBio.Name = "btnBio";
            this.btnBio.Size = new System.Drawing.Size(148, 100);
            this.btnBio.TabIndex = 42;
            this.btnBio.Text = "Biodegradables";
            this.btnBio.UseVisualStyleBackColor = false;
            this.btnBio.Click += new System.EventHandler(this.BtnBio_Click);
            // 
            // lblQuepeso
            // 
            this.lblQuepeso.AutoSize = true;
            this.lblQuepeso.Location = new System.Drawing.Point(580, 210);
            this.lblQuepeso.Name = "lblQuepeso";
            this.lblQuepeso.Size = new System.Drawing.Size(46, 17);
            this.lblQuepeso.TabIndex = 43;
            this.lblQuepeso.Text = "label2";
            // 
            // frm_Pesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblQuepeso);
            this.Controls.Add(this.btnBio);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPlastico);
            this.Controls.Add(this.btnVidrio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTotaldePuntos);
            this.Controls.Add(this.lblPuntosGanados);
            this.Controls.Add(this.btnPesar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Pesaje";
            this.Text = "frm_pesajevidrio";
            this.Load += new System.EventHandler(this.Frm_Pesaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTotaldePuntos;
        private System.Windows.Forms.Label lblPuntosGanados;
        private System.Windows.Forms.Button btnPesar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVidrio;
        private System.Windows.Forms.Button btnPlastico;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnBio;
        private System.Windows.Forms.Label lblQuepeso;
    }
}