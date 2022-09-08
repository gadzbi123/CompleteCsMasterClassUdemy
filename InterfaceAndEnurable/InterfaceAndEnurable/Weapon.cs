using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndEnurable
{
    internal class Weapon
    {
        public string Name { get; set; }
        public Weapon(string name) { Name = name; }
        public Weapon() { Name = ""; }
        public void Label()
        {
            Console.WriteLine("This is {0}!", Name);
        }
    }
}
