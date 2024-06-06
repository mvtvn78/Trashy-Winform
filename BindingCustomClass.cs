using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trashy_WinForm
{
    // kế thừa : interface
    class BindingCustomClass : INotifyPropertyChanged
    {
        private DateTime myName;
        //Getter Setter
        public DateTime MyValue
        {
            get { return myName; }
            set
            {
                myName = value;
                Age = (DateTime.Now.Year - MyValue.Year).ToString() ;
                // gọi binding khi có thay đổi
                OnPropertyChanged("MyValue");
            }
        }
        //Binding Age
        private string age;
        public string Age
        {
            get { return age; }
            set
            {
                age = value;
                // thông báo bindings
                OnPropertyChanged("Age");
            }
        } 
        //implement inteface
        public event PropertyChangedEventHandler PropertyChanged;
        //override 
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // khai báo binding
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }    
        }
    }
}
