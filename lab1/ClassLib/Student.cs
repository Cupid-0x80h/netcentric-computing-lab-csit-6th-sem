using System;
using System.Collections.Generic;

namespace ClassLib
{
    public class Student : Person
    {
        // Additional properties
        public string? University { get; set; }
        public string? Major { get; set; }

        // Aggregated field: list of students
        public List<Student> Friends = new List<Student>();

        // Overriding method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, University: {University}, Major: {Major}");
        }

        // Method overloading
        public void DisplayInfo(bool showFriends)
        {
            DisplayInfo();
            if (showFriends && Friends.Count > 0)
            {
                Console.WriteLine("Friends:");
                foreach (var f in Friends)
                    Console.WriteLine($"- {f.Name}, Age: {f.Age}");
            }
        }
    }
}
