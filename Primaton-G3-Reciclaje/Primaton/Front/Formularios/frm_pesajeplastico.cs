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
    public partial class frm_pesajeplastico : Form
    {
        public frm_pesajeplastico()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int ingreso = rdm.Next(1, 10000);
            txtPeso.Text = "El peso ingresado es: " + ingreso.ToString();
        }
    }
}
