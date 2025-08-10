using System.ComponentModel.Design;
using System.Threading.Channels;

namespace challeange2Lec5
{
    internal class Program
    {
        static int[] binary(int n)
        {

            int[] arr = new int[n];
            for (int i = 0; n >= 1; i++)
            {
                if (n % 2 == 0)
                    arr[i] += 0;

                else
                {
                    arr[i] += 1;
                }
                n = n / 2;
            }
            return arr;
        }
        static bool comp(int[] arr)
        {
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[j])
                {
                    j--;
                }
                else
                { return false; }
            }
            return true;
        }         
            static bool isodd(int n)
            {
                if (n % 2 != 0) return true;
                else return false;
            }
            static void Main(string[] args)
        {
            Console.WriteLine("enter your number ");
            int n = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("this number is :");
         
            if (comp(binary(n))||isodd(n)) { Console.WriteLine("wonderfull"); }
            else { Console.WriteLine("not wonderfull"); }

       
        }    
    }
}
