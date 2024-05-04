using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    internal class Xe
    {
        public Xe(long gia_Xe)
        {
            Gia_Xe = gia_Xe;
        }

        public long Gia_Xe {  get; set; }
        public static void SoSanh(object a, object b)
        {
            Xe t1, t2 = null;
            t1 = a as Xe;
            t2 = b as Xe;
            MessageBox.Show((t1.Gia_Xe > t2.Gia_Xe) ? "Xe a giá xe lớn hơn" : "Xe b giá xe lớn hơn");
        }
    }
}
