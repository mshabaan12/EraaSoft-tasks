namespace challeange1Lec5
{
    internal class Program
    {
        static double calc(double num1, int num2, string op)
        {
            switch (op)
            {
                    case "+" :
                    return num1 + num2;
                    case "-" : 
                    return num1 - num2;
                    case "*" :
                    return num1 * num2;
                    case "/" :
                    return num1 / num2;
                    default:
                    return  0;
                 
            }
         }
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter op");
            string op = Console.ReadLine();
            Console.WriteLine( calc(num1, num2, op));
        }
    }
}
