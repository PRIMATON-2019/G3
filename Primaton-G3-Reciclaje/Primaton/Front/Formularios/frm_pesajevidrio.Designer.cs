namespace Primaton.Front.Formularios
{
    partial class frm_pesajevidrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesajevidrio));
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lblTotaldePuntos = new System.Windows.Forms.Label();
            this.lblPuntosGanados = new System.Windows.Forms.Label();
            this.lblPuntosAcumulados = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btPesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Estás pesando: ";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(301, 402);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(89, 29);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(443, 402);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(89, 29);
            this.btModificar.TabIndex = 19;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(584, 402);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(89, 29);
            this.btAceptar.TabIndex = 18;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // lblTotaldePuntos
            // 
            this.lblTotaldePuntos.AutoSize = true;
            this.lblTotaldePuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaldePuntos.Location = new System.Drawing.Point(450, 346);
            this.lblTotaldePuntos.Name = "lblTotaldePuntos";
            this.lblTotaldePuntos.Size = new System.Drawing.Size(213, 20);
            this.lblTotaldePuntos.TabIndex = 17;
            this.lblTotaldePuntos.Text = "Total de puntos acumulados:";
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosGanados.Location = new System.Drawing.Point(449, 292);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(129, 20);
            this.lblPuntosGanados.TabIndex = 16;
            this.lblPuntosGanados.Text = "Puntos ganados:";
            // 
            // lblPuntosAcumulados
            // 
            this.lblPuntosAcumulados.AutoSize = true;
            this.lblPuntosAcumulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosAcumulados.Location = new System.Drawing.Point(126, 20);
            this.lblPuntosAcumulados.Name = "lblPuntosAcumulados";
            this.lblPuntosAcumulados.Size = new System.Drawing.Size(230, 20);
            this.lblPuntosAcumulados.TabIndex = 15;
            this.lblPuntosAcumulados.Text = "Puntos acumulados a la fecha: ";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(454, 237);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(221, 20);
            this.txtPeso.TabIndex = 14;
            // 
            // btPesar
            // 
            this.btPesar.Location = new System.Drawing.Point(454, 140);
            this.btPesar.Name = "btPesar";
            this.btPesar.Size = new System.Drawing.Size(136, 48);
            this.btPesar.TabIndex = 13;
            this.btPesar.Text = "Pesar";
            this.btPesar.UseVisualStyleBackColor = true;
            this.btPesar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "Deposita los residuos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_pesajevidrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lblTotaldePuntos);
            this.Controls.Add(this.lblPuntosGanados);
            this.Controls.Add(this.lblPuntosAcumulados);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btPesar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_pesajevidrio";
            this.Text = "frm_pesajevidrio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lblTotaldePuntos;
        private System.Windows.Forms.Label lblPuntosGanados;
        private System.Windows.Forms.Label lblPuntosAcumulados;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btPesar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}