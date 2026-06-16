using System;

namespace Module3.Exercise13
{
    public record Employee
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }

    class Program
    {
        static void Main()
        {
            var e1 = new Employee { Id = 1, Name = "Alice" };
            var e2 = e1 with { Name = "Alice Smith" };
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
