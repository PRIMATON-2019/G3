
using entidades;
using System;
using System.Windows.Forms;

namespace Primaton.Front.Formularios
{
    public partial class frm_tiposdereciclaje : Form
    {
        Registros registro;
        public frm_tiposdereciclaje()
        {
            InitializeComponent();
            
        }
        #region METODO

        #endregion
        #region EVENTOS

        private void Btn_vidrio_Click(object sender, EventArgs e)
        {
            frm_pesajevidrio vidrio = new frm_pesajevidrio();
            vidrio.ShowDialog();
        }

        private void Btn_plastico_Click_1(object sender, EventArgs e)
        {
            frm_pesajeplastico plastico = new frm_pesajeplastico();
            plastico.ShowDialog();
        }

        private void Btn_papel_Click(object sender, EventArgs e)
        {
            frm_pesajepapel papel = new frm_pesajepapel();
            papel.ShowDialog();
        }

        private void Btn_biodegradables_Click(object sender, EventArgs e)
        {
            frm_pesajebiod biod = new frm_pesajebiod();
            biod.ShowDialog();
        }
        private void Frm_tiposdereciclaje_Load(object sender, EventArgs e)
        {
            lbl_informacion.Text = " Elegi el tipo de residuo.";
        }
        #endregion

    }
}
