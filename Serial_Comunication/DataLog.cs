using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;  //add this,represents a serial port resource


namespace Serial_Comunication
{
    public partial class DataLog : Form
    {
        SerialPort myserial = new SerialPort(); //create of serial port

        public DataLog()
        { 
            InitializeComponent();
            getportnames();                   //load all port names in this computer
            comboBoxBaudR.SelectedIndex = 6;  //default  set for baudrate-9600
            comboBoxDataB.SelectedIndex = 1;  //default  set for data bits-8
            comboBoxParity.SelectedIndex = 0; //default  set for parity -none
            comboBoxStopB.SelectedIndex = 0;  //default  set for stop bits -one 
//            InitComPort();
        }


        public void InitComPort()
        {
            try
            {
                if (myserial.IsOpen)  //if port is  open 
                {
                    myserial.Close();  //close port
                }
                myserial.PortName = comboBoxPort.Text;                                           //selected name of port
                myserial.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);   //selected parity 
                myserial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopB.Text);//selected stopbits
                myserial.DataBits = int.Parse(comboBoxDataB.Text);                           //selected data bits
                myserial.BaudRate = int.Parse(comboBoxBaudR.Text);                             //selected baudrate
                myserial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);//received even handler
                myserial.Open();
            }
            catch
            {
                MessageBox.Show("com port is not available");
            }
        }
        public void getportnames()         
        {
            string[] portnames = SerialPort.GetPortNames(); //load all names of  com ports to string 
            comboBoxPort.Items.Clear();                     //delete previous names in combobox items 
            
            foreach (string s in portnames)                 //add this names to comboboxPort items
            { 
                comboBoxPort.Items.Add(s);
            }

           if (comboBoxPort.Items.Count > 0)   //if there are some com ports ,select first 
            { 
               comboBoxPort.SelectedIndex = 0;
            }
           else
            { 
               comboBoxPort.Text = "No COM Port "; //if there are no com ports ,write No Com Port
            }
        }
        public  void  transmit()    
        {
           // InitComPort();
            try
            {
//                myserial.Open();        //open serial port
                myserial.Write(richTextBoxSend.Text); //write string  to serial port from rich text box 
            }
            catch
            {
                MessageBox.Show("com port is not available"); //if there are not is any COM port in PC show message
            }
        }

        public void DataReceivedHandler( object sender,SerialDataReceivedEventArgs e)
        {
            string indata=  myserial.ReadExisting();  //read data to string 
            Invoke(new Action(() => richTextBoxReceive.Text += indata)); //invoke method use for write receive data to richtextbox 
        }
        private void buttonSend_Click(object sender, EventArgs e) // send button  event
        { 
            transmit();     //transmit data
        }
        private void buttonReload_Click(object sender, EventArgs e)//reload button event ,most useful if you use virtual COM port e.g FTDI,Prolific 
        {
            PanelData.Visible = true;
 //           getportnames();                 //init parameters of serial comunication before every touch button "send" 
            InitComPort();
        }

        private void buttonBackToSettings_Click(object sender, EventArgs e)
        {
            PanelData.Visible = false;
        }    
    }
}
