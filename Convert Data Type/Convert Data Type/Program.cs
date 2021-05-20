using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Salary: " + salary.ToString());
            Console.ReadLine();
        }
    }
}
