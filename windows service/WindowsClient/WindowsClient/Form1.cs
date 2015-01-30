using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private HelloServiceContract.HelloServiceClient client;
        //private HelloService.HelloServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HelloServiceContract.HelloServiceClient();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = client.GetMessage(textBox1.Text);
        }

      
     }
}
