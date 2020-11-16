using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class HinhTron
    {
        public double BanKinh;
        public double bk
        {
            get { return BanKinh; }
            set { this.BanKinh = value; }
        }
        private double Chuvi;
        public double Cv
        {
            get { return Chuvi; }
            set { this.Chuvi= value;}
        }
        private double Dientich;
        public double dt
        {
            get { return Dientich; }
            set { this.Dientich = value; }

        }
        //public HinhTron( double banKinh)
        //{
        //    BanKinh = banKinh;
        //}
        public void nhapHinhtron()
        {
            do
            {
            Console.Write("Nhap ban kinh :");
            BanKinh = double.Parse(Console.ReadLine());
                
            } while (BanKinh<0);
        }
        public double ChuVi()
        {
            return BanKinh * 2 * Math.PI;
        }
        public double DienTichHT()
        {
            return (BanKinh * BanKinh) * Math.PI;
        }
        public override string ToString()
        {
            return string.Format( "Hinh tron: Ban kinh: {0}, chu vi hinh tron: {1}, dien tich hinh tron: {2}", BanKinh, ChuVi(), DienTichHT());
        }
        
    }
}
