using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Trashy_WinForm
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox2.AppendText(label2.Text +" ") ;
            textBox2.AppendText(textBox1.Text);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText(label3.Text + " ");
            textBox2.AppendText(comboBox1.Text);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText(label4.Text + " ");
            textBox2.AppendText(comboBox2.Text);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText(label5.Text + " ");
            textBox2.AppendText(textBox4.Text);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText(label6.Text + " ");
            textBox2.AppendText(textBox5.Text);
            textBox2.AppendText(Environment.NewLine);

            textBox2.AppendText(label7.Text + " ");
            textBox2.AppendText(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
