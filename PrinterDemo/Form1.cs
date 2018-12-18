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


namespace PrinterDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // init serial com port at here
            // Todo: set the arduino COM port at here. Check at device manager
            try
            {
                SerialPort mySerialPort = new SerialPort("COM5");

                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.RtsEnable = true;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.Open();
            }
            catch (Exception)
            {
                // Error handling to remind user to reset arduino
                MessageBox.Show("COM port not detected! Pls reset COM at Arduino!", "Error", MessageBoxButtons.OK);
                System.Environment.Exit(999);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDemoLabel();
        }
   
        private static void DataReceivedHandler(
                            object sender,
                            SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            // If received "Detected!" from arduino Port
            if (indata.Contains("D"))
            {
                PrintDemoLabel();
                // Add a handling here to stop printer from keep printing.
            }
        }

        // Function to perform printing module!
        private static void PrintDemoLabel()
        {
            TSCLIB_DLL.openport("TSC TDP-225");                                                 //Open specified printer driver
            TSCLIB_DLL.setup("25", "400", "1", "8", "1", "6", "250");                           //Setup the media size and sensor type info
            TSCLIB_DLL.clearbuffer();                                                           //Clear image buffer
            TSCLIB_DLL.barcode("50", "450", "128", "100", "1", "270", "2", "2", "Brady123");    //Drawing barcode
            TSCLIB_DLL.printerfont("150", "480", "5", "90", "1", "1", "BRADY");                 //Drawing printer font
            TSCLIB_DLL.sendcommand("QRCODE 30,0,M,7,M,0,M2,S1,\"ABRADY123\"");                  //Draw QR Code
            TSCLIB_DLL.printlabel("1", "1");                                                    //Print labels
            TSCLIB_DLL.closeport();                                                             //Close specified printer driver
        }
    }
}
