using System;

namespace Module3.Exercise09
{
    class Program
    {
        static long CalculateFactorial(int n)
        {
            long Inner(int k) => k <= 1 ? 1 : k * Inner(k - 1);
            return Inner(n);
        }

        static void Main()
        {
            Console.WriteLine(CalculateFactorial(5)); // 120
        }
    }
}
