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
    public partial class Stupid : Form
    {
        private int cao_voi = 100000;
        private int tay_trang = 1500000;
        private int nho_rang = 150000;
        private int tram_rang = 200000;
        private IEnumerable<Control> controls = null;
        public Stupid()
        {
            InitializeComponent();
            controls = Controls.OfType<Control>().Where(x => x is NumericUpDown || x is CheckBox || x is Button);
        }
        void handleEnableFalse()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox2.Text = string.Empty;
            foreach (var i in controls)
            {
                i.Enabled = false;
            }
            button3.Enabled = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                foreach (var i in controls)
                {
                    i.Enabled = true;
                    textBox2.Enabled = false;
                }
            }
            else
            {
                handleEnableFalse();
            }
        }

        private void Stupid_Load(object sender, EventArgs e)
        {
            handleEnableFalse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           string x =MessageBox.Show("Bạn có muốn đóng chương trình không ", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
           if(x =="OK")
            {
                this.Close();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if(checkBox1.Checked)
            {
                sum += cao_voi;
            }
            if (checkBox3.Checked)
            {
                sum += tay_trang;
            }
            if(numericUpDown1.Value!=0)
            {
                sum += (int)numericUpDown1.Value * nho_rang;
            }
            if (numericUpDown2.Value != 0)
            {
                sum += (int)numericUpDown2.Value * nho_rang;
            }
            textBox2.Text = sum.ToString();
            MessageBox.Show($"Khách hàng {textBox1.Text} cần trả số tiền {sum}Đ ");
        }
    }
}
