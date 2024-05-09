using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Lệnh import 
using Newtonsoft.Json;
using System.IO;
namespace Trashy_WinForm
{
    public partial class JSON : Form
    {
        public JSON()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"data.json");
            string json = reader.ReadToEnd();
            var a = JsonConvert.DeserializeObject<SinhVien1>(json);
            MessageBox.Show(a.Hoten);
        }
    }
}
