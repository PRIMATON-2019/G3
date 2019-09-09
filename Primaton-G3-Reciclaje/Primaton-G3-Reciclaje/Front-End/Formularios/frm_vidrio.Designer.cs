namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    partial class frm_vidrio
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
            this.components = new System.ComponentModel.Container();
            this.txtVidrio = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtinformacion = new System.Windows.Forms.Label();
            this.btn_Pesar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.tiempofecha = new System.Windows.Forms.Timer(this.components);
            this.txtFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVidrio
            // 
            this.txtVidrio.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtVidrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVidrio.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVidrio.Location = new System.Drawing.Point(25, 12);
            this.txtVidrio.Multiline = true;
            this.txtVidrio.Name = "txtVidrio";
            this.txtVidrio.ShortcutsEnabled = false;
            this.txtVidrio.Size = new System.Drawing.Size(252, 25);
            this.txtVidrio.TabIndex = 0;
            this.txtVidrio.Text = "SELECCIONÓ VIDRIO";
            this.txtVidrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.DarkGray;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfo.Location = new System.Drawing.Point(52, 60);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(701, 397);
            this.txtInfo.TabIndex = 1;
            // 
            // txtinformacion
            // 
            this.txtinformacion.BackColor = System.Drawing.Color.Transparent;
            this.txtinformacion.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinformacion.Location = new System.Drawing.Point(56, 111);
            this.txtinformacion.Name = "txtinformacion";
            this.txtinformacion.Size = new System.Drawing.Size(656, 218);
            this.txtinformacion.TabIndex = 2;
            this.txtinformacion.Text = "Poner todo dentro del contenedor y esperar unos segundos para el pesaje, cuando i" +
    "ntroduzca todo el contenido presione el botón \"PESAR\"";
            // 
            // btn_Pesar
            // 
            this.btn_Pesar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesar.Location = new System.Drawing.Point(321, 332);
            this.btn_Pesar.Name = "btn_Pesar";
            this.btn_Pesar.Size = new System.Drawing.Size(135, 51);
            this.btn_Pesar.TabIndex = 3;
            this.btn_Pesar.Text = "PESAR";
            this.btn_Pesar.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(162, 408);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(164, 38);
            this.btn_siguiente.TabIndex = 4;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(444, 408);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(164, 38);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // tiempofecha
            // 
            this.tiempofecha.Enabled = true;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(603, 14);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(62, 18);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.Text = "Fecha:";
            // 
            // frm_vidrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_Pesar);
            this.Controls.Add(this.txtinformacion);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtVidrio);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frm_vidrio";
            this.Text = "frm_vidrio";
            this.Load += new System.EventHandler(this.Frm_vidrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVidrio;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label txtinformacion;
        private System.Windows.Forms.Button btn_Pesar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Timer tiempofecha;
        private System.Windows.Forms.Label txtFecha;
    }
}