using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam01
{
    public partial class Form2 : Form
    {
        static public int millisec = 0;
        static public int sec = 0;
        static public int min = 0;


        public Form2()
        {
            InitializeComponent();
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2.millisec++;
            if (Form2.millisec > 9)
            {
                Form2.millisec = 0;
                Form2.sec++;
                if (Form2.sec > 59)
                {
                    Form2.min++;
                }
            }

            label1.Text = Form2.min + ":" + Form2.sec + "." + Form2.millisec;
        }
    }
}