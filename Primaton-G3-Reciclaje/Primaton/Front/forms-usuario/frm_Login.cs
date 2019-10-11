using entidades;
using Primaton.Front.Formularios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Primaton.Front.forms_usuario
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //Verificar usuario ingresado.
            if (txtDNI.Text != "" && txtPass.Text != "")
            {
                Persistencia pd = new Persistencia();
                DataSet ds = pd.BuscarDatos("Cuentas");
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    string dni = ds.Tables[0].Rows[j][5].ToString();
                    string pass = ds.Tables[0].Rows[j][4].ToString();
                    if (txtDNI.Text.Equals(dni)
                        && txtPass.Text.Equals(pass))
                    {
                       
                        
                        this.Dispose();
                        this.Close();
                        frm_plataforma perfil = new frm_plataforma(dni);
                        perfil.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtPass.Text = "";
            txtDNI.SelectAll();
            this.Dispose();
            this.Close();
        }

        private void LinklblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            this.Close();
            frm_registro registro = new frm_registro();
            registro.ShowDialog();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }
    }
}
