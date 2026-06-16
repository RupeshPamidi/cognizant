using System;

namespace Module3.Exercise21
{
    class Program
    {
        static void Describe(object o)
        {
            if (o is int i) Console.WriteLine($"int: {i}");
            else if (o is string s) Console.WriteLine($"string: {s}");
            else Console.WriteLine("other");

            switch (o)
            {
                case int n when n>0: Console.WriteLine("positive int"); break;
                case string str: Console.WriteLine($"string length {str.Length}"); break;
                default: Console.WriteLine("no match"); break;
            }
        }

        static void Main(){ Describe(5); Describe("hi"); }
    }
}
