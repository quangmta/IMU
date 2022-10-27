
namespace IMU
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.COM = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPageThreeAxis = new System.Windows.Forms.TabPage();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTypeAxis = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSendCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelReceiveCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.labelByteCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.textBoxCheckSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.checkBoxActivate = new System.Windows.Forms.CheckBox();
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxOutputSet = new System.Windows.Forms.ComboBox();
            this.comboBoxZeroSet = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRateSet = new System.Windows.Forms.ComboBox();
            this.buttonSetOutput = new System.Windows.Forms.Button();
            this.buttonSetZero = new System.Windows.Forms.Button();
            this.buttonSetBaudRate = new System.Windows.Forms.Button();
            this.buttonSetAddress = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelSetState = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControlData.SuspendLayout();
            this.tabPageThreeAxis.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.comboBoxCOM);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set COM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(82, 54);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(73, 24);
            this.comboBoxBaudRate.TabIndex = 9;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(82, 19);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(73, 24);
            this.comboBoxCOM.TabIndex = 9;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(41, 156);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(104, 33);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // COM
            // 
            this.COM.AutoSize = true;
            this.COM.Location = new System.Drawing.Point(13, 22);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(37, 16);
            this.COM.TabIndex = 8;
            this.COM.Text = "COM";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(41, 102);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(104, 40);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Open";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(41, 102);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(104, 40);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Close";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(64, 399);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 29);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPageThreeAxis);
            this.tabControlData.Controls.Add(this.tabPage2);
            this.tabControlData.Controls.Add(this.tabPage1);
            this.tabControlData.Location = new System.Drawing.Point(214, 40);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(640, 494);
            this.tabControlData.TabIndex = 4;
            // 
            // tabPageThreeAxis
            // 
            this.tabPageThreeAxis.Controls.Add(this.buttonStart);
            this.tabPageThreeAxis.Controls.Add(this.labelZ);
            this.tabPageThreeAxis.Controls.Add(this.labelY);
            this.tabPageThreeAxis.Controls.Add(this.labelX);
            this.tabPageThreeAxis.Controls.Add(this.label5);
            this.tabPageThreeAxis.Controls.Add(this.label4);
            this.tabPageThreeAxis.Controls.Add(this.label3);
            this.tabPageThreeAxis.Controls.Add(this.comboBoxTypeAxis);
            this.tabPageThreeAxis.Location = new System.Drawing.Point(4, 25);
            this.tabPageThreeAxis.Name = "tabPageThreeAxis";
            this.tabPageThreeAxis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThreeAxis.Size = new System.Drawing.Size(632, 465);
            this.tabPageThreeAxis.TabIndex = 0;
            this.tabPageThreeAxis.Text = "Three Axis";
            this.tabPageThreeAxis.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(202, 29);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 34);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.Location = new System.Drawing.Point(88, 246);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(24, 25);
            this.labelZ.TabIndex = 11;
            this.labelZ.Text = "0";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(88, 191);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 25);
            this.labelY.TabIndex = 12;
            this.labelY.Text = "0";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(90, 131);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 25);
            this.labelX.TabIndex = 13;
            this.labelX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Z :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "X :";
            // 
            // comboBoxTypeAxis
            // 
            this.comboBoxTypeAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeAxis.FormattingEnabled = true;
            this.comboBoxTypeAxis.Items.AddRange(new object[] {
            "Angle",
            "Magnetic field",
            "Gravity acceleration",
            "Angular velocity"});
            this.comboBoxTypeAxis.Location = new System.Drawing.Point(27, 39);
            this.comboBoxTypeAxis.Name = "comboBoxTypeAxis";
            this.comboBoxTypeAxis.Size = new System.Drawing.Size(146, 24);
            this.comboBoxTypeAxis.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "COM Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelSendCount);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.labelReceiveCount);
            this.groupBox4.Location = new System.Drawing.Point(24, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(557, 46);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comunication Statitics";
            // 
            // labelSendCount
            // 
            this.labelSendCount.AutoSize = true;
            this.labelSendCount.Location = new System.Drawing.Point(316, 18);
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(14, 16);
            this.labelSendCount.TabIndex = 14;
            this.labelSendCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Send:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Receive:";
            // 
            // labelReceiveCount
            // 
            this.labelReceiveCount.AutoSize = true;
            this.labelReceiveCount.Location = new System.Drawing.Point(91, 18);
            this.labelReceiveCount.Name = "labelReceiveCount";
            this.labelReceiveCount.Size = new System.Drawing.Size(14, 16);
            this.labelReceiveCount.TabIndex = 11;
            this.labelReceiveCount.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxSend);
            this.groupBox3.Controls.Add(this.labelByteCount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBoxSendData);
            this.groupBox3.Controls.Add(this.textBoxCheckSum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.buttonSend);
            this.groupBox3.Location = new System.Drawing.Point(23, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 172);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Location = new System.Drawing.Point(18, 85);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(525, 67);
            this.richTextBoxSend.TabIndex = 12;
            this.richTextBoxSend.Text = "";
            // 
            // labelByteCount
            // 
            this.labelByteCount.AutoSize = true;
            this.labelByteCount.Location = new System.Drawing.Point(62, 56);
            this.labelByteCount.Name = "labelByteCount";
            this.labelByteCount.Size = new System.Drawing.Size(14, 16);
            this.labelByteCount.TabIndex = 11;
            this.labelByteCount.Text = "0";
            this.labelByteCount.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Byte:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(388, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Hex";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.Location = new System.Drawing.Point(19, 21);
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(345, 22);
            this.textBoxSendData.TabIndex = 5;
            this.textBoxSendData.TextChanged += new System.EventHandler(this.textBoxSendData_TextChanged);
            // 
            // textBoxCheckSum
            // 
            this.textBoxCheckSum.Location = new System.Drawing.Point(245, 56);
            this.textBoxCheckSum.Name = "textBoxCheckSum";
            this.textBoxCheckSum.Size = new System.Drawing.Size(66, 22);
            this.textBoxCheckSum.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "CheckSum Caculator";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(350, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(459, 20);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxReceive);
            this.groupBox2.Controls.Add(this.checkBoxActivate);
            this.groupBox2.Controls.Add(this.checkBoxHex);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Location = new System.Drawing.Point(22, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 178);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Data";
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(20, 47);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(524, 96);
            this.richTextBoxReceive.TabIndex = 4;
            this.richTextBoxReceive.Text = "";
            // 
            // checkBoxActivate
            // 
            this.checkBoxActivate.AutoSize = true;
            this.checkBoxActivate.Location = new System.Drawing.Point(19, 21);
            this.checkBoxActivate.Name = "checkBoxActivate";
            this.checkBoxActivate.Size = new System.Drawing.Size(77, 20);
            this.checkBoxActivate.TabIndex = 1;
            this.checkBoxActivate.Text = "Activate";
            this.checkBoxActivate.UseVisualStyleBackColor = true;
            this.checkBoxActivate.CheckedChanged += new System.EventHandler(this.checkBoxActivate_CheckedChanged);
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.AutoSize = true;
            this.checkBoxHex.Checked = true;
            this.checkBoxHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHex.Location = new System.Drawing.Point(19, 149);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(53, 20);
            this.checkBoxHex.TabIndex = 2;
            this.checkBoxHex.Text = "Hex";
            this.checkBoxHex.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(460, 149);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 465);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxOutputSet);
            this.groupBox6.Controls.Add(this.comboBoxZeroSet);
            this.groupBox6.Controls.Add(this.comboBoxBaudRateSet);
            this.groupBox6.Controls.Add(this.buttonSetOutput);
            this.groupBox6.Controls.Add(this.buttonSetZero);
            this.groupBox6.Controls.Add(this.buttonSetBaudRate);
            this.groupBox6.Controls.Add(this.buttonSetAddress);
            this.groupBox6.Controls.Add(this.textBoxAddress);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(22, 116);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(552, 226);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Set";
            // 
            // comboBoxOutputSet
            // 
            this.comboBoxOutputSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputSet.FormattingEnabled = true;
            this.comboBoxOutputSet.Items.AddRange(new object[] {
            "Answer mode",
            "5Hz auto mode",
            "10Hz auto mode",
            "15Hz auto mode",
            "20Hz auto mode",
            "25Hz auto mode",
            "50Hz auto mode",
            "100Hz auto mode"});
            this.comboBoxOutputSet.Location = new System.Drawing.Point(106, 118);
            this.comboBoxOutputSet.Name = "comboBoxOutputSet";
            this.comboBoxOutputSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxOutputSet.Size = new System.Drawing.Size(112, 24);
            this.comboBoxOutputSet.TabIndex = 3;
            // 
            // comboBoxZeroSet
            // 
            this.comboBoxZeroSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZeroSet.FormattingEnabled = true;
            this.comboBoxZeroSet.Items.AddRange(new object[] {
            "Absolute",
            "Relative"});
            this.comboBoxZeroSet.Location = new System.Drawing.Point(106, 88);
            this.comboBoxZeroSet.Name = "comboBoxZeroSet";
            this.comboBoxZeroSet.Size = new System.Drawing.Size(112, 24);
            this.comboBoxZeroSet.TabIndex = 3;
            // 
            // comboBoxBaudRateSet
            // 
            this.comboBoxBaudRateSet.DisplayMember = "0";
            this.comboBoxBaudRateSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRateSet.FormattingEnabled = true;
            this.comboBoxBaudRateSet.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.comboBoxBaudRateSet.Location = new System.Drawing.Point(106, 58);
            this.comboBoxBaudRateSet.Name = "comboBoxBaudRateSet";
            this.comboBoxBaudRateSet.Size = new System.Drawing.Size(112, 24);
            this.comboBoxBaudRateSet.TabIndex = 3;
            // 
            // buttonSetOutput
            // 
            this.buttonSetOutput.Location = new System.Drawing.Point(242, 119);
            this.buttonSetOutput.Name = "buttonSetOutput";
            this.buttonSetOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonSetOutput.TabIndex = 2;
            this.buttonSetOutput.Text = "SET";
            this.buttonSetOutput.UseVisualStyleBackColor = true;
            this.buttonSetOutput.Click += new System.EventHandler(this.buttonSetOutput_Click);
            // 
            // buttonSetZero
            // 
            this.buttonSetZero.Location = new System.Drawing.Point(242, 88);
            this.buttonSetZero.Name = "buttonSetZero";
            this.buttonSetZero.Size = new System.Drawing.Size(75, 23);
            this.buttonSetZero.TabIndex = 2;
            this.buttonSetZero.Text = "SET";
            this.buttonSetZero.UseVisualStyleBackColor = true;
            this.buttonSetZero.Click += new System.EventHandler(this.buttonSetZero_Click);
            // 
            // buttonSetBaudRate
            // 
            this.buttonSetBaudRate.Location = new System.Drawing.Point(242, 57);
            this.buttonSetBaudRate.Name = "buttonSetBaudRate";
            this.buttonSetBaudRate.Size = new System.Drawing.Size(75, 23);
            this.buttonSetBaudRate.TabIndex = 2;
            this.buttonSetBaudRate.Text = "SET";
            this.buttonSetBaudRate.UseVisualStyleBackColor = true;
            this.buttonSetBaudRate.Click += new System.EventHandler(this.buttonSetBaudRate_Click);
            // 
            // buttonSetAddress
            // 
            this.buttonSetAddress.Location = new System.Drawing.Point(242, 25);
            this.buttonSetAddress.Name = "buttonSetAddress";
            this.buttonSetAddress.Size = new System.Drawing.Size(75, 23);
            this.buttonSetAddress.TabIndex = 2;
            this.buttonSetAddress.Text = "SET";
            this.buttonSetAddress.UseVisualStyleBackColor = true;
            this.buttonSetAddress.Click += new System.EventHandler(this.buttonSetAddress_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(106, 24);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(112, 22);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Output";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Zero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Baud Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adress";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelSetState);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(22, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(552, 58);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set State";
            // 
            // labelSetState
            // 
            this.labelSetState.AutoSize = true;
            this.labelSetState.Location = new System.Drawing.Point(103, 29);
            this.labelSetState.Name = "labelSetState";
            this.labelSetState.Size = new System.Drawing.Size(40, 16);
            this.labelSetState.TabIndex = 1;
            this.labelSetState.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Set State:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(209, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(457, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Bewis General Cominication Protocol Interface";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 546);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlData.ResumeLayout(false);
            this.tabPageThreeAxis.ResumeLayout(false);
            this.tabPageThreeAxis.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label COM;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPageThreeAxis;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypeAxis;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelByteCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxSendData;
        private System.Windows.Forms.TextBox textBoxCheckSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxActivate;
        private System.Windows.Forms.CheckBox checkBoxHex;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelSendCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelReceiveCount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxOutputSet;
        private System.Windows.Forms.ComboBox comboBoxZeroSet;
        private System.Windows.Forms.ComboBox comboBoxBaudRateSet;
        private System.Windows.Forms.Button buttonSetOutput;
        private System.Windows.Forms.Button buttonSetZero;
        private System.Windows.Forms.Button buttonSetBaudRate;
        private System.Windows.Forms.Button buttonSetAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelSetState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
    }
}

