using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace taskLec5
{
     class Program
    {
      static List<int> numbers = new List<int>();

        static void printnumber ()
        { if (numbers.Count == 0)
            { Console.WriteLine("[]-the list is empty "); }
            else
            {
                foreach (int i in numbers) { 
                Console.WriteLine(i);
            }
            }
        }
        static void addnumbers()
        {
            Console.WriteLine("enter you number");
          int  x = Convert.ToInt32(Console.ReadLine());
          numbers.Add(x);
            Console.WriteLine($"{x} added.");
        }
        static void Mean ()
        {if (numbers.Count == 0) 
            Console.WriteLine("yoour list is empty ");
            return;
            double mean =(double)numbers.Sum()/numbers.Count;
            Console.WriteLine("the mean is "+mean);
        }
        static void Smallest()
        { if (numbers.Count == 0)
            {     Console.WriteLine("your list is empty ");
            return; }
            else
            {
                Console.WriteLine("the smallest number is "+numbers.Min());
            }

        }
        static void Largest() {
            if (numbers.Count == 0)
            {
                Console.WriteLine("your list is empty ");
                return;
            }
            else
            {
                Console.WriteLine("the lrgest number is " + numbers.Max());
            }

        }
        static void Main(string[] args)
        {
             char choice;
            do {

                Console.WriteLine(" P - Print numbers\r\n    A - Add a number\r\n    M - Display mean of the numbers\r\n    S - Display the smallest number\r\n    L - Display the largest number\r\n    Q - Quit\r\n");

            Console.WriteLine("enter your choice");
             choice =  Convert.ToChar(Console.ReadLine().ToLower());
                switch(choice){
                    case 'p':

                        printnumber();
                     break;
                    case 'a':
                        addnumbers();

                        break;
                    case 'm':
                        Mean();
                        break;
                    case 's':
                        Smallest ();
                        break;
                    case 'l':
                        Largest ();
                        break;
                    case 'q':
                        Console.WriteLine("good bye ");
                        break;
                    default:
                        Console.WriteLine("not defined");
                        break;
                }


            } while (choice != 'q');
        }
    }
}
