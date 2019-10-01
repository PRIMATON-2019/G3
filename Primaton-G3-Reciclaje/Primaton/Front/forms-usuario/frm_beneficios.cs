using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton.Front.forms_usuario
{
    public partial class frm_beneficios : Form
    {
        private readonly int puntosLocal;

        public frm_beneficios(string puntos)
        {
            InitializeComponent();
            this.puntosLocal = System.Convert.ToInt32(puntos);
        }



        //ACLARACIÓN IMPORTANTE!!!!

        //Puse este valor porque no sé aún como acoplar los datos a la base xml.
        //Ahora estoy viendo bien el programa y apenas sepa como llamarla lo arreglo




        private void BtSeleccionar_Click(object sender, EventArgs e)
        {
            if (chkCine.Checked & puntosLocal >= 2000)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 2000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkCine.Checked & puntosLocal < 2000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkDisco.Checked & puntosLocal >= 7500)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 7500);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkDisco.Checked & puntosLocal < 7500)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkMc.Checked & puntosLocal >= 3000)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 3000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkMc.Checked & puntosLocal < 3000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkVaq.Checked & puntosLocal >= 5000)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 5000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkVaq.Checked & puntosLocal < 5000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkVenex.Checked & puntosLocal >= 10000)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 10000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkVenex.Checked & puntosLocal < 10000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkDexter.Checked & puntosLocal >= 9000)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 9000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkDexter.Checked & puntosLocal < 9000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkBalcon.Checked & puntosLocal >= 8000)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 8000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkBalcon.Checked & puntosLocal < 8000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkGarba.Checked & puntosLocal >= 15000)
            {
                lblSaldo.Text = Convert.ToString (puntosLocal - 15000);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkGarba.Checked & puntosLocal < 15000)
            {
                MessageBox.Show("Puntos insuficientes");
            }

            if (chkCarre.Checked & puntosLocal >= 7500)
            {
                lblSaldo.Text = Convert.ToString(puntosLocal - 7500);
                MessageBox.Show("¡Felicitaciones! El canje se realizó correctamente");
            }
            else if (chkCarre.Checked & puntosLocal < 7500)
            {
                MessageBox.Show("Puntos insuficientes");
            }
        }

    }
}
