using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
namespace Trashy_WinForm
{
    public partial class ADO : Form
    {
       
        DataTable dt;
        public ADO()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Hello",typeof(string));
            dt.Columns.Add("Kaioken",typeof(string));
            dt.Rows.Add("Mai Van Tien", "Cung Xu Nu");
        }

        private void ADO_Load(object sender, EventArgs e)
        {
            textBox1.DataBindings.Add("Text", dt, "Kaioken");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt.Rows[0]["Kaioken"].ToString());
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
