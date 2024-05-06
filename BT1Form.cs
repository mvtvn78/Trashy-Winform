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
    public partial class BT1Form : Form
    {
        public BT1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                textBox3.Text = (float.Parse(textBox2.Text) + float.Parse(textBox1.Text)).ToString();
            }
           catch {
                errorProvider1.SetError(textBox1, "InValid");
                errorProvider2.SetError(textBox2, "InValid");
                errorProvider3.SetError(textBox3, "InValid");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                textBox3.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString();
            }
            catch
            {
                errorProvider1.SetError(textBox1, "InValid");
                errorProvider2.SetError(textBox2, "InValid");
                errorProvider3.SetError(textBox3, "InValid");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                textBox3.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
            }
            catch
            {
                errorProvider1.SetError(textBox1, "InValid");
                errorProvider2.SetError(textBox2, "InValid");
                errorProvider3.SetError(textBox3, "InValid");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                if(int.Parse(textBox2.Text) == 0) { throw new Exception("Divide zero"); }
                float kq = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
                textBox3.Text = kq.ToString();
            }
            catch 
            {
                errorProvider1.SetError(textBox1, "InValid");
                errorProvider2.SetError(textBox2, "InValid");
                errorProvider3.SetError(textBox3, "InValid");
            }
          
        }

        private void BT1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void BT1Form_FormClosing(object sender, FormClosingEventArgs e)
        {
  
          // Assume that X has been clicked and act accordingly.
          // Confirm user wants to close
                    switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        //Stay on this form
                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                        default:
                            break;
                    }
        }

        private void BT1Form_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }
    }
}
