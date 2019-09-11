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
        public Usuarios Usuario { get; set; }// TODO: pensar bien la idea antes de seguir con usuarios
        public TipoResiduo Tipo { get; set; }
        public float Cantidad { get; set; }
        public Contenedor Contenedor { get; set; }// Crear clase y hacer la referencia
        public int Ticket { get; set; }
        public int TipodeRegistro { get; set; }//si es 1 entrada, si es 2 salida (camion)
        #endregion


        #region METODOS

        public string GrabarRegistro(Registros nuevoregistro)
        {
            //if (usuario == null)
            //{
            //    Console.WriteLine("El usuario no esta registrado");
            //}
            //else
            //{
                
                Usuarios usuario = new Usuarios();
                usuario.Apellido = "Manzana";
                nuevoregistro.Usuario = usuario;
           
                //nuevoregistro.Fecha = System.DateTime.Now; REVISAR ESTO.
                //nuevoregistro.Cantidad = Balanza.obtenerCantidad();
                //nuevoregistro.Contenedor = Contenedor.obtenerNumero();
                nuevoregistro.Ticket = 1; // Generer un metodo que incremente el nro de ticket
                Persistenciadedatos pd = new Persistenciadedatos();
                pd.LlenaRegistroTabla(nuevoregistro);
            return "";
        }

        #endregion


    }
}
