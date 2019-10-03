using entidades;
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
    public partial class frm_dnimanual : Form
    {
        public frm_dnimanual()
        {
            InitializeComponent();
            timer1.Start();
        }
        #region eventos Botones

        private void Btn_1_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            txt_documento.Text = txt_documento.Text + "0";
        }
        #endregion


        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            //Usuarios usuario = new Usuarios();
            //usuario.DNI = txt_documento.Text;
            //this.Dispose();
            this.Close();
            frm_Pesaje pesaje = new frm_Pesaje(txt_documento.Text);
            pesaje.ShowDialog();
        }

        private void Pn_dni_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
