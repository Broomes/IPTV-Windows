using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace IPTV_v3
{
    public partial class Form1 : Form
    {

        private Boolean cc = false;
        public string resourceFolderPath = "http://iptv.cobbk12.org/GB/resources/";
        private string currentChannel = "";

        public Form1()
        {
            InitializeComponent();

            vlcControl1.Video.IsMouseInputEnabled = false;
            vlcControl1.Video.IsKeyInputEnabled = false;
            vlcControl2.Video.IsMouseInputEnabled = false;
            vlcControl2.Video.IsKeyInputEnabled = false;

            if (!CountyUtils.CheckEthernet())
            {
                ethernetErrorPanel.Visible = true;
                Timer timer = new Timer();
                timer.Interval = (3 * 1000); // 3 secs
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }

            else
            {
                try
                {
                    CreateChannelList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Source);
                }
            }
            
        }

        private void vlcControl_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }

        private void PlayChannel(string udpAddress)
        {
            vlcControl1.Stop();
            vlcControl2.Stop();

            if (cc)
            {
                vlcControl1.SetMedia(udpAddress);
                vlcControl1.Play();
                vlcControl1.BringToFront();
                
            }
            else
            {
                vlcControl2.SetMedia(udpAddress);
                vlcControl2.Play();
                vlcControl2.BringToFront();
            }
        }
       

        public void CreateChannelList()
        {
            string ip = CountyUtils.GetLocalIPAddress();
            string[] ipParts = ip.Split('.');
            Int32 subnet = Int32.Parse(ipParts[1]);
            if(subnet > 11 && subnet < 134)
            {
                // This section added School Broadcast and School TV channels
                try
                {
                    Button channelButton = new Button();
                    WebClient wc = new WebClient();
                    byte[] imageData = wc.DownloadData(resourceFolderPath + "schools\\" + subnet + ".png");
                    MemoryStream stream = new MemoryStream(imageData);
                    Image logo = Image.FromStream(stream);

                    channelButton.FlatStyle = FlatStyle.Flat;
                    channelButton.FlatAppearance.BorderSize = 0;

                    channelButton.TextImageRelation = TextImageRelation.ImageAboveText;
                    channelButton.Image = logo;
                    channelButton.Text = "School Broadcast";
                    channelButton.ForeColor = Color.LightGray;
                    channelButton.Font = new Font("Ariel", 10, FontStyle.Bold);
                    channelButton.Size = new Size((flowLayoutPanel1.Width - SystemInformation.VerticalScrollBarWidth - 6), logo.Size.Height + 20);

                    channelButton.Click += (sender1, e1) =>
                    {
                        currentChannel = "udp://@225.168.3." + subnet + ":1234/";
                        PlayChannel(currentChannel);
                    };
                    flowLayoutPanel1.Controls.Add(channelButton);
                }
                catch
                {
                    flowLayoutPanel1.Controls.Add(ChannelButton("School Broadcast", "udp://@225.168.3." + subnet + ":1234/"));
                }

                // This Section check for third channel
                try
                {
                    using (XmlReader reader = XmlReader.Create(resourceFolderPath + "schools\\" + subnet + ".xml"))
                    {
                        string[] attr = new string[2];
                        while (reader.Read())
                        {
                            if (reader.IsStartElement())
                            {
                                if (reader.Name.ToString() == "channelName")
                                {
                                    attr[0] = reader.ReadString();
                                }
                                if (reader.Name.ToString() == "channelAddress")
                                {
                                    attr[1] = reader.ReadString();
                                }
                            }
                            if (attr[1] != null)
                            {
                                Button channelButton = new Button();
                                WebClient wc = new WebClient();
                                byte[] imageData = wc.DownloadData(resourceFolderPath + "schools\\" + subnet + ".png");
                                MemoryStream stream = new MemoryStream(imageData);
                                Image logo = Image.FromStream(stream);

                                channelButton.FlatStyle = FlatStyle.Flat;
                                channelButton.FlatAppearance.BorderSize = 0;

                                channelButton.TextImageRelation = TextImageRelation.ImageAboveText;
                                channelButton.Image = logo;
                                channelButton.Text = attr[0];
                                channelButton.ForeColor = Color.LightGray;
                                channelButton.Font = new Font("Ariel", 10, FontStyle.Bold);
                                channelButton.Size = new Size((flowLayoutPanel1.Width - SystemInformation.VerticalScrollBarWidth - 6), logo.Size.Height + 20);
                                string udpAddress = attr[1];

                                channelButton.Click += (sender1, e1) =>
                                {
                                    currentChannel = udpAddress;
                                    PlayChannel(currentChannel);
                                };
                                flowLayoutPanel1.Controls.Add(channelButton);
                                attr[0] = null;
                                attr[1] = null;
                            }
                        }
                    }
                }
                catch { }

                finally
                {
                    flowLayoutPanel1.Controls.Add(ChannelButton("School Cable", "udp://@225.168.4." + subnet + ":1234/"));
                }
            }

            // This section added main cable channels
            using (XmlReader reader = XmlReader.Create(resourceFolderPath + "list.xml"))
            {
                string[] attr = new string[2];
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name.ToString() == "channelName")
                        {
                            attr[0] = reader.ReadString();
                        }
                        if (reader.Name.ToString() == "channelAddress")
                        {
                            attr[1] = reader.ReadString();
                        }
                    }
                    if (attr[1] != null)
                    {
                        flowLayoutPanel1.Controls.Add(ChannelButton(attr[0], attr[1]));
                        attr[0] = null;
                        attr[1] = null;
                    }
                }
            }
        }

        public Button ChannelButton(string name, string udpAddress)
        {
            Button channelButton = new Button();
            WebClient wc = new WebClient();
            byte[] imageData = wc.DownloadData(resourceFolderPath + name + ".png");
            MemoryStream stream = new MemoryStream(imageData);
            Image logo = Image.FromStream(stream);
            channelButton.Size = new Size((flowLayoutPanel1.Width - SystemInformation.VerticalScrollBarWidth - 6), logo.Size.Height + 22);
            channelButton.FlatStyle = FlatStyle.Flat;
            channelButton.FlatAppearance.BorderSize = 0;

            channelButton.TextImageRelation = TextImageRelation.ImageAboveText;
            channelButton.Image = logo;
            channelButton.Text = name;
            channelButton.ForeColor = Color.LightGray;
            channelButton.Font = new Font("Ariel", 10, FontStyle.Bold);

            channelButton.Click += (sender1, e1) =>
            {
                currentChannel = udpAddress;
                PlayChannel(currentChannel);
            };
            return channelButton;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (CountyUtils.CheckEthernet())
            {
                ethernetErrorPanel.Visible = false;
                try
                {
                    CreateChannelList();
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Source);
                }
            }
        }

        private void ccButton_Click(object sender, EventArgs e)
        {
            if (cc) {
                cc = false;
                ccButton.BackColor = Color.Transparent;
            }
            else {
                cc = true;
                ccButton.BackColor = Color.DarkGray;
            }
            PlayChannel(currentChannel);
        }

        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                flowLayoutPanel1.Visible = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                flowLayoutPanel1.Visible = true;
            }
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
