namespace PrinterDemo
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_print = new System.Windows.Forms.Button();
            this.PB_Sunway = new System.Windows.Forms.PictureBox();
            this.PB_Brady = new System.Windows.Forms.PictureBox();
            this.LABEL_GATE = new System.Windows.Forms.Label();
            this.LABEL_COUNTER = new System.Windows.Forms.Label();
            this.LABEL_GATE_NO = new System.Windows.Forms.Label();
            this.LABEL_COUNT = new System.Windows.Forms.Label();
            this.LABEL_TIME = new System.Windows.Forms.Label();
            this.Timer_time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sunway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Brady)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(623, 364);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(212, 79);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Re-Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // PB_Sunway
            // 
            this.PB_Sunway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_Sunway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Sunway.Enabled = false;
            this.PB_Sunway.Image = ((System.Drawing.Image)(resources.GetObject("PB_Sunway.Image")));
            this.PB_Sunway.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Sunway.InitialImage")));
            this.PB_Sunway.Location = new System.Drawing.Point(232, 36);
            this.PB_Sunway.Name = "PB_Sunway";
            this.PB_Sunway.Size = new System.Drawing.Size(446, 196);
            this.PB_Sunway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Sunway.TabIndex = 1;
            this.PB_Sunway.TabStop = false;
            // 
            // PB_Brady
            // 
            this.PB_Brady.Image = ((System.Drawing.Image)(resources.GetObject("PB_Brady.Image")));
            this.PB_Brady.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Brady.InitialImage")));
            this.PB_Brady.Location = new System.Drawing.Point(593, 485);
            this.PB_Brady.Name = "PB_Brady";
            this.PB_Brady.Size = new System.Drawing.Size(259, 64);
            this.PB_Brady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Brady.TabIndex = 2;
            this.PB_Brady.TabStop = false;
            // 
            // LABEL_GATE
            // 
            this.LABEL_GATE.AutoSize = true;
            this.LABEL_GATE.Location = new System.Drawing.Point(37, 284);
            this.LABEL_GATE.Name = "LABEL_GATE";
            this.LABEL_GATE.Size = new System.Drawing.Size(75, 25);
            this.LABEL_GATE.TabIndex = 3;
            this.LABEL_GATE.Text = "GATE:";
            // 
            // LABEL_COUNTER
            // 
            this.LABEL_COUNTER.AutoSize = true;
            this.LABEL_COUNTER.Location = new System.Drawing.Point(37, 336);
            this.LABEL_COUNTER.Name = "LABEL_COUNTER";
            this.LABEL_COUNTER.Size = new System.Drawing.Size(94, 25);
            this.LABEL_COUNTER.TabIndex = 3;
            this.LABEL_COUNTER.Text = "Counter:";
            // 
            // LABEL_GATE_NO
            // 
            this.LABEL_GATE_NO.AutoSize = true;
            this.LABEL_GATE_NO.Location = new System.Drawing.Point(142, 284);
            this.LABEL_GATE_NO.Name = "LABEL_GATE_NO";
            this.LABEL_GATE_NO.Size = new System.Drawing.Size(104, 25);
            this.LABEL_GATE_NO.TabIndex = 3;
            this.LABEL_GATE_NO.Text = "Not setup";
            // 
            // LABEL_COUNT
            // 
            this.LABEL_COUNT.AutoSize = true;
            this.LABEL_COUNT.Location = new System.Drawing.Point(142, 336);
            this.LABEL_COUNT.Name = "LABEL_COUNT";
            this.LABEL_COUNT.Size = new System.Drawing.Size(157, 25);
            this.LABEL_COUNT.TabIndex = 3;
            this.LABEL_COUNT.Text = "0 - Not Started!";
            // 
            // LABEL_TIME
            // 
            this.LABEL_TIME.AutoSize = true;
            this.LABEL_TIME.Location = new System.Drawing.Point(37, 418);
            this.LABEL_TIME.Name = "LABEL_TIME";
            this.LABEL_TIME.Size = new System.Drawing.Size(232, 25);
            this.LABEL_TIME.TabIndex = 4;
            this.LABEL_TIME.Text = "DD:MM:YY HH:MM:SS";
            // 
            // Timer_time
            // 
            this.Timer_time.Enabled = true;
            this.Timer_time.Interval = 1000;
            this.Timer_time.Tick += new System.EventHandler(this.Timer_time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 572);
            this.Controls.Add(this.LABEL_TIME);
            this.Controls.Add(this.LABEL_COUNTER);
            this.Controls.Add(this.LABEL_COUNT);
            this.Controls.Add(this.LABEL_GATE_NO);
            this.Controls.Add(this.LABEL_GATE);
            this.Controls.Add(this.PB_Brady);
            this.Controls.Add(this.PB_Sunway);
            this.Controls.Add(this.btn_print);
            this.Name = "Form1";
            this.Text = "Printer Demo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sunway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Brady)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox PB_Sunway;
        private System.Windows.Forms.PictureBox PB_Brady;
        private System.Windows.Forms.Label LABEL_GATE;
        private System.Windows.Forms.Label LABEL_COUNTER;
        private System.Windows.Forms.Label LABEL_GATE_NO;
        private System.Windows.Forms.Label LABEL_COUNT;
        private System.Windows.Forms.Label LABEL_TIME;
        private System.Windows.Forms.Timer Timer_time;
    }
}

