using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polyphorm
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            return Math.Pow(Radius, 3) * Math.PI * 4d / 3d;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The Volume is {0}", Volume());
        }
    }
}
