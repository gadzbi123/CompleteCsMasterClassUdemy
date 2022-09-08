using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class Vehicle
    {
        public float Speed;
        public string Color;
        public Vehicle()
        {
            Speed = 20.5f;
            this.Color = "Green";
        }
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            this.Color = color;
        }
    }
}
