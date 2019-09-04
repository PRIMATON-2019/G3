namespace Primaton_G3_Reciclaje
{
    partial class Form1
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
            this.btn_reciclaje = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bl_info = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.link_lbl = new System.Windows.Forms.LinkLabel();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reciclaje
            // 
            this.btn_reciclaje.BackColor = System.Drawing.Color.Transparent;
            this.btn_reciclaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reciclaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reciclaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_reciclaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reciclaje.Location = new System.Drawing.Point(146, 226);
            this.btn_reciclaje.Name = "btn_reciclaje";
            this.btn_reciclaje.Size = new System.Drawing.Size(282, 206);
            this.btn_reciclaje.TabIndex = 0;
            this.btn_reciclaje.Text = "Reciclar";
            this.btn_reciclaje.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(572, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 206);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bl_info
            // 
            this.bl_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_info.Location = new System.Drawing.Point(182, 138);
            this.bl_info.Name = "bl_info";
            this.bl_info.Size = new System.Drawing.Size(631, 55);
            this.bl_info.TabIndex = 2;
            this.bl_info.Text = "Informacion Sobre el Programa";
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
            this.lbl_hora.Text = "Hora/Fecha";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_lbl
            // 
            this.link_lbl.AutoSize = true;
            this.link_lbl.Location = new System.Drawing.Point(767, 497);
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
            this.lbl_bienvenida.Location = new System.Drawing.Point(370, 62);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(245, 53);
            this.lbl_bienvenida.TabIndex = 5;
            this.lbl_bienvenida.Text = "Bienvenida/o";
            this.lbl_bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(982, 570);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.link_lbl);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.bl_info);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reciclaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reciclaje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bl_info;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.LinkLabel link_lbl;
        private System.Windows.Forms.Label lbl_bienvenida;
    }
}

