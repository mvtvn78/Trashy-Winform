using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashy_WinForm
{
    internal class SinhVien1
    {
        public SinhVien1()
        {

        }
        public SinhVien1(int mASV, string hoten, string ngaysinh, string quequan, string lop, string khoa, string gioitinh)
        {
            MASV = mASV;
            Hoten = hoten;
            Ngaysinh = ngaysinh;
            Quequan = quequan;
            Lop = lop;
            Khoa = khoa;
            Gioitinh = gioitinh;
        }
        public SinhVien1(int mASV, string hoten, string ngaysinh, string quequan, string lop, string khoa, bool gioitinh)
        {
            MASV = mASV;
            Hoten = hoten;
            Ngaysinh = ngaysinh;
            Quequan = quequan;
            Lop = lop;
            Khoa = khoa;
            Gioitinh = (gioitinh) ? "Nam" : "Nữ";
        }

      

        public int MASV { get; set; }
        public string Hoten { get; set; }
        public string Ngaysinh { get; set; }  
        public string Quequan { get; set; }
        public string  Lop { get; set; }
        public string Khoa { get; set;}
        public string Gioitinh { get; set; }
    }
}
