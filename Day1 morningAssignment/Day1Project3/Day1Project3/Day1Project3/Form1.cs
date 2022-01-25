using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);

            int result = input1 + input2;

            MessageBox.Show("Addition result =" + result.ToString());
        }
    }
}
