using System;
using System.Collections;

namespace HashTables
{
    // key - data
    // auto - car
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Antonio", 88);
            Student stud3 = new Student(3, "Jack", 77);
            Student stud4 = new Student(4, "Elise", 44);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[stud3.Id];

            // foreach (DictionaryEntry entry in studentsTable)
            // {
            //     Student temp = (Student)entry.Value;
            //     Console.WriteLine(
            //         "Student ID:{0}, Name:{1}, GPA:{2}",
            //         temp.Id,
            //         temp.Name,
            //         temp.GPA
            //     );
            // }

            // foreach (Student value in studentsTable.Values)
            // {
            //     Console.WriteLine(
            //         "Student ID:{0}, Name:{1}, GPA:{2}",
            //         value.Id,
            //         value.Name,
            //         value.GPA
            //     );
            // }

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Arch", 88);
            students[2] = new Student(6, "Adam", 88);
            students[3] = new Student(1, "Eva", 88);
            students[4] = new Student(10, "Bob", 88);

            Hashtable studs = new Hashtable();
            foreach (Student value in students)
            {
                if (!studs.ContainsKey(value.Id))
                {
                    studs.Add(value.Id, value);
                    Console.WriteLine(
                        "Student ID:{0}, Name:{1}, GPA:{2}",
                        value.Id,
                        value.Name,
                        value.GPA
                    );
                }
                else
                {
                    Console.WriteLine("Student with this id Exists");
                }
            }
        }
    }

    class Student
    {
        //property Id
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
