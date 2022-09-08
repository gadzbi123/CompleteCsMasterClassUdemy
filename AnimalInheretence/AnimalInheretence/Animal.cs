using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        virtual public void MakeSound() { }
        virtual public void Eat()
        {
            if (IsHungry)
                Console.WriteLine($"{Name} is eating");
            else
                Console.WriteLine($"{Name} is not eating");
        }
        virtual public void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
