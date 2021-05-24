using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Customer
    {
        string firstName = "";
        string lastName = "";

        public Customer()
        {
            Console.WriteLine("Hello World");
        }

        public Customer(string firstName, string lastName)
        {
            Console.WriteLine("Hello" + firstName + " " + lastName);
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
