using System;

namespace Module3.Exercise22
{
    class Program
    {
        static (int,string) GetPair() => (42, "Answer");
        static void Main(){ var (n,s) = GetPair(); Console.WriteLine(n); Console.WriteLine(s); }
    }
}
