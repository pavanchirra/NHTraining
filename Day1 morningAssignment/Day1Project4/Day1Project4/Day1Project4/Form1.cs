using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basenumber, exponent, i, power;
            basenumber = Convert.ToInt32(textBox1.Text);
            exponent = Convert.ToInt32(textBox2.Text);

            power = 1;

            for (i = 1; i <= exponent; i++)
                power = power * basenumber;
            textBox3.Text = power.ToString();
        }
    }
}
