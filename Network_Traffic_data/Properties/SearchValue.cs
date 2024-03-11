using System;

namespace Network_Traffic_data.Properties
{
    public class SearchValue
    {
        public bool Convert(int line = 0, int userInput = 0)
        {
            if (line == userInput)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}