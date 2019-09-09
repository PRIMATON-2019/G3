using AForge.Video;
using AForge.Video.DirectShow;
using Primaton_G3_Reciclaje.Front_End.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
namespace Primaton_G3_Reciclaje
{
    public partial class frm_principal : Form
    {
        //´variables de el scanner
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public frm_principal()
        {
            InitializeComponent();
            timer_hora.Start();

            //iniciamos el scanner
            #region scanner

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                combobox_camara.Items.Add(Device.Name);
            }

            combobox_camara.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            #endregion
        }
        #region EVENTOS HERRAMIENTAS

        private void Link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_registro_comercio = new Form();
            frm_registro_comercio.ShowDialog();
        }
        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Form frm_tiposdereciclaje = new frm_tiposdereciclaje();
            // Para seguir, bandera 1 (Si el usuario ingresó el dni o escaneó) sino, no permitir seguir.
            // by:fabri



            frm_tiposdereciclaje.ShowDialog();
        }
        #endregion

        #region EVENTOS SCANNER

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[combobox_camara.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void Btn_show_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)picbox_camara.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    timer1.Stop();
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
        }
    }
    #endregion

}
