using Primaton.Front.forms_usuario;
using System;
using System.Windows.Forms;
namespace Primaton.Front.Formularios
{
    public partial class frm_Personal : Form
    {

        #region Propiedades
        public int genero { get; set; }
        #endregion
        public frm_Personal()
        {
            InitializeComponent();

        }


        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new frm_perfil());
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.pictureBox3.Visible = false;
            pictureBox13.Visible = true;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.pictureBox3.Visible = true;
            pictureBox13.Visible = false;
        }

        private void PbMenu_Click(object sender, EventArgs e)
        {


        }
        private void Abrirforminpanel(object formhijo)
        {
            if (this.pnGrande.Controls.Count > 0)
            {
                this.pnGrande.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnGrande.Controls.Add(fh);
            this.pnGrande.Tag = fh;
            fh.Show();
        }

        private void BtBeneficio_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new frm_SelectBenefit());
        }
    }
}
