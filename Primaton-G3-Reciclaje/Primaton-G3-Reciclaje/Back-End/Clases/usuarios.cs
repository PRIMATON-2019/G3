using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaton_G3_Reciclaje.Back_End.Clases
{
    public class Usuarios
    {

        #region Propiedades
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Genero { get; set; }
        public int Domicilio { get; set; } //hacer clase domicilio y hacer la ref
        public int FechadeNacimiento { get; set; }// hacer clase datatime y hacer la ref
        #endregion

        #region Constructor
        public Usuarios()
        {

        }
        #endregion
        #region Metodos
        public string IdentificarUsuario(string Documento)
        {
//en este metodo identifico al usiario que ha mostrado su dni a la camara con la lectora de qr

            return "";
        }
        #endregion
    }
}
