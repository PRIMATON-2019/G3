using entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton.Front.Formularios
{
    public partial class frm_dnimanual : Form
    {
        public frm_dnimanual()
        {
            InitializeComponent();
        }
        #region eventos Botones

        private void Btn_1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_7_Click(object sender, EventArgs e)
        {

        }

        private void Btn_8_Click(object sender, EventArgs e)
        {

        }

        private void Btn_9_Click(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.DNI = txt_documento.Text;
            Registros registro = new Registros();
            registro.Usuario = usuario;



            frm_Pesaje pesaje = new frm_Pesaje();
            pesaje.ShowDialog();
        }
    }
}
