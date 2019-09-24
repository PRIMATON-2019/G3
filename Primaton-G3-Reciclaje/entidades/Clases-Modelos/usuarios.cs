using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace entidades

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
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
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

        public string GenerarQR(string dni)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            System.Drawing.Image qr = qrcode.Draw(dni, 50);

            qr.Save(dni);
            return dni;
        }
        #endregion
    }
}
