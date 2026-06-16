using System;

namespace Module3.Exercise06
{
    class Program
    {
        static void Main()
        {
            int[] arr = {1,2,3,4,5};

            Console.WriteLine("for loop:");
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]==3) continue; // skip 3
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("foreach loop:");
            foreach(var v in arr) Console.WriteLine(v);

            Console.WriteLine("while loop:");
            int idx=0;
            while(idx < arr.Length)
            {
                Console.WriteLine(arr[idx]);
                if (arr[idx]==4) break; // stop at 4
                idx++;
            }

            Console.WriteLine("do-while loop:");
            idx=0;
            do { Console.WriteLine(arr[idx++]); } while (idx < arr.Length && idx<3);
        }
    }
}
