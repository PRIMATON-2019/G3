using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaton_G3_Reciclaje.Back_End.Clases
{
    public class Persistenciadedatos
    {
        #region Propiedades
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"personas.xml";

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        private System.Data.DataTable TablaPersona = new DataTable("TablaPersonas");
        public Registros RegistroBasura { get; set; }
        #endregion
        #region Constructor
        public Persistenciadedatos()
        {
            ConfiguracionInicial();
            
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        private void ConfiguracionInicial()
        {
            // diseño de la TablaPersona
            TablaPersona.Columns.Add("Nombre");
            TablaPersona.Columns.Add("Domicilio");
            TablaPersona.Columns.Add("DNI");
            TablaPersona.Columns.Add("Edad");

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaPersona.ReadXml(NombreArchivo);
            }

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
            //txtNombre.Text = "";
            //txtDomicilio.Text = "";
            //txtEdad.Text = "";
            //txtDNI.Text = "";
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        public void LlenaRegistroTabla(Registros registro)// pasamos un objeto " registro "
        {
            TablaPersona.Rows.Add();
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Nombre"] = registro.Usuario.Apellido; //despues lo utilizamos aca
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Domicilio"] = txtDomicilio.Text;
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["DNI"] = txtDNI.Text;
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Edad"] = txtEdad.Text;
        }
        #endregion
    }
}
