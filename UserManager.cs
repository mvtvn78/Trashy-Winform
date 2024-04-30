using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trashy_WinForm.ConnectDatabase;

namespace Trashy_WinForm
{
    public partial class UserManager : Form
    {
        private SQLConnect sqlconn;
        private List<User> users;
        public UserManager()
        {
            InitializeComponent();
            sqlconn = new SQLConnect();
            users = new List<User>();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            users.Add(new User(1, "m1", "v", "t", "a", "e"));
            users.Add(new User(2, "m1", "v", "t", "a", "e"));
            dataGridView1.DataSource = users;
        }
    }
}
