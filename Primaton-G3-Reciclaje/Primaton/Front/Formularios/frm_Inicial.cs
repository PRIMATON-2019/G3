﻿using Primaton.Front.forms_usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton.Front.Formularios
{
    public partial class frm_Inicial : Form
    {

        public frm_Inicial()
        {
            InitializeComponent();
            timer_hora.Start();

        }

        private void Timer_hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }
        #region eventos
        private void Button1_Click(object sender, EventArgs e)
        {
            
            frm_scan scaneo = new frm_scan();
            scaneo.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            frm_dnimanual dnimanual = new frm_dnimanual();
            dnimanual.ShowDialog();

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login nb = new frm_Login();
            nb.Show();
        }
        #endregion

        private void Frm_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frm_quienessomos frm = new frm_quienessomos();
            frm.ShowDialog();
        }
    }
}
