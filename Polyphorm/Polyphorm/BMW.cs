using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphorm
{
    class BMW : Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }
        public BMW(int HP, string color, string model) : base(HP, color)
        {
            Model = model;
            Brand = "BMW";
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"The {color} {Brand} {Model} has {HP} hp!");
        }

        public override void Repair()
        {
            HP = 100;
            Console.WriteLine($"{Brand} {Model} was repaired!");
        }
    }
}
