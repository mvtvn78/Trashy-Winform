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
    public partial class JSONHomework : Form
    {
        DataTable dt_noisinh;
        DataTable dt_khoa;
        DataTable dt_lop;
        DataTable dt_grid;
        int idx_current;
        public JSONHomework()
        {
            InitializeComponent();
            idx_current = -1;
            dt_khoa = new DataTable();
            dt_noisinh = new DataTable();
            dt_lop = new DataTable();
            //KHOA
            dt_khoa.Columns.Add("Name",typeof(string));
            dt_khoa.Rows.Add("CNTT");
            dt_khoa.Rows.Add("KT");
            dt_khoa.Rows.Add("TMDT");
            dt_khoa.Rows.Add("CX");
            //LOP
            dt_lop.Columns.Add("Name", typeof(string));
            dt_lop.Rows.Add("60TH1");
            dt_lop.Rows.Add("61TH1");
            dt_lop.Rows.Add("63TH1");
            dt_lop.Rows.Add("64CNTT");

            //NoiSinh
            dt_noisinh.Columns.Add("Name", typeof(string));
            dt_noisinh.Rows.Add("Hà Lội");
            dt_noisinh.Rows.Add("Phú Yên");

            comboBox1.DataSource= dt_noisinh;  
            comboBox1.DisplayMember = "Name";

            comboBox2.DataSource=  dt_khoa;
            comboBox2.DisplayMember = "Name";

            comboBox3.DataSource = dt_lop;
            comboBox3.DisplayMember = "Name";
            tabControl1.SelectedTab = tabPage4;

            dt_grid = new DataTable();
            dt_grid.Columns.Add("MaSV", typeof(string));
            dt_grid.Columns.Add("HoTen", typeof(string));
            dt_grid.Columns.Add("NgaySinh", typeof(string));
            dt_grid.Columns.Add("GioiTinh", typeof(string));
            dt_grid.Columns.Add("QueQuan", typeof(string));
            dt_grid.Columns.Add("Khoa", typeof(string));
            dt_grid.Columns.Add("Lop", typeof(string));

            //Grid view
            dataGridView1.DataSource = dt_grid;
            //Nam
            radioButton1.Checked = true;
        }

        private void panel1_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gioitinh = (radioButton1.Checked) ? "Nam" : "Nữ";
            dt_grid.Rows.Add(textBox1.Text,textBox2.Text,dateTimePicker1.Text, gioitinh,comboBox1.Text,comboBox2.Text,comboBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idx_current != -1)
            {
                string gioitinh = (radioButton1.Checked) ? "Nam" : "Nữ";
                dt_grid.Rows[idx_current]["MaSV"] = textBox1.Text;
                dt_grid.Rows[idx_current]["HoTen"] = textBox2.Text;
                dt_grid.Rows[idx_current]["NgaySinh"] = dateTimePicker1.Text;
                dt_grid.Rows[idx_current]["GioiTinh"] = gioitinh;
                dt_grid.Rows[idx_current]["QueQuan"] = comboBox1.Text;
                dt_grid.Rows[idx_current]["Khoa"] = comboBox2.Text;
                dt_grid.Rows[idx_current]["Lop"] = comboBox3.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idx_current != -1)
            {
                dt_grid.Rows[idx_current].Delete();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dt_grid.Rows.Count )
            {
                idx_current = e.RowIndex;
                textBox1.Text = dt_grid.Rows[idx_current]["MaSV"].ToString();
                textBox2.Text = dt_grid.Rows[idx_current]["HoTen"].ToString();
                DateTime d = DateTime.ParseExact(dt_grid.Rows[idx_current]["NgaySinh"].ToString(),"dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dateTimePicker1.Text = d.ToString("yyyy/MM/dd");
                if(dt_grid.Rows[idx_current]["GioiTinh"].ToString() == "Nam")
                {
                    radioButton1.Checked = true;
                }    
                else
                {
                    radioButton2.Checked = true;
                }
                comboBox1.Text = dt_grid.Rows[idx_current]["QueQuan"].ToString();
                comboBox2.Text = dt_grid.Rows[idx_current]["Khoa"].ToString();
                comboBox3.Text = dt_grid.Rows[idx_current]["Lop"].ToString();
            }
            else
                idx_current = -1;
        }
    }
}
