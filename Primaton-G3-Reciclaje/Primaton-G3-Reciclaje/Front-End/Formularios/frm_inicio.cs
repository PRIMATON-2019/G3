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
    public partial class frm_inicio : Form
    {
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"RegistroBasura.xml";

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        private System.Data.DataTable TablaRegistros = new DataTable("TablaRegistros");
        #endregion
        public frm_inicio()
        {
            InitializeComponent();
        }
        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        private void ConfiguracionInicial()
        {
            // diseño de la TablaPersona
            TablaRegistros.Columns.Add("Nombre");
            TablaRegistros.Columns.Add("Domicilio");
            TablaRegistros.Columns.Add("DNI");
            TablaRegistros.Columns.Add("Edad");

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaRegistros.ReadXml(NombreArchivo);
            }

            // asigna TablaPersona a dgvPersonas
            dgvPersonas.DataSource = TablaRegistros;
            // elimina la posibilidad de ingresar datos en el datagridview
            dgvPersonas.AllowUserToAddRows = false;
            // elimina el encabezado de las filas
            dgvPersonas.RowHeadersVisible = false;
        }

        // Llena con string vacio los texbox
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtEdad.Text = "";
            txtDNI.Text = "";
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        private void LlenaRegistroTabla()
        {
            TablaRegistros.Rows[TablaRegistros.Rows.Count - 1]["Nombre"] = txtNombre.Text;
            TablaRegistros.Rows[TablaRegistros.Rows.Count - 1]["Domicilio"] = txtDomicilio.Text;
            TablaRegistros.Rows[TablaRegistros.Rows.Count - 1]["DNI"] = txtDNI.Text;
            TablaRegistros.Rows[TablaRegistros.Rows.Count - 1]["Edad"] = txtEdad.Text;
        }
        #endregion
    }
}
