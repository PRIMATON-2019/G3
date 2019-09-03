using System.Windows.Forms;

namespace Primaton_G3_Reciclaje
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
