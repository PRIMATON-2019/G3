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
            this.btnVidrio = new System.Windows.Forms.Button();
            this.btnPlastico = new System.Windows.Forms.Button();
            this.btnBio = new System.Windows.Forms.Button();
            this.lblQuepeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPtsGanados = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPapel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(13, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 44);
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
            this.lblPeso.ForeColor = System.Drawing.Color.Yellow;
            this.lblPeso.Location = new System.Drawing.Point(252, 123);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(26, 30);
            this.lblPeso.TabIndex = 36;
            this.lblPeso.Text = "0";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cantidad.Location = new System.Drawing.Point(3, 122);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(243, 30);
            this.lbl_cantidad.TabIndex = 35;
            this.lbl_cantidad.Text = "El peso ingresado es: ";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinfo.Location = new System.Drawing.Point(8, 8);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(182, 30);
            this.lblinfo.TabIndex = 34;
            this.lblinfo.Text = "Estás pesando:  ";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(14, 14);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(131, 83);
            this.btCancelar.TabIndex = 33;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btVolver.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btVolver.FlatAppearance.BorderSize = 0;
            this.btVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(14, 114);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(131, 83);
            this.btVolver.TabIndex = 32;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btFinalizar.Enabled = false;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btFinalizar.FlatAppearance.BorderSize = 0;
            this.btFinalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(16, 15);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(139, 40);
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
            this.lblPuntosAcumulados.Location = new System.Drawing.Point(8, 214);
            this.lblPuntosAcumulados.Name = "lblPuntosAcumulados";
            this.lblPuntosAcumulados.Size = new System.Drawing.Size(321, 30);
            this.lblPuntosAcumulados.TabIndex = 30;
            this.lblPuntosAcumulados.Text = "Total de puntos acumulados:";
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuntosGanados.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosGanados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosGanados.Location = new System.Drawing.Point(3, 172);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(188, 30);
            this.lblPuntosGanados.TabIndex = 28;
            this.lblPuntosGanados.Text = "Puntos ganados:";
            // 
            // btnPesar
            // 
            this.btnPesar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPesar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPesar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesar.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesar.Location = new System.Drawing.Point(13, 12);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(139, 44);
            this.btnPesar.TabIndex = 27;
            this.btnPesar.Text = "Pesar";
            this.btnPesar.UseVisualStyleBackColor = false;
            this.btnPesar.Click += new System.EventHandler(this.BtnPesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnVidrio
            // 
            this.btnVidrio.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVidrio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnVidrio.FlatAppearance.BorderSize = 0;
            this.btnVidrio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnVidrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVidrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVidrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidrio.Location = new System.Drawing.Point(11, 11);
            this.btnVidrio.Margin = new System.Windows.Forms.Padding(2);
            this.btnVidrio.Name = "btnVidrio";
            this.btnVidrio.Size = new System.Drawing.Size(105, 73);
            this.btnVidrio.TabIndex = 39;
            this.btnVidrio.Text = "Vidrio";
            this.btnVidrio.UseVisualStyleBackColor = false;
            this.btnVidrio.Click += new System.EventHandler(this.BtnVidrio_Click);
            // 
            // btnPlastico
            // 
            this.btnPlastico.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlastico.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPlastico.FlatAppearance.BorderSize = 0;
            this.btnPlastico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnPlastico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlastico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlastico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlastico.Location = new System.Drawing.Point(11, 97);
            this.btnPlastico.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlastico.Name = "btnPlastico";
            this.btnPlastico.Size = new System.Drawing.Size(105, 73);
            this.btnPlastico.TabIndex = 40;
            this.btnPlastico.Text = "Plastico";
            this.btnPlastico.UseVisualStyleBackColor = false;
            this.btnPlastico.Click += new System.EventHandler(this.BtnPlastico_Click);
            // 
            // btnBio
            // 
            this.btnBio.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnBio.FlatAppearance.BorderSize = 0;
            this.btnBio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnBio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBio.Location = new System.Drawing.Point(132, 97);
            this.btnBio.Margin = new System.Windows.Forms.Padding(2);
            this.btnBio.Name = "btnBio";
            this.btnBio.Size = new System.Drawing.Size(105, 73);
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
            this.lblQuepeso.Location = new System.Drawing.Point(197, 14);
            this.lblQuepeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuepeso.Name = "lblQuepeso";
            this.lblQuepeso.Size = new System.Drawing.Size(23, 30);
            this.lblQuepeso.TabIndex = 43;
            this.lblQuepeso.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(314, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 44;
            this.label2.Text = "Grs.";
            // 
            // lblPtsGanados
            // 
            this.lblPtsGanados.AutoSize = true;
            this.lblPtsGanados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPtsGanados.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtsGanados.ForeColor = System.Drawing.Color.Lime;
            this.lblPtsGanados.Location = new System.Drawing.Point(192, 169);
            this.lblPtsGanados.Name = "lblPtsGanados";
            this.lblPtsGanados.Size = new System.Drawing.Size(26, 30);
            this.lblPtsGanados.TabIndex = 46;
            this.lblPtsGanados.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Controls.Add(this.lblPuntosGanados);
            this.panel1.Controls.Add(this.lblPtsGanados);
            this.panel1.Controls.Add(this.lblPuntosAcumulados);
            this.panel1.Controls.Add(this.lbl_cantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.lblQuepeso);
            this.panel1.Location = new System.Drawing.Point(215, 245);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 319);
            this.panel1.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-2, 306);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(386, 8);
            this.label13.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-2, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(8, 323);
            this.label9.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-2, 582);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(824, 12);
            this.label10.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbldni);
            this.panel2.Location = new System.Drawing.Point(607, 271);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 127);
            this.panel2.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Usuario: ";
            // 
            // lbldni
            // 
            this.lbldni.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldni.Location = new System.Drawing.Point(2, 44);
            this.lbldni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(177, 82);
            this.lbldni.TabIndex = 0;
            this.lbldni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Primaton.Properties.Resources.eco_sistema_fondo_transparente_recuadro;
            this.pictureBox2.Location = new System.Drawing.Point(592, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPapel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPapel.FlatAppearance.BorderSize = 0;
            this.btnPapel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnPapel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.Location = new System.Drawing.Point(132, 11);
            this.btnPapel.Margin = new System.Windows.Forms.Padding(2);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(105, 73);
            this.btnPapel.TabIndex = 41;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.BtnPapel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.btnVidrio);
            this.panel3.Controls.Add(this.btnPlastico);
            this.panel3.Controls.Add(this.btnPapel);
            this.panel3.Controls.Add(this.btnBio);
            this.panel3.Location = new System.Drawing.Point(295, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 180);
            this.panel3.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.Controls.Add(this.btCancelar);
            this.panel4.Controls.Add(this.btVolver);
            this.panel4.Location = new System.Drawing.Point(10, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 209);
            this.panel4.TabIndex = 62;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.btFinalizar);
            this.panel5.Location = new System.Drawing.Point(608, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 70);
            this.panel5.TabIndex = 63;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_hora.Location = new System.Drawing.Point(592, 197);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(200, 52);
            this.lbl_hora.TabIndex = 38;
            this.lbl_hora.Text = "Hora";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 82);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGreen;
            this.panel6.Controls.Add(this.btnAceptar);
            this.panel6.Location = new System.Drawing.Point(112, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 67);
            this.panel6.TabIndex = 64;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGreen;
            this.panel7.Controls.Add(this.btnPesar);
            this.panel7.Location = new System.Drawing.Point(112, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 67);
            this.panel7.TabIndex = 64;
            // 
            // frm_Pesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Pesaje";
            this.Load += new System.EventHandler(this.Frm_Pesaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnVidrio;
        private System.Windows.Forms.Button btnPlastico;
        private System.Windows.Forms.Button btnBio;
        private System.Windows.Forms.Label lblQuepeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPtsGanados;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}