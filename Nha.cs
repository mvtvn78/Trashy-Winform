using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    internal class Nha
    {
        public Nha(float san_nha)
        {
            San_nha = san_nha;
        }

        public float San_nha {  get; set; }
        public static void SoSanh(object a, object b)
        {
            Nha t1, t2 = null;
            t1 = (Nha) a;
            t2 = (Nha) b;
            if (t1 == null || t2 == null) return;
            MessageBox.Show((t1.San_nha > t2.San_nha) ? "Nhà a sàn nhà lớn hơn" : "Nhà b sàn nhà lớn hơn");
        }
    }
}
