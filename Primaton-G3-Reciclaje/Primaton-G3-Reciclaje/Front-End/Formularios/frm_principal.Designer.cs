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
            this.pn_dni = new System.Windows.Forms.Panel();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.lbl_infomanual = new System.Windows.Forms.Label();
            this.btn_sig = new System.Windows.Forms.Button();
            this.pn_scanner = new System.Windows.Forms.Panel();
            this.picbox_camara = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.combobox_camara = new System.Windows.Forms.ComboBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_dni.SuspendLayout();
            this.pn_scanner.SuspendLayout();
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
            // pn_dni
            // 
            this.pn_dni.Controls.Add(this.btn_0);
            this.pn_dni.Controls.Add(this.btn_9);
            this.pn_dni.Controls.Add(this.lbl_infomanual);
            this.pn_dni.Controls.Add(this.btn_8);
            this.pn_dni.Controls.Add(this.btn_7);
            this.pn_dni.Controls.Add(this.txt_documento);
            this.pn_dni.Controls.Add(this.btn_3);
            this.pn_dni.Controls.Add(this.btn_6);
            this.pn_dni.Controls.Add(this.btn_2);
            this.pn_dni.Controls.Add(this.btn_5);
            this.pn_dni.Controls.Add(this.btn_4);
            this.pn_dni.Controls.Add(this.btn_1);
            this.pn_dni.Location = new System.Drawing.Point(717, 155);
            this.pn_dni.Margin = new System.Windows.Forms.Padding(4);
            this.pn_dni.Name = "pn_dni";
            this.pn_dni.Size = new System.Drawing.Size(251, 324);
            this.pn_dni.TabIndex = 10;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Olive;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Location = new System.Drawing.Point(88, 275);
            this.btn_0.Margin = new System.Windows.Forms.Padding(4);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(85, 54);
            this.btn_0.TabIndex = 9;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Olive;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Location = new System.Drawing.Point(164, 229);
            this.btn_9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(48, 43);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Olive;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Location = new System.Drawing.Point(105, 229);
            this.btn_8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(48, 43);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Olive;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Location = new System.Drawing.Point(42, 229);
            this.btn_7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(48, 43);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Olive;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Location = new System.Drawing.Point(164, 127);
            this.btn_3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(48, 43);
            this.btn_3.TabIndex = 5;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Olive;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Location = new System.Drawing.Point(164, 178);
            this.btn_6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(48, 43);
            this.btn_6.TabIndex = 4;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Olive;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Location = new System.Drawing.Point(105, 127);
            this.btn_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(48, 43);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Olive;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Location = new System.Drawing.Point(105, 178);
            this.btn_5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(48, 43);
            this.btn_5.TabIndex = 2;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Olive;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Location = new System.Drawing.Point(42, 178);
            this.btn_4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(48, 43);
            this.btn_4.TabIndex = 1;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Olive;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Location = new System.Drawing.Point(42, 127);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(48, 43);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // txt_documento
            // 
            this.txt_documento.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_documento.Location = new System.Drawing.Point(25, 97);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(220, 22);
            this.txt_documento.TabIndex = 11;
            // 
            // lbl_infomanual
            // 
            this.lbl_infomanual.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.lbl_infomanual.Location = new System.Drawing.Point(63, 10);
            this.lbl_infomanual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_infomanual.Name = "lbl_infomanual";
            this.lbl_infomanual.Size = new System.Drawing.Size(139, 23);
            this.lbl_infomanual.TabIndex = 12;
            this.lbl_infomanual.Text = "Manualmente";
            // 
            // btn_sig
            // 
            this.btn_sig.BackColor = System.Drawing.Color.Olive;
            this.btn_sig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sig.Location = new System.Drawing.Point(505, 316);
            this.btn_sig.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sig.Name = "btn_sig";
            this.btn_sig.Size = new System.Drawing.Size(204, 163);
            this.btn_sig.TabIndex = 13;
            this.btn_sig.Text = "Siguiente";
            this.btn_sig.UseVisualStyleBackColor = false;
            // 
            // pn_scanner
            // 
            this.pn_scanner.Controls.Add(this.btn_show);
            this.pn_scanner.Controls.Add(this.btn_inicio);
            this.pn_scanner.Controls.Add(this.combobox_camara);
            this.pn_scanner.Controls.Add(this.lbl_info);
            this.pn_scanner.Controls.Add(this.picbox_camara);
            this.pn_scanner.Location = new System.Drawing.Point(12, 143);
            this.pn_scanner.Name = "pn_scanner";
            this.pn_scanner.Size = new System.Drawing.Size(484, 349);
            this.pn_scanner.TabIndex = 15;
            // 
            // picbox_camara
            // 
            this.picbox_camara.Location = new System.Drawing.Point(19, 44);
            this.picbox_camara.Name = "picbox_camara";
            this.picbox_camara.Size = new System.Drawing.Size(454, 240);
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
            this.combobox_camara.Cursor = System.Windows.Forms.Cursors.No;
            this.combobox_camara.FormattingEnabled = true;
            this.combobox_camara.Location = new System.Drawing.Point(194, 12);
            this.combobox_camara.Name = "combobox_camara";
            this.combobox_camara.Size = new System.Drawing.Size(254, 24);
            this.combobox_camara.TabIndex = 5;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Olive;
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Controls.Add(this.pn_scanner);
            this.Controls.Add(this.btn_sig);
            this.Controls.Add(this.pn_dni);
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
            this.pn_dni.ResumeLayout(false);
            this.pn_dni.PerformLayout();
            this.pn_scanner.ResumeLayout(false);
            this.pn_scanner.PerformLayout();
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
        private System.Windows.Forms.Panel pn_dni;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label lbl_infomanual;
        private System.Windows.Forms.Button btn_sig;
        private System.Windows.Forms.Panel pn_scanner;
        private System.Windows.Forms.PictureBox picbox_camara;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox combobox_camara;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Timer timer1;
    }
}

