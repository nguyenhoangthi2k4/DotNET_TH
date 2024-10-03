using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TimSLN
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

        public int TimMax(int n)
        {
            int i = 0, max = 0, tmp;
            do
            {
                Console.Write("Nhap so nguyen thu {0} = ", (i + 1));
                tmp = Convert.ToInt32(Console.ReadLine());
                if (max < tmp)
                {
                    max = tmp;
                }
                i++;
            } while (i < n);
            return max;
        }
    }
}
