using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using Coding4Fun.Kinect.WinForm;
using System.IO.Ports;
using System.Windows.Media;
using System.Windows;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;

        long avg = 0;

        int iteration = 0;

        int countFor250 = 0;

        int countFor300 = 0;

        int countFor350 = 0;

        int countFor400 = 0;

        int countFor450 = 0;

        int countFor500 = 0;

        int countFor550 = 0;

        int countFor600 = 0;

        bool iskinectDisconnected = false;

        long dataOut;

        private KinectSensor kSensor;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            string[] ports = SerialPort.GetPortNames();
            foreach (var item in ports)
            {
                cboComPort.Items.Add(item);
                cboComPort.SelectedIndex = 0;

            }
            lblConnectionId.Visible = false;
            lblConnectionIdValue.Visible = false;
            serialPort1.PortName = cboComPort.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;
            serialPort1.Open();

        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            if (btnStream.Text == "Start")
            {

                if (KinectSensor.KinectSensors.Count > 0)
                {
                    this.btnStream.Text = "Stop";

                    kSensor = KinectSensor.KinectSensors[0];

                    KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
                }
                kSensor.Start();

                this.lblConnectionIdValue.Text = kSensor.DeviceConnectionId;

                kSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);

                kSensor.DepthStream.Enable();

                kSensor.AllFramesReady += KSensor_AllFramesReady;

                kSensor.SkeletonStream.Enable();

                kSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;
            }
            else
            {
                if (kSensor != null && kSensor.IsRunning && btnStream.Text == "Stop")
                {
                    kSensor.Stop();

                    this.btnStream.Text = "Start";

                    this.pictureBox1.Image = null;

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }
                }
            }

        }

        private void KSensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            using (var frame = e.OpenColorImageFrame())
                if (frame != null)
                {
                    if (!iskinectDisconnected)
                        pictureBox1.Image = CreateBitmapFromSensor(frame);
                }

            using (var frame = e.OpenSkeletonFrame())
            {
                if (frame == null)
                {
                    return;

                }

                var skeletons = new Skeleton[frame.SkeletonArrayLength];
                frame.CopySkeletonDataTo(skeletons);

                var TrackedSkeleton = skeletons.FirstOrDefault(x => x.TrackingState == SkeletonTrackingState.Tracked);

                if (TrackedSkeleton == null)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    serialPort1.WriteLine(Convert.ToString(-500));
                    iteration = 0;
                    return;
                }


                var position = TrackedSkeleton.Joints[JointType.HandRight].Position;

                var coordinatemapper = new CoordinateMapper(kSensor);

                var colorpoint = coordinatemapper.MapSkeletonPointToColorPoint(position, ColorImageFormat.InfraredResolution640x480Fps30);

                this.lblPosition.Text = string.Format(" Hand Position X:{0}, Y : {1}", colorpoint.X, colorpoint.Y);

                dataOut = colorpoint.X;

                count++;
                if (dataOut > 150)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    if (dataOut > 150 )
                    {
                        countFor250++;
                    }
                    if (dataOut > 250 && dataOut < 300)
                    {
                        countFor300++;
                    }

                    if (dataOut > 300 && dataOut < 350)
                    {
                        countFor350++;
                    }
                    if (dataOut > 350 && dataOut < 400)
                    {
                        countFor400++;
                    }
                    if (dataOut > 400 && dataOut < 450)
                    {
                        countFor450++;
                    }
                    if (dataOut > 450 && dataOut < 500)
                    {
                        countFor500++;
                    }
                    if (dataOut > 500 && dataOut < 550)
                    {
                        countFor550++;
                    }
                    if (dataOut > 550)
                    {
                        countFor600++;
                    }
                    if (count > 50 && iteration == 0 && countFor250 > 1)
                    {
                        avg = 300;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 1;
                        avg = 0;
                        countFor300 = 0;

                    }
                    if (count > 50 && iteration == 1 && countFor300 > 1)
                    {
                        avg = 300;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 2;
                        avg = 0;
                        countFor300 = 0;

                    }
                    if (count > 50 && iteration <= 2 && countFor350 > 5)
                    {
                        avg = 350;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 3;
                        avg = 0;
                        countFor350 = 0;
                    }
                    if (count > 50 && iteration == 3 && countFor400 > 5)
                    {
                        avg = 400;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 4;
                        avg = 0;
                        countFor400 = 0;

                    }
                    if (count > 50 && iteration == 4 && countFor450 > 5)
                    {
                        avg = 450;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 5;
                        avg = 0;
                        countFor450 = 0;

                    }
                    if (count > 50 && iteration == 5 && countFor500 > 5)
                    {
                        avg = 500;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 6;
                        avg = 0;
                        countFor500 = 0;

                    }
                    if (count > 50 && iteration == 6 && countFor550 > 5)
                    {
                        avg = 550;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 7;
                        avg = 0;
                        countFor550 = 0;

                    }
                    if (countFor600 > 15)
                    {
                        avg = 700;
                        serialPort1.WriteLine(Convert.ToString(avg));
                        count = 0;
                        iteration = 0;
                        avg = 0;
                        countFor600 = 0;

                    }
                    dataOut = 0;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    serialPort1.WriteLine(Convert.ToString(-500));
                    iteration = 0;
                    
                }
            }
        }

        //private void KSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        //{
        //    using (var frame = e.OpenColorImageFrame())
        //    {
        //        if (frame != null)
        //        {
        //            if (!iskinectDisconnected)
        //                pictureBox1.Image = CreateBitmapFromSensor(frame);
        //        }
        //    }
        //}

        private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            this.lblStatusValue.Text = kSensor.Status.ToString();
        }

        private System.Drawing.Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
        {
            var pixelData = new byte[frame.PixelDataLength];

            frame.CopyPixelDataTo(pixelData);

            return pixelData.ToBitmap(frame.Width, frame.Height);
        }

        private void btnStream_Click_1(object sender, EventArgs e)
        {
            if (btnStream.Text == "Start")
            {

                if (KinectSensor.KinectSensors.Count > 0)
                {
                    this.btnStream.Text = "Stop";

                    kSensor = KinectSensor.KinectSensors[0];

                    this.lblStatusValue.Text = "Connected";

                    axWindowsMediaPlayer1.URL = "C:\\Users\\Songs\\Shambhu_Sutaya.mp3";
                }
                kSensor.Start();
                iskinectDisconnected = false;

                this.lblConnectionIdValue.Text = kSensor.DeviceConnectionId;

                kSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);

                kSensor.DepthStream.Enable();

                kSensor.AllFramesReady += KSensor_AllFramesReady;

                kSensor.SkeletonStream.Enable();

                kSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;
            }
            else
            {
                if (kSensor != null && kSensor.IsRunning && btnStream.Text == "Stop")
                {
                    kSensor.Stop();

                    iskinectDisconnected = true;

                    serialPort1.WriteLine(Convert.ToString(-500));
                    iteration = 0;
                    this.btnStream.Text = "Start";

                    this.lblStatusValue.Text = "Disconnected";

                }
            }
        }
    }
}
