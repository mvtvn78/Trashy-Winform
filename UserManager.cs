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

       
        private void Load_DataGrid()
        {
            dataGridView1.DataSource = users;
        }
        private void UserManager_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                users.Add(new User(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text));
                Load_DataGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
