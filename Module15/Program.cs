using System;
using System.Collections.Generic;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            // ???
            var result = new List<string>();
            
            for(int i = 0; i < classes.Length;i++)
            {
                var s = result.Concat(classes[i].Students).ToList();
                result = s;
            }
            return result.ToArray();
        }

    }
}