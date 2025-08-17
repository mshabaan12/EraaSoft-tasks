namespace Lec7
{ class Account
    {
        int id;
        string name;
        string email;
        string address;
        string phone;
        double balance;

        public Account(int id, string name, string email, string address, string phone, double balance)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.balance = balance;
        }
        public string Name { get; set; }
        public double Balance { get;  }

        public bool Depsite(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;

            }
            return false;



        }
        public bool Withdrow(double amount)
        {  double fees = 0;
            if (amount > 0 && amount < balance)
            {
                fees = amount * 0.01;
                if (fees<3)
                { fees=3; }
                amount += fees;
                balance -= amount; return true;
            }
            return false;
        }
        public bool Transfer(double amount,Account des)
        {
            if (amount>0)
            { this.balance -= amount;
                des.balance += amount;
                
                return true;
            }
            return false;
        }
        internal class Program

        {
            static void Main(string[] args)
            {
                Account accoun1 = new Account(11, "malek", "m@1", "sadat", "01014206267", 5000);
                accoun1.Withdrow(1000);
                Console.WriteLine(accoun1.balance);
                accoun1.Name = "ah";
                Console.WriteLine(accoun1.Name);
            }
        }
    }
}
