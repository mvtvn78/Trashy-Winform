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
        SqlConnection conn;
        string sql_con;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        string ConvertStringFormatForStore(string ngay)
        {
            DateTime d = DateTime.ParseExact(ngay, "dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);

            return d.ToString("yyyy/MM/dd"); 
        }
        public ADO()
        {
            InitializeComponent();
            sql_con = "Data Source=MVT\\SQLEXPRESS01;Initial Catalog=mvt;Integrated Security=True";
            conn = new SqlConnection(sql_con);
        }
        private void GetData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, sql_con);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                table.PrimaryKey = new DataColumn[] { table.Columns["MASV"] }; 
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void ADO_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from HocSinh");
            string s = "15/09/2004";
            string fs = ConvertStringFormatForStore(s);
            MessageBox.Show($"Khi format : {fs}", s);
        }

        private void ADO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(conn != null && conn.State == ConnectionState.Open) 
            {
                conn.Close();
            }
        }
    }
}
