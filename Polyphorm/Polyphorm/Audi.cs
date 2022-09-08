using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphorm
{
    internal class Audi : Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }
        public Audi(int HP, string color, string model) : base(HP, color)
        {
            Model = model;
            Brand = "Audi";
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
