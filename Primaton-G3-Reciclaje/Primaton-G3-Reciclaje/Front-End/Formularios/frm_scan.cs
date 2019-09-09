using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace Primaton_G3_Reciclaje.Front_End.Formularios
{
    public partial class frm_scan : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public frm_scan()
        {
            InitializeComponent();
        }

        private void Frm_scan_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                combobox_camara.Items.Add(Device.Name);
            }

            combobox_camara.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }


        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picbox_camara.Image = (Bitmap)eventArgs.Frame.Clone();
        }







        private void Button1_Click_1(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[combobox_camara.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
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

        private void Frm_scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
