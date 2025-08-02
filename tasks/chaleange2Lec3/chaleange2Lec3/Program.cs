using System.ComponentModel.Design;

namespace chaleange2Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("have you any experience before ; answer with (y , n)");
            string E = Console.ReadLine();
            Console.WriteLine("please enter you age ");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A >= 18 && E == "y")
            {
                Console.WriteLine("you are eligible ");
            }

            else
            {
                Console.WriteLine("you are rejected");



            }

            } 
    }
}
