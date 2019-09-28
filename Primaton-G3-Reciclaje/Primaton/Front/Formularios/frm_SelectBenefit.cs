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
    public partial class frm_SelectBenefit : Form
    {
        public frm_SelectBenefit()
        {
            InitializeComponent();
        }

        //ACLARACIÓN IMPORTANTE!!!!

        //Puse este valor porque no sé aún como acoplar los datos a la base xml.
        //Ahora estoy viendo bien el programa y apenas sepa como llamarla lo arreglo
        int PuntosAcumulados = 50000;
        private void BtSeleccionar_Click(object sender, EventArgs e)
        {
            if (chkCine.Checked & PuntosAcumulados >= 2000)
            {
                PuntosAcumulados = PuntosAcumulados - 2000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkCine.Checked & PuntosAcumulados < 2000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkDisco.Checked & PuntosAcumulados >= 7500)
            {
                PuntosAcumulados = PuntosAcumulados - 7500;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkDisco.Checked & PuntosAcumulados < 7500)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkMc.Checked & PuntosAcumulados >= 3000)
            {
                PuntosAcumulados = PuntosAcumulados - 3000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkMc.Checked & PuntosAcumulados < 3000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkVaq.Checked & PuntosAcumulados >= 5000)
            {
                PuntosAcumulados = PuntosAcumulados - 5000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkVaq.Checked & PuntosAcumulados < 5000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkVenex.Checked & PuntosAcumulados >= 10000)
            {
                PuntosAcumulados = PuntosAcumulados - 10000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkVenex.Checked & PuntosAcumulados < 10000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkDexter.Checked & PuntosAcumulados >= 9000)
            {
                PuntosAcumulados = PuntosAcumulados - 9000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkDexter.Checked & PuntosAcumulados < 9000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkBalcon.Checked & PuntosAcumulados >= 8000)
            {
                PuntosAcumulados = PuntosAcumulados - 8000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkBalcon.Checked & PuntosAcumulados < 8000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkGarba.Checked & PuntosAcumulados >= 15000)
            {
                PuntosAcumulados = PuntosAcumulados - 15000;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkGarba.Checked & PuntosAcumulados < 15000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkCarre.Checked & PuntosAcumulados >= 7500)
            {
                PuntosAcumulados = PuntosAcumulados - 7500;
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkCarre.Checked & PuntosAcumulados < 7500)
            {
                MessageBox.Show("Puntos insuficientes");
            }
        }
    }
}
