namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentOutput = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.testingLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.searchLineLabel = new System.Windows.Forms.Label();
            this.searchLine = new System.Windows.Forms.Label();
            this.timeOutput = new System.Windows.Forms.Label();
            this.dayOfWeekOutput = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bigTempOutput = new System.Windows.Forms.Label();
            this.dailyLowOutput = new System.Windows.Forms.Label();
            this.dailyHighOutput = new System.Windows.Forms.Label();
            this.celsuis2 = new System.Windows.Forms.Label();
            this.celsius3 = new System.Windows.Forms.Label();
            this.sunSetOutput = new System.Windows.Forms.Label();
            this.sunRiseOutput = new System.Windows.Forms.Label();
            this.forecastTemp1 = new System.Windows.Forms.Label();
            this.forecastTemp2 = new System.Windows.Forms.Label();
            this.forecastTemp3 = new System.Windows.Forms.Label();
            this.forecastTemp4 = new System.Windows.Forms.Label();
            this.forecastTemp5 = new System.Windows.Forms.Label();
            this.forecastIcon1 = new System.Windows.Forms.PictureBox();
            this.forecastIcon3 = new System.Windows.Forms.PictureBox();
            this.forecastIcon2 = new System.Windows.Forms.PictureBox();
            this.forecastIcon5 = new System.Windows.Forms.PictureBox();
            this.forecastIcon4 = new System.Windows.Forms.PictureBox();
            this.highLow1 = new System.Windows.Forms.Label();
            this.highLow2 = new System.Windows.Forms.Label();
            this.highLow3 = new System.Windows.Forms.Label();
            this.highLow4 = new System.Windows.Forms.Label();
            this.highLow5 = new System.Windows.Forms.Label();
            this.celsius1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon4)).BeginInit();
            this.SuspendLayout();
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(50, 57);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(83, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(139, 57);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            // 
            // testingLabel
            // 
            this.testingLabel.BackColor = System.Drawing.Color.Chartreuse;
            this.testingLabel.ForeColor = System.Drawing.Color.Red;
            this.testingLabel.Location = new System.Drawing.Point(236, -260);
            this.testingLabel.Name = "testingLabel";
            this.testingLabel.Size = new System.Drawing.Size(198, 294);
            this.testingLabel.TabIndex = 43;
            this.testingLabel.Text = "testingBox";
            // 
            // cityInput
            // 
            this.cityInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityInput.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cityInput.Location = new System.Drawing.Point(72, 46);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(172, 34);
            this.cityInput.TabIndex = 44;
            this.cityInput.Text = "Stratford,CA";
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTest.Image = global::XMLWeather.Properties.Resources.Search_Icon;
            this.pictureBoxTest.Location = new System.Drawing.Point(13, 46);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(52, 39);
            this.pictureBoxTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTest.TabIndex = 48;
            this.pictureBoxTest.TabStop = false;
            this.pictureBoxTest.Click += new System.EventHandler(this.pictureBoxTest_Click);
            // 
            // searchLineLabel
            // 
            this.searchLineLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLineLabel.ForeColor = System.Drawing.Color.Black;
            this.searchLineLabel.Location = new System.Drawing.Point(60, 57);
            this.searchLineLabel.Name = "searchLineLabel";
            this.searchLineLabel.Size = new System.Drawing.Size(153, 27);
            this.searchLineLabel.TabIndex = 47;
            this.searchLineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchLine
            // 
            this.searchLine.BackColor = System.Drawing.Color.Transparent;
            this.searchLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLine.Location = new System.Drawing.Point(55, 34);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(215, 68);
            this.searchLine.TabIndex = 49;
            this.searchLine.Text = "__________________";
            // 
            // timeOutput
            // 
            this.timeOutput.BackColor = System.Drawing.Color.Transparent;
            this.timeOutput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutput.Location = new System.Drawing.Point(59, 13);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(156, 33);
            this.timeOutput.TabIndex = 51;
            this.timeOutput.Text = "12:25 PM";
            this.timeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOfWeekOutput
            // 
            this.dayOfWeekOutput.BackColor = System.Drawing.Color.Transparent;
            this.dayOfWeekOutput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dayOfWeekOutput.Location = new System.Drawing.Point(-1, 0);
            this.dayOfWeekOutput.Name = "dayOfWeekOutput";
            this.dayOfWeekOutput.Size = new System.Drawing.Size(117, 19);
            this.dayOfWeekOutput.TabIndex = 52;
            this.dayOfWeekOutput.Text = "Thu. Apr. 10";
            this.dayOfWeekOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionOutput
            // 
            this.conditionOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput.Location = new System.Drawing.Point(16, 179);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(83, 37);
            this.conditionOutput.TabIndex = 53;
            this.conditionOutput.Text = "Light Thunderstorm";
            this.conditionOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::XMLWeather.Properties.Resources.Partial_Cloudy_Day;
            this.pictureBox1.Location = new System.Drawing.Point(25, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // bigTempOutput
            // 
            this.bigTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.bigTempOutput.Font = new System.Drawing.Font("Century Gothic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTempOutput.Location = new System.Drawing.Point(122, 116);
            this.bigTempOutput.Name = "bigTempOutput";
            this.bigTempOutput.Size = new System.Drawing.Size(122, 78);
            this.bigTempOutput.TabIndex = 55;
            this.bigTempOutput.Text = "-23";
            this.bigTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dailyLowOutput
            // 
            this.dailyLowOutput.BackColor = System.Drawing.Color.Transparent;
            this.dailyLowOutput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyLowOutput.Location = new System.Drawing.Point(104, 183);
            this.dailyLowOutput.Name = "dailyLowOutput";
            this.dailyLowOutput.Size = new System.Drawing.Size(65, 33);
            this.dailyLowOutput.TabIndex = 57;
            this.dailyLowOutput.Text = "L: -10";
            this.dailyLowOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dailyHighOutput
            // 
            this.dailyHighOutput.BackColor = System.Drawing.Color.Transparent;
            this.dailyHighOutput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyHighOutput.Location = new System.Drawing.Point(173, 183);
            this.dailyHighOutput.Name = "dailyHighOutput";
            this.dailyHighOutput.Size = new System.Drawing.Size(67, 33);
            this.dailyHighOutput.TabIndex = 58;
            this.dailyHighOutput.Text = "H: 25";
            this.dailyHighOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // celsuis2
            // 
            this.celsuis2.BackColor = System.Drawing.Color.Transparent;
            this.celsuis2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsuis2.Location = new System.Drawing.Point(164, 185);
            this.celsuis2.Name = "celsuis2";
            this.celsuis2.Size = new System.Drawing.Size(26, 19);
            this.celsuis2.TabIndex = 59;
            this.celsuis2.Text = "°C";
            // 
            // celsius3
            // 
            this.celsius3.BackColor = System.Drawing.Color.Transparent;
            this.celsius3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsius3.Location = new System.Drawing.Point(236, 183);
            this.celsius3.Name = "celsius3";
            this.celsius3.Size = new System.Drawing.Size(26, 19);
            this.celsius3.TabIndex = 60;
            this.celsius3.Text = "°C";
            // 
            // sunSetOutput
            // 
            this.sunSetOutput.BackColor = System.Drawing.Color.Transparent;
            this.sunSetOutput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunSetOutput.Location = new System.Drawing.Point(198, 263);
            this.sunSetOutput.Name = "sunSetOutput";
            this.sunSetOutput.Size = new System.Drawing.Size(64, 19);
            this.sunSetOutput.TabIndex = 61;
            this.sunSetOutput.Text = "10:20 PM";
            this.sunSetOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunRiseOutput
            // 
            this.sunRiseOutput.BackColor = System.Drawing.Color.Transparent;
            this.sunRiseOutput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunRiseOutput.Location = new System.Drawing.Point(10, 263);
            this.sunRiseOutput.Name = "sunRiseOutput";
            this.sunRiseOutput.Size = new System.Drawing.Size(64, 19);
            this.sunRiseOutput.TabIndex = 62;
            this.sunRiseOutput.Text = "7:20 AM";
            this.sunRiseOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastTemp1
            // 
            this.forecastTemp1.BackColor = System.Drawing.Color.Transparent;
            this.forecastTemp1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp1.ForeColor = System.Drawing.SystemColors.Control;
            this.forecastTemp1.Location = new System.Drawing.Point(-3, 402);
            this.forecastTemp1.Name = "forecastTemp1";
            this.forecastTemp1.Size = new System.Drawing.Size(60, 33);
            this.forecastTemp1.TabIndex = 63;
            this.forecastTemp1.Text = "-10";
            this.forecastTemp1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // forecastTemp2
            // 
            this.forecastTemp2.BackColor = System.Drawing.Color.Transparent;
            this.forecastTemp2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp2.ForeColor = System.Drawing.SystemColors.Control;
            this.forecastTemp2.Location = new System.Drawing.Point(52, 402);
            this.forecastTemp2.Name = "forecastTemp2";
            this.forecastTemp2.Size = new System.Drawing.Size(60, 33);
            this.forecastTemp2.TabIndex = 64;
            this.forecastTemp2.Text = "-10";
            this.forecastTemp2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // forecastTemp3
            // 
            this.forecastTemp3.BackColor = System.Drawing.Color.Transparent;
            this.forecastTemp3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp3.ForeColor = System.Drawing.SystemColors.Control;
            this.forecastTemp3.Location = new System.Drawing.Point(104, 402);
            this.forecastTemp3.Name = "forecastTemp3";
            this.forecastTemp3.Size = new System.Drawing.Size(60, 33);
            this.forecastTemp3.TabIndex = 65;
            this.forecastTemp3.Text = "-10";
            this.forecastTemp3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // forecastTemp4
            // 
            this.forecastTemp4.BackColor = System.Drawing.Color.Transparent;
            this.forecastTemp4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp4.ForeColor = System.Drawing.SystemColors.Control;
            this.forecastTemp4.Location = new System.Drawing.Point(159, 402);
            this.forecastTemp4.Name = "forecastTemp4";
            this.forecastTemp4.Size = new System.Drawing.Size(60, 33);
            this.forecastTemp4.TabIndex = 66;
            this.forecastTemp4.Text = "-10";
            this.forecastTemp4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // forecastTemp5
            // 
            this.forecastTemp5.BackColor = System.Drawing.Color.Transparent;
            this.forecastTemp5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp5.ForeColor = System.Drawing.SystemColors.Control;
            this.forecastTemp5.Location = new System.Drawing.Point(213, 401);
            this.forecastTemp5.Name = "forecastTemp5";
            this.forecastTemp5.Size = new System.Drawing.Size(60, 33);
            this.forecastTemp5.TabIndex = 67;
            this.forecastTemp5.Text = "-10";
            this.forecastTemp5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // forecastIcon1
            // 
            this.forecastIcon1.BackColor = System.Drawing.Color.Transparent;
            this.forecastIcon1.Image = global::XMLWeather.Properties.Resources.Partial_Cloudy_Day;
            this.forecastIcon1.Location = new System.Drawing.Point(1, 379);
            this.forecastIcon1.Name = "forecastIcon1";
            this.forecastIcon1.Size = new System.Drawing.Size(54, 31);
            this.forecastIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forecastIcon1.TabIndex = 68;
            this.forecastIcon1.TabStop = false;
            // 
            // forecastIcon3
            // 
            this.forecastIcon3.BackColor = System.Drawing.Color.Transparent;
            this.forecastIcon3.Image = global::XMLWeather.Properties.Resources.Partial_Cloudy_Day;
            this.forecastIcon3.Location = new System.Drawing.Point(108, 379);
            this.forecastIcon3.Name = "forecastIcon3";
            this.forecastIcon3.Size = new System.Drawing.Size(54, 31);
            this.forecastIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forecastIcon3.TabIndex = 69;
            this.forecastIcon3.TabStop = false;
            // 
            // forecastIcon2
            // 
            this.forecastIcon2.BackColor = System.Drawing.Color.Transparent;
            this.forecastIcon2.Image = global::XMLWeather.Properties.Resources.Partial_Cloudy_Day;
            this.forecastIcon2.Location = new System.Drawing.Point(54, 379);
            this.forecastIcon2.Name = "forecastIcon2";
            this.forecastIcon2.Size = new System.Drawing.Size(54, 31);
            this.forecastIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forecastIcon2.TabIndex = 70;
            this.forecastIcon2.TabStop = false;
            // 
            // forecastIcon5
            // 
            this.forecastIcon5.BackColor = System.Drawing.Color.Transparent;
            this.forecastIcon5.Image = global::XMLWeather.Properties.Resources.Partial_Cloudy_Day;
            this.forecastIcon5.Location = new System.Drawing.Point(216, 379);
            this.forecastIcon5.Name = "forecastIcon5";
            this.forecastIcon5.Size = new System.Drawing.Size(54, 31);
            this.forecastIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forecastIcon5.TabIndex = 71;
            this.forecastIcon5.TabStop = false;
            // 
            // forecastIcon4
            // 
            this.forecastIcon4.BackColor = System.Drawing.Color.Transparent;
            this.forecastIcon4.Image = global::XMLWeather.Properties.Resources.Partial_Cloudy_Day;
            this.forecastIcon4.Location = new System.Drawing.Point(162, 379);
            this.forecastIcon4.Name = "forecastIcon4";
            this.forecastIcon4.Size = new System.Drawing.Size(54, 31);
            this.forecastIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forecastIcon4.TabIndex = 72;
            this.forecastIcon4.TabStop = false;
            // 
            // highLow1
            // 
            this.highLow1.BackColor = System.Drawing.Color.Transparent;
            this.highLow1.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLow1.ForeColor = System.Drawing.SystemColors.Control;
            this.highLow1.Location = new System.Drawing.Point(7, 431);
            this.highLow1.Name = "highLow1";
            this.highLow1.Size = new System.Drawing.Size(43, 39);
            this.highLow1.TabIndex = 73;
            this.highLow1.Text = "L: 12";
            this.highLow1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highLow2
            // 
            this.highLow2.BackColor = System.Drawing.Color.Transparent;
            this.highLow2.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLow2.ForeColor = System.Drawing.SystemColors.Control;
            this.highLow2.Location = new System.Drawing.Point(60, 431);
            this.highLow2.Name = "highLow2";
            this.highLow2.Size = new System.Drawing.Size(43, 39);
            this.highLow2.TabIndex = 74;
            this.highLow2.Text = "L: 12";
            this.highLow2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highLow3
            // 
            this.highLow3.BackColor = System.Drawing.Color.Transparent;
            this.highLow3.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLow3.ForeColor = System.Drawing.SystemColors.Control;
            this.highLow3.Location = new System.Drawing.Point(114, 430);
            this.highLow3.Name = "highLow3";
            this.highLow3.Size = new System.Drawing.Size(43, 40);
            this.highLow3.TabIndex = 75;
            this.highLow3.Text = "L: 12";
            this.highLow3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highLow4
            // 
            this.highLow4.BackColor = System.Drawing.Color.Transparent;
            this.highLow4.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLow4.ForeColor = System.Drawing.SystemColors.Control;
            this.highLow4.Location = new System.Drawing.Point(168, 430);
            this.highLow4.Name = "highLow4";
            this.highLow4.Size = new System.Drawing.Size(43, 40);
            this.highLow4.TabIndex = 76;
            this.highLow4.Text = "L: 12";
            this.highLow4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highLow5
            // 
            this.highLow5.BackColor = System.Drawing.Color.Transparent;
            this.highLow5.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLow5.ForeColor = System.Drawing.SystemColors.Control;
            this.highLow5.Location = new System.Drawing.Point(222, 429);
            this.highLow5.Name = "highLow5";
            this.highLow5.Size = new System.Drawing.Size(43, 41);
            this.highLow5.TabIndex = 77;
            this.highLow5.Text = "L: 12";
            this.highLow5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // celsius1
            // 
            this.celsius1.BackColor = System.Drawing.Color.Transparent;
            this.celsius1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsius1.Location = new System.Drawing.Point(222, 123);
            this.celsius1.Name = "celsius1";
            this.celsius1.Size = new System.Drawing.Size(30, 20);
            this.celsius1.TabIndex = 78;
            this.celsius1.Text = "°C";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Blank_Day;
            this.Controls.Add(this.celsius1);
            this.Controls.Add(this.highLow5);
            this.Controls.Add(this.highLow4);
            this.Controls.Add(this.highLow3);
            this.Controls.Add(this.highLow2);
            this.Controls.Add(this.highLow1);
            this.Controls.Add(this.dayOfWeekOutput);
            this.Controls.Add(this.testingLabel);
            this.Controls.Add(this.forecastIcon4);
            this.Controls.Add(this.forecastIcon5);
            this.Controls.Add(this.forecastIcon2);
            this.Controls.Add(this.forecastIcon3);
            this.Controls.Add(this.forecastIcon1);
            this.Controls.Add(this.forecastTemp5);
            this.Controls.Add(this.forecastTemp4);
            this.Controls.Add(this.forecastTemp3);
            this.Controls.Add(this.forecastTemp2);
            this.Controls.Add(this.forecastTemp1);
            this.Controls.Add(this.sunRiseOutput);
            this.Controls.Add(this.sunSetOutput);
            this.Controls.Add(this.celsius3);
            this.Controls.Add(this.celsuis2);
            this.Controls.Add(this.dailyHighOutput);
            this.Controls.Add(this.dailyLowOutput);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.bigTempOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.pictureBoxTest);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.searchLine);
            this.Controls.Add(this.searchLineLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.currentOutput);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(270, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIcon4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label testingLabel;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.PictureBox pictureBoxTest;
        private System.Windows.Forms.Label searchLineLabel;
        private System.Windows.Forms.Label searchLine;
        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.Label dayOfWeekOutput;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bigTempOutput;
        private System.Windows.Forms.Label dailyLowOutput;
        private System.Windows.Forms.Label dailyHighOutput;
        private System.Windows.Forms.Label celsuis2;
        private System.Windows.Forms.Label celsius3;
        private System.Windows.Forms.Label sunSetOutput;
        private System.Windows.Forms.Label sunRiseOutput;
        private System.Windows.Forms.Label forecastTemp1;
        private System.Windows.Forms.Label forecastTemp2;
        private System.Windows.Forms.Label forecastTemp3;
        private System.Windows.Forms.Label forecastTemp4;
        private System.Windows.Forms.Label forecastTemp5;
        private System.Windows.Forms.PictureBox forecastIcon1;
        private System.Windows.Forms.PictureBox forecastIcon3;
        private System.Windows.Forms.PictureBox forecastIcon2;
        private System.Windows.Forms.PictureBox forecastIcon5;
        private System.Windows.Forms.PictureBox forecastIcon4;
        private System.Windows.Forms.Label highLow1;
        private System.Windows.Forms.Label highLow2;
        private System.Windows.Forms.Label highLow3;
        private System.Windows.Forms.Label highLow4;
        private System.Windows.Forms.Label highLow5;
        private System.Windows.Forms.Label celsius1;
    }
}
