namespace challengeLec8
{ class animal
    {
        string name;
        int age;
       public virtual void  animalsound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class pig : animal
    {
        int size;
        public override void animalsound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class dogg : animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           animal myanimal = new animal();
            animal mypig = new pig();
            animal mydog = new dogg();
            myanimal.animalsound(); // The animal makes a sound 
            mypig.animalsound(); // The pig says: wee wee 
            mydog.animalsound(); // The dog says: bow wow
            Console.WriteLine(myanimal);
            Console.WriteLine(mypig);
            Console.WriteLine(mydog);
        }
    }
}
