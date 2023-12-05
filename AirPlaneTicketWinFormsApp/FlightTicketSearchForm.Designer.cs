using System.Windows.Forms;
using AirPlaneTicketWinFormsApp.UserControls;

namespace AirPlaneTicketWinFormsApp
{
    partial class FlightTicketSearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customUpDown2 = new AirPlaneTicketWinFormsApp.UserControls.CustomUpDown();
            this.customUpDown1 = new AirPlaneTicketWinFormsApp.UserControls.CustomUpDown();
            this.customUpDown6 = new AirPlaneTicketWinFormsApp.UserControls.CustomUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnOneWay = new AirPlaneTicketWinFormsApp.UserControls.RJButton();
            this.BtnRoundTrip = new AirPlaneTicketWinFormsApp.UserControls.RJButton();
            this.BtnMultiCity = new AirPlaneTicketWinFormsApp.UserControls.RJButton();
            this.CbFlightClass = new System.Windows.Forms.ComboBox();
            this.customUpDown3 = new AirPlaneTicketWinFormsApp.UserControls.CustomUpDown();
            this.customUpDown4 = new AirPlaneTicketWinFormsApp.UserControls.CustomUpDown();
            this.customUpDown5 = new AirPlaneTicketWinFormsApp.UserControls.CustomUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnAddFlight = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customUpDown2
            // 
            this.customUpDown2.BackColor = System.Drawing.Color.White;
            this.customUpDown2.ButtonBackColor = System.Drawing.Color.Empty;
            this.customUpDown2.ButtonForeColor = System.Drawing.Color.Gray;
            this.customUpDown2.ButtonStyle = CustomUpDown.ButtonDisplay.PlusMinus3;
            this.customUpDown2.DecimalPlaces = 0;
            this.customUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customUpDown2.Location = new System.Drawing.Point(24, 166);
            this.customUpDown2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.customUpDown2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customUpDown2.Name = "customUpDown2";
            this.customUpDown2.RepeatDelayMs = 100;
            this.customUpDown2.Size = new System.Drawing.Size(164, 33);
            this.customUpDown2.TabIndex = 25;
            this.customUpDown2.Text = "نوزادان";
            this.customUpDown2.TextBackColor = System.Drawing.Color.White;
            this.customUpDown2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // customUpDown1
            // 
            this.customUpDown1.BackColor = System.Drawing.Color.White;
            this.customUpDown1.ButtonBackColor = System.Drawing.Color.Empty;
            this.customUpDown1.ButtonForeColor = System.Drawing.Color.Gray;
            this.customUpDown1.ButtonStyle = CustomUpDown.ButtonDisplay.PlusMinus3;
            this.customUpDown1.DecimalPlaces = 0;
            this.customUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customUpDown1.Location = new System.Drawing.Point(24, 118);
            this.customUpDown1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.customUpDown1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customUpDown1.Name = "customUpDown1";
            this.customUpDown1.RepeatDelayMs = 100;
            this.customUpDown1.Size = new System.Drawing.Size(164, 38);
            this.customUpDown1.TabIndex = 26;
            this.customUpDown1.Text = "کودکان";
            this.customUpDown1.TextBackColor = System.Drawing.Color.White;
            this.customUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // customUpDown6
            // 
            this.customUpDown6.BackColor = System.Drawing.Color.White;
            this.customUpDown6.ButtonBackColor = System.Drawing.Color.Empty;
            this.customUpDown6.ButtonForeColor = System.Drawing.Color.Gray;
            this.customUpDown6.ButtonStyle = CustomUpDown.ButtonDisplay.PlusMinus3;
            this.customUpDown6.DecimalPlaces = 0;
            this.customUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customUpDown6.Location = new System.Drawing.Point(24, 71);
            this.customUpDown6.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.customUpDown6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customUpDown6.Name = "customUpDown6";
            this.customUpDown6.RepeatDelayMs = 100;
            this.customUpDown6.Size = new System.Drawing.Size(164, 38);
            this.customUpDown6.TabIndex = 27;
            this.customUpDown6.Text = "بزرگسالان";
            this.customUpDown6.TextBackColor = System.Drawing.Color.White;
            this.customUpDown6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 27);
            this.textBox1.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(5, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 164);
            this.listBox1.TabIndex = 0;
            // 
            // BtnOneWay
            // 
            this.BtnOneWay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnOneWay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnOneWay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnOneWay.BorderRadius = 10;
            this.BtnOneWay.BorderSize = 0;
            this.BtnOneWay.FlatAppearance.BorderSize = 0;
            this.BtnOneWay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOneWay.ForeColor = System.Drawing.Color.White;
            this.BtnOneWay.Location = new System.Drawing.Point(12, 12);
            this.BtnOneWay.Name = "BtnOneWay";
            this.BtnOneWay.Size = new System.Drawing.Size(132, 50);
            this.BtnOneWay.TabIndex = 0;
            this.BtnOneWay.Text = "رفت";
            this.BtnOneWay.TextColor = System.Drawing.Color.White;
            this.BtnOneWay.UseVisualStyleBackColor = false;
            this.BtnOneWay.Click += new System.EventHandler(this.BtnOneWay_Click);
            // 
            // BtnRoundTrip
            // 
            this.BtnRoundTrip.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnRoundTrip.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnRoundTrip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRoundTrip.BorderRadius = 10;
            this.BtnRoundTrip.BorderSize = 0;
            this.BtnRoundTrip.FlatAppearance.BorderSize = 0;
            this.BtnRoundTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoundTrip.ForeColor = System.Drawing.Color.White;
            this.BtnRoundTrip.Location = new System.Drawing.Point(162, 12);
            this.BtnRoundTrip.Name = "BtnRoundTrip";
            this.BtnRoundTrip.Size = new System.Drawing.Size(132, 50);
            this.BtnRoundTrip.TabIndex = 0;
            this.BtnRoundTrip.Text = "رفت و برگشت";
            this.BtnRoundTrip.TextColor = System.Drawing.Color.White;
            this.BtnRoundTrip.UseVisualStyleBackColor = false;
            this.BtnRoundTrip.Click += new System.EventHandler(this.BtnRoundTrip_Click);
            // 
            // BtnMultiCity
            // 
            this.BtnMultiCity.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMultiCity.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMultiCity.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMultiCity.BorderRadius = 10;
            this.BtnMultiCity.BorderSize = 0;
            this.BtnMultiCity.FlatAppearance.BorderSize = 0;
            this.BtnMultiCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiCity.ForeColor = System.Drawing.Color.White;
            this.BtnMultiCity.Location = new System.Drawing.Point(311, 12);
            this.BtnMultiCity.Name = "BtnMultiCity";
            this.BtnMultiCity.Size = new System.Drawing.Size(132, 50);
            this.BtnMultiCity.TabIndex = 0;
            this.BtnMultiCity.Text = "چند مسیره";
            this.BtnMultiCity.TextColor = System.Drawing.Color.White;
            this.BtnMultiCity.UseVisualStyleBackColor = false;
            this.BtnMultiCity.Click += new System.EventHandler(this.BtnMultiCity_Click);
            // 
            // CbFlightClass
            // 
            this.CbFlightClass.FormattingEnabled = true;
            this.CbFlightClass.Location = new System.Drawing.Point(487, 34);
            this.CbFlightClass.Name = "CbFlightClass";
            this.CbFlightClass.Size = new System.Drawing.Size(151, 28);
            this.CbFlightClass.TabIndex = 29;
            // 
            // customUpDown3
            // 
            this.customUpDown3.BackColor = System.Drawing.Color.White;
            this.customUpDown3.ButtonBackColor = System.Drawing.Color.Empty;
            this.customUpDown3.ButtonForeColor = System.Drawing.Color.Gray;
            this.customUpDown3.ButtonStyle = CustomUpDown.ButtonDisplay.PlusMinus3;
            this.customUpDown3.DecimalPlaces = 0;
            this.customUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customUpDown3.Location = new System.Drawing.Point(700, 177);
            this.customUpDown3.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.customUpDown3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customUpDown3.Name = "customUpDown3";
            this.customUpDown3.RepeatDelayMs = 100;
            this.customUpDown3.Size = new System.Drawing.Size(164, 33);
            this.customUpDown3.TabIndex = 26;
            this.customUpDown3.Text = "نوزادان";
            this.customUpDown3.TextBackColor = System.Drawing.Color.White;
            this.customUpDown3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // customUpDown4
            // 
            this.customUpDown4.BackColor = System.Drawing.Color.White;
            this.customUpDown4.ButtonBackColor = System.Drawing.Color.Empty;
            this.customUpDown4.ButtonForeColor = System.Drawing.Color.Gray;
            this.customUpDown4.ButtonStyle = CustomUpDown.ButtonDisplay.PlusMinus3;
            this.customUpDown4.DecimalPlaces = 0;
            this.customUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customUpDown4.Location = new System.Drawing.Point(700, 129);
            this.customUpDown4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.customUpDown4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customUpDown4.Name = "customUpDown4";
            this.customUpDown4.RepeatDelayMs = 100;
            this.customUpDown4.Size = new System.Drawing.Size(164, 38);
            this.customUpDown4.TabIndex = 27;
            this.customUpDown4.Text = "کودکان";
            this.customUpDown4.TextBackColor = System.Drawing.Color.White;
            this.customUpDown4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // customUpDown5
            // 
            this.customUpDown5.BackColor = System.Drawing.Color.White;
            this.customUpDown5.ButtonBackColor = System.Drawing.Color.Empty;
            this.customUpDown5.ButtonForeColor = System.Drawing.Color.Gray;
            this.customUpDown5.ButtonStyle = CustomUpDown.ButtonDisplay.PlusMinus3;
            this.customUpDown5.DecimalPlaces = 0;
            this.customUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customUpDown5.Location = new System.Drawing.Point(700, 82);
            this.customUpDown5.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.customUpDown5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customUpDown5.Name = "customUpDown5";
            this.customUpDown5.RepeatDelayMs = 100;
            this.customUpDown5.Size = new System.Drawing.Size(164, 38);
            this.customUpDown5.TabIndex = 28;
            this.customUpDown5.Text = "بزرگسالان";
            this.customUpDown5.TextBackColor = System.Drawing.Color.White;
            this.customUpDown5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(682, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 27);
            this.textBox2.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(681, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(216, 164);
            this.listBox2.TabIndex = 24;
            // 
            // BtnAddFlight
            // 
            this.BtnAddFlight.Location = new System.Drawing.Point(3, 3);
            this.BtnAddFlight.Name = "BtnAddFlight";
            this.BtnAddFlight.Size = new System.Drawing.Size(94, 29);
            this.BtnAddFlight.TabIndex = 30;
            this.BtnAddFlight.Text = "اضافه کردن";
            this.BtnAddFlight.UseVisualStyleBackColor = true;
            this.BtnAddFlight.Click += new System.EventHandler(this.BtnAddFlight_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnAddFlight);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 239);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 589);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "لوگوی شرکت های هواپیمایی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(962, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "اد کردن بلیط پرواز";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(3, 852);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(94, 29);
            this.BtnSearch.TabIndex = 34;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FlightTicketSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 994);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CbFlightClass);
            this.Controls.Add(this.customUpDown3);
            this.Controls.Add(this.customUpDown4);
            this.Controls.Add(this.customUpDown5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnMultiCity);
            this.Controls.Add(this.BtnRoundTrip);
            this.Controls.Add(this.BtnOneWay);
            this.Name = "FlightTicketSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FlightSelectForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomUpDown customUpDown2;
        private CustomUpDown customUpDown1;
        private CustomUpDown customUpDown6;
        private TextBox textBox1;
        private ListBox listBox1;
        private RJButton BtnOneWay;
        private RJButton BtnRoundTrip;
        private RJButton BtnMultiCity;
        private CustomUpDown customUpDown3;
        private CustomUpDown customUpDown4;
        private CustomUpDown customUpDown5;
        private TextBox textBox2;
        private ListBox listBox2;
        private Button BtnAddFlight;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button BtnSearch;
        public ComboBox CbFlightClass;
    }
}
