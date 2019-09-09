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
            this.button2 = new System.Windows.Forms.Button();
            this.bl_info = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.link_lbl = new System.Windows.Forms.LinkLabel();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_redondo = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bl_info
            // 
            this.bl_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_info.Location = new System.Drawing.Point(167, 84);
            this.bl_info.Name = "bl_info";
            this.bl_info.Size = new System.Drawing.Size(631, 55);
            this.bl_info.TabIndex = 2;
            this.bl_info.Text = "Acerca tu DNI por favor";
            this.bl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(664, 9);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(306, 52);
            this.lbl_hora.TabIndex = 3;
            this.lbl_hora.Text = "12:32:25";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_lbl
            // 
            this.link_lbl.AutoSize = true;
            this.link_lbl.Location = new System.Drawing.Point(44, 501);
            this.link_lbl.Name = "link_lbl";
            this.link_lbl.Size = new System.Drawing.Size(132, 17);
            this.link_lbl.TabIndex = 4;
            this.link_lbl.TabStop = true;
            this.link_lbl.Text = "Queres ser Parte? !";
            this.link_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_lbl_LinkClicked);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenida.Location = new System.Drawing.Point(354, 11);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(245, 53);
            this.lbl_bienvenida.TabIndex = 5;
            this.lbl_bienvenida.Text = "Bienvenida/o";
            this.lbl_bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_hora
            // 
            this.timer_hora.Enabled = true;
            this.timer_hora.Interval = 1000;
            this.timer_hora.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informacion de la persona en base al dni  aca";
            // 
            // btn_redondo
            // 
            this.btn_redondo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_redondo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_redondo.Location = new System.Drawing.Point(433, 242);
            this.btn_redondo.Name = "btn_redondo";
            this.btn_redondo.Size = new System.Drawing.Size(325, 276);
            this.btn_redondo.TabIndex = 7;
            this.btn_redondo.Text = "Reciclar";
            this.btn_redondo.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(982, 570);
            this.Controls.Add(this.btn_redondo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.link_lbl);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.bl_info);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.ShowIcon = false;
            this.Text = "Reciclador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bl_info;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.LinkLabel link_lbl;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton btn_redondo;
    }
}

