namespace assesment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
    
    public class Die
    {
        private int[] _Rolls = { 1, 2, 3, 4, 5, 6 };
        private int _Roll;
        

        public int Rolls
        {
            get { return _Rolls;}
            set { Rolls = value; }
        }
        public int Roll
        {
            get { return _Roll;}
            set { Roll = value; }
        }


        static void Rolling
        {
            num = rand.Next(5);
            return _Rolls[num]
        }
        
}