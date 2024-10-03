using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            TamGiac[] tg = new TamGiac[n];
            Console.WriteLine("Nhap thong tin danh sach tam giac");
            for (int i = 0; i < tg.Length; i++)
            {
                Console.WriteLine("Nhap thong tin tam giac " + (i + 1).ToString());
                tg[i] = new TamGiac();
                tg[i].Input();
            }

            Console.WriteLine("Danh sach cac tam giac");
            for (int i = 0; i < tg.Length; i++)
            {
                tg[i].Display();
            }
            
            Console.ReadLine();
        }
    }
   
}