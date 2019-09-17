using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G3_Reciclaje
{
    public partial class UC_ReciclajeElegido : UserControl
    {
        public UC_ReciclajeElegido()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int ingreso = rdm.Next(1, 5000);
            txt_peso.Text = ingreso.ToString();
        }
    }
}
