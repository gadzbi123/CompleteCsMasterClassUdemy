using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesDemo
{
    // key - data
    // auto - car
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] Employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Antonio", 35, 25),
                new Employee("HR", "Lora", 32, 10),
                new Employee("Secretary", "Ernest", 28, 18),
            };

            Dictionary<string, Employee> EmployeesDirectory = new Dictionary<string, Employee>()
            {
                { "LOL", new Employee("Secretary", "Ernest", 28, 18) }
            };
            foreach (Employee emp in Employees)
            {
                EmployeesDirectory.Add(emp.Role, emp);
            }

            for (int i = 0; i < EmployeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyPairValue = EmployeesDirectory.ElementAt(i);

                Console.WriteLine("Key: {0}", keyPairValue.Key);
                Employee value = keyPairValue.Value;
                Console.WriteLine("Name: {0}", value.Name);
            }

            Employee result = new Employee("CEO", "XD", 1, 1);
            if (EmployeesDirectory.TryGetValue("HR", out result))
            {
                Console.Write(
                    "Role: {0}, Name:{1}, Age:{2}, Salary:{3}\n",
                    result.Role,
                    result.Name,
                    result.Age,
                    result.Salary
                );
            }
            EmployeesDirectory.TryGetValue("HRz", out result);
            Console.WriteLine("--------{0}", result.Age);

            //Update
            string KeyToUpdate = "HR";
            if (EmployeesDirectory.ContainsKey(KeyToUpdate))
            {
                EmployeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee {0} was added", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("Key {0} not found", KeyToUpdate);
            }

            //Remove

            string KeyToRemove = "Secretary";
            if (EmployeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("{0} removed", KeyToRemove);
            }
            else
            {
                Console.WriteLine("{0} not exists");
            }
            for (int i = 0; i < EmployeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyPairValue = EmployeesDirectory.ElementAt(i);

                Console.WriteLine("Key: {0}", keyPairValue.Key);
                Employee value = keyPairValue.Value;
                Console.WriteLine("Name: {0}", value.Name);
            }

            // string key = "CEO";
            // if (EmployeesDirectory.ContainsKey(key))
            // {
            //     Employee empl = EmployeesDirectory[key];
            //     Console.Write(
            //         "Role: {0}, Name:{1}, Age:{2}, Salary:{3}\n",
            //         empl.Role,
            //         empl.Name,
            //         empl.Age,
            //         empl.Salary
            //     );
            // }
        }
    }

    class Employee
    {
        //property Id
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get { return Rate * 8 * 5 * 4 * 12; }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
