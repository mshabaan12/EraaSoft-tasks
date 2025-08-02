namespace task1Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        { //grade  checker 
            Console.WriteLine("enter your mark from 0 to 100");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m >= 90 && m <= 100)
            {
                Console.WriteLine("grade a ");
            }
            else if (m >= 80 && m <= 89)
            {
                Console.WriteLine("grade b ");
            }
            else if (m >= 70 && m <= 79)
            {
                Console.WriteLine("grade c ");
            }
            else if (m >= 60 && m <= 69)
            {
                Console.WriteLine("grade d");
            }
            else
            {
                Console.WriteLine("grade f ");
            }
        }
    
    }
}
