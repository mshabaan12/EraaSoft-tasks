using System.Threading.Channels;

namespace chaleange1Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you attend the exame ? ,answer with y or n");
            string x = Console.ReadLine();
            Console.WriteLine("enter your score ");
            int S =Convert.ToInt32(Console.ReadLine());
            String M = (x.ToLower() == "n" || S < 50) ? "fail" :"pass" ;
            Console.WriteLine(M);

        }
    }
}
