namespace task2Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {// multiplication table 
            Console.WriteLine("Enter a number to print its multiplication table ");
            int num =Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine(i + "*" + num + "=" + i * num);
                i++;
            }
        }
    }
}
