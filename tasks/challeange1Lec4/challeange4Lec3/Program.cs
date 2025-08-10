using System.ComponentModel.Design;

namespace challeange4Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("the number is even ");
            }
            else
            {
                Console.WriteLine("the number is odd ");
            }
        }  
        
    }
}
