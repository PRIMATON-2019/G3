using Primaton_G3_Reciclaje.Back_End.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    public partial class frm_persistenciadedatos : Form
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        //private const string NombreArchivo = @"personas.xml";

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        //private System.Data.DataTable TablaPersona = new DataTable("TablaPersonas");
        #endregion
        #region CONSTRUCTOR
        public frm_persistenciadedatos()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }
        #endregion 
        #region EVENTOS

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            // Agrega registro nuevo a la tabla
            //TablaPersona.Rows.Add();
            Usuarios usuario = new Usuarios();
            TipoResiduo tipo = new TipoResiduo();
            Registros RG = new Registros();
            RG.Cantidad = Convert.ToInt32(txtCantidad.Text);
            usuario.DNI = txtDNI.Text;
            tipo.Id = 1;
            RG.Id = 1;
            RG.Tipo = tipo;
            RG.GrabarRegistro(RG);

            //LlenaRegistroTabla();

            LimpiarCampos();

            txtCantidad.Focus();
        }

        private void BtGrabar_Click_1(object sender, EventArgs e)
        {
            Persistenciadedatos pd = new Persistenciadedatos();
            pd.GrabarArchivo();
           
        }

        #endregion
        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        private void ConfiguracionInicial()
        {
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
        }

        // Llena con string vacio los texbox
        private void LimpiarCampos()
        {
            txtCantidad.Text = "";
            txtTipo.Text = "";
            txtEdad.Text = "";
            txtDNI.Text = "";
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        
        #endregion

    }
}
