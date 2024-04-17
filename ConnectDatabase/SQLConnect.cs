using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace Trashy_WinForm.ConnectDatabase
{
     class SQLConnect
    {
        private string strCon;
        private SqlConnection sqlCon;
        public SQLConnect() 
        {
            strCon = @"Data Source=MVT\SQLEXPRESS01;Initial Catalog=mvt;Integrated Security=True;";
            sqlCon = null;
        }
        public void connect()
        {
            try
            {   //Sql Intialization
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                
                //Connect
                if(sqlCon.State == ConnectionState.Closed) {
                    sqlCon.Open();
                    MessageBox.Show("Connect Successfully");
                }
            }
            catch { MessageBox.Show("Connect Failed"); }
        }
        public void close()
        {
            if(sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Terminate Connection Successfully");
            }
            else
            {
                MessageBox.Show("Fuck the shit you have to connect DB before");
            }
        }
    }
}
