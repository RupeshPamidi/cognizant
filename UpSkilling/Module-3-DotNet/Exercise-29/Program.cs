using System;
using System.Net;

namespace Module3.Exercise29
{
    class Program
    {
        static string Sanitize(string input) => WebUtility.HtmlEncode(input);
        static void Main()
        {
            var dangerous = "<script>alert('x')</script>";
            Console.WriteLine(Sanitize(dangerous));
        }
    }
}
