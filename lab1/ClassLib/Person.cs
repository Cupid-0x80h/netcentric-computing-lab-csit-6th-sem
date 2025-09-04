using System;

namespace ClassLib
{
    public class Person
    {
        // Base class properties
        public string? Name { get; set; }
        public int Age { get; set; }

        // Base class method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
