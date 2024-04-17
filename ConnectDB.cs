using Microsoft.SqlServer.Server;
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
    public partial class ConnectDB  :Form
    {
        private SQLConnect sQLConnect;
        public ConnectDB()
        {
            InitializeComponent();
            sQLConnect = new SQLConnect();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sQLConnect.connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sQLConnect.close();
        }
    }
}
