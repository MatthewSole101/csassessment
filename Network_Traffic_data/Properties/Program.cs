using System;
using System.IO;
using Network_Traffic_data.Properties;

namespace Network_Traffic_data
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int count1 = 0;
            Array1 a1 = new Array1();
            Array2 a2 = new Array2();
            Array3 a3 = new Array3();

            
            Console.WriteLine("What array do you want to choose?: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ascending(1) or Descending(2) order?: ");
            int userOrder = Convert.ToInt32(Console.ReadLine());
            
            

            if (userChoice == 1)
            {
                a1.look(userOrder);
            }

            if (userChoice == 2)
            {
                a2.look(userOrder);
            }
            if (userChoice == 3)
            {
                a3.look(userOrder);
            }
                
            
            

            // for (int i = 0; i < 256; i++)
            // {
            //     if (10 % i = 0)
            //     {
            //         Console.WriteLine();
            //     }
            // }
            
            
            
            
        }
        
        
    }
}