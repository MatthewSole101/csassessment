using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace ConsoleApplication3
{
    internal class Game
    {
        public static void Main(string[] args)
        {
            Die Die1 = new Die();
            Die Die2 = new Die();
            Die Die3 = new Die();

           

            
            List<int> RollList = new List<int>();
            // RollList.Add(Die1.Roll());
            // RollList.Add(Die1.Roll());
            for (int i = 0; i <= 2; i++)
            {
                RollList.Add(Die1.Roll(i));

            }
            int Roll1 = RollList[0];
            int Roll2 = RollList[1];
            int Roll3 = RollList[2];
            

            Console.WriteLine("Die 1: " + Roll1);
            Console.WriteLine("Die 2: " + Roll2);
            Console.WriteLine("Die 3: " + Roll3);

            int rolltotal = Roll1 + Roll2 + Roll3;
                

            Console.WriteLine(rolltotal);
            

        }
    }
}