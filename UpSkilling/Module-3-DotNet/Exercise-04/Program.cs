using System;

namespace Module3.Exercise04
{
    class MyClass { public int N = 5; }

    class Program
    {
        static void Main()
        {
            var x = 10; // inferred int
            var s = "hello"; // inferred string
            var obj = new MyClass(); // inferred MyClass
            var obj2 = new(); // error if type cannot be inferred - new() requires explicit target

            Console.WriteLine($"x ({x.GetType()}): {x}");
            Console.WriteLine($"s ({s.GetType()}): {s}");
            Console.WriteLine($"obj ({obj.GetType()}): N={obj.N}");
        }
    }
}
