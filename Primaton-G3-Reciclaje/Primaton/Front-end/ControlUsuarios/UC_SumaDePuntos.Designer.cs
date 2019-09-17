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
            this.txtAcumu = new System.Windows.Forms.Label();
            this.txtSumaste = new System.Windows.Forms.Label();
            this.txtGracias = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAcumu
            // 
            this.txtAcumu.AutoSize = true;
            this.txtAcumu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcumu.Location = new System.Drawing.Point(28, 191);
            this.txtAcumu.Name = "txtAcumu";
            this.txtAcumu.Size = new System.Drawing.Size(317, 23);
            this.txtAcumu.TabIndex = 13;
            this.txtAcumu.Text = "Tenés acumulados: xxxx puntos";
            // 
            // txtSumaste
            // 
            this.txtSumaste.AutoSize = true;
            this.txtSumaste.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaste.Location = new System.Drawing.Point(28, 119);
            this.txtSumaste.Name = "txtSumaste";
            this.txtSumaste.Size = new System.Drawing.Size(261, 23);
            this.txtSumaste.TabIndex = 10;
            this.txtSumaste.Text = "SUMASTE XXXXX PUNTOS";
            // 
            // txtGracias
            // 
            this.txtGracias.AutoSize = true;
            this.txtGracias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracias.Location = new System.Drawing.Point(28, 47);
            this.txtGracias.Name = "txtGracias";
            this.txtGracias.Size = new System.Drawing.Size(135, 23);
            this.txtGracias.TabIndex = 9;
            this.txtGracias.Text = "¡EXCELENTE!";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(280, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 43);
            this.button5.TabIndex = 18;
            this.button5.Text = "Finalizar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 43);
            this.button4.TabIndex = 17;
            this.button4.Text = "Canjear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 16;
            this.button3.Text = "Nuevo ingreso";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UC_SumaDePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtAcumu);
            this.Controls.Add(this.txtSumaste);
            this.Controls.Add(this.txtGracias);
            this.Name = "UC_SumaDePuntos";
            this.Size = new System.Drawing.Size(400, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtAcumu;
        private System.Windows.Forms.Label txtSumaste;
        private System.Windows.Forms.Label txtGracias;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
