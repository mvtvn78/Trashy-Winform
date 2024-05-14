//Iteraction
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
    public partial class Adapter : Form
    {

        DataTable dt ;

        public Adapter()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("ID",typeof(int));
            dt.Columns.Add("First Name",typeof(string));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"], dt.Columns["First Name"] };
            dt.TableName = " Testing";
            dataGridView1.DataSource = dt;
        }

        private void Adapter_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.NewRow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    throw new Exception("ss");
                DataRow row = dt.Rows[dataGridView1.CurrentRow.Index];
                dt.Rows.Remove(row);
            }
            catch (Exception  )
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt.Rows.Count.ToString());

        }
    }
}
