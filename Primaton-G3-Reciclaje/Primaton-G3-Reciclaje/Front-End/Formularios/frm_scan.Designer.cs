namespace Primaton_G3_Reciclaje.Front_End.Formularios
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.combobox_camara = new System.Windows.Forms.ComboBox();
            this.picbox_camara = new System.Windows.Forms.PictureBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info.Location = new System.Drawing.Point(83, 55);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(164, 17);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Camara de el Dispositivo";
            // 
            // combobox_camara
            // 
            this.combobox_camara.BackColor = System.Drawing.Color.SlateGray;
            this.combobox_camara.FormattingEnabled = true;
            this.combobox_camara.Location = new System.Drawing.Point(287, 52);
            this.combobox_camara.Name = "combobox_camara";
            this.combobox_camara.Size = new System.Drawing.Size(254, 24);
            this.combobox_camara.TabIndex = 1;
            // 
            // picbox_camara
            // 
            this.picbox_camara.Location = new System.Drawing.Point(67, 135);
            this.picbox_camara.Name = "picbox_camara";
            this.picbox_camara.Size = new System.Drawing.Size(444, 301);
            this.picbox_camara.TabIndex = 2;
            this.picbox_camara.TabStop = false;
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(120, 475);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(127, 45);
            this.btn_inicio.TabIndex = 3;
            this.btn_inicio.Text = "Iniciar";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(388, 475);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(198, 45);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "Mostrar Codigo";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(650, 596);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.picbox_camara);
            this.Controls.Add(this.combobox_camara);
            this.Controls.Add(this.lbl_info);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_scan";
            this.Text = "frm_scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_scan_FormClosing);
            this.Load += new System.EventHandler(this.Frm_scan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox combobox_camara;
        private System.Windows.Forms.PictureBox picbox_camara;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Timer timer1;
    }
}