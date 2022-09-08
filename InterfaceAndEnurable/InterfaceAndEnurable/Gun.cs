using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndEnurable
{
    internal class Gun : Weapon, IShootable
    {
        public Gun(string Name) : base(Name) { }
        public Gun() : base("Gun") { }

        public void Shoot()
        {
            Console.WriteLine("BAM!");
        }
    }
}
