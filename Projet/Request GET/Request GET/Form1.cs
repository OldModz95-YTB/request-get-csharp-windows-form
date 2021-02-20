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

namespace Request_GET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebClient WebClient = new WebClient();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = WebClient.DownloadString("https://protondev.000webhostapp.com/api/ex.php");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = WebClient.DownloadString("https://protondev.000webhostapp.com/api/ex.txt");
        }
    }
}
