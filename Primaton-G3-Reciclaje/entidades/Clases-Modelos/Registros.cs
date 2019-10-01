using System;

namespace entidades

{
    public class Registros
    {
        #region PROPIEDADES / MODELO
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public Usuarios Usuario { get; set; }
        public TipoResiduo Tipo { get; set; }
        public int Cantidad { get; set; }
        public Contenedor Contenedor { get; set; }
        public int Ticket { get; set; }
        public int TipodeRegistro { get; set; }
        public int Creditos { get; set; }
        #endregion
        public Registros()
        {
            
        }

        #region METODOS
        public string GrabarRegistro(Registros registro)
        {


            string[] datos = {
                registro.Id.ToString(),
                registro.Fecha.ToString(),
                registro.Usuario.DNI,
                registro.Tipo.Nombre,
                registro.Cantidad.ToString(),
                registro.Creditos.ToString(),
                
            };
            string[] columnas = { "Id", "Fecha", "Usuario", "Tipo", "Cantidad", "Creditos" };

            Persistencia pd = new Persistencia(6, columnas, "Registros");

            pd.CargaDatos(datos, 6, columnas);

            return "";
        }

        public void LeerTodos()
        {

        }

        public void BuscarUno()
        {

        }



        public Registros ArmarRegistro(Registros registro)
        {
            return registro;

        }

        #endregion


    }
}
