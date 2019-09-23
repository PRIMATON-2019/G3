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
    public partial class frm_pesajepapel : Form
    {
        public frm_pesajepapel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Se asigna un valor aleatorio al peso de la balanza para poder tomar esto como 
            //parámetro al momento de calcular los puntos que el usuario va a sumar 
            Random rdm = new Random();
            int ingreso = rdm.Next(1, 10000);
            //En el cuadro de texto se va a mostrar el peso del material reciclado
            lblPeso.Text = ingreso.ToString();

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            //Cuando se hace clic en acepatar se va a mostrar la cantidad de puntos que se estarían sumando
            lblPuntosGanados.Visible = true;
            lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.5;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            //regresa al usuario al formulario de seleccion de tipos de reciclaje
            Form Volver = new frm_tiposdereciclaje();
            Volver.ShowDialog();
        }

        private void BtSiguiente_Click(object sender, EventArgs e)
        {
            //Redirige al usuario a la seleccion de beneficios para el canje de puntos
            Form siguiente = new frm_SelectBenefit();
            siguiente.ShowDialog();
        }

        private void Frm_pesajepapel_Load(object sender, EventArgs e)
        {

        }
    }
}
