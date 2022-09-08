using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class Chair : Furniture, IDestroyable
    {
        public Chair(string Color, string Material) : base(Color, Material)
        {
            DesctructionSound = "ChairCrash.mp3";
        }
        public string DesctructionSound { get; set; }
        public void Destroy()
        {
            Console.WriteLine($"The {color} chair was destroyed");
            Console.WriteLine($"Playing destruction sound {DesctructionSound}");
            Console.WriteLine($"Spawning chair parts");
        }
    }
}
