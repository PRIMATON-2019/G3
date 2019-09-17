using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    public partial class frm_balanza : Form
    {
        public frm_balanza()
        {
            InitializeComponent();
        }

        //Nesitamos VIDRIO - PLASTICO - PAPEL - LATAS - MATERIALES BIODEGRADABLES 
        //Una hoja A4 pesa aproximadamente 5 gramos 
        //Una botella de plástico de 500 cc pesa aproximadamente 25 gramos 
        //Una botella de vidrio de 750 cc pesa aproximadamente 570 gramos 
        //Una lata de alumunio pesa aproximadamente 14 gramos 
        //Materiales biodegradables ????
        //Los puntos no tienen que vencer, son acumulables 

        //Cada gramo de papel va a dar 0.4 puntos (Por hoja A4 son 2 puntos aprox) 
        //5 hojas A4 son 10 puntos, una botella de plástico son 25 puntos 1 punto por gramo,
        //una botella de vidrio son 156 puntos ( en este punto la botella probablemente debería valer 
        // un poco menos de puntos - 0.3 puntos por gramo ), las latas de alumunio 0.7

        private void Frm_papel_Load(object sender, EventArgs e)
        {

        }
    }
}
