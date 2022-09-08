using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndEnurable
{
    class PhoneBook : IEnumerable<Contact>
    {
        List<Contact> contacts;
        public PhoneBook()
        {
            contacts = new List<Contact>()
            {
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };

        }

        public IEnumerator<Contact> GetEnumerator()
        {
            return contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
