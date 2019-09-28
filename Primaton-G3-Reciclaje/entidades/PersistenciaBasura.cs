using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class PersistenciaBasura
    {
        private const string NombreArchivo = @"RegistroBasura.xml";
        Registros Reg = new Registros();

        /// <summary>
        /// Tabla en memoria con la lista de registros
        /// </summary>
        public DataTable TablaRegistro = new DataTable("TablaRegistro");
        public PersistenciaBasura()
        {

        }
        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>

        public void ConfigInicial()  // diseño de la TablaRegistro
        {
            TablaRegistro.Columns.Add("Id");
            TablaRegistro.Columns.Add("DNI");
            TablaRegistro.Columns.Add("Fecha");
            TablaRegistro.Columns.Add("Tipo");
            TablaRegistro.Columns.Add("Cantidad");
            TablaRegistro.Columns.Add("Creditos");
            TablaRegistro.Columns.Add("Contenedor");
        }



        public void NuevoRegistro(int DNI, int Cantidad , DateTime fecha, int Contenedor, int Creditos, int Tipo, int Id)
        {
            Reg.Id = Id;
            Reg.Usuario.DNI = DNI.ToString() ;
            Reg.Fecha = fecha;
            
            Reg.Cantidad = Cantidad;
            Reg.Contenedor.tamanio = Contenedor;
            Reg.Creditos = Creditos;
            Reg.Tipo.Tiporesiduo = Tipo;

            
            {

                TablaRegistro.Rows.Add();
                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["DNI"] = Reg.Usuario.DNI;
                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Id"] = Reg.Id;

                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Fecha"] = Reg.Fecha;
                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Tipo"] = Reg.Tipo;
                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Cantidad"] = Reg.Cantidad;
                
                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Contenedor"] = Reg.Contenedor;
                TablaRegistro.Rows[TablaRegistro.Rows.Count - 1]["Creditos"] = Reg.Creditos;
                
                TablaRegistro.WriteXml(NombreArchivo);

                
            }
        }

        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        /// 

        public void LeeGastos()
        {
            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaRegistro.ReadXml(NombreArchivo);
            }
        }

        #endregion
    }
}
