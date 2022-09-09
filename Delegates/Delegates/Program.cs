using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> names = new List<string> { "Alekin", "Stefania", "Jarek", "Irka", "Antonio" };

            Console.WriteLine("----before----");
            foreach (string name in names)
                Console.WriteLine(name);

            names.RemoveAll(Filter);

            Console.WriteLine("----after----");
            foreach (string name in names)
                Console.WriteLine(name);

            Console.WriteLine();

            ApplyOperation(4, 6, Multiply);
            Person p1 = new Person("Andrzej", 28) { };
            Person p2 = new Person("Jaro", 11) { };
            Person p3 = new Person("Sztef", 77) { };
            Person p4 = new Person("Kizia", 44) { };
            List<Person> list = new List<Person> { p1, p2, p3, p4 };

            DisplayPeople("Kids", list, IsMinor);
            DisplayPeople("Senior", list, IsSenior);
            DisplayPeople("Adult", list, IsAdult);
            DisplayPeople("Custom", list, delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            });
            DisplayPeople("Custom", list, (p) => p.Age >= 20 && p.Age <= 30);


            //Console.WriteLine(Add(5, 3));
            Console.WriteLine(OperationGet("*") != null ? OperationGet("*")(5, 7) : null);
            */

            RenderingEngine renderingEngine = new RenderingEngine();
            AudioSystem audioSystem = new AudioSystem();
            Player player1 = new Player("Kacper");
            Player player2 = new Player("Tomek");

            GameEventMenager.TriggerGameStart();
            // GameEventMenager.TriggerGameStart();
            GameEventMenager.TriggerGameOver();


            Console.WriteLine("Press a key to stop");
            Console.Read();


        }

        static Func<int, int, int> Add = (a, b) => (a + b);
        static Func<int, int, int> Subtract = (a, b) => (a - b);
        static Func<int, int, int> Multiply = (a, b) => (a * b);
        static Func<int, int, int> Divide = (a, b) => (a / b);
        static Dictionary<string, Func<int, int, int>> operators = new Dictionary<string, Func<int, int, int>>() {
                { "+", Add },
                { "-", Subtract },
                { "*", Multiply },
                { "/", Divide }
        };
        static Func<int, int, int> OperationGet(string input)
        {
            Func<int, int, int> result;
            if (operators.TryGetValue(input, out result)) return result;
            else return null;
        }

        public delegate float OperationDelegate(float a, float b);
        static public float Add2(float a, float b)
        {
            return a + b;
        }
        static public float Subtract2(float a, float b)
        {
            return a - b;
        }
        static public float Divide2(float a, float b)
        {
            return a / b;
        }
        static public float Multiply2(float a, float b)
        {
            return a * b;
        }

        static public float ApplyOperation(float a, float b, OperationDelegate operation)
        {
            var res = operation(a, b);
            Console.WriteLine(res);
            return res;
        }
        public delegate bool FilterDelegate(Person p);
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine("==={0}===", title);
            foreach (Person p in people)
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);

                }
        }
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age > 65;
        }


        static bool Filter(string s)
        {
            return s.Contains("i") || s.Contains("I");
        }
    }
}
