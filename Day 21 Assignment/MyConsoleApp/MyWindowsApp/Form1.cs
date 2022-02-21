using System;
using System.Windows.Forms;
using MyWindowsApp.ServiceReference1;

namespace MyWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
                textBox2.Text = obj.Factorial(5).ToString();
        }
    }
}
