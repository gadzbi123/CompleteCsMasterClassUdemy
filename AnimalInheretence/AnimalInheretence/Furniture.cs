using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class Furniture
    {
        public string color { get; set; }
        public string Material { get; set; }
        public Furniture()
        {
            this.color = "White";
            Material = "Wood";
        }
        public Furniture(string color, string material)
        {
            this.color = color;
            Material = material;
        }
    }
}
