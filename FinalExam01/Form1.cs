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

namespace FinalExam01
{
    public partial class Form1 : Form
    {
        private ButtonLogic _bl;

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
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            _bl = new ButtonLogic();
            _bl.SetList();

            timer.Start();

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


    }
}
