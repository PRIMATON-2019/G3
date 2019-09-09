using Primaton_G3_Reciclaje.Front_End.Formularios;
using System;
using System.Windows.Forms;
namespace Primaton_G3_Reciclaje
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            timer_hora.Start();
        }
        #region EVENTOS HERRAMIENTAS

        private void Link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_registro_comercio = new Form();
            frm_registro_comercio.ShowDialog();
        }
        #endregion

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            //lbl_hora.Text = DateTime.Now..ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form frm_scan = new frm_scan();
            frm_scan.ShowDialog();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form frm_tiposdereciclaje = new frm_tiposdereciclaje();
            // Para seguir, bandera 1 (Si el usuario ingresó el dni o escaneó) sino, no permitir seguir.
            // by:fabri



            frm_tiposdereciclaje.ShowDialog();
        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEscanear_Click(object sender, EventArgs e)
        {

        }

        private void Bl_info_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
