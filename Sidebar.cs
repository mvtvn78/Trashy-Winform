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
    public partial class Sidebar : Form
    {
        Page45 suB_form1;
        Mananh suB_form2;
        public Sidebar()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 165)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <=53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sideBarExpand = true;
        private void sliderBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideB.Width -= 10;
                if(sideB.Width<= 52)
                {
                    sideBarExpand = false;
                    sliderBarTransition.Stop();
                }
            }
            else
            {
                sideB.Width += 10;
                if(sideB.Width >= 184)
                {
                    sideBarExpand = true;
                    sliderBarTransition.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sliderBarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(suB_form1 == null)
            {
                suB_form1 = new Page45();
                suB_form1.FormClosed += SuB_form1_FormClosed;
                suB_form1.MdiParent = this;
                suB_form1.Show();
            }
            else
            {
                suB_form1.Activate();
            }
        }

        private void SuB_form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            suB_form1 = null;
        }
    }
}
