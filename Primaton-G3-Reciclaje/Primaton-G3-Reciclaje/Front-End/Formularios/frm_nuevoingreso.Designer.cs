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
            this.SuspendLayout();
            // 
            // btn_nuevoing
            // 
            this.btn_nuevoing.Font = new System.Drawing.Font("Verdana", 15.25F);
            this.btn_nuevoing.Location = new System.Drawing.Point(101, 93);
            this.btn_nuevoing.Name = "btn_nuevoing";
            this.btn_nuevoing.Size = new System.Drawing.Size(227, 204);
            this.btn_nuevoing.TabIndex = 0;
            this.btn_nuevoing.Text = "NUEVO INGRESO";
            this.btn_nuevoing.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Verdana", 15.25F);
            this.btn_finalizar.Location = new System.Drawing.Point(448, 93);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(227, 204);
            this.btn_finalizar.TabIndex = 1;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // frm_nuevoingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_nuevoing);
            this.Name = "frm_nuevoingreso";
            this.Text = "frm_nuevoingreso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoing;
        private System.Windows.Forms.Button btn_finalizar;
    }
}