using entidades;
using System;
using System.Data;
using System.Windows.Forms;
namespace Primaton.Front.Formularios
{
    public partial class frm_nuevobeneficiario : Form
    {
        private readonly DataTable pepe;
        #region Propiedades
        public int genero { get; set; }
        #endregion
        public frm_nuevobeneficiario(DataTable pepe)
        {
            InitializeComponent();
            this.pepe = pepe;
        }
        #region Registro-Usuario

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Usuarios user = new Usuarios();

                user.NombreUsuario = txtCorreo.Text;
                user.Clave = txtClave.Text;
                user.Apellido = txtApellido.Text;
                user.Nombre = TxtNombre.Text;
                user.DNI = txt_dni.Text;
                if (rbFemenino.Checked)
                {
                    genero = 1;
                }
                if (rbMasculino.Checked)
                {
                    genero = 2;
                }
                if (rbNoBinario.Checked)
                {
                    genero = 3;
                }
                user.Genero = genero;
                string[] columnas = { "usuario", "apellido", "nombre", "genero", "clave", "dni" };

                Persistencia db = new Persistencia(6, columnas, "Usuarios");
                string[] datos = {
                    user.NombreUsuario,
                    user.Apellido,
                    user.Nombre,
                    user.Genero.ToString(),
                    user.Clave,
                    user.DNI,
                };
                db.CargaDatos(datos, 6, columnas);
                
                MessageBox.Show("Usuario Creado.");

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
        #region LOGIN

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //Verificar usuario ingresado.
            if (txtDNI.Text != "" && txtClave.Text != "")
            {
                Persistencia pd = new Persistencia();
                DataSet ds = pd.BuscarDatos("dni");
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    string dni = ds.Tables[0].Rows[j][0].ToString();
                    string pass = ds.Tables[0].Rows[j][4].ToString();
                    if (txtDNI.Text.Equals(dni)
                        && txtClave.Text.Equals(pass))
                    {
                        //MenuInicial mi = new MenuInicial();
                        //mi.Show();
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
        }

        private void LinklblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            pnLogin.Visible = false;
            pnRegistro.Visible = true;
        }
        #endregion
    }
}
