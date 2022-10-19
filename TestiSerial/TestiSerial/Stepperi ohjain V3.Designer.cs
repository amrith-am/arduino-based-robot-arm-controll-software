namespace TestiSerial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendData = new System.Windows.Forms.Button();
            this.J6Box = new System.Windows.Forms.TextBox();
            this.J5Box = new System.Windows.Forms.TextBox();
            this.J4Box = new System.Windows.Forms.TextBox();
            this.J3Box = new System.Windows.Forms.TextBox();
            this.J2Box = new System.Windows.Forms.TextBox();
            this.J1Box = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comPortStatus = new System.Windows.Forms.Label();
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.examplePicture = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.calAll = new System.Windows.Forms.Button();
            this.calJ6 = new System.Windows.Forms.Button();
            this.calJ5 = new System.Windows.Forms.Button();
            this.calJ4 = new System.Windows.Forms.Button();
            this.calJ3 = new System.Windows.Forms.Button();
            this.calJ2 = new System.Windows.Forms.Button();
            this.calJ1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveWP1 = new System.Windows.Forms.Button();
            this.SaveWP2 = new System.Windows.Forms.Button();
            this.PLAY = new System.Windows.Forms.Button();
            this.SaveWP3 = new System.Windows.Forms.Button();
            this.checkJ1 = new System.Windows.Forms.CheckBox();
            this.checkJ2 = new System.Windows.Forms.CheckBox();
            this.checkJ3 = new System.Windows.Forms.CheckBox();
            this.checkJ4 = new System.Windows.Forms.CheckBox();
            this.checkJ5 = new System.Windows.Forms.CheckBox();
            this.checkJ6 = new System.Windows.Forms.CheckBox();
            this.enableAll = new System.Windows.Forms.Button();
            this.disableAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.zBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.zbar = new System.Windows.Forms.TrackBar();
            this.ybar = new System.Windows.Forms.TrackBar();
            this.xbar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Wifi = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.J1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.j1bar = new System.Windows.Forms.TrackBar();
            this.j2bar = new System.Windows.Forms.TrackBar();
            this.j3bar = new System.Windows.Forms.TrackBar();
            this.j4bar = new System.Windows.Forms.TrackBar();
            this.j5bar = new System.Windows.Forms.TrackBar();
            this.j6bar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePicture)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ybar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbar)).BeginInit();
            this.Wifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.j1bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j3bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j4bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j5bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j6bar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnect);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections (Serial + BT)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.Color.Red;
            this.disconnect.Location = new System.Drawing.Point(7, 78);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(121, 23);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.Lime;
            this.connect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connect.Location = new System.Drawing.Point(7, 48);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(121, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.j6bar);
            this.groupBox3.Controls.Add(this.j5bar);
            this.groupBox3.Controls.Add(this.j4bar);
            this.groupBox3.Controls.Add(this.j3bar);
            this.groupBox3.Controls.Add(this.j2bar);
            this.groupBox3.Controls.Add(this.j1bar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.J1);
            this.groupBox3.Controls.Add(this.sendData);
            this.groupBox3.Controls.Add(this.J6Box);
            this.groupBox3.Controls.Add(this.J5Box);
            this.groupBox3.Controls.Add(this.J4Box);
            this.groupBox3.Controls.Add(this.J3Box);
            this.groupBox3.Controls.Add(this.J2Box);
            this.groupBox3.Controls.Add(this.J1Box);
            this.groupBox3.Location = new System.Drawing.Point(510, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 349);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jog joints";
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(33, 266);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(195, 55);
            this.sendData.TabIndex = 3;
            this.sendData.Text = "Drive joints to values";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // J6Box
            // 
            this.J6Box.Location = new System.Drawing.Point(188, 206);
            this.J6Box.Name = "J6Box";
            this.J6Box.Size = new System.Drawing.Size(72, 20);
            this.J6Box.TabIndex = 20;
            this.J6Box.TextChanged += new System.EventHandler(this.J6Box_TextChanged);
            // 
            // J5Box
            // 
            this.J5Box.Location = new System.Drawing.Point(187, 170);
            this.J5Box.Name = "J5Box";
            this.J5Box.Size = new System.Drawing.Size(72, 20);
            this.J5Box.TabIndex = 19;
            // 
            // J4Box
            // 
            this.J4Box.Location = new System.Drawing.Point(187, 134);
            this.J4Box.Name = "J4Box";
            this.J4Box.Size = new System.Drawing.Size(72, 20);
            this.J4Box.TabIndex = 18;
            // 
            // J3Box
            // 
            this.J3Box.Location = new System.Drawing.Point(187, 98);
            this.J3Box.Name = "J3Box";
            this.J3Box.Size = new System.Drawing.Size(72, 20);
            this.J3Box.TabIndex = 11;
            this.J3Box.TextChanged += new System.EventHandler(this.J3Box_TextChanged);
            // 
            // J2Box
            // 
            this.J2Box.Location = new System.Drawing.Point(187, 62);
            this.J2Box.Name = "J2Box";
            this.J2Box.Size = new System.Drawing.Size(72, 20);
            this.J2Box.TabIndex = 9;
            this.J2Box.TextChanged += new System.EventHandler(this.J2Box_TextChanged);
            // 
            // J1Box
            // 
            this.J1Box.Location = new System.Drawing.Point(187, 27);
            this.J1Box.Name = "J1Box";
            this.J1Box.Size = new System.Drawing.Size(72, 20);
            this.J1Box.TabIndex = 2;
            this.J1Box.Text = "0";
            this.J1Box.TextChanged += new System.EventHandler(this.J1Box_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comPortStatus);
            this.groupBox5.Location = new System.Drawing.Point(13, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 53);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Connection status";
            // 
            // comPortStatus
            // 
            this.comPortStatus.AutoSize = true;
            this.comPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comPortStatus.Location = new System.Drawing.Point(33, 16);
            this.comPortStatus.Name = "comPortStatus";
            this.comPortStatus.Size = new System.Drawing.Size(72, 31);
            this.comPortStatus.TabIndex = 0;
            this.comPortStatus.Text = "OFF";
            this.comPortStatus.Click += new System.EventHandler(this.comPortStatus_Click);
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.label1);
            this.Parameters.Controls.Add(this.speedBar);
            this.Parameters.Location = new System.Drawing.Point(515, 371);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(151, 89);
            this.Parameters.TabIndex = 6;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed";
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 1;
            this.speedBar.Location = new System.Drawing.Point(7, 37);
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(121, 45);
            this.speedBar.TabIndex = 0;
            this.speedBar.Value = 5;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // examplePicture
            // 
            this.examplePicture.Image = ((System.Drawing.Image)(resources.GetObject("examplePicture.Image")));
            this.examplePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("examplePicture.InitialImage")));
            this.examplePicture.Location = new System.Drawing.Point(6, 19);
            this.examplePicture.Name = "examplePicture";
            this.examplePicture.Size = new System.Drawing.Size(317, 670);
            this.examplePicture.TabIndex = 7;
            this.examplePicture.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.examplePicture);
            this.groupBox6.Location = new System.Drawing.Point(172, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(332, 693);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.calAll);
            this.groupBox7.Controls.Add(this.calJ6);
            this.groupBox7.Controls.Add(this.calJ5);
            this.groupBox7.Controls.Add(this.calJ4);
            this.groupBox7.Controls.Add(this.calJ3);
            this.groupBox7.Controls.Add(this.calJ2);
            this.groupBox7.Controls.Add(this.calJ1);
            this.groupBox7.Location = new System.Drawing.Point(5, 236);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(145, 253);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calibrate joints";
            // 
            // calAll
            // 
            this.calAll.Location = new System.Drawing.Point(10, 204);
            this.calAll.Name = "calAll";
            this.calAll.Size = new System.Drawing.Size(119, 49);
            this.calAll.TabIndex = 6;
            this.calAll.Text = "Auto calibrate all";
            this.calAll.UseVisualStyleBackColor = true;
            this.calAll.Click += new System.EventHandler(this.calAll_Click);
            // 
            // calJ6
            // 
            this.calJ6.Location = new System.Drawing.Point(10, 170);
            this.calJ6.Name = "calJ6";
            this.calJ6.Size = new System.Drawing.Size(119, 23);
            this.calJ6.TabIndex = 5;
            this.calJ6.Text = "Calibrate J6";
            this.calJ6.UseVisualStyleBackColor = true;
            this.calJ6.Click += new System.EventHandler(this.calJ6_Click);
            // 
            // calJ5
            // 
            this.calJ5.Location = new System.Drawing.Point(10, 140);
            this.calJ5.Name = "calJ5";
            this.calJ5.Size = new System.Drawing.Size(119, 23);
            this.calJ5.TabIndex = 4;
            this.calJ5.Text = "Calibrate J5";
            this.calJ5.UseVisualStyleBackColor = true;
            this.calJ5.Click += new System.EventHandler(this.calJ5_Click);
            // 
            // calJ4
            // 
            this.calJ4.Location = new System.Drawing.Point(10, 110);
            this.calJ4.Name = "calJ4";
            this.calJ4.Size = new System.Drawing.Size(119, 23);
            this.calJ4.TabIndex = 3;
            this.calJ4.Text = "Calibrate J4";
            this.calJ4.UseVisualStyleBackColor = true;
            this.calJ4.Click += new System.EventHandler(this.calJ4_Click);
            // 
            // calJ3
            // 
            this.calJ3.Location = new System.Drawing.Point(10, 80);
            this.calJ3.Name = "calJ3";
            this.calJ3.Size = new System.Drawing.Size(119, 23);
            this.calJ3.TabIndex = 2;
            this.calJ3.Text = "Calibrate J3";
            this.calJ3.UseVisualStyleBackColor = true;
            this.calJ3.Click += new System.EventHandler(this.calJ3_Click);
            // 
            // calJ2
            // 
            this.calJ2.Location = new System.Drawing.Point(8, 50);
            this.calJ2.Name = "calJ2";
            this.calJ2.Size = new System.Drawing.Size(121, 23);
            this.calJ2.TabIndex = 1;
            this.calJ2.Text = "Calibrate J2";
            this.calJ2.UseVisualStyleBackColor = true;
            this.calJ2.Click += new System.EventHandler(this.calJ2_Click);
            // 
            // calJ1
            // 
            this.calJ1.Location = new System.Drawing.Point(7, 20);
            this.calJ1.Name = "calJ1";
            this.calJ1.Size = new System.Drawing.Size(122, 23);
            this.calJ1.TabIndex = 0;
            this.calJ1.Text = "Calibrate J1";
            this.calJ1.UseVisualStyleBackColor = true;
            this.calJ1.Click += new System.EventHandler(this.calJ1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SaveWP1
            // 
            this.SaveWP1.Location = new System.Drawing.Point(703, 371);
            this.SaveWP1.Name = "SaveWP1";
            this.SaveWP1.Size = new System.Drawing.Size(75, 23);
            this.SaveWP1.TabIndex = 10;
            this.SaveWP1.Text = "Save WP1";
            this.SaveWP1.UseVisualStyleBackColor = true;
            this.SaveWP1.Click += new System.EventHandler(this.SaveWP1_Click);
            // 
            // SaveWP2
            // 
            this.SaveWP2.Location = new System.Drawing.Point(703, 400);
            this.SaveWP2.Name = "SaveWP2";
            this.SaveWP2.Size = new System.Drawing.Size(75, 23);
            this.SaveWP2.TabIndex = 11;
            this.SaveWP2.Text = "Save WP2";
            this.SaveWP2.UseVisualStyleBackColor = true;
            this.SaveWP2.Click += new System.EventHandler(this.SaveWP2_Click);
            // 
            // PLAY
            // 
            this.PLAY.Location = new System.Drawing.Point(703, 466);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(75, 23);
            this.PLAY.TabIndex = 12;
            this.PLAY.Text = "PLAY";
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // SaveWP3
            // 
            this.SaveWP3.Location = new System.Drawing.Point(703, 429);
            this.SaveWP3.Name = "SaveWP3";
            this.SaveWP3.Size = new System.Drawing.Size(75, 23);
            this.SaveWP3.TabIndex = 13;
            this.SaveWP3.Text = "Save WP3";
            this.SaveWP3.UseVisualStyleBackColor = true;
            this.SaveWP3.Click += new System.EventHandler(this.SaveWP3_Click);
            // 
            // checkJ1
            // 
            this.checkJ1.AutoSize = true;
            this.checkJ1.Location = new System.Drawing.Point(17, 25);
            this.checkJ1.Name = "checkJ1";
            this.checkJ1.Size = new System.Drawing.Size(73, 17);
            this.checkJ1.TabIndex = 2;
            this.checkJ1.Text = "Enable J1";
            this.checkJ1.UseVisualStyleBackColor = true;
            this.checkJ1.CheckedChanged += new System.EventHandler(this.checkJ1_CheckedChanged);
            // 
            // checkJ2
            // 
            this.checkJ2.AutoSize = true;
            this.checkJ2.Location = new System.Drawing.Point(17, 48);
            this.checkJ2.Name = "checkJ2";
            this.checkJ2.Size = new System.Drawing.Size(73, 17);
            this.checkJ2.TabIndex = 3;
            this.checkJ2.Text = "Enable J2";
            this.checkJ2.UseVisualStyleBackColor = true;
            this.checkJ2.CheckedChanged += new System.EventHandler(this.checkJ2_CheckedChanged);
            // 
            // checkJ3
            // 
            this.checkJ3.AutoSize = true;
            this.checkJ3.Location = new System.Drawing.Point(17, 66);
            this.checkJ3.Name = "checkJ3";
            this.checkJ3.Size = new System.Drawing.Size(73, 17);
            this.checkJ3.TabIndex = 4;
            this.checkJ3.Text = "Enable J3";
            this.checkJ3.UseVisualStyleBackColor = true;
            this.checkJ3.CheckedChanged += new System.EventHandler(this.checkJ3_CheckedChanged);
            // 
            // checkJ4
            // 
            this.checkJ4.AutoSize = true;
            this.checkJ4.Location = new System.Drawing.Point(17, 84);
            this.checkJ4.Name = "checkJ4";
            this.checkJ4.Size = new System.Drawing.Size(73, 17);
            this.checkJ4.TabIndex = 5;
            this.checkJ4.Text = "Enable J4";
            this.checkJ4.UseVisualStyleBackColor = true;
            this.checkJ4.CheckedChanged += new System.EventHandler(this.checkJ4_CheckedChanged);
            // 
            // checkJ5
            // 
            this.checkJ5.AutoSize = true;
            this.checkJ5.Location = new System.Drawing.Point(17, 103);
            this.checkJ5.Name = "checkJ5";
            this.checkJ5.Size = new System.Drawing.Size(73, 17);
            this.checkJ5.TabIndex = 6;
            this.checkJ5.Text = "Enable J5";
            this.checkJ5.UseVisualStyleBackColor = true;
            this.checkJ5.CheckedChanged += new System.EventHandler(this.checkJ5_CheckedChanged);
            // 
            // checkJ6
            // 
            this.checkJ6.AutoSize = true;
            this.checkJ6.Location = new System.Drawing.Point(17, 122);
            this.checkJ6.Name = "checkJ6";
            this.checkJ6.Size = new System.Drawing.Size(73, 17);
            this.checkJ6.TabIndex = 7;
            this.checkJ6.Text = "Enable J6";
            this.checkJ6.UseVisualStyleBackColor = true;
            this.checkJ6.CheckedChanged += new System.EventHandler(this.checkJ6_CheckedChanged);
            // 
            // enableAll
            // 
            this.enableAll.Location = new System.Drawing.Point(11, 152);
            this.enableAll.Name = "enableAll";
            this.enableAll.Size = new System.Drawing.Size(120, 25);
            this.enableAll.TabIndex = 8;
            this.enableAll.Text = "Enable all";
            this.enableAll.UseVisualStyleBackColor = true;
            this.enableAll.Click += new System.EventHandler(this.enableAll_Click);
            // 
            // disableAll
            // 
            this.disableAll.Location = new System.Drawing.Point(11, 184);
            this.disableAll.Name = "disableAll";
            this.disableAll.Size = new System.Drawing.Size(118, 23);
            this.disableAll.TabIndex = 9;
            this.disableAll.Text = "Disable all";
            this.disableAll.UseVisualStyleBackColor = true;
            this.disableAll.Click += new System.EventHandler(this.disableAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disableAll);
            this.groupBox2.Controls.Add(this.enableAll);
            this.groupBox2.Controls.Add(this.checkJ6);
            this.groupBox2.Controls.Add(this.checkJ5);
            this.groupBox2.Controls.Add(this.checkJ4);
            this.groupBox2.Controls.Add(this.checkJ3);
            this.groupBox2.Controls.Add(this.checkJ2);
            this.groupBox2.Controls.Add(this.checkJ1);
            this.groupBox2.Location = new System.Drawing.Point(5, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stepper ON/OFF";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.zBox);
            this.groupBox4.Controls.Add(this.yBox);
            this.groupBox4.Controls.Add(this.xBox);
            this.groupBox4.Controls.Add(this.zbar);
            this.groupBox4.Controls.Add(this.ybar);
            this.groupBox4.Controls.Add(this.xbar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(515, 502);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 204);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inverse Kinematics";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // zBox
            // 
            this.zBox.Location = new System.Drawing.Point(176, 113);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(47, 20);
            this.zBox.TabIndex = 18;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(176, 68);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(47, 20);
            this.yBox.TabIndex = 17;
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(176, 24);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(47, 20);
            this.xBox.TabIndex = 16;
            // 
            // zbar
            // 
            this.zbar.Location = new System.Drawing.Point(45, 114);
            this.zbar.Minimum = 1;
            this.zbar.Name = "zbar";
            this.zbar.Size = new System.Drawing.Size(124, 45);
            this.zbar.TabIndex = 15;
            this.zbar.Value = 1;
            this.zbar.Scroll += new System.EventHandler(this.zbar_Scroll);
            // 
            // ybar
            // 
            this.ybar.Location = new System.Drawing.Point(45, 69);
            this.ybar.Minimum = 1;
            this.ybar.Name = "ybar";
            this.ybar.Size = new System.Drawing.Size(124, 45);
            this.ybar.TabIndex = 14;
            this.ybar.Value = 1;
            this.ybar.Scroll += new System.EventHandler(this.ybar_Scroll);
            // 
            // xbar
            // 
            this.xbar.LargeChange = 1;
            this.xbar.Location = new System.Drawing.Point(45, 25);
            this.xbar.Minimum = 1;
            this.xbar.Name = "xbar";
            this.xbar.Size = new System.Drawing.Size(124, 45);
            this.xbar.TabIndex = 13;
            this.xbar.Value = 1;
            this.xbar.Scroll += new System.EventHandler(this.xbar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            // 
            // Wifi
            // 
            this.Wifi.Controls.Add(this.comboBox2);
            this.Wifi.Location = new System.Drawing.Point(13, 125);
            this.Wifi.Name = "Wifi";
            this.Wifi.Size = new System.Drawing.Size(144, 46);
            this.Wifi.TabIndex = 16;
            this.Wifi.TabStop = false;
            this.Wifi.Text = "Wifi";
            this.Wifi.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // J1
            // 
            this.J1.AutoSize = true;
            this.J1.Location = new System.Drawing.Point(21, 34);
            this.J1.Name = "J1";
            this.J1.Size = new System.Drawing.Size(18, 13);
            this.J1.TabIndex = 21;
            this.J1.Text = "J1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "J2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "J3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "J4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "J5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "J6";
            // 
            // j1bar
            // 
            this.j1bar.Location = new System.Drawing.Point(45, 27);
            this.j1bar.Maximum = 180;
            this.j1bar.Name = "j1bar";
            this.j1bar.Size = new System.Drawing.Size(136, 45);
            this.j1bar.TabIndex = 27;
            this.j1bar.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // j2bar
            // 
            this.j2bar.Location = new System.Drawing.Point(45, 62);
            this.j2bar.Maximum = 130;
            this.j2bar.Name = "j2bar";
            this.j2bar.Size = new System.Drawing.Size(136, 45);
            this.j2bar.TabIndex = 28;
            this.j2bar.Scroll += new System.EventHandler(this.j2bar_Scroll);
            // 
            // j3bar
            // 
            this.j3bar.Location = new System.Drawing.Point(45, 97);
            this.j3bar.Maximum = 150;
            this.j3bar.Name = "j3bar";
            this.j3bar.Size = new System.Drawing.Size(136, 45);
            this.j3bar.TabIndex = 29;
            this.j3bar.Scroll += new System.EventHandler(this.j3bar_Scroll);
            // 
            // j4bar
            // 
            this.j4bar.Location = new System.Drawing.Point(45, 132);
            this.j4bar.Maximum = 180;
            this.j4bar.Name = "j4bar";
            this.j4bar.Size = new System.Drawing.Size(136, 45);
            this.j4bar.TabIndex = 30;
            this.j4bar.Scroll += new System.EventHandler(this.j4bar_Scroll);
            // 
            // j5bar
            // 
            this.j5bar.Location = new System.Drawing.Point(45, 167);
            this.j5bar.Maximum = 150;
            this.j5bar.Name = "j5bar";
            this.j5bar.Size = new System.Drawing.Size(136, 45);
            this.j5bar.TabIndex = 31;
            this.j5bar.Scroll += new System.EventHandler(this.j5bar_Scroll);
            // 
            // j6bar
            // 
            this.j6bar.Location = new System.Drawing.Point(45, 202);
            this.j6bar.Maximum = 140;
            this.j6bar.Minimum = 80;
            this.j6bar.Name = "j6bar";
            this.j6bar.Size = new System.Drawing.Size(136, 45);
            this.j6bar.TabIndex = 32;
            this.j6bar.Value = 80;
            this.j6bar.Scroll += new System.EventHandler(this.j6bar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(786, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Wifi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SaveWP3);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.SaveWP2);
            this.Controls.Add(this.SaveWP1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "RoboDroid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePicture)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ybar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbar)).EndInit();
            this.Wifi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.j1bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j3bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j4bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j5bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j6bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label comPortStatus;
        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.PictureBox examplePicture;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button calAll;
        private System.Windows.Forms.Button calJ6;
        private System.Windows.Forms.Button calJ5;
        private System.Windows.Forms.Button calJ4;
        private System.Windows.Forms.Button calJ3;
        private System.Windows.Forms.Button calJ2;
        private System.Windows.Forms.Button calJ1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SaveWP1;
        private System.Windows.Forms.Button SaveWP2;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Button SaveWP3;
        private System.Windows.Forms.CheckBox checkJ1;
        private System.Windows.Forms.CheckBox checkJ2;
        private System.Windows.Forms.CheckBox checkJ3;
        private System.Windows.Forms.CheckBox checkJ4;
        private System.Windows.Forms.CheckBox checkJ5;
        private System.Windows.Forms.CheckBox checkJ6;
        private System.Windows.Forms.Button enableAll;
        private System.Windows.Forms.Button disableAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar zbar;
        private System.Windows.Forms.TrackBar ybar;
        private System.Windows.Forms.TrackBar xbar;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox J6Box;
        private System.Windows.Forms.TextBox J5Box;
        private System.Windows.Forms.TextBox J4Box;
        private System.Windows.Forms.TextBox J3Box;
        private System.Windows.Forms.TextBox J2Box;
        private System.Windows.Forms.TextBox J1Box;
        private System.Windows.Forms.GroupBox Wifi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar j6bar;
        private System.Windows.Forms.TrackBar j5bar;
        private System.Windows.Forms.TrackBar j4bar;
        private System.Windows.Forms.TrackBar j3bar;
        private System.Windows.Forms.TrackBar j2bar;
        private System.Windows.Forms.TrackBar j1bar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label J1;
    }
}

