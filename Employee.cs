using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeMethods
{
    internal class Employee
    {
        public const float Gravity = 9.8f; // compile time constant
        public readonly int id; // runtime constant

        // Readonly property only get value or assign value in constructor
        public string Name { get; }

        public string Address { get; } = "Rawalpindi";

       // readyonly only allowd with field not property
       // we remove setter from property to make it readonly 
       // public readonly string Mobile { get; }

        public Employee(string _name)
        {
            Name = _name;
        }

    }
}
