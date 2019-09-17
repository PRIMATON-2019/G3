using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using Zen.Barcode;
namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    public partial class frm_ticketqr : Form
    {
        public frm_ticketqr()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Usando la Libreria Zen.Barcode, desde Nugets manager, logramos generar un codigo de barras /br
        /// y QR. Todavia Falta ver casos de Uso de el Mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region CODIGOS GENERADOR

        private void Btn_encode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(txt_barcode.Text, 50);
            //Codigo de barras solamente usando zXING
            //BarcodeWriter codigo = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            //pictureBox1.Image = codigo.Write(txt_encode.Text);

        }

        private void Btn_decode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(txt_qr.Text, 50);
            //CODIGO DE BARRAS SOLAMENTE USANDO ZXING
            //BarcodeReader Lector = new BarcodeReader();
            //var resultado = Lector.Decode((Bitmap)pictureBox1.Image)
            //if (resultado!=null)
            //{
            //    txt_decode.Text = resultado.Text;
            //}
        }
        #endregion
    }
}
