using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//using ZedGraph;
using System.Diagnostics;
using System.Xml.Linq;

namespace IMU
{
    struct DataFrame
    {
        public byte Identifier;
        public byte FrameLength;
        public byte AdressCode;
        public byte Command;
        public byte[] Data;
        public byte CheckSum;
    }
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
    public partial class Form1 : Form
    {
        string dataReceive;
        private DataFrame dataRx;
        string typeAxis;
        bool flagConnect = false;
        bool flagDataReceived = false;
        byte addressCode = 0x00;
        //bool checkActivate = false;
        int checksum;
        private readonly Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        double XValue = 0, YValue=0, ZValue=0;
        //int i=0;
        //DateTime time;
        //Stopwatch sw = new Stopwatch();


        public Form1()
        {
            InitializeComponent();
            comboBoxBaudRate.SelectedItem = "9600";
            getAvailablePorts();
            if (comboBoxCOM.Items.Count != 0) comboBoxCOM.SelectedIndex = 0;
            comboBoxTypeAxis.SelectedIndex = 0;
            comboBoxBaudRateSet.SelectedItem = "9600";
            comboBoxZeroSet.SelectedIndex = 0;
            comboBoxOutputSet.SelectedIndex = 0;
            comboBoxTypeAxis.SelectedIndex = 0;
        }

        void getAvailablePorts()
        {
            //this code gets the name of the port and port number
            string[] lPorts = SerialPort.GetPortNames();
            if (lPorts == null)
            {
                MessageBox.Show("This machine has no serial port！", "Error");
                return;
            }
            foreach (var port in lPorts)
            {
                string portname = port;
                /// handel
                if (port.Length > 4 && port[3] != '1')
                    portname = port.Substring(0, 4);
                comboBoxCOM.Items.Add(portname);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxCOM.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    buttonConnect.Visible = false;
                    buttonDisconnect.Visible = true;
                    comboBoxCOM.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    flagConnect = true;

                }
                catch
                {
                    MessageBox.Show($"Can't open {comboBoxCOM.Text}");
                }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            serialPort1.Close();
            serialPort1.Dispose();
            buttonConnect.Visible = true;
            buttonDisconnect.Visible = false;
            comboBoxCOM.Enabled = true;
            comboBoxBaudRate.Enabled = true;
            flagConnect = false;
        }

        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        // Hàm checksum
        private byte CalcCheckSum(byte[] data)
        {
            var checkSum = 0;

            for (int i = 1; i < data.Length; i++)
            {
                checkSum += data[i];
            }
            return (byte)checkSum;
        }
        private void Log(LogMsgType msgtype, string msg, string displaywhere)

        {
            //displaywhere = "SEND";
            switch (displaywhere)
            {
                case "SEND":
                    richTextBoxSend.Invoke(new EventHandler(delegate
                    {
                        richTextBoxSend.SelectedText = string.Empty;
                        richTextBoxSend.SelectionFont = new Font(richTextBoxSend.SelectionFont, FontStyle.Bold);
                        richTextBoxSend.SelectionColor = LogMsgTypeColor[(int)msgtype];
                        richTextBoxSend.AppendText(msg);
                        richTextBoxSend.ScrollToCaret();
                    }));
                    break;
                case "RECEIVE":
                    {
                        richTextBoxReceive.Invoke(new EventHandler(delegate
                        {
                            richTextBoxReceive.SelectedText = string.Empty;
                            richTextBoxReceive.SelectionFont = new Font(richTextBoxSend.SelectionFont, FontStyle.Bold);
                            richTextBoxReceive.SelectionColor = LogMsgTypeColor[(int)msgtype];
                            richTextBoxReceive.AppendText(msg);
                            richTextBoxReceive.ScrollToCaret();
                        }));
                    }
                    break;
                default:
                    displaywhere = "SEND";
                    break;

            }

        }
        //Hàm tách 3 bytes góc
        private static int Bytes2Int(byte b1, byte b2, byte b3)
        {
            int r = 0;
            //byte b0 = 0xff;

            // if ((b1 & 0x80) != 0) r |= b0 << 24;
            r |= b1 << 16;
            r |= b2 << 8;
            r |= b3;
            return r;
        }
        //Transform a 2-complement word (2 bytes) to a common int
        private static int convert_int_data(byte msb, byte lsb)
        {
            //ushort[] words= (ushort)(msb << 8) | lsb;
            ushort _word = Convert.ToUInt16((msb << 8) | lsb);
            int data;
            //int data= (msb << 8) | lsb;
            if (_word == 0x8000)
            {
                _word ^= 0xFFFF; //XOR
                _word++;
                data = -_word;
            }
            else
            {
                data = _word;
            }
            return data;
            //return data;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int NumOfUnreadBytes = serialPort1.BytesToRead;
            //bool Received = false;
            byte[] MsgBuffer = new byte[NumOfUnreadBytes];
            serialPort1.Read(MsgBuffer, 0, NumOfUnreadBytes); //wiped after if
            checksum = 0;
            for (int i = 1; i < NumOfUnreadBytes - 1; i++)
            {
                checksum += (MsgBuffer[i]);
            }

            if (MsgBuffer[0] == 0x77)
            {
                flagDataReceived = true;
                string bufffer = ByteArrayToHexString(MsgBuffer);
                if (checkBoxActivate.Checked)
                {
                    Log(LogMsgType.Normal, bufffer + "\n", "RECEIVE");
                }

                dataRx.Identifier = MsgBuffer[0];
                dataRx.FrameLength = MsgBuffer[1];
                dataRx.AdressCode = MsgBuffer[2];
                dataRx.Command = MsgBuffer[3];
                dataRx.Data = new byte[NumOfUnreadBytes - 5];
                for (int i = 4; i < NumOfUnreadBytes - 1; i++)
                {
                    dataRx.Data[i - 4] = MsgBuffer[i];
                }
                dataRx.CheckSum = MsgBuffer[NumOfUnreadBytes - 1];
                processingData(dataRx);
                labelX.Invoke(new Action(()=> labelX.Text = XValue.ToString()));
                labelY.Invoke(new Action(() => labelY.Text = YValue.ToString()));
                labelZ.Invoke(new Action(() => labelZ.Text = ZValue.ToString()));

            }

        }

        private void Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                if (flagConnect)
                {
                    flagConnect = false;
                    buttonConnect.Visible = true;
                    buttonDisconnect.Visible = false;
                    comboBoxCOM.Enabled = true;
                    comboBoxBaudRate.Enabled = true;
                    //string com = comboBoxCOM.Text;
                    //comboBoxCOM.Items.Clear();
                    //getAvailablePorts();
                    //if (comboBoxCOM.Items.Count != 0) comboBoxCOM.SelectedIndex = 0;
                    //else comboBoxCOM.Text = "";
                    MessageBox.Show($"{comboBoxCOM.Text} is disconected!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)

                try
                {
                    comboBoxCOM.Items.Clear();
                    getAvailablePorts();
                    if (comboBoxCOM.Items.Count != 0) comboBoxCOM.SelectedIndex = 0;
                    else comboBoxCOM.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Serial Port is Busy Or Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show("Close The Current Port Before Refreshing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            /*
             * Angle
             * Magnetic field
             * Gravity acceleration
             * Angular velocity
             */
            typeAxis = comboBoxTypeAxis.Text;
            byte[] dataSend = { 0x77, 0x04, addressCode, 0x04, 0x00 };
            switch (comboBoxTypeAxis.Text)
            {
                case "Angle":
                    dataSend[3] = 0x04;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "Magnetic field":
                    //command ???
                    //dataSend[3] = 0x04;
                    //dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    //sendData(dataSend);
                    break;
                case "Gravity acceleration":
                    dataSend[3] = 0x54;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "Angular velocity":
                    dataSend[3] = 0x50;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
            }

        }

        double CalAngle(byte[] dataAngle)
        {
            double angle = 0;
            angle = Convert.ToDouble(dataAngle[1].ToString("X2")) + Convert.ToDouble(dataAngle[2].ToString("X2"))/100;
            return dataAngle[0] == 0x00?angle:-angle;
        }

        void processingData(DataFrame dataRx)
        {
            switch (dataRx.Command)
            {

                case 0x84: //read axises angle
                    XValue = CalAngle(new byte[] { dataRx.Data[0], dataRx.Data[1], dataRx.Data[2] });
                    YValue = CalAngle(new byte[] { dataRx.Data[3], dataRx.Data[4], dataRx.Data[5] });
                    ZValue = CalAngle(new byte[] { dataRx.Data[6], dataRx.Data[7], dataRx.Data[8] });
                    break;
            }
        }

        private void checkBoxActivate_CheckedChanged(object sender, EventArgs e)
        {
            //checkActivate = checkBoxActivate.Checked;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxSend.Clear();

        }

        void sendData(string strHex)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
                    byte[] data = HexStringToByteArray(strHex);
                    //txtSendData.Show();
                    // Send the binary data out the port
                    serialPort1.Write(data, 0, data.Length);

                    // Show the hex digits on in the terminal window
                    DateTime dt = DateTime.Now;
                    String dtn = dt.ToShortTimeString();
                    Log(LogMsgType.Outgoing, "[" + dtn + "] " + "Send: " + ByteArrayToHexString(data) + "\n", "SEND");

                }
                catch (FormatException)
                {
                    // Inform the user if the hex string was not properly formatted
                    Log(LogMsgType.Error, "Not properly formatted hex string: " + richTextBoxSend.Text + "\n", "SEND");
                }
            }
            else
                MessageBox.Show("Please open the serial port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void sendData(byte[] byteHext)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
                    //txtSendData.Show();
                    // Send the binary data out the port
                    serialPort1.Write(byteHext, 0, byteHext.Length);

                    // Show the hex digits on in the terminal window
                    DateTime dt = DateTime.Now;
                    String dtn = dt.ToShortTimeString();
                    Log(LogMsgType.Outgoing, "[" + dtn + "] " + "Send: " + ByteArrayToHexString(byteHext) + "\n", "SEND");

                }
                catch (FormatException)
                {
                    // Inform the user if the hex string was not properly formatted
                    Log(LogMsgType.Error, "Not properly formatted hex string: " + richTextBoxSend.Text + "\n", "SEND");
                }
            }
            else
                MessageBox.Show("Please open the serial port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendData(textBoxSendData.Text);
            
        }

        private void textBoxSendData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] data = HexStringToByteArray(textBoxSendData.Text);
                textBoxCheckSum.Invoke(new Action(() => textBoxCheckSum.Text = CalcCheckSum(data).ToString("X2")));
            }
            catch { }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxSendData.Invoke(new Action(() => textBoxSendData.Text += " " + textBoxCheckSum.Text ));
        }

        private void buttonSetAddress_Click(object sender, EventArgs e)
        {
            byte[] dataSend = { 0x77, 0x05, addressCode, 0x0F, 0x01,0x00 };
            dataSend[dataSend.Length-1] = CalcCheckSum(dataSend);
            sendData(dataSend);
        }

        private void buttonSetBaudRate_Click(object sender, EventArgs e)
        {
            byte[] dataSend = { 0x77, 0x05, addressCode, 0x0B, 0x00, 0x00 };
            switch (comboBoxBaudRateSet.Text)
            {
                case "2400":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "4800":
                    dataSend[4] = 0x01;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "9600":
                    dataSend[4] = 0x02;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "19200":
                    dataSend[4] = 0x03;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "115200":
                    dataSend[4] = 0x04;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
            }
        }

        private void buttonSetZero_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetOutput_Click(object sender, EventArgs e)
        {
            /*
             *  Answer mode
                5Hz auto mode
                10Hz auto mode
                15Hz auto mode
                20Hz auto mode
                25Hz auto mode
                50Hz auto mode
                100Hz auto mode
            */
            byte[] dataSend = { 0x77, 0x05, addressCode, 0x0C, 0x00, 0x00 };
            switch (comboBoxOutputSet.Text)
            {
                case "Answer mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "5Hz auto mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "10Hz auto mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "20Hz auto mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "25Hz auto mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "50Hz auto mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
                case "100Hz auto mode":
                    dataSend[4] = 0x00;
                    dataSend[dataSend.Length - 1] = CalcCheckSum(dataSend);
                    sendData(dataSend);
                    break;
            }

        }
    }
}
