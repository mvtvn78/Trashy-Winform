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
    public partial class Adapter : Form
    {
        private string strcon = "Data Source=MVT\\SQLEXPRESS01;Initial Catalog=mvt;Integrated Security=True;";
        private SqlConnection conn;
        private SqlCommand cmd;

        public Adapter()
        {
            InitializeComponent();
            conn = new SqlConnection(strcon);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                MessageBox.Show("Connection successfully");
                cmd = new SqlCommand("select * from test",conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dtSV = new DataTable();
                sqlDataAdapter.Fill(dtSV);
                dataGridView1.DataSource = dtSV;
            }   
        }

        private void Adapter_Load(object sender, EventArgs e)
        {

        }
    }
}
