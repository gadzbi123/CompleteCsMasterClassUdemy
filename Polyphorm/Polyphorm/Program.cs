using System;
using System.Linq;
using System.IO;

namespace Polyphorm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new BMW(22, "white", "i8");
            Audi car2 = new Audi(55, "black", "a4");
            car1.ShowDetails();
            car2.ShowDetails();
            car1.Repair();
            car2.Repair();
            car1.setCarIDInfo(2322222, "Kacper");
            car1.getCarIdInfo();
            car2.getCarIdInfo();
            M3 myM3 = new M3(222, "Green", "m3Super Turbo");
            my
            M3.Repair();
            Shape[] shapes = { new Cube(4), new Sphere(3d) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("Name: {0}, Vol: {1}", shape.Name, shape.Volume());

                Cube iceCube = shape as Cube;
                if (iceCube == null)
                    Console.WriteLine("This shape isnt a cube");
                if (shape is Cube)
                    Console.WriteLine("This shape is a cube");

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a Volume of {1}", cube2.Name, cube2.Volume());
            }
            */
            var count = 0;
            var lines = File.ReadAllLines(@"C:\projekty\CSharp\Polyphorm\Polyphorm\input.txt");
            string[] output = new string[] { };
            foreach (var line in lines)
            {
                if (line.Contains("split"))
                {
                    var splited = line.Split("split", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var p in splited)
                        Console.WriteLine(p + $"({count}) ");
                    output = output.Concat(new[] { splited[3] }).ToArray();
                    count++;

                }
                else
                {
                    output = output.Concat(new[] { line }).ToArray();
                }
            }
            File.WriteAllLines(@"C:\projekty\CSharp\Polyphorm\Polyphorm\output.txt", output);
        }
    }
}
