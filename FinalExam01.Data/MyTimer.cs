

using System;
using System.Diagnostics;

namespace FinalExam01.Data
{
    public class MyTimer
    {
        //public static Stopwatch stopwatch = new Stopwatch();
        public Stopwatch stopwatch = new Stopwatch();

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public TimeSpan GetTime()
        {
            return stopwatch.Elapsed;
        }
    }
}