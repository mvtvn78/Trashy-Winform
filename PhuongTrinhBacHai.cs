using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trashy_WinForm
{
    internal class PhuongTrinhBacHai
    {
        public PhuongTrinhBacHai()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        // Ax^2 + Bx + C =0;
        // Bx+ C = 0;
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public bool isPTBN()
        {
            return A == 0;
        }
      
        public  string Solve()
        {
            try
            {
                if (isPTBN())
                {
                    return $"Phương trình có nghiệm x = {-C *1.0/ B}";
                }
                else
                {
                    float delta = B * B - 4 * A * C;
                    if (delta > 0)
                    {
                        return $"Phương tình có 2 nghiệm phân biệt x1 = {(-B + Math.Sqrt(delta)) / (2 * A)} x2 = {(-B - Math.Sqrt(delta)) / (2 * A)}";
                    }
                    else if (delta < 0)
                    {
                        return $"Phương trình có một nghiệm kép x = {-B / (2 * A)}";
                    }
                    else
                    {
                        return $"Phương trình vô nghiệm";
                    }

                }
            }
            catch
            {
                return "Có lỗi xảy ra ! hãy kiểm tra các trường của bạn cho hợp lệ";
            }
        }

    }
}
