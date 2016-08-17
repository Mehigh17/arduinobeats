using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace ArduinoBeats
{
    public partial class Form1 : Form
    {

        private SerialPort port;
        private Timer timer;
        private MMDevice device;

        private float soundThreshold = 0.02f;
        private int refreshRate = 5; // ms

        public Form1()
        {
            InitializeComponent();

            portsBox.Items.AddRange(SerialPort.GetPortNames());
            portsBox.SelectedIndex = 0;
            portsBox.SelectedIndexChanged += PortsBox_SelectedIndexChanged;

            device = new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = refreshRate;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float audioLevel = device.AudioMeterInformation.MasterPeakValue;

            if (audioLevel < soundThreshold)
                return; // Ignore really small values that would actually keep spamming your port and keep the led at low voltage while the sound is actually high

            port.Write(audioLevel.ToString());
            if(soundLevelCheckbox.Checked)
            {
                print(audioLevel.ToString());
            }
        }

        private void PortsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(port != null && port.IsOpen)
            {
                port.Close();
            }

            port = new SerialPort(portsBox.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
            ClosePort();
        }

        private void portswitchButton_Click(object sender, EventArgs e)
        {
            if(port != null && port.IsOpen)
            {
                ClosePort();
            } else
            {
                OpenPort();
            }
        }

        void ClosePort()
        {
            timer.Stop();
            if (port != null && port.IsOpen)
            {
                port.Write("0.0");
                port.Close();
                print("Port closed.");
            }
            portswitchButton.Text = "Open Port";
        }

        void OpenPort()
        {
            try
            {
                port.Open();
                timer.Start();

                print("Port opened on " + portsBox.SelectedItem.ToString());
                print("Remember to upload the build on Arduino, also prepare your pins and LEDs before starting!");
                portswitchButton.Text = "Close Port";
            }
            catch (NullReferenceException)
            {
                print("A nasty exception occured...");
            }
        }

        void print(string text)
        {
            consoleTextBox.AppendText(string.Format("{0}\n", text));
            consoleTextBox.ScrollToCaret();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosePort();
        }
    }
}
