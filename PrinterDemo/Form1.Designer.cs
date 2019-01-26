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
            this.LABEL_DATE = new System.Windows.Forms.Label();
            this.Timer_time = new System.Windows.Forms.Timer(this.components);
            this.down_arrow = new System.Windows.Forms.PictureBox();
            this.up_arrow = new System.Windows.Forms.PictureBox();
            this.TB_ManualCount = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LABEL_TIME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sunway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Brady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.RtsEnable = true;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_print.Location = new System.Drawing.Point(959, 500);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(212, 79);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Re-Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // PB_Sunway
            // 
            this.PB_Sunway.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PB_Sunway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_Sunway.Enabled = false;
            this.PB_Sunway.Image = ((System.Drawing.Image)(resources.GetObject("PB_Sunway.Image")));
            this.PB_Sunway.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Sunway.InitialImage")));
            this.PB_Sunway.Location = new System.Drawing.Point(228, -1);
            this.PB_Sunway.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Sunway.Name = "PB_Sunway";
            this.PB_Sunway.Size = new System.Drawing.Size(974, 358);
            this.PB_Sunway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Sunway.TabIndex = 1;
            this.PB_Sunway.TabStop = false;
            // 
            // PB_Brady
            // 
            this.PB_Brady.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Brady.Image = ((System.Drawing.Image)(resources.GetObject("PB_Brady.Image")));
            this.PB_Brady.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Brady.InitialImage")));
            this.PB_Brady.Location = new System.Drawing.Point(1122, 765);
            this.PB_Brady.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Brady.Name = "PB_Brady";
            this.PB_Brady.Size = new System.Drawing.Size(260, 63);
            this.PB_Brady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Brady.TabIndex = 2;
            this.PB_Brady.TabStop = false;
            // 
            // LABEL_GATE
            // 
            this.LABEL_GATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_GATE.AutoSize = true;
            this.LABEL_GATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL_GATE.Image = ((System.Drawing.Image)(resources.GetObject("LABEL_GATE.Image")));
            this.LABEL_GATE.Location = new System.Drawing.Point(36, 378);
            this.LABEL_GATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_GATE.Name = "LABEL_GATE";
            this.LABEL_GATE.Size = new System.Drawing.Size(75, 25);
            this.LABEL_GATE.TabIndex = 3;
            this.LABEL_GATE.Text = "GATE:";
            this.LABEL_GATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL_COUNTER
            // 
            this.LABEL_COUNTER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_COUNTER.AutoSize = true;
            this.LABEL_COUNTER.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LABEL_COUNTER.Image = ((System.Drawing.Image)(resources.GetObject("LABEL_COUNTER.Image")));
            this.LABEL_COUNTER.Location = new System.Drawing.Point(36, 430);
            this.LABEL_COUNTER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_COUNTER.Name = "LABEL_COUNTER";
            this.LABEL_COUNTER.Size = new System.Drawing.Size(94, 25);
            this.LABEL_COUNTER.TabIndex = 3;
            this.LABEL_COUNTER.Text = "Counter:";
            // 
            // LABEL_GATE_NO
            // 
            this.LABEL_GATE_NO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_GATE_NO.AutoSize = true;
            this.LABEL_GATE_NO.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_GATE_NO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL_GATE_NO.Image = ((System.Drawing.Image)(resources.GetObject("LABEL_GATE_NO.Image")));
            this.LABEL_GATE_NO.Location = new System.Drawing.Point(142, 378);
            this.LABEL_GATE_NO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_GATE_NO.Name = "LABEL_GATE_NO";
            this.LABEL_GATE_NO.Size = new System.Drawing.Size(104, 25);
            this.LABEL_GATE_NO.TabIndex = 3;
            this.LABEL_GATE_NO.Text = "Not setup";
            // 
            // LABEL_COUNT
            // 
            this.LABEL_COUNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_COUNT.AutoSize = true;
            this.LABEL_COUNT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL_COUNT.Image = ((System.Drawing.Image)(resources.GetObject("LABEL_COUNT.Image")));
            this.LABEL_COUNT.Location = new System.Drawing.Point(142, 430);
            this.LABEL_COUNT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_COUNT.Name = "LABEL_COUNT";
            this.LABEL_COUNT.Size = new System.Drawing.Size(24, 25);
            this.LABEL_COUNT.TabIndex = 3;
            this.LABEL_COUNT.Text = "0";
            // 
            // LABEL_DATE
            // 
            this.LABEL_DATE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LABEL_DATE.AutoSize = true;
            this.LABEL_DATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL_DATE.Image = ((System.Drawing.Image)(resources.GetObject("LABEL_DATE.Image")));
            this.LABEL_DATE.Location = new System.Drawing.Point(952, 388);
            this.LABEL_DATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_DATE.Name = "LABEL_DATE";
            this.LABEL_DATE.Size = new System.Drawing.Size(120, 25);
            this.LABEL_DATE.TabIndex = 4;
            this.LABEL_DATE.Text = "DD:MM:YY";
            // 
            // Timer_time
            // 
            this.Timer_time.Enabled = true;
            this.Timer_time.Interval = 1000;
            this.Timer_time.Tick += new System.EventHandler(this.Timer_time_Tick);
            // 
            // down_arrow
            // 
            this.down_arrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.down_arrow.Image = ((System.Drawing.Image)(resources.GetObject("down_arrow.Image")));
            this.down_arrow.Location = new System.Drawing.Point(745, 543);
            this.down_arrow.Margin = new System.Windows.Forms.Padding(4);
            this.down_arrow.Name = "down_arrow";
            this.down_arrow.Size = new System.Drawing.Size(115, 84);
            this.down_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.down_arrow.TabIndex = 6;
            this.down_arrow.TabStop = false;
            this.down_arrow.Visible = false;
            this.down_arrow.Click += new System.EventHandler(this.down_arrow_Click);
            // 
            // up_arrow
            // 
            this.up_arrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.up_arrow.Image = ((System.Drawing.Image)(resources.GetObject("up_arrow.Image")));
            this.up_arrow.Location = new System.Drawing.Point(745, 451);
            this.up_arrow.Margin = new System.Windows.Forms.Padding(4);
            this.up_arrow.Name = "up_arrow";
            this.up_arrow.Size = new System.Drawing.Size(115, 84);
            this.up_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.up_arrow.TabIndex = 5;
            this.up_arrow.TabStop = false;
            this.up_arrow.Visible = false;
            this.up_arrow.Click += new System.EventHandler(this.up_arrow_Click);
            // 
            // TB_ManualCount
            // 
            this.TB_ManualCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TB_ManualCount.Location = new System.Drawing.Point(589, 524);
            this.TB_ManualCount.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ManualCount.Name = "TB_ManualCount";
            this.TB_ManualCount.Size = new System.Drawing.Size(105, 31);
            this.TB_ManualCount.TabIndex = 7;
            this.TB_ManualCount.Text = "0";
            this.TB_ManualCount.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(897, 783);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 29);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "ByPass Sensor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1433, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LABEL_TIME
            // 
            this.LABEL_TIME.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LABEL_TIME.AutoSize = true;
            this.LABEL_TIME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL_TIME.Image = ((System.Drawing.Image)(resources.GetObject("LABEL_TIME.Image")));
            this.LABEL_TIME.Location = new System.Drawing.Point(954, 430);
            this.LABEL_TIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_TIME.Name = "LABEL_TIME";
            this.LABEL_TIME.Size = new System.Drawing.Size(118, 25);
            this.LABEL_TIME.TabIndex = 11;
            this.LABEL_TIME.Text = "HH:MM:SS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 829);
            this.Controls.Add(this.LABEL_TIME);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TB_ManualCount);
            this.Controls.Add(this.down_arrow);
            this.Controls.Add(this.up_arrow);
            this.Controls.Add(this.LABEL_DATE);
            this.Controls.Add(this.LABEL_COUNTER);
            this.Controls.Add(this.LABEL_COUNT);
            this.Controls.Add(this.LABEL_GATE_NO);
            this.Controls.Add(this.LABEL_GATE);
            this.Controls.Add(this.PB_Brady);
            this.Controls.Add(this.PB_Sunway);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Printer Demo";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sunway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Brady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label LABEL_DATE;
        private System.Windows.Forms.Timer Timer_time;
        private System.Windows.Forms.PictureBox down_arrow;
        private System.Windows.Forms.PictureBox up_arrow;
        private System.Windows.Forms.TextBox TB_ManualCount;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LABEL_TIME;
    }
}

