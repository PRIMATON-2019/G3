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
        public frm_bienvenida()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form DatosBienvenida = new frm_tiposdereciclaje();
            DatosBienvenida.Show();
        }
    }
}
