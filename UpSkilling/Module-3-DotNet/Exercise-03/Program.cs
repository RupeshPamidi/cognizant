using System;

namespace Module3.Exercise03
{
    // Primary constructor syntax requires modern C#; shown here as a simple example
    public class Person(string firstName, string lastName, int age)
    {
        public string FirstName { get; } = firstName;
        public string LastName { get; } = lastName;
        public int Age { get; } = age;

        public void Print() => Console.WriteLine($"Person: {FirstName} {LastName}, Age {Age}");
    }

    class Program
    {
        static void Main()
        {
            var p = new Person("Alice", "Johnson", 30);
            p.Print();
        }
    }
}
