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
    public partial class giaiphuongtrinh : Form
    {
        PhuongTrinhBacHai a;
        // BN : False , BH : true
        private bool mode = false;
        private IEnumerable<Control> controls = null;
        public giaiphuongtrinh()
        {
            InitializeComponent();
            controls = Controls.OfType<Control>().Where(x => x is TextBox);
        }
        void CheckInput()
        {
            bool value = mode ? controls.All(x => x.Text != string.Empty) : (textBox1.Text != string.Empty && textBox2.Text != string.Empty);

            if (value)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        public bool isTextBoxEmpty(TextBox a)
        {
            return a.Text == string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giaiphuongtrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void giaiphuongtrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn rời đi", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void giaiphuongtrinh_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            mode = false;
            CheckInput();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            mode = true;
            CheckInput();
        }

        private void giaiphuongtrinh_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void giaiphuongtrinh_KeyUp(object sender, KeyEventArgs e)
        {

            CheckInput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new PhuongTrinhBacHai();
            if (!mode)
            {
                a.B = int.Parse(textBox1.Text);
                a.C = int.Parse(textBox2.Text);
            }
            else
            {
                a.A = int.Parse(textBox1.Text);
                a.B = int.Parse(textBox2.Text);
                a.C = int.Parse(textBox3.Text);
            }
            richTextBox1.Text = a.Solve();
        }
    }
}
