using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;

namespace TestiSerial
{
    public partial class Form1 : Form
    {
        int J1newSteps;
        int J2newSteps;
        int J3newSteps;
        int J4newSteps;
        int J5newSteps;
        int J6newSteps;

        int speedVal;
        int accValue;

        bool J1jogging;

        private static System.Timers.Timer jogTimer;


        public Form1()
        {
            InitializeComponent();
            disconnect.Enabled = false;
            comPortStatus.ForeColor = Color.Red;

            J1Box.Text = "0";
            J2Box.Text = "0";
            J3Box.Text = "0";
            J4Box.Text = "0";
            J5Box.Text = "0";
            J6Box.Text = "0";
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                disconnect.Enabled = true;
                connect.Enabled = false;
                comPortStatus.Text = "ON";
                comPortStatus.ForeColor = Color.Green;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                disconnect.Enabled = false;
                connect.Enabled = true;
                comPortStatus.Text = "OFF";
                comPortStatus.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void sendData_Click(object sender, EventArgs e)
        {

            J1newSteps = Convert.ToInt32(J1Box.Text);
            J2newSteps = Convert.ToInt32(J2Box.Text);
            J3newSteps = Convert.ToInt32(J3Box.Text);
            J4newSteps = Convert.ToInt32(J4Box.Text);
            J5newSteps = Convert.ToInt32(J5Box.Text);
            J6newSteps = Convert.ToInt32(J6Box.Text);
            speedVal = speedBar.Value;
            accValue = accelerationBar.Value;

            if (serialPort1.IsOpen)
            {
                string dataOut = "drive" + "," + J1newSteps + "," + J2newSteps + "," + J3newSteps + "," + J4newSteps + "," + J5newSteps + "," + J6newSteps + "," + speedVal + "," + accValue;
                serialPort1.WriteLine(dataOut);
            }
        }

        private void J1MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            string dataOut = "jogJ1-";
        }

        private void J1MinusBtn_MouseUp(object sender, MouseEventArgs e)
        {
            string dataOut = "stop";
        }
    }
}
