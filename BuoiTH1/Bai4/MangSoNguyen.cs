using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class MangSoNguyen
    {
        public int NhapSoDuong()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            return n;
        }

        public int NhapSo()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu a[{0}] = ", (i + 1));
                a[i] = NhapSo();
            }
        }

        public void InMang(int[] a) 
        {
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write("{0} ", a[i]);
            } 
        }

        public int TimMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }

        public int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }


        public void SapXep(int[] a)
        {
            for (int i = 0;i < a.Length; i++)
                for(int j = i+1; j < a.Length - 1; j++)
                    if (a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
        }

        public int TinhTong(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
                sum += a[i];
            return sum;
        }
    }
}
