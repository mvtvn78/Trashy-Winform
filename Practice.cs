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
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kaiokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(dateTimePicker1.Text);
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(colorDialog1.Color.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
