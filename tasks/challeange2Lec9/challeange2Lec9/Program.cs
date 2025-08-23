namespace challeange2Lec9
{ class Player
    {
        public string name {  get; set; }
        public int health {  get; set; }
        public int exp {  get; set; }

        public Player(string name, int health, int exp)
        {
            this.name = name;
            this.health = health;
            this.exp = exp;
        }
        public static Player operator +(Player left, Player right)
        {
            return new Player(left.name + right.name, left.health + right.health, left.exp + right.exp);
        } 
        public static Player operator++(Player pp)
        {
            return new Player(pp.name.ToUpper(),pp.health+1,pp.exp);
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("mmm",4,9);
            Player p2 = new Player("nnn",6,1);
            Player p3 = p1+p2 ;
            Console.WriteLine(p3.name);
            Console.WriteLine(p3.health);
            Console.WriteLine(p3.exp);
            p1++;
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.health);

        }
    }
}
