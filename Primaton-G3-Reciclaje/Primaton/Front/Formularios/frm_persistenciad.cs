using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
namespace Primaton.Front.Formularios
{
    public partial class frm_persistenciad : Form
    {
        public frm_persistenciad()
        {
            InitializeComponent();
        }
        #region eventos

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            // en este caso, este boton Agrega registro nuevo a la tabla
            //Instanciamos los objetos que creamos que sean necesitarios
            //con sus respectivos constructores
            Usuarios usuario = new Usuarios();
            TipoResiduo tipo = new TipoResiduo();
            Registros RG = new Registros();
            //trabajamos sus propiedades, en este caso, vamos a decir que las propiedades
            //son iguales a lo que estan en los txt.box de el formulario en el que estamos

            RG.Cantidad = Convert.ToInt32(txtCantidad.Text);
            usuario.DNI = txtDNI.Text;
            tipo.Id = 1;
            RG.Id = 1;
            RG.Tipo = tipo;
            //instanciamos un objeto clase registros, y con ese objetos 
            //llamamos al metodo grabarregistro, y le pasamos como argumento RG
            RG.GrabarRegistro(RG);

            //despues llamamos al metodo que limpia los campos, que en este caso yo no lo uso
            LimpiarCampos();
        }

        private void BtGrabar_Click(object sender, EventArgs e)
        {
            //el evento click de el boton grabar, instancia un nuevo objeto pdd de la clase
            //persistenciadedatos, y utilizamos el mismo para llamar al metodo grabararchivo

            Persistenciadedatos pdd = new Persistenciadedatos();
            pdd.GrabarArchivo();
        }
#endregion
        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        //private void ConfiguracionInicial()
        //{
        // diseño de la TablaPersona


        // busca si el archivo ya existe para precargar sus datos
        //if (System.IO.File.Exists(NombreArchivo))
        //{
        //    TablaPersona.ReadXml(NombreArchivo);
        //}

        //// asigna TablaPersona a dgvPersonas
        //dgvPersonas.DataSource = TablaPersona;
        //// elimina la posibilidad de ingresar datos en el datagridview
        //dgvPersonas.AllowUserToAddRows = false;
        //// elimina el encabezado de las filas
        //dgvPersonas.RowHeadersVisible = false;
        //}

        // Llena con string vacio los texbox
        private void LimpiarCampos()
        {
            txtCantidad.Text = "";
            txtTipo.Text = "";
            txtEdad.Text = "";
            txtDNI.Text = "";
        }


        #endregion
    }
}
