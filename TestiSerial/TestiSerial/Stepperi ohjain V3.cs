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
        int xnewSteps;
        int ynewSteps;
        int znewSteps;

        int J1WP1;
        int J2WP1;
        int J3WP1;
        int J4WP1;
        int J5WP1;
        int J6WP1;
        int WP1speedVal;
        int WP1accVal;

        int J1WP2;
        int J2WP2;
        int J3WP2;
        int J4WP2;
        int J5WP2;
        int J6WP2;
        int WP2speedVal;
        int WP2accVal;

        String testVal;

        int speedVal;
        int accValue;
        int xval;
        int yval;
        int zval;
        int j1val;
        int j2val;
        int j3val;
        int j4val;
        int j5val;
        int j6val;
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
            J6Box.Text = "80";
            xBox.Text = "0";
            yBox.Text = "0";
            zBox.Text = "0";
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
                timer1.Start();
                MessageBox.Show("Port Connected");
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
                timer1.Stop();
                MessageBox.Show("Port Disconnected");
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


            if (serialPort1.IsOpen)
            {
                string dataOut = "drive" + "," + J1newSteps + "," + J2newSteps + "," + J3newSteps + "," + J4newSteps + "," + J5newSteps + "," + J6newSteps + "," + speedVal;
                serialPort1.WriteLine(dataOut);

            }
        }

        private void calJ1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibration1";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void calJ2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibration2";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void calJ3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibration3";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void calJ4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibration4";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void calJ5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibration5";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void calJ6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibration6";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void calAll_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataOut = "calibrationall";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void checkJ1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkJ1.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J1enable";
                    serialPort1.WriteLine(dataOut);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J1disable";
                    serialPort1.WriteLine(dataOut);
                }
            }
        }

        private void checkJ2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ2.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J2enable";
                    serialPort1.WriteLine(dataOut);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J2disable";
                    serialPort1.WriteLine(dataOut);
                }
            }
        }

        private void checkJ3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ3.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J3enable";
                    serialPort1.WriteLine(dataOut);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J3disable";
                    serialPort1.WriteLine(dataOut);
                }
            }
        }

        private void checkJ4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ4.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J4enable";
                    serialPort1.WriteLine(dataOut);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J4disable";
                    serialPort1.WriteLine(dataOut);
                }
            }
        }

        private void checkJ5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ5.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J5enable";
                    serialPort1.WriteLine(dataOut);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J5disable";
                    serialPort1.WriteLine(dataOut);
                }
            }
        }

        private void checkJ6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ6.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J6enable";
                    serialPort1.WriteLine(dataOut);
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    string dataOut = "J6disable";
                    serialPort1.WriteLine(dataOut);
                }
            }
        }

        private void enableAll_Click(object sender, EventArgs e)
        {
            string dataOut = "enableAll";
            serialPort1.WriteLine(dataOut);
            checkJ1.Checked = true;
            checkJ2.Checked = true;
            checkJ3.Checked = true;
            checkJ4.Checked = true;
            checkJ5.Checked = true;
            checkJ6.Checked = true;
        }

        private void disableAll_Click(object sender, EventArgs e)
        {
            string dataOut = "disableAll";
            serialPort1.WriteLine(dataOut);
            checkJ1.Checked = false;
            checkJ2.Checked = false;
            checkJ3.Checked = false;
            checkJ4.Checked = false;
            checkJ5.Checked = false;
            checkJ6.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            try
            {
                J1stepBox.ResetText();
                J1stepBox.Text = serialPort1.ReadExisting();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            */
        }

        private void SaveWP1_Click(object sender, EventArgs e)
        {
            string dataOut = "saveWP1";
            serialPort1.WriteLine(dataOut);
        }

        private void SaveWP2_Click(object sender, EventArgs e)
        {
            string dataOut = "saveWP2";
            serialPort1.WriteLine(dataOut);
        }

        private void SaveWP3_Click(object sender, EventArgs e)
        {
            string dataOut = "saveWP3";
            serialPort1.WriteLine(dataOut);
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            string dataOut = "PLAY";
            serialPort1.WriteLine(dataOut);
        }

        private void J3Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void J1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void J2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void J6Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void comPortStatus_Click(object sender, EventArgs e)
        {

        }

        private void J3MinusBtn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {

        }

        private void xbar_Scroll(object sender, EventArgs e)
        {
            xval=xbar.Value;
            string dataOut = "xval"+","+xval;
            serialPort1.WriteLine(dataOut);
        }

        private void ybar_Scroll(object sender, EventArgs e)
        {
            yval = ybar.Value;
            string dataOut = "yval" + "," + yval;
            serialPort1.WriteLine(dataOut);
        }

        private void J6MinusBtn_Click(object sender, EventArgs e)
        {

        }

        private void J1MinusBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void zbar_Scroll(object sender, EventArgs e)
        {
            zval = zbar.Value;
            string dataOut = "zval" + "," + zval;
            serialPort1.WriteLine(dataOut);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            xnewSteps = Convert.ToInt32(xBox.Text);
            ynewSteps = Convert.ToInt32(yBox.Text);
            znewSteps = Convert.ToInt32(zBox.Text);
            if (serialPort1.IsOpen)
            {
                string dataOut = "xyz" + "," + xnewSteps + "," + ynewSteps + "," + znewSteps;
                serialPort1.WriteLine(dataOut);

            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            j1val = j1bar.Value;
            string dataOut = "s1" + j1val;
            serialPort1.WriteLine(dataOut);
        }

        private void j2bar_Scroll(object sender, EventArgs e)
        {
            j2val = j2bar.Value;
            string dataOut = "s2" + j2val;
            serialPort1.WriteLine(dataOut);
        }

        private void j3bar_Scroll(object sender, EventArgs e)
        {
            j3val = j3bar.Value;
            string dataOut = "s3" + j3val;
            serialPort1.WriteLine(dataOut);
        }

        private void j4bar_Scroll(object sender, EventArgs e)
        {
            j4val = j4bar.Value;
            string dataOut = "s4" + j4val;
            serialPort1.WriteLine(dataOut);
        }

        private void j5bar_Scroll(object sender, EventArgs e)
        {
            j5val = j5bar.Value;
            string dataOut = "s5" + j5val;
            serialPort1.WriteLine(dataOut);
        }

        private void j6bar_Scroll(object sender, EventArgs e)
        {
            j6val = j6bar.Value;
            string dataOut = "s6" + j6val;
            serialPort1.WriteLine(dataOut);
        }
    }
}
