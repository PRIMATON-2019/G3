namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    partial class frm_tiposdereciclaje
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
            this.btn_vidrio = new System.Windows.Forms.Button();
            this.btn_plastico = new System.Windows.Forms.Button();
            this.btn_carton = new System.Windows.Forms.Button();
            this.btn_biodegradables = new System.Windows.Forms.Button();
            this.btn_basuracomun = new System.Windows.Forms.Button();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_vidrio
            // 
            this.btn_vidrio.BackColor = System.Drawing.Color.Transparent;
            this.btn_vidrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vidrio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_vidrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_vidrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vidrio.Location = new System.Drawing.Point(82, 96);
            this.btn_vidrio.Name = "btn_vidrio";
            this.btn_vidrio.Size = new System.Drawing.Size(282, 275);
            this.btn_vidrio.TabIndex = 1;
            this.btn_vidrio.Text = "vidrio";
            this.btn_vidrio.UseVisualStyleBackColor = false;
            // 
            // btn_plastico
            // 
            this.btn_plastico.BackColor = System.Drawing.Color.Transparent;
            this.btn_plastico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plastico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_plastico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_plastico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plastico.Location = new System.Drawing.Point(370, 96);
            this.btn_plastico.Name = "btn_plastico";
            this.btn_plastico.Size = new System.Drawing.Size(282, 275);
            this.btn_plastico.TabIndex = 2;
            this.btn_plastico.Text = "plastico";
            this.btn_plastico.UseVisualStyleBackColor = false;
            this.btn_plastico.Click += new System.EventHandler(this.Btn_plastico_Click);
            // 
            // btn_carton
            // 
            this.btn_carton.BackColor = System.Drawing.Color.Transparent;
            this.btn_carton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_carton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_carton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carton.Location = new System.Drawing.Point(82, 377);
            this.btn_carton.Name = "btn_carton";
            this.btn_carton.Size = new System.Drawing.Size(282, 287);
            this.btn_carton.TabIndex = 3;
            this.btn_carton.Text = "carton";
            this.btn_carton.UseVisualStyleBackColor = false;
            // 
            // btn_biodegradables
            // 
            this.btn_biodegradables.BackColor = System.Drawing.Color.Transparent;
            this.btn_biodegradables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_biodegradables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_biodegradables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_biodegradables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_biodegradables.Location = new System.Drawing.Point(370, 377);
            this.btn_biodegradables.Name = "btn_biodegradables";
            this.btn_biodegradables.Size = new System.Drawing.Size(282, 287);
            this.btn_biodegradables.TabIndex = 4;
            this.btn_biodegradables.Text = "biodegradables";
            this.btn_biodegradables.UseVisualStyleBackColor = false;
            // 
            // btn_basuracomun
            // 
            this.btn_basuracomun.BackColor = System.Drawing.Color.Transparent;
            this.btn_basuracomun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_basuracomun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_basuracomun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_basuracomun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basuracomun.Location = new System.Drawing.Point(658, 96);
            this.btn_basuracomun.Name = "btn_basuracomun";
            this.btn_basuracomun.Size = new System.Drawing.Size(282, 577);
            this.btn_basuracomun.TabIndex = 5;
            this.btn_basuracomun.Text = "basura comun";
            this.btn_basuracomun.UseVisualStyleBackColor = false;
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion.Location = new System.Drawing.Point(138, 24);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(686, 54);
            this.lbl_informacion.TabIndex = 6;
            this.lbl_informacion.Text = "SELECCIONE UNA OPCION";
            this.lbl_informacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_tiposdereciclaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(952, 676);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.btn_basuracomun);
            this.Controls.Add(this.btn_biodegradables);
            this.Controls.Add(this.btn_carton);
            this.Controls.Add(this.btn_plastico);
            this.Controls.Add(this.btn_vidrio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_tiposdereciclaje";
            this.Text = "frm_tiposdereciclaje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vidrio;
        private System.Windows.Forms.Button btn_plastico;
        private System.Windows.Forms.Button btn_carton;
        private System.Windows.Forms.Button btn_biodegradables;
        private System.Windows.Forms.Button btn_basuracomun;
        private System.Windows.Forms.Label lbl_informacion;
    }
}