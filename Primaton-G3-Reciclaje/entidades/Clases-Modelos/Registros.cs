namespace entidades

{
    public class Registros
    {
        #region PROPIEDADES
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuarios Usuario { get; set; }//todo: pensar bien la idea antes de seguir con usuarios
        public TipoResiduo Tipo { get; set; }
        public int Cantidad { get; set; }
        public Contenedor Contenedor { get; set; }// Crear clase y hacer la referencia
        public int Ticket { get; set; }
        public int TipodeRegistro { get; set; }//si es 1 entrada, si es 2 salida (camion)
        #endregion


        #region METODOS
        /// <summary>
        /// Este metodo, lo que hace es recibir, un argumento de la clase Registros, 
        /// llamado nuevoregistro
        /// lo que hacemos aca es instanciar un nuevo objeto "pd" de la clase Persistenciadedatos
        /// el objeto pd, llama al metodo Llenarregistrotabla, y le pasamos el argumento.
        /// pd llama al metodo GrabarArchivo [ nuestro xml]
        /// </summary>
        /// <param name="nuevoregistro"></param>
        /// <returns>Argumento de el metodo</returns>
        /// 
        public string GrabarRegistro(Registros nuevoregistro)
        {
            Persistenciadedatos pd = new Persistenciadedatos();  //creo un pd que me permite acceder de base de datos
            //Usuarios usuario = new Usuarios();
            //usuario.Apellido = "manzanas";
            //nuevoregistro.Usuario = usuario;
            //nuevoregistro.Fecha = System.DateTime.Now; REVISAR ESTO.
            //nuevoregistro.Tipo = tipo;
            //nuevoregistro.Cantidad = Balanza.obtenerCantidad();
            //nuevoregistro.Contenedor = Contenedor.obtenerNumero();
            //nuevoregistro.Ticket = 1; // Generer un metodo que incremente el nro de ticket
                                      //registro[1] = nuevoregistro;

            pd.LlenaRegistroTabla(nuevoregistro); //paso argumento
            pd.GrabarArchivo();
            //}
            return "";
        }
        #endregion


    }
}
