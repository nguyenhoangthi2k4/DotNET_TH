using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen mang = new MangSoNguyen();
            int n = mang.NhapSoDuong();
            int[] arr = new int[n];

            Console.WriteLine("Nhap cac phan tu trong mang");
            mang.NhapMang(arr);

            Console.WriteLine("\nIn cac phan tu trong mang");
            mang.SapXep(arr);
            mang.InMang(arr);

            Console.WriteLine("\n\nMAX = {0}, MIN = {1}", mang.TimMax(arr), mang.TimMin(arr));
            Console.WriteLine("\nSum = {0}", mang.TinhTong(arr));
            Console.ReadLine();

        }
    }
}
