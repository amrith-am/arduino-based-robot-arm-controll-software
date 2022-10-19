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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.stepperOff = new System.Windows.Forms.Button();
            this.stepperOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendData = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comPortStatus = new System.Windows.Forms.Label();
            this.stepBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnect);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 113);
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
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.stepperOff);
            this.groupBox2.Controls.Add(this.stepperOn);
            this.groupBox2.Location = new System.Drawing.Point(13, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stepper ON/OFF";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Direction";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // stepperOff
            // 
            this.stepperOff.Location = new System.Drawing.Point(73, 33);
            this.stepperOff.Name = "stepperOff";
            this.stepperOff.Size = new System.Drawing.Size(55, 55);
            this.stepperOff.TabIndex = 1;
            this.stepperOff.Text = "OFF";
            this.stepperOff.UseVisualStyleBackColor = true;
            this.stepperOff.Click += new System.EventHandler(this.stepperOff_Click);
            // 
            // stepperOn
            // 
            this.stepperOn.Location = new System.Drawing.Point(6, 33);
            this.stepperOn.Name = "stepperOn";
            this.stepperOn.Size = new System.Drawing.Size(55, 55);
            this.stepperOn.TabIndex = 0;
            this.stepperOn.Text = "ON";
            this.stepperOn.UseVisualStyleBackColor = true;
            this.stepperOn.Click += new System.EventHandler(this.stepperOn_Click);
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(6, 20);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(209, 20);
            this.tBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendData);
            this.groupBox3.Controls.Add(this.tBox);
            this.groupBox3.Location = new System.Drawing.Point(163, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data transmit";
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(7, 46);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(208, 55);
            this.sendData.TabIndex = 3;
            this.sendData.Text = "Send data";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comPortStatus);
            this.groupBox5.Location = new System.Drawing.Point(13, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 61);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Com port status";
            // 
            // comPortStatus
            // 
            this.comPortStatus.AutoSize = true;
            this.comPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comPortStatus.Location = new System.Drawing.Point(33, 21);
            this.comPortStatus.Name = "comPortStatus";
            this.comPortStatus.Size = new System.Drawing.Size(72, 31);
            this.comPortStatus.TabIndex = 0;
            this.comPortStatus.Text = "OFF";
            // 
            // stepBtn
            // 
            this.stepBtn.Location = new System.Drawing.Point(170, 133);
            this.stepBtn.Name = "stepBtn";
            this.stepBtn.Size = new System.Drawing.Size(109, 69);
            this.stepBtn.TabIndex = 6;
            this.stepBtn.Text = "JOG +";
            this.stepBtn.UseVisualStyleBackColor = true;
            this.stepBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stepBtn_MouseDown);
            this.stepBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stepBtn_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "JOG -";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stepBtn);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stepperOff;
        private System.Windows.Forms.Button stepperOn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label comPortStatus;
        private System.Windows.Forms.Button stepBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

