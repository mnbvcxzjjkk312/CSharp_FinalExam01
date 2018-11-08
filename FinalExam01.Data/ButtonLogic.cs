using System;
using System.Collections.Generic;

namespace FinalExam01.Data
{
    public class ButtonLogic
    {
        Random rand = new Random();
        
        // 1~9 랜덤 리스트
        public List<int> groupA = new List<int>();
        // 10~18 랜덤 리스트
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
        
        
    }

}