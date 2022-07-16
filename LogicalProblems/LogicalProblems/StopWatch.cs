using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalProblems
{
    public class StopWatch
    {
        public static void stopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}