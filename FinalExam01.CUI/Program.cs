using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam01.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            //int group2 = rand.Next(10, 19);

            List<int> a = new List<int>();

            while (a.Count < 9)
            {
                int group1 = rand.Next(1, 10);

                if (!a.Contains(group1))
                    a.Add(group1);
                
            }

            foreach (var x in a)
            {
                Console.WriteLine(x);
            }

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Input Start, start stopwatch");
            string line = Console.ReadLine();
            if (line == "Start")
            {
                sw.Start();
            }
            
            Console.WriteLine("Input Stop, stop stopwatch");
            string line2 = Console.ReadLine();
            if (line2 == "Stop")
            {
                if (sw.IsRunning)
                {
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.ToString());
                }
            }
            
        }
    }
}
