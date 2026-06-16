using System;

namespace Module3.Exercise16
{
    class Person { public string? Name { get; set; } }
    class Program
    {
        static void Main()
        {
            Person? p = null;
            Console.WriteLine(p?.Name ?? "No name available");
            p = new Person();
            Console.WriteLine(p?.Name ?? "No name set");
            p.Name = "Bob";
            Console.WriteLine(p?.Name ?? "No name set");
        }
    }
}
