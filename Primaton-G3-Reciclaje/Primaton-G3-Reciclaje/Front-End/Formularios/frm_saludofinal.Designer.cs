namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    partial class frm_saludofinal
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
            this.txtSaludo = new System.Windows.Forms.TextBox();
            this.pic1mund = new System.Windows.Forms.PictureBox();
            this.pic2mund = new System.Windows.Forms.PictureBox();
            this.txtingresarf = new System.Windows.Forms.Label();
            this.txtingresarf2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1mund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2mund)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaludo
            // 
            this.txtSaludo.BackColor = System.Drawing.Color.DarkGray;
            this.txtSaludo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaludo.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaludo.Location = new System.Drawing.Point(106, 61);
            this.txtSaludo.Multiline = true;
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(635, 321);
            this.txtSaludo.TabIndex = 0;
            this.txtSaludo.Text = "¡Muchas gracias por tu ayuda!";
            this.txtSaludo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic1mund
            // 
            this.pic1mund.Location = new System.Drawing.Point(202, 247);
            this.pic1mund.Name = "pic1mund";
            this.pic1mund.Size = new System.Drawing.Size(155, 118);
            this.pic1mund.TabIndex = 1;
            this.pic1mund.TabStop = false;
            // 
            // pic2mund
            // 
            this.pic2mund.Location = new System.Drawing.Point(469, 247);
            this.pic2mund.Name = "pic2mund";
            this.pic2mund.Size = new System.Drawing.Size(155, 118);
            this.pic2mund.TabIndex = 2;
            this.pic2mund.TabStop = false;
            // 
            // txtingresarf
            // 
            this.txtingresarf.AutoSize = true;
            this.txtingresarf.Location = new System.Drawing.Point(255, 300);
            this.txtingresarf.Name = "txtingresarf";
            this.txtingresarf.Size = new System.Drawing.Size(60, 13);
            this.txtingresarf.TabIndex = 3;
            this.txtingresarf.Text = "agregar pic";
            // 
            // txtingresarf2
            // 
            this.txtingresarf2.AutoSize = true;
            this.txtingresarf2.Location = new System.Drawing.Point(524, 300);
            this.txtingresarf2.Name = "txtingresarf2";
            this.txtingresarf2.Size = new System.Drawing.Size(60, 13);
            this.txtingresarf2.TabIndex = 4;
            this.txtingresarf2.Text = "agregar pic";
            // 
            // frm_saludofinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtingresarf2);
            this.Controls.Add(this.txtingresarf);
            this.Controls.Add(this.pic2mund);
            this.Controls.Add(this.pic1mund);
            this.Controls.Add(this.txtSaludo);
            this.Name = "frm_saludofinal";
            this.Text = "frm_saludofinal";
            ((System.ComponentModel.ISupportInitialize)(this.pic1mund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2mund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaludo;
        private System.Windows.Forms.PictureBox pic1mund;
        private System.Windows.Forms.PictureBox pic2mund;
        private System.Windows.Forms.Label txtingresarf;
        private System.Windows.Forms.Label txtingresarf2;
    }
}