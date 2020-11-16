using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class DanhSachHinhChuNhat
    {
        public List<HinhChuNhat> dshcn = new List<HinhChuNhat>();

        public HinhChuNhat this[int index]
        {
            get { return dshcn[index]; }
        }

        public int Dem
        {
            get { return dshcn.Count; }
        }

        public void Them(HinhChuNhat n)
        {
            dshcn.Add(n);
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in dshcn)
                s += item + "\n";
            return s;
        }

        public void Xuat()
        {
            Console.WriteLine(this);
        }

        public void Xoa(HinhChuNhat a)
        {
            dshcn.Remove(a);
        }
    }
}
