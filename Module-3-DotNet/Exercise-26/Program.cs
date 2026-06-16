using System;
using System.Threading;

namespace Module3.Exercise26
{
    class Program
    {
        static int counter = 0;
        static object locker = new();
        static void Inc() { for(int i=0;i<10000;i++){ lock(locker){ counter++; } } }
        static void Main()
        {
            var t1 = new Thread(Inc); var t2=new Thread(Inc);
            t1.Start(); t2.Start(); t1.Join(); t2.Join();
            Console.WriteLine(counter);
        }
    }
}
