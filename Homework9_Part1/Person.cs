using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1
{
    public class Person
    {
        private string name;

        // Default constructor
        public Person()
        {
            name = "Unknown";
        }

        // Constructor with name parameter
        public Person(string theName)
        {
            name = theName;
        }

        // Copy constructor
        public Person(Person obj)
        {
            name = obj.name;
        }

        // Getter
        public string GetName()
        {
            return name;
        }

        // Setter
        public void SetName(string newName)
        {
            name = newName;
        }

        // ToString override
        public override string ToString()
        {
            return name;
        }

        // Equals override
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Person))
                return false;
            Person other = (Person)obj;
            return name == other.name;
        }

        
    }

}
