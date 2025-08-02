using System.Threading.Channels;
using System.Transactions;

namespace lec4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0 ;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter your num 10 numbers ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    continue;
                else if (num == 999)
                    break;
                sum = sum + num ;
                {
          Console.WriteLine(sum);




                }
            }
           
            


        }
    }
}