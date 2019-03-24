using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.Runtime.InteropServices;
using System.Collections.Concurrent; // ConcurrentQueue

namespace Mbed_GUI
{
    public partial class Form1 : Form
    {
        string RecvData = String.Empty;
        SerialPort sPort = new SerialPort();
        C_InofComPort sPortInfo = new C_InofComPort();
        ConcurrentQueue<string> cq = new ConcurrentQueue<string>();

        delegate void EnQCallback(string text);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);

        public Form1()
        {
            InitializeComponent();

            sPortInfo.init_Win32DeviceMgmt();
            
            sPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived_Cb);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            init_DevConnection_Tab();

        }

        //
        // Data Receive
        //
        private void EnQText(string _text)
        {

            //cq.Enqueue(_text);
            rtbDevLog.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + _text + "\n" + rtbDevLog.Text;
            

        }

        private void DataReceived_Cb(object sender, SerialDataReceivedEventArgs e)
        {
            RecvData = sPort.ReadExisting();
            if (RecvData != String.Empty)
            {
                this.BeginInvoke(new EnQCallback(EnQText), new object[] { RecvData });
            }
        }


        //
        // Data Send
        //
        private void DataSend(string _s)
        {   
            rtbDevLog.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + _s + "\n" + rtbDevLog.Text;
            try
            {
                sPort.Write(_s);
            }
            catch
            {

            }
        }

        //
        // Device Connect Page
        //
        private void init_DevConnection_Tab()
        {
            combo_DevSPortDataBit.Items.AddRange(new object[] { "7", "8" });
            combo_DevSPortStopBit.Items.AddRange(new object[] { "One", "OnePointFive", "Two" });
            combo_DevSPortParity.Items.AddRange(new object[] { "None", "Even", "Mark", "Odd", "Space" });
            combo_DevSPortRate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            combo_DevSPortHandShaking.Items.AddRange(new object[] { "None", "XOnXOff", "ReqToSend", "ReqToSendXOnXOff" });

            combo_DevSPortRate.SelectedIndex = 4;
            combo_DevSPortParity.SelectedIndex = 0;
            combo_DevSPortDataBit.SelectedIndex = 1;
            combo_DevSPortStopBit.SelectedIndex = 0;
            combo_DevSPortHandShaking.SelectedIndex = 0;

            btnDevUpdate_Click(new object(), new EventArgs());
        }

        private void btnDevUpdate_Click(object sender, EventArgs e)
        {
            string prefDev = null;
            List<C_InofComPort.DeviceInfo> lSPortInfo = sPortInfo.GetAllCOMPorts();

            if(lSPortInfo.Count == 0)
            {
                combo_DevSPort.Items.Clear();
                label_DevConnected.Text = "Not Connected";
                rtbDevLog.Text = "No Serial Port Detected..\n";
                return;
            }
            
            rtbDevLog.Text = "";
            combo_DevSPort.Items.Clear();
            foreach (C_InofComPort.DeviceInfo sp in lSPortInfo)
            {
                combo_DevSPort.Items.Add(sp.name);
                rtbDevLog.Text = "  Port Name: " + sp.name + " / Bus Description: " + sp.bus_description + "\n" + rtbDevLog.Text;
                if(sp.bus_description == tboxDevPrefName.Text.Trim())
                {
                    prefDev = sp.name;
                }
            }
            rtbDevLog.Text = "Searched Serial Port(s)\n" + rtbDevLog.Text;

            if (prefDev != null)
                combo_DevSPort.SelectedItem = prefDev;
            else
                combo_DevSPort.SelectedIndex = 0;
        }

        private void SetComponent_As_Connected(Boolean _en)
        {
            btnDevUpdate.Enabled = !_en;
            combo_DevSPort.Enabled = !_en;
            tboxDevPrefName.Enabled = !_en;
            combo_DevSPortRate.Enabled = !_en;
            combo_DevSPortRate.Enabled = !_en;
            combo_DevSPortDataBit.Enabled = !_en;
            combo_DevSPortParity.Enabled = !_en;
            combo_DevSPortStopBit.Enabled = !_en;
            combo_DevSPortHandShaking.Enabled = !_en;
            
            btnDevSend.Enabled = _en;

            if (_en)
            {
                btnDevConnect.Text = "Disconnect";
                label_DevConnected.Text = "Connected";
                label_DevConnected.ForeColor = Color.Blue;

            }
            else
            {
                btnDevConnect.Text = "Connect";
                label_DevConnected.Text = "Not Connected";
                label_DevConnected.ForeColor = Color.Red;

            }

        }

        private void btnDevConnect_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(btn.Text == "Connect")
            {
                sPort.PortName = Convert.ToString(combo_DevSPort.Text);
                sPort.BaudRate = Convert.ToInt32(combo_DevSPortRate.Text);
                sPort.DataBits = Convert.ToInt16(combo_DevSPortDataBit.Text);
                sPort.Parity = (Parity)Enum.Parse(typeof(Parity), combo_DevSPortParity.Text);
                sPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combo_DevSPortStopBit.Text);
                sPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), combo_DevSPortHandShaking.Text);
                try
                {
                    sPort.Open();
                    SetComponent_As_Connected(true);
                    rtbDevLog.Text = DateTime.Now.ToString("h:mm:ss tt") + ": " + "Success to Open the Serial Port: " + sPort.PortName + "\n";
                }
                catch
                {
                    SetComponent_As_Connected(false);
                    rtbDevLog.Text = "Error to Open the Serial Port: " + sPort.PortName + "\n";
                }
            }
            else
            {
                SetComponent_As_Connected(false);
                rtbDevLog.Text = DateTime.Now.ToString("h:mm:ss tt") + ": " + "Success to Close the Serial Port \n" + rtbDevLog.Text;

                try
                {
                    sPort.Close();
                }
                catch
                {

                }
            }
            
        }

        private void btnLMenuConnect_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(this.tabPage_Connect.Name);
        }

        private void btnDevSend_Click(object sender, EventArgs e)
        {
            if(label_DevConnected.Text == "Connected")
            {
                DataSend(textBox_DevSendData.Text + '\n');
            }
        }


        //
        // Device Connect Page
        //



    }

}
