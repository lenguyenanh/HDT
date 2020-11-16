using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class HinhVuong
    {
        public float canh;
        public float c
        {
            get { return canh; }
            set { canh = value; }
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
        public void NhapHV()
        {
            do
            {
                Console.Write("Nhap do dai canh: ");
                canh = float.Parse(Console.ReadLine());
            } while (canh < 0);
            
        }
        public float TinhChuVi()
        {
            return canh * 4;
            
        }
        public float TinhDienTich()
        {
            return  canh * canh;
            
        }
        public override string ToString()
        {
            return string.Format("Hinh vuong co canh: {0}, chu vi: {1}, dien tich: {2}", canh, TinhChuVi(), TinhDienTich() );
        }
       

    }

}
