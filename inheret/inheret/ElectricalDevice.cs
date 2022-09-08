using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheret
{
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public ElectricalDevice(bool isOn = false, string brand = "")
        {
            IsOn = isOn;
            Brand = brand;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
    }
}
