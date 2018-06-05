using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Photo1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "you click on the photo button ";
            //initialisation timer
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ushort[] imageData = new ushort[288 * 384];
            byte[] bArr = new byte[288 * 384];
            Bitmap b = new Bitmap(384, 288, PixelFormat.Format8bppIndexed);
            ColorPalette ncp = b.Palette;
            Rectangle BoundsRect = new Rectangle(0, 0, 384, 288);
            BitmapData bmpData;
            IntPtr ptr;
            DLLHelper.RecvImage(imageData, 0);
            for (int n = 0; n < 288 * 384; n++)
            {
                bArr[n] = (byte)(imageData[n] >> 8);
            }
            bmpData = b.LockBits(BoundsRect, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            ptr = bmpData.Scan0;

            Marshal.Copy(bArr, 0, ptr, bmpData.Stride * 288);
            b.UnlockBits(bmpData);

            RefreshImage(b);


            if (textBox1.Text.Equals("tick"))
            {
                textBox1.Text = "tack";
            }
            else
            {
                textBox1.Text = "tick";
            }

        }

        delegate void RefreshImageDelegate(Bitmap bmpData);

        void RefreshImage(Bitmap bmpData)
        {

            if (pictureBox1.InvokeRequired == false)
            {
                pictureBox1.Image = bmpData;



               // if (btnStop.Enabled == false) btnStop.Enabled = true;
                //if (btnCalibrate.Enabled == true && liveStream == true) btnCalibrate.Enabled = false;
            }
            else
            {
                RefreshImageDelegate showProgress = new RefreshImageDelegate(RefreshImage);
                BeginInvoke(showProgress, new object[] { bmpData });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = this.Handle;

            int bRes = DLLHelper.UsbOpenDevice(hWnd, 0);
            if (bRes == 1)
            {
                textBox1.Text = "Connected!";
            }
            else
            {
                textBox1.Text = "Err:" + bRes.ToString();
            }

            bRes = DLLHelper.ReadFlashData(0);
            if (bRes == 1)
            {
                textBox1.Text = "Flash read completed";
               //need to enable th good buttons
                // btnStream.Enabled = true;
                //btnDisconnect.Enabled = true;
               // btnCalibrate.Enabled = true;
            }
            else
            {
                textBox1.Text = "Err:" + bRes.ToString();
            }

        }

        private void disconect_Click(object sender, EventArgs e)
        {
            DLLHelper.UsbCloseDevice(0);
            textBox1.Text = "Disconnected!";

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void onePhoto_Click(object sender, EventArgs e)
        {
            ushort[] imageData = new ushort[288 * 384];
            byte[] bArr = new byte[288 * 384];
            Bitmap b = new Bitmap(384, 288, PixelFormat.Format8bppIndexed);
            ColorPalette ncp = b.Palette;
            Rectangle BoundsRect = new Rectangle(0, 0, 384, 288);
            BitmapData bmpData;
            IntPtr ptr;
            DLLHelper.RecvImage(imageData, 0);
            for (int n = 0; n < 288 * 384; n++)
            {
                bArr[n] = (byte)(imageData[n] >> 8);
            }
            bmpData = b.LockBits(BoundsRect, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            ptr = bmpData.Scan0;

            Marshal.Copy(bArr, 0, ptr, bmpData.Stride * 288);
            b.UnlockBits(bmpData);

            RefreshImage(b);

            //to do retrive the data from the  CalcEntireTemp fonction






        }
    }
}
