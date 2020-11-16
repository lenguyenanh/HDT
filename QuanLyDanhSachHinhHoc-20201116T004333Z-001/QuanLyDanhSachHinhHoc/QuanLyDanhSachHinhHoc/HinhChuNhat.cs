using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class HinhChuNhat
    {
        public float chieuDai;
        public float cd
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public float chieuRong;
        public float cr
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        public float chuVi;
        public float cv
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        public float dienTich;
        public float dt
        {
            get { return dienTich; }
            set { dienTich = value; }
        }
        public void NhapHCN()
        {
            do
            {
                Console.Write("Nhap chieu dai: ");
                cd = float.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                cr = float.Parse(Console.ReadLine());
  
            } while (cd < 0 && cr < 0);
        }
        public float ChuVi()
        {
            return (cd + cr) * 2;
        }
        public float DienTich()
        {
            return cd * cr;
        }
        public override string ToString()
        {
            return string.Format("Hinh chu nhat co: chieu dai: {0}, chieu rong: {1}, chu vi: {2}, dien tich: {3}", cd, cr, ChuVi(), DienTich());
        }
    }
}
