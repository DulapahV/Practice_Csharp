using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] country = { "Thailand", "Laos", "Singapore" };
            foreach(string data in country)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
    }
}
