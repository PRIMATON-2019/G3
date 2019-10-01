using entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Primaton.Front.forms_usuario
{
    public partial class frm_registrodebasuras : Form
    {
        Persistencia listaregistros = new Persistencia();
        public frm_registrodebasuras()
        {
            InitializeComponent();
            //listaregistros.SoloLeer();
            DataSet ds = new DataSet();
            //dataGridView1.DataSource = listaregistros.Tabla;
            ds = listaregistros.SoloLeer("Registros");
            if (ds != null)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow reg = ds.Tables[0].Rows[i];
                   
                }
            }

        }

        private void Frm_graficos_Load(object sender, EventArgs e)
        {

        }
    }
}
