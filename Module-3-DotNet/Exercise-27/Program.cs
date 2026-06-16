using System;
using System.Threading;

namespace Module3.Exercise27
{
    class Program
    {
        static object a = new(), b = new();
        static void Deadlock()
        {
            lock(a){ Thread.Sleep(50); lock(b){ Console.WriteLine("Acquired a then b"); } }
        }
        static void Fixed()
        {
            if (Monitor.TryEnter(a,100))
            {
                try{ if(Monitor.TryEnter(b,100)){ try{ Console.WriteLine("Acquired a and b (try)"); } finally{ Monitor.Exit(b); } } }
                finally{ Monitor.Exit(a); }
            }
        }
        static void Main(){ var t1=new Thread(Deadlock); var t2=new Thread(Fixed); t1.Start(); t2.Start(); t1.Join(); t2.Join(); }
    }
}
