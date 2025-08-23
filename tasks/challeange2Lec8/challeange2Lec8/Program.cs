namespace challeange2Lec8
{ class helper <T>
    {
        public void printtwice( T x )
        {
           
            


            Console.WriteLine(x); ;
            Console.WriteLine(x);        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           helper<int> h1= new helper<int> ();
            
            h1.printtwice(4 );

           helper<double> h2= new helper<double> ();
            h2.printtwice(5.9);   
           helper<string> h3= new helper<string> ();
            
            
            h3.printtwice("malek");
        }
    }
}
