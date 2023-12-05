namespace AirPlaneTicketWinFormsApp.Airlines
{
    partial class AddImageLogoAirlineForm
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
            this.BtnBrowsePicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAddImageLogoAirline = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBrowsePicture
            // 
            this.BtnBrowsePicture.Location = new System.Drawing.Point(103, 12);
            this.BtnBrowsePicture.Name = "BtnBrowsePicture";
            this.BtnBrowsePicture.Size = new System.Drawing.Size(109, 29);
            this.BtnBrowsePicture.TabIndex = 2;
            this.BtnBrowsePicture.Text = "انتخاب عکس";
            this.BtnBrowsePicture.UseVisualStyleBackColor = true;
            this.BtnBrowsePicture.Click += new System.EventHandler(this.BtnBrowsePicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnAddImageLogoAirline
            // 
            this.BtnAddImageLogoAirline.Location = new System.Drawing.Point(103, 159);
            this.BtnAddImageLogoAirline.Name = "BtnAddImageLogoAirline";
            this.BtnAddImageLogoAirline.Size = new System.Drawing.Size(94, 29);
            this.BtnAddImageLogoAirline.TabIndex = 3;
            this.BtnAddImageLogoAirline.Text = "ثبت";
            this.BtnAddImageLogoAirline.UseVisualStyleBackColor = true;
            this.BtnAddImageLogoAirline.Click += new System.EventHandler(this.BtnAddImageLogoAirline_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(116, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddImageLogoAirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 244);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAddImageLogoAirline);
            this.Controls.Add(this.BtnBrowsePicture);
            this.Name = "AddImageLogoAirlineForm";
            this.Text = "AddImageLogoAirlineForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBrowsePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnAddImageLogoAirline;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}