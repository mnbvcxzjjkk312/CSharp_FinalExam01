using FinalExam01.Data;
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
            ButtonLogic rb = new ButtonLogic();
            rb.SetList();

            Console.WriteLine(rb.groupA.Count);
        }
    }
}
