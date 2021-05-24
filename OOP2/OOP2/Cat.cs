using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Cat : Animal
    {
        string name;

        public string Name { get => name; set => name = value; }

        public string cry()
        {
            return "Meow!";
        }

        public string move() // Overide Animal.cs
        {
            return "Super RUN!";
        }
    }
}
