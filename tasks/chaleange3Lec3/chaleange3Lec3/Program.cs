namespace chaleange3Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("the number is positive ");
            }
            else if (x < 0)
            {
                Console.WriteLine("the number is negative ");
            }
            else {
                Console.WriteLine("the number is zero ");
                    }
        }
    }
}
