using System.Windows.Forms;
using Primaton_G3_Reciclaje.Front_End.Formularios;
namespace Primaton_G3_Reciclaje
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }
        #region EVENTOS HERRAMIENTAS

        private void Link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_registro_comercio = new Form();
            frm_registro_comercio.ShowDialog();
        }
        #endregion

        private void Btn_reciclaje_Click(object sender, System.EventArgs e)
        {

            Form frm_tiposdereciclaje = new frm_tiposdereciclaje();

            frm_tiposdereciclaje.ShowDialog();
        }
    }
}
