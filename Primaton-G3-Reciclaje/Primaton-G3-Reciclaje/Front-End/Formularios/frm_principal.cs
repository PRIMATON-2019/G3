using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G3_Reciclaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_registro_comercio = new Form();
            frm_registro_comercio.ShowDialog();
        }
    }
}
