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
            
            Console.WriteLine("What array do you want to choose?: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ascending(1) or Descending(2) order?: ");
            int userOrder = Convert.ToInt32(Console.ReadLine());
            
            

            if (userChoice == 1)
            {
                a1.look(userOrder);
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