using System;
using System.IO;
using System.Text;

namespace Module3.Exercise25
{
    class Program
    {
        static void Main()
        {
            File.WriteAllText("sample.txt","Hello FileStream");
            using(var fs = new FileStream("sample.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] buf = new byte[fs.Length];
                fs.Read(buf,0,buf.Length);
                Console.WriteLine(Encoding.UTF8.GetString(buf));
            }

            using(var ms = new MemoryStream())
            {
                var data = Encoding.UTF8.GetBytes("Memory data");
                ms.Write(data,0,data.Length);
                Console.WriteLine($"Bytes written: {ms.Length}");
            }
        }
    }
}
