using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorHw
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            toplam = s1 + s2;
            label4.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, cikar;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            cikar = s1 - s2;
            label4.Text = Convert.ToString(cikar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, bol;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            bol = s1 / s2;
            label4.Text = Convert.ToString(bol);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2, carp;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            carp = s1 * s2;
            label4.Text = Convert.ToString(carp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s1= 0,s2 = 0;
            label4.Text = "Reset";
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
