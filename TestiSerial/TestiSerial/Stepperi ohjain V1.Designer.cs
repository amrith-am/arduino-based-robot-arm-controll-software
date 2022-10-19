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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkJ6 = new System.Windows.Forms.CheckBox();
            this.checkJ5 = new System.Windows.Forms.CheckBox();
            this.checkJ4 = new System.Windows.Forms.CheckBox();
            this.checkJ3 = new System.Windows.Forms.CheckBox();
            this.checkJ2 = new System.Windows.Forms.CheckBox();
            this.checkJ1 = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.J1Box = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendData = new System.Windows.Forms.Button();
            this.J6Box = new System.Windows.Forms.TextBox();
            this.J5Box = new System.Windows.Forms.TextBox();
            this.J4Box = new System.Windows.Forms.TextBox();
            this.J6PlusBtn = new System.Windows.Forms.Button();
            this.J5PlusBtn = new System.Windows.Forms.Button();
            this.J4PlusBtn = new System.Windows.Forms.Button();
            this.J6MinusBtn = new System.Windows.Forms.Button();
            this.J5MinusBtn = new System.Windows.Forms.Button();
            this.J4MinusBtn = new System.Windows.Forms.Button();
            this.J3Box = new System.Windows.Forms.TextBox();
            this.J3PlusBtn = new System.Windows.Forms.Button();
            this.J2Box = new System.Windows.Forms.TextBox();
            this.J3MinusBtn = new System.Windows.Forms.Button();
            this.J1MinusBtn = new System.Windows.Forms.Button();
            this.J2PlusBtn = new System.Windows.Forms.Button();
            this.J1PlusBtn = new System.Windows.Forms.Button();
            this.J2MinusBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comPortStatus = new System.Windows.Forms.Label();
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.accelerationBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePicture)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.groupBox1.Text = "Connection";
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(7, 78);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(121, 23);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(7, 48);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(121, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkJ6);
            this.groupBox2.Controls.Add(this.checkJ5);
            this.groupBox2.Controls.Add(this.checkJ4);
            this.groupBox2.Controls.Add(this.checkJ3);
            this.groupBox2.Controls.Add(this.checkJ2);
            this.groupBox2.Controls.Add(this.checkJ1);
            this.groupBox2.Location = new System.Drawing.Point(13, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stepper ON/OFF";
            // 
            // checkJ6
            // 
            this.checkJ6.AutoSize = true;
            this.checkJ6.Location = new System.Drawing.Point(7, 134);
            this.checkJ6.Name = "checkJ6";
            this.checkJ6.Size = new System.Drawing.Size(73, 17);
            this.checkJ6.TabIndex = 7;
            this.checkJ6.Text = "Enable J6";
            this.checkJ6.UseVisualStyleBackColor = true;
            this.checkJ6.CheckedChanged += new System.EventHandler(this.checkJ6_CheckedChanged);
            // 
            // checkJ5
            // 
            this.checkJ5.AutoSize = true;
            this.checkJ5.Location = new System.Drawing.Point(6, 111);
            this.checkJ5.Name = "checkJ5";
            this.checkJ5.Size = new System.Drawing.Size(73, 17);
            this.checkJ5.TabIndex = 6;
            this.checkJ5.Text = "Enable J5";
            this.checkJ5.UseVisualStyleBackColor = true;
            this.checkJ5.CheckedChanged += new System.EventHandler(this.checkJ5_CheckedChanged);
            // 
            // checkJ4
            // 
            this.checkJ4.AutoSize = true;
            this.checkJ4.Location = new System.Drawing.Point(6, 88);
            this.checkJ4.Name = "checkJ4";
            this.checkJ4.Size = new System.Drawing.Size(73, 17);
            this.checkJ4.TabIndex = 5;
            this.checkJ4.Text = "Enable J4";
            this.checkJ4.UseVisualStyleBackColor = true;
            this.checkJ4.CheckedChanged += new System.EventHandler(this.checkJ4_CheckedChanged);
            // 
            // checkJ3
            // 
            this.checkJ3.AutoSize = true;
            this.checkJ3.Location = new System.Drawing.Point(6, 65);
            this.checkJ3.Name = "checkJ3";
            this.checkJ3.Size = new System.Drawing.Size(73, 17);
            this.checkJ3.TabIndex = 4;
            this.checkJ3.Text = "Enable J3";
            this.checkJ3.UseVisualStyleBackColor = true;
            this.checkJ3.CheckedChanged += new System.EventHandler(this.checkJ3_CheckedChanged);
            // 
            // checkJ2
            // 
            this.checkJ2.AutoSize = true;
            this.checkJ2.Location = new System.Drawing.Point(6, 42);
            this.checkJ2.Name = "checkJ2";
            this.checkJ2.Size = new System.Drawing.Size(73, 17);
            this.checkJ2.TabIndex = 3;
            this.checkJ2.Text = "Enable J2";
            this.checkJ2.UseVisualStyleBackColor = true;
            this.checkJ2.CheckedChanged += new System.EventHandler(this.checkJ2_CheckedChanged);
            // 
            // checkJ1
            // 
            this.checkJ1.AutoSize = true;
            this.checkJ1.Location = new System.Drawing.Point(6, 19);
            this.checkJ1.Name = "checkJ1";
            this.checkJ1.Size = new System.Drawing.Size(73, 17);
            this.checkJ1.TabIndex = 2;
            this.checkJ1.Text = "Enable J1";
            this.checkJ1.UseVisualStyleBackColor = true;
            this.checkJ1.CheckedChanged += new System.EventHandler(this.checkJ1_CheckedChanged);
            // 
            // J1Box
            // 
            this.J1Box.Location = new System.Drawing.Point(122, 45);
            this.J1Box.Name = "J1Box";
            this.J1Box.Size = new System.Drawing.Size(72, 20);
            this.J1Box.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendData);
            this.groupBox3.Controls.Add(this.J6Box);
            this.groupBox3.Controls.Add(this.J5Box);
            this.groupBox3.Controls.Add(this.J4Box);
            this.groupBox3.Controls.Add(this.J6PlusBtn);
            this.groupBox3.Controls.Add(this.J5PlusBtn);
            this.groupBox3.Controls.Add(this.J4PlusBtn);
            this.groupBox3.Controls.Add(this.J6MinusBtn);
            this.groupBox3.Controls.Add(this.J5MinusBtn);
            this.groupBox3.Controls.Add(this.J4MinusBtn);
            this.groupBox3.Controls.Add(this.J3Box);
            this.groupBox3.Controls.Add(this.J3PlusBtn);
            this.groupBox3.Controls.Add(this.J2Box);
            this.groupBox3.Controls.Add(this.J1Box);
            this.groupBox3.Controls.Add(this.J3MinusBtn);
            this.groupBox3.Controls.Add(this.J1MinusBtn);
            this.groupBox3.Controls.Add(this.J2PlusBtn);
            this.groupBox3.Controls.Add(this.J1PlusBtn);
            this.groupBox3.Controls.Add(this.J2MinusBtn);
            this.groupBox3.Location = new System.Drawing.Point(163, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 550);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jog joints";
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(60, 485);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(208, 55);
            this.sendData.TabIndex = 3;
            this.sendData.Text = "Drive joints to values";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // J6Box
            // 
            this.J6Box.Location = new System.Drawing.Point(122, 421);
            this.J6Box.Name = "J6Box";
            this.J6Box.Size = new System.Drawing.Size(72, 20);
            this.J6Box.TabIndex = 20;
            // 
            // J5Box
            // 
            this.J5Box.Location = new System.Drawing.Point(122, 346);
            this.J5Box.Name = "J5Box";
            this.J5Box.Size = new System.Drawing.Size(72, 20);
            this.J5Box.TabIndex = 19;
            // 
            // J4Box
            // 
            this.J4Box.Location = new System.Drawing.Point(122, 270);
            this.J4Box.Name = "J4Box";
            this.J4Box.Size = new System.Drawing.Size(72, 20);
            this.J4Box.TabIndex = 18;
            // 
            // J6PlusBtn
            // 
            this.J6PlusBtn.Location = new System.Drawing.Point(200, 396);
            this.J6PlusBtn.Name = "J6PlusBtn";
            this.J6PlusBtn.Size = new System.Drawing.Size(109, 69);
            this.J6PlusBtn.TabIndex = 17;
            this.J6PlusBtn.Text = "J6 +";
            this.J6PlusBtn.UseVisualStyleBackColor = true;
            this.J6PlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J6PlusBtn_MouseDown);
            this.J6PlusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J6PlusBtn_MouseUp);
            // 
            // J5PlusBtn
            // 
            this.J5PlusBtn.Location = new System.Drawing.Point(200, 321);
            this.J5PlusBtn.Name = "J5PlusBtn";
            this.J5PlusBtn.Size = new System.Drawing.Size(109, 69);
            this.J5PlusBtn.TabIndex = 16;
            this.J5PlusBtn.Text = "J5 +";
            this.J5PlusBtn.UseVisualStyleBackColor = true;
            this.J5PlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J5PlusBtn_MouseDown);
            this.J5PlusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J5PlusBtn_MouseUp);
            // 
            // J4PlusBtn
            // 
            this.J4PlusBtn.Location = new System.Drawing.Point(200, 246);
            this.J4PlusBtn.Name = "J4PlusBtn";
            this.J4PlusBtn.Size = new System.Drawing.Size(109, 69);
            this.J4PlusBtn.TabIndex = 15;
            this.J4PlusBtn.Text = "J4 +";
            this.J4PlusBtn.UseVisualStyleBackColor = true;
            this.J4PlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J4PlusBtn_MouseDown);
            this.J4PlusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J4PlusBtn_MouseUp);
            // 
            // J6MinusBtn
            // 
            this.J6MinusBtn.Location = new System.Drawing.Point(7, 396);
            this.J6MinusBtn.Name = "J6MinusBtn";
            this.J6MinusBtn.Size = new System.Drawing.Size(109, 69);
            this.J6MinusBtn.TabIndex = 14;
            this.J6MinusBtn.Text = "J6 -";
            this.J6MinusBtn.UseVisualStyleBackColor = true;
            this.J6MinusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J6MinusBtn_MouseDown);
            this.J6MinusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J6MinusBtn_MouseUp);
            // 
            // J5MinusBtn
            // 
            this.J5MinusBtn.Location = new System.Drawing.Point(7, 321);
            this.J5MinusBtn.Name = "J5MinusBtn";
            this.J5MinusBtn.Size = new System.Drawing.Size(109, 69);
            this.J5MinusBtn.TabIndex = 13;
            this.J5MinusBtn.Text = "J5 -";
            this.J5MinusBtn.UseVisualStyleBackColor = true;
            this.J5MinusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J5MinusBtn_MouseDown);
            this.J5MinusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J5MinusBtn_MouseUp);
            // 
            // J4MinusBtn
            // 
            this.J4MinusBtn.Location = new System.Drawing.Point(7, 245);
            this.J4MinusBtn.Name = "J4MinusBtn";
            this.J4MinusBtn.Size = new System.Drawing.Size(109, 69);
            this.J4MinusBtn.TabIndex = 12;
            this.J4MinusBtn.Text = "J4 -";
            this.J4MinusBtn.UseVisualStyleBackColor = true;
            this.J4MinusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J4MinusBtn_MouseDown);
            this.J4MinusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J4MinusBtn_MouseUp);
            // 
            // J3Box
            // 
            this.J3Box.Location = new System.Drawing.Point(122, 195);
            this.J3Box.Name = "J3Box";
            this.J3Box.Size = new System.Drawing.Size(72, 20);
            this.J3Box.TabIndex = 11;
            // 
            // J3PlusBtn
            // 
            this.J3PlusBtn.Location = new System.Drawing.Point(200, 170);
            this.J3PlusBtn.Name = "J3PlusBtn";
            this.J3PlusBtn.Size = new System.Drawing.Size(109, 69);
            this.J3PlusBtn.TabIndex = 11;
            this.J3PlusBtn.Text = "J3 +";
            this.J3PlusBtn.UseVisualStyleBackColor = true;
            this.J3PlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J3PlusBtn_MouseDown);
            this.J3PlusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J3PlusBtn_MouseUp);
            // 
            // J2Box
            // 
            this.J2Box.Location = new System.Drawing.Point(122, 120);
            this.J2Box.Name = "J2Box";
            this.J2Box.Size = new System.Drawing.Size(72, 20);
            this.J2Box.TabIndex = 9;
            // 
            // J3MinusBtn
            // 
            this.J3MinusBtn.Location = new System.Drawing.Point(7, 170);
            this.J3MinusBtn.Name = "J3MinusBtn";
            this.J3MinusBtn.Size = new System.Drawing.Size(109, 69);
            this.J3MinusBtn.TabIndex = 10;
            this.J3MinusBtn.Text = "J3 -";
            this.J3MinusBtn.UseVisualStyleBackColor = true;
            this.J3MinusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J3MinusBtn_MouseDown);
            this.J3MinusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J3MinusBtn_MouseUp);
            // 
            // J1MinusBtn
            // 
            this.J1MinusBtn.Location = new System.Drawing.Point(7, 20);
            this.J1MinusBtn.Name = "J1MinusBtn";
            this.J1MinusBtn.Size = new System.Drawing.Size(109, 69);
            this.J1MinusBtn.TabIndex = 6;
            this.J1MinusBtn.Text = "J1 -";
            this.J1MinusBtn.UseVisualStyleBackColor = true;
            this.J1MinusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J1MinusBtn_MouseDown);
            this.J1MinusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J1MinusBtn_MouseUp);
            // 
            // J2PlusBtn
            // 
            this.J2PlusBtn.Location = new System.Drawing.Point(200, 95);
            this.J2PlusBtn.Name = "J2PlusBtn";
            this.J2PlusBtn.Size = new System.Drawing.Size(109, 69);
            this.J2PlusBtn.TabIndex = 9;
            this.J2PlusBtn.Text = "J2 +";
            this.J2PlusBtn.UseVisualStyleBackColor = true;
            this.J2PlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J2PlusBtn_MouseDown);
            this.J2PlusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J2PlusBtn_MouseUp);
            // 
            // J1PlusBtn
            // 
            this.J1PlusBtn.Location = new System.Drawing.Point(200, 19);
            this.J1PlusBtn.Name = "J1PlusBtn";
            this.J1PlusBtn.Size = new System.Drawing.Size(109, 70);
            this.J1PlusBtn.TabIndex = 7;
            this.J1PlusBtn.Text = "J1 +";
            this.J1PlusBtn.UseVisualStyleBackColor = true;
            this.J1PlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J1PlusBtn_MouseDown);
            this.J1PlusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J1PlusBtn_MouseUp);
            // 
            // J2MinusBtn
            // 
            this.J2MinusBtn.Location = new System.Drawing.Point(7, 95);
            this.J2MinusBtn.Name = "J2MinusBtn";
            this.J2MinusBtn.Size = new System.Drawing.Size(109, 69);
            this.J2MinusBtn.TabIndex = 8;
            this.J2MinusBtn.Text = "J2 -";
            this.J2MinusBtn.UseVisualStyleBackColor = true;
            this.J2MinusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.J2MinusBtn_MouseDown);
            this.J2MinusBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.J2MinusBtn_MouseUp);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comPortStatus);
            this.groupBox5.Location = new System.Drawing.Point(13, 124);
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
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.accelerationBar);
            this.Parameters.Controls.Add(this.label2);
            this.Parameters.Controls.Add(this.label1);
            this.Parameters.Controls.Add(this.speedBar);
            this.Parameters.Location = new System.Drawing.Point(510, 349);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(144, 126);
            this.Parameters.TabIndex = 6;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Parameters";
            // 
            // accelerationBar
            // 
            this.accelerationBar.Location = new System.Drawing.Point(6, 88);
            this.accelerationBar.Minimum = 1;
            this.accelerationBar.Name = "accelerationBar";
            this.accelerationBar.Size = new System.Drawing.Size(122, 45);
            this.accelerationBar.TabIndex = 1;
            this.accelerationBar.Value = 1;
            this.accelerationBar.ValueChanged += new System.EventHandler(this.accelerationBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acceleration";
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
            this.speedBar.Location = new System.Drawing.Point(7, 37);
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(121, 45);
            this.speedBar.TabIndex = 0;
            this.speedBar.Value = 1;
            this.speedBar.ValueChanged += new System.EventHandler(this.speedBar_ValueChanged);
            // 
            // examplePicture
            // 
            this.examplePicture.Image = ((System.Drawing.Image)(resources.GetObject("examplePicture.Image")));
            this.examplePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("examplePicture.InitialImage")));
            this.examplePicture.Location = new System.Drawing.Point(6, 19);
            this.examplePicture.Name = "examplePicture";
            this.examplePicture.Size = new System.Drawing.Size(317, 303);
            this.examplePicture.TabIndex = 7;
            this.examplePicture.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.examplePicture);
            this.groupBox6.Location = new System.Drawing.Point(504, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(330, 329);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Example photo";
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
            this.groupBox7.Location = new System.Drawing.Point(12, 349);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(145, 274);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calibrate joints";
            // 
            // calAll
            // 
            this.calAll.Location = new System.Drawing.Point(10, 219);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 664);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePicture)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox J1Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label comPortStatus;
        private System.Windows.Forms.Button J1MinusBtn;
        private System.Windows.Forms.Button J1PlusBtn;
        private System.Windows.Forms.CheckBox checkJ1;
        private System.Windows.Forms.CheckBox checkJ6;
        private System.Windows.Forms.CheckBox checkJ5;
        private System.Windows.Forms.CheckBox checkJ4;
        private System.Windows.Forms.CheckBox checkJ3;
        private System.Windows.Forms.CheckBox checkJ2;
        private System.Windows.Forms.TextBox J3Box;
        private System.Windows.Forms.Button J3PlusBtn;
        private System.Windows.Forms.TextBox J2Box;
        private System.Windows.Forms.Button J3MinusBtn;
        private System.Windows.Forms.Button J2PlusBtn;
        private System.Windows.Forms.Button J2MinusBtn;
        private System.Windows.Forms.TextBox J6Box;
        private System.Windows.Forms.TextBox J5Box;
        private System.Windows.Forms.TextBox J4Box;
        private System.Windows.Forms.Button J6PlusBtn;
        private System.Windows.Forms.Button J5PlusBtn;
        private System.Windows.Forms.Button J4PlusBtn;
        private System.Windows.Forms.Button J6MinusBtn;
        private System.Windows.Forms.Button J5MinusBtn;
        private System.Windows.Forms.Button J4MinusBtn;
        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.TrackBar accelerationBar;
        private System.Windows.Forms.Label label2;
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
    }
}

