namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    partial class frm_sumadepuntos
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
            this.txtGracias = new System.Windows.Forms.Label();
            this.txtSumaste = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAcumu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPuntosSum = new System.Windows.Forms.Label();
            this.txtPuntosAcu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGracias
            // 
            this.txtGracias.AutoSize = true;
            this.txtGracias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGracias.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracias.Location = new System.Drawing.Point(23, 9);
            this.txtGracias.Name = "txtGracias";
            this.txtGracias.Size = new System.Drawing.Size(224, 47);
            this.txtGracias.TabIndex = 0;
            this.txtGracias.Text = "¡GRACIAS!";
            // 
            // txtSumaste
            // 
            this.txtSumaste.AutoSize = true;
            this.txtSumaste.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaste.Location = new System.Drawing.Point(130, 82);
            this.txtSumaste.Name = "txtSumaste";
            this.txtSumaste.Size = new System.Drawing.Size(190, 42);
            this.txtSumaste.TabIndex = 1;
            this.txtSumaste.Text = "SUMASTE";
            this.txtSumaste.Click += new System.EventHandler(this.TxtSumaste_Click);
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(259, 148);
            this.txtPuntos.Multiline = true;
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(267, 36);
            this.txtPuntos.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(259, 293);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 36);
            this.textBox1.TabIndex = 3;
            // 
            // txtAcumu
            // 
            this.txtAcumu.AutoSize = true;
            this.txtAcumu.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcumu.Location = new System.Drawing.Point(130, 220);
            this.txtAcumu.Name = "txtAcumu";
            this.txtAcumu.Size = new System.Drawing.Size(410, 42);
            this.txtAcumu.TabIndex = 4;
            this.txtAcumu.Text = "Acumulados a la fecha";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "CANJEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(414, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "FINALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPuntosSum
            // 
            this.txtPuntosSum.AutoSize = true;
            this.txtPuntosSum.Location = new System.Drawing.Point(373, 162);
            this.txtPuntosSum.Name = "txtPuntosSum";
            this.txtPuntosSum.Size = new System.Drawing.Size(87, 13);
            this.txtPuntosSum.TabIndex = 7;
            this.txtPuntosSum.Text = "Puntos Sumados";
            // 
            // txtPuntosAcu
            // 
            this.txtPuntosAcu.AutoSize = true;
            this.txtPuntosAcu.Location = new System.Drawing.Point(360, 305);
            this.txtPuntosAcu.Name = "txtPuntosAcu";
            this.txtPuntosAcu.Size = new System.Drawing.Size(100, 13);
            this.txtPuntosAcu.TabIndex = 8;
            this.txtPuntosAcu.Text = "Puntos acumulados";
            // 
            // frm_sumadepuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPuntosAcu);
            this.Controls.Add(this.txtPuntosSum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAcumu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtSumaste);
            this.Controls.Add(this.txtGracias);
            this.Name = "frm_sumadepuntos";
            this.Text = "frm_sumadepuntos";
            this.Load += new System.EventHandler(this.Frm_sumadepuntos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtGracias;
        private System.Windows.Forms.Label txtSumaste;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtAcumu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtPuntosSum;
        private System.Windows.Forms.Label txtPuntosAcu;
    }
}