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
    public partial class Mananh : Form
    {
        List<int> ds_chon;
        List<int> ds_ban;
        int ve_a = 1000;
        int ve_b = 1500;
        int ve_c = 2000;
        int current = -1;
        private Color da_ban = Color.Yellow;
        private Color dang_chong = Color.Blue;
        private Color default_ = Color.White;
        private IEnumerable<Control> controls;
        public int isVeloai(int a)
        {
            // Ve loai A : -1
            // Ve loai B : 0
            // Ve loai C : 1
            if (a >= 1 && a <= 5)
                return -1;
            else if (a <= 10 && a >= 6)
                return 0;
            return 1;
        }
        public Mananh()
        {
            InitializeComponent();
            ds_chon= new List<int>();
            controls = Controls.OfType<Control>().Where(x =>  x is Button);
            ds_ban = new List<int>();
        }
        private void button_Click (object sender, EventArgs e)
        {
            Button curr =  (Button)sender;
            current = int.Parse(curr.Text);
            if(!ds_ban.Contains(current))
            {
                if (!ds_chon.Contains(current))
                {
                    curr.BackColor = dang_chong;
                    ds_chon.Add(current);
                }
                else
                {
                    ds_chon.Remove(current);
                    curr.BackColor = default_;
                }
            }    
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (Control control in controls)
            {
                int k = 0;
                bool value =  int.TryParse(control.Text, out k);
                if (value && ds_chon.Contains(int.Parse(control.Text)))
                {
                    control.BackColor = da_ban;
                }
            }
            foreach(int item in ds_chon)
            {
                ds_ban.Add(item);
                if(isVeloai(item) == 0)
                {
                    sum += ve_a;
                }   
                else if( isVeloai(item) == 1)
                {
                    sum += ve_b;
                }
                else
                {
                    sum += ve_c;
                }
            }
            textBox1.Text = sum.ToString();
            ds_chon.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            foreach(Control control in controls)
            {
                int k = 0;
                bool value = int.TryParse(control.Text, out k);
                if (value && ds_chon.Contains(int.Parse(control.Text)))
                {
                    control.BackColor = default_;
                }
            }
            current = -1;
            ds_chon.Clear();
        }
    }
}
