using System;
using System.Data.SQLite;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace PrinterDemo
{
    public partial class Form1 : Form
    {
        private SerialPort mySerialPort;

        public Form1()
        {
            InitializeComponent();

            // init serial com port at here
            try
            {
                mySerialPort = new SerialPort("COM5");

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
                //System.Environment.Exit(999);
            }

            // Update the label of the gate
            LABEL_GATE_NO.Text = getGateID();
        }

        // Reprint button event
        private void btn_print_Click(object sender, EventArgs e)
        {
            TB_ManualCount.Visible = false;
            LABEL_COUNT.Text = TB_ManualCount.Text;
            // If user press reprint, the counter should not increase
            PrintDemoLabel(true);
            btn_print.Text = "Re-Print";
        }

        // Handle serial com incoming data
        private void DataReceivedHandler(
                            object sender,
                            SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            // If received "D" from arduino Port, sensor is triggered.
            if (indata.Contains("D"))
            {
                // If sensor detect door open, update the counter to increase by 1
                PrintDemoLabel(false);
            }
        }

        // Function to perform printing module!
        private void PrintDemoLabel(bool reprint)
        {
            // Read from DB to get counter. return 1 if db not found.
            // append the string with time,gate and counter
            // write time, gate, count and reprint to DB.
            // Print out ticket accordingly.
            // Update the label for counter.
            // if reprtint, do not increment the counter.
            String printformat = UpdateDB(reprint);
            // Update the counter at here
            LABEL_COUNT.Invoke(new EventHandler(delegate
            {
                LABEL_COUNT.Text = printformat.Split('/').Last();
            }));
            String gatePrint = "Gate: " + printformat.Split('/')[1];
            String CountPrint = "Counter: " + printformat.Split('/').Last();
            TSCLIB_DLL.openport("TSC TDP-225");                                                 //Open specified printer driver
            TSCLIB_DLL.setup("25", "400", "1", "8", "1", "6", "250");                           //Setup the media size and sensor type info
            TSCLIB_DLL.clearbuffer();                                                           //Clear image buffer
            TSCLIB_DLL.barcode("50", "470", "128", "100", "1", "270", "2", "2", printformat);   //Drawing barcode
            TSCLIB_DLL.printerfont("140", "480", "5", "90", "1", "1", gatePrint);               //Print Gate number
            TSCLIB_DLL.printerfont("180", "480", "5", "90", "1", "1", CountPrint);              //Print Ticket Counter
            TSCLIB_DLL.sendcommand($"QRCODE 20,0,M,7,M,0,M2,S1,\"A{printformat}\"");            //Draw QR Code
            TSCLIB_DLL.printlabel("1", "1");                                                    //Print labels
            TSCLIB_DLL.closeport();                                                             //Close specified printer driver
    }

        private String getGateID()
        {
            string gate = "0";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                gate = System.IO.File.ReadAllText("GateID.txt");

                // If somebody alter the file, delete the file 
                // and prompt user to update the gate ID
                if (gate.Contains(Environment.NewLine))
                {
                    File.Delete("GateID.txt");
                    ShowMyDialogBox();
                }
            }
            catch (Exception e)
            {
                // If file not file, prompt user to update GateID
                Console.WriteLine("Exception: " + e.Message);
                ShowMyDialogBox();
            }

            gate = System.IO.File.ReadAllText("GateID.txt");

            return gate;
        }

        private String UpdateCurrentCounter()
        {
            return LABEL_COUNT.Text;
        }

        private void Timer_time_Tick(object sender, EventArgs e)
        {
            LABEL_DATE.Text = DateTime.Now.ToString("yyyy-MM-dd");
            LABEL_TIME.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private String UpdateDB(bool ReprintFlag)
        {
            String current_time = DateTime.Now.ToString();
            String current_date = DateTime.Now.ToString("yyyyMMdd");
            String retPrint = "";
            String gate = LABEL_GATE_NO.Text;
            int reprint = (ReprintFlag) ? 1 : 0;
            int count=0;
            bool table_created = false;

            String DatabaseFile = $"{current_date}.db";
            // Create the file which will be hosting our database
            if (!File.Exists(DatabaseFile))
            {
                SQLiteConnection.CreateFile(DatabaseFile);
                table_created = true;
            }

            // Connect to the database 
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;"))
            {
                // Create a database command
                using (var command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    if (table_created)
                    {
                        // Create the table
                        command.CommandText = "create table GateTracking (time varchar(40), gate varchar(10), count int, reprint int)";
                        command.ExecuteNonQuery();
                    }

                    if (!table_created)
                    {
                        // Select and display database entries
                        var command_read = new SQLiteCommand(connection);
                        //command_read.CommandText = "SELECT * FROM GateTracking LIMIT 1";
                        command_read.CommandText = "SELECT * FROM gateTracking ORDER BY count DESC LIMIT 1;";
                        var reader = command_read.ExecuteReader();
                        if (reader.Read())
                        {
                            int db_count = reader.GetInt32(2);
                            count = db_count;
                            // if not reprint, only increase the counter
                            if (reprint == 0)
                            {
                                count += 1;
                            }
                            else
                            {
                                if (btn_print.Text == "Manual Print")
                                {
                                    count = Int32.Parse(TB_ManualCount.Text);
                                }
                            }
                        }
                    }
                    else
                    {
                        LABEL_COUNT.Text = "0";
                        count = 0;
                    }

                    // Insert entries in database table
                    command.CommandText = $"insert into GateTracking (time, gate, count, reprint) values ('{current_time}', '{gate}', {count}, {reprint})";
                    command.ExecuteNonQuery();

                    connection.Close(); // Close the connection to the database

                }
            }
            retPrint = current_date +"/" +gate + "/" +count.ToString();
            return retPrint;
        }

        public void ShowMyDialogBox()
        {
            Form2 testDialog = new Form2();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {

                // Read the contents of testDialog's TextBox.
                this.LABEL_GATE_NO.Text = testDialog.textBox1.Text;
            }
            else
            {
                this.LABEL_GATE_NO.Text = "Problem! Please contact support!";
            }
            testDialog.Dispose();
        }

        private void up_arrow_Click(object sender, EventArgs e)
        {
            TB_ManualCount.Visible = true;
            TB_ManualCount.Text = (Int32.Parse(TB_ManualCount.Text) + 1).ToString();
            btn_print.Text = "Manual Print";
        }

        private void down_arrow_Click(object sender, EventArgs e)
        {
            TB_ManualCount.Visible = true;
            if (Int32.Parse(TB_ManualCount.Text) > 0)
            {
                TB_ManualCount.Text = (Int32.Parse(TB_ManualCount.Text) - 1).ToString();
            }
            else
            {
                TB_ManualCount.Text = "0";
            }
            btn_print.Text = "Manual Print";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                down_arrow.Visible = true;
                up_arrow.Visible = true;
            }
            else
            {
                // Error handling to remind user to reset arduino
                MessageBox.Show("Please restart the program", "Restart Needed", MessageBoxButtons.OK);
                System.Environment.Exit(999);
            }
        }
    }
}
