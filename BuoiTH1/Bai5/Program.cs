using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong Sinh Vien: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];

            Console.WriteLine("Nhap danh sach Sinh Vien");
            for (int i = 0; i < sv.Length; i++)
            {
                Console.WriteLine("\nNhap Sinh vien {0}", (i + 1));
                sv[i] = new SinhVien();
                sv[i].NhapSv();
                sv[i].TinhDTB();
            }

            Console.WriteLine("Xuat danh sach Sinh Vien");
            for (int i = 0; i < sv.Length; i++)
                sv[i].XuatSV();

            Console.ReadKey();
        }
    }
}
