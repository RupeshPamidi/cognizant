using System;
using System.Diagnostics;
using System.IO;

namespace Module3.Exercise28
{
    class Program
    {
        static void Main()
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("trace.log")));
            Trace.AutoFlush = true;
            Trace.WriteLine("This is a trace message");
        }
    }
}
