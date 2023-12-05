namespace AirPlaneTicketWinFormsApp.UserControls
{
    partial class TicketTypeControl2
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
            this.DtpDepart = new System.Windows.Forms.DateTimePicker();
            this.LbDestination = new System.Windows.Forms.ListBox();
            this.CbDestination = new System.Windows.Forms.ComboBox();
            this.LbOrigin = new System.Windows.Forms.ListBox();
            this.CbOrigin = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DtpDepart
            // 
            this.DtpDepart.Location = new System.Drawing.Point(18, 16);
            this.DtpDepart.Name = "DtpDepart";
            this.DtpDepart.Size = new System.Drawing.Size(240, 27);
            this.DtpDepart.TabIndex = 32;
            // 
            // LbDestination
            // 
            this.LbDestination.FormattingEnabled = true;
            this.LbDestination.ItemHeight = 20;
            this.LbDestination.Location = new System.Drawing.Point(332, 44);
            this.LbDestination.Name = "LbDestination";
            this.LbDestination.Size = new System.Drawing.Size(150, 104);
            this.LbDestination.TabIndex = 29;
            this.LbDestination.SelectedIndexChanged += new System.EventHandler(this.LbDestination_SelectedIndexChanged);
            // 
            // CbDestination
            // 
            this.CbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbDestination.FormattingEnabled = true;
            this.CbDestination.Location = new System.Drawing.Point(332, 18);
            this.CbDestination.Name = "CbDestination";
            this.CbDestination.Size = new System.Drawing.Size(151, 28);
            this.CbDestination.TabIndex = 28;
            this.CbDestination.TextChanged += new System.EventHandler(this.CbDestination_TextChanged);
            // 
            // LbOrigin
            // 
            this.LbOrigin.FormattingEnabled = true;
            this.LbOrigin.ItemHeight = 20;
            this.LbOrigin.Location = new System.Drawing.Point(548, 43);
            this.LbOrigin.Name = "LbOrigin";
            this.LbOrigin.Size = new System.Drawing.Size(150, 104);
            this.LbOrigin.TabIndex = 27;
            this.LbOrigin.SelectedIndexChanged += new System.EventHandler(this.LbOrigin_SelectedIndexChanged);
            // 
            // CbOrigin
            // 
            this.CbOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbOrigin.FormattingEnabled = true;
            this.CbOrigin.Location = new System.Drawing.Point(548, 15);
            this.CbOrigin.Name = "CbOrigin";
            this.CbOrigin.Size = new System.Drawing.Size(151, 28);
            this.CbOrigin.TabIndex = 26;
            this.CbOrigin.TextChanged += new System.EventHandler(this.CbOrigin_TextChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(18, 61);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 29);
            this.BtnDelete.TabIndex = 39;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TicketTypeControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DtpDepart);
            this.Controls.Add(this.LbDestination);
            this.Controls.Add(this.CbDestination);
            this.Controls.Add(this.LbOrigin);
            this.Controls.Add(this.CbOrigin);
            this.Name = "TicketTypeControl2";
            this.Size = new System.Drawing.Size(717, 164);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpDepart;
        private System.Windows.Forms.ListBox LbDestination;
        private System.Windows.Forms.ComboBox CbDestination;
        private System.Windows.Forms.ListBox LbOrigin;
        private System.Windows.Forms.ComboBox CbOrigin;
        private System.Windows.Forms.Button BtnDelete;
    }
}
