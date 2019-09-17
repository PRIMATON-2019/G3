using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades

{
    public class Persistenciadedatos
    {
        #region Propiedades
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        public const string NombreArchivo = @"RegistroBasura.xml"; //por defecto se guarda en la carpeta bin.

        /// <summary>
        /// Tabla en memoria con la lista de registros
        /// </summary>
        public System.Data.DataTable TablaRegistro = new DataTable("TablaRegistro");
        
        #endregion
        #region Constructor
        public Persistenciadedatos()
        {
            ConfiguracionInicial();
            
        }
        #endregion
        #region Metodos
        /// <summary>
        /// el metodo [configuracioninicial]
        /// Diseña columnas del datatable y 
        /// verifica si el archivo existe previamente
        /// 
        /// </summary>
        private void ConfiguracionInicial()
        {
            // diseño de la TablaRegistro
            TablaRegistro.Columns.Add("Id");
            TablaRegistro.Columns.Add("Fecha");
            TablaRegistro.Columns.Add("Usuario");
            TablaRegistro.Columns.Add("Tipo");
            TablaRegistro.Columns.Add("Cantidad");
            TablaRegistro.Columns.Add("Contenedor");
            TablaRegistro.Columns.Add("Ticket");
            TablaRegistro.Columns.Add("TipoRegistro");

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaRegistro.ReadXml(NombreArchivo);
            }

            //// asigna TablaPersona a dgvPersonas
            //dgvPersonas.DataSource = TablaPersona;
            //// elimina la posibilidad de ingresar datos en el datagridview
            //dgvPersonas.AllowUserToAddRows = false;
            //// elimina el encabezado de las filas
            //dgvPersonas.RowHeadersVisible = false;
        }
        /// <summary>
        /// Graba el Archivo XML que creeamos previamente en las propiedades.
        /// </summary>
        public void GrabarArchivo()
        {
            TablaRegistro.WriteXml(NombreArchivo);
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
        /// Agregamos una nueva Fila, y a cada fila le damos un nombre, el metodo
        /// pide un argumento, en este caso pide el Objeto Registro, y Enlazamos cada propiedad
        /// correspondiente con cada fila
        /// </summary>
        public void LlenaRegistroTabla(Registros registro)// pasamos un objeto " registro "
        {
            TablaRegistro.Rows.Add();
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["ID"] = registro.Id; //despues lo utilizamos aca
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Fecha"] = registro.Fecha;
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Usuario"] = registro.Usuario;
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Tipo"] = registro.Tipo;
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Cantidad"] = registro.Cantidad; //despues lo utilizamos aca
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Contenedor"] = registro.Contenedor;
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Ticket"] = registro.Ticket;
            TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["TipoRegistro"] = registro.TipodeRegistro;
        }
        #endregion
    }
}
