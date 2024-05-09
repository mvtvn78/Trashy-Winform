using System;
using System.Collections;
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
    public partial class Arr1D : Form
    {
        ArrClass arr;
        private IEnumerable<Control> controls;
        public Arr1D()
        {
            InitializeComponent();
            arr = new ArrClass();
            IEnumerable<Control> controls1 = Controls.OfType<GroupBox>(); 
            foreach (Control control in controls1)
            {
                foreach(Control x in control.Controls)
                {
                    if(x is TextBox)
                        x.Enabled = false;
                }    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.SaveArr(textBox1.Text);
            textBox1.Enabled = false;
            textBox2.Text = arr.ToString();
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            textBox1.Enabled = true;
            arr.clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            arr.SortAsc();
            textBox2.Text = arr.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            arr.SortDsc();
            textBox2.Text = arr.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox3.Text != string.Empty)
            {
                int value = int.Parse(textBox3.Text);
                int searchIdx = arr.Search(value, true);
                if (searchIdx == -1)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                }

                textBox5.Text = searchIdx.ToString();
            }
            else
            {
                errorProvider1.SetError(textBox3, "Vui lòng nhập");
            }
            radioButton4.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox3.Text != string.Empty)
            {
                int value = int.Parse(textBox4.Text);
                int valueIdx = arr.Search(value);
                textBox5.Text = valueIdx.ToString();
            }    
            else
            {
                errorProvider1.SetError(textBox4, "Vui lòng nhập");
            }
            radioButton3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!arr.isEmpty())
            {
                textBox10.Text = arr.TongMang().ToString();
                textBox11.Text = arr.TongChan().ToString();
                textBox12.Text = arr.TongLe().ToString();

            }
        }

        private void Arr1D_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát chương trình","Cà chá na",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Arr1D_Load(object sender, EventArgs e)
        {
            
        }
    }
}
