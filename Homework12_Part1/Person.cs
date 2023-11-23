using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_Part1
{
    public class Person
    {
        // Instance variables
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        // Full constructor
        public Person(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        }
    }
}
