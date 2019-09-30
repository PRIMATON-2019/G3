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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pesaje));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPuntosAcumulados = new System.Windows.Forms.Label();
            this.lblPuntosGanados = new System.Windows.Forms.Label();
            this.btnPesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btnVidrio = new System.Windows.Forms.Button();
            this.btnPlastico = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnBio = new System.Windows.Forms.Button();
            this.lblQuepeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSeguirRec = new System.Windows.Forms.Button();
            this.lblPtsGanados = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatAppearance.BorderSize = 5;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(240, 600);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(594, 122);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(606, 478);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 36);
            this.lblPeso.TabIndex = 36;
            this.lblPeso.Text = "0";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(303, 481);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(295, 32);
            this.lbl_cantidad.TabIndex = 35;
            this.lbl_cantidad.Text = "El peso ingresado es: ";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.Black;
            this.lblinfo.Location = new System.Drawing.Point(431, 270);
            this.lblinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(225, 32);
            this.lblinfo.TabIndex = 34;
            this.lblinfo.Text = "Estás pesando:  ";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.BorderSize = 4;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(13, 301);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(214, 118);
            this.btCancelar.TabIndex = 33;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btVolver.FlatAppearance.BorderSize = 2;
            this.btVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(13, 481);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(214, 98);
            this.btVolver.TabIndex = 32;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.LightGreen;
            this.btFinalizar.Enabled = false;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btFinalizar.FlatAppearance.BorderSize = 5;
            this.btFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(861, 463);
            this.btFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(203, 115);
            this.btFinalizar.TabIndex = 31;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.BtSiguiente_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(668, 45);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(120, 25);
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "Usuario: xxx";
            // 
            // lblPuntosAcumulados
            // 
            this.lblPuntosAcumulados.AutoSize = true;
            this.lblPuntosAcumulados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuntosAcumulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosAcumulados.ForeColor = System.Drawing.Color.Black;
            this.lblPuntosAcumulados.Location = new System.Drawing.Point(303, 560);
            this.lblPuntosAcumulados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosAcumulados.Name = "lblPuntosAcumulados";
            this.lblPuntosAcumulados.Size = new System.Drawing.Size(397, 36);
            this.lblPuntosAcumulados.TabIndex = 30;
            this.lblPuntosAcumulados.Text = "Total de puntos acumulados:";
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuntosGanados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosGanados.ForeColor = System.Drawing.Color.Black;
            this.lblPuntosGanados.Location = new System.Drawing.Point(303, 518);
            this.lblPuntosGanados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(229, 32);
            this.lblPuntosGanados.TabIndex = 28;
            this.lblPuntosGanados.Text = "Puntos ganados:";
            // 
            // btnPesar
            // 
            this.btnPesar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPesar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnPesar.FlatAppearance.BorderSize = 5;
            this.btnPesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesar.Location = new System.Drawing.Point(507, 330);
            this.btnPesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(263, 131);
            this.btnPesar.TabIndex = 27;
            this.btnPesar.Text = "Pesar";
            this.btnPesar.UseVisualStyleBackColor = false;
            this.btnPesar.Click += new System.EventHandler(this.BtnPesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 231);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 71);
            this.label1.TabIndex = 25;
            this.label1.Text = "Deposita los residuos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_hora.Location = new System.Drawing.Point(831, 9);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(185, 69);
            this.lbl_hora.TabIndex = 38;
            this.lbl_hora.Text = "Hora";
            // 
            // btnVidrio
            // 
            this.btnVidrio.BackColor = System.Drawing.Color.Teal;
            this.btnVidrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVidrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidrio.Location = new System.Drawing.Point(195, 80);
            this.btnVidrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVidrio.Name = "btnVidrio";
            this.btnVidrio.Size = new System.Drawing.Size(189, 145);
            this.btnVidrio.TabIndex = 39;
            this.btnVidrio.Text = "Vidrio";
            this.btnVidrio.UseVisualStyleBackColor = false;
            this.btnVidrio.Click += new System.EventHandler(this.BtnVidrio_Click);
            // 
            // btnPlastico
            // 
            this.btnPlastico.BackColor = System.Drawing.Color.Teal;
            this.btnPlastico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlastico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlastico.Location = new System.Drawing.Point(390, 80);
            this.btnPlastico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlastico.Name = "btnPlastico";
            this.btnPlastico.Size = new System.Drawing.Size(178, 147);
            this.btnPlastico.TabIndex = 40;
            this.btnPlastico.Text = "Plastico";
            this.btnPlastico.UseVisualStyleBackColor = false;
            this.btnPlastico.Click += new System.EventHandler(this.BtnPlastico_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Teal;
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.Location = new System.Drawing.Point(574, 80);
            this.btnPapel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(180, 147);
            this.btnPapel.TabIndex = 41;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            // 
            // btnBio
            // 
            this.btnBio.BackColor = System.Drawing.Color.Teal;
            this.btnBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBio.Location = new System.Drawing.Point(760, 80);
            this.btnBio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBio.Name = "btnBio";
            this.btnBio.Size = new System.Drawing.Size(178, 147);
            this.btnBio.TabIndex = 42;
            this.btnBio.Text = "Biodegradables";
            this.btnBio.UseVisualStyleBackColor = false;
            this.btnBio.Click += new System.EventHandler(this.BtnBio_Click);
            // 
            // lblQuepeso
            // 
            this.lblQuepeso.AutoSize = true;
            this.lblQuepeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuepeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuepeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuepeso.Location = new System.Drawing.Point(695, 270);
            this.lblQuepeso.Name = "lblQuepeso";
            this.lblQuepeso.Size = new System.Drawing.Size(25, 36);
            this.lblQuepeso.TabIndex = 43;
            this.lblQuepeso.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(702, 481);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Grs.";
            // 
            // btSeguirRec
            // 
            this.btSeguirRec.BackColor = System.Drawing.Color.LightGreen;
            this.btSeguirRec.Enabled = false;
            this.btSeguirRec.FlatAppearance.BorderSize = 0;
            this.btSeguirRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSeguirRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btSeguirRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeguirRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeguirRec.Location = new System.Drawing.Point(861, 309);
            this.btSeguirRec.Margin = new System.Windows.Forms.Padding(4);
            this.btSeguirRec.Name = "btSeguirRec";
            this.btSeguirRec.Size = new System.Drawing.Size(203, 103);
            this.btSeguirRec.TabIndex = 45;
            this.btSeguirRec.Text = "Seguir reciclando";
            this.btSeguirRec.UseVisualStyleBackColor = false;
            this.btSeguirRec.Click += new System.EventHandler(this.BtSeguirRec_Click);
            // 
            // lblPtsGanados
            // 
            this.lblPtsGanados.AutoSize = true;
            this.lblPtsGanados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPtsGanados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtsGanados.ForeColor = System.Drawing.Color.Black;
            this.lblPtsGanados.Location = new System.Drawing.Point(540, 515);
            this.lblPtsGanados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPtsGanados.Name = "lblPtsGanados";
            this.lblPtsGanados.Size = new System.Drawing.Size(32, 36);
            this.lblPtsGanados.TabIndex = 46;
            this.lblPtsGanados.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Primaton.Properties.Resources.eco_sistema_fondo_transparente_recuadro;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_Pesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 725);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPtsGanados);
            this.Controls.Add(this.btSeguirRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuepeso);
            this.Controls.Add(this.btnBio);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPlastico);
            this.Controls.Add(this.btnVidrio);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPuntosAcumulados);
            this.Controls.Add(this.lblPuntosGanados);
            this.Controls.Add(this.btnPesar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Pesaje";
            this.Text = "frm_pesajevidrio";
            this.Load += new System.EventHandler(this.Frm_Pesaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPuntosAcumulados;
        private System.Windows.Forms.Label lblPuntosGanados;
        private System.Windows.Forms.Button btnPesar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btnVidrio;
        private System.Windows.Forms.Button btnPlastico;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnBio;
        private System.Windows.Forms.Label lblQuepeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSeguirRec;
        private System.Windows.Forms.Label lblPtsGanados;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}