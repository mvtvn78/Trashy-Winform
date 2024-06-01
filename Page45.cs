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
    public partial class Page45 : Form
    {
        bool isGender;
        string connectString = "Data Source=MVT\\SQLEXPRESS01;Initial Catalog=kaioken;Integrated Security=True;";
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        bool isMale (string x)
        {
            return x == "Nam" ? true : false;
        }
        string getStringGender(bool x)
        {
            return x == true ? "Nam" : "Nữ";
        }
        string convertDateTime(string dt)
        {
            DateTime d = DateTime.ParseExact(dt,"dd-mm-yyyy",System.Globalization.CultureInfo.InvariantCulture);
            return d.ToString("yyyy-mm-dd");
        }
        public Page45()
        {
            InitializeComponent();
            conn = new SqlConnection(connectString);
            adapter = new SqlDataAdapter("select * from SV", conn);
            dt = new DataTable();
        }
        void Reload()
        {
            if(dt.Columns.Contains("Gioitinhs"))
                dt.Columns.Remove("Gioitinhs");
            dt.Rows.Clear();
            adapter.Fill(dt);
            dt.Columns.Add("Gioitinhs",typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["Gioitinhs"] = getStringGender((bool )dr["Gioitinh"]);
            }
            dt.Columns.Remove("Gioitinh");
        }
        private void Page45_Load(object sender, EventArgs e)
        {
            conn.Open();
            Reload();
            dataGridView1.DataSource = dt;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into SV values(@MASV,@Hoten,@QueQuan,@Lop,@Khoa,@Ngaysinh,@Gioitinh)", conn);
            cmd.Parameters.Add("MASV", SqlDbType.VarChar);
            cmd.Parameters.Add("Hoten", SqlDbType.NVarChar);
            cmd.Parameters.Add("QueQuan", SqlDbType.NVarChar);
            cmd.Parameters.Add("Lop", SqlDbType.VarChar);
            cmd.Parameters.Add("Khoa", SqlDbType.VarChar);
            cmd.Parameters.Add("Ngaysinh", SqlDbType.DateTime);
            cmd.Parameters.Add("Gioitinh", SqlDbType.Bit);


            cmd.Parameters["MASV"].Value = textBox1.Text;
            cmd.Parameters["Hoten"].Value = textBox2.Text;
            cmd.Parameters["QueQuan"].Value = comboBox4.Text;
            cmd.Parameters["Lop"].Value = comboBox3.Text;
            cmd.Parameters["Khoa"].Value = comboBox2.Text;
            cmd.Parameters["Ngaysinh"].Value = convertDateTime(dateTimePicker1.Text);
            cmd.Parameters["Gioitinh"].Value = (radioButton1.Checked) ? 1 : 0;
            if (cmd.ExecuteNonQuery() == -1)
            {
                MessageBox.Show("Lỗi");
            }
            Reload();
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
            textBox1.Text = dt.Rows[e.RowIndex]["MASV"].ToString();
            textBox2.Text = dt.Rows[e.RowIndex]["Hoten"].ToString();
            dateTimePicker1.Text = dt.Rows[e.RowIndex]["Ngaysinh"].ToString();
            comboBox4.Text = dt.Rows[e.RowIndex]["Quequan"].ToString();
            comboBox3.Text = dt.Rows[e.RowIndex]["Lop"].ToString();
            comboBox2.Text = dt.Rows[e.RowIndex]["Khoa"].ToString();
            if (dt.Rows[e.RowIndex]["Gioitinhs"].ToString() == "Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Page45_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(conn.State == ConnectionState.Open )
            {
                conn.Close();
            }
        }
    }
}
