using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many customer?");
            int people = int.Parse(Console.ReadLine());
            string[][] customers = new string[people][];
            for (int i = 0; i < people; i++)
            {
                customers[i] = new string[3];
                Console.WriteLine("Customer no. " + (i+1));
                Console.WriteLine("Please input Customer's Name ?");
                customers[i][0] = Console.ReadLine();
                Console.WriteLine("Please input Customer's Address");
                customers[i][1] = Console.ReadLine();
                Console.WriteLine("Please input Customer's Phone number");
                customers[i][2] = (Console.ReadLine());
            }
            Console.WriteLine("Summary:");
            for (int i = 0; i < people; i++)
            {
                Console.WriteLine("Customer " + (i+1));
                Console.WriteLine("Name: " + customers[i][0] + " Address: " + customers[i][1] + " PhoneNo. " + customers[i][2]);
            }
            Console.ReadLine();
        }
    }
}
