using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Linq_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Students> students = new List<Students>();
            students.Add(new Students("Jimmy", 13));
            students.Add(new Students("Hannah BAnana", 21));
            students.Add(new Students("Justin", 30));
            students.Add(new Students("Sarah", 53));
            students.Add(new Students("Hannibal", 15));
            students.Add(new Students("Phillip", 16));
            students.Add(new Students("Maria", 63));
            students.Add(new Students("Abe", 33));
            students.Add(new Students("Curtis", 10));


            //1 Min value
            var minValue = nums.Min();
            Console.WriteLine(minValue);
            //2 Max value
            var maxValue = nums.Max();
            Console.WriteLine(maxValue);
            //3 Max value less than 10000
            var maxValue2 = nums.Where(x => x < 10000).Max();
            Console.WriteLine(maxValue2);
            //4 values between 10 and 100
            List<int> values = nums.Where(x => x <= 100 && x >= 10).ToList();
            foreach(var v in values)
            {
                Console.WriteLine(v);
            }
            //5 values between 100000 and 999999
            List<int> values2 = nums.Where(x => x <= 999999 && x >= 100000).ToList();
            foreach (var v in values2)
            {
                Console.WriteLine(v);
            }
            //6 count even
            var values3 = nums.Count(x => x % 2 == 0);
            Console.WriteLine(values3);

            //Students
            //1
            List<Students> age21 = students.Where(x => x.Age >= 21).ToList();
            foreach (var v in age21)
            {
                Console.WriteLine(v.Name);
            }
            //2 Oldest Student
            Students oldest = students.First(x => x.Age == (students.Max(x => x.Age)));
            Console.WriteLine(oldest.Name);

            //3 Youngest student

            Students youngest = students.First(x => x.Age == (students.Min(x => x.Age)));
            Console.WriteLine(youngest.Name);


            //4 Oldest student under 25
            Students youngest25 = students.First(x => x.Age == (students.Where(x => x.Age < 25).Max(x => x.Age)));
            Console.WriteLine(youngest25.Name);

            //5 Over 21 and even
            List<Students> even = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            foreach(Students m in even)
            {
                Console.WriteLine(m.Name);
            }

            //6 students 13-19
            List<Students> teen = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach(Students m in teen)
            {
                Console.WriteLine(m.Name);
            }

            //7 name starts with vowel
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            List<Students> vowel = students.Where(x => vowels.Contains(x.Name[0])).ToList();

            foreach(Students student in vowel)
            {
                Console.WriteLine(student.Name);
            }




        }
    }
}
