using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trashy_WinForm.ConnectDatabase;
using Trashy_WinForm.QueryDatabase;

namespace Trashy_WinForm
{
    public partial class CRUD : Form
    {
        private SQLConnect sQLConnect;
        private SQLQuery SQLQuery;
        public int[] arr;
        const int MAX = 100;
        static int index = 0;
        public CRUD()
        {
            InitializeComponent();
            sQLConnect = new SQLConnect();
            SQLQuery = new SQLQuery();
            sQLConnect.connect();
            arr = new int[MAX];
        }
        ~CRUD()
        {
            sQLConnect.close();
        }
        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLQuery.Select("Select * from HocSinh", sQLConnect.SqlCon); 

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int rd = rand.Next(6, 100);
            if (SQLQuery.QueryNotSelect($"Insert into HocSinh Values({rd},'Mai Văn Tiền {rd}')", sQLConnect.SqlCon))
            {
                MessageBox.Show("Đã chèn thành công");
            }
            else
            {
                MessageBox.Show("Chèn thất bại !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SQLQuery.QueryNotSelect($"update HocSinh set Hoten= '{TextSet.Text}' where MaID = {int.Parse(textID.Text)}", sQLConnect.SqlCon))
            {
                MessageBox.Show("Đã update thành công");
            }
            else
            {
                MessageBox.Show("update thất bại !!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SQLQuery.QueryNotSelect($"delete  HocSinh where MaID = {DTextID.Text}", sQLConnect.SqlCon))
            {
                MessageBox.Show("Đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Delete thất bại !!");
            }
        }
    }
}
