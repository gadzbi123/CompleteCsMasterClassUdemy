using System;

namespace Polyphorm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new BMW(22, "white", "i8");
            Audi car2 = new Audi(55, "black", "a4");
            car1.ShowDetails();
            car2.ShowDetails();
            car1.Repair();
            car2.Repair();
            M3 myM3 = new M3(222, "Green", "m3Super Turbo");
            myM3.Repair();
        }
    }
}
