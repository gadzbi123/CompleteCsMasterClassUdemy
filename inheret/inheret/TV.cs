using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheret
{
    class TV : ElectricalDevice
    {

        public TV(bool isOn, string brand) : base(isOn, brand) { }


        public void WatchTV()
        {
            if (IsOn)
                Console.WriteLine("Watching TV!");
            else
                Console.WriteLine("TV is off, please switch it on");
        }
    }
}
