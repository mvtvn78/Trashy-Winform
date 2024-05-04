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
    public partial class BT1 : Form
    {
        string o_label4;
        string o_label5;
        string o_label6;
        string o_label7;
        public BT1()
        {
            InitializeComponent();
            textBox1.AutoSize = true;
            o_label4 = label4.Text;
            o_label5 = label5.Text;
            o_label6 = label6.Text;
            o_label7 = label7.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void handle()
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                label4.Text = o_label4 + (a + b).ToString();
                label5.Text = o_label5 + (a - b).ToString();
                label6.Text = o_label6 + (a * b).ToString();
                label7.Text = o_label7 + (a / b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            handle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void PhepCong_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyValue == 27)
            {
                this.Close ();
            }
           else if(e.KeyValue == 13)
            {
                handle();
            }
        }

       
    }
}
