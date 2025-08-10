namespace challeange2Lec4
{
    internal class Program
    {
        static void Main(string[] args)
        {// challeange2 lec 4 "continue"
            Console.WriteLine("you can enter 10 numbers ");
            int sum = 0;
            for (int i = 1; i <=10; i++)
            {

                Console.WriteLine("enter number" + i);
               
                int num = Convert.ToInt32(Console.ReadLine());
               
                if (num < 0)

                { continue; }
                else if (num == 999)
                {break;
                } 
                else 
                    sum = sum + num;
            }
            Console.WriteLine("sum = " + sum);

        }

    }
}
