using System.Drawing.Text;
using System.Net.NetworkInformation;

namespace Project_Simulator_OOP
{
    //GUI interface



    public partial class Interface : Form
    {


        private int c = 0;
        private bool isDragging = false;
        private Point startPoint;
        private PictureBox picbox_select = null;
        private bool is_simulation = false;

        public Interface()
        {
            InitializeComponent();

        }

        public static class MyStaticList
        {
            public static List<NetworkDevice> d_list = new List<NetworkDevice>();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(combo.GetItemText(combo.SelectedItem));
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(80, 80);
            pictureBox.Location = new Point(20, 20);
            pictureBox.Tag = (combo.GetItemText(combo.SelectedItem));
            pictureBox.Name = (combo.GetItemText(combo.SelectedItem));



            if (combo.GetItemText(combo.SelectedItem).ToUpper() == "ROUTER")
            {
                combo.ResetText();

                string tempname;
                string tempip;
                string tempport;

                Device_Input d = new Device_Input();
                d.ShowDialog();


                tempname = d.dev_nam();
                tempip = d.dev_ip();
                tempport = d.dev_typ();

                Router R = new Router(tempname, tempip, tempport);
                pictureBox.Name = tempname + " ip:" + tempip + " port: " + tempport;
                pictureBox.Image = R.GetDeviceImage();

                MyStaticList.d_list.Add(R);

            }

            else if (combo.GetItemText(combo.SelectedItem).ToUpper() == "PC")
            {
                combo.ResetText();
                Device_Input d = new Device_Input();
                d.ShowDialog();


                string tempname = d.dev_nam();
                string tempip = d.dev_ip();
                string tempport = d.dev_typ();
                Pc P = new Pc(tempname, tempip, tempport);
                pictureBox.Image = P.GetDeviceImage();
                pictureBox.Name = tempname + " ip:" + tempip + " port: " + tempport;
                MyStaticList.d_list.Add(P);


            }
            else if ((combo.GetItemText(combo.SelectedItem).ToUpper() == "SWITCH"))
            {
                combo.ResetText();

                Device_Input d = new Device_Input();
                d.ShowDialog();


                string tempname = d.dev_nam();
                string tempip = d.dev_ip();
                string tempport = d.dev_typ();
                Switch S = new Switch(tempname, tempip, tempport);
                pictureBox.Image = S.GetDeviceImage();
                pictureBox.Name = tempname + " ip:" + tempip + " port: " + tempport;



                MyStaticList.d_list.Add(S);


            }

            else if (combo.GetItemText(combo.SelectedItem).ToUpper() == "FIREWALL")
            {
                combo.ResetText();
                Device_Input d = new Device_Input();
                d.ShowDialog();


                string tempname = d.dev_nam();
                string tempip = d.dev_ip();
                string tempport = d.dev_typ();


                Firewall F = new Firewall(tempname, tempip, tempport);
                pictureBox.Image = F.GetDeviceImage();
                pictureBox.Name = tempname + " ip:" + tempip + " port: " + tempport;
                MyStaticList.d_list.Add(F);

            }


            else if ((combo.GetItemText(combo.SelectedItem).ToUpper()) == "WORK")
            {
                combo.ResetText();
                Device_Input d = new Device_Input();
                d.ShowDialog();


                string tempname = d.dev_nam();
                string tempip = d.dev_ip();
                string tempport = d.dev_typ();


                Workstation W = new Workstation(tempname, tempip, tempport);
                pictureBox.Name = tempname + " ip:" + tempip + " port: " + tempport;
                pictureBox.Image = (W.GetDeviceImage());

                MyStaticList.d_list.Add(W);


            }

            else
            {
                MessageBox.Show("Device Not found");
                return;

            }

            Controls.Add(pictureBox);
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;



        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            if (Run_Button.Text == "start")
            {
                //  timer1.Enabled = true;
                Run_Button.Text = "stop";
                Run_Button.BackColor = Color.Yellow;
                is_simulation = true;
            }


            else if (Run_Button.Text == "stop")
            {
                //  timer1.Enabled = false;
                Run_Button.Text = "start";
                Run_Button.BackColor = Color.Orange;
                is_simulation = false;
            }

        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            isDragging = true;
            startPoint = e.Location;


            if (e.Button == MouseButtons.Right)
            {
                if (is_simulation)
                {
                    ContextMenuStrip co_n = new ContextMenuStrip();
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    toolStripMenuItem.Text = "Ping";
                    toolStripMenuItem.Click += ToolStripMenuItem_Click;
                    ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();

                    toolStripMenuItem2.Text = "Remove";
                    toolStripMenuItem2.Click += ToolStripMenuItem2_Click;

                    picbox_select = ((PictureBox)sender);

                    co_n.Items.Add(toolStripMenuItem);
                    co_n.Items.Add(toolStripMenuItem2);
                    co_n.Show(((PictureBox)sender), new Point(e.X, e.Y));

                }
                else
                {
                    MessageBox.Show("Simulation is not Started");
                }

            }
        }

        private void ToolStripMenuItem_Click(object? sender, EventArgs e)
        {

            MessageBox.Show("Successfully ping to the Server");
            MessageBox.Show(picbox_select.Name);

        }


        private bool PerformPing(string ipAddress)
        {
            using (System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping())
            {
                try
                {
                    System.Net.NetworkInformation.PingReply reply = pingSender.Send(ipAddress);
                    return reply.Status == System.Net.NetworkInformation.IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void ToolStripMenuItem2_Click(object? sender, EventArgs e)
        {
            picbox_select.Dispose();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Left += e.X - startPoint.X;
                pictureBox.Top += e.Y - startPoint.Y;



            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        // private void timer1_Tick(object sender, EventArgs e)
        //{
        // c = c + 1;
        //imer_Label.Text = c.ToString() + " sec";

        // }

        private void Manager_Click(object sender, EventArgs e)
        {


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {



        }



        private async void ToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            if (picbox_select != null)
            {
                NetworkDevice device = picbox_select.Tag as NetworkDevice;
                if (device != null)
                {
                    bool isPingSuccessful = await PerformPingAsync(device.IPAddress);
                    if (isPingSuccessful)
                    {
                        MessageBox.Show("Ping is successful to the device.");
                    }
                    else
                    {
                        MessageBox.Show("Ping failed to the device.");
                    }
                }
            }
        }

        private async Task<bool> PerformPingAsync(string ipAddress)
        {
            using (System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping())
            {
                try
                {
                    System.Net.NetworkInformation.PingReply reply = await pingSender.SendPingAsync(ipAddress);
                    return reply.Status == System.Net.NetworkInformation.IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Label_Click(object sender, EventArgs e)
        {

        }
    }
}