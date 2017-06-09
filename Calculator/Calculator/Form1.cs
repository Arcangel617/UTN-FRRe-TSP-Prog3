using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        bool secuencia = true;
        int current = 0;

        private int op(int c) {
            return current + c;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            op(current)
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";                
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = btn.Text;
                current = int.Parse(textBox1.Text);
                secuencia = false;
            }
            else
            {
                textBox1.AppendText(btn.Text);
                current = int.Parse(textBox1.Text);
            }
        }
    }
}
