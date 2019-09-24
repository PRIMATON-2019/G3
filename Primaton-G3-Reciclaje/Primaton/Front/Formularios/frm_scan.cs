using AForge.Video;
using AForge.Video.DirectShow;
using entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
namespace Primaton.Front.Formularios
{
    public partial class frm_scan : Form
    {
        #region propiedades
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        #endregion
        public frm_scan()
        {
            InitializeComponent();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                combobox_camara.Items.Add(Device.Name);
            }
            try
            {
                combobox_camara.SelectedIndex = 0;
                FinalFrame = new VideoCaptureDevice();
            }
            catch (Exception)
            {
                Console.WriteLine("No se encontro la camara");
            }
        }
        #region eventos

        private void Timer_hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }
        #endregion

        #region eventos scanner

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[combobox_camara.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer_scan.Enabled = true;
            timer_scan.Interval = 1000;
            timer_scan.Start();

        }

        private void Frm_scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (FinalFrame.IsRunning == true)
                {
                    FinalFrame.Stop();
                }
            }
            catch (Exception)
            {
                //TODO: Controlar excepcion

            }
        }

        private void Timer_scan_Tick(object sender, EventArgs e)
        {
            
            try
            {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)picbox_camara.Image);
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    timer_scan.Stop();
                    if (!listBox1.Items.Contains(decoded))
                    {
                        listBox1.Items.Insert(0, decoded);
                    }
                    MessageBox.Show(decoded);
                    //Form2 form = new Form2();
                    //form.Show();
                    //this.Hide();

                }
                
            }
            catch (Exception ex)
            {

            }
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picbox_camara.Image = (Bitmap)eventArgs.Frame.Clone();
            //todo: generar el metodo de decodificacion de qr, y recien alli con esos dato generar usuario
            //  Usuarios usuario = new Usuarios();
        }

        private void Btn_detenercamara_Click(object sender, EventArgs e)
        {
            FinalFrame.Stop(); //Detenemos la camara
                               //trabajar para cerrar la camara al apretar el boton, que desaparezca la imagen.

        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            timer_scan.Enabled = true;
            timer_scan.Start();
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            Registros registro = new Registros();
            registro.Usuario.DNI = "aca va el textbox o label con el dato del usuaario";
            Persistencia pd = new Persistencia();
            DataSet ds = pd.BuscarDatos("Usuarios");
           
            frm_bienvenida InicioScan = new frm_bienvenida(registro);
            InicioScan.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form DigDNI = new frm_Inicial();
            DigDNI.Show();
        }
    }
}
