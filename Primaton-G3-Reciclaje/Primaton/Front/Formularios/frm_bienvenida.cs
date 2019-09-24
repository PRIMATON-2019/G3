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
        Registros registro;
        public frm_bienvenida(Registros registro)
        {
            InitializeComponent();
            this.registro=registro;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frm_tiposdereciclaje reciclaje = new frm_tiposdereciclaje();
            reciclaje.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form Cancel = new frm_Inicial();
            Cancel.ShowDialog();
        }

        private void Frm_bienvenida_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido " + registro.Usuario.DNI + " a Ecosistema, la nueva forma de reciclar.";

         }
    }
}
