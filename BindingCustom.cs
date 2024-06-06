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
    public partial class BindingCustom : Form
    {
        public BindingCustom()
        {
            InitializeComponent();
            Load();
        }
        BindingCustomClass bdC = new BindingCustomClass();
        void Load()
        {
            Binding dataBinding = new Binding("Value",bdC,"MyValue",true,DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add(dataBinding);

            Binding dataBinding2 = new Binding("Text", bdC, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.DataBindings.Add(dataBinding2);
        }
    }
}
