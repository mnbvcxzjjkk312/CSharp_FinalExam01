using System;
using System.Collections.Generic;

namespace FinalExam01.Data
{
    public class ButtonLogic
    {
        Random rand = new Random();
        private int _target = 1;

        public List<int> groupA = new List<int>();
        public List<int> groupB = new List<int>();

        public void SetList()
        {
            //int list를 채워주는 메소드,
            while (groupA.Count < 9)
            {
                int x = rand.Next(1, 10);

                if (!groupA.Contains(x))
                    groupA.Add(x);

            }

            while (groupB.Count < 9)
            {
                int x = rand.Next(10, 19);

                if (!groupB.Contains(x))
                    groupB.Add(x);

            }
        }
        
        //타겟 넘버를 누른게 맞는지
        //Button.Text의 int 형태와 target을 비교해서 맞으면 true, false
        public bool IsSame(int number)
        {
            if (_target == number)
                return true;

            return false;
        }
    }

}