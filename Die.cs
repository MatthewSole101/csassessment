using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class Die
    {
        private int _Roll;

        // rand.Next(5);
        public  int Rolls
        {
                    
            get { return _Roll; }
            set { _Roll = value; }
        }

        public int Roll(int count = 0)
        {
            List<int> RollList = new List<int>();
            
            Random rand = new Random();

            int num = rand.Next(1, 7);
            int num2 = rand.Next(1, 7);
            int num3 = rand.Next(1, 7);

            for (int i = 1; i <= 3; i++)
                RollList.Add(rand.Next(1, 7));
            
            Console.WriteLine();
            



            return RollList[count];
            
        }
    }
}