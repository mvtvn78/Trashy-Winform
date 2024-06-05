using Microsoft.VisualBasic;
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
    public partial class Form5_1_HD : Form
    {
        SqlConnection conn;
        public Form5_1_HD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Khoa set TinhTrang =@TinhTrang  where MaKhoa = @MA", conn);
            cmd.Parameters.Add("MA", SqlDbType.Char);
            cmd.Parameters.Add("TinhTrang", SqlDbType.Bit);
            cmd.Parameters["MA"].Value = textBox1.Text;
            cmd.Parameters["TinhTrang"].Value = 0;
            cmd.ExecuteNonQuery();

        }

        private void Form5_1_HD_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=MVT\\SQLEXPRESS01;Initial Catalog=Tests;Integrated Security=True");
            conn.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Khoa values(@MaKhoa,@TenKhoa,@TinhTrang)",conn);
            cmd.Parameters.Add("Makhoa", SqlDbType.Char);
            cmd.Parameters.Add("TenKhoa",SqlDbType.VarChar);
            cmd.Parameters.Add("TinhTrang",SqlDbType.Bit);

            cmd.Parameters["Makhoa"].Value = textBox1.Text;
            cmd.Parameters["TenKhoa"].Value = textBox2.Text;
            cmd.Parameters["TinhTrang"].Value = 1;
            cmd.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Khoa set TenKhoa = @TenKhoa  where MaKhoa = @MaKhoa", conn);
            cmd.Parameters.Add("Makhoa", SqlDbType.Char);
            cmd.Parameters.Add("TenKhoa", SqlDbType.VarChar);

            cmd.Parameters["Makhoa"].Value = textBox1.Text;
            cmd.Parameters["TenKhoa"].Value = textBox2.Text;
            cmd.ExecuteNonQuery();
        }
    }
}
