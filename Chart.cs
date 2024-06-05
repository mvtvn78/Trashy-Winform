using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }
        Hashtable hashtable = new Hashtable();
        private void Chart_Load(object sender, EventArgs e)
        {
            hashtable.Add("mai văn tiền",2 );
            hashtable.Add("Mai hoàng tân", 5);
            hashtable.Add("Liên hoàng tụy", 10);
            chart1.Series[0].XValueMember = "key";
            chart1.Series[0].YValueMembers = "value";
            chart1.DataSource = hashtable;
        }
    }
}
