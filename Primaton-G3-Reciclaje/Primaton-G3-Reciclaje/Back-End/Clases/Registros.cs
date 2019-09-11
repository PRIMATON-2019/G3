using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaton_G3_Reciclaje.Back_End.Clases
{
    public class Registros
    {
        #region PROPIEDADES
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuarios Usuario { get; set; }// pensar bien la idea antes de seguir con usuarios
        public TipoResiduo Tipo { get; set; }
        public float Cantidad { get; set; }
        public Contenedor Contenedor { get; set; }// Crear clase y hacer la referencia
        public string Ticket { get; set; }
        public int TipodeRegistro { get; set; }//si es 1 entrada, si es 2 salida (camion)
        #endregion
        Registros nuevoregistro = new Registros();

        public Object[] registro = new Object[1];
        #region METODOS

        public string GrabarRegistro(Usuarios usuario, TipoResiduo tipo)
        {
            if (usuario==null)
            {
                Console.WriteLine("El usuario no esta registrado");
            }
            else
            {
                //Usuarios usuario = new Usuarios();
                nuevoregistro.Usuario = usuario;
                //nuevoregistro.Fecha = System.DateTime.Now; REVISAR ESTO.
                nuevoregistro.Tipo = tipo;
                nuevoregistro.Cantidad = Balanza.obtenerCantidad();
                nuevoregistro.Contenedor = Contenedor.obtenerNumero();
                nuevoregistro.Ticket = "1"; // Generer un metodo que incremente el nro de ticket
                registro[1] = nuevoregistro;
            }


            return "";
        }

        #endregion


    }
}
