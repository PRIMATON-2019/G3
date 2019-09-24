using System;

namespace entidades

{
    public class Registros
    {
        #region PROPIEDADES / MODELO
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public Usuarios Usuario { get; set; }//todo: pensar bien la idea antes de seguir con usuarios
        public TipoResiduo Tipo { get; set; }
        public int Cantidad { get; set; }
        public Contenedor Contenedor { get; set; }// Crear clase y hacer la referencia
        public int Ticket { get; set; }
        public int TipodeRegistro { get; set; }//si es 1 entrada, si es 2 salida (camion)
        public int Creditos { get; set; }
        #endregion


        Registros registro;


        public Registros()
        {
            registro = new Registros();
        }

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
        public string GrabarRegistro()
        {

            Persistencia pd = new Persistencia();

            string[] datos = {
                registro.Id.ToString(),
                registro.Fecha.ToString(),
                registro.Usuario.DNI,
                registro.Tipo.ToString(),
                registro.Cantidad.ToString(),
                registro.Creditos.ToString() };
            string[] columnas = { "Id", "Fecha", "Usuario", "Tipo", "Cantidad", "Creditos" };

            pd.CargaDatos(datos, 6, columnas);


            return "";
        }
      
        public void LeerTodos(){

        }

        public void BuscarUno(){

        }

     
      
        public void ArmarRegistro(Usuarios usuario)
        {

            //usuario.DNI = ;
            Registros registro = new Registros();
            registro.Tipo = registro.Tipo;
        }

        //Aca estoy yo
        //
        //Joya
        #endregion


    }
}
