using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Employee
    {
        private string _name;
        private int _id, _yearOfBirth;
        private double _salaryLevel;
        private static double _basicSalary;

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public int YearOfBirth { get => _yearOfBirth; set => _yearOfBirth = value; }
        public double SalaryLevel { get => _salaryLevel; set => _salaryLevel = value; }
        public static double BasicSalary { get => _basicSalary; set => _basicSalary = value; }

        // Cac phuong thuc
        public int GetId() { return Id; }
        public string GetName() { return Name; }
        public int GetYearOfBirth() { return YearOfBirth; }

        public double GetInCome()
        {
            return BasicSalary * SalaryLevel;
        }

        public void SetSalaryLevel(double salaryLevel) { SalaryLevel = salaryLevel; }
        public static void SetBasicLevel(double basicSalary){ BasicSalary = basicSalary; }

        public void InPut()
        {
            Console.Write("Nhap ho ten: ");
            Name = Console.ReadLine();

            Console.Write("Nhap id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap year of birth: ");
            YearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap salary level: ");
            double tmp = double.Parse(Console.ReadLine());
            SetSalaryLevel(tmp);
        }

        public void Display()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-5} {4,-5}", GetId(), GetName(), GetYearOfBirth(), SalaryLevel, GetInCome());
        }



    }
}
