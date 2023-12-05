namespace AirPlaneTicketWinFormsApp.UserControls
{
    partial class UserFlightSearchControl
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
            this.LblCityOrigin = new System.Windows.Forms.Label();
            this.LblCityDestination = new System.Windows.Forms.Label();
            this.LblFlightDate = new System.Windows.Forms.Label();
            this.LblFlightClass = new System.Windows.Forms.Label();
            this.LblNumberPassengers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCityOrigin
            // 
            this.LblCityOrigin.AutoSize = true;
            this.LblCityOrigin.Location = new System.Drawing.Point(563, 31);
            this.LblCityOrigin.Name = "LblCityOrigin";
            this.LblCityOrigin.Size = new System.Drawing.Size(50, 20);
            this.LblCityOrigin.TabIndex = 1;
            this.LblCityOrigin.Text = "label1";
            // 
            // LblCityDestination
            // 
            this.LblCityDestination.AutoSize = true;
            this.LblCityDestination.Location = new System.Drawing.Point(430, 31);
            this.LblCityDestination.Name = "LblCityDestination";
            this.LblCityDestination.Size = new System.Drawing.Size(50, 20);
            this.LblCityDestination.TabIndex = 2;
            this.LblCityDestination.Text = "label1";
            // 
            // LblFlightDate
            // 
            this.LblFlightDate.AutoSize = true;
            this.LblFlightDate.Location = new System.Drawing.Point(281, 31);
            this.LblFlightDate.Name = "LblFlightDate";
            this.LblFlightDate.Size = new System.Drawing.Size(50, 20);
            this.LblFlightDate.TabIndex = 3;
            this.LblFlightDate.Text = "label1";
            // 
            // LblFlightClass
            // 
            this.LblFlightClass.AutoSize = true;
            this.LblFlightClass.Location = new System.Drawing.Point(35, 31);
            this.LblFlightClass.Name = "LblFlightClass";
            this.LblFlightClass.Size = new System.Drawing.Size(50, 20);
            this.LblFlightClass.TabIndex = 4;
            this.LblFlightClass.Text = "label1";
            // 
            // LblNumberPassengers
            // 
            this.LblNumberPassengers.AutoSize = true;
            this.LblNumberPassengers.Location = new System.Drawing.Point(149, 31);
            this.LblNumberPassengers.Name = "LblNumberPassengers";
            this.LblNumberPassengers.Size = new System.Drawing.Size(50, 20);
            this.LblNumberPassengers.TabIndex = 4;
            this.LblNumberPassengers.Text = "label1";
            // 
            // UserFlightSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblNumberPassengers);
            this.Controls.Add(this.LblFlightClass);
            this.Controls.Add(this.LblFlightDate);
            this.Controls.Add(this.LblCityDestination);
            this.Controls.Add(this.LblCityOrigin);
            this.Name = "UserFlightSearchControl";
            this.Size = new System.Drawing.Size(647, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblCityOrigin;
        public System.Windows.Forms.Label LblCityDestination;
        public System.Windows.Forms.Label LblFlightDate;
        public System.Windows.Forms.Label LblFlightClass;
        public System.Windows.Forms.Label LblNumberPassengers;
    }
}
