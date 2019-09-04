using System;
using System.Windows.Forms;

namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    public partial class frm_tiposdereciclaje : Form
    {
        public frm_tiposdereciclaje()
        {
            InitializeComponent();
        }
        #region EVENTOS
        private void Btn_plastico_Click(object sender, EventArgs e)
        {
            Form frm_plastico = new frm_plastico();
            frm_plastico.ShowDialog();
        }
        #endregion
    }
}
