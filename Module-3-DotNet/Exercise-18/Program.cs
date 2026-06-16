using System;

namespace Module3.Exercise18
{
    class Student { public required string Name { get; init; } public required int Age { get; init; } }
    class Program { static void Main(){ var s = new Student { Name = "Tom", Age = 20 }; Console.WriteLine($"{s.Name} ({s.Age})"); } }
}
