using System;
using System.Collections;
using System.Collections.Generic;

namespace InterfaceAndEnurable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DogShelter dogShelter = new DogShelter();
            foreach (var dog in dogShelter)
            {
                if (dog.IsGood)
                    dog.GiveTreat(2);
                else
                    dog.GiveTreat(1);

            }
            IEnumerable<int> unknownCollection = GetCollection(3);
            foreach (int i in unknownCollection)
            {
                Console.Write(i + " ");
            }
            List<int> list = new List<int>() { 5, 7, 9 };
            int[] array = new int[] { 2, 6, 10 };
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(2);
            queue.Enqueue(7);
            CollectionSum(list);
            CollectionSum(array);
            CollectionSum(queue);
            */
            PhoneBook pb = new PhoneBook();
            foreach (Contact contact in pb)
            {
                contact.Call();
            }

        }
        static void CollectionSum(IEnumerable<int> anyCol)
        {
            int sum = 0;
            foreach (int num in anyCol)
            {
                sum += num;
            }
            Console.WriteLine($"Sum is {sum}");
        }
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> nq = new Queue<int>();
            nq.Enqueue(6);
            nq.Enqueue(7);
            nq.Enqueue(8);
            nq.Enqueue(9);
            nq.Enqueue(10);

            if (option == 1)
                return list;
            if (option == 2)
                return nq;
            else
                return new int[] { 11, 12, 13, 14, 15 };

        }
    }



    class Dog
    {
        public string Name { get; set; }
        public bool IsGood { get; set; }
        public Dog(string name, bool isGood)
        {
            Name = name;
            IsGood = isGood;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine($"Dog: {Name}, woofed {numberOfTreats} times!");
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        private List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog> {
            new Dog("Arek",false),
            new Dog("Czarek",true),
            new Dog("Jacek",true),
            new Dog("Ziutek",false)
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
