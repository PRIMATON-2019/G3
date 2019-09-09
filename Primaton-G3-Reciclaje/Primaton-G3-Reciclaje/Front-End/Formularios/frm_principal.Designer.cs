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
            this.btnscann = new System.Windows.Forms.Button();
            this.bl_info = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.link_lbl = new System.Windows.Forms.LinkLabel();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.btn_reciclar = new System.Windows.Forms.Button();
            this.txtEscanear = new System.Windows.Forms.Label();
            this.paneldoc = new System.Windows.Forms.Panel();
            this.BTNN1 = new System.Windows.Forms.Button();
            this.BTNN4 = new System.Windows.Forms.Button();
            this.BTNN5 = new System.Windows.Forms.Button();
            this.BTNN2 = new System.Windows.Forms.Button();
            this.BTNN6 = new System.Windows.Forms.Button();
            this.BTNN3 = new System.Windows.Forms.Button();
            this.BTNN7 = new System.Windows.Forms.Button();
            this.BTNN8 = new System.Windows.Forms.Button();
            this.BTNN9 = new System.Windows.Forms.Button();
            this.BTNN0 = new System.Windows.Forms.Button();
            this.txtDOC = new System.Windows.Forms.TextBox();
            this.txtmanual = new System.Windows.Forms.Label();
            this.btn_sig = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.paneldoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnscann
            // 
            this.btnscann.BackColor = System.Drawing.Color.Transparent;
            this.btnscann.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnscann.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnscann.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnscann.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnscann.Location = new System.Drawing.Point(86, 227);
            this.btnscann.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnscann.Name = "btnscann";
            this.btnscann.Size = new System.Drawing.Size(132, 113);
            this.btnscann.TabIndex = 1;
            this.btnscann.Text = "Scan";
            this.btnscann.UseVisualStyleBackColor = false;
            this.btnscann.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bl_info
            // 
            this.bl_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bl_info.Font = new System.Drawing.Font("Verdana", 24F);
            this.bl_info.Location = new System.Drawing.Point(79, 86);
            this.bl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bl_info.Name = "bl_info";
            this.bl_info.Size = new System.Drawing.Size(473, 45);
            this.bl_info.TabIndex = 2;
            this.bl_info.Text = "INGRESE SU DNI";
            this.bl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bl_info.Click += new System.EventHandler(this.Bl_info_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(498, 7);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(230, 42);
            this.lbl_hora.TabIndex = 3;
            this.lbl_hora.Text = "12:32:25";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_lbl
            // 
            this.link_lbl.AutoSize = true;
            this.link_lbl.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.link_lbl.Location = new System.Drawing.Point(21, 441);
            this.link_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_lbl.Name = "link_lbl";
            this.link_lbl.Size = new System.Drawing.Size(120, 13);
            this.link_lbl.TabIndex = 4;
            this.link_lbl.TabStop = true;
            this.link_lbl.Text = "¿Queres ser Parte? ";
            this.link_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_lbl_LinkClicked);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.Font = new System.Drawing.Font("Verdana", 19.8F);
            this.lbl_bienvenida.Location = new System.Drawing.Point(240, 9);
            this.lbl_bienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(227, 43);
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
            this.btn_reciclar.Location = new System.Drawing.Point(116, 371);
            this.btn_reciclar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reciclar.Name = "btn_reciclar";
            this.btn_reciclar.Size = new System.Drawing.Size(77, 19);
            this.btn_reciclar.TabIndex = 8;
            this.btn_reciclar.Text = "modificar";
            this.btn_reciclar.UseVisualStyleBackColor = true;
            this.btn_reciclar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtEscanear
            // 
            this.txtEscanear.AutoSize = true;
            this.txtEscanear.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.txtEscanear.Location = new System.Drawing.Point(113, 185);
            this.txtEscanear.Name = "txtEscanear";
            this.txtEscanear.Size = new System.Drawing.Size(71, 17);
            this.txtEscanear.TabIndex = 9;
            this.txtEscanear.Text = "Escanear";
            this.txtEscanear.Click += new System.EventHandler(this.TxtEscanear_Click);
            // 
            // paneldoc
            // 
            this.paneldoc.Controls.Add(this.BTNN0);
            this.paneldoc.Controls.Add(this.BTNN9);
            this.paneldoc.Controls.Add(this.BTNN8);
            this.paneldoc.Controls.Add(this.BTNN7);
            this.paneldoc.Controls.Add(this.BTNN3);
            this.paneldoc.Controls.Add(this.BTNN6);
            this.paneldoc.Controls.Add(this.BTNN2);
            this.paneldoc.Controls.Add(this.BTNN5);
            this.paneldoc.Controls.Add(this.BTNN4);
            this.paneldoc.Controls.Add(this.BTNN1);
            this.paneldoc.Location = new System.Drawing.Point(483, 227);
            this.paneldoc.Name = "paneldoc";
            this.paneldoc.Size = new System.Drawing.Size(203, 149);
            this.paneldoc.TabIndex = 10;
            // 
            // BTNN1
            // 
            this.BTNN1.Location = new System.Drawing.Point(18, 13);
            this.BTNN1.Name = "BTNN1";
            this.BTNN1.Size = new System.Drawing.Size(36, 35);
            this.BTNN1.TabIndex = 0;
            this.BTNN1.Text = "1";
            this.BTNN1.UseVisualStyleBackColor = true;
            // 
            // BTNN4
            // 
            this.BTNN4.Location = new System.Drawing.Point(18, 54);
            this.BTNN4.Name = "BTNN4";
            this.BTNN4.Size = new System.Drawing.Size(36, 35);
            this.BTNN4.TabIndex = 1;
            this.BTNN4.Text = "4";
            this.BTNN4.UseVisualStyleBackColor = true;
            // 
            // BTNN5
            // 
            this.BTNN5.Location = new System.Drawing.Point(60, 54);
            this.BTNN5.Name = "BTNN5";
            this.BTNN5.Size = new System.Drawing.Size(36, 35);
            this.BTNN5.TabIndex = 2;
            this.BTNN5.Text = "5";
            this.BTNN5.UseVisualStyleBackColor = true;
            // 
            // BTNN2
            // 
            this.BTNN2.Location = new System.Drawing.Point(60, 13);
            this.BTNN2.Name = "BTNN2";
            this.BTNN2.Size = new System.Drawing.Size(36, 35);
            this.BTNN2.TabIndex = 3;
            this.BTNN2.Text = "2";
            this.BTNN2.UseVisualStyleBackColor = true;
            // 
            // BTNN6
            // 
            this.BTNN6.Location = new System.Drawing.Point(102, 54);
            this.BTNN6.Name = "BTNN6";
            this.BTNN6.Size = new System.Drawing.Size(36, 35);
            this.BTNN6.TabIndex = 4;
            this.BTNN6.Text = "6";
            this.BTNN6.UseVisualStyleBackColor = true;
            // 
            // BTNN3
            // 
            this.BTNN3.Location = new System.Drawing.Point(102, 13);
            this.BTNN3.Name = "BTNN3";
            this.BTNN3.Size = new System.Drawing.Size(36, 35);
            this.BTNN3.TabIndex = 5;
            this.BTNN3.Text = "3";
            this.BTNN3.UseVisualStyleBackColor = true;
            // 
            // BTNN7
            // 
            this.BTNN7.Location = new System.Drawing.Point(18, 95);
            this.BTNN7.Name = "BTNN7";
            this.BTNN7.Size = new System.Drawing.Size(36, 35);
            this.BTNN7.TabIndex = 6;
            this.BTNN7.Text = "7";
            this.BTNN7.UseVisualStyleBackColor = true;
            // 
            // BTNN8
            // 
            this.BTNN8.Location = new System.Drawing.Point(60, 95);
            this.BTNN8.Name = "BTNN8";
            this.BTNN8.Size = new System.Drawing.Size(36, 35);
            this.BTNN8.TabIndex = 7;
            this.BTNN8.Text = "8";
            this.BTNN8.UseVisualStyleBackColor = true;
            // 
            // BTNN9
            // 
            this.BTNN9.Location = new System.Drawing.Point(102, 95);
            this.BTNN9.Name = "BTNN9";
            this.BTNN9.Size = new System.Drawing.Size(36, 35);
            this.BTNN9.TabIndex = 8;
            this.BTNN9.Text = "9";
            this.BTNN9.UseVisualStyleBackColor = true;
            this.BTNN9.Click += new System.EventHandler(this.Button11_Click);
            // 
            // BTNN0
            // 
            this.BTNN0.Location = new System.Drawing.Point(144, 95);
            this.BTNN0.Name = "BTNN0";
            this.BTNN0.Size = new System.Drawing.Size(36, 35);
            this.BTNN0.TabIndex = 9;
            this.BTNN0.Text = "0";
            this.BTNN0.UseVisualStyleBackColor = true;
            // 
            // txtDOC
            // 
            this.txtDOC.Location = new System.Drawing.Point(483, 196);
            this.txtDOC.Name = "txtDOC";
            this.txtDOC.Size = new System.Drawing.Size(203, 20);
            this.txtDOC.TabIndex = 11;
            this.txtDOC.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtmanual
            // 
            this.txtmanual.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.txtmanual.Location = new System.Drawing.Point(528, 174);
            this.txtmanual.Name = "txtmanual";
            this.txtmanual.Size = new System.Drawing.Size(104, 19);
            this.txtmanual.TabIndex = 12;
            this.txtmanual.Text = "Manualmente";
            // 
            // btn_sig
            // 
            this.btn_sig.Location = new System.Drawing.Point(270, 413);
            this.btn_sig.Name = "btn_sig";
            this.btn_sig.Size = new System.Drawing.Size(75, 23);
            this.btn_sig.TabIndex = 13;
            this.btn_sig.Text = "Siguiente";
            this.btn_sig.UseVisualStyleBackColor = true;
            this.btn_sig.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(366, 413);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_sig);
            this.Controls.Add(this.txtmanual);
            this.Controls.Add(this.txtDOC);
            this.Controls.Add(this.paneldoc);
            this.Controls.Add(this.txtEscanear);
            this.Controls.Add(this.btn_reciclar);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.link_lbl);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.bl_info);
            this.Controls.Add(this.btnscann);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.ShowIcon = false;
            this.Text = "Reciclador";
            this.paneldoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnscann;
        private System.Windows.Forms.Label bl_info;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.LinkLabel link_lbl;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.Button btn_reciclar;
        private System.Windows.Forms.Label txtEscanear;
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
        private System.Windows.Forms.Button btn_salir;
    }
}

