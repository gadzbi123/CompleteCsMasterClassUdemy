using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphorm
{
    internal class Car
    {
        public int HP { get; set; }
        public string color { set; get; }
        public Car(int hp, string color)
        {
            HP = hp;
            this.color = color;
        }
        virtual public void ShowDetails()
        {
            Console.WriteLine($"The {color} car has {HP} hp!");
        }
        virtual public void Repair()
        {
            HP = 100;
            Console.WriteLine($"Car was repaired!");
        }
    }
}
