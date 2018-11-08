using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
