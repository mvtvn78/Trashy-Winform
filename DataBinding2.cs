using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    public partial class DataBinding2 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        BindingSource bs;
        public DataBinding2()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=MVT\\SQLEXPRESS01;Initial Catalog=QuanLyHocSinh;Integrated Security=True;"); 
        }

        private void DataBinding2_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select * from NGUOIDUNG";
            adapter = new SqlDataAdapter(sql,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds,"tbtNguoiDung");

            bs = new BindingSource(ds, "tbtNguoiDung");

            MaND.DataBindings.Add("Text", bs, "MaNguoiDung");
            MaLoai.DataBindings.Add("Text", bs, "MaLoai");
            TenND.DataBindings.Add("Text", bs, "TenNguoiDung");
            TenDN.DataBindings.Add("Text", bs, "TenDangNhap");
            MK.DataBindings.Add("Text", bs, "MatKhau");
            //
            label7.Text ="Trang" +(bs.Position+1).ToString() + " of "+bs.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
            //
            label7.Text = "Trang" + (bs.Position + 1).ToString() + " of " + bs.Count;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count-1;
            //
            label7.Text = "Trang" + (bs.Position + 1).ToString() + " of " + bs.Count;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(bs.Position< bs.Count-1) bs.Position++;
            //
            label7.Text = "Trang" + (bs.Position + 1).ToString() + " of " + bs.Count;
        }

    
        private void button5_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0) bs.Position--;
            //
            label7.Text = "Trang" + (bs.Position + 1).ToString() + " of " + bs.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            MessageBox.Show(bs.Position.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            int kt = adapter.Update(ds.Tables["tbtNguoiDung"]);
            if(kt >0)
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // xóa hiện tại đang làm việc
            bs.RemoveCurrent();
            int kt = adapter.Update(ds.Tables["tbtNguoiDung"]);
            if(kt >0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
