
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class DanhSachHinhTron
    {
        public List<HinhTron> dsht = new List<HinhTron>();

        public HinhTron this[int index]
        {
            get { return dsht[index]; }
        }

        public int Dem
        {
            get { return dsht.Count; }
        }

        public void Them(HinhTron t)
        {
            dsht.Add(t);
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in dsht)
                s += item + "\n";
            return s;
        }

        public void Xuat()
        {
            Console.WriteLine(this);
        }

        public void Xoa(HinhTron a)
        {
            dsht.Remove(a);
        }
    }
}
