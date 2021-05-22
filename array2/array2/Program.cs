using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int people;
            Console.WriteLine("How many people?");
            people = int.Parse(Console.ReadLine());
            string[] firstName = new string[people];
            string[] lastName = new string[people];
            int[] salary = new int[people];
            for (int i = 0; i < people; i++)
            {
                Console.WriteLine("No." + (i+1) + " First Name:");
                firstName[i] = Console.ReadLine();
                Console.WriteLine("No." + (i+1) + " Last Name:");
                lastName[i] = Console.ReadLine();
                Console.WriteLine("No." + (i+1) + " Salary:");
                salary[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < people; i++)
            {
                Console.WriteLine(firstName[i] + " " + lastName[i] + ", Salary = " + salary[i]);
            }
            Console.ReadLine();
        }
    }
}
