namespace AutoMeasurement
{
    partial class Settings
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
            this.label8 = new System.Windows.Forms.Label();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.DeviceList = new System.Windows.Forms.ComboBox();
            this.ConnectDevice = new System.Windows.Forms.Button();
            this.DeviceInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindDevice = new System.Windows.Forms.Button();
            this.vibor_freq_rub = new System.Windows.Forms.TextBox();
            this.vibor_freq = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Номер LPT-порта";
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(140, 55);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(28, 20);
            this.PortNumber.TabIndex = 5;
            this.PortNumber.Text = "378";
            // 
            // DeviceList
            // 
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.Location = new System.Drawing.Point(52, 79);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(121, 21);
            this.DeviceList.TabIndex = 10;
            this.DeviceList.SelectedIndexChanged += new System.EventHandler(this.DeviceList_SelectedIndexChanged_1);
            this.DeviceList.Click += new System.EventHandler(this.DeviceList_Click);
            // 
            // ConnectDevice
            // 
            this.ConnectDevice.Location = new System.Drawing.Point(233, 74);
            this.ConnectDevice.Name = "ConnectDevice";
            this.ConnectDevice.Size = new System.Drawing.Size(120, 29);
            this.ConnectDevice.TabIndex = 12;
            this.ConnectDevice.Text = "Подключить";
            this.ConnectDevice.UseVisualStyleBackColor = true;
            this.ConnectDevice.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeviceInfo
            // 
            this.DeviceInfo.AutoSize = true;
            this.DeviceInfo.Location = new System.Drawing.Point(49, 127);
            this.DeviceInfo.Name = "DeviceInfo";
            this.DeviceInfo.Size = new System.Drawing.Size(127, 13);
            this.DeviceInfo.TabIndex = 14;
            this.DeviceInfo.Text = "Информация о приборе";
            this.DeviceInfo.Click += new System.EventHandler(this.DeviceInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindDevice);
            this.groupBox2.Controls.Add(this.ConnectDevice);
            this.groupBox2.Controls.Add(this.DeviceList);
            this.groupBox2.Controls.Add(this.DeviceInfo);
            this.groupBox2.Location = new System.Drawing.Point(286, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 200);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключение к прибору";
            // 
            // FindDevice
            // 
            this.FindDevice.Location = new System.Drawing.Point(174, 28);
            this.FindDevice.Name = "FindDevice";
            this.FindDevice.Size = new System.Drawing.Size(90, 30);
            this.FindDevice.TabIndex = 15;
            this.FindDevice.Text = "Найти прибор";
            this.FindDevice.UseVisualStyleBackColor = true;
            this.FindDevice.Click += new System.EventHandler(this.FindDevice_Click);
            // 
            // vibor_freq_rub
            // 
            this.vibor_freq_rub.Location = new System.Drawing.Point(43, 89);
            this.vibor_freq_rub.Name = "vibor_freq_rub";
            this.vibor_freq_rub.Size = new System.Drawing.Size(121, 20);
            this.vibor_freq_rub.TabIndex = 17;
            this.vibor_freq_rub.Text = "25000000";
            // 
            // vibor_freq
            // 
            this.vibor_freq.Location = new System.Drawing.Point(43, 35);
            this.vibor_freq.Name = "vibor_freq";
            this.vibor_freq.Size = new System.Drawing.Size(121, 20);
            this.vibor_freq.TabIndex = 18;
            this.vibor_freq.Text = "15000000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vibor_freq);
            this.groupBox1.Controls.Add(this.vibor_freq_rub);
            this.groupBox1.Location = new System.Drawing.Point(41, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 154);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значение тактовой частоты";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PortNumber);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.ComboBox DeviceList;
        private System.Windows.Forms.Button ConnectDevice;
        private System.Windows.Forms.Label DeviceInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox vibor_freq_rub;
        private System.Windows.Forms.Button FindDevice;
        private System.Windows.Forms.TextBox vibor_freq;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}