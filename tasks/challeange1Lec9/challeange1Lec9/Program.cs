namespace challeange1Lec9
{      abstract  class Book
    {
        string title { get; set; }

        string author { get; set; }
        public abstract string Read();
        
    }
    interface Idownloadable
    {
         string Download(); // by default public 
    }
     class Physicalbook : Book 
    {
        public override string Read()
        {
            return "reading a physical book ";
        }
    }
    class Ebook : Book, Idownloadable
    {
        public override string Read()
        {
            return  "reading an  e_book ";
        }
        public string Download()
        {
            return "downloading the E_book ";
        }

     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Physicalbook pp = new Physicalbook();
            Console.WriteLine( pp.Read());
            Ebook ee = new Ebook();
            Console.WriteLine( ee.Download());
            Console.WriteLine( ee.Read());

        }
    }
}
