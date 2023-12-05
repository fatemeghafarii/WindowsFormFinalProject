namespace AirPlaneTicketWinFormsApp.Flights
{
    partial class AddFlightTicketForm
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
            this.CbFlightClass = new System.Windows.Forms.ComboBox();
            this.CbAirplane = new System.Windows.Forms.ComboBox();
            this.DtpFlightDate = new System.Windows.Forms.DateTimePicker();
            this.DtpLandingDate = new System.Windows.Forms.DateTimePicker();
            this.CbOrigin = new System.Windows.Forms.ComboBox();
            this.CbDestination = new System.Windows.Forms.ComboBox();
            this.TxtFlightTime = new System.Windows.Forms.TextBox();
            this.TxtLandingTime = new System.Windows.Forms.TextBox();
            this.BtnAddFlightTicket = new System.Windows.Forms.Button();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbFlightClass
            // 
            this.CbFlightClass.FormattingEnabled = true;
            this.CbFlightClass.Location = new System.Drawing.Point(609, 109);
            this.CbFlightClass.Name = "CbFlightClass";
            this.CbFlightClass.Size = new System.Drawing.Size(151, 28);
            this.CbFlightClass.TabIndex = 0;
            // 
            // CbAirplane
            // 
            this.CbAirplane.FormattingEnabled = true;
            this.CbAirplane.Location = new System.Drawing.Point(609, 43);
            this.CbAirplane.Name = "CbAirplane";
            this.CbAirplane.Size = new System.Drawing.Size(151, 28);
            this.CbAirplane.TabIndex = 1;
            // 
            // DtpFlightDate
            // 
            this.DtpFlightDate.Location = new System.Drawing.Point(83, 44);
            this.DtpFlightDate.Name = "DtpFlightDate";
            this.DtpFlightDate.Size = new System.Drawing.Size(250, 27);
            this.DtpFlightDate.TabIndex = 2;
            // 
            // DtpLandingDate
            // 
            this.DtpLandingDate.Location = new System.Drawing.Point(22, 385);
            this.DtpLandingDate.Name = "DtpLandingDate";
            this.DtpLandingDate.Size = new System.Drawing.Size(250, 27);
            this.DtpLandingDate.TabIndex = 2;
            this.DtpLandingDate.Visible = false;
            // 
            // CbOrigin
            // 
            this.CbOrigin.FormattingEnabled = true;
            this.CbOrigin.Location = new System.Drawing.Point(600, 175);
            this.CbOrigin.Name = "CbOrigin";
            this.CbOrigin.Size = new System.Drawing.Size(151, 28);
            this.CbOrigin.TabIndex = 0;
            // 
            // CbDestination
            // 
            this.CbDestination.FormattingEnabled = true;
            this.CbDestination.Location = new System.Drawing.Point(206, 175);
            this.CbDestination.Name = "CbDestination";
            this.CbDestination.Size = new System.Drawing.Size(151, 28);
            this.CbDestination.TabIndex = 0;
            // 
            // TxtFlightTime
            // 
            this.TxtFlightTime.Location = new System.Drawing.Point(609, 226);
            this.TxtFlightTime.Name = "TxtFlightTime";
            this.TxtFlightTime.Size = new System.Drawing.Size(125, 27);
            this.TxtFlightTime.TabIndex = 3;
            // 
            // TxtLandingTime
            // 
            this.TxtLandingTime.Location = new System.Drawing.Point(208, 226);
            this.TxtLandingTime.Name = "TxtLandingTime";
            this.TxtLandingTime.Size = new System.Drawing.Size(125, 27);
            this.TxtLandingTime.TabIndex = 3;
            // 
            // BtnAddFlightTicket
            // 
            this.BtnAddFlightTicket.Location = new System.Drawing.Point(409, 367);
            this.BtnAddFlightTicket.Name = "BtnAddFlightTicket";
            this.BtnAddFlightTicket.Size = new System.Drawing.Size(94, 29);
            this.BtnAddFlightTicket.TabIndex = 4;
            this.BtnAddFlightTicket.Text = "ثبت";
            this.BtnAddFlightTicket.UseVisualStyleBackColor = true;
            this.BtnAddFlightTicket.Click += new System.EventHandler(this.BtnAddFlightTicket_Click);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(208, 297);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(125, 27);
            this.TxtPrice.TabIndex = 3;
            // 
            // AddFlightTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddFlightTicket);
            this.Controls.Add(this.TxtLandingTime);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtFlightTime);
            this.Controls.Add(this.DtpLandingDate);
            this.Controls.Add(this.DtpFlightDate);
            this.Controls.Add(this.CbAirplane);
            this.Controls.Add(this.CbDestination);
            this.Controls.Add(this.CbOrigin);
            this.Controls.Add(this.CbFlightClass);
            this.Name = "AddFlightTicketForm";
            this.Text = "AddFlightTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbFlightClass;
        private System.Windows.Forms.ComboBox CbAirplane;
        private System.Windows.Forms.DateTimePicker DtpFlightDate;
        private System.Windows.Forms.DateTimePicker DtpLandingDate;
        private System.Windows.Forms.ComboBox CbOrigin;
        private System.Windows.Forms.ComboBox CbDestination;
        private System.Windows.Forms.TextBox TxtFlightTime;
        private System.Windows.Forms.TextBox TxtLandingTime;
        private System.Windows.Forms.Button BtnAddFlightTicket;
        private System.Windows.Forms.TextBox TxtPrice;
    }
}