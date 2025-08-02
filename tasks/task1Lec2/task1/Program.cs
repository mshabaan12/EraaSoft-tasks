namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Islam's Carpet Cleaning Service");
            Console.WriteLine("our price list is \n " +
                "small carpet = 25$ \n" +
                "large carpet = 35$ \n " +
                "and there is a 6% sales tax on all services "
                 );
            Console.WriteLine("how many small carpets do you want to clean ?");
            int nosmall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many large carpets do  you want to clean ?");
            int nolarge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Cost of small carpet = " + nosmall * 25);
            Console.WriteLine(" Cost of large carpet = " + nolarge * 25);
            int Cost = (nosmall * 25) + (nolarge * 35);
            Console.WriteLine("the cost = " + Cost);
            double tax = Cost * 0.06;
            Console.WriteLine("the tax = " + tax);
            Console.WriteLine("the total cost =" + (Cost + tax));

        }
    }
}
