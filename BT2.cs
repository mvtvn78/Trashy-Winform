using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Trashy_WinForm
{
    public partial class BT2 : Form
    {
        private byte State = 0;
        private List<String> Input_nha;
        private List<String> Input_xe;
        private List<String> Input_nguoi;
        delegate void D_SoSanh(object a, object b) ;
        //Control Label and Textbox
        private IEnumerable<Control> controls = null;
        D_SoSanh ss = null;
        public BT2()
        {
            InitializeComponent();
            controls = Controls.OfType<Control>().Where(x => x is TextBox || x is Label);
            State = 0;
            Input_nha = new List<string>();
            Input_xe = new List<string>();
            Input_nguoi = new List<string>();
            Input_nha.Add("Nhập diện tích nhà B");
            Input_nha.Add("Nhập diện tích nhà A");

            Input_xe.Add("Nhập giá xe xe B");
            Input_xe.Add("Nhập giá xe xe A");

            Input_nguoi.Add("Nhập chiều cao người B");
            Input_nguoi.Add("Nhập chiều cao người A");
            Handle(false);
        }


        private void Handle(bool visible = true)
        {
            List<string> temp = (State ==1) ? Input_nha : (State ==2) ? Input_xe : (State ==3) ? Input_nguoi : null;
            if (temp == null) visible =false;
            int id = 0;
            foreach (Control control in controls)
            {
                    if(control is Label && control.Text != "Nhập thông tin" && visible)
                    {
                        control.Text = temp[id++];
                    }
                    control.Visible = visible;
            }
        }
        void ClearTextBox()
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.Text =string.Empty;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            State =2;
            Handle(true);
        }

        private void BT2_Layout(object sender, LayoutEventArgs e)
        {
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
            State = 1;
            Handle(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            State = 3;
            Handle(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(State ==1)
            {
                ss = new D_SoSanh(Nha.SoSanh);
                ss(new Nha(float.Parse(textBox1.Text)), new Nha(float.Parse(textBox2.Text)));
            }
            if (State == 2)
            {
                ss = new D_SoSanh(Xe.SoSanh);
                ss(new Xe(long.Parse(textBox1.Text)), new Xe(long.Parse(textBox2.Text)));
            }
            if (State == 3)
            {
                ss = new D_SoSanh(Nguoi.SoSanh);
                ss(new Nguoi(float.Parse(textBox1.Text)), new Nguoi(float.Parse(textBox2.Text)));
            }
        }
    }
}
