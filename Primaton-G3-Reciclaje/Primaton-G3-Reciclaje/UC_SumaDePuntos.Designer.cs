namespace Primaton_G3_Reciclaje
{
    partial class UC_SumaDePuntos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPuntosAcu = new System.Windows.Forms.Label();
            this.txtPuntosSum = new System.Windows.Forms.Label();
            this.txtAcumu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtSumaste = new System.Windows.Forms.Label();
            this.txtGracias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPuntosAcu
            // 
            this.txtPuntosAcu.AutoSize = true;
            this.txtPuntosAcu.Location = new System.Drawing.Point(399, 332);
            this.txtPuntosAcu.Name = "txtPuntosAcu";
            this.txtPuntosAcu.Size = new System.Drawing.Size(100, 13);
            this.txtPuntosAcu.TabIndex = 15;
            this.txtPuntosAcu.Text = "Puntos acumulados";
            // 
            // txtPuntosSum
            // 
            this.txtPuntosSum.AutoSize = true;
            this.txtPuntosSum.Location = new System.Drawing.Point(412, 189);
            this.txtPuntosSum.Name = "txtPuntosSum";
            this.txtPuntosSum.Size = new System.Drawing.Size(87, 13);
            this.txtPuntosSum.TabIndex = 14;
            this.txtPuntosSum.Text = "Puntos Sumados";
            // 
            // txtAcumu
            // 
            this.txtAcumu.AutoSize = true;
            this.txtAcumu.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcumu.Location = new System.Drawing.Point(169, 247);
            this.txtAcumu.Name = "txtAcumu";
            this.txtAcumu.Size = new System.Drawing.Size(410, 42);
            this.txtAcumu.TabIndex = 13;
            this.txtAcumu.Text = "Acumulados a la fecha";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(298, 320);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 36);
            this.textBox1.TabIndex = 12;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(298, 175);
            this.txtPuntos.Multiline = true;
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(267, 36);
            this.txtPuntos.TabIndex = 11;
            // 
            // txtSumaste
            // 
            this.txtSumaste.AutoSize = true;
            this.txtSumaste.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaste.Location = new System.Drawing.Point(169, 107);
            this.txtSumaste.Name = "txtSumaste";
            this.txtSumaste.Size = new System.Drawing.Size(190, 42);
            this.txtSumaste.TabIndex = 10;
            this.txtSumaste.Text = "SUMASTE";
            // 
            // txtGracias
            // 
            this.txtGracias.AutoSize = true;
            this.txtGracias.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracias.Location = new System.Drawing.Point(62, 36);
            this.txtGracias.Name = "txtGracias";
            this.txtGracias.Size = new System.Drawing.Size(222, 45);
            this.txtGracias.TabIndex = 9;
            this.txtGracias.Text = "¡GRACIAS!";
            // 
            // UC_SumaDePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.txtPuntosAcu);
            this.Controls.Add(this.txtPuntosSum);
            this.Controls.Add(this.txtAcumu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtSumaste);
            this.Controls.Add(this.txtGracias);
            this.Name = "UC_SumaDePuntos";
            this.Size = new System.Drawing.Size(816, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPuntosAcu;
        private System.Windows.Forms.Label txtPuntosSum;
        private System.Windows.Forms.Label txtAcumu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label txtSumaste;
        private System.Windows.Forms.Label txtGracias;
    }
}
