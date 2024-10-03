using System;
using System.Text;
namespace Bai8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhuongTrinhBac2 pt = new PhuongTrinhBac2();
            Console.WriteLine("Tính phương trình bậc 2");
            pt.TinhNghiem();

            Console.ReadLine();
        }
    }
}
