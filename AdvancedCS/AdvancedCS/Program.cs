using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace AdvancedCS
{
    enum Day { Su = 1, Mo = 3, Tu, We, Th, Fr, Sa }
    enum Month { Sty = 1, Lu, Mar, Kwi, Maj, Cze, Lip, Sierp, Wrze, Paź, List, Gru }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random dice = new Random();
            List<int> nums = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                nums.Add(dice.Next(1, 7));
                Console.WriteLine(nums[i]);
            }

            Random number = new Random();
            int value = number.Next(1, 4);
            if (value == 1)
                Console.WriteLine("Yes");
            if (value == 2)
                Console.WriteLine("Maybe");
            if (value == 3)
                Console.WriteLine("No");

            string txt = File.ReadAllText(@"C:\projekty\CSharp\AdvancedCS\AdvancedCS\input2.txt");
            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(txt);
            Console.WriteLine(matches.Count + " <- Count");
            foreach (Match match in matches)
            {
                char val = (char)Int32.Parse(match.Value);
                Console.Write(val);
                //GroupCollection group = match.Groups;
                //Console.WriteLine(group[0].Value + " -at- " + group[0].Index);
            }
            DateTime birthDate = new DateTime(2000, 4, 7);
            var daysFromBirth = (DateTime.Today.Subtract(birthDate).TotalDays);
            Console.WriteLine("{0} days from my birthday", daysFromBirth);
            Console.WriteLine("I was born on {0}th day of the year", birthDate.DayOfYear);
            Console.WriteLine("today is {0}", DateTime.Today.DayOfWeek);
            const int year = 1889;
            Console.WriteLine("First day of year {1} is {0}", GetFirstDayOfYear(year).DayOfWeek, year);
            int days = DateTime.DaysInMonth(2023, 2);
            Console.WriteLine("Days in feb 2023: " + days);

            Console.WriteLine("Write date in format: yyyy-mm-dd");
            var line = Console.ReadLine();
            var inputDatetime = new DateTime();
            if (DateTime.TryParse(line, out inputDatetime))
            {
                Console.WriteLine("You inputed {0}", inputDatetime);
                TimeSpan daysPassed = DateTime.Now.Subtract(inputDatetime);
                Console.WriteLine("Days passed since: {0}", daysPassed.TotalDays);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            */
            int? number1 = null;
            int? number2 = 1337;
            double? number3 = new Double?();
            bool? number4 = new bool?();
            Console.WriteLine("{0},{1},{2},{3}", number1, number2, number3, number4);

            bool? genderMale = null;
            genderMale = false;
            if (genderMale == true)
                Console.WriteLine("MAN");
            else if (genderMale == false)
                Console.WriteLine("WOMAN");
            else
                Console.WriteLine("NO GENDER");

            double? num6 = 13.4;
            double? num7 = null;
            double num8;
            num8 = num7 ?? 0;

        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
