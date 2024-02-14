using System;

namespace ooppract
{
    internal class Program
    {
        class game
        {
           

            
            class Die
            {
               
                private int _Roll;

                // rand.Next(5);
                public  int Rolls
                {
                    
                    get { return _Roll; }
                    set { _Roll = value; }
                }

                public int Roll()
                {
                    
                    int num = this.Rolls;
                    Random rand = new Random();

                    num = rand.Next(1, 7);
                    this.Rolls = num;

                    return  num;

                }
              


               
            }

            public static void Main(string[] args)
            {

                Die Die1 = new Die();
                Die Die2 = new Die();
                Die Die3 = new Die();

                int roll1 = Die1.Roll();
                int roll2 = Die1.Roll();
                int roll3 = Die1.Roll();
                
                Console.WriteLine("Die 1: " + roll1);
                Console.WriteLine("Die 2: " + roll2);
                Console.WriteLine("Die 3: " + roll3);

                int rolltotal = roll1 + roll2 + roll3;
                

                Console.WriteLine(rolltotal);
                
            }
        }
    }
}