namespace AirPlaneTicketWinFormsApp.Flights
{
    partial class FlightTicketSearchResultDisplayForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Flp);
            this.groupBox1.Location = new System.Drawing.Point(2, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 775);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Flp
            // 
            this.Flp.AutoScroll = true;
            this.Flp.Location = new System.Drawing.Point(6, 76);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(891, 555);
            this.Flp.TabIndex = 1;
            // 
            // FlightTicketSearchResultDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 861);
            this.Controls.Add(this.groupBox1);
            this.Name = "FlightTicketSearchResultDisplayForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FlightTicketSearchResultDisplayForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.FlowLayoutPanel Flp;
    }
}