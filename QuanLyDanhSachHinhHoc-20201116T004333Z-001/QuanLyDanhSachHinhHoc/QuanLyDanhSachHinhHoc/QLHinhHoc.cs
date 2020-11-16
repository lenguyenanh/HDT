using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinhHoc
{
    class QLHinhHoc
    {
        
        public DanhSachHinhChuNhat DS_HCN = new DanhSachHinhChuNhat();
		public DanhSachHinhTron DS_HT = new DanhSachHinhTron();
		public DanhSachHinhVuong dshv = new DanhSachHinhVuong();
        
        List<HinhVuong>  danhSachHinhVuong = new List<HinhVuong>();
        List<HinhTron>  danhSachHinhTron = new List<HinhTron>();
        List<HinhChuNhat>  danhSachHinhCN = new List<HinhChuNhat>();

        //Khởi tạo 1 danh sách lưu 3 loại hình
        

        /// <summary>
        /// Đọc dữ liệu từ tập tin
        /// </summary>
        public void DocTuFile()
        {
            string path = "data.txt";
            StreamReader sr = new StreamReader(path);
            string l = "";
            while ((l = sr.ReadLine()) != null)
            {
                string[] t = l.Split(' ');
                if (t[0] == "ht")
                    DS_HT.Them(new HinhTron(double.Parse(t[1])));
                else if (t[0] == "HV")
                    dshv.Them(new HinhVuong(float.Parse(t[1])));
                else
                    DS_HCN.Them(new HinhChuNhat(float.Parse(t[1]), float.Parse(t[2])));
            }
        }
        
        
    }
}
