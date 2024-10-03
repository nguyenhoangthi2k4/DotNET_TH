using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class PhuongTrinhBac2
    {
        private int _soA, _soB, _soC;

        // Properties
        public int SoA { get => _soA; set => _soA = value; }
        public int SoB { get => _soB; set => _soB = value; }
        public int SoC { get => _soC; set => _soC = value; }

        // Constructor
        public PhuongTrinhBac2() 
        {
            SoA = SoB = SoC = 0;    
        }
        public PhuongTrinhBac2(int soA, int soB, int soC)
        {
            SoA = soA;
            SoB = soB;
            SoC = soC;
        }

        public void TinhNghiem()
        {
            Console.Write("Nhap so nguyen a: ");
            SoA = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen b: ");
            SoB = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen c: ");
            SoC = int.Parse(Console.ReadLine());


            float dt = SoB * SoB - 4 * SoA * SoC;
            if (dt > 0)
            {
                double x1 = (-SoB - Math.Sqrt(dt)) / (2 * SoA);
                double x2 = (-SoB + Math.Sqrt(dt)) / (2 * SoA);
                hienThi(true, x1, x2);
            }
            else if (dt == 0)
            {
                double x = -SoB / (2 * SoA);
                hienThi(true,x);
            }
            else
            {
                hienThi(false);
            }    
        }
            
        
        public void hienThi(bool flag, params double[] nghiem)
        {
            if (flag == false) // Flag = 0 co vo so nghiem
                Console.WriteLine("Phuong trinh vo nghiem");
            else
                for (int i = 0; i < nghiem.Length; i++)
                {
                    Console.WriteLine("Nghiem la: {0:F2}", nghiem[i]);
                }
        }
    }
}
