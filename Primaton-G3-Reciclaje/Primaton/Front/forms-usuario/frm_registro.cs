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
using System.Data;

namespace Primaton.Front.forms_usuario
{
    
    public partial class frm_registro : Form
    {
        public int genero { get; private set; }

        public frm_registro()
        {
            InitializeComponent();
        }

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
    }
}
