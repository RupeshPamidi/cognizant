using System;
using System.Collections.Generic;

namespace Module3.Exercise19
{
    class Program
    {
        static void Main()
        {
            var list = new List<string>{"a","b","c"};
            var dict = new Dictionary<int,string>{{1,"one"},{2,"two"}};
            list.Add("d"); list.Remove("b");
            foreach(var s in list) Console.WriteLine(s);
            foreach(var kv in dict) Console.WriteLine($"{kv.Key} => {kv.Value}");
        }
    }
}
