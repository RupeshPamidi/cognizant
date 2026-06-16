using System;

namespace Module3.Exercise08
{
    class Program
    {
        static void UseRef(ref int x) { x += 10; }
        static void UseOut(out int x) { x = 42; }
        static void UseIn(in int x) { Console.WriteLine($"in param value: {x}"); }

        static void Main()
        {
            int a = 1;
            Console.WriteLine($"before ref: {a}");
            UseRef(ref a);
            Console.WriteLine($"after ref: {a}");

            UseOut(out int b);
            Console.WriteLine($"out b: {b}");

            UseIn(a);
        }
    }
}
