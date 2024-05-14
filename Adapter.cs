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

        int x = 0;
        int cur_indx = -1;
        public Adapter()
        {
            InitializeComponent();
           
        }

        private void Adapter_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            dataGridView1.Rows.Add(x.ToString(), "Mai Văn Tiền");
            cur_indx = 0;
            dataGridView1.Rows[0].Selected = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cur_indx.ToString(),dataGridView1.Rows.Count.ToString());
            //XOA
            if (cur_indx != -1)
                dataGridView1.Rows.RemoveAt(cur_indx);
            //XU LY
            if (cur_indx == 0 && dataGridView1.Rows.Count != 0)
                cur_indx = 0;
            else if(cur_indx == dataGridView1.Rows.Count  && dataGridView1.Rows.Count != 0)
                cur_indx = dataGridView1.Rows.Count -1;
            else
                cur_indx = -1;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[cur_indx].Cells[0].Value.ToString());
            MessageBox.Show(dataGridView1.Rows[cur_indx].Cells[1].Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_indx = e.RowIndex;

        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

            MessageBox.Show(e.Cell.Value.ToString());

        }
    }
}
