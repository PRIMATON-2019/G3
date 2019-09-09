using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaton_G3_Reciclaje.Back_End.Clases
{
    public class Domicilio
    {
        //trabajar esta clase
        public int ID { get; set; }
        public string Calle { get; set; }
        public string CalleNro { get; set; }
        public string Barrio { get; set; }
        public Ciudad Ciudad { get; set; } //trabajar ciudad

    }
}
