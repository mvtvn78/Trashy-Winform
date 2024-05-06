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
    public partial class Page45 : Form
    {
        private List<SinhVien1> svs;
        bool isGender;
        public Page45()
        {
            InitializeComponent();
            svs = new List<SinhVien1>();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Reload()
        {
            dataGridView1.DataSource = svs;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = new List<SinhVien1>();
                svs.Add(new SinhVien1(int.Parse(textBox1.Text), textBox2.Text, dateTimePicker1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, isGender));
                Reload();
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(isGender.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isGender = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isGender = false;
        }

        private void Page45_Layout(object sender, LayoutEventArgs e)
        {
            if( isGender )
            {
                radioButton1.Checked = true; 
                return;
            }
            radioButton2.Checked = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = svs[e.RowIndex].MASV.ToString();
            textBox2.Text = svs[e.RowIndex].Hoten.ToString();
            dateTimePicker1.Text = svs[e.RowIndex].Ngaysinh;
            comboBox4.Text = svs[e.RowIndex].Quequan;
            comboBox3.Text = svs[e.RowIndex].Lop;
            comboBox2.Text = svs[e.RowIndex].Khoa;
            if (svs[e.RowIndex].Gioitinh=="Nam")
            {
                radioButton1.Checked =true;
            }   
            else
            {
                radioButton2.Checked = true;
            }    
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
