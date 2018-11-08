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
using FinalExam01.Data;
using Timer = System.Windows.Forms.Timer;

namespace FinalExam01
{
    public partial class Form1 : Form
    {
        private ButtonLogic _bl;
        private MyTimer stopwatch;

        private int _target = 1;
        private int _dummy = 1;

        public Form1()
        {
            InitializeComponent();
        }

        void Onclick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "") return;

            if (_target == int.Parse(btn.Text))
            {
                btn.Text = "";
                _target++;
            }

            if (_target == 10 && _dummy == 1)
            {
                _dummy = 2;

                SetButtonText(_bl.groupB);
            }

            if (_target == 19)
            {
                stopwatch.Stop();
                timer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bl = new ButtonLogic();
            stopwatch = new MyTimer();
            _bl.SetList();

            SetButtonText(_bl.groupA);
        }

        public void SetButtonText(List<int> list)
        {
            List<Button> buttons = new List<Button>();

            foreach (Control control in btnBox.Controls)
            {
                if (control is Button)
                {
                    buttons.Add(control as Button);
                    control.Click += this.Onclick;
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                buttons[i].Text = list[i].ToString();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SetTimerText();
        }

        private void SetTimerText()
        {
            TimeSpan t = stopwatch.GetTime();
            string answer = string.Format("{0:D2}m:{1:D2}s:{2:D3}ms",
                t.Minutes,
                t.Seconds,
                t.Milliseconds);

            label1.Text = answer;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer.Start();
            stopwatch.Start();
            button10.Enabled = false;
        }
    }
}
