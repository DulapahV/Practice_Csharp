using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of: ");
            int multiplication = int.Parse(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(multiplication + " x " + i + " = " + multiplication * i);
            }
            Console.ReadLine();
        }
    }
}
