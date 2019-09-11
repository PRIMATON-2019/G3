namespace Primaton_G3_Reciclaje
{
    partial class UC_Vidrio
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
            this.txtFecha = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_Pesar = new System.Windows.Forms.Button();
            this.txtinformacion = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtVidrio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(605, 22);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(62, 18);
            this.txtFecha.TabIndex = 13;
            this.txtFecha.Text = "Fecha:";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(437, 362);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(164, 38);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(155, 362);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(164, 38);
            this.btn_siguiente.TabIndex = 11;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // btn_Pesar
            // 
            this.btn_Pesar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesar.Location = new System.Drawing.Point(314, 286);
            this.btn_Pesar.Name = "btn_Pesar";
            this.btn_Pesar.Size = new System.Drawing.Size(135, 51);
            this.btn_Pesar.TabIndex = 10;
            this.btn_Pesar.Text = "PESAR";
            this.btn_Pesar.UseVisualStyleBackColor = true;
            // 
            // txtinformacion
            // 
            this.txtinformacion.BackColor = System.Drawing.Color.Transparent;
            this.txtinformacion.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinformacion.Location = new System.Drawing.Point(42, 79);
            this.txtinformacion.Name = "txtinformacion";
            this.txtinformacion.Size = new System.Drawing.Size(713, 172);
            this.txtinformacion.TabIndex = 9;
            this.txtinformacion.Text = "Poner todo dentro del contenedor y esperar unos segundos para el pesaje, cuando i" +
    "ntroduzca todo el contenido presione el botón \"PESAR\"";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(49, 68);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(706, 212);
            this.txtInfo.TabIndex = 8;
            // 
            // txtVidrio
            // 
            this.txtVidrio.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtVidrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVidrio.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVidrio.Location = new System.Drawing.Point(27, 20);
            this.txtVidrio.Multiline = true;
            this.txtVidrio.Name = "txtVidrio";
            this.txtVidrio.ShortcutsEnabled = false;
            this.txtVidrio.Size = new System.Drawing.Size(252, 25);
            this.txtVidrio.TabIndex = 7;
            this.txtVidrio.Text = "SELECCIONÓ VIDRIO";
            this.txtVidrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_Vidrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_Pesar);
            this.Controls.Add(this.txtinformacion);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtVidrio);
            this.Name = "UC_Vidrio";
            this.Size = new System.Drawing.Size(816, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_Pesar;
        private System.Windows.Forms.Label txtinformacion;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtVidrio;
    }
}
