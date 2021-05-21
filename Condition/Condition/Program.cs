using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            if (salary >= 15000 && age >= 18 || salary >= 20000 && age >= 15)
            {
                Console.WriteLine("Nice");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
