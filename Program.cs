using System;

namespace ooppract
{
    internal class Program
    {
        class game
        {
            private String name;
            private int age;

            
            class Die
            {
                private int[] _Rolls = { 1, 2, 3, 4, 5, 6 };
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

                    num = rand.Next(1, 6);
                    this.Rolls = num;

                    return  num;

                }
              


                // static void Rolling
                // {
                //     get { return _Roll; }
                //     set { _Roll = rand.Next(1, 6); }
                //     // Roll.SetValue(rand.Next(5));
                //     // Roll = rand.Next(5);
                //     // Roll = Num + 1;
                //     // return Roll;
                // }
            }

            public static void Main(string[] args)
            {

                Die Die1 = new Die();

                int roll1 = Die1.Roll();
                Console.WriteLine(roll1);
                
            }
        }
    }
}