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
    public partial class frm_Inicial : Form
    {
        public frm_Inicial()
        {
            InitializeComponent();
            timer_hora.Start();
        }

        private void Timer_hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }
    }
}
