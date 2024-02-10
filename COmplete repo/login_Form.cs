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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Ahmad" && txtpass.Text == "1234")
            {

                this.Hide();
                Interface a = new Interface();
                a.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid Username and password.Please try Again", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    txt_username.Clear();
                    txtpass.Clear();

                }
            }


        }

        private void login_page_Load(object sender, EventArgs e)
        {

        }
    }
}
