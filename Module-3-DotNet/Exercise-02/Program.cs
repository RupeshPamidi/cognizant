using System;

namespace Module3.Exercise02
{
    class Box { public int Value; }

    class Program
    {
        static void ModifyValue(int x)
        {
            x = 999;
        }

        static void ModifyReference(Box b)
        {
            b.Value = 999;
            b = new Box { Value = 1234 }; // reassign local reference
        }

        static void Main()
        {
            int a = 10;
            Console.WriteLine($"Before ModifyValue: a={a}");
            ModifyValue(a);
            Console.WriteLine($"After ModifyValue: a={a} (value type unchanged)");

            var box = new Box { Value = 10 };
            Console.WriteLine($"Before ModifyReference: box.Value={box.Value}");
            ModifyReference(box);
            Console.WriteLine($"After ModifyReference: box.Value={box.Value} (reference modified)");
        }
    }
}
