using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class Car : Vehicle, IDestroyable
    {
        public Car(float speed, string color) : base(speed, color)
        {
            DesctructionSound = "CarBoom.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public string DesctructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DesctructionSound);
            Console.WriteLine($"Creare fire");
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
