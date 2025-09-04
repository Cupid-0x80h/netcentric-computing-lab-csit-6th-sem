using System;
using System.Collections.Generic;
using System.Linq;
using ClassLib;

namespace App
{
    class Program
    {
        static void Main()
        {
            // --- Instantiate child class and set properties ---
            Student s1 = new Student
            {
                Name = "Upesh",
                Age = 20,
                University = "TU",
                Major = "CS"
            };

            // --- Add friends to the generic list ---
            s1.Friends.Add(new Student { Name = "Bishal", Age = 21 });
            s1.Friends.Add(new Student { Name = "Charlie", Age = 22 });
            s1.Friends.Add(new Student { Name = "Dinesh", Age = 20 });
            s1.Friends.Add(new Student { Name = "Eva", Age = 21 });

            // --- Print using overridden method ---
            s1.DisplayInfo();

            // --- Print friends using for loop ---
            Console.WriteLine("\nFriends (for loop):");
            for (int i = 0; i < s1.Friends.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {s1.Friends[i].Name}, Age: {s1.Friends[i].Age}");
            }

            // --- Print friends using foreach loop ---
            Console.WriteLine("\nFriends (foreach loop):");
            foreach (var f in s1.Friends)
            {
                Console.WriteLine($"{f.Name}, Age: {f.Age}");
            }

            // --- Exception Handling ---
            Console.WriteLine("\nException Handling Demo:");
            try
            {
                int x = 10, y = 0;
                Console.WriteLine(x / y);  // This will throw DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed!");
            }

            // --- LINQ queries ---
            string[] cities = { "Kathmandu", "Pokhara", "Lalitpur", "Bhaktapur", "Biratnagar",
                                "Birgunj", "Hetauda", "Dharan", "Janakpur", "Nepalgunj" };

            // Query 1: Cities starting with 'B'
            var bCities = from c in cities
                          where c.StartsWith("B")
                          select c;
            Console.WriteLine("\nCities starting with B (LINQ):");
            foreach (var c in bCities) Console.WriteLine(c);

            // Query 2: Cities with length > 7
            var longCities = cities.Where(c => c.Length > 7);
            Console.WriteLine("\nCities with more than 7 letters (Lambda):");
            foreach (var c in longCities) Console.WriteLine(c);
        }
    }
}
