using System.Runtime.Serialization;
using System.Transactions;

namespace Lec6

{
    enum TransactionType
    {
        Deposite,
        Withdrow,
        Transfer

    }
    class Transaction
    {
        public Guid id;
        public TransactionType type;
        public DateTime date;
        public bool status;
        public string sendername;
        public string recivername;
        public double amount;

        public Transaction(Guid id, TransactionType type, DateTime date, bool status, string sendername, string recivername, double amount)
        {
            this.id = id;
            this.type = type;
            this.date = date;
            this.status = status;
            this.sendername = sendername;
            this.recivername = recivername;
            this.amount = amount;
        }
    }


    class Account
    {
        int id;
        string name;
        string adress;
        string phone;
        string mail;
        public double balance;
        List<Transaction> Transactions;

        public Account(int id, string name, string adress, string phone, string mail, double balance, List<Transaction> transactions)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.mail = mail;
            this.balance = balance;
            this.Transactions = new List<Transaction>();
        }

        //constractor 



        public bool Deposite(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Deposite, DateTime.Now, true, this.name, "", 1000));
                return true;
            }

            else
            {
                Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Deposite, DateTime.Now, false, this.name, "", 1000));
                return false;
            }
        }
        //withbrow
        public bool withdrow(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance -= amount;
                Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Withdrow, DateTime.Now, true, this.name, "", 1000));
                return true;
            }
            else
            {
                Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Withdrow, DateTime.Now, false, this.name, "", 1000));
                return false;
            }



        }
        // transfer 
        public bool transfer(int amount, Account des)
        {
            if ((amount > 0) && (amount <= balance))
            {
                this.balance -= amount;
                des.balance += amount;
                Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Deposite, DateTime.Now, true, this.name, des.name, 1000));
                des.Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Deposite, DateTime.Now, true, this.name, des.name, 1000));
                return true;
            }
            else
                Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Deposite, DateTime.Now, false, this.name, des.name, 1000));
            des.Transactions.Add(new Transaction(Guid.NewGuid(), TransactionType.Deposite, DateTime.Now, false, this.name, des.name, 1000));

            return false;
        }

        public void printTransaction()
        {
            for (int i = 0; i < Transactions.Count; i++)
            {
                Console.WriteLine(Transactions[i].id);
                Console.WriteLine(Transactions[i].type);
                Console.WriteLine(Transactions[i].amount);
                Console.WriteLine(Transactions[i].date);
                Console.WriteLine(Transactions[i].sendername);
                Console.WriteLine(Transactions[i].recivername);
                Console.WriteLine(Transactions[i].status);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Account account1 = new Account(11, "malek", "sadat", "01014206267", "mo@", 10000, new List<Transaction>());
                Account account2 = new Account(12, "malak", "sadat", "01014206267", "mo@", 4000, new List<Transaction>());
                account1.Deposite(2000);
                account1.withdrow(3000);
                account1.transfer(2000, account2);

                Console.WriteLine("balance of account1 is "+account1.balance);
                Console.WriteLine(account1.transfer(2000, account2));
                Console.WriteLine("balance of account2 is " + account2.balance);
                account1.printTransaction();


            }


        }
    }
}
     
    
