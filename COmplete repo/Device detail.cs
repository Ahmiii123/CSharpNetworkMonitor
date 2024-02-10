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
    public partial class Device_Input : Form
    {
        //public bool is_clik = false;
        public Device_Input()
        {
            InitializeComponent();
        }

        public string dev_nam()
        {
            return TB_Device_Name.Text;
        }
        public string dev_ip()
        {
            return TB_Device_IP.Text;
        }
        public string dev_typ()
        {
            return TB_Device_Type.Text;
        }

        private void input_ok_button_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Device_Input_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }




}
