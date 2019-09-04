namespace Primaton_G3_Reciclaje.Back_End.Clases
{
    public class Residuo
    {

        #region Propiedades
        public int Id { get; set; }
        public bool Reciclable { get; set; }
        public bool Reutilizable { get; set; }
        public tipoResiduos Tipo { get; set; }
        public Usuarios Usuario { get; set; }

        #endregion

        #region Constructor
        public Residuo()
        {

        }
        #endregion
        #region Metodos
        public string RecibirResiduo()
        {

            return "";
        }
        #endregion
    }
}
