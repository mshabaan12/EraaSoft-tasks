namespace challenge3Lec8
{internal class Clscalculator
    {
        public static bool AreEqual<T>(T x,T y)
        {
            if(  x.Equals (y))
             {
                return true;
             }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = Clscalculator.AreEqual<int>(5, 6);
            if (IsEqual == true)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
