using System;
using System.IO;

namespace Network_Traffic_data.Properties
{
    public class Array3
    {
        public int look( int Sort = 0)
        {
            SearchValue search = new SearchValue();

            int count1 = 0;
            int[] array1 = new int[256];

            StreamReader reader = new StreamReader("12934780.txt");
            
            int line = 0;
            
            for (int i = 0; i < 256; i ++ )
            {
                line = int.Parse(reader.ReadLine());
                array1[i] = line;


            }
            reader.Close();

            Array.Sort(array1);

            if (Sort == 1)
            {
                for (int i = 9; i < array1.Length; i+= 10)
                {
                    Console.WriteLine(array1[i]);
                }
            }

            if (Sort == 2)
            {
                Array.Reverse(array1);
                for (int i = 9; i < array1.Length; i+= 10)
                {
                    Console.WriteLine(array1[i]);
                }
                
            }
            
            Console.WriteLine("What value are looking for?: ");
            int userInput = System.Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 256; i++)
            {
                bool isFound = search.Convert(array1[i], userInput);

                if (isFound == true)
                {
                    Console.WriteLine("Value found in array location " + i);
                }
                if(isFound == false)
                {
                    count1++;
                }

                if (count1 == 256)
                {
                    Console.WriteLine("Error!!: Value inputted");

                }
            }

            return 0;
        }
        
    }
}

