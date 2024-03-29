﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Primaton.Front.Formularios;
using entidades;

namespace Primaton.Front.forms_usuario
{
    public partial class frm_plataforma : Form
    {
        private readonly string dni;

        public frm_plataforma(string dni)
        {
            InitializeComponent();
            this.dni = dni;
        }
        private void Abrirforminpanel(object formhijo)
        {
            if (this.pnContenedor.Controls.Count > 0)
            {
                this.pnContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(fh);
            this.pnContenedor.Tag = fh;
            fh.Show();
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.pictureBox3.Visible = true;
            pictureBox13.Visible = false;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.pictureBox3.Visible = false;
            pictureBox13.Visible = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }


        private void BtBeneficio_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_plataforma_Load(object sender, EventArgs e)
        {
            Abrirforminpanel(new frm_qrUsuario(dni));
            
        }
    }
}
