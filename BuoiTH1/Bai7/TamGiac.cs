using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class TamGiac
    {
        private int _canh1, _canh2, _canh3, _loaiTG;
        private float _dienTich;

        public int Canh1 { get { return _canh1; } set { _canh1 = value; } }
        public int Canh2 { get { return _canh2; } set { _canh2 = value; } }
        public int Canh3 { get { return _canh3; } set { _canh3 = value; } }
        public int LoaiTG { get { return _loaiTG; } set { _loaiTG = value; } }
        public float DenTich { get { return _dienTich; } set {_dienTich = value; } }

        // Phuong thuc khoi tao
        public TamGiac()
        {
            Canh1 = 2; Canh2 = 3; Canh3 = -5;
        }
        public TamGiac(int a, int b, int c)
        {
            Canh1 = a; Canh2 = b; Canh3 = c;
        }

        public void Input()
        {
            int a, b, c;
            do
            {
                Console.Write("Nhap canh 1: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Nhap canh 2: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Nhap canh 3: ");
                c = int.Parse(Console.ReadLine());

                if ( (a + b <= c) || (a + c <= b) || (b + c <= a) )
                {
                    Console.WriteLine("Nhap khong hop le! Nhap lai!");
                }

            } while (a + b <= c || a + c <= b || b + c <= a);

            Canh1 = a; 
            Canh2 = b;
            Canh3 = c;

            Console.Write("Nhap loai tam giac: ");
            LoaiTG = Convert.ToInt32(Console.ReadLine());

        }
        public double TinhChuVi()
        {
            return Canh1 + Canh2 + Canh3;
        }

        public double TinhDienTich()
        {
            double p = TinhChuVi()/2.0;
            double dt = Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
            return dt;
        }

        public void Display()
        {
            double dt = TinhDienTich();
            Console.WriteLine("Canh1: {0} Canh2: {1} Canh3: {2} Chuvi: {3} Dientich: {4:F3}", Canh1, Canh2, Canh3, TinhChuVi(), dt);
        }
    }
}
