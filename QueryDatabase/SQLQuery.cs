using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Trashy_WinForm.QueryDatabase
{
    internal class SQLQuery
    {
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SQLQuery()
        {
            cmd = null;
            reader = null;
        }
        public void Select(string sql, SqlConnection conn)
        {
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            string OutPut = string.Empty;
            while(reader.Read())
            {
                OutPut = OutPut + reader.GetValue(0).ToString() + reader.GetValue(1).ToString() + "\n";
            }
            MessageBox.Show(OutPut);
            reader.Close();
            cmd.Dispose();
        }
        public bool QueryNotSelect(string sql,SqlConnection conn)
        {
           try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
