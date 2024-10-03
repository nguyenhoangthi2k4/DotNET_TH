using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai6
{
    class Programs
    { 
        static void Main(string[] args)
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] employee = new Employee[n];
            Employee.SetBasicLevel(3.5);

            Console.WriteLine("Nhap thong tin nhan vien");
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine("\nNhap thong tin nhan vien " + (i + 1).ToString());
                employee[i] = new Employee();
                employee[i].InPut();
            }
            Console.WriteLine("Thong tin nhan vien");
            for (int i = 0; i < employee.Length; i++) 
            {
                employee[i].Display();
            }
            
            Console.ReadKey();
        }
    
    }

}
