namespace LGMA
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGDriveEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIPAddresses = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLocationConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 - Enter your Google Drive Email";
            // 
            // txtGDriveEmail
            // 
            this.txtGDriveEmail.Location = new System.Drawing.Point(7, 25);
            this.txtGDriveEmail.Name = "txtGDriveEmail";
            this.txtGDriveEmail.Size = new System.Drawing.Size(255, 20);
            this.txtGDriveEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 2 - Select the IP Address/Port to bind to";
            // 
            // cmbIPAddresses
            // 
            this.cmbIPAddresses.FormattingEnabled = true;
            this.cmbIPAddresses.Location = new System.Drawing.Point(7, 64);
            this.cmbIPAddresses.Name = "cmbIPAddresses";
            this.cmbIPAddresses.Size = new System.Drawing.Size(174, 21);
            this.cmbIPAddresses.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(216, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(46, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8999";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(187, 67);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 13);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start the FTP server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocationConf
            // 
            this.txtLocationConf.Location = new System.Drawing.Point(7, 220);
            this.txtLocationConf.Multiline = true;
            this.txtLocationConf.Name = "txtLocationConf";
            this.txtLocationConf.Size = new System.Drawing.Size(255, 60);
            this.txtLocationConf.TabIndex = 7;
            this.txtLocationConf.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "PLEASE NOTE: The first time you try to link a new\r\nemailto this service, it will " +
    "pop up a window\r\nasking you to authorize it.";
            // 
            // lblConfig
            // 
            this.lblConfig.Location = new System.Drawing.Point(4, 187);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(258, 30);
            this.lblConfig.TabIndex = 9;
            this.lblConfig.Text = "Add a new entry to your switch/dz/locations.conf\r\nas shown below:";
            this.lblConfig.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 288);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocationConf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.cmbIPAddresses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGDriveEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGDriveEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIPAddresses;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLocationConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConfig;
    }
}

