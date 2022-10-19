using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestiSerial
{
    public partial class Form1 : Form
    {
        string dataOut;

        public Form1()
        {
            InitializeComponent();
            disconnect.Enabled = false;
            comPortStatus.ForeColor = Color.Red;
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
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                disconnect.Enabled = false;
                connect.Enabled = true;
                comPortStatus.Text = "OFF";
                comPortStatus.ForeColor = Color.Red;
            }
        }

        private void stepperOn_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkBox1.Checked)
                {
                    serialPort1.WriteLine("+");
                }
                else
                {
                    serialPort1.WriteLine("-");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void stepperOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("OFF");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOut = tBox.Text;
                serialPort1.WriteLine(dataOut);
                tBox.Clear();
            }
        }

        private void stepBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void stepBtn_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("OFF");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("OFF");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
