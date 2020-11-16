using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class DanhSachHinhVuong
    {
        public List<HinhVuong> dshv = new List<HinhVuong>();
        public HinhVuong this[int index]
        {
            get { return dshv[index]; }
        }
        public int Dem
        {
            get { return dshv.Count; }
        }
        public void Them(HinhVuong v)
        {
            dshv.Add(v);
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in dshv)
                s += item + "\n";
            return s;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public void Xoa(HinhVuong a)
        {
            dshv.Remove(a); 
        }
    }
}
