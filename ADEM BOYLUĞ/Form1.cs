using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADEM_BOYLUĞ
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

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightPink;
            label1.Text = "Bilişim";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label1.Text = "Ahmet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LimeGreen;
            label1.Text = "Erkul";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label6.Text = textBox3.Text + " " + textBox4.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label8.Text = "Merhaba" + " " + textBox5.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
    }
}
