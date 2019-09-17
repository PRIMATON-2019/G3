namespace Primaton_G3_Reciclaje
{
    partial class UC_SaludoFinal
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
            this.txtSaludo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSaludo
            // 
            this.txtSaludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.txtSaludo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaludo.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaludo.Location = new System.Drawing.Point(3, 15);
            this.txtSaludo.Multiline = true;
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(394, 322);
            this.txtSaludo.TabIndex = 5;
            this.txtSaludo.Text = "¡Muchas gracias por tu ayuda!";
            this.txtSaludo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_SaludoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.txtSaludo);
            this.Name = "UC_SaludoFinal";
            this.Size = new System.Drawing.Size(400, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaludo;
    }
}
