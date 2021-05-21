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
            Console.WriteLine("Hello");
            int salary = 12000;
            int age = 15;
            if (salary >= 15000 && age >= 18 || salary >= 20000 && age >= 15)
            {
                Console.WriteLine("True");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
