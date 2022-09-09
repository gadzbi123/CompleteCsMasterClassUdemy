using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCS
{
    public class Exercise
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public void Run(string line)
        {
            double lineInt;
            if (!double.TryParse(line, out lineInt) || !(lineInt >= 0 && lineInt <= 180))
            {
                Console.WriteLine("Check the input!\n");
                return;
            }
            Console.WriteLine($"Cos = {(Math.Cos(ConvertToRadians(lineInt)))}");
            Console.WriteLine($"Sin = {(Math.Sin(ConvertToRadians(lineInt)))}");
            Console.WriteLine($"Tg = {(Math.Tan(ConvertToRadians(lineInt)))}");

        }
    }
}
