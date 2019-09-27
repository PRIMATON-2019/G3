using entidades;
using Primaton.Front.Formularios;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //Verificar usuario ingresado.
            if (txtDNI.Text != "" && txtPass.Text != "")
            {
                Persistencia pd = new Persistencia();
                DataSet ds = pd.BuscarDatos("Usuarios");
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    string dni = ds.Tables[0].Rows[j][5].ToString();
                    string pass = ds.Tables[0].Rows[j][4].ToString();
                    if (txtDNI.Text.Equals(dni)
                        && txtPass.Text.Equals(pass))
                    {
                        MessageBox.Show("Encontrado");
                        //MenuInicial mi = new MenuInicial();
                        //mi.Show();
                    }
                }
                frm_Personal perfil = new frm_Personal();
                perfil.ShowDialog();
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
            this.Close();
        }

        private void LinklblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_registro registro = new frm_registro();
            registro.ShowDialog();

        }
    }
}
