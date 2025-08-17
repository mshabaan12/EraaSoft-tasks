namespace LEC
{
    class player
    {
        public player(string name, int health, string exp)
        {
            this.name = name;
            this.health = health;
            this.exp = exp;
        }

        public string name { get; set; }
        public int health { get; set; }
        public string exp { get; set; }

        public static player operator ++(player player1)
        {
            return new player(player1.name.ToUpper() ,player1.health+1 ,player1.exp);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                player player2= new player("malek",10,"hh");
                Console.WriteLine(player2++);


            }
        }
    }
}
