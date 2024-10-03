using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class SinhVien
    {
        private string _hoTen;
        private int _tuoi;
        private float _diemToan, _diemVan, _dtb;

        // Phuong thuc khoi tao
        public SinhVien()
        {
            _hoTen = "";
            _tuoi = 0;
            _diemToan = _diemVan = _dtb = 0;
        }


        // Cac phuong thuc Properties
        public string HoTen { get { return _hoTen; } set { _hoTen = value; } }

        public int Tuoi { get { return _tuoi; } set { _tuoi = value; } }
        public float DiemToan { get { return _diemToan; } set { _diemToan = value; } }
        public float DiemVan { get { return _diemVan; } set { _diemVan = value; } }
        public float DTB { get { return _dtb; } set { _dtb = value; } }

        // Phuong thuc nhap/xuat
        public void NhapSv()
        {
            Console.Write("Nhap ho ten Sinh Vien: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            Tuoi= Convert.ToInt32(Console.ReadLine()); 

            float tmp;
            do
            {
                Console.Write("Nhap diem Toan: ");
                tmp = float.Parse(Console.ReadLine());
                if (tmp < 0 || tmp > 10)
                {
                    Console.WriteLine("Nhap khong hop le! Diem phai tu 0 -> 10!");
                    Console.WriteLine("Nhap lai!");
                }
            } while (tmp < 0 || tmp > 10);
            DiemToan = tmp;

            do
            {
                Console.Write("Nhap diem Van: ");
                tmp = float.Parse(Console.ReadLine());
                if (tmp < 0.0 || tmp > 10.0)
                {
                    Console.WriteLine("Nhap khong hop le! Diem phai tu 0 -> 10!");
                    Console.WriteLine("Nhap lai!");
                }
            } while (tmp < 0.0 || tmp > 10.0);
            DiemVan = tmp;
        }

        public void XuatSV()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-5} {3,-5} {4,-5}", HoTen, Tuoi, DiemToan, DiemVan, DTB);
        }

        public void TinhDTB()
        {
            DTB = (float)(DiemToan + DiemVan) / 2;
        }
    }
}
