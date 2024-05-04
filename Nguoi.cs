using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    internal class Nguoi
    {
        public Nguoi(float chieucao)
        {
            Chieucao = chieucao;
        }

        public float Chieucao {  get; set; }
        public static void SoSanh (object a, object b)
        {
            Nguoi t1, t2 = null;
            t1 = a as Nguoi;
            t2 = b as Nguoi;
            MessageBox.Show((t1.Chieucao > t2.Chieucao) ? "Người a chiều cao lớn hơn" :"Người b chiều cao lớn hơn");
        }
    }
}
