using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GiaiThuaN gt = new GiaiThuaN();
            int n = gt.NhapMotSo();
            Console.WriteLine("Gia tri gia thua cua {0} = {1}", n, gt.TinhGT(n));

            Console.ReadLine();
        }
    }
}

