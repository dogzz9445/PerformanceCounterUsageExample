using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceCounterUsageExample
{
    class Program
    {
        private static PerformanceCounter cpuCounter = 
            new PerformanceCounter("Processor", "% Processor Time", "_Total");
        
        private static PerformanceCounter memmoryCounter = 
            new PerformanceCounter("Memory", "% Committed Bytes in Use");

        private static PerformanceCounter networkCounter =
            new PerformanceCounter("Network Interface", "Bytes Received/sec", "Bytes Sent/sec");

        static void Main(string[] args)
        {
            Console.WriteLine("{0}", cpuCounter.NextValue().ToString());
            Console.ReadLine();
        }
    }
}
