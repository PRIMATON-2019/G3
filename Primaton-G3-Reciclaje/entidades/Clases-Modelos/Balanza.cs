using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Balanza
    {
        #region Propiedades
        public int Id { get; set; }




        #endregion
        #region Constructor
        public Balanza()
        {

        }
        #endregion

        public int obtenerCantidad()
        {
            Random peso = new Random();
            return peso.Next();
        }
        #region Metodos
        #endregion
    }
}
