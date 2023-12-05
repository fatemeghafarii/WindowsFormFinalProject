namespace AirPlaneTicketWinFormsApp.UserControls
{
    partial class TicketTypeControl1
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
            this.LblCache = new System.Windows.Forms.Label();
            this.BtnMoveOriginAndDestination = new System.Windows.Forms.Button();
            this.LbDestination = new System.Windows.Forms.ListBox();
            this.CbDestination = new System.Windows.Forms.ComboBox();
            this.LbOrigin = new System.Windows.Forms.ListBox();
            this.CbOrigin = new System.Windows.Forms.ComboBox();
            this.DtpDepart = new System.Windows.Forms.DateTimePicker();
            this.rjToggleButton1 = new AirPlaneTicketWinFormsApp.UserControls.RJToggleButton();
            this.DtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LblCache
            // 
            this.LblCache.AutoSize = true;
            this.LblCache.Location = new System.Drawing.Point(289, 45);
            this.LblCache.Name = "LblCache";
            this.LblCache.Size = new System.Drawing.Size(50, 20);
            this.LblCache.TabIndex = 11;
            this.LblCache.Text = "label1";
            this.LblCache.Visible = false;
            // 
            // BtnMoveOriginAndDestination
            // 
            this.BtnMoveOriginAndDestination.Location = new System.Drawing.Point(273, 13);
            this.BtnMoveOriginAndDestination.Name = "BtnMoveOriginAndDestination";
            this.BtnMoveOriginAndDestination.Size = new System.Drawing.Size(94, 29);
            this.BtnMoveOriginAndDestination.TabIndex = 10;
            this.BtnMoveOriginAndDestination.Text = "button1";
            this.BtnMoveOriginAndDestination.UseVisualStyleBackColor = true;
            this.BtnMoveOriginAndDestination.Click += new System.EventHandler(this.BtnMoveOriginAndDestination_Click);
            // 
            // LbDestination
            // 
            this.LbDestination.FormattingEnabled = true;
            this.LbDestination.ItemHeight = 20;
            this.LbDestination.Location = new System.Drawing.Point(61, 41);
            this.LbDestination.Name = "LbDestination";
            this.LbDestination.Size = new System.Drawing.Size(150, 104);
            this.LbDestination.TabIndex = 9;
            this.LbDestination.SelectedIndexChanged += new System.EventHandler(this.LbDestination_SelectedIndexChanged);
            // 
            // CbDestination
            // 
            this.CbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbDestination.FormattingEnabled = true;
            this.CbDestination.Location = new System.Drawing.Point(61, 13);
            this.CbDestination.Name = "CbDestination";
            this.CbDestination.Size = new System.Drawing.Size(151, 28);
            this.CbDestination.TabIndex = 8;
            this.CbDestination.TextChanged += new System.EventHandler(this.CbDestination_TextChanged);
            // 
            // LbOrigin
            // 
            this.LbOrigin.FormattingEnabled = true;
            this.LbOrigin.ItemHeight = 20;
            this.LbOrigin.Location = new System.Drawing.Point(437, 41);
            this.LbOrigin.Name = "LbOrigin";
            this.LbOrigin.Size = new System.Drawing.Size(150, 104);
            this.LbOrigin.TabIndex = 7;
            this.LbOrigin.SelectedIndexChanged += new System.EventHandler(this.LbOrigin_SelectedIndexChanged);
            // 
            // CbOrigin
            // 
            this.CbOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbOrigin.FormattingEnabled = true;
            this.CbOrigin.Location = new System.Drawing.Point(437, 13);
            this.CbOrigin.Name = "CbOrigin";
            this.CbOrigin.Size = new System.Drawing.Size(151, 28);
            this.CbOrigin.TabIndex = 6;
            this.CbOrigin.TextChanged += new System.EventHandler(this.CbOrigin_TextChanged);
            // 
            // DtpDepart
            // 
            this.DtpDepart.Location = new System.Drawing.Point(390, 155);
            this.DtpDepart.Name = "DtpDepart";
            this.DtpDepart.Size = new System.Drawing.Size(240, 27);
            this.DtpDepart.TabIndex = 14;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(307, 155);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 24;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // DtpDeparture
            // 
            this.DtpDeparture.Location = new System.Drawing.Point(21, 160);
            this.DtpDeparture.Name = "DtpDeparture";
            this.DtpDeparture.Size = new System.Drawing.Size(250, 27);
            this.DtpDeparture.TabIndex = 25;
            // 
            // TicketTypeControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DtpDeparture);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.DtpDepart);
            this.Controls.Add(this.LblCache);
            this.Controls.Add(this.BtnMoveOriginAndDestination);
            this.Controls.Add(this.LbDestination);
            this.Controls.Add(this.CbDestination);
            this.Controls.Add(this.LbOrigin);
            this.Controls.Add(this.CbOrigin);
            this.Name = "TicketTypeControl1";
            this.Size = new System.Drawing.Size(654, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCache;
        private System.Windows.Forms.Button BtnMoveOriginAndDestination;
        private System.Windows.Forms.ListBox LbDestination;
        private System.Windows.Forms.ListBox LbOrigin;
        public RJToggleButton rjToggleButton1;
        public System.Windows.Forms.DateTimePicker DtpDeparture;
        public System.Windows.Forms.DateTimePicker DtpDepart;
        public System.Windows.Forms.ComboBox CbDestination;
        public System.Windows.Forms.ComboBox CbOrigin;
    }
}
