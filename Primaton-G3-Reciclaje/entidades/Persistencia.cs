using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Persistencia
    {
        #region Propiedades
        public DataTable Tabla;
        
        public string NombreArchivo;
        public DataSet ds;
        #endregion

        /// <summary>
        /// Clase encargada de persistir datos.
        /// </summary>
        /// <param name="cantColumnas">Numero de columnas en la tabla</param>
        /// <param name="columnas">Encabezados de la tabla. Debe coincidir con la cantidad en cantColumnas</param>
        /// <param name="nombreArchivo">Nombre del archivo a guardar, sin extension.</param>
        public Persistencia()
        {
            Tabla = new DataTable();
            

        }
        #region metodos
        public Persistencia(int cantColumnas, string[] columnas, string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
            Tabla = new DataTable(NombreArchivo);
            
            ConfiguracionInicial(cantColumnas, columnas);
        }
        public void ConfiguracionInicial(int cantColumnas, string[] columnas)
        {
            // Diseñamos la Tabla 
            for (int i = 0; i < cantColumnas; i++)
            {
                Tabla.Columns.Add(columnas[i]);
                
            }
        }
        /// <summary>
        /// Graba el archivo XML a disco.
        /// </summary>
        /// <param name="NombreArchivo">Nombre de Archivo, sin extension</param>
        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        public void CargaDatos(string[] datos, int cantColumnas, string[] columnas)// pasamos un objeto " registro "
        {
            LeerArchivo();
            Tabla.Rows.Add();
            
            for (int i = 0; i < cantColumnas; i++)
            {
                
                Tabla.Rows[Tabla.Rows.Count - 1][columnas[i]] = datos[i]; //despues lo utilizamos aca
            }
            GrabarArchivo();
        }
        public DataSet SoloLeer(string nombreArch)
        {
                ds = new DataSet();
            if (System.IO.File.Exists(nombreArch + ".xml"))
            {
                ds.ReadXml(@"registros.xml");
                //Tabla.ReadXml(@"Registros.xml");
            }
                return ds;
        }
        public void LeerArchivo()
        {
            if (System.IO.File.Exists(NombreArchivo + ".xml"))
            {
                Tabla.ReadXml(NombreArchivo + ".xml");
            }
            else
            {
                string[] columnas = { "Id", "Fecha", "Usuario", "Tipo", "Cantidad", "Creditos" };
                //ConfiguracionInicial(6, columnas);
                GrabarArchivo();
            }
        }
        public void GrabarArchivo() 
        {
            //string NombreArchivo = "Cuentas";
            Tabla.WriteXml(NombreArchivo + ".xml");
        }

        public DataSet BuscarDatos(string nombreArchivo)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(nombreArchivo + ".xml");
            return ds;
        }
        //public string DevuelveIngresos(string dni)
        //{
        //    for (int i = Tabla.Rows.Count - 1; i >= 0; i--)
        //    {
        //        DataRow fila = Tabla.Rows[i];
        //        if (fila["Usuario"].ToString() == dni)
        //        {
        //            return fila["Usuario"].ToString();
        //        }
        //    }
        //    return "0";
        //}
        #endregion
    }
}
