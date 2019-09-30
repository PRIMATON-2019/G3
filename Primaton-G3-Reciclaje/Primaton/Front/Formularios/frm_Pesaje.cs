using entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Primaton.Front.Formularios
{
    public partial class frm_Pesaje : Form
    {
        //hacer variable global tipo, y or cada boton, asignar el tipo, 
        int suma = 0;
        bool Select = false;
        public string DNI;
        public frm_Pesaje(string DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            timer1.Start();

        }

        private void BtnPesar_Click(object sender, EventArgs e)
        {
            if (Select == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de reciduo");
            }
            else
            {
                Random rdm = new Random();
                int ingreso = rdm.Next(1, 10000);
                lblPeso.Text = ingreso.ToString();

                btnVidrio.Enabled = false;
                btnPlastico.Enabled = false;
                btnPapel.Enabled = false;
                btnBio.Enabled = false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            lblPuntosGanados.Visible = true;
            double peso = Convert.ToDouble(lblPeso.Text);
            peso = Math.Round(peso * 0.4);
            lblPtsGanados.Text = Convert.ToString(peso);
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
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
            usuario.DNI = DNI;

            registro.Fecha = DateTime.Now;
            registro.Usuario = usuario;
            registro.Tipo = tipo;
            registro.Cantidad = Int32.Parse(lblPeso.Text);
            registro.Contenedor = contenedor;
            registro.Creditos = Int32.Parse(lblPtsGanados.Text);
            registro.GrabarRegistro(registro);



        }

        private void BtnVidrio_Click(object sender, EventArgs e)
        {
            lblQuepeso.Text = "Vidrio";
            lblPuntosGanados.Visible = true;
            Select = true;
        }

        private void BtnPlastico_Click(object sender, EventArgs e)
        {
            lblQuepeso.Text = "Plastico";
            lblPuntosGanados.Visible = true;
            Select = true;
        }

        //Cuando se hace clic en acepatar se va a mostrar la cantidad de puntos que se estarían sumando
        private void BtnPapel_Click(object sender, EventArgs e)
        {
            lblQuepeso.Text = "Papel";
            lblPuntosGanados.Visible = true;
            Select = true;
        }

        private void BtnBio_Click(object sender, EventArgs e)
        {
            lblQuepeso.Text = "Bio-degradables";
            lblPuntosGanados.Visible = true;
            Select = true;
        }

        private void Frm_Pesaje_Load(object sender, EventArgs e)
        {

            Persistencia pdd = new Persistencia();
            DataSet ds = pdd.BuscarDatos("Cuentas");
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                if (ds.Tables[0].Columns[i].ToString() == DNI)
                {
                    lblUser.Text = ds.Tables[0].Columns[5].ToString();
                }
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al cancelar no sumarás los puntos, ¿Estás seguro de esto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            MessageBox.Show("La operación a sido cancelada");
            this.Dispose();
            this.Close();
            frm_Inicial Volver = new frm_Inicial();
            Volver.ShowDialog();
        }

        private void BtSeguirRec_Click(object sender, EventArgs e)
        {
            int point = 0;

            lblQuepeso.Text = "";
            lblPeso.Text = "";

            point = Convert.ToInt32(lblPtsGanados.Text);
            suma = suma + point;

            lblPuntosAcumulados.Text = "Puntos Acumulados: " + Convert.ToString(suma);
            lblPtsGanados.Text = "";

            btnVidrio.Enabled = true;
            btnPlastico.Enabled = true;
            btnPapel.Enabled = true;
            btnBio.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }
    }
}
