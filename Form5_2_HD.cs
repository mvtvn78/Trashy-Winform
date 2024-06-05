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
    public partial class Form5_2_HD : Form
    {
        SqlConnection conn;
        DataTable dt;
        public Form5_2_HD()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=MVT\\SQLEXPRESS01;Initial Catalog=Tests;Integrated Security=True");
            dt= new DataTable();
        }

        private void Form5_2_HD_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Khoa",conn);
            adapter.Fill(dt);
            comboBox1.DataSource = dt;   
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "Makhoa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
