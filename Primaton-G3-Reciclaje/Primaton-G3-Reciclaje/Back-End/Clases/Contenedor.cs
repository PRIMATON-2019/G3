using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaton_G3_Reciclaje.Back_End.Clases
{
    public class Contenedor
    {
        #region Propiedades
        public int Id { get; set; }
        public decimal Capacidad { get; set; }
        public int tamanio { get; set; }



        #endregion
        #region Constructor
        public Contenedor()
        {

        }

        internal Contenedor obtenerNumero()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Metodos
        #endregion
    }
}
