using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSoLonNhat sln = new TimSoLonNhat();
            Console.WriteLine("Nhap so a: ");
            int a = sln.NhapMotSo();

            Console.WriteLine("Nhap so b: ");
            int b = sln.NhapMotSo();

            Console.WriteLine("Nhap so c: ");
            int c = sln.NhapMotSo();

            int max = sln.TimMax(a, b, c);
            Console.WriteLine("So lon nhat trong 3 so {0}, {1}, {2} la {3}", a, b, c, max);
            Console.ReadLine();

        }
    }
}
