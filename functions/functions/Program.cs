using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHelloWorld();
            Console.WriteLine(calculate());
            Console.ReadLine();
        }

        // Private means that it can only execute in current class
        // <Access Specifier> <Return Type> <Method Name>(Parameter List)
        private static void sayHelloWorld()
        {
            for (int i = 0; i < 10; i++)
            Console.WriteLine("Hello World");
        }

        private static int calculate()
        {
            int a = 10;
            int b = 5;
            int sum = a + b;
            return sum;
        }
    }
}
