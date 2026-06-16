using System;
using System.Collections.Generic;

namespace Module3.Exercise17
{
    class Contact { public string? Name { get; set; } public string? Phone { get; set; } }
    class Program
    {
        static void Main()
        {
            List<Contact?> contacts = new() { new Contact { Name = "Ann" }, null, new Contact() };
            foreach (var c in contacts)
            {
                var name = c?.Name ?? "(no name)";
                Console.WriteLine(name);
            }
        }
    }
}
