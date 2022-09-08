using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndEnurable
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void Call()
        {
            Console.WriteLine($"Calling to {Name}. Phone number is {PhoneNumber}");
        }
    }
}
