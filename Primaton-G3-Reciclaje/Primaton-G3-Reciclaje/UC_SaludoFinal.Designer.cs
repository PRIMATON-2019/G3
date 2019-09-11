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
            this.txtingresarf2 = new System.Windows.Forms.Label();
            this.txtingresarf = new System.Windows.Forms.Label();
            this.pic2mund = new System.Windows.Forms.PictureBox();
            this.pic1mund = new System.Windows.Forms.PictureBox();
            this.txtSaludo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic2mund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1mund)).BeginInit();
            this.SuspendLayout();
            // 
            // txtingresarf2
            // 
            this.txtingresarf2.AutoSize = true;
            this.txtingresarf2.Location = new System.Drawing.Point(509, 288);
            this.txtingresarf2.Name = "txtingresarf2";
            this.txtingresarf2.Size = new System.Drawing.Size(60, 13);
            this.txtingresarf2.TabIndex = 9;
            this.txtingresarf2.Text = "agregar pic";
            // 
            // txtingresarf
            // 
            this.txtingresarf.AutoSize = true;
            this.txtingresarf.Location = new System.Drawing.Point(240, 288);
            this.txtingresarf.Name = "txtingresarf";
            this.txtingresarf.Size = new System.Drawing.Size(60, 13);
            this.txtingresarf.TabIndex = 8;
            this.txtingresarf.Text = "agregar pic";
            // 
            // pic2mund
            // 
            this.pic2mund.Location = new System.Drawing.Point(454, 235);
            this.pic2mund.Name = "pic2mund";
            this.pic2mund.Size = new System.Drawing.Size(155, 118);
            this.pic2mund.TabIndex = 7;
            this.pic2mund.TabStop = false;
            // 
            // pic1mund
            // 
            this.pic1mund.Location = new System.Drawing.Point(187, 235);
            this.pic1mund.Name = "pic1mund";
            this.pic1mund.Size = new System.Drawing.Size(155, 118);
            this.pic1mund.TabIndex = 6;
            this.pic1mund.TabStop = false;
            // 
            // txtSaludo
            // 
            this.txtSaludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.txtSaludo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaludo.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaludo.Location = new System.Drawing.Point(91, 49);
            this.txtSaludo.Multiline = true;
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(635, 321);
            this.txtSaludo.TabIndex = 5;
            this.txtSaludo.Text = "¡Muchas gracias por tu ayuda!";
            this.txtSaludo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_SaludoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.txtingresarf2);
            this.Controls.Add(this.txtingresarf);
            this.Controls.Add(this.pic2mund);
            this.Controls.Add(this.pic1mund);
            this.Controls.Add(this.txtSaludo);
            this.Name = "UC_SaludoFinal";
            this.Size = new System.Drawing.Size(816, 419);
            ((System.ComponentModel.ISupportInitialize)(this.pic2mund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1mund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtingresarf2;
        private System.Windows.Forms.Label txtingresarf;
        private System.Windows.Forms.PictureBox pic2mund;
        private System.Windows.Forms.PictureBox pic1mund;
        private System.Windows.Forms.TextBox txtSaludo;
    }
}
