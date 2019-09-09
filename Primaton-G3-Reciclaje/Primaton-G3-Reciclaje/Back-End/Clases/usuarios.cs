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
        public Domicilio Domicilio { get; set; } //listo
        public DateTime FechadeNacimiento { get; set; }// listo
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
//conectar la camara aqui.
            return "";
        }
        #endregion
    }
}
