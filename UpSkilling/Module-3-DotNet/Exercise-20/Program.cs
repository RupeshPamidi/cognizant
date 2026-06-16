using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3.Exercise20
{
    record Order(int OrderId, string CustomerName, decimal TotalAmount);
    class Program
    {
        static void Main()
        {
            var orders = new List<Order>{ new Order(1,"A",50), new Order(2,"B",200), new Order(3,"C",150) };
            var q = orders.Where(o=>o.TotalAmount>100).Select(o=> new { o.OrderId, o.TotalAmount });
            foreach(var item in q) Console.WriteLine(item);
        }
    }
}
