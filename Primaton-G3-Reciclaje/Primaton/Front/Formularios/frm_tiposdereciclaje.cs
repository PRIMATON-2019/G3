
using System;
using System.Windows.Forms;

namespace Primaton.Front.Formularios
{
    public partial class frm_tiposdereciclaje : Form
    {
        public frm_tiposdereciclaje()
        {
            InitializeComponent();
        }
        #region EVENTOS

        #endregion

        private void Btn_vidrio_Click(object sender, EventArgs e)
        {
            frm_pesajevidrio vidrio = new frm_pesajevidrio();
            vidrio.Show();
        }

        private void Btn_plastico_Click_1(object sender, EventArgs e)
        {
            Form plastico = new frm_pesajeplastico();
            plastico.Show();
        }

        private void Btn_papel_Click(object sender, EventArgs e)
        {
            Form papel = new frm_pesajepapel();
            papel.Show();
        }

        private void Btn_biodegradables_Click(object sender, EventArgs e)
        {
            Form biod = new frm_pesajebiod();
            biod.Show();
        }
    }
}
