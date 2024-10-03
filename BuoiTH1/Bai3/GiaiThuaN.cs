using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class GiaiThuaN
    {
        public int NhapMotSo()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            return n;
        }

        public int TinhGT(int n)
        {
            int tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp *= i;
            }
            return tmp;
        }
    }
}
