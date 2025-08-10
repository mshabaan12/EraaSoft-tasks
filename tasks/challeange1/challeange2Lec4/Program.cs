using System.Threading.Channels;

namespace challeange2Lec4
{
    internal class Program
    {
        static void Main(string[] args)
        {// test the number is even or odd
            Console.WriteLine("how many numbers  you want to enter");

            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter your number "+(i+1));
                arr [i] = Convert.ToInt32 (Console.ReadLine());
               
               if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
              
            }
            Console.WriteLine("even numbers = "+ even +" ,odd numbers " + odd); 
        }  
    }
}
