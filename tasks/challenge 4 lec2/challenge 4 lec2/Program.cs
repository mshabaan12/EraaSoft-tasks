using System.ComponentModel.Design;

namespace challenge_4_lec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int y = Convert.ToInt32 (Console.ReadLine());
            int x = y % 2;

            if (x == 0) {
                Console.WriteLine("your num is even");
            }

            else { 
                        Console.WriteLine("your num is neg ");



            }
        }   

    }
}
