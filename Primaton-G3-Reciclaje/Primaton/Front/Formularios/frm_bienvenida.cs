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
    public partial class frm_bienvenida : Form
    {
        Usuarios user;
        public frm_bienvenida(Usuarios user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form DatosBienvenida = new frm_tiposdereciclaje();
            DatosBienvenida.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form Cancel = new frm_Inicial();
            Cancel.ShowDialog();
        }

        private void Frm_bienvenida_Load(object sender, EventArgs e)
        {
            if (user.Genero== 1)
            {
            lblBienvenida.Text = "Bienvenida " + user.Nombre + " a Ecosistema, la nueva forma de reciclar.";

            }
        }
    }
}
