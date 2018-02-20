using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Ping_of_Duth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static IPAddress ip = IPAddress.None;
        static Ping p = new Ping();
        static PingReply reply;
        static int length;

        private void btn_Ping_Click(object sender, EventArgs e)
        {
            ip = IPAddress.Parse(txt_ip.Text);

            if (checkBox1.Checked)
            {
                while (true)
                {
                    reply = p.Send(ip, 1000);
                }
            }
            else
            {
                length = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i <= length; i++)
                {
                    reply = p.Send(ip, 1000);
                    label3.Text = "Pings Done " + i.ToString();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("The program may... lag? if you set a number above 10k pings. As for the unlimited pings, this program will surely lag");

            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;

            if (checkBox1.Checked == false)
            {
                textBox1.Visible = true;
            }

        }


    }
}
