using System;
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
    public partial class Databinding1 : Form
    {
        public Databinding1()
        {
            InitializeComponent();
        }

        private void Databinding1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHocSinhDataSet.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.quanLyHocSinhDataSet.NGUOIDUNG);

        }
    }
}
