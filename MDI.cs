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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mananh mananh = new Mananh();
            mananh.MdiParent = this; // cha của form con f là form hiện tại.
            mananh.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giaiphuongtrinh gpt = new giaiphuongtrinh();
            gpt.MdiParent = this;
            gpt.Show();
        }

        private void biToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Leave(object sender, EventArgs e)
        {

        }

        private void MDI_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void MDI_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }

        private void MDI_MdiChildActivate(object sender, EventArgs e)
        {
            int count = this.MdiChildren.Count();
            label1.Text = $"đang có {count} Form hoạt động";
        }

        private void MDI_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Hehe");

        }
    }
}
