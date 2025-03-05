using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300088
{
    public partial class Form1 : Form
    {
        string angka1;
        string number;

        private List<int> angkalist = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = number + "1";
            label1.Text = number;
            label1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "9";
            label1.Text = number;
            label1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka1 = label1.Text;
            number = "+";
            
            Console.WriteLine(angka1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(angka1);
            int result = Int32.Parse(number);
            int hasil = a + result;
            label1.Text = hasil.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = number + "2";
            label1.Text = number;
            label1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = number + "3";
            label1.Text = number;
            label1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "4";
            label1.Text = number;
            label1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "5";
            label1.Text = number;
            label1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "6";
            label1.Text = number;
            label1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "7";
            label1.Text = number;
            label1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "8";
            label1.Text = number;
            label1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number = number + "0";
            label1.Text = number;
            label1.Show();
        }
    }
}
