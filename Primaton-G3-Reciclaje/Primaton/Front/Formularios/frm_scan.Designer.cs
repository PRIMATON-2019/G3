﻿namespace Primaton.Front.Formularios
{
    partial class frm_scan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_scan));
            this.lbl_info = new System.Windows.Forms.Label();
            this.pn_scanner = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btn_detenercamara = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.combobox_camara = new System.Windows.Forms.ComboBox();
            this.picbox_camara = new System.Windows.Forms.PictureBox();
            this.lbl_scanner = new System.Windows.Forms.Label();
            this.timer_scan = new System.Windows.Forms.Timer(this.components);
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.pn_scanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info.Location = new System.Drawing.Point(141, 49);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(207, 20);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "Camara de el Dispositivo";
            // 
            // pn_scanner
            // 
            this.pn_scanner.BackColor = System.Drawing.Color.White;
            this.pn_scanner.Controls.Add(this.label1);
            this.pn_scanner.Controls.Add(this.pictureBox1);
            this.pn_scanner.Controls.Add(this.lblDato);
            this.pn_scanner.Controls.Add(this.button1);
            this.pn_scanner.Controls.Add(this.lbl_hora);
            this.pn_scanner.Controls.Add(this.btn_detenercamara);
            this.pn_scanner.Controls.Add(this.btn_show);
            this.pn_scanner.Controls.Add(this.btn_inicio);
            this.pn_scanner.Controls.Add(this.combobox_camara);
            this.pn_scanner.Controls.Add(this.lbl_info);
            this.pn_scanner.Controls.Add(this.picbox_camara);
            this.pn_scanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_scanner.Location = new System.Drawing.Point(0, 0);
            this.pn_scanner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_scanner.Name = "pn_scanner";
            this.pn_scanner.Size = new System.Drawing.Size(713, 484);
            this.pn_scanner.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(509, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primaton.Properties.Resources.eco_sistema_fondo_transparente_recuadro;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDato.Location = new System.Drawing.Point(508, 130);
            this.lblDato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(73, 20);
            this.lblDato.TabIndex = 13;
            this.lblDato.Text = "usuario:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(508, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 176);
            this.button1.TabIndex = 11;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_hora.Location = new System.Drawing.Point(536, 10);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(166, 97);
            this.lbl_hora.TabIndex = 9;
            this.lbl_hora.Text = "12:32:25";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_detenercamara
            // 
            this.btn_detenercamara.BackColor = System.Drawing.Color.Silver;
            this.btn_detenercamara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detenercamara.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_detenercamara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_detenercamara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_detenercamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detenercamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_detenercamara.Location = new System.Drawing.Point(186, 381);
            this.btn_detenercamara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_detenercamara.Name = "btn_detenercamara";
            this.btn_detenercamara.Size = new System.Drawing.Size(129, 93);
            this.btn_detenercamara.TabIndex = 8;
            this.btn_detenercamara.Text = "Detener Camara";
            this.btn_detenercamara.UseVisualStyleBackColor = false;
            this.btn_detenercamara.Click += new System.EventHandler(this.Btn_detenercamara_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Silver;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_show.Location = new System.Drawing.Point(351, 381);
            this.btn_show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(129, 93);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Mostrar Codigo";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Silver;
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.Location = new System.Drawing.Point(12, 381);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(129, 93);
            this.btn_inicio.TabIndex = 6;
            this.btn_inicio.Text = "Iniciar";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // combobox_camara
            // 
            this.combobox_camara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.combobox_camara.Cursor = System.Windows.Forms.Cursors.No;
            this.combobox_camara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_camara.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.combobox_camara.FormattingEnabled = true;
            this.combobox_camara.Location = new System.Drawing.Point(366, 48);
            this.combobox_camara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combobox_camara.Name = "combobox_camara";
            this.combobox_camara.Size = new System.Drawing.Size(150, 21);
            this.combobox_camara.TabIndex = 5;
            // 
            // picbox_camara
            // 
            this.picbox_camara.BackColor = System.Drawing.Color.Transparent;
            this.picbox_camara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_camara.Location = new System.Drawing.Point(12, 106);
            this.picbox_camara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbox_camara.Name = "picbox_camara";
            this.picbox_camara.Size = new System.Drawing.Size(468, 271);
            this.picbox_camara.TabIndex = 3;
            this.picbox_camara.TabStop = false;
            // 
            // lbl_scanner
            // 
            this.lbl_scanner.AutoSize = true;
            this.lbl_scanner.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.lbl_scanner.Location = new System.Drawing.Point(209, 86);
            this.lbl_scanner.Name = "lbl_scanner";
            this.lbl_scanner.Size = new System.Drawing.Size(71, 17);
            this.lbl_scanner.TabIndex = 16;
            this.lbl_scanner.Text = "Escanear";
            // 
            // timer_scan
            // 
            this.timer_scan.Tick += new System.EventHandler(this.Timer_scan_Tick);
            // 
            // timer_hora
            // 
            this.timer_hora.Interval = 1000;
            this.timer_hora.Tick += new System.EventHandler(this.Timer_hora_Tick);
            // 
            // frm_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 484);
            this.Controls.Add(this.pn_scanner);
            this.Controls.Add(this.lbl_scanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_scan_FormClosing);
            this.pn_scanner.ResumeLayout(false);
            this.pn_scanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel pn_scanner;
        private System.Windows.Forms.Button btn_detenercamara;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.ComboBox combobox_camara;
        private System.Windows.Forms.PictureBox picbox_camara;
        private System.Windows.Forms.Label lbl_scanner;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer_scan;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}