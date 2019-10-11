using System.Windows.Forms;

namespace IPTV_v3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ethernetErrorPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.fullscreenButton = new System.Windows.Forms.Button();
            this.ccButton = new System.Windows.Forms.Button();
            this.volumePanel = new System.Windows.Forms.Panel();
            this.vlcControl2 = new Vlc.DotNet.Forms.VlcControl();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.ethernetErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ethernetErrorPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.vlcControl2);
            this.panel1.Controls.Add(this.vlcControl1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 561);
            this.panel1.TabIndex = 0;
            // 
            // ethernetErrorPanel
            // 
            this.ethernetErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ethernetErrorPanel.Controls.Add(this.pictureBox1);
            this.ethernetErrorPanel.Controls.Add(this.pictureBox2);
            this.ethernetErrorPanel.Controls.Add(this.textBox1);
            this.ethernetErrorPanel.Controls.Add(this.pictureBox3);
            this.ethernetErrorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ethernetErrorPanel.Location = new System.Drawing.Point(200, 0);
            this.ethernetErrorPanel.Name = "ethernetErrorPanel";
            this.ethernetErrorPanel.Size = new System.Drawing.Size(684, 519);
            this.ethernetErrorPanel.TabIndex = 3;
            this.ethernetErrorPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::IPTV_v3.Properties.Resources.ethernet;
            this.pictureBox1.Location = new System.Drawing.Point(472, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::IPTV_v3.Properties.Resources.docking_station;
            this.pictureBox2.Location = new System.Drawing.Point(26, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(106, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 151);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "In order to play live IPTV video you will need to connect the network cable to yo" +
    "ur docking station or computer.\r\nIPTV does not work over WiFi.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::IPTV_v3.Properties.Resources.up_arrow;
            this.pictureBox3.InitialImage = global::IPTV_v3.Properties.Resources.up_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(152, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 233);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonPanel);
            this.panel2.Controls.Add(this.volumePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 42);
            this.panel2.TabIndex = 5;
            this.panel2.DoubleClick += new System.EventHandler(this.fullscreenButton_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.fullscreenButton);
            this.buttonPanel.Controls.Add(this.ccButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(96, 42);
            this.buttonPanel.TabIndex = 5;
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.BackColor = System.Drawing.Color.Transparent;
            this.fullscreenButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.fullscreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscreenButton.Image = global::IPTV_v3.Properties.Resources.fullscreen;
            this.fullscreenButton.Location = new System.Drawing.Point(53, 0);
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(43, 42);
            this.fullscreenButton.TabIndex = 1;
            this.fullscreenButton.UseVisualStyleBackColor = false;
            this.fullscreenButton.Click += new System.EventHandler(this.fullscreenButton_Click);
            // 
            // ccButton
            // 
            this.ccButton.BackColor = System.Drawing.Color.Transparent;
            this.ccButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccButton.Image = global::IPTV_v3.Properties.Resources.cc_logo1;
            this.ccButton.Location = new System.Drawing.Point(0, 0);
            this.ccButton.Name = "ccButton";
            this.ccButton.Size = new System.Drawing.Size(44, 42);
            this.ccButton.TabIndex = 0;
            this.ccButton.UseVisualStyleBackColor = false;
            this.ccButton.Click += new System.EventHandler(this.ccButton_Click);
            // 
            // volumePanel
            // 
            this.volumePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.volumePanel.Location = new System.Drawing.Point(374, 0);
            this.volumePanel.Name = "volumePanel";
            this.volumePanel.Size = new System.Drawing.Size(310, 42);
            this.volumePanel.TabIndex = 4;
            // 
            // vlcControl2
            // 
            this.vlcControl2.BackColor = System.Drawing.Color.Black;
            this.vlcControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl2.Location = new System.Drawing.Point(200, 0);
            this.vlcControl2.Name = "vlcControl2";
            this.vlcControl2.Size = new System.Drawing.Size(684, 561);
            this.vlcControl2.Spu = -1;
            this.vlcControl2.TabIndex = 2;
            this.vlcControl2.Text = "vlcControl2";
            this.vlcControl2.VlcLibDirectory = null;
            this.vlcControl2.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl_VlcLibDirectoryNeeded);
            this.vlcControl2.DoubleClick += new System.EventHandler(this.fullscreenButton_Click);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vlcControl1.Location = new System.Drawing.Point(200, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(684, 561);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 1;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = new[] { "--sub-track=0" };
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl_VlcLibDirectoryNeeded);
            this.vlcControl1.DoubleClick += new System.EventHandler(this.fullscreenButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 561);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "Form1";
            this.Text = "CCSD IPTV v4";
            this.panel1.ResumeLayout(false);
            this.ethernetErrorPanel.ResumeLayout(false);
            this.ethernetErrorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Vlc.DotNet.Forms.VlcControl vlcControl2;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Panel ethernetErrorPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ccButton;
        private System.Windows.Forms.Button fullscreenButton;
        private System.Windows.Forms.Panel volumePanel;
        private System.Windows.Forms.Panel buttonPanel;
    }
}

