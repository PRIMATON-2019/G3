using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton.Front.forms_usuario
{
    public partial class frm_qrUsuario : Form
    {
        private readonly string dni;

        public frm_qrUsuario(string dni)
        {
            InitializeComponent();
            this.dni = dni;
        }

        private void Btn_qr_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(dni, 50);
        }
    }
}
