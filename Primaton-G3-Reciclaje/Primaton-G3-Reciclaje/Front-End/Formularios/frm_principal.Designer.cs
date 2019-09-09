namespace Primaton_G3_Reciclaje
{
    partial class frm_principal
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
            this.lbl_informacionDNI = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.link_lbl = new System.Windows.Forms.LinkLabel();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.btn_reciclar = new System.Windows.Forms.Button();
            this.lbl_scanner = new System.Windows.Forms.Label();
            this.paneldoc = new System.Windows.Forms.Panel();
            this.BTNN0 = new System.Windows.Forms.Button();
            this.BTNN9 = new System.Windows.Forms.Button();
            this.BTNN8 = new System.Windows.Forms.Button();
            this.BTNN7 = new System.Windows.Forms.Button();
            this.BTNN3 = new System.Windows.Forms.Button();
            this.BTNN6 = new System.Windows.Forms.Button();
            this.BTNN2 = new System.Windows.Forms.Button();
            this.BTNN5 = new System.Windows.Forms.Button();
            this.BTNN4 = new System.Windows.Forms.Button();
            this.BTNN1 = new System.Windows.Forms.Button();
            this.txtDOC = new System.Windows.Forms.TextBox();
            this.txtmanual = new System.Windows.Forms.Label();
            this.btn_sig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox_camara = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.combobox_camara = new System.Windows.Forms.ComboBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paneldoc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_informacionDNI
            // 
            this.lbl_informacionDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_informacionDNI.Font = new System.Drawing.Font("Verdana", 24F);
            this.lbl_informacionDNI.Location = new System.Drawing.Point(318, 77);
            this.lbl_informacionDNI.Name = "lbl_informacionDNI";
            this.lbl_informacionDNI.Size = new System.Drawing.Size(372, 63);
            this.lbl_informacionDNI.TabIndex = 2;
            this.lbl_informacionDNI.Text = "INGRESE SU DNI";
            this.lbl_informacionDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(676, 7);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(301, 121);
            this.lbl_hora.TabIndex = 3;
            this.lbl_hora.Text = "12:32:25";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_lbl
            // 
            this.link_lbl.AutoSize = true;
            this.link_lbl.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.link_lbl.Location = new System.Drawing.Point(28, 543);
            this.link_lbl.Name = "link_lbl";
            this.link_lbl.Size = new System.Drawing.Size(147, 17);
            this.link_lbl.TabIndex = 4;
            this.link_lbl.TabStop = true;
            this.link_lbl.Text = "¿Queres ser Parte? ";
            this.link_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_lbl_LinkClicked);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.Font = new System.Drawing.Font("Verdana", 19.8F);
            this.lbl_bienvenida.Location = new System.Drawing.Point(387, 8);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(303, 53);
            this.lbl_bienvenida.TabIndex = 5;
            this.lbl_bienvenida.Text = "BIENVENIDA/O";
            this.lbl_bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_hora
            // 
            this.timer_hora.Enabled = true;
            this.timer_hora.Interval = 1000;
            this.timer_hora.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_reciclar
            // 
            this.btn_reciclar.Location = new System.Drawing.Point(206, 541);
            this.btn_reciclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reciclar.Name = "btn_reciclar";
            this.btn_reciclar.Size = new System.Drawing.Size(103, 23);
            this.btn_reciclar.TabIndex = 8;
            this.btn_reciclar.Text = "modificar";
            this.btn_reciclar.UseVisualStyleBackColor = true;
            this.btn_reciclar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_scanner
            // 
            this.lbl_scanner.AutoSize = true;
            this.lbl_scanner.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.lbl_scanner.Location = new System.Drawing.Point(59, 107);
            this.lbl_scanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_scanner.Name = "lbl_scanner";
            this.lbl_scanner.Size = new System.Drawing.Size(91, 22);
            this.lbl_scanner.TabIndex = 9;
            this.lbl_scanner.Text = "Escanear";
            // 
            // paneldoc
            // 
            this.paneldoc.Controls.Add(this.BTNN0);
            this.paneldoc.Controls.Add(this.BTNN9);
            this.paneldoc.Controls.Add(this.txtmanual);
            this.paneldoc.Controls.Add(this.BTNN8);
            this.paneldoc.Controls.Add(this.BTNN7);
            this.paneldoc.Controls.Add(this.txtDOC);
            this.paneldoc.Controls.Add(this.BTNN3);
            this.paneldoc.Controls.Add(this.BTNN6);
            this.paneldoc.Controls.Add(this.BTNN2);
            this.paneldoc.Controls.Add(this.BTNN5);
            this.paneldoc.Controls.Add(this.BTNN4);
            this.paneldoc.Controls.Add(this.BTNN1);
            this.paneldoc.Location = new System.Drawing.Point(717, 155);
            this.paneldoc.Margin = new System.Windows.Forms.Padding(4);
            this.paneldoc.Name = "paneldoc";
            this.paneldoc.Size = new System.Drawing.Size(251, 324);
            this.paneldoc.TabIndex = 10;
            // 
            // BTNN0
            // 
            this.BTNN0.BackColor = System.Drawing.Color.Olive;
            this.BTNN0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN0.Location = new System.Drawing.Point(88, 275);
            this.BTNN0.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN0.Name = "BTNN0";
            this.BTNN0.Size = new System.Drawing.Size(85, 54);
            this.BTNN0.TabIndex = 9;
            this.BTNN0.Text = "0";
            this.BTNN0.UseVisualStyleBackColor = false;
            // 
            // BTNN9
            // 
            this.BTNN9.BackColor = System.Drawing.Color.Olive;
            this.BTNN9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN9.Location = new System.Drawing.Point(164, 229);
            this.BTNN9.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN9.Name = "BTNN9";
            this.BTNN9.Size = new System.Drawing.Size(48, 43);
            this.BTNN9.TabIndex = 8;
            this.BTNN9.Text = "9";
            this.BTNN9.UseVisualStyleBackColor = false;
            // 
            // BTNN8
            // 
            this.BTNN8.BackColor = System.Drawing.Color.Olive;
            this.BTNN8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN8.Location = new System.Drawing.Point(105, 229);
            this.BTNN8.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN8.Name = "BTNN8";
            this.BTNN8.Size = new System.Drawing.Size(48, 43);
            this.BTNN8.TabIndex = 7;
            this.BTNN8.Text = "8";
            this.BTNN8.UseVisualStyleBackColor = false;
            // 
            // BTNN7
            // 
            this.BTNN7.BackColor = System.Drawing.Color.Olive;
            this.BTNN7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN7.Location = new System.Drawing.Point(42, 229);
            this.BTNN7.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN7.Name = "BTNN7";
            this.BTNN7.Size = new System.Drawing.Size(48, 43);
            this.BTNN7.TabIndex = 6;
            this.BTNN7.Text = "7";
            this.BTNN7.UseVisualStyleBackColor = false;
            // 
            // BTNN3
            // 
            this.BTNN3.BackColor = System.Drawing.Color.Olive;
            this.BTNN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN3.Location = new System.Drawing.Point(164, 127);
            this.BTNN3.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN3.Name = "BTNN3";
            this.BTNN3.Size = new System.Drawing.Size(48, 43);
            this.BTNN3.TabIndex = 5;
            this.BTNN3.Text = "3";
            this.BTNN3.UseVisualStyleBackColor = false;
            // 
            // BTNN6
            // 
            this.BTNN6.BackColor = System.Drawing.Color.Olive;
            this.BTNN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN6.Location = new System.Drawing.Point(164, 178);
            this.BTNN6.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN6.Name = "BTNN6";
            this.BTNN6.Size = new System.Drawing.Size(48, 43);
            this.BTNN6.TabIndex = 4;
            this.BTNN6.Text = "6";
            this.BTNN6.UseVisualStyleBackColor = false;
            // 
            // BTNN2
            // 
            this.BTNN2.BackColor = System.Drawing.Color.Olive;
            this.BTNN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN2.Location = new System.Drawing.Point(105, 127);
            this.BTNN2.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN2.Name = "BTNN2";
            this.BTNN2.Size = new System.Drawing.Size(48, 43);
            this.BTNN2.TabIndex = 3;
            this.BTNN2.Text = "2";
            this.BTNN2.UseVisualStyleBackColor = false;
            // 
            // BTNN5
            // 
            this.BTNN5.BackColor = System.Drawing.Color.Olive;
            this.BTNN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN5.Location = new System.Drawing.Point(105, 178);
            this.BTNN5.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN5.Name = "BTNN5";
            this.BTNN5.Size = new System.Drawing.Size(48, 43);
            this.BTNN5.TabIndex = 2;
            this.BTNN5.Text = "5";
            this.BTNN5.UseVisualStyleBackColor = false;
            // 
            // BTNN4
            // 
            this.BTNN4.BackColor = System.Drawing.Color.Olive;
            this.BTNN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN4.Location = new System.Drawing.Point(42, 178);
            this.BTNN4.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN4.Name = "BTNN4";
            this.BTNN4.Size = new System.Drawing.Size(48, 43);
            this.BTNN4.TabIndex = 1;
            this.BTNN4.Text = "4";
            this.BTNN4.UseVisualStyleBackColor = false;
            // 
            // BTNN1
            // 
            this.BTNN1.BackColor = System.Drawing.Color.Olive;
            this.BTNN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNN1.Location = new System.Drawing.Point(42, 127);
            this.BTNN1.Margin = new System.Windows.Forms.Padding(4);
            this.BTNN1.Name = "BTNN1";
            this.BTNN1.Size = new System.Drawing.Size(48, 43);
            this.BTNN1.TabIndex = 0;
            this.BTNN1.Text = "1";
            this.BTNN1.UseVisualStyleBackColor = false;
            // 
            // txtDOC
            // 
            this.txtDOC.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDOC.Location = new System.Drawing.Point(25, 97);
            this.txtDOC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOC.Name = "txtDOC";
            this.txtDOC.Size = new System.Drawing.Size(220, 22);
            this.txtDOC.TabIndex = 11;
            // 
            // txtmanual
            // 
            this.txtmanual.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.txtmanual.Location = new System.Drawing.Point(63, 10);
            this.txtmanual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmanual.Name = "txtmanual";
            this.txtmanual.Size = new System.Drawing.Size(139, 23);
            this.txtmanual.TabIndex = 12;
            this.txtmanual.Text = "Manualmente";
            // 
            // btn_sig
            // 
            this.btn_sig.BackColor = System.Drawing.Color.Olive;
            this.btn_sig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sig.Location = new System.Drawing.Point(505, 316);
            this.btn_sig.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sig.Name = "btn_sig";
            this.btn_sig.Size = new System.Drawing.Size(204, 163);
            this.btn_sig.TabIndex = 13;
            this.btn_sig.Text = "Siguiente";
            this.btn_sig.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_show);
            this.panel1.Controls.Add(this.btn_inicio);
            this.panel1.Controls.Add(this.combobox_camara);
            this.panel1.Controls.Add(this.lbl_info);
            this.panel1.Controls.Add(this.picbox_camara);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 349);
            this.panel1.TabIndex = 15;
            // 
            // picbox_camara
            // 
            this.picbox_camara.Location = new System.Drawing.Point(19, 44);
            this.picbox_camara.Name = "picbox_camara";
            this.picbox_camara.Size = new System.Drawing.Size(250, 241);
            this.picbox_camara.TabIndex = 3;
            this.picbox_camara.TabStop = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info.Location = new System.Drawing.Point(16, 12);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(164, 17);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "Camara de el Dispositivo";
            // 
            // combobox_camara
            // 
            this.combobox_camara.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.combobox_camara.FormattingEnabled = true;
            this.combobox_camara.Location = new System.Drawing.Point(194, 12);
            this.combobox_camara.Name = "combobox_camara";
            this.combobox_camara.Size = new System.Drawing.Size(254, 24);
            this.combobox_camara.TabIndex = 5;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Olive;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(74, 291);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(127, 45);
            this.btn_inicio.TabIndex = 6;
            this.btn_inicio.Text = "Iniciar";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Olive;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(275, 291);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(198, 45);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Mostrar Codigo";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(981, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sig);
            this.Controls.Add(this.paneldoc);
            this.Controls.Add(this.lbl_scanner);
            this.Controls.Add(this.btn_reciclar);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.link_lbl);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_informacionDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.ShowIcon = false;
            this.Text = "Reciclador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_principal_FormClosing);
            this.paneldoc.ResumeLayout(false);
            this.paneldoc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_informacionDNI;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.LinkLabel link_lbl;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.Button btn_reciclar;
        private System.Windows.Forms.Label lbl_scanner;
        private System.Windows.Forms.Panel paneldoc;
        private System.Windows.Forms.Button BTNN0;
        private System.Windows.Forms.Button BTNN9;
        private System.Windows.Forms.Button BTNN8;
        private System.Windows.Forms.Button BTNN7;
        private System.Windows.Forms.Button BTNN3;
        private System.Windows.Forms.Button BTNN6;
        private System.Windows.Forms.Button BTNN2;
        private System.Windows.Forms.Button BTNN5;
        private System.Windows.Forms.Button BTNN4;
        private System.Windows.Forms.Button BTNN1;
        private System.Windows.Forms.TextBox txtDOC;
        private System.Windows.Forms.Label txtmanual;
        private System.Windows.Forms.Button btn_sig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbox_camara;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox combobox_camara;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Timer timer1;
    }
}

