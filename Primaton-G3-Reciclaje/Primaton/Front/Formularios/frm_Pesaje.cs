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
    public partial class frm_Pesaje : Form
    {
        public frm_Pesaje()
        {
            InitializeComponent();
        }

        private void BtnPesar_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int ingreso = rdm.Next(1, 10000);
            lblPeso.Text = ingreso.ToString();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            lblPuntosGanados.Visible = true;
            //lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.5;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            frm_dnimanual Volver = new frm_dnimanual();
            Volver.ShowDialog();
        }

        public void BtSiguiente_Click_1(object sender, EventArgs e)
        {
            //Form siguiente = new frm_SelectBenefit();
            //siguiente.ShowDialog();
            ////Llamar metodo para grabar registro
            Usuarios usuario = new Usuarios();
            Contenedor contenedor = new Contenedor();
            TipoResiduo tipo = new TipoResiduo();
            Registros registro = new Registros();
            tipo.Id = 1;
            contenedor.Id = 1;
            contenedor.tamanio = 100;
            usuario.DNI = "30782195";
            registro.Fecha = DateTime.Now;
            registro.Usuario = usuario;
            registro.Tipo = tipo;
            registro.Cantidad = Int32.Parse(lblPeso.Text);
            registro.Contenedor = contenedor;

            registro.GrabarRegistro(registro);


            //usuario
            //peso
            //tipo
            //puntos
            //fecha
        }

        private void BtnVidrio_Click(object sender, EventArgs e)
        {
            lblQuepeso.Text = "Vidrio";
            lblPuntosGanados.Visible = true;
            //lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.5;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void BtnPlastico_Click(object sender, EventArgs e)
        {
            lblPuntosGanados.Visible = true;
            //lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.4;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void BtnPapel_Click(object sender, EventArgs e)
        {
            //Cuando se hace clic en acepatar se va a mostrar la cantidad de puntos que se estarían sumando
            lblPuntosGanados.Visible = true;
            //lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.45;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void BtnBio_Click(object sender, EventArgs e)
        {
            lblPuntosGanados.Visible = true;
            //lblPuntosAcumulados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = peso * 0.35;
            lblPuntosGanados.Text = "Estás sumando: " + Convert.ToString(peso);
        }

        private void Frm_Pesaje_Load(object sender, EventArgs e)
        {
            
        }
    }
}
