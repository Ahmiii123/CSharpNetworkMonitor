using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Simulator_OOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //MyProgressBar.Click += MyProgressBar.Click;
            timer2.Start();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            MyProgressBar.Value = startpoint;
            if (MyProgressBar.Value >= MyProgressBar.Maximum)
            {
                timer2.Stop();

                //login_page loginForm = new login_page();
                //loginForm.Show();

                this.Hide();
            }

        }

        private void MyProgressBar_ValueChanged(object sender, EventArgs e)
        {
            if (MyProgressBar.Value == MyProgressBar.Maximum)
            {
                login_page loginform = new login_page();
                loginform.Show();
                this.Hide();
            }

        }
    }
}
