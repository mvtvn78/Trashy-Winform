using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Trashy_WinForm
{
    public partial class CaPheSinhVien : Form
    {
        long tong_tien = 0;
        int so_khach = 0;
        Hashtable drinks;
        bool isStudent;
        Hashtable foods;
        List<string>  drinkNames = new List<string>() { "Cà phê đen" , "Cà phê đá", "Cà phê sữa", "Cà phê sữa đá","Cà phê kem"};
        List<string> foodNames = new List<string>() { "Bánh mỳ trứng","Bánh mỳ cá","Mỳ tôm trứng","Mỳ xào bò","Mỳ cay"};
        IEnumerable<Control> controls;
        IEnumerable<Control> controls_btn;
        List<CheckBox> choice_food;
        RadioButton check_current;
        public CaPheSinhVien()
        {
            InitializeComponent();
            drinks = new Hashtable();
            foods = new Hashtable();
            choice_food = new List<CheckBox>();
            controls_btn = Controls.OfType<Button>();
            controls = Controls.OfType<Control>().Where(x => x is GroupBox);
            isStudent = false;
            check_current = new RadioButton();
            Init();
        }
        public bool GetRadioButton()
        {
            int i = 0;
            try
            {
                foreach (Control control in controls)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is RadioButton)
                        {
                            RadioButton radioButton1 = (RadioButton)control2;
                            if (radioButton1.Checked)
                            {
                                check_current = radioButton1;
                                ++i;
                            }
                        }
                    }
                }
                if(i!=0)
                    return true;
                return false;
            }
             catch 
            {
                return false;
            }
        }
        void Init()
        {
            int i = 0;
            int j = 0;
            foreach(Control control in controls)
            {
                foreach( Control control2 in control.Controls)
                {
                    if(control2 is CheckBox)
                    {
                        control2.Text = foodNames[i++];
                    }
                    else if ( control2 is RadioButton)
                    {
                        control2.Text = drinkNames[j++];
                    }
                }    
            }
            drinks.Add(drinkNames[0], 20000);
            drinks.Add(drinkNames[1], 25000);
            drinks.Add(drinkNames[2], 25000);
            drinks.Add(drinkNames[3], 30000);
            drinks.Add(drinkNames[4], 35000);

            foods.Add(foodNames[0], 15000);
            foods.Add(foodNames[1], 15000);
            foods.Add(foodNames[2], 20000);
            foods.Add(foodNames[3], 30000);
            foods.Add(foodNames[4], 50000);
            //Tooltip


            foreach (Control control in controls)
            {
                foreach (Control control2 in control.Controls)
                {
                    if (control2 is CheckBox)
                    {
                       toolTip1.SetToolTip(control2, foods[control2.Text].ToString());
                    }
                    else if (control2 is RadioButton)
                    {
                        toolTip1.SetToolTip(control2, drinks[control2.Text].ToString());
                    }
                }
            }
        }
        public void Show_BTN(bool value)
        {
            foreach (Control control in controls_btn)
            {
                control.Enabled = value;
            }
        }

        private void CaPheSinhVien_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            Show_BTN(false);
            button4.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!isStudent)
            {
                checkBox1.Checked = true;
                isStudent = true;
                return;
            }
            isStudent = false;
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sum = 0;
            int x_r = 0;
            if (GetRadioButton())
                x_r = (int) drinks[check_current.Text];
            sum += x_r;
            
            foreach (CheckBox control in choice_food)
            {
                sum += (int)foods[control.Text];
            }
            if (isStudent)
                sum = Convert.ToInt64(sum * 0.8);
            MessageBox.Show($"Của bạn {textBox1.Text} {string.Format("{0:N0}",sum)} ");
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            

            so_khach += int.Parse(textBox2.Text);
            tong_tien += sum;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = sender as CheckBox;
            if(!choice_food.Contains(a))
                choice_food.Add(a);
            else choice_food.Remove(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = (int)e.KeyChar;
            bool value = int.TryParse(e.KeyChar.ToString(), out int val) || x ==8 ;
            if (!value)
            {
                e.Handled = true;
                errorProvider1.SetError(textBox2, "Vui lòng chỉ ghi giá trị số");
            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
        }

        private void CaPheSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
              
        }

        private void CaPheSinhVien_KeyUp(object sender, KeyEventArgs e)
        {
            bool value = textBox1.Text != string.Empty && textBox2.Text != string.Empty;
            if (value)
            {
                button1.Enabled = true;
                return;
            }
            button1.Enabled = false;
        }

        private void CaPheSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            choice_food.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            so_khach = 0;
            tong_tien = 0;
            choice_food.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = so_khach.ToString();
            textBox4.Text = string.Format("{0:N0}", tong_tien);
            choice_food.Clear();
            so_khach = 0;
            tong_tien = 0;
            button3.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
