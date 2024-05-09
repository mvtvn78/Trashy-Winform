using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    public partial class Maytinh : Form
    {
        float a;
        float b;
        int choice;
        public Maytinh()
        {
            InitializeComponent();
            choice = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                b = float.Parse(textBox1.Text);
                switch (choice)
                {
                    case 0:
                        MessageBox.Show("Chưa nhập phép tính");
                        break;
                    case 1:
                        textBox1.Text = (a + b).ToString();
                        break;
                    case 2:
                        string temp = (a - b).ToString();
                        textBox1.Text = temp;
                        break;
                    case 3:
                        textBox1.Text = (a * b).ToString();
                        break;
                    case 4:
                        textBox1.Text = (a / b).ToString();
                        break;
                }
                Khoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi cu", ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Khoa(false);
                a = float.Parse(textBox1.Text);
                choice = 1;
                textBox1.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Lỗi rồi cu");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Khoa(false);
                a = float.Parse(textBox1.Text);
                choice = 2;
                textBox1.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Lỗi rồi cu");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {

                Khoa(false);
                a = float.Parse(textBox1.Text);
                choice = 3;
                textBox1.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Lỗi rồi cu");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                Khoa(false);
                a = float.Parse(textBox1.Text);
                choice = 4;
                textBox1.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Lỗi rồi cu");
            }
        }
        void Khoa(bool vl = true)
        {
            button16.Enabled = vl;
            button15.Enabled = vl;
            button14.Enabled = vl;
            button13.Enabled = vl;
        }
        private void Maytinh_Layout(object sender, LayoutEventArgs e)
        {
           
            
        }
    }
}
