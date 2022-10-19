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

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                string dataOut = "driveAngles" + "," + J1Box.Text + "," + J2Box.Text + "," + J3Box.Text + "," + J4Box.Text + "," + J5Box.Text + "," + J6Box.Text;
                serialPort1.WriteLine(dataOut);
            }
        }

        private void J1MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J1-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J1PlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J1+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void J2MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J2-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J2PlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J2+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J3MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J3-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J3PlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J3+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J4MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J4-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J4PlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J4+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J5MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J5-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J5PlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J5+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J6MinusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J6-");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J6PlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("J6+");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void J1MinusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J1PlusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J2MinusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J2PlusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J3MinusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J3PlusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J4MinusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J4PlusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J5MinusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J5PlusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J6MinusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void J6PlusBtn_MouseUp(object sender, MouseEventArgs e)
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

        private void checkJ1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkJ1.Checked)
            {
                try
                {
                    serialPort1.WriteLine("J1Enable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("J1Disable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void checkJ2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ2.Checked)
            {
                try
                {
                    serialPort1.WriteLine("J2Enable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("J2Disable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void checkJ3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ3.Checked)
            {
                try
                {
                    serialPort1.WriteLine("J3Enable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("J3Disable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void checkJ4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ4.Checked)
            {
                try
                {
                    serialPort1.WriteLine("J4Enable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("J4Disable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void checkJ5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ5.Checked)
            {
                try
                {
                    serialPort1.WriteLine("J5Enable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("J5Disable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void checkJ6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJ6.Checked)
            {
                try
                {
                    serialPort1.WriteLine("J6Enable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("J6Disable");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void speedBar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("s"+speedBar.Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void accelerationBar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("a" + accelerationBar.Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calJ1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calJ1");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calJ2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calJ2");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calJ3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calJ3");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calJ4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calJ4");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calJ5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calJ5");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calJ6_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calJ6");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calAll_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("calAll");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
