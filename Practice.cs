using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
namespace Trashy_WinForm
{
    public partial class Practice : Form
    {
        List<string> hello = new List<string>() { "Mai Văn Tiền", "Đẹp trai"};
        DataTable dt;
        public Practice()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Hello", typeof(string));
            dt.Columns.Add("index", typeof(int));
            dt.Rows.Add("hello1",1);
            dt.Rows.Add("hello2", 2);
            comboBox1.DataSource = new Dictionary<string, string>()
            {
                {"HEllo1","COM1" },
                {"HEllo2","COM2" },
            }.ToList();
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Hello";
            comboBox2.ValueMember = "index";
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


            MessageBox.Show(comboBox1.SelectedValue.ToString());
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() ==DialogResult.OK)
            {
                
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaioken");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = File.CreateText(saveFileDialog2.FileName);
                streamWriter.Write("Kaioken");
                streamWriter.Close();

            }
        }
    }
}
