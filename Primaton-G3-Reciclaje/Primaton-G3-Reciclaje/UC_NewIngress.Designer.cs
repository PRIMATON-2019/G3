﻿namespace Primaton_G3_Reciclaje
{
    partial class UC_NewIngress
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
            this.btn_nuevoing = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_nuevoing
            // 
            this.btn_nuevoing.Font = new System.Drawing.Font("Verdana", 15.25F);
            this.btn_nuevoing.Location = new System.Drawing.Point(120, 81);
            this.btn_nuevoing.Name = "btn_nuevoing";
            this.btn_nuevoing.Size = new System.Drawing.Size(227, 204);
            this.btn_nuevoing.TabIndex = 1;
            this.btn_nuevoing.Text = "NUEVO INGRESO";
            this.btn_nuevoing.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Verdana", 15.25F);
            this.btn_finalizar.Location = new System.Drawing.Point(422, 81);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(227, 204);
            this.btn_finalizar.TabIndex = 2;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(316, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 81);
            this.panel1.TabIndex = 3;
            // 
            // UC_NewIngress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_nuevoing);
            this.Name = "UC_NewIngress";
            this.Size = new System.Drawing.Size(816, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoing;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Panel panel1;
    }
}
