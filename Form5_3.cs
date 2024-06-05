using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    public partial class
        Form5_3 : Form
    {
        SqlConnection conn;
        DataTable dt;
        public Form5_3()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=MVT\\SQLEXPRESS01;Initial Catalog=Tests;Integrated Security=True");
            dt = new DataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Khoa values(@MaKhoa,@TenKhoa,@TinhTrang)", conn);
            cmd.Parameters.Add("Makhoa", SqlDbType.Char);
            cmd.Parameters.Add("TenKhoa", SqlDbType.VarChar);
            cmd.Parameters.Add("TinhTrang", SqlDbType.Bit);

            cmd.Parameters["Makhoa"].Value = textBox1.Text;
            cmd.Parameters["TenKhoa"].Value = textBox2.Text;
            cmd.Parameters["TinhTrang"].Value = 1;
            cmd.ExecuteNonQuery();
        }

        private void Form5_3_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select  * from Khoa ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Columns.Add("Col1", "mã khoa");
            dataGridView1.Columns["Col1"].Width = 100;
            dataGridView1.Columns.Add("Col2", "tên khoa");
            dataGridView1.Columns["Col2"].Width = 300;
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetValue(0).ToString(),reader.GetValue(1).ToString());
            }
            reader.Close();
        }
    }
}
