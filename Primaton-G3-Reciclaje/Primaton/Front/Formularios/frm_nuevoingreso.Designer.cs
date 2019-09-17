namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    partial class frm_nuevoingreso
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
            this.btn_nuevoing = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_nuevoing
            // 
            this.btn_nuevoing.Font = new System.Drawing.Font("Verdana", 15.25F);
            this.btn_nuevoing.Location = new System.Drawing.Point(135, 114);
            this.btn_nuevoing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_nuevoing.Name = "btn_nuevoing";
            this.btn_nuevoing.Size = new System.Drawing.Size(303, 251);
            this.btn_nuevoing.TabIndex = 0;
            this.btn_nuevoing.Text = "NUEVO INGRESO";
            this.btn_nuevoing.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Verdana", 15.25F);
            this.btn_finalizar.Location = new System.Drawing.Point(597, 114);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(303, 251);
            this.btn_finalizar.TabIndex = 1;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(389, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // frm_nuevoingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_nuevoing);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_nuevoingreso";
            this.Text = "frm_nuevoingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoing;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Panel panel1;
    }
}