using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN sln = new TimSLN();
            int n = sln.NhapMotSo();

            int max = sln.TimMax(n);
            Console.Write("So lon nhat trong {0} phan tu vua nhap la {1}", n,max);
            
            Console.ReadLine();

        }
    }
}
