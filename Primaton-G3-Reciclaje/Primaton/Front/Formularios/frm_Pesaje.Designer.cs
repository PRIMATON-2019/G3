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
            this.lblPuntosAcumulados = new System.Windows.Forms.Label();
            this.lblPuntosGanados = new System.Windows.Forms.Label();
            this.btnPesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btnVidrio = new System.Windows.Forms.Button();
            this.btnPlastico = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnBio = new System.Windows.Forms.Button();
            this.lblQuepeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPtsGanados = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Gray;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(135, 321);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(238, 52);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Lime;
            this.lblPeso.Location = new System.Drawing.Point(320, 141);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(33, 38);
            this.lblPeso.TabIndex = 36;
            this.lblPeso.Text = "0";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cantidad.Location = new System.Drawing.Point(4, 141);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(304, 38);
            this.lbl_cantidad.TabIndex = 35;
            this.lbl_cantidad.Text = "El peso ingresado es: ";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinfo.Location = new System.Drawing.Point(8, 20);
            this.lblinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(229, 38);
            this.lblinfo.TabIndex = 34;
            this.lblinfo.Text = "Estás pesando:  ";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Gray;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(13, 337);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(269, 144);
            this.btCancelar.TabIndex = 33;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.Gray;
            this.btVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btVolver.FlatAppearance.BorderSize = 0;
            this.btVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(13, 566);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(269, 136);
            this.btVolver.TabIndex = 32;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.Gray;
            this.btFinalizar.Enabled = false;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btFinalizar.FlatAppearance.BorderSize = 0;
            this.btFinalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(810, 506);
            this.btFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(251, 210);
            this.btFinalizar.TabIndex = 31;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.BtSiguiente_Click_1);
            // 
            // lblPuntosAcumulados
            // 
            this.lblPuntosAcumulados.AutoSize = true;
            this.lblPuntosAcumulados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuntosAcumulados.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosAcumulados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosAcumulados.Location = new System.Drawing.Point(10, 264);
            this.lblPuntosAcumulados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosAcumulados.Name = "lblPuntosAcumulados";
            this.lblPuntosAcumulados.Size = new System.Drawing.Size(401, 38);
            this.lblPuntosAcumulados.TabIndex = 30;
            this.lblPuntosAcumulados.Text = "Total de puntos acumulados:";
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuntosGanados.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosGanados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosGanados.Location = new System.Drawing.Point(4, 212);
            this.lblPuntosGanados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(238, 38);
            this.lblPuntosGanados.TabIndex = 28;
            this.lblPuntosGanados.Text = "Puntos ganados:";
            // 
            // btnPesar
            // 
            this.btnPesar.BackColor = System.Drawing.Color.Gray;
            this.btnPesar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPesar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesar.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesar.Location = new System.Drawing.Point(10, 59);
            this.btnPesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(478, 56);
            this.btnPesar.TabIndex = 27;
            this.btnPesar.Text = "Pesar";
            this.btnPesar.UseVisualStyleBackColor = false;
            this.btnPesar.Click += new System.EventHandler(this.BtnPesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_hora.Location = new System.Drawing.Point(773, 243);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(282, 80);
            this.lbl_hora.TabIndex = 38;
            this.lbl_hora.Text = "Hora";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVidrio
            // 
            this.btnVidrio.BackColor = System.Drawing.Color.Gray;
            this.btnVidrio.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVidrio.FlatAppearance.BorderSize = 0;
            this.btnVidrio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVidrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVidrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVidrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidrio.Location = new System.Drawing.Point(360, 161);
            this.btnVidrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVidrio.Name = "btnVidrio";
            this.btnVidrio.Size = new System.Drawing.Size(199, 160);
            this.btnVidrio.TabIndex = 39;
            this.btnVidrio.Text = "Vidrio";
            this.btnVidrio.UseVisualStyleBackColor = false;
            this.btnVidrio.Click += new System.EventHandler(this.BtnVidrio_Click);
            // 
            // btnPlastico
            // 
            this.btnPlastico.BackColor = System.Drawing.Color.Gray;
            this.btnPlastico.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPlastico.FlatAppearance.BorderSize = 0;
            this.btnPlastico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPlastico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlastico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlastico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlastico.Location = new System.Drawing.Point(360, -1);
            this.btnPlastico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlastico.Name = "btnPlastico";
            this.btnPlastico.Size = new System.Drawing.Size(199, 160);
            this.btnPlastico.TabIndex = 40;
            this.btnPlastico.Text = "Plastico";
            this.btnPlastico.UseVisualStyleBackColor = false;
            this.btnPlastico.Click += new System.EventHandler(this.BtnPlastico_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Gray;
            this.btnPapel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPapel.FlatAppearance.BorderSize = 0;
            this.btnPapel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPapel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.Location = new System.Drawing.Point(565, -1);
            this.btnPapel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(209, 160);
            this.btnPapel.TabIndex = 41;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            // 
            // btnBio
            // 
            this.btnBio.BackColor = System.Drawing.Color.Gray;
            this.btnBio.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBio.FlatAppearance.BorderSize = 0;
            this.btnBio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBio.Location = new System.Drawing.Point(565, 161);
            this.btnBio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBio.Name = "btnBio";
            this.btnBio.Size = new System.Drawing.Size(209, 160);
            this.btnBio.TabIndex = 42;
            this.btnBio.Text = "Bio - Deg.";
            this.btnBio.UseVisualStyleBackColor = false;
            this.btnBio.Click += new System.EventHandler(this.BtnBio_Click);
            // 
            // lblQuepeso
            // 
            this.lblQuepeso.AutoSize = true;
            this.lblQuepeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuepeso.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuepeso.ForeColor = System.Drawing.Color.Lime;
            this.lblQuepeso.Location = new System.Drawing.Point(263, 17);
            this.lblQuepeso.Name = "lblQuepeso";
            this.lblQuepeso.Size = new System.Drawing.Size(29, 38);
            this.lblQuepeso.TabIndex = 43;
            this.lblQuepeso.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(418, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "Grs.";
            // 
            // lblPtsGanados
            // 
            this.lblPtsGanados.AutoSize = true;
            this.lblPtsGanados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPtsGanados.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtsGanados.ForeColor = System.Drawing.Color.Lime;
            this.lblPtsGanados.Location = new System.Drawing.Point(256, 208);
            this.lblPtsGanados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPtsGanados.Name = "lblPtsGanados";
            this.lblPtsGanados.Size = new System.Drawing.Size(33, 38);
            this.lblPtsGanados.TabIndex = 46;
            this.lblPtsGanados.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Primaton.Properties.Resources.eco_sistema_fondo_transparente_recuadro;
            this.pictureBox2.Location = new System.Drawing.Point(767, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Controls.Add(this.lblPuntosGanados);
            this.panel1.Controls.Add(this.lblPtsGanados);
            this.panel1.Controls.Add(this.lblPuntosAcumulados);
            this.panel1.Controls.Add(this.lbl_cantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.lblQuepeso);
            this.panel1.Controls.Add(this.btnPesar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(298, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 387);
            this.panel1.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(495, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 393);
            this.label14.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(-3, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(515, 10);
            this.label13.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(360, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 14);
            this.label1.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(360, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 10);
            this.label3.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(353, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 328);
            this.label4.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(764, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 328);
            this.label5.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(356, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 10);
            this.label6.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(558, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 321);
            this.label7.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(-2, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1070, 10);
            this.label8.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(-2, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 398);
            this.label9.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(-2, 716);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1098, 15);
            this.label10.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(1054, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 702);
            this.label11.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(289, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 387);
            this.label12.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbldni);
            this.panel2.Location = new System.Drawing.Point(809, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 156);
            this.panel2.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Usuario: ";
            // 
            // lbldni
            // 
            this.lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldni.Location = new System.Drawing.Point(3, 54);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(236, 101);
            this.lbldni.TabIndex = 0;
            this.lbldni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCerrar
            // 
            this.btCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.Image = global::Primaton.Properties.Resources.Close_Window__2_48px2;
            this.btCerrar.Location = new System.Drawing.Point(1010, 6);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(51, 51);
            this.btCerrar.TabIndex = 61;
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // frm_Pesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 725);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBio);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPlastico);
            this.Controls.Add(this.btnVidrio);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Pesaje";
            this.Load += new System.EventHandler(this.Frm_Pesaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lblPuntosAcumulados;
        private System.Windows.Forms.Label lblPuntosGanados;
        private System.Windows.Forms.Button btnPesar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btnVidrio;
        private System.Windows.Forms.Button btnPlastico;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnBio;
        private System.Windows.Forms.Label lblQuepeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPtsGanados;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Button btCerrar;
    }
}